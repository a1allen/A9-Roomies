Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddChoreControl

    Public Event AddChoreButtonClick As EventHandler
    Public Event CancelChoreButtonClick As EventHandler

    Private Sub AddChoreControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomChorePanel.Hide()
        AssignedToPanel.Hide()
        EffortPanel.Hide()
        DatePanel.Hide()

        AddChoreButton.Enabled = False
    End Sub
    Private Sub ChoreTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChoreTypeComboBox.SelectedIndexChanged
        If ChoreTypeComboBox.SelectedIndex = 0 Then
            AssignedToPanel.Hide()
            DatePanel.Hide()
            CustomChorePanel.Show()
            EffortPanel.Hide()
            AddChoreButton.Enabled = False
        Else
            CustomChorePanel.Hide()
            AssignedToPanel.Show()
            DatePanel.Hide()
            EffortPanel.Hide()
            AddChoreButton.Enabled = False

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
        Else
            AssignedToPanel.Hide()
            DatePanel.Hide()
            EffortPanel.Hide()
            AddChoreButton.Enabled = False

        End If

    End Sub

    Private Sub RoomateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomateComboBox.SelectedIndexChanged
        EffortScore.SelectedIndex = 0
        EffortPanel.Show()
    End Sub



    Private Sub EffortScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EffortScore.SelectedIndexChanged
        DatePanel.Show()
        AddChoreButton.Enabled = True
    End Sub

    Private Sub EffortPanel_Paint(sender As Object, e As PaintEventArgs) Handles EffortPanel.Paint

    End Sub
End Class
