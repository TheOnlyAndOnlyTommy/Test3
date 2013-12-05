<Serializable> Public Class Repository

    'Variables

    Private _persons As New List(Of Person)

    'Properties

    Public ReadOnly Property Persons As List(Of Person)

        Get

            Return _persons

        End Get

    End Property

    'Methods

    Public Sub AddPerson(person As Person)

        _persons.Add(person)

    End Sub

    Public Function GetPersonsByParameters(givenName As String, gender As Gender) As List(Of Person)

        Dim persons As New List(Of Person)

        For Each person As Person In _persons

            If person.Gender = gender AndAlso person.GivenName.Contains(givenName) Then

                persons.Add(person)

            End If

        Next

        Return persons

    End Function

End Class