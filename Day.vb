Public Class Day
    Public dayChores As Date
    Public choresList As List(Of Chore)

    Public Sub New(dayDateTime As Date, choreListItem As List(Of Chore))
        dayChores = dayDateTime
        choresList = choreListItem
    End Sub

    Public Property choreDate() As Date
        Get
            Return dayChores
        End Get
        Set(ByVal value As Date)
            dayChores = value
        End Set
    End Property

    Public Property choreListItems() As List(Of Chore)
        Get
            Return choresList
        End Get
        Set(ByVal value As List(Of Chore))
            choresList = value
        End Set
    End Property

End Class
