Public Class FormSearchAndReturnPerson
    Inherits FormSearchPerson

    'Constructors

    Public Sub New(repository As Repository, gender As Gender)

        MyBase.New(repository)

        InitializeComponent()

        InitializeControls(gender)

    End Sub

    'Events

    Public Event PersonSelected As Action(Of Person)

    'Methods

    Private Sub InitializeControls(gender As Gender)

        RadioButtonMale.Enabled = False

        RadioButtonFemale.Enabled = False

        If gender = Genealogy.Gender.Male Then

            RadioButtonMale.Checked = True

        Else

            RadioButtonFemale.Checked = True

        End If

    End Sub

    Protected Overrides Sub ListBoxPersons_DoubleClick(sender As Object, e As EventArgs)

        If ListBoxPersons.SelectedItem IsNot Nothing Then

            Dim person As Person = CType(ListBoxPersons.SelectedItem, Person)

            RaiseEvent PersonSelected(person)

            Close()

        End If

    End Sub

End Class