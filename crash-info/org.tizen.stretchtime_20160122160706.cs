S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 20062
Date: 2016-01-22 16:07:06+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x7

Register Information
r0   = 0x00010305, r1   = 0x00000001
r2   = 0x00000001, r3   = 0x000a20fc
r4   = 0x00000000, r5   = 0x00000001
r6   = 0x00000007, r7   = 0xbea71dfc
r8   = 0x4059c25c, r9   = 0x40451824
r10  = 0x41a168b8, fp   = 0x00000000
ip   = 0x4059a920, sp   = 0xbea71d78
lr   = 0x404fa420, pc   = 0x404fa26c
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     22952 KB
Buffers:     26120 KB
Cached:     122064 KB
VmPeak:      78160 KB
VmSize:      77648 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15376 KB
VmRSS:       15376 KB
VmData:      21156 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23720 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20062 TID = 20062
20062 20109 20115 

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
41771000 4184e000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
4189c000 418a3000 r-xp /usr/lib/libappcore-watch.so.1.1
418ac000 418b1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418b9000 418bd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
418c6000 418ce000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
418cf000 418ef000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f0000 418fd000 r-xp /usr/lib/libalarm.so.0.0.0
41906000 4190c000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41914000 4191a000 r-xp /usr/lib/libwidget.so.1.0.0
41923000 41928000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41930000 4194e000 r-xp /usr/lib/libsensor.so.1.1.0
41958000 4196a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41972000 4197b000 r-xp /usr/lib/libcom-core.so.0.0.1
41984000 41990000 r-xp /usr/lib/libwidget_service.so.1.0.0
41998000 419a1000 r-xp /usr/lib/libwidget_provider.so.1.0.0
419aa000 419b1000 r-xp /usr/lib/libsensord-share.so
419b9000 419cb000 r-xp /usr/lib/libtts.so
419d3000 419db000 rw-p [heap]
419db000 41b0d000 rw-p [heap]
41b0d000 41c4a000 r-xp /usr/lib/libicui18n.so.51.1
41c5a000 41d3e000 r-xp /usr/lib/libicuuc.so.51.1
41d53000 41e0b000 r-xp /usr/lib/libcairo.so.2.11200.14
4339d000 433be000 r-xp /usr/lib/libui-extension.so.0.1.0
433c7000 433ce000 r-xp /usr/lib/libtbm.so.1.0.0
433d6000 433e4000 r-xp /usr/lib/libGLESv2.so.2.0
433ed000 433ee000 r-xp /usr/lib/libxcb-shm.so.0.0.0
433f7000 433fd000 r-xp /usr/lib/libxcb-render.so.0.0.0
43405000 43408000 r-xp /usr/lib/libEGL.so.1.4
43410000 43418000 r-xp /usr/lib/libdrm.so.2.4.0
43420000 43422000 r-xp /usr/lib/libdri2.so.0.0.0
4342a000 4342d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43435000 4343a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43443000 43448000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43450000 43471000 r-xp /usr/lib/libexif.so.12.3.3
43484000 43489000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43491000 4355b000 r-xp /usr/lib/libCOREGL.so.4.0
439a0000 4419f000 rwxp [stack:20109]
4419f000 441a2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
441aa000 441b5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
442d9000 44ad8000 rwxp [stack:20115]
bea52000 bea73000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20062)
Call Stack Count: 2
 0: (0x404fa26c) [/lib/libc.so.6] + 0x8626c
 1: (0xbea71dfc) (null)
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
STEM_SETTINGS(20120): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
01-22 16:07:08.299+0900 I/DALI    (20120): slp-logging.cpp: LogMessage(36) > EGL Information
01-22 16:07:08.299+0900 I/DALI    (20120):             Vendor:        ARM
01-22 16:07:08.299+0900 I/DALI    (20120):             Version:       1.4 Linux-r4p0-00rel0
01-22 16:07:08.299+0900 I/DALI    (20120):             Client APIs:   OpenGL_ES
01-22 16:07:08.299+0900 I/DALI    (20120):             Extensions:    EGL_KHR_image EGL_KHR_image_base EGL_KHR_image_pixmap EGL_KHR_gl_texture_2D_image EGL_KHR_gl_texture_cubemap_image EGL_KHR_gl_renderbuffer_image EGL_KHR_reusable_sync EGL_KHR_fence_sync EGL_EXT_swap_buffers_with_damage EGL_TIZEN_image_native_buffer EGL_TIZEN_image_native_surface EGL_KHR_lock_surface EGL_KHR_lock_surface2 EGL_EXT_create_context_robustness EGL_SEC_swapbuffers_region 
01-22 16:07:08.349+0900 I/watchface-viewer(20120): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
01-22 16:07:08.349+0900 I/watchface-viewer(20120): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
01-22 16:07:08.354+0900 I/watchface-viewer(20120): viewer-view.cpp: View(96) > default camera z[720.000000]
01-22 16:07:08.569+0900 E/BASE_UTILS(20120): utils_i18n_ucalendar.c: i18n_ucalendar_get_timezone_displayname(113) > (calendar == NULL || result == NULL || buf_size_needed == NULL)
01-22 16:07:08.579+0900 I/watchface-viewer(20120): viewer-util.cpp: ToUTF8(1214) > i18n_ustring_to_UTF8 returns -22(ffffffea)
01-22 16:07:08.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: UpdateTimezone(2782) > timezonePath[Asia/Seoul] mTimezone[]
01-22 16:07:08.579+0900 I/watchface-viewer(20120): viewer-impl.cpp: SetDummyMode(95) > dummyMode[3]
01-22 16:07:08.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: UpdateTimestamp(1310) > now[1453446428] dummy[1453425040]
01-22 16:07:08.629+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseXML(669) > schema version[0.0]
01-22 16:07:08.639+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseXML(689) > wrong target resolution!!
01-22 16:07:08.639+0900 I/watchface-viewer(20120): viewer-util.cpp: GetAppId(61) > appId[com.samsung.watchface]
01-22 16:07:08.709+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
01-22 16:07:08.714+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
01-22 16:07:08.719+0900 I/data-util(20120): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
01-22 16:07:08.719+0900 I/data-util(20120): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.719+0900 I/data-util(20120): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:08.719+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.724+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.729+0900 I/data-util(20120): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:08.729+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-group-manager.cpp: Clear(32) > 
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-impl.cpp: LoadWatchfaceData(212) > wrong shape [0]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-view.cpp: SetWatchfaceSizeType(676) > watchface size 0x0 shape[0] noMasking[0]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-group.cpp: Group(96) > Group[0x47897a18][bg]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x47875d30]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4788eb00]
01-22 16:07:08.734+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47897438]
01-22 16:07:08.739+0900 I/watchface-viewer(20120): viewer-group.cpp: Group(96) > Group[0x47896958][complication-1]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x47875d30]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4788ba40]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47893c58]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478972a0]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x4788e590]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x478972fc] for [37]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [37] to pending list
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47878d18]
01-22 16:07:08.744+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47878e48]
01-22 16:07:08.749+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47883a28]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478840c8]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4788b8c0]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47879688]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47888fe8]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47889688]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4788f758]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x4788fea8]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x4788f7b4] for [23]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [23] to pending list
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47890f48]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47894d28]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x47890fa4] for [22]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [22] to pending list
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-group.cpp: Group(96) > Group[0x47895a70][day-1]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x47875d30]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47895e40]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47892430]
01-22 16:07:08.754+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47884638]
01-22 16:07:08.759+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47884cd8]
01-22 16:07:08.759+0900 E/TIZEN_N_SYSTEM_SETTINGS(20120): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-22 16:07:08.759+0900 E/TIZEN_N_SYSTEM_SETTINGS(20120): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-22 16:07:08.759+0900 E/TIZEN_N_SYSTEM_SETTINGS(20120): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-22 16:07:08.759+0900 E/TIZEN_N_SYSTEM_SETTINGS(20120): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-22 16:07:08.759+0900 I/watchface-viewer(20120): viewer-util.cpp: UpdateLocale(1043) > mLocale[ko_KR]
01-22 16:07:08.774+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x47878a90]
01-22 16:07:08.774+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x47890cf0]
01-22 16:07:08.794+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x47895830]
01-22 16:07:08.804+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0x47882390] size(32x32)
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x47888180] for [17]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x47878248] for [30]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-group.cpp: Group(96) > Group[0x4788d0b0][hands]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x47875d30]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4788cab0]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47898000]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x4788cb0c] for [7]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x47898ba0]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x47899300]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x47899dd0] for [11]
01-22 16:07:08.809+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:08.814+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x47898bfc] for [7]
01-22 16:07:08.814+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x4789a0d8]
01-22 16:07:08.814+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478e85a8]
01-22 16:07:08.814+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x4789a134] for [5]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478e91f0]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478e9950]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x478ea420] for [6]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x478e924c] for [5]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478ea708]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478eae78]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x478ea764] for [2]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478ebb38]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478ec288]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddListener(570) > added listener[0x478ebb94] for [2]
01-22 16:07:08.819+0900 I/watchface-viewer(20120): viewer-group.cpp: Group(96) > Group[0x478ef850][alpm-hands]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddDataBroker(1563) > added broker [0x478efc20]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-broker.cpp: AmbientDataBroker(1276) > AmbientDataBroker[0x478efc20]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478f01d0]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478f0908]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-broker.cpp: AddListener(1289) > added listener[0x478f13d8] for [11]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-broker.cpp: AddListener(1289) > added listener[0x478f022c] for [7]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-part.cpp: Part(84) > Part[0x478f1748]
01-22 16:07:08.824+0900 I/watchface-viewer(20120): viewer-part-resource.cpp: PartResource(66) > PartResource[0x478f1ea0]
01-22 16:07:08.829+0900 I/watchface-viewer(20120): viewer-data-broker.cpp: AddListener(1289) > added listener[0x478f2970] for [6]
01-22 16:07:08.829+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:08.829+0900 I/watchface-viewer(20120): viewer-data-broker.cpp: AddListener(1289) > added listener[0x478f17a4] for [6]
01-22 16:07:08.829+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: ConnectModels(1381) > models will be connected later when first resume received!!
01-22 16:07:08.829+0900 I/watchface-viewer(20120): viewer-model.cpp: ~ModelWatchfaceData(534) > 
01-22 16:07:08.829+0900 W/WATCH_CORE(20120): appcore-watch.c: __widget_create(976) > widget_create done
01-22 16:07:08.834+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x47898a20]
01-22 16:07:08.949+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x47899f70]
01-22 16:07:09.039+0900 I/WATCH_CORE(20120): appcore-watch.c: __watch_core_set_metadata(818) > Tick per second: 5
01-22 16:07:09.044+0900 I/WATCH_CORE(20120): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-22 16:07:09.044+0900 W/WATCH_CORE(20120): appcore-watch.c: __watch_core_set_metadata(845) > Watchface type
01-22 16:07:09.104+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppControl(680) > 
01-22 16:07:09.119+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
01-22 16:07:09.124+0900 I/watchface-viewer(20120): viewer-util.cpp: GetSystemLocale(694) > mLocale[ko_KR.UTF-8]
01-22 16:07:09.144+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
01-22 16:07:09.144+0900 E/BASE_UTILS(20120): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
01-22 16:07:09.144+0900 I/watchface-viewer(20120): viewer-util.cpp: Create(864) > created locale[ko_KR] impl[0x478f75b0] refcount[1]
01-22 16:07:09.144+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
01-22 16:07:09.164+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478e9060]
01-22 16:07:09.174+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478ea5b0]
01-22 16:07:09.194+0900 E/W_HOME  (  713): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
01-22 16:07:09.224+0900 W/W_HOME  (  713): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
01-22 16:07:09.224+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c8a1e0), origin_x(0), origin_y(0)
01-22 16:07:09.229+0900 W/W_HOME  (  713): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
01-22 16:07:09.229+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:07:09.244+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c8a1e0), origin_x(0), origin_y(0)
01-22 16:07:09.244+0900 W/W_HOME  (  713): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
01-22 16:07:09.244+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:07:09.249+0900 W/W_HOME  (  713): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
01-22 16:07:09.249+0900 W/W_HOME  (  713): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
01-22 16:07:09.249+0900 E/W_HOME  (  713): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
01-22 16:07:09.249+0900 E/W_HOME  (  713): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
01-22 16:07:09.254+0900 W/W_HOME  (  713): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
01-22 16:07:09.254+0900 E/W_HOME  (  713): dbox.c: del_cb(225) > Add viewer has no info: org.tizen.stretchtime
01-22 16:07:09.269+0900 W/W_HOME  (  713): clock_service.c: clock_service_event_handler(821) > scroller freeze off
01-22 16:07:09.269+0900 W/W_HOME  (  713): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
01-22 16:07:09.269+0900 W/W_HOME  (  713): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
01-22 16:07:09.269+0900 E/W_HOME  (  713): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
01-22 16:07:09.269+0900 W/W_HOME  (  713): cfwd.c: cfwd_get_icon_status(362) > 
01-22 16:07:09.269+0900 W/W_HOME  (  713): ============================
01-22 16:07:09.269+0900 W/W_HOME  (  713): multi_sim_category:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): multi_sim_model:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): support_callforward_auto:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): conn_status:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): remote_call_forward_auto:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): auto_call_forward_status:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): support_callforward_reverse:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): reverse_call_forward_auto:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): fwd_type:
01-22 16:07:09.269+0900 W/W_HOME  (  713): ============================
01-22 16:07:09.269+0900 W/W_HOME  (  713): 
01-22 16:07:09.269+0900 W/W_HOME  (  713): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
01-22 16:07:09.269+0900 W/W_HOME  (  713): clock_indicator.c: clock_indicator_icon_push(356) > icon:5 is added to clock indicator
01-22 16:07:09.269+0900 E/W_HOME  (  713): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
01-22 16:07:09.269+0900 E/W_HOME  (  713): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-22 16:07:09.269+0900 W/W_HOME  (  713): noti_broker.c: _clock_attached_cb(804) > 0
01-22 16:07:09.269+0900 W/W_HOME  (  713): cs_broker.c: _clock_view_attached_cb(231) > 
01-22 16:07:09.274+0900 I/GESTURE (  135): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-22 16:07:09.279+0900 I/GESTURE (  135): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-22 16:07:09.334+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 26x24
01-22 16:07:09.334+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateImage(136) > resized 32x32 -> 26x24
01-22 16:07:09.424+0900 E/W_HOME  (  713): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
01-22 16:07:09.499+0900 W/WATCH_CORE(20120): appcore-watch.c: __widget_resume(1012) > widget_resume
01-22 16:07:09.569+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppResume(725) > 
01-22 16:07:09.574+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478eb980]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [37]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [37]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [37] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [23]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [23]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [23] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [22]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [22]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [22] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [11]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [6]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
01-22 16:07:09.579+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppResume(732) > mFirstResumeDone
01-22 16:07:09.579+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:09.579+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
01-22 16:07:09.579+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
01-22 16:07:09.594+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478ef690]
01-22 16:07:09.644+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478f1578]
01-22 16:07:09.654+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478f2b08]
01-22 16:07:09.744+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:09.744+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:09.744+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:09.744+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:09.754+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
01-22 16:07:09.754+0900 E/watchface-loader(20120): watchface-loader.cpp: OnLoadingDone(812) > 
01-22 16:07:09.759+0900 E/watchface-loader(20120): watchface-loader.cpp: OnLoadingDone(815) > idle_watch = [com.samsung.watchface]
01-22 16:07:09.759+0900 E/watchface-loader(20120): watchface-loader.cpp: OnLoadingDone(823) > idle_watch = [com.samsung.watchface]
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
01-22 16:07:09.759+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:09.759+0900 E/MESSAGE_PORT(20120): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
01-22 16:07:09.759+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:09.759+0900 E/MESSAGE_PORT(20120): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
01-22 16:07:09.759+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:09.759+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:09.764+0900 E/MESSAGE_PORT(20120): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
01-22 16:07:09.764+0900 E/watchface-loader(20120): watchface-loader.cpp: OnLoadingDone(860) > mFirstLoadingDone
01-22 16:07:09.914+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:09.914+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:09.914+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:09.914+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:10.094+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:10.094+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:10.094+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:10.094+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:10.094+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
01-22 16:07:10.094+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
01-22 16:07:10.094+0900 E/watchface-loader(20120): watchface-loader.cpp: OnDummyModeOffTimerExpired(396) > disable dummy mode
01-22 16:07:10.094+0900 I/watchface-viewer(20120): viewer-impl.cpp: SetDummyMode(95) > dummyMode[0]
01-22 16:07:10.099+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:10.099+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:10.099+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:10.099+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:10.099+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [37]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [23]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [22]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
01-22 16:07:10.169+0900 I/watchface-viewer(20120): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
01-22 16:07:10.174+0900 E/BASE_UTILS(20120): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
01-22 16:07:10.174+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
01-22 16:07:10.174+0900 I/watchface-viewer(20120): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 26x24
01-22 16:07:10.174+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x478f2b08]
01-22 16:07:10.184+0900 I/watchface-viewer(20120): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
01-22 16:07:10.274+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:10.274+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:10.464+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:10.464+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:10.649+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:10.649+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.694+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.699+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.699+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.699+0900 I/watchface-viewer(20120): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:10.699+0900 I/watchface-viewer(20120): viewer-view.cpp: DummyModeAnimationFinished(360) > 
01-22 16:07:10.839+0900 I/AUL_PAD (20119): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-22 16:07:10.839+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:10.839+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:11.034+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:11.034+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:11.229+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:11.229+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:11.424+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:11.424+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:11.619+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:11.619+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:11.814+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:11.814+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.014+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:12.014+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.214+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:12.214+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.409+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:12.409+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.614+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:12.614+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.809+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:12.809+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:12.839+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 11200637374721453446424
01-22 16:07:13.009+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:13.009+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:13.209+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:13.209+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:13.314+0900 I/GESTURE (  135): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
01-22 16:07:13.319+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.319+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(196) ev->cur.canvas.y(217)
01-22 16:07:13.319+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.319+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9361718 button=1 downs=1
01-22 16:07:13.349+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.349+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(195) ev->cur.canvas.y(217)
01-22 16:07:13.349+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.359+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.359+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(194) ev->cur.canvas.y(217)
01-22 16:07:13.359+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.404+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.404+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(194) ev->cur.canvas.y(218)
01-22 16:07:13.404+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.409+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:13.409+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:13.414+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.414+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(194) ev->cur.canvas.y(219)
01-22 16:07:13.414+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.444+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), block(2)
01-22 16:07:13.444+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), ev->cur.canvas.x(194) ev->cur.canvas.y(220)
01-22 16:07:13.444+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c8a1e0), hold(0) freeze(0)
01-22 16:07:13.609+0900 I/CAPI_WATCH_APPLICATION(20120): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:13.609+0900 E/watchface-loader(20120): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:13.689+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 1120062737472145344642
