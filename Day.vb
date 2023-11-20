Public Class Day
    Public dayChores As Date
    Public choresList As List(Of Chore)

    Public Sub New(dayDateTime As Date, choreListItem As List(Of Chore))
        dayChores = dayDateTime
        choresList = choreListItem
    End Sub

End Class
