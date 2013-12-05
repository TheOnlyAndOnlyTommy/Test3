Public Class FormEditPerson
    Inherits FormPerson

    'Variables

    Private _person As Person

    'Constructors

    Public Sub New(repository As Repository, person As Person)

        MyBase.New(repository)

        InitializeComponent()

        _person = person

        _father = _person.Father

        _mother = _person.Mother

        InitializeControls()

    End Sub

    'Methods

    Protected Overrides Sub ButtonShowTree_Click(sender As Object, e As EventArgs)

        Dim formShowTree As New FormShowTree(_repository, _person)

        formShowTree.ShowDialog()

    End Sub

    Private Sub InitializeControls()

        ButtonShowTree.Visible = True

        ButtonDoAction.Text = "Edit person"

        TextBoxGivenName.Text = _person.GivenName

        TextBoxFamilyName.Text = _person.FamilyName

        If _father IsNot Nothing Then

            TextBoxFamilyName.Enabled = False

        End If

        DateTimePickerBirthdate.Value = _person.Birthdate

        If _person.Gender = Gender.Male Then

            RadioButtonMale.Checked = True

        Else

            RadioButtonFemale.Checked = True

        End If

    End Sub

    Protected Overrides Sub ButtonDoAction_Click(sender As Object, e As EventArgs)

        Try

            _person.GivenName = TextBoxGivenName.Text

            _person.FamilyName = TextBoxFamilyName.Text

            _person.Birthdate = DateTimePickerBirthdate.Value

            _person.Gender = GetGender()

            _person.Father = _father

            _person.Mother = _mother

            If CheckBoxDeathdateEnabled.Checked Then

                _person.Deathdate = DateTimePickerDeathdate.Value

            End If

            Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Function GetGender() As Gender

        If RadioButtonMale.Checked Then

            Return Gender.Male

        Else

            Return Gender.Female

        End If

    End Function

End Class