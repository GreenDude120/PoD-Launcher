﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.playBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.dfxChk = New System.Windows.Forms.RadioButton()
        Me.wChk = New System.Windows.Forms.CheckBox()
        Me.advancedChk = New System.Windows.Forms.CheckBox()
        Me.directcbox = New System.Windows.Forms.CheckBox()
        Me.sndbkgChk = New System.Windows.Forms.CheckBox()
        Me.widescreenChk = New System.Windows.Forms.CheckBox()
        Me.cpufixChk = New System.Windows.Forms.CheckBox()
        Me.ddrawChk = New System.Windows.Forms.RadioButton()
        Me.d3dChk = New System.Windows.Forms.RadioButton()
        Me.playCloseChk = New System.Windows.Forms.CheckBox()
        Me.autoLootChk = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.downloadcfg = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.filterlibBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lootfilterurl = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LogBox = New System.Windows.Forms.ListBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dlInfo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playBtn
        '
        Me.playBtn.Enabled = False
        Me.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.playBtn.Location = New System.Drawing.Point(804, 12)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(130, 53)
        Me.playBtn.TabIndex = 1
        Me.playBtn.Text = "Checking for Updates"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(627, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 136)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Launch Flags"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.skipChk, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.aspectChk, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nsChk, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dfxChk, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.wChk, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.sndbkgChk, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cpufixChk, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ddrawChk, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.d3dChk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.widescreenChk, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.directcbox, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.advancedChk, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 111)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'skipChk
        '
        Me.skipChk.AutoSize = True
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.skipChk.Location = New System.Drawing.Point(116, 3)
        Me.skipChk.Name = "skipChk"
        Me.skipChk.Size = New System.Drawing.Size(78, 17)
        Me.skipChk.TabIndex = 4
        Me.skipChk.Text = "-skiptobnet"
        Me.ToolTip1.SetToolTip(Me.skipChk, "Game opens straight into online multiplayer & skips cutscenes")
        Me.skipChk.UseVisualStyleBackColor = True
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNoFixAspect
        Me.aspectChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNoFixAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.aspectChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.aspectChk.Location = New System.Drawing.Point(3, 57)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(83, 17)
        Me.aspectChk.TabIndex = 8
        Me.aspectChk.Text = "-nofixaspect"
        Me.ToolTip1.SetToolTip(Me.aspectChk, "Window will stretch to whatever aspect ratio you use," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "instead of keeing the 4:3 " &
        "aspect ratio.")
        Me.aspectChk.UseVisualStyleBackColor = True
        '
        'nsChk
        '
        Me.nsChk.AutoSize = True
        Me.nsChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNs
        Me.nsChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nsChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.nsChk.Location = New System.Drawing.Point(3, 84)
        Me.nsChk.Name = "nsChk"
        Me.nsChk.Size = New System.Drawing.Size(40, 17)
        Me.nsChk.TabIndex = 9
        Me.nsChk.Text = "-ns"
        Me.ToolTip1.SetToolTip(Me.nsChk, "Disables the in-game sound.")
        Me.nsChk.UseVisualStyleBackColor = True
        '
        'dfxChk
        '
        Me.dfxChk.AutoSize = True
        Me.dfxChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkbox3dfx
        Me.dfxChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.dfxChk.Location = New System.Drawing.Point(3, 30)
        Me.dfxChk.Name = "dfxChk"
        Me.dfxChk.Size = New System.Drawing.Size(49, 17)
        Me.dfxChk.TabIndex = 1
        Me.dfxChk.Text = "-3dfx"
        Me.ToolTip1.SetToolTip(Me.dfxChk, "VideoMode: Glide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must open glide-init.exe in PoD folder to configure glide settings")
        Me.dfxChk.UseVisualStyleBackColor = True
        '
        'wChk
        '
        Me.wChk.AutoSize = True
        Me.wChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.wChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.wChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.wChk.Location = New System.Drawing.Point(3, 3)
        Me.wChk.Name = "wChk"
        Me.wChk.Size = New System.Drawing.Size(37, 17)
        Me.wChk.TabIndex = 3
        Me.wChk.Text = "-w"
        Me.ToolTip1.SetToolTip(Me.wChk, "Run the game in windowed mode.")
        Me.wChk.UseVisualStyleBackColor = True
        Me.wChk.Visible = False
        '
        'advancedChk
        '
        Me.advancedChk.AutoSize = True
        Me.advancedChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxAdvanced
        Me.advancedChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAdvanced", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.advancedChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.advancedChk.Location = New System.Drawing.Point(229, 3)
        Me.advancedChk.Name = "advancedChk"
        Me.advancedChk.Size = New System.Drawing.Size(75, 17)
        Me.advancedChk.TabIndex = 10
        Me.advancedChk.Text = "Advanced"
        Me.ToolTip1.SetToolTip(Me.advancedChk, "Show advanced options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use at your own risk!")
        Me.advancedChk.UseVisualStyleBackColor = True
        '
        'directcbox
        '
        Me.directcbox.AutoSize = True
        Me.directcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDirect
        Me.directcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDirect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.directcbox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.directcbox.Location = New System.Drawing.Point(229, 30)
        Me.directcbox.Name = "directcbox"
        Me.directcbox.Size = New System.Drawing.Size(55, 17)
        Me.directcbox.TabIndex = 11
        Me.directcbox.Text = "-direct"
        Me.directcbox.UseVisualStyleBackColor = True
        Me.directcbox.Visible = False
        '
        'sndbkgChk
        '
        Me.sndbkgChk.AutoSize = True
        Me.sndbkgChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSndBkg
        Me.sndbkgChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSndBkg", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.sndbkgChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.sndbkgChk.Location = New System.Drawing.Point(116, 30)
        Me.sndbkgChk.Name = "sndbkgChk"
        Me.sndbkgChk.Size = New System.Drawing.Size(64, 17)
        Me.sndbkgChk.TabIndex = 5
        Me.sndbkgChk.Text = "-sndbkg"
        Me.ToolTip1.SetToolTip(Me.sndbkgChk, "Enables game sounds even when game is minimized.")
        Me.sndbkgChk.UseVisualStyleBackColor = True
        '
        'widescreenChk
        '
        Me.widescreenChk.AutoSize = True
        Me.widescreenChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.widescreenChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.widescreenChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxWidescreen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.widescreenChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.widescreenChk.Location = New System.Drawing.Point(116, 84)
        Me.widescreenChk.Name = "widescreenChk"
        Me.widescreenChk.Size = New System.Drawing.Size(83, 17)
        Me.widescreenChk.TabIndex = 7
        Me.widescreenChk.Text = "-widescreen"
        Me.ToolTip1.SetToolTip(Me.widescreenChk, "Run the game in wide screen mode.")
        Me.widescreenChk.UseVisualStyleBackColor = True
        '
        'cpufixChk
        '
        Me.cpufixChk.AutoSize = True
        Me.cpufixChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.cpufixChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpufixChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxCpufix", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cpufixChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.cpufixChk.Location = New System.Drawing.Point(116, 57)
        Me.cpufixChk.Name = "cpufixChk"
        Me.cpufixChk.Size = New System.Drawing.Size(57, 17)
        Me.cpufixChk.TabIndex = 6
        Me.cpufixChk.Text = "-cpufix"
        Me.ToolTip1.SetToolTip(Me.cpufixChk, "Fix for cpu.")
        Me.cpufixChk.UseVisualStyleBackColor = True
        '
        'd3dChk
        '
        Me.d3dChk.AutoSize = True
        Me.d3dChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxD3d
        Me.d3dChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.d3dChk.Location = New System.Drawing.Point(3, 30)
        Me.d3dChk.Name = "d3dChk"
        Me.d3dChk.Size = New System.Drawing.Size(55, 17)
        Me.d3dChk.TabIndex = 0
        Me.d3dChk.Text = "-d3d"
        Me.ToolTip1.SetToolTip(Me.d3dChk, "VideoMode: Direct 3D")
        Me.d3dChk.UseVisualStyleBackColor = True
        '
        'ddrawChk
        '
        Me.ddrawChk.AutoSize = True
        Me.ddrawChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDdraw
        Me.ddrawChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ddrawChk.Location = New System.Drawing.Point(3, 30)
        Me.ddrawChk.Name = "ddrawChk"
        Me.ddrawChk.Size = New System.Drawing.Size(55, 17)
        Me.ddrawChk.TabIndex = 2
        Me.ddrawChk.Text = "-ddraw"
        Me.ToolTip1.SetToolTip(Me.ddrawChk, "VideoMode: Direct Draw")
        Me.ddrawChk.UseVisualStyleBackColor = True
        '
        'playCloseChk
        '
        Me.playCloseChk.AutoSize = True
        Me.playCloseChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxPlayClose", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.playCloseChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.playCloseChk.Location = New System.Drawing.Point(792, 69)
        Me.playCloseChk.Name = "playCloseChk"
        Me.playCloseChk.Size = New System.Drawing.Size(162, 17)
        Me.playCloseChk.TabIndex = 10
        Me.playCloseChk.Text = "Clicking play closes launcher"
        Me.ToolTip1.SetToolTip(Me.playCloseChk, "Close the launcher when starting the game.")
        Me.playCloseChk.UseVisualStyleBackColor = True
        '
        'autoLootChk
        '
        Me.autoLootChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAutoUpdate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.autoLootChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.autoLootChk.Location = New System.Drawing.Point(213, 17)
        Me.autoLootChk.Name = "autoLootChk"
        Me.autoLootChk.Size = New System.Drawing.Size(62, 31)
        Me.autoLootChk.TabIndex = 23
        Me.autoLootChk.Text = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.autoLootChk, "Update the loot filter when you open the game.")
        Me.autoLootChk.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 155)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(609, 278)
        Me.WebBrowser1.TabIndex = 9
        Me.WebBrowser1.Url = New System.Uri("https://pathofdiablo.com/p/?getnewsembed", System.UriKind.Absolute)
        '
        'downloadcfg
        '
        Me.downloadcfg.Enabled = False
        Me.downloadcfg.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.downloadcfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadcfg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.downloadcfg.Location = New System.Drawing.Point(270, 18)
        Me.downloadcfg.Name = "downloadcfg"
        Me.downloadcfg.Size = New System.Drawing.Size(65, 25)
        Me.downloadcfg.TabIndex = 21
        Me.downloadcfg.Text = "Download"
        Me.downloadcfg.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.filterlibBtn)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lootfilterurl)
        Me.GroupBox5.Controls.Add(Me.downloadcfg)
        Me.GroupBox5.Controls.Add(Me.autoLootChk)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(628, 295)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 55)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loot Filter Downloader"
        '
        'filterlibBtn
        '
        Me.filterlibBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.filterlibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterlibBtn.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.filterlibBtn.Location = New System.Drawing.Point(337, 18)
        Me.filterlibBtn.Name = "filterlibBtn"
        Me.filterlibBtn.Size = New System.Drawing.Size(25, 25)
        Me.filterlibBtn.TabIndex = 24
        Me.filterlibBtn.Text = "+"
        Me.ToolTip1.SetToolTip(Me.filterlibBtn, "Opens loot filters library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for you to browse pre-made filters.")
        Me.filterlibBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "URL:"
        '
        'lootfilterurl
        '
        Me.lootfilterurl.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lootfilterurl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lootfilterurl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "stringLootLink", True))
        Me.lootfilterurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lootfilterurl.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lootfilterurl.Location = New System.Drawing.Point(33, 21)
        Me.lootfilterurl.Name = "lootfilterurl"
        Me.lootfilterurl.Size = New System.Drawing.Size(175, 20)
        Me.lootfilterurl.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LogBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(627, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 81)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Log"
        '
        'LogBox
        '
        Me.LogBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.HorizontalScrollbar = True
        Me.LogBox.Location = New System.Drawing.Point(6, 16)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(356, 52)
        Me.LogBox.TabIndex = 0
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(3, 61)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(750, 23)
        Me.ProgressBar.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.playBtn)
        Me.Panel1.Controls.Add(Me.ProgressBar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.playCloseChk)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 439)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 87)
        Me.Panel1.TabIndex = 28
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button6.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.discord
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(633, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 27)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Discord"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button4.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._70
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(129, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 27)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Servers List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button5.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._90
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(381, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 27)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Rules"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button3.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._43
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(255, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 27)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Wiki"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._84
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Donate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.reddit
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(507, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 27)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Reddit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dlInfo
        '
        Me.dlInfo.AutoSize = True
        Me.dlInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.dlInfo.Location = New System.Drawing.Point(12, 484)
        Me.dlInfo.Name = "dlInfo"
        Me.dlInfo.Size = New System.Drawing.Size(0, 13)
        Me.dlInfo.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(983, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 538)
        Me.Controls.Add(Me.dlInfo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents playBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents aspectChk As System.Windows.Forms.CheckBox
    Friend WithEvents dfxChk As System.Windows.Forms.RadioButton
    Friend WithEvents nsChk As System.Windows.Forms.CheckBox
    Friend WithEvents txtChk As System.Windows.Forms.CheckBox
    Friend WithEvents directcbox As System.Windows.Forms.CheckBox
    Friend WithEvents directChk As System.Windows.Forms.CheckBox
    Friend WithEvents skipChk As System.Windows.Forms.CheckBox
    Friend WithEvents wChk As System.Windows.Forms.CheckBox
    Friend WithEvents widescreenChk As System.Windows.Forms.CheckBox
    Friend WithEvents cpufixChk As System.Windows.Forms.CheckBox
    Friend WithEvents ddrawChk As System.Windows.Forms.RadioButton
    Friend WithEvents d3dChk As System.Windows.Forms.RadioButton
    Friend WithEvents playCloseChk As System.Windows.Forms.CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents downloadcfg As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lootfilterurl As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LogBox As ListBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents advancedChk As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents filterlibBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dlInfo As Label
    Friend WithEvents sndbkgChk As CheckBox
    Friend WithEvents autoLootChk As CheckBox
    Friend WithEvents Button6 As Button
End Class
