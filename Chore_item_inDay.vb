Public Class Chore_item_inDay

    Public Event EditChoreButtonClick As EventHandler
    Public Event ExtendChoreButtonClick As EventHandler
    Public Event RequestVolunteerButtonClick As EventHandler

    Private Sub EditChoreButton_Click(sender As Object, e As EventArgs) Handles EditChoreButton.Click
        RaiseEvent EditChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub ExtendChoreButton_Click(sender As Object, e As EventArgs) Handles ExtendChoreButton.Click
        RaiseEvent ExtendChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub RequestVolunteerButton_Click(sender As Object, e As EventArgs) Handles RequestVolunteerButton.Click
        RaiseEvent RequestVolunteerButtonClick(Me, EventArgs.Empty)
    End Sub


    Public Property TypeOfChore() As String
        Get
            Return ChoreName.Text
        End Get
        Set(ByVal value As String)
            ChoreName.Text = value
        End Set
    End Property

    Public Property AssignedPerson() As String
        Get
            Return AssignTo.Text
        End Get
        Set(ByVal value As String)
            AssignTo.Text = value
        End Set
    End Property
End Class
