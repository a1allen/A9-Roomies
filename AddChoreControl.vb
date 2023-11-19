Public Class AddChoreControl

    Public Event AddChoreButtonClick As EventHandler
    Public Event CancelChoreButtonClick As EventHandler

    Private Sub AddChoreControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomChorePanel.Hide()
        AssignedToPanel.Hide()
        DatePanel.Hide()
        AddChoreButton.Enabled = False
    End Sub
    Private Sub ChoreTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChoreTypeComboBox.SelectedIndexChanged
        If ChoreTypeComboBox.Text = "Add Custom Chore" Then
            CustomChorePanel.Show()
        Else
            CustomChorePanel.Hide()
            AssignedToPanel.Show()
        End If
    End Sub

    Private Sub AddChoreButton_Click(sender As Object, e As EventArgs) Handles AddChoreButton.Click
        RaiseEvent AddChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RaiseEvent CancelChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub ChoreBackButton_Click(sender As Object, e As EventArgs) Handles ChoreBackButton.Click
        RaiseEvent CancelChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub NewChoreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NewChoreTextBox.TextChanged
        If NewChoreTextBox.Text <> "" Then
            AssignedToPanel.Show()
        End If

    End Sub

    Private Sub RoomateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomateComboBox.SelectedIndexChanged
        DatePanel.Show()
        AddChoreButton.Enabled = True
    End Sub
End Class
