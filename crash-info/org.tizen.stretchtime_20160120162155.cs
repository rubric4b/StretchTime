S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 17756
Date: 2016-01-20 16:21:55+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17756, uid 5000)

Register Information
r0   = 0x44b82788, r1   = 0x7b5687a5
r2   = 0x41a55a54, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x00000001
r6   = 0x44b82788, r7   = 0x0000003b
r8   = 0x00000004, r9   = 0x40451824
r10  = 0x414dc200, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xbeaf9560
lr   = 0x41a01548, pc   = 0x41a01558
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     28612 KB
Buffers:     11276 KB
Cached:     108768 KB
VmPeak:      97204 KB
VmSize:      94916 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22628 KB
VmRSS:       22628 KB
VmData:      33416 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26000 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 17756 TID = 17756
17756 17856 17867 17912 

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
43965000 44164000 rwxp [stack:17856]
44164000 44167000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4416f000 4417a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4429e000 44a9d000 rwxp [stack:17867]
44a9d000 44aa8000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
44ab0000 44ac7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44ad4000 44ad6000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44ade000 44adf000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44ae7000 44ae8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44af0000 44af7000 r-xp /usr/lib/libfeedback.so.0.1.4
44c01000 45400000 rwxp [stack:17912]
456e7000 456e8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
456f0000 456f2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
456fa000 45704000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.48
4570c000 45713000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4571b000 45731000 r-xp /usr/lib/libmmfsound.so.0.1.0
45743000 45748000 r-xp /usr/lib/libmmfsession.so.0.0.0
45750000 4575a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45766000 4576a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45773000 45789000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45792000 45797000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4579f000 457a2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
457aa000 4580b000 r-xp /usr/lib/libasound.so.2.0.0
45815000 4584d000 r-xp /usr/lib/libpulse.so.0.16.2
4584e000 45851000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45859000 45866000 r-xp /usr/lib/libail.so.0.1.0
4586f000 4587f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
458a0000 458a8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
458b7000 458e8000 r-xp /usr/lib/libmdm.so.1.1.85
458f0000 458f3000 r-xp /usr/lib/libcompress.so.0.2.0
458fb000 45900000 r-xp /usr/lib/libjson.so.0.0.1
45908000 45950000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45951000 45994000 r-xp /usr/lib/libsndfile.so.1.0.25
459a1000 459a9000 r-xp /usr/lib/libmdm-common.so.1.0.89
459aa000 459cc000 r-xp /usr/lib/libvorbis.so.0.4.3
459d4000 459d8000 r-xp /usr/lib/libogg.so.0.7.1
beada000 beafb000 rwxp [stack]
End of Maps Information

Callstack Information (PID:17756)
Call Stack Count: 1
 0: ghmm_dmodel_generate_sequences + 0xc8 (0x41a01558) [/opt/usr/apps/org.tizen.stretchtime/bin/stretchtime] + 0x90558
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
7, 1.014036, -0.117888, 0.361215, 1.082092, -0.041575, 1.970093, -1.996025, -0.534040, 0.870211, -2.298792, -0.007895, 0.002376, -0.001986, -0.011248, -0.003037, -0.004611
01-20 16:21:54.955+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.041575 1.970093 -1.996025 num: 17
01-20 16:21:54.955+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.066492 1.744392 -2.062878 num: 17
01-20 16:21:54.955+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.059781 1.630795 -1.780181 num: 17
01-20 16:21:54.955+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 7.922181
01-20 16:21:54.965+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2370, 7.728817, -0.646062, -3.579663, 7.067297, 1.002520, -3.113888, 0.029322, 0.056200, 1.026254, -0.078119, 0.278814, 1.067007, -0.034635, 2.374083, -1.775496, -0.495653, 0.973556, -2.236714, -0.007897, 0.002547, -0.002114, -0.011284, -0.002967, -0.004772
01-20 16:21:54.965+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.034635 2.374083 -1.775496 num: 17
01-20 16:21:54.965+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.041575 1.970093 -1.996025 num: 17
01-20 16:21:54.965+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.066492 1.744392 -2.062878 num: 17
01-20 16:21:54.970+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 8.471974
01-20 16:21:54.975+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2377, 8.269595, -0.899701, -3.649055, 7.215476, 0.816966, -3.146645, -0.006109, 0.056200, 1.023810, -0.058665, 0.218673, 1.055337, 0.166377, 2.561341, -1.260432, -0.405391, 1.105036, -2.121983, -0.007893, 0.002610, -0.002145, -0.011294, -0.002940, -0.004824
01-20 16:21:54.975+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.166377 2.561341 -1.260432 num: 14
01-20 16:21:54.975+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.034635 2.374083 -1.775496 num: 17
01-20 16:21:54.975+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.041575 1.970093 -1.996025 num: 17
01-20 16:21:54.975+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 8.629124
01-20 16:21:54.985+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2390, 8.611769, -0.868595, -3.596412, 7.385046, 0.651022, -3.174413, -0.010996, 0.063530, 0.941954, -0.045787, 0.176760, 1.024706, 0.196056, 2.421407, -0.911035, -0.351416, 1.187747, -1.978754, -0.007877, 0.002814, -0.002222, -0.011323, -0.002839, -0.004991
01-20 16:21:54.985+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.196056 2.421407 -0.911035 num: 14
01-20 16:21:54.985+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.166377 2.561341 -1.260432 num: 14
01-20 16:21:54.985+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.034635 2.374083 -1.775496 num: 17
01-20 16:21:54.985+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 8.418826
01-20 16:21:54.995+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2397, 8.410772, -1.064806, -3.527020, 7.511406, 0.482052, -3.190445, 0.048869, 0.116064, 0.811229, -0.020215, 0.160363, 0.967034, 0.290630, 2.498532, -1.134290, -0.262366, 1.293334, -1.879601, -0.007870, 0.002875, -0.002250, -0.011330, -0.002808, -0.005037
01-20 16:21:54.995+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.290630 2.498532 -1.134290 num: 14
01-20 16:21:54.995+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.196056 2.421407 -0.911035 num: 14
01-20 16:21:54.995+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.166377 2.561341 -1.260432 num: 14
01-20 16:21:54.995+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 8.213358
01-20 16:21:55.005+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2409, 8.233703, -0.954736, -3.381058, 7.600988, 0.339596, -3.192664, 0.045204, 0.108734, 0.772134, -0.002541, 0.146415, 0.914380, 0.231068, 2.273585, -1.305626, -0.215039, 1.347726, -1.809500, -0.007853, 0.003039, -0.002344, -0.011345, -0.002711, -0.005168
01-20 16:21:55.005+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.231068 2.273585 -1.305626 num: 14
01-20 16:21:55.005+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.290630 2.498532 -1.134290 num: 14
01-20 16:21:55.005+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.196056 2.421407 -0.911035 num: 14
01-20 16:21:55.005+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 7.985806
01-20 16:21:55.015+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2417, 8.066205, -0.892523, -3.536592, 7.660613, 0.220493, -3.212430, 0.122173, 0.036652, 0.756251, 0.031151, 0.116762, 0.871661, 0.005406, 2.295778, -1.422057, -0.179438, 1.413606, -1.761138, -0.007853, 0.003113, -0.002389, -0.011351, -0.002665, -0.005224
01-20 16:21:55.015+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.005406 2.295778 -1.422057 num: 14
01-20 16:21:55.015+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.231068 2.273585 -1.305626 num: 14
01-20 16:21:55.015+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.290630 2.498532 -1.134290 num: 14
01-20 16:21:55.015+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 8.091799
01-20 16:21:55.025+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2428, 8.520842, -0.873380, -3.768696, 7.766326, 0.116638, -3.257293, 0.108734, -0.034208, 0.773355, 0.052111, 0.075976, 0.845103, -0.127459, 2.351811, -0.916272, -0.171925, 1.467271, -1.656763, -0.007861, 0.003255, -0.002445, -0.011361, -0.002577, -0.005324
01-20 16:21:55.030+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.127459 2.351811 -0.916272 num: 17
01-20 16:21:55.030+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.005406 2.295778 -1.422057 num: 14
01-20 16:21:55.030+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.231068 2.273585 -1.305626 num: 14
01-20 16:21:55.030+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 7.859713
01-20 16:21:55.035+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2440, 9.004191, -0.808774, -3.704089, 7.914800, 0.026621, -3.294726, 0.058643, 0.002443, 0.761138, 0.053875, 0.056111, 0.822419, -0.074621, 2.172566, -0.434781, -0.160323, 1.498216, -1.508349, -0.007866, 0.003411, -0.002476, -0.011373, -0.002469, -0.005433
01-20 16:21:55.035+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.074621 2.172566 -0.434781 num: 6
01-20 16:21:55.035+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.127459 2.351811 -0.916272 num: 17
01-20 16:21:55.035+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.005406 2.295778 -1.422057 num: 14
01-20 16:21:55.035+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 7.444647
01-20 16:21:55.045+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2448, 9.178867, -0.674776, -3.634698, 8.065108, -0.042753, -3.324455, 0.025656, 0.086743, 0.678060, 0.046252, 0.064386, 0.783420, -0.111390, 1.981602, -0.258568, -0.137515, 1.528243, -1.359526, -0.007869, 0.003475, -0.002484, -0.011377, -0.002420, -0.005476
01-20 16:21:55.050+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.111390 1.981602 -0.258568 num: 6
01-20 16:21:55.050+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.074621 2.172566 -0.434781 num: 6
01-20 16:21:55.050+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.127459 2.351811 -0.916272 num: 17
01-20 16:21:55.050+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 6.745617
01-20 16:21:55.055+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2457, 9.104690, -0.753739, -3.244668, 8.187858, -0.118108, -3.310317, -0.008552, 0.173486, 0.612087, 0.031446, 0.093860, 0.737133, 0.170369, 1.765293, -0.405559, -0.090397, 1.534081, -1.246681, -0.007863, 0.003546, -0.002501, -0.011381, -0.002358, -0.005527
01-20 16:21:55.055+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.170369 1.765293 -0.405559 num: 3
01-20 16:21:55.055+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.111390 1.981602 -0.258568 num: 6
01-20 16:21:55.055+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.074621 2.172566 -0.434781 num: 6
01-20 16:21:55.055+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 6.037677
01-20 16:21:55.065+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2470, 8.803195, -0.820738, -2.811567, 8.259831, -0.196936, -3.251896, -0.012217, 0.224798, 0.593761, 0.019650, 0.129234, 0.698400, 0.412937, 1.520668, -0.779184, -0.039746, 1.504594, -1.190369, -0.007828, 0.003675, -0.002567, -0.011384, -0.002231, -0.005627
01-20 16:21:55.070+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.412937 1.520668 -0.779184 num: 14
01-20 16:21:55.070+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.170369 1.765293 -0.405559 num: 3
01-20 16:21:55.070+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.111390 1.981602 -0.258568 num: 6
01-20 16:21:55.070+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.578638
01-20 16:21:55.075+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2478, 8.539984, -1.196411, -2.938386, 8.294708, -0.301436, -3.207023, -0.019548, 0.149051, 0.603535, 0.009061, 0.134588, 0.672772, 0.479750, 1.881119, -1.033407, 0.032266, 1.525139, -1.172421, -0.007812, 0.003735, -0.002600, -0.011383, -0.002182, -0.005665
01-20 16:21:55.075+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.479750 1.881119 -1.033407 num: 14
01-20 16:21:55.080+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.412937 1.520668 -0.779184 num: 14
01-20 16:21:55.080+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.170369 1.765293 -0.405559 num: 3
01-20 16:21:55.080+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.776385
01-20 16:21:55.090+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2490, 8.863015, -1.213161, -2.873780, 8.362599, -0.398537, -3.162433, -0.047647, 0.064752, 0.626748, -0.006259, 0.115721, 0.660338, 0.551542, 1.783577, -0.717561, 0.091345, 1.523905, -1.117917, -0.007773, 0.003863, -0.002651, -0.011377, -0.002072, -0.005745
01-20 16:21:55.090+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.551542 1.783577 -0.717561 num: 3
01-20 16:21:55.090+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.479750 1.881119 -1.033407 num: 14
01-20 16:21:55.090+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.412937 1.520668 -0.779184 num: 14
01-20 16:21:55.090+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.957170
01-20 16:21:55.095+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2499, 9.018548, -1.160519, -3.022135, 8.440836, -0.478417, -3.139967, -0.021991, 0.062308, 0.592539, -0.010509, 0.101291, 0.642022, 0.401323, 1.794776, -0.526844, 0.139461, 1.533630, -1.048063, -0.007756, 0.003936, -0.002673, -0.011371, -0.002010, -0.005788
01-20 16:21:55.095+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.401323 1.794776 -0.526844 num: 3
01-20 16:21:55.095+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.551542 1.783577 -0.717561 num: 3
01-20 16:21:55.095+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.479750 1.881119 -1.033407 num: 14
01-20 16:21:55.095+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 6.112381
01-20 16:21:55.105+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2508, 9.174082, -1.136591, -3.017349, 8.527727, -0.548032, -3.121039, -0.047647, 0.081856, 0.537561, -0.020543, 0.096041, 0.613801, 0.383956, 1.732421, -0.367184, 0.181552, 1.538187, -0.967685, -0.007741, 0.004006, -0.002687, -0.011364, -0.001948, -0.005827
01-20 16:21:55.110+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.383956 1.732421 -0.367184 num: 3
01-20 16:21:55.110+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.401323 1.794776 -0.526844 num: 3
01-20 16:21:55.110+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.551542 1.783577 -0.717561 num: 3
01-20 16:21:55.110+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.725183
01-20 16:21:55.115+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2517, 8.992228, -0.818345, -2.665605, 8.580832, -0.582835, -3.072486, -0.065973, 0.112399, 0.500910, -0.032816, 0.100460, 0.583303, 0.374600, 1.254468, -0.589764, 0.216871, 1.501074, -0.923216, -0.007726, 0.004057, -0.002711, -0.011355, -0.001887, -0.005865
01-20 16:21:55.115+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.374600 1.254468 -0.589764 num: 14
01-20 16:21:55.115+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.383956 1.732421 -0.367184 num: 3
01-20 16:21:55.115+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.401323 1.794776 -0.526844 num: 3
01-20 16:21:55.115+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.161033
01-20 16:21:55.125+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2529, 8.748159, -0.918844, -2.615355, 8.599718, -0.623116, -3.021734, -0.036652, 0.096517, 0.478918, -0.033852, 0.099395, 0.555103, 0.398211, 1.287591, -0.837094, 0.240622, 1.461400, -0.911363, -0.007697, 0.004150, -0.002772, -0.011338, -0.001782, -0.005930
01-20 16:21:55.125+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.398211 1.287591 -0.837094 num: 14
01-20 16:21:55.125+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.374600 1.254468 -0.589764 num: 14
01-20 16:21:55.125+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.383956 1.732421 -0.367184 num: 3
01-20 16:21:55.125+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.834526
01-20 16:21:55.135+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2537, 8.776874, -1.088734, -2.600998, 8.620344, -0.675782, -2.972937, 0.003665, 0.019548, 0.499688, -0.023717, 0.077824, 0.540132, 0.501100, 1.378097, -0.812562, 0.287341, 1.443734, -0.900193, -0.007681, 0.004194, -0.002798, -0.011328, -0.001735, -0.005959
01-20 16:21:55.135+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.501100 1.378097 -0.812562 num: 14
01-20 16:21:55.135+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.398211 1.287591 -0.837094 num: 14
01-20 16:21:55.140+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.374600 1.254468 -0.589764 num: 14
01-20 16:21:55.140+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.698932
01-20 16:21:55.145+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2548, 8.961121, -1.153341, -2.813959, 8.660959, -0.726581, -2.951333, 0.046426, -0.046426, 0.498466, -0.004767, 0.044257, 0.528876, 0.385960, 1.506760, -0.587034, 0.309078, 1.429550, -0.861446, -0.007658, 0.004285, -0.002833, -0.011310, -0.001649, -0.006011
01-20 16:21:55.145+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.385960 1.506760 -0.587034 num: 3
01-20 16:21:55.150+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.501100 1.378097 -0.812562 num: 14
01-20 16:21:55.150+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.398211 1.287591 -0.837094 num: 14
01-20 16:21:55.150+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.925521
01-20 16:21:55.155+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2557, 9.188439, -1.040878, -2.868994, 8.722919, -0.760789, -2.940528, 0.064752, -0.074526, 0.482584, 0.014014, 0.012167, 0.516370, 0.284508, 1.400113, -0.343898, 0.324508, 1.412875, -0.799324, -0.007646, 0.004342, -0.002847, -0.011297, -0.001592, -0.006043
01-20 16:21:55.155+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.284508 1.400113 -0.343898 num: 3
01-20 16:21:55.155+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.385960 1.506760 -0.587034 num: 3
01-20 16:21:55.155+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.501100 1.378097 -0.812562 num: 14
01-20 16:21:55.155+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.808489
01-20 16:21:55.165+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2569, 9.195618, -0.885344, -2.672783, 8.777155, -0.778556, -2.913210, 0.047647, -0.050091, 0.469145, 0.023100, -0.004652, 0.503611, 0.298667, 1.110644, -0.361554, 0.332584, 1.362684, -0.744969, -0.007625, 0.004422, -0.002873, -0.011273, -0.001494, -0.006097
01-20 16:21:55.165+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.298667 1.110644 -0.361554 num: 3
01-20 16:21:55.170+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.284508 1.400113 -0.343898 num: 3
01-20 16:21:55.170+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.385960 1.506760 -0.587034 num: 3
01-20 16:21:55.170+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.337624
01-20 16:21:55.175+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2577, 9.090333, -1.052842, -2.538785, 8.813036, -0.812087, -2.872313, -0.013439, -0.039095, 0.445932, 0.013229, -0.013957, 0.488029, 0.473800, 1.134616, -0.487980, 0.369907, 1.331231, -0.714784, -0.007609, 0.004458, -0.002889, -0.011261, -0.001451, -0.006120
01-20 16:21:55.175+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.473800 1.134616 -0.487980 num: 3
01-20 16:21:55.175+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.298667 1.110644 -0.361554 num: 3
01-20 16:21:55.175+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.284508 1.400113 -0.343898 num: 3
01-20 16:21:55.175+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.997988
01-20 16:21:55.185+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2590, 9.030513, -1.225125, -2.388037, 8.837910, -0.860564, -2.817904, -0.067195, -0.042761, 0.426384, -0.008498, -0.021739, 0.471375, 0.663842, 1.132371, -0.569255, 0.414010, 1.287435, -0.695760, -0.007553, 0.004554, -0.002937, -0.011226, -0.001342, -0.006179
01-20 16:21:55.185+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.663842 1.132371 -0.569255 num: 14
01-20 16:21:55.185+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.473800 1.134616 -0.487980 num: 3
01-20 16:21:55.185+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.298667 1.110644 -0.361554 num: 3
01-20 16:21:55.185+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.959190
01-20 16:21:55.195+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2598, 8.922836, -1.476372, -2.297110, 8.848007, -0.929188, -2.756450, -0.068417, -0.068417, 0.415388, -0.024686, -0.034349, 0.456250, 0.867295, 1.248933, -0.688948, 0.487770, 1.272476, -0.696349, -0.007526, 0.004594, -0.002959, -0.011210, -0.001302, -0.006201
01-20 16:21:55.195+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.867295 1.248933 -0.688948 num: 14
01-20 16:21:55.195+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.663842 1.132371 -0.569255 num: 14
01-20 16:21:55.195+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.473800 1.134616 -0.487980 num: 3
01-20 16:21:55.195+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.422934
01-20 16:21:55.205+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2608, 8.817552, -1.552942, -2.603391, 8.846136, -0.993078, -2.732030, -0.064752, -0.124617, 0.410501, -0.035510, -0.058735, 0.443891, 0.663921, 1.482400, -0.729859, 0.527252, 1.272004, -0.699450, -0.007492, 0.004668, -0.002995, -0.011184, -0.001238, -0.006236
01-20 16:21:55.205+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.663921 1.482400 -0.729859 num: 14
01-20 16:21:55.205+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.867295 1.248933 -0.688948 num: 14
01-20 16:21:55.205+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.663842 1.132371 -0.569255 num: 14
01-20 16:21:55.205+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.880801
01-20 16:21:55.215+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2617, 9.121440, -1.402194, -2.854637, 8.879972, -1.032941, -2.739905, -0.061087, -0.180816, 0.411723, -0.042419, -0.091716, 0.435200, 0.413025, 1.460623, -0.377761, 0.538189, 1.272569, -0.660419, -0.007476, 0.004727, -0.003011, -0.011162, -0.001186, -0.006263
01-20 16:21:55.215+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.413025 1.460623 -0.377761 num: 3
01-20 16:21:55.215+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.663921 1.482400 -0.729859 num: 14
01-20 16:21:55.215+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.867295 1.248933 -0.688948 num: 14
01-20 16:21:55.215+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 5.014263
01-20 16:21:55.225+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2628, 9.454042, -1.414158, -2.746960, 8.947906, -1.072712, -2.737479, -0.067195, -0.174707, 0.394619, -0.049113, -0.114137, 0.424237, 0.536403, 1.315881, -0.063215, 0.561565, 1.254780, -0.588598, -0.007443, 0.004806, -0.003014, -0.011128, -0.001110, -0.006298
01-20 16:21:55.225+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.536403 1.315881 -0.063215 num: 3
01-20 16:21:55.225+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.413025 1.460623 -0.377761 num: 3
01-20 16:21:55.225+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.663921 1.482400 -0.729859 num: 14
01-20 16:21:55.225+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.767341
01-20 16:21:55.235+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2637, 9.248260, -1.428515, -2.823531, 8.984318, -1.107884, -2.742453, -0.081856, -0.127060, 0.354302, -0.057959, -0.117628, 0.405344, 0.452738, 1.373367, -0.245720, 0.575260, 1.249515, -0.547371, -0.007425, 0.004862, -0.003024, -0.011105, -0.001060, -0.006321
01-20 16:21:55.235+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.452738 1.373367 -0.245720 num: 3
01-20 16:21:55.235+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.536403 1.315881 -0.063215 num: 3
01-20 16:21:55.235+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.413025 1.460623 -0.377761 num: 3
01-20 16:21:55.235+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.453407
01-20 16:21:55.245+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2648, 9.174082, -1.593620, -2.787638, 9.008223, -1.156117, -2.741032, -0.127060, -0.101404, 0.299324, -0.076627, -0.113245, 0.376702, 0.571357, 1.454434, -0.318461, 0.599371, 1.246946, -0.519137, -0.007390, 0.004950, -0.003044, -0.011068, -0.000984, -0.006352
01-20 16:21:55.245+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.571357 1.454434 -0.318461 num: 3
01-20 16:21:55.245+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.452738 1.373367 -0.245720 num: 3
01-20 16:21:55.245+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.536403 1.315881 -0.063215 num: 3
01-20 16:21:55.245+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.483966
01-20 16:21:55.255+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2657, 9.052048, -1.727618, -2.749353, 9.015380, -1.212847, -2.734106, -0.103847, -0.103847, 0.279776, -0.083980, -0.110706, 0.350517, 0.666993, 1.523333, -0.439476, 0.633998, 1.257220, -0.509887, -0.007363, 0.005012, -0.003062, -0.011043, -0.000934, -0.006373
01-20 16:21:55.255+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.666993 1.523333 -0.439476 num: 3
01-20 16:21:55.255+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.571357 1.454434 -0.318461 num: 3
01-20 16:21:55.255+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.452738 1.373367 -0.245720 num: 3
01-20 16:21:55.255+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.781597
01-20 16:21:55.270+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2670, 9.090333, -1.679761, -2.651247, 9.025429, -1.260581, -2.719432, -0.045204, -0.135612, 0.256563, -0.073505, -0.117435, 0.325135, 0.707063, 1.384559, -0.414686, 0.666980, 1.244734, -0.497199, -0.007303, 0.005129, -0.003097, -0.010986, -0.000828, -0.006415
01-20 16:21:55.270+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.707063 1.384559 -0.414686 num: 3
01-20 16:21:55.270+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.666993 1.523333 -0.439476 num: 3
01-20 16:21:55.270+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.571357 1.454434 -0.318461 num: 3
01-20 16:21:55.270+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.923810
01-20 16:21:55.275+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2680, 9.166903, -1.605584, -2.639283, 9.042763, -1.296423, -2.706979, -0.001222, -0.149051, 0.229685, -0.053977, -0.125976, 0.299348, 0.673629, 1.285129, -0.338518, 0.695755, 1.233354, -0.478400, -0.007270, 0.005193, -0.003113, -0.010952, -0.000767, -0.006439
01-20 16:21:55.275+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.673629 1.285129 -0.338518 num: 3
01-20 16:21:55.275+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.707063 1.384559 -0.414686 num: 3
01-20 16:21:55.275+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.666993 1.523333 -0.439476 num: 3
01-20 16:21:55.275+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.818997
01-20 16:21:55.285+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2689, 9.257831, -1.531406, -2.931208, 9.069373, -1.317386, -2.727432, 0.010996, -0.144164, 0.200364, -0.036424, -0.130890, 0.272607, 0.420231, 1.385749, -0.190503, 0.694088, 1.234859, -0.444154, -0.007253, 0.005249, -0.003121, -0.010923, -0.000717, -0.006456
01-20 16:21:55.290+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.420231 1.385749 -0.190503 num: 3
01-20 16:21:55.290+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.673629 1.285129 -0.338518 num: 3
01-20 16:21:55.290+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.707063 1.384559 -0.414686 num: 3
01-20 16:21:55.290+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.559493
01-20 16:21:55.295+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2698, 9.497113, -1.512264, -3.163311, 9.121285, -1.332191, -2.770865, -0.013439, -0.155160, 0.180816, -0.030215, -0.137446, 0.247809, 0.269430, 1.467140, 0.092692, 0.677220, 1.244260, -0.380458, -0.007242, 0.005309, -0.003117, -0.010896, -0.000666, -0.006472
01-20 16:21:55.295+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.269430 1.467140 0.092692 num: 3
01-20 16:21:55.295+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.420231 1.385749 -0.190503 num: 3
01-20 16:21:55.295+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.673629 1.285129 -0.338518 num: 3
01-20 16:21:55.295+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.445036
01-20 16:21:55.305+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2709, 9.573684, -1.397408, -3.144169, 9.175357, -1.335093, -2.809798, -0.041539, -0.128282, 0.188146, -0.033274, -0.134970, 0.231691, 0.216048, 1.333953, 0.165550, 0.656215, 1.237573, -0.314848, -0.007229, 0.005389, -0.003107, -0.010856, -0.000591, -0.006491
01-20 16:21:55.305+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.216048 1.333953 0.165550 num: 3
01-20 16:21:55.305+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.269430 1.467140 0.092692 num: 3
01-20 16:21:55.305+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.420231 1.385749 -0.190503 num: 3
01-20 16:21:55.305+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.316532
01-20 16:21:55.315+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2718, 9.497113, -1.447658, -3.019742, 9.213842, -1.344493, -2.830892, -0.021991, -0.054978, 0.145386, -0.030226, -0.113360, 0.208375, 0.326928, 1.289170, 0.069217, 0.650345, 1.233608, -0.269530, -0.007216, 0.005441, -0.003105, -0.010830, -0.000541, -0.006502
01-20 16:21:55.315+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.326928 1.289170 0.069217 num: 3
01-20 16:21:55.315+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.216048 1.333953 0.165550 num: 3
01-20 16:21:55.315+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.269430 1.467140 0.092692 num: 3
01-20 16:21:55.315+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.187767
01-20 16:21:55.325+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2729, 9.276974, -1.450050, -2.823531, 9.221511, -1.355292, -2.828909, -0.045204, -0.035430, 0.106291, -0.034272, -0.092307, 0.180796, 0.440728, 1.185930, -0.183568, 0.656819, 1.219220, -0.259124, -0.007189, 0.005513, -0.003116, -0.010790, -0.000468, -0.006518
01-20 16:21:55.330+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.440728 1.185930 -0.183568 num: 3
01-20 16:21:55.330+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.326928 1.289170 0.069217 num: 3
01-20 16:21:55.330+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.216048 1.333953 0.165550 num: 3
01-20 16:21:55.330+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.971640
01-20 16:21:55.335+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2738, 8.965906, -1.483550, -2.742175, 9.192017, -1.368304, -2.817307, -0.056200, -0.064752, 0.086743, -0.040196, -0.084863, 0.155387, 0.483121, 1.196349, -0.502250, 0.667432, 1.211255, -0.288073, -0.007169, 0.005562, -0.003136, -0.010763, -0.000419, -0.006529
01-20 16:21:55.335+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.483121 1.196349 -0.502250 num: 3
01-20 16:21:55.335+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.440728 1.185930 -0.183568 num: 3
01-20 16:21:55.335+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.326928 1.289170 0.069217 num: 3
01-20 16:21:55.335+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.994728
01-20 16:21:55.345+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2749, 8.925228, -1.478764, -2.926422, 9.161896, -1.376790, -2.825923, -0.026878, -0.130725, 0.087965, -0.036598, -0.097253, 0.137173, 0.345003, 1.303778, -0.502988, 0.661872, 1.210558, -0.312895, -0.007148, 0.005641, -0.003166, -0.010723, -0.000345, -0.006548
01-20 16:21:55.345+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.345003 1.303778 -0.502988 num: 3
01-20 16:21:55.345+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.483121 1.196349 -0.502250 num: 3
01-20 16:21:55.345+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.440728 1.185930 -0.183568 num: 3
01-20 16:21:55.345+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.102346
01-20 16:21:55.355+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2758, 9.195618, -1.354338, -3.125026, 9.166844, -1.370528, -2.856924, 0.008552, -0.167377, 0.083078, -0.024401, -0.116197, 0.122558, 0.157836, 1.284123, -0.199199, 0.637519, 1.211189, -0.299128, -0.007142, 0.005693, -0.003175, -0.010697, -0.000296, -0.006560
01-20 16:21:55.355+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.157836 1.284123 -0.199199 num: 3
01-20 16:21:55.355+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.345003 1.303778 -0.502988 num: 3
01-20 16:21:55.355+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.483121 1.196349 -0.502250 num: 3
01-20 16:21:55.355+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 4.132954
01-20 16:21:55.365+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2769, 9.430114, -1.174876, -3.251846, 9.198140, -1.346575, -2.900982, 0.021991, -0.160047, 0.056200, -0.011868, -0.128043, 0.104631, -0.015858, 1.180519, 0.053740, 0.598166, 1.200459, -0.256440, -0.007143, 0.005764, -0.003171, -0.010661, -0.000224, -0.006576
01-20 16:21:55.370+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.015858 1.180519 0.053740 num: 6
01-20 16:21:55.370+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.157836 1.284123 -0.199199 num: 3
01-20 16:21:55.370+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.345003 1.303778 -0.502988 num: 3
01-20 16:21:55.370+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.930275
01-20 16:21:55.375+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2777, 9.585647, -1.060020, -3.256632, 9.243364, -1.314597, -2.942756, -0.020769, -0.114843, 0.050091, -0.014272, -0.124477, 0.089897, -0.070828, 1.065102, 0.205068, 0.556938, 1.185765, -0.201558, -0.007145, 0.005798, -0.003165, -0.010643, -0.000186, -0.006582
01-20 16:21:55.375+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.070828 1.065102 0.205068 num: 6
01-20 16:21:55.375+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.015858 1.180519 0.053740 num: 6
01-20 16:21:55.380+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 0.157836 1.284123 -0.199199 num: 3
01-20 16:21:55.380+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.577854
01-20 16:21:55.385+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2789, 9.401401, -1.007378, -3.182454, 9.261481, -1.281358, -2.972109, -0.086743, -0.076969, 0.045204, -0.033851, -0.111643, 0.077823, -0.069869, 0.998571, 0.009482, 0.521600, 1.162676, -0.175385, -0.007150, 0.005870, -0.003164, -0.010606, -0.000102, -0.006595
01-20 16:21:55.385+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.069869 0.998571 0.009482 num: 6
01-20 16:21:55.385+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.070828 1.065102 0.205068 num: 6
01-20 16:21:55.385+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.015858 1.180519 0.053740 num: 6
01-20 16:21:55.385+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.269879
01-20 16:21:55.395+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2798, 9.157332, -1.036092, -3.144169, 9.249175, -1.254266, -2.992708, -0.095295, -0.062308, 0.014661, -0.050450, -0.098315, 0.060759, -0.049459, 1.030541, -0.235635, 0.490978, 1.148813, -0.181659, -0.007152, 0.005912, -0.003174, -0.010586, -0.000056, -0.006602
01-20 16:21:55.395+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.049459 1.030541 -0.235635 num: 6
01-20 16:21:55.395+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.069869 0.998571 0.009482 num: 6
01-20 16:21:55.395+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.070828 1.065102 0.205068 num: 6
01-20 16:21:55.395+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.146325
01-20 16:21:55.405+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2809, 9.090333, -0.923629, -3.055635, 9.229815, -1.220026, -3.003137, -0.045204, -0.085521, 0.015882, -0.049033, -0.094858, 0.048635, -0.062275, 0.893701, -0.321555, 0.463259, 1.123320, -0.197001, -0.007156, 0.005966, -0.003193, -0.010558, 0.000012, -0.006614
01-20 16:21:55.405+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.062275 0.893701 -0.321555 num: -1
01-20 16:21:55.405+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.049459 1.030541 -0.235635 num: 6
01-20 16:21:55.405+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.069869 0.998571 0.009482 num: 6
01-20 16:21:55.405+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 3.011180
01-20 16:21:55.415+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2820, 9.128618, -0.878166, -3.069991, 9.217112, -1.184825, -3.014339, -0.003665, -0.125838, 0.046426, -0.036777, -0.103228, 0.048039, -0.091308, 0.850882, -0.280646, 0.435687, 1.095918, -0.205591, -0.007162, 0.006017, -0.003210, -0.010532, 0.000079, -0.006627
01-20 16:21:55.415+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.091308 0.850882 -0.280646 num: -1
01-20 16:21:55.415+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.062275 0.893701 -0.321555 num: -1
01-20 16:21:55.415+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.049459 1.030541 -0.235635 num: 6
01-20 16:21:55.415+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.910733
01-20 16:21:55.430+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2829, 9.265009, -0.696311, -3.158526, 9.221455, -1.134536, -3.036040, 0.002443, -0.136834, 0.059865, -0.026181, -0.112307, 0.051233, -0.254083, 0.740062, -0.132683, 0.392180, 1.062580, -0.195457, -0.007172, 0.006047, -0.003215, -0.010516, 0.000122, -0.006634
01-20 16:21:55.430+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.254083 0.740062 -0.132683 num: -1
01-20 16:21:55.430+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.091308 0.850882 -0.280646 num: -1
01-20 16:21:55.430+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.062275 0.893701 -0.321555 num: -1
01-20 16:21:55.430+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.646074
01-20 16:21:55.435+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2838, 9.329616, -0.744168, -3.256632, 9.233421, -1.093137, -3.064409, -0.024435, -0.111177, 0.054978, -0.025709, -0.112002, 0.052245, -0.279952, 0.819302, -0.046138, 0.350943, 1.038960, -0.176334, -0.007183, 0.006080, -0.003217, -0.010501, 0.000164, -0.006642
01-20 16:21:55.435+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.279952 0.819302 -0.046138 num: -1
01-20 16:21:55.435+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.254083 0.740062 -0.132683 num: -1
01-20 16:21:55.435+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.091308 0.850882 -0.280646 num: -1
01-20 16:21:55.435+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.561285
01-20 16:21:55.445+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2849, 9.145369, -0.770489, -3.249453, 9.222753, -1.058246, -3.087471, -0.040317, -0.084299, 0.034208, -0.029656, -0.104518, 0.047372, -0.276464, 0.856452, -0.225574, 0.315186, 1.019132, -0.180255, -0.007200, 0.006132, -0.003231, -0.010482, 0.000226, -0.006653
01-20 16:21:55.450+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.276464 0.856452 -0.225574 num: -1
01-20 16:21:55.450+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.279952 0.819302 -0.046138 num: -1
01-20 16:21:55.450+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.254083 0.740062 -0.132683 num: -1
01-20 16:21:55.450+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.588481
01-20 16:21:55.455+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2858, 9.083155, -0.909273, -3.156133, 9.206295, -1.042015, -3.096034, -0.042761, -0.083078, 0.029322, -0.033196, -0.098726, 0.042496, -0.118965, 0.902565, -0.300732, 0.300340, 1.007288, -0.193333, -0.007205, 0.006169, -0.003243, -0.010470, 0.000266, -0.006660
01-20 16:21:55.455+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.118965 0.902565 -0.300732 num: -1
01-20 16:21:55.455+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.276464 0.856452 -0.225574 num: -1
01-20 16:21:55.455+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.279952 0.819302 -0.046138 num: -1
01-20 16:21:55.455+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.753604
01-20 16:21:55.465+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2869, 9.111869, -0.928415, -3.146562, 9.195132, -1.029707, -3.102422, -0.023213, -0.105069, 0.045204, -0.030499, -0.100439, 0.043227, -0.089334, 0.895285, -0.272510, 0.291647, 0.994139, -0.201444, -0.007210, 0.006223, -0.003260, -0.010453, 0.000326, -0.006673
01-20 16:21:55.470+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.089334 0.895285 -0.272510 num: -1
01-20 16:21:55.470+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.118965 0.902565 -0.300732 num: -1
01-20 16:21:55.470+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.276464 0.856452 -0.225574 num: -1
01-20 16:21:55.470+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.826658
01-20 16:21:55.475+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2880, 9.200402, -0.971486, -3.134598, 9.195655, -1.023504, -3.106538, -0.030543, -0.113621, 0.046426, -0.030511, -0.104000, 0.044091, -0.032817, 0.893479, -0.185561, 0.290829, 0.981878, -0.198616, -0.007212, 0.006277, -0.003271, -0.010435, 0.000386, -0.006685
01-20 16:21:55.475+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.032817 0.893479 -0.185561 num: -1
01-20 16:21:55.475+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.089334 0.895285 -0.272510 num: -1
01-20 16:21:55.475+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.118965 0.902565 -0.300732 num: -1
01-20 16:21:55.475+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.811985
01-20 16:21:55.485+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2890, 10.045070, -0.679562, -2.842674, 9.291896, -0.996094, -3.087537, -0.040317, -0.185703, 0.001222, -0.033160, -0.126073, 0.032510, 0.114164, 0.333429, 0.568357, 0.310156, 0.923771, -0.108235, -0.007206, 0.006294, -0.003242, -0.010419, 0.000432, -0.006690
01-20 16:21:55.490+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 0.114164 0.333429 0.568357 num: -1
01-20 16:21:55.490+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 -0.032817 0.893479 -0.185561 num: -1
01-20 16:21:55.490+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.089334 0.895285 -0.272510 num: -1
01-20 16:21:55.490+0900 D/stretch (17756): stretching_sensor_cb(92) > Sequence tail length: 2.521987
01-20 16:21:55.495+0900 D/stretch (17756): on_sensor_event(289) > ALLDATA	  2898, 8.659625, -0.748954, -3.160919, 9.217997, -0.968297, -3.096101, -0.310320, -0.030543, -0.056200, -0.108036, -0.100265, 0.008545, -0.251512, 0.831823, -0.712845, 0.280788, 0.916383, -0.177788, -0.007215, 0.006320, -0.003265, -0.010410, 0.000461, -0.006696
01-20 16:21:55.495+0900 D/stretch (17756): stretching_sensor_cb(85) > Sequence last11111 -0.251512 0.831823 -0.712845 num: 17
01-20 16:21:55.495+0900 D/stretch (17756): stretching_sensor_cb(87) > Sequence last22222 0.114164 0.333429 0.568357 num: -1
01-20 16:21:55.495+0900 D/stretch (17756): stretching_sensor_cb(89) > Sequence last33333 -0.032817 0.893479 -0.185561 num: -1
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
01-20 16:21:55.970+0900 W/CRASH_MANAGER(17924): worker.c: worker_job(1199) > 1117756737472145327451
