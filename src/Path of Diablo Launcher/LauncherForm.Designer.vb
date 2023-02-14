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
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.dfxChk = New System.Windows.Forms.RadioButton()
        Me.ButtonGlideConfig = New System.Windows.Forms.Button()
        Me.wChk = New System.Windows.Forms.RadioButton()
        Me.sndbkgChk = New System.Windows.Forms.CheckBox()
        Me.cpufixChk = New System.Windows.Forms.CheckBox()
        Me.ddrawChk = New System.Windows.Forms.RadioButton()
        Me.vidTestChk = New System.Windows.Forms.RadioButton()
        Me.widescreenChk = New System.Windows.Forms.CheckBox()
        Me.PTRchk = New System.Windows.Forms.CheckBox()
        Me.advancedChk = New System.Windows.Forms.CheckBox()
        Me.idsoundChk = New System.Windows.Forms.CheckBox()
        Me.ButtonSelectFilter = New System.Windows.Forms.Button()
        Me.CheckAutoUpdateFilter = New System.Windows.Forms.CheckBox()
        Me.ButtonDDrawConfig = New System.Windows.Forms.Button()
        Me.LauncherBanner = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.GroupBoxLaunchFlags = New System.Windows.Forms.GroupBox()
        Me.TableLayoutConfigOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.directcbox = New System.Windows.Forms.CheckBox()
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
        Me.ButtonPlay.Location = New System.Drawing.Point(765, 13)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(213, 53)
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
        Me.CheckCloseOnPlay.Location = New System.Drawing.Point(792, 71)
        Me.CheckCloseOnPlay.Name = "CheckCloseOnPlay"
        Me.CheckCloseOnPlay.Size = New System.Drawing.Size(162, 17)
        Me.CheckCloseOnPlay.TabIndex = 10
        Me.CheckCloseOnPlay.Text = "Clicking play closes launcher"
        Me.ToolTip1.SetToolTip(Me.CheckCloseOnPlay, "Close the launcher when starting the game.")
        Me.CheckCloseOnPlay.UseVisualStyleBackColor = True
        '
        'ProgressBarDownload
        '
        Me.ProgressBarDownload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ProgressBarDownload.Location = New System.Drawing.Point(3, 45)
        Me.ProgressBarDownload.Name = "ProgressBarDownload"
        Me.ProgressBarDownload.Size = New System.Drawing.Size(750, 31)
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
        Me.PanelBottom.Location = New System.Drawing.Point(12, 512)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(984, 94)
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
        Me.ButtonDiscord.Location = New System.Drawing.Point(633, 9)
        Me.ButtonDiscord.Name = "ButtonDiscord"
        Me.ButtonDiscord.Size = New System.Drawing.Size(120, 27)
        Me.ButtonDiscord.TabIndex = 27
        Me.ButtonDiscord.Text = "Discord"
        Me.ButtonDiscord.UseVisualStyleBackColor = True
        '
        'LabelDownloadStatus
        '
        Me.LabelDownloadStatus.AutoSize = True
        Me.LabelDownloadStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelDownloadStatus.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LabelDownloadStatus.Location = New System.Drawing.Point(3, 79)
        Me.LabelDownloadStatus.Name = "LabelDownloadStatus"
        Me.LabelDownloadStatus.Size = New System.Drawing.Size(88, 13)
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
        Me.ButtonServerList.Location = New System.Drawing.Point(129, 9)
        Me.ButtonServerList.Name = "ButtonServerList"
        Me.ButtonServerList.Size = New System.Drawing.Size(120, 27)
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
        Me.ButtonRules.Location = New System.Drawing.Point(381, 9)
        Me.ButtonRules.Name = "ButtonRules"
        Me.ButtonRules.Size = New System.Drawing.Size(120, 27)
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
        Me.ButtonWiki.Location = New System.Drawing.Point(255, 9)
        Me.ButtonWiki.Name = "ButtonWiki"
        Me.ButtonWiki.Size = New System.Drawing.Size(120, 27)
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
        Me.ButtonDonate.Location = New System.Drawing.Point(3, 9)
        Me.ButtonDonate.Name = "ButtonDonate"
        Me.ButtonDonate.Size = New System.Drawing.Size(120, 27)
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
        Me.ButtonReddit.Location = New System.Drawing.Point(507, 9)
        Me.ButtonReddit.Name = "ButtonReddit"
        Me.ButtonReddit.Size = New System.Drawing.Size(120, 27)
        Me.ButtonReddit.TabIndex = 12
        Me.ButtonReddit.Text = "Reddit"
        Me.ButtonReddit.UseVisualStyleBackColor = True
        '
        'skipChk
        '
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.skipChk.Location = New System.Drawing.Point(159, 3)
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
        Me.aspectChk.Location = New System.Drawing.Point(259, 3)
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
        Me.nsChk.Location = New System.Drawing.Point(259, 27)
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
        Me.dfxChk.Location = New System.Drawing.Point(3, 27)
        Me.dfxChk.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.dfxChk.Name = "dfxChk"
        Me.dfxChk.Size = New System.Drawing.Size(81, 17)
        Me.dfxChk.TabIndex = 1
        Me.dfxChk.Text = "-3dfx (Glide)"
        Me.ToolTip1.SetToolTip(Me.dfxChk, "VideoMode: Glide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the cog icon to configure glide settings")
        Me.dfxChk.UseVisualStyleBackColor = True
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
        Me.ButtonGlideConfig.Location = New System.Drawing.Point(91, 27)
        Me.ButtonGlideConfig.Name = "ButtonGlideConfig"
        Me.ButtonGlideConfig.Size = New System.Drawing.Size(14, 18)
        Me.ButtonGlideConfig.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ButtonGlideConfig, "Configure glide settings")
        Me.ButtonGlideConfig.UseVisualStyleBackColor = False
        '
        'wChk
        '
        Me.wChk.AutoSize = True
        Me.wChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.wChk, 3)
        Me.wChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.wChk.Location = New System.Drawing.Point(3, 3)
        Me.wChk.Name = "wChk"
        Me.wChk.Size = New System.Drawing.Size(70, 17)
        Me.wChk.TabIndex = 3
        Me.wChk.TabStop = True
        Me.wChk.Text = "-w (GDI+)"
        Me.ToolTip1.SetToolTip(Me.wChk, "VideoMode: GDI+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Runs the game in windowed mode.")
        Me.wChk.UseVisualStyleBackColor = True
        '
        'sndbkgChk
        '
        Me.sndbkgChk.AutoSize = True
        Me.sndbkgChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSndBkg
        Me.sndbkgChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSndBkg", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.sndbkgChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.sndbkgChk.Location = New System.Drawing.Point(159, 27)
        Me.sndbkgChk.Name = "sndbkgChk"
        Me.sndbkgChk.Size = New System.Drawing.Size(64, 17)
        Me.sndbkgChk.TabIndex = 5
        Me.sndbkgChk.Text = "-sndbkg"
        Me.ToolTip1.SetToolTip(Me.sndbkgChk, "Enables game sounds even when game is minimized.")
        Me.sndbkgChk.UseVisualStyleBackColor = True
        '
        'cpufixChk
        '
        Me.cpufixChk.AutoSize = True
        Me.cpufixChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.cpufixChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpufixChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxCpufix", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cpufixChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.cpufixChk.Location = New System.Drawing.Point(159, 51)
        Me.cpufixChk.Name = "cpufixChk"
        Me.cpufixChk.Size = New System.Drawing.Size(57, 17)
        Me.cpufixChk.TabIndex = 6
        Me.cpufixChk.Text = "-cpufix"
        Me.ToolTip1.SetToolTip(Me.cpufixChk, "Fix for cpu.")
        Me.cpufixChk.UseVisualStyleBackColor = True
        '
        'ddrawChk
        '
        Me.ddrawChk.AutoSize = True
        Me.ddrawChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDdraw
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.ddrawChk, 2)
        Me.ddrawChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ddrawChk.Location = New System.Drawing.Point(3, 51)
        Me.ddrawChk.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.ddrawChk.Name = "ddrawChk"
        Me.ddrawChk.Size = New System.Drawing.Size(119, 17)
        Me.ddrawChk.TabIndex = 2
        Me.ddrawChk.Text = "-ddraw (DirectDraw)"
        Me.ToolTip1.SetToolTip(Me.ddrawChk, "VideoMode: DirectDraw" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the cog icon to configure ddraw settings")
        Me.ddrawChk.UseVisualStyleBackColor = True
        '
        'vidTestChk
        '
        Me.vidTestChk.AutoSize = True
        Me.vidTestChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxVidTest
        Me.TableLayoutConfigOptions.SetColumnSpan(Me.vidTestChk, 3)
        Me.vidTestChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.vidTestChk.Location = New System.Drawing.Point(3, 75)
        Me.vidTestChk.Name = "vidTestChk"
        Me.vidTestChk.Size = New System.Drawing.Size(105, 17)
        Me.vidTestChk.TabIndex = 0
        Me.vidTestChk.Text = "D2VidTst Setting"
        Me.ToolTip1.SetToolTip(Me.vidTestChk, "Use the config set by D2VidTst.exe")
        Me.vidTestChk.UseVisualStyleBackColor = True
        '
        'widescreenChk
        '
        Me.widescreenChk.AutoSize = True
        Me.widescreenChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.widescreenChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.widescreenChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxWidescreen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.widescreenChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.widescreenChk.Location = New System.Drawing.Point(159, 75)
        Me.widescreenChk.Name = "widescreenChk"
        Me.widescreenChk.Size = New System.Drawing.Size(83, 17)
        Me.widescreenChk.TabIndex = 7
        Me.widescreenChk.Text = "-widescreen"
        Me.ToolTip1.SetToolTip(Me.widescreenChk, "Run the game in wide screen mode.")
        Me.widescreenChk.UseVisualStyleBackColor = True
        '
        'PTRchk
        '
        Me.PTRchk.AutoSize = True
        Me.PTRchk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.PTRchk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxPTR", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PTRchk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.PTRchk.Location = New System.Drawing.Point(159, 99)
        Me.PTRchk.Name = "PTRchk"
        Me.PTRchk.Size = New System.Drawing.Size(41, 17)
        Me.PTRchk.TabIndex = 12
        Me.PTRchk.Text = "-ptr"
        Me.ToolTip1.SetToolTip(Me.PTRchk, "Connect to the Public Test Realm.")
        Me.PTRchk.UseVisualStyleBackColor = True
        '
        'advancedChk
        '
        Me.advancedChk.AutoSize = True
        Me.advancedChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxAdvanced
        Me.advancedChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAdvanced", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.advancedChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.advancedChk.Location = New System.Drawing.Point(259, 75)
        Me.advancedChk.Name = "advancedChk"
        Me.advancedChk.Size = New System.Drawing.Size(75, 17)
        Me.advancedChk.TabIndex = 10
        Me.advancedChk.Text = "Advanced"
        Me.ToolTip1.SetToolTip(Me.advancedChk, "Show advanced options." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use at your own risk!")
        Me.advancedChk.UseVisualStyleBackColor = True
        '
        'idsoundChk
        '
        Me.idsoundChk.AutoSize = True
        Me.idsoundChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.idsoundChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxIdSound", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.idsoundChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.idsoundChk.Location = New System.Drawing.Point(259, 51)
        Me.idsoundChk.Name = "idsoundChk"
        Me.idsoundChk.Size = New System.Drawing.Size(66, 17)
        Me.idsoundChk.TabIndex = 13
        Me.idsoundChk.Text = "-idsound"
        Me.ToolTip1.SetToolTip(Me.idsoundChk, "Run the game with IndirectSound.")
        Me.idsoundChk.UseVisualStyleBackColor = True
        '
        'ButtonSelectFilter
        '
        Me.ButtonSelectFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonSelectFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonSelectFilter.Location = New System.Drawing.Point(337, 18)
        Me.ButtonSelectFilter.Name = "ButtonSelectFilter"
        Me.ButtonSelectFilter.Size = New System.Drawing.Size(25, 25)
        Me.ButtonSelectFilter.TabIndex = 24
        Me.ButtonSelectFilter.Text = "+"
        Me.ToolTip1.SetToolTip(Me.ButtonSelectFilter, "Opens loot filters library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for you to browse pre-made filters.")
        Me.ButtonSelectFilter.UseVisualStyleBackColor = True
        '
        'CheckAutoUpdateFilter
        '
        Me.CheckAutoUpdateFilter.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAutoUpdate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckAutoUpdateFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckAutoUpdateFilter.Location = New System.Drawing.Point(6, 45)
        Me.CheckAutoUpdateFilter.Name = "CheckAutoUpdateFilter"
        Me.CheckAutoUpdateFilter.Size = New System.Drawing.Size(139, 31)
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
        Me.ButtonDDrawConfig.Location = New System.Drawing.Point(125, 51)
        Me.ButtonDDrawConfig.Name = "ButtonDDrawConfig"
        Me.ButtonDDrawConfig.Size = New System.Drawing.Size(14, 18)
        Me.ButtonDDrawConfig.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.ButtonDDrawConfig, "Configure ddraw settings")
        Me.ButtonDDrawConfig.UseVisualStyleBackColor = False
        '
        'LauncherBanner
        '
        Me.LauncherBanner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LauncherBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LauncherBanner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LauncherBanner.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner2
        Me.LauncherBanner.Location = New System.Drawing.Point(13, 14)
        Me.LauncherBanner.Name = "LauncherBanner"
        Me.LauncherBanner.Size = New System.Drawing.Size(984, 137)
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
        Me.PanelMain.Location = New System.Drawing.Point(13, 155)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(984, 351)
        Me.PanelMain.TabIndex = 29
        '
        'GroupBoxLaunchFlags
        '
        Me.GroupBoxLaunchFlags.Controls.Add(Me.TableLayoutConfigOptions)
        Me.GroupBoxLaunchFlags.ForeColor = System.Drawing.Color.White
        Me.GroupBoxLaunchFlags.Location = New System.Drawing.Point(616, 0)
        Me.GroupBoxLaunchFlags.Name = "GroupBoxLaunchFlags"
        Me.GroupBoxLaunchFlags.Size = New System.Drawing.Size(368, 143)
        Me.GroupBoxLaunchFlags.TabIndex = 30
        Me.GroupBoxLaunchFlags.TabStop = False
        Me.GroupBoxLaunchFlags.Text = "Launch Flags"
        '
        'TableLayoutConfigOptions
        '
        Me.TableLayoutConfigOptions.ColumnCount = 5
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutConfigOptions.Controls.Add(Me.skipChk, 2, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.aspectChk, 3, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.nsChk, 4, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.dfxChk, 0, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.wChk, 0, 0)
        Me.TableLayoutConfigOptions.Controls.Add(Me.sndbkgChk, 3, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ddrawChk, 0, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.vidTestChk, 0, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.widescreenChk, 2, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.PTRchk, 3, 4)
        Me.TableLayoutConfigOptions.Controls.Add(Me.directcbox, 4, 4)
        Me.TableLayoutConfigOptions.Controls.Add(Me.advancedChk, 4, 3)
        Me.TableLayoutConfigOptions.Controls.Add(Me.idsoundChk, 4, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ButtonGlideConfig, 1, 1)
        Me.TableLayoutConfigOptions.Controls.Add(Me.cpufixChk, 3, 2)
        Me.TableLayoutConfigOptions.Controls.Add(Me.ButtonDDrawConfig, 2, 2)
        Me.TableLayoutConfigOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutConfigOptions.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutConfigOptions.Name = "TableLayoutConfigOptions"
        Me.TableLayoutConfigOptions.RowCount = 5
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.Size = New System.Drawing.Size(356, 120)
        Me.TableLayoutConfigOptions.TabIndex = 31
        '
        'directcbox
        '
        Me.directcbox.AutoSize = True
        Me.directcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDirect
        Me.directcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDirect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.directcbox.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.directcbox.Location = New System.Drawing.Point(259, 99)
        Me.directcbox.Name = "directcbox"
        Me.directcbox.Size = New System.Drawing.Size(55, 17)
        Me.directcbox.TabIndex = 11
        Me.directcbox.Text = "-direct"
        Me.directcbox.UseVisualStyleBackColor = True
        Me.directcbox.Visible = False
        '
        'GroupBoxEventLog
        '
        Me.GroupBoxEventLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEventLog.Controls.Add(Me.LogBoxEventLog)
        Me.GroupBoxEventLog.ForeColor = System.Drawing.Color.White
        Me.GroupBoxEventLog.Location = New System.Drawing.Point(616, 234)
        Me.GroupBoxEventLog.Name = "GroupBoxEventLog"
        Me.GroupBoxEventLog.Size = New System.Drawing.Size(368, 114)
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
        Me.LogBoxEventLog.HorizontalScrollbar = True
        Me.LogBoxEventLog.Location = New System.Drawing.Point(6, 19)
        Me.LogBoxEventLog.Name = "LogBoxEventLog"
        Me.LogBoxEventLog.Size = New System.Drawing.Size(356, 91)
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
        Me.GroupBoxLootFilter.Location = New System.Drawing.Point(616, 149)
        Me.GroupBoxLootFilter.Name = "GroupBoxLootFilter"
        Me.GroupBoxLootFilter.Size = New System.Drawing.Size(368, 79)
        Me.GroupBoxLootFilter.TabIndex = 32
        Me.GroupBoxLootFilter.TabStop = False
        Me.GroupBoxLootFilter.Text = "Loot Filter"
        '
        'LabelLootFilterURL
        '
        Me.LabelLootFilterURL.AutoSize = True
        Me.LabelLootFilterURL.Location = New System.Drawing.Point(1, 24)
        Me.LabelLootFilterURL.Name = "LabelLootFilterURL"
        Me.LabelLootFilterURL.Size = New System.Drawing.Size(32, 13)
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
        Me.TextBoxLootFilterURL.Location = New System.Drawing.Point(33, 21)
        Me.TextBoxLootFilterURL.Name = "TextBoxLootFilterURL"
        Me.TextBoxLootFilterURL.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxLootFilterURL.TabIndex = 22
        '
        'ButtonDownloadFilter
        '
        Me.ButtonDownloadFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDownloadFilter.Enabled = False
        Me.ButtonDownloadFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDownloadFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloadFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDownloadFilter.Location = New System.Drawing.Point(150, 47)
        Me.ButtonDownloadFilter.Name = "ButtonDownloadFilter"
        Me.ButtonDownloadFilter.Size = New System.Drawing.Size(212, 25)
        Me.ButtonDownloadFilter.TabIndex = 21
        Me.ButtonDownloadFilter.Text = "Download"
        Me.ButtonDownloadFilter.UseVisualStyleBackColor = True
        '
        'WebBrowserNews
        '
        Me.WebBrowserNews.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserNews.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserNews.Location = New System.Drawing.Point(1, 2)
        Me.WebBrowserNews.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserNews.Name = "WebBrowserNews"
        Me.WebBrowserNews.ScriptErrorsSuppressed = True
        Me.WebBrowserNews.Size = New System.Drawing.Size(609, 346)
        Me.WebBrowserNews.TabIndex = 31
        Me.WebBrowserNews.Url = New System.Uri("https://pathofdiablo.com/p/?getnewsembed", System.UriKind.Absolute)
        '
        'LauncherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 610)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.LauncherBanner)
        Me.Controls.Add(Me.PanelBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents txtChk As System.Windows.Forms.CheckBox
    Friend WithEvents directChk As System.Windows.Forms.CheckBox
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
    Friend WithEvents skipChk As CheckBox
    Friend WithEvents aspectChk As CheckBox
    Friend WithEvents nsChk As CheckBox
    Friend WithEvents dfxChk As RadioButton
    Friend WithEvents ButtonGlideConfig As Button
    Friend WithEvents wChk As RadioButton
    Friend WithEvents sndbkgChk As CheckBox
    Friend WithEvents cpufixChk As CheckBox
    Friend WithEvents ddrawChk As RadioButton
    Friend WithEvents vidTestChk As RadioButton
    Friend WithEvents widescreenChk As CheckBox
    Friend WithEvents PTRchk As CheckBox
    Friend WithEvents directcbox As CheckBox
    Friend WithEvents advancedChk As CheckBox
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
End Class
