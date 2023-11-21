Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.Devices
Imports System.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports System.Reflection.Metadata
Imports System.Globalization
Imports System.Drawing.Imaging
Imports A9.My.Resources
Imports System.Formats.Asn1.AsnWriter
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

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
    Private overlayPanel As New Panel()
    Dim aboutControl As ManagementAboutUsControl
    Dim faqControl As ManagementFAQControl
    Dim roommateProfilesControl As ManagementRoommateProfilesControl
    Public Expenses As New Dictionary(Of String, Double) From {
        {"Roommate 1", 0.0},
        {"Roommate 2", -60.0},
        {"Roommate 3", 30.0},
        {"Roommate 4", 30.0}
    }
    Dim expenseControl As RecordExpenseControl
    Dim budgetHistoryControl As Budget_HistoryControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        budgetHistoryControl = New Budget_HistoryControl()
        budgetHistoryControl.Size = New Size(434, 707)
        BudgetTabPage.Controls.Add(budgetHistoryControl)
        budgetHistoryControl.Hide()
        For i As Integer = 0 To dayPanelArray.Length - 1
            controlName = "DayPanelControl" & (i.ToString() + 1)
            dayPanelArray(i) = Me.Controls.Find(controlName, True).FirstOrDefault()

            overlayPanel.BackColor = Color.FromArgb(5, 255, 255, 255) ' Adjust the alpha value for transparency
            overlayPanel.Dock = DockStyle.Fill
            overlayPanel.Visible = True ' Initially, the overlay panel is hidden

            ' Add the overlayPanel to the MainForm controls
            Me.Controls.Add(overlayPanel)
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

        '######################################
        'Dim currentChore1 As Chore

        'Hardcode instances for usability test
        'Housemate red cleaning the bathroom
        dayPanelAssignments.Add("2023-11-11", New List(Of Chore)())
        Dim currentChore1 = New Chore("Clean Bathroom", "Roomate 1", 1)
        currentChore1.statusOfChore = True
        dayPanelAssignments("2023-11-11").Add(currentChore1)
        dayPanelAssignments.Add("2023-11-18", New List(Of Chore)())
        Dim currentChore2 = New Chore("Clean Bathroom", "Roomate 1", 1)
        currentChore2.statusOfChore = True
        dayPanelAssignments("2023-11-18").Add(currentChore2)
        dayPanelAssignments.Add("2023-11-25", New List(Of Chore)())
        Dim currentChore3 = New Chore("Clean Bathroom", "Roomate 1", 1)
        dayPanelAssignments("2023-11-25").Add(currentChore3)
        dayPanelAssignments.Add("2023-12-2", New List(Of Chore)())
        Dim currentChore4 = New Chore("Clean Bathroom", "Roomate 1", 1)
        dayPanelAssignments("2023-12-2").Add(currentChore4)

        'Housemate pruple cleans the kitchen
        dayPanelAssignments.Add("2023-11-29", New List(Of Chore)())
        Dim currentChore5 = New Chore("Clean Kitchen", "Roomate 2", 1)
        dayPanelAssignments("2023-11-29").Add(currentChore5)
        dayPanelAssignments.Add("2023-11-21", New List(Of Chore)())
        Dim currentChore6 = New Chore("Take out trash", "Roomate 2", 1)
        dayPanelAssignments("2023-11-21").Add(currentChore6)


        '######################################

        'Set up the calendar for November
        year = 2023
        month = 11
        setupCalendar()

        roommateProfilesControl = New ManagementRoommateProfilesControl
        ManagementTabPage.Controls.Add(roommateProfilesControl)
        roommateProfilesControl.Roommate4PreferenceCheckBox.SetItemChecked(0, True)
        roommateProfilesControl.Roommate4ExclusionCheckBox.SetItemChecked(2, True)
        roommateProfilesControl.Hide()

    End Sub
    Private Sub DayPanel_Click(sender As Object, e As EventArgs)

        ' Handle the click event for the panels
        Dim clickedPanel As DayPanelControl
        If TypeOf sender Is DayPanelControl Then
            ' Handle the click event for the panels
            clickedPanel = DirectCast(sender, DayPanelControl)
        Else
            ' Handle the click event for picture boxes
            Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
            ' Retrieve the associated DayPanel from the Tag property
            clickedPanel = DirectCast(clickedPictureBox.Tag, DayPanelControl)
        End If

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
        Roomie1_Total.Hide()
        Roomie2_Total.Hide()
        Roomie3_Total.Hide()
        Roomie4_Total.Hide()
        Roomie1_Done.Hide()
        Roomie2_Done.Hide()
        Roomie3_Done.Hide()
        Roomie4_Done.Hide()
        Label12.Hide()
        Label13.Hide()
        Label16.Hide()
        Label17.Hide()
        Label7.Hide()
        Label6.Hide()
        Label8.Hide()
        Label9.Hide()

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
        Dim todays_date As DateTime = DateTime.Now

        numDaysInMonth = DateTime.DaysInMonth(year, month)
        currentDate = New DateTime(year, month, 1)
        startDayOfWeek = (currentDate.DayOfWeek)
        ' to keep track of the chores of each roomie in each month
        Dim R1_contribution = 0
        Dim R2_contribution = 0
        Dim R3_contribution = 0
        Dim R4_contribution = 0
        Dim R1_done_num = 0
        Dim R2_done_num = 0
        Dim R3_done_num = 0
        Dim R4_done_num = 0

        count = 0
        For i As Integer = 0 To dayPanelArray.Length - 1
            ' to keep track of chores of each day for each roomie
            Dim local_R1_contribution = 0
            Dim local_R2_contribution = 0
            Dim local_R3_contribution = 0
            Dim local_R4_contribution = 0
            Dim local_R1_done_num = 0
            Dim local_R2_done_num = 0
            Dim local_R3_done_num = 0
            Dim local_R4_done_num = 0
            If (i >= startDayOfWeek) And (count <= numDaysInMonth - 1) Then

                count += 1
                dayPanelArray(i).DayNum = count
                dayPanelArray(i).DayDate = currentDate
                If dayPanelArray(i).DayDate = todays_date.Date Then
                    dayPanelArray(i).DayNumberLabel.Font = New Font(dayPanelArray(i).DayNumberLabel.Font, FontStyle.Bold)
                    dayPanelArray(i).DayNumberLabel.ForeColor = Color.DarkRed
                Else
                    dayPanelArray(i).DayNumberLabel.Font = New Font(dayPanelArray(i).DayNumberLabel.Font, FontStyle.Regular)
                    dayPanelArray(i).DayNumberLabel.ForeColor = Color.Black

                End If
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
                                    Dim intValue As Integer = Integer.Parse(chore_item.EffortOfChore)
                                    R1_contribution = R1_contribution + (intValue + 1)
                                    local_R1_contribution = local_R1_contribution + (intValue + 1)
                                    If chore_item.statusOfChore Then
                                        R1_done_num = R1_done_num + (intValue + 1)
                                        local_R1_done_num = local_R1_done_num + (intValue + 1)
                                    End If
                                ElseIf person = "Roomate 2" Then
                                    Dim intValue As Integer = Integer.Parse(chore_item.EffortOfChore)
                                    dayPanelArray(i).Roomate2PictureBox.Show()
                                    R2_contribution = R2_contribution + (intValue + 1)
                                    local_R2_contribution = local_R2_contribution + (intValue + 1)
                                    If chore_item.statusOfChore Then
                                        R2_done_num = R2_done_num + (intValue + 1)
                                        local_R2_done_num = local_R2_done_num + (intValue + 1)
                                    End If
                                ElseIf person = "Roomate 3" Then
                                    Dim intValue As Integer = Integer.Parse(chore_item.EffortOfChore)
                                    R3_contribution = R3_contribution + (intValue + 1)
                                    local_R3_contribution = local_R3_contribution + (intValue + 1)
                                    dayPanelArray(i).Roomate3PictureBox.Show()
                                    If chore_item.statusOfChore Then
                                        R3_done_num = R3_done_num + (intValue + 1)
                                        local_R3_done_num = local_R3_done_num + (intValue + 1)
                                    End If
                                ElseIf person = "Roomate 4" Then
                                    Dim intValue As Integer = Integer.Parse(chore_item.EffortOfChore)
                                    R4_contribution = R4_contribution + (intValue + 1)
                                    local_R4_contribution = local_R4_contribution + (intValue + 1)
                                    dayPanelArray(i).Roomate4PictureBox.Show()
                                    If chore_item.statusOfChore Then
                                        R4_done_num = R4_done_num + (intValue + 1)
                                        local_R4_done_num = local_R4_done_num + (intValue + 1)
                                    End If
                                End If

                            Next
                        End If
                    End If


                    dayPanelArray(i).Show()

                    'Check if extra panels were used
                    If i = 35 Then
                        Panel1.Show()
                    ElseIf i = 36 Then
                        Panel2.Show()
                    End If


                    ' If the chores of each roomie is done for that day, change the colored dot to a less 
                    ' transparent dot
                    If (local_R1_contribution <> 0 And local_R1_contribution = local_R1_done_num) Then
                        dayPanelArray(i).Roomate1PictureBox.Image = myResources.pink_done
                    Else
                        dayPanelArray(i).Roomate1PictureBox.Image = myResources.pink
                    End If

                    If (local_R2_contribution <> 0 And local_R2_contribution = local_R2_done_num) Then
                        dayPanelArray(i).Roomate2PictureBox.Image = myResources.green_done
                    Else
                        dayPanelArray(i).Roomate2PictureBox.Image = myResources.green
                    End If

                    If (local_R3_contribution <> 0 And local_R3_contribution = local_R3_done_num) Then
                        dayPanelArray(i).Roomate3PictureBox.Image = myResources.blue_done
                    Else
                        dayPanelArray(i).Roomate3PictureBox.Image = myResources.blue

                    End If

                    If (local_R4_contribution <> 0 And local_R4_contribution = local_R4_done_num) Then
                        dayPanelArray(i).Roomate4PictureBox.Image = myResources.purple_done
                    Else
                        dayPanelArray(i).Roomate4PictureBox.Image = myResources.purple
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
        Roomie1_Total.Text = R1_contribution
        Roomie2_Total.Text = R2_contribution
        Roomie3_Total.Text = R3_contribution
        Roomie4_Total.Text = R4_contribution
        Roomie1_Done.Text = R1_done_num
        Roomie2_Done.Text = R2_done_num
        Roomie3_Done.Text = R3_done_num
        Roomie4_Done.Text = R4_done_num
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
        Roomie1_Total.Hide()
        Roomie2_Total.Hide()
        Roomie3_Total.Hide()
        Roomie4_Total.Hide()
        Roomie1_Done.Hide()
        Roomie2_Done.Hide()
        Roomie3_Done.Hide()
        Roomie4_Done.Hide()
        Label12.Hide()
        Label13.Hide()
        Label16.Hide()
        Label17.Hide()
        Label7.Hide()
        Label6.Hide()
        Label8.Hide()
        Label9.Hide()

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
                currentChoreL.Add(New Chore(choreControl.NewChoreTextBox.Text, choreControl.RoomateComboBox.Text, choreControl.EffortScore.SelectedIndex))
            Else
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.ChoreTypeComboBox.Text, choreControl.RoomateComboBox.Text, choreControl.EffortScore.SelectedIndex))
            End If
            ' Key does not exist, so add the key-value pair
            dayPanelAssignments.Add(choreControl.AddChoreDateTimePicker.Value.Date, currentChoreL)
        Else
            currentChoreL = dayPanelAssignments(choreControl.AddChoreDateTimePicker.Value.Date)
            'Add new default chore if added by user
            If choreControl.ChoreTypeComboBox.Text = "Add Custom Chore" Then
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.NewChoreTextBox.Text, choreControl.RoomateComboBox.Text, choreControl.EffortScore.SelectedIndex))
            Else
                'Add chore to ChoreList
                currentChoreL.Add(New Chore(choreControl.ChoreTypeComboBox.Text, choreControl.RoomateComboBox.Text, choreControl.EffortScore.SelectedIndex))
            End If
            dayPanelAssignments(choreControl.AddChoreDateTimePicker.Value.Date) = currentChoreL
        End If


        'update calendar
        setupCalendar()
        showCalendarTab()

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
        Roomie1_Total.Show()
        Roomie2_Total.Show()
        Roomie3_Total.Show()
        Roomie4_Total.Show()
        Roomie1_Done.Show()
        Roomie2_Done.Show()
        Roomie3_Done.Show()
        Roomie4_Done.Show()
        Label12.Show()
        Label13.Show()
        Label16.Show()
        Label17.Show()
        Label7.Show()
        Label6.Show()
        Label8.Show()
        Label9.Show()
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
        Dim score As String = dayViewPage.ChoreItem.EffortOfChore
        Dim score_ind As Integer
        If score.Count = 1 Then
            score_ind = 0
        ElseIf score.Count = 2 Then
            score_ind = 1
        ElseIf score.Count = 3 Then
            score_ind = 2
        ElseIf score.Count = 4 Then
            score_ind = 3
        ElseIf score.Count = 5 Then
            score_ind = 4
        End If
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
        editChoreControl.EffortScore.SelectedIndex = score_ind

        AddHandler editChoreControl.SubmitChoreEditsButtonClick, AddressOf SubmitChoreEditsButton_Click
        AddHandler editChoreControl.DeleteChoreButtonClick, AddressOf DeleteChoreButton_Click
        AddHandler editChoreControl.CancelEditChoreButtonClick, AddressOf CancelEditChoreButton_Click

    End Sub

    Private Sub SubmitChoreEditsButton_Click(sender As Object, e As EventArgs)
        'Get the attributes needed to search through the list
        Dim thisChoreName As String = dayViewPage.ChoreItem.TypeOfChore
        Dim thisAssignedPerson As String = dayViewPage.ChoreItem.AssignedPerson
        Dim thisDate As DateTime = dayViewPage.FullDate.Text
        Dim thisScore As String = dayViewPage.ChoreItem.EffortOfChore
        Dim score_ind As Integer
        If thisScore.Count = 1 Then
            score_ind = 0
        ElseIf thisScore.Count = 2 Then
            score_ind = 1
        ElseIf thisScore.Count = 3 Then
            score_ind = 2
        ElseIf thisScore.Count = 4 Then
            score_ind = 3
        ElseIf thisScore.Count = 5 Then
            score_ind = 4
        End If


        'Get the new attributes 
        Dim newChoreName As String = editChoreControl.EditChoreTextBox.Text
        Dim newAssignedPerson As String = editChoreControl.EditRoomateComboBox.Text
        Dim newDate As DateTime = editChoreControl.EditChoreDateTimePicker.Value
        Dim newScore As String = editChoreControl.EffortScore.SelectedIndex
        Dim new_item As New Chore(newChoreName, newAssignedPerson, newScore)


        Dim item As Chore
        Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)

        If dayPanelAssignments.ContainsKey(thisDate) Then
            'Remove chore from the dictionary
            For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                item = thisChoreList(i)
                If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) And (item.EffortOfChore = score_ind) Then
                    thisChoreList.RemoveAt(i)
                End If
            Next
        End If


        'Re-add the chore from the dictionary
        If Not dayPanelAssignments.ContainsKey(newDate) Then
            'Key does not exist for new day so add it
            dayPanelAssignments.Add(newDate, New List(Of Chore)())
        End If
        Dim newChoreList As List(Of Chore) = dayPanelAssignments(newDate)
        newChoreList.Add(New Chore(newChoreName, newAssignedPerson, newScore))
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
        Dim score As String = dayViewPage.ChoreItem.EffortOfChore
        Dim score_ind As Integer
        If score.Count = 1 Then
            score_ind = 0
        ElseIf score.Count = 2 Then
            score_ind = 1
        ElseIf score.Count = 3 Then
            score_ind = 2
        ElseIf score.Count = 4 Then
            score_ind = 3
        ElseIf score.Count = 5 Then
            score_ind = 4
        End If

        Dim item As Chore
        Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)

        If dayPanelAssignments.ContainsKey(thisDate) Then
            'Remove chore from the dictionary
            For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                item = thisChoreList(i)
                If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) And (item.EffortOfChore = score_ind) Then
                    thisChoreList.RemoveAt(i)
                End If
            Next
        End If

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
            Dim score As String = dayViewPage.ChoreItem.EffortOfChore
            Dim score_ind As String = 1
            If score.Count = 1 Then
                score_ind = 0
            ElseIf score.Count = 2 Then
                score_ind = 1
            ElseIf score.Count = 3 Then
                score_ind = 2
            ElseIf score.Count = 4 Then
                score_ind = 3
            ElseIf score.Count = 5 Then
                score_ind = 4
            End If

            'Get the exact same date 2 days later
            Dim newDate As DateTime = thisDate.AddDays(2)

            Dim item As Chore
            Dim thisChoreList As List(Of Chore) = dayPanelAssignments(thisDate)

            If dayPanelAssignments.ContainsKey(thisDate) Then
                'Remove chore from the dictionary
                For i As Integer = thisChoreList.Count - 1 To 0 Step -1
                    item = thisChoreList(i)
                    If (item.TypeOfChore = thisChoreName) And (item.AssignedPerson = thisAssignedPerson) And (item.EffortOfChore = score_ind) Then
                        thisChoreList.RemoveAt(i)
                    End If
                Next
            End If

            'Re-add the chore from the dictionary
            If Not dayPanelAssignments.ContainsKey(newDate) Then
                'Key does not exist for new day so add it
                dayPanelAssignments.Add(newDate, New List(Of Chore)())
            End If

            'Re-add the chore from the dictionary
            Dim newChoreList As List(Of Chore) = dayPanelAssignments(newDate)

            newChoreList.Add(New Chore(thisChoreName, thisAssignedPerson, score_ind))
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

    Private Sub ManagementButtons_Click(sender As Object, e As EventArgs) Handles AboutUsButton.Click, FAQButton.Click, RoomatesProfileButton.Click

        ManagementTitleLabel.Hide()
        ManagementPictureBox.Hide()
        ManageHouseholdsButton.Hide()
        RoomatesProfileButton.Hide()
        FAQButton.Hide()
        AboutUsButton.Hide()


        'Create instance
        If sender.Name Is "RoomatesProfileButton" Then
            roommateProfilesControl.Show()
        ElseIf sender.Name Is "FAQButton" Then
            faqControl = New ManagementFAQControl()
            ManagementTabPage.Controls.Add(faqControl)
        ElseIf sender.Name Is "AboutUsButton" Then
            aboutControl = New ManagementAboutUsControl()
            ManagementTabPage.Controls.Add(aboutControl)
        End If




    End Sub

    Public Sub showManagementTab()
        'Remove instance 
        ManagementTabPage.Controls.Remove(aboutControl)
        ManagementTabPage.Controls.Remove(faqControl)
        roommateProfilesControl.Hide()
        'Show all other elements on the tab
        ManagementTitleLabel.Show()
        ManagementPictureBox.Show()
        ManageHouseholdsButton.Show()
        RoomatesProfileButton.Show()
        FAQButton.Show()
        AboutUsButton.Show()
    End Sub

    Private Sub RecordExpenseButton_Click(sender As Object, e As EventArgs) Handles RecordExpenseButton.Click
        'Remove budget page controls
        BudgetTitle.Hide()
        BudgetPictureBox.Hide()
        BudgetPanel.Hide()
        RecordExpenseButton.Hide()
        ViewBalanceSheetButton.Hide()

        'Create instance
        expenseControl = New RecordExpenseControl()
        BudgetTabPage.Controls.Add(expenseControl)
        'expenseControl.ExpenseCheckBox.SetItemChecked(0, True)

        AddHandler expenseControl.AddExpenseButtonClick, AddressOf AddExpenseButton_Click
        AddHandler expenseControl.CancelExpenseButtonClick, AddressOf CancelExpenseButton_Click
    End Sub

    Private Sub AddExpenseButton_Click(sender As Object, e As EventArgs)
        Dim amount As Double = Double.Parse(expenseControl.ExpenseAmountTextBox.Text)
        Dim payer_name As String = expenseControl.whoPaidCombo.SelectedIndex
        Dim label_name_record As String = expenseControl.label_of_record.Text
        'Dim otherToPay As Integer()
        budgetHistoryControl.BudgetItem2.ExpenseName = "bought New vacuum"
        budgetHistoryControl.BudgetItem2.DateofItem = "Nov 12"
        budgetHistoryControl.BudgetItem2.NameOfRoomate = 2
        budgetHistoryControl.BudgetItem2.Paid = 90

        budgetHistoryControl.BudgetItem1.ExpenseName = label_name_record
        budgetHistoryControl.BudgetItem1.DateofItem = "Nov 21"
        budgetHistoryControl.BudgetItem1.NameOfRoomate = 3
        budgetHistoryControl.BudgetItem1.Paid = amount

        If payer_name = 0 Then
            If expenseControl.R_check.Checked Then
                Dim amount_for_each = amount / 4
                Expenses("Roommate 1") += amount_for_each
                Expenses("Roommate 2") += amount_for_each
                Expenses("Roommate 3") += amount_for_each
                Expenses("Roommate 4") += amount_for_each
            Else
                Dim counting = 0
                If expenseControl.R1_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R2_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R3_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R4_check.Checked Then
                    counting += 1
                End If

                Dim amount_for_each = amount / counting
                If expenseControl.R1_check.Checked Then
                    Expenses("Roommate 1") += amount_for_each

                End If

                If expenseControl.R2_check.Checked Then
                    Expenses("Roommate 2") += amount_for_each

                End If

                If expenseControl.R3_check.Checked Then
                    Expenses("Roommate 3") += amount_for_each
                End If

                If expenseControl.R4_check.Checked Then
                    Expenses("Roommate 4") += amount_for_each
                End If

            End If
        ElseIf payer_name = 1 Then
            If expenseControl.R_check.Checked Then
                Dim amount_for_each = amount / 3
                Expenses("Roommate 1") -= amount
                Expenses("Roommate 2") += amount_for_each
                Expenses("Roommate 3") += amount_for_each
                Expenses("Roommate 4") += amount_for_each
            Else
                Dim counting = 0

                If expenseControl.R2_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R3_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R4_check.Checked Then
                    counting += 1
                End If

                Dim amount_for_each = amount / counting

                Expenses("Roommate 1") -= amount


                If expenseControl.R2_check.Checked Then
                    Expenses("Roommate 2") += amount_for_each
                End If

                If expenseControl.R3_check.Checked Then
                    Expenses("Roommate 3") += amount_for_each
                End If

                If expenseControl.R4_check.Checked Then
                    Expenses("Roommate 4") += amount_for_each
                End If

            End If
        ElseIf payer_name = 2 Then
            If expenseControl.R_check.Checked Then
                Dim amount_for_each = amount / 3
                Expenses("Roommate 1") += amount_for_each
                Expenses("Roommate 2") -= amount
                Expenses("Roommate 3") += amount_for_each
                Expenses("Roommate 4") += amount_for_each
            Else
                Dim counting = 0
                If expenseControl.R1_check.Checked Then
                    counting += 1
                End If


                If expenseControl.R3_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R4_check.Checked Then
                    counting += 1
                End If

                Dim amount_for_each = amount / counting
                If expenseControl.R1_check.Checked Then
                    Expenses("Roommate 1") += amount_for_each

                End If


                Expenses("Roommate 2") -= amount


                If expenseControl.R3_check.Checked Then
                    Expenses("Roommate 3") += amount_for_each
                End If

                If expenseControl.R4_check.Checked Then
                    Expenses("Roommate 4") += amount_for_each
                End If

            End If
        ElseIf payer_name = 2 Then
            If expenseControl.R_check.Checked Then
                Dim amount_for_each = amount / 3
                Expenses("Roommate 1") += amount_for_each
                Expenses("Roommate 2") += amount_for_each
                Expenses("Roommate 3") -= amount
                Expenses("Roommate 4") += amount_for_each
            Else
                Dim counting = 0
                If expenseControl.R1_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R2_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R4_check.Checked Then
                    counting += 1
                End If

                Dim amount_for_each = amount / counting
                If expenseControl.R1_check.Checked Then
                    Expenses("Roommate 1") += amount_for_each

                End If

                If expenseControl.R2_check.Checked Then
                    Expenses("Roommate 2") += amount_for_each

                End If


                Expenses("Roommate 3") -= amount


                If expenseControl.R4_check.Checked Then
                    Expenses("Roommate 4") += amount_for_each
                End If

            End If
        ElseIf payer_name = 3 Then
            If expenseControl.R_check.Checked Then
                Dim amount_for_each = amount / 3
                Expenses("Roommate 1") += amount_for_each
                Expenses("Roommate 2") += amount_for_each
                Expenses("Roommate 3") += amount_for_each
                Expenses("Roommate 4") -= amount
            Else
                Dim counting = 0
                If expenseControl.R1_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R2_check.Checked Then
                    counting += 1
                End If

                If expenseControl.R3_check.Checked Then
                    counting += 1
                End If


                Dim amount_for_each = amount / counting
                If expenseControl.R1_check.Checked Then
                    Expenses("Roommate 1") += amount_for_each

                End If

                If expenseControl.R2_check.Checked Then
                    Expenses("Roommate 2") += amount_for_each

                End If

                If expenseControl.R3_check.Checked Then
                    Expenses("Roommate 3") += amount_for_each
                End If


                Expenses("Roommate 4") -= amount


            End If
        End If
        'Dim expenseType As String = expenseControl.ExpenseDecisionComboBox.Text

        'Get a list of roomates to apply the expense type to
        Dim selectedRoommates As New List(Of String)



        'Update balances on main screen
        Roomate1AmountLabel.Text = $"${Expenses("Roommate 1"):F2}"
        Roomate2AmountLabel.Text = $"${Expenses("Roommate 2"):F2}"
        Roomate3AmountLabel.Text = $"${Expenses("Roommate 3"):F2}"
        Roomate4AmountLabel.Text = $"${Expenses("Roommate 4"):F2}"

        'Remove control
        BudgetTabPage.Controls.Remove(expenseControl)

        'Show budget page controls
        BudgetTitle.Show()
        BudgetPictureBox.Show()
        BudgetPanel.Show()
        RecordExpenseButton.Show()
        ViewBalanceSheetButton.Show()

    End Sub

    Private Sub CancelExpenseButton_Click(sender As Object, e As EventArgs)
        'Remove control
        BudgetTabPage.Controls.Remove(expenseControl)
        budgetHistoryControl.Hide()

        'Show budget page controls
        BudgetTitle.Show()
        BudgetPictureBox.Show()
        BudgetPanel.Show()
        RecordExpenseButton.Show()
        ViewBalanceSheetButton.Show()
    End Sub

    Private Sub ViewBalanceSheetButton_Click(sender As Object, e As EventArgs) Handles ViewBalanceSheetButton.Click

        budgetHistoryControl.Show()
        AddHandler budgetHistoryControl.CancelExpenseButtonClick, AddressOf CancelExpenseButton_Click

        BudgetTitle.Hide()
        BudgetPictureBox.Hide()
        BudgetPanel.Hide()
        RecordExpenseButton.Hide()
        ViewBalanceSheetButton.Hide()
    End Sub

End Class
