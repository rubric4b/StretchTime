S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 23115
Date: 2016-01-25 17:50:14+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x428

Register Information
r0   = 0x0000041c, r1   = 0x0000000d
r2   = 0x0000032c, r3   = 0x41454194
r4   = 0x0000041c, r5   = 0x00000000
r6   = 0x41934bec, r7   = 0x41913808
r8   = 0x0000007f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeac4c44, sp   = 0xbeac4bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     29356 KB
Buffers:     16124 KB
Cached:     119772 KB
VmPeak:      77740 KB
VmSize:      77228 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15156 KB
VmRSS:       15156 KB
VmData:      21876 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22684 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 23115 TID = 23115
23115 23249 23258 

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
41454000 41457000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
41468000 4146d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41475000 41477000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41480000 41486000 r-xp /usr/lib/libappsvc.so.0.1.0
4148e000 414b2000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414bb000 4158a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415a0000 415aa000 r-xp /lib/libnss_files-2.13.so
41771000 41775000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41785000 4178c000 r-xp /usr/lib/libappcore-watch.so.1.1
41795000 4179a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a2000 417aa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417ab000 417b8000 r-xp /usr/lib/libalarm.so.0.0.0
417c1000 417c7000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
417cf000 417d5000 r-xp /usr/lib/libwidget.so.1.0.0
417de000 417e3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417eb000 417fd000 r-xp /usr/lib/libefl-assist.so.0.1.0
41805000 4180e000 r-xp /usr/lib/libcom-core.so.0.0.1
41817000 41819000 r-xp /usr/lib/libdri2.so.0.0.0
41821000 41954000 rw-p [heap]
41954000 41a91000 r-xp /usr/lib/libicui18n.so.51.1
41aa1000 41b85000 r-xp /usr/lib/libicuuc.so.51.1
43121000 4312d000 r-xp /usr/lib/libwidget_service.so.1.0.0
43135000 4313e000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43147000 43159000 r-xp /usr/lib/libtts.so
43161000 43219000 r-xp /usr/lib/libcairo.so.2.11200.14
43224000 43245000 r-xp /usr/lib/libui-extension.so.0.1.0
4324e000 43255000 r-xp /usr/lib/libtbm.so.1.0.0
4325d000 43265000 r-xp /usr/lib/libdrm.so.2.4.0
4326d000 4327b000 r-xp /usr/lib/libGLESv2.so.2.0
43284000 43285000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4328e000 43294000 r-xp /usr/lib/libxcb-render.so.0.0.0
4329c000 4329f000 r-xp /usr/lib/libEGL.so.1.4
432a7000 432c7000 r-xp /usr/lib/libefl-extension.so.0.1.0
432c8000 432cb000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
432d3000 432d8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
432e1000 432e6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
432ee000 4330f000 r-xp /usr/lib/libexif.so.12.3.3
43322000 43327000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4332f000 433f9000 r-xp /usr/lib/libCOREGL.so.4.0
4383e000 4403d000 rwxp [stack:23249]
4403d000 44040000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44048000 44053000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44177000 44976000 rwxp [stack:23258]
beaa5000 beac6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:23115)
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
/data/scs/scs_gear/ ), LogLevel( 5 ), CONNECT_TIMEOUT( TCP:2, UDP:3, TURN:10, PLAIN_UDP:3 ), AuthType( 10 ), MCC( 450 ), CC( KOR ), FWK( 0 ), SERVER_TYPE( 0 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: NetworkType(0)
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_UPNP( 1 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_LOGSIZE( 1 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_NO_EXCHANGE_D2D_KEY( 0 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_GAP_C_TIME( 0 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: OPTIONS : SCONE_OPTION_PUDP_CLOSE_TIME( 20 )
01-25 17:49:05.221+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: init - p( :89:5B:9F:BD:B1 ) opt_s( 1 )
01-25 17:49:05.256+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
01-25 17:49:05.281+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: init - SCA Request Setting : GrpID( 54a87fea5295f923fa3a ), InstanceID( w3zf8m10dj ),  AuthType( 10 ), AppSecret( CC49B78F38AE579124A11E5DFCC9EFCF ), MCC( 450 ), CC( KOR ), FWK( 0 ), SERVER_TYPE( 0 )
01-25 17:49:05.281+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: server_type(0)
01-25 17:49:05.281+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: sca - g_h_b_n s
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 73 -> 72 1453711746 180
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 639 301 767
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 0 0 897
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 761 767 913
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 444 5 533
01-25 17:49:06.806+0900 I/RESOURCED(  509): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 441 26 529
01-25 17:49:25.301+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: sca - g_h_b_n t_o
01-25 17:49:25.301+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: sca - g_h_b_n e
01-25 17:49:25.321+0900 W/SNL     ( 9176): Scone_Log.cpp: secure_dump(3003) > [SECURE_LOG] SNL :: p_sca - iv( 1075473992 ), ip( 1075473992 )
01-25 17:49:25.326+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: p_sca - e_r_t_s finish
01-25 17:49:25.366+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: init - SCA initialize failed( -201 )
01-25 17:49:25.366+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: s::terminate()
01-25 17:49:25.381+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: init - Res ( -21 )
01-25 17:49:25.381+0900 W/SNL_W   ( 9176): <sec_initializeCore_w:115> sec_initializeCore_W - err ( -21 ) - end
01-25 17:49:25.381+0900 E/SCSD    ( 9176): <util_scs_login:696> sec_init() failed. (ret:-21)
01-25 17:49:25.381+0900 E/SCSD    ( 9176): <util_scs_login:748> message: SCA API server GetHostbyname failed (check network status)
01-25 17:49:25.381+0900 W/SNL_W   ( 9176): <sec_terminateCore_ex_w:239> sec_terminateCore_ex_w () - begin 
01-25 17:49:25.386+0900 W/SNL_W   ( 9176): <setIsLoggedin:907> setIsLoggedin - isloggedin( 0 )
01-25 17:49:25.466+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.511+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.511+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
01-25 17:49:25.516+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 25-1-2016, 15:00:00 (UTC).
01-25 17:49:25.516+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-25 17:49:25.526+0900 W/SNL_W   ( 9176): <terminate_d2d_close_thread:897> terminate_d2d_close_thread - begin
01-25 17:49:25.526+0900 W/SNL_W   ( 9176): <clearAllData:290> ==== clearAllData Start ====
01-25 17:49:25.526+0900 W/SNL_W   ( 9176): <clearAllData:301> ==== clearAllData End ====
01-25 17:49:25.526+0900 W/SNL_W   ( 9176): <terminate_d2d_close_thread:901> terminate_d2d_close_thread - end
01-25 17:49:25.526+0900 W/SNL_W   ( 9176): <sec_terminateCore_ex_w:249> sec_terminateCore_ex_w () - remove all alarm
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: terminate - Call ()
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: terminate - relogin thread join
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: terminate - relogin thread end
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: m::terminate_i()
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: s::terminate()
01-25 17:49:25.531+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: p_removeAllKey (0)
01-25 17:49:25.541+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: terminate - Res( 0 )
01-25 17:49:25.541+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: terminate - ac-fin
01-25 17:49:25.541+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 0 ), way( 16)
01-25 17:49:25.541+0900 W/SNL     ( 9176): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
01-25 17:49:25.541+0900 W/SNL_W   ( 9176): <sec_terminateCore_ex_w:256> sec_terminateCore_ex_w () - end 
01-25 17:49:25.566+0900 E/SCSD    ( 9176): <on_login_alarm_event:1145> relogin() failed rv(-21)
01-25 17:49:25.566+0900 W/SCSD    ( 9176): <_set_login_interval:66> interval : 30, retry_cnt : 3
01-25 17:49:25.591+0900 W/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2213) > Unable to delete the alarm! alarm_id[1585999026], return_code[-9]
01-25 17:49:25.616+0900 I/AUL     ( 9176): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.626+0900 I/AUL     ( 9176): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.626+0900 W/ALARM_MANAGER( 9176): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(60), start(25-1-2016, 17:50:26), repeat(0), interval(0), type(-1073741822)
01-25 17:49:25.651+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.671+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.686+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.701+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.716+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.731+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1453711826, Mon Jan 25 17:50:26 2016
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 31380133, next duetime: 1453711826
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(31380133)
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1453734000), due_time(1453711826)
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
01-25 17:49:25.731+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 25-1-2016, 08:50:26 (UTC).
01-25 17:49:25.736+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
01-25 17:49:25.741+0900 W/SCSD    ( 9176): <_register_alarm:160> interval : 60, _alarm_id : 31380133
01-25 17:49:39.566+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:39.566+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:39.576+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:39.576+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:39.661+0900 I/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(264) > [1;35mts:1452877804368.000000, pattern:[MMM d일][0;m
01-25 17:49:39.661+0900 E/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(289) > [0;40;31mlocale ko_KR[0;m
01-25 17:49:39.676+0900 I/SHealth ( 3632): ICUStringUtil.cpp: GetStrFromIcu(362) > [1;35mformattedString:[1월 15일][0;m
01-25 17:49:39.676+0900 W/SHealth ( 3632): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/25 17:49:39 1월 15일[0;m
01-25 17:49:39.676+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:39.676+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:39.686+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:39.686+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:39.686+0900 I/SHealth ( 3632): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[8시간 전][0;m
01-25 17:49:39.691+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:39.691+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:39.691+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:39.691+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:39.696+0900 I/SHealth ( 3632): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-25 17:49:39.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:39.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:39.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:39.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3632): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:46.916+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=26   flick_area=55 ---> SET value to 1
01-25 17:49:46.916+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
01-25 17:49:46.916+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=26   flick_area=55 ---> SET value to 1
01-25 17:49:47.026+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
01-25 17:49:47.031+0900 I/CAPI_APPFW_APPLICATION(23055): app_main.c: ui_app_exit(715) > ui_app_exit
01-25 17:49:47.031+0900 I/CAPI_APPFW_APPLICATION(23055): app_main.c: app_efl_exit(145) > app_efl_exit
01-25 17:49:47.031+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 22
01-25 17:49:47.031+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(884) > app status : 4
01-25 17:49:47.286+0900 I/APP_CORE(23055): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
01-25 17:49:47.286+0900 I/APP_CORE(23055): appcore-efl.c: __after_loop(1090) > [APP 23055] PAUSE before termination
01-25 17:49:47.296+0900 I/CAPI_APPFW_APPLICATION(23055): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
01-25 17:49:47.296+0900 I/CAPI_APPFW_APPLICATION(23055): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
01-25 17:49:47.381+0900 W/AUL_AMD (  503): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-25 17:49:47.381+0900 W/AUL_AMD (  503): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
01-25 17:49:47.421+0900 I/efl-extension(23055): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
01-25 17:49:47.421+0900 I/efl-extension(23055): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442584b0 is freed
01-25 17:49:47.436+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b7bb8] swap changed from sync to async
01-25 17:49:47.506+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
01-25 17:49:47.506+0900 W/WATCH_CORE(23037): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
01-25 17:49:47.506+0900 I/WATCH_CORE(23037): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
01-25 17:49:47.511+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
01-25 17:49:47.511+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.511+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.511+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.511+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(0)
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.551+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2A00003] is now visible(0)
01-25 17:49:47.551+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
01-25 17:49:47.551+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-25 17:49:47.551+0900 W/W_HOME  (  717): main.c: _appcore_resume_cb(681) > appcore resume
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.551+0900 W/W_HOME  (  717): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
01-25 17:49:47.551+0900 W/W_HOME  (  717): main.c: home_resume(733) > clock/widget resumed
01-25 17:49:47.551+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-25 17:49:47.566+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
01-25 17:49:47.566+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
01-25 17:49:47.566+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-25 17:49:47.566+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-25 17:49:47.566+0900 W/WATCH_CORE(23037): appcore-watch.c: __widget_resume(1012) > widget_resume
01-25 17:49:47.571+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:47.571+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 47
01-25 17:49:47.616+0900 I/UXT     (23055): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
01-25 17:49:47.816+0900 I/efl-extension(23055): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-25 17:49:48.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:48.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 48
01-25 17:49:48.031+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b7bb8] swap changed from async to sync
01-25 17:49:48.086+0900 I/AUL_AMD (  503): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23055
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.566+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-25 17:49:48.581+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-25 17:49:48.586+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.621+0900 E/CAPI_APPFW_APP_CONTROL(  895): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-25 17:49:48.621+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:895]   value = [true][0m
01-25 17:49:48.671+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:49:48.701+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 717
01-25 17:49:48.721+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:895]   [MUSIC_PLAYER_EVENT][0m
01-25 17:49:48.721+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-25 17:49:48.726+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-25 17:49:48.726+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: preference_get_int(1132) > preference_get_int(895) : key(music-control-service_native/playing_diration) error
01-25 17:49:48.726+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:895]   preference_get_int() .. [0xfef00030][0m
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.741+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-25 17:49:48.746+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.751+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-25 17:49:48.751+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-25 17:49:48.756+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:895]   [MUSIC_PLAYER_EVENT][0m
01-25 17:49:48.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
01-25 17:49:48.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
01-25 17:49:48.761+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  895): preference.c: preference_get_int(1132) > preference_get_int(895) : key(music-control-service_native/playing_diration) error
01-25 17:49:48.761+0900 W/MUSIC_CONTROL_SERVICE(  895): music-control-info.c: music_control_info_get_player_position(577) > [31m[TID:895]   preference_get_int() .. [0xfef00030][0m
01-25 17:49:48.761+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.761+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
01-25 17:49:48.766+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-25 17:49:48.771+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-25 17:49:48.771+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
01-25 17:49:48.771+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
01-25 17:49:49.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:49.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 49
01-25 17:49:49.031+0900 W/AUL_AMD (  503): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-25 17:49:50.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:50.006+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 50
01-25 17:49:51.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:51.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 51
01-25 17:49:51.351+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:51.351+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:51.361+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:51.366+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:51.406+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-25 17:49:51.406+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-25 17:49:51.416+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-25 17:49:51.421+0900 E/TIZEN_N_SYSTEM_SETTINGS(  797): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-25 17:49:52.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:52.006+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 52
01-25 17:49:53.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:53.006+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 53
01-25 17:49:54.006+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:54.011+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 54
01-25 17:49:55.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:55.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 55
01-25 17:49:56.006+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:56.006+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 56
01-25 17:49:57.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:57.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 57
01-25 17:49:58.001+0900 I/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-25 17:49:58.001+0900 D/ANALOGWATCH(23037): Time : 5 : 49 : 58
01-25 17:49:58.131+0900 I/RESOURCED(  509): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-25 17:49:58.131+0900 I/RESOURCED(  509): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-25 17:49:58.586+0900 E/PKGMGR_SERVER(23235): pkgmgr-server.c: main(2126) > package manager server start
01-25 17:49:58.681+0900 E/PKGMGR_SERVER(23235): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1487268290], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-25 17:49:58.686+0900 E/PKGMGR_SERVER(23236): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-25 17:49:58.691+0900 E/PKGMGR  (23233): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-25 17:49:58.756+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:49:58.766+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 23037
01-25 17:49:58.766+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:49:58.771+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:49:58.771+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19206) is dead. cmd(5) is canceled
01-25 17:49:58.771+0900 E/PKGMGR_SERVER(23236): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:49:58.771+0900 E/PKGMGR_SERVER(23236): [0;m
01-25 17:49:58.776+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:49:58.776+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19495) is dead. cmd(5) is canceled
01-25 17:49:58.776+0900 E/PKGMGR_SERVER(23236): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:49:58.776+0900 E/PKGMGR_SERVER(23236): [0;m
01-25 17:49:58.776+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:49:58.776+0900 E/AUL_AMD (  503): amd_request.c: __app_process_by_pid(193) > pid(19506) is dead. cmd(5) is canceled
01-25 17:49:58.776+0900 E/PKGMGR_SERVER(23236): pkgmgr-server.c: __terminate_app(1398) > [0;31m[__terminate_app(): 1398](ret < 0) aul_terminate_pid[-3] fail
01-25 17:49:58.776+0900 E/PKGMGR_SERVER(23236): [0;m
01-25 17:49:58.776+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 5
01-25 17:49:58.781+0900 W/CAPI_WATCH_APPLICATION(23037): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-25 17:49:58.781+0900 D/ANALOGWATCH(23037): Destroy analog watch
01-25 17:49:58.781+0900 W/WATCH_CORE(23037): appcore-watch.c: __widget_destroy(992) > widget_destory
01-25 17:49:58.781+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 22
01-25 17:49:58.781+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(884) > app status : 4
01-25 17:49:58.781+0900 W/AUL_AMD (  503): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(23037), cmd(4)
01-25 17:49:58.781+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:49:58.781+0900 E/WIDGET_PROVIDER_APP(23037): client.c: client_fini(1175) > Provider is not initialized
01-25 17:49:58.796+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 23037
01-25 17:49:58.796+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 4
01-25 17:49:58.801+0900 I/efl-extension(23037): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-25 17:49:58.901+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:49:58.991+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-25 17:49:59.056+0900 E/AUL_AMD (  503): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-25 17:49:59.066+0900 W/AUL_AMD (  503): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(23037), cmd(4)
01-25 17:49:59.071+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 0
01-25 17:49:59.186+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-25 17:49:59.231+0900 I/AUL_AMD (  503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-25 17:49:59.231+0900 E/AUL_AMD (  503): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-25 17:49:59.236+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(1659) > caller pid : 695
01-25 17:49:59.321+0900 E/PKGMGR_SERVER(23236): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-25 17:49:59.426+0900 E/PKGMGR_SERVER(23235): pkgmgr-server.c: sighandler(445) > child NORMAL exit [23236]
01-25 17:49:59.456+0900 E/RESOURCED(  509): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 3
01-25 17:49:59.456+0900 E/RESOURCED(  509): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-25 17:49:59.466+0900 W/AUL_AMD (  503): amd_launch.c: _start_app(2026) > pad pid(-5)
01-25 17:49:59.466+0900 W/AUL_PAD ( 1126): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-25 17:49:59.466+0900 W/AUL_PAD ( 1126): launchpad.c: __send_result_to_caller(265) > Check app launching
01-25 17:49:59.501+0900 I/efl-extension(23115): efl_extension.c: eext_mod_init(40) > Init
01-25 17:49:59.501+0900 I/UXT     (23115): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-25 17:49:59.511+0900 I/CAPI_WATCH_APPLICATION(23115): watch_app_main.c: watch_app_main(382) > watch_app_main
01-25 17:49:59.536+0900 E/TBM     (23115): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-25 17:49:59.566+0900 I/AUL_AMD (  503): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23037
01-25 17:49:59.606+0900 W/WATCH_CORE(23115): appcore-watch.c: __widget_create(958) > widget_create
01-25 17:49:59.606+0900 D/ANALOGWATCH(23115): Create analog watch
01-25 17:49:59.606+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [23891.294922] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_23891.294922.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263078:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-25 17:49:59.606+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[23891.294922] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_23891.294922.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263078:4] gbar_fname[]
01-25 17:49:59.621+0900 E/WIDGET_VIEWER(  719): client.c: master_created(1712) > [SECURE_LOG] [23891.294922] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_23891.294922.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263078:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-25 17:49:59.621+0900 E/WIDGET_VIEWER(  719): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[23891.294922] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_717_23891.294922.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263078:4] gbar_fname[]
01-25 17:49:59.631+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-25 17:49:59.631+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-25 17:49:59.706+0900 D/ANALOGWATCH(23115): Time : 5 : 49 : 59
01-25 17:49:59.706+0900 W/WATCH_CORE(23115): appcore-watch.c: __widget_create(976) > widget_create done
01-25 17:49:59.776+0900 I/WATCH_CORE(23115): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-25 17:49:59.776+0900 I/WATCH_CORE(23115): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-25 17:49:59.776+0900 I/WATCH_CORE(23115): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-25 17:49:59.816+0900 E/EFL     (23115): edje<23115> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-25 17:49:59.821+0900 D/ANALOGWATCH(23115): [key] name, [value] 19_23891.367588
01-25 17:49:59.821+0900 D/ANALOGWATCH(23115): [key] secured, [value] true
01-25 17:49:59.821+0900 D/ANALOGWATCH(23115): [key] abi, [value] app
01-25 17:49:59.826+0900 D/ANALOGWATCH(23115): [key] hw-acceleration, [value] use-sw
01-25 17:50:00.571+0900 W/AUL_AMD (  503): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-25 17:50:00.571+0900 W/AUL_AMD (  503): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-25 17:50:00.586+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:50:00.596+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 23115
01-25 17:50:00.596+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:50:00.601+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 14
01-25 17:50:00.611+0900 W/AUL_AMD (  503): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 23115
01-25 17:50:00.611+0900 W/AUL_AMD (  503): amd_request.c: __request_handler(640) > __request_handler: 12
01-25 17:50:00.781+0900 W/AUL_AMD (  503): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-25 17:50:00.811+0900 I/AUL_PAD (23277): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-25 17:50:01.301+0900 E/PKGMGR_SERVER(23235): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-25 17:50:01.306+0900 E/PKGMGR_SERVER(23235): pkgmgr-server.c: main(2180) > package manager server terminated.
01-25 17:50:08.151+0900 E/PKGMGR  (23378): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-25 17:50:08.306+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: main(2126) > package manager server start
01-25 17:50:08.391+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1477533237], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-1477533237' '-r' 'org.tizen.stretchtime'], cookie=[Ql3HLE4xjurNzRjXFtvVPxJ9C4U=], backend_flag=[0]
01-25 17:50:08.396+0900 E/PKGMGR  (23380): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-25 17:50:08.396+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-25 17:50:08.401+0900 E/PKGMGR  (23378): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[233780002]
01-25 17:50:08.401+0900 E/PKGMGR_SERVER(23381): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-25 17:50:08.556+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-25 17:50:08.566+0900 W/AUL_AMD (  503): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-25 17:50:08.576+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:1
01-25 17:50:08.581+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:50:09.381+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
01-25 17:50:09.391+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 98
01-25 17:50:09.391+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 98
01-25 17:50:09.391+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 16 3
01-25 17:50:09.391+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 17 3
01-25 17:50:09.391+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 3
01-25 17:50:09.396+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 3
01-25 17:50:09.396+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:50:09.416+0900 E/PKGMGR_CERT(23381): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
01-25 17:50:10.301+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:50:11.361+0900 E/rpm-installer(23381): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
01-25 17:50:12.301+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:50:14.301+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
01-25 17:50:14.531+0900 E/PKGMGR_SERVER(23380): pkgmgr-server.c: sighandler(445) > child NORMAL exit [23381]
01-25 17:50:14.536+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-25 17:50:14.556+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.tizen.stretchtime is updated, need to check validation
01-25 17:50:14.556+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.tizen.stretchtime
01-25 17:50:14.571+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
01-25 17:50:14.571+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
01-25 17:50:14.576+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
01-25 17:50:14.576+0900 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
01-25 17:50:14.591+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.tizen.stretchtime is updated, preload:0 update:1 event->update:1
01-25 17:50:14.626+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
01-25 17:50:14.736+0900 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
01-25 17:50:14.996+0900 W/CRASH_MANAGER(23385): worker.c: worker_job(1199) > 1123115737472145371181
