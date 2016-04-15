S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 15237
Date: 2016-01-20 15:59:14+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x390c

Register Information
r0   = 0x00000006, r1   = 0x4182cab8
r2   = 0x4182dd55, r3   = 0x417a767d
r4   = 0xbeabe538, r5   = 0xbeabe2d0
r6   = 0x00000132, r7   = 0x418a14d0
r8   = 0x4030b9c0, r9   = 0x41f28078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x41854e10, sp   = 0xbeabe2a8
lr   = 0x417a7695, pc   = 0x0000390c
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     17516 KB
Buffers:      9324 KB
Cached:     117620 KB
VmPeak:      79196 KB
VmSize:      78684 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15336 KB
VmRSS:       15336 KB
VmData:      22196 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23716 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15237 TID = 15237
15237 15439 15446 

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
4189b000 418a2000 r-xp /usr/lib/libappcore-watch.so.1.1
418ab000 418b0000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418b8000 418bc000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
418c5000 418cd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
418ce000 418ee000 r-xp /usr/lib/libefl-extension.so.0.1.0
418ef000 418fc000 r-xp /usr/lib/libalarm.so.0.0.0
41905000 41a42000 r-xp /usr/lib/libicui18n.so.51.1
41a52000 41b36000 r-xp /usr/lib/libicuuc.so.51.1
41b4b000 41b51000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41b59000 41b5f000 r-xp /usr/lib/libwidget.so.1.0.0
41b68000 41b6d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b75000 41b93000 r-xp /usr/lib/libsensor.so.1.1.0
41b9d000 41baf000 r-xp /usr/lib/libefl-assist.so.0.1.0
41bb7000 41c6f000 r-xp /usr/lib/libcairo.so.2.11200.14
41c7a000 41c83000 r-xp /usr/lib/libcom-core.so.0.0.1
41c8c000 41c98000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ca0000 41ca9000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41cb2000 41cb9000 r-xp /usr/lib/libsensord-share.so
41cc1000 41cd3000 r-xp /usr/lib/libtts.so
41cdb000 41cfc000 r-xp /usr/lib/libui-extension.so.0.1.0
41d05000 41d0c000 r-xp /usr/lib/libtbm.so.1.0.0
41d14000 41d22000 r-xp /usr/lib/libGLESv2.so.2.0
41d2b000 41d2c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41d35000 41d3b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41d43000 41d46000 r-xp /usr/lib/libEGL.so.1.4
41d4e000 41d56000 r-xp /usr/lib/libdrm.so.2.4.0
41d5e000 41d60000 r-xp /usr/lib/libdri2.so.0.0.0
41d68000 41d6b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d73000 41d78000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d81000 41d86000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d8e000 41daf000 r-xp /usr/lib/libexif.so.12.3.3
41dc2000 41dc7000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41dcf000 41e99000 r-xp /usr/lib/libCOREGL.so.4.0
41eab000 41eae000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41eb6000 41ec1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41ed9000 41eef000 rw-p [heap]
41eef000 42021000 rw-p [heap]
439db000 441da000 rwxp [stack:15439]
442e6000 44ae5000 rwxp [stack:15446]
bea9e000 beabf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:15237)
Call Stack Count: 1
 0: (0x390c) (null)
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
ore_time_tick
01-20 15:56:55.006+0900 D/stretch (15040): Time : 3 : 56 : 55
01-20 15:56:56.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:56:56.005+0900 D/stretch (15040): Time : 3 : 56 : 56
01-20 15:56:57.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:56:57.005+0900 D/stretch (15040): Time : 3 : 56 : 57
01-20 15:56:58.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:56:58.006+0900 D/stretch (15040): Time : 3 : 56 : 58
01-20 15:56:59.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:56:59.006+0900 D/stretch (15040): Time : 3 : 56 : 59
01-20 15:57:00.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:00.005+0900 D/stretch (15040): Time : 3 : 57 : 0
01-20 15:57:00.845+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 15:57:00.845+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 15:57:00.855+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 15:57:00.855+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:57:00.860+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:57:00.860+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 15:57:00.870+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:57:00.875+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:57:00.880+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 15:57:01.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:01.010+0900 D/stretch (15040): Time : 3 : 57 : 1
01-20 15:57:01.620+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 15:57:01.625+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 15:57:02.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:02.005+0900 D/stretch (15040): Time : 3 : 57 : 2
01-20 15:57:03.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:03.005+0900 D/stretch (15040): Time : 3 : 57 : 3
01-20 15:57:04.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:04.005+0900 D/stretch (15040): Time : 3 : 57 : 4
01-20 15:57:05.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:05.006+0900 D/stretch (15040): Time : 3 : 57 : 5
01-20 15:57:06.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:06.010+0900 D/stretch (15040): Time : 3 : 57 : 6
01-20 15:57:07.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:07.005+0900 D/stretch (15040): Time : 3 : 57 : 7
01-20 15:57:08.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:08.010+0900 D/stretch (15040): Time : 3 : 57 : 8
01-20 15:57:09.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:09.005+0900 D/stretch (15040): Time : 3 : 57 : 9
01-20 15:57:10.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:10.010+0900 D/stretch (15040): Time : 3 : 57 : 10
01-20 15:57:11.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:11.005+0900 D/stretch (15040): Time : 3 : 57 : 11
01-20 15:57:12.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:12.006+0900 D/stretch (15040): Time : 3 : 57 : 12
01-20 15:57:13.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:13.005+0900 D/stretch (15040): Time : 3 : 57 : 13
01-20 15:57:14.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:14.006+0900 D/stretch (15040): Time : 3 : 57 : 14
01-20 15:57:15.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:15.005+0900 D/stretch (15040): Time : 3 : 57 : 15
01-20 15:57:16.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:16.005+0900 D/stretch (15040): Time : 3 : 57 : 16
01-20 15:57:17.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:17.005+0900 D/stretch (15040): Time : 3 : 57 : 17
01-20 15:57:18.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:18.005+0900 D/stretch (15040): Time : 3 : 57 : 18
01-20 15:57:19.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:19.005+0900 D/stretch (15040): Time : 3 : 57 : 19
01-20 15:57:20.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:20.005+0900 D/stretch (15040): Time : 3 : 57 : 20
01-20 15:57:20.225+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:57:20.230+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:57:20.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:57:20.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:57:21.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:21.005+0900 D/stretch (15040): Time : 3 : 57 : 21
01-20 15:57:22.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:22.006+0900 D/stretch (15040): Time : 3 : 57 : 22
01-20 15:57:23.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:23.005+0900 D/stretch (15040): Time : 3 : 57 : 23
01-20 15:57:23.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:57:23.395+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:57:23.400+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:57:23.400+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:57:23.430+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 15:57:23 5일 전[0;m
01-20 15:57:23.445+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 15:57:23.445+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:57:23.450+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:57:23.455+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:57:23.455+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:57:23.470+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 15:57:24.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:24.005+0900 D/stretch (15040): Time : 3 : 57 : 24
01-20 15:57:25.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:25.005+0900 D/stretch (15040): Time : 3 : 57 : 25
01-20 15:57:26.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:26.006+0900 D/stretch (15040): Time : 3 : 57 : 26
01-20 15:57:27.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:27.005+0900 D/stretch (15040): Time : 3 : 57 : 27
01-20 15:57:28.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:28.005+0900 D/stretch (15040): Time : 3 : 57 : 28
01-20 15:57:29.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:29.005+0900 D/stretch (15040): Time : 3 : 57 : 29
01-20 15:57:30.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:30.005+0900 D/stretch (15040): Time : 3 : 57 : 30
01-20 15:57:31.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:31.005+0900 D/stretch (15040): Time : 3 : 57 : 31
01-20 15:57:32.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:32.005+0900 D/stretch (15040): Time : 3 : 57 : 32
01-20 15:57:33.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:33.005+0900 D/stretch (15040): Time : 3 : 57 : 33
01-20 15:57:34.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:34.005+0900 D/stretch (15040): Time : 3 : 57 : 34
01-20 15:57:35.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:35.005+0900 D/stretch (15040): Time : 3 : 57 : 35
01-20 15:57:36.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:36.005+0900 D/stretch (15040): Time : 3 : 57 : 36
01-20 15:57:37.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:37.006+0900 D/stretch (15040): Time : 3 : 57 : 37
01-20 15:57:38.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:38.005+0900 D/stretch (15040): Time : 3 : 57 : 38
01-20 15:57:39.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:39.005+0900 D/stretch (15040): Time : 3 : 57 : 39
01-20 15:57:40.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:40.005+0900 D/stretch (15040): Time : 3 : 57 : 40
01-20 15:57:41.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:41.005+0900 D/stretch (15040): Time : 3 : 57 : 41
01-20 15:57:42.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:42.010+0900 D/stretch (15040): Time : 3 : 57 : 42
01-20 15:57:43.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:43.005+0900 D/stretch (15040): Time : 3 : 57 : 43
01-20 15:57:44.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:44.006+0900 D/stretch (15040): Time : 3 : 57 : 44
01-20 15:57:45.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:45.006+0900 D/stretch (15040): Time : 3 : 57 : 45
01-20 15:57:46.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:46.005+0900 D/stretch (15040): Time : 3 : 57 : 46
01-20 15:57:47.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:47.005+0900 D/stretch (15040): Time : 3 : 57 : 47
01-20 15:57:48.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:48.005+0900 D/stretch (15040): Time : 3 : 57 : 48
01-20 15:57:49.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:49.005+0900 D/stretch (15040): Time : 3 : 57 : 49
01-20 15:57:50.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:50.011+0900 D/stretch (15040): Time : 3 : 57 : 50
01-20 15:57:51.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:51.005+0900 D/stretch (15040): Time : 3 : 57 : 51
01-20 15:57:52.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:52.005+0900 D/stretch (15040): Time : 3 : 57 : 52
01-20 15:57:53.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:53.006+0900 D/stretch (15040): Time : 3 : 57 : 53
01-20 15:57:54.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:54.006+0900 D/stretch (15040): Time : 3 : 57 : 54
01-20 15:57:55.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:55.006+0900 D/stretch (15040): Time : 3 : 57 : 55
01-20 15:57:56.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:56.006+0900 D/stretch (15040): Time : 3 : 57 : 56
01-20 15:57:57.011+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:57.011+0900 D/stretch (15040): Time : 3 : 57 : 57
01-20 15:57:58.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:58.010+0900 D/stretch (15040): Time : 3 : 57 : 58
01-20 15:57:59.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:57:59.010+0900 D/stretch (15040): Time : 3 : 57 : 59
01-20 15:58:00.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:00.005+0900 D/stretch (15040): Time : 3 : 58 : 0
01-20 15:58:00.820+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 15:58:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 15:58:00.830+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 15:58:00.830+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:58:00.835+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:58:00.835+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 15:58:00.845+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:58:00.850+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:58:00.855+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 15:58:01.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:01.005+0900 D/stretch (15040): Time : 3 : 58 : 1
01-20 15:58:01.670+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 15:58:01.670+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 15:58:02.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:02.005+0900 D/stretch (15040): Time : 3 : 58 : 2
01-20 15:58:03.011+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:03.016+0900 D/stretch (15040): Time : 3 : 58 : 3
01-20 15:58:04.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:04.005+0900 D/stretch (15040): Time : 3 : 58 : 4
01-20 15:58:05.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:05.005+0900 D/stretch (15040): Time : 3 : 58 : 5
01-20 15:58:06.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:06.006+0900 D/stretch (15040): Time : 3 : 58 : 6
01-20 15:58:07.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:07.005+0900 D/stretch (15040): Time : 3 : 58 : 7
01-20 15:58:08.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:08.006+0900 D/stretch (15040): Time : 3 : 58 : 8
01-20 15:58:09.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:09.006+0900 D/stretch (15040): Time : 3 : 58 : 9
01-20 15:58:10.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:10.010+0900 D/stretch (15040): Time : 3 : 58 : 10
01-20 15:58:11.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:11.006+0900 D/stretch (15040): Time : 3 : 58 : 11
01-20 15:58:12.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:12.006+0900 D/stretch (15040): Time : 3 : 58 : 12
01-20 15:58:13.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:13.010+0900 D/stretch (15040): Time : 3 : 58 : 13
01-20 15:58:14.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:14.006+0900 D/stretch (15040): Time : 3 : 58 : 14
01-20 15:58:15.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:15.005+0900 D/stretch (15040): Time : 3 : 58 : 15
01-20 15:58:16.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:16.006+0900 D/stretch (15040): Time : 3 : 58 : 16
01-20 15:58:17.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:17.010+0900 D/stretch (15040): Time : 3 : 58 : 17
01-20 15:58:18.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:18.005+0900 D/stretch (15040): Time : 3 : 58 : 18
01-20 15:58:19.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:19.006+0900 D/stretch (15040): Time : 3 : 58 : 19
01-20 15:58:20.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:20.010+0900 D/stretch (15040): Time : 3 : 58 : 20
01-20 15:58:20.275+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:58:20.275+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:58:20.295+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:58:20.295+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:58:21.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:21.006+0900 D/stretch (15040): Time : 3 : 58 : 21
01-20 15:58:22.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:22.006+0900 D/stretch (15040): Time : 3 : 58 : 22
01-20 15:58:23.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:23.010+0900 D/stretch (15040): Time : 3 : 58 : 23
01-20 15:58:23.395+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:58:23.395+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:58:23.405+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:58:23.405+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:58:23.430+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 15:58:23 5일 전[0;m
01-20 15:58:23.440+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 15:58:23.440+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:58:23.440+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:58:23.445+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:58:23.445+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:58:23.450+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 15:58:24.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:24.005+0900 D/stretch (15040): Time : 3 : 58 : 24
01-20 15:58:25.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:25.005+0900 D/stretch (15040): Time : 3 : 58 : 25
01-20 15:58:26.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:26.005+0900 D/stretch (15040): Time : 3 : 58 : 26
01-20 15:58:27.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:27.005+0900 D/stretch (15040): Time : 3 : 58 : 27
01-20 15:58:28.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:28.010+0900 D/stretch (15040): Time : 3 : 58 : 28
01-20 15:58:29.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:29.005+0900 D/stretch (15040): Time : 3 : 58 : 29
01-20 15:58:29.265+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 95 -> 94 1453273109 271
01-20 15:58:29.265+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 662 260 1037
01-20 15:58:29.270+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 0 0 1272
01-20 15:58:29.270+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 811 725 1271
01-20 15:58:29.270+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 271 5 425
01-20 15:58:29.270+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 271 5 425
01-20 15:58:30.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:30.006+0900 D/stretch (15040): Time : 3 : 58 : 30
01-20 15:58:31.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:31.010+0900 D/stretch (15040): Time : 3 : 58 : 31
01-20 15:58:32.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:32.006+0900 D/stretch (15040): Time : 3 : 58 : 32
01-20 15:58:33.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:33.010+0900 D/stretch (15040): Time : 3 : 58 : 33
01-20 15:58:34.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:34.006+0900 D/stretch (15040): Time : 3 : 58 : 34
01-20 15:58:35.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:35.005+0900 D/stretch (15040): Time : 3 : 58 : 35
01-20 15:58:36.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:36.005+0900 D/stretch (15040): Time : 3 : 58 : 36
01-20 15:58:37.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:37.005+0900 D/stretch (15040): Time : 3 : 58 : 37
01-20 15:58:38.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:38.005+0900 D/stretch (15040): Time : 3 : 58 : 38
01-20 15:58:39.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:39.006+0900 D/stretch (15040): Time : 3 : 58 : 39
01-20 15:58:40.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:40.006+0900 D/stretch (15040): Time : 3 : 58 : 40
01-20 15:58:41.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:41.010+0900 D/stretch (15040): Time : 3 : 58 : 41
01-20 15:58:42.001+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:42.006+0900 D/stretch (15040): Time : 3 : 58 : 42
01-20 15:58:43.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:43.011+0900 D/stretch (15040): Time : 3 : 58 : 43
01-20 15:58:44.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:44.010+0900 D/stretch (15040): Time : 3 : 58 : 44
01-20 15:58:45.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:45.006+0900 D/stretch (15040): Time : 3 : 58 : 45
01-20 15:58:46.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:46.006+0900 D/stretch (15040): Time : 3 : 58 : 46
01-20 15:58:47.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:47.010+0900 D/stretch (15040): Time : 3 : 58 : 47
01-20 15:58:48.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:48.005+0900 D/stretch (15040): Time : 3 : 58 : 48
01-20 15:58:49.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:49.005+0900 D/stretch (15040): Time : 3 : 58 : 49
01-20 15:58:50.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:50.005+0900 D/stretch (15040): Time : 3 : 58 : 50
01-20 15:58:51.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:51.010+0900 D/stretch (15040): Time : 3 : 58 : 51
01-20 15:58:52.005+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:52.005+0900 D/stretch (15040): Time : 3 : 58 : 52
01-20 15:58:53.006+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:53.006+0900 D/stretch (15040): Time : 3 : 58 : 53
01-20 15:58:54.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:54.000+0900 D/stretch (15040): Time : 3 : 58 : 54
01-20 15:58:55.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:55.000+0900 D/stretch (15040): Time : 3 : 58 : 55
01-20 15:58:56.000+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:56.000+0900 D/stretch (15040): Time : 3 : 58 : 56
01-20 15:58:57.000+0900 E/PKGMGR_SERVER(15428): pkgmgr-server.c: main(2126) > package manager server start
01-20 15:58:57.010+0900 I/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:57.010+0900 D/stretch (15040): Time : 3 : 58 : 57
01-20 15:58:57.100+0900 E/PKGMGR_SERVER(15428): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-2062191333], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 15:58:57.105+0900 E/PKGMGR_SERVER(15430): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 15:58:57.110+0900 E/PKGMGR  (15422): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 15:58:57.185+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:58:57.195+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15040
01-20 15:58:57.195+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:58:57.200+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 15:58:57.205+0900 W/CAPI_WATCH_APPLICATION(15040): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 15:58:57.205+0900 D/stretch (15040): Destroy analog watch
01-20 15:58:57.205+0900 W/WATCH_CORE(15040): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 15:58:57.205+0900 E/WIDGET_PROVIDER_APP(15040): client.c: client_fini(1175) > Provider is not initialized
01-20 15:58:57.205+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 15:58:57.205+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 15:58:57.205+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(15040), cmd(4)
01-20 15:58:57.210+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:58:57.220+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15040
01-20 15:58:57.220+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 15:58:57.225+0900 I/efl-extension(15040): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 15:58:57.325+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:58:57.400+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 15:58:57.460+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 15:58:57.465+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(15040), cmd(4)
01-20 15:58:57.475+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 15:58:57.540+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:58:57.585+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:58:57.585+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 15:58:57.590+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 15:58:57.635+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 15:58:57.640+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 15:58:57.640+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 15:58:57.725+0900 E/PKGMGR_SERVER(15430): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 15:58:57.850+0900 I/efl-extension(15237): efl_extension.c: eext_mod_init(40) > Init
01-20 15:58:57.850+0900 I/UXT     (15237): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 15:58:57.855+0900 E/PKGMGR_SERVER(15428): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15430]
01-20 15:58:57.875+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 15:58:57.875+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 15:58:57.880+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 15:58:57.905+0900 E/TBM     (15237): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 15:58:57.950+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 15040
01-20 15:58:57.995+0900 W/WATCH_CORE(15237): appcore-watch.c: __widget_create(958) > widget_create
01-20 15:58:58.000+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [4076.373291] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4076.373291.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263082:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:58:58.000+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[4076.373291] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4076.373291.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263082:4] gbar_fname[]
01-20 15:58:58.000+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [4076.373291] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4076.373291.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263082:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:58:58.000+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[4076.373291] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4076.373291.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263082:4] gbar_fname[]
01-20 15:58:58.000+0900 D/stretch (15237): Create analog watch
01-20 15:58:58.015+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 15:58:58.015+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 15:58:58.070+0900 D/stretch (15237): Time : 3 : 58 : 58
01-20 15:58:58.070+0900 E/EFL     (15237): edje<15237> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:58:58.070+0900 W/WATCH_CORE(15237): appcore-watch.c: __widget_create(976) > widget_create done
01-20 15:58:58.155+0900 I/WATCH_CORE(15237): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 15:58:58.155+0900 I/WATCH_CORE(15237): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 15:58:58.160+0900 I/WATCH_CORE(15237): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 15:58:58.205+0900 W/WATCH_CORE(15237): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 15:58:58.235+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:58.240+0900 D/stretch (15237): Time : 3 : 58 : 58
01-20 15:58:58.955+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 15:58:58.955+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 15:58:58.970+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:58:58.975+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15237
01-20 15:58:58.975+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:58:58.995+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:58:59.000+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15237
01-20 15:58:59.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:58:59.000+0900 D/stretch (15237): Time : 3 : 58 : 59
01-20 15:58:59.005+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:58:59.090+0900 E/PKGMGR_SERVER(15428): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 15:58:59.090+0900 E/PKGMGR_SERVER(15428): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 15:58:59.175+0900 I/AUL_PAD (15462): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 15:58:59.215+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 15:59:00.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:00.005+0900 D/stretch (15237): Time : 3 : 59 : 0
01-20 15:59:00.805+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 15:59:00.805+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 15:59:00.815+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 15:59:00.815+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:59:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:59:00.830+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 15:59:00.830+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:59:00.830+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:59:00.835+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 15:59:01.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:01.000+0900 D/stretch (15237): Time : 3 : 59 : 1
01-20 15:59:01.605+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 15:59:01.605+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 15:59:01.610+0900 I/RESOURCED(  521): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
01-20 15:59:02.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:02.000+0900 D/stretch (15237): Time : 3 : 59 : 2
01-20 15:59:03.005+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:03.010+0900 D/stretch (15237): Time : 3 : 59 : 3
01-20 15:59:04.010+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:04.010+0900 D/stretch (15237): Time : 3 : 59 : 4
01-20 15:59:05.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:05.005+0900 D/stretch (15237): Time : 3 : 59 : 5
01-20 15:59:06.005+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:06.005+0900 D/stretch (15237): Time : 3 : 59 : 6
01-20 15:59:07.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:07.005+0900 D/stretch (15237): Time : 3 : 59 : 7
01-20 15:59:08.005+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:08.005+0900 D/stretch (15237): Time : 3 : 59 : 8
01-20 15:59:09.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:09.020+0900 D/stretch (15237): Time : 3 : 59 : 9
01-20 15:59:10.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:10.005+0900 D/stretch (15237): Time : 3 : 59 : 10
01-20 15:59:11.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:11.000+0900 D/stretch (15237): Time : 3 : 59 : 11
01-20 15:59:12.020+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:12.030+0900 D/stretch (15237): Time : 3 : 59 : 12
01-20 15:59:13.000+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:13.000+0900 D/stretch (15237): Time : 3 : 59 : 13
01-20 15:59:13.210+0900 E/PKGMGR  (15591): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 15:59:13.525+0900 E/PKGMGR_SERVER(15593): pkgmgr-server.c: main(2126) > package manager server start
01-20 15:59:13.615+0900 E/PKGMGR_SERVER(15593): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-2045801700], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-2045801700' '-r' 'org.tizen.stretchtime'], cookie=[eKix79uxsdXIe+8topu7V35wGro=], backend_flag=[0]
01-20 15:59:13.620+0900 E/PKGMGR  (15593): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 15:59:13.625+0900 E/PKGMGR_SERVER(15593): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 15:59:13.630+0900 E/PKGMGR  (15591): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[155910002]
01-20 15:59:13.630+0900 E/PKGMGR_SERVER(15594): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 15:59:13.855+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 15:59:13.865+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 15:59:13.880+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 15:59:13.995+0900 I/CAPI_WATCH_APPLICATION(15237): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:59:14.050+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 15:59:14.310+0900 W/CRASH_MANAGER(15596): worker.c: worker_job(1199) > 1115237737472145327315
