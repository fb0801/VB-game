Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        game.Show()
        'make the game appear
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
        'make the game close

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form3.Show()
        'open the help guide of the game
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        'open the high score page
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form4.Show()
        'open the settings page
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
