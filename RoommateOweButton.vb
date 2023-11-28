Public Class RoommateOweButton


    Private roommateName As Integer = 0
    Private moneyOwed As Double = 0
    Private roommateColor As Color

    Public Property NameOfRoommate As Integer
        Get
            Return roommateName

        End Get
        Set(value As Integer)
            roommateName = value

            If moneyOwed >= 0 Then
                Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Owes:"

            Else
                Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Lent:"

            End If

        End Set

    End Property

    Public Property MoneyToOwe As Double
        Get
            Return moneyOwed

        End Get
        Set(value As Double)
            moneyOwed = value

            If moneyOwed >= 0 Then
                Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Owes:"
                Me.RoommateNameMoney.Text = "$" + Math.Abs(moneyOwed).ToString()

            Else
                Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Lent:"
                Me.RoommateNameMoney.Text = "$" + Math.Abs(moneyOwed).ToString()

            End If

        End Set

    End Property

    Public Property ColorOfRoommate As Color
        Get
            Return roommateColor

        End Get
        Set(value As Color)
            roommateColor = value

            Me.RoommateNameOwes.ForeColor = roommateColor




        End Set

    End Property

    Private Sub RoommateNameMoney_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RoommateOweButton_MouseEnter(sender As Object, e As EventArgs) Handles RoommateNameMoney.MouseEnter, RoommateNameOwes.MouseEnter, MyBase.MouseEnter
        Me.BackColor = Color.Gainsboro

    End Sub

    Private Sub RoommateOweButton_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = Color.Transparent

    End Sub


    Private Sub simulateButtonClick()
        ' Change the background color temporarily
        Dim originalColor As Color = Me.BackColor
        Me.BackColor = Color.LightGray
        Me.Refresh() ' Force an immediate repaint

        ' Wait for a short duration (e.g., 200 milliseconds)
        System.Threading.Thread.Sleep(100)

        ' Restore the original background color
        Me.BackColor = originalColor
    End Sub

    Public Sub updateMoneyOwed(m As Double)
        moneyOwed = m
        If moneyOwed >= 0 Then
            Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Owes:"
            Me.RoommateNameMoney.Text = "$" + Math.Abs(moneyOwed).ToString()

        Else
            Me.RoommateNameOwes.Text = "Roommate " + roommateName.ToString() + " Lent:"
            Me.RoommateNameMoney.Text = "$" + Math.Abs(moneyOwed).ToString()

        End If
    End Sub

    Private Sub RoommateOweButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Event RoommateOweButtonClick As EventHandler
    Private Sub RoommateOweButton_Click(sender As Object, e As EventArgs) Handles RoommateNameMoney.Click, RoommateNameOwes.Click, MyBase.Click
        simulateButtonClick()
        RaiseEvent RoommateOweButtonClick(Me, EventArgs.Empty)
    End Sub
End Class
