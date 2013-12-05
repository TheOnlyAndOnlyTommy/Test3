Public Class FormShowTree

    'Variables

    Private _repository As Repository

    Private _person As Person

    'Constructors

    Public Sub New(repository As Repository, person As Person)

        InitializeComponent()

        _repository = repository

        _person = person

        WindowState = FormWindowState.Maximized

    End Sub

    'Methods

    Public Sub DrawTree()

        Dim image As New Bitmap(PictureBoxTree.Width, PictureBoxTree.Height)

        Using graph As Graphics = Graphics.FromImage(image)

            graph.Clear(Color.White)

            Dim size As New Size(230, 50)

            'draw center

            Dim center As New Point((image.Width \ 2) - (Size.Width \ 2), (image.Height \ 2) - (Size.Height \ 2))

            DrawPerson(graph, size, center, _person)

            If _person.Father IsNot Nothing Then

                'draw dad

                Dim dad As New Point(center.X - (image.Width \ 4), center.Y - 100)

                DrawPerson(graph, size, dad, _person.Father)

                If _person.Father.Father IsNot Nothing Then

                    'draw dads dad

                    Dim dadsDad As New Point(dad.X - (image.Width \ 8), dad.Y - 100)

                    DrawPerson(graph, size, dadsDad, _person.Father.Father)

                End If

                If _person.Father.Mother IsNot Nothing Then

                    'draw dads mom

                    Dim dadsMom As New Point(dad.X + (image.Width \ 8), dad.Y - 100)

                    DrawPerson(graph, size, dadsMom, _person.Father.Mother)

                End If

            End If

            If _person.Mother IsNot Nothing Then

                'draw mom

                Dim mom As New Point(center.X + (image.Width \ 4), center.Y - 100)

                DrawPerson(graph, size, mom, _person.Mother)

                If _person.Mother.Father IsNot Nothing Then

                    'draw moms dad

                    Dim momsDad As New Point(mom.X - (image.Width \ 8), mom.Y - 100)

                    DrawPerson(graph, size, momsDad, _person.Mother.Father)

                End If

                If _person.Mother.Mother IsNot Nothing Then

                    'draw moms mom

                    Dim momsMom As New Point(mom.X + (image.Width \ 8), mom.Y - 100)

                    DrawPerson(graph, size, momsMom, _person.Mother.Mother)

                End If

            End If

        End Using

        PictureBoxTree.Image = image

    End Sub

    Private Sub DrawPerson(graph As Graphics, size As Size, point As Point, person As Person)

        Dim font As New Font(FontFamily.GenericSerif, 14)

        Dim brush As New SolidBrush(Color.Black)

        Dim pen As New Pen(Color.Black)

        graph.DrawString(person.FullInfo(), font, brush, point)

        graph.DrawRectangle(pen, New Rectangle(point, Size))

    End Sub

    Private Sub FormShowTree_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If _person IsNot Nothing Then

            DrawTree()

        End If

    End Sub

End Class