Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.Devices
Imports System.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports System.Reflection.Metadata
Imports System.Globalization

Public Class Form1

    Dim dayPanelArray(36) As DayPanelControl
    Dim controlName As String
    Dim year As Integer
    Dim month As Integer
    Dim numDaysInMonth As Integer
    Dim currentDate As DateTime
    Dim startDayOfWeek As Integer
    Dim count As Integer
    Dim choreControl As AddChoreControl
    Dim editChoreControl As EditChoreControl
    'Dim dayViewPage As DayView
    Public ChoreList As New List(Of Chore)()
    Public dayPanelAssignments As New Dictionary(Of DateTime, List(Of Chore))
    Private WithEvents dayViewPage As DayView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To dayPanelArray.Length - 1
            controlName = "DayPanelControl" & (i.ToString() + 1)
            dayPanelArray(i) = Me.Controls.Find(controlName, True).FirstOrDefault()
            'Hide the 4 dots
            dayPanelArray(i).Roomate1PictureBox.Hide()
            dayPanelArray(i).Roomate2PictureBox.Hide()
            dayPanelArray(i).Roomate3PictureBox.Hide()
            dayPanelArray(i).Roomate4PictureBox.Hide()
            AddHandler dayPanelArray(i).Click, AddressOf DayPanel_Click
            AddHandler dayPanelArray(i).Roomate1PictureBox.Click, AddressOf DayPanel_Click
            AddHandler dayPanelArray(i).Roomate2PictureBox.Click, AddressOf DayPanel_Click
            AddHandler dayPanelArray(i).Roomate3PictureBox.Click, AddressOf DayPanel_Click
            AddHandler dayPanelArray(i).Roomate4PictureBox.Click, AddressOf DayPanel_Click
            Me.Controls.Find(controlName, True)
        Next

        'Set up the calendar for November
        year = 2023
        month = 11
        setupCalendar()

    End Sub
    Private Sub DayPanel_Click(sender As Object, e As EventArgs)

        ' Handle the click event for the panels
        Dim clickedPanel As DayPanelControl
        If TypeOf sender Is DayPanelControl Then
            ' Handle the click event for the panels
            clickedPanel = DirectCast(sender, DayPanelControl)
            ' ... Your existing logic for panels
        Else
            ' Handle the click event for picture boxes
            Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

            ' Retrieve the associated DayPanel from the Tag property
            clickedPanel = DirectCast(clickedPictureBox.Tag, DayPanelControl)
            ' ... Your logic for picture boxes and associated DayPanel
        End If
        ' Find the index of the clicked panel in the array
        Dim index As Integer = Array.IndexOf(dayPanelArray, clickedPanel)

        ' Do something with the index
        'MessageBox.Show($"Clicked panel at index {clickedPanel.DayNum}, {clickedPanel.DayDate}, ")
        'Hide all other elements on the tab
        MonthLabel.Hide()
        AddToCalendarButton.Hide()
        DecorationPanel1.Hide()
        DecorationPanel2.Hide()
        DecorationPanel3.Hide()
        SunLabel.Hide()
        MonLabel.Hide()
        TuesLabel.Hide()
        WedLabel.Hide()
        ThursLabel.Hide()
        FriLabel.Hide()
        SatLabel.Hide()
        CalendarTableLayoutPanel.Hide()
        Panel1.Hide()
        Panel2.Hide()
        PreviousButton.Hide()
        NextButton.Hide()
        RoomiesTitleLabel.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        Roomie1PointsLabel.Hide()
        Roomie2PointsLabel.Hide()
        Roomie3PointsLabel.Hide()
        Roomie4PointsLabel.Hide()

        'Create instance
        dayViewPage = New DayView()
        dayViewPage.date_of_today = clickedPanel.DayDate
        CalendarTabPage.Controls.Add(dayViewPage)

        AddHandler dayViewPage.backToCalButtonClick, AddressOf BackToCalButton_Click

    End Sub

    Private Sub BackToCalButton_Click(sender As Object, e As EventArgs)
        CalendarTabPage.Controls.Remove(dayViewPage)
        setupCalendar()
        showCalendarTab()
    End Sub
    Private Sub setupCalendar()

        numDaysInMonth = DateTime.DaysInMonth(year, month)
        currentDate = New DateTime(year, month, 1)
        startDayOfWeek = (currentDate.DayOfWeek)
        Dim R1_contribution = 0
        Dim R2_contribution = 0
        Dim R3_contribution = 0
        Dim R4_contribution = 0

        count = 0
        For i As Integer = 0 To dayPanelArray.Length - 1
            If (i >= startDayOfWeek) And (count <= numDaysInMonth - 1) Then

                count += 1
                dayPanelArray(i).DayNum = count
                dayPanelArray(i).DayDate = currentDate
                If Not dayPanelAssignments.ContainsKey(currentDate) Then
                    ' Key does not exist, so add the key-value pair
                    dayPanelAssignments.Add(currentDate, New List(Of Chore)())
                    dayPanelArray(i).Roomate1PictureBox.Hide()
                    dayPanelArray(i).Roomate2PictureBox.Hide()
                    dayPanelArray(i).Roomate3PictureBox.Hide()
                    dayPanelArray(i).Roomate4PictureBox.Hide()
                Else

                    Dim Chores = dayPanelAssignments(currentDate)
                    If (Chores.Count = 0) Then
                        dayPanelArray(i).Roomate1PictureBox.Hide()
                        dayPanelArray(i).Roomate2PictureBox.Hide()
                        dayPanelArray(i).Roomate3PictureBox.Hide()
                        dayPanelArray(i).Roomate4PictureBox.Hide()
                    Else

                        For Each chore_item As Chore In Chores
                            Dim person = chore_item.AssignedPerson
                            If person = "Roomate 1" Then
                                dayPanelArray(i).Roomate1PictureBox.Show()
                                R1_contribution = R1_contribution + 1
                            ElseIf person = "Roomate 2" Then
                                dayPanelArray(i).Roomate2PictureBox.Show()
                                R2_contribution = R2_contribution + 1
                            ElseIf person = "Roomate 3" Then
                                R3_contribution = R3_contribution + 1
                                dayPanelArray(i).Roomate3PictureBox.Show()
                            ElseIf person = "Roomate 4" Then
                                R4_contribution = R4_contribution + 1
                                dayPanelArray(i).Roomate4PictureBox.Show()
                            End If
                        Next
                    End If
                End If
                Roomie1PointsLabel.Text = R1_contribution
                Roomie2PointsLabel.Text = R2_contribution
                Roomie3PointsLabel.Text = R3_contribution
                Roomie4PointsLabel.Text = R4_contribution
                dayPanelArray(i).Show()

                'Check if extra panels were used
                If i = 35 Then
                    Panel1.Show()
                ElseIf i = 36 Then
                    Panel2.Show()
                End If

                currentDate = currentDate.AddDays(1)

            Else
                dayPanelArray(i).Hide()

                'Hide extra panels if they are not being used
                If i = 35 Then
                    Panel1.Hide()
                ElseIf i = 36 Then
                    Panel2.Hide()
                End If
            End If
        Next
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        If month = 12 Then
            year += 1
            month = 1
        Else
            month += 1
        End If

        MonthLabel.Text = MonthName(month) & " " & year

        'Update the calendar
        setupCalendar()

    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click

        If month = 1 Then
            year -= 1
            month = 12
        Else
            month -= 1
        End If

        MonthLabel.Text = MonthName(month) & " " & year

        'Update the calendar
        setupCalendar()
    End Sub

    Private Sub AddToCalendarButton_Click(sender As Object, e As EventArgs) Handles AddToCalendarButton.Click

        'Hide all other elements on the tab
        MonthLabel.Hide()
        AddToCalendarButton.Hide()
        DecorationPanel1.Hide()
        DecorationPanel2.Hide()
        DecorationPanel3.Hide()
        SunLabel.Hide()
        MonLabel.Hide()
        TuesLabel.Hide()
        WedLabel.Hide()
        ThursLabel.Hide()
        FriLabel.Hide()
        SatLabel.Hide()
        CalendarTableLayoutPanel.Hide()
        Panel1.Hide()
        Panel2.Hide()
        PreviousButton.Hide()
        NextButton.Hide()
        RoomiesTitleLabel.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        Roomie1PointsLabel.Hide()
        Roomie2PointsLabel.Hide()
        Roomie3PointsLabel.Hide()
        Roomie4PointsLabel.Hide()

        'Create instance
        choreControl = New AddChoreControl()
        CalendarTabPage.Controls.Add(choreControl)

        AddHandler choreControl.AddChoreButtonClick, AddressOf AddChoreButton_Click
        AddHandler choreControl.CancelChoreButtonClick, AddressOf CancelChoreButton_Click

    End Sub

    Private Sub AddChoreButton_Click(sender As Object, e As EventArgs)
        Dim currentChoreL As New List(Of Chore)


        If Not dayPanelAssignments.ContainsKey(choreControl.AddChoreDateTimePicker.Value.Date) Then
            'Add new default chore if added by user
            If choreControl.ChoreTypeComboBox.Text = "Add Custom Chore" Then
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.NewChoreTextBox.Text, choreControl.RoomateComboBox.Text))
            Else
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.ChoreTypeComboBox.Text, choreControl.RoomateComboBox.Text))
            End If
            ' Key does not exist, so add the key-value pair
            dayPanelAssignments.Add(choreControl.AddChoreDateTimePicker.Value.Date, currentChoreL)
        Else
            currentChoreL = dayPanelAssignments(choreControl.AddChoreDateTimePicker.Value.Date)
            'Add new default chore if added by user
            If choreControl.ChoreTypeComboBox.Text = "Add Custom Chore" Then
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.NewChoreTextBox.Text, choreControl.RoomateComboBox.Text))
            Else
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.ChoreTypeComboBox.Text, choreControl.RoomateComboBox.Text))
            End If
            dayPanelAssignments(choreControl.AddChoreDateTimePicker.Value.Date) = currentChoreL
        End If




        'Add the chore to the Day class
        'Dim dayChores As New Day(choreControl.AddChoreDateTimePicker.Value.Date, ChoreList)
        'MessageBox.Show($"Clicked panel at index {choreControl.AddChoreDateTimePicker.Value.Date}, {currentChoreL}, ")

        ' Alternatively, concatenate the names into a single string
        'Dim documentNames As String = String.Join(", ", currentChoreL.Select(Function(d) d.TypeOfChore))

        ' Display the concatenated names in a MsgBox
        'MsgBox("List of Document Names:" & Environment.NewLine & documentNames, MsgBoxStyle.Information, "Document Names")




        'updateCalendar(choreControl.AddChoreDateTimePicker.Value.Date, choreControl.RoomateComboBox.SelectedIndex)
        setupCalendar()
        showCalendarTab()

        'Update the weights at the bottom of the page

    End Sub



    Private Sub CancelChoreButton_Click(sender As Object, e As EventArgs)

        showCalendarTab()

    End Sub

    Private Sub showCalendarTab()

        'Remove instance 
        CalendarTabPage.Controls.Remove(choreControl)

        'Show all other elements on the tab
        MonthLabel.Show()
        AddToCalendarButton.Show()
        DecorationPanel1.Show()
        DecorationPanel2.Show()
        DecorationPanel3.Show()
        SunLabel.Show()
        MonLabel.Show()
        TuesLabel.Show()
        WedLabel.Show()
        ThursLabel.Show()
        FriLabel.Show()
        SatLabel.Show()
        CalendarTableLayoutPanel.Show()
        PreviousButton.Show()
        NextButton.Show()
        RoomiesTitleLabel.Show()
        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
        PictureBox4.Show()
        Roomie1PointsLabel.Show()
        Roomie2PointsLabel.Show()
        Roomie3PointsLabel.Show()
        Roomie4PointsLabel.Show()

    End Sub

    Private Sub DayView_EditChoreButtonClick(sender As Object, e As EventArgs) Handles dayViewPage.EditChoreButtonClickInDayView
        'Hide the dayView control
        dayViewPage.Hide()

        'Create instance
        editChoreControl = New EditChoreControl()
        CalendarTabPage.Controls.Add(editChoreControl)

        'Fill in the fields with the information from the chore that was clicked
        Dim thisChoreName As String = dayViewPage.ChoreItem.TypeOfChore
        Dim thisAssignedPerson As String = dayViewPage.ChoreItem.AssignedPerson
        Dim thisDate As DateTime = dayViewPage.FullDate.Text
        'Fill in fields
        editChoreControl.EditChoreTextBox.Text = thisChoreName
        If thisAssignedPerson = "Roomate 1" Then
            editChoreControl.EditRoomateComboBox.SelectedIndex = 0
        ElseIf thisAssignedPerson = "Roomate 2" Then
            editChoreControl.EditRoomateComboBox.SelectedIndex = 1
        ElseIf thisAssignedPerson = "Roomate 3" Then
            editChoreControl.EditRoomateComboBox.SelectedIndex = 2
        ElseIf thisAssignedPerson = "Roomate 4" Then
            editChoreControl.EditRoomateComboBox.SelectedIndex = 3
        End If
        editChoreControl.EditChoreDateTimePicker.Value = DateTime.ParseExact(thisDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)


        AddHandler editChoreControl.SubmitChoreEditsButtonClick, AddressOf SubmitChoreEditsButton_Click
        AddHandler editChoreControl.DeleteChoreButtonClick, AddressOf DeleteChoreButton_Click
        AddHandler editChoreControl.CancelEditChoreButtonClick, AddressOf CancelEditChoreButton_Click

    End Sub

    Private Sub SubmitChoreEditsButton_Click(sender As Object, e As EventArgs)
        'Get the attributes needed to search through the list
        Dim thisChoreName As String = dayViewPage.ChoreItem.TypeOfChore
        Dim thisAssignedPerson As String = dayViewPage.ChoreItem.AssignedPerson
        Dim thisDate As DateTime = dayViewPage.FullDate.Text

        'Get the new attributes 
        Dim newChoreName As String = editChoreControl.EditChoreTextBox.Text
        Dim newAssignedPerson As String = editChoreControl.EditRoomateComboBox.Text
        Dim newDate As DateTime = editChoreControl.EditChoreDateTimePicker.Value

        Dim item As Chore

        'Remove the chore from the dictionary
        Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)
        If dayPanelAssignments.ContainsKey(thisDate) Then
            For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                item = thisChoreList(i)
                If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) Then
                    'Once the chore instance has been found, delete it
                    thisChoreList.RemoveAt(i)
                End If
            Next
        End If

        'Re-add the chore from the dictionary
        Dim newChoreList As List(Of Chore) = dayPanelAssignments(newDate)

        newChoreList.Add(New Chore(newChoreName, newAssignedPerson))
        dayPanelAssignments(newDate) = newChoreList


        'Update the daypanel view for all 4 dots
        For Each panel As DayPanelControl In dayPanelArray
            panel.Roomate1PictureBox.Hide()
            panel.Roomate2PictureBox.Hide()
            panel.Roomate3PictureBox.Hide()
            panel.Roomate4PictureBox.Hide()
        Next

        'Update the dayview page
        dayViewPage.DisplayChoresForDate(thisDate)

        'Remove instance
        CalendarTabPage.Controls.Remove(editChoreControl)

        'Show the dayView control
        dayViewPage.Show()

    End Sub

    Private Sub DeleteChoreButton_Click(sender As Object, e As EventArgs)
        'Get the attributes needed to search through the list
        Dim thisChoreName As String = dayViewPage.ChoreItem.TypeOfChore
        Dim thisAssignedPerson As String = dayViewPage.ChoreItem.AssignedPerson
        Dim thisDate As DateTime = dayViewPage.FullDate.Text
        Dim item As Chore
        If dayPanelAssignments.ContainsKey(thisDate) Then
            'Remove chore from the dictionary
            Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)
            For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                item = thisChoreList(i)
                If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) Then
                    thisChoreList.RemoveAt(i)
                End If
            Next
        End If

        'Update the dayview page
        dayViewPage.DisplayChoresForDate(thisDate)

        'Remove instance
        CalendarTabPage.Controls.Remove(editChoreControl)

        'Show the dayView control
        dayViewPage.Show()

    End Sub

    Private Sub CancelEditChoreButton_Click(sender As Object, e As EventArgs)
        'Remove instance
        CalendarTabPage.Controls.Remove(editChoreControl)

        'Show the dayView control
        dayViewPage.Show()
    End Sub

    Private Sub DayView_ExtendChoreButtonClick(sender As Object, e As EventArgs) Handles dayViewPage.ExtendChoreButtonClickInDayView
        'Disable main control
        Me.Enabled = False

        'Show the confirmation form to ask user if they want to extend chore 
        Dim askUserForm As New AskExtendForm()
        askUserForm.StartPosition = FormStartPosition.CenterParent
        askUserForm.ShowDialog(Me)

        'Enable main control once response is given
        Me.Enabled = True

        'Get the result and more the chore 2 days down if user says yes
        If askUserForm.Result Then
            'Get the attributes needed to search through the list
            Dim thisChoreName As String = dayViewPage.ChoreItem.TypeOfChore
            Dim thisAssignedPerson As String = dayViewPage.ChoreItem.AssignedPerson
            Dim thisDate As DateTime = dayViewPage.FullDate.Text

            'Get the exact same date 2 days later
            Dim newDate As DateTime = thisDate.AddDays(2)

            Dim item As Chore
            'Remove the chore from the dictionary
            Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)
            If dayPanelAssignments.ContainsKey(thisDate) Then
                For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                    item = thisChoreList(i)
                    If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) Then
                        'Once the chore instance has been found, delete it
                        thisChoreList.RemoveAt(i)
                    End If
                Next
            End If

            'Re-add the chore for 2 days later with newDate
            Dim newChoreList As List(Of Chore) = dayPanelAssignments(newDate)

            newChoreList.Add(New Chore(thisChoreName, thisAssignedPerson))
            dayPanelAssignments(newDate) = newChoreList

            'Update the daypanel view for all 4 dots
            For Each panel As DayPanelControl In dayPanelArray
                panel.Roomate1PictureBox.Hide()
                panel.Roomate2PictureBox.Hide()
                panel.Roomate3PictureBox.Hide()
                panel.Roomate4PictureBox.Hide()
            Next

            'Update the dayview page
            dayViewPage.DisplayChoresForDate(thisDate)
        End If

    End Sub

    Private Sub DayView_RequestVolunteerButtonClick(sender As Object, e As EventArgs) Handles dayViewPage.RequestVolunteerButtonClick
        Debug.Print("Request volunteer button clicked")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

    End Sub
End Class
