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

            BudgetItem_DateLabel.Text = itemDate

        End Set
    End Property

    Public Property ExpenseName As String
        Get
            Return itemName

        End Get
        Set(value As String)
            itemName = value

            BudgetItem_ExpenseNameLabel.Text = itemName

        End Set
    End Property

    Public Property NameOfRoomate As Integer
        Get
            Return roommateName

        End Get
        Set(value As Integer)
            roommateName = value

            BudgetItem_RoommateNamePaid.Text = "Roommate " + roommateName.ToString() + " Paid"

            BudgetItem_MoneyPaidLabel.Left = BudgetItem_RoommateNamePaid.Left + BudgetItem_RoommateNamePaid.Width - BudgetItem_MoneyPaidLabel.Width + 5



        End Set
    End Property

    Public Property Paid As Double
        Get
            Return moneyPaid

        End Get
        Set(value As Double)
            moneyPaid = value

            BudgetItem_MoneyPaidLabel.Text = "$" + moneyPaid.ToString()
            BudgetItem_MoneyPaidLabel.Left = BudgetItem_RoommateNamePaid.Left + BudgetItem_RoommateNamePaid.Width - BudgetItem_MoneyPaidLabel.Width + 5







        End Set
    End Property



    Private Sub BudgetItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateLabel_Click(sender As Object, e As EventArgs) Handles BudgetItem_DateLabel.Click

    End Sub

    Private Sub RoomateName_Click(sender As Object, e As EventArgs) Handles BudgetItem_RoommateNamePaid.Click

    End Sub
End Class
