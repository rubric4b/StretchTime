//
// Created by hobbang5 on 2016-04-27.
//

#include <watch_app_efl.h>
#include <efl_extension.h>

#include "stretch_time.h"
#include "view_defines.h"
#include "log.h"

#include "sm_view.h"

/*
 * @brief Sends a message to the EDJE script in order to set the badge's value. This function handles the
 * 'missed calls' and the 'unread messages' badges depending on the message_id.
 * @param[message_id]: the message id. Available messages: MSG_ID_SET_BADGE_MISSED_CALLS, MSG_ID_SET_BADGE_UNREAD_MESSAGES.
 */
static void _set_badge(int message_id, int badge_count, void* data)
{
    appdata_s* ad = data;

    Edje_Message_Int msg = {0,};

    if (!ad->layout) {
        dlog_print(DLOG_ERROR, LOG_TAG, "Invalid layout object.");
        return;
    }

    msg.val = badge_count;

    edje_object_message_send(elm_layout_edje_get(ad->layout), EDJE_MESSAGE_INT, message_id, &msg);
}

/*
 * @brief Sends a signal to the EDJE script.
 * @param[layout]: the target layout for the signal.
 * @param[target_part]: the target part's name within the layout for the signal.
 * @param[signal_name]: the name of the signal to be sent.
 */
static void _emit_signal(Evas_Object *layout, const char *target_part, const char *signal_name)
{
    if (!layout) {
        dlog_print(DLOG_ERROR, LOG_TAG, "Invalid input argument.");
        return;
    }

    elm_object_signal_emit(layout, signal_name, target_part);
}

/*
 * @brief Sets the badge counter for 'missed calls' icon.
 * @param[count]: the number of missed calls to be displayed.
 */
void view_set_bagde_missed_calls(int count, void* data)
{
    _set_badge(MSG_ID_SET_BADGE_APP_ICON, count, data);
}

/*
 * @brief The callback function invoked on mouse down event over the 'missed calls' icon.
 * @param[data]: the user data passed to the elm_object_signal_callback_add function.
 * @param[obj]: the calling object (main layout in this case).
 * @param[emission]: the signal emitted from EDJE resulting with the function invocation.
 * @param[source]: the part name where the signal was emitted from.
 */
static void _app_icon_mouse_down_cb(void *data, Evas_Object *obj, const char *emission, const char *source)
{
    _emit_signal(obj, PART_APP_ICON, SIGNAL_APP_ICON_PRESS);
}

/*
 * @brief The callback function invoked on mouse up event over the 'missed calls' icon.
 * @param[data]: the user data passed to the elm_object_signal_callback_add function.
 * @param[obj]: the calling object (main layout in this case).
 * @param[emission]: the signal emitted from EDJE resulting with the function invocation.
 * @param[source]: the part name where the signal was emitted from.
 */
static void _app_icon_mouse_up_cb(void *data, Evas_Object *obj, const char *emission, const char *source)
{
    appdata_s* ad = data;

    _emit_signal(obj, PART_APP_ICON, SIGNAL_APP_ICON_UNPRESS);

    if (ad->icon_cb)
        ad->icon_cb(VIEW_ICON_ID_APP);
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

/*
 * @brief Toggles the ambient mode on (draws a second hand) and off (hides a second hand).
 * @param[current_time]: the structure of time components.
 */
void view_toggle_ambient_mode(bool ambient_mode, void *data)
{
    appdata_s* ad = data;
    Edje_Message_Int msg = {0,};

    msg.val = (int)ambient_mode;

    edje_object_message_send(elm_layout_edje_get(ad->layout), EDJE_MESSAGE_INT, MSG_ID_AMBIENT_MODE, &msg);
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

Evas_Object *view_set_swallow_image_from_path(Evas_Object *layout, char *path, char *part)
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

    ad->hand_hh = view_set_swallow_image_from_path(layout, "images/watch/hand_hour.png", PART_HAND_HOUR);
    ad->hand_mm = view_set_swallow_image_from_path(layout, "images/watch/hand_minute.png", PART_HAND_MINUTE);

    evas_object_show(layout);

    elm_object_signal_callback_add(layout, "mouse,down,1", PART_APP_ICON, _app_icon_mouse_down_cb, data);
    elm_object_signal_callback_add(layout, "mouse,up,1", PART_APP_ICON, _app_icon_mouse_up_cb, data);

    return layout;
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