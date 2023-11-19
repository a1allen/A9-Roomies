Public Class DayPanelControl

    Dim dayCalendarNum As Integer
    Dim dateOfDay As Date

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

End Class
