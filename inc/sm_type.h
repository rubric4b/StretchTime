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
#define EX_TYPE_LEN 1
#define TIME_LEN 19
#define TYPE_LEN 1
#define ACHIEVE_COUNT 1
#define ST_TYPE_LEN 1
#define RATE_INT_LEN 5
#define RATE_REAL_LEN 8
#define RATE_LEN (RATE_INT_LEN+1+RATE_REAL_LEN) // 12345.12345678
#define DATA_LINE_LENGTH (EX_TYPE_LEN + 1 + TIME_LEN + 1 + TYPE_LEN + 1 + ACHIEVE_COUNT + 1 + ST_TYPE_LEN + 1 + RATE_LEN + 1)

#define EXPERIMENT_TYPE1_FILE_PATH "/opt/usr/media/stretchme.ex1"
#define EXPERIMENT_TYPE2_FILE_PATH "/opt/usr/media/stretchme.ex2"
#define EXPERIMENT_TYPE3_FILE_PATH "/opt/usr/media/stretchme.ex3"

struct _current_time {
    int hour;
    int minute;
    int second;
};

typedef struct _current_time current_time_t;

typedef enum {
    VIEW_ICON_ID_APP
} view_icon_id_t;

typedef enum
{
    EXPERIMENT_1,	// reminder only
    EXPERIMENT_2,	// reminder + motion recognition
    EXPERIMENT_3,	// reminder + motion recognition + gamification
    EXPERIMENT_MAX
}Experiment_Type;

typedef void      (*Resume_cb)(void *data, Evas_Object *obj, void *event_info);
typedef void (*Icon_Pressed_cb)(view_icon_id_t id);

#endif //STRETCHTIME_SM_TYPE_H
