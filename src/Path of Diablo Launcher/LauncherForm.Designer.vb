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
        Me.PanelPlay = New System.Windows.Forms.Panel()
        Me.LabelDownloadStatus = New System.Windows.Forms.Label()
        Me.ButtonDiscord = New System.Windows.Forms.Button()
        Me.ButtonServerList = New System.Windows.Forms.Button()
        Me.ButtonRules = New System.Windows.Forms.Button()
        Me.ButtonWiki = New System.Windows.Forms.Button()
        Me.ButtonDonate = New System.Windows.Forms.Button()
        Me.ButtonReddit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonSelectFilter = New System.Windows.Forms.Button()
        Me.CheckAutoUpdateFilter = New System.Windows.Forms.CheckBox()
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
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.directChk = New System.Windows.Forms.CheckBox()
        Me.ButtonD2VidTestConfig = New System.Windows.Forms.Button()
        Me.ButtonGlideConfig = New System.Windows.Forms.Button()
        Me.ButtonDDrawConfig = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.GroupBoxLaunchFlags = New System.Windows.Forms.GroupBox()
        Me.TableLayoutConfigOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxEventLog = New System.Windows.Forms.GroupBox()
        Me.LogBoxEventLog = New System.Windows.Forms.ListBox()
        Me.GroupBoxLootFilter = New System.Windows.Forms.GroupBox()
        Me.LootFilterButton = New System.Windows.Forms.Button()
        Me.WebBrowserNews = New System.Windows.Forms.WebBrowser()
        Me.LootFilterSettingsPanel = New System.Windows.Forms.Panel()
        Me.FilterThreeLabel = New System.Windows.Forms.Label()
        Me.FilterTwoLabel = New System.Windows.Forms.Label()
        Me.LabelLootFilterURLThree = New System.Windows.Forms.Label()
        Me.TextBoxLootFilterURLThree = New System.Windows.Forms.TextBox()
        Me.LabelLootFilterURLTwo = New System.Windows.Forms.Label()
        Me.TextBoxLootFilterURLTwo = New System.Windows.Forms.TextBox()
        Me.LootFilerSettingsCloseButton = New System.Windows.Forms.Button()
        Me.LabelLootFilterURL = New System.Windows.Forms.Label()
        Me.ButtonDownloadFilter = New System.Windows.Forms.Button()
        Me.TextBoxLootFilterURL = New System.Windows.Forms.TextBox()
        Me.FilterOneLabel = New System.Windows.Forms.Label()
        Me.LauncherBanner = New System.Windows.Forms.PictureBox()
        Me.PanelLinks = New System.Windows.Forms.Panel()
        Me.ButtonDeleteFilterOne = New System.Windows.Forms.Button()
        Me.ButtonDeleteFilterTwo = New System.Windows.Forms.Button()
        Me.ButtonDeleteFilterThree = New System.Windows.Forms.Button()
        Me.PanelPlay.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.GroupBoxLaunchFlags.SuspendLayout()
        Me.TableLayoutConfigOptions.SuspendLayout()
        Me.GroupBoxEventLog.SuspendLayout()
        Me.GroupBoxLootFilter.SuspendLayout()
        Me.LootFilterSettingsPanel.SuspendLayout()
        CType(Me.LauncherBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPlay.ForeColor = System.Drawing.Color.Green
        Me.ButtonPlay.Location = New System.Drawing.Point(682, 6)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(266, 45)
        Me.ButtonPlay.TabIndex = 1
        Me.ButtonPlay.Text = "Checking for Updates"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'CheckCloseOnPlay
        '
        Me.CheckCloseOnPlay.AutoSize = True
        Me.CheckCloseOnPlay.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxPlayClose", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckCloseOnPlay.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckCloseOnPlay.Location = New System.Drawing.Point(724, 55)
        Me.CheckCloseOnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckCloseOnPlay.Name = "CheckCloseOnPlay"
        Me.CheckCloseOnPlay.Size = New System.Drawing.Size(202, 20)
        Me.CheckCloseOnPlay.TabIndex = 10
        Me.CheckCloseOnPlay.Text = "Clicking play closes launcher"
        Me.ToolTip1.SetToolTip(Me.CheckCloseOnPlay, "Close the launcher when starting the game.")
        Me.CheckCloseOnPlay.UseVisualStyleBackColor = True
        '
        'ProgressBarDownload
        '
        Me.ProgressBarDownload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ProgressBarDownload.Location = New System.Drawing.Point(4, 9)
        Me.ProgressBarDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBarDownload.Name = "ProgressBarDownload"
        Me.ProgressBarDownload.Size = New System.Drawing.Size(671, 39)
        Me.ProgressBarDownload.Step = 1
        Me.ProgressBarDownload.TabIndex = 26
        '
        'PanelPlay
        '
        Me.PanelPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelPlay.Controls.Add(Me.ButtonPlay)
        Me.PanelPlay.Controls.Add(Me.LabelDownloadStatus)
        Me.PanelPlay.Controls.Add(Me.ProgressBarDownload)
        Me.PanelPlay.Controls.Add(Me.CheckCloseOnPlay)
        Me.PanelPlay.Location = New System.Drawing.Point(15, 499)
        Me.PanelPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelPlay.Name = "PanelPlay"
        Me.PanelPlay.Size = New System.Drawing.Size(952, 79)
        Me.PanelPlay.TabIndex = 28
        '
        'LabelDownloadStatus
        '
        Me.LabelDownloadStatus.AutoSize = True
        Me.LabelDownloadStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelDownloadStatus.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LabelDownloadStatus.Location = New System.Drawing.Point(6, 56)
        Me.LabelDownloadStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDownloadStatus.Name = "LabelDownloadStatus"
        Me.LabelDownloadStatus.Size = New System.Drawing.Size(108, 16)
        Me.LabelDownloadStatus.TabIndex = 27
        Me.LabelDownloadStatus.Text = "Download Status"
        Me.LabelDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonDiscord
        '
        Me.ButtonDiscord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDiscord.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDiscord.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDiscord.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.discord
        Me.ButtonDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDiscord.Location = New System.Drawing.Point(795, 6)
        Me.ButtonDiscord.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDiscord.Name = "ButtonDiscord"
        Me.ButtonDiscord.Size = New System.Drawing.Size(150, 34)
        Me.ButtonDiscord.TabIndex = 27
        Me.ButtonDiscord.Text = "Discord"
        Me.ButtonDiscord.UseVisualStyleBackColor = True
        '
        'ButtonServerList
        '
        Me.ButtonServerList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonServerList.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonServerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonServerList.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonServerList.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources._70
        Me.ButtonServerList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonServerList.Location = New System.Drawing.Point(165, 6)
        Me.ButtonServerList.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonServerList.Name = "ButtonServerList"
        Me.ButtonServerList.Size = New System.Drawing.Size(150, 34)
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
        Me.ButtonRules.Location = New System.Drawing.Point(480, 6)
        Me.ButtonRules.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRules.Name = "ButtonRules"
        Me.ButtonRules.Size = New System.Drawing.Size(150, 34)
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
        Me.ButtonWiki.Location = New System.Drawing.Point(322, 6)
        Me.ButtonWiki.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonWiki.Name = "ButtonWiki"
        Me.ButtonWiki.Size = New System.Drawing.Size(150, 34)
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
        Me.ButtonDonate.Location = New System.Drawing.Point(8, 6)
        Me.ButtonDonate.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDonate.Name = "ButtonDonate"
        Me.ButtonDonate.Size = New System.Drawing.Size(150, 34)
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
        Me.ButtonReddit.Location = New System.Drawing.Point(638, 6)
        Me.ButtonReddit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReddit.Name = "ButtonReddit"
        Me.ButtonReddit.Size = New System.Drawing.Size(150, 34)
        Me.ButtonReddit.TabIndex = 12
        Me.ButtonReddit.Text = "Reddit"
        Me.ButtonReddit.UseVisualStyleBackColor = True
        '
        'ButtonSelectFilter
        '
        Me.ButtonSelectFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonSelectFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSelectFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonSelectFilter.Location = New System.Drawing.Point(346, 36)
        Me.ButtonSelectFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSelectFilter.Name = "ButtonSelectFilter"
        Me.ButtonSelectFilter.Size = New System.Drawing.Size(31, 31)
        Me.ButtonSelectFilter.TabIndex = 24
        Me.ButtonSelectFilter.Text = "+"
        Me.ToolTip1.SetToolTip(Me.ButtonSelectFilter, "Opens loot filters library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for you to browse pre-made filters.")
        Me.ButtonSelectFilter.UseVisualStyleBackColor = True
        '
        'CheckAutoUpdateFilter
        '
        Me.CheckAutoUpdateFilter.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxAutoUpdate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckAutoUpdateFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckAutoUpdateFilter.Location = New System.Drawing.Point(12, 357)
        Me.CheckAutoUpdateFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAutoUpdateFilter.Name = "CheckAutoUpdateFilter"
        Me.CheckAutoUpdateFilter.Size = New System.Drawing.Size(152, 39)
        Me.CheckAutoUpdateFilter.TabIndex = 23
        Me.CheckAutoUpdateFilter.Text = "Auto Update Filter"
        Me.ToolTip1.SetToolTip(Me.CheckAutoUpdateFilter, "Update the loot filter when you open the game.")
        Me.CheckAutoUpdateFilter.UseVisualStyleBackColor = True
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNoFixAspect
        Me.aspectChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNoFixAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.aspectChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.aspectChk.Location = New System.Drawing.Point(322, 4)
        Me.aspectChk.Margin = New System.Windows.Forms.Padding(4)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(101, 20)
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
        Me.nsChk.Location = New System.Drawing.Point(322, 34)
        Me.nsChk.Margin = New System.Windows.Forms.Padding(4)
        Me.nsChk.Name = "nsChk"
        Me.nsChk.Size = New System.Drawing.Size(47, 20)
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
        Me.radio3DFX.Location = New System.Drawing.Point(4, 34)
        Me.radio3DFX.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radio3DFX.Name = "radio3DFX"
        Me.radio3DFX.Size = New System.Drawing.Size(99, 20)
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
        Me.radioGDI.Margin = New System.Windows.Forms.Padding(4)
        Me.radioGDI.Name = "radioGDI"
        Me.radioGDI.Size = New System.Drawing.Size(82, 20)
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
        Me.sndbkgChk.Location = New System.Drawing.Point(196, 34)
        Me.sndbkgChk.Margin = New System.Windows.Forms.Padding(4)
        Me.sndbkgChk.Name = "sndbkgChk"
        Me.sndbkgChk.Size = New System.Drawing.Size(78, 20)
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
        Me.radioDDraw.Location = New System.Drawing.Point(4, 64)
        Me.radioDDraw.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radioDDraw.Name = "radioDDraw"
        Me.radioDDraw.Size = New System.Drawing.Size(146, 20)
        Me.radioDDraw.TabIndex = 2
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
        Me.radioVidTest.Location = New System.Drawing.Point(4, 94)
        Me.radioVidTest.Margin = New System.Windows.Forms.Padding(4)
        Me.radioVidTest.Name = "radioVidTest"
        Me.radioVidTest.Size = New System.Drawing.Size(128, 20)
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
        Me.widescreenChk.Location = New System.Drawing.Point(196, 94)
        Me.widescreenChk.Margin = New System.Windows.Forms.Padding(4)
        Me.widescreenChk.Name = "widescreenChk"
        Me.widescreenChk.Size = New System.Drawing.Size(102, 20)
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
        Me.ptrChk.Location = New System.Drawing.Point(196, 124)
        Me.ptrChk.Margin = New System.Windows.Forms.Padding(4)
        Me.ptrChk.Name = "ptrChk"
        Me.ptrChk.Size = New System.Drawing.Size(48, 20)
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
        Me.dsoalChk.Location = New System.Drawing.Point(322, 94)
        Me.dsoalChk.Margin = New System.Windows.Forms.Padding(4)
        Me.dsoalChk.Name = "dsoalChk"
        Me.dsoalChk.Size = New System.Drawing.Size(67, 20)
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
        Me.idsoundChk.Location = New System.Drawing.Point(322, 64)
        Me.idsoundChk.Margin = New System.Windows.Forms.Padding(4)
        Me.idsoundChk.Name = "idsoundChk"
        Me.idsoundChk.Size = New System.Drawing.Size(81, 20)
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
        Me.cpufixChk.Location = New System.Drawing.Point(196, 64)
        Me.cpufixChk.Margin = New System.Windows.Forms.Padding(4)
        Me.cpufixChk.Name = "cpufixChk"
        Me.cpufixChk.Size = New System.Drawing.Size(67, 20)
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
        Me.radioD2GL.Location = New System.Drawing.Point(4, 124)
        Me.radioD2GL.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.radioD2GL.Name = "radioD2GL"
        Me.radioD2GL.Size = New System.Drawing.Size(103, 20)
        Me.radioD2GL.TabIndex = 16
        Me.radioD2GL.TabStop = True
        Me.radioD2GL.Text = "-d2gl (D2GL)"
        Me.ToolTip1.SetToolTip(Me.radioD2GL, "VideoMode: D2GL Glide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Configure via Ctrl+O in-game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WARNING: This mode requires" &
        " OpenGL 3.3+ support.")
        Me.radioD2GL.UseVisualStyleBackColor = True
        '
        'skipChk
        '
        Me.skipChk.AutoSize = True
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.skipChk.Location = New System.Drawing.Point(196, 4)
        Me.skipChk.Margin = New System.Windows.Forms.Padding(4)
        Me.skipChk.Name = "skipChk"
        Me.skipChk.Size = New System.Drawing.Size(95, 20)
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
        Me.directChk.Location = New System.Drawing.Point(322, 124)
        Me.directChk.Margin = New System.Windows.Forms.Padding(4)
        Me.directChk.Name = "directChk"
        Me.directChk.Size = New System.Drawing.Size(66, 20)
        Me.directChk.TabIndex = 11
        Me.directChk.Text = "-direct"
        Me.ToolTip1.SetToolTip(Me.directChk, "Advanced: Stream files from disk first then MPQs")
        Me.directChk.UseVisualStyleBackColor = True
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
        Me.ButtonD2VidTestConfig.Location = New System.Drawing.Point(154, 94)
        Me.ButtonD2VidTestConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonD2VidTestConfig.Name = "ButtonD2VidTestConfig"
        Me.ButtonD2VidTestConfig.Size = New System.Drawing.Size(18, 22)
        Me.ButtonD2VidTestConfig.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.ButtonD2VidTestConfig, "Run D2VidTst")
        Me.ButtonD2VidTestConfig.UseVisualStyleBackColor = False
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
        Me.ButtonGlideConfig.Location = New System.Drawing.Point(112, 34)
        Me.ButtonGlideConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGlideConfig.Name = "ButtonGlideConfig"
        Me.ButtonGlideConfig.Size = New System.Drawing.Size(18, 22)
        Me.ButtonGlideConfig.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ButtonGlideConfig, "Configure glide settings")
        Me.ButtonGlideConfig.UseVisualStyleBackColor = False
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
        Me.ButtonDDrawConfig.Location = New System.Drawing.Point(154, 64)
        Me.ButtonDDrawConfig.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDDrawConfig.Name = "ButtonDDrawConfig"
        Me.ButtonDDrawConfig.Size = New System.Drawing.Size(18, 22)
        Me.ButtonDDrawConfig.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.ButtonDDrawConfig, "Configure ddraw settings")
        Me.ButtonDDrawConfig.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMain.Controls.Add(Me.GroupBoxLaunchFlags)
        Me.PanelMain.Controls.Add(Me.GroupBoxEventLog)
        Me.PanelMain.Controls.Add(Me.GroupBoxLootFilter)
        Me.PanelMain.Controls.Add(Me.WebBrowserNews)
        Me.PanelMain.Location = New System.Drawing.Point(15, 85)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(952, 410)
        Me.PanelMain.TabIndex = 29
        '
        'GroupBoxLaunchFlags
        '
        Me.GroupBoxLaunchFlags.Controls.Add(Me.TableLayoutConfigOptions)
        Me.GroupBoxLaunchFlags.ForeColor = System.Drawing.Color.White
        Me.GroupBoxLaunchFlags.Location = New System.Drawing.Point(491, 4)
        Me.GroupBoxLaunchFlags.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLaunchFlags.Name = "GroupBoxLaunchFlags"
        Me.GroupBoxLaunchFlags.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLaunchFlags.Size = New System.Drawing.Size(460, 179)
        Me.GroupBoxLaunchFlags.TabIndex = 30
        Me.GroupBoxLaunchFlags.TabStop = False
        Me.GroupBoxLaunchFlags.Text = "Launch Flags"
        '
        'TableLayoutConfigOptions
        '
        Me.TableLayoutConfigOptions.ColumnCount = 5
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutConfigOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
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
        Me.TableLayoutConfigOptions.Location = New System.Drawing.Point(8, 21)
        Me.TableLayoutConfigOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutConfigOptions.Name = "TableLayoutConfigOptions"
        Me.TableLayoutConfigOptions.RowCount = 5
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutConfigOptions.Size = New System.Drawing.Size(445, 150)
        Me.TableLayoutConfigOptions.TabIndex = 31
        '
        'GroupBoxEventLog
        '
        Me.GroupBoxEventLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEventLog.Controls.Add(Me.LogBoxEventLog)
        Me.GroupBoxEventLog.ForeColor = System.Drawing.Color.White
        Me.GroupBoxEventLog.Location = New System.Drawing.Point(491, 289)
        Me.GroupBoxEventLog.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxEventLog.Name = "GroupBoxEventLog"
        Me.GroupBoxEventLog.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxEventLog.Size = New System.Drawing.Size(460, 114)
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
        Me.LogBoxEventLog.ItemHeight = 16
        Me.LogBoxEventLog.Location = New System.Drawing.Point(8, 24)
        Me.LogBoxEventLog.Margin = New System.Windows.Forms.Padding(4)
        Me.LogBoxEventLog.Name = "LogBoxEventLog"
        Me.LogBoxEventLog.Size = New System.Drawing.Size(445, 80)
        Me.LogBoxEventLog.TabIndex = 0
        '
        'GroupBoxLootFilter
        '
        Me.GroupBoxLootFilter.Controls.Add(Me.LootFilterButton)
        Me.GroupBoxLootFilter.Controls.Add(Me.ButtonSelectFilter)
        Me.GroupBoxLootFilter.ForeColor = System.Drawing.Color.White
        Me.GroupBoxLootFilter.Location = New System.Drawing.Point(491, 186)
        Me.GroupBoxLootFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLootFilter.Name = "GroupBoxLootFilter"
        Me.GroupBoxLootFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLootFilter.Size = New System.Drawing.Size(460, 99)
        Me.GroupBoxLootFilter.TabIndex = 32
        Me.GroupBoxLootFilter.TabStop = False
        Me.GroupBoxLootFilter.Text = "Loot Filter"
        '
        'LootFilterButton
        '
        Me.LootFilterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LootFilterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LootFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LootFilterButton.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LootFilterButton.Location = New System.Drawing.Point(32, 36)
        Me.LootFilterButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LootFilterButton.Name = "LootFilterButton"
        Me.LootFilterButton.Size = New System.Drawing.Size(265, 31)
        Me.LootFilterButton.TabIndex = 34
        Me.LootFilterButton.Text = "Loot Filter Settings"
        Me.LootFilterButton.UseVisualStyleBackColor = True
        '
        'WebBrowserNews
        '
        Me.WebBrowserNews.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserNews.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserNews.Location = New System.Drawing.Point(4, 2)
        Me.WebBrowserNews.Margin = New System.Windows.Forms.Padding(4)
        Me.WebBrowserNews.MinimumSize = New System.Drawing.Size(25, 25)
        Me.WebBrowserNews.Name = "WebBrowserNews"
        Me.WebBrowserNews.ScriptErrorsSuppressed = True
        Me.WebBrowserNews.Size = New System.Drawing.Size(481, 404)
        Me.WebBrowserNews.TabIndex = 31
        Me.WebBrowserNews.Url = New System.Uri("https://beta.pathofdiablo.com/launcher-embed", System.UriKind.Absolute)
        '
        'LootFilterSettingsPanel
        '
        Me.LootFilterSettingsPanel.Controls.Add(Me.ButtonDeleteFilterThree)
        Me.LootFilterSettingsPanel.Controls.Add(Me.ButtonDeleteFilterTwo)
        Me.LootFilterSettingsPanel.Controls.Add(Me.ButtonDeleteFilterOne)
        Me.LootFilterSettingsPanel.Controls.Add(Me.FilterThreeLabel)
        Me.LootFilterSettingsPanel.Controls.Add(Me.FilterTwoLabel)
        Me.LootFilterSettingsPanel.Controls.Add(Me.LabelLootFilterURLThree)
        Me.LootFilterSettingsPanel.Controls.Add(Me.TextBoxLootFilterURLThree)
        Me.LootFilterSettingsPanel.Controls.Add(Me.LabelLootFilterURLTwo)
        Me.LootFilterSettingsPanel.Controls.Add(Me.TextBoxLootFilterURLTwo)
        Me.LootFilterSettingsPanel.Controls.Add(Me.CheckAutoUpdateFilter)
        Me.LootFilterSettingsPanel.Controls.Add(Me.LootFilerSettingsCloseButton)
        Me.LootFilterSettingsPanel.Controls.Add(Me.LabelLootFilterURL)
        Me.LootFilterSettingsPanel.Controls.Add(Me.ButtonDownloadFilter)
        Me.LootFilterSettingsPanel.Controls.Add(Me.TextBoxLootFilterURL)
        Me.LootFilterSettingsPanel.Controls.Add(Me.FilterOneLabel)
        Me.LootFilterSettingsPanel.Location = New System.Drawing.Point(506, 82)
        Me.LootFilterSettingsPanel.Name = "LootFilterSettingsPanel"
        Me.LootFilterSettingsPanel.Size = New System.Drawing.Size(463, 472)
        Me.LootFilterSettingsPanel.TabIndex = 35
        Me.LootFilterSettingsPanel.Visible = False
        '
        'FilterThreeLabel
        '
        Me.FilterThreeLabel.AutoSize = True
        Me.FilterThreeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterThreeLabel.Location = New System.Drawing.Point(230, 230)
        Me.FilterThreeLabel.Name = "FilterThreeLabel"
        Me.FilterThreeLabel.Size = New System.Drawing.Size(46, 16)
        Me.FilterThreeLabel.TabIndex = 31
        Me.FilterThreeLabel.Text = "Filter 3"
        '
        'FilterTwoLabel
        '
        Me.FilterTwoLabel.AutoSize = True
        Me.FilterTwoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterTwoLabel.Location = New System.Drawing.Point(230, 122)
        Me.FilterTwoLabel.Name = "FilterTwoLabel"
        Me.FilterTwoLabel.Size = New System.Drawing.Size(46, 16)
        Me.FilterTwoLabel.TabIndex = 30
        Me.FilterTwoLabel.Text = "Filter 2"
        '
        'LabelLootFilterURLThree
        '
        Me.LabelLootFilterURLThree.AutoSize = True
        Me.LabelLootFilterURLThree.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLootFilterURLThree.Location = New System.Drawing.Point(19, 253)
        Me.LabelLootFilterURLThree.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLootFilterURLThree.Name = "LabelLootFilterURLThree"
        Me.LabelLootFilterURLThree.Size = New System.Drawing.Size(34, 16)
        Me.LabelLootFilterURLThree.TabIndex = 29
        Me.LabelLootFilterURLThree.Text = "URL"
        '
        'TextBoxLootFilterURLThree
        '
        Me.TextBoxLootFilterURLThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TextBoxLootFilterURLThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLootFilterURLThree.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "stringLootLinkThree", True))
        Me.TextBoxLootFilterURLThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLootFilterURLThree.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxLootFilterURLThree.Location = New System.Drawing.Point(73, 250)
        Me.TextBoxLootFilterURLThree.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLootFilterURLThree.Name = "TextBoxLootFilterURLThree"
        Me.TextBoxLootFilterURLThree.Size = New System.Drawing.Size(372, 23)
        Me.TextBoxLootFilterURLThree.TabIndex = 28
        '
        'LabelLootFilterURLTwo
        '
        Me.LabelLootFilterURLTwo.AutoSize = True
        Me.LabelLootFilterURLTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLootFilterURLTwo.Location = New System.Drawing.Point(19, 145)
        Me.LabelLootFilterURLTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLootFilterURLTwo.Name = "LabelLootFilterURLTwo"
        Me.LabelLootFilterURLTwo.Size = New System.Drawing.Size(34, 16)
        Me.LabelLootFilterURLTwo.TabIndex = 27
        Me.LabelLootFilterURLTwo.Text = "URL"
        '
        'TextBoxLootFilterURLTwo
        '
        Me.TextBoxLootFilterURLTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TextBoxLootFilterURLTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLootFilterURLTwo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "stringLootLinkTwo", True))
        Me.TextBoxLootFilterURLTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLootFilterURLTwo.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxLootFilterURLTwo.Location = New System.Drawing.Point(73, 142)
        Me.TextBoxLootFilterURLTwo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLootFilterURLTwo.Name = "TextBoxLootFilterURLTwo"
        Me.TextBoxLootFilterURLTwo.Size = New System.Drawing.Size(372, 23)
        Me.TextBoxLootFilterURLTwo.TabIndex = 26
        '
        'LootFilerSettingsCloseButton
        '
        Me.LootFilerSettingsCloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LootFilerSettingsCloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LootFilerSettingsCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LootFilerSettingsCloseButton.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LootFilerSettingsCloseButton.Location = New System.Drawing.Point(204, 420)
        Me.LootFilerSettingsCloseButton.Name = "LootFilerSettingsCloseButton"
        Me.LootFilerSettingsCloseButton.Size = New System.Drawing.Size(80, 30)
        Me.LootFilerSettingsCloseButton.TabIndex = 24
        Me.LootFilerSettingsCloseButton.Text = "Close"
        Me.LootFilerSettingsCloseButton.UseVisualStyleBackColor = True
        '
        'LabelLootFilterURL
        '
        Me.LabelLootFilterURL.AutoSize = True
        Me.LabelLootFilterURL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLootFilterURL.Location = New System.Drawing.Point(19, 32)
        Me.LabelLootFilterURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLootFilterURL.Name = "LabelLootFilterURL"
        Me.LabelLootFilterURL.Size = New System.Drawing.Size(34, 16)
        Me.LabelLootFilterURL.TabIndex = 23
        Me.LabelLootFilterURL.Text = "URL"
        '
        'ButtonDownloadFilter
        '
        Me.ButtonDownloadFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDownloadFilter.Enabled = False
        Me.ButtonDownloadFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDownloadFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloadFilter.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDownloadFilter.Location = New System.Drawing.Point(172, 357)
        Me.ButtonDownloadFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDownloadFilter.Name = "ButtonDownloadFilter"
        Me.ButtonDownloadFilter.Size = New System.Drawing.Size(265, 31)
        Me.ButtonDownloadFilter.TabIndex = 21
        Me.ButtonDownloadFilter.Text = "Download"
        Me.ButtonDownloadFilter.UseVisualStyleBackColor = True
        '
        'TextBoxLootFilterURL
        '
        Me.TextBoxLootFilterURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TextBoxLootFilterURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLootFilterURL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "stringLootLink", True))
        Me.TextBoxLootFilterURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLootFilterURL.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxLootFilterURL.Location = New System.Drawing.Point(73, 29)
        Me.TextBoxLootFilterURL.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLootFilterURL.Name = "TextBoxLootFilterURL"
        Me.TextBoxLootFilterURL.Size = New System.Drawing.Size(372, 23)
        Me.TextBoxLootFilterURL.TabIndex = 22
        '
        'FilterOneLabel
        '
        Me.FilterOneLabel.AutoSize = True
        Me.FilterOneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterOneLabel.Location = New System.Drawing.Point(230, 7)
        Me.FilterOneLabel.Name = "FilterOneLabel"
        Me.FilterOneLabel.Size = New System.Drawing.Size(46, 16)
        Me.FilterOneLabel.TabIndex = 25
        Me.FilterOneLabel.Text = "Filter 1"
        '
        'LauncherBanner
        '
        Me.LauncherBanner.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LauncherBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LauncherBanner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LauncherBanner.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner2
        Me.LauncherBanner.Location = New System.Drawing.Point(0, -6)
        Me.LauncherBanner.Margin = New System.Windows.Forms.Padding(4)
        Me.LauncherBanner.Name = "LauncherBanner"
        Me.LauncherBanner.Size = New System.Drawing.Size(980, 88)
        Me.LauncherBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LauncherBanner.TabIndex = 0
        Me.LauncherBanner.TabStop = False
        '
        'PanelLinks
        '
        Me.PanelLinks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLinks.Controls.Add(Me.ButtonDiscord)
        Me.PanelLinks.Controls.Add(Me.ButtonServerList)
        Me.PanelLinks.Controls.Add(Me.ButtonRules)
        Me.PanelLinks.Controls.Add(Me.ButtonWiki)
        Me.PanelLinks.Controls.Add(Me.ButtonDonate)
        Me.PanelLinks.Controls.Add(Me.ButtonReddit)
        Me.PanelLinks.Location = New System.Drawing.Point(15, 580)
        Me.PanelLinks.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLinks.Name = "PanelLinks"
        Me.PanelLinks.Size = New System.Drawing.Size(952, 46)
        Me.PanelLinks.TabIndex = 30
        '
        'ButtonDeleteFilterOne
        '
        Me.ButtonDeleteFilterOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteFilterOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDeleteFilterOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteFilterOne.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDeleteFilterOne.Location = New System.Drawing.Point(365, 58)
        Me.ButtonDeleteFilterOne.Name = "ButtonDeleteFilterOne"
        Me.ButtonDeleteFilterOne.Size = New System.Drawing.Size(80, 30)
        Me.ButtonDeleteFilterOne.TabIndex = 32
        Me.ButtonDeleteFilterOne.Text = "Delete"
        Me.ButtonDeleteFilterOne.UseVisualStyleBackColor = True
        '
        'ButtonDeleteFilterTwo
        '
        Me.ButtonDeleteFilterTwo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteFilterTwo.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDeleteFilterTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteFilterTwo.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDeleteFilterTwo.Location = New System.Drawing.Point(365, 172)
        Me.ButtonDeleteFilterTwo.Name = "ButtonDeleteFilterTwo"
        Me.ButtonDeleteFilterTwo.Size = New System.Drawing.Size(80, 30)
        Me.ButtonDeleteFilterTwo.TabIndex = 33
        Me.ButtonDeleteFilterTwo.Text = "Delete"
        Me.ButtonDeleteFilterTwo.UseVisualStyleBackColor = True
        '
        'ButtonDeleteFilterThree
        '
        Me.ButtonDeleteFilterThree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteFilterThree.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonDeleteFilterThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteFilterThree.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonDeleteFilterThree.Location = New System.Drawing.Point(365, 280)
        Me.ButtonDeleteFilterThree.Name = "ButtonDeleteFilterThree"
        Me.ButtonDeleteFilterThree.Size = New System.Drawing.Size(80, 30)
        Me.ButtonDeleteFilterThree.TabIndex = 34
        Me.ButtonDeleteFilterThree.Text = "Delete"
        Me.ButtonDeleteFilterThree.UseVisualStyleBackColor = True
        '
        'LauncherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 629)
        Me.Controls.Add(Me.LootFilterSettingsPanel)
        Me.Controls.Add(Me.PanelLinks)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.LauncherBanner)
        Me.Controls.Add(Me.PanelPlay)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LauncherForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        Me.PanelPlay.ResumeLayout(False)
        Me.PanelPlay.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.GroupBoxLaunchFlags.ResumeLayout(False)
        Me.TableLayoutConfigOptions.ResumeLayout(False)
        Me.TableLayoutConfigOptions.PerformLayout()
        Me.GroupBoxEventLog.ResumeLayout(False)
        Me.GroupBoxLootFilter.ResumeLayout(False)
        Me.LootFilterSettingsPanel.ResumeLayout(False)
        Me.LootFilterSettingsPanel.PerformLayout()
        CType(Me.LauncherBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLinks.ResumeLayout(False)
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
    Friend WithEvents PanelPlay As Panel
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
    Friend WithEvents PanelLinks As Panel
    Friend WithEvents LootFilterButton As Button
    Friend WithEvents LootFilterSettingsPanel As Panel
    Friend WithEvents LootFilerSettingsCloseButton As Button
    Friend WithEvents FilterOneLabel As Label
    Friend WithEvents FilterThreeLabel As Label
    Friend WithEvents FilterTwoLabel As Label
    Friend WithEvents LabelLootFilterURLThree As Label
    Friend WithEvents TextBoxLootFilterURLThree As TextBox
    Friend WithEvents LabelLootFilterURLTwo As Label
    Friend WithEvents TextBoxLootFilterURLTwo As TextBox
    Friend WithEvents ButtonDeleteFilterTwo As Button
    Friend WithEvents ButtonDeleteFilterOne As Button
    Friend WithEvents ButtonDeleteFilterThree As Button
End Class
