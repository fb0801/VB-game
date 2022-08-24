Public Class game
#Region "variable"
    Dim lef As Boolean
    Dim rig As Boolean
    Dim moveaac As Integer = 1

    Dim ss As Integer = 1
    Dim bs As Integer = 6
    Dim bullet As Integer
    
    Dim shooterm As Integer
    Dim changedirection As Integer
#End Region
    Private Sub game_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' make shooter move left
        If e.KeyValue = Keys.Left Then
            lef = True
            Shooter.Left = Shooter.Left - 3
            'make shooter move right 
        End If
        If e.KeyValue = Keys.Right Then
            rig = True
            Shooter.Left = Shooter.Left + 3
        End If

        'make the spacebar shoot the bullet
        If e.KeyValue = Keys.Space And Bullet1.Visible = False Then
            ' Bullet1.Top = Shooter.Top
            'Bullet1.Left = Shooter.Left = Shooter.Width / 2 - Bullet1.Width / 2
            Bullet1.Visible = True
            Bullet1.Top -= bs
        End If
        If Bullet1.Top + Bullet1.Height < Me.ClientRectangle.Top Then
            Bullet1.Visible = False
        End If
    End Sub

    Private Sub moveshooter()
        If rig = True And Shooter.Left And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then

            '< Me.ClientRectangle.Width + = shooterm
            'Me.ClientRectangle.Width += shooterm
        End If


        If lef = True And Shooter.Left and Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left -= shooterm
        End If





    End Sub
#Region "timer"
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        moveshooter()
        firebullets()


    End Sub
#End Region

    Private Sub movecompstop(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Space Then
            Bullet1.Visible = False
        End If

    End Sub

    Public Sub New()
        InitializeComponent()
        createarray()
    End Sub
    Private Sub createarray()
       
    End Sub
    Private Sub movealiens()
        'make aliens move 
       
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        '2 timer to make aliens move
        movealiens()


    End Sub
    Private Sub firebullets()
        'to make the bullets move
        If Bullet1.Visible = True Then
            Bullet1.Top -= bs
        End If
        If Bullet1.Top + Bullet1.Height < Me.ClientRectangle.Top Then
            Bullet1.Visible = False
        End If
        If Bullet1.Top = 0 Then
            Bullet1.Top = Shooter.Top
        End If
    End Sub
    Private Sub loadsetting()
        'shooter speed
        ss = 3
        'bullet speed
        bs = 6
        Bullet1.Visible = False


    End Sub
    Private Sub checkshot()
    End Sub

End Class


