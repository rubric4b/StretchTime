//
// Created by hobbang5 on 2016-04-25.
//

#include "sm_popup.h"

static void
popup_hide_cb(void *data, Evas_Object *obj, void *event_info)
{
    if(!data) return;
    elm_popup_dismiss(data);
}

static void
popup_hide_finished_cb(void *data, Evas_Object *obj, void *event_info)
{
    if(!data) return;
    evas_object_del(data);
}

void popup_training_cb(void *data, Evas_Object *obj, void *event_info)
{
    Evas_Object *popup;
    Evas_Object *btn;
    Evas_Object *icon;
    Evas_Object *layout;
    appdata_s *ad = (appdata_s *) data;

    popup = elm_popup_add(ad->layout);
    elm_object_style_set(popup, "circle");
    evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, popup_hide_cb, popup);
    evas_object_smart_callback_add(popup, "dismissed", popup_hide_finished_cb, popup);

    layout = elm_layout_add(popup);
    elm_layout_theme_set(layout, "layout", "popup", "content/circle/buttons2");
    elm_object_part_text_set(layout, "elm.text.title", "ALERT");

    elm_object_part_text_set(layout, "elm.text", "움직이실 시간입니다.<br>"
            "스트레칭을 시작 하시겠습니까?");
    elm_object_content_set(popup, layout);

    btn = elm_button_add(popup);
    elm_object_style_set(btn, "popup/circle/left");
    evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(popup, "button1", btn);
    evas_object_smart_callback_add(btn, "clicked", popup_hide_cb, popup);

    icon = elm_image_add(btn);
    elm_image_file_set(icon, get_resource_path("images/tw_ic_popup_btn_delete.png"), NULL);
    evas_object_size_hint_weight_set(icon, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(btn, "elm.swallow.content", icon);
    evas_object_show(icon);

    btn = elm_button_add(popup);
    elm_object_style_set(btn, "popup/circle/right");
    evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(popup, "button2", btn);
    evas_object_smart_callback_add(btn, "clicked", popup_hide_cb, popup);

    icon = elm_image_add(btn);

//	elm_image_file_set(icon, get_resource_path("images/Hour.png"), NULL);
    elm_image_file_set(icon, get_resource_path("images/tw_ic_popup_btn_check.png"), NULL);
    evas_object_size_hint_weight_set(icon, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    elm_object_part_content_set(btn, "elm.swallow.content", icon);
    evas_object_show(icon);

    evas_object_show(popup);
}
