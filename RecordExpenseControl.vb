Public Class RecordExpenseControl

    Public Event AddExpenseButtonClick As EventHandler
    Public Event CancelExpenseButtonClick As EventHandler
    Dim checked As Boolean = False

    Private Sub AddExpenseButton_Click(sender As Object, e As EventArgs) Handles AddExpenseButton.Click
        RaiseEvent AddExpenseButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub BudgetExpenseBackButton_Click(sender As Object, e As EventArgs) Handles BudgetExpenseBackButton.Click
        RaiseEvent CancelExpenseButtonClick(Me, EventArgs.Empty)
    End Sub

End Class
