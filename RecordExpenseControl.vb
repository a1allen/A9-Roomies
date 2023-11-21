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
        whoPaidCombo.SelectedIndex = 0
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
