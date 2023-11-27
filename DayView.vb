Imports System.Security.Cryptography.X509Certificates

Public Class DayView
    Public Event backToCalButtonClick As EventHandler
    Public Event EditChoreButtonClickInDayView As EventHandler
    Public Event ExtendChoreButtonClickInDayView As EventHandler
    Public Event RequestVolunteerButtonClick As EventHandler
    Public Event AddChoreDayViewButtonClick As EventHandler
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
            new_item.EffortOfChore = chore_item.EffortOfChore
            If new_item.AssignTo.Text = "Roommate 1" Then
                new_item.AssignTo.ForeColor = Color.FromArgb(209, 40, 85)
            ElseIf new_item.AssignTo.Text = "Roommate 2" Then
                new_item.AssignTo.ForeColor = Color.FromArgb(70, 153, 61)
            ElseIf new_item.AssignTo.Text = "Roommate 3" Then
                new_item.AssignTo.ForeColor = Color.FromArgb(50, 122, 140)
            ElseIf new_item.AssignTo.Text = "Roommate 4" Then
                new_item.AssignTo.ForeColor = Color.FromArgb(158, 102, 227)
            End If
            new_item.TheChore = chore_item
            If chore_item.statusOfChore Then
                new_item.choreDone.Checked = True
                new_item.ForeColor = Color.Gray
                new_item.ExtendChoreButton.Enabled = False
                new_item.EditChoreButton.Enabled = False
                new_item.RequestVolunteerButton.Enabled = False
            End If
            Me.Controls.Add(new_item)
            new_item.Size = New Size(360, 112) ' Set the size (width, height)
            If (mycount = 0) Then
                new_item.Location = New Point(38, 108) ' Set the location (x, y)
            Else
                new_item.Location = New Point(38, (108 + (mycount * 118))) ' Set the location (x, y)
            End If
            mycount = mycount + 1

            'Add button click events
            AddHandler new_item.EditChoreButtonClick, AddressOf ChoreItem_EditChoreButtonClick
            AddHandler new_item.ExtendChoreButtonClick, AddressOf ChoreItem_ExtendChoreButtonClick
            AddHandler new_item.RequestVolunteerButtonClick, AddressOf ChoreItem_RequestVolunteereButtonClick

            AddHandler new_item.updateChoreStatus, AddressOf choreDone_CheckedChanged


        Next
    End Sub

    Public Sub RemoveChoreItems()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Chore_item_inDay Then
                Me.Controls.Remove(ctrl)
                ctrl.Dispose() ' Dispose of the control to release resources
            End If
        Next
    End Sub

    Private Sub choreDone_CheckedChanged(sender As Object, e As EventArgs)

        ' Get the type of the sender
        Dim senderType As Type = sender.GetType()

        ' Display the type in a MessageBox
        'MessageBox.Show("Sender type: " & senderType.FullName, "Sender Type", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Dim thisChore As Chore
        ' Handle the click event for picture boxes
        Dim this_chore_item As Chore_item_inDay = DirectCast(sender, Chore_item_inDay)
        Dim this_chore As Chore = this_chore_item.TheChore
        ' Retrieve the associated DayPanel from the Tag property
        'thisChore = DirectCast(choreDone.Tag, Chore)
        ' ... Your logic for picture boxes and associated DayPanel
        If this_chore_item.choreDone.Checked Then
            ' Display confirmation dialog
            Dim confirmationMessage As String = "Are you sure you want to mark the chore as done?"
            Using confirmationForm As New ConfirmationForm(confirmationMessage)
                ' Set the location of the confirmation form at the center of the main form
                confirmationForm.StartPosition = FormStartPosition.CenterParent
                confirmationForm.Size = New Size(327, 239)

                ' Show the confirmation form
                If confirmationForm.ShowDialog(Me) = DialogResult.Yes Then
                    ' User confirmed, perform your action here
                    'Console.WriteLine("User confirmed.")
                    'choreDone.Checked = True
                    this_chore.statusOfChore = True
                    this_chore_item.ForeColor = Color.Gray
                    this_chore_item.ExtendChoreButton.Enabled = False
                    this_chore_item.EditChoreButton.Enabled = False
                    this_chore_item.RequestVolunteerButton.Enabled = False
                Else
                    ' User canceled, uncheck the checkbox
                    this_chore_item.choreDone.Checked = False
                    'Console.WriteLine("User canceled.")
                    this_chore.statusOfChore = False
                    this_chore_item.ForeColor = Color.Black
                    this_chore_item.ExtendChoreButton.Enabled = True
                    this_chore_item.EditChoreButton.Enabled = True
                    this_chore_item.RequestVolunteerButton.Enabled = True
                End If
            End Using

        Else
            this_chore_item.choreDone.Checked = False
            this_chore_item.ExtendChoreButton.Enabled = True
            this_chore_item.EditChoreButton.Enabled = True
            this_chore_item.RequestVolunteerButton.Enabled = True
            'Console.WriteLine("User canceled.")
            this_chore.statusOfChore = False
            this_chore_item.ForeColor = Color.Black

        End If

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
            new_item.EffortOfChore = chore_item.EffortOfChore
            new_item.TheChore = chore_item
            If chore_item.statusOfChore Then
                new_item.choreDone.Checked = True
                new_item.ForeColor = Color.Gray
                new_item.ExtendChoreButton.Enabled = False
                new_item.EditChoreButton.Enabled = False
                new_item.RequestVolunteerButton.Enabled = False
            End If
            Me.Controls.Add(new_item)
            new_item.Size = New Size(360, 112) ' Set the size (width, height)
            If (mycount = 0) Then
                new_item.Location = New Point(38, 108) ' Set the location (x, y)
            Else
                new_item.Location = New Point(38, (108 + (mycount * 118))) ' Set the location (x, y)
            End If
            mycount = mycount + 1

            'Add button click events
            AddHandler new_item.EditChoreButtonClick, AddressOf ChoreItem_EditChoreButtonClick
            AddHandler new_item.ExtendChoreButtonClick, AddressOf ChoreItem_ExtendChoreButtonClick
            AddHandler new_item.RequestVolunteerButtonClick, AddressOf ChoreItem_RequestVolunteereButtonClick

            AddHandler new_item.updateChoreStatus, AddressOf choreDone_CheckedChanged


        Next
    End Sub

    Public Sub DisplayChoresForDate(chore_L As List(Of Chore))

        'Dim chore_L = Form1.dayPanelAssignments(Me.myDate)
        'Dim mycount As New Integer
        Dim mycount = 0
        'MsgBox("List of Document Names:" & chore_L.Count)


        For Each chore_item In chore_L
            Dim new_item As New Chore_item_inDay()
            new_item.ChoreName.Text = chore_item.TypeOfChore
            new_item.AssignTo.Text = chore_item.AssignedPerson
            new_item.EffortOfChore = chore_item.EffortOfChore
            new_item.TheChore = chore_item
            If chore_item.statusOfChore Then
                new_item.choreDone.Checked = True
                new_item.ForeColor = Color.Gray
                new_item.ExtendChoreButton.Enabled = False
                new_item.EditChoreButton.Enabled = False
                new_item.RequestVolunteerButton.Enabled = False
            End If
            Me.Controls.Add(new_item)
            new_item.Size = New Size(360, 112) ' Set the size (width, height)
            If (mycount = 0) Then
                new_item.Location = New Point(38, 108) ' Set the location (x, y)
            Else
                new_item.Location = New Point(38, (108 + (mycount * 118))) ' Set the location (x, y)
            End If
            mycount = mycount + 1

            'Add button click events
            AddHandler new_item.EditChoreButtonClick, AddressOf ChoreItem_EditChoreButtonClick
            AddHandler new_item.ExtendChoreButtonClick, AddressOf ChoreItem_ExtendChoreButtonClick
            AddHandler new_item.RequestVolunteerButtonClick, AddressOf ChoreItem_RequestVolunteereButtonClick

            AddHandler new_item.updateChoreStatus, AddressOf choreDone_CheckedChanged


        Next
    End Sub

    Private Sub DayViewAddChoreButton_Click(sender As Object, e As EventArgs) Handles DayViewAddChoreButton.Click
        RaiseEvent AddChoreDayViewButtonClick(sender, e)
    End Sub
End Class
