Imports System.Data.Odbc
Imports System.Diagnostics.Eventing

Public Class Db
    Public ReadOnly Property Users As New User()
    Public ReadOnly Property Posts As New Post()
    Public ReadOnly Property Daftars As New Daftar()


    Public Class User

        Public Shared Function Login(email As String, password As String) As Boolean

            Rd = FindFirstWhereEmailAndPassword(email, password)

            If Rd.HasRows Then
                Dim id As Integer = Rd.GetInt32(Rd.GetOrdinal("id"))
                Dim username As String = Rd("nama").ToString()
                Dim userEmail As String = Rd("email").ToString()

                SessionManager.CreateSession(id, username, email)

                MessageBox.Show("Login successful! Welcome, " & username, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True
            Else
                MessageBox.Show("User tidak ditemukan. Silahkan Daftar Terlebih dahulu", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End Function

        Public Shared Function Create(name As String, username As String, dDate As Date, email As String, password As String)

            Try
                Call Koneksi()

                Dim query As String = "INSERT INTO user (nama, nama_pengguna, tgl_lahir, email, password) VALUES (?, ?, ?, ?, ?)"
                Using Cmd As New OdbcCommand(query, Conn)
                    Cmd.Parameters.Add(New OdbcParameter("nama", name))
                    Cmd.Parameters.Add(New OdbcParameter("nama_pengguna", username))
                    Cmd.Parameters.Add(New OdbcParameter("tgl_lahir", OdbcType.Date)).Value = dDate
                    Cmd.Parameters.Add(New OdbcParameter("email", email))
                    Cmd.Parameters.Add(New OdbcParameter("password", password))
                    Cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Berhasil Daftar")
                Return True
            Catch e As Exception
                MessageBox.Show("Gagal Daftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Private Shared Function FindFirstWhereEmailAndPassword(email, password)

            Call Koneksi()

            Cmd = New OdbcCommand("Select * From user where email='" & email & "' and password='" & password & "'", Conn)
            Rd = Cmd.ExecuteReader()

            Return Rd
        End Function

    End Class

    Public Class Post

        Public Property Id As Integer
        Public Property Judul As String
        Public Property TotalHadiah As Single
        Public Property TanggalDeadline As Date
        Public Property Penyelenggara As String
        Public Property TingkatPendidikan As String
        Public Property TingkatWilayah As String
        Public Property Kategori As String
        Public Property Deskripsi As String
        Public Property Gambar As String

        Public Shared Sub Create(gambar As String, judul As String, total_hadiah As String, tgl_deadline As String, penyelenggara As String, t_pendidikan As String, t_wilayah As String, kategori As String, deskripsi As String)

            Try
                Call Koneksi()

                Dim query As String = ("INSERT INTO post (judul, total_hadiah, tgl_deadline, penyelenggara, tingkat_pendidikan, tingkat_wilayah, kategori, deskripsi, gambar) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)")

                Using Cmd As New OdbcCommand(query, Conn)
                    Cmd.Parameters.Add(New OdbcParameter("judul", judul))
                    Cmd.Parameters.Add(New OdbcParameter("total_hadiah", Convert.ToSingle(total_hadiah)))
                    Cmd.Parameters.Add(New OdbcParameter("tgl_deadline", OdbcType.Date)).Value = tgl_deadline
                    Cmd.Parameters.Add(New OdbcParameter("penyelenggara", penyelenggara))
                    Cmd.Parameters.Add(New OdbcParameter("tingkat_pendidikan", t_pendidikan))
                    Cmd.Parameters.Add(New OdbcParameter("tingkat_wilayah", t_wilayah))
                    Cmd.Parameters.Add(New OdbcParameter("kategori", kategori))
                    Cmd.Parameters.Add(New OdbcParameter("deskripsi", deskripsi))
                    Cmd.Parameters.Add(New OdbcParameter("gambar", gambar))
                    Cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Berhasil membuat poster lomba!")

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Public Shared Function GetAll() As List(Of Post)
            Dim posts As New List(Of Post)()

            Try
                Call Koneksi()

                Dim query As String = "SELECT * FROM post ORDER BY createdAt DESC"
                Using Cmd As New OdbcCommand(query, Conn)
                    Rd = Cmd.ExecuteReader()
                    While Rd.Read()
                        Dim post As New Post() With {
                            .Id = Rd.GetInt32(Rd.GetOrdinal("id")),
                            .Judul = Rd("judul").ToString(),
                            .TotalHadiah = Single.Parse(Rd("total_hadiah").ToString()),
                            .TanggalDeadline = DateTime.Parse(Rd("tgl_deadline").ToString()),
                            .Penyelenggara = Rd("penyelenggara").ToString(),
                            .TingkatPendidikan = Rd("tingkat_pendidikan").ToString(),
                            .TingkatWilayah = Rd("tingkat_wilayah").ToString(),
                            .Kategori = Rd("kategori").ToString(),
                            .Deskripsi = Rd("deskripsi").ToString(),
                            .Gambar = Rd("gambar").ToString()
                        }
                        posts.Add(post)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error retrieving data: {ex.Message}")
            End Try

            Return posts
        End Function

        Public Shared Function GetById(id As Integer) As Post

            Dim post As New Post()

            Try

                Call Koneksi()

                Dim query As String = $"SELECT * FROM post WHERE id = {id}"
                Cmd = New OdbcCommand(query, Conn)
                Rd = Cmd.ExecuteReader()

                If Rd.Read Then

                    post.Id = Rd.GetInt32(Rd.GetOrdinal("id"))
                    post.Judul = Rd("judul").ToString()
                    post.TotalHadiah = Single.Parse(Rd("total_hadiah").ToString())
                    post.TanggalDeadline = DateTime.Parse(Rd("tgl_deadline").ToString())
                    post.Penyelenggara = Rd("penyelenggara").ToString()
                    post.TingkatPendidikan = Rd("tingkat_pendidikan").ToString()
                    post.TingkatWilayah = Rd("tingkat_wilayah").ToString()
                    post.Kategori = Rd("kategori").ToString()
                    post.Deskripsi = Rd("deskripsi").ToString()
                    post.Gambar = Rd("gambar").ToString()

                End If

            Catch ex As Exception
                MessageBox.Show($"Error retrieving data: {ex.Message}")
            End Try

            Return post
        End Function

        Public Shared Function FindByJudul(judul As String) As List(Of Post)

            Dim posts As New List(Of Post)()

            Try

                Call Koneksi()

                Dim query As String = "SELECT * FROM post WHERE judul LIKE ?"

                Using Cmd As New OdbcCommand(query, Conn)
                    Cmd.Parameters.Add(New OdbcParameter("judul", "%" & judul & "%"))

                    Rd = Cmd.ExecuteReader()

                    While Rd.Read()
                        Dim post As New Post With {
                            .Id = Rd.GetInt32(Rd.GetOrdinal("id")),
                            .Judul = Rd("judul").ToString(),
                            .TotalHadiah = Single.Parse(Rd("total_hadiah").ToString()),
                            .TanggalDeadline = DateTime.Parse(Rd("tgl_deadline").ToString()),
                            .Penyelenggara = Rd("penyelenggara").ToString(),
                            .TingkatPendidikan = Rd("tingkat_pendidikan").ToString(),
                            .TingkatWilayah = Rd("tingkat_wilayah").ToString(),
                            .Kategori = Rd("kategori").ToString(),
                            .Deskripsi = Rd("deskripsi").ToString(),
                            .Gambar = Rd("gambar").ToString()
                        }

                        posts.Add(post)
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error retrieving data: {ex.Message}")
            End Try

            Return posts

        End Function

    End Class

    Public Class Daftar

        Public Shared Sub Create(postId As Integer, tgl_pendaftaran As Date)

            Try
                Dim user = If(SessionManager.CurrentUser, Nothing)

                Call Koneksi()

                Dim query As String = "INSERT INTO pendaftaran (id_user, id_post, tgl_pendaftaran) VALUES (?, ?, ?)"

                Using Cmd As New OdbcCommand(query, Conn)
                    Cmd.Parameters.AddWithValue("id_user", user.Id)
                    Cmd.Parameters.AddWithValue("id_post", postId)
                    Cmd.Parameters.AddWithValue("tgl_pendaftaran", OdbcType.Date).Value = tgl_pendaftaran
                    Cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Daftar berhasil!")

            Catch ex As Exception
                MessageBox.Show($"Error saat mendaftar: {ex.Message}")
            End Try

        End Sub

        Public Shared Function FindById(postId As Integer) As Boolean
            Dim isExists As Boolean = False
            Dim user = SessionManager.CurrentUser

            If user IsNot Nothing Then
                Try
                    Call Koneksi()
                    Dim query As String = $"SELECT * FROM pendaftaran WHERE id_post = {postId} AND id_user = {user.Id}"

                    Using Cmd As New OdbcCommand(query, Conn)
                        Rd = Cmd.ExecuteReader()
                        If Rd.HasRows Then
                            isExists = True
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Error checking registration: {ex.Message}")
                End Try

            Else
                isExists = False
            End If

            Return isExists
        End Function


    End Class

End Class
