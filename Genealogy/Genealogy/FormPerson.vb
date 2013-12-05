Public Class FormPerson

    'Variables

    Protected _repository As Repository

    Protected _father As Person

    Protected _mother As Person

    'Constructors

    Public Sub New(repository As Repository)

        InitializeComponent()

        _repository = repository

    End Sub

    'Methods

    Protected Overridable Sub ButtonDoAction_Click(sender As Object, e As EventArgs) Handles ButtonDoAction.Click

    End Sub

    Protected Overridable Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGivenName.TextChanged, TextBoxFamilyName.TextChanged

    End Sub

    Private Sub OpenFormSearchAndReturnPerson(gender As Gender)

        Dim formSearchAndReturnPerson As New FormSearchAndReturnPerson(_repository, gender)

        AddHandler formSearchAndReturnPerson.PersonSelected, AddressOf SetParent

        formSearchAndReturnPerson.ShowDialog()

    End Sub

    Private Sub ButtonFather_Click(sender As Object, e As EventArgs) Handles ButtonFather.Click

        OpenFormSearchAndReturnPerson(Gender.Male)

    End Sub

    Private Sub ButtonMother_Click(sender As Object, e As EventArgs) Handles ButtonMother.Click

        OpenFormSearchAndReturnPerson(Gender.Female)

    End Sub

    Private Sub SetParent(person As Person)

        If person.Gender = Gender.Male Then

            _father = person

            TextBoxFamilyName.Enabled = False

            TextBoxFamilyName.Text = _father.FamilyName

        Else

            _mother = person

        End If

    End Sub

    Private Sub CheckBoxDeathdateEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDeathdateEnabled.CheckedChanged

        DateTimePickerDeathdate.Enabled = CheckBoxDeathdateEnabled.Checked

    End Sub

    Protected Overridable Sub ButtonShowTree_Click(sender As Object, e As EventArgs) Handles ButtonShowTree.Click

    End Sub

End Class