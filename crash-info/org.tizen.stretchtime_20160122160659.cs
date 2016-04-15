S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 19756
Date: 2016-01-22 16:06:59+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10ca

Register Information
r0   = 0x000010be, r1   = 0x0000000f
r2   = 0x0000040e, r3   = 0x41971194
r4   = 0x000010be, r5   = 0x00000000
r6   = 0x4188e534, r7   = 0x414dda08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbee38c44, sp   = 0xbee38bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     25268 KB
Buffers:     25596 KB
Cached:     117900 KB
VmPeak:      78984 KB
VmSize:      78472 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15348 KB
VmRSS:       15348 KB
VmData:      21980 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23720 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 19756 TID = 19756
19756 19863 19869 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40054000 40060000 r-xp /usr/lib/libaul.so.0.1.0
4006a000 4006c000 r-xp /lib/libdl-2.13.so
40075000 40078000 r-xp /usr/lib/libbundle.so.0.1.22
40080000 40082000 r-xp /usr/lib/libdlog.so.0.0.0
4008a000 4009e000 r-xp /lib/libpthread-2.13.so
400a9000 401e3000 r-xp /usr/lib/libelementary.so.1.7.99
401f9000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ec000 40303000 r-xp /usr/lib/libecore.so.1.7.99
4031a000 40377000 r-xp /usr/lib/libedje.so.1.7.99
40381000 40451000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40452000 40458000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40460000 40463000 r-xp /usr/lib/libsmack.so.1.0.0
4046b000 40473000 r-xp /lib/libgcc_s-4.6.so.1
40474000 4058f000 r-xp /lib/libc-2.13.so
4059d000 405d9000 r-xp /usr/lib/libsystemd.so.0.4.0
405e2000 405ed000 r-xp /lib/libunwind.so.8.0.1
4061a000 40631000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40639000 40663000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066c000 40671000 r-xp /usr/lib/libxdgmime.so.1.1.0
40679000 4069b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a3000 406a6000 r-xp /usr/lib/libproc-stat.so.0.2.86
406ae000 406b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406bd000 40726000 r-xp /lib/libm-2.13.so
4072f000 40748000 r-xp /usr/lib/libeet.so.1.7.99
40759000 4079a000 r-xp /usr/lib/libeina.so.1.7.99
407a3000 407c5000 r-xp /usr/lib/libecore_evas.so.1.7.99
407ce000 407d3000 r-xp /usr/lib/libecore_file.so.1.7.99
407db000 407ec000 r-xp /usr/lib/libecore_input.so.1.7.99
407f4000 407f8000 r-xp /usr/lib/libvconf.so.0.2.45
40800000 40850000 r-xp /usr/lib/libecore_x.so.1.7.99
40852000 4085b000 r-xp /usr/lib/libedbus.so.1.7.99
40863000 4087d000 r-xp /usr/lib/libecore_con.so.1.7.99
40886000 40899000 r-xp /usr/lib/libfribidi.so.0.3.1
408a1000 408de000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e7000 4090f000 r-xp /usr/lib/libfontconfig.so.1.8.0
40910000 40966000 r-xp /usr/lib/libfreetype.so.6.11.3
40972000 409c8000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d5000 409db000 r-xp /lib/librt-2.13.so
409e4000 409eb000 r-xp /usr/lib/libembryo.so.1.7.99
409f3000 40a0a000 r-xp /usr/lib/liblua-5.1.so
40a13000 40a19000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a21000 40a22000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2a000 40a50000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a59000 40a5c000 r-xp /lib/libcap.so.2.21
40a64000 40a7c000 r-xp /usr/lib/liblzma.so.5.0.3
40a84000 40b00000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b0c000 40b1c000 r-xp /lib/libresolv-2.13.so
40b20000 40bf3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40bfe000 40c32000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c3b000 40c51000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c59000 40cce000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cd8000 40cee000 r-xp /lib/libz.so.1.2.5
40cf6000 40d19000 r-xp /usr/lib/libjpeg.so.8.0.2
40d31000 40e12000 r-xp /usr/lib/libX11.so.6.3.0
40e1d000 40e22000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e2b000 40e2f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e38000 40e3b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e43000 40e4a000 r-xp /usr/lib/libXcursor.so.1.0.2
40e52000 40e54000 r-xp /usr/lib/libXdamage.so.1.1.0
40e5c000 40e5e000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e66000 40e68000 r-xp /usr/lib/libXgesture.so.7.0.0
40e70000 40e73000 r-xp /usr/lib/libXfixes.so.3.1.0
40e7b000 40e84000 r-xp /usr/lib/libXi.so.6.1.0
40e8c000 40e8d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e96000 40e9c000 r-xp /usr/lib/libXrandr.so.2.2.0
40ea4000 40eaa000 r-xp /usr/lib/libXrender.so.1.3.0
40eb2000 40eb5000 r-xp /usr/lib/libXtst.so.6.1.0
40ebe000 40ec8000 r-xp /usr/lib/libXext.so.6.4.0
40ed1000 40f15000 r-xp /usr/lib/libcurl.so.4.3.0
40f1e000 40f34000 r-xp /lib/libexpat.so.1.5.2
40f3e000 40f56000 r-xp /usr/lib/libpng12.so.0.50.0
40f5e000 40f7a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f83000 41017000 r-xp /usr/lib/libstdc++.so.6.0.16
4102b000 4102e000 r-xp /lib/libattr.so.1.1.0
41036000 41041000 r-xp /usr/lib/libgpg-error.so.0.15.0
41049000 4104a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41052000 41057000 r-xp /usr/lib/libffi.so.5.0.10
4105f000 41061000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4106a000 41136000 r-xp /usr/lib/libxml2.so.2.7.8
41143000 41145000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4114e000 41150000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41158000 4116b000 r-xp /usr/lib/libxcb.so.1.1.0
41175000 4117e000 r-xp /usr/lib/libcares.so.2.1.0
41187000 411b5000 r-xp /usr/lib/libidn.so.11.5.44
411bd000 4120a000 r-xp /usr/lib/libssl.so.1.0.0
41216000 413be000 r-xp /usr/lib/libcrypto.so.1.0.0
413d7000 413d9000 r-xp /usr/lib/libiri.so
413e2000 413e9000 r-xp /lib/libcrypt-2.13.so
41419000 4141b000 r-xp /usr/lib/libXau.so.6.0.0
41528000 4152c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4153c000 41541000 r-xp /usr/lib/libappcore-common.so.1.1
41549000 4154b000 r-xp /usr/lib/libiniparser.so.0
41554000 41558000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41568000 4156d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41575000 41577000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41580000 41586000 r-xp /usr/lib/libappsvc.so.0.1.0
4158e000 415b2000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415bb000 4168a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416a0000 416aa000 r-xp /lib/libnss_files-2.13.so
41971000 41a4e000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
41a9c000 41aa3000 r-xp /usr/lib/libappcore-watch.so.1.1
41aac000 41ab1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41ab9000 41abd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41ac6000 41ace000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41acf000 41aef000 r-xp /usr/lib/libefl-extension.so.0.1.0
41af0000 41afd000 r-xp /usr/lib/libalarm.so.0.0.0
41b06000 41c43000 r-xp /usr/lib/libicui18n.so.51.1
41c53000 41d37000 r-xp /usr/lib/libicuuc.so.51.1
41d4c000 41d52000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41d5a000 41d60000 r-xp /usr/lib/libwidget.so.1.0.0
41d69000 41d6e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41d76000 41d94000 r-xp /usr/lib/libsensor.so.1.1.0
41d9e000 41db0000 r-xp /usr/lib/libefl-assist.so.0.1.0
41db8000 41e70000 r-xp /usr/lib/libcairo.so.2.11200.14
43402000 4340b000 r-xp /usr/lib/libcom-core.so.0.0.1
43414000 43420000 r-xp /usr/lib/libwidget_service.so.1.0.0
43428000 43431000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4343a000 43441000 r-xp /usr/lib/libsensord-share.so
43449000 4345b000 r-xp /usr/lib/libtts.so
43463000 43484000 r-xp /usr/lib/libui-extension.so.0.1.0
4348d000 43494000 r-xp /usr/lib/libtbm.so.1.0.0
4349c000 434aa000 r-xp /usr/lib/libGLESv2.so.2.0
434b3000 434b4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
434bd000 434c3000 r-xp /usr/lib/libxcb-render.so.0.0.0
434cb000 434ce000 r-xp /usr/lib/libEGL.so.1.4
434d6000 434de000 r-xp /usr/lib/libdrm.so.2.4.0
434e6000 434e8000 r-xp /usr/lib/libdri2.so.0.0.0
434f0000 434f3000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
434fb000 43500000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43509000 4350e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43516000 43537000 r-xp /usr/lib/libexif.so.12.3.3
4354a000 4354f000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43557000 43621000 r-xp /usr/lib/libCOREGL.so.4.0
43966000 44165000 rwxp [stack:19863]
44165000 44168000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44170000 4417b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4429f000 44a9e000 rwxp [stack:19869]
bee19000 bee3a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:19756)
Call Stack Count: 6
 0: (0x400169dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0x400170d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0x40017360) [/lib/ld-linux.so.3] + 0xa360
 3: (0x4001b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0x40021a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0x404e170c) [/lib/libc.so.6] + 0x6d70c
End of Call Stack

Package Information
Package Name: org.tizen.stretchtime
Package ID : org.tizen.stretchtime
Version: 1.0.0
Package Type: rpm
App Name: stretchtime
App ID: org.tizen.stretchtime
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
l() return
01-22 16:05:52.229+0900 E/W_HOME  (  713): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
01-22 16:05:52.244+0900 W/W_HOME  (  713): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
01-22 16:05:52.244+0900 E/W_HOME  (  713): dbox.c: del_cb(225) > Add viewer has no info: dd.watchdesigner.Robuste
01-22 16:05:52.254+0900 W/W_HOME  (  713): cfwd.c: cfwd_get_icon_status(362) > 
01-22 16:05:52.254+0900 W/W_HOME  (  713): ============================
01-22 16:05:52.254+0900 W/W_HOME  (  713): multi_sim_category:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): multi_sim_model:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): support_callforward_auto:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): conn_status:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): remote_call_forward_auto:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): auto_call_forward_status:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): support_callforward_reverse:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): reverse_call_forward_auto:0
01-22 16:05:52.254+0900 W/W_HOME  (  713): fwd_type:
01-22 16:05:52.254+0900 W/W_HOME  (  713): ============================
01-22 16:05:52.254+0900 W/W_HOME  (  713): 
01-22 16:05:52.254+0900 W/W_HOME  (  713): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
01-22 16:05:52.269+0900 W/W_HOME  (  713): clock_indicator.c: clock_indicator_icon_push(356) > icon:5 is added to clock indicator
01-22 16:05:52.274+0900 E/W_HOME  (  713): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
01-22 16:05:52.274+0900 E/W_HOME  (  713): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-22 16:05:52.274+0900 W/W_HOME  (  713): noti_broker.c: _clock_attached_cb(804) > 0
01-22 16:05:52.274+0900 W/W_HOME  (  713): cs_broker.c: _clock_view_attached_cb(231) > 
01-22 16:05:52.284+0900 W/W_HOME  (  713): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
01-22 16:05:52.289+0900 W/W_HOME  (  713): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
01-22 16:05:52.289+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:05:52.294+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:05:52.294+0900 I/CLOCK-LIST(  713): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.tizen.stretchtime:watchface::messageport::event]
01-22 16:05:52.294+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:05:52.294+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:05:52.294+0900 E/MESSAGE_PORT(  713): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
01-22 16:05:52.294+0900 E/CLOCK-LIST(  713): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
01-22 16:05:52.314+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8c760, elm_box, _activated_obj : 0x45c8c760, activated : 1
01-22 16:05:52.314+0900 E/wnotib  (  713): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-22 16:05:52.314+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 409, 218.
01-22 16:05:52.314+0900 I/wnotib  (  713): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
01-22 16:05:52.314+0900 I/efl-extension(  713): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x49b50770, obj: 0x49b50770
01-22 16:05:52.314+0900 I/efl-extension(  713): efl_extension_rotary.c: _object_deleted_cb(601) > done
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49b50770, elm_scroller, func : 0x4072fe19
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x491b3640, elm_image, func : 0x4072fe19
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
01-22 16:05:52.319+0900 I/efl-extension(  713): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x49b50770 : elm_scroller] rotary callabck is deleted
01-22 16:05:52.419+0900 I/GESTURE (  135): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-22 16:05:52.444+0900 W/WATCH_CORE(  753): appcore-watch.c: __widget_pause(1001) > widget_pause
01-22 16:05:52.444+0900 E/watchface-app(  753): watchface.cpp: OnAppPause(591) > 
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.444+0900 E/watchface-viewer(  753): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
01-22 16:05:52.544+0900 E/W_HOME  (  713): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
01-22 16:05:52.569+0900 W/WATCH_CORE(  753): appcore-watch.c: __widget_destroy(992) > widget_destory
01-22 16:05:52.569+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 22
01-22 16:05:52.569+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(884) > app status : 4
01-22 16:05:52.569+0900 W/CAPI_WATCH_APPLICATION(  753): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-22 16:05:52.569+0900 E/watchface-app(  753): watchface.cpp: OnAppTerminated(523) > 
01-22 16:05:52.574+0900 W/W_CLOCK_VIEWER(  717): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(82) >  DBOX deleted[dd.watchdesigner.Robuste]
01-22 16:05:52.574+0900 I/watchface-viewer(  753): viewer-view.cpp: CleanTrash(800) > Flush 13 groups
01-22 16:05:52.574+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f54008] for [17]
01-22 16:05:52.574+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f54048] for [30]
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f34950] for [17]
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f34a98] for [30]
01-22 16:05:52.579+0900 E/W_HOME  (  713): move.c: move_back_to_home_no_anim(270) > home is already on position
01-22 16:05:52.579+0900 W/W_HOME  (  713): scroller.c: _get_index_in_list(1902) > page:0x4a07d888 idx:1 total12 exist:1
01-22 16:05:52.579+0900 W/W_HOME  (  713): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
01-22 16:05:52.579+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c8a1e0), origin_x(0), origin_y(0)
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
01-22 16:05:52.579+0900 W/W_HOME  (  713): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f398c4] for [32]
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f3b46c] for [32]
01-22 16:05:52.579+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f3ccd4] for [9]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f3e4bc] for [9]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f6f54c] for [9]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f70d3c] for [9]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f7260c] for [5]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f73dac] for [5]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f75634] for [4]
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47f76df4] for [4]
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  753): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [dd.watchdesigner.Robuste:watchface-external-command], client = 753
01-22 16:05:52.584+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-bitmap-font-manager.cpp: ~BitmapFontManager(124) > 
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-group-manager.cpp: Clear(32) > 
01-22 16:05:52.584+0900 I/watchface-viewer(  753): viewer-shader-manager.cpp: ~ShaderEffect(396) > 
01-22 16:05:52.594+0900 I/efl-extension( 1132): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
01-22 16:05:52.594+0900 W/wnotibp ( 1132): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
01-22 16:05:52.594+0900 I/MALI    (  753): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
01-22 16:05:52.594+0900 I/MALI    (  753): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=753   close drm_fd=44 
01-22 16:05:52.594+0900 I/MALI    (  753): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
01-22 16:05:52.599+0900 E/UXT     (  753): uxt_theme.c: uxt_theme_delete_changed_callback(492) > failed to get the callback from list
01-22 16:05:52.599+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > >~Adaptor()
01-22 16:05:52.599+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > >~Core()
01-22 16:05:52.599+0900 E/E17     (  364): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02600003)
01-22 16:05:52.604+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > <~ResourceClient()
01-22 16:05:52.604+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > <~ResourceManager()
01-22 16:05:52.609+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > <~Core()
01-22 16:05:52.614+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > <~SlpPlatformAbstraction()
01-22 16:05:52.614+0900 I/DALI    (  753): slp-logging.cpp: LogMessage(36) > <~Adaptor()
01-22 16:05:52.619+0900 I/watchface-app(  753): watchface-package-control.cpp: DelListener(223) > removed listener[0x438a4128] for [1074821290]
01-22 16:05:52.624+0900 I/watchface-common-util(  753): common-util-ipc-control.cpp: ~CommonUtilIPCControl(197) > 
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  753): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [dd.watchdesigner.Robuste:watchface::messageport::event], client = 753
01-22 16:05:52.629+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:05:52.634+0900 I/watchface-common-util(  753): common-util-privacy-lock.cpp: ~CommonUtilPrivacyLock(53) > vconf_ignore_key_changed(VCONFKEY_IDLE_LOCK_STATE) returns -1
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
01-22 16:05:52.634+0900 E/TIZEN_N_SYSTEM_SETTINGS(  753): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
01-22 16:05:52.634+0900 E/WIDGET_PROVIDER_APP(  753): client.c: client_fini(1175) > Provider is not initialized
01-22 16:05:52.664+0900 I/UXT     (  753): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
01-22 16:05:52.934+0900 I/efl-extension(  753): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-22 16:05:52.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:52.999+0900 D/stretch (18759): Time : 4 : 5 : 53
01-22 16:05:53.069+0900 W/W_HOME  (  713): main.c: _init_timer_cb(1138) > home init
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:05:53.234+0900 E/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
01-22 16:05:53.234+0900 E/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(753) are closed. delete client info
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
01-22 16:05:53.234+0900 E/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  753
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.234+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.254+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.254+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
01-22 16:05:53.524+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 23
01-22 16:05:53.529+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
01-22 16:05:53.529+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 753
01-22 16:05:53.529+0900 W/AUL_AMD (  527): amd_request.c: __send_app_termination_signal(507) > send dead signal done
01-22 16:05:53.599+0900 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 753
01-22 16:05:54.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:54.009+0900 D/stretch (18759): Time : 4 : 5 : 54
01-22 16:05:54.579+0900 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-22 16:05:55.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:55.004+0900 D/stretch (18759): Time : 4 : 5 : 55
01-22 16:05:56.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:56.004+0900 D/stretch (18759): Time : 4 : 5 : 56
01-22 16:05:57.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:57.004+0900 D/stretch (18759): Time : 4 : 5 : 57
01-22 16:05:58.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:58.009+0900 D/stretch (18759): Time : 4 : 5 : 58
01-22 16:05:59.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:05:59.004+0900 D/stretch (18759): Time : 4 : 5 : 59
01-22 16:06:00.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:00.004+0900 D/stretch (18759): Time : 4 : 6 : 0
01-22 16:06:00.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-22 16:06:00.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-22 16:06:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : pedometer_inactive_period error
01-22 16:06:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-22 16:06:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-22 16:06:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : inactive_10min_precaution_millisec error
01-22 16:06:00.109+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-22 16:06:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-22 16:06:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : inactive_before_10min_precaution_millisec error
01-22 16:06:01.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:01.004+0900 D/stretch (18759): Time : 4 : 6 : 1
01-22 16:06:02.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:02.004+0900 D/stretch (18759): Time : 4 : 6 : 2
01-22 16:06:03.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:03.004+0900 D/stretch (18759): Time : 4 : 6 : 3
01-22 16:06:04.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:04.004+0900 D/stretch (18759): Time : 4 : 6 : 4
01-22 16:06:05.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:05.004+0900 D/stretch (18759): Time : 4 : 6 : 5
01-22 16:06:06.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:06.004+0900 D/stretch (18759): Time : 4 : 6 : 6
01-22 16:06:07.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:07.009+0900 D/stretch (18759): Time : 4 : 6 : 7
01-22 16:06:08.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:08.004+0900 D/stretch (18759): Time : 4 : 6 : 8
01-22 16:06:09.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:09.004+0900 D/stretch (18759): Time : 4 : 6 : 9
01-22 16:06:10.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:10.004+0900 D/stretch (18759): Time : 4 : 6 : 10
01-22 16:06:11.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:11.004+0900 D/stretch (18759): Time : 4 : 6 : 11
01-22 16:06:12.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:12.004+0900 D/stretch (18759): Time : 4 : 6 : 12
01-22 16:06:13.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:13.004+0900 D/stretch (18759): Time : 4 : 6 : 13
01-22 16:06:14.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:14.009+0900 D/stretch (18759): Time : 4 : 6 : 14
01-22 16:06:14.684+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-22 16:06:14.689+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-22 16:06:14.694+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-22 16:06:14.694+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-22 16:06:14.719+0900 W/SHealth ( 6346): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/22 16:6:14 7일 전[0;m
01-22 16:06:14.724+0900 I/SHealth ( 6346): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-22 16:06:14.729+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-22 16:06:14.734+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-22 16:06:14.739+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-22 16:06:14.739+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6346): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-22 16:06:14.744+0900 I/SHealth ( 6346): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-22 16:06:15.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:15.004+0900 D/stretch (18759): Time : 4 : 6 : 15
01-22 16:06:16.004+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:16.004+0900 D/stretch (18759): Time : 4 : 6 : 16
01-22 16:06:16.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:16.999+0900 D/stretch (18759): Time : 4 : 6 : 17
01-22 16:06:17.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:17.999+0900 D/stretch (18759): Time : 4 : 6 : 18
01-22 16:06:18.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:19.004+0900 D/stretch (18759): Time : 4 : 6 : 19
01-22 16:06:19.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:19.999+0900 D/stretch (18759): Time : 4 : 6 : 20
01-22 16:06:20.859+0900 E/PKGMGR_SERVER(19859): pkgmgr-server.c: main(2126) > package manager server start
01-22 16:06:20.939+0900 E/PKGMGR_SERVER(19859): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-617004261], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-22 16:06:20.944+0900 E/PKGMGR_SERVER(19860): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-22 16:06:20.999+0900 I/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:06:20.999+0900 D/stretch (18759): Time : 4 : 6 : 21
01-22 16:06:21.009+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 14
01-22 16:06:21.019+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18759
01-22 16:06:21.024+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 12
01-22 16:06:21.029+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 5
01-22 16:06:21.029+0900 W/AUL_AMD (  527): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(18759), cmd(4)
01-22 16:06:21.034+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 22
01-22 16:06:21.034+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(884) > app status : 4
01-22 16:06:21.034+0900 W/CAPI_WATCH_APPLICATION(18759): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-22 16:06:21.034+0900 D/stretch (18759): Destroy analog watch
01-22 16:06:21.034+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 14
01-22 16:06:21.034+0900 W/WATCH_CORE(18759): appcore-watch.c: __widget_destroy(992) > widget_destory
01-22 16:06:21.034+0900 E/WIDGET_PROVIDER_APP(18759): client.c: client_fini(1175) > Provider is not initialized
01-22 16:06:21.044+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18759
01-22 16:06:21.044+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 4
01-22 16:06:21.054+0900 I/efl-extension(18759): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-22 16:06:21.154+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 14
01-22 16:06:21.229+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-22 16:06:21.264+0900 E/AUL_AMD (  527): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-22 16:06:21.264+0900 W/AUL_AMD (  527): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(18759), cmd(4)
01-22 16:06:21.289+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 0
01-22 16:06:21.324+0900 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-22 16:06:21.354+0900 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-22 16:06:21.354+0900 E/AUL_AMD (  527): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-22 16:06:21.354+0900 W/AUL_AMD (  527): amd_launch.c: _start_app(1659) > caller pid : 706
01-22 16:06:21.359+0900 E/PKGMGR  (19853): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-22 16:06:21.369+0900 E/PKGMGR_SERVER(19860): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-22 16:06:21.374+0900 W/AUL_AMD (  527): amd_launch.c: _start_app(2026) > pad pid(-5)
01-22 16:06:21.374+0900 W/AUL_PAD ( 1128): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-22 16:06:21.374+0900 W/AUL_PAD ( 1128): launchpad.c: __send_result_to_caller(265) > Check app launching
01-22 16:06:21.414+0900 E/PKGMGR_SERVER(19859): pkgmgr-server.c: sighandler(445) > child NORMAL exit [19860]
01-22 16:06:21.474+0900 I/efl-extension(19756): efl_extension.c: eext_mod_init(40) > Init
01-22 16:06:21.474+0900 I/UXT     (19756): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-22 16:06:21.494+0900 I/CAPI_WATCH_APPLICATION(19756): watch_app_main.c: watch_app_main(382) > watch_app_main
01-22 16:06:21.494+0900 E/RESOURCED(  528): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 1
01-22 16:06:21.494+0900 E/RESOURCED(  528): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-22 16:06:21.524+0900 E/TBM     (19756): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-22 16:06:21.579+0900 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 18759
01-22 16:06:21.614+0900 W/WATCH_CORE(19756): appcore-watch.c: __widget_create(958) > widget_create
01-22 16:06:21.614+0900 D/stretch (19756): Create analog watch
01-22 16:06:21.614+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [9278.023438] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_713_9278.023438.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263018:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-22 16:06:21.614+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9278.023438] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_713_9278.023438.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263018:4] gbar_fname[]
01-22 16:06:21.629+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [9278.023438] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_713_9278.023438.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263018:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-22 16:06:21.629+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9278.023438] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_713_9278.023438.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263018:4] gbar_fname[]
01-22 16:06:21.639+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-22 16:06:21.639+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-22 16:06:21.694+0900 D/stretch (19756): Time : 4 : 6 : 21
01-22 16:06:21.694+0900 W/WATCH_CORE(19756): appcore-watch.c: __widget_create(976) > widget_create done
01-22 16:06:21.764+0900 I/WATCH_CORE(19756): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-22 16:06:21.764+0900 I/WATCH_CORE(19756): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-22 16:06:21.764+0900 I/WATCH_CORE(19756): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-22 16:06:21.794+0900 E/EFL     (19756): edje<19756> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-22 16:06:21.804+0900 D/stretch (19756): [key] name, [value] 7_9278.105130
01-22 16:06:21.804+0900 D/stretch (19756): [key] secured, [value] true
01-22 16:06:21.804+0900 D/stretch (19756): [key] abi, [value] app
01-22 16:06:21.804+0900 D/stretch (19756): [key] hw-acceleration, [value] use-sw
01-22 16:06:22.579+0900 W/AUL_AMD (  527): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-22 16:06:22.579+0900 W/AUL_AMD (  527): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-22 16:06:22.594+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 14
01-22 16:06:22.604+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19756
01-22 16:06:22.604+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 12
01-22 16:06:22.609+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 14
01-22 16:06:22.614+0900 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19756
01-22 16:06:22.614+0900 W/AUL_AMD (  527): amd_request.c: __request_handler(640) > __request_handler: 12
01-22 16:06:22.819+0900 I/AUL_PAD (19870): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-22 16:06:23.034+0900 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-22 16:06:23.599+0900 E/PKGMGR_SERVER(19859): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-22 16:06:23.599+0900 E/PKGMGR_SERVER(19859): pkgmgr-server.c: main(2180) > package manager server terminated.
01-22 16:06:28.390+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 95 -> 94 1453446388 270
01-22 16:06:28.400+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 667 313 1045
01-22 16:06:28.400+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 0 0 1285
01-22 16:06:28.400+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 783 679 1227
01-22 16:06:28.400+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 2153 5 3373
01-22 16:06:28.400+0900 I/RESOURCED(  528): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 2153 5 3373
01-22 16:06:35.044+0900 I/RESOURCED(  528): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-22 16:06:35.044+0900 I/RESOURCED(  528): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-22 16:06:35.044+0900 I/RESOURCED(  528): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] abnormal cache is empty
01-22 16:06:44.374+0900 E/PKGMGR  (19999): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-22 16:06:44.759+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: main(2126) > package manager server start
01-22 16:06:44.904+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-593306723], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-593306723' '-r' 'org.tizen.stretchtime'], cookie=[BqR1C0g410nNZJIeOJUe4hGAYZo=], backend_flag=[0]
01-22 16:06:44.909+0900 E/PKGMGR  (20001): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-22 16:06:44.909+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-22 16:06:44.909+0900 E/PKGMGR  (19999): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[199990002]
01-22 16:06:45.369+0900 E/PKGMGR_SERVER(20003): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-22 16:06:45.834+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-22 16:06:45.839+0900 W/AUL_AMD (  527): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-22 16:06:45.844+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:1
01-22 16:06:46.109+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-22 16:06:47.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:49.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:50.494+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-22 16:06:50.504+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
01-22 16:06:50.539+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 98
01-22 16:06:50.539+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 98
01-22 16:06:50.539+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 16 3
01-22 16:06:50.539+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 17 3
01-22 16:06:50.539+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 3
01-22 16:06:50.544+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 3
01-22 16:06:50.559+0900 E/PKGMGR_CERT(20003): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
01-22 16:06:51.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:53.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:54.589+0900 E/rpm-installer(20003): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
01-22 16:06:55.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:57.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:59.599+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-22 16:06:59.834+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-22 16:06:59.844+0900 E/PKGMGR_SERVER(20001): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20003]
01-22 16:06:59.849+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.tizen.stretchtime is updated, need to check validation
01-22 16:06:59.849+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.tizen.stretchtime
01-22 16:06:59.874+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
01-22 16:06:59.874+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
01-22 16:06:59.874+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
01-22 16:06:59.874+0900 E/WMS     (  525): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
01-22 16:06:59.904+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.tizen.stretchtime is updated, preload:0 update:1 event->update:1
01-22 16:06:59.954+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
01-22 16:07:00.029+0900 E/PKGMGR_INFO(  524): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
01-22 16:07:00.064+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-22 16:07:00.064+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-22 16:07:00.064+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : pedometer_inactive_period error
01-22 16:07:00.064+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-22 16:07:00.069+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-22 16:07:00.069+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : inactive_10min_precaution_millisec error
01-22 16:07:00.069+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-22 16:07:00.069+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-22 16:07:00.069+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1012): preference.c: preference_get_double(1214) > preference_get_double(1012) : inactive_before_10min_precaution_millisec error
01-22 16:07:00.334+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 1119756737472145344641
