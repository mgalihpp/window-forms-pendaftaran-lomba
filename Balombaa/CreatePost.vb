Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CreatePost

    Private apiUrl As String = "http://127.0.0.1:5000/upload"
    Private selectedImageToUpload As String
    Private imageName As String
    Private Judul As String
    Private Tgl_Deadline As Date
    Private TotalHadiah As String
    Private Penyeleggara As String
    Private Tingkat_Pendidikan As String
    Private Tingkat_Wilayah As String
    Private Kategori As String
    Private Deskripsi As String

    Private Sub ButtonUploadGambar_Click(sender As Object, e As EventArgs) Handles ButtonUploadGambar.Click
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImageToUpload = openFileDialog.FileName
            imageName = Path.GetFileName(openFileDialog.FileName)
            PictureBox1.Image = Image.FromFile(selectedImageToUpload)

        End If
    End Sub

    Private Async Sub UploadImage()

        If Not String.IsNullOrEmpty(selectedImageToUpload) Then
            Using client As New HttpClient()
                Using content As New MultipartFormDataContent()
                    Dim fileContent As New ByteArrayContent(File.ReadAllBytes(selectedImageToUpload))
                    fileContent.Headers.ContentType = New Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream")

                    content.Add(fileContent, "file", Path.GetFileName(selectedImageToUpload))

                    Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                    If response.IsSuccessStatusCode Then
                        Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                        Dim result As JObject = JsonConvert.DeserializeObject(Of JObject)(responseContent)
                        'MessageBox.Show($"File uploaded successfully!{Environment.NewLine}Filename: {result("filename")}")
                    Else
                        MessageBox.Show("Failed to upload file.")
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("Please select an image first.")
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSumbitPost.Click

        Dim gambar As String = apiUrl + "s/" + imageName
        Judul = Judul_TextBox.Text
        Tgl_Deadline = TglDeadline_TextBox.Value
        TotalHadiah = TotalHadiah_TextBox.Text
        Penyeleggara = Penyelenggara_ComboBox.Text
        Tingkat_Pendidikan = TingkatPendidikan_ComboBox.Text
        Tingkat_Wilayah = TingkatWilayah_ComboBox.Text
        Kategori = Kategori_ComboBox.Text
        Deskripsi = Deskriptsi_TextBox.Text

        If Not CheckField() Then
            Return
        End If


        UploadImage()

        Db.Post.Create(gambar, Judul, TotalHadiah, Tgl_Deadline, Penyeleggara,
                       Tingkat_Pendidikan, Tingkat_Wilayah,
                       Kategori, Deskripsi
                       )

    End Sub

    Private Function CheckField() As Boolean

        If String.IsNullOrWhiteSpace(Judul) Then
            MessageBox.Show("Judul tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(imageName) Then
            MessageBox.Show("Gambar harus di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim currentDate As DateTime = Date.Now

        ' Validate Tgl_Deadline
        If TglDeadline_TextBox.Value <= TglDeadline_TextBox.MinDate OrElse TglDeadline_TextBox.Value < currentDate.Date Then
            MessageBox.Show("Tanggal Deadline tidak boleh kosong atau tanggal yang sudah lewat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(TotalHadiah) Then
            MessageBox.Show("Total Hadiah tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(Penyeleggara) Then
            MessageBox.Show("Penyeleggara tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(Tingkat_Pendidikan) Then
            MessageBox.Show("Tingkat Pendidikan harus di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(Tingkat_Wilayah) Then
            MessageBox.Show("Tingkat Wilayah harus di isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(Kategori) Then
            MessageBox.Show("Kategori tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(Deskripsi) OrElse Deskripsi.Length < 50 Then
            MessageBox.Show("Deskripsi tidak boleh kosong dan minimal 50 karakter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

End Class
