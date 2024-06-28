Imports System.Drawing.Drawing2D

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
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

        LoadDataIntoTableLayoutPanel()

        Try
            Call Koneksi()
        Catch ex As Exception
            MessageBox.Show("error", ex.Message)
        End Try
    End Sub
    Private Sub ButtonCloseHome_Click(sender As Object, e As EventArgs) Handles ButtonCloseHome.Click
        Application.Exit()
    End Sub

    Private Sub Akun_Click(sender As Object, e As EventArgs) Handles Akun.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Cari_Lomba_Click(sender As Object, e As EventArgs) Handles Cari_Lomba.Click
        CariLomba.Show()
        Me.Hide()
    End Sub

    Private Sub Cari_Lomba_Paint(sender As Object, e As PaintEventArgs) Handles Cari_Lomba.Paint
        'Dim radius As Integer = 10 ' Ukuran radius sudut melengkung
        'Dim path As New GraphicsPath()

        '' Menambahkan sudut melengkung pada path
        'path.StartFigure()
        'path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        'path.AddLine(radius, 0, Cari_Lomba.Width - radius, 0)
        'path.AddArc(New Rectangle(Cari_Lomba.Width - radius, 0, radius, radius), -90, 90)
        'path.AddLine(Cari_Lomba.Width, radius, Cari_Lomba.Width, Cari_Lomba.Height - radius)
        'path.AddArc(New Rectangle(Cari_Lomba.Width - radius, Cari_Lomba.Height - radius, radius, radius), 0, 90)
        'path.AddLine(Cari_Lomba.Width - radius, Cari_Lomba.Height, radius, Cari_Lomba.Height)
        'path.AddArc(New Rectangle(0, Cari_Lomba.Height - radius, radius, radius), 90, 90)
        'path.CloseFigure()
        'Cari_Lomba.Region = New Region(path)

    End Sub

    Private Sub Buat_Lomba_Click(sender As Object, e As EventArgs) Handles ButtonBuat_Lomba.Click
        CaraBuatLomba.Show()
        Me.Hide()
    End Sub

    Private Sub LoadDataIntoTableLayoutPanel()
        Try

            Dim Posts = Db.Post.GetAll()

            Me.TableLayoutPanel1.Controls.Clear()

            If Posts IsNot Nothing Then
                Dim rowIndex As Integer = 0

                For Each post In Posts

                    If rowIndex >= 9 Then

                        LihatSemuaLomba_Button = New Button With {
                            .BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138)),
                            .Dock = DockStyle.Top
                        }
                        LihatSemuaLomba_Button.FlatAppearance.BorderSize = 0
                        LihatSemuaLomba_Button.FlatStyle = FlatStyle.Flat
                        LihatSemuaLomba_Button.Font = New Font("Poppins", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
                        LihatSemuaLomba_Button.ForeColor = Color.White
                        LihatSemuaLomba_Button.Location = New Point(676, 428)
                        LihatSemuaLomba_Button.Margin = New Padding(3, 4, 3, 4)
                        LihatSemuaLomba_Button.Name = "LihatSemuaLomba_Button"
                        LihatSemuaLomba_Button.Size = New Size(667, 100)
                        LihatSemuaLomba_Button.TabIndex = 10
                        LihatSemuaLomba_Button.Text = "Lihat semua" & vbCrLf & "Klik di sini untuk telusuri semua lomba"
                        LihatSemuaLomba_Button.TextAlign = ContentAlignment.MiddleLeft
                        LihatSemuaLomba_Button.UseVisualStyleBackColor = False

                        AddHandler LihatSemuaLomba_Button.Click, AddressOf Cari_Lomba_Click

                        TableLayoutPanel1.Controls.Add(LihatSemuaLomba_Button, 1, 4)

                        Exit For
                    End If

                    Dim button As New Button With {
                        .BackColor = Color.White,
                        .Dock = DockStyle.Top
                    }
                    button.FlatAppearance.BorderSize = 0
                    button.Font = New Font("Poppins", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
                    button.FlatStyle = FlatStyle.Flat
                    button.Margin = New Padding(3, 4, 3, 4)
                    button.Size = New Size(667, 98)
                    button.TextAlign = ContentAlignment.MiddleLeft
                    button.UseVisualStyleBackColor = False

                    Dim deadline As DateTime = Convert.ToDateTime(post.TanggalDeadline)
                    Dim formattedDeadline As String = deadline.ToString("dd/MM/yyyy")
                    Dim columnIndex As Integer = rowIndex Mod 2

                    button.Text = $"{post.Judul}" & vbCrLf & $"Deadline: {formattedDeadline}"
                    button.Tag = post.Id

                    AddHandler button.Click, AddressOf PostLomba_Click
                    AddHandler button.MouseEnter, AddressOf Button_MouseEnter
                    AddHandler button.MouseLeave, AddressOf Button_MouseLeave

                    TableLayoutPanel1.Controls.Add(button, columnIndex, rowIndex \ 2)
                    rowIndex += 1
                Next
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub PostLomba_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)

        Dim id As Integer = Convert.ToInt32(button.Tag)


        PostDetails.LoadAndShow(id)
        Me.Hide()
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        button.Cursor = Cursors.Hand
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        button.Cursor = Cursors.Default
    End Sub

End Class
