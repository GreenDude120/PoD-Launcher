<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateD2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateD2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updated2Btn = New System.Windows.Forms.Button()
        Me.updated2Bar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diablo II Game.exe version is not 1.13c or 1.13d."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You must update Diablo II to play on the Path of Diablo server."
        '
        'updated2Btn
        '
        Me.updated2Btn.Location = New System.Drawing.Point(15, 68)
        Me.updated2Btn.Name = "updated2Btn"
        Me.updated2Btn.Size = New System.Drawing.Size(124, 27)
        Me.updated2Btn.TabIndex = 2
        Me.updated2Btn.Text = "Update"
        Me.updated2Btn.UseVisualStyleBackColor = True
        '
        'updated2Bar
        '
        Me.updated2Bar.Location = New System.Drawing.Point(146, 68)
        Me.updated2Bar.Name = "updated2Bar"
        Me.updated2Bar.Size = New System.Drawing.Size(167, 27)
        Me.updated2Bar.TabIndex = 3
        '
        'UpdateD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 104)
        Me.Controls.Add(Me.updated2Bar)
        Me.Controls.Add(Me.updated2Btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateD2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diablo2 Client Update"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents updated2Btn As System.Windows.Forms.Button
    Friend WithEvents updated2Bar As System.Windows.Forms.ProgressBar
End Class
