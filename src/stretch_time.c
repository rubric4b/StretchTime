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
#include <Elementary.h>

#include "stretch_time.h"
#include "sm_view.h"
#include "sm_data.h"
#include "sm_signal.h"
#include "sm_popup.h"
#include "view_defines.h"
#include "log.h"


void update_alram_time(void* data) {
	appdata_s* ad = data;
	time_t current_time, time1;
	struct tm alram;
	time_t last_success_time;
	bool is_read = get_stored_last_time(&last_success_time, ST_SUCCESS);
	struct tm test = *localtime(&last_success_time);
	_D("is_read %d, last_succes_time %d:%d:%d, ad->last %d\n", is_read, test.tm_hour,test.tm_min,test.tm_sec, ad->last_success_time);
	_D("alram time is %2d:%2d:%2d\n", ad->alram_time.hour, ad->alram_time.minute, ad->alram_time.second);

	time(&current_time); //get current time

	// if alarm time was expired already, reset
	if(is_read && current_time > ad->alram_time2)
		ad->is_alram_set = false;

	// if last_success_time was updated, reset
	if(is_read && (last_success_time != ad->last_success_time)) {
		ad->last_success_time = last_success_time;
		ad->is_alram_set = false;
	}

	if(ad->is_alram_set == false)
	{
		// if current time is not elapsed less than 1 hour from last success
		if(difftime(current_time, last_success_time) < 60 * 60 /*1hour*/)
		{
			time1 = last_success_time + 60 * 60; // after 1 hour from last success
//			time1 = current_time + 60 * 1; // TESTCODE 1 min!
		}
		else
		{
			time1 = current_time + 60 * 5; // after 5 min from current
//			time1 = current_time + 60 * 1; // TESTCODE 1 min!
		}
		ad->is_alram_set = true;

		alram = *localtime(&time1);
		ad->alram_time2 = time1; // raw time data update
		ad->alram_time.hour = alram.tm_hour;
		ad->alram_time.minute = alram.tm_min;

		_D("alram reset %2d:%2d:%2d\n", ad->alram_time.hour, ad->alram_time.minute, ad->alram_time.second);
	}


	int count = (is_read) ? div((int)difftime(current_time, ad->last_success_time), 60 * 60).quot : 0;
//	count = 5; //TESTCODE!
	if(!ad->is_ambient) {
		view_set_bagde_missed_calls(count, data);
	}

}

/*
 * @brief: Obtains the current time from watch_time_h and converts to the current_time_t.
 * @param[watch_time]: The date and time structure acquired in time_tick callback function.
 * @param[current_time]: The structure of time components extracted from watch_time argument.
 * @return: The function returns 'true' if the time is successfully converted, otherwise 'false' is returned.
 */
static bool _get_time(watch_time_h watch_time, current_time_t *current_time)
{
	int ret;

	if (!current_time) {
		dlog_print(DLOG_ERROR, LOG_TAG, "current_time is NULL");
		return false;
	}

	memset(current_time, 0, sizeof(current_time_t));

	if (!watch_time) {
		dlog_print(DLOG_ERROR, LOG_TAG, "watch_time is NULL");
		return false;
	}

	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get current time. err = %d", ret);
		return false;
	}

	watch_time_get_hour24(watch_time, &current_time->hour);
	watch_time_get_minute(watch_time, &current_time->minute);
	watch_time_get_second(watch_time, &current_time->second);

	return true;
}

static void _destroy_analogwatch(appdata_s *ad)
{
	ret_if(!ad);

	_D("Destroy analog watch");
	if (ad->dummy) evas_object_del(ad->dummy);
	if (ad->hand_mm) evas_object_del(ad->hand_mm);
	if (ad->hand_hh) evas_object_del(ad->hand_hh);
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

void _icon_pressed_cb(view_icon_id_t id) {
	const char *app_id = NULL;

	switch (id) {
		case VIEW_ICON_ID_APP:
			app_id = STRETCHME_APP_ID;
			break;
		default:
			dlog_print(DLOG_WARN, LOG_TAG, "Unknown id of the tapped application's icon.");
			return;
	}

	signal_app_launch_request(app_id);

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

	view_create(ad);

	ad->icon_cb = _icon_pressed_cb;

	return true;
}


static bool
_app_control_extra_data_cb(app_control_h app_control, const char *key, void *user_data)
{
	/*int ret;
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
	}*/

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
	_D("app_pause\n");
}

static void app_resume(void* user_data)
{
	// Take necessary actions when application becomes visible
	// Acquire the resources which need to draw the normal watch
	_D("app_resume\n");

	appdata_s* ad = user_data;

	if(ad->resume_cb) {
		ad->resume_cb(user_data, NULL, NULL);
		ad->resume_cb = NULL;
	}

	update_alram_time(user_data);

}

static void app_terminate(void* user_data)
{
	// Releases all resources;
	appdata_s *ad = NULL;

	ret_if(!user_data);

	ad = (appdata_s *)user_data;

	_destroy_analogwatch(ad);
}

static void app_time_tick(watch_time_h watch_time, void* data)
{
	appdata_s* ad = data;

	current_time_t current_time = {0,};

	if (_get_time(watch_time, &current_time))
		view_set_display_time(current_time, data);
//	_D("tick %2d:%2d:%2d, mode %d\n", current_time.hour, current_time.minute, current_time.second, ad->is_ambient);
//	_D("alram set %2d:%2d:%2d\n", ad->alram_time.hour, ad->alram_time.minute, ad->alram_time.second);

	if(current_time.second == 0)
	{
		// check and update alarm time at every minute
		update_alram_time(data);
	}

	if(current_time.hour >= 10 && current_time.hour < 22 && ad->is_alram_set) {
//	if( ad->is_alram_set) { // TESTCODE

		if(ad->popup && current_time.second == 0)
		{
			signal_vibrate(1000, 99);
		}

		if (ad->alram_time.hour == current_time.hour &&
			ad->alram_time.minute == current_time.minute &&
			ad->popup == NULL) {

			signal_vibrate(1000, 99);

			if(!ad->is_ambient) {
				popup_training_cb(data, NULL, NULL);
			}else{
				ad->resume_cb = popup_training_cb;
			}
		}
	}

}

static void app_ambient_tick(watch_time_h watch_time, void* user_data)
{
	app_time_tick(watch_time, user_data);
}

static void app_ambient_changed(bool ambient_mode, void* data)
{
	appdata_s* ad = data;
	ad->is_ambient = ambient_mode;

	_D("app_ambient_changed bool %d\n", ambient_mode);
	if(ambient_mode) {
		evas_object_del(ad->hand_hh);
		evas_object_del(ad->hand_mm);
		ad->hand_hh = view_set_swallow_image_from_path(ad->layout, "images/watch/hand_hour_w.png", PART_HAND_HOUR);
		ad->hand_mm = view_set_swallow_image_from_path(ad->layout, "images/watch/hand_minute_w.png", PART_HAND_MINUTE);
		ad->dummy = view_set_swallow_image_from_path(ad->layout, "images/watch/black.png", PART_APP_ICON_DUMMY);
	}else {
		evas_object_del(ad->hand_hh);
		evas_object_del(ad->hand_mm);
		evas_object_del(ad->dummy);
		ad->hand_hh = view_set_swallow_image_from_path(ad->layout, "images/watch/hand_hour.png", PART_HAND_HOUR);
		ad->hand_mm = view_set_swallow_image_from_path(ad->layout, "images/watch/hand_minute.png", PART_HAND_MINUTE);
		ad->dummy = NULL;

	}

	view_toggle_ambient_mode(ambient_mode, data);
}

int main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;
	_D("main\n");

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

