/*
 * Samsung API
 * Copyright (c) 2009-2015 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


#include <tizen.h>
#include <watch_app.h>
#include <watch_app_efl.h>

#include "log.h"
#include "stretch_time.h"

#define PI 3.1415926535897

#include <app.h>
#include <device/haptic.h>

#include <sys/time.h>
#include <unistd.h>
#include <stdio.h>

#define LAUNCH_AT_EVERY_HOUR 1

void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

void vibrate(int duration, int feedback)
{
	haptic_device_h haptic_handle;
	haptic_effect_h effect_handle;

	if(device_haptic_open(0, &haptic_handle) == DEVICE_ERROR_NONE) {

		LOGI("Connection to vibrator established");

		if(device_haptic_vibrate(haptic_handle, duration, feedback, &effect_handle) == DEVICE_ERROR_NONE) {
			LOGI("Device vibrates!");
		}
	}
}

static double _get_radian(int num)
{
	return num * (PI / 180);
}



static Evas_Object *_create_win(appdata_s *ad)
{
	Evas_Object *win = NULL;
	int ret = 0;

	ret = watch_app_get_elm_win(&win);
	if (ret != APP_ERROR_NONE) {
		_E("failed to get window. err = %d", ret);
		return NULL;
	}

	elm_win_title_set(win, "analogwatch");
	elm_win_borderless_set(win, EINA_TRUE);
	elm_win_alpha_set(win, EINA_FALSE);
	elm_win_indicator_mode_set(win, ELM_WIN_INDICATOR_HIDE);
	elm_win_indicator_opacity_set(win, ELM_WIN_INDICATOR_BG_TRANSPARENT);
	elm_win_prop_focus_skip_set(win, EINA_TRUE);
	elm_win_role_set(win, "no-effect");

	evas_object_resize(win, ad->w, ad->h);
	evas_object_show(win);

	return win;
}



static Evas_Object *_create_layout(appdata_s *ad)
{
	Elm_Object_Item *nf_it = NULL;
	Evas_Object *layout = NULL;
	Eina_Bool ret;

	retv_if(!ad, NULL);
	retv_if(!ad->win, NULL);

	layout = elm_layout_add(ad->win);
	retv_if(!layout, NULL);

	ret = elm_layout_file_set(layout, LAYOUTEDJ, "main");
	if (EINA_FALSE == ret) return NULL;

	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(layout, ad->w, ad->h);
	evas_object_resize(layout, ad->w, ad->h);
	evas_object_show(layout);

	return layout;
}



static Evas_Object *_create_clock(appdata_s *ad)
{
	Evas *evas = NULL;
	Evas_Object *clock = NULL;

	retv_if(!ad, NULL);
	retv_if(!ad->layout, NULL);

	evas = evas_object_evas_get(ad->layout);
	retv_if(!evas, NULL);

	/* Clock base */
	clock = evas_object_rectangle_add(evas);
	retv_if(!clock, NULL);

	if (ad->w < ad->h) {
		evas_object_size_hint_min_set(clock, ad->w, ad->w);
		evas_object_resize(clock, ad->w, ad->w);
	} else {
		evas_object_size_hint_min_set(clock, ad->h, ad->h);
		evas_object_resize(clock, ad->h, ad->h);
	}
	evas_object_color_set(clock, 255, 255, 255, 255);
	elm_object_part_content_set(ad->layout, "clock", clock);
	evas_object_show(clock);

	/* Hands of the clock */
	ad->hour_needle = evas_object_line_add(evas);
	evas_object_color_set(ad->hour_needle, 0, 0, 0, 255);
	evas_object_show(ad->hour_needle);

	ad->min_needle = evas_object_line_add(evas);
	evas_object_color_set(ad->min_needle, 100, 100, 100, 255);
	evas_object_show(ad->min_needle);

	ad->sec_needle = evas_object_line_add(evas);
	evas_object_color_set(ad->sec_needle, 255, 0, 0, 255);
	evas_object_show(ad->sec_needle);

	return clock;
}


#define DATA_FILE_PATH "/opt/usr/media/stretching_data.txt"

static void _launch_stretchme_app(void *data)
{
	app_control_h app_control;

	app_control_create(&app_control);
	app_control_set_operation(app_control, APP_CONTROL_OPERATION_DEFAULT);
	app_control_set_app_id(app_control, "org.example.stretchme");

	// app parameter : time
	// TODO: emit the last time instead of the current

	time_t current_time;
	struct tm* struct_time;

	char timeformat[20];
	bool is_read = false;

	// get current time
	time(&current_time);
	struct_time = localtime(&current_time);

	dlog_print(DLOG_DEBUG, LOG_TAG, "[%d] : %d, %d, %d, %d : %d : %d\n", current_time, struct_time->tm_year+1900, struct_time->tm_mon+1, struct_time->tm_mday, struct_time->tm_hour, struct_time->tm_min, struct_time->tm_sec);

	// get the last success time from file
	FILE *fp = fopen(DATA_FILE_PATH, "rw+");

	if(fp != NULL)
	{
		if(fgets(timeformat, sizeof(timeformat), fp) != NULL)
		{
			_D("reading data : %s", timeformat);
			is_read = true;
		}

		fclose(fp);
	}
	else
	{
		_D("file open failed");
	}

	char timestring[20];

	// emit current time stamp
	snprintf(timestring, sizeof(timestring), "%d", current_time);
	app_control_add_extra_data(app_control, "timestamp", timestring);

	// emit the last success time formatted text
	if(is_read)
	{
		app_control_add_extra_data(app_control, "timeformat", timeformat);
	}
	else
	{
		// emit current time formatted text
		snprintf(timestring, sizeof(timestring), "%04d-%02d-%02d %02d:%02d:%02d", struct_time->tm_year+1900, struct_time->tm_mon+1, struct_time->tm_mday, struct_time->tm_hour, struct_time->tm_min, struct_time->tm_sec);
		app_control_add_extra_data(app_control, "timeformat", timestring);
	}

	if (app_control_send_launch_request(app_control, NULL, NULL) == APP_CONTROL_ERROR_NONE)
	{
	   _D("Succeeded to launch a stretchme app.");
	}
	else
	{
	   _D("Failed to launch a stretchme app.");
	}

	app_control_destroy(app_control);

}


static void _clock_set_info_time(void *data, watch_time_h watch_time)
{
	appdata_s *ad = NULL;
	int hour24, minute, second;
	int w, h = 0;
	double num = 0;

	ret_if(!data);
	ret_if(!watch_time);

	ad = (appdata_s *)data;

	watch_time_get_hour24(watch_time, &hour24);
	watch_time_get_minute(watch_time, &minute);
	watch_time_get_second(watch_time, &second);

	w = ad->w;
	h = ad->h;

	num = _get_radian((hour24%12) * HOUR_ANGLE);
	evas_object_line_xy_set(ad->hour_needle, (w/2), (h/2), (w/2) + HOUR_NEEDLE_SIZE*(sin(num)), (h/2) - HOUR_NEEDLE_SIZE*(cos(num)));

	num = _get_radian(minute * MIN_ANGLE);
	evas_object_line_xy_set(ad->min_needle, (w/2), (h/2), (w/2) + MIN_NEEDLE_SIZE*(sin(num)), (h/2) - MIN_NEEDLE_SIZE*(cos(num)));

	num = _get_radian(second * SEC_ANGLE);
	_D("Time : %d : %d : %d", hour24%12, minute, second);
	evas_object_line_xy_set(ad->sec_needle, (w/2), (h/2), (w/2) + SEC_NEEDLE_SIZE*(sin(num)), (h/2) - SEC_NEEDLE_SIZE*(cos(num)));

#if LAUNCH_AT_EVERY_HOUR
	if(ad->is_running && minute == 0 && second == 0)
		if(hour24 > 9 && hour24 < 18)
			_launch_stretchme_app(data);
#endif
}

#if !LAUNCH_AT_EVERY_HOUR
static void clock_mouse_down_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
   Evas_Event_Mouse_Down *ev = event_info;
   appdata_s *ad = (appdata_s *)data;

	// TODO: need to check exception
   ad->is_stretching = EINA_FALSE;
}

static void clock_mouse_up_cb(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
   Evas_Event_Mouse_Up *ev = event_info;
   appdata_s *ad = (appdata_s *)data;

   // TODO: need to check exception

   if(ad->is_stretching == EINA_FALSE)
   {
   		_D("clicked!!");
#if 0
   		// TODO: launch the strecthing ui with new window
   		create_main_win(ad);
#else
		_launch_stretchme_app(ad);
   }

   ad->is_stretching = EINA_TRUE;
#endif
}
#endif

static void _create_analogwatch(appdata_s *ad)
{
	int ret;
	watch_time_h watch_time = NULL;

	ret_if(!ad);

	_D("Create analog watch");

	/* Window */
	ad->win = _create_win(ad);
	ret_if(!ad->win);

	/* Layout */
	ad->layout = _create_layout(ad);
	goto_if(!ad->layout, ERROR);

	/* Clock */
	ad->clock = _create_clock(ad);
	goto_if(!ad->clock, ERROR);

#if !LAUNCH_AT_EVERY_HOUR
	/* Stretching UI */
	evas_object_event_callback_add(ad->clock, EVAS_CALLBACK_MOUSE_DOWN, clock_mouse_down_cb, ad);
	evas_object_event_callback_add(ad->clock, EVAS_CALLBACK_MOUSE_UP, clock_mouse_up_cb, ad);
#endif

	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE) {
		_E("failed to get current time. err = %d", ret);
	}

	_clock_set_info_time(ad, watch_time);

	return;

ERROR:
	if (ad->sec_needle) evas_object_del(ad->sec_needle);
	if (ad->min_needle) evas_object_del(ad->min_needle);
	if (ad->hour_needle) evas_object_del(ad->hour_needle);
	if (ad->layout) evas_object_del(ad->layout);
	if (ad->win) evas_object_del(ad->win);

	return;
}

static void _destroy_analogwatch(appdata_s *ad)
{
	ret_if(!ad);

	_D("Destroy analog watch");

	if (ad->sec_needle) evas_object_del(ad->sec_needle);
	if (ad->min_needle) evas_object_del(ad->min_needle);
	if (ad->hour_needle) evas_object_del(ad->hour_needle);
	if (ad->clock) evas_object_del(ad->clock);
	if (ad->layout) evas_object_del(ad->layout);
	if (ad->win) evas_object_del(ad->win);
}



static void lang_changed(app_event_info_h event_info, void* user_data)
{
	// Takes necessary actions when language setting is changed
	char *locale = NULL;

	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	ret_if(!locale);

	elm_language_set(locale);
	free(locale);

	return;
}



static void region_changed(app_event_info_h event_info, void* user_data)
{
	// Takes necessary actions when region setting is changed
}



static void low_battery(app_event_info_h event_info, void* user_data)
{
	// Takes necessary actions when system is running on low battery
	watch_app_exit();
}



static void low_memory(app_event_info_h event_info, void* user_data)
{
	// Takes necessary actions when system is running on low memory
	watch_app_exit();
}



static void device_orientation(app_event_info_h event_info, void* user_data)
{
	// Takes necessary actions when system is running on low memory
}



static bool app_create(int width, int height, void* user_data)
{
	// Hook to take necessary actions before main event loop starts; this
	// usually means initializing UI and application's data.

	app_event_handler_h handlers[5] = {NULL, };

	// Register callbacks for each system event
	if (watch_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, lang_changed, NULL) != APP_ERROR_NONE) {
		 _E("watch_app_add_event_handler () is failed");
	}
	if (watch_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, region_changed, NULL) != APP_ERROR_NONE) {
		 _E("watch_app_add_event_handler () is failed");
	}
	if (watch_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, low_battery, NULL) != APP_ERROR_NONE) {
		 _E("watch_app_add_event_handler () is failed");
	}
	if (watch_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY,low_memory, NULL) != APP_ERROR_NONE) {
		 _E("watch_app_add_event_handler () is failed");
	}
	if (watch_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, device_orientation, NULL) != APP_ERROR_NONE) {
		 _E("watch_app_add_event_handler () is failed");
	}

	appdata_s *ad = (appdata_s *)user_data;

	ad->w = width;
	ad->h = height;

	_create_analogwatch(ad);

	return true;
}


static bool
_app_control_extra_data_cb(app_control_h app_control, const char *key, void *user_data)
{
	int ret;
	char *value;

	ret = app_control_get_extra_data(app_control, key, &value);
	if (ret != APP_CONTROL_ERROR_NONE)
	{
		_E("app_control_get_extra_data() failed. err = %d", ret);
	}

	_D("[key] %s, [value] %s", key, value);

	if(strcmp(key, "last_success_time") == 0)
	{
		// last success time

		// TODO: need to handle the last success time
		int success_time = atoi(value);
		struct tm* tm = localtime (success_time);

		_D("[%s] : %d, %d, %d, %d : %d : %d\n", key, tm->tm_year+1900, tm->tm_mon+1, tm->tm_mday, tm->tm_hour, tm->tm_min, tm->tm_sec);
	}

	return true;
}


static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */

	int ret = app_control_foreach_extra_data(app_control, _app_control_extra_data_cb, 0);
	if (ret != APP_CONTROL_ERROR_NONE)
	   _E("app_control_foreach_extra_data() failed. err = %d", ret);
}

static void app_pause(void* user_data)
{
	// Takes necessary actions when application becomes invisible
	// Release the resources which need to draw the normal watch
}



static void app_resume(void* user_data)
{
	// Take necessary actions when application becomes visible
	// Acquire the resources which need to draw the normal watch
}



static void app_terminate(void* user_data)
{
	// Releases all resources;
	appdata_s *ad = NULL;

	ret_if(!user_data);

	ad = (appdata_s *)user_data;

	_destroy_analogwatch(ad);
}



static void app_time_tick(watch_time_h watch_time, void* user_data)
{
	appdata_s *ad = (appdata_s *)user_data;

	ad->is_running = EINA_TRUE;
	_clock_set_info_time(ad, watch_time);
}



static void app_ambient_tick(watch_time_h watch_time, void* user_data)
{
	appdata_s *ad = (appdata_s *)user_data;

	ad->is_running = EINA_TRUE;
	_clock_set_info_time(ad, watch_time);
}



static void app_ambient_changed(bool ambient_mode, void* user_data)
{
	if (ambient_mode) {
		// Prepare to enter the ambient mode
	}
	else {
		// Prepare to exit the ambient mode
	}
}



int main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	watch_app_lifecycle_callback_s event_callback = {0,};

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;
	event_callback.time_tick = app_time_tick;
	event_callback.ambient_tick = app_ambient_tick;
	event_callback.ambient_changed = app_ambient_changed;

	ret = watch_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		_E("watch_app_main() is failed. err = %d", ret);
	}

	return ret;
}
/* End of file */

