Public Class DayPanelControl

    Dim dayCalendarNum As Integer
    Dim dateOfDay As DateTime

    Private Sub DayPanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property DayNum As Integer
        Get
            Return dayCalendarNum
        End Get
        Set(value As Integer)
            dayCalendarNum = value
            DayNumberLabel.Text = dayCalendarNum
        End Set
    End Property

    Public Property DayDate As DateTime
        Get
            Return dateOfDay
        End Get
        Set(value As DateTime)
            dateOfDay = value
            'DayNumberLabel.Text = dayCalendarNum
        End Set

    End Property


End Class
