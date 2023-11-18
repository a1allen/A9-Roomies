Imports System.Security.Cryptography.X509Certificates

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
    Public ChoreList As New List(Of Chore)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To dayPanelArray.Length - 1
            controlName = "DayPanelControl" & (i.ToString() + 1)
            dayPanelArray(i) = Me.Controls.Find(controlName, True).FirstOrDefault()
            'Hide the 4 dots
            dayPanelArray(i).Roomate1PictureBox.Hide()
            dayPanelArray(i).Roomate2PictureBox.Hide()
            dayPanelArray(i).Roomate3PictureBox.Hide()
            dayPanelArray(i).Roomate4PictureBox.Hide()
        Next
        'Set up the calendar for November
        year = 2023
        month = 11
        setupCalendar()
    End Sub
    Private Sub setupCalendar()
        numDaysInMonth = DateTime.DaysInMonth(year, month)
        currentDate = New DateTime(year, month, 1)
        startDayOfWeek = (currentDate.DayOfWeek)

        count = 0
        For i As Integer = 0 To dayPanelArray.Length - 1
            If (i >= startDayOfWeek) And (count <= numDaysInMonth - 1) Then
                count += 1
                dayPanelArray(i).DayNum = count
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
        'Add new default chore if added by user
        If choreControl.ChoreTypeComboBox.Text = "Add Custom Chore" Then
            'Add chore to ChoreList
            ChoreList.Add(New Chore(choreControl.NewChoreTextBox.Text, choreControl.RoomateComboBox.Text))
        Else
            'Add chore to ChoreList
            ChoreList.Add(New Chore(choreControl.ChoreTypeComboBox.Text, choreControl.RoomateComboBox.Text))
        End If

        'Add the chore to the Day class
        Dim dayChores As New Day(choreControl.AddChoreDateTimePicker.Value.Date, ChoreList)

        updateCalendar(choreControl.AddChoreDateTimePicker.Value.Date, choreControl.RoomateComboBox.SelectedIndex)
        showCalendarTab()

    End Sub

    Private Sub updateCalendar(choreDate As Date, person As Integer)
        numDaysInMonth = DateTime.DaysInMonth(choreDate.Year, choreDate.Month)
        currentDate = New DateTime(choreDate.Year, choreDate.Month, 1)
        startDayOfWeek = (currentDate.DayOfWeek)

        count = 0
        For i As Integer = 0 To dayPanelArray.Length - 1
            If (i >= startDayOfWeek) And (count <= numDaysInMonth - 1) Then
                count += 1
                If (count = choreDate.Day) Then
                    If person = 0 Then
                        dayPanelArray(i).Roomate1PictureBox.Show()
                    ElseIf person = 1 Then
                        dayPanelArray(i).Roomate2PictureBox.Show()
                    ElseIf person = 2 Then
                        dayPanelArray(i).Roomate3PictureBox.Show()
                    ElseIf person = 3 Then
                        dayPanelArray(i).Roomate4PictureBox.Show()
                    End If
                End If
                'Check if extra panels were used
                currentDate = currentDate.AddDays(1)
            End If
        Next
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
        Panel1.Show()
        Panel2.Show()
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

End Class
