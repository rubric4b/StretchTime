S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOL3
Build-Date: 2015.12.15 19:22:13

Crash Information
Process Name: stretchtime
PID: 20262
Date: 2016-01-22 16:07:22+0900
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
r6   = 0x00000009, r7   = 0xbedb5c4c
r8   = 0x4079225c, r9   = 0x40bfd824
r10  = 0x43087ae0, fp   = 0x00000000
ip   = 0x40790920, sp   = 0xbedb5bc8
lr   = 0x406f0420, pc   = 0x406f026c
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     14548 KB
Buffers:     24704 KB
Cached:     129132 KB
VmPeak:      75936 KB
VmSize:      75424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15280 KB
VmRSS:       15280 KB
VmData:      22148 KB
VmStk:         136 KB
VmExe:         884 KB
VmLib:       47748 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20262 TID = 20262
20262 20266 20271 

Maps Information
40000000 400dd000 r-xp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
400e4000 400e6000 rwxp /opt/usr/apps/org.tizen.stretchtime/bin/stretchtime
4012b000 40148000 r-xp /lib/ld-2.13.so
4014f000 40150000 r-xp /lib/ld-2.13.so
40150000 40151000 rwxp /lib/ld-2.13.so
40151000 40155000 r-xp /usr/lib/libsys-assert.so
4015d000 4015e000 rwxp /usr/lib/libsys-assert.so
4015e000 40162000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
40169000 4016a000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4016b000 4016d000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4016d000 40170000 r-xs /opt/usr/apps/org.tizen.stretchtime/res/edje/main.edj
40172000 40186000 r-xp /lib/libpthread-2.13.so
4018d000 4018e000 r-xp /lib/libpthread-2.13.so
4018e000 4018f000 rwxp /lib/libpthread-2.13.so
40191000 40198000 r-xp /usr/lib/libappcore-watch.so.1.1
401a0000 401a1000 rwxp /usr/lib/libappcore-watch.so.1.1
401a1000 401a3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
401ab000 401ac000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
401ac000 401b1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
401b8000 401b9000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
401b9000 401be000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
401c5000 401c6000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
401c6000 401ca000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
401d2000 401d3000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
401d3000 401db000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
401db000 401dc000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
401dc000 401de000 r-xp /usr/lib/libdlog.so.0.0.0
401e5000 401e6000 rwxp /usr/lib/libdlog.so.0.0.0
401e6000 401fd000 r-xp /usr/lib/libecore.so.1.7.99
40205000 40206000 rwxp /usr/lib/libecore.so.1.7.99
40214000 40234000 r-xp /usr/lib/libefl-extension.so.0.1.0
40234000 40235000 rwxp /usr/lib/libefl-extension.so.0.1.0
40235000 4036f000 r-xp /usr/lib/libelementary.so.1.7.99
40376000 4037e000 rwxp /usr/lib/libelementary.so.1.7.99
40385000 40454000 r-xp /usr/lib/libevas.so.1.7.99
4045b000 40465000 rwxp /usr/lib/libevas.so.1.7.99
40478000 40544000 r-xp /usr/lib/libxml2.so.2.7.8
4054b000 40550000 rwxp /usr/lib/libxml2.so.2.7.8
40551000 405e5000 r-xp /usr/lib/libstdc++.so.6.0.16
405ed000 405f0000 r-xp /usr/lib/libstdc++.so.6.0.16
405f0000 405f2000 rwxp /usr/lib/libstdc++.so.6.0.16
405f8000 40661000 r-xp /lib/libm-2.13.so
40668000 40669000 r-xp /lib/libm-2.13.so
40669000 4066a000 rwxp /lib/libm-2.13.so
4066a000 40785000 r-xp /lib/libc-2.13.so
4078d000 4078f000 r-xp /lib/libc-2.13.so
4078f000 40790000 rwxp /lib/libc-2.13.so
40793000 4079b000 r-xp /lib/libgcc_s-4.6.so.1
4079b000 4079c000 rwxp /lib/libgcc_s-4.6.so.1
4079c000 407a7000 r-xp /lib/libunwind.so.8.0.1
407ae000 407af000 rwxp /lib/libunwind.so.8.0.1
407d4000 407d6000 r-xp /lib/libdl-2.13.so
407dd000 407de000 r-xp /lib/libdl-2.13.so
407de000 407df000 rwxp /lib/libdl-2.13.so
407df000 407eb000 r-xp /usr/lib/libaul.so.0.1.0
407f3000 407f4000 rwxp /usr/lib/libaul.so.0.1.0
407f5000 4080c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40813000 40814000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40814000 40821000 r-xp /usr/lib/libalarm.so.0.0.0
40828000 4082a000 rwxp /usr/lib/libalarm.so.0.0.0
4082a000 4085e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40865000 40867000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40867000 40889000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40890000 40891000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
40891000 408d2000 r-xp /usr/lib/libeina.so.1.7.99
408d9000 408db000 rwxp /usr/lib/libeina.so.1.7.99
408db000 40a18000 r-xp /usr/lib/libicui18n.so.51.1
40a20000 40a28000 rwxp /usr/lib/libicui18n.so.51.1
40a28000 40b0c000 r-xp /usr/lib/libicuuc.so.51.1
40b13000 40b1d000 rwxp /usr/lib/libicuuc.so.51.1
40b21000 40b25000 r-xp /usr/lib/libvconf.so.0.2.45
40b2c000 40b2d000 rwxp /usr/lib/libvconf.so.0.2.45
40b2d000 40bfd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40bfd000 40bfe000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40bfe000 40c28000 r-xp /usr/lib/libdbus-1.so.3.8.12
40c30000 40c31000 rwxp /usr/lib/libdbus-1.so.3.8.12
40c31000 40c37000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
40c3e000 40c3f000 rwxp /usr/lib/libwidget_provider_app.so.1.0.0
40c3f000 40c45000 r-xp /usr/lib/libwidget.so.1.0.0
40c4d000 40c4e000 rwxp /usr/lib/libwidget.so.1.0.0
40c4e000 40c54000 r-xp /usr/lib/libappsvc.so.0.1.0
40c5b000 40c5c000 rwxp /usr/lib/libappsvc.so.0.1.0
40c5c000 40c5f000 r-xp /usr/lib/libbundle.so.0.1.22
40c66000 40c67000 rwxp /usr/lib/libbundle.so.0.1.22
40c67000 40c6a000 r-xp /usr/lib/libsmack.so.1.0.0
40c71000 40c72000 rwxp /usr/lib/libsmack.so.1.0.0
40c72000 40c77000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40c7e000 40c7f000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
40c7f000 40d52000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40d59000 40d5d000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40d5d000 40d7b000 r-xp /usr/lib/libsensor.so.1.1.0
40d83000 40d84000 rwxp /usr/lib/libsensor.so.1.1.0
40d85000 40dd5000 r-xp /usr/lib/libecore_x.so.1.7.99
40dd5000 40dd7000 rwxp /usr/lib/libecore_x.so.1.7.99
40dd7000 40df9000 r-xp /usr/lib/libecore_evas.so.1.7.99
40e00000 40e02000 rwxp /usr/lib/libecore_evas.so.1.7.99
40e02000 40e2a000 r-xp /usr/lib/libfontconfig.so.1.8.0
40e2a000 40e2b000 rwxp /usr/lib/libfontconfig.so.1.8.0
40e2b000 40e3d000 r-xp /usr/lib/libefl-assist.so.0.1.0
40e44000 40e45000 rwxp /usr/lib/libefl-assist.so.0.1.0
40e45000 40e4b000 r-xp /lib/librt-2.13.so
40e52000 40e53000 r-xp /lib/librt-2.13.so
40e53000 40e54000 rwxp /lib/librt-2.13.so
40e54000 40eb1000 r-xp /usr/lib/libedje.so.1.7.99
40eb9000 40ebb000 rwxp /usr/lib/libedje.so.1.7.99
40ebb000 40f73000 r-xp /usr/lib/libcairo.so.2.11200.14
40f7a000 40f7d000 rwxp /usr/lib/libcairo.so.2.11200.14
40f7e000 4105f000 r-xp /usr/lib/libX11.so.6.3.0
41066000 4106a000 rwxp /usr/lib/libX11.so.6.3.0
4106a000 41073000 r-xp /usr/lib/libXi.so.6.1.0
4107a000 4107b000 rwxp /usr/lib/libXi.so.6.1.0
4107b000 41094000 r-xp /usr/lib/libeet.so.1.7.99
4109c000 4109d000 rwxp /usr/lib/libeet.so.1.7.99
410a5000 410aa000 r-xp /usr/lib/libecore_file.so.1.7.99
410b1000 410b2000 rwxp /usr/lib/libecore_file.so.1.7.99
410b2000 410c3000 r-xp /usr/lib/libecore_input.so.1.7.99
410ca000 410cb000 rwxp /usr/lib/libecore_input.so.1.7.99
410cb000 410d4000 r-xp /usr/lib/libedbus.so.1.7.99
410db000 410dc000 rwxp /usr/lib/libedbus.so.1.7.99
410dc000 410f6000 r-xp /usr/lib/libecore_con.so.1.7.99
410fd000 410fe000 rwxp /usr/lib/libecore_con.so.1.7.99
410ff000 41112000 r-xp /usr/lib/libfribidi.so.0.3.1
41119000 4111a000 rwxp /usr/lib/libfribidi.so.0.3.1
4111a000 41157000 r-xp /usr/lib/libharfbuzz.so.0.940.0
4115e000 4115f000 rwxp /usr/lib/libharfbuzz.so.0.940.0
41160000 411b6000 r-xp /usr/lib/libfreetype.so.6.11.3
411be000 411c2000 rwxp /usr/lib/libfreetype.so.6.11.3
411c2000 41218000 r-xp /usr/lib/libpixman-1.so.0.28.2
41220000 41225000 rwxp /usr/lib/libpixman-1.so.0.28.2
41225000 4123b000 r-xp /lib/libz.so.1.2.5
41242000 41243000 rwxp /lib/libz.so.1.2.5
41243000 41248000 r-xp /usr/lib/libxdgmime.so.1.1.0
4124f000 41250000 rwxp /usr/lib/libxdgmime.so.1.1.0
41250000 4128c000 r-xp /usr/lib/libsystemd.so.0.4.0
41293000 41294000 r-xp /usr/lib/libsystemd.so.0.4.0
41294000 41295000 rwxp /usr/lib/libsystemd.so.0.4.0
41295000 41298000 r-xp /usr/lib/libproc-stat.so.0.2.86
4129f000 412a0000 rwxp /usr/lib/libproc-stat.so.0.2.86
412a0000 412c6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
412ce000 412cf000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
412cf000 412d0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
412d7000 412d8000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
412d8000 412dd000 r-xp /usr/lib/libffi.so.5.0.10
412e4000 412e5000 rwxp /usr/lib/libffi.so.5.0.10
412e5000 412fb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
41302000 41303000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
41303000 41378000 r-xp /usr/lib/libsqlite3.so.0.8.6
4137f000 41382000 rwxp /usr/lib/libsqlite3.so.0.8.6
41382000 42901000 r-xp /usr/lib/libicudata.so.51.1
42908000 42909000 rwxp /usr/lib/libicudata.so.51.1
42909000 42912000 r-xp /usr/lib/libcom-core.so.0.0.1
4291a000 4291b000 rwxp /usr/lib/libcom-core.so.0.0.1
4291b000 42927000 r-xp /usr/lib/libwidget_service.so.1.0.0
4292e000 4292f000 rwxp /usr/lib/libwidget_service.so.1.0.0
4292f000 42935000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
4293d000 4293e000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
4293e000 42947000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4294f000 42950000 rwxp /usr/lib/libwidget_provider.so.1.0.0
42950000 42952000 r-xp /usr/lib/libiniparser.so.0
4295a000 4295b000 rwxp /usr/lib/libiniparser.so.0
4295b000 4295d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
42964000 42965000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
42966000 42976000 r-xp /lib/libresolv-2.13.so
42976000 42977000 r-xp /lib/libresolv-2.13.so
42977000 42978000 rwxp /lib/libresolv-2.13.so
4297a000 42981000 r-xp /usr/lib/libsensord-share.so
42988000 42989000 rwxp /usr/lib/libsensord-share.so
42989000 42990000 r-xp /usr/lib/libXcursor.so.1.0.2
42997000 42998000 rwxp /usr/lib/libXcursor.so.1.0.2
42998000 4299a000 r-xp /usr/lib/libXdamage.so.1.1.0
429a1000 429a2000 rwxp /usr/lib/libXdamage.so.1.1.0
429a2000 429a4000 r-xp /usr/lib/libXcomposite.so.1.0.0
429ab000 429ac000 rwxp /usr/lib/libXcomposite.so.1.0.0
429ad000 429af000 r-xp /usr/lib/libXgesture.so.7.0.0
429b6000 429b7000 rwxp /usr/lib/libXgesture.so.7.0.0
429b7000 429ba000 r-xp /usr/lib/libXfixes.so.3.1.0
429c1000 429c2000 rwxp /usr/lib/libXfixes.so.3.1.0
429c2000 429c3000 r-xp /usr/lib/libXinerama.so.1.0.0
429cb000 429cc000 rwxp /usr/lib/libXinerama.so.1.0.0
429cc000 429d2000 r-xp /usr/lib/libXrandr.so.2.2.0
429d9000 429da000 rwxp /usr/lib/libXrandr.so.2.2.0
429da000 429e0000 r-xp /usr/lib/libXrender.so.1.3.0
429e7000 429e8000 rwxp /usr/lib/libXrender.so.1.3.0
429e8000 429eb000 r-xp /usr/lib/libXtst.so.6.1.0
429f3000 429f4000 rwxp /usr/lib/libXtst.so.6.1.0
429f5000 429ff000 r-xp /usr/lib/libXext.so.6.4.0
42a07000 42a08000 rwxp /usr/lib/libXext.so.6.4.0
42a08000 42a0d000 r-xp /usr/lib/libecore_fb.so.1.7.99
42a14000 42a16000 rwxp /usr/lib/libecore_fb.so.1.7.99
42a16000 42a1a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
42a22000 42a23000 rwxp /usr/lib/libecore_ipc.so.1.7.99
42a23000 42a26000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
42a2d000 42a2e000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
42a2e000 42a44000 r-xp /lib/libexpat.so.1.5.2
42a4c000 42a4e000 rwxp /lib/libexpat.so.1.5.2
42a4f000 42a61000 r-xp /usr/lib/libtts.so
42a68000 42a69000 rwxp /usr/lib/libtts.so
42a69000 42a8a000 r-xp /usr/lib/libui-extension.so.0.1.0
42a92000 42a93000 rwxp /usr/lib/libui-extension.so.0.1.0
42a93000 42a9a000 r-xp /usr/lib/libtbm.so.1.0.0
42aa1000 42aa2000 rwxp /usr/lib/libtbm.so.1.0.0
42aa2000 42aa9000 r-xp /usr/lib/libembryo.so.1.7.99
42ab0000 42ab1000 rwxp /usr/lib/libembryo.so.1.7.99
42ab1000 42ac8000 r-xp /usr/lib/liblua-5.1.so
42ad0000 42ad1000 rwxp /usr/lib/liblua-5.1.so
42ad2000 42ad8000 r-xp /usr/lib/libecore_imf.so.1.7.99
42adf000 42ae0000 rwxp /usr/lib/libecore_imf.so.1.7.99
42ae0000 42ae1000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
42ae8000 42ae9000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
42ae9000 42af7000 r-xp /usr/lib/libGLESv2.so.2.0
42aff000 42b00000 rwxp /usr/lib/libGLESv2.so.2.0
42b00000 42b18000 r-xp /usr/lib/libpng12.so.0.50.0
42b1f000 42b20000 rwxp /usr/lib/libpng12.so.0.50.0
42b20000 42b21000 r-xp /usr/lib/libxcb-shm.so.0.0.0
42b29000 42b2a000 rwxp /usr/lib/libxcb-shm.so.0.0.0
42b2b000 42b31000 r-xp /usr/lib/libxcb-render.so.0.0.0
42b38000 42b39000 rwxp /usr/lib/libxcb-render.so.0.0.0
42b39000 42b4c000 r-xp /usr/lib/libxcb.so.1.1.0
42b54000 42b55000 rwxp /usr/lib/libxcb.so.1.1.0
42b55000 42b58000 r-xp /usr/lib/libEGL.so.1.4
42b5f000 42b60000 rwxp /usr/lib/libEGL.so.1.4
42b60000 42b83000 r-xp /usr/lib/libjpeg.so.8.0.2
42b8a000 42b8b000 rwxp /usr/lib/libjpeg.so.8.0.2
42b9b000 42bdf000 r-xp /usr/lib/libcurl.so.4.3.0
42be6000 42be8000 rwxp /usr/lib/libcurl.so.4.3.0
42be9000 42c01000 r-xp /usr/lib/liblzma.so.5.0.3
42c08000 42c09000 rwxp /usr/lib/liblzma.so.5.0.3
42c09000 42c85000 r-xp /usr/lib/libgcrypt.so.20.0.3
42c8c000 42c91000 rwxp /usr/lib/libgcrypt.so.20.0.3
42c91000 42cad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42cb5000 42cb6000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
42cb6000 42cb8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
42cc0000 42cc1000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
42cc1000 42cc3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
42cca000 42ccb000 rwxp /usr/lib/journal/libjournal.so.0.1.0
42ccc000 42cd4000 r-xp /usr/lib/libdrm.so.2.4.0
42cdb000 42cdc000 rwxp /usr/lib/libdrm.so.2.4.0
42cdc000 42cde000 r-xp /usr/lib/libdri2.so.0.0.0
42ce5000 42ce6000 rwxp /usr/lib/libdri2.so.0.0.0
42ce6000 42ce9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
42cf0000 42cf1000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
42cf2000 42cf4000 r-xp /usr/lib/libXau.so.6.0.0
42cfb000 42cfc000 rwxp /usr/lib/libXau.so.6.0.0
42cfc000 42d05000 r-xp /usr/lib/libcares.so.2.1.0
42d0d000 42d0e000 rwxp /usr/lib/libcares.so.2.1.0
42d0e000 42d3c000 r-xp /usr/lib/libidn.so.11.5.44
42d43000 42d44000 rwxp /usr/lib/libidn.so.11.5.44
42d44000 42d91000 r-xp /usr/lib/libssl.so.1.0.0
42d98000 42d9d000 rwxp /usr/lib/libssl.so.1.0.0
42d9d000 42f45000 r-xp /usr/lib/libcrypto.so.1.0.0
42f45000 42f5a000 rwxp /usr/lib/libcrypto.so.1.0.0
42f5f000 42f6a000 r-xp /usr/lib/libgpg-error.so.0.15.0
42f71000 42f72000 rwxp /usr/lib/libgpg-error.so.0.15.0
42f72000 42f74000 r-xp /usr/lib/libiri.so
42f7b000 42f7c000 rwxp /usr/lib/libiri.so
42f7c000 42f7f000 r-xp /lib/libcap.so.2.21
42f86000 42f87000 rwxp /lib/libcap.so.2.21
42f87000 42f8e000 r-xp /lib/libcrypt-2.13.so
42f95000 42f96000 r-xp /lib/libcrypt-2.13.so
42f96000 42f97000 rwxp /lib/libcrypt-2.13.so
42fbe000 42fc3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fcb000 42fcc000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42fcd000 42fd2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42fd9000 42fda000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42fda000 42fdd000 r-xp /lib/libattr.so.1.1.0
42fe4000 42fe5000 rwxp /lib/libattr.so.1.1.0
42fe5000 43006000 r-xp /usr/lib/libexif.so.12.3.3
4300d000 43019000 rwxp /usr/lib/libexif.so.12.3.3
43019000 4301e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43025000 43026000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
4312c000 431f6000 r-xp /usr/lib/libCOREGL.so.4.0
431fe000 43200000 rwxp /usr/lib/libCOREGL.so.4.0
43208000 43408000 r-xp /usr/share/locale/locale-archive
43408000 4353a000 r-xp /usr/share/locale/locale-archive
4353b000 43d3a000 rwxp [stack:20266]
43d3a000 43d3d000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d44000 43d45000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d45000 43d50000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43d58000 43d59000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43d59000 43dd8000 rwxs /dev/dri/card0
43dd8000 43ddb000 r-xs /opt/home/app/.cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43ddb000 43ddf000 r-xs /opt/home/app/.cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43ddf000 43dee000 r-xs /opt/home/app/.cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43dee000 43e7a000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
43e7b000 449f7000 rwxp [stack:20271]
bed96000 bedb7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20262)
Call Stack Count: 2
 0: (0x406f026c) [/lib/libc.so.6] + 0x8626c
 1: (0xbedb5c4c) (null)
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
4.479+0900 I/watchface-viewer(20278): viewer-model.cpp: ParsePartImage(4412) > deprecated default tag
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
01-22 16:07:34.719+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 11202287374721453446441
01-22 16:07:34.809+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:34.809+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:35.009+0900 I/RESOURCED(  528): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
01-22 16:07:35.009+0900 I/RESOURCED(  528): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
01-22 16:07:35.009+0900 I/RESOURCED(  528): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
01-22 16:07:35.009+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:35.009+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:35.209+0900 I/CAPI_WATCH_APPLICATION(20278): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-22 16:07:35.209+0900 E/watchface-loader(20278): watchface-loader.cpp: OnAppTimeTick(744) > 
01-22 16:07:35.289+0900 W/CRASH_MANAGER(20014): worker.c: worker_job(1199) > 1120262737472145344644
