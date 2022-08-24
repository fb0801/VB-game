<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet1 = New System.Windows.Forms.PictureBox()
        Me.AAC10 = New System.Windows.Forms.PictureBox()
        Me.AAC11 = New System.Windows.Forms.PictureBox()
        Me.AAC12 = New System.Windows.Forms.PictureBox()
        Me.AAC13 = New System.Windows.Forms.PictureBox()
        Me.AAC14 = New System.Windows.Forms.PictureBox()
        Me.AAC15 = New System.Windows.Forms.PictureBox()
        Me.AAC16 = New System.Windows.Forms.PictureBox()
        Me.AAC17 = New System.Windows.Forms.PictureBox()
        Me.AAC18 = New System.Windows.Forms.PictureBox()
        Me.AAC9 = New System.Windows.Forms.PictureBox()
        Me.AAC5 = New System.Windows.Forms.PictureBox()
        Me.AAC8 = New System.Windows.Forms.PictureBox()
        Me.AAC7 = New System.Windows.Forms.PictureBox()
        Me.AAC6 = New System.Windows.Forms.PictureBox()
        Me.AAC4 = New System.Windows.Forms.PictureBox()
        Me.AAC3 = New System.Windows.Forms.PictureBox()
        Me.AAC2 = New System.Windows.Forms.PictureBox()
        Me.AAC1 = New System.Windows.Forms.PictureBox()
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Bullet3 = New System.Windows.Forms.PictureBox()
        Me.Bullet4 = New System.Windows.Forms.PictureBox()
        Me.Bullet5 = New System.Windows.Forms.PictureBox()
        Me.restartbullet = New System.Windows.Forms.PictureBox()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restartbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Bullet1
        '
        Me.Bullet1.Image = Global.game.My.Resources.Resources.Bullet
        Me.Bullet1.Location = New System.Drawing.Point(547, 540)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(10, 14)
        Me.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet1.TabIndex = 52
        Me.Bullet1.TabStop = False
        Me.Bullet1.Visible = False
        '
        'AAC10
        '
        Me.AAC10.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC10.Location = New System.Drawing.Point(526, 12)
        Me.AAC10.Name = "AAC10"
        Me.AAC10.Size = New System.Drawing.Size(50, 50)
        Me.AAC10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC10.TabIndex = 51
        Me.AAC10.TabStop = False
        '
        'AAC11
        '
        Me.AAC11.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC11.Location = New System.Drawing.Point(583, 12)
        Me.AAC11.Name = "AAC11"
        Me.AAC11.Size = New System.Drawing.Size(50, 50)
        Me.AAC11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC11.TabIndex = 50
        Me.AAC11.TabStop = False
        '
        'AAC12
        '
        Me.AAC12.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC12.Location = New System.Drawing.Point(639, 12)
        Me.AAC12.Name = "AAC12"
        Me.AAC12.Size = New System.Drawing.Size(50, 50)
        Me.AAC12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC12.TabIndex = 49
        Me.AAC12.TabStop = False
        '
        'AAC13
        '
        Me.AAC13.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC13.Location = New System.Drawing.Point(695, 12)
        Me.AAC13.Name = "AAC13"
        Me.AAC13.Size = New System.Drawing.Size(50, 50)
        Me.AAC13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC13.TabIndex = 48
        Me.AAC13.TabStop = False
        '
        'AAC14
        '
        Me.AAC14.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC14.Location = New System.Drawing.Point(751, 12)
        Me.AAC14.Name = "AAC14"
        Me.AAC14.Size = New System.Drawing.Size(50, 50)
        Me.AAC14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC14.TabIndex = 47
        Me.AAC14.TabStop = False
        '
        'AAC15
        '
        Me.AAC15.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC15.Location = New System.Drawing.Point(807, 12)
        Me.AAC15.Name = "AAC15"
        Me.AAC15.Size = New System.Drawing.Size(50, 50)
        Me.AAC15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC15.TabIndex = 46
        Me.AAC15.TabStop = False
        '
        'AAC16
        '
        Me.AAC16.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC16.Location = New System.Drawing.Point(863, 12)
        Me.AAC16.Name = "AAC16"
        Me.AAC16.Size = New System.Drawing.Size(50, 50)
        Me.AAC16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC16.TabIndex = 45
        Me.AAC16.TabStop = False
        '
        'AAC17
        '
        Me.AAC17.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC17.Location = New System.Drawing.Point(919, 12)
        Me.AAC17.Name = "AAC17"
        Me.AAC17.Size = New System.Drawing.Size(50, 50)
        Me.AAC17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC17.TabIndex = 44
        Me.AAC17.TabStop = False
        '
        'AAC18
        '
        Me.AAC18.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC18.Location = New System.Drawing.Point(919, 68)
        Me.AAC18.Name = "AAC18"
        Me.AAC18.Size = New System.Drawing.Size(50, 50)
        Me.AAC18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC18.TabIndex = 43
        Me.AAC18.TabStop = False
        '
        'AAC9
        '
        Me.AAC9.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC9.Location = New System.Drawing.Point(470, 12)
        Me.AAC9.Name = "AAC9"
        Me.AAC9.Size = New System.Drawing.Size(50, 50)
        Me.AAC9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC9.TabIndex = 42
        Me.AAC9.TabStop = False
        '
        'AAC5
        '
        Me.AAC5.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC5.Location = New System.Drawing.Point(246, 12)
        Me.AAC5.Name = "AAC5"
        Me.AAC5.Size = New System.Drawing.Size(50, 50)
        Me.AAC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC5.TabIndex = 41
        Me.AAC5.TabStop = False
        '
        'AAC8
        '
        Me.AAC8.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC8.Location = New System.Drawing.Point(414, 12)
        Me.AAC8.Name = "AAC8"
        Me.AAC8.Size = New System.Drawing.Size(50, 50)
        Me.AAC8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC8.TabIndex = 40
        Me.AAC8.TabStop = False
        '
        'AAC7
        '
        Me.AAC7.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC7.Location = New System.Drawing.Point(358, 12)
        Me.AAC7.Name = "AAC7"
        Me.AAC7.Size = New System.Drawing.Size(50, 50)
        Me.AAC7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC7.TabIndex = 39
        Me.AAC7.TabStop = False
        '
        'AAC6
        '
        Me.AAC6.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC6.Location = New System.Drawing.Point(302, 12)
        Me.AAC6.Name = "AAC6"
        Me.AAC6.Size = New System.Drawing.Size(50, 50)
        Me.AAC6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC6.TabIndex = 38
        Me.AAC6.TabStop = False
        '
        'AAC4
        '
        Me.AAC4.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC4.Location = New System.Drawing.Point(190, 12)
        Me.AAC4.Name = "AAC4"
        Me.AAC4.Size = New System.Drawing.Size(50, 50)
        Me.AAC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC4.TabIndex = 37
        Me.AAC4.TabStop = False
        '
        'AAC3
        '
        Me.AAC3.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC3.Location = New System.Drawing.Point(134, 12)
        Me.AAC3.Name = "AAC3"
        Me.AAC3.Size = New System.Drawing.Size(50, 50)
        Me.AAC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC3.TabIndex = 36
        Me.AAC3.TabStop = False
        '
        'AAC2
        '
        Me.AAC2.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC2.Location = New System.Drawing.Point(78, 12)
        Me.AAC2.Name = "AAC2"
        Me.AAC2.Size = New System.Drawing.Size(50, 50)
        Me.AAC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC2.TabIndex = 35
        Me.AAC2.TabStop = False
        '
        'AAC1
        '
        Me.AAC1.Image = Global.game.My.Resources.Resources.alien_aircraft
        Me.AAC1.Location = New System.Drawing.Point(22, 12)
        Me.AAC1.Name = "AAC1"
        Me.AAC1.Size = New System.Drawing.Size(50, 50)
        Me.AAC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AAC1.TabIndex = 34
        Me.AAC1.TabStop = False
        '
        'Shooter
        '
        Me.Shooter.Image = Global.game.My.Resources.Resources.Shooter
        Me.Shooter.Location = New System.Drawing.Point(526, 540)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(50, 50)
        Me.Shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Shooter.TabIndex = 33
        Me.Shooter.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.Image = Global.game.My.Resources.Resources.Bullet
        Me.Bullet2.Location = New System.Drawing.Point(547, 540)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(10, 14)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet2.TabIndex = 53
        Me.Bullet2.TabStop = False
        Me.Bullet2.Visible = False
        '
        'Bullet3
        '
        Me.Bullet3.Image = Global.game.My.Resources.Resources.Bullet
        Me.Bullet3.Location = New System.Drawing.Point(547, 540)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(10, 14)
        Me.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet3.TabIndex = 54
        Me.Bullet3.TabStop = False
        Me.Bullet3.Visible = False
        '
        'Bullet4
        '
        Me.Bullet4.Image = Global.game.My.Resources.Resources.Bullet
        Me.Bullet4.Location = New System.Drawing.Point(547, 540)
        Me.Bullet4.Name = "Bullet4"
        Me.Bullet4.Size = New System.Drawing.Size(10, 14)
        Me.Bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet4.TabIndex = 55
        Me.Bullet4.TabStop = False
        Me.Bullet4.Visible = False
        '
        'Bullet5
        '
        Me.Bullet5.Image = Global.game.My.Resources.Resources.Bullet
        Me.Bullet5.Location = New System.Drawing.Point(547, 540)
        Me.Bullet5.Name = "Bullet5"
        Me.Bullet5.Size = New System.Drawing.Size(10, 14)
        Me.Bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet5.TabIndex = 56
        Me.Bullet5.TabStop = False
        Me.Bullet5.Visible = False
        '
        'restartbullet
        '
        Me.restartbullet.Image = Global.game.My.Resources.Resources.Bullet
        Me.restartbullet.Location = New System.Drawing.Point(547, 540)
        Me.restartbullet.Name = "restartbullet"
        Me.restartbullet.Size = New System.Drawing.Size(10, 14)
        Me.restartbullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restartbullet.TabIndex = 57
        Me.restartbullet.TabStop = False
        Me.restartbullet.Visible = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1120, 591)
        Me.Controls.Add(Me.Shooter)
        Me.Controls.Add(Me.AAC10)
        Me.Controls.Add(Me.AAC11)
        Me.Controls.Add(Me.AAC12)
        Me.Controls.Add(Me.AAC13)
        Me.Controls.Add(Me.AAC14)
        Me.Controls.Add(Me.AAC15)
        Me.Controls.Add(Me.AAC16)
        Me.Controls.Add(Me.AAC17)
        Me.Controls.Add(Me.AAC18)
        Me.Controls.Add(Me.AAC9)
        Me.Controls.Add(Me.AAC5)
        Me.Controls.Add(Me.AAC8)
        Me.Controls.Add(Me.AAC7)
        Me.Controls.Add(Me.AAC6)
        Me.Controls.Add(Me.AAC4)
        Me.Controls.Add(Me.AAC3)
        Me.Controls.Add(Me.AAC2)
        Me.Controls.Add(Me.AAC1)
        Me.Controls.Add(Me.Bullet3)
        Me.Controls.Add(Me.Bullet2)
        Me.Controls.Add(Me.Bullet1)
        Me.Controls.Add(Me.restartbullet)
        Me.Controls.Add(Me.Bullet5)
        Me.Controls.Add(Me.Bullet4)
        Me.Name = "game"
        Me.Text = "Game"
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restartbullet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Shooter As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AAC1 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC2 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC3 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC4 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC6 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC7 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC8 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC5 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC9 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents AAC18 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC17 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC16 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC15 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC14 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC13 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC12 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC11 As System.Windows.Forms.PictureBox
    Friend WithEvents AAC10 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet2 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet3 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet4 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet5 As System.Windows.Forms.PictureBox
    Friend WithEvents restartbullet As System.Windows.Forms.PictureBox
End Class
