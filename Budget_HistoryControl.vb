Public Class Budget_HistoryControl

    Private Months As New Dictionary(Of Integer, String) From {
        {1, "January"},
        {2, "Febuary"},
        {3, "March"},
        {4, "April"},
        {5, "May"},
        {6, "June"},
        {7, "July"},
        {8, "August"},
        {9, "September"},
        {10, "October"},
        {11, "November"},
        {12, "December"}
    }

    Private currMax As Integer = 11
    Private budgetItemList As New List(Of BudgetItem)
    Private monthsLabelList As New List(Of Label)

    Public Event BackButtonClick As EventHandler
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RaiseEvent BackButtonClick(Me, EventArgs.Empty)
    End Sub


    Public Sub addExpense(d As Date, e As Double, r As Integer, c As String)

        Dim labelDate As String = getDate(d, True)
        If monthsLabelList(0).Text <> labelDate Then
            addNewMonthLabel(d, labelDate)
        End If
        moveHistoryDown(48)

        Dim currDate As String = getDate(d, False)

        Dim newBudgetItem As New BudgetItem()
        Me.Controls.Add(newBudgetItem)
        newBudgetItem.Location = New Point(-2, 103)

        newBudgetItem.enterDate(currDate)
        newBudgetItem.enterPaid(e)
        newBudgetItem.enterRoomate(r)
        newBudgetItem.enterExpenseName(c)
        budgetItemList.Insert(0, newBudgetItem)

    End Sub

    Private Sub Budget_HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        budgetItemList.AddRange(
            {BudgetItem1, BudgetItem2, BudgetItem3, BudgetItem4, BudgetItem5,
             BudgetItem6, BudgetItem7, BudgetItem8, BudgetItem9, BudgetItem10,
             BudgetItem11, BudgetItem12, BudgetItem13, BudgetItem14, BudgetItem15,
             BudgetItem16, BudgetItem17, BudgetItem18, BudgetItem19, BudgetItem20,
             BudgetItem21, BudgetItem22, BudgetItem23, BudgetItem24, BudgetItem25,
             BudgetItem26, BudgetItem27, BudgetItem28}
        )

        monthsLabelList.AddRange(
            {Budget_NovTabLabel, Budget_OctTabLabel, Budget_SepTabLabel, Budget_AugTabLabel,
             Budget_JulTabLabel, Budget_JunTabLabel, Budget_MayTabLabel, Budget_AprTabControl,
             Budget_MarTabLabel, Budget_FebTabLabel, Budget_JanTabLabel}
        )


    End Sub

    Private Sub moveHistoryDown(s As Integer)

        For Each budItem As BudgetItem In budgetItemList
            budItem.Location = New Point(budItem.Left, budItem.Top + s)

        Next

        Dim i As Integer = 0
        For Each monthItem As Label In monthsLabelList
            If i <> 0 Then
                monthItem.Location = New Point(monthItem.Left, monthItem.Top + s)
            End If
            i += 1

        Next
    End Sub

    Private Function getDate(d As Date, l As Boolean) As String
        Dim firstPart As String
        Dim secondPart As String


        If l Then
            firstPart = Months(d.Month)
            secondPart = d.Year.ToString()
        Else
            firstPart = Months(d.Month).Substring(0, 3)
            secondPart = d.Day.ToString()

        End If

        Return firstPart + " " + secondPart

    End Function

    Private Sub addNewMonthLabel(d As Date, s As String)


        Dim newMonthYearLabel As New Label
        Me.Controls.Add(newMonthYearLabel)
        newMonthYearLabel.BackColor = Color.Silver
        newMonthYearLabel.Location = New Point(-2, 73)
        newMonthYearLabel.MinimumSize = New Size(350, 20)
        newMonthYearLabel.Size = New Size(407, 26)


        newMonthYearLabel.Text = s
        monthsLabelList.Insert(0, newMonthYearLabel)
        moveHistoryDown(15)

    End Sub

    Private Sub BudgetItem25_Load(sender As Object, e As EventArgs) Handles BudgetItem25.Load

    End Sub

    Private Sub BudgetItem27_Load(sender As Object, e As EventArgs) Handles BudgetItem27.Load
    End Sub

    Private Sub BudgetItem26_Load(sender As Object, e As EventArgs) Handles BudgetItem26.Load
    End Sub

    Private Sub BudgetItem28_Load(sender As Object, e As EventArgs) Handles BudgetItem28.Load
    End Sub
End Class
