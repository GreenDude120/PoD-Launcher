<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LauncherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LauncherForm))
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.CheckCloseOnPlay = New System.Windows.Forms.CheckBox()
        Me.ProgressBarDownload = New System.Windows.Forms.ProgressBar()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonDiscord = New System.Windows.Forms.Button()
        Me.LabelDownloadStatus = New System.Windows.Forms.Label()
        Me.ButtonServerList = New System.Windows.Forms.Button()
        Me.ButtonRules = New System.Windows.Forms.Button()
        Me.ButtonWiki = New System.Windows.Forms.Button()
        Me.ButtonDonate = New System.Windows.Forms.Button()
        Me.ButtonReddit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonGlideConfig = New System.Windows.Forms.Button()
        Me.ButtonSelectFilter = New System.Windows.Forms.Button()
        Me.CheckAutoUpdateFilter = New System.Windows.Forms.CheckBox()
        Me.ButtonDDrawConfig = New System.Windows.Forms.Button()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.radio3DFX = New System.Windows.Forms.RadioButton()
        Me.radioGDI = New System.Windows.Forms.RadioButton()
        Me.sndbkgChk = New System.Windows.Forms.CheckBox()
        Me.radioDDraw = New System.Windows.Forms.RadioButton()
        Me.radioVidTest = New System.Windows.Forms.RadioButton()
        Me.widescreenChk = New System.Windows.Forms.CheckBox()
        Me.ptrChk = New System.Windows.Forms.CheckBox()
        Me.dsoalChk = New System.Windows.Forms.CheckBox()
        Me.idsoundChk = New System.Windows.Forms.CheckBox()
        Me.cpufixChk = New System.Windows.Forms.CheckBox()
        Me.radioD2GL = New System.Windows.Forms.RadioButton()
        Me.ButtonD2VidTestConfig = New System.Windows.Forms.Button()
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.directChk = New System.Windows.Forms.CheckBox()
        Me.LauncherBanner = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.GroupBoxLaunchFlags = New System.Windows.Forms.GroupBox()
        Me.TableLayoutConfigOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxEventLog = New System.Windows.Forms.GroupBox()
        Me.LogBoxEventLog = New System.Windows.Forms.ListBox()
        Me.GroupBoxLootFilter = New System.Windows.Forms.GroupBox()
        Me.LabelLootFilterURL = New System.Windows.Forms.Label()
        Me.TextBoxLootFilterURL = New System.Windows.Forms.TextBox()
        Me.ButtonDownloadFilter = New System.Windows.Forms.Button()
        Me.WebBrowserNews = New System.Windows.Forms.WebBrowser()
        Me.PanelBottom.SuspendLayout()
        CType(Me.LauncherBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        Me.GroupBoxLaunchFlags.SuspendLayout()
        Me.TableLayoutConfigOptions.SuspendLayout()
        Me.GroupBoxEventLog.SuspendLayout()
        Me.GroupBoxLootFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonPlay.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPlay.ForeColor = System.Drawing.Color.Green
        Me.ButtonPlay.Location = New System.Drawing.Point(810, 68)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(320, 52)
        Me.ButtonPlay.TabIndex = 1
        Me.ButtonPlay.Text = "Checking for Updates"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'CheckCloseOnPlay
        '
        Me.CheckCloseOnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckCloseOnPlay.AutoSize = True
        Me.CheckCloseOnPlay.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxPlayClose", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckCloseOnPlay.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckCloseOnPlay.Location = New System.Drawing.Point(843, 134)
        Me.CheckCloseOnPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckCloseOnPlay.Name = "CheckCloseOnPlay"
        Me.CheckCloseOnPlay.Size = New System.Drawing.Size(235, 24)
        Me.CheckCloseOnPlay.TabIndex = 10
        Me.CheckCloseOnPlay.Text = "Clicking play closes launcher"
        Me.ToolTip1.SetToolTip(Me.CheckCloseOnPlay, "Close the launcher when starting the game.")
        Me.CheckCloseOnPlay.UseVisualStyleBackColor = True
        '
        'ProgressBarDownload
        '
        Me.ProgressBarDownload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ProgressBarDownload.Location = New System.Drawing.Point(4, 68)
        Me.ProgressBarDownload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBarDownload.Name = "ProgressBarDownload"
        Me.ProgressBarDownload.Size = New System.Drawing.Size(790, 46)
        Me.ProgressBarDownload.Step = 1
        Me.ProgressBarDownload.TabIndex = 26
        '
        'PanelBottom
        '
        Me.PanelBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PanelBottom.Controls.Add(Me.ButtonDiscord)
        Me.PanelBottom.Controls.Add(Me.LabelDownloadStatus)
        Me.PanelBottom.Controls.Add(Me.ButtonServerList)
        Me.PanelBottom.Controls.Add(Me.ButtonRules)
        Me.PanelBottom.Controls.Add(Me.ButtonPlay)
        Me.PanelBottom.Controls.Add(Me.ProgressBarDownload)
        Me.PanelBottom.Controls.Add(Me.ButtonWiki)
        Me.PanelBottom.Controls.Add(Me.ButtonDonate)
        Me.PanelBottom.Controls.Add(Me.CheckCloseOnPlay)
        Me.PanelBottom.Controls.Add(Me.ButtonReddit)
        Me.PanelBottom.Location = New System.Drawing.Point(18, 664)
        Me.PanelBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1143, 166)
        Me.PanelBottom.TabIndex = 28
        '
        'ButtonDiscord
        '
        Me.ButtonDiscord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDiscord.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDiscord.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDiscord.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.discord
        Me.ButtonDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDiscord.Location = New System.Drawing.Point(950, 14)
        Me.ButtonDiscord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDiscord.Name = "ButtonDiscord"
        Me.ButtonDiscord.Size = New System.Drawing.Size(180, 40)
        Me.ButtonDiscord.TabIndex = 27
        Me.ButtonDiscord.Text = "Discord"
        Me.ButtonDiscord.UseVisualStyleBackColor = True
        '
        'LabelDownloadStatus
        '
        Me.LabelDownloadStatus.AutoSize = True
        Me.LabelDownloadStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelDownloadStatus.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LabelDownloadStatus.Location = New System.Drawing.Point(0, 134)
        Me.LabelDownloadStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDownloadStatus.Name = "LabelDownloadStatus"
        Me.LabelDownloadStatus.Size = New System.Drawing.Size(131, 20)
        Me.LabelDownloadStatus.TabIndex = 27
        Me.LabelDownloadStatus.Text = "Download Status"
        Me.LabelDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonServerList
        '
        Me.ButtonServerList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonServerList.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonServerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonServerList.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonServerList.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._70
        Me.ButtonServerList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonServerList.Location = New System.Drawing.Point(194, 14)
        Me.ButtonServerList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonServerList.Name = "ButtonServerList"
        Me.ButtonServerList.Size = New System.Drawing.Size(180, 40)
        Me.ButtonServerList.TabIndex = 14
        Me.ButtonServerList.Text = "Servers List"
        Me.ButtonServerList.UseVisualStyleBackColor = True
        '
        'ButtonRules
        '
        Me.ButtonRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRules.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRules.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonRules.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._90
        Me.ButtonRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRules.Location = New System.Drawing.Point(572, 14)
        Me.ButtonRules.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRules.Name = "ButtonRules"
        Me.ButtonRules.Size = New System.Drawing.Size(180, 40)
        Me.ButtonRules.TabIndex = 15
        Me.ButtonRules.Text = "Rules"
        Me.ButtonRules.UseVisualStyleBackColor = True
        '
        'ButtonWiki
        '
        Me.ButtonWiki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonWiki.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonWiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonWiki.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonWiki.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._43
        Me.ButtonWiki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonWiki.Location = New System.Drawing.Point(382, 14)
        Me.ButtonWiki.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonWiki.Name = "ButtonWiki"
        Me.ButtonWiki.Size = New System.Drawing.Size(180, 40)
        Me.ButtonWiki.TabIndex = 13
        Me.ButtonWiki.Text = "Wiki"
        Me.ButtonWiki.UseVisualStyleBackColor = True
        '
        'ButtonDonate
        '
        Me.ButtonDonate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDonate.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDonate.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDonate.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._84
        Me.ButtonDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDonate.Location = New System.Drawing.Point(4, 14)
        Me.ButtonDonate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDonate.Name = "ButtonDonate"
        Me.ButtonDonate.Size = New System.Drawing.Size(180, 40)
        Me.ButtonDonate.TabIndex = 11
        Me.ButtonDonate.Text = "Donate"
        Me.ButtonDonate.UseVisualStyleBackColor = True
        '
        'ButtonReddit
        '
        Me.ButtonReddit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReddit.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonReddit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReddit.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonReddit.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.reddit
        Me.ButtonReddit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReddit.Location = New System.Drawing.Point(760, 14)
        Me.ButtonReddit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonReddit.Name = "ButtonReddit"
        Me.ButtonReddit.Size = New System.Drawing.Size(180, 40)
        Me.ButtonReddit.TabIndex = 12
        Me.ButtonReddit.Text = "Reddit"
        Me.ButtonReddit.UseVisualStyleBackColor = True
        '
        'ButtonGlideConfig
        '
        Me.ButtonGlideConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonGlideConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGlideConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonGlideConfig.FlatAppearance.BorderSize = 0
        Me.ButtonGlideConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGlideConfig.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonGlideConfig.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.cog
        Me.ButtonGlideConfig.Location = New System.Drawing.Point(132, 40)
        Me.ButtonGlideConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGlideConfig.Name = "ButtonGlideConfig"
        Me.ButtonGlideConfig.Size = New System.Drawing.Size(21, 28)
        Me.ButtonGlideConfig.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ButtonGlideConfig, "Configure glide settings")
        Me.ButtonGlideConfig.UseVisualStyleBackColor = False
        '
        'ButtonSelectFilter
        '
        Me.ButtonSelectFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonSelectFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonSelectFilter.Location = New System.Drawing.Point(506, 27)
        Me.ButtonSelectFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSelectFilter.Name = "ButtonSelectFilter"
        Me.ButtonSelectFilter.Size = New System.Drawing.Size(38, 38)
        Me.ButtonSelectFilter.TabIndex = 24
        Me.ButtonSelectFilter.Text = "+"
        Me.ToolTip1.SetToolTip(Me.ButtonSelectFilter, "Opens loot filters library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for you to browse pre-made filters.")
        Me.ButtonSelectFilter.UseVisualStyleBackColor = True
        '
        'CheckAutoUpdateFilter
        '
        Me.CheckAutoUpdateFilter.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAutoUpdate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckAutoUpdateFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckAutoUpdateFilter.Location = New System.Drawing.Point(9, 68)
        Me.CheckAutoUpdateFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckAutoUpdateFilter.Name = "CheckAutoUpdateFilter"
        Me.CheckAutoUpdateFilter.Size = New System.Drawing.Size(208, 46)
        Me.CheckAutoUpdateFilter.TabIndex = 23
        Me.CheckAutoUpdateFilter.Text = "Auto Update Filter"
        Me.ToolTip1.SetToolTip(Me.CheckAutoUpdateFilter, "Update the loot filter when you open the game.")
        Me.CheckAutoUpdateFilter.UseVisualStyleBackColor = True
        '
        'ButtonDDrawConfig
        '
        Me.ButtonDDrawConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonDDrawConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDDrawConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonDDrawConfig.FlatAppearance.BorderSize = 0
        Me.ButtonDDrawConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDDrawConfig.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDDrawConfig.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.cog
        Me.ButtonDDrawConfig.Location = New System.Drawing.Point(183, 76)
        Me.ButtonDDrawConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDDrawConfig.Name = "ButtonDDrawConfig"
        Me.ButtonDDrawConfig.Size = New System.Drawing.Size(21, 28)
        Me.ButtonDDrawConfig.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.ButtonDDrawConfig, "Configure ddraw settings")
        Me.ButtonDDrawConfig.UseVisualStyleBackColor = False
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNoFixAspect
        Me.aspectChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNoFixAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.aspectChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.aspectChk.Location = New System.Drawing.Point(386, 4)
        Me.aspectChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(121, 24)
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
        Me.nsChk.Location = New System.Drawing.Point(386, 40)
        Me.nsChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nsChk.Name = "nsChk"
        Me.nsChk.Size = New System.Drawing.Size(57, 24)
        Me.nsChk.TabIndex = 9
        Me.nsChk.Text = "-ns"
        Me.ToolTip1.SetToolTip(Me.nsChk, "Disables the in-game sound.")
        Me.nsChk.UseVisualStyleBackColor = True
        '
        'radio3DFX
        '
        Me.radio3DFX.AutoSize = True
        Me.radio3DFX.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkbox3dfx
        Me.radio3DFX.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.radio3DFX.Location = New System.Drawing.Point(4, 40)
        Me.radio3DFX.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radio3DFX.Name = "radio3DFX"
        Me.radio3DFX.Size = New System.Drawing.Size(120, 24)
        Me.radio3DFX.TabIndex = 1
        Me.radio3DFX.Text = "-3dfx (Glide)"
        Me.ToolTip1.SetToolTip(Me.radio3DFX, "VideoMode: Glide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the cog icon to configure glide settings")
        Me.radio3DFX.UseVisualStyleBackColor = True
        '
        'radioGDI
        '
        Me.radioGDI.AutoSize = True
        Me.radioGDI.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.radioGDI, 3)
        Me.radioGDI.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.radioGDI.Location = New System.Drawing.Point(4, 4)
        Me.radioGDI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioGDI.Name = "radioGDI"
        Me.radioGDI.Size = New System.Drawing.Size(103, 24)
        Me.radioGDI.TabIndex = 3
        Me.radioGDI.Text = "-w (GDI+)"
        Me.ToolTip1.SetToolTip(Me.radioGDI, "VideoMode: GDI+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Runs the game in windowed mode.")
        Me.radioGDI.UseVisualStyleBackColor = True
        '
        'sndbkgChk
        '
        Me.sndbkgChk.AutoSize = True
        Me.sndbkgChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSndBkg
        Me.sndbkgChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSndBkg", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.sndbkgChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.sndbkgChk.Location = New System.Drawing.Point(234, 40)
        Me.sndbkgChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sndbkgChk.Name = "sndbkgChk"
        Me.sndbkgChk.Size = New System.Drawing.Size(92, 24)
        Me.sndbkgChk.TabIndex = 5
        Me.sndbkgChk.Text = "-sndbkg"
        Me.ToolTip1.SetToolTip(Me.sndbkgChk, "Enables game sounds even when game is minimized.")
        Me.sndbkgChk.UseVisualStyleBackColor = True
        '
        'radioDDraw
        '
        Me.radioDDraw.AutoSize = True
        Me.radioDDraw.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDdraw
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.radioDDraw, 2)
        Me.radioDDraw.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.radioDDraw.Location = New System.Drawing.Point(4, 76)
        Me.radioDDraw.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radioDDraw.Name = "radioDDraw"
        Me.radioDDraw.Size = New System.Drawing.Size(175, 24)
        Me.radioDDraw.TabIndex = 2
        Me.radioDDraw.TabStop = True
        Me.radioDDraw.Text = "-ddraw (DirectDraw)"
        Me.ToolTip1.SetToolTip(Me.radioDDraw, "VideoMode: DirectDraw" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the cog icon to configure ddraw settings")
        Me.radioDDraw.UseVisualStyleBackColor = True
        '
        'radioVidTest
        '
        Me.radioVidTest.AutoSize = True
        Me.radioVidTest.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxVidTest
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.radioVidTest, 2)
        Me.radioVidTest.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.radioVidTest.Location = New System.Drawing.Point(4, 112)
        Me.radioVidTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioVidTest.Name = "radioVidTest"
        Me.radioVidTest.Size = New System.Drawing.Size(155, 24)
        Me.radioVidTest.TabIndex = 0
        Me.radioVidTest.Text = "D2VidTst Setting"
        Me.ToolTip1.SetToolTip(Me.radioVidTest, "Use the config set by D2VidTst.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the cog icon to run D2VidTst.")
        Me.radioVidTest.UseVisualStyleBackColor = True
        '
        'widescreenChk
        '
        Me.widescreenChk.AutoSize = True
        Me.widescreenChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.widescreenChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.widescreenChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxWidescreen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.widescreenChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.widescreenChk.Location = New System.Drawing.Point(234, 112)
        Me.widescreenChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.widescreenChk.Name = "widescreenChk"
        Me.widescreenChk.Size = New System.Drawing.Size(120, 24)
        Me.widescreenChk.TabIndex = 7
        Me.widescreenChk.Text = "-widescreen"
        Me.ToolTip1.SetToolTip(Me.widescreenChk, "Run the game in wide screen mode.")
        Me.widescreenChk.UseVisualStyleBackColor = True
        '
        'ptrChk
        '
        Me.ptrChk.AutoSize = True
        Me.ptrChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.ptrChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxPTR", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ptrChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ptrChk.Location = New System.Drawing.Point(234, 148)
        Me.ptrChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ptrChk.Name = "ptrChk"
        Me.ptrChk.Size = New System.Drawing.Size(59, 24)
        Me.ptrChk.TabIndex = 12
        Me.ptrChk.Text = "-ptr"
        Me.ToolTip1.SetToolTip(Me.ptrChk, "Connect to the Public Test Realm.")
        Me.ptrChk.UseVisualStyleBackColor = True
        '
        'dsoalChk
        '
        Me.dsoalChk.AutoSize = True
        Me.dsoalChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDSOAL
        Me.dsoalChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDSOAL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dsoalChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.dsoalChk.Location = New System.Drawing.Point(386, 112)
        Me.dsoalChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dsoalChk.Name = "dsoalChk"
        Me.dsoalChk.Size = New System.Drawing.Size(78, 24)
        Me.dsoalChk.TabIndex = 10
        Me.dsoalChk.Text = "-dsoal"
        Me.ToolTip1.SetToolTip(Me.dsoalChk, "enabled DSOAL, an OpenAL based audio driver supporting EAX")
        Me.dsoalChk.UseVisualStyleBackColor = True
        '
        'idsoundChk
        '
        Me.idsoundChk.AutoSize = True
        Me.idsoundChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.idsoundChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxIdSound", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.idsoundChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.idsoundChk.Location = New System.Drawing.Point(386, 76)
        Me.idsoundChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.idsoundChk.Name = "idsoundChk"
        Me.idsoundChk.Size = New System.Drawing.Size(96, 24)
        Me.idsoundChk.TabIndex = 13
        Me.idsoundChk.Text = "-idsound"
        Me.ToolTip1.SetToolTip(Me.idsoundChk, "Run the game with IndirectSound.")
        Me.idsoundChk.UseVisualStyleBackColor = True
        '
        'cpufixChk
        '
        Me.cpufixChk.AutoSize = True
        Me.cpufixChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.cpufixChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpufixChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxCpufix", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cpufixChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.cpufixChk.Location = New System.Drawing.Point(234, 76)
        Me.cpufixChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cpufixChk.Name = "cpufixChk"
        Me.cpufixChk.Size = New System.Drawing.Size(81, 24)
        Me.cpufixChk.TabIndex = 6
        Me.cpufixChk.Text = "-cpufix"
        Me.ToolTip1.SetToolTip(Me.cpufixChk, "Fix for cpu.")
        Me.cpufixChk.UseVisualStyleBackColor = True
        '
        'radioD2GL
        '
        Me.radioD2GL.AutoSize = True
        Me.radioD2GL.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxD2GL
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.radioD2GL, 3)
        Me.radioD2GL.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.radioD2GL.Location = New System.Drawing.Point(4, 148)
        Me.radioD2GL.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radioD2GL.Name = "radioD2GL"
        Me.radioD2GL.Size = New System.Drawing.Size(222, 24)
        Me.radioD2GL.TabIndex = 16
        Me.radioD2GL.Text = "-d2gl (D2GL Experimental)"
        Me.ToolTip1.SetToolTip(Me.radioD2GL, "VideoMode: D2GL Glide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Configure via Ctrl+O in-game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WARNING: This mode is exper" &
        "imental, requires OpenGL 3.3+ support." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.radioD2GL.UseVisualStyleBackColor = True
        '
        'ButtonD2VidTestConfig
        '
        Me.ButtonD2VidTestConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonD2VidTestConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonD2VidTestConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonD2VidTestConfig.FlatAppearance.BorderSize = 0
        Me.ButtonD2VidTestConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonD2VidTestConfig.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonD2VidTestConfig.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.cog
        Me.ButtonD2VidTestConfig.Location = New System.Drawing.Point(183, 112)
        Me.ButtonD2VidTestConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonD2VidTestConfig.Name = "ButtonD2VidTestConfig"
        Me.ButtonD2VidTestConfig.Size = New System.Drawing.Size(21, 28)
        Me.ButtonD2VidTestConfig.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.ButtonD2VidTestConfig, "Run D2VidTst")
        Me.ButtonD2VidTestConfig.UseVisualStyleBackColor = False
        '
        'skipChk
        '
        Me.skipChk.AutoSize = True
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.skipChk.Location = New System.Drawing.Point(234, 4)
        Me.skipChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.skipChk.Name = "skipChk"
        Me.skipChk.Size = New System.Drawing.Size(114, 24)
        Me.skipChk.TabIndex = 4
        Me.skipChk.Text = "-skiptobnet"
        Me.ToolTip1.SetToolTip(Me.skipChk, "Game opens straight into online multiplayer & skips cutscenes")
        Me.skipChk.UseVisualStyleBackColor = True
        '
        'directChk
        '
        Me.directChk.AutoSize = True
        Me.directChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDirect
        Me.directChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDirect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.directChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.directChk.Location = New System.Drawing.Point(386, 148)
        Me.directChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.directChk.Name = "directChk"
        Me.directChk.Size = New System.Drawing.Size(79, 24)
        Me.directChk.TabIndex = 11
        Me.directChk.Text = "-direct"
        Me.ToolTip1.SetToolTip(Me.directChk, "Advanced: Stream files from disk first then MPQs")
        Me.directChk.UseVisualStyleBackColor = True
        '
        'LauncherBanner
        '
        Me.LauncherBanner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LauncherBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LauncherBanner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LauncherBanner.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner2
        Me.LauncherBanner.Location = New System.Drawing.Point(18, 18)
        Me.LauncherBanner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LauncherBanner.Name = "LauncherBanner"
        Me.LauncherBanner.Size = New System.Drawing.Size(1142, 174)
        Me.LauncherBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LauncherBanner.TabIndex = 0
        Me.LauncherBanner.TabStop = False
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.Controls.Add(Me.GroupBoxLaunchFlags)
        Me.PanelMain.Controls.Add(Me.GroupBoxEventLog)
        Me.PanelMain.Controls.Add(Me.GroupBoxLootFilter)
        Me.PanelMain.Controls.Add(Me.WebBrowserNews)
        Me.PanelMain.Location = New System.Drawing.Point(18, 202)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1143, 453)
        Me.PanelMain.TabIndex = 29
        '
        'GroupBoxLaunchFlags
        '
        Me.GroupBoxLaunchFlags.Controls.Add(Me.TableLayoutConfigOptions)
        Me.GroupBoxLaunchFlags.ForeColor = System.Drawing.Color.White
        Me.GroupBoxLaunchFlags.Location = New System.Drawing.Point(590, 4)
        Me.GroupBoxLaunchFlags.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLaunchFlags.Name = "GroupBoxLaunchFlags"
        Me.GroupBoxLaunchFlags.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLaunchFlags.Size = New System.Drawing.Size(552, 214)
        Me.GroupBoxLaunchFlags.TabIndex = 30
        Me.GroupBoxLaunchFlags.TabStop = False
        Me.GroupBoxLaunchFlags.Text = "Launch Flags"
        '
        'TableLayoutConfigOptions
        '
        Me.TableLayoutConfigOptions.ColumnCount = 5
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutConfigOptions.Controls.Add(Me.ButtonD2VidTestConfig, 2, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.skipChk, 1, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.aspectChk, 3, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.nsChk, 4, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.radio3DFX, 0, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.radioGDI, 0, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.sndbkgChk, 3, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.radioDDraw, 0, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.radioVidTest, 0, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.widescreenChk, 3, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ptrChk, 3, 4)
        Me.TableLayoutConfigOptions.Controls.Add(Me.directChk, 4, 4)
        Me.TableLayoutConfigOptions.Controls.Add(Me.dsoalChk, 4, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.idsoundChk, 4, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ButtonGlideConfig, 1, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.cpufixChk, 3, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ButtonDDrawConfig, 2, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.radioD2GL, 0, 4)
        Me.TableLayoutConfigOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutConfigOptions.Location = New System.Drawing.Point(9, 26)
        Me.TableLayoutConfigOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutConfigOptions.Name = "TableLayoutConfigOptions"
        Me.TableLayoutConfigOptions.RowCount = 5
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.Size = New System.Drawing.Size(534, 180)
        Me.TableLayoutConfigOptions.TabIndex = 31
        '
        'GroupBoxEventLog
        '
        Me.GroupBoxEventLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEventLog.Controls.Add(Me.LogBoxEventLog)
        Me.GroupBoxEventLog.ForeColor = System.Drawing.Color.White
        Me.GroupBoxEventLog.Location = New System.Drawing.Point(590, 346)
        Me.GroupBoxEventLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxEventLog.Name = "GroupBoxEventLog"
        Me.GroupBoxEventLog.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxEventLog.Size = New System.Drawing.Size(552, 98)
        Me.GroupBoxEventLog.TabIndex = 33
        Me.GroupBoxEventLog.TabStop = False
        Me.GroupBoxEventLog.Text = "Event Log"
        '
        'LogBoxEventLog
        '
        Me.LogBoxEventLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogBoxEventLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LogBoxEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBoxEventLog.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LogBoxEventLog.FormattingEnabled = True
        Me.LogBoxEventLog.ItemHeight = 20
        Me.LogBoxEventLog.Location = New System.Drawing.Point(9, 28)
        Me.LogBoxEventLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogBoxEventLog.Name = "LogBoxEventLog"
        Me.LogBoxEventLog.Size = New System.Drawing.Size(534, 40)
        Me.LogBoxEventLog.TabIndex = 0
        '
        'GroupBoxLootFilter
        '
        Me.GroupBoxLootFilter.Controls.Add(Me.ButtonSelectFilter)
        Me.GroupBoxLootFilter.Controls.Add(Me.LabelLootFilterURL)
        Me.GroupBoxLootFilter.Controls.Add(Me.TextBoxLootFilterURL)
        Me.GroupBoxLootFilter.Controls.Add(Me.ButtonDownloadFilter)
        Me.GroupBoxLootFilter.Controls.Add(Me.CheckAutoUpdateFilter)
        Me.GroupBoxLootFilter.ForeColor = System.Drawing.Color.White
        Me.GroupBoxLootFilter.Location = New System.Drawing.Point(590, 224)
        Me.GroupBoxLootFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLootFilter.Name = "GroupBoxLootFilter"
        Me.GroupBoxLootFilter.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLootFilter.Size = New System.Drawing.Size(552, 118)
        Me.GroupBoxLootFilter.TabIndex = 32
        Me.GroupBoxLootFilter.TabStop = False
        Me.GroupBoxLootFilter.Text = "Loot Filter"
        '
        'LabelLootFilterURL
        '
        Me.LabelLootFilterURL.AutoSize = True
        Me.LabelLootFilterURL.Location = New System.Drawing.Point(2, 36)
        Me.LabelLootFilterURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLootFilterURL.Name = "LabelLootFilterURL"
        Me.LabelLootFilterURL.Size = New System.Drawing.Size(46, 20)
        Me.LabelLootFilterURL.TabIndex = 23
        Me.LabelLootFilterURL.Text = "URL:"
        '
        'TextBoxLootFilterURL
        '
        Me.TextBoxLootFilterURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TextBoxLootFilterURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLootFilterURL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "stringLootLink", True))
        Me.TextBoxLootFilterURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLootFilterURL.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxLootFilterURL.Location = New System.Drawing.Point(50, 32)
        Me.TextBoxLootFilterURL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLootFilterURL.Name = "TextBoxLootFilterURL"
        Me.TextBoxLootFilterURL.Size = New System.Drawing.Size(449, 26)
        Me.TextBoxLootFilterURL.TabIndex = 22
        '
        'ButtonDownloadFilter
        '
        Me.ButtonDownloadFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDownloadFilter.Enabled = False
        Me.ButtonDownloadFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDownloadFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloadFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDownloadFilter.Location = New System.Drawing.Point(225, 70)
        Me.ButtonDownloadFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDownloadFilter.Name = "ButtonDownloadFilter"
        Me.ButtonDownloadFilter.Size = New System.Drawing.Size(318, 38)
        Me.ButtonDownloadFilter.TabIndex = 21
        Me.ButtonDownloadFilter.Text = "Download"
        Me.ButtonDownloadFilter.UseVisualStyleBackColor = True
        '
        'WebBrowserNews
        '
        Me.WebBrowserNews.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserNews.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserNews.Location = New System.Drawing.Point(4, 3)
        Me.WebBrowserNews.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WebBrowserNews.MinimumSize = New System.Drawing.Size(30, 30)
        Me.WebBrowserNews.Name = "WebBrowserNews"
        Me.WebBrowserNews.ScriptErrorsSuppressed = True
        Me.WebBrowserNews.Size = New System.Drawing.Size(578, 446)
        Me.WebBrowserNews.TabIndex = 31
        Me.WebBrowserNews.Url = New System.Uri("https://pathofdiablo.com/p/?getnewsembed", System.UriKind.Absolute)
        '
        'LauncherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 842)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.LauncherBanner)
        Me.Controls.Add(Me.PanelBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LauncherForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.LauncherBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.GroupBoxLaunchFlags.ResumeLayout(False)
        Me.TableLayoutConfigOptions.ResumeLayout(False)
        Me.TableLayoutConfigOptions.PerformLayout()
        Me.GroupBoxEventLog.ResumeLayout(False)
        Me.GroupBoxLootFilter.ResumeLayout(False)
        Me.GroupBoxLootFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LauncherBanner As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents CheckCloseOnPlay As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonDonate As Button
    Friend WithEvents ButtonReddit As Button
    Friend WithEvents ButtonWiki As Button
    Friend WithEvents ButtonServerList As Button
    Friend WithEvents ButtonRules As Button
    Friend WithEvents ProgressBarDownload As ProgressBar
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelDownloadStatus As Label
    Friend WithEvents ButtonDiscord As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents GroupBoxLaunchFlags As GroupBox
    Friend WithEvents TableLayoutConfigOptions As TableLayoutPanel
    Friend WithEvents aspectChk As CheckBox
    Friend WithEvents nsChk As CheckBox
    Friend WithEvents radio3DFX As RadioButton
    Friend WithEvents ButtonGlideConfig As Button
    Friend WithEvents radioGDI As RadioButton
    Friend WithEvents sndbkgChk As CheckBox
    Friend WithEvents cpufixChk As CheckBox
    Friend WithEvents radioDDraw As RadioButton
    Friend WithEvents radioVidTest As RadioButton
    Friend WithEvents widescreenChk As CheckBox
    Friend WithEvents ptrChk As CheckBox
    Friend WithEvents directChk As CheckBox
    Friend WithEvents dsoalChk As CheckBox
    Friend WithEvents idsoundChk As CheckBox
    Friend WithEvents GroupBoxEventLog As GroupBox
    Friend WithEvents LogBoxEventLog As ListBox
    Friend WithEvents GroupBoxLootFilter As GroupBox
    Friend WithEvents ButtonSelectFilter As Button
    Friend WithEvents LabelLootFilterURL As Label
    Friend WithEvents TextBoxLootFilterURL As TextBox
    Friend WithEvents ButtonDownloadFilter As Button
    Friend WithEvents CheckAutoUpdateFilter As CheckBox
    Friend WithEvents WebBrowserNews As WebBrowser
    Friend WithEvents ButtonDDrawConfig As Button
    Friend WithEvents radioD2GL As RadioButton
    Friend WithEvents ButtonD2VidTestConfig As Button
    Friend WithEvents skipChk As CheckBox
End Class
