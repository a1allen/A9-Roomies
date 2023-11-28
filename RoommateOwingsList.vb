Public Class RoommateOwingsList

    Public roommateSummaries As Dictionary(Of String, Double())
    Public k As String
    Public currRom As Integer
    Public RoommateOwesArray As Label()
    Public RoommateMoneyArray As Label()
    Public Sub New(currRoommate As Integer, budgetPage As BudgetTabMainPage)

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        k = "Roommate " + currRoommate.ToString()
        MainRoommateName.Text = "Roommate " + currRoommate.ToString()
        roommateSummaries = New Dictionary(Of String, Double())(budgetPage.roommateSummaries)
        TotalOwed.Text = roommateSummaries(k)(currRoommate - 1).ToString()
        currRom = currRoommate
        RoommateOwesArray = {OtherRoommateLabel1, OtherRoommateLabel2, OtherRoommateLabel3}
        RoommateMoneyArray = {OtherRoommateMoney1, OtherRoommateMoney2, OtherRoommateMoney3}
        getOwed()
        getLent()
        getOtherRoomates()

    End Sub

    Public Event ExitButtonClick As EventHandler
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        RaiseEvent ExitButtonClick(Me, EventArgs.Empty)
    End Sub

    Private Sub getOtherRoomates()
        Dim roommateIndex As Integer = 0
        For x As Integer = 0 To 3
            If (currRom - 1) <> x Then
                If roommateSummaries(k)(x) > 0 Then
                    RoommateOwesArray(roommateIndex).Text = "Roommate " + (x + 1).ToString + " Lent You: "
                    RoommateMoneyArray(roommateIndex).Text = "$" + Math.Abs(Math.Round(roommateSummaries(k)(x), 2)).ToString()
                    roommateIndex += 1

                Else
                    RoommateOwesArray(roommateIndex).Text = "Roommate " + (x + 1).ToString + " Owes You: "
                    RoommateMoneyArray(roommateIndex).Text = "$" + Math.Abs(Math.Round(roommateSummaries(k)(x), 2)).ToString()
                    roommateIndex += 1

                End If
            End If
        Next
    End Sub

    Private Sub getOwed()
        Dim tempowed As Double = 0
        For Each roommate As KeyValuePair(Of String, Double()) In roommateSummaries
            If roommate.Key = k Then
                For x As Integer = 0 To 3
                    If x <> (currRom - 1) And (roommateSummaries(roommate.Key)(x) > 0) Then
                        tempowed += roommateSummaries(roommate.Key)(x)

                    End If
                Next
            End If
        Next

        TotalOwed.Text = "$" + Math.Abs(Math.Round(tempowed, 2)).ToString
    End Sub

    Private Sub getLent()
        Dim templent As Double = 0
        For Each roommate As KeyValuePair(Of String, Double()) In roommateSummaries
            If roommate.Key = k Then
                For x As Integer = 0 To 3
                    If x <> (currRom - 1) And (roommateSummaries(roommate.Key)(x) < 0) Then
                        templent += roommateSummaries(roommate.Key)(x)

                    End If
                Next
            End If
        Next

        TotalLent.Text = "$" + Math.Abs(Math.Round(templent, 2)).ToString
    End Sub
End Class
