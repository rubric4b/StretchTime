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
#include <device/haptic.h>

#include "stretch_time.h"
#include "sm_popup.h"
#include "view_defines.h"
#include "log.h"

#define MAIN_EDJ "edje/main.edj"
#define PI 3.1415926535897

Evas_Object *view_create_win(const char *pkg_name, void* data);
static Evas_Object *_create_layout(void* data);

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

/*
 * @brief Create Essential Object window and layout
 */
void view_create(void* data)
{
	appdata_s* ad = data;

	ad->win = view_create_win(PACKAGE, data);
	if (!ad->win) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to create a window.");
		return;
	}

	ad->layout = _create_layout(data);
	if (!ad->layout) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to create main layout.");
		return;
	}

	evas_object_show(ad->win);
}


/*
 * @brief Makes a basic window named with package name.
 * @param[pkg_name]: Name of the window.
 */
Evas_Object *view_create_win(const char *pkg_name, void* data)
{
	appdata_s* ad = data;
	Evas_Object *win = NULL;
	int ret;

	/*
	 * Window
	 * Create and initialize elm_win.
	 * elm_win is mandatory to manipulate window
	 */
	ret = watch_app_get_elm_win(&win);
	if (ret != APP_ERROR_NONE)
		return NULL;

	elm_win_title_set(win, pkg_name);
	elm_win_borderless_set(win, EINA_TRUE);
	elm_win_alpha_set(win, EINA_FALSE);
	elm_win_indicator_mode_set(win, ELM_WIN_INDICATOR_HIDE);
	elm_win_indicator_opacity_set(win, ELM_WIN_INDICATOR_BG_TRANSPARENT);
	elm_win_prop_focus_skip_set(win, EINA_TRUE);
	elm_win_role_set(win, "no-effect");

	evas_object_resize(win, ad->w, ad->h);

	return win;
}

/*
 * @brief Makes and sets a layout to the part
 * @param[parent]: Object to which you want to set this layout
 * @param[file_path]: File path of EDJ will be used
 * @param[group_name]: Group name in EDJ that you want to set to layout
 * @param[part_name]: Part name to which you want to set this layout
 */
Evas_Object *view_create_layout_for_part(Evas_Object *parent, char *file_path, char *group_name, char *part_name)
{
	Evas_Object *layout = NULL;

	if (parent == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "parent is NULL.");
		return NULL;
	}

	layout = elm_layout_add(parent);
	elm_layout_file_set(layout, file_path, group_name);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	evas_object_show(layout);

	elm_object_part_content_set(parent, part_name, layout);

	return layout;
}

void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

Evas_Object *set_swallow_image_from_path(Evas_Object *layout, char *path, char *part)
{
	Evas_Object* img;

	img = elm_image_add(layout);
	elm_image_file_set(img, get_resource_path(path), NULL);
	evas_object_size_hint_weight_set(img, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_part_content_set(layout, part, img);
	evas_object_show(img);

	return img;
}

/*
 * @brief Creates the application's layout.
 * @return: The Evas_Object of the layout created.
 */
static Evas_Object *_create_layout(void* data)
{
	appdata_s* ad = data;

	char *edj_path = get_resource_path(MAIN_EDJ);
	Evas_Object *layout = view_create_layout_for_part(ad->win, edj_path, "main", "default");
	if (!layout)
		return NULL;

	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_min_set(layout, ad->w, ad->h);
	evas_object_resize(layout, ad->w, ad->h);

	ad->bg = set_swallow_image_from_path(layout, "images/watch/cipher_board_bg.png", PART_BACKGROUND);
	ad->hand_hh = set_swallow_image_from_path(layout, "images/watch/hand_hour.png", PART_HAND_HOUR);
	ad->hand_mm = set_swallow_image_from_path(layout, "images/watch/hand_minute.png", PART_HAND_MINUTE);

	evas_object_show(layout);
	return layout;
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
	if (ad->hand_mm) evas_object_del(ad->hand_mm);
	if (ad->hand_hh) evas_object_del(ad->hand_hh);
	if (ad->bg) evas_object_del(ad->bg);
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

	view_create(ad);

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


/*
 * @brief Draws the clock's hands.
 * @param[current_time]: the structure of time components.
 */
void view_set_display_time(current_time_t current_time, void* data)
{
	appdata_s* ad = data;

	Edje_Message_Int_Set *msg = malloc(sizeof(Edje_Message_Int_Set) + 2 * sizeof(int));

	msg->count = 3;
	msg->val[0] = current_time.hour;
	msg->val[1] = current_time.minute;
	msg->val[2] = current_time.second;

	edje_object_message_send(elm_layout_edje_get(ad->layout), EDJE_MESSAGE_INT_SET, MSG_ID_SET_TIME, msg);

	free(msg);
}

static void app_time_tick(watch_time_h watch_time, void* data)
{

	current_time_t current_time = {0,};

	if (_get_time(watch_time, &current_time))
		view_set_display_time(current_time, data);
}



static void app_ambient_tick(watch_time_h watch_time, void* user_data)
{
	app_time_tick(watch_time, user_data);
}

/*
 * @brief Toggles the ambient mode on (draws a second hand) and off (hides a second hand).
 * @param[current_time]: the structure of time components.
 */
void view_toggle_ambient_mode(bool ambient_mode, void* data)
{
	appdata_s* ad = data;
	Edje_Message_Int msg = {0,};

	msg.val = (int)ambient_mode;

	edje_object_message_send(elm_layout_edje_get(ad->layout), EDJE_MESSAGE_INT, MSG_ID_AMBIENT_MODE, &msg);
}

static void app_ambient_changed(bool ambient_mode, void* data)
{
	appdata_s* ad = data;

	_D("app_ambient_changed bool %d\n", ambient_mode);
	if(ambient_mode) {
		evas_object_del(ad->bg);
		evas_object_del(ad->hand_hh);
		evas_object_del(ad->hand_mm);
		ad->bg = set_swallow_image_from_path(ad->layout, "images/watch/black.png", PART_BACKGROUND);
		ad->hand_hh = set_swallow_image_from_path(ad->layout, "images/watch/hand_hour_w.png", PART_HAND_HOUR);
		ad->hand_mm = set_swallow_image_from_path(ad->layout, "images/watch/hand_minute_w.png", PART_HAND_MINUTE);
	}else {
		evas_object_del(ad->bg);
		evas_object_del(ad->hand_hh);
		evas_object_del(ad->hand_mm);
		ad->bg = set_swallow_image_from_path(ad->layout, "images/watch/cipher_board_bg.png", PART_BACKGROUND);
		ad->hand_hh = set_swallow_image_from_path(ad->layout, "images/watch/hand_hour.png", PART_HAND_HOUR);
		ad->hand_mm = set_swallow_image_from_path(ad->layout, "images/watch/hand_minute.png", PART_HAND_MINUTE);

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

