S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 19805
Date: 2016-01-20 17:19:30+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x152c

Register Information
r0   = 0x00001520, r1   = 0x0000000f
r2   = 0x000008a0, r3   = 0x41971194
r4   = 0x00001520, r5   = 0x00000000
r6   = 0x4188e57c, r7   = 0x414dda08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeef6c44, sp   = 0xbeef6bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     15660 KB
Buffers:     11488 KB
Cached:     121748 KB
VmPeak:      77944 KB
VmSize:      77432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15272 KB
VmRSS:       15272 KB
VmData:      20944 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23716 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 19805 TID = 19805
19805 20056 20061 

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
41971000 41a4d000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
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
43966000 44165000 rwxp [stack:20056]
44165000 44168000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44170000 4417b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4429f000 44a9e000 rwxp [stack:20061]
beed7000 beef8000 rwxp [stack]
End of Maps Information

Callstack Information (PID:19805)
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
607) > [Enter]
01-20 17:17:36.491+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: _wifi_set_power_on_off_cb(1506) > Wi-Fi registered device state changed callback
01-20 17:17:36.496+0900 I/WIFI_EFL_SDK(18976): app_main.c: _wifi_manager_scan_start(158) > _wifi_manager_scan_start
01-20 17:17:36.496+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: wifi_manager_scan(498) > Wi-Fi Scan start.
01-20 17:17:36.511+0900 I/APP_CORE(18976): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
01-20 17:17:36.511+0900 I/APP_CORE(18976): appcore-efl.c: __do_app(474) > [APP 18976] Initial Launching, call the resume_cb
01-20 17:17:36.511+0900 I/CAPI_APPFW_APPLICATION(18976): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-20 17:17:36.511+0900 I/WIFI_EFL_SDK(18976): app_main.c: app_resume(4329) > [Enter]
01-20 17:17:36.511+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: wifi_manager_set_scan_mode(526) > Wi-Fi Scan mode 1.
01-20 17:17:36.526+0900 W/APP_CORE(18976): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600003
01-20 17:17:36.531+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44b9db28 = w: 0 h: 0  obj 0x44bb05a0 w: 360 h: 360
01-20 17:17:36.531+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
01-20 17:17:36.571+0900 I/APP_CORE( 2723): appcore-efl.c: __do_app(429) > [APP 2723] Event: PAUSE State: RUNNING
01-20 17:17:36.571+0900 I/CAPI_APPFW_APPLICATION( 2723): app_main.c: app_appcore_pause(202) > app_appcore_pause
01-20 17:17:36.616+0900 E/WIFI_EFL_SDK(18976): layout_main.c: layout_main_menu_set_access_info(190) > 'access_obj != NULL' failed.
01-20 17:17:36.676+0900 E/CAPI_NETWORK_WECONN(18976): weconnection.c: weconn_get_service_state(587) > Failed to request (GDBus.Error:org.freedesktop.DBus.Error.UnknownMethod: No such interface `net.weconn.Technology' on object at path /net/weconn/technology/bluetooth)
01-20 17:17:36.676+0900 E/WIFI_EFL_SDK(18976): wifi_manager.c: wifi_manager_is_mobile_connected_via_bluetooth(1279) > is_mobile_connected_via_bluetooth() is failed. error = -5
01-20 17:17:36.706+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 1
01-20 17:17:36.706+0900 I/CAPI_NETWORK_WIFI(18976): net_wifi.c: wifi_get_connected_ap(226) > Connected AP 0x44c41358, rv 0
01-20 17:17:36.716+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 30
01-20 17:17:36.716+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 17:17:36.716+0900 E/RESOURCED(  521): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 18976
01-20 17:17:36.716+0900 I/APP_CORE(18976): appcore-efl.c: __do_app(429) > [APP 18976] Event: RESUME State: RUNNING
01-20 17:17:36.721+0900 E/EFL     (18976): elementary<18976> elm_widget.c:4367 elm_widget_type_check() Passing Object: 0x44bd0a00 in function: elm_check_state_get, of type: '(unknown)' when expecting type: 'elm_check'
01-20 17:17:36.721+0900 E/WIFI_EFL_SDK(18976): layout_main.c: layout_main_menu_set_access_info(190) > 'access_obj != NULL' failed.
01-20 17:17:36.741+0900 E/CAPI_NETWORK_WECONN(18976): weconnection.c: weconn_get_service_state(587) > Failed to request (GDBus.Error:org.freedesktop.DBus.Error.UnknownMethod: No such interface `net.weconn.Technology' on object at path /net/weconn/technology/bluetooth)
01-20 17:17:36.741+0900 E/WIFI_EFL_SDK(18976): wifi_manager.c: wifi_manager_is_mobile_connected_via_bluetooth(1279) > is_mobile_connected_via_bluetooth() is failed. error = -5
01-20 17:17:36.771+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 1
01-20 17:17:36.771+0900 I/CAPI_NETWORK_WIFI(18976): net_wifi.c: wifi_get_connected_ap(226) > Connected AP 0x44c40890, rv 0
01-20 17:17:36.966+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:17:36.976+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18976
01-20 17:17:36.976+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:17:37.001+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:17:37.011+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18976
01-20 17:17:37.011+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:17:37.036+0900 I/MALI    (18976): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x418a0650] swap changed from async to sync
01-20 17:17:37.236+0900 I/AUL_PAD (19805): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 17:17:37.371+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_scan_finished_cb(344) > [Enter]
01-20 17:17:37.371+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_scan_finished_cb(350) > Scanning progress is closed by user.
01-20 17:17:38.386+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:38.386+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:38.386+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:38.386+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:38.386+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44baec20, elm_image, time_stamp : 9062294
01-20 17:17:39.161+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), block(1)
01-20 17:17:39.161+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), ev->cur.canvas.x(228) ev->cur.canvas.y(163)
01-20 17:17:39.161+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), hold(0) freeze(0)
01-20 17:17:39.161+0900 E/EFL     (18976): evas_main<18976> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9063068 button=1 downs=1
01-20 17:17:39.176+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), block(1)
01-20 17:17:39.176+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), ev->cur.canvas.x(227) ev->cur.canvas.y(161)
01-20 17:17:39.176+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), hold(0) freeze(0)
01-20 17:17:39.186+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), block(1)
01-20 17:17:39.186+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), ev->cur.canvas.x(229) ev->cur.canvas.y(159)
01-20 17:17:39.186+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), hold(0) freeze(0)
01-20 17:17:39.196+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), block(1)
01-20 17:17:39.196+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), ev->cur.canvas.x(234) ev->cur.canvas.y(152)
01-20 17:17:39.196+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44b9a520), hold(0) freeze(0)
01-20 17:17:39.206+0900 E/EFL     (18976): evas_main<18976> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9063118 button=1 downs=0
01-20 17:17:39.411+0900 I/WIFI_EFL_SDK(18976): app_main.c: __main_menu_scan_tap_cb(4017) > [Enter]
01-20 17:17:39.461+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 8
01-20 17:17:39.461+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:17:39.461+0900 I/WIFI_EFL_SDK(18976): app_main.c: _scan_create(3711) > [Enter]
01-20 17:17:39.461+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_create(328) > [Enter]
01-20 17:17:39.536+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
01-20 17:17:39.536+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c660a0, elm_image, _activated_obj : 0x44baec20, activated : 1
01-20 17:17:39.536+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
01-20 17:17:39.541+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:17:39.541+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_append_ap_items(244) > [Enter]
01-20 17:17:39.541+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_clear_data(510) > 'self->ap_data_list != NULL' failed.
01-20 17:17:39.541+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:17:39.541+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:17:39.541+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 7.
01-20 17:17:39.551+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x4597be18]'s widget[0x45973320] to layout widget[0x45970da0]
01-20 17:17:39.551+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4597be18 = w: 0 h: 0  obj 0x45973320 w: 360 h: 360
01-20 17:17:39.556+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
01-20 17:17:39.556+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c660a0, elm_image, _activated_obj : 0x44c660a0, activated : 1
01-20 17:17:40.826+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:40.826+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:40.826+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:40.831+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:40.831+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c660a0, elm_image, time_stamp : 9064735
01-20 17:17:41.571+0900 I/APP_CORE( 2723): appcore-efl.c: __do_app(429) > [APP 2723] Event: MEM_FLUSH State: PAUSED
01-20 17:17:41.751+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 17:17:41.751+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 17:17:41.751+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 17:17:41.751+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c660a0, elm_image, time_stamp : 9065659
01-20 17:17:41.756+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 17:17:42.381+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), block(1)
01-20 17:17:42.381+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), ev->cur.canvas.x(132) ev->cur.canvas.y(194)
01-20 17:17:42.381+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), hold(0) freeze(0)
01-20 17:17:42.381+0900 E/EFL     (18976): evas_main<18976> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9066287 button=1 downs=1
01-20 17:17:42.406+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), block(1)
01-20 17:17:42.406+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), ev->cur.canvas.x(127) ev->cur.canvas.y(193)
01-20 17:17:42.406+0900 E/EFL     (18976): elementary<18976> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44bd1600), hold(0) freeze(0)
01-20 17:17:42.406+0900 E/EFL     (18976): evas_main<18976> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9066306 button=1 downs=0
01-20 17:17:42.426+0900 I/WIFI_EFL_SDK(18976): app_main.c: __scan_menu_ap_item_tap_cb(3579) > [Enter]
01-20 17:17:42.451+0900 I/WIFI_EFL_SDK(18976): app_main.c: __scan_menu_ap_item_tap_cb(3588) > Connected AP
01-20 17:17:42.451+0900 I/WIFI_EFL_SDK(18976): app_main.c: _is_removable_ap(925) > [Media_AP] is removable ap.(security type enum value is 0)
01-20 17:17:42.451+0900 I/WIFI_EFL_SDK(18976): app_main.c: _detail_create(1006) > [Enter]
01-20 17:17:42.456+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
01-20 17:17:42.456+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c75ba8, elm_image, _activated_obj : 0x44c660a0, activated : 1
01-20 17:17:42.456+0900 I/efl-extension(18976): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
01-20 17:17:42.521+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x44125b38]'s widget[0x44120408] to layout widget[0x44141068]
01-20 17:17:42.526+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44125b38 = w: 0 h: 0  obj 0x44120408 w: 360 h: 360
01-20 17:17:42.531+0900 I/efl-extension(18976): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
01-20 17:17:43.211+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.211+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9067120
01-20 17:17:43.211+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.211+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.211+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.751+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.751+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.751+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.756+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.756+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9067661
01-20 17:17:43.791+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.791+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.791+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.796+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.796+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9067702
01-20 17:17:43.826+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.826+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.826+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.831+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.831+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9067733
01-20 17:17:43.866+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.866+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.866+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.866+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:43.866+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9067773
01-20 17:17:44.321+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:44.321+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:44.321+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:44.321+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:17:44.321+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9068229
01-20 17:17:49.376+0900 E/DBG_PAD (12721): discovery.c: _discovery_thread(74) > Unknown packet, 5
01-20 17:17:49.376+0900 E/DBG_PAD (12721): 192.168.159.2:26101
01-20 17:17:49.376+0900 E/DBG_PAD (12721): ,22
01-20 17:17:54.861+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:17:55.006+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 11
01-20 17:17:55.006+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:17:55.006+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:17:55.006+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:17:55.111+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 10.
01-20 17:17:55.111+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:17:55.111+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:18:01.621+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:18:01.621+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:18:11.776+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:18:11.901+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 12
01-20 17:18:11.901+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:18:11.901+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:18:11.901+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:18:11.971+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 11.
01-20 17:18:11.971+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:18:11.971+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:18:20.261+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:18:20.266+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:18:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:18:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:18:23.426+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:18:23.426+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:18:23.436+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:18:23.436+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:18:23.461+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 17:18:23 5일 전[0;m
01-20 17:18:23.466+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 17:18:23.476+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:18:23.481+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:18:23.481+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:18:23.481+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:18:23.481+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 17:18:28.676+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:18:28.801+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 11
01-20 17:18:28.806+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:18:28.806+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:18:28.806+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:18:28.856+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 10.
01-20 17:18:28.856+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:18:28.861+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:18:44.326+0900 I/efl-extension(18976): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:18:44.326+0900 I/efl-extension(18976): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c75ba8, elm_image, time_stamp : 9128235
01-20 17:18:44.331+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:18:44.331+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:18:44.331+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
01-20 17:18:45.661+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:18:45.771+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 10
01-20 17:18:45.771+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:18:45.771+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:18:45.771+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:18:45.816+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 8.
01-20 17:18:45.816+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:18:45.816+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:19:01.666+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:19:01.666+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:19:02.231+0900 E/PKGMGR_SERVER(20051): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:19:02.321+0900 E/PKGMGR_SERVER(20051): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1551902991], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 17:19:02.326+0900 E/PKGMGR_SERVER(20053): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 17:19:02.331+0900 E/PKGMGR  (20045): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 17:19:02.406+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:19:02.411+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18958
01-20 17:19:02.416+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:19:02.421+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:19:02.421+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17773) is dead. cmd(5) is canceled
01-20 17:19:02.421+0900 E/PKGMGR_SERVER(20053): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-20 17:19:02.421+0900 E/PKGMGR_SERVER(20053): [0;m
01-20 17:19:02.421+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:19:02.426+0900 W/CAPI_WATCH_APPLICATION(18958): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 17:19:02.426+0900 D/stretch (18958): Destroy analog watch
01-20 17:19:02.426+0900 W/WATCH_CORE(18958): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 17:19:02.426+0900 E/WIDGET_PROVIDER_APP(18958): client.c: client_fini(1175) > Provider is not initialized
01-20 17:19:02.426+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 17:19:02.426+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 17:19:02.426+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(18958), cmd(4)
01-20 17:19:02.426+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:19:02.436+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18958
01-20 17:19:02.436+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 17:19:02.446+0900 I/efl-extension(18958): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 17:19:02.471+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:19:02.531+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 9
01-20 17:19:02.531+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:19:02.536+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:19:02.536+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:19:02.541+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:19:02.551+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 17:19:02.561+0900 E/PKGMGR_SERVER(20053): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 17:19:02.576+0900 E/PKGMGR_SERVER(20051): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20053]
01-20 17:19:02.586+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 7.
01-20 17:19:02.586+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:19:02.586+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:19:02.661+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 17:19:02.661+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(18958), cmd(4)
01-20 17:19:02.666+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 17:19:02.701+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:19:02.731+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:19:02.731+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 17:19:02.731+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 17:19:02.756+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 17:19:02.756+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 17:19:02.756+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 17:19:02.831+0900 I/efl-extension(19805): efl_extension.c: eext_mod_init(40) > Init
01-20 17:19:02.836+0900 I/UXT     (19805): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 17:19:02.851+0900 I/CAPI_WATCH_APPLICATION(19805): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 17:19:02.866+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 18958
01-20 17:19:02.866+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 17:19:02.866+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 17:19:02.896+0900 E/TBM     (19805): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 17:19:02.941+0900 W/WATCH_CORE(19805): appcore-watch.c: __widget_create(958) > widget_create
01-20 17:19:02.941+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [7186.330566] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_7186.330566.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263204:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:19:02.941+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[7186.330566] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_7186.330566.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263204:4] gbar_fname[]
01-20 17:19:02.941+0900 D/stretch (19805): Create analog watch
01-20 17:19:02.946+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [7186.330566] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_7186.330566.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263204:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:19:02.946+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[7186.330566] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_7186.330566.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263204:4] gbar_fname[]
01-20 17:19:02.956+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 17:19:02.956+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 17:19:03.016+0900 D/stretch (19805): Time : 5 : 19 : 3
01-20 17:19:03.016+0900 W/WATCH_CORE(19805): appcore-watch.c: __widget_create(976) > widget_create done
01-20 17:19:03.091+0900 I/WATCH_CORE(19805): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 17:19:03.091+0900 I/WATCH_CORE(19805): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 17:19:03.091+0900 I/WATCH_CORE(19805): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 17:19:03.126+0900 E/EFL     (19805): edje<19805> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 17:19:03.861+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 17:19:03.861+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 17:19:03.891+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:19:03.896+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19805
01-20 17:19:03.896+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:19:03.906+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19805
01-20 17:19:03.906+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:19:03.911+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:19:04.091+0900 E/PKGMGR_SERVER(20051): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 17:19:04.091+0900 E/PKGMGR_SERVER(20051): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 17:19:04.106+0900 I/AUL_PAD (20066): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 17:19:04.431+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 17:19:19.611+0900 I/WIFI_EFL_SDK(18976): app_main.c: __wifi_manager_background_scan_cb(580) > [Enter]
01-20 17:19:19.831+0900 E/PKGMGR  (20198): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 17:19:19.846+0900 I/CAPI_NETWORK_WIFI(18976): libnetwork.c: __libnet_update_profile_iterator(224) > Wi-Fi profile count: 7
01-20 17:19:19.846+0900 I/WIFI_EFL_SDK(18976): wifi_manager.c: __update_ap_list_foreach(311) > EAP type AP skip(No SIM model).
01-20 17:19:19.851+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_update(433) > [Enter]
01-20 17:19:19.851+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(280) > [Enter]
01-20 17:19:19.901+0900 I/WIFI_EFL_SDK(18976): layout_scan.c: _ap_list_update_ap_items(300) > ap list update items count 6.
01-20 17:19:19.901+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
01-20 17:19:19.981+0900 E/WIFI_EFL_SDK(18976): layout_scan.c: layout_scan_ap_list_show(411) > '!_is_in_naviframe(self)' failed.
01-20 17:19:20.011+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:19:20.161+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1534158554], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-1534158554' '-r' 'org.tizen.stretchtime'], cookie=[C8TNHRbpEpA05569qOWQLjL88Zc=], backend_flag=[0]
01-20 17:19:20.161+0900 E/PKGMGR  (20200): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 17:19:20.161+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 17:19:20.166+0900 E/PKGMGR  (20198): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[201980002]
01-20 17:19:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:19:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:19:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:19:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:19:21.826+0900 E/PKGMGR_SERVER(20205): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 17:19:22.091+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 17:19:22.191+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 17:19:22.191+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 17:19:22.221+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 17:19:22.441+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 17:19:23.416+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:19:23.416+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:19:23.416+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:19:23.416+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:19:23.421+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 17:19:23 5일 전[0;m
01-20 17:19:23.421+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 17:19:23.421+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:19:23.421+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:19:23.421+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:19:23.421+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:19:23.421+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 17:19:24.091+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 17:19:24.801+0900 E/rpm-installer(20205): coretpk-parser.c: __coretpk_parser_check_ese_metadata(749) > (ret == 1) metadata(watchface) is empty.
01-20 17:19:24.801+0900 E/rpm-installer(20205): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
01-20 17:19:24.801+0900 E/rpm-installer(20205): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
01-20 17:19:24.801+0900 E/rpm-installer(20205): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(272) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
01-20 17:19:24.821+0900 E/PKGMGR_PARSER(20205): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2107) > Manifest is Valid
01-20 17:19:24.856+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
01-20 17:19:24.861+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
01-20 17:19:24.876+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
01-20 17:19:25.046+0900 I/PRIVACY-MANAGER-CLIENT(20205): SocketClient.cpp: SocketClient(37) > Client created
01-20 17:19:25.051+0900 I/PRIVACY-MANAGER-CLIENT(20205): SocketStream.h: SocketStream(31) > Created
01-20 17:19:25.051+0900 I/PRIVACY-MANAGER-CLIENT(20205): SocketConnection.h: SocketConnection(44) > Created
01-20 17:19:25.051+0900 I/PRIVACY-MANAGER-CLIENT(20205): SocketClient.cpp: connect(62) > Client connected
01-20 17:19:25.091+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: mainloop(227) > Got incoming connection
01-20 17:19:25.096+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: connectionThread(253) > Starting connection thread
01-20 17:19:25.096+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketStream.h: SocketStream(31) > Created
01-20 17:19:25.096+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketConnection.h: SocketConnection(44) > Created
01-20 17:19:25.121+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: connectionService(304) > Calling service
01-20 17:19:25.156+0900 I/PRIVACY-MANAGER-CLIENT(20205): SocketClient.cpp: disconnect(72) > Client disconnected
01-20 17:19:25.161+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: connectionService(307) > Removing client
01-20 17:19:25.161+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: connectionService(311) > Call served
01-20 17:19:25.161+0900 I/PRIVACY-MANAGER-SERVER(  459): SocketService.cpp: connectionThread(262) > Client serviced
01-20 17:19:25.426+0900 I/efl-extension(20205): efl_extension.c: eext_mod_init(40) > Init
01-20 17:19:25.426+0900 I/efl-extension(20205): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 17:19:25.626+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
01-20 17:19:25.636+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 98
01-20 17:19:25.641+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 98
01-20 17:19:25.641+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 16 3
01-20 17:19:25.646+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 17 3
01-20 17:19:25.646+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 3
01-20 17:19:25.651+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 3
01-20 17:19:25.681+0900 E/PKGMGR_CERT(20205): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
01-20 17:19:25.681+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 17:19:26.091+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 17:19:27.736+0900 E/rpm-installer(20205): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
01-20 17:19:28.091+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 17:19:30.091+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 17:19:30.936+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.tizen.stretchtime is updated, need to check validation
01-20 17:19:30.936+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.tizen.stretchtime
01-20 17:19:30.941+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 17:19:30.946+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
01-20 17:19:30.946+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
01-20 17:19:30.946+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
01-20 17:19:30.946+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
01-20 17:19:31.031+0900 E/PKGMGR_INFO(  513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
01-20 17:19:31.031+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.tizen.stretchtime is updated, preload:0 update:1 event->update:0
01-20 17:19:31.036+0900 E/PKGMGR_SERVER(20200): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20205]
01-20 17:19:31.071+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
01-20 17:19:31.436+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 17:19:31.446+0900 E/AUL     (  519): app_sock.c: __connect_client_sock(194) > connect error: 111
01-20 17:19:31.446+0900 E/AUL     (  519): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
01-20 17:19:31.546+0900 E/AUL     (  519): app_sock.c: __connect_client_sock(194) > connect error: 111
01-20 17:19:31.551+0900 E/AUL     (  519): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
01-20 17:19:31.551+0900 E/RESOURCED(  521): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/19805/oom_score_adj failed
01-20 17:19:31.551+0900 E/RESOURCED(  521): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 19805
01-20 17:19:31.601+0900 W/CRASH_MANAGER(20220): worker.c: worker_job(1199) > 1119805737472145327797
