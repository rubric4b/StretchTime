S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 13209
Date: 2016-01-20 15:40:47+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1460

Register Information
r0   = 0x00001454, r1   = 0x0000000f
r2   = 0x00000874, r3   = 0x41971194
r4   = 0x00001454, r5   = 0x00000000
r6   = 0x4188e5b4, r7   = 0x414dda08
r8   = 0x00000085, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe86ac4c, sp   = 0xbe86ac00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     13144 KB
Buffers:      6800 KB
Cached:     113908 KB
VmPeak:      87936 KB
VmSize:      87424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16444 KB
VmRSS:       16444 KB
VmData:      30196 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23816 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13209 TID = 13209
13209 13329 13337 

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
43965000 44164000 rwxp [stack:13329]
44164000 44167000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4416f000 4417a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44202000 44219000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44226000 44228000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44c8c000 4548b000 rwxp [stack:13337]
be84b000 be86c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13209)
Call Stack Count: 6
 0: (0x400169dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0x400170d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0x40017360) [/lib/ld-linux.so.3] + 0xa360
 3: (0x4001b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0x40021a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0x404e1808) [/lib/libc.so.6] + 0x6d808
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
lc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.855+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.860+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.860+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.860+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.865+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.865+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.870+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.870+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.870+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.870+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.875+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.875+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.875+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.880+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.880+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.885+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.885+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.885+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.890+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.890+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.890+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.895+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.895+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.900+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.900+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.905+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.905+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.915+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.920+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.925+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.925+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.930+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.930+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.935+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.935+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.940+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.940+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.945+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.945+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.960+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.970+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.975+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.985+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.995+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:42.995+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.005+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.010+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.010+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.015+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.015+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.020+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.020+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.020+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.025+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.025+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.030+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.030+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.045+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:43.085+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,show
01-20 15:40:43.085+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:2, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:43.090+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:2, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(187) ev->cur.canvas.y(231)
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(1)
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(188) ev->cur.canvas.y(231)
01-20 15:40:43.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(1)
01-20 15:40:43.095+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3246029 button=1 downs=0
01-20 15:40:43.105+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45cb4658), freeze(1)
01-20 15:40:43.105+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45cb4658), freeze(1)
01-20 15:40:43.120+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-20 15:40:43.135+0900 E/EFL     (13209): evas_main<13209> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3245636 button=1 downs=0
01-20 15:40:43.570+0900 W/W_HOME  (  715): scroller.c: scroller_freeze(1837) > freezed:40043c5d
01-20 15:40:43.570+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45cb4658), freeze(0)
01-20 15:40:43.570+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45cb4658), freeze(0)
01-20 15:40:43.635+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,show
01-20 15:40:43.635+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:43.640+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:3, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:43.640+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
01-20 15:40:43.640+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
01-20 15:40:43.770+0900 I/efl-extension( 2513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 15:40:43.770+0900 I/efl-extension( 2723): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 15:40:43.770+0900 I/efl-extension(12584): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 15:40:43.770+0900 I/efl-extension( 2565): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4a5cabd0, elm_image, time_stamp : 3247680
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45cb4658 : elm_scroller] rotary callabck is called.
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45cb4658 : elm_scroller] block(1)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45cb4658 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45cb4658 : elm_scroller] content size (w, h)(7378, 360)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45cb4658 : elm_scroller] viewport size (w, h)(360, 360)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45cb4658 : elm_scroller] CurrentPage(28) DetentCount(-1)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45cb4658 : elm_scroller] mx(7018), my(0), minx(0), miny(0), px(6776), py(0)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45cb4658 : elm_scroller] mx(7018), my(0), minx(0), miny(0), px(6776), py(0)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45cb4658 : elm_scroller] mx(7018), my(0), minx(0), miny(0), px(6776), py(0)
01-20 15:40:43.770+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45cb4658 : elm_scroller] bring in 27 page
01-20 15:40:44.055+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45cb4658 : elm_scroller] CurrentPage(27)
01-20 15:40:44.350+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), block(1)
01-20 15:40:44.350+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), ev->cur.canvas.x(178) ev->cur.canvas.y(215)
01-20 15:40:44.350+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), hold(0) freeze(0)
01-20 15:40:44.350+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3248256 button=1 downs=1
01-20 15:40:44.375+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), block(1)
01-20 15:40:44.375+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), ev->cur.canvas.x(179) ev->cur.canvas.y(215)
01-20 15:40:44.380+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), hold(0) freeze(0)
01-20 15:40:44.400+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), block(1)
01-20 15:40:44.400+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), ev->cur.canvas.x(182) ev->cur.canvas.y(214)
01-20 15:40:44.400+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45cb4658), hold(0) freeze(0)
01-20 15:40:44.400+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3248306 button=1 downs=0
01-20 15:40:44.475+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6366) > ConnectionType[0] is not BT, ignore this callback.
01-20 15:40:44.475+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x45cb4658
01-20 15:40:44.475+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8c1b8, elm_box, _activated_obj : 0x4a5cabd0, activated : 1
01-20 15:40:44.475+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
01-20 15:40:44.475+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 15:40:44.475+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
01-20 15:40:44.475+0900 I/MESSAGE_PORT(  715): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
01-20 15:40:44.475+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 15:40:44.475+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 15:40:44.475+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 15:40:44.480+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
01-20 15:40:44.480+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
01-20 15:40:44.480+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 15:40:44.480+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 715
01-20 15:40:44.480+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 15:40:44.480+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:40:44.500+0900 W/W_CLOCK_VIEWER(  718): clock-viewer.c: _clock_viewer_set_current_clock(654) >  package[org.tizen.3dwatch] ambient type[3]
01-20 15:40:44.530+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
01-20 15:40:44.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c89c38), freeze(0)
01-20 15:40:44.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c89c38), freeze(0)
01-20 15:40:44.535+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
01-20 15:40:44.535+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.tizen.3dwatch 1 0 0 1
01-20 15:40:44.535+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
01-20 15:40:44.535+0900 E/W_HOME  (  715): clock_service.c: _clock_provider_change(396) > clock will be changed to org.tizen.3dwatch
01-20 15:40:44.555+0900 E/W_HOME  (  715): dbox.c: widget_create(359) > add-viewer info none: org.tizen.3dwatch
01-20 15:40:44.555+0900 W/W_HOME  (  715): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
01-20 15:40:44.555+0900 E/WIDGET_VIEWER(  718): client.c: make_direct_connection(2077) > [SECURE_LOG] Failed to create a connection
01-20 15:40:44.560+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
01-20 15:40:44.560+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
01-20 15:40:44.560+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [3172.115723] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3172.115723.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263026:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:40:44.560+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[3172.115723] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3172.115723.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263026:4] gbar_fname[]
01-20 15:40:44.565+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
01-20 15:40:44.570+0900 E/W_HOME  (  715): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
01-20 15:40:44.570+0900 E/W_HOME  (  715): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
01-20 15:40:44.570+0900 W/W_HOME  (  715): cs_broker.c: _wms_clock_vconf_cb(283) > 
01-20 15:40:44.570+0900 E/CLOCK-LIST(  715): clocklist_main.c: clock_setting_event(3637) > proxy image is not deleted. Ignore event
01-20 15:40:44.570+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
01-20 15:40:44.570+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:44.575+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:44.575+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
01-20 15:40:44.575+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
01-20 15:40:44.645+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 15:40:44.660+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:40:44.670+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:40:44.670+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 15:40:44.670+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 15:40:44.685+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.3dwatch, table num : 2
01-20 15:40:44.685+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 15:40:44.685+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 15:40:44.690+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 15:40:44.690+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 15:40:44.915+0900 I/efl-extension(13350): efl_extension.c: eext_mod_init(40) > Init
01-20 15:40:44.915+0900 I/UXT     (13350): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 15:40:45.045+0900 I/CAPI_WATCH_APPLICATION(13350): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 15:40:45.075+0900 E/TBM     (13350): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 15:40:45.095+0900 E/RESOURCED(  521): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.tizen.3dwatch
01-20 15:40:45.140+0900 W/WATCH_CORE(13350): appcore-watch.c: __widget_create(958) > widget_create
01-20 15:40:45.145+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [3248.474121] pkgname: org.tizen.3dwatch, id: file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:40:45.145+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x4a58f448
01-20 15:40:45.145+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:40:45.155+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [3248.474121] pkgname: org.tizen.3dwatch, id: file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:40:45.160+0900 E/WIDGET_VIEWER(  718): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:40:45.160+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
01-20 15:40:45.160+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_resize(5449) > [SECURE_LOG] System created Widget is not able to be resized (org.tizen.3dwatch)
01-20 15:40:45.160+0900 E/WIDGET_VIEWER(  718): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:40:45.160+0900 W/W_CLOCK_VIEWER(  718): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(48) >  DBOX Created[org.tizen.3dwatch] it should be [org.tizen.3dwatch]
01-20 15:40:45.160+0900 E/WIDGET_VIEWER(  718): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:40:45.160+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_set_visibility(3853) > [SECURE_LOG] CA Livebox is not able to change the visibility
01-20 15:40:45.250+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 15:40:45.250+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 15:40:45.350+0900 E/EFL     (13350): ecore_evas<13350> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
01-20 15:40:45.435+0900 W/WATCH_CORE(13350): appcore-watch.c: __widget_create(976) > widget_create done
01-20 15:40:45.610+0900 I/WATCH_CORE(13350): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 15:40:45.615+0900 I/WATCH_CORE(13350): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 15:40:45.615+0900 I/WATCH_CORE(13350): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 15:40:45.980+0900 E/PKGMGR  (13458): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 15:40:46.095+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 15:40:46.095+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 15:40:46.125+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:40:46.130+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13350
01-20 15:40:46.130+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:40:46.155+0900 E/PKGMGR_SERVER(13461): pkgmgr-server.c: main(2126) > package manager server start
01-20 15:40:46.250+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:40:46.260+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13350
01-20 15:40:46.260+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:40:46.275+0900 E/PKGMGR_SERVER(13461): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_1141925510], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_1141925510' '-r' 'org.tizen.stretchtime'], cookie=[OJXBbPDm+FZ04QHMZ1wCxVIBRus=], backend_flag=[0]
01-20 15:40:46.275+0900 E/PKGMGR  (13461): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 15:40:46.280+0900 E/PKGMGR_SERVER(13461): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 15:40:46.290+0900 E/PKGMGR  (13458): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[134580002]
01-20 15:40:46.290+0900 E/PKGMGR_SERVER(13463): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 15:40:46.535+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 15:40:46.545+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 15:40:46.560+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 15:40:46.640+0900 I/AUL_PAD (13462): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 15:40:47.050+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 15:40:47.060+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
01-20 15:40:47.255+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
01-20 15:40:47.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c89c38), origin_x(0), origin_y(0)
01-20 15:40:47.255+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
01-20 15:40:47.255+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:47.315+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c89c38), origin_x(0), origin_y(0)
01-20 15:40:47.365+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
01-20 15:40:47.365+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:47.410+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
01-20 15:40:47.410+0900 W/W_HOME  (  715): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
01-20 15:40:47.410+0900 E/W_HOME  (  715): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
01-20 15:40:47.410+0900 E/W_HOME  (  715): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
01-20 15:40:47.475+0900 W/W_HOME  (  715): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
01-20 15:40:47.475+0900 E/W_HOME  (  715): dbox.c: del_cb(225) > Add viewer has no info: org.tizen.stretchtime
01-20 15:40:47.485+0900 W/W_HOME  (  715): cfwd.c: cfwd_get_icon_status(362) > 
01-20 15:40:47.485+0900 W/W_HOME  (  715): ============================
01-20 15:40:47.485+0900 W/W_HOME  (  715): multi_sim_category:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): multi_sim_model:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): support_callforward_auto:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): conn_status:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): remote_call_forward_auto:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): auto_call_forward_status:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): support_callforward_reverse:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): reverse_call_forward_auto:0
01-20 15:40:47.485+0900 W/W_HOME  (  715): fwd_type:
01-20 15:40:47.485+0900 W/W_HOME  (  715): ============================
01-20 15:40:47.485+0900 W/W_HOME  (  715): 
01-20 15:40:47.485+0900 W/W_HOME  (  715): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
01-20 15:40:47.490+0900 W/W_HOME  (  715): clock_indicator.c: clock_indicator_icon_push(356) > icon:5 is added to clock indicator
01-20 15:40:47.495+0900 E/W_HOME  (  715): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
01-20 15:40:47.495+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-20 15:40:47.495+0900 W/W_HOME  (  715): noti_broker.c: _clock_attached_cb(804) > 0
01-20 15:40:47.495+0900 W/W_HOME  (  715): cs_broker.c: _clock_view_attached_cb(231) > 
01-20 15:40:47.500+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
01-20 15:40:47.515+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
01-20 15:40:47.515+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:47.520+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 15:40:47.520+0900 I/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.tizen.3dwatch:watchface::messageport::event]
01-20 15:40:47.520+0900 E/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-20 15:40:47.520+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-20 15:40:47.520+0900 E/MESSAGE_PORT(  715): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
01-20 15:40:47.520+0900 E/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
01-20 15:40:47.535+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8c1b8, elm_box, _activated_obj : 0x45c8c1b8, activated : 1
01-20 15:40:47.540+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-20 15:40:47.540+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45cb4658, obj: 0x45cb4658
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(601) > done
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45cb4658, elm_scroller, func : 0x4072fe19
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4a5cabd0, elm_image, func : 0x4072fe19
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
01-20 15:40:47.540+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x45cb4658 : elm_scroller] rotary callabck is deleted
01-20 15:40:47.690+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-20 15:40:47.700+0900 W/WATCH_CORE(13209): appcore-watch.c: __widget_pause(1001) > widget_pause
01-20 15:40:47.760+0900 E/WATCH_CORE(13209): appcore-watch.c: __do_app(322) > Invalid state
01-20 15:40:47.895+0900 E/W_HOME  (  715): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
01-20 15:40:47.940+0900 E/W_HOME  (  715): move.c: move_back_to_home_no_anim(270) > home is already on position
01-20 15:40:47.945+0900 W/W_HOME  (  715): scroller.c: _get_index_in_list(1902) > page:0x4a5bb2c8 idx:1 total12 exist:1
01-20 15:40:47.945+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
01-20 15:40:47.945+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c89c38), origin_x(0), origin_y(0)
01-20 15:40:47.945+0900 W/W_HOME  (  715): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
01-20 15:40:47.945+0900 I/efl-extension( 2513): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
01-20 15:40:47.945+0900 W/wnotibp ( 2513): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
01-20 15:40:47.950+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02a00003)
01-20 15:40:48.090+0900 E/PKGMGR_SERVER(13461): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-20 15:40:48.120+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 15:40:48.120+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 15:40:48.435+0900 W/CRASH_MANAGER(13475): worker.c: worker_job(1199) > 1113209737472145327204
