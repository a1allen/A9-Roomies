Public Class AddChoreControl

    Public Event AddChoreButtonClick As EventHandler
    Public Event CancelChoreButtonClick As EventHandler

    Private Sub AddChoreControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomChorePanel.Hide()
        RepeatComboBox.SelectedIndex = 0
    End Sub
    Private Sub ChoreTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChoreTypeComboBox.SelectedIndexChanged
        If ChoreTypeComboBox.Text = "Add Custom Chore" Then
            CustomChorePanel.Show()
        Else
            CustomChorePanel.Hide()
        End If
    End Sub

    Private Sub RepeatComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepeatComboBox.SelectedIndexChanged
        If RepeatComboBox.Text = "Yes" Then
            RepeatFrequencyComboBox.Show()
        Else
            RepeatFrequencyComboBox.Hide()
        End If
    End Sub

    Private Sub AddChoreButton_Click(sender As Object, e As EventArgs) Handles AddChoreButton.Click
        RaiseEvent AddChoreButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RaiseEvent CancelChoreButtonClick(Me, EventArgs.Empty)
    End Sub


End Class
