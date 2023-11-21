Public Class Budget_HistoryControl
    Public Event CancelExpenseButtonClick As EventHandler
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RaiseEvent CancelExpenseButtonClick(Me, EventArgs.Empty)
    End Sub
End Class
