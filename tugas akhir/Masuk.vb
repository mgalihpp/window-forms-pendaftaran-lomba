Public Class Masuk
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Daftar_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Daftar_LinkLabel.LinkClicked
        Me.Close()
        Daftar.Show()
    End Sub
End Class