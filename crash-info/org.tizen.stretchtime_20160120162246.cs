S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 17946
Date: 2016-01-20 16:22:46+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20

Register Information
r0   = 0x00000000, r1   = 0x44b3b920
r2   = 0x44b3b920, r3   = 0x00000000
r4   = 0x44b3b920, r5   = 0x418e9cb0
r6   = 0x418e7320, r7   = 0xbeb921e8
r8   = 0x44b535f0, r9   = 0x44b3b920
r10  = 0xbeb92298, fp   = 0x00000000
ip   = 0x402243d1, sp   = 0xbeb921d0
lr   = 0x400f2973, pc   = 0x419a578e
cpsr = 0x00000030

Memory Information
MemTotal:   491012 KB
MemFree:     25064 KB
Buffers:     11576 KB
Cached:     112376 KB
VmPeak:      90944 KB
VmSize:      89924 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18320 KB
VmRSS:       18320 KB
VmData:      31388 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23864 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17946 TID = 17946
17946 18025 18031 

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
41a9b000 41aa2000 r-xp /usr/lib/libappcore-watch.so.1.1
41aab000 41ab0000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41ab8000 41abc000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41ac5000 41acd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41ace000 41aee000 r-xp /usr/lib/libefl-extension.so.0.1.0
41aef000 41afc000 r-xp /usr/lib/libalarm.so.0.0.0
41b05000 41c42000 r-xp /usr/lib/libicui18n.so.51.1
41c52000 41d36000 r-xp /usr/lib/libicuuc.so.51.1
41d4b000 41d51000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41d59000 41d5f000 r-xp /usr/lib/libwidget.so.1.0.0
41d68000 41d6d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41d75000 41d93000 r-xp /usr/lib/libsensor.so.1.1.0
41d9d000 41daf000 r-xp /usr/lib/libefl-assist.so.0.1.0
41db7000 41e6f000 r-xp /usr/lib/libcairo.so.2.11200.14
43401000 4340a000 r-xp /usr/lib/libcom-core.so.0.0.1
43413000 4341f000 r-xp /usr/lib/libwidget_service.so.1.0.0
43427000 43430000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43439000 43440000 r-xp /usr/lib/libsensord-share.so
43448000 4345a000 r-xp /usr/lib/libtts.so
43462000 43483000 r-xp /usr/lib/libui-extension.so.0.1.0
4348c000 43493000 r-xp /usr/lib/libtbm.so.1.0.0
4349b000 434a9000 r-xp /usr/lib/libGLESv2.so.2.0
434b2000 434b3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
434bc000 434c2000 r-xp /usr/lib/libxcb-render.so.0.0.0
434ca000 434cd000 r-xp /usr/lib/libEGL.so.1.4
434d5000 434dd000 r-xp /usr/lib/libdrm.so.2.4.0
434e5000 434e7000 r-xp /usr/lib/libdri2.so.0.0.0
434ef000 434f2000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
434fa000 434ff000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43508000 4350d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43515000 43536000 r-xp /usr/lib/libexif.so.12.3.3
43549000 4354e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43556000 43620000 r-xp /usr/lib/libCOREGL.so.4.0
43965000 44164000 rwxp [stack:18025]
44164000 44167000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4416f000 4417a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4429e000 44a9d000 rwxp [stack:18031]
44a9d000 44aa8000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
44ab0000 44ac7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44ad4000 44ad6000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44ade000 44adf000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
beb72000 beb93000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17946)
Call Stack Count: 1
 0: naviframe_pop_cb + 0x11 (0x419a578e) [/opt/usr/apps/org.tizen.stretchtime/bin/stretchtime] + 0x3478e
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
_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:20.006+0900 D/stretch (17869): Time : 4 : 22 : 20
01-20 16:22:20.230+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:22:20.230+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:22:20.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:22:20.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:22:21.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:21.006+0900 D/stretch (17869): Time : 4 : 22 : 21
01-20 16:22:22.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:22.000+0900 D/stretch (17869): Time : 4 : 22 : 22
01-20 16:22:23.001+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:23.005+0900 D/stretch (17869): Time : 4 : 22 : 23
01-20 16:22:23.355+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:22:23.355+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:22:23.365+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:22:23.365+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:22:23.395+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 16:22:23 5일 전[0;m
01-20 16:22:23.405+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 16:22:23.410+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:22:23.410+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:22:23.410+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:22:23.410+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:22:23.420+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 16:22:24.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:24.005+0900 D/stretch (17869): Time : 4 : 22 : 24
01-20 16:22:25.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:25.006+0900 D/stretch (17869): Time : 4 : 22 : 25
01-20 16:22:26.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:26.005+0900 D/stretch (17869): Time : 4 : 22 : 26
01-20 16:22:27.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:27.005+0900 D/stretch (17869): Time : 4 : 22 : 27
01-20 16:22:28.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:28.006+0900 D/stretch (17869): Time : 4 : 22 : 28
01-20 16:22:29.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:29.006+0900 D/stretch (17869): Time : 4 : 22 : 29
01-20 16:22:30.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:30.010+0900 D/stretch (17869): Time : 4 : 22 : 30
01-20 16:22:31.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:31.006+0900 D/stretch (17869): Time : 4 : 22 : 31
01-20 16:22:32.001+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:32.001+0900 D/stretch (17869): Time : 4 : 22 : 32
01-20 16:22:33.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:33.005+0900 D/stretch (17869): Time : 4 : 22 : 33
01-20 16:22:34.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:34.005+0900 D/stretch (17869): Time : 4 : 22 : 34
01-20 16:22:35.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:35.005+0900 D/stretch (17869): Time : 4 : 22 : 35
01-20 16:22:36.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:36.000+0900 D/stretch (17869): Time : 4 : 22 : 36
01-20 16:22:37.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:37.000+0900 D/stretch (17869): Time : 4 : 22 : 37
01-20 16:22:38.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:38.005+0900 D/stretch (17869): Time : 4 : 22 : 38
01-20 16:22:39.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:39.006+0900 D/stretch (17869): Time : 4 : 22 : 39
01-20 16:22:39.080+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
01-20 16:22:39.100+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:22:39.100+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(185) ev->cur.canvas.y(160)
01-20 16:22:39.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:22:39.120+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5762993 button=1 downs=1
01-20 16:22:39.125+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:22:39.125+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(182) ev->cur.canvas.y(159)
01-20 16:22:39.125+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:22:39.130+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:22:39.130+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(183) ev->cur.canvas.y(159)
01-20 16:22:39.130+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:22:39.140+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5763052 button=1 downs=0
01-20 16:22:39.150+0900 E/EFL     (17869): evas_main<17869> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5763036 button=1 downs=1
01-20 16:22:39.160+0900 E/EFL     (17869): evas_main<17869> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5763059 button=1 downs=0
01-20 16:22:39.160+0900 D/stretch (17869): clicked!!
01-20 16:22:39.400+0900 E/E17     (  365): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06e0002f)
01-20 16:22:39.430+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
01-20 16:22:39.430+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.430+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.435+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.435+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
01-20 16:22:39.435+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-20 16:22:39.550+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(1)
01-20 16:22:39.550+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
01-20 16:22:39.550+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.550+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(1)
01-20 16:22:39.550+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
01-20 16:22:39.550+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
01-20 16:22:39.550+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
01-20 16:22:39.550+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
01-20 16:22:39.550+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.555+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.555+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
01-20 16:22:39.555+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:22:39.555+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:39.555+0900 E/CAPI_APPFW_APP_CONTROL( 1027): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-20 16:22:39.555+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1027]   value = [false][0m
01-20 16:22:39.560+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:39.570+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 812
01-20 16:22:39.645+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
01-20 16:22:39.645+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 16:22:39.655+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:22:39.655+0900 W/AUL_AMD (  519): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-20 16:22:39.700+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
01-20 16:22:39.705+0900 W/WATCH_CORE(17869): appcore-watch.c: __widget_pause(1001) > widget_pause
01-20 16:22:40.060+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
01-20 16:22:40.500+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=41   flick_area=55 ---> SET value to 1
01-20 16:22:40.500+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
01-20 16:22:40.500+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=41   flick_area=55 ---> SET value to 1
01-20 16:22:40.570+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
01-20 16:22:40.880+0900 W/CRASH_MANAGER(18009): worker.c: worker_job(1199) > 11178697374721453274560
01-20 16:22:40.965+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 16:22:40.970+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17869) is dead. cmd(4) is canceled
01-20 16:22:40.970+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 16:22:40.985+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:22:41.000+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:22:41.000+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 16:22:41.000+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 16:22:41.015+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 16:22:41.015+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 16:22:41.015+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 16:22:41.030+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
01-20 16:22:41.070+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
01-20 16:22:41.070+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.070+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.075+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.075+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
01-20 16:22:41.085+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(0)
01-20 16:22:41.085+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
01-20 16:22:41.090+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.090+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(0)
01-20 16:22:41.090+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
01-20 16:22:41.115+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-20 16:22:41.115+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
01-20 16:22:41.115+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
01-20 16:22:41.115+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.115+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.115+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
01-20 16:22:41.115+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
01-20 16:22:41.120+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:41.145+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
01-20 16:22:41.145+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 16:22:41.150+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 16:22:41.150+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-20 16:22:41.195+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 16:22:41.195+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 16:22:41.220+0900 I/efl-extension(17946): efl_extension.c: eext_mod_init(40) > Init
01-20 16:22:41.220+0900 I/UXT     (17946): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 16:22:41.250+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 16:22:41.285+0900 E/TBM     (17946): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 16:22:41.330+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:22:41.330+0900 W/AUL_AMD (  519): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-20 16:22:41.330+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 17869
01-20 16:22:41.405+0900 W/WATCH_CORE(17946): appcore-watch.c: __widget_create(958) > widget_create
01-20 16:22:41.405+0900 D/stretch (17946): Create analog watch
01-20 16:22:41.405+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263176:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:22:41.405+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263176:4] gbar_fname[]
01-20 16:22:41.410+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263176:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:22:41.410+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263176:4] gbar_fname[]
01-20 16:22:41.430+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:22:41.430+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:22:41.490+0900 D/stretch (17946): Time : 4 : 22 : 41
01-20 16:22:41.490+0900 W/WATCH_CORE(17946): appcore-watch.c: __widget_create(976) > widget_create done
01-20 16:22:41.580+0900 I/WATCH_CORE(17946): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 16:22:41.580+0900 I/WATCH_CORE(17946): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 16:22:41.580+0900 I/WATCH_CORE(17946): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 16:22:41.605+0900 E/EFL     (17946): edje<17946> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 16:22:41.615+0900 W/WATCH_CORE(17946): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 16:22:41.645+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:41.650+0900 D/stretch (17946): Time : 4 : 22 : 41
01-20 16:22:42.000+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:42.000+0900 D/stretch (17946): Time : 4 : 22 : 42
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:22:42.125+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.125+0900 E/CAPI_APPFW_APP_CONTROL( 1027): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-20 16:22:42.125+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1027]   value = [true][0m
01-20 16:22:42.130+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:42.135+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 812
01-20 16:22:42.135+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:42.140+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
01-20 16:22:42.145+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 16:22:42.145+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 16:22:42.145+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 16:22:42.145+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 16:22:42.145+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 16:22:42.145+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.145+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.145+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.145+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:22:42.150+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.150+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 16:22:42.150+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 16:22:42.150+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 16:22:42.155+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 16:22:42.155+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 16:22:42.155+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 16:22:42.155+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:22:42.155+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:42.155+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 16:22:42.155+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 16:22:42.355+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:42.360+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17946
01-20 16:22:42.365+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:22:42.560+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:42.565+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17946
01-20 16:22:42.575+0900 I/AUL_PAD (18034): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 16:22:42.605+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:22:43.000+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:43.000+0900 D/stretch (17946): Time : 4 : 22 : 43
01-20 16:22:44.000+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:44.000+0900 D/stretch (17946): Time : 4 : 22 : 44
01-20 16:22:44.815+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
01-20 16:22:44.820+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:22:44.820+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(223) ev->cur.canvas.y(179)
01-20 16:22:44.820+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:22:44.820+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5768727 button=1 downs=1
01-20 16:22:44.835+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:22:44.835+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(224) ev->cur.canvas.y(179)
01-20 16:22:44.835+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:22:44.840+0900 E/EFL     (17946): evas_main<17946> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5768732 button=1 downs=1
01-20 16:22:44.860+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5768769 button=1 downs=0
01-20 16:22:44.875+0900 E/EFL     (17946): evas_main<17946> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5768772 button=1 downs=0
01-20 16:22:44.875+0900 D/stretch (17946): clicked!!
01-20 16:22:45.095+0900 E/E17     (  365): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x01400007)
01-20 16:22:45.155+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
01-20 16:22:45.160+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.160+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.165+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.165+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
01-20 16:22:45.165+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-20 16:22:45.185+0900 I/CAPI_WATCH_APPLICATION(17946): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:45.185+0900 D/stretch (17946): Time : 4 : 22 : 45
01-20 16:22:45.195+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b7560] swap changed from sync to async
01-20 16:22:45.260+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(1)
01-20 16:22:45.260+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
01-20 16:22:45.260+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.260+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(1)
01-20 16:22:45.265+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:22:45.265+0900 W/AUL_AMD (  519): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-20 16:22:45.275+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
01-20 16:22:45.275+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
01-20 16:22:45.275+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
01-20 16:22:45.275+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
01-20 16:22:45.275+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.275+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.275+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
01-20 16:22:45.275+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:22:45.280+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:22:45.285+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:22:45.285+0900 E/CAPI_APPFW_APP_CONTROL( 1027): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-20 16:22:45.285+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1027]   value = [false][0m
01-20 16:22:45.285+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:22:45.290+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 812
01-20 16:22:45.390+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
01-20 16:22:45.390+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 16:22:45.400+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
01-20 16:22:45.405+0900 W/WATCH_CORE(17946): appcore-watch.c: __widget_pause(1001) > widget_pause
01-20 16:22:45.785+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
01-20 16:22:46.450+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=36   flick_area=55 ---> SET value to 1
01-20 16:22:46.450+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
01-20 16:22:46.450+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=36   flick_area=55 ---> SET value to 1
01-20 16:22:46.515+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
01-20 16:22:46.515+0900 E/EFL     (17946): evas_main<17946> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5770362 button=1 downs=1
01-20 16:22:46.515+0900 E/EFL     (17946): evas_main<17946> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5770426 button=1 downs=0
01-20 16:22:46.545+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=37   flick_area=55 ---> SET value to 1
01-20 16:22:46.545+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
01-20 16:22:46.545+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=37   flick_area=55 ---> SET value to 1
01-20 16:22:46.580+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
01-20 16:22:46.710+0900 W/CRASH_MANAGER(18009): worker.c: worker_job(1199) > 1117946737472145327456
