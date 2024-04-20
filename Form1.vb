Imports System.IO
Imports System.Security.Policy
Imports Microsoft.VisualBasic.Logging

Public Class Form1


    Class Zona
        Public tipo_asenta As String
        Public asenta As String
        Public mun As String
        Public estado As String
        Public ciudad As String
        Public cod_postal As String

        Sub Show()
            Dim zona As String

            zona = cod_postal & "-"
            zona &= asenta & "-"
            zona &= tipo_asenta & "-"
            zona &= mun & "-"
            zona &= estado & "-"
            zona &= ciudad
            MsgBox(zona)
        End Sub

    End Class
    Dim zonas As List(Of Zona) = New List(Of Zona)

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
            Dim lines As String()
            Dim file_lines As List(Of String)
            content = My.Computer.FileSystem.ReadAllText(filePath)
            file_lines = content.Split(vbNewLine).ToList()
            file_lines.RemoveRange(0, 2)
            lines = file_lines.ToArray()

            For Each line In lines
                Dim props As String()
                props = line.Split("|")

                If props.Length < 10 Then
                    Continue For
                End If

                Dim zone = New Zona With {
                    .cod_postal = props(0).Trim,
                    .asenta = props(1).Trim,
                    .tipo_asenta = props(2).Trim,
                    .mun = props(3).Trim,
                    .estado = props(4).Trim,
                    .ciudad = props(5).Trim
                }

                zonas.Add(zone)
            Next
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cod As String

        cod = codPost.Text


        Dim collection = zonas.FindAll(Function(z) z.cod_postal = cod)

        For Each item In collection
            item.Show()
        Next



    End Sub
End Class
