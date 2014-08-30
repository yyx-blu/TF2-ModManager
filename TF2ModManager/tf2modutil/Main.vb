Imports System.IO

Public Class Main
    Dim steamdir As String
    Dim updatefail As Boolean
    Dim list1, list2 As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Actualizar()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.firstlaunch = True Then
            My.Settings.steamdir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\Steam\SteamApps\common\Team Fortress 2\tf\"
            My.Settings.firstlaunch = False
            My.Settings.Save()
            steamdir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\Steam\SteamApps\common\Team Fortress 2\tf\"

        Else
            steamdir = My.Settings.steamdir
        End If


        
        Try
            Directory.GetDirectories(steamdir)

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Posiblemente tenga steam instalado en otro directorio, Puede seleccionarlo en las opciones", MsgBoxStyle.Exclamation, "Error")
        End Try



        Label2.Text = steamdir

        Actualizar()
        'Label2.Text = CheckedListBox1.Items.Count.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Enabled = False
        Dim checked As String
        Dim tempdir As String
        Dim tempdir2 As String
        checked = 0
        'Activados a desactivados (No se porque carajo no funciona)
        While checked < list1
            If CheckedListBox1.GetItemChecked(checked) = True Then
                'Desactivar Mod
                'Mover el mod a la carpeta desactivada
                'Label2.Text = CheckedListBox1.Items(checked).ToString
                tempdir = CheckedListBox3.Items(checked).ToString
                tempdir2 = steamdir & "cache\"


                If Directory.Exists(tempdir2 & CheckedListBox1.Items(checked).ToString) Then
                    Directory.Delete(tempdir2 & CheckedListBox1.Items(checked).ToString, True)
                End If
                If File.Exists(tempdir2 & CheckedListBox1.Items(checked).ToString) Then
                    File.Delete(tempdir2 & CheckedListBox1.Items(checked).ToString)
                End If
                Directory.Move(tempdir, tempdir2 & CheckedListBox1.Items(checked).ToString)
            End If

            checked += 1
        End While
        
        checked = 0

        'Desactivados a activados (Funciona correctamente)
        'If CheckedListBox2.Items.Count.ToString = 0 Then
        'Else
        While checked < list2
            If CheckedListBox2.GetItemChecked(checked) = True Then
                'Activar Mod
                'Mover el mod a la carpeta activada
                'Label2.Text = CheckedListBox2.Items(checked).ToString
                tempdir2 = CheckedListBox4.Items(checked).ToString
                tempdir = steamdir & "custom\"
                If Directory.Exists(tempdir & CheckedListBox2.Items(checked).ToString) Then
                    Directory.Delete(tempdir & CheckedListBox2.Items(checked).ToString, True)
                    'MsgBox("borrado")
                End If
                If File.Exists(tempdir & CheckedListBox2.Items(checked).ToString) Then
                    File.Delete(tempdir & CheckedListBox2.Items(checked).ToString)
                    'MsgBox("borrado")
                End If
                Directory.Move(tempdir2, tempdir & CheckedListBox2.Items(checked).ToString)
            Else
            End If

            checked += 1
        End While
        'End If

        
        Actualizar()
        'MsgBox("Trabajo Terminado", MsgBoxStyle.Information, "Listo")
        checked = 0
        Me.Enabled = True

    End Sub

    Public Sub Actualizar()
        updatefail = False
        steamdir = Label2.Text
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        CheckedListBox3.Items.Clear()
        CheckedListBox4.Items.Clear()
        'Mods en carpetas

        Try
            For Each Dir As String In Directory.GetDirectories(steamdir & "custom\")
                CheckedListBox1.Items.Add(Path.GetFileName(Dir))
            Next Dir
            For Each Dir As String In Directory.GetDirectories(steamdir & "cache\")
                CheckedListBox2.Items.Add(Path.GetFileName(Dir))
            Next Dir
            For Each Dir As String In Directory.GetDirectories(steamdir & "custom\")
                CheckedListBox3.Items.Add(Path.GetFullPath(Dir))
            Next Dir
            For Each Dir As String In Directory.GetDirectories(steamdir & "cache\")
                CheckedListBox4.Items.Add(Path.GetFullPath(Dir))
            Next Dir
        Catch ex As Exception
            updatefail = True
        End Try

        If updatefail = True Then
            MsgBox("Hubo un error al actualizar la lista de archivos. Se estan buscando en la siguiente ruta." & vbCrLf & steamdir, MsgBoxStyle.Critical, "Error")
            CheckedListBox1.Items.Clear()
            CheckedListBox2.Items.Clear()
            CheckedListBox3.Items.Clear()
            CheckedListBox4.Items.Clear()
        End If
        updatefail = False

        'Mods en Archivos
        Try
            For Each vpk As String In Directory.GetFiles(steamdir & "custom\", "*.vpk")
                CheckedListBox1.Items.Add(Path.GetFileName(vpk))
            Next vpk
            For Each vpk As String In Directory.GetFiles(steamdir & "cache\", "*.vpk")
                CheckedListBox2.Items.Add(Path.GetFileName(vpk))
            Next vpk
            For Each vpk As String In Directory.GetFiles(steamdir & "custom\", "*.vpk")
                CheckedListBox3.Items.Add(Path.GetFullPath(vpk))
            Next vpk
            For Each vpk As String In Directory.GetFiles(steamdir & "cache\", "*.vpk")
                CheckedListBox4.Items.Add(Path.GetFullPath(vpk))
            Next vpk
        Catch ex As Exception
            updatefail = True
        End Try
        If updatefail = True Then
            MsgBox("Hubo un error al actualizar la lista de archivos. Se estan buscando en la siguiente ruta." & vbCrLf & steamdir, MsgBoxStyle.Critical, "Error")
            CheckedListBox1.Items.Clear()
            CheckedListBox2.Items.Clear()
            CheckedListBox3.Items.Clear()
            CheckedListBox4.Items.Clear()
        End If
        Label2.Text = steamdir
        'Label2.Text = CheckedListBox2.Items.Count.ToString
        list1 = CheckedListBox1.Items.Count.ToString
        list2 = CheckedListBox2.Items.Count.ToString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Enabled = False
        Opciones.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Instalar.Show()
        Me.Enabled = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        About.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Utils.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("explorer.exe " & steamdir,AppWinStyle.NormalFocus)
    End Sub
End Class
