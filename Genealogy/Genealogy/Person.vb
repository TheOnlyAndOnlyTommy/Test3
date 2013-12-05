<Serializable> Public Class Person

    Private _birthdate As Date

    Private _deathdate As Nullable(Of Date)

    'Properties

    Public Property GivenName As String

    Public Property FamilyName As String

    Public Property Birthdate As Date

        Get

            Return _birthdate

        End Get

        Set(value As Date)

            If value < Date.Today.AddDays(1) Then

                _birthdate = value

            Else

                Throw New Exception("Birthdate can't be in the future")

            End If

        End Set

    End Property

    Public Property Deathdate As Nullable(Of Date)

        Get

            Return _deathdate

        End Get

        Set(value As Nullable(Of Date))

            If value Is Nothing Then

                _deathdate = value

            Else

                If value < Date.Today.AddDays(1) Then

                    If value < Birthdate Then

                        Throw New Exception("Deathdate can't be before birthdate")

                    Else

                        _deathdate = value

                    End If

                Else

                    Throw New Exception("Deathdate can't be in the future")

                End If

            End If

        End Set

    End Property

    Public Property Gender As Gender

    Public Property Father As Person

    Public Property Mother As Person

    'Constructors

    Public Sub New(giveName As String, familyName As String, birthdate As Date, gender As Gender, father As Person, mother As Person, Optional deathdate As Nullable(Of Date) = Nothing)

        Me.GivenName = giveName

        Me.FamilyName = familyName

        Me.Birthdate = birthdate

        Me.Gender = gender

        Me.Father = father

        Me.Mother = mother

        Me.Deathdate = deathdate

    End Sub

    'Methods

    Public Overrides Function ToString() As String

        Return String.Format("{0} {1}", FamilyName, GivenName)

    End Function

    Public Function FullInfo() As String

        Dim info As String = String.Format("{0}{1}° {2} ", ToString(), Environment.NewLine, Birthdate.ToString("d"))

        If Deathdate IsNot Nothing Then

            info &= String.Format("+ {0}", Deathdate.Value.ToString("d"))

        End If

        Return info

    End Function

End Class