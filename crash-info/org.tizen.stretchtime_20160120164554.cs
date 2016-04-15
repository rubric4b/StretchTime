S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 18068
Date: 2016-01-20 16:45:54+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3acc

Register Information
r0   = 0x00000006, r1   = 0xbebe82c8
r2   = 0xbebc1435, r3   = 0x417a7925
r4   = 0xbebe8530, r5   = 0xbebe82c8
r6   = 0x00000132, r7   = 0x418a14d0
r8   = 0x4030b9c0, r9   = 0x41ccade8
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x41855320, sp   = 0xbebe82a0
lr   = 0x417a7935, pc   = 0x00003acc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     13804 KB
Buffers:     12908 KB
Cached:     122136 KB
VmPeak:      79196 KB
VmSize:      78684 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15360 KB
VmRSS:       15360 KB
VmData:      22196 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23716 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 18068 TID = 18068
18068 18623 18628 

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
41c8c000 41c92000 rw-p [heap]
41c92000 41dc4000 rw-p [heap]
4334b000 43357000 r-xp /usr/lib/libwidget_service.so.1.0.0
4335f000 43368000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43371000 43378000 r-xp /usr/lib/libsensord-share.so
43380000 43392000 r-xp /usr/lib/libtts.so
4339a000 433bb000 r-xp /usr/lib/libui-extension.so.0.1.0
433c4000 433cb000 r-xp /usr/lib/libtbm.so.1.0.0
433d3000 433e1000 r-xp /usr/lib/libGLESv2.so.2.0
433ea000 433eb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
433f4000 433fa000 r-xp /usr/lib/libxcb-render.so.0.0.0
43402000 43405000 r-xp /usr/lib/libEGL.so.1.4
4340d000 43415000 r-xp /usr/lib/libdrm.so.2.4.0
4341d000 4341f000 r-xp /usr/lib/libdri2.so.0.0.0
43427000 4342a000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43432000 43437000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43440000 43445000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4344d000 4346e000 r-xp /usr/lib/libexif.so.12.3.3
43481000 43486000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4348e000 43558000 r-xp /usr/lib/libCOREGL.so.4.0
4399d000 4419c000 rwxp [stack:18623]
4419c000 4419f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
441a7000 441b2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
442d6000 44ad5000 rwxp [stack:18628]
bebc8000 bebe9000 rwxp [stack]
End of Maps Information

Callstack Information (PID:18068)
Call Stack Count: 1
 0: (0x3acc) (null)
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
4): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:27.006+0900 D/stretch (18034): Time : 4 : 43 : 27
01-20 16:43:28.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:28.005+0900 D/stretch (18034): Time : 4 : 43 : 28
01-20 16:43:29.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:29.005+0900 D/stretch (18034): Time : 4 : 43 : 29
01-20 16:43:30.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:30.006+0900 D/stretch (18034): Time : 4 : 43 : 30
01-20 16:43:31.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:31.006+0900 D/stretch (18034): Time : 4 : 43 : 31
01-20 16:43:32.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:32.001+0900 D/stretch (18034): Time : 4 : 43 : 32
01-20 16:43:33.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:33.005+0900 D/stretch (18034): Time : 4 : 43 : 33
01-20 16:43:34.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:34.006+0900 D/stretch (18034): Time : 4 : 43 : 34
01-20 16:43:35.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:35.001+0900 D/stretch (18034): Time : 4 : 43 : 35
01-20 16:43:36.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:36.005+0900 D/stretch (18034): Time : 4 : 43 : 36
01-20 16:43:37.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:37.006+0900 D/stretch (18034): Time : 4 : 43 : 37
01-20 16:43:38.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:38.006+0900 D/stretch (18034): Time : 4 : 43 : 38
01-20 16:43:39.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:39.006+0900 D/stretch (18034): Time : 4 : 43 : 39
01-20 16:43:40.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:40.005+0900 D/stretch (18034): Time : 4 : 43 : 40
01-20 16:43:41.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:41.006+0900 D/stretch (18034): Time : 4 : 43 : 41
01-20 16:43:42.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:42.001+0900 D/stretch (18034): Time : 4 : 43 : 42
01-20 16:43:43.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:43.011+0900 D/stretch (18034): Time : 4 : 43 : 43
01-20 16:43:44.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:44.005+0900 D/stretch (18034): Time : 4 : 43 : 44
01-20 16:43:45.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:45.005+0900 D/stretch (18034): Time : 4 : 43 : 45
01-20 16:43:46.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:46.005+0900 D/stretch (18034): Time : 4 : 43 : 46
01-20 16:43:47.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:47.000+0900 D/stretch (18034): Time : 4 : 43 : 47
01-20 16:43:48.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:48.005+0900 D/stretch (18034): Time : 4 : 43 : 48
01-20 16:43:49.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:49.005+0900 D/stretch (18034): Time : 4 : 43 : 49
01-20 16:43:50.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:50.005+0900 D/stretch (18034): Time : 4 : 43 : 50
01-20 16:43:51.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:51.006+0900 D/stretch (18034): Time : 4 : 43 : 51
01-20 16:43:52.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:52.000+0900 D/stretch (18034): Time : 4 : 43 : 52
01-20 16:43:53.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:53.005+0900 D/stretch (18034): Time : 4 : 43 : 53
01-20 16:43:54.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:54.006+0900 D/stretch (18034): Time : 4 : 43 : 54
01-20 16:43:55.011+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:55.011+0900 D/stretch (18034): Time : 4 : 43 : 55
01-20 16:43:56.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:56.005+0900 D/stretch (18034): Time : 4 : 43 : 56
01-20 16:43:57.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:57.006+0900 D/stretch (18034): Time : 4 : 43 : 57
01-20 16:43:58.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:58.006+0900 D/stretch (18034): Time : 4 : 43 : 58
01-20 16:43:59.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:43:59.006+0900 D/stretch (18034): Time : 4 : 43 : 59
01-20 16:44:00.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:00.011+0900 D/stretch (18034): Time : 4 : 44 : 0
01-20 16:44:00.856+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 16:44:00.856+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 16:44:00.866+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 16:44:00.866+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:44:00.866+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:44:00.871+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 16:44:00.871+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:44:00.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:44:00.876+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 16:44:01.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:01.001+0900 D/stretch (18034): Time : 4 : 44 : 1
01-20 16:44:01.616+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 16:44:01.616+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 16:44:02.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:02.000+0900 D/stretch (18034): Time : 4 : 44 : 2
01-20 16:44:03.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:03.006+0900 D/stretch (18034): Time : 4 : 44 : 3
01-20 16:44:04.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:04.006+0900 D/stretch (18034): Time : 4 : 44 : 4
01-20 16:44:05.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:05.006+0900 D/stretch (18034): Time : 4 : 44 : 5
01-20 16:44:06.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:06.006+0900 D/stretch (18034): Time : 4 : 44 : 6
01-20 16:44:07.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:07.006+0900 D/stretch (18034): Time : 4 : 44 : 7
01-20 16:44:08.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:08.011+0900 D/stretch (18034): Time : 4 : 44 : 8
01-20 16:44:09.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:09.005+0900 D/stretch (18034): Time : 4 : 44 : 9
01-20 16:44:10.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:10.006+0900 D/stretch (18034): Time : 4 : 44 : 10
01-20 16:44:11.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:11.005+0900 D/stretch (18034): Time : 4 : 44 : 11
01-20 16:44:12.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:12.001+0900 D/stretch (18034): Time : 4 : 44 : 12
01-20 16:44:13.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:13.010+0900 D/stretch (18034): Time : 4 : 44 : 13
01-20 16:44:14.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:14.005+0900 D/stretch (18034): Time : 4 : 44 : 14
01-20 16:44:15.011+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:15.011+0900 D/stretch (18034): Time : 4 : 44 : 15
01-20 16:44:16.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:16.006+0900 D/stretch (18034): Time : 4 : 44 : 16
01-20 16:44:17.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:17.006+0900 D/stretch (18034): Time : 4 : 44 : 17
01-20 16:44:18.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:18.006+0900 D/stretch (18034): Time : 4 : 44 : 18
01-20 16:44:19.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:19.005+0900 D/stretch (18034): Time : 4 : 44 : 19
01-20 16:44:20.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:20.006+0900 D/stretch (18034): Time : 4 : 44 : 20
01-20 16:44:20.271+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:44:20.276+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:44:20.286+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:44:20.286+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:44:21.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:21.005+0900 D/stretch (18034): Time : 4 : 44 : 21
01-20 16:44:22.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:22.006+0900 D/stretch (18034): Time : 4 : 44 : 22
01-20 16:44:23.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:23.010+0900 D/stretch (18034): Time : 4 : 44 : 23
01-20 16:44:23.396+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:44:23.396+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:44:23.406+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:44:23.406+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:44:23.436+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 16:44:23 5일 전[0;m
01-20 16:44:23.446+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 16:44:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:44:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:44:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:44:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:44:23.461+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 16:44:24.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:24.005+0900 D/stretch (18034): Time : 4 : 44 : 24
01-20 16:44:25.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:25.005+0900 D/stretch (18034): Time : 4 : 44 : 25
01-20 16:44:26.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:26.006+0900 D/stretch (18034): Time : 4 : 44 : 26
01-20 16:44:27.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:27.001+0900 D/stretch (18034): Time : 4 : 44 : 27
01-20 16:44:28.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:28.006+0900 D/stretch (18034): Time : 4 : 44 : 28
01-20 16:44:29.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:29.006+0900 D/stretch (18034): Time : 4 : 44 : 29
01-20 16:44:30.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:30.006+0900 D/stretch (18034): Time : 4 : 44 : 30
01-20 16:44:31.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:31.010+0900 D/stretch (18034): Time : 4 : 44 : 31
01-20 16:44:32.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:32.001+0900 D/stretch (18034): Time : 4 : 44 : 32
01-20 16:44:33.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:33.006+0900 D/stretch (18034): Time : 4 : 44 : 33
01-20 16:44:34.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:34.005+0900 D/stretch (18034): Time : 4 : 44 : 34
01-20 16:44:35.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:35.006+0900 D/stretch (18034): Time : 4 : 44 : 35
01-20 16:44:36.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:36.006+0900 D/stretch (18034): Time : 4 : 44 : 36
01-20 16:44:37.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:37.006+0900 D/stretch (18034): Time : 4 : 44 : 37
01-20 16:44:38.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:38.006+0900 D/stretch (18034): Time : 4 : 44 : 38
01-20 16:44:39.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:39.006+0900 D/stretch (18034): Time : 4 : 44 : 39
01-20 16:44:40.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:40.006+0900 D/stretch (18034): Time : 4 : 44 : 40
01-20 16:44:41.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:41.005+0900 D/stretch (18034): Time : 4 : 44 : 41
01-20 16:44:42.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:42.000+0900 D/stretch (18034): Time : 4 : 44 : 42
01-20 16:44:43.010+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:43.010+0900 D/stretch (18034): Time : 4 : 44 : 43
01-20 16:44:44.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:44.005+0900 D/stretch (18034): Time : 4 : 44 : 44
01-20 16:44:45.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:45.011+0900 D/stretch (18034): Time : 4 : 44 : 45
01-20 16:44:46.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:46.006+0900 D/stretch (18034): Time : 4 : 44 : 46
01-20 16:44:47.010+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:47.010+0900 D/stretch (18034): Time : 4 : 44 : 47
01-20 16:44:48.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:48.006+0900 D/stretch (18034): Time : 4 : 44 : 48
01-20 16:44:49.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:49.006+0900 D/stretch (18034): Time : 4 : 44 : 49
01-20 16:44:50.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:50.006+0900 D/stretch (18034): Time : 4 : 44 : 50
01-20 16:44:51.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:51.005+0900 D/stretch (18034): Time : 4 : 44 : 51
01-20 16:44:52.000+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:52.000+0900 D/stretch (18034): Time : 4 : 44 : 52
01-20 16:44:53.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:53.006+0900 D/stretch (18034): Time : 4 : 44 : 53
01-20 16:44:54.011+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:54.011+0900 D/stretch (18034): Time : 4 : 44 : 54
01-20 16:44:55.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:55.005+0900 D/stretch (18034): Time : 4 : 44 : 55
01-20 16:44:56.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:56.006+0900 D/stretch (18034): Time : 4 : 44 : 56
01-20 16:44:57.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:57.005+0900 D/stretch (18034): Time : 4 : 44 : 57
01-20 16:44:58.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:58.011+0900 D/stretch (18034): Time : 4 : 44 : 58
01-20 16:44:59.011+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:44:59.011+0900 D/stretch (18034): Time : 4 : 44 : 59
01-20 16:45:00.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:00.011+0900 D/stretch (18034): Time : 4 : 45 : 0
01-20 16:45:00.915+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 16:45:00.915+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 16:45:00.925+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 16:45:00.925+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:45:00.931+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:45:00.931+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 16:45:00.936+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:45:00.946+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:45:00.946+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 16:45:01.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:01.001+0900 D/stretch (18034): Time : 4 : 45 : 1
01-20 16:45:01.666+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 16:45:01.666+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 16:45:02.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:02.001+0900 D/stretch (18034): Time : 4 : 45 : 2
01-20 16:45:03.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:03.010+0900 D/stretch (18034): Time : 4 : 45 : 3
01-20 16:45:04.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:04.006+0900 D/stretch (18034): Time : 4 : 45 : 4
01-20 16:45:04.776+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 88 -> 87 1453275904 1082
01-20 16:45:04.786+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 87 655 267 950
01-20 16:45:04.786+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 87 0 0 1087
01-20 16:45:04.786+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 87 807 732 1170
01-20 16:45:04.786+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 87 288 5 418
01-20 16:45:04.786+0900 I/RESOURCED(  521): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 87 278 12 403
01-20 16:45:05.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:05.006+0900 D/stretch (18034): Time : 4 : 45 : 5
01-20 16:45:06.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:06.006+0900 D/stretch (18034): Time : 4 : 45 : 6
01-20 16:45:07.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:07.006+0900 D/stretch (18034): Time : 4 : 45 : 7
01-20 16:45:08.010+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:08.010+0900 D/stretch (18034): Time : 4 : 45 : 8
01-20 16:45:09.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:09.011+0900 D/stretch (18034): Time : 4 : 45 : 9
01-20 16:45:10.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:10.005+0900 D/stretch (18034): Time : 4 : 45 : 10
01-20 16:45:11.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:11.011+0900 D/stretch (18034): Time : 4 : 45 : 11
01-20 16:45:12.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:12.001+0900 D/stretch (18034): Time : 4 : 45 : 12
01-20 16:45:13.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:13.011+0900 D/stretch (18034): Time : 4 : 45 : 13
01-20 16:45:14.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:14.006+0900 D/stretch (18034): Time : 4 : 45 : 14
01-20 16:45:15.016+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:15.016+0900 D/stretch (18034): Time : 4 : 45 : 15
01-20 16:45:16.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:16.006+0900 D/stretch (18034): Time : 4 : 45 : 16
01-20 16:45:17.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:17.005+0900 D/stretch (18034): Time : 4 : 45 : 17
01-20 16:45:18.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:18.006+0900 D/stretch (18034): Time : 4 : 45 : 18
01-20 16:45:19.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:19.005+0900 D/stretch (18034): Time : 4 : 45 : 19
01-20 16:45:20.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:20.011+0900 D/stretch (18034): Time : 4 : 45 : 20
01-20 16:45:20.246+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:45:20.251+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:45:20.261+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:45:20.261+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:45:21.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:21.005+0900 D/stretch (18034): Time : 4 : 45 : 21
01-20 16:45:22.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:22.005+0900 D/stretch (18034): Time : 4 : 45 : 22
01-20 16:45:23.011+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:23.011+0900 D/stretch (18034): Time : 4 : 45 : 23
01-20 16:45:23.396+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:45:23.396+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:45:23.406+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:45:23.406+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:45:23.436+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 16:45:23 5일 전[0;m
01-20 16:45:23.446+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 16:45:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:45:23.446+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:45:23.451+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:45:23.451+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:45:23.461+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 16:45:24.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:24.006+0900 D/stretch (18034): Time : 4 : 45 : 24
01-20 16:45:25.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:25.006+0900 D/stretch (18034): Time : 4 : 45 : 25
01-20 16:45:26.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:26.006+0900 D/stretch (18034): Time : 4 : 45 : 26
01-20 16:45:27.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:27.006+0900 D/stretch (18034): Time : 4 : 45 : 27
01-20 16:45:28.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:28.006+0900 D/stretch (18034): Time : 4 : 45 : 28
01-20 16:45:29.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:29.006+0900 D/stretch (18034): Time : 4 : 45 : 29
01-20 16:45:30.005+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:30.005+0900 D/stretch (18034): Time : 4 : 45 : 30
01-20 16:45:31.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:31.006+0900 D/stretch (18034): Time : 4 : 45 : 31
01-20 16:45:32.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:32.001+0900 D/stretch (18034): Time : 4 : 45 : 32
01-20 16:45:33.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:33.001+0900 D/stretch (18034): Time : 4 : 45 : 33
01-20 16:45:34.006+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:34.006+0900 D/stretch (18034): Time : 4 : 45 : 34
01-20 16:45:35.001+0900 I/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:35.001+0900 D/stretch (18034): Time : 4 : 45 : 35
01-20 16:45:35.226+0900 E/PKGMGR_SERVER(18618): pkgmgr-server.c: main(2126) > package manager server start
01-20 16:45:35.311+0900 E/PKGMGR_SERVER(18618): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_736053273], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 16:45:35.316+0900 E/PKGMGR_SERVER(18620): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 16:45:35.321+0900 E/PKGMGR  (18611): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 16:45:35.391+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:45:35.401+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18034
01-20 16:45:35.401+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:45:35.406+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 16:45:35.406+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17773) is dead. cmd(5) is canceled
01-20 16:45:35.406+0900 E/PKGMGR_SERVER(18620): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-20 16:45:35.406+0900 E/PKGMGR_SERVER(18620): [0;m
01-20 16:45:35.411+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 16:45:35.411+0900 W/CAPI_WATCH_APPLICATION(18034): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 16:45:35.411+0900 D/stretch (18034): Destroy analog watch
01-20 16:45:35.411+0900 W/WATCH_CORE(18034): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 16:45:35.416+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 16:45:35.416+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 16:45:35.416+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(18034), cmd(4)
01-20 16:45:35.416+0900 E/WIDGET_PROVIDER_APP(18034): client.c: client_fini(1175) > Provider is not initialized
01-20 16:45:35.416+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:45:35.421+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18034
01-20 16:45:35.426+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 16:45:35.431+0900 I/efl-extension(18034): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 16:45:35.526+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:45:35.566+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 16:45:35.591+0900 E/PKGMGR_SERVER(18620): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 16:45:35.631+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 16:45:35.631+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(18034), cmd(4)
01-20 16:45:35.636+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 16:45:35.676+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:45:35.696+0900 E/PKGMGR_SERVER(18618): pkgmgr-server.c: sighandler(445) > child NORMAL exit [18620]
01-20 16:45:35.701+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:45:35.706+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 16:45:35.706+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 16:45:35.721+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 16:45:35.721+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 16:45:35.721+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 16:45:35.791+0900 I/efl-extension(18068): efl_extension.c: eext_mod_init(40) > Init
01-20 16:45:35.791+0900 I/UXT     (18068): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 16:45:35.811+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 16:45:35.826+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 16:45:35.826+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 16:45:35.826+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 18034
01-20 16:45:35.851+0900 E/TBM     (18068): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 16:45:35.896+0900 W/WATCH_CORE(18068): appcore-watch.c: __widget_create(958) > widget_create
01-20 16:45:35.896+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263184:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:45:35.896+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263184:4] gbar_fname[]
01-20 16:45:35.896+0900 D/stretch (18068): Create analog watch
01-20 16:45:35.896+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263184:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:45:35.896+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263184:4] gbar_fname[]
01-20 16:45:35.911+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:45:35.911+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:45:35.911+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:45:35.911+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:45:35.966+0900 D/stretch (18068): Time : 4 : 45 : 35
01-20 16:45:35.966+0900 W/WATCH_CORE(18068): appcore-watch.c: __widget_create(976) > widget_create done
01-20 16:45:36.036+0900 I/WATCH_CORE(18068): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 16:45:36.036+0900 I/WATCH_CORE(18068): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 16:45:36.041+0900 I/WATCH_CORE(18068): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 16:45:36.071+0900 E/EFL     (18068): edje<18068> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 16:45:36.081+0900 W/WATCH_CORE(18068): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 16:45:36.111+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:36.111+0900 D/stretch (18068): Time : 4 : 45 : 36
01-20 16:45:36.831+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:45:36.831+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 16:45:36.846+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:45:36.856+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18068
01-20 16:45:36.856+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:45:36.866+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:45:36.876+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18068
01-20 16:45:36.876+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:45:36.996+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:36.996+0900 D/stretch (18068): Time : 4 : 45 : 37
01-20 16:45:37.056+0900 I/AUL_PAD (18642): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 16:45:37.091+0900 E/PKGMGR_SERVER(18618): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 16:45:37.091+0900 E/PKGMGR_SERVER(18618): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 16:45:37.416+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 16:45:38.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:38.001+0900 D/stretch (18068): Time : 4 : 45 : 38
01-20 16:45:39.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:39.001+0900 D/stretch (18068): Time : 4 : 45 : 39
01-20 16:45:40.006+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:40.011+0900 D/stretch (18068): Time : 4 : 45 : 40
01-20 16:45:41.011+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:41.021+0900 D/stretch (18068): Time : 4 : 45 : 41
01-20 16:45:42.011+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:42.011+0900 D/stretch (18068): Time : 4 : 45 : 42
01-20 16:45:43.006+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:43.011+0900 D/stretch (18068): Time : 4 : 45 : 43
01-20 16:45:44.011+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:44.011+0900 D/stretch (18068): Time : 4 : 45 : 44
01-20 16:45:45.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:45.006+0900 D/stretch (18068): Time : 4 : 45 : 45
01-20 16:45:46.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:46.001+0900 D/stretch (18068): Time : 4 : 45 : 46
01-20 16:45:47.006+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:47.006+0900 D/stretch (18068): Time : 4 : 45 : 47
01-20 16:45:48.000+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:48.000+0900 D/stretch (18068): Time : 4 : 45 : 48
01-20 16:45:49.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:49.001+0900 D/stretch (18068): Time : 4 : 45 : 49
01-20 16:45:50.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:50.001+0900 D/stretch (18068): Time : 4 : 45 : 50
01-20 16:45:51.001+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:51.006+0900 D/stretch (18068): Time : 4 : 45 : 51
01-20 16:45:52.021+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:52.021+0900 D/stretch (18068): Time : 4 : 45 : 52
01-20 16:45:52.546+0900 E/PKGMGR  (18782): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 16:45:52.811+0900 E/PKGMGR_SERVER(18784): pkgmgr-server.c: main(2126) > package manager server start
01-20 16:45:52.906+0900 E/PKGMGR_SERVER(18784): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_753525000], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_753525000' '-r' 'org.tizen.stretchtime'], cookie=[1iEKN/B5rA4RNl+6t/tTbaHnAzY=], backend_flag=[0]
01-20 16:45:52.906+0900 E/PKGMGR  (18784): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 16:45:52.906+0900 E/PKGMGR_SERVER(18784): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 16:45:52.911+0900 E/PKGMGR  (18782): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[187820002]
01-20 16:45:52.916+0900 E/PKGMGR_SERVER(18785): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 16:45:52.996+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:53.001+0900 D/stretch (18068): Time : 4 : 45 : 53
01-20 16:45:53.116+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 16:45:53.136+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 16:45:53.156+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 16:45:53.996+0900 I/CAPI_WATCH_APPLICATION(18068): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:45:54.131+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 16:45:54.256+0900 W/CRASH_MANAGER(18794): worker.c: worker_job(1199) > 1118068737472145327595
