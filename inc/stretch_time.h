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

#define HOUR_ANGLE 30
#define MIN_ANGLE 6
#define SEC_ANGLE 6
#define HOUR_NEEDLE_SIZE 70
#define MIN_NEEDLE_SIZE 100
#define SEC_NEEDLE_SIZE 110

typedef struct appdata{
	Evas_Object *win;
	Evas_Object *layout;

	Evas_Object *clock;
	Evas_Object *hour_needle;
	Evas_Object *min_needle;
	Evas_Object *sec_needle;

	int w;
	int h;

	/* about stretching */
	Evas_Object *st_win;
	Evas_Object *st_nf;
	Evas_Object *st_layout;
	Eext_Circle_Surface *st_circle_surface;

	Evas_Object *st_datetime;
	Evas_Object *st_label;
	struct tm st_saved_time;

	// view
	Ecore_Timer * fold_timer;
	Eina_Bool is_stretch_success;

	Eina_Bool is_stretching;
} appdata_s;

static inline const char *get_resource_path(const char * file_path);

#if !defined(PACKAGE)
#define PACKAGE "org.example.stretchtime"
#endif

#define EDJPATH "edje"
#define LAYOUTEDJ get_resource_path(EDJPATH"/main.edj")

#define EDJ_FILE "edje/stretch_ui_layout.edj"
#define ICON_DIR "/opt/usr/apps/org.example.stretchme/res/images"

static inline const char *get_resource_path(const char *file_path)
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

void app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max);
void vibrate(int duration, int feedback);

#endif /* __main_H__ */
