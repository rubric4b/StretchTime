//
// Created by hobbang5 on 2016-04-27.
//

#include <app.h>
#include <Elementary.h>
#include <haptic.h>

#include "log.h"

#include "sm_signal.h"

/*
 * @brief The callback function invoked in response to app_control_send_launch_request().
 * @param[request]: the handle of app_control request.
 * @param[reply]: the handle of app_control response.
 * @param[result]: the result of app_control_send_launch_request() invocation.
 * @param[data]: the user data passed to the app_control_send_launch_request() function.
 */
static void _app_launch_request_cb(app_control_h request, app_control_h reply, app_control_result_e result, void *data)
{
    const char *app_id = (const char *)data;

    switch (result) {
        case APP_CONTROL_RESULT_SUCCEEDED:
            dlog_print(DLOG_INFO, LOG_TAG, "The '%s' launch request succeeded.", app_id);
            break;
        case APP_CONTROL_RESULT_CANCELED:
            dlog_print(DLOG_WARN, LOG_TAG, "The '%s' launch request was canceled.", app_id);
            break;
        case APP_CONTROL_RESULT_FAILED:
            dlog_print(DLOG_WARN, LOG_TAG, "The '%s' launch request failed.", app_id);
            break;
        default:
            dlog_print(DLOG_ERROR, LOG_TAG, "The '%s' launch request error.", app_id);
            break;
    }
}

/*
 * @brief The callback function invoked on application's icon tap.
 * @param[id]: the identifier of the tapped application.
 */
void signal_app_launch_request(const char* app_id)
{
    app_control_h app_ctrl = NULL;

    if (app_control_create(&app_ctrl) != APP_CONTROL_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "app_control_create() is failed.");
        return;
    }

    if (app_control_set_app_id(app_ctrl, app_id) != APP_CONTROL_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "app_control_set_app_id() is failed.");
        app_control_destroy(app_ctrl);
        return;
    }

    if (app_control_send_launch_request(app_ctrl, _app_launch_request_cb, (void *)app_id) != APP_CONTROL_ERROR_NONE)
        dlog_print(DLOG_ERROR, LOG_TAG, "app_control_send_launch_request() is failed.");

    app_control_destroy(app_ctrl);
}

void signal_vibrate(int duration, int feedback)
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