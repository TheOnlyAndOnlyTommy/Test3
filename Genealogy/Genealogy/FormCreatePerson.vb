Public Class FormCreatePerson
    Inherits FormPerson

    'Constructors

    Public Sub New(repository As Repository)

        MyBase.New(repository)

        InitializeComponent()

        ButtonDoAction.Enabled = False

        ButtonDoAction.Text = "Create person"

    End Sub

    'Events

    Public Event PersonCreated As Action(Of Person)

    'Methods

    Protected Overrides Sub ButtonDoAction_Click(sender As Object, e As EventArgs)

        Try

            Dim gender As Gender = GetGender()

            Dim person As Person

            If CheckBoxDeathdateEnabled.Checked Then

                person = New Person(TextBoxGivenName.Text, TextBoxFamilyName.Text, DateTimePickerBirthdate.Value, gender, _father, _mother, DateTimePickerDeathdate.Value)

            Else

                person = New Person(TextBoxGivenName.Text, TextBoxFamilyName.Text, DateTimePickerBirthdate.Value, gender, _father, _mother)

            End If

            RaiseEvent PersonCreated(person)

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

    Protected Overrides Sub TextBox_TextChanged(sender As Object, e As EventArgs)

        ButtonDoAction.Enabled = TextBoxGivenName.Text <> String.Empty AndAlso TextBoxFamilyName.Text <> String.Empty

    End Sub

End Class