//
// Created by hobbang5 on 2016-04-25.
//

#include "sm_popup.h"
#include "log.h"

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

/*    // get the last success time from file
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
    }*/

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

static void
popup_yes_cb(void *data, Evas_Object *obj, void *event_info)
{
    appdata_s *ad = (appdata_s *) data;

    if(!data) return;

    ad->is_alram_set = false; // stretchme app lunched

    elm_popup_dismiss(ad->popup);

    _launch_stretchme_app(data);

}

static void
popup_hide_cb(void *data, Evas_Object *obj, void *event_info)
{
    appdata_s *ad = (appdata_s *) data;
    time_t current_time;
    struct tm alram;

    if(!data) return;

//    ad->is_alram_set = false;
    time(&current_time); //get current time
    current_time += 3600;
    alram = *localtime(&current_time);

    ad->alram_time.hour = alram.tm_hour;
    ad->alram_time.minute = alram.tm_min;

    _D("stretch canceled : alram set %2d:%2d:%2d\n", ad->alram_time.hour, ad->alram_time.minute, ad->alram_time.second);

    elm_popup_dismiss(ad->popup);
}

static void
popup_hide_finished_cb(void *data, Evas_Object *obj, void *event_info)
{
    appdata_s *ad = (appdata_s *) data;
    if(!data) return;
    evas_object_del(ad->popup);
}

void popup_training_cb(void *data, Evas_Object *obj, void *event_info)
{
    Evas_Object *btn;
    Evas_Object *icon;
    Evas_Object *layout;
    appdata_s *ad = (appdata_s *) data;

    if(ad->popup) return;

    vibrate(150, 99);

    ad->popup = elm_popup_add(ad->layout);
    elm_object_style_set(ad->popup, "circle");
    evas_object_size_hint_weight_set(ad->popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    eext_object_event_callback_add(ad->popup, EEXT_CALLBACK_BACK, popup_hide_cb, data);
    evas_object_smart_callback_add(ad->popup, "dismissed", popup_hide_finished_cb, data);

    layout = elm_layout_add(ad->popup);
    elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
    elm_object_part_text_set(layout, "elm.text.title", "ALERT");

    elm_object_part_text_set(layout, "elm.text", "<font_size=38> 스트레칭<br>시간입니다!</font_size><br>"
            "시작하시겠습니까?");

    elm_object_content_set(ad->popup, layout);

    btn = elm_button_add(ad->popup);
    elm_object_style_set(btn, "popup/circle/left");
    evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(ad->popup, "button1", btn);
    evas_object_smart_callback_add(btn, "clicked", popup_hide_cb, data);

    icon = elm_image_add(btn);
    elm_image_file_set(icon, get_resource_path("images/tw_ic_popup_btn_delete.png"), NULL);
    evas_object_size_hint_weight_set(icon, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(btn, "elm.swallow.content", icon);
    evas_object_show(icon);

    btn = elm_button_add(ad->popup);
    elm_object_style_set(btn, "popup/circle/right");
    evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(ad->popup, "button2", btn);
    evas_object_smart_callback_add(btn, "clicked", popup_yes_cb, data);

    icon = elm_image_add(btn);

//	elm_image_file_set(icon, get_resource_path("images/Hour.png"), NULL);
    elm_image_file_set(icon, get_resource_path("images/tw_ic_popup_btn_check.png"), NULL);
    evas_object_size_hint_weight_set(icon, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(btn, "elm.swallow.content", icon);
    evas_object_show(icon);

    evas_object_show(ad->popup);
}

