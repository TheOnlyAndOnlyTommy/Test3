Public Class FormSearchPerson

    'Variables

    Protected _repository As Repository

    'Constructors

    Public Sub New(repository As Repository)

        InitializeComponent()

        _repository = repository

        Search()

    End Sub

    'Methods

    Private Sub DoSearch(sender As Object, e As EventArgs) Handles TextBoxGivenName.TextChanged, RadioButtonMale.CheckedChanged, RadioButtonFemale.CheckedChanged

        Search()

    End Sub

    Private Sub Search()

        If _repository IsNot Nothing Then

            Dim gender As Gender = GetGender()

            Dim persons As List(Of Person) = _repository.GetPersonsByParameters(TextBoxGivenName.Text, gender)

            ListBoxPersons.Items.Clear()

            ListBoxPersons.Items.AddRange(persons.ToArray())

        End If

    End Sub

    Private Function GetGender() As Gender

        If RadioButtonMale.Checked Then

            Return Gender.Male

        Else

            Return Gender.Female

        End If

    End Function

    Protected Overridable Sub ListBoxPersons_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxPersons.DoubleClick

    End Sub

End Class