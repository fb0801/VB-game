<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.movestop1 = New System.Windows.Forms.Timer(Me.components)
        Me.Shooter = New System.Windows.Forms.PictureBox()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'movestop1
        '
        Me.movestop1.Enabled = True
        Me.movestop1.Interval = 1
        '
        'Shooter
        '
        Me.Shooter.Image = Global.game.My.Resources.Resources.Shooter
        Me.Shooter.Location = New System.Drawing.Point(500, 538)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(50, 50)
        Me.Shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Shooter.TabIndex = 32
        Me.Shooter.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1120, 591)
        Me.Controls.Add(Me.Shooter)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents movestop1 As System.Windows.Forms.Timer
    Friend WithEvents Shooter As System.Windows.Forms.PictureBox
End Class
