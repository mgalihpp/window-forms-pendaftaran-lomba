<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePost
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelCreatePostIsi = New Panel()
        ButtonSumbitPost = New Button()
        Deskriptsi_TextBox = New RichTextBox()
        Label10 = New Label()
        TotalHadiah_TextBox = New TextBox()
        Penyelenggara_ComboBox = New ComboBox()
        Kategori_ComboBox = New ComboBox()
        Label8 = New Label()
        Label9 = New Label()
        TingkatWilayah_ComboBox = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        TingkatPendidikan_ComboBox = New ComboBox()
        Label5 = New Label()
        TglDeadline_TextBox = New DateTimePicker()
        Label4 = New Label()
        Judul_TextBox = New TextBox()
        Label3 = New Label()
        ButtonUploadGambar = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PanelCreatePostIsi.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCreatePostIsi
        ' 
        PanelCreatePostIsi.BackColor = Color.White
        PanelCreatePostIsi.BorderStyle = BorderStyle.FixedSingle
        PanelCreatePostIsi.Controls.Add(ButtonSumbitPost)
        PanelCreatePostIsi.Controls.Add(Deskriptsi_TextBox)
        PanelCreatePostIsi.Controls.Add(Label10)
        PanelCreatePostIsi.Controls.Add(TotalHadiah_TextBox)
        PanelCreatePostIsi.Controls.Add(Penyelenggara_ComboBox)
        PanelCreatePostIsi.Controls.Add(Kategori_ComboBox)
        PanelCreatePostIsi.Controls.Add(Label8)
        PanelCreatePostIsi.Controls.Add(Label9)
        PanelCreatePostIsi.Controls.Add(TingkatWilayah_ComboBox)
        PanelCreatePostIsi.Controls.Add(Label6)
        PanelCreatePostIsi.Controls.Add(Label7)
        PanelCreatePostIsi.Controls.Add(TingkatPendidikan_ComboBox)
        PanelCreatePostIsi.Controls.Add(Label5)
        PanelCreatePostIsi.Controls.Add(TglDeadline_TextBox)
        PanelCreatePostIsi.Controls.Add(Label4)
        PanelCreatePostIsi.Controls.Add(Judul_TextBox)
        PanelCreatePostIsi.Controls.Add(Label3)
        PanelCreatePostIsi.Controls.Add(ButtonUploadGambar)
        PanelCreatePostIsi.Controls.Add(PictureBox1)
        PanelCreatePostIsi.Controls.Add(Label2)
        PanelCreatePostIsi.Dock = DockStyle.Fill
        PanelCreatePostIsi.Location = New Point(0, 0)
        PanelCreatePostIsi.Margin = New Padding(3, 4, 3, 4)
        PanelCreatePostIsi.Name = "PanelCreatePostIsi"
        PanelCreatePostIsi.Size = New Size(1218, 911)
        PanelCreatePostIsi.TabIndex = 1
        ' 
        ' ButtonSumbitPost
        ' 
        ButtonSumbitPost.BackColor = Color.White
        ButtonSumbitPost.Font = New Font("Poppins", 10.8F)
        ButtonSumbitPost.Location = New Point(1008, 727)
        ButtonSumbitPost.Margin = New Padding(3, 4, 3, 4)
        ButtonSumbitPost.Name = "ButtonSumbitPost"
        ButtonSumbitPost.Size = New Size(149, 53)
        ButtonSumbitPost.TabIndex = 27
        ButtonSumbitPost.Text = "Submit"
        ButtonSumbitPost.UseVisualStyleBackColor = False
        ' 
        ' Deskriptsi_TextBox
        ' 
        Deskriptsi_TextBox.BorderStyle = BorderStyle.FixedSingle
        Deskriptsi_TextBox.Font = New Font("Poppins", 9F)
        Deskriptsi_TextBox.Location = New Point(53, 369)
        Deskriptsi_TextBox.Margin = New Padding(3, 4, 3, 4)
        Deskriptsi_TextBox.Name = "Deskriptsi_TextBox"
        Deskriptsi_TextBox.Size = New Size(1103, 348)
        Deskriptsi_TextBox.TabIndex = 26
        Deskriptsi_TextBox.Text = ""
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 10.8F)
        Label10.Location = New Point(46, 328)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 31)
        Label10.TabIndex = 25
        Label10.Text = "Deskripsi"
        ' 
        ' TotalHadiah_TextBox
        ' 
        TotalHadiah_TextBox.BorderStyle = BorderStyle.FixedSingle
        TotalHadiah_TextBox.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalHadiah_TextBox.Location = New Point(559, 164)
        TotalHadiah_TextBox.Margin = New Padding(3, 4, 3, 4)
        TotalHadiah_TextBox.Name = "TotalHadiah_TextBox"
        TotalHadiah_TextBox.Size = New Size(286, 30)
        TotalHadiah_TextBox.TabIndex = 24
        ' 
        ' Penyelenggara_ComboBox
        ' 
        Penyelenggara_ComboBox.Font = New Font("Poppins", 9F)
        Penyelenggara_ComboBox.FormattingEnabled = True
        Penyelenggara_ComboBox.Items.AddRange(New Object() {"Osis", "Ekskul", "Himpunan", "BEM", "UKM"})
        Penyelenggara_ComboBox.Location = New Point(870, 163)
        Penyelenggara_ComboBox.Margin = New Padding(3, 4, 3, 4)
        Penyelenggara_ComboBox.Name = "Penyelenggara_ComboBox"
        Penyelenggara_ComboBox.Size = New Size(286, 34)
        Penyelenggara_ComboBox.TabIndex = 23
        ' 
        ' Kategori_ComboBox
        ' 
        Kategori_ComboBox.Font = New Font("Poppins", 9F)
        Kategori_ComboBox.FormattingEnabled = True
        Kategori_ComboBox.Items.AddRange(New Object() {"Esport", "Gambar", "Desain", "Karya Tulis Ilmiah", "Puisi", "Pidato", "Olimpiade"})
        Kategori_ComboBox.Location = New Point(870, 251)
        Kategori_ComboBox.Margin = New Padding(3, 4, 3, 4)
        Kategori_ComboBox.Name = "Kategori_ComboBox"
        Kategori_ComboBox.Size = New Size(286, 34)
        Kategori_ComboBox.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 10.8F)
        Label8.Location = New Point(870, 203)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 31)
        Label8.TabIndex = 20
        Label8.Text = "Kategori"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Poppins", 10.8F)
        Label9.Location = New Point(870, 115)
        Label9.Name = "Label9"
        Label9.Size = New Size(150, 31)
        Label9.TabIndex = 19
        Label9.Text = "Penyelenggara"
        ' 
        ' TingkatWilayah_ComboBox
        ' 
        TingkatWilayah_ComboBox.Font = New Font("Poppins", 9F)
        TingkatWilayah_ComboBox.FormattingEnabled = True
        TingkatWilayah_ComboBox.Items.AddRange(New Object() {"Desa", "Kota", "Kabupaten", "Provinsi", "Nasional", "Internasional"})
        TingkatWilayah_ComboBox.Location = New Point(559, 251)
        TingkatWilayah_ComboBox.Margin = New Padding(3, 4, 3, 4)
        TingkatWilayah_ComboBox.Name = "TingkatWilayah_ComboBox"
        TingkatWilayah_ComboBox.Size = New Size(286, 34)
        TingkatWilayah_ComboBox.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10.8F)
        Label6.Location = New Point(559, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 31)
        Label6.TabIndex = 16
        Label6.Text = "Tingkat Wilayah"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 10.8F)
        Label7.Location = New Point(559, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 31)
        Label7.TabIndex = 14
        Label7.Text = "Total Hadiah"
        ' 
        ' TingkatPendidikan_ComboBox
        ' 
        TingkatPendidikan_ComboBox.Font = New Font("Poppins", 9F)
        TingkatPendidikan_ComboBox.FormattingEnabled = True
        TingkatPendidikan_ComboBox.Items.AddRange(New Object() {"SMA", "SMP", "SD", "TK", "Umum", "Mahasiswa"})
        TingkatPendidikan_ComboBox.Location = New Point(234, 251)
        TingkatPendidikan_ComboBox.Margin = New Padding(3, 4, 3, 4)
        TingkatPendidikan_ComboBox.Name = "TingkatPendidikan_ComboBox"
        TingkatPendidikan_ComboBox.Size = New Size(286, 34)
        TingkatPendidikan_ComboBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 10.8F)
        Label5.Location = New Point(234, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 31)
        Label5.TabIndex = 11
        Label5.Text = "Tingkat Pendidikan"
        ' 
        ' TglDeadline_TextBox
        ' 
        TglDeadline_TextBox.Font = New Font("Poppins", 9F)
        TglDeadline_TextBox.Location = New Point(234, 164)
        TglDeadline_TextBox.Margin = New Padding(3, 4, 3, 4)
        TglDeadline_TextBox.Name = "TglDeadline_TextBox"
        TglDeadline_TextBox.Size = New Size(286, 30)
        TglDeadline_TextBox.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 10.8F)
        Label4.Location = New Point(234, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 31)
        Label4.TabIndex = 8
        Label4.Text = "Deadline"
        ' 
        ' Judul_TextBox
        ' 
        Judul_TextBox.BorderStyle = BorderStyle.FixedSingle
        Judul_TextBox.Font = New Font("Poppins", 9F)
        Judul_TextBox.Location = New Point(234, 76)
        Judul_TextBox.Margin = New Padding(3, 4, 3, 4)
        Judul_TextBox.Name = "Judul_TextBox"
        Judul_TextBox.Size = New Size(922, 30)
        Judul_TextBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 10.8F)
        Label3.Location = New Point(234, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 31)
        Label3.TabIndex = 6
        Label3.Text = "Judul"
        ' 
        ' ButtonUploadGambar
        ' 
        ButtonUploadGambar.BackColor = Color.White
        ButtonUploadGambar.FlatStyle = FlatStyle.System
        ButtonUploadGambar.Font = New Font("Poppins", 10.8F)
        ButtonUploadGambar.Location = New Point(30, 228)
        ButtonUploadGambar.Margin = New Padding(3, 4, 3, 4)
        ButtonUploadGambar.Name = "ButtonUploadGambar"
        ButtonUploadGambar.Size = New Size(149, 53)
        ButtonUploadGambar.TabIndex = 5
        ButtonUploadGambar.Text = "Upload"
        ButtonUploadGambar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(46, 83)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 10.8F)
        Label2.Location = New Point(30, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 31)
        Label2.TabIndex = 0
        Label2.Text = "Upload Gambar"
        ' 
        ' CreatePost
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(PanelCreatePostIsi)
        Name = "CreatePost"
        Size = New Size(1218, 911)
        PanelCreatePostIsi.ResumeLayout(False)
        PanelCreatePostIsi.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCreatePostIsi As Panel
    Friend WithEvents ButtonSumbitPost As Button
    Friend WithEvents Deskriptsi_TextBox As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TotalHadiah_TextBox As TextBox
    Friend WithEvents Penyelenggara_ComboBox As ComboBox
    Friend WithEvents Kategori_ComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TingkatWilayah_ComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TingkatPendidikan_ComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TglDeadline_TextBox As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Judul_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonUploadGambar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label

End Class
