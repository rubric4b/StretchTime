S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 13605
Date: 2016-01-20 15:42:51+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3864

Register Information
r0   = 0xbee272d0, r1   = 0xbee27270
r2   = 0xbee272d0, r3   = 0xbee275b0
r4   = 0xbee27538, r5   = 0xbee272d0
r6   = 0x00000132, r7   = 0xbee27280
r8   = 0x4030b9c0, r9   = 0x41460f30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x41a54d80, sp   = 0xbee27198
lr   = 0x419a77a9, pc   = 0x00003864
cpsr = 0xa0000010

Memory Information
MemTotal:   491012 KB
MemFree:     19032 KB
Buffers:      8280 KB
Cached:     116912 KB
VmPeak:      87936 KB
VmSize:      87424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16560 KB
VmRSS:       16560 KB
VmData:      30196 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23816 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13605 TID = 13605
13605 13712 13718 

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
43965000 44164000 rwxp [stack:13712]
44164000 44167000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4416f000 4417a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44202000 44219000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44226000 44228000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44c8c000 4548b000 rwxp [stack:13718]
bee07000 bee28000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13605)
Call Stack Count: 1
 0: (0x3864) (null)
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
, auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:41:15.880+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x4a52cb30
01-20 15:41:15.880+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:41:15.905+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [3248.474121] pkgname: org.tizen.3dwatch, id: file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263034:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:41:15.905+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[3248.474121] pkgname[org.tizen.3dwatch], id[file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263034:4] gbar_fname[]
01-20 15:41:15.910+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [3274.210938] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3274.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:41:15.910+0900 E/WIDGET_VIEWER(  718): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:41:15.910+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
01-20 15:41:15.910+0900 W/W_CLOCK_VIEWER(  718): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(48) >  DBOX Created[org.tizen.stretchtime] it should be [org.tizen.stretchtime]
01-20 15:41:15.915+0900 E/WIDGET_VIEWER(  718): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
01-20 15:41:15.925+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 15:41:15.925+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 15:41:15.955+0900 I/CAPI_WATCH_APPLICATION(13350): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:15.960+0900 E/WIDGET_VIEWER(  715): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png) is not exists, but updated
01-20 15:41:15.960+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: widget_event_handler(6498) > [SECURE_LOG] Failed to get smart data
01-20 15:41:15.965+0900 W/WATCH_CORE(13350): appcore-watch.c: __widget_pause(1001) > widget_pause
01-20 15:41:15.965+0900 E/WIDGET_VIEWER(  715): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/org.tizen.3dwatch_715_3248.474121.png) is not exists, but updated
01-20 15:41:15.965+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: widget_event_handler(6498) > [SECURE_LOG] Failed to get smart data
01-20 15:41:15.980+0900 W/WATCH_CORE(13350): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 15:41:15.985+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 15:41:15.985+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 15:41:15.985+0900 W/CAPI_WATCH_APPLICATION(13350): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 15:41:15.985+0900 E/WIDGET_PROVIDER_APP(13350): client.c: client_fini(1175) > Provider is not initialized
01-20 15:41:15.990+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: widget_event_handler(6498) > [SECURE_LOG] Failed to get smart data
01-20 15:41:16.080+0900 D/stretch (13570): Time : 3 : 41 : 16
01-20 15:41:16.080+0900 W/WATCH_CORE(13570): appcore-watch.c: __widget_create(976) > widget_create done
01-20 15:41:16.085+0900 I/efl-extension(13350): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 15:41:16.105+0900 I/MALI    (13350): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
01-20 15:41:16.105+0900 I/MALI    (13350): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=13350   close drm_fd=33 
01-20 15:41:16.105+0900 I/MALI    (13350): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
01-20 15:41:16.150+0900 I/WATCH_CORE(13570): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 15:41:16.150+0900 I/WATCH_CORE(13570): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 15:41:16.150+0900 I/WATCH_CORE(13570): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 15:41:16.185+0900 E/EFL     (13570): edje<13570> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:41:16.195+0900 W/WATCH_CORE(13570): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 15:41:16.220+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:16.220+0900 D/stretch (13570): Time : 3 : 41 : 16
01-20 15:41:16.340+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13350
01-20 15:41:16.810+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 15:41:16.810+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 15:41:16.825+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:41:16.835+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13570
01-20 15:41:16.835+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:41:16.845+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:41:16.855+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13570
01-20 15:41:16.855+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:41:16.995+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:16.995+0900 D/stretch (13570): Time : 3 : 41 : 17
01-20 15:41:17.065+0900 I/AUL_PAD (13605): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 15:41:17.985+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 15:41:18.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:18.000+0900 D/stretch (13570): Time : 3 : 41 : 18
01-20 15:41:19.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:19.010+0900 D/stretch (13570): Time : 3 : 41 : 19
01-20 15:41:20.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:20.006+0900 D/stretch (13570): Time : 3 : 41 : 20
01-20 15:41:20.210+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:41:20.210+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:41:20.215+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:41:20.215+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:41:21.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:21.006+0900 D/stretch (13570): Time : 3 : 41 : 21
01-20 15:41:22.001+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:22.006+0900 D/stretch (13570): Time : 3 : 41 : 22
01-20 15:41:23.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:23.005+0900 D/stretch (13570): Time : 3 : 41 : 23
01-20 15:41:23.335+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:41:23.335+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:41:23.345+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:41:23.345+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:41:23.385+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 15:41:23 5일 전[0;m
01-20 15:41:23.385+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 15:41:23.385+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:41:23.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:41:23.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:41:23.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:41:23.395+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 15:41:24.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:24.005+0900 D/stretch (13570): Time : 3 : 41 : 24
01-20 15:41:25.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:25.005+0900 D/stretch (13570): Time : 3 : 41 : 25
01-20 15:41:26.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:26.005+0900 D/stretch (13570): Time : 3 : 41 : 26
01-20 15:41:27.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:27.005+0900 D/stretch (13570): Time : 3 : 41 : 27
01-20 15:41:28.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:28.005+0900 D/stretch (13570): Time : 3 : 41 : 28
01-20 15:41:29.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:29.005+0900 D/stretch (13570): Time : 3 : 41 : 29
01-20 15:41:30.001+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:30.006+0900 D/stretch (13570): Time : 3 : 41 : 30
01-20 15:41:31.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:31.005+0900 D/stretch (13570): Time : 3 : 41 : 31
01-20 15:41:32.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:32.010+0900 D/stretch (13570): Time : 3 : 41 : 32
01-20 15:41:33.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:33.005+0900 D/stretch (13570): Time : 3 : 41 : 33
01-20 15:41:34.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:34.006+0900 D/stretch (13570): Time : 3 : 41 : 34
01-20 15:41:35.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:35.005+0900 D/stretch (13570): Time : 3 : 41 : 35
01-20 15:41:36.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:36.000+0900 D/stretch (13570): Time : 3 : 41 : 36
01-20 15:41:37.001+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:37.006+0900 D/stretch (13570): Time : 3 : 41 : 37
01-20 15:41:38.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:38.010+0900 D/stretch (13570): Time : 3 : 41 : 38
01-20 15:41:39.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:39.005+0900 D/stretch (13570): Time : 3 : 41 : 39
01-20 15:41:40.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:40.006+0900 D/stretch (13570): Time : 3 : 41 : 40
01-20 15:41:40.405+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 15:41:40.415+0900 E/AUL_AMD (  519): amd_request.c: __app_process_by_pid(193) > pid(13462) is dead. cmd(4) is canceled
01-20 15:41:41.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:41.005+0900 D/stretch (13570): Time : 3 : 41 : 41
01-20 15:41:42.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:42.006+0900 D/stretch (13570): Time : 3 : 41 : 42
01-20 15:41:43.001+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:43.006+0900 D/stretch (13570): Time : 3 : 41 : 43
01-20 15:41:44.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:44.005+0900 D/stretch (13570): Time : 3 : 41 : 44
01-20 15:41:45.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:45.005+0900 D/stretch (13570): Time : 3 : 41 : 45
01-20 15:41:46.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:46.010+0900 D/stretch (13570): Time : 3 : 41 : 46
01-20 15:41:47.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:47.005+0900 D/stretch (13570): Time : 3 : 41 : 47
01-20 15:41:48.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:48.005+0900 D/stretch (13570): Time : 3 : 41 : 48
01-20 15:41:49.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:49.006+0900 D/stretch (13570): Time : 3 : 41 : 49
01-20 15:41:50.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:50.005+0900 D/stretch (13570): Time : 3 : 41 : 50
01-20 15:41:51.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:51.005+0900 D/stretch (13570): Time : 3 : 41 : 51
01-20 15:41:52.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:52.006+0900 D/stretch (13570): Time : 3 : 41 : 52
01-20 15:41:53.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:53.005+0900 D/stretch (13570): Time : 3 : 41 : 53
01-20 15:41:54.001+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:54.006+0900 D/stretch (13570): Time : 3 : 41 : 54
01-20 15:41:55.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:55.005+0900 D/stretch (13570): Time : 3 : 41 : 55
01-20 15:41:56.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:56.005+0900 D/stretch (13570): Time : 3 : 41 : 56
01-20 15:41:57.010+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:57.010+0900 D/stretch (13570): Time : 3 : 41 : 57
01-20 15:41:58.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:58.005+0900 D/stretch (13570): Time : 3 : 41 : 58
01-20 15:41:59.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:41:59.005+0900 D/stretch (13570): Time : 3 : 41 : 59
01-20 15:42:00.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:00.010+0900 D/stretch (13570): Time : 3 : 42 : 0
01-20 15:42:00.835+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 15:42:00.835+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 15:42:00.840+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 15:42:00.840+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:42:00.845+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:42:00.845+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 15:42:00.850+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 15:42:00.850+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 15:42:00.850+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 15:42:00.900+0900 I/HealthDataService( 1085): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
01-20 15:42:00.945+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
01-20 15:42:01.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:01.000+0900 D/stretch (13570): Time : 3 : 42 : 1
01-20 15:42:01.630+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 15:42:01.630+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 15:42:02.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:02.005+0900 D/stretch (13570): Time : 3 : 42 : 2
01-20 15:42:03.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:03.006+0900 D/stretch (13570): Time : 3 : 42 : 3
01-20 15:42:04.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:04.006+0900 D/stretch (13570): Time : 3 : 42 : 4
01-20 15:42:05.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:05.005+0900 D/stretch (13570): Time : 3 : 42 : 5
01-20 15:42:06.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:06.010+0900 D/stretch (13570): Time : 3 : 42 : 6
01-20 15:42:07.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:07.005+0900 D/stretch (13570): Time : 3 : 42 : 7
01-20 15:42:08.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:08.005+0900 D/stretch (13570): Time : 3 : 42 : 8
01-20 15:42:09.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:09.005+0900 D/stretch (13570): Time : 3 : 42 : 9
01-20 15:42:10.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:10.005+0900 D/stretch (13570): Time : 3 : 42 : 10
01-20 15:42:11.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:11.005+0900 D/stretch (13570): Time : 3 : 42 : 11
01-20 15:42:12.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:12.005+0900 D/stretch (13570): Time : 3 : 42 : 12
01-20 15:42:13.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:13.005+0900 D/stretch (13570): Time : 3 : 42 : 13
01-20 15:42:14.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:14.005+0900 D/stretch (13570): Time : 3 : 42 : 14
01-20 15:42:15.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:15.005+0900 D/stretch (13570): Time : 3 : 42 : 15
01-20 15:42:16.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:16.005+0900 D/stretch (13570): Time : 3 : 42 : 16
01-20 15:42:17.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:17.011+0900 D/stretch (13570): Time : 3 : 42 : 17
01-20 15:42:18.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:18.005+0900 D/stretch (13570): Time : 3 : 42 : 18
01-20 15:42:19.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:19.005+0900 D/stretch (13570): Time : 3 : 42 : 19
01-20 15:42:20.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:20.010+0900 D/stretch (13570): Time : 3 : 42 : 20
01-20 15:42:20.280+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:42:20.280+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:42:20.295+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:42:20.300+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:42:21.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:21.005+0900 D/stretch (13570): Time : 3 : 42 : 21
01-20 15:42:22.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:22.005+0900 D/stretch (13570): Time : 3 : 42 : 22
01-20 15:42:23.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:23.005+0900 D/stretch (13570): Time : 3 : 42 : 23
01-20 15:42:23.395+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:42:23.395+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:42:23.405+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:42:23.405+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:42:23.445+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 15:42:23 5일 전[0;m
01-20 15:42:23.450+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 15:42:23.450+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 15:42:23.455+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 15:42:23.455+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 15:42:23.455+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 15:42:23.465+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 15:42:24.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:24.005+0900 D/stretch (13570): Time : 3 : 42 : 24
01-20 15:42:25.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:25.005+0900 D/stretch (13570): Time : 3 : 42 : 25
01-20 15:42:26.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:26.005+0900 D/stretch (13570): Time : 3 : 42 : 26
01-20 15:42:27.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:27.005+0900 D/stretch (13570): Time : 3 : 42 : 27
01-20 15:42:28.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:28.005+0900 D/stretch (13570): Time : 3 : 42 : 28
01-20 15:42:29.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:29.005+0900 D/stretch (13570): Time : 3 : 42 : 29
01-20 15:42:30.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:30.005+0900 D/stretch (13570): Time : 3 : 42 : 30
01-20 15:42:31.006+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:31.011+0900 D/stretch (13570): Time : 3 : 42 : 31
01-20 15:42:32.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:32.010+0900 D/stretch (13570): Time : 3 : 42 : 32
01-20 15:42:33.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:33.005+0900 D/stretch (13570): Time : 3 : 42 : 33
01-20 15:42:34.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:34.005+0900 D/stretch (13570): Time : 3 : 42 : 34
01-20 15:42:35.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:35.000+0900 D/stretch (13570): Time : 3 : 42 : 35
01-20 15:42:36.005+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:36.005+0900 D/stretch (13570): Time : 3 : 42 : 36
01-20 15:42:36.860+0900 E/PKGMGR_SERVER(13707): pkgmgr-server.c: main(2126) > package manager server start
01-20 15:42:36.950+0900 E/PKGMGR_SERVER(13707): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_1252648513], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 15:42:36.955+0900 E/PKGMGR_SERVER(13709): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 15:42:36.960+0900 E/PKGMGR  (13701): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 15:42:37.000+0900 I/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:37.000+0900 D/stretch (13570): Time : 3 : 42 : 37
01-20 15:42:37.025+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:42:37.035+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13570
01-20 15:42:37.035+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:42:37.040+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 15:42:37.045+0900 W/CAPI_WATCH_APPLICATION(13570): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 15:42:37.045+0900 D/stretch (13570): Destroy analog watch
01-20 15:42:37.050+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 15:42:37.050+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 15:42:37.050+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(13570), cmd(4)
01-20 15:42:37.050+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:42:37.055+0900 W/WATCH_CORE(13570): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 15:42:37.055+0900 E/WIDGET_PROVIDER_APP(13570): client.c: client_fini(1175) > Provider is not initialized
01-20 15:42:37.060+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13570
01-20 15:42:37.060+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 15:42:37.070+0900 I/efl-extension(13570): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 15:42:37.165+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:42:37.230+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 15:42:37.270+0900 E/PKGMGR_SERVER(13709): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 15:42:37.310+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 15:42:37.310+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(13570), cmd(4)
01-20 15:42:37.315+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 15:42:37.335+0900 E/PKGMGR_SERVER(13707): pkgmgr-server.c: sighandler(445) > child NORMAL exit [13709]
01-20 15:42:37.350+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:42:37.375+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 15:42:37.375+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 15:42:37.375+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 15:42:37.390+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 15:42:37.395+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 15:42:37.395+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 15:42:37.470+0900 I/efl-extension(13605): efl_extension.c: eext_mod_init(40) > Init
01-20 15:42:37.470+0900 I/UXT     (13605): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 15:42:37.485+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 15:42:37.500+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13570
01-20 15:42:37.500+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 15:42:37.500+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 15:42:37.525+0900 E/TBM     (13605): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 15:42:37.570+0900 W/WATCH_CORE(13605): appcore-watch.c: __widget_create(958) > widget_create
01-20 15:42:37.570+0900 D/stretch (13605): Create analog watch
01-20 15:42:37.570+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [3274.210938] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3274.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263038:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:42:37.570+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[3274.210938] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3274.210938.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263038:4] gbar_fname[]
01-20 15:42:37.570+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [3274.210938] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3274.210938.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263038:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 15:42:37.570+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[3274.210938] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_3274.210938.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263038:4] gbar_fname[]
01-20 15:42:37.585+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 15:42:37.585+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 15:42:37.675+0900 D/stretch (13605): Time : 3 : 42 : 37
01-20 15:42:37.675+0900 W/WATCH_CORE(13605): appcore-watch.c: __widget_create(976) > widget_create done
01-20 15:42:37.745+0900 I/WATCH_CORE(13605): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 15:42:37.745+0900 I/WATCH_CORE(13605): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 15:42:37.745+0900 I/WATCH_CORE(13605): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 15:42:37.775+0900 E/EFL     (13605): edje<13605> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 15:42:37.790+0900 W/WATCH_CORE(13605): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 15:42:37.815+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:37.815+0900 D/stretch (13605): Time : 3 : 42 : 37
01-20 15:42:37.995+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:37.995+0900 D/stretch (13605): Time : 3 : 42 : 38
01-20 15:42:38.500+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 15:42:38.500+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 15:42:38.520+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:42:38.525+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13605
01-20 15:42:38.525+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:42:38.540+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 15:42:38.545+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13605
01-20 15:42:38.550+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 15:42:38.845+0900 I/AUL_PAD (13737): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 15:42:38.995+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:38.995+0900 D/stretch (13605): Time : 3 : 42 : 39
01-20 15:42:39.050+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 15:42:39.090+0900 E/PKGMGR_SERVER(13707): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 15:42:39.090+0900 E/PKGMGR_SERVER(13707): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 15:42:40.005+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:40.005+0900 D/stretch (13605): Time : 3 : 42 : 40
01-20 15:42:41.005+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:41.005+0900 D/stretch (13605): Time : 3 : 42 : 41
01-20 15:42:42.005+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:42.005+0900 D/stretch (13605): Time : 3 : 42 : 42
01-20 15:42:43.005+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:43.005+0900 D/stretch (13605): Time : 3 : 42 : 43
01-20 15:42:43.995+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
01-20 15:42:44.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:44.000+0900 D/stretch (13605): Time : 3 : 42 : 44
01-20 15:42:44.010+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
01-20 15:42:44.050+0900 E/RESOURCED(  521): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 555
01-20 15:42:44.055+0900 W/ALARM_MANAGER(  555): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [329075165]
01-20 15:42:44.055+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __alarm_expired(1325) > alarm_id[329075165] is expired.
01-20 15:42:44.060+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(329075165)
01-20 15:42:44.060+0900 W/ALARM_MANAGER(  503): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(535) > The duetime of alarm(265655648) is OVER.
01-20 15:42:44.065+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
01-20 15:42:44.065+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 20-1-2016, 15:00:00 (UTC).
01-20 15:42:44.070+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-20 15:42:44.070+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
01-20 15:42:44.080+0900 W/ALARM_MANAGER(  503): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
01-20 15:42:44.080+0900 W/ALARM_MANAGER(  503): alarm-manager.c: alarm_manager_alarm_delete(2213) > Unable to delete the alarm! alarm_id[329075165], return_code[-9]
01-20 15:42:44.095+0900 I/WECONN  (  555): util.c: wc_stop_hardware_timer(305) > Alarm removed(329075165)
01-20 15:42:44.100+0900 W/WECONN  (  555): esap.c: __sap_service_set_state(778) > sap state is changed(2)
01-20 15:42:44.100+0900 I/WECONN  (  555): technology.c: __wc_technology_sap_property_changed_cb(631) > property: W_SERVICE_TYPE_SAP
01-20 15:42:44.100+0900 I/WECONN  (  555): technology.c: __wc_technology_sap_property_changed_cb(649) > state: W_SERVICE_STATE_CONNECTING
01-20 15:42:44.100+0900 I/WECONN  (  555): control.c: wc_control_sap_property_changed(1192) > property: W_SERVICE_TYPE_SAP
01-20 15:42:44.115+0900 W/SCSD    (12685): <_method_login:72> >> _method_login, Mode is : 1
01-20 15:42:44.115+0900 W/SCSD    (12685): <scs_init:1012> network_status : 2
01-20 15:42:44.115+0900 W/SCSD    (12685): <util_scs_set_network_changed:1382> set network type (0)
01-20 15:42:44.115+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: nc - Call(0)(0)
01-20 15:42:44.115+0900 I/SCSD    (12685): SCS initialized
01-20 15:42:44.120+0900 I/SECURE_STORAGE(  524): ss_server_ipc.c: SsServerComm(252) > write succeed
01-20 15:42:44.125+0900 W/SCSD    (12685): <scs_create_group_id:548> group_id: 7fe154a87fea5295f923fa3a
01-20 15:42:44.125+0900 W/SCSD    (12685): <util_scs_login:680> 
01-20 15:42:44.125+0900 W/SCSD    (12685): - token:ALxSdTEkL5 
01-20 15:42:44.125+0900 W/SCSD    (12685): - token_secret:us-auth2.samsungosp.com,us-auth2.samsungosp.com 
01-20 15:42:44.125+0900 W/SCSD    (12685): - appid:w3zf8m10dj 
01-20 15:42:44.125+0900 W/SCSD    (12685): - guid:uexormxciu 
01-20 15:42:44.125+0900 W/SCSD    (12685): - secret:CC49B78F38AE579124A11E5DFCC9EFCF 
01-20 15:42:44.125+0900 W/SCSD    (12685): - group_id:7fe154a87fea5295f923fa3a 
01-20 15:42:44.125+0900 W/SCSD    (12685): - mnc:0 
01-20 15:42:44.125+0900 W/SCSD    (12685): - network_type:0
01-20 15:42:44.125+0900 I/WECONN  (  555): esap.c: esap_bearer_connect(2257) > connect success
01-20 15:42:44.125+0900 I/WECONN  (  555): technology.c: __wc_technology_sap_property_changed_cb(631) > property: SCSRequested
01-20 15:42:44.125+0900 I/WECONN  (  555): control.c: wc_control_sap_property_changed(1192) > property: SCSRequested
01-20 15:42:44.135+0900 W/SCSD    (12685): <util_scs_login:691> sec_initializeCore_w
01-20 15:42:44.135+0900 W/SNL_W   (12685): <sec_initializeCore_w:56> sec_initializeCore_W () - begin - version ( 1.0.19 )
01-20 15:42:44.135+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: init - Call() opt_s( 1 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: init - wearable version 0.2.7.0.5 keep(-1)
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: Config Setting : GrpID( 54a87fea5295f923fa3a ), InstanceID( w3zf8m10dj ), SvrPr( :0 ), SvrSTN( :0 ), SvcPort( 7080 ), LogPath( /opt/usr/data/scs/scs_gear/ ), LogLevel( 5 ), CONNECT_TIMEOUT( TCP:2, UDP:3, TURN:10, PLAIN_UDP:3 ), AuthType( 10 ), MCC( 450 ), CC( KOR ), FWK( 0 ), SERVER_TYPE( 0 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: NetworkType(0)
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_UPNP( 1 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_LOGSIZE( 1 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_NO_EXCHANGE_D2D_KEY( 0 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_GAP_C_TIME( 0 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_PUDP_CLOSE_TIME( 20 )
01-20 15:42:44.140+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: init - p( :89:5B:9F:BD:B1 ) opt_s( 1 )
01-20 15:42:44.155+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: init - SCA Request Setting : GrpID( 54a87fea5295f923fa3a ), InstanceID( w3zf8m10dj ),  AuthType( 10 ), AppSecret( CC49B78F38AE579124A11E5DFCC9EFCF ), MCC( 450 ), CC( KOR ), FWK( 0 ), SERVER_TYPE( 0 )
01-20 15:42:44.155+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: server_type(0)
01-20 15:42:44.155+0900 W/SNL     (12685): Scone_Log.cpp: dump(2972) > SNL :: sca - g_h_b_n s
01-20 15:42:45.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:45.000+0900 D/stretch (13605): Time : 3 : 42 : 45
01-20 15:42:46.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:46.005+0900 D/stretch (13605): Time : 3 : 42 : 46
01-20 15:42:47.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:47.000+0900 D/stretch (13605): Time : 3 : 42 : 47
01-20 15:42:48.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:48.005+0900 D/stretch (13605): Time : 3 : 42 : 48
01-20 15:42:49.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:49.000+0900 D/stretch (13605): Time : 3 : 42 : 49
01-20 15:42:50.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:50.000+0900 D/stretch (13605): Time : 3 : 42 : 50
01-20 15:42:50.140+0900 E/PKGMGR  (13830): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 15:42:50.345+0900 E/PKGMGR_SERVER(13832): pkgmgr-server.c: main(2126) > package manager server start
01-20 15:42:50.425+0900 E/PKGMGR_SERVER(13832): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_1266091108], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_1266091108' '-r' 'org.tizen.stretchtime'], cookie=[aGsM0LHHa3XWsvdzsmoTq+dcqC8=], backend_flag=[0]
01-20 15:42:50.430+0900 E/PKGMGR  (13832): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 15:42:50.430+0900 E/PKGMGR_SERVER(13832): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 15:42:50.435+0900 E/PKGMGR  (13830): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[138300002]
01-20 15:42:50.435+0900 E/PKGMGR_SERVER(13833): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 15:42:50.585+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 15:42:50.590+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 15:42:50.615+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 15:42:50.770+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 15:42:51.000+0900 I/CAPI_WATCH_APPLICATION(13605): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 15:42:51.320+0900 W/CRASH_MANAGER(13835): worker.c: worker_job(1199) > 1113605737472145327217
