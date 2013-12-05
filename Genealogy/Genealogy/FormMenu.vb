Public Class FormMenu

    'Variables

    Private _repository As New Repository()

    'Methods

    Private Sub ButtonCreatePerson_Click(sender As Object, e As EventArgs) Handles ButtonCreatePerson.Click

        Dim formCreatePerson As New FormCreatePerson(_repository)

        AddHandler formCreatePerson.PersonCreated, AddressOf _repository.AddPerson

        formCreatePerson.ShowDialog()

    End Sub

    Private Sub ButtonSearchPerson_Click(sender As Object, e As EventArgs) Handles ButtonSearchPerson.Click

        Dim formSearchAndGotoPerson As New FormSearchAndGotoPerson(_repository)

        formSearchAndGotoPerson.ShowDialog()

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim repository As Repository = FileAccess.ReadFile()

        If repository IsNot Nothing Then

            _repository = repository

        End If

    End Sub

    Private Sub FormMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        FileAccess.WriteFile(_repository)

    End Sub

End Class