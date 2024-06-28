Imports Balombaa.Db

Public Class CariLomba


    Private Async Sub CariLomba_Load(sender As Object, e As EventArgs) Handles Me.Load

        Await LoadDataIntoTableLayoutPanel()

    End Sub

    Private Sub ButtonCloseHome_Click(sender As Object, e As EventArgs) Handles ButtonCloseHome.Click
        Application.Exit()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        ' Buat instance ToolTip
        Dim ToolTip1 As New ToolTip()


        ' Tetapkan teks ToolTip untuk button1
        ToolTip1.SetToolTip(Me.BackHome, "Kembali Ke Home")
    End Sub

    Private Sub BackHome_Click(sender As Object, e As EventArgs) Handles BackHome.Click

        Dim Home As New Home()

        Home.Show()
        Me.Close()
    End Sub

    Private Async Function LoadDataIntoTableLayoutPanel(Optional filterJudul As String = "") As Task
        Try

            Dim posts As List(Of Post)

            If String.IsNullOrWhiteSpace(filterJudul) Then
                posts = Await Task.Run(Function() Db.Post.GetAll())
            Else
                posts = Await Task.Run(Function() Db.Post.FindByJudul(filterJudul))
            End If

            Me.TableLayoutPanel1.Controls.Clear()

            If posts IsNot Nothing Then
                Dim rowIndex = 0

                For Each post As Post In posts

                    If rowIndex >= 8 Then

                        Exit For

                    End If

                    Dim panel As New Panel()
                    Dim lihatSelengkapnya As New LinkLabel()
                    Dim hadiah As New Label()
                    Dim judul As New Label()
                    Dim deadline As New Label()
                    Dim gambar As New PictureBox With {
                    .Dock = DockStyle.Left,
                    .Location = New Point(0, 0),
                    .Name = "Gambar1",
                    .Size = New Size(122, 153),
                    .TabIndex = 0,
                    .TabStop = False,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .InitialImage = My.Resources.Resources.loading_loading_forever_resize,
                    .WaitOnLoad = True
                    }

                    lihatSelengkapnya.AutoSize = True
                    lihatSelengkapnya.Location = New Point(141, 117)
                    lihatSelengkapnya.Name = "LihatSelengkapnya_Label"
                    lihatSelengkapnya.Size = New Size(137, 20)
                    lihatSelengkapnya.TabIndex = 4
                    lihatSelengkapnya.TabStop = True
                    lihatSelengkapnya.Text = "Lihat Selengkapnya"

                    hadiah.AutoSize = True
                    hadiah.Location = New Point(141, 88)
                    hadiah.Name = "Hadiah_Label"
                    hadiah.Size = New Size(57, 20)
                    hadiah.TabIndex = 3
                    hadiah.Text = $"Rp. {post.TotalHadiah:N0}"

                    judul.AutoSize = True
                    judul.Location = New Point(141, 30)
                    judul.Name = "JudulLomba_Label"
                    judul.Size = New Size(93, 20)
                    judul.MaximumSize = New Size(350, 20)
                    judul.AutoEllipsis = True
                    judul.TabIndex = 1
                    judul.Text = post.Judul

                    deadline.AutoSize = True
                    deadline.Location = New Point(141, 59)
                    deadline.Name = "Deadline_Lomba"
                    deadline.Size = New Size(69, 20)
                    deadline.TabIndex = 2
                    deadline.Text = post.TanggalDeadline

                    gambar.LoadAsync(post.Gambar)

                    panel.BorderStyle = BorderStyle.FixedSingle
                    panel.Controls.Add(lihatSelengkapnya)
                    panel.Controls.Add(hadiah)
                    panel.Controls.Add(deadline)
                    panel.Controls.Add(judul)
                    panel.Controls.Add(gambar)
                    panel.Location = New Point(3, 3)
                    panel.Name = "BLomba_Panel"
                    panel.Size = New Size(534, 159)
                    panel.TabIndex = 4

                    lihatSelengkapnya.Tag = post.Id

                    AddHandler lihatSelengkapnya.Click, AddressOf LihatSelengkapnya_Click
                    AddHandler lihatSelengkapnya.MouseEnter, AddressOf Button_MouseEnter
                    AddHandler lihatSelengkapnya.MouseLeave, AddressOf Button_MouseLeave

                    Dim columnIndex As Integer = rowIndex Mod 2

                    TableLayoutPanel1.Controls.Add(panel, columnIndex, rowIndex \ 2)
                    rowIndex += 1
                Next
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}")

        End Try
    End Function

    Private Async Sub CariLombaButton_Click(sender As Object, e As EventArgs) Handles CariLomba_Button.Click

        Dim filter As String = FilterJudul_TextBox.Text

        If filter = "Cari Lomba..." Then
            filter = ""

        Else
            filter = filter
        End If

        If String.IsNullOrWhiteSpace(filter) Then
            Return
        End If

        Await LoadDataIntoTableLayoutPanel(filter)

    End Sub

    Private Sub FilterJudul_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FilterJudul_TextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Panggil event handler Click dari CariLomba_Button
            CariLomba_Button.PerformClick()
        End If
    End Sub

    Private Sub LihatSelengkapnya_Click(sender As Object, e As EventArgs)
        Dim label As LinkLabel = CType(sender, LinkLabel)

        Dim id As Integer = Convert.ToInt32(label.Tag)

        PostDetails.LoadAndShow(id)
        Me.Close()
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim button As LinkLabel = CType(sender, LinkLabel)
        button.Cursor = Cursors.Hand
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim button As LinkLabel = CType(sender, LinkLabel)
        button.Cursor = Cursors.Default
    End Sub

    Private Sub FilterJudul_TextBox_LostFocus(sender As Object, e As EventArgs) Handles FilterJudul_TextBox.LostFocus

        Dim filter = FilterJudul_TextBox

        If filter.Text = "" Then
            filter.Text = "Cari Lomba..."

        Else
            filter.Text = filter.Text
        End If

    End Sub


    Private Sub FilterJudul_TextBox_GotFocus(sender As Object, e As EventArgs) Handles FilterJudul_TextBox.GotFocus

        Dim filter = FilterJudul_TextBox

        filter.Text = ""

    End Sub
End Class