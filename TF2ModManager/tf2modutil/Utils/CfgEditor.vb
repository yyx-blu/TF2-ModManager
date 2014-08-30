Public Class CfgEditor

    Private Sub CfgEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = IO.File.ReadAllText(My.Settings.texteditor)
            Label1.Text = "Editando: " & My.Settings.texteditor
        Catch ex As Exception
            MsgBox("Hubo un error al cargar el archivo. El error se muestra a continuacion: " + Str(ex), MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub CfgEditor_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        CfgChooser.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.FileSystem.WriteAllText(My.Settings.texteditor, TextBox1.Text, False)
            MsgBox("Configuracion Guardada", MsgBoxStyle.Information, "Listo")
        Catch ex As Exception
            MsgBox("Error al guardar: " + Str(ex), MsgBoxStyle.Critical, "Nope")
        End Try


    End Sub
End Class