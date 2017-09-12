<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LinkChooser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinkChooser))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Links = New System.Windows.Forms.ListBox()
        Me.DlNow = New System.Windows.Forms.Button()
        Me.File = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Select the link where you want to download the file from ", "and press ""Download Now.""", "", "The download speed may vary between the different hosts."})
        Me.ListBox1.Location = New System.Drawing.Point(13, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(283, 52)
        Me.ListBox1.TabIndex = 0
        '
        'Links
        '
        Me.Links.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Links.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Links.FormattingEnabled = True
        Me.Links.Location = New System.Drawing.Point(13, 85)
        Me.Links.Name = "Links"
        Me.Links.Size = New System.Drawing.Size(280, 134)
        Me.Links.TabIndex = 1
        '
        'DlNow
        '
        Me.DlNow.Location = New System.Drawing.Point(13, 227)
        Me.DlNow.Name = "DlNow"
        Me.DlNow.Size = New System.Drawing.Size(94, 23)
        Me.DlNow.TabIndex = 2
        Me.DlNow.Text = "Download Now"
        Me.DlNow.UseVisualStyleBackColor = True
        '
        'File
        '
        Me.File.AutoSize = True
        Me.File.ForeColor = System.Drawing.Color.White
        Me.File.Location = New System.Drawing.Point(13, 72)
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(39, 13)
        Me.File.TabIndex = 3
        Me.File.Text = "Label1"
        '
        'LinkChooser
        '
        Me.AcceptButton = Me.DlNow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.File)
        Me.Controls.Add(Me.DlNow)
        Me.Controls.Add(Me.Links)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LinkChooser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Path of Diablo Launcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Links As ListBox
    Friend WithEvents DlNow As Button
    Friend WithEvents File As Label
End Class
