S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 16174
Date: 2016-01-20 16:08:35+0900
Executable File Path: /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3834

Register Information
r0   = 0xbe8bc2d0, r1   = 0xbe8bc290
r2   = 0xbe8bc2d0, r3   = 0xbe8bc5b0
r4   = 0xbe8bc538, r5   = 0xbe8bc2d0
r6   = 0x00000132, r7   = 0xbe8bc2a0
r8   = 0x4030b9c0, r9   = 0x41607098
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x41990ddc, sp   = 0xbe8bc1b8
lr   = 0x418e3771, pc   = 0x00003834
cpsr = 0xa0000010

Memory Information
MemTotal:   491012 KB
MemFree:     17972 KB
Buffers:     11132 KB
Cached:     120280 KB
VmPeak:      79136 KB
VmSize:      78624 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15340 KB
VmRSS:       15340 KB
VmData:      22136 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23716 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 16174 TID = 16174
16174 16755 16760 

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
414bb000 414c5000 r-xp /lib/libnss_files-2.13.so
414ce000 414d5000 r-xp /usr/lib/libappcore-watch.so.1.1
414de000 414e6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414e7000 414e9000 rw-p [heap]
414e9000 4150a000 rw-p [heap]
4150a000 415d9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
418ad000 41989000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
419d7000 419dc000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419e4000 419e8000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
419f1000 41a11000 r-xp /usr/lib/libefl-extension.so.0.1.0
41a12000 41a1f000 r-xp /usr/lib/libalarm.so.0.0.0
41a28000 41b65000 r-xp /usr/lib/libicui18n.so.51.1
41b75000 41c59000 r-xp /usr/lib/libicuuc.so.51.1
41c6e000 41c74000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c7c000 41c82000 r-xp /usr/lib/libwidget.so.1.0.0
41c8b000 41c90000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c98000 41cb6000 r-xp /usr/lib/libsensor.so.1.1.0
41cc0000 41cd2000 r-xp /usr/lib/libefl-assist.so.0.1.0
41cda000 41d92000 r-xp /usr/lib/libcairo.so.2.11200.14
43324000 4332d000 r-xp /usr/lib/libcom-core.so.0.0.1
43336000 43342000 r-xp /usr/lib/libwidget_service.so.1.0.0
4334a000 43353000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4335c000 43363000 r-xp /usr/lib/libsensord-share.so
4336b000 4337d000 r-xp /usr/lib/libtts.so
43385000 433a6000 r-xp /usr/lib/libui-extension.so.0.1.0
433af000 433b6000 r-xp /usr/lib/libtbm.so.1.0.0
433be000 433cc000 r-xp /usr/lib/libGLESv2.so.2.0
433d5000 433d6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
433df000 433e5000 r-xp /usr/lib/libxcb-render.so.0.0.0
433ed000 433f0000 r-xp /usr/lib/libEGL.so.1.4
433f8000 43400000 r-xp /usr/lib/libdrm.so.2.4.0
43408000 4340a000 r-xp /usr/lib/libdri2.so.0.0.0
43412000 43415000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4341d000 43422000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4342b000 43430000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43438000 43459000 r-xp /usr/lib/libexif.so.12.3.3
4346c000 43471000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43579000 43643000 r-xp /usr/lib/libCOREGL.so.4.0
43988000 44187000 rwxp [stack:16755]
44187000 4418a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44192000 4419d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
442c1000 44ac0000 rwxp [stack:16760]
be89c000 be8bd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:16174)
Call Stack Count: 1
 0: (0x3834) (null)
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
EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4867337 button=1 downs=0
01-20 16:07:43.435+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c89c38), type(elm_scroller)
01-20 16:07:43.435+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.435+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.435+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.435+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.445+0900 E/EFL     (16100): evas_main<16100> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4867288 button=1 downs=0
01-20 16:07:43.450+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.450+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.450+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.450+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.455+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
01-20 16:07:43.460+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.460+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.460+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.460+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.475+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.475+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.475+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.475+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.495+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.495+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.495+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.495+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.510+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.510+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.515+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.515+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.530+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.530+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.530+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.535+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.555+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:43.555+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:43.555+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.555+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.575+0900 W/WATCH_CORE(16100): appcore-watch.c: __widget_pause(1001) > widget_pause
01-20 16:07:43.580+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 16:07:43.580+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c89c38 : elm_scroller] CurrentPage(0)
01-20 16:07:43.710+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
01-20 16:07:43.825+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.825+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(108) ev->cur.canvas.y(219)
01-20 16:07:43.825+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.825+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4867736 button=1 downs=1
01-20 16:07:43.840+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.840+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(112) ev->cur.canvas.y(221)
01-20 16:07:43.840+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.845+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.845+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(126) ev->cur.canvas.y(221)
01-20 16:07:43.845+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.855+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.855+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(142) ev->cur.canvas.y(221)
01-20 16:07:43.855+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(165) ev->cur.canvas.y(221)
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c89c38), type(elm_scroller)
01-20 16:07:43.865+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
01-20 16:07:43.870+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c89c38), type(elm_scroller)
01-20 16:07:43.870+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:43.870+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:43.870+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_show(541) > 
01-20 16:07:43.870+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
01-20 16:07:43.870+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: widget_viewer_evas_is_widget(7974) > [SECURE_LOG] Invalid object
01-20 16:07:43.890+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x49b99a58 -> 360 0 0x4a5154f8
01-20 16:07:43.890+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
01-20 16:07:43.890+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c89c38), locked_x(0)
01-20 16:07:43.890+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c89c38)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(198) ev->cur.canvas.y(223)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(230) ev->cur.canvas.y(226)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.910+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(262) ev->cur.canvas.y(228)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(294) ev->cur.canvas.y(229)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c89c38), locked_x(0)
01-20 16:07:43.915+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c89c38)
01-20 16:07:43.925+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4867831 button=1 downs=0
01-20 16:07:43.925+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c89c38), type(elm_scroller)
01-20 16:07:43.950+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
01-20 16:07:44.315+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.315+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(319) ev->cur.canvas.y(152)
01-20 16:07:44.315+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.315+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4868223 button=1 downs=1
01-20 16:07:44.320+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.320+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(306) ev->cur.canvas.y(147)
01-20 16:07:44.320+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(277) ev->cur.canvas.y(141)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c89c38), type(elm_scroller)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
01-20 16:07:44.325+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c89c38), type(elm_scroller)
01-20 16:07:44.330+0900 E/W_HOME  (  715): home_navigation.c: _vi_init(939) > (scroller_info->vi_info.on == 1) -> _vi_init() return
01-20 16:07:44.330+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x49b99a58 -> 360 0 0x4a5154f8
01-20 16:07:44.335+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c89c38), locked_x(0)
01-20 16:07:44.335+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c89c38)
01-20 16:07:44.335+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.335+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.335+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.335+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.345+0900 W/WATCH_CORE(16100): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 16:07:44.350+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:44.350+0900 D/stretch (16100): Time : 4 : 7 : 44
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(239) ev->cur.canvas.y(147)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(198) ev->cur.canvas.y(157)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c89c38), locked_x(0)
01-20 16:07:44.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c89c38)
01-20 16:07:44.355+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.355+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.355+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.355+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.365+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.365+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(152) ev->cur.canvas.y(168)
01-20 16:07:44.365+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.365+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c89c38), locked_x(0)
01-20 16:07:44.365+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c89c38)
01-20 16:07:44.375+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.375+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.375+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.375+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.385+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), block(2)
01-20 16:07:44.385+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), ev->cur.canvas.x(107) ev->cur.canvas.y(179)
01-20 16:07:44.385+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c89c38), hold(0) freeze(0)
01-20 16:07:44.390+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4868291 button=1 downs=0
01-20 16:07:44.390+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c89c38), type(elm_scroller)
01-20 16:07:44.395+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.400+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.400+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.400+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.410+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.410+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.410+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.410+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.420+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.420+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.420+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.420+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.430+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.430+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.435+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.435+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.450+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.450+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.450+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.450+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.465+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
01-20 16:07:44.465+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-20 16:07:44.470+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.470+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.470+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.470+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.470+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
01-20 16:07:44.490+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.490+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.490+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.490+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.510+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.510+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.510+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(581) > 0
01-20 16:07:44.510+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_select(591) > select index:1
01-20 16:07:44.530+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
01-20 16:07:44.530+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
01-20 16:07:44.535+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
01-20 16:07:44.535+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c89c38 : elm_scroller] CurrentPage(1)
01-20 16:07:44.660+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
01-20 16:07:45.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:45.005+0900 D/stretch (16100): Time : 4 : 7 : 45
01-20 16:07:45.040+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
01-20 16:07:46.010+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:46.010+0900 D/stretch (16100): Time : 4 : 7 : 46
01-20 16:07:47.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:47.006+0900 D/stretch (16100): Time : 4 : 7 : 47
01-20 16:07:48.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:48.010+0900 D/stretch (16100): Time : 4 : 7 : 48
01-20 16:07:49.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:49.006+0900 D/stretch (16100): Time : 4 : 7 : 49
01-20 16:07:50.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:50.010+0900 D/stretch (16100): Time : 4 : 7 : 50
01-20 16:07:51.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:51.011+0900 D/stretch (16100): Time : 4 : 7 : 51
01-20 16:07:52.001+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:52.006+0900 D/stretch (16100): Time : 4 : 7 : 52
01-20 16:07:53.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:53.006+0900 D/stretch (16100): Time : 4 : 7 : 53
01-20 16:07:54.001+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:54.006+0900 D/stretch (16100): Time : 4 : 7 : 54
01-20 16:07:55.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:55.005+0900 D/stretch (16100): Time : 4 : 7 : 55
01-20 16:07:56.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:56.005+0900 D/stretch (16100): Time : 4 : 7 : 56
01-20 16:07:57.001+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:57.001+0900 D/stretch (16100): Time : 4 : 7 : 57
01-20 16:07:58.011+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:58.011+0900 D/stretch (16100): Time : 4 : 7 : 58
01-20 16:07:59.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:07:59.005+0900 D/stretch (16100): Time : 4 : 7 : 59
01-20 16:08:00.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:00.005+0900 D/stretch (16100): Time : 4 : 8 : 0
01-20 16:08:00.875+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-20 16:08:00.875+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-20 16:08:00.880+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
01-20 16:08:00.885+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:08:00.885+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:08:00.890+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
01-20 16:08:00.890+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-20 16:08:00.895+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-20 16:08:00.895+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
01-20 16:08:01.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:01.005+0900 D/stretch (16100): Time : 4 : 8 : 1
01-20 16:08:01.665+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-20 16:08:01.665+0900 I/RESOURCED(  521): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-20 16:08:02.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:02.005+0900 D/stretch (16100): Time : 4 : 8 : 2
01-20 16:08:03.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:03.005+0900 D/stretch (16100): Time : 4 : 8 : 3
01-20 16:08:04.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:04.005+0900 D/stretch (16100): Time : 4 : 8 : 4
01-20 16:08:05.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:05.010+0900 D/stretch (16100): Time : 4 : 8 : 5
01-20 16:08:06.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:06.005+0900 D/stretch (16100): Time : 4 : 8 : 6
01-20 16:08:07.001+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:07.001+0900 D/stretch (16100): Time : 4 : 8 : 7
01-20 16:08:08.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:08.006+0900 D/stretch (16100): Time : 4 : 8 : 8
01-20 16:08:09.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:09.006+0900 D/stretch (16100): Time : 4 : 8 : 9
01-20 16:08:10.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:10.006+0900 D/stretch (16100): Time : 4 : 8 : 10
01-20 16:08:11.005+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:11.005+0900 D/stretch (16100): Time : 4 : 8 : 11
01-20 16:08:12.006+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:12.011+0900 D/stretch (16100): Time : 4 : 8 : 12
01-20 16:08:13.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:13.005+0900 D/stretch (16100): Time : 4 : 8 : 13
01-20 16:08:14.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:14.000+0900 D/stretch (16100): Time : 4 : 8 : 14
01-20 16:08:15.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:15.005+0900 D/stretch (16100): Time : 4 : 8 : 15
01-20 16:08:16.000+0900 I/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:16.000+0900 D/stretch (16100): Time : 4 : 8 : 16
01-20 16:08:16.355+0900 E/PKGMGR_SERVER(16750): pkgmgr-server.c: main(2126) > package manager server start
01-20 16:08:16.465+0900 E/PKGMGR_SERVER(16750): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1502851287], req_type=[12], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[], cookie=[], backend_flag=[0]
01-20 16:08:16.470+0900 E/PKGMGR_SERVER(16751): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.tizen.stretchtime]
01-20 16:08:16.475+0900 E/PKGMGR  (16743): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.tizen.stretchtime, -1]
01-20 16:08:16.545+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:08:16.555+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16100
01-20 16:08:16.555+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:08:16.560+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 5
01-20 16:08:16.565+0900 W/CAPI_WATCH_APPLICATION(16100): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
01-20 16:08:16.565+0900 D/stretch (16100): Destroy analog watch
01-20 16:08:16.570+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 22
01-20 16:08:16.570+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(884) > app status : 4
01-20 16:08:16.570+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(16100), cmd(4)
01-20 16:08:16.570+0900 W/WATCH_CORE(16100): appcore-watch.c: __widget_destroy(992) > widget_destory
01-20 16:08:16.570+0900 E/WIDGET_PROVIDER_APP(16100): client.c: client_fini(1175) > Provider is not initialized
01-20 16:08:16.570+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:08:16.585+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16100
01-20 16:08:16.585+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 4
01-20 16:08:16.590+0900 I/efl-extension(16100): efl_extension.c: eext_mod_shutdown(46) > Shutdown
01-20 16:08:16.690+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:08:16.760+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
01-20 16:08:16.805+0900 E/PKGMGR_SERVER(16751): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
01-20 16:08:16.845+0900 E/AUL_AMD (  519): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
01-20 16:08:16.845+0900 W/AUL_AMD (  519): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(13), pid(16100), cmd(4)
01-20 16:08:16.850+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 0
01-20 16:08:16.885+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:08:16.905+0900 I/AUL_AMD (  519): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
01-20 16:08:16.905+0900 E/AUL_AMD (  519): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
01-20 16:08:16.905+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(1659) > caller pid : 677
01-20 16:08:16.920+0900 W/AUL_AMD (  519): amd_launch.c: _start_app(2026) > pad pid(-5)
01-20 16:08:16.920+0900 W/AUL_PAD ( 1127): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
01-20 16:08:16.925+0900 W/AUL_PAD ( 1127): launchpad.c: __send_result_to_caller(265) > Check app launching
01-20 16:08:16.930+0900 E/PKGMGR_SERVER(16750): pkgmgr-server.c: sighandler(445) > child NORMAL exit [16751]
01-20 16:08:17.000+0900 I/efl-extension(16174): efl_extension.c: eext_mod_init(40) > Init
01-20 16:08:17.000+0900 I/UXT     (16174): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
01-20 16:08:17.015+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: watch_app_main(382) > watch_app_main
01-20 16:08:17.040+0900 I/AUL_AMD (  519): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 16100
01-20 16:08:17.040+0900 E/RESOURCED(  521): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.tizen.stretchtime, table num : 2
01-20 16:08:17.040+0900 E/RESOURCED(  521): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
01-20 16:08:17.060+0900 E/TBM     (16174): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
01-20 16:08:17.105+0900 W/WATCH_CORE(16174): appcore-watch.c: __widget_create(958) > widget_create
01-20 16:08:17.105+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [4683.952148] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4683.952148.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263128:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:08:17.105+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[4683.952148] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4683.952148.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263128:4] gbar_fname[]
01-20 16:08:17.105+0900 D/stretch (16174): Create analog watch
01-20 16:08:17.105+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1712) > [SECURE_LOG] [4683.952148] pkgname: org.tizen.stretchtime, id: file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4683.952148.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263128:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
01-20 16:08:17.105+0900 E/WIDGET_VIEWER(  718): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[4683.952148] pkgname[org.tizen.stretchtime], id[file:///opt/usr/share/live_magazine/org.tizen.stretchtime_715_4683.952148.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263128:4] gbar_fname[]
01-20 16:08:17.120+0900 E/WIDGET_VIEWER(  718): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:08:17.120+0900 E/WIDGET_EVAS(  718): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:08:17.120+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
01-20 16:08:17.120+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
01-20 16:08:17.170+0900 F/EFL     (16174): evas_main<16174> main.c:122 evas_debug_magic_wrong() Input object is wrong type
01-20 16:08:17.170+0900 F/EFL     (16174):     Expected: 71737723 - Evas_Object
01-20 16:08:17.170+0900 F/EFL     (16174):     Supplied: eb0045af - <UNKNOWN>
01-20 16:08:17.170+0900 F/EFL     (16174): evas_main<16174> main.c:122 evas_debug_magic_wrong() Input object is wrong type
01-20 16:08:17.170+0900 F/EFL     (16174):     Expected: 71737723 - Evas_Object
01-20 16:08:17.170+0900 F/EFL     (16174):     Supplied: eb0045af - <UNKNOWN>
01-20 16:08:17.175+0900 D/stretch (16174): Time : 4 : 8 : 17
01-20 16:08:17.175+0900 W/WATCH_CORE(16174): appcore-watch.c: __widget_create(976) > widget_create done
01-20 16:08:17.255+0900 I/WATCH_CORE(16174): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
01-20 16:08:17.255+0900 I/WATCH_CORE(16174): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
01-20 16:08:17.255+0900 I/WATCH_CORE(16174): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
01-20 16:08:17.285+0900 E/EFL     (16174): edje<16174> edje_util.c:3770 edje_object_size_min_restricted_calc() group main has a non-fixed part 'clock'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
01-20 16:08:17.295+0900 W/WATCH_CORE(16174): appcore-watch.c: __widget_resume(1012) > widget_resume
01-20 16:08:17.325+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:17.325+0900 D/stretch (16174): Time : 4 : 8 : 17
01-20 16:08:17.995+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:17.995+0900 D/stretch (16174): Time : 4 : 8 : 18
01-20 16:08:18.030+0900 W/AUL_AMD (  519): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-20 16:08:18.030+0900 W/AUL_AMD (  519): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
01-20 16:08:18.040+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:08:18.050+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16174
01-20 16:08:18.050+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 14
01-20 16:08:18.055+0900 W/AUL_AMD (  519): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16174
01-20 16:08:18.055+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:08:18.060+0900 W/AUL_AMD (  519): amd_request.c: __request_handler(640) > __request_handler: 12
01-20 16:08:18.265+0900 I/AUL_PAD (16773): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
01-20 16:08:18.570+0900 W/AUL_AMD (  519): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
01-20 16:08:19.010+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:19.030+0900 D/stretch (16174): Time : 4 : 8 : 19
01-20 16:08:19.090+0900 E/PKGMGR_SERVER(16750): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
01-20 16:08:19.090+0900 E/PKGMGR_SERVER(16750): pkgmgr-server.c: main(2180) > package manager server terminated.
01-20 16:08:20.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:20.000+0900 D/stretch (16174): Time : 4 : 8 : 20
01-20 16:08:20.210+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:08:20.215+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:08:20.215+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:08:20.230+0900 E/TIZEN_N_SYSTEM_SETTINGS(  798): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:08:21.010+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:21.020+0900 D/stretch (16174): Time : 4 : 8 : 21
01-20 16:08:22.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:22.005+0900 D/stretch (16174): Time : 4 : 8 : 22
01-20 16:08:23.005+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:23.005+0900 D/stretch (16174): Time : 4 : 8 : 23
01-20 16:08:23.330+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:08:23.330+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:08:23.340+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:08:23.340+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:08:23.385+0900 W/SHealth ( 2565): ExercisePage.cpp: UpdateTime(237) > [1;40;33mtime is 2016/1/15 17:10:4 2016/1/20 16:8:23 5일 전[0;m
01-20 16:08:23.400+0900 I/SHealth ( 2565): HeartRatePage.cpp: UpdateTime(162) > [1;35mtimeString:[어제][0;m
01-20 16:08:23.400+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-20 16:08:23.400+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-20 16:08:23.400+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-20 16:08:23.405+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2565): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-20 16:08:23.410+0900 I/SHealth ( 2565): HeartRatePage.cpp: SetEDCStateByCurrentHRValueType(182) > [1;35mhide_title_show_main_sub_text[0;m
01-20 16:08:24.010+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:24.015+0900 D/stretch (16174): Time : 4 : 8 : 24
01-20 16:08:25.005+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:25.005+0900 D/stretch (16174): Time : 4 : 8 : 25
01-20 16:08:26.010+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:26.010+0900 D/stretch (16174): Time : 4 : 8 : 26
01-20 16:08:27.010+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:27.010+0900 D/stretch (16174): Time : 4 : 8 : 27
01-20 16:08:28.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:28.000+0900 D/stretch (16174): Time : 4 : 8 : 28
01-20 16:08:29.005+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:29.005+0900 D/stretch (16174): Time : 4 : 8 : 29
01-20 16:08:30.005+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:30.010+0900 D/stretch (16174): Time : 4 : 8 : 30
01-20 16:08:31.005+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:31.005+0900 D/stretch (16174): Time : 4 : 8 : 31
01-20 16:08:32.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:32.000+0900 D/stretch (16174): Time : 4 : 8 : 32
01-20 16:08:33.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:33.005+0900 D/stretch (16174): Time : 4 : 8 : 33
01-20 16:08:34.000+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:34.005+0900 D/stretch (16174): Time : 4 : 8 : 34
01-20 16:08:34.465+0900 E/PKGMGR  (16923): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
01-20 16:08:34.680+0900 E/PKGMGR_SERVER(16925): pkgmgr-server.c: main(2126) > package manager server start
01-20 16:08:34.765+0900 E/PKGMGR_SERVER(16925): pkgmgr-server.c: req_cb(686) > req_id=[org.tizen.stretchtime_-1484551227], req_type=[1], pkg_type=[rpm], pkgid=[org.tizen.stretchtime], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.tizen.stretchtime_-1484551227' '-r' 'org.tizen.stretchtime'], cookie=[UUrJsDgPCen1lN/yitSaTKM33Vg=], backend_flag=[0]
01-20 16:08:34.765+0900 E/PKGMGR  (16925): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.tizen.stretchtime]
01-20 16:08:34.765+0900 E/PKGMGR_SERVER(16925): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.tizen.stretchtime 
01-20 16:08:34.770+0900 E/PKGMGR  (16923): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[169230002]
01-20 16:08:34.775+0900 E/PKGMGR_SERVER(16926): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.tizen.stretchtime]
01-20 16:08:34.930+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
01-20 16:08:34.945+0900 W/AUL_AMD (  519): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
01-20 16:08:34.945+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.tizen.stretchtime is being updateded:0
01-20 16:08:34.995+0900 I/CAPI_WATCH_APPLICATION(16174): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-20 16:08:35.125+0900 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
01-20 16:08:35.230+0900 W/CRASH_MANAGER(16928): worker.c: worker_job(1199) > 1116174737472145327371
