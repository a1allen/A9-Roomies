Imports System.Runtime.CompilerServices

Public Class BudgetItem
    Inherits UserControl

    Private itemDate As String = "Jan 01"
    Private itemName As String = "Expense Name"
    Private roommateName As Integer = 0
    Private moneyPaid As Double = 100
    Private moneyOwed As Double = 25

    Public Property DateofItem As String
        Get
            Return itemDate

        End Get
        Set(value As String)
            itemDate = value

            enterDate(itemDate)

        End Set
    End Property

    Public Property ExpenseName As String
        Get
            Return itemName

        End Get
        Set(value As String)
            itemName = value

            enterExpenseName(itemName)

        End Set
    End Property

    Public Property NameOfRoomate As Integer
        Get
            Return roommateName

        End Get
        Set(value As Integer)
            roommateName = value

            enterRoomate(roommateName)

        End Set
    End Property

    Public Property Paid As Double
        Get
            Return moneyPaid

        End Get
        Set(value As Double)
            moneyPaid = value

            enterPaid(moneyPaid)

        End Set
    End Property


    Public Sub enterRoomate(r As Integer)
        If r <= 0 Then
            BudgetItem_RoommateNamePaid.Text = "No one has paid: "
        Else
            BudgetItem_RoommateNamePaid.Text = "Roommate " + r.ToString() + " Paid"

        End If

        BudgetItem_MoneyPaidLabel.Left = BudgetItem_RoommateNamePaid.Left + BudgetItem_RoommateNamePaid.Width - BudgetItem_MoneyPaidLabel.Width + 5

        roommateName = r
    End Sub

    Public Sub enterPaid(p As Double)

        BudgetItem_MoneyPaidLabel.Text = "$" + moneyPaid.ToString()
        BudgetItem_MoneyPaidLabel.Left = BudgetItem_RoommateNamePaid.Left + BudgetItem_RoommateNamePaid.Width - BudgetItem_MoneyPaidLabel.Width + 5

        moneyPaid = p
    End Sub

    Public Sub enterDate(d As String)
        BudgetItem_DateLabel.Text = d
        itemDate = d
    End Sub

    Public Sub enterExpenseName(e As String)
        If e <> "" Then
            BudgetItem_ExpenseNameLabel.Text = e
        Else
            BudgetItem_ExpenseNameLabel.Text = "Unnamed Expense"
        End If
        itemName = e
    End Sub

End Class
