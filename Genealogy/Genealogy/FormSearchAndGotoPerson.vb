Public Class FormSearchAndGotoPerson
    Inherits FormSearchPerson

    'Constructors

    Public Sub New(repository As Repository)

        MyBase.New(repository)

        InitializeComponent()

    End Sub

    'Methods

    Protected Overrides Sub ListBoxPersons_DoubleClick(sender As Object, e As EventArgs)

        If ListBoxPersons.SelectedItem IsNot Nothing Then

            Dim person As Person = CType(ListBoxPersons.SelectedItem, Person)

            Dim formEditPerson As New FormEditPerson(_repository, person)

            formEditPerson.ShowDialog()

        End If

    End Sub

End Class