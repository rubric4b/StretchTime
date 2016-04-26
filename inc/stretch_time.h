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

#ifndef __main_H__
#define __main_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <Ecore.h>

#define MAX_LENGTH_PATH 1024
#define MAIN_EDJ "edje/main.edj"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.stretchtime"
#endif
#define STRETCHME_APP_ID "org.tizen.stretchme"

struct _current_time {
	int hour;
	int minute;
	int second;
};

typedef struct _current_time current_time_t;

typedef enum {
	VIEW_ICON_ID_APP
} view_icon_id_t;

typedef void      (*Resume_cb)(void *data, Evas_Object *obj, void *event_info);
typedef void (*Icon_Pressed_cb)(view_icon_id_t id);


typedef struct appdata{
	Evas_Object *win;
	Evas_Object *layout;
	Evas_Object *bg;
	Evas_Object *hand_hh;
	Evas_Object *hand_mm;
	Evas_Object *dummy;
	Evas_Object *popup;

	int w;
	int h;

	bool is_ambient;

	current_time_t alram_time;

	time_t alram_time2;
	time_t last_success_time;

	bool is_alram_set;

	Resume_cb resume_cb;
	Icon_Pressed_cb icon_cb;

} appdata_s;

static inline char *get_resource_path(const char * file_path);

static inline char *get_resource_path(const char *file_path)
{
	static char absolute_path[MAX_LENGTH_PATH] = {'\0'};

	static char *res_path_buff = NULL;
	if(res_path_buff == NULL)
	{
		res_path_buff = app_get_resource_path();
	}

	snprintf(absolute_path, MAX_LENGTH_PATH, "%s%s", res_path_buff, file_path);

	return absolute_path;
}

void vibrate(int duration, int feedback);
void update_alram_time(void* data);


#endif /* __main_H__ */
