Public Class PostLomba

    Private Sub PostLomba2(sender As Object, e As EventArgs) Handles Me.Load

        Dim PanelHome As New Welcome()

        Me.Panel3.Controls.Clear()
        Me.Panel3.Controls.Add(PanelHome)
    End Sub


    Private Sub ButtonCloseHome_Click(sender As Object, e As EventArgs) Handles ButtonCloseHome.Click
        Application.Exit()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click

        Dim PanelHome As New Welcome()

        Me.Panel3.Controls.Clear()
        Me.Panel3.Controls.Add(PanelHome)
    End Sub

    Private Sub ButtonListPost_Click(sender As Object, e As EventArgs) Handles ButtonListPost.Click

        Dim PanelListPost As New ListPost()

        Me.Panel3.Controls.Clear()
        Me.Panel3.Controls.Add(PanelListPost)
    End Sub

    Private Sub ButtonCreatePost_Click(sender As Object, e As EventArgs) Handles ButtonCreatePost.Click

        Dim PanelCreatePost As New CreatePost()

        Me.Panel3.Controls.Clear()
        Me.Panel3.Controls.Add(PanelCreatePost)
    End Sub
End Class