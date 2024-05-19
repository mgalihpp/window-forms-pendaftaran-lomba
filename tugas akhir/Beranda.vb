Public Class Beranda
    Private Sub DaftarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarToolStripMenuItem.Click
        Me.Hide()
        Daftar.Show()
    End Sub

    Private Sub MasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasukToolStripMenuItem.Click
        Me.Hide()
        Masuk.Show()
    End Sub

    Private Sub Masuk_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Hide()
        Masuk.Show()
    End Sub

    Private Sub Daftar_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Hide()
        Daftar.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://docs.google.com/document/d/1Z57YeKS5-QdHadtgY5jl_GupbW5DbFCQkwc1C-oiyNw/edit"
        Try
            System.Diagnostics.Process.Start("cmd.exe", "/c start " & url)
        Catch ex As Exception
            MessageBox.Show("Unable to open the web browser.")
        End Try
    End Sub
End Class
