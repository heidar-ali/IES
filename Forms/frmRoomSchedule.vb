Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports C1.Win.C1FlexGrid

Public Class frmRoomSchedule
    Inherits Form
    Friend WithEvents imgList32X32 As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    Friend WithEvents imgList16X16 As System.Windows.Forms.ImageList


    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomSchedule))
        Me.imgList16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.imgList32X32 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'imgList16X16
        '
        Me.imgList16X16.ImageStream = CType(resources.GetObject("imgList16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList16X16.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList16X16.Images.SetKeyName(0, "frmBorrowedBooks_i16x1611.ico")
        Me.imgList16X16.Images.SetKeyName(1, "frmBorrowedBooks_i16x161.ico")
        Me.imgList16X16.Images.SetKeyName(2, "frmBorrowedBooks_i16x162.ico")
        Me.imgList16X16.Images.SetKeyName(3, "frmBorrowedBooks_i16x163.ico")
        Me.imgList16X16.Images.SetKeyName(4, "frmBorrowedBooks_i16x164.ico")
        Me.imgList16X16.Images.SetKeyName(5, "frmBorrowedBooks_i16x165.ico")
        Me.imgList16X16.Images.SetKeyName(6, "frmBorrowedBooks_i16x168.ico")
        Me.imgList16X16.Images.SetKeyName(7, "frmBorrowedBooks_i16x169.ico")
        Me.imgList16X16.Images.SetKeyName(8, "frmBorrowedBooks_i16x1610.ico")
        Me.imgList16X16.Images.SetKeyName(9, "268.ICO")
        Me.imgList16X16.Images.SetKeyName(10, "322.ICO")
        Me.imgList16X16.Images.SetKeyName(11, "101.ico")
        Me.imgList16X16.Images.SetKeyName(12, "102.ico")
        Me.imgList16X16.Images.SetKeyName(13, "room_16.png")
        Me.imgList16X16.Images.SetKeyName(14, "assignclassrooms_16.png")
        Me.imgList16X16.Images.SetKeyName(15, "gener_16.png")
        Me.imgList16X16.Images.SetKeyName(16, "001.ICO")
        '
        'imgList32X32
        '
        Me.imgList32X32.ImageStream = CType(resources.GetObject("imgList32X32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList32X32.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList32X32.Images.SetKeyName(0, "MAIN_itb32x3210.ico")
        Me.imgList32X32.Images.SetKeyName(1, "frmAccounts_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(2, "frmAddEnrolment_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(3, "frmDateChecker_Image1.ico")
        Me.imgList32X32.Images.SetKeyName(4, "frmFind_imgICO.ico")
        Me.imgList32X32.Images.SetKeyName(5, "frmShortcuts_ImageList14.ico")
        Me.imgList32X32.Images.SetKeyName(6, "frmShortcuts_ImageList117.ico")
        Me.imgList32X32.Images.SetKeyName(7, "frmShortcuts_ImageList120.ico")
        Me.imgList32X32.Images.SetKeyName(8, "frmShortcuts_ImageList121.ico")
        Me.imgList32X32.Images.SetKeyName(9, "frmStudentRecord_Icon.ico")
        Me.imgList32X32.Images.SetKeyName(10, "MAIN_itb32x320.ico")
        Me.imgList32X32.Images.SetKeyName(11, "MAIN_itb32x321.ico")
        Me.imgList32X32.Images.SetKeyName(12, "MAIN_itb32x323.ico")
        Me.imgList32X32.Images.SetKeyName(13, "MAIN_itb32x324.ico")
        Me.imgList32X32.Images.SetKeyName(14, "MAIN_itb32x326.ico")
        Me.imgList32X32.Images.SetKeyName(15, "MAIN_itb32x327.ico")
        Me.imgList32X32.Images.SetKeyName(16, "MAIN_itb32x328.ico")
        Me.imgList32X32.Images.SetKeyName(17, "frmmain_imglst_Toolbar20.jpg")
        Me.imgList32X32.Images.SetKeyName(18, "frmmain_imglst_Toolbar0.ico")
        Me.imgList32X32.Images.SetKeyName(19, "frmmain_imglst_Toolbar2.ico")
        Me.imgList32X32.Images.SetKeyName(20, "frmmain_imglst_Toolbar4.ico")
        Me.imgList32X32.Images.SetKeyName(21, "frmmain_imglst_Toolbar5.ico")
        Me.imgList32X32.Images.SetKeyName(22, "frmmain_imglst_Toolbar6.ico")
        Me.imgList32X32.Images.SetKeyName(23, "frmmain_imglst_Toolbar7.ico")
        Me.imgList32X32.Images.SetKeyName(24, "frmmain_imglst_Toolbar8.ico")
        Me.imgList32X32.Images.SetKeyName(25, "frmmain_imglst_Toolbar9.ico")
        Me.imgList32X32.Images.SetKeyName(26, "frmmain_imglst_Toolbar10.ico")
        Me.imgList32X32.Images.SetKeyName(27, "frmmain_imglst_Toolbar11.ico")
        Me.imgList32X32.Images.SetKeyName(28, "frmmain_imglst_Toolbar12.ico")
        Me.imgList32X32.Images.SetKeyName(29, "frmmain_imglst_Toolbar13.ico")
        Me.imgList32X32.Images.SetKeyName(30, "frmmain_imglst_Toolbar14.ico")
        Me.imgList32X32.Images.SetKeyName(31, "frmmain_imglst_Toolbar15.ico")
        Me.imgList32X32.Images.SetKeyName(32, "frmmain_imglst_Toolbar16.ico")
        Me.imgList32X32.Images.SetKeyName(33, "gener_whole.png")
        Me.imgList32X32.Images.SetKeyName(34, "assignclassrooms_32.png")
        Me.imgList32X32.Images.SetKeyName(35, "change_32.png")
        Me.imgList32X32.Images.SetKeyName(36, "class_32.png")
        Me.imgList32X32.Images.SetKeyName(37, "compare_32.png")
        Me.imgList32X32.Images.SetKeyName(38, "constraints_32.png")
        Me.imgList32X32.Images.SetKeyName(39, "email_32.png")
        Me.imgList32X32.Images.SetKeyName(40, "export_32.png")
        Me.imgList32X32.Images.SetKeyName(41, "gener_32.png")
        Me.imgList32X32.Images.SetKeyName(42, "help_32.png")
        Me.imgList32X32.Images.SetKeyName(43, "import_32.png")
        Me.imgList32X32.Images.SetKeyName(44, "improve_32.png")
        Me.imgList32X32.Images.SetKeyName(45, "like_32.png")
        Me.imgList32X32.Images.SetKeyName(46, "lock_32.png")
        Me.imgList32X32.Images.SetKeyName(47, "look_32.png")
        Me.imgList32X32.Images.SetKeyName(48, "open_32.png")
        Me.imgList32X32.Images.SetKeyName(49, "preview_back_32.png")
        Me.imgList32X32.Images.SetKeyName(50, "preview_color_32.png")
        Me.imgList32X32.Images.SetKeyName(51, "preview_design_32.png")
        Me.imgList32X32.Images.SetKeyName(52, "preview_extracolumns_32.png")
        Me.imgList32X32.Images.SetKeyName(53, "preview_filter_32.png")
        Me.imgList32X32.Images.SetKeyName(54, "preview_forward_32.png")
        Me.imgList32X32.Images.SetKeyName(55, "preview_global_32.png")
        Me.imgList32X32.Images.SetKeyName(56, "preview_modify_32.png")
        Me.imgList32X32.Images.SetKeyName(57, "preview_sizes2_32.png")
        Me.imgList32X32.Images.SetKeyName(58, "preview_sizes_32.png")
        Me.imgList32X32.Images.SetKeyName(59, "preview_style_32.png")
        Me.imgList32X32.Images.SetKeyName(60, "print_area_32.png")
        Me.imgList32X32.Images.SetKeyName(61, "print_preview_32.png")
        Me.imgList32X32.Images.SetKeyName(62, "printer_32.png")
        Me.imgList32X32.Images.SetKeyName(63, "publish_32.png")
        Me.imgList32X32.Images.SetKeyName(64, "related_32.png")
        Me.imgList32X32.Images.SetKeyName(65, "remove_32.png")
        Me.imgList32X32.Images.SetKeyName(66, "room_32.png")
        Me.imgList32X32.Images.SetKeyName(67, "save_32.png")
        Me.imgList32X32.Images.SetKeyName(68, "saveas_32.png")
        Me.imgList32X32.Images.SetKeyName(69, "seminar_32.png")
        Me.imgList32X32.Images.SetKeyName(70, "settings_adv_32.png")
        Me.imgList32X32.Images.SetKeyName(71, "settings_basic_32.png")
        Me.imgList32X32.Images.SetKeyName(72, "show_tabs_32.png")
        Me.imgList32X32.Images.SetKeyName(73, "statistics_32.png")
        Me.imgList32X32.Images.SetKeyName(74, "subject_32.png")
        Me.imgList32X32.Images.SetKeyName(75, "teacher_32.png")
        Me.imgList32X32.Images.SetKeyName(76, "techsup_32.png")
        Me.imgList32X32.Images.SetKeyName(77, "test_32.png")
        Me.imgList32X32.Images.SetKeyName(78, "translate_32.png")
        Me.imgList32X32.Images.SetKeyName(79, "ttonline_32.png")
        Me.imgList32X32.Images.SetKeyName(80, "tutor_32.png")
        Me.imgList32X32.Images.SetKeyName(81, "unlock_32.png")
        Me.imgList32X32.Images.SetKeyName(82, "verification_32.png")
        Me.imgList32X32.Images.SetKeyName(83, "view_define_32.png")
        Me.imgList32X32.Images.SetKeyName(84, "weeks_32.png")
        Me.imgList32X32.Images.SetKeyName(85, "wizard_32.png")
        Me.imgList32X32.Images.SetKeyName(86, "zoom_32.png")
        Me.imgList32X32.Images.SetKeyName(87, "zoom_ok_32.png")
        Me.imgList32X32.Images.SetKeyName(88, "overtime_32.png")
        Me.imgList32X32.Images.SetKeyName(89, "edit_32.png")
        Me.imgList32X32.Images.SetKeyName(90, "help_32.png")
        Me.imgList32X32.Images.SetKeyName(91, "no_32.png")
        Me.imgList32X32.Images.SetKeyName(92, "ok_32.png")
        Me.imgList32X32.Images.SetKeyName(93, "view_timetable_32.png")
        '
        'frmRoomSchedule
        '
        Me.ClientSize = New System.Drawing.Size(1082, 650)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRoomSchedule"
        Me.Text = "Room and Faculty Utilization"
        Me.ResumeLayout(False)

    End Sub




End Class
