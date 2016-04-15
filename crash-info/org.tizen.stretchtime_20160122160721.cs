S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 20228
Date: 2016-01-22 16:07:21+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x9

Register Information
r0   = 0x00010305, r1   = 0x00000001
r2   = 0x00000001, r3   = 0x000a20fc
r4   = 0x00000000, r5   = 0x00000001
r6   = 0x00000009, r7   = 0xbebe3dfc
r8   = 0x4059c25c, r9   = 0x40451824
r10  = 0x41b318b8, fp   = 0x00000000
ip   = 0x4059a920, sp   = 0xbebe3d78
lr   = 0x404fa420, pc   = 0x404fa26c
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     18692 KB
Buffers:     24692 KB
Cached:     127668 KB
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
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20228 TID = 20228
20228 20246 20252 

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
41906000 41a43000 r-xp /usr/lib/libicui18n.so.51.1
41a53000 41a59000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a61000 41a67000 r-xp /usr/lib/libwidget.so.1.0.0
41a70000 41a75000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a7d000 41a9b000 r-xp /usr/lib/libsensor.so.1.1.0
41aa5000 41ab7000 r-xp /usr/lib/libefl-assist.so.0.1.0
41abf000 41ac8000 r-xp /usr/lib/libcom-core.so.0.0.1
41ad1000 41add000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ae5000 41aec000 r-xp /usr/lib/libsensord-share.so
41af4000 41af6000 rw-p [heap]
41af6000 41c28000 rw-p [heap]
41c28000 41d0c000 r-xp /usr/lib/libicuuc.so.51.1
41d21000 41dd9000 r-xp /usr/lib/libcairo.so.2.11200.14
4336b000 43374000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4337d000 4338f000 r-xp /usr/lib/libtts.so
43397000 433b8000 r-xp /usr/lib/libui-extension.so.0.1.0
433c1000 433c8000 r-xp /usr/lib/libtbm.so.1.0.0
433d0000 433de000 r-xp /usr/lib/libGLESv2.so.2.0
433e7000 433e8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
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
4399a000 44199000 rwxp [stack:20246]
44199000 4419c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
441a4000 441af000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
442d3000 44ad2000 rwxp [stack:20252]
bebc4000 bebe5000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20228)
Call Stack Count: 2
 0: (0x404fa26c) [/lib/libc.so.6] + 0x8626c
 1: (0xbebe3dfc) (null)
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
ationData set!!
01-22 16:07:24.474+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.474+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.474+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
01-22 16:07:24.474+0900 I/data-util(20278): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:24.474+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
01-22 16:07:24.479+0900 I/data-util(20278): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/data-util(20278): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/data-util(20278): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePart(2175) > rotationData set!!
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-group-manager.cpp: Clear(32) > 
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-impl.cpp: LoadWatchfaceData(212) > wrong shape [0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-view.cpp: SetWatchfaceSizeType(676) > watchface size 0x0 shape[0] noMasking[0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-group.cpp: Group(96) > Group[0x45e68070][bg]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x45e49fa0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e6bcd0]
01-22 16:07:24.484+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e550d0]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-group.cpp: Group(96) > Group[0x45e5ee08][complication-1]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x45e49fa0]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e55228]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e55548]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e689c0]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e4d930]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e68a1c] for [37]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [37] to pending list
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e57548]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e645e0]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e5f288]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e5f928]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e67a88]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e67ea0]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e64110]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e60398]
01-22 16:07:24.489+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e610e0]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e56030]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e6113c] for [23]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [23] to pending list
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e65618]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e65d68]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e65674] for [22]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [22] to pending list
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-group.cpp: Group(96) > Group[0x45e61c58][day-1]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x45e49fa0]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e66a88]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e62678]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e5cb20]
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e5d1c0]
01-22 16:07:24.494+0900 E/TIZEN_N_SYSTEM_SETTINGS(20278): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-22 16:07:24.494+0900 E/TIZEN_N_SYSTEM_SETTINGS(20278): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-22 16:07:24.494+0900 E/TIZEN_N_SYSTEM_SETTINGS(20278): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-22 16:07:24.494+0900 E/TIZEN_N_SYSTEM_SETTINGS(20278): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-22 16:07:24.494+0900 I/watchface-viewer(20278): viewer-util.cpp: UpdateLocale(1043) > mLocale[ko_KR]
01-22 16:07:24.499+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e572c0]
01-22 16:07:24.499+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e56b28]
01-22 16:07:24.544+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e66860]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0x45e57ce8] size(32x32)
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x4777d7b8] for [17]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x4777d7f8] for [30]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-group.cpp: Group(96) > Group[0x4777db00][hands]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x45e49fa0]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x4777dc48]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x4777ec18]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x4777dca4] for [7]
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:24.554+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x4777f940]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x4777f6d0]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477ff3f8]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x47781010] for [11]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x4777f99c] for [7]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e58568]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e58c80]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e585c4] for [5]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e69df8]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e6a558]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e6a838] for [6]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e69e54] for [5]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e4ab08]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e4b248]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e4ab64] for [2]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e4bf08]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e4c658]
01-22 16:07:24.559+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddListener(570) > added listener[0x45e4bf64] for [2]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-group.cpp: Group(96) > Group[0x45e59b70][alpm-hands]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddDataBroker(1563) > added broker [0x45e59f40]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-data-broker.cpp: AmbientDataBroker(1276) > AmbientDataBroker[0x45e59f40]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e5a4f0]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e5ac18]
01-22 16:07:24.564+0900 I/watchface-viewer(20278): viewer-data-broker.cpp: AddListener(1289) > added listener[0x45e5b6e8] for [11]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-broker.cpp: AddListener(1289) > added listener[0x45e5a54c] for [7]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-part.cpp: Part(84) > Part[0x45e5ba58]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-part-resource.cpp: PartResource(66) > PartResource[0x45e5c1b0]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-broker.cpp: AddListener(1289) > added listener[0x45e4eed8] for [6]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-broker.cpp: AddListener(1289) > added listener[0x45e5bab4] for [6]
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: ConnectModels(1381) > models will be connected later when first resume received!!
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-model.cpp: ~ModelWatchfaceData(534) > 
01-22 16:07:24.569+0900 W/WATCH_CORE(20278): appcore-watch.c: __widget_create(976) > widget_create done
01-22 16:07:24.569+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e58400]
01-22 16:07:24.584+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e58f00]
01-22 16:07:24.604+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e4a9a0]
01-22 16:07:24.629+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e4bd50]
01-22 16:07:24.639+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e59950]
01-22 16:07:24.649+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e5b888]
01-22 16:07:24.659+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e4f038]
01-22 16:07:24.684+0900 I/WATCH_CORE(20278): appcore-watch.c: __watch_core_set_metadata(818) > Tick per second: 5
01-22 16:07:24.684+0900 I/WATCH_CORE(20278): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-22 16:07:24.684+0900 W/WATCH_CORE(20278): appcore-watch.c: __watch_core_set_metadata(845) > Watchface type
01-22 16:07:24.719+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppControl(680) > 
01-22 16:07:24.729+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
01-22 16:07:24.729+0900 I/watchface-viewer(20278): viewer-util.cpp: GetSystemLocale(694) > mLocale[ko_KR.UTF-8]
01-22 16:07:24.734+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
01-22 16:07:24.734+0900 E/BASE_UTILS(20278): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
01-22 16:07:24.744+0900 I/watchface-viewer(20278): viewer-util.cpp: Create(864) > created locale[ko_KR] impl[0x45e85c98] refcount[1]
01-22 16:07:24.744+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
01-22 16:07:24.774+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 26x24
01-22 16:07:24.774+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateImage(136) > resized 32x32 -> 26x24
01-22 16:07:24.784+0900 W/WATCH_CORE(20278): appcore-watch.c: __widget_resume(1012) > widget_resume
01-22 16:07:24.824+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppResume(725) > 
01-22 16:07:24.824+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:24.824+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:24.829+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [37]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [37]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [37] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [23]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [23]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [23] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [22]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [22]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [22] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [11]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [11] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [6]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
01-22 16:07:24.834+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
01-22 16:07:24.839+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppResume(732) > mFirstResumeDone
01-22 16:07:24.839+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:24.839+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:24.839+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:24.839+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
01-22 16:07:24.839+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:24.844+0900 E/W_HOME  (  713): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
01-22 16:07:24.864+0900 W/W_HOME  (  713): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
01-22 16:07:24.864+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c8a1e0), origin_x(0), origin_y(0)
01-22 16:07:24.864+0900 W/W_HOME  (  713): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
01-22 16:07:24.864+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:07:24.869+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c8a1e0), origin_x(0), origin_y(0)
01-22 16:07:24.874+0900 W/W_HOME  (  713): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
01-22 16:07:24.874+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-22 16:07:24.879+0900 W/W_HOME  (  713): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
01-22 16:07:24.879+0900 W/W_HOME  (  713): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
01-22 16:07:24.879+0900 E/W_HOME  (  713): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
01-22 16:07:24.879+0900 E/W_HOME  (  713): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
01-22 16:07:24.884+0900 W/W_HOME  (  713): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
01-22 16:07:24.884+0900 E/W_HOME  (  713): dbox.c: del_cb(225) > Add viewer has no info: org.tizen.stretchtime
01-22 16:07:24.894+0900 W/W_HOME  (  713): clock_service.c: clock_service_event_handler(821) > scroller freeze off
01-22 16:07:24.894+0900 W/W_HOME  (  713): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
01-22 16:07:24.894+0900 W/W_HOME  (  713): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
01-22 16:07:24.894+0900 E/W_HOME  (  713): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
01-22 16:07:24.894+0900 W/W_HOME  (  713): cfwd.c: cfwd_get_icon_status(362) > 
01-22 16:07:24.894+0900 W/W_HOME  (  713): ============================
01-22 16:07:24.894+0900 W/W_HOME  (  713): multi_sim_category:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): multi_sim_model:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): support_callforward_auto:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): conn_status:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): remote_call_forward_auto:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): auto_call_forward_status:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): support_callforward_reverse:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): reverse_call_forward_auto:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): fwd_type:
01-22 16:07:24.894+0900 W/W_HOME  (  713): ============================
01-22 16:07:24.894+0900 W/W_HOME  (  713): 
01-22 16:07:24.894+0900 W/W_HOME  (  713): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
01-22 16:07:24.894+0900 W/W_HOME  (  713): clock_indicator.c: clock_indicator_icon_push(356) > icon:5 is added to clock indicator
01-22 16:07:24.899+0900 E/W_HOME  (  713): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
01-22 16:07:24.899+0900 E/W_HOME  (  713): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-22 16:07:24.899+0900 W/W_HOME  (  713): noti_broker.c: _clock_attached_cb(804) > 0
01-22 16:07:24.899+0900 W/W_HOME  (  713): cs_broker.c: _clock_view_attached_cb(231) > 
01-22 16:07:24.899+0900 I/GESTURE (  135): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-22 16:07:24.899+0900 I/GESTURE (  135): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-22 16:07:24.934+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
01-22 16:07:24.934+0900 E/watchface-loader(20278): watchface-loader.cpp: OnLoadingDone(812) > 
01-22 16:07:24.934+0900 E/watchface-loader(20278): watchface-loader.cpp: OnLoadingDone(815) > idle_watch = [com.samsung.watchface]
01-22 16:07:24.934+0900 E/watchface-loader(20278): watchface-loader.cpp: OnLoadingDone(823) > idle_watch = [com.samsung.watchface]
01-22 16:07:24.934+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
01-22 16:07:24.939+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:24.939+0900 E/MESSAGE_PORT(20278): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
01-22 16:07:24.939+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:24.939+0900 E/MESSAGE_PORT(20278): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
01-22 16:07:24.939+0900 E/MESSAGE_PORT(  446): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
01-22 16:07:24.939+0900 I/MESSAGE_PORT(  446): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-22 16:07:24.939+0900 E/MESSAGE_PORT(20278): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
01-22 16:07:24.939+0900 E/watchface-loader(20278): watchface-loader.cpp: OnLoadingDone(860) > mFirstLoadingDone
01-22 16:07:24.974+0900 W/AUL_AMD (  527): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-22 16:07:24.974+0900 W/AUL_AMD (  527): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-22 16:07:25.024+0900 E/W_HOME  (  713): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
01-22 16:07:25.029+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:25.029+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:25.029+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:25.029+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:25.029+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
01-22 16:07:25.029+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
01-22 16:07:25.029+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
01-22 16:07:25.224+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:25.224+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:25.224+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
01-22 16:07:25.224+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
01-22 16:07:25.269+0900 E/watchface-loader(20278): watchface-loader.cpp: OnDummyModeOffTimerExpired(396) > disable dummy mode
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-impl.cpp: SetDummyMode(95) > dummyMode[0]
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:25.269+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [37]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [23]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [22]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [11]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
01-22 16:07:25.334+0900 E/BASE_UTILS(20278): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
01-22 16:07:25.334+0900 I/watchface-viewer(20278): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 26x24
01-22 16:07:25.339+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x45e4f038]
01-22 16:07:25.349+0900 I/watchface-viewer(20278): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
01-22 16:07:25.419+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:25.419+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:25.614+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:25.614+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:25.814+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:25.814+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
01-22 16:07:25.859+0900 I/watchface-viewer(20278): viewer-view.cpp: DummyModeAnimationFinished(360) > 
01-22 16:07:25.999+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 11201197374721453446437
01-22 16:07:26.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:26.014+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:26.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:26.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:26.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:26.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:26.409+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 11202297374721453446439
01-22 16:07:26.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:26.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:26.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:26.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:27.014+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:27.014+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:27.214+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:27.214+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:27.414+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:27.414+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:27.619+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:27.619+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:27.814+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:27.814+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:28.014+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:28.014+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:28.214+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:28.214+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:28.414+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:28.414+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:28.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:28.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:28.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:28.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:29.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:29.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:29.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:29.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:29.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:29.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:29.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:29.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:29.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:29.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:30.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:30.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:30.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:30.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:30.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:30.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:30.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:30.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:30.814+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:30.814+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:31.014+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:31.014+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:31.214+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:31.214+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:31.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:31.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:31.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:31.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:31.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:31.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:32.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:32.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:32.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:32.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:32.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:32.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:32.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:32.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:32.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:32.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:33.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:33.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:33.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:33.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:33.414+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:33.414+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:33.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:33.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:33.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:33.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:34.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:34.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:34.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:34.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:34.409+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:34.409+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:34.609+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:34.609+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:34.719+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 1120228737472145344644
