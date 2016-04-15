S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 17869
Date: 2016-01-20 16:22:40+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x20

Register Information
r0   = 0x00000000, r1   = 0x44b417e8
r2   = 0x44b417e8, r3   = 0x00000000
r4   = 0x44b417e8, r5   = 0x43945360
r6   = 0x43915858, r7   = 0xbe8ef1e8
r8   = 0x44b53e68, r9   = 0x44b417e8
r10  = 0xbe8ef298, fp   = 0x00000000
ip   = 0x402243d1, sp   = 0xbe8ef1d0
lr   = 0x400f2973, pc   = 0x417a578e
cpsr = 0x00000030

Memory Information
MemTotal:   491012 KB
MemFree:     30428 KB
Buffers:     11464 KB
Cached:     109028 KB
VmPeak:      89984 KB
VmSize:      88964 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18332 KB
VmRSS:       18332 KB
VmData:      30428 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23864 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17869 TID = 17869
17869 17937 17943 

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
41ed9000 41ee4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41eec000 41eee000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41ef6000 41efd000 rw-p [heap]
41efd000 4202f000 rw-p [heap]
439e9000 441e8000 rwxp [stack:17937]
442f4000 44af3000 rwxp [stack:17943]
44af3000 44af4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44c00000 44c17000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
be8cf000 be8f0000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17869)
Call Stack Count: 1
 0: naviframe_pop_cb + 0x11 (0x417a578e) [/opt/usr/apps/org.tizen.stretchtime/bin/stretchtime] + 0x3478e
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
21:55.495+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.032817 0.893479 -0.185561 num: -1
01-20 16:21:55.495+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.705875
01-20 16:21:55.505+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2909, 8.748159, -1.141376, -3.237489, 9.164684, -0.981819, -3.106383, -0.169821, 0.059865, -0.058643, -0.124728, -0.057005, -0.009607, -0.025050, 1.167849, -0.599360, 0.282509, 0.940665, -0.226962, -0.007216, 0.006391, -0.003301, -0.010393, 0.000518, -0.006709
01-20 16:21:55.505+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.025050 1.167849 -0.599360 num: 17
01-20 16:21:55.505+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.251512 0.831823 -0.712845 num: 17
01-20 16:21:55.505+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.114164 0.333429 0.568357 num: -1
01-20 16:21:55.505+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.105650
01-20 16:21:55.515+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2918, 8.870193, -0.744168, -3.223132, 9.130135, -0.955569, -3.120512, -0.018326, -0.089186, 0.059865, -0.095983, -0.065699, 0.009162, -0.263422, 0.837161, -0.494057, 0.255006, 0.933123, -0.257041, -0.007227, 0.006425, -0.003321, -0.010383, 0.000556, -0.006720
01-20 16:21:55.515+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.263422 0.837161 -0.494057 num: 17
01-20 16:21:55.515+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.025050 1.167849 -0.599360 num: 17
01-20 16:21:55.515+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.251512 0.831823 -0.712845 num: 17
01-20 16:21:55.515+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.444027
01-20 16:21:55.525+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2929, 9.454042, -0.497707, -2.914458, 9.165270, -0.914175, -3.107032, 0.074526, -0.156382, 0.101404, -0.049919, -0.090197, 0.034081, -0.121961, 0.334205, 0.002956, 0.249043, 0.879897, -0.225254, -0.007234, 0.006445, -0.003321, -0.010368, 0.000609, -0.006733
01-20 16:21:55.525+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.121961 0.334205 0.002956 num: -1
01-20 16:21:55.525+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.263422 0.837161 -0.494057 num: 17
01-20 16:21:55.525+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.025050 1.167849 -0.599360 num: 17
01-20 16:21:55.530+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.675821
01-20 16:21:55.535+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2938, 9.506684, -0.442672, -2.859423, 9.202229, -0.872068, -3.089561, 0.043982, -0.112399, 0.097738, -0.024551, -0.096195, 0.051279, -0.111086, 0.234944, 0.041389, 0.243436, 0.822856, -0.192688, -0.007239, 0.006455, -0.003320, -0.010358, 0.000643, -0.006741
01-20 16:21:55.535+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.111086 0.234944 0.041389 num: -1
01-20 16:21:55.535+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.121961 0.334205 0.002956 num: -1
01-20 16:21:55.535+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.263422 0.837161 -0.494057 num: 17
01-20 16:21:55.535+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 1.626069
01-20 16:21:55.545+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2949, 9.260223, -0.559920, -3.108276, 9.207905, -0.841053, -3.096028, -0.042761, -0.074526, 0.065973, -0.029470, -0.090341, 0.055249, -0.243946, 0.516898, -0.139636, 0.223118, 0.793098, -0.184676, -0.007253, 0.006486, -0.003328, -0.010345, 0.000691, -0.006752
01-20 16:21:55.550+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.243946 0.516898 -0.139636 num: -1
01-20 16:21:55.550+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.111086 0.234944 0.041389 num: -1
01-20 16:21:55.550+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.121961 0.334205 0.002956 num: -1
01-20 16:21:55.550+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 1.207314
01-20 16:21:55.575+0900 D/stretch (17756): read_model_from_file(396) > error! can not open the file 'hmm_up' in read_model_from_file
01-20 16:21:55.595+0900 D/stretch (17756): PrintSymbols(157) > Sequence: 6,9,10,9,2,12,9,5,11,12,10,6,7,3,7,4,7,18,10,9,19,
01-20 16:21:55.595+0900 D/stretch (17756): PrintSymbols(157) > Sequence: 6,7,14,3,4,18,13,16,13,9,2,17,2,5,19,5,19,2,5,2,19,
01-20 16:21:55.595+0900 D/stretch (17756): PrintSymbols(157) > Sequence: 17,14,17,14,17,14,17,6,3,14,3,14,3,14,3,6,17,
01-20 16:21:55.600+0900 D/stretch (17756): stretching_sensor_cb(106) > Sequence generate! (59 / 0)
01-20 16:21:55.970+0900 W/CRASH_MANAGER(17924): worker.c: worker_job(1199) > 11177567374721453274515
01-20 16:21:56.065+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 16:21:56.065+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(17756) is dead. cmd(4) is canceled
01-20 16:21:56.070+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 16:21:56.085+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:21:56.105+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:21:56.105+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 16:21:56.105+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 16:21:56.125+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 16:21:56.125+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 16:21:56.125+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 16:21:56.140+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
01-20 16:21:56.180+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
01-20 16:21:56.180+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.180+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.180+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.180+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(0)
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.210+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(0)
01-20 16:21:56.210+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
01-20 16:21:56.210+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-20 16:21:56.210+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.210+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
01-20 16:21:56.210+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
01-20 16:21:56.210+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:21:56.250+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
01-20 16:21:56.250+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 16:21:56.250+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 16:21:56.250+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-20 16:21:56.335+0900 I/efl-extension(17869): efl_extension.c: eext_mod_init(40) > Init
01-20 16:21:56.340+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 16:21:56.340+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 16:21:56.340+0900 I/UXT     (17869): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 16:21:56.375+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 16:21:56.420+0900 E/TBM     (17869): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 16:21:56.435+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:21:56.435+0900 W/AUL_AMD (  519): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-20 16:21:56.435+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 17756
01-20 16:21:56.500+0900 W/WATCH_CORE(17869): appcore-watch.c: __widget_create(958) > widget_create
01-20 16:21:56.500+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263172:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:21:56.500+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263172:4] gbar_fname[]
01-20 16:21:56.500+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [5700.039551] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263172:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:21:56.500+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5700.039551] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_5700.039551.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263172:4] gbar_fname[]
01-20 16:21:56.500+0900 D/stretch (17869): Create analog watch
01-20 16:21:56.520+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:21:56.520+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:21:56.580+0900 D/stretch (17869): Time : 4 : 21 : 56
01-20 16:21:56.580+0900 W/WATCH_CORE(17869): appcore-watch.c: __widget_create(976) > widget_create done
01-20 16:21:56.640+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b7560] swap changed from async to sync
01-20 16:21:56.660+0900 I/WATCH_CORE(17869): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 16:21:56.660+0900 I/WATCH_CORE(17869): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 16:21:56.665+0900 I/WATCH_CORE(17869): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 16:21:56.700+0900 E/EFL     (17869): edje<17869> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 16:21:56.705+0900 W/WATCH_CORE(17869): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 16:21:56.735+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:21:56.735+0900 D/stretch (17869): Time : 4 : 21 : 56
01-20 16:21:57.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:21:57.000+0900 D/stretch (17869): Time : 4 : 21 : 57
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:21:57.250+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.250+0900 E/CAPI_APPFW_APP_CONTROL( 1027): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-20 16:21:57.250+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1027]   value = [true][0m
01-20 16:21:57.250+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:21:57.255+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 812
01-20 16:21:57.255+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:21:57.260+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
01-20 16:21:57.265+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 16:21:57.265+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 16:21:57.265+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 16:21:57.265+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 16:21:57.270+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:21:57.270+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.270+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 16:21:57.270+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 16:21:57.275+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1027]   [MUSIC_PLAYER_EVENT][0m
01-20 16:21:57.275+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-20 16:21:57.275+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-20 16:21:57.275+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_int(1132) > preference_get_int(1027) : key(music-control-service_native/playing_diration) error
01-20 16:21:57.275+0900 W/MUSIC_CONTROL_SERVICE( 1027): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:1027]   preference_get_int() .. [0xfef00030][0m
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-20 16:21:57.275+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 16:21:57.275+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-20 16:21:57.275+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 16:21:57.450+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:21:57.455+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17869
01-20 16:21:57.455+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:21:57.475+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:21:57.480+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17869
01-20 16:21:57.480+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:21:57.700+0900 I/AUL_PAD (17946): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 16:21:57.995+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:21:58.000+0900 D/stretch (17869): Time : 4 : 21 : 58
01-20 16:21:58.995+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:21:59.000+0900 D/stretch (17869): Time : 4 : 21 : 59
01-20 16:21:59.995+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:21:59.995+0900 D/stretch (17869): Time : 4 : 22 : 0
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:22:00.825+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 16:22:00.995+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:00.995+0900 D/stretch (17869): Time : 4 : 22 : 1
01-20 16:22:01.605+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 16:22:01.605+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 16:22:01.995+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:01.995+0900 D/stretch (17869): Time : 4 : 22 : 2
01-20 16:22:03.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:03.000+0900 D/stretch (17869): Time : 4 : 22 : 3
01-20 16:22:04.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:04.000+0900 D/stretch (17869): Time : 4 : 22 : 4
01-20 16:22:05.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:05.000+0900 D/stretch (17869): Time : 4 : 22 : 5
01-20 16:22:06.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:06.000+0900 D/stretch (17869): Time : 4 : 22 : 6
01-20 16:22:07.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:07.000+0900 D/stretch (17869): Time : 4 : 22 : 7
01-20 16:22:08.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:08.010+0900 D/stretch (17869): Time : 4 : 22 : 8
01-20 16:22:09.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:09.005+0900 D/stretch (17869): Time : 4 : 22 : 9
01-20 16:22:10.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:10.005+0900 D/stretch (17869): Time : 4 : 22 : 10
01-20 16:22:11.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:11.006+0900 D/stretch (17869): Time : 4 : 22 : 11
01-20 16:22:12.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:12.010+0900 D/stretch (17869): Time : 4 : 22 : 12
01-20 16:22:13.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:13.005+0900 D/stretch (17869): Time : 4 : 22 : 13
01-20 16:22:14.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:14.005+0900 D/stretch (17869): Time : 4 : 22 : 14
01-20 16:22:15.005+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:15.005+0900 D/stretch (17869): Time : 4 : 22 : 15
01-20 16:22:16.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:16.011+0900 D/stretch (17869): Time : 4 : 22 : 16
01-20 16:22:17.000+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:17.005+0900 D/stretch (17869): Time : 4 : 22 : 17
01-20 16:22:18.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:18.011+0900 D/stretch (17869): Time : 4 : 22 : 18
01-20 16:22:19.006+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:22:19.006+0900 D/stretch (17869): Time : 4 : 22 : 19
01-20 16:22:20.001+0900 I/CAPI_WATCH_APPLICATION(17869): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
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
01-20 16:22:40.880+0900 W/CRASH_MANAGER(18009): worker.c: worker_job(1199) > 1117869737472145327456
