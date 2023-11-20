Imports System.Security.Cryptography.X509Certificates

Public Class DayView
    Public Event backToCalButtonClick As EventHandler
    Public Event EditChoreButtonClickInDayView As EventHandler
    Public Event ExtendChoreButtonClickInDayView As EventHandler
    Public Event RequestVolunteerButtonClick As EventHandler
    Dim choreName As String
    Dim assignedPerson As String
    Dim selectedChoreItem As Chore_item_inDay
    Private controlsToKeep As New List(Of Control)()


    Private Sub DayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlsToKeep.Add(BackButton)
        controlsToKeep.Add(DayDate)
        controlsToKeep.Add(FullDate)
        controlsToKeep.Add(devider)

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

            'Add button click events
            AddHandler new_item.EditChoreButtonClick, AddressOf ChoreItem_EditChoreButtonClick
            AddHandler new_item.ExtendChoreButtonClick, AddressOf ChoreItem_ExtendChoreButtonClick
            AddHandler new_item.RequestVolunteerButtonClick, AddressOf ChoreItem_RequestVolunteereButtonClick

        Next
    End Sub

    Private Sub ChoreItem_EditChoreButtonClick(sender As Object, e As EventArgs)
        selectedChoreItem = DirectCast(sender, Chore_item_inDay)

        RaiseEvent EditChoreButtonClickInDayView(sender, e)
    End Sub
    Private Sub ChoreItem_ExtendChoreButtonClick(sender As Object, e As EventArgs)
        selectedChoreItem = DirectCast(sender, Chore_item_inDay)

        RaiseEvent ExtendChoreButtonClickInDayView(sender, e)
    End Sub
    Private Sub ChoreItem_RequestVolunteereButtonClick(sender As Object, e As EventArgs)
        RaiseEvent RequestVolunteerButtonClick(sender, e)
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

    Public ReadOnly Property ChoreItem As Chore_item_inDay
        Get
            Return selectedChoreItem
        End Get
    End Property

    Private Sub BackToCalButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RaiseEvent backToCalButtonClick(Me, EventArgs.Empty)
    End Sub

    Public Sub DisplayChoresForDate(selectedDate As DateTime)
        'Ensure to keep certain control from the list above
        For i = Controls.Count - 1 To 0 Step -1
            If Not controlsToKeep.Contains(Controls(i)) Then
                Controls.RemoveAt(i)
            End If
        Next

        Dim choreList = Form1.dayPanelAssignments(selectedDate)

        Dim mycount = 0
        For Each chore_item In choreList
            Dim new_item As New Chore_item_inDay()
            new_item.ChoreName.Text = chore_item.TypeOfChore
            new_item.AssignTo.Text = chore_item.AssignedPerson
            Controls.Add(new_item)
            new_item.Size = New Size(353, 112) ' Set the size (width, height)

            If (mycount = 0) Then
                new_item.Location = New Point(41, 108) ' Set the location (x, y)
            Else
                new_item.Location = New Point(41, (108 + (mycount * 118))) ' Set the location (x, y)
            End If

            mycount += 1

            AddHandler new_item.EditChoreButtonClick, AddressOf ChoreItem_EditChoreButtonClick
            AddHandler new_item.ExtendChoreButtonClick, AddressOf ChoreItem_ExtendChoreButtonClick
            AddHandler new_item.RequestVolunteerButtonClick, AddressOf ChoreItem_RequestVolunteereButtonClick
        Next
    End Sub

End Class
