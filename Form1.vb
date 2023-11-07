Public Class Form1
    Dim year As Integer = 2023
    Dim month As Integer = 11
    Dim monthDays As Integer = DateTime.DaysInMonth(year, month)
    Dim startDay As DayOfWeek
    Dim firstDay As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupCalendar()
    End Sub
    Private Sub setupCalendar()

    End Sub

End Class
