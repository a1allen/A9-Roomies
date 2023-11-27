Public Class Chore_item_inDay

    Public Event EditChoreButtonClick As EventHandler
    Public Event ExtendChoreButtonClick As EventHandler
    Public Event RequestVolunteerButtonClick As EventHandler
    Public Event updateChoreStatus As EventHandler
    Private thisChore As Chore

    Private Sub EditChoreButton_Click(sender As Object, e As EventArgs) Handles EditChoreButton.Click
        RaiseEvent EditChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub ExtendChoreButton_Click(sender As Object, e As EventArgs) Handles ExtendChoreButton.Click
        RaiseEvent ExtendChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub RequestVolunteerButton_Click(sender As Object, e As EventArgs) Handles RequestVolunteerButton.Click
        RaiseEvent RequestVolunteerButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub choreDone_CheckedChanged(sender As Object, e As EventArgs) Handles choreDone.CheckedChanged
        RaiseEvent updateChoreStatus(Me, EventArgs.Empty)

    End Sub

    Private Sub score_label_Click(sender As Object, e As EventArgs) Handles score_label.Click

    End Sub

    Private Sub AssignTo_Click(sender As Object, e As EventArgs) Handles AssignTo.Click

    End Sub

    Private Sub Chore_item_inDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AssignTo.Text = "Roommate 1" Then
            AssignTo.ForeColor = Color.FromArgb(209, 40, 85)
        ElseIf AssignTo.Text = "Roommate 2" Then
            AssignTo.ForeColor = Color.FromArgb(70, 153, 61)
        ElseIf AssignTo.Text = "Roommate 3" Then
            AssignTo.ForeColor = Color.FromArgb(50, 122, 140)
        ElseIf AssignTo.Text = "Roommate 4" Then
            AssignTo.ForeColor = Color.FromArgb(158, 102, 227)
        End If
    End Sub

    Public Property TypeOfChore() As String
        Get
            Return ChoreName.Text
        End Get
        Set(ByVal value As String)
            ChoreName.Text = value
        End Set
    End Property

    Public Property TheChore() As Chore
        Get
            Return thisChore
        End Get
        Set(ByVal value As Chore)
            thisChore = value
        End Set
    End Property

    Public Property EffortOfChore() As String
        Get
            Return score_label.Text
        End Get
        Set(ByVal value As String)
            If (value = "0") Then
                score_label.Text = "★"
            ElseIf (value = "1") Then
                score_label.Text = "★★"
            ElseIf (value = "2") Then
                score_label.Text = "★★★"
            ElseIf (value = "3") Then
                score_label.Text = "★★★★"
            ElseIf (value = "4") Then
                score_label.Text = "★★★★★"
            End If
        End Set
    End Property

    Public Property AssignedPerson() As String
        Get
            Return AssignTo.Text
        End Get
        Set(ByVal value As String)
            AssignTo.Text = value
            If AssignTo.Text = "Roommate 1" Then
                AssignTo.ForeColor = Color.FromArgb(209, 40, 85)
            ElseIf AssignTo.Text = "Roommate 2" Then
                AssignTo.ForeColor = Color.FromArgb(70, 153, 61)
            ElseIf AssignTo.Text = "Roommate 3" Then
                AssignTo.ForeColor = Color.FromArgb(50, 122, 140)
            ElseIf AssignTo.Text = "Roommate 4" Then
                AssignTo.ForeColor = Color.FromArgb(158, 102, 227)
            End If
        End Set
    End Property
End Class
