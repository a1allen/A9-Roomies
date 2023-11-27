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
        RoomateComboBox.Items.Add("Roommate 1")
        RoomateComboBox.Items.Add("Roommate 2")
        RoomateComboBox.Items.Add("Roommate 3")
        RoomateComboBox.Items.Add("Roommate 4")

        ' Set the DrawMode property to OwnerDrawFixed
        RoomateComboBox.DrawMode = DrawMode.OwnerDrawFixed
    End Sub
    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles RoomateComboBox.DrawItem
        If e.Index >= 0 Then
            ' Get the ComboBox
            'Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

            ' Get the item text
            Dim itemText As String = RoomateComboBox.GetItemText(RoomateComboBox.Items(e.Index))

            ' Set the default text color
            Dim textColor As Color = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Color.White, Color.Black)

            ' Set the background color based on the item
            Dim backgroundColor As Color
            Select Case itemText
                Case "Roommate 1"
                    backgroundColor = Color.FromArgb(209, 40, 85)
                Case "Roommate 2"
                    backgroundColor = Color.FromArgb(96, 240, 108)
                Case "Roommate 3"
                    backgroundColor = Color.FromArgb(99, 206, 224)
                Case "Roommate 4"
                    backgroundColor = Color.FromArgb(158, 102, 227)
                Case Else
                    backgroundColor = Color.White
            End Select

            ' Create a brush for the text color
            Dim textBrush As New SolidBrush(textColor)

            ' Create a brush for the background color
            Dim backgroundBrush As New SolidBrush(backgroundColor)

            ' Fill the background
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds)

            ' Draw the item text
            e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds)

            ' Clean up brushes
            textBrush.Dispose()
            backgroundBrush.Dispose()
        End If
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
