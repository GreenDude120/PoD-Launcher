<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.patchPrgBr = New System.Windows.Forms.ProgressBar()
        Me.localcrcTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.servercrcTxt = New System.Windows.Forms.TextBox()
        Me.playBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.runasChk = New System.Windows.Forms.CheckBox()
        Me.aspectChk = New System.Windows.Forms.CheckBox()
        Me.dfxChk = New System.Windows.Forms.CheckBox()
        Me.nsChk = New System.Windows.Forms.CheckBox()
        Me.skipChk = New System.Windows.Forms.CheckBox()
        Me.wChk = New System.Windows.Forms.CheckBox()
        Me.setgatewayBtn = New System.Windows.Forms.Button()
        Me.setgateway2Btn = New System.Windows.Forms.Button()
        Me.DEP = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.patchPrgBr)
        Me.GroupBox1.Controls.Add(Me.localcrcTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Local Version CRC"
        '
        'patchPrgBr
        '
        Me.patchPrgBr.Location = New System.Drawing.Point(12, 24)
        Me.patchPrgBr.Name = "patchPrgBr"
        Me.patchPrgBr.Size = New System.Drawing.Size(140, 20)
        Me.patchPrgBr.TabIndex = 2
        Me.patchPrgBr.Visible = False
        '
        'localcrcTxt
        '
        Me.localcrcTxt.Location = New System.Drawing.Point(12, 24)
        Me.localcrcTxt.Name = "localcrcTxt"
        Me.localcrcTxt.ReadOnly = True
        Me.localcrcTxt.Size = New System.Drawing.Size(140, 20)
        Me.localcrcTxt.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.servercrcTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 60)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Server Version CRC"
        '
        'servercrcTxt
        '
        Me.servercrcTxt.Location = New System.Drawing.Point(15, 24)
        Me.servercrcTxt.Name = "servercrcTxt"
        Me.servercrcTxt.ReadOnly = True
        Me.servercrcTxt.Size = New System.Drawing.Size(140, 20)
        Me.servercrcTxt.TabIndex = 3
        Me.servercrcTxt.Text = "Checking..."
        '
        'playBtn
        '
        Me.playBtn.Enabled = False
        Me.playBtn.Location = New System.Drawing.Point(12, 311)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(164, 75)
        Me.playBtn.TabIndex = 1
        Me.playBtn.Text = "Checking for Update"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.runasChk)
        Me.GroupBox3.Controls.Add(Me.aspectChk)
        Me.GroupBox3.Controls.Add(Me.dfxChk)
        Me.GroupBox3.Controls.Add(Me.nsChk)
        Me.GroupBox3.Controls.Add(Me.skipChk)
        Me.GroupBox3.Controls.Add(Me.wChk)
        Me.GroupBox3.Location = New System.Drawing.Point(182, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 159)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Launch Flags"
        '
        'runasChk
        '
        Me.runasChk.AutoSize = True
        Me.runasChk.Checked = True
        Me.runasChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.runasChk.Location = New System.Drawing.Point(6, 136)
        Me.runasChk.Name = "runasChk"
        Me.runasChk.Size = New System.Drawing.Size(111, 17)
        Me.runasChk.TabIndex = 5
        Me.runasChk.Text = "Run D2 as admin."
        Me.runasChk.UseVisualStyleBackColor = True
        '
        'aspectChk
        '
        Me.aspectChk.AutoSize = True
        Me.aspectChk.Location = New System.Drawing.Point(6, 115)
        Me.aspectChk.Name = "aspectChk"
        Me.aspectChk.Size = New System.Drawing.Size(83, 17)
        Me.aspectChk.TabIndex = 4
        Me.aspectChk.Text = "-nofixaspect"
        Me.aspectChk.UseVisualStyleBackColor = True
        '
        'dfxChk
        '
        Me.dfxChk.AutoSize = True
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
        Me.skipChk.Checked = True
        Me.skipChk.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.wChk.Checked = True
        Me.wChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wChk.Location = New System.Drawing.Point(6, 19)
        Me.wChk.Name = "wChk"
        Me.wChk.Size = New System.Drawing.Size(111, 17)
        Me.wChk.TabIndex = 0
        Me.wChk.Text = "-w (window mode)"
        Me.wChk.UseVisualStyleBackColor = True
        '
        'setgatewayBtn
        '
        Me.setgatewayBtn.Enabled = False
        Me.setgatewayBtn.Location = New System.Drawing.Point(12, 190)
        Me.setgatewayBtn.Name = "setgatewayBtn"
        Me.setgatewayBtn.Size = New System.Drawing.Size(164, 55)
        Me.setgatewayBtn.TabIndex = 5
        Me.setgatewayBtn.Text = "Gateway Already Set"
        Me.setgatewayBtn.UseVisualStyleBackColor = True
        '
        'setgateway2Btn
        '
        Me.setgateway2Btn.Enabled = False
        Me.setgateway2Btn.Location = New System.Drawing.Point(12, 251)
        Me.setgateway2Btn.Name = "setgateway2Btn"
        Me.setgateway2Btn.Size = New System.Drawing.Size(164, 54)
        Me.setgateway2Btn.TabIndex = 6
        Me.setgateway2Btn.Text = "Gateway Already Set"
        Me.setgateway2Btn.UseVisualStyleBackColor = True
        '
        'DEP
        '
        Me.DEP.Location = New System.Drawing.Point(182, 350)
        Me.DEP.Name = "DEP"
        Me.DEP.Size = New System.Drawing.Size(75, 23)
        Me.DEP.TabIndex = 7
        Me.DEP.Text = "DEP"
        Me.DEP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 393)
        Me.Controls.Add(Me.DEP)
        Me.Controls.Add(Me.setgateway2Btn)
        Me.Controls.Add(Me.setgatewayBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path of Diablo Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents localcrcTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents servercrcTxt As System.Windows.Forms.TextBox
    Friend WithEvents playBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents aspectChk As System.Windows.Forms.CheckBox
    Friend WithEvents dfxChk As System.Windows.Forms.CheckBox
    Friend WithEvents nsChk As System.Windows.Forms.CheckBox
    Friend WithEvents skipChk As System.Windows.Forms.CheckBox
    Friend WithEvents wChk As System.Windows.Forms.CheckBox
    Friend WithEvents setgatewayBtn As System.Windows.Forms.Button
    Friend WithEvents patchPrgBr As System.Windows.Forms.ProgressBar
    Friend WithEvents runasChk As System.Windows.Forms.CheckBox
    Friend WithEvents setgateway2Btn As System.Windows.Forms.Button
    Friend WithEvents DEP As Button
End Class
