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
#include <Ecore.h>
#include <system_settings.h>
//#include <Elementary.h>
//#include <efl_extension.h>
//#include <dlog.h>

#include "sm_type.h"

#define MAX_LENGTH_PATH 1024

typedef struct appdata{
	Evas_Object *win;
	Evas_Object *layout;
	Evas_Object *popup;

	// SWALLOW edje object
	Evas_Object *hand_hh;
	Evas_Object *hand_mm;
	Evas_Object *dummy;


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

void update_alram_time(void* data);

#endif /* __main_H__ */
