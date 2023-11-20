Public Class Chore
    Private choreType As String
    Private chorePerson As String
    Private choreEffort As String
    Private choreStatus As Boolean

    Public Sub New(typeOfChore As String, assignedPerson As String, effort As Integer)
        choreType = typeOfChore
        chorePerson = assignedPerson
        choreEffort = effort
    End Sub

    Public Property TypeOfChore() As String
        Get
            Return choreType
        End Get
        Set(ByVal value As String)
            choreType = value
        End Set
    End Property
    Public Property statusOfChore() As Boolean
        Get
            Return choreStatus
        End Get
        Set(ByVal value As Boolean)
            choreStatus = value
        End Set
    End Property

    Public Property EffortOfChore() As String
        Get
            Return choreEffort
        End Get
        Set(ByVal value As String)
            choreEffort = value
        End Set
    End Property
    Public Property AssignedPerson() As String
        Get
            Return chorePerson
        End Get
        Set(ByVal value As String)
            chorePerson = value
        End Set
    End Property

End Class
