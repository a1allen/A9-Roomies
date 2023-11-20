Public Class EditChoreControl

    Public Event SubmitChoreEditsButtonClick As EventHandler
    Public Event DeleteChoreButtonClick As EventHandler
    Public Event CancelEditChoreButtonClick As EventHandler

    Private Sub SubmitChangesChoreButton_Click(sender As Object, e As EventArgs) Handles SubmitChangesChoreButton.Click
        RaiseEvent SubmitChoreEditsButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        RaiseEvent DeleteChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub ChoreBackButton_Click(sender As Object, e As EventArgs) Handles ChoreBackButton.Click
        RaiseEvent CancelEditChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub EditChoreControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditChoreDateTimePicker.MinDate = DateTime.Now.Date
    End Sub
End Class
