Imports System.IO

Public Class Form1


    Structure Zona
        Dim tipo_asenta As String
        Dim asenta As String
        Dim mun As String
        Dim estado As String
        Dim ciudad As String
        Dim cod_postal As String
    End Structure

    Dim zonas As List(Of Zona)


    Function ExistFile(filepath As String) As Boolean
        Return My.Computer.FileSystem.FileExists(filepath)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechaTxt.Text = Date.Now
        Dim content As String

        Dim items = Application.StartupPath.Split("\")

        items.Resize(items, items.Length - 2)
        Dim proyPath = String.Join("\", items)
        Dim filePath = Path.Combine(proyPath, "codigos_postales.txt")


        If (ExistFile(filePath)) Then
            content = My.Computer.FileSystem.ReadAllText(filePath)
        End If


        MsgBox("Hola mundo")


    End Sub
End Class
