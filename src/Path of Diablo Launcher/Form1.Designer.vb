<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.podlauncherlocalv = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.downloadcfg = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.viewmorecfg = New System.Windows.Forms.Button()
        Me.resetcfg = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lootfilterurl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LogBox = New System.Windows.Forms.ListBox()
        Me.directcbox = New System.Windows.Forms.CheckBox()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.txtcbox = New System.Windows.Forms.CheckBox()
        Me.dfxChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.wChk = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Path_of_Diablo_Launcher.My.Resources.Resources.banner
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 113)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'playBtn
        '
        Me.playBtn.Enabled = False
        Me.playBtn.Location = New System.Drawing.Point(510, 496)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(169, 55)
        Me.playBtn.TabIndex = 1
        Me.playBtn.Text = "Checking for Update"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.directcbox)
        Me.GroupBox3.Controls.Add(Me.aspectChk)
        Me.GroupBox3.Controls.Add(Me.txtcbox)
        Me.GroupBox3.Controls.Add(Me.dfxChk)
        Me.GroupBox3.Controls.Add(Me.nsChk)
        Me.GroupBox3.Controls.Add(Me.skipChk)
        Me.GroupBox3.Controls.Add(Me.wChk)
        Me.GroupBox3.Location = New System.Drawing.Point(196, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 183)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Launch Flags"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(363, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(326, 400)
        Me.WebBrowser1.TabIndex = 9
        Me.WebBrowser1.Url = New System.Uri("http://pathofdiablo.com/news/index.htm", System.UriKind.Absolute)
        '
        'podlauncherlocalv
        '
        Me.podlauncherlocalv.AutoSize = True
        Me.podlauncherlocalv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.podlauncherlocalv.Location = New System.Drawing.Point(427, 517)
        Me.podlauncherlocalv.Name = "podlauncherlocalv"
        Me.podlauncherlocalv.Size = New System.Drawing.Size(19, 13)
        Me.podlauncherlocalv.TabIndex = 10
        Me.podlauncherlocalv.Text = "10"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Donate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Forums"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Wiki"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(24, 246)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Server List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Rules"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'downloadcfg
        '
        Me.downloadcfg.Location = New System.Drawing.Point(226, 16)
        Me.downloadcfg.Name = "downloadcfg"
        Me.downloadcfg.Size = New System.Drawing.Size(94, 25)
        Me.downloadcfg.TabIndex = 21
        Me.downloadcfg.Text = "Download Filter"
        Me.downloadcfg.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.viewmorecfg)
        Me.GroupBox5.Controls.Add(Me.resetcfg)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lootfilterurl)
        Me.GroupBox5.Controls.Add(Me.downloadcfg)
        Me.GroupBox5.Location = New System.Drawing.Point(363, 406)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(326, 80)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loot Filter"
        '
        'viewmorecfg
        '
        Me.viewmorecfg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.viewmorecfg.Location = New System.Drawing.Point(176, 51)
        Me.viewmorecfg.Name = "viewmorecfg"
        Me.viewmorecfg.Size = New System.Drawing.Size(140, 23)
        Me.viewmorecfg.TabIndex = 25
        Me.viewmorecfg.Text = "Browse Filter Library"
        Me.viewmorecfg.UseVisualStyleBackColor = True
        '
        'resetcfg
        '
        Me.resetcfg.Location = New System.Drawing.Point(9, 51)
        Me.resetcfg.Name = "resetcfg"
        Me.resetcfg.Size = New System.Drawing.Size(140, 23)
        Me.resetcfg.TabIndex = 24
        Me.resetcfg.Text = "Reset to Default"
        Me.resetcfg.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "URL:"
        '
        'lootfilterurl
        '
        Me.lootfilterurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lootfilterurl.Location = New System.Drawing.Point(38, 19)
        Me.lootfilterurl.Name = "lootfilterurl"
        Me.lootfilterurl.Size = New System.Drawing.Size(182, 18)
        Me.lootfilterurl.TabIndex = 22
        Me.lootfilterurl.Text = "example http://pathofdiablo.com/item.filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 517)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "podL"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LogBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 446)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Log"
        '
        'LogBox
        '
        Me.LogBox.BackColor = System.Drawing.SystemColors.Control
        Me.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.HorizontalScrollbar = True
        Me.LogBox.Location = New System.Drawing.Point(6, 15)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(329, 78)
        Me.LogBox.TabIndex = 0
        '
        'directcbox
        '
        Me.directcbox.AutoSize = True
        Me.directcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxDirect
        Me.directcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxDirect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.directcbox.Enabled = False
        Me.directcbox.Location = New System.Drawing.Point(6, 138)
        Me.directcbox.Name = "directcbox"
        Me.directcbox.Size = New System.Drawing.Size(55, 17)
        Me.directcbox.TabIndex = 6
        Me.directcbox.Text = "-direct"
        Me.directcbox.UseVisualStyleBackColor = True
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNoFixAspect
        Me.aspectChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNoFixAspect", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.aspectChk.Location = New System.Drawing.Point(6, 115)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(83, 17)
        Me.aspectChk.TabIndex = 4
        Me.aspectChk.Text = "-nofixaspect"
        Me.aspectChk.UseVisualStyleBackColor = True
        '
        'txtcbox
        '
        Me.txtcbox.AutoSize = True
        Me.txtcbox.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxTxt
        Me.txtcbox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxTxt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtcbox.Enabled = False
        Me.txtcbox.Location = New System.Drawing.Point(6, 161)
        Me.txtcbox.Name = "txtcbox"
        Me.txtcbox.Size = New System.Drawing.Size(40, 17)
        Me.txtcbox.TabIndex = 7
        Me.txtcbox.Text = "-txt"
        Me.txtcbox.UseVisualStyleBackColor = True
        '
        'dfxChk
        '
        Me.dfxChk.AutoSize = True
        Me.dfxChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkbox3dfx
        Me.dfxChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkbox3dfx", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dfxChk.Location = New System.Drawing.Point(6, 91)
        Me.dfxChk.Name = "dfxChk"
        Me.dfxChk.Size = New System.Drawing.Size(143, 17)
        Me.dfxChk.TabIndex = 3
        Me.dfxChk.Text = "-3dfx (glide wrapper only)"
        Me.dfxChk.UseVisualStyleBackColor = True
        '
        'nsChk
        '
        Me.nsChk.AutoSize = True
        Me.nsChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxNs
        Me.nsChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxNs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nsChk.Location = New System.Drawing.Point(6, 67)
        Me.nsChk.Name = "nsChk"
        Me.nsChk.Size = New System.Drawing.Size(93, 17)
        Me.nsChk.TabIndex = 2
        Me.nsChk.Text = "-ns (no sound)"
        Me.nsChk.UseVisualStyleBackColor = True
        '
        'skipChk
        '
        Me.skipChk.AutoSize = True
        Me.skipChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxSkipToBnet
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.skipChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxSkipToBnet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.skipChk.Location = New System.Drawing.Point(6, 43)
        Me.skipChk.Name = "skipChk"
        Me.skipChk.Size = New System.Drawing.Size(78, 17)
        Me.skipChk.TabIndex = 1
        Me.skipChk.Text = "-skiptobnet"
        Me.skipChk.UseVisualStyleBackColor = True
        '
        'wChk
        '
        Me.wChk.AutoSize = True
        Me.wChk.Checked = Global.Path_of_Diablo_Launcher.My.MySettings.Default.chkboxW
        Me.wChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wChk.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Path_of_Diablo_Launcher.My.MySettings.Default, "chkboxW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.wChk.Location = New System.Drawing.Point(6, 19)
        Me.wChk.Name = "wChk"
        Me.wChk.Size = New System.Drawing.Size(111, 17)
        Me.wChk.TabIndex = 0
        Me.wChk.Text = "-w (window mode)"
        Me.wChk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 558)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.podlauncherlocalv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents playBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents aspectChk As System.Windows.Forms.CheckBox
    Friend WithEvents dfxChk As System.Windows.Forms.CheckBox
    Friend WithEvents nsChk As System.Windows.Forms.CheckBox
    Friend WithEvents txtChk As System.Windows.Forms.CheckBox
    Friend WithEvents txtcbox As System.Windows.Forms.CheckBox
    Friend WithEvents directcbox As System.Windows.Forms.CheckBox
    Friend WithEvents directChk As System.Windows.Forms.CheckBox
    Friend WithEvents skipChk As System.Windows.Forms.CheckBox
    Friend WithEvents wChk As System.Windows.Forms.CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents podlauncherlocalv As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents downloadcfg As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents viewmorecfg As Button
    Friend WithEvents resetcfg As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lootfilterurl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LogBox As ListBox
End Class
