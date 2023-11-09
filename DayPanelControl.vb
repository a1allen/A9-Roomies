Public Class DayPanelControl

    Dim dayCalendarNum As Integer
    Public Property DayNum As Integer
        Get
            Return dayCalendarNum
        End Get
        Set(value As Integer)
            dayCalendarNum = value
            DayNumberLabel.Text = dayCalendarNum
        End Set
    End Property

End Class
