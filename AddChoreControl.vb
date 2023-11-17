Public Class AddChoreControl

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

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Hide()

        'Show all other elements on the tab
        Form1.MonthLabel.Show()
        Form1.AddToCalendarButton.Show()
        Form1.DecorationPanel1.Show()
        Form1.DecorationPanel2.Show()
        Form1.DecorationPanel3.Show()
        Form1.SunLabel.Show()
        Form1.MonLabel.Show()
        Form1.TuesLabel.Show()
        Form1.WedLabel.Show()
        Form1.ThursLabel.Show()
        Form1.FriLabel.Show()
        Form1.SatLabel.Show()
        Form1.CalendarTableLayoutPanel.Show()
        Form1.Panel1.Show()
        Form1.Panel2.Show()
        Form1.PreviousButton.Show()
        Form1.NextButton.Show()
        Form1.RoomiesTitleLabel.Show()
        Form1.PictureBox1.Show()
        Form1.PictureBox2.Show()
        Form1.PictureBox3.Show()
        Form1.PictureBox4.Show()
        Form1.Roomie1PointsLabel.Show()
        Form1.Roomie2PointsLabel.Show()
        Form1.Roomie3PointsLabel.Show()
        Form1.Roomie4PointsLabel.Show()
    End Sub

    Private Sub AddChoreButton_Click(sender As Object, e As EventArgs) Handles AddChoreButton.Click

    End Sub
End Class
