Public Class RecordExpenseControl

    Public Event AddExpenseButtonClick As EventHandler
    Public Event CancelExpenseButtonClick As EventHandler
    Dim checked As Boolean = False

    Private Sub AddExpenseButton_Click(sender As Object, e As EventArgs) Handles AddExpenseButton.Click
        RaiseEvent AddExpenseButtonClick(Me, EventArgs.Empty)

    End Sub

    Private Sub BudgetExpenseBackButton_Click(sender As Object, e As EventArgs) Handles BudgetExpenseBackButton.Click
        RaiseEvent CancelExpenseButtonClick(Me, EventArgs.Empty)
    End Sub


    Private Sub RecordExpenseControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ExpenseCheckBox.SelectionMode = SelectionMode.MultiSimple
        AddExpenseButton.Enabled = False
        R1_check.Visible = False
        R_check.Visible = False
        R2_check.Visible = False
        R3_check.Visible = False
        R4_check.Visible = False
        Label1.Visible = False
        R_check.Checked = True
        AssignExpenseToTitleLabel.Visible = False
        whoPaidCombo.Visible = False
        whoPaidLabel.Visible = False
        whoPaidCombo.Items.Add("No One Yet")
        whoPaidCombo.Items.Add("Roommate 1")
        whoPaidCombo.Items.Add("Roommate 2")
        whoPaidCombo.Items.Add("Roommate 3")
        whoPaidCombo.Items.Add("Roommate 4")
        whoPaidCombo.SelectedIndex = 0
        R1_check.ForeColor = Color.FromArgb(209, 40, 85)
        R2_check.ForeColor = Color.FromArgb(70, 153, 61)
        R3_check.ForeColor = Color.FromArgb(50, 122, 140)
        R4_check.ForeColor = Color.FromArgb(158, 102, 227)


        ' Set the DrawMode property to OwnerDrawFixed
        whoPaidCombo.DrawMode = DrawMode.OwnerDrawFixed
    End Sub
    Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles whoPaidCombo.DrawItem
        If e.Index >= 0 Then
            ' Get the ComboBox
            'Dim comboBox As ComboBox = DirectCast(sender, ComboBox)

            ' Get the item text
            Dim itemText As String = whoPaidCombo.GetItemText(whoPaidCombo.Items(e.Index))

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
                    backgroundColor = Color.LightGray
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
    Private Sub ExpenseAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles ExpenseAmountTextBox.TextChanged
        If ExpenseAmountTextBox.Text <> "" Then
            whoPaidCombo.Visible = True
            whoPaidLabel.Visible = True
            R1_check.Visible = True
            R_check.Visible = True
            R2_check.Visible = True
            R3_check.Visible = True
            Label1.Visible = True

            R4_check.Visible = True
            AssignExpenseToTitleLabel.Visible = True
            AddExpenseButton.Enabled = True

        Else
            whoPaidCombo.Visible = False
            whoPaidLabel.Visible = False
            'ExpenseCheckBox.Visible = False
            R1_check.Visible = False
            R_check.Visible = False
            R2_check.Visible = False
            R3_check.Visible = False
            Label1.Visible = False

            R4_check.Visible = False
            AssignExpenseToTitleLabel.Visible = False
            AddExpenseButton.Enabled = False

        End If

        'whoPaidCombo.SelectedIndex = 0
    End Sub

    Private Sub whoPaidCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles whoPaidCombo.SelectedIndexChanged
        If whoPaidCombo.SelectedIndex = 1 Then
            R1_check.Enabled = False
            R2_check.Enabled = True
            R3_check.Enabled = True
            R4_check.Enabled = True

        ElseIf whoPaidCombo.SelectedIndex = 2 Then
            R2_check.Enabled = False
            R1_check.Enabled = True
            R3_check.Enabled = True
            R4_check.Enabled = True
        ElseIf whoPaidCombo.SelectedIndex = 3 Then
            R3_check.Enabled = False
            R1_check.Enabled = True
            R2_check.Enabled = True
            R4_check.Enabled = True
        ElseIf whoPaidCombo.SelectedIndex = 4 Then
            R4_check.Enabled = False
            R1_check.Enabled = True
            R2_check.Enabled = True
            R3_check.Enabled = True
        ElseIf whoPaidCombo.SelectedIndex = 0 Then
            R4_check.Enabled = True
            R1_check.Enabled = True
            R2_check.Enabled = True
            R3_check.Enabled = True
        End If
    End Sub

    Private Sub R_check_CheckedChanged(sender As Object, e As EventArgs) Handles R_check.CheckedChanged
        If R_check.Checked Then
            R1_check.Checked = False
            R2_check.Checked = False
            R3_check.Checked = False
            R4_check.Checked = False
        End If
    End Sub

    Private Sub R2_check_CheckedChanged(sender As Object, e As EventArgs) Handles R2_check.CheckedChanged
        If R2_check.Checked Then
            R_check.Checked = False
        End If
    End Sub
    Private Sub R3_check_CheckedChanged(sender As Object, e As EventArgs) Handles R3_check.CheckedChanged
        If R3_check.Checked Then
            R_check.Checked = False
        End If
    End Sub
    Private Sub R1_check_CheckedChanged(sender As Object, e As EventArgs) Handles R1_check.CheckedChanged
        If R1_check.Checked Then
            R_check.Checked = False
        End If
    End Sub
    Private Sub R4_check_CheckedChanged(sender As Object, e As EventArgs) Handles R4_check.CheckedChanged
        If R4_check.Checked Then
            R_check.Checked = False
        End If
    End Sub
End Class
