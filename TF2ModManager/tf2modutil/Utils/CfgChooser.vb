Imports System.IO

Public Class CfgChooser
    Dim cfgdir As String
    Private Sub Cargar(clase As String)
        Dim archivo As String
        archivo = cfgdir + clase + ".cfg"

        If File.Exists(archivo) Then
            My.Settings.texteditor = archivo
            CfgEditor.Show()
        Else
            Dim archivo2 As New IO.StreamWriter(archivo, True)
            archivo2.WriteLine(" ")
            archivo2.Close()
            My.Settings.texteditor = archivo
            MsgBox("Se creo un archivo de configuracion nuevo", MsgBoxStyle.Information, "Info")
            CfgEditor.Show()
        End If
    End Sub
    Private Sub CfgChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cfgdir = My.Settings.steamdir + "cfg\"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'SelectConf.Show()

        With OpenFileDialog1
            .Filter = "Archivo de Configuracion (*.cfg)|*.cfg"
            .Title = "Seleccione el archivo que desee editar"
            .InitialDirectory = My.Settings.steamdir & "cfg\"
        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.texteditor = OpenFileDialog1.FileName
            'MsgBox(My.Settings.texteditor)
            Me.Enabled = False
            CfgEditor.Show()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Scout
        Cargar("scout")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Soldier
        Cargar("soldier")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Pyro
        Cargar("pyro")
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Demoman
        Cargar("demoman")
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Heavy
        Cargar("heavyweapons")
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Engineer
        Cargar("engineer")
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Medic
        Cargar("medic")
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Sniper
        Cargar("sniper")
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Spy
        Cargar("spy")
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Autoexec
        Cargar("autoexec")
        Me.Close()
    End Sub
End Class