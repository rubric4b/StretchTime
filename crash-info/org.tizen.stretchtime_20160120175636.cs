S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 21637
Date: 2016-01-20 17:56:36+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x7fff80a4

Register Information
r0   = 0x414dda08, r1   = 0x41a55280
r2   = 0x7fff80a0, r3   = 0x000053f4
r4   = 0x419a7ada, r5   = 0x414dda08
r6   = 0x40032048, r7   = 0x40599000
r8   = 0x41971000, r9   = 0x00000000
r10  = 0x00000000, fp   = 0x000053f4
ip   = 0xbe88d654, sp   = 0xbe88d408
lr   = 0x40092fa4, pc   = 0x4056e0bc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     11120 KB
Buffers:      7620 KB
Cached:     126564 KB
VmPeak:      80396 KB
VmSize:      79888 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16772 KB
VmRSS:       16772 KB
VmData:      23400 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23720 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21637 TID = 21637
21637 22112 22117 

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
43966000 44165000 rwxp [stack:22112]
44165000 44168000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44170000 4417b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4429f000 44a9e000 rwxp [stack:22117]
be872000 be893000 rwxp [stack]
End of Maps Information

Callstack Information (PID:21637)
Call Stack Count: 1
 0: _dl_addr + 0x260 (0x4056e0bc) [/lib/libc.so.6] + 0xfa0bc
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
31+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 17:53:44.631+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 17:53:44.631+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 17:53:44.631+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 17:53:44.646+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 17:53:44.646+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 17:53:44.646+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 17:53:44.646+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 17:53:44.661+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 17:53:44.661+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 17:53:44.671+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 17:53:44.671+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c89c38 : elm_scroller] CurrentPage(1)
01-20 17:53:44.806+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
01-20 17:53:44.996+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:44.996+0900 D/stretch (20982): Time : 5 : 53 : 45
01-20 17:53:45.171+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
01-20 17:53:46.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:46.001+0900 D/stretch (20982): Time : 5 : 53 : 46
01-20 17:53:47.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:47.006+0900 D/stretch (20982): Time : 5 : 53 : 47
01-20 17:53:48.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:48.006+0900 D/stretch (20982): Time : 5 : 53 : 48
01-20 17:53:49.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:49.001+0900 D/stretch (20982): Time : 5 : 53 : 49
01-20 17:53:50.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:50.006+0900 D/stretch (20982): Time : 5 : 53 : 50
01-20 17:53:51.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:51.001+0900 D/stretch (20982): Time : 5 : 53 : 51
01-20 17:53:52.016+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:52.016+0900 D/stretch (20982): Time : 5 : 53 : 52
01-20 17:53:53.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:53.001+0900 D/stretch (20982): Time : 5 : 53 : 53
01-20 17:53:54.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:54.006+0900 D/stretch (20982): Time : 5 : 53 : 54
01-20 17:53:55.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:55.006+0900 D/stretch (20982): Time : 5 : 53 : 55
01-20 17:53:56.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:56.011+0900 D/stretch (20982): Time : 5 : 53 : 56
01-20 17:53:57.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:57.011+0900 D/stretch (20982): Time : 5 : 53 : 57
01-20 17:53:58.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:58.001+0900 D/stretch (20982): Time : 5 : 53 : 58
01-20 17:53:59.016+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:53:59.016+0900 D/stretch (20982): Time : 5 : 53 : 59
01-20 17:54:00.016+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:00.021+0900 D/stretch (20982): Time : 5 : 54 : 0
01-20 17:54:01.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:01.006+0900 D/stretch (20982): Time : 5 : 54 : 1
01-20 17:54:01.661+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:54:01.661+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:54:01.706+0900 I/RESOURCED(  521): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] battery cache is empty
01-20 17:54:02.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:02.001+0900 D/stretch (20982): Time : 5 : 54 : 2
01-20 17:54:03.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:03.006+0900 D/stretch (20982): Time : 5 : 54 : 3
01-20 17:54:04.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:04.011+0900 D/stretch (20982): Time : 5 : 54 : 4
01-20 17:54:05.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:05.006+0900 D/stretch (20982): Time : 5 : 54 : 5
01-20 17:54:06.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:06.011+0900 D/stretch (20982): Time : 5 : 54 : 6
01-20 17:54:07.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:07.001+0900 D/stretch (20982): Time : 5 : 54 : 7
01-20 17:54:08.016+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:08.021+0900 D/stretch (20982): Time : 5 : 54 : 8
01-20 17:54:09.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:09.006+0900 D/stretch (20982): Time : 5 : 54 : 9
01-20 17:54:10.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:10.011+0900 D/stretch (20982): Time : 5 : 54 : 10
01-20 17:54:11.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:11.006+0900 D/stretch (20982): Time : 5 : 54 : 11
01-20 17:54:12.031+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:12.031+0900 D/stretch (20982): Time : 5 : 54 : 12
01-20 17:54:13.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:13.006+0900 D/stretch (20982): Time : 5 : 54 : 13
01-20 17:54:14.016+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:14.016+0900 D/stretch (20982): Time : 5 : 54 : 14
01-20 17:54:15.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:15.006+0900 D/stretch (20982): Time : 5 : 54 : 15
01-20 17:54:16.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:16.006+0900 D/stretch (20982): Time : 5 : 54 : 16
01-20 17:54:17.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:17.006+0900 D/stretch (20982): Time : 5 : 54 : 17
01-20 17:54:18.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:18.006+0900 D/stretch (20982): Time : 5 : 54 : 18
01-20 17:54:19.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:19.006+0900 D/stretch (20982): Time : 5 : 54 : 19
01-20 17:54:20.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:20.011+0900 D/stretch (20982): Time : 5 : 54 : 20
01-20 17:54:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:54:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:54:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:54:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:54:21.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:21.006+0900 D/stretch (20982): Time : 5 : 54 : 21
01-20 17:54:22.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:22.001+0900 D/stretch (20982): Time : 5 : 54 : 22
01-20 17:54:23.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:23.006+0900 D/stretch (20982): Time : 5 : 54 : 23
01-20 17:54:24.021+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:24.021+0900 D/stretch (20982): Time : 5 : 54 : 24
01-20 17:54:25.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:25.011+0900 D/stretch (20982): Time : 5 : 54 : 25
01-20 17:54:26.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:26.006+0900 D/stretch (20982): Time : 5 : 54 : 26
01-20 17:54:27.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:27.006+0900 D/stretch (20982): Time : 5 : 54 : 27
01-20 17:54:28.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:28.011+0900 D/stretch (20982): Time : 5 : 54 : 28
01-20 17:54:29.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:29.006+0900 D/stretch (20982): Time : 5 : 54 : 29
01-20 17:54:30.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:30.006+0900 D/stretch (20982): Time : 5 : 54 : 30
01-20 17:54:31.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:31.005+0900 D/stretch (20982): Time : 5 : 54 : 31
01-20 17:54:32.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:32.000+0900 D/stretch (20982): Time : 5 : 54 : 32
01-20 17:54:33.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:33.006+0900 D/stretch (20982): Time : 5 : 54 : 33
01-20 17:54:34.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:34.011+0900 D/stretch (20982): Time : 5 : 54 : 34
01-20 17:54:35.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:35.006+0900 D/stretch (20982): Time : 5 : 54 : 35
01-20 17:54:36.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:36.011+0900 D/stretch (20982): Time : 5 : 54 : 36
01-20 17:54:37.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:37.001+0900 D/stretch (20982): Time : 5 : 54 : 37
01-20 17:54:38.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:38.011+0900 D/stretch (20982): Time : 5 : 54 : 38
01-20 17:54:39.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:39.006+0900 D/stretch (20982): Time : 5 : 54 : 39
01-20 17:54:40.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:40.006+0900 D/stretch (20982): Time : 5 : 54 : 40
01-20 17:54:41.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:41.005+0900 D/stretch (20982): Time : 5 : 54 : 41
01-20 17:54:42.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:42.006+0900 D/stretch (20982): Time : 5 : 54 : 42
01-20 17:54:43.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:43.011+0900 D/stretch (20982): Time : 5 : 54 : 43
01-20 17:54:44.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:44.006+0900 D/stretch (20982): Time : 5 : 54 : 44
01-20 17:54:45.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:45.006+0900 D/stretch (20982): Time : 5 : 54 : 45
01-20 17:54:46.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:46.010+0900 D/stretch (20982): Time : 5 : 54 : 46
01-20 17:54:47.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:47.005+0900 D/stretch (20982): Time : 5 : 54 : 47
01-20 17:54:48.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:48.005+0900 D/stretch (20982): Time : 5 : 54 : 48
01-20 17:54:49.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:49.006+0900 D/stretch (20982): Time : 5 : 54 : 49
01-20 17:54:50.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:50.006+0900 D/stretch (20982): Time : 5 : 54 : 50
01-20 17:54:51.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:51.006+0900 D/stretch (20982): Time : 5 : 54 : 51
01-20 17:54:52.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:52.001+0900 D/stretch (20982): Time : 5 : 54 : 52
01-20 17:54:53.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:53.006+0900 D/stretch (20982): Time : 5 : 54 : 53
01-20 17:54:54.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:54.011+0900 D/stretch (20982): Time : 5 : 54 : 54
01-20 17:54:55.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:55.011+0900 D/stretch (20982): Time : 5 : 54 : 55
01-20 17:54:56.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:56.011+0900 D/stretch (20982): Time : 5 : 54 : 56
01-20 17:54:57.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:57.001+0900 D/stretch (20982): Time : 5 : 54 : 57
01-20 17:54:58.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:58.011+0900 D/stretch (20982): Time : 5 : 54 : 58
01-20 17:54:59.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:54:59.006+0900 D/stretch (20982): Time : 5 : 54 : 59
01-20 17:55:00.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:00.006+0900 D/stretch (20982): Time : 5 : 55 : 0
01-20 17:55:01.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:01.006+0900 D/stretch (20982): Time : 5 : 55 : 1
01-20 17:55:01.616+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:55:01.621+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:55:02.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:02.001+0900 D/stretch (20982): Time : 5 : 55 : 2
01-20 17:55:03.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:03.006+0900 D/stretch (20982): Time : 5 : 55 : 3
01-20 17:55:04.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:04.006+0900 D/stretch (20982): Time : 5 : 55 : 4
01-20 17:55:05.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:05.006+0900 D/stretch (20982): Time : 5 : 55 : 5
01-20 17:55:06.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:06.011+0900 D/stretch (20982): Time : 5 : 55 : 6
01-20 17:55:07.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:07.000+0900 D/stretch (20982): Time : 5 : 55 : 7
01-20 17:55:08.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:08.005+0900 D/stretch (20982): Time : 5 : 55 : 8
01-20 17:55:09.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:09.005+0900 D/stretch (20982): Time : 5 : 55 : 9
01-20 17:55:10.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:10.011+0900 D/stretch (20982): Time : 5 : 55 : 10
01-20 17:55:11.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:11.011+0900 D/stretch (20982): Time : 5 : 55 : 11
01-20 17:55:12.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:12.001+0900 D/stretch (20982): Time : 5 : 55 : 12
01-20 17:55:13.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:13.006+0900 D/stretch (20982): Time : 5 : 55 : 13
01-20 17:55:14.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:14.006+0900 D/stretch (20982): Time : 5 : 55 : 14
01-20 17:55:15.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:15.006+0900 D/stretch (20982): Time : 5 : 55 : 15
01-20 17:55:16.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:16.005+0900 D/stretch (20982): Time : 5 : 55 : 16
01-20 17:55:17.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:17.016+0900 D/stretch (20982): Time : 5 : 55 : 17
01-20 17:55:18.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:18.005+0900 D/stretch (20982): Time : 5 : 55 : 18
01-20 17:55:19.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:19.006+0900 D/stretch (20982): Time : 5 : 55 : 19
01-20 17:55:20.000+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:20.005+0900 D/stretch (20982): Time : 5 : 55 : 20
01-20 17:55:20.206+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:55:20.206+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:55:20.216+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:55:20.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:55:21.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:21.006+0900 D/stretch (20982): Time : 5 : 55 : 21
01-20 17:55:22.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:22.006+0900 D/stretch (20982): Time : 5 : 55 : 22
01-20 17:55:23.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:23.011+0900 D/stretch (20982): Time : 5 : 55 : 23
01-20 17:55:24.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:24.006+0900 D/stretch (20982): Time : 5 : 55 : 24
01-20 17:55:25.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:25.006+0900 D/stretch (20982): Time : 5 : 55 : 25
01-20 17:55:26.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:26.006+0900 D/stretch (20982): Time : 5 : 55 : 26
01-20 17:55:27.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:27.006+0900 D/stretch (20982): Time : 5 : 55 : 27
01-20 17:55:28.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:28.010+0900 D/stretch (20982): Time : 5 : 55 : 28
01-20 17:55:29.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:29.006+0900 D/stretch (20982): Time : 5 : 55 : 29
01-20 17:55:30.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:30.011+0900 D/stretch (20982): Time : 5 : 55 : 30
01-20 17:55:31.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:31.006+0900 D/stretch (20982): Time : 5 : 55 : 31
01-20 17:55:32.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:32.006+0900 D/stretch (20982): Time : 5 : 55 : 32
01-20 17:55:33.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:33.006+0900 D/stretch (20982): Time : 5 : 55 : 33
01-20 17:55:34.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:34.006+0900 D/stretch (20982): Time : 5 : 55 : 34
01-20 17:55:35.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:35.006+0900 D/stretch (20982): Time : 5 : 55 : 35
01-20 17:55:36.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:36.006+0900 D/stretch (20982): Time : 5 : 55 : 36
01-20 17:55:37.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:37.006+0900 D/stretch (20982): Time : 5 : 55 : 37
01-20 17:55:38.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:38.006+0900 D/stretch (20982): Time : 5 : 55 : 38
01-20 17:55:39.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:39.006+0900 D/stretch (20982): Time : 5 : 55 : 39
01-20 17:55:40.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:40.006+0900 D/stretch (20982): Time : 5 : 55 : 40
01-20 17:55:41.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:41.011+0900 D/stretch (20982): Time : 5 : 55 : 41
01-20 17:55:42.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:42.001+0900 D/stretch (20982): Time : 5 : 55 : 42
01-20 17:55:43.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:43.016+0900 D/stretch (20982): Time : 5 : 55 : 43
01-20 17:55:44.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:44.006+0900 D/stretch (20982): Time : 5 : 55 : 44
01-20 17:55:45.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:45.005+0900 D/stretch (20982): Time : 5 : 55 : 45
01-20 17:55:46.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:46.005+0900 D/stretch (20982): Time : 5 : 55 : 46
01-20 17:55:47.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:47.005+0900 D/stretch (20982): Time : 5 : 55 : 47
01-20 17:55:48.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:48.011+0900 D/stretch (20982): Time : 5 : 55 : 48
01-20 17:55:49.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:49.006+0900 D/stretch (20982): Time : 5 : 55 : 49
01-20 17:55:50.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:50.006+0900 D/stretch (20982): Time : 5 : 55 : 50
01-20 17:55:51.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:51.006+0900 D/stretch (20982): Time : 5 : 55 : 51
01-20 17:55:52.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:52.001+0900 D/stretch (20982): Time : 5 : 55 : 52
01-20 17:55:53.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:53.006+0900 D/stretch (20982): Time : 5 : 55 : 53
01-20 17:55:54.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:54.006+0900 D/stretch (20982): Time : 5 : 55 : 54
01-20 17:55:55.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:55.011+0900 D/stretch (20982): Time : 5 : 55 : 55
01-20 17:55:56.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:56.005+0900 D/stretch (20982): Time : 5 : 55 : 56
01-20 17:55:57.011+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:57.016+0900 D/stretch (20982): Time : 5 : 55 : 57
01-20 17:55:58.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:58.006+0900 D/stretch (20982): Time : 5 : 55 : 58
01-20 17:55:59.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:55:59.011+0900 D/stretch (20982): Time : 5 : 55 : 59
01-20 17:56:00.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:00.006+0900 D/stretch (20982): Time : 5 : 56 : 0
01-20 17:56:01.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:01.006+0900 D/stretch (20982): Time : 5 : 56 : 1
01-20 17:56:01.681+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:56:01.681+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:56:02.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:02.001+0900 D/stretch (20982): Time : 5 : 56 : 2
01-20 17:56:03.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:03.006+0900 D/stretch (20982): Time : 5 : 56 : 3
01-20 17:56:04.005+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:04.010+0900 D/stretch (20982): Time : 5 : 56 : 4
01-20 17:56:05.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:05.006+0900 D/stretch (20982): Time : 5 : 56 : 5
01-20 17:56:06.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:06.006+0900 D/stretch (20982): Time : 5 : 56 : 6
01-20 17:56:07.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:07.001+0900 D/stretch (20982): Time : 5 : 56 : 7
01-20 17:56:08.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:08.011+0900 D/stretch (20982): Time : 5 : 56 : 8
01-20 17:56:09.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:09.006+0900 D/stretch (20982): Time : 5 : 56 : 9
01-20 17:56:10.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:10.006+0900 D/stretch (20982): Time : 5 : 56 : 10
01-20 17:56:11.006+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:11.006+0900 D/stretch (20982): Time : 5 : 56 : 11
01-20 17:56:12.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:12.001+0900 D/stretch (20982): Time : 5 : 56 : 12
01-20 17:56:13.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:13.001+0900 D/stretch (20982): Time : 5 : 56 : 13
01-20 17:56:14.010+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:14.010+0900 D/stretch (20982): Time : 5 : 56 : 14
01-20 17:56:15.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:15.006+0900 D/stretch (20982): Time : 5 : 56 : 15
01-20 17:56:16.010+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:16.010+0900 D/stretch (20982): Time : 5 : 56 : 16
01-20 17:56:17.001+0900 I/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:17.001+0900 D/stretch (20982): Time : 5 : 56 : 17
01-20 17:56:17.671+0900 E/PKGMGR_SERVER(22106): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:56:17.766+0900 E/PKGMGR_SERVER(22106): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_683492817], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 17:56:17.771+0900 E/PKGMGR_SERVER(22108): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 17:56:17.776+0900 E/PKGMGR  (22100): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 17:56:17.846+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:56:17.856+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20982
01-20 17:56:17.856+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:56:17.861+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:56:17.866+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17773) is dead. cmd(5) is canceled
01-20 17:56:17.866+0900 E/PKGMGR_SERVER(22108): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-20 17:56:17.866+0900 E/PKGMGR_SERVER(22108): [0;m
01-20 17:56:17.866+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:56:17.866+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(20982), cmd(4)
01-20 17:56:17.866+0900 W/CAPI_WATCH_APPLICATION(20982): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 17:56:17.866+0900 D/stretch (20982): Destroy analog watch
01-20 17:56:17.866+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 17:56:17.866+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 17:56:17.871+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:56:17.871+0900 W/WATCH_CORE(20982): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 17:56:17.871+0900 E/WIDGET_PROVIDER_APP(20982): client.c: client_fini(1175) > Provider is not initialized
01-20 17:56:17.876+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20982
01-20 17:56:17.881+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 17:56:17.886+0900 I/efl-extension(20982): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 17:56:17.981+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:56:18.001+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 17:56:18.026+0900 E/PKGMGR_SERVER(22108): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 17:56:18.071+0900 E/PKGMGR_SERVER(22106): pkgmgr-server.c: sighandler(445) > child NORMAL exit [22108]
01-20 17:56:18.111+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 17:56:18.111+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(20982), cmd(4)
01-20 17:56:18.126+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 17:56:18.186+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:56:18.226+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:56:18.226+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 17:56:18.226+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 17:56:18.256+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 17:56:18.256+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 17:56:18.256+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 17:56:18.286+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 3
01-20 17:56:18.291+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 17:56:18.341+0900 I/efl-extension(21637): efl_extension.c: eext_mod_init(40) > Init
01-20 17:56:18.341+0900 I/UXT     (21637): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 17:56:18.356+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 17:56:18.361+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20982
01-20 17:56:18.381+0900 E/TBM     (21637): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 17:56:18.431+0900 W/WATCH_CORE(21637): appcore-watch.c: __widget_create(958) > widget_create
01-20 17:56:18.431+0900 D/stretch (21637): Create analog watch
01-20 17:56:18.431+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [9197.310547] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263232:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:56:18.431+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9197.310547] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263232:4] gbar_fname[]
01-20 17:56:18.431+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [9197.310547] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263232:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:56:18.431+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9197.310547] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263232:4] gbar_fname[]
01-20 17:56:18.446+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 17:56:18.446+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 17:56:18.446+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 17:56:18.446+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 17:56:18.501+0900 D/stretch (21637): Time : 5 : 56 : 18
01-20 17:56:18.501+0900 W/WATCH_CORE(21637): appcore-watch.c: __widget_create(976) > widget_create done
01-20 17:56:18.576+0900 I/WATCH_CORE(21637): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 17:56:18.576+0900 I/WATCH_CORE(21637): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 17:56:18.576+0900 I/WATCH_CORE(21637): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 17:56:18.606+0900 E/EFL     (21637): edje<21637> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 17:56:18.616+0900 W/WATCH_CORE(21637): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 17:56:18.646+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:18.651+0900 D/stretch (21637): Time : 5 : 56 : 18
01-20 17:56:19.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:19.001+0900 D/stretch (21637): Time : 5 : 56 : 19
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 93 -> 92 1453280179 842
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 649 274 995
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 0 0 1097
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 803 739 1231
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 0 0 0
01-20 17:56:19.306+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 0 0 0
01-20 17:56:19.361+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 17:56:19.361+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 17:56:19.376+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:56:19.386+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 21637
01-20 17:56:19.386+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:56:19.601+0900 I/AUL_PAD (22134): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 17:56:19.896+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 17:56:20.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:20.001+0900 D/stretch (21637): Time : 5 : 56 : 20
01-20 17:56:20.091+0900 E/PKGMGR_SERVER(22106): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 17:56:20.091+0900 E/PKGMGR_SERVER(22106): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 17:56:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:56:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:56:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:56:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:56:21.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:21.021+0900 D/stretch (21637): Time : 5 : 56 : 21
01-20 17:56:22.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:22.016+0900 D/stretch (21637): Time : 5 : 56 : 22
01-20 17:56:23.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:23.006+0900 D/stretch (21637): Time : 5 : 56 : 23
01-20 17:56:24.011+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:24.011+0900 D/stretch (21637): Time : 5 : 56 : 24
01-20 17:56:25.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:25.006+0900 D/stretch (21637): Time : 5 : 56 : 25
01-20 17:56:26.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:26.001+0900 D/stretch (21637): Time : 5 : 56 : 26
01-20 17:56:27.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:27.011+0900 D/stretch (21637): Time : 5 : 56 : 27
01-20 17:56:28.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:28.011+0900 D/stretch (21637): Time : 5 : 56 : 28
01-20 17:56:29.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:29.006+0900 D/stretch (21637): Time : 5 : 56 : 29
01-20 17:56:30.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:30.001+0900 D/stretch (21637): Time : 5 : 56 : 30
01-20 17:56:31.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:31.006+0900 D/stretch (21637): Time : 5 : 56 : 31
01-20 17:56:32.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:32.001+0900 D/stretch (21637): Time : 5 : 56 : 32
01-20 17:56:33.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:33.006+0900 D/stretch (21637): Time : 5 : 56 : 33
01-20 17:56:34.006+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:34.006+0900 D/stretch (21637): Time : 5 : 56 : 34
01-20 17:56:34.651+0900 E/PKGMGR  (22255): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 17:56:34.856+0900 E/PKGMGR_SERVER(22257): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:56:34.946+0900 E/PKGMGR_SERVER(22257): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_700662527], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_700662527' '-r' 'org.tizen.stretchtime'], cookie=[32im8qk/wJ8X43umzJ/ULDfq2wk=], backend_flag=[0]
01-20 17:56:34.946+0900 E/PKGMGR  (22257): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 17:56:34.946+0900 E/PKGMGR_SERVER(22257): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 17:56:34.951+0900 E/PKGMGR  (22255): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[222550002]
01-20 17:56:34.956+0900 E/PKGMGR_SERVER(22258): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 17:56:35.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:35.001+0900 D/stretch (21637): Time : 5 : 56 : 35
01-20 17:56:35.166+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 17:56:35.176+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 17:56:35.186+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:1
01-20 17:56:35.366+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 17:56:36.001+0900 I/CAPI_WATCH_APPLICATION(21637): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:56:36.551+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 21637
01-20 17:56:36.606+0900 W/CRASH_MANAGER(22261): worker.c: worker_job(1199) > 1121637737472145328019
