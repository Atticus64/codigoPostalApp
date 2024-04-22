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


    Sub AgregarUnicos(lista As ComboBox.ObjectCollection, elem As String)

        Dim found = False

        For Each e In lista
            If e = elem Then
                found = True
            End If
        Next

        If Not found Then
            lista.Add(elem)
        End If
    End Sub


    Sub AgregarZona(z As Zona)

        AgregarUnicos(estadoBox.Items, z.estado)
        AgregarUnicos(MunicipioBox.Items, z.mun)
        AgregarUnicos(AsentamientoBox.Items, z.asenta)
        AgregarUnicos(TipAsentaBox.Items, z.tipo_asenta)
        AgregarUnicos(CiudadBox.Items, z.ciudad)
    End Sub

    Sub LimpiarBoxes()
        estadoBox.Items.Clear()
        MunicipioBox.Items.Clear()
        AsentamientoBox.Items.Clear()
        TipAsentaBox.Items.Clear()
        CiudadBox.Items.Clear()
    End Sub

    Sub DatosPorDefecto()
        estadoBox.Text = estadoBox.Items(0)
        MunicipioBox.Text = MunicipioBox.Items(0)
        CiudadBox.Text = CiudadBox.Items(0)
        AsentamientoBox.Text = AsentamientoBox.Items(0)
        TipAsentaBox.Text = TipAsentaBox.Items(0)
    End Sub


    Private Sub BuscarCp()

        Dim cod As String

        cod = CodPost.Text

        Dim coincidences = zonas.FindAll(
            Function(z) z.cod_postal = cod
        )

        If (coincidences.Count = 0) Then
            MsgBox("Codigo postal no encontrado", MsgBoxStyle.Exclamation)
            Return
        End If

        LimpiarBoxes()
        For Each z In coincidences
            AgregarZona(z)
        Next

        DatosPorDefecto()


    End Sub

    Private Sub codPost_TextChanged(sender As Object, e As EventArgs) Handles CodPost.TextChanged

        If Not CodPost.Text.Length = 5 Then
            Return
        End If

        BuscarCp()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
