Public Class AskExtendForm

    Public Property Result As Boolean = False
    Private Sub AskExtendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

    Private Sub YesExtendButton_Click(sender As Object, e As EventArgs) Handles YesExtendButton.Click
        Result = True
        Me.Close()
    End Sub

    Private Sub NoExtendButton_Click(sender As Object, e As EventArgs) Handles NoExtendButton.Click
        Result = False
        Me.Close()
    End Sub
End Class