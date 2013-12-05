Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FileAccess

    'Methods

    Public Shared Sub WriteFile(repository As Repository)

        Dim formatter As New BinaryFormatter()

        Using stream As Stream = File.Open("genealogy.data", FileMode.Create)

            formatter.Serialize(stream, repository)

        End Using

    End Sub

    Public Shared Function ReadFile() As Repository

        Dim formatter As New BinaryFormatter()

        Try

            Using stream As Stream = File.Open("genealogy.data", FileMode.Open)

                Return CType(formatter.Deserialize(stream), Repository)

            End Using

        Catch ex As FileNotFoundException

            Return Nothing

        End Try

    End Function

End Class