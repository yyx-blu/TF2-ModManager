Imports System.IO

Public Class Instalar
    Dim tempmod As String
    Dim tempmodname As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderMod.HelpRequest

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FolderMod
            .Description = "Seleccione la carpeta del Mod a instalar"
            .ShowNewFolderButton = False
        End With
        'FolderBrowserDialog1.ShowDialog()

        If FolderMod.ShowDialog() = DialogResult.OK Then

            tempmod = FolderMod.SelectedPath
            tempmodname = Path.GetFileName(tempmod)

            If Directory.Exists(My.Settings.steamdir & "custom\" & tempmodname) Then
                Directory.Delete(My.Settings.steamdir & "custom\" & tempmodname, True)
                'MsgBox("Se ha borrado para ser remplazado...:" & vbCrLf & My.Settings.steamdir & "custom\" & tempmodname, MsgBoxStyle.Exclamation, "o.o")
            End If

            Try

                Directory.Move(tempmod, My.Settings.steamdir & "custom\" & tempmodname)
                MsgBox(tempmodname & " ha sido instalado", MsgBoxStyle.Information, "Muy bien")
            Catch ex As Exception
                MsgBox("Algo no esperado acaba de ocurrir. El mensaje de error se muestra a continuacion." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error!")
            End Try


        End If
    End Sub

    Private Sub Instalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Instalar_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        Main.Enabled = True
        Main.Actualizar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With FileMod
            .Filter = "Valve ""Pak"" (*.vpk)|*.vpk"
            .Title = "Team Fortress 2 Mod Manager"


        End With
        'FolderBrowserDialog1.ShowDialog()

        If FileMod.ShowDialog() = DialogResult.OK Then

            tempmod = FileMod.FileName
            tempmodname = Path.GetFileName(tempmod)

            If File.Exists(My.Settings.steamdir & "custom\" & tempmodname) Then
                File.Delete(My.Settings.steamdir & "custom\" & tempmodname)
            End If

            Try

                File.Move(tempmod, My.Settings.steamdir & "custom\" & tempmodname)
                MsgBox(tempmodname & " ha sido instalado", MsgBoxStyle.Information, "Muy bien")
            Catch ex As Exception
                MsgBox("Algo no esperado acaba de ocurrir. El mensaje de error se muestra a continuacion." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error!")
            End Try


        End If
    End Sub
End Class