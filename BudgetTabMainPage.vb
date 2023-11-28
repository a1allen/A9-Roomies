Imports System.Net.Http.Headers

Public Class BudgetTabMainPage

    Dim budgetHistoryControl As Budget_HistoryControl
    Private Expenses As New Dictionary(Of String, Double) From {
        {"Roommate 1", 0.0},
        {"Roommate 2", -60.0},
        {"Roommate 3", 30.0},
        {"Roommate 4", 30.0}
    }
    Public roommateSummaries As New Dictionary(Of String, Double()) From {
        {"Roommate 1", {0.0, 0.0, 0.0, 0.0}},
        {"Roommate 2", {0.0, 0.0, -30.0, -30.0}},
        {"Roommate 3", {0.0, 30.0, 0.0, 0.0}},
        {"Roommate 4", {0.0, 30.0, 0.0, 0.0}}
    }

    Dim expenseControl As RecordExpenseControl
    Dim roommateOweButtons(4) As RoommateOweButton
    Dim roommateOwingsPage As RoommateOwingsList

    Private Sub BudgetTabMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        budgetHistoryControl = New Budget_HistoryControl
        Me.Controls.Add(budgetHistoryControl)
        budgetHistoryControl.Hide()
        roommateOweButtons = {RoommateOweButton1, RoommateOweButton2, RoommateOweButton3, RoommateOweButton4}

    End Sub


    Private Sub recordexpensebutton_click(sender As Object, e As EventArgs) Handles RecordExpenseButton.Click
        'remove budget page controls
        hideMainPageControls()


        'create instance
        expenseControl = New RecordExpenseControl()
        Me.Controls.Add(expenseControl)
        'expensecontrol.expensecheckbox.setitemchecked(0, true)
        expenseControl.Location = New Point(Me.Width / 2 - expenseControl.Width / 2, 0)

        AddHandler expenseControl.AddExpenseButtonClick, AddressOf addexpensebutton_click
        AddHandler expenseControl.CancelExpenseButtonClick, AddressOf CancelExpenseButton_Click
    End Sub

    Private Sub addexpensebutton_click(sender As Object, e As EventArgs)
        Dim amount As Double = Double.Parse(expenseControl.ExpenseAmountTextBox.Text)
        Dim payer_name As Integer = expenseControl.whoPaidCombo.SelectedIndex
        Dim label_name_record As String = expenseControl.label_of_record.Text
        'dim othertopay as integer()

        Dim checkBoxes() As CheckBox = {expenseControl.R1_check, expenseControl.R2_check, expenseControl.R3_check, expenseControl.R4_check}

        Dim i As Integer = 1
        Dim amount_for_each As Double
        Dim counting As Integer
        If expenseControl.R_check.Checked Then

            amount_for_each = amount / 4

            For Each roommate As KeyValuePair(Of String, Double) In Expenses
                If i <> payer_name Then
                    Expenses(roommate.Key) += amount_for_each

                    For x As Integer = 0 To 3
                        If (x + 1 <> i) Then
                            roommateSummaries(roommate.Key)(x) += amount_for_each
                            roommateSummaries(roommate.Key)(i - 1) += amount_for_each
                        End If

                    Next
                Else
                    Expenses(roommate.Key) -= (amount - amount_for_each)

                    For x As Integer = 0 To 3
                        If (x + 1 <> i) Then
                            roommateSummaries(roommate.Key)(x) -= amount_for_each
                        End If

                    Next
                End If
                i += 1

            Next

        Else
            counting = 0

            For Each checkBox As CheckBox In checkBoxes
                If checkBox.Checked Then
                    counting += 1
                End If

            Next

            If payer_name <> 0 Then
                counting += 1
            End If

            amount_for_each = amount / counting

            i = 1
            Dim j As New List(Of Integer)
            For Each checkBox As CheckBox In checkBoxes
                If checkBox.Checked And i <> payer_name Then
                    Expenses("Roommate " + i.ToString()) += amount_for_each

                    For x As Integer = 0 To 3
                        If (Not j.Contains(x + 1)) And (x + 1 <> i) Then
                            roommateSummaries("Roommate " + i.ToString())(x) += amount_for_each
                            roommateSummaries("Roommate " + i.ToString())(i - 1) += amount_for_each
                        End If
                    Next

                ElseIf i = payer_name Then
                    Expenses("Roommate " + i.ToString()) -= (amount - amount_for_each)

                    For x As Integer = 0 To 3
                        If (Not j.Contains(x + 1)) And (x + 1 <> i) Then
                            roommateSummaries("Roommate " + i.ToString())(x) -= amount_for_each
                        End If

                    Next
                End If

                If checkBox.Checked = False Then
                    j.Add(i)
                End If
                i += 1
            Next

        End If

        'update balances on main screen
        i = 0
        For Each roommate As KeyValuePair(Of String, Double) In Expenses
            roommateOweButtons(i).updateMoneyOwed(Math.Round(Expenses(roommate.Key), 2))
            i += 1

        Next

        'remove control
        Me.Controls.Remove(expenseControl)

        'show budget page controls
        showMainPageControls()
        Dim cD As Date = (DateTime.Now).Date
        Me.budgetHistoryControl.addExpense(cD, amount, payer_name, label_name_record)

    End Sub
    Private Sub CancelExpenseButton_Click(sender As Object, e As EventArgs)
        'Remove control
        Me.Controls.Remove(expenseControl)


        'Show budget page controls
        showMainPageControls()

    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click

        hideMainPageControls()
        budgetHistoryControl.Show()

        AddHandler budgetHistoryControl.BackButtonClick, AddressOf BackButton_Click
        Console.WriteLine("Hello")


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        budgetHistoryControl.Hide()
        showMainPageControls()
    End Sub
    Private Sub hideMainPageControls()
        BudgetTitle.Hide()
        BudgetPictureBox.Hide()
        RoommateOweButton1.Hide()
        RoommateOweButton2.Hide()
        RoommateOweButton3.Hide()
        RoommateOweButton4.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        RecordExpenseButton.Hide()
        SettleUpButton.Hide()
        HistoryButton.Hide()

    End Sub

    Private Sub showMainPageControls()
        BudgetTitle.Show()
        BudgetPictureBox.Show()
        RoommateOweButton1.Show()
        RoommateOweButton2.Show()
        RoommateOweButton3.Show()
        RoommateOweButton4.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        RecordExpenseButton.Show()
        SettleUpButton.Show()
        HistoryButton.Show()

    End Sub

    Private Sub RoommateOweButton1_RoommateOweButtonClick(sender As Object, e As EventArgs) Handles RoommateOweButton1.RoommateOweButtonClick, RoommateOweButton2.RoommateOweButtonClick, RoommateOweButton3.RoommateOweButtonClick, RoommateOweButton4.RoommateOweButtonClick
        hideMainPageControls()
        Dim cr As Integer
        If sender.Equals(RoommateOweButton1) Then
            cr = 1
        ElseIf sender.Equals(RoommateOweButton2) Then
            cr = 2
        ElseIf sender.Equals(RoommateOweButton3) Then
            cr = 3
        Else
            cr = 4
        End If
        roommateOwingsPage = New RoommateOwingsList(cr, Me)
        Me.Controls.Add(roommateOwingsPage)

        AddHandler roommateOwingsPage.ExitButtonClick, AddressOf exitButton_click

    End Sub

    Private Sub exitButton_click(sender As Object, e As EventArgs)
        Me.Controls.Remove(roommateOwingsPage)
        showMainPageControls()
    End Sub
End Class
