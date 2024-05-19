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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Panel1 = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(260, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 19)
        Label1.TabIndex = 5
        Label1.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(213, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 19)
        Label2.TabIndex = 4
        Label2.Text = "Babak penyisihan :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(443, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 19)
        Label3.TabIndex = 7
        Label3.Text = "27 Juni 2024"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(396, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 19)
        Label4.TabIndex = 6
        Label4.Text = "Pengumuman juara :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(614, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 19)
        Label5.TabIndex = 9
        Label5.Text = "Seni / Bakat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(567, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 19)
        Label6.TabIndex = 8
        Label6.Text = "Jenis kompetisi :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(22, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 23)
        Label7.TabIndex = 10
        Label7.Text = "Tentang Event"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(22, 218)
        Label8.MaximumSize = New Size(730, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(727, 84)
        Label8.TabIndex = 11
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(TableLayoutPanel1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
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
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(74, 1088)
        Label19.MaximumSize = New Size(500, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(492, 19)
        Label19.TabIndex = 26
        Label19.Text = "4. Peserta membuat poster dengan mengikuti panduan berikut ini :"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(74, 1055)
        Label18.MaximumSize = New Size(500, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(212, 19)
        Label18.TabIndex = 25
        Label18.Text = "3. Biaya pendaftaran gratis."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(74, 1024)
        Label17.MaximumSize = New Size(500, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(201, 19)
        Label17.TabIndex = 24
        Label17.Text = "2. Lomba bersifat individu."
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(74, 996)
        Label16.MaximumSize = New Size(500, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(292, 19)
        Label16.TabIndex = 23
        Label16.Text = "1. Lomba poster dibuka bagi siapapun."
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(493, 1003)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 329)
        Panel1.TabIndex = 22
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(51, 962)
        Label15.Name = "Label15"
        Label15.Size = New Size(475, 24)
        Label15.TabIndex = 21
        Label15.Text = "Berikut ini persyaratan pendaftaran lomba poster"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(74, 893)
        Label14.Name = "Label14"
        Label14.Size = New Size(253, 19)
        Label14.TabIndex = 20
        Label14.Text = "• Masyarakat Sehat, Negara Maju"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(74, 864)
        Label13.Name = "Label13"
        Label13.Size = New Size(246, 19)
        Label13.TabIndex = 19
        Label13.Text = "• Akses Kesehatan untuk Semua"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(74, 834)
        Label12.Name = "Label12"
        Label12.Size = New Size(201, 19)
        Label12.TabIndex = 18
        Label12.Text = "• Inovasi dalam Kesehatan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(51, 804)
        Label11.Name = "Label11"
        Label11.Size = New Size(350, 19)
        Label11.TabIndex = 16
        Label11.Text = "Silakan pilih salah satu tema poster berikut ini :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(51, 770)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 24)
        Label10.TabIndex = 15
        Label10.Text = "Tema Poster"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(22, 705)
        Label9.Name = "Label9"
        Label9.Size = New Size(241, 32)
        Label9.TabIndex = 14
        Label9.Text = "Persyaratan Event"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label

End Class
