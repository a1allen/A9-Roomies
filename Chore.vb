﻿Public Class Chore
    Private choreType As String
    Private chorePerson As String

    Public Sub New(typeOfChore As String, assignedPerson As String)
        choreType = typeOfChore
        chorePerson = assignedPerson
    End Sub

    Public Property TypeOfChore() As String
        Get
            Return choreType
        End Get
        Set(ByVal value As String)
            choreType = value
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
