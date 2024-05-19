<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daftar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        inputPanel = New Panel()
        Nama = New Label()
        Alamat = New Label()
        No_Kontak = New Label()
        Email = New Label()
        Jenis_Kelamin = New Label()
        Judul_Poster = New Label()
        Daftar_Button = New Button()
        Nama_TextBox = New TextBox()
        No_Hp_TextBox = New TextBox()
        Email_TextBox = New TextBox()
        Jenis_Kelamin_ComboBox = New ComboBox()
        Password_TextBox = New TextBox()
        Sudah_Daftar_Label = New Label()
        Masuk_LinkLabel = New LinkLabel()
        Daftar_Heading_Label = New Label()
        DateTimePicker1 = New DateTimePicker()
        MenuStrip1 = New MenuStrip()
        BerandaToolStripMenuItem = New ToolStripMenuItem()
        PengumumanToolStripMenuItem = New ToolStripMenuItem()
        MasukDaftarToolStripMenuItem = New ToolStripMenuItem()
        MasukToolStripMenuItem = New ToolStripMenuItem()
        DaftarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' inputPanel
        ' 
        inputPanel.BackColor = Color.LightGray
        inputPanel.Dock = DockStyle.Fill
        inputPanel.Location = New Point(0, 0)
        inputPanel.Margin = New Padding(10)
        inputPanel.Name = "inputPanel"
        inputPanel.Padding = New Padding(20)
        inputPanel.Size = New Size(200, 100)
        inputPanel.TabIndex = 0
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Location = New Point(197, 209)
        Nama.Name = "Nama"
        Nama.Size = New Size(49, 20)
        Nama.TabIndex = 0
        Nama.Text = "Nama"
        ' 
        ' Alamat
        ' 
        Alamat.AutoSize = True
        Alamat.Location = New Point(197, 324)
        Alamat.Name = "Alamat"
        Alamat.Size = New Size(55, 20)
        Alamat.TabIndex = 1
        Alamat.Text = "No. HP"
        ' 
        ' No_Kontak
        ' 
        No_Kontak.AutoSize = True
        No_Kontak.Location = New Point(197, 267)
        No_Kontak.Name = "No_Kontak"
        No_Kontak.Size = New Size(97, 20)
        No_Kontak.TabIndex = 2
        No_Kontak.Text = "Tanggal Lahir"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(197, 439)
        Email.Name = "Email"
        Email.Size = New Size(46, 20)
        Email.TabIndex = 3
        Email.Text = "Email"
        ' 
        ' Jenis_Kelamin
        ' 
        Jenis_Kelamin.AutoSize = True
        Jenis_Kelamin.Location = New Point(197, 381)
        Jenis_Kelamin.Name = "Jenis_Kelamin"
        Jenis_Kelamin.Size = New Size(98, 20)
        Jenis_Kelamin.TabIndex = 4
        Jenis_Kelamin.Text = "Jenis Kelamin"
        ' 
        ' Judul_Poster
        ' 
        Judul_Poster.AutoSize = True
        Judul_Poster.Location = New Point(197, 496)
        Judul_Poster.Name = "Judul_Poster"
        Judul_Poster.Size = New Size(70, 20)
        Judul_Poster.TabIndex = 6
        Judul_Poster.Text = "Password"
        ' 
        ' Daftar_Button
        ' 
        Daftar_Button.BackColor = Color.DarkBlue
        Daftar_Button.FlatAppearance.BorderSize = 0
        Daftar_Button.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        Daftar_Button.FlatAppearance.MouseOverBackColor = Color.LightBlue
        Daftar_Button.FlatStyle = FlatStyle.Flat
        Daftar_Button.Font = New Font("Arial", 12F, FontStyle.Bold)
        Daftar_Button.ForeColor = Color.White
        Daftar_Button.Location = New Point(342, 553)
        Daftar_Button.Name = "Daftar_Button"
        Daftar_Button.Size = New Size(154, 52)
        Daftar_Button.TabIndex = 7
        Daftar_Button.Text = "Daftar"
        Daftar_Button.UseVisualStyleBackColor = False
        ' 
        ' Nama_TextBox
        ' 
        Nama_TextBox.Location = New Point(325, 204)
        Nama_TextBox.Name = "Nama_TextBox"
        Nama_TextBox.Size = New Size(218, 27)
        Nama_TextBox.TabIndex = 8
        ' 
        ' No_Hp_TextBox
        ' 
        No_Hp_TextBox.Location = New Point(325, 319)
        No_Hp_TextBox.Name = "No_Hp_TextBox"
        No_Hp_TextBox.Size = New Size(218, 27)
        No_Hp_TextBox.TabIndex = 9
        ' 
        ' Email_TextBox
        ' 
        Email_TextBox.Location = New Point(325, 433)
        Email_TextBox.Name = "Email_TextBox"
        Email_TextBox.Size = New Size(218, 27)
        Email_TextBox.TabIndex = 11
        ' 
        ' Jenis_Kelamin_ComboBox
        ' 
        Jenis_Kelamin_ComboBox.AccessibleDescription = "Pilih Jenis Kelamin Anda"
        Jenis_Kelamin_ComboBox.AccessibleName = "Pilih Jenis Kelamin Anda"
        Jenis_Kelamin_ComboBox.AccessibleRole = AccessibleRole.ComboBox
        Jenis_Kelamin_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Jenis_Kelamin_ComboBox.FormattingEnabled = True
        Jenis_Kelamin_ComboBox.Items.AddRange(New Object() {"Pria", "Wanita"})
        Jenis_Kelamin_ComboBox.Location = New Point(325, 376)
        Jenis_Kelamin_ComboBox.Name = "Jenis_Kelamin_ComboBox"
        Jenis_Kelamin_ComboBox.Size = New Size(143, 28)
        Jenis_Kelamin_ComboBox.TabIndex = 12
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Location = New Point(325, 491)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.Size = New Size(218, 27)
        Password_TextBox.TabIndex = 17
        ' 
        ' Sudah_Daftar_Label
        ' 
        Sudah_Daftar_Label.AutoSize = True
        Sudah_Daftar_Label.Location = New Point(343, 619)
        Sudah_Daftar_Label.Name = "Sudah_Daftar_Label"
        Sudah_Daftar_Label.Size = New Size(105, 20)
        Sudah_Daftar_Label.TabIndex = 18
        Sudah_Daftar_Label.Text = "Sudah daftar ?"
        ' 
        ' Masuk_LinkLabel
        ' 
        Masuk_LinkLabel.AutoSize = True
        Masuk_LinkLabel.Location = New Point(433, 619)
        Masuk_LinkLabel.Name = "Masuk_LinkLabel"
        Masuk_LinkLabel.Size = New Size(46, 20)
        Masuk_LinkLabel.TabIndex = 19
        Masuk_LinkLabel.TabStop = True
        Masuk_LinkLabel.Text = "Login"
        ' 
        ' Daftar_Heading_Label
        ' 
        Daftar_Heading_Label.AutoSize = True
        Daftar_Heading_Label.BorderStyle = BorderStyle.FixedSingle
        Daftar_Heading_Label.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Daftar_Heading_Label.Location = New Point(325, 112)
        Daftar_Heading_Label.Name = "Daftar_Heading_Label"
        Daftar_Heading_Label.Size = New Size(165, 38)
        Daftar_Heading_Label.TabIndex = 20
        Daftar_Heading_Label.Text = "Buat Akun"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(325, 261)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(218, 27)
        DateTimePicker1.TabIndex = 21
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BerandaToolStripMenuItem, PengumumanToolStripMenuItem, MasukDaftarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(782, 30)
        MenuStrip1.TabIndex = 22
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BerandaToolStripMenuItem
        ' 
        BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        BerandaToolStripMenuItem.Size = New Size(78, 24)
        BerandaToolStripMenuItem.Text = "Beranda"
        ' 
        ' PengumumanToolStripMenuItem
        ' 
        PengumumanToolStripMenuItem.Name = "PengumumanToolStripMenuItem"
        PengumumanToolStripMenuItem.Size = New Size(113, 24)
        PengumumanToolStripMenuItem.Text = "Pengumuman"
        ' 
        ' MasukDaftarToolStripMenuItem
        ' 
        MasukDaftarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MasukToolStripMenuItem, DaftarToolStripMenuItem})
        MasukDaftarToolStripMenuItem.Name = "MasukDaftarToolStripMenuItem"
        MasukDaftarToolStripMenuItem.Size = New Size(113, 24)
        MasukDaftarToolStripMenuItem.Text = "Masuk/Daftar"
        ' 
        ' MasukToolStripMenuItem
        ' 
        MasukToolStripMenuItem.Name = "MasukToolStripMenuItem"
        MasukToolStripMenuItem.Size = New Size(134, 26)
        MasukToolStripMenuItem.Text = "Masuk"
        ' 
        ' DaftarToolStripMenuItem
        ' 
        DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        DaftarToolStripMenuItem.Size = New Size(134, 26)
        DaftarToolStripMenuItem.Text = "Daftar"
        ' 
        ' Daftar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 753)
        Controls.Add(MenuStrip1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Daftar_Heading_Label)
        Controls.Add(Masuk_LinkLabel)
        Controls.Add(Sudah_Daftar_Label)
        Controls.Add(Password_TextBox)
        Controls.Add(Jenis_Kelamin_ComboBox)
        Controls.Add(Email_TextBox)
        Controls.Add(No_Hp_TextBox)
        Controls.Add(Nama_TextBox)
        Controls.Add(Daftar_Button)
        Controls.Add(Judul_Poster)
        Controls.Add(Jenis_Kelamin)
        Controls.Add(Email)
        Controls.Add(No_Kontak)
        Controls.Add(Alamat)
        Controls.Add(Nama)
        Name = "Daftar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Daftar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nama As Label
    Friend WithEvents Alamat As Label
    Friend WithEvents No_Kontak As Label
    Friend WithEvents Email As Label
    Friend WithEvents Jenis_Kelamin As Label
    Friend WithEvents Judul_Poster As Label
    Friend WithEvents Daftar_Button As Button
    Friend WithEvents Nama_TextBox As TextBox
    Friend WithEvents No_Hp_TextBox As TextBox
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents Jenis_Kelamin_ComboBox As ComboBox
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents Sudah_Daftar_Label As Label
    Friend WithEvents Masuk_LinkLabel As LinkLabel
    Friend WithEvents Daftar_Heading_Label As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengumumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasukDaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents inputPanel As Panel
End Class
