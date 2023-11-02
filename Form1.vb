Public Class Form1
    Private Sub BackgroundPictureBox_Click(sender As Object, e As EventArgs) Handles BackgroundPictureBox.Click
        BackgroundPictureBox.BackgroundImage = New Bitmap(My.Resources.backgroundResource.phoneBackground, New Size(429, 759))
    End Sub

End Class
