Public Class Form2
#Region "variable"
    Dim lef As Boolean
    Dim rig As Boolean
    Dim moveaac As Integer = 1
    Dim AAC As PictureBox
    Dim farhan As String
#End Region

#Region "key presses"

#End Region
    Private Sub movestop1_Tick(sender As System.Object, e As System.EventArgs) Handles movestop1.Tick
        ' make the shooter move left and right with the arrow keys

    End Sub


    Private Sub New()

        InitializeComponent()


    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)
        'Shooter.Left = Shooter.Left - 1 Then
        'else IF rig = True Then Shooter.Left + 1 
        'End If If lef = True Then
        'If Shooter.Left = Shooter.Left - 1 Then
        'If rig = True Then Shooter.Left(+1)
        'End If moveaac
    End Sub

    Private Sub Form2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Left Then Shooter.Left = True

        End


    End Sub
End Class