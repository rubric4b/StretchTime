//
// Created by hobbang5 on 2016-04-27.
//

#ifndef STRETCHTIME_SM_TYPE_H
#define STRETCHTIME_SM_TYPE_H

#include <Evas.h>

#define MAIN_EDJ "edje/main.edj"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.stretchtime"
#endif
#define STRETCHME_APP_ID "org.tizen.stretchme"
#define DATA_FILE_PATH "/opt/usr/media/stretching_data.txt"
#define DATA_LINE_LENGTH 22

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

#endif //STRETCHTIME_SM_TYPE_H
