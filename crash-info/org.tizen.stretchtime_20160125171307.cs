S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 20794
Date: 2016-01-25 17:13:07+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x428

Register Information
r0   = 0x0000041c, r1   = 0x0000000d
r2   = 0x0000032c, r3   = 0x41554194
r4   = 0x0000041c, r5   = 0x00000000
r6   = 0x414e4744, r7   = 0x414dda08
r8   = 0x0000007f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeb42c44, sp   = 0xbeb42bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     24292 KB
Buffers:     27100 KB
Cached:     109488 KB
VmPeak:      77532 KB
VmSize:      77020 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15148 KB
VmRSS:       15148 KB
VmData:      21668 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22684 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20794 TID = 20794
20794 20862 20867 

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
41554000 41557000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
41568000 4156d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41575000 41577000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41580000 41586000 r-xp /usr/lib/libappsvc.so.0.1.0
4158e000 415b2000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415bb000 4168a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416a0000 416aa000 r-xp /lib/libnss_files-2.13.so
41971000 41975000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41985000 4198c000 r-xp /usr/lib/libappcore-watch.so.1.1
41995000 4199a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419a2000 419aa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
419ab000 419b8000 r-xp /usr/lib/libalarm.so.0.0.0
419c1000 41afe000 r-xp /usr/lib/libicui18n.so.51.1
41b0e000 41bf2000 r-xp /usr/lib/libicuuc.so.51.1
41c07000 41c0d000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c15000 41c1b000 r-xp /usr/lib/libwidget.so.1.0.0
41c24000 41c29000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c31000 41c43000 r-xp /usr/lib/libefl-assist.so.0.1.0
431d2000 431db000 r-xp /usr/lib/libcom-core.so.0.0.1
431e4000 431f0000 r-xp /usr/lib/libwidget_service.so.1.0.0
431f8000 43201000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4320a000 4321c000 r-xp /usr/lib/libtts.so
43224000 432dc000 r-xp /usr/lib/libcairo.so.2.11200.14
432e7000 43308000 r-xp /usr/lib/libui-extension.so.0.1.0
43311000 43318000 r-xp /usr/lib/libtbm.so.1.0.0
43320000 43328000 r-xp /usr/lib/libdrm.so.2.4.0
43330000 43332000 r-xp /usr/lib/libdri2.so.0.0.0
4333a000 43348000 r-xp /usr/lib/libGLESv2.so.2.0
43351000 43352000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4335b000 43361000 r-xp /usr/lib/libxcb-render.so.0.0.0
43369000 4336c000 r-xp /usr/lib/libEGL.so.1.4
43374000 43394000 r-xp /usr/lib/libefl-extension.so.0.1.0
43395000 43398000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
433a0000 433a5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
433ae000 433b3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
433bb000 433dc000 r-xp /usr/lib/libexif.so.12.3.3
433ef000 433f4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433fc000 434c6000 r-xp /usr/lib/libCOREGL.so.4.0
4380b000 4400a000 rwxp [stack:20862]
4400a000 4400d000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44015000 44020000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44144000 44943000 rwxp [stack:20867]
beb23000 beb44000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20794)
Call Stack Count: 6
 0: (0x400169dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0x400170d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0x40017360) [/lib/ld-linux.so.3] + 0xa360
 3: (0x4001b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0x40021a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0x404e170c) [/lib/libc.so.6] + 0x6d70c
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
r(640) > __request_handler: 14
01-25 17:12:14.877+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:14.977+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:14.987+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:14.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:14.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 15
01-25 17:12:15.092+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.102+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.202+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.212+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.312+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.322+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.422+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.437+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.537+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.547+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.647+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.662+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.762+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.772+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.872+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.882+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.982+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:15.992+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:15.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:15.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 16
01-25 17:12:16.092+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.102+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.202+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.212+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.317+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.327+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.427+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.437+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.542+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.552+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.652+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.667+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.767+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.777+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.877+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:12:16.882+0900 I/APP_CORE(20291): appcore-efl.c: __do_app(429) > [APP 20291] Event: TERMINATE State: PAUSED
01-25 17:12:16.887+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 22
01-25 17:12:16.887+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(884) > app status : 4
01-25 17:12:16.887+0900 W/AUL_AMD (  503): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(20291), cmd(4)
01-25 17:12:16.892+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:16.907+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:16.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:16.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 17
01-25 17:12:17.007+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:17.017+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:17.087+0900 I/APP_CORE(20291): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
01-25 17:12:17.087+0900 I/CAPI_APPFW_APPLICATION(20291): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
01-25 17:12:17.117+0900 I/efl-extension(20291): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
01-25 17:12:17.117+0900 I/efl-extension(20291): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454d0d68 is freed
01-25 17:12:17.122+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:17.127+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:17.177+0900 I/UXT     (20291): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
01-25 17:12:17.232+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:17.242+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:17.347+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:17.357+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20291
01-25 17:12:17.367+0900 I/efl-extension(20291): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-25 17:12:17.442+0900 I/AUL_AMD (  503): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20291
01-25 17:12:17.457+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:17.472+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-25 17:12:17.482+0900 E/PKGMGR_SERVER(20527): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-25 17:12:17.497+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20527]
01-25 17:12:17.502+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:12:17.502+0900 E/PKGMGR_SERVER(20706): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.example.stretchme]
01-25 17:12:17.672+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-25 17:12:17.677+0900 W/AUL_AMD (  503): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-25 17:12:17.697+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.stretchme is being updateded:1
01-25 17:12:17.837+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:12:17.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:17.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 18
01-25 17:12:18.887+0900 W/AUL_AMD (  503): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-25 17:12:18.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:18.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 19
01-25 17:12:19.937+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:12:19.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:19.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 20
01-25 17:12:20.232+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
01-25 17:12:20.237+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 98
01-25 17:12:20.242+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 98
01-25 17:12:20.242+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 16 3
01-25 17:12:20.242+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 17 3
01-25 17:12:20.242+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 3
01-25 17:12:20.242+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 3
01-25 17:12:20.252+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:12:20.267+0900 E/PKGMGR_CERT(20706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
01-25 17:12:20.767+0900 I/RESOURCED(  509): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-25 17:12:20.767+0900 I/RESOURCED(  509): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-25 17:12:20.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:20.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 21
01-25 17:12:21.937+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:12:21.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:21.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 22
01-25 17:12:22.357+0900 E/rpm-installer(20706): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
01-25 17:12:22.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:22.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 23
01-25 17:12:23.937+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:12:23.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:23.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 24
01-25 17:12:24.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:24.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 25
01-25 17:12:25.562+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:12:25.587+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20706]
01-25 17:12:25.602+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.stretchme is updated, need to check validation
01-25 17:12:25.602+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.tizen.stretchtime
01-25 17:12:25.612+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
01-25 17:12:25.612+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
01-25 17:12:25.612+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
01-25 17:12:25.612+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
01-25 17:12:25.687+0900 W/APPS    (  717): pkgmgr.c: _update_app(732) >  old order:[26]
01-25 17:12:25.727+0900 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
01-25 17:12:25.772+0900 E/EFL     (  717): elementary<717> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x47b76ae0 into part 'elm.swallow.event.0'
01-25 17:12:25.782+0900 E/APPS    (  717): AppsViewNecklace.cpp: onShow(568) >  AppsItemList[27]
01-25 17:12:25.782+0900 W/APPS    (  717): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[0:2]
01-25 17:12:25.842+0900 E/Vi::Animations(  717): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
01-25 17:12:25.842+0900 I/Vi::Animations(  717): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
01-25 17:12:25.842+0900 E/Vi::Animations(  717): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
01-25 17:12:25.842+0900 I/Vi::Animations(  717): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
01-25 17:12:25.857+0900 E/EFL     (  717): elementary<717> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x47b76ae0 into part 'elm.swallow.event.0'
01-25 17:12:25.867+0900 E/APPS    (  717): AppsViewNecklace.cpp: onShow(568) >  AppsItemList[28]
01-25 17:12:25.867+0900 W/APPS    (  717): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[0:2]
01-25 17:12:25.937+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-25 17:12:25.937+0900 E/PKGMGR_SERVER(20524): pkgmgr-server.c: main(2180) > package manager server terminated.
01-25 17:12:25.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:25.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 26
01-25 17:12:26.372+0900 W/APPS    (  717): pkgmgr.c: _update_app_cb(711) >  Update apps order
01-25 17:12:26.372+0900 W/APPS    (  717): AppsViewNecklace.cpp: onTouchEventCancel(4324) >  touch cancel
01-25 17:12:26.532+0900 W/APPS    (  717): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[0:2]
01-25 17:12:26.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:26.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 27
01-25 17:12:27.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:28.002+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 28
01-25 17:12:29.002+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:29.002+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 29
01-25 17:12:30.002+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:30.002+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 30
01-25 17:12:31.002+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:31.007+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 31
01-25 17:12:31.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:31.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 32
01-25 17:12:32.287+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 0
01-25 17:12:32.307+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
01-25 17:12:32.317+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
01-25 17:12:32.317+0900 E/AUL_AMD (  503): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-25 17:12:32.317+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(1659) > caller pid : 20789
01-25 17:12:32.332+0900 E/RESOURCED(  509): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.stretchme, table num : 2
01-25 17:12:32.332+0900 E/RESOURCED(  509): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-25 17:12:32.332+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(2026) > pad pid(-5)
01-25 17:12:32.332+0900 W/AUL_PAD ( 1126): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-25 17:12:32.332+0900 W/AUL_PAD ( 1126): launchpad.c: __send_result_to_caller(265) > Check app launching
01-25 17:12:32.377+0900 I/efl-extension(20362): efl_extension.c: eext_mod_init(40) > Init
01-25 17:12:32.382+0900 I/UXT     (20362): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-25 17:12:32.392+0900 D/stretchme(20362): test_model(229) > transition matrix:
01-25 17:12:32.392+0900 D/stretchme(20362): test_model(231) > observation symbol matrix:
01-25 17:12:32.397+0900 D/stretchme(20362): hmm_evaluate(315) > HMM applying forward algorithm to the sequence...
01-25 17:12:32.397+0900 D/stretchme(20362): hmm_evaluate(336) > HMM before learning -> log_p_forward: -182.739669
01-25 17:12:32.427+0900 D/stretchme(20362): test_model(265) > HMM transition matrix:
01-25 17:12:32.427+0900 D/stretchme(20362): test_model(267) > HMM observation symbol matrix:
01-25 17:12:32.427+0900 D/stretchme(20362): hmm_evaluate(315) > HMM applying forward algorithm to the sequence...
01-25 17:12:32.427+0900 D/stretchme(20362): hmm_evaluate(336) > HMM before learning -> log_p_forward: -157.181831
01-25 17:12:32.432+0900 I/CAPI_APPFW_APPLICATION(20362): app_main.c: ui_app_main(704) > app_efl_main
01-25 17:12:32.437+0900 I/CAPI_APPFW_APPLICATION(20362): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
01-25 17:12:32.502+0900 E/TBM     (20362): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-25 17:12:32.687+0900 I/stretchme(20362): main.c: vibrate(31) > Connection to vibrator established
01-25 17:12:32.697+0900 I/stretchme(20362): main.c: vibrate(34) > Device vibrates!
01-25 17:12:32.912+0900 E/E17     (  365): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03c00002)
01-25 17:12:32.912+0900 I/APP_CORE(20362): appcore-efl.c: __do_app(429) > [APP 20362] Event: RESET State: CREATED
01-25 17:12:32.917+0900 I/CAPI_APPFW_APPLICATION(20362): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
01-25 17:12:32.952+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
01-25 17:12:32.952+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:32.957+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:32.957+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:32.957+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
01-25 17:12:32.962+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
01-25 17:12:32.962+0900 I/APP_CORE(20362): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
01-25 17:12:32.962+0900 I/APP_CORE(20362): appcore-efl.c: __do_app(474) > [APP 20362] Initial Launching, call the resume_cb
01-25 17:12:32.962+0900 I/CAPI_APPFW_APPLICATION(20362): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
01-25 17:12:32.987+0900 W/APP_CORE(20362): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
01-25 17:12:32.997+0900 I/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:12:32.997+0900 D/ANALOGWATCH(19914): Time : 5 : 12 : 33
01-25 17:12:33.012+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b7bb8] swap changed from sync to async
01-25 17:12:33.062+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(1)
01-25 17:12:33.062+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
01-25 17:12:33.062+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:33.062+0900 W/W_HOME  (  717): event_manager.c: _state_control(333) > appcore paused manually
01-25 17:12:33.062+0900 W/W_HOME  (  717): main.c: home_appcore_pause(717) > Home Appcore Paused
01-25 17:12:33.067+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
01-25 17:12:33.067+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:33.072+0900 W/AUL_AMD (  503): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-25 17:12:33.072+0900 W/AUL_AMD (  503): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-25 17:12:33.082+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:33.082+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
01-25 17:12:33.082+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-25 17:12:33.082+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:12:33.087+0900 I/APP_CORE(20362): appcore-efl.c: __do_app(429) > [APP 20362] Event: RESUME State: RUNNING
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-25 17:12:33.087+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:12:33.087+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(1)
01-25 17:12:33.087+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
01-25 17:12:33.092+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
01-25 17:12:33.092+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
01-25 17:12:33.092+0900 E/W_HOME  (  717): main.c: _pause_cb(668) > paused already
01-25 17:12:33.092+0900 E/CAPI_APPFW_APP_CONTROL(  895): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-25 17:12:33.092+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:895]   value = [false][0m
01-25 17:12:33.157+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
01-25 17:12:33.157+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-25 17:12:33.157+0900 W/WATCH_CORE(19914): appcore-watch.c: __widget_pause(1001) > widget_pause
01-25 17:12:33.592+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
01-25 17:12:33.607+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:33.627+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20362
01-25 17:12:33.632+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:12:33.662+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:33.677+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20362
01-25 17:12:33.677+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:12:33.687+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 78 -> 77 1453709553 211
01-25 17:12:33.692+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 77 642 296 824
01-25 17:12:33.692+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 77 0 0 964
01-25 17:12:33.692+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 77 764 762 980
01-25 17:12:33.692+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 77 198 5 254
01-25 17:12:33.692+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 77 528 22 678
01-25 17:12:33.972+0900 I/AUL_PAD (20794): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-25 17:12:38.132+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
01-25 17:12:48.947+0900 E/PKGMGR_SERVER(20857): pkgmgr-server.c: main(2126) > package manager server start
01-25 17:12:49.032+0900 E/PKGMGR_SERVER(20857): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_578083743], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-25 17:12:49.037+0900 E/PKGMGR_SERVER(20859): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-25 17:12:49.042+0900 E/PKGMGR  (20851): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-25 17:12:49.092+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:49.102+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19914
01-25 17:12:49.102+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:12:49.107+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:12:49.107+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19206) is dead. cmd(5) is canceled
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): [0;m
01-25 17:12:49.112+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:12:49.112+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19495) is dead. cmd(5) is canceled
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): [0;m
01-25 17:12:49.112+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:12:49.112+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19506) is dead. cmd(5) is canceled
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:12:49.112+0900 E/PKGMGR_SERVER(20859): [0;m
01-25 17:12:49.112+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:12:49.117+0900 W/AUL_AMD (  503): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(19914), cmd(4)
01-25 17:12:49.117+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 22
01-25 17:12:49.117+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(884) > app status : 4
01-25 17:12:49.117+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:49.117+0900 W/CAPI_WATCH_APPLICATION(19914): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-25 17:12:49.117+0900 D/ANALOGWATCH(19914): Destroy analog watch
01-25 17:12:49.122+0900 W/WATCH_CORE(19914): appcore-watch.c: __widget_destroy(992) > widget_destory
01-25 17:12:49.122+0900 E/WIDGET_PROVIDER_APP(19914): client.c: client_fini(1175) > Provider is not initialized
01-25 17:12:49.127+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19914
01-25 17:12:49.127+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 4
01-25 17:12:49.132+0900 I/efl-extension(19914): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-25 17:12:49.232+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:49.302+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-25 17:12:49.357+0900 E/AUL_AMD (  503): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-25 17:12:49.362+0900 W/AUL_AMD (  503): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(19914), cmd(4)
01-25 17:12:49.382+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 0
01-25 17:12:49.417+0900 E/PKGMGR_SERVER(20859): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-25 17:12:49.447+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-25 17:12:49.482+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-25 17:12:49.482+0900 E/AUL_AMD (  503): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-25 17:12:49.482+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(1659) > caller pid : 695
01-25 17:12:49.507+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(2026) > pad pid(-5)
01-25 17:12:49.512+0900 W/AUL_PAD ( 1126): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-25 17:12:49.512+0900 W/AUL_PAD ( 1126): launchpad.c: __send_result_to_caller(265) > Check app launching
01-25 17:12:49.577+0900 I/efl-extension(20794): efl_extension.c: eext_mod_init(40) > Init
01-25 17:12:49.577+0900 I/UXT     (20794): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-25 17:12:49.592+0900 I/CAPI_WATCH_APPLICATION(20794): watch_app_main.c: watch_app_main(382) > watch_app_main
01-25 17:12:49.612+0900 E/PKGMGR_SERVER(20857): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20859]
01-25 17:12:49.637+0900 E/TBM     (20794): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-25 17:12:49.647+0900 I/AUL_AMD (  503): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 19914
01-25 17:12:49.647+0900 E/RESOURCED(  509): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-25 17:12:49.647+0900 E/RESOURCED(  509): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-25 17:12:49.687+0900 W/WATCH_CORE(20794): appcore-watch.c: __widget_create(958) > widget_create
01-25 17:12:49.687+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [21713.451172] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_21713.451172.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263040:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-25 17:12:49.687+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[21713.451172] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_21713.451172.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263040:4] gbar_fname[]
01-25 17:12:49.687+0900 E/WIDGET_VIEWER(  719): client.c: master_created(1712) > [SECURE_LOG] [21713.451172] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_21713.451172.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263040:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-25 17:12:49.687+0900 E/WIDGET_VIEWER(  719): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[21713.451172] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_21713.451172.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263040:4] gbar_fname[]
01-25 17:12:49.692+0900 D/ANALOGWATCH(20794): Create analog watch
01-25 17:12:49.702+0900 E/WIDGET_VIEWER(  719): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-25 17:12:49.702+0900 E/WIDGET_EVAS(  719): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-25 17:12:49.702+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-25 17:12:49.702+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-25 17:12:49.757+0900 D/ANALOGWATCH(20794): Time : 5 : 12 : 49
01-25 17:12:49.757+0900 W/WATCH_CORE(20794): appcore-watch.c: __widget_create(976) > widget_create done
01-25 17:12:49.822+0900 I/WATCH_CORE(20794): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-25 17:12:49.822+0900 I/WATCH_CORE(20794): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-25 17:12:49.822+0900 I/WATCH_CORE(20794): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-25 17:12:49.852+0900 E/EFL     (20794): edje<20794> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-25 17:12:49.857+0900 D/ANALOGWATCH(20794): [key] name, [value] 15_21713.516073
01-25 17:12:49.857+0900 D/ANALOGWATCH(20794): [key] secured, [value] true
01-25 17:12:49.857+0900 D/ANALOGWATCH(20794): [key] abi, [value] app
01-25 17:12:49.857+0900 D/ANALOGWATCH(20794): [key] hw-acceleration, [value] use-sw
01-25 17:12:50.622+0900 W/AUL_AMD (  503): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-25 17:12:50.622+0900 W/AUL_AMD (  503): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-25 17:12:50.642+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:50.647+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20794
01-25 17:12:50.647+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:12:50.657+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20794
01-25 17:12:50.657+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:12:50.662+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:12:50.857+0900 I/AUL_PAD (20877): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-25 17:12:50.937+0900 E/PKGMGR_SERVER(20857): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-25 17:12:50.937+0900 E/PKGMGR_SERVER(20857): pkgmgr-server.c: main(2180) > package manager server terminated.
01-25 17:12:51.122+0900 W/AUL_AMD (  503): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-25 17:13:01.032+0900 E/PKGMGR  (20990): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-25 17:13:01.247+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: main(2126) > package manager server start
01-25 17:13:01.327+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_590313673], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_590313673' '-r' 'org.tizen.stretchtime'], cookie=[tZLIS022NtluJytVNtE81dQA76I=], backend_flag=[0]
01-25 17:13:01.332+0900 E/PKGMGR  (20992): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-25 17:13:01.332+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-25 17:13:01.337+0900 E/PKGMGR_SERVER(20994): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-25 17:13:01.337+0900 E/PKGMGR  (20990): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[209900002]
01-25 17:13:01.497+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:1
01-25 17:13:01.502+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-25 17:13:01.507+0900 W/AUL_AMD (  503): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-25 17:13:01.522+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:13:02.142+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:13:02.142+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:13:02.142+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:13:02.142+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:13:02.157+0900 I/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(264) > [1;35mts:1452877804368.000000, pattern:[MMM d일][0;m
01-25 17:13:02.157+0900 E/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(289) > [0;40;31mlocale ko_KR[0;m
01-25 17:13:02.157+0900 I/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(362) > [1;35mformattedString:[1월 15일][0;m
01-25 17:13:02.162+0900 W/SHealth ( 3632): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/25 17:13:2 1월 15일[0;m
01-25 17:13:02.162+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:13:02.162+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:13:02.162+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:13:02.162+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:13:02.162+0900 I/SHealth ( 3632): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[8시간 전][0;m
01-25 17:13:02.162+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:13:02.167+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:13:02.167+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:13:02.167+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:13:02.167+0900 I/SHealth ( 3632): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-25 17:13:02.172+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:13:02.172+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:13:02.172+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:13:02.172+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:13:02.352+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
01-25 17:13:02.362+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 98
01-25 17:13:02.362+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 98
01-25 17:13:02.367+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 16 3
01-25 17:13:02.367+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 17 3
01-25 17:13:02.367+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 3
01-25 17:13:02.367+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 3
01-25 17:13:02.377+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:13:02.397+0900 E/PKGMGR_CERT(20994): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
01-25 17:13:03.937+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:13:04.302+0900 E/rpm-installer(20994): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
01-25 17:13:05.937+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:13:07.487+0900 E/PKGMGR_SERVER(20992): pkgmgr-server.c: sighandler(445) > child NORMAL exit [20994]
01-25 17:13:07.497+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:13:07.512+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.tizen.stretchtime is updated, need to check validation
01-25 17:13:07.512+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.tizen.stretchtime
01-25 17:13:07.537+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
01-25 17:13:07.537+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
01-25 17:13:07.537+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
01-25 17:13:07.537+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
01-25 17:13:07.592+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.tizen.stretchtime is updated, preload:0 update:1 event->update:1
01-25 17:13:07.617+0900 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
01-25 17:13:07.662+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
01-25 17:13:07.927+0900 W/CRASH_MANAGER(20999): worker.c: worker_job(1199) > 1120794737472145370958
