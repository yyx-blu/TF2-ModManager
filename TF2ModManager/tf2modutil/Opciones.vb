Public Class Opciones

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.steamdir
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.steamdir = TextBox1.Text
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub Opciones_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        Main.Label2.Text = TextBox1.Text
        My.Settings.steamdir = TextBox1.Text
        My.Settings.Save()
        Main.Actualizar()
        Main.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FolderBrowserDialog1
            .Description = "Seleccione su carpeta de Team Fortress 2" & vbCrLf & "\SteamApps\common\Team Fortress 2\tf"
            .ShowNewFolderButton = False
        End With
        'FolderBrowserDialog1.ShowDialog()

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub
End Class