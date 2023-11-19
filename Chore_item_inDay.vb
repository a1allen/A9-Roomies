Public Class Chore_item_inDay

    Public Event EditChoreButtonClick As EventHandler

    Private Sub EditChoreButton_Click(sender As Object, e As EventArgs) Handles EditChoreButton.Click
        RaiseEvent EditChoreButtonClick(Me, EventArgs.Empty)
    End Sub

End Class
