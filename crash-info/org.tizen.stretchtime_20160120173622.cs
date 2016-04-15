S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 20658
Date: 2016-01-20 17:36:22+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3b08

Register Information
r0   = 0x00000003, r1   = 0x4182cf48
r2   = 0x4182e1e7, r3   = 0x417a7a8d
r4   = 0xbe83a530, r5   = 0xbe83a2c8
r6   = 0x00000132, r7   = 0xbe83a298
r8   = 0x4030b9c0, r9   = 0x41b73f30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x41855350, sp   = 0xbe83a278
lr   = 0x417a7f2d, pc   = 0x00003b08
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     10672 KB
Buffers:     12340 KB
Cached:     122484 KB
VmPeak:      79200 KB
VmSize:      78688 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15348 KB
VmRSS:       15348 KB
VmData:      22200 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23716 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20658 TID = 20658
20658 20954 20960 

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
41428000 4142c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4143c000 41441000 r-xp /usr/lib/libappcore-common.so.1.1
41449000 4144b000 r-xp /usr/lib/libiniparser.so.0
41454000 41458000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41468000 4146d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41475000 41477000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41480000 41486000 r-xp /usr/lib/libappsvc.so.0.1.0
4148e000 414b2000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414bb000 4158a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415a0000 415aa000 r-xp /lib/libnss_files-2.13.so
41771000 4184d000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
4189c000 418a3000 r-xp /usr/lib/libappcore-watch.so.1.1
418ac000 418b1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418b9000 418bd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
418c6000 418ce000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
418cf000 418ef000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f0000 418fd000 r-xp /usr/lib/libalarm.so.0.0.0
41906000 41a43000 r-xp /usr/lib/libicui18n.so.51.1
41a53000 41a59000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a61000 41a67000 r-xp /usr/lib/libwidget.so.1.0.0
41a70000 41a75000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a7d000 41a9b000 r-xp /usr/lib/libsensor.so.1.1.0
41aa5000 41ab7000 r-xp /usr/lib/libefl-assist.so.0.1.0
41abf000 41ac8000 r-xp /usr/lib/libcom-core.so.0.0.1
41ad1000 41add000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ae5000 41aee000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41af7000 41afe000 r-xp /usr/lib/libsensord-share.so
41b06000 41b18000 r-xp /usr/lib/libtts.so
41b20000 41b27000 r-xp /usr/lib/libtbm.so.1.0.0
41b2f000 41b30000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41b39000 41b3b000 rw-p [heap]
41b3b000 41c6d000 rw-p [heap]
41c6d000 41d51000 r-xp /usr/lib/libicuuc.so.51.1
41d66000 41e1e000 r-xp /usr/lib/libcairo.so.2.11200.14
433b0000 433d1000 r-xp /usr/lib/libui-extension.so.0.1.0
433da000 433e8000 r-xp /usr/lib/libGLESv2.so.2.0
433f1000 433f7000 r-xp /usr/lib/libxcb-render.so.0.0.0
433ff000 43402000 r-xp /usr/lib/libEGL.so.1.4
4340a000 43412000 r-xp /usr/lib/libdrm.so.2.4.0
4341a000 4341c000 r-xp /usr/lib/libdri2.so.0.0.0
43424000 43427000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4342f000 43434000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4343d000 43442000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4344a000 4346b000 r-xp /usr/lib/libexif.so.12.3.3
4347e000 43483000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4348b000 43555000 r-xp /usr/lib/libCOREGL.so.4.0
4399a000 44199000 rwxp [stack:20954]
44199000 4419c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
441a4000 441af000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4440c000 44c0b000 rwxp [stack:20960]
be81a000 be83b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20658)
Call Stack Count: 1
 0: (0x3b08) (null)
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
is 20-1-2016, 08:47:20 (UTC).
01-20 17:32:43.690+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-20 17:32:43.690+0900 W/ALARM_MANAGER(  503): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[640476832] is removed.
01-20 17:33:01.625+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:33:01.625+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:33:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:33:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:33:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:33:20.286+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:34:01.665+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:34:01.665+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:34:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:34:20.281+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:34:20.286+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:34:20.286+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.111+0900 I/SHealth_Service( 1036): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(628) > [1;35mlength of Array [1][0;m
01-20 17:35:01.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.311+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.311+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.311+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.311+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.316+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.321+0900 I/CAPI_WIDGET_APPLICATION(  798): widget_app.c: __provider_update_cb(279) > received updating signal
01-20 17:35:01.351+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.381+0900 W/SHealth_Widget(  798): Button.cpp: SetEnable(140) > [1;40;33mmIsEnable == true[0;m
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:01.381+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:01.381+0900 W/SHealth_Widget(  798): Button.cpp: SetEnable(140) > [1;40;33mmIsEnable == true[0;m
01-20 17:35:01.381+0900 I/CAPI_WIDGET_APPLICATION(  798): widget_app.c: __provider_update_cb(279) > received updating signal
01-20 17:35:01.416+0900 I/CAPI_WIDGET_APPLICATION(  798): widget_app.c: __provider_update_cb(279) > received updating signal
01-20 17:35:01.421+0900 I/HealthDataService( 1085): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
01-20 17:35:01.451+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
01-20 17:35:01.606+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:35:01.606+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:35:01.606+0900 I/RESOURCED(  521): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
01-20 17:35:20.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:35:20.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:35:20.236+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:35:20.241+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:35:57.761+0900 I/GESTURE (  139): gesture.c: GestureHandleKeyPressEvent(3712) > [GestureHandleKeyPressEvent] Ignore key press in DPMS off (devid:7) keycode=124
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 3
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 1
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
01-20 17:35:57.911+0900 W/STARTER (  663): hw_key.c: _is_enable_to_launch_home_directly(1098) > [_is_enable_to_launch_home_directly:1098] launching home directly
01-20 17:35:57.926+0900 W/STARTER (  663): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
01-20 17:35:57.926+0900 W/STARTER (  663): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[0] pressed lcd status[3], current lcd status[3] pressed pm state[1]
01-20 17:35:57.926+0900 W/STARTER (  663): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] LCD OFF state => ignore key operation
01-20 17:35:57.976+0900 W/WATCH_CORE(20351): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
01-20 17:35:57.976+0900 I/WATCH_CORE(20351): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
01-20 17:35:57.991+0900 W/wnotibp ( 2513): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1405) > ::APP:: view state=0, 2, 0
01-20 17:35:58.031+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(186) > LCD on
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_set(161) > timer set
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _apps_status_get(123) > apps status:0
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:0 info->offtime:498190
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _lcd_on_cb(299) > clock isn't on top, place a clock to top
01-20 17:35:58.031+0900 W/W_HOME  (  715): gesture.c: _clock_show(228) > clock show
01-20 17:35:58.036+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: __clock_viewer_lcdon_cb(365) >  event lcdon[1][0]
01-20 17:35:58.036+0900 W/W_CLOCK_VIEWER(  718): clock-viewer-dbox.c: clock_viewer_widget_set_black_cover(315) >  Set black cover[1] ani[0]
01-20 17:35:58.036+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: __clock_viewer_lcdon_cb(392) >  lcdon by [powerkey] time[498190]
01-20 17:35:58.051+0900 W/W_HOME  (  715): gesture.c: _clock_show(243) > home raise
01-20 17:35:58.051+0900 E/W_HOME  (  715): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
01-20 17:35:58.056+0900 W/STARTER (  663): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [powerkey] after screen off time [498190]ms
01-20 17:35:58.056+0900 W/STARTER (  663): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[1]
01-20 17:35:58.061+0900 I/SCONTEXT-LIB(  598): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=17)
01-20 17:35:58.106+0900 W/W_HOME  (  715): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
01-20 17:35:58.106+0900 W/W_HOME  (  715): gesture.c: _clock_show(246) > home raise done
01-20 17:35:58.106+0900 W/W_HOME  (  715): gesture.c: _clock_show(253) > show clock
01-20 17:35:58.106+0900 W/W_HOME  (  715): event_manager.c: _lcd_on_cb(691) > lcd state: 1
01-20 17:35:58.111+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.111+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02a00003)
01-20 17:35:58.151+0900 W/WAKEUP-SERVICE( 1074): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124321840[0;m
01-20 17:35:58.151+0900 W/WAKEUP-SERVICE( 1074): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
01-20 17:35:58.151+0900 I/TIZEN_N_SOUND_MANAGER( 1074): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
01-20 17:35:58.156+0900 W/TIZEN_N_SOUND_MANAGER( 1074): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
01-20 17:35:58.156+0900 I/TIZEN_N_SOUND_MANAGER( 1074): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
01-20 17:35:58.231+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
01-20 17:35:58.231+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
01-20 17:35:58.241+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b7560] swap changed from sync to async
01-20 17:35:58.256+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: __clock_viewer_lcdon_completed_cb(420) >  event lcdon completed[1]
01-20 17:35:58.256+0900 W/W_CLOCK_VIEWER(  718): clock-viewer-dbox.c: clock_viewer_widget_set_black_cover(315) >  Set black cover[0] ani[1]
01-20 17:35:58.256+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: clock_viewer_hide(951) >  reservied[0], gesture[1], clock visible[1]
01-20 17:35:58.256+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: _clock_viewer_send_clock_stop(733) >  clock stop <<
01-20 17:35:58.261+0900 W/STARTER (  663): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [powerkey]
01-20 17:35:58.261+0900 W/STARTER (  663): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[1]
01-20 17:35:58.296+0900 I/efl-extension( 2513): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
01-20 17:35:58.296+0900 W/wnotibp ( 2513): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
01-20 17:35:58.301+0900 W/WATCH_CORE(20351): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 0, state: 3
01-20 17:35:58.301+0900 D/stretch (20351): Time : 5 : 35 : 58
01-20 17:35:58.301+0900 W/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_ambient_changed(337) > _watch_core_ambient_changed: 0
01-20 17:35:58.306+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
01-20 17:35:58.336+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
01-20 17:35:58.336+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
01-20 17:35:58.421+0900 I/TIZEN_N_SOUND_MANAGER( 1074): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
01-20 17:35:58.421+0900 W/TIZEN_N_SOUND_MANAGER( 1074): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
01-20 17:35:58.421+0900 W/WAKEUP-SERVICE( 1074): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
01-20 17:35:58.421+0900 I/HIGEAR  ( 1074): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
01-20 17:35:58.456+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: __clock_viewer_lcdon_vi_timer_cb(139) >  lcdon vi wait timer
01-20 17:35:58.456+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_set_visibility(3853) > [SECURE_LOG] CA Livebox is not able to change the visibility
01-20 17:35:58.466+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
01-20 17:35:58.466+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
01-20 17:35:58.466+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.466+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.466+0900 W/WATCH_CORE(20351): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
01-20 17:35:58.466+0900 I/WATCH_CORE(20351): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
01-20 17:35:58.466+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.466+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
01-20 17:35:58.471+0900 I/MALI    (  718): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42e01008] swap changed from sync to async
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(0)
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.501+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(0)
01-20 17:35:58.501+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
01-20 17:35:58.501+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-20 17:35:58.501+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.501+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
01-20 17:35:58.501+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
01-20 17:35:58.501+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 17:35:58.511+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
01-20 17:35:58.511+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 17:35:58.511+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 17:35:58.511+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-20 17:35:58.516+0900 W/WATCH_CORE(20351): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 17:35:58.521+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:35:58.521+0900 D/stretch (20351): Time : 5 : 35 : 58
01-20 17:35:58.541+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b7560] swap changed from async to sync
01-20 17:35:58.556+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: __clock_viewer_clock_changed_timer_cb(131) >  clock changed timer
01-20 17:35:58.556+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: _clock_viewer_send_clock_changed(747) >  clock changed <<
01-20 17:35:59.046+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:35:59.046+0900 D/stretch (20351): Time : 5 : 35 : 59
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 17:35:59.506+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.511+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 17:35:59.516+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.516+0900 E/CAPI_APPFW_APP_CONTROL( 1027): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-20 17:35:59.516+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1027]   value = [true][0m
01-20 17:35:59.526+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:35:59.571+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 812
01-20 17:35:59.576+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:35:59.611+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
01-20 17:35:59.621+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 17:35:59.631+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 17:35:59.631+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 17:35:59.631+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 17:35:59.631+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 17:35:59.636+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.641+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 17:35:59.641+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 17:35:59.641+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 17:35:59.646+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 17:35:59.646+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 17:35:59.646+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 17:35:59.646+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 17:35:59.646+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 17:35:59.651+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 17:35:59.651+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 17:35:59.651+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 17:36:00.006+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:00.011+0900 D/stretch (20351): Time : 5 : 36 : 0
01-20 17:36:01.006+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:01.006+0900 D/stretch (20351): Time : 5 : 36 : 1
01-20 17:36:01.656+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 17:36:01.656+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 17:36:02.001+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:02.001+0900 D/stretch (20351): Time : 5 : 36 : 2
01-20 17:36:03.016+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:03.016+0900 D/stretch (20351): Time : 5 : 36 : 3
01-20 17:36:04.001+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:04.001+0900 D/stretch (20351): Time : 5 : 36 : 4
01-20 17:36:05.001+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:05.001+0900 D/stretch (20351): Time : 5 : 36 : 5
01-20 17:36:06.001+0900 I/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:06.001+0900 D/stretch (20351): Time : 5 : 36 : 6
01-20 17:36:06.721+0900 E/PKGMGR_SERVER(20949): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:36:06.801+0900 E/PKGMGR_SERVER(20949): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-527424910], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 17:36:06.806+0900 E/PKGMGR_SERVER(20951): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 17:36:06.811+0900 E/PKGMGR  (20943): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 17:36:06.881+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:36:06.891+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20351
01-20 17:36:06.891+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:36:06.896+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:36:06.901+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17773) is dead. cmd(5) is canceled
01-20 17:36:06.901+0900 E/PKGMGR_SERVER(20951): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-20 17:36:06.901+0900 E/PKGMGR_SERVER(20951): [0;m
01-20 17:36:06.901+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 17:36:06.906+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(20351), cmd(4)
01-20 17:36:06.906+0900 W/CAPI_WATCH_APPLICATION(20351): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 17:36:06.906+0900 D/stretch (20351): Destroy analog watch
01-20 17:36:06.906+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 17:36:06.906+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 17:36:06.906+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:36:06.906+0900 W/WATCH_CORE(20351): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 17:36:06.906+0900 E/WIDGET_PROVIDER_APP(20351): client.c: client_fini(1175) > Provider is not initialized
01-20 17:36:06.916+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20351
01-20 17:36:06.916+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 17:36:06.926+0900 I/efl-extension(20351): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 17:36:07.021+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:36:07.091+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 17:36:07.131+0900 E/PKGMGR_SERVER(20951): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 17:36:07.171+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 17:36:07.171+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(20351), cmd(4)
01-20 17:36:07.181+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 17:36:07.226+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:36:07.251+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 17:36:07.251+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 17:36:07.251+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 17:36:07.271+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 17:36:07.271+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 17:36:07.271+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 17:36:07.301+0900 E/PKGMGR_SERVER(20949): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20951]
01-20 17:36:07.351+0900 I/efl-extension(20658): efl_extension.c: eext_mod_init(40) > Init
01-20 17:36:07.351+0900 I/UXT     (20658): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 17:36:07.366+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 17:36:07.371+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 3
01-20 17:36:07.371+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 17:36:07.401+0900 E/TBM     (20658): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 17:36:07.476+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20351
01-20 17:36:07.521+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [9197.310547] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263224:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:36:07.521+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9197.310547] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263224:4] gbar_fname[]
01-20 17:36:07.526+0900 W/WATCH_CORE(20658): appcore-watch.c: __widget_create(958) > widget_create
01-20 17:36:07.526+0900 D/stretch (20658): Create analog watch
01-20 17:36:07.526+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [9197.310547] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263224:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 17:36:07.526+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9197.310547] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_9197.310547.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263224:4] gbar_fname[]
01-20 17:36:07.541+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 17:36:07.541+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 17:36:07.541+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 17:36:07.541+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 17:36:07.591+0900 D/stretch (20658): Time : 5 : 36 : 7
01-20 17:36:07.591+0900 W/WATCH_CORE(20658): appcore-watch.c: __widget_create(976) > widget_create done
01-20 17:36:07.671+0900 I/WATCH_CORE(20658): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 17:36:07.671+0900 I/WATCH_CORE(20658): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 17:36:07.671+0900 I/WATCH_CORE(20658): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 17:36:07.701+0900 E/EFL     (20658): edje<20658> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 17:36:07.706+0900 W/WATCH_CORE(20658): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 17:36:07.736+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:07.736+0900 D/stretch (20658): Time : 5 : 36 : 7
01-20 17:36:08.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:08.001+0900 D/stretch (20658): Time : 5 : 36 : 8
01-20 17:36:08.476+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 17:36:08.476+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 17:36:08.491+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 17:36:08.501+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20658
01-20 17:36:08.501+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 17:36:08.726+0900 I/AUL_PAD (20982): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 17:36:08.911+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 17:36:09.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:09.001+0900 D/stretch (20658): Time : 5 : 36 : 9
01-20 17:36:09.091+0900 E/PKGMGR_SERVER(20949): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 17:36:09.091+0900 E/PKGMGR_SERVER(20949): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 17:36:10.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:10.001+0900 D/stretch (20658): Time : 5 : 36 : 10
01-20 17:36:11.006+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:11.006+0900 D/stretch (20658): Time : 5 : 36 : 11
01-20 17:36:12.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:12.001+0900 D/stretch (20658): Time : 5 : 36 : 12
01-20 17:36:13.006+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:13.006+0900 D/stretch (20658): Time : 5 : 36 : 13
01-20 17:36:14.006+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:14.026+0900 D/stretch (20658): Time : 5 : 36 : 14
01-20 17:36:15.006+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:15.016+0900 D/stretch (20658): Time : 5 : 36 : 15
01-20 17:36:16.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:16.001+0900 D/stretch (20658): Time : 5 : 36 : 16
01-20 17:36:17.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:17.001+0900 D/stretch (20658): Time : 5 : 36 : 17
01-20 17:36:18.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:18.006+0900 D/stretch (20658): Time : 5 : 36 : 18
01-20 17:36:19.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:19.001+0900 D/stretch (20658): Time : 5 : 36 : 19
01-20 17:36:20.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:20.001+0900 D/stretch (20658): Time : 5 : 36 : 20
01-20 17:36:20.221+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 17:36:20.221+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 17:36:20.221+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 17:36:20.221+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 17:36:21.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:21.001+0900 D/stretch (20658): Time : 5 : 36 : 21
01-20 17:36:21.196+0900 E/PKGMGR  (21110): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 17:36:21.576+0900 E/PKGMGR_SERVER(21112): pkgmgr-server.c: main(2126) > package manager server start
01-20 17:36:21.681+0900 E/PKGMGR_SERVER(21112): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-512794899], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-512794899' '-r' 'org.tizen.stretchtime'], cookie=[1vbhdGG5W9GRoVipISz7S3LChk0=], backend_flag=[0]
01-20 17:36:21.686+0900 E/PKGMGR  (21112): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 17:36:21.686+0900 E/PKGMGR_SERVER(21112): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 17:36:21.691+0900 E/PKGMGR  (21110): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[211100002]
01-20 17:36:21.691+0900 E/PKGMGR_SERVER(21113): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 17:36:21.906+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 17:36:21.926+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 17:36:21.941+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:1
01-20 17:36:22.001+0900 I/CAPI_WATCH_APPLICATION(20658): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 17:36:22.131+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 17:36:22.346+0900 W/CRASH_MANAGER(21115): worker.c: worker_job(1199) > 1120658737472145327898
