﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Links = New System.Windows.Forms.ListBox()
        Me.DlNow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Links
        '
        Me.Links.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Links.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Links.FormattingEnabled = True
        Me.Links.Location = New System.Drawing.Point(13, 46)
        Me.Links.Name = "Links"
        Me.Links.Size = New System.Drawing.Size(325, 173)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A new update is available. Which download server do you choose?"
        '
        'LinkChooser
        '
        Me.AcceptButton = Me.DlNow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BackgroundImage = Global.Path_of_Diablo_Launcher.My.Resources.Resources.wallpaper
        Me.ClientSize = New System.Drawing.Size(350, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DlNow)
        Me.Controls.Add(Me.Links)
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
    Friend WithEvents Links As ListBox
    Friend WithEvents DlNow As Button
    Friend WithEvents Label1 As Label
End Class
