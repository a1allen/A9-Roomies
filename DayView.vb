Public Class DayView
    Public Event backToCalButtonClick As EventHandler
    Dim choreDayItemControl As Chore_item_inDay


    Private Sub DayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chore_L = Form1.dayPanelAssignments(Me.myDate)
        'Dim mycount As New Integer
        Dim mycount = 0
        'MsgBox("List of Document Names:" & chore_L.Count)


        For Each chore_item In chore_L
            Dim new_item As New Chore_item_inDay()
            new_item.ChoreName.Text = chore_item.TypeOfChore
            new_item.AssignTo.Text = chore_item.AssignedPerson
            Me.Controls.Add(new_item)
            new_item.Size = New Size(353, 112) ' Set the size (width, height)
            If (mycount = 0) Then
                new_item.Location = New Point(41, 108) ' Set the location (x, y)
            Else
                new_item.Location = New Point(41, (108 + (mycount * 118))) ' Set the location (x, y)
            End If
            mycount = mycount + 1
        Next
    End Sub

    Private myDate As Date

    Public Property date_of_today As Date
        Get
            Return date_of_today
        End Get
        Set(value As Date)
            myDate = value
            ' Optionally, update the user interface based on the new value
            Me.DayDate.Text = myDate.DayOfWeek.ToString
            Me.FullDate.Text = myDate.ToString("yyyy-MM-dd")
        End Set
    End Property

    Private Sub BackToCalButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RaiseEvent backToCalButtonClick(Me, EventArgs.Empty)
    End Sub
End Class
