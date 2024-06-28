Imports System.Drawing.Drawing2D
Imports Balombaa.Db

Public Class PostDetails
    Private postId As Integer
    Private loadingForm As FormLoading

    Public Sub New(post As Post)
        ' This call is required by the designer.
        InitializeComponent()

        postId = post.Id
        PictureBox1.LoadAsync(post.Gambar)
        Judul_Label.Text = post.Judul
        Deskripsi_Label.Text = post.Deskripsi
        Deadline_Value.Text = post.TanggalDeadline
        TotalHadiah_Value.Text = $"Rp. {post.TotalHadiah:N0}"
        Peserta_Value.Text = post.TingkatPendidikan
        Penyelenggara_Value.Text = post.Penyelenggara

        Dim isRegistered = Db.Daftar.FindById(postId)
        If isRegistered Then
            Daftar_Button.Enabled = False
            Daftar_Button.BackColor = Color.Gray
            Daftar_Button.ForeColor = Color.DarkGray
            Daftar_Button.Text = "Anda sudah mendaftar"
        End If

        AddHandler Daftar_Button.MouseEnter, AddressOf Daftar_Button_MouseEnter
        AddHandler Daftar_Button.MouseLeave, AddressOf Daftar_Button_MouseLeave
    End Sub


    Private Sub PostDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim radius As Integer = 10 ' Ukuran radius sudut melengkung
        Dim path As New GraphicsPath()

        ' Menambahkan sudut melengkung pada path
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddLine(radius, 0, Me.Width - radius, 0)
        path.AddArc(New Rectangle(Me.Width - radius, 0, radius, radius), -90, 90)
        path.AddLine(Me.Width, radius, Me.Width, Me.Height - radius)
        path.AddArc(New Rectangle(Me.Width - radius, Me.Height - radius, radius, radius), 0, 90)
        path.AddLine(Me.Width - radius, Me.Height, radius, Me.Height)
        path.AddArc(New Rectangle(0, Me.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        ' Mengatur region form dengan path yang telah dibuat
        Me.Region = New Region(path)
    End Sub

    Public Shared Async Sub LoadAndShow(id As Integer)
        Dim loadingForm As New FormLoading()
        loadingForm.Show()
        loadingForm.Refresh()
        Try
            Dim post = Await Task.Run(Function() Db.Post.GetById(id))

            Dim postDetailsForm As New PostDetails(post)

            loadingForm.Close()
            postDetailsForm.ShowDialog()
        Catch ex As Exception
            loadingForm.Close()
            MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonCloseHome_Click(sender As Object, e As EventArgs) Handles ButtonCloseHome.Click
        Application.Exit()
    End Sub

    Private Sub BackHome_Click(sender As Object, e As EventArgs) Handles BackHome.Click
        Dim home As New Home()

        home.Show()
        Me.Close()
    End Sub

    Private Sub Daftar_Button_Click(sender As Object, e As EventArgs) Handles Daftar_Button.Click
        If Not SessionManager.IsUserLoggedIn Then
            MessageBox.Show("Mohon untuk login terlebih dahulu untuk melanjutkan", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login.Show()
            Me.Close()
            Return
        End If


        Dim isRegistered = Db.Daftar.FindById(postId)

        If isRegistered Then
            MessageBox.Show("Anda sudah terdaftar")
            Daftar_Button.Enabled = False
            Daftar_Button.BackColor = Color.Gray
            Daftar_Button.ForeColor = Color.DarkGray
            Daftar_Button.Text = "Anda sudah mendaftar"
            Return
        End If

        Db.Daftar.Create(postId, Date.Now())

        Daftar_Button.Enabled = False
        Daftar_Button.BackColor = Color.Gray
        Daftar_Button.ForeColor = Color.DarkGray
        Daftar_Button.Text = "Anda sudah mendaftar"

    End Sub

    Private Sub Daftar_Button_MouseEnter(sender As Object, e As EventArgs)
        ' Change to a lighter shade of blue on hover
        Daftar_Button.BackColor = Color.FromArgb(CByte(55), CByte(76), CByte(150))
        Daftar_Button.Cursor = Cursors.Hand
    End Sub

    Private Sub Daftar_Button_MouseLeave(sender As Object, e As EventArgs)
        ' Revert back to the original color when the mouse leaves
        Daftar_Button.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Daftar_Button.Cursor = Cursors.Default
    End Sub
End Class
