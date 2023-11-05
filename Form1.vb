Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add phone background image as the background 
        BackgroundPictureBox.BackgroundImage = New Bitmap(My.Resources.backgroundResource.phoneBackground, New Size(486, 887))
    End Sub

End Class
