Public Class Welcome
    Private Sub Button_BuatPost_Click(sender As Object, e As EventArgs) Handles Button_BuatPost.Click

        Dim PanelCreatePost As New CreatePost()

        PostLomba.Panel3.Controls.Clear()
        PostLomba.Panel3.Controls.Add(PanelCreatePost)

    End Sub

    Private Sub BackHome_Click(sender As Object, e As EventArgs) Handles BackHome.Click


        Dim Home As New Home()

        PostLomba.Close()
        Home.Show()

    End Sub
End Class
