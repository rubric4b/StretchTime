//
// Created by hobbang5 on 2016-04-27.
//

#ifndef STRETCHTIME_SM_VIEW_H
#define STRETCHTIME_SM_VIEW_H

#include <Evas.h>
#include <stdbool.h>

#include "sm_type.h"

void view_set_bagde_missed_calls(int count, void* data);

void view_set_display_time(current_time_t current_time, void* data);

void view_toggle_ambient_mode(bool ambient_mode, void *data);

Evas_Object *view_set_swallow_image_from_path(Evas_Object *layout, char *path, char *part);

void view_create(void* data);

#endif //STRETCHTIME_SM_VIEW_H
