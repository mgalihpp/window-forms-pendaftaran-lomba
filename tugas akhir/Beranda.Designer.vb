<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Beranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beranda))
        MenuStrip1 = New MenuStrip()
        BerandaToolStripMenuItem = New ToolStripMenuItem()
        PengumumanToolStripMenuItem = New ToolStripMenuItem()
        MasukDaftarToolStripMenuItem = New ToolStripMenuItem()
        MasukToolStripMenuItem = New ToolStripMenuItem()
        DaftarToolStripMenuItem = New ToolStripMenuItem()
        BindingSource1 = New BindingSource(components)
        Title_Label = New Label()
        Batas_Label = New Label()
        Tanggal_Label1 = New Label()
        strip_Label = New Label()
        Babak_Label = New Label()
        Tanggal_Label2 = New Label()
        Pengumuman_Label = New Label()
        Jenis_Label2 = New Label()
        Jenis_Label = New Label()
        Tentang_Label = New Label()
        Desc_Label = New Label()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        List2_Label4 = New Label()
        List2_Label3 = New Label()
        List2_Label2 = New Label()
        List2_Label1 = New Label()
        Panel1 = New Panel()
        Berikut_Label = New Label()
        List_Label3 = New Label()
        List_Label2 = New Label()
        List_Label1 = New Label()
        Silahkan_Label = New Label()
        Tema_Label = New Label()
        Persyaratan_Label = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BerandaToolStripMenuItem, PengumumanToolStripMenuItem, MasukDaftarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(782, 30)
        MenuStrip1.TabIndex = 0
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
        ' Title_Label
        ' 
        Title_Label.AutoSize = True
        Title_Label.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title_Label.Location = New Point(15, 23)
        Title_Label.Name = "Title_Label"
        Title_Label.Size = New Size(290, 35)
        Title_Label.TabIndex = 1
        Title_Label.Text = "Lomba Poster 2024"
        ' 
        ' Batas_Label
        ' 
        Batas_Label.AutoSize = True
        Batas_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Batas_Label.ForeColor = Color.DimGray
        Batas_Label.Location = New Point(22, 82)
        Batas_Label.Name = "Batas_Label"
        Batas_Label.Size = New Size(161, 19)
        Batas_Label.TabIndex = 2
        Batas_Label.Text = "Batas pendaftaraan :"
        ' 
        ' Tanggal_Label1
        ' 
        Tanggal_Label1.AutoSize = True
        Tanggal_Label1.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tanggal_Label1.ForeColor = Color.Black
        Tanggal_Label1.Location = New Point(69, 111)
        Tanggal_Label1.Name = "Tanggal_Label1"
        Tanggal_Label1.Size = New Size(106, 19)
        Tanggal_Label1.TabIndex = 3
        Tanggal_Label1.Text = "20 Juni 2024"
        ' 
        ' strip_Label
        ' 
        strip_Label.AutoSize = True
        strip_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        strip_Label.ForeColor = Color.DimGray
        strip_Label.Location = New Point(260, 111)
        strip_Label.Name = "strip_Label"
        strip_Label.Size = New Size(15, 19)
        strip_Label.TabIndex = 5
        strip_Label.Text = "-"
        ' 
        ' Babak_Label
        ' 
        Babak_Label.AutoSize = True
        Babak_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Babak_Label.ForeColor = Color.DimGray
        Babak_Label.Location = New Point(213, 82)
        Babak_Label.Name = "Babak_Label"
        Babak_Label.Size = New Size(149, 19)
        Babak_Label.TabIndex = 4
        Babak_Label.Text = "Babak penyisihan :"
        ' 
        ' Tanggal_Label2
        ' 
        Tanggal_Label2.AutoSize = True
        Tanggal_Label2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tanggal_Label2.ForeColor = Color.Black
        Tanggal_Label2.Location = New Point(443, 111)
        Tanggal_Label2.Name = "Tanggal_Label2"
        Tanggal_Label2.Size = New Size(106, 19)
        Tanggal_Label2.TabIndex = 7
        Tanggal_Label2.Text = "27 Juni 2024"
        ' 
        ' Pengumuman_Label
        ' 
        Pengumuman_Label.AutoSize = True
        Pengumuman_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Pengumuman_Label.ForeColor = Color.DimGray
        Pengumuman_Label.Location = New Point(396, 82)
        Pengumuman_Label.Name = "Pengumuman_Label"
        Pengumuman_Label.Size = New Size(160, 19)
        Pengumuman_Label.TabIndex = 6
        Pengumuman_Label.Text = "Pengumuman juara :"
        ' 
        ' Jenis_Label2
        ' 
        Jenis_Label2.AutoSize = True
        Jenis_Label2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Jenis_Label2.ForeColor = Color.Black
        Jenis_Label2.Location = New Point(614, 111)
        Jenis_Label2.Name = "Jenis_Label2"
        Jenis_Label2.Size = New Size(103, 19)
        Jenis_Label2.TabIndex = 9
        Jenis_Label2.Text = "Seni / Bakat"
        ' 
        ' Jenis_Label
        ' 
        Jenis_Label.AutoSize = True
        Jenis_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Jenis_Label.ForeColor = Color.DimGray
        Jenis_Label.Location = New Point(567, 82)
        Jenis_Label.Name = "Jenis_Label"
        Jenis_Label.Size = New Size(131, 19)
        Jenis_Label.TabIndex = 8
        Jenis_Label.Text = "Jenis kompetisi :"
        ' 
        ' Tentang_Label
        ' 
        Tentang_Label.AutoSize = True
        Tentang_Label.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tentang_Label.ForeColor = Color.DimGray
        Tentang_Label.Location = New Point(22, 175)
        Tentang_Label.Name = "Tentang_Label"
        Tentang_Label.Size = New Size(134, 23)
        Tentang_Label.TabIndex = 10
        Tentang_Label.Text = "Tentang Event"
        ' 
        ' Desc_Label
        ' 
        Desc_Label.AutoSize = True
        Desc_Label.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Desc_Label.Location = New Point(22, 218)
        Desc_Label.MaximumSize = New Size(730, 0)
        Desc_Label.Name = "Desc_Label"
        Desc_Label.Size = New Size(727, 84)
        Desc_Label.TabIndex = 11
        Desc_Label.Text = resources.GetString("Desc_Label.Text")
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(List2_Label4)
        Panel2.Controls.Add(List2_Label3)
        Panel2.Controls.Add(List2_Label2)
        Panel2.Controls.Add(List2_Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Berikut_Label)
        Panel2.Controls.Add(List_Label3)
        Panel2.Controls.Add(List_Label2)
        Panel2.Controls.Add(List_Label1)
        Panel2.Controls.Add(Silahkan_Label)
        Panel2.Controls.Add(Tema_Label)
        Panel2.Controls.Add(Persyaratan_Label)
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Controls.Add(Desc_Label)
        Panel2.Controls.Add(Tentang_Label)
        Panel2.Controls.Add(Jenis_Label2)
        Panel2.Controls.Add(Jenis_Label)
        Panel2.Controls.Add(Tanggal_Label2)
        Panel2.Controls.Add(Pengumuman_Label)
        Panel2.Controls.Add(strip_Label)
        Panel2.Controls.Add(Babak_Label)
        Panel2.Controls.Add(Tanggal_Label1)
        Panel2.Controls.Add(Batas_Label)
        Panel2.Controls.Add(Title_Label)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 30)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(782, 723)
        Panel2.TabIndex = 13
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(96, 1107)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(165, 20)
        LinkLabel1.TabIndex = 27
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Peraturan Lomba Poster"
        ' 
        ' List2_Label4
        ' 
        List2_Label4.AutoSize = True
        List2_Label4.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List2_Label4.Location = New Point(74, 1088)
        List2_Label4.MaximumSize = New Size(500, 0)
        List2_Label4.Name = "List2_Label4"
        List2_Label4.Size = New Size(492, 19)
        List2_Label4.TabIndex = 26
        List2_Label4.Text = "4. Peserta membuat poster dengan mengikuti panduan berikut ini :"
        ' 
        ' List2_Label3
        ' 
        List2_Label3.AutoSize = True
        List2_Label3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List2_Label3.Location = New Point(74, 1055)
        List2_Label3.MaximumSize = New Size(500, 0)
        List2_Label3.Name = "List2_Label3"
        List2_Label3.Size = New Size(212, 19)
        List2_Label3.TabIndex = 25
        List2_Label3.Text = "3. Biaya pendaftaran gratis."
        ' 
        ' List2_Label2
        ' 
        List2_Label2.AutoSize = True
        List2_Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List2_Label2.Location = New Point(74, 1024)
        List2_Label2.MaximumSize = New Size(500, 0)
        List2_Label2.Name = "List2_Label2"
        List2_Label2.Size = New Size(201, 19)
        List2_Label2.TabIndex = 24
        List2_Label2.Text = "2. Lomba bersifat individu."
        ' 
        ' List2_Label1
        ' 
        List2_Label1.AutoSize = True
        List2_Label1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List2_Label1.Location = New Point(74, 996)
        List2_Label1.MaximumSize = New Size(500, 0)
        List2_Label1.Name = "List2_Label1"
        List2_Label1.Size = New Size(292, 19)
        List2_Label1.TabIndex = 23
        List2_Label1.Text = "1. Lomba poster dibuka bagi siapapun."
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(493, 1003)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 329)
        Panel1.TabIndex = 22
        ' 
        ' Berikut_Label
        ' 
        Berikut_Label.AutoSize = True
        Berikut_Label.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Berikut_Label.Location = New Point(51, 962)
        Berikut_Label.Name = "Berikut_Label"
        Berikut_Label.Size = New Size(475, 24)
        Berikut_Label.TabIndex = 21
        Berikut_Label.Text = "Berikut ini persyaratan pendaftaran lomba poster"
        ' 
        ' List_Label3
        ' 
        List_Label3.AutoSize = True
        List_Label3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List_Label3.Location = New Point(74, 893)
        List_Label3.Name = "List_Label3"
        List_Label3.Size = New Size(253, 19)
        List_Label3.TabIndex = 20
        List_Label3.Text = "• Masyarakat Sehat, Negara Maju"
        ' 
        ' List_Label2
        ' 
        List_Label2.AutoSize = True
        List_Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List_Label2.Location = New Point(74, 864)
        List_Label2.Name = "List_Label2"
        List_Label2.Size = New Size(246, 19)
        List_Label2.TabIndex = 19
        List_Label2.Text = "• Akses Kesehatan untuk Semua"
        ' 
        ' List_Label1
        ' 
        List_Label1.AutoSize = True
        List_Label1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List_Label1.Location = New Point(74, 834)
        List_Label1.Name = "List_Label1"
        List_Label1.Size = New Size(201, 19)
        List_Label1.TabIndex = 18
        List_Label1.Text = "• Inovasi dalam Kesehatan"
        ' 
        ' Silahkan_Label
        ' 
        Silahkan_Label.AutoSize = True
        Silahkan_Label.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Silahkan_Label.Location = New Point(51, 804)
        Silahkan_Label.Name = "Silahkan_Label"
        Silahkan_Label.Size = New Size(350, 19)
        Silahkan_Label.TabIndex = 16
        Silahkan_Label.Text = "Silakan pilih salah satu tema poster berikut ini :"
        ' 
        ' Tema_Label
        ' 
        Tema_Label.AutoSize = True
        Tema_Label.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tema_Label.Location = New Point(51, 770)
        Tema_Label.Name = "Tema_Label"
        Tema_Label.Size = New Size(129, 24)
        Tema_Label.TabIndex = 15
        Tema_Label.Text = "Tema Poster"
        ' 
        ' Persyaratan_Label
        ' 
        Persyaratan_Label.AutoSize = True
        Persyaratan_Label.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Persyaratan_Label.ForeColor = Color.DimGray
        Persyaratan_Label.Location = New Point(22, 705)
        Persyaratan_Label.Name = "Persyaratan_Label"
        Persyaratan_Label.Size = New Size(241, 32)
        Persyaratan_Label.TabIndex = 14
        Persyaratan_Label.Text = "Persyaratan Event"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.5454559F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.4545441F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 223.0F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox3, 2, 0)
        TableLayoutPanel1.Location = New Point(43, 329)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(5)
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(674, 302)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.gambar1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(8, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 286)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.gambar2
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(226, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(216, 286)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.gambar3
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(448, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(218, 286)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Beranda
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 753)
        Controls.Add(Panel2)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Beranda"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Beranda"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengumumanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasukDaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Title_Label As Label
    Friend WithEvents Batas_Label As Label
    Friend WithEvents Tanggal_Label1 As Label
    Friend WithEvents strip_Label As Label
    Friend WithEvents Babak_Label As Label
    Friend WithEvents Tanggal_Label2 As Label
    Friend WithEvents Pengumuman_Label As Label
    Friend WithEvents Jenis_Label2 As Label
    Friend WithEvents Jenis_Label As Label
    Friend WithEvents Tentang_Label As Label
    Friend WithEvents Desc_Label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Tema_Label As Label
    Friend WithEvents Persyaratan_Label As Label
    Friend WithEvents Silahkan_Label As Label
    Friend WithEvents List_Label3 As Label
    Friend WithEvents List_Label2 As Label
    Friend WithEvents List_Label1 As Label
    Friend WithEvents Berikut_Label As Label
    Friend WithEvents List2_Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents List2_Label4 As Label
    Friend WithEvents List2_Label3 As Label
    Friend WithEvents List2_Label2 As Label

End Class
