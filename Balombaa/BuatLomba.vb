Public Class CaraBuatLomba
    Private Sub ButtonCloseHome_Click(sender As Object, e As EventArgs) Handles ButtonCloseHome.Click
        Application.Exit()
    End Sub

    Private Sub Akun_Click(sender As Object, e As EventArgs) Handles Akun.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ButtonPost_Lomba_Click(sender As Object, e As EventArgs) Handles ButtonPost_Lomba.Click
        PostLomba.Show()
        Me.Close()

    End Sub

    Private Sub BackHome_Click(sender As Object, e As EventArgs) Handles BackHome.Click

        Dim Home As New Home()

        Me.Close()
        Home.Show()
    End Sub
End Class