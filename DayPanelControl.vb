Public Class DayPanelControl

    Dim dayCalendarNum As Integer
    Dim dateOfDay As DateTime
    Dim R1_transparent As Boolean
    Dim R2_transparent As Boolean
    Dim R3_transparent As Boolean
    Dim R4_transparent As Boolean

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

    Public Property R1_done_stat As Boolean
        Get
            Return R1_transparent
        End Get
        Set(value As Boolean)
            R1_transparent = value
        End Set
    End Property

    Public Property R2_done_stat As Boolean
        Get
            Return R2_transparent
        End Get
        Set(value As Boolean)
            R2_transparent = value
        End Set
    End Property
    Public Property R3_done_stat As Boolean
        Get
            Return R3_transparent
        End Get
        Set(value As Boolean)
            R3_transparent = value
        End Set
    End Property
    Public Property R4_done_stat As Boolean
        Get
            Return R4_transparent
        End Get
        Set(value As Boolean)
            R4_transparent = value
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
