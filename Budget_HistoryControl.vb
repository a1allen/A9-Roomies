Public Class Budget_HistoryControl
    Public Event CancelExpenseButtonClick As EventHandler
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RaiseEvent CancelExpenseButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub BudgetItem1_Load(sender As Object, e As EventArgs) Handles BudgetItem1.Load

    End Sub

    Private Sub Budget_HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
