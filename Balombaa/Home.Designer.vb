<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseHome = New Button()
        Panel2 = New Panel()
        Akun = New Button()
        ButtonBuat_Lomba = New Button()
        Cari_Lomba = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        BLomba_Terbaru1 = New Button()
        LihatSemuaLomba_Button = New Button()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonCloseHome)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1463, 43)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(71), CByte(132), CByte(246))
        Label1.Location = New Point(14, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 37)
        Label1.TabIndex = 1
        Label1.Text = "Balombaa"
        ' 
        ' ButtonCloseHome
        ' 
        ButtonCloseHome.BackColor = Color.Transparent
        ButtonCloseHome.BackgroundImage = My.Resources.Resources.Close25px
        ButtonCloseHome.BackgroundImageLayout = ImageLayout.Center
        ButtonCloseHome.Dock = DockStyle.Right
        ButtonCloseHome.FlatAppearance.BorderSize = 0
        ButtonCloseHome.FlatStyle = FlatStyle.Flat
        ButtonCloseHome.Location = New Point(1418, 0)
        ButtonCloseHome.Margin = New Padding(3, 4, 3, 4)
        ButtonCloseHome.Name = "ButtonCloseHome"
        ButtonCloseHome.Size = New Size(45, 43)
        ButtonCloseHome.TabIndex = 0
        ButtonCloseHome.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Panel2.Controls.Add(Akun)
        Panel2.Controls.Add(ButtonBuat_Lomba)
        Panel2.Controls.Add(Cari_Lomba)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Panel2.Location = New Point(0, 43)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1463, 276)
        Panel2.TabIndex = 1
        ' 
        ' Akun
        ' 
        Akun.BackgroundImageLayout = ImageLayout.Center
        Akun.FlatAppearance.BorderColor = Color.White
        Akun.FlatStyle = FlatStyle.Flat
        Akun.Image = CType(resources.GetObject("Akun.Image"), Image)
        Akun.Location = New Point(1378, 51)
        Akun.Margin = New Padding(3, 4, 3, 4)
        Akun.Name = "Akun"
        Akun.Size = New Size(46, 53)
        Akun.TabIndex = 6
        Akun.UseVisualStyleBackColor = True
        ' 
        ' ButtonBuat_Lomba
        ' 
        ButtonBuat_Lomba.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        ButtonBuat_Lomba.FlatStyle = FlatStyle.System
        ButtonBuat_Lomba.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonBuat_Lomba.ForeColor = Color.White
        ButtonBuat_Lomba.Location = New Point(252, 208)
        ButtonBuat_Lomba.Margin = New Padding(3, 4, 3, 4)
        ButtonBuat_Lomba.Name = "ButtonBuat_Lomba"
        ButtonBuat_Lomba.RightToLeft = RightToLeft.No
        ButtonBuat_Lomba.Size = New Size(168, 43)
        ButtonBuat_Lomba.TabIndex = 5
        ButtonBuat_Lomba.Text = "Buat Lomba"
        ButtonBuat_Lomba.UseVisualStyleBackColor = False
        ' 
        ' Cari_Lomba
        ' 
        Cari_Lomba.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Cari_Lomba.FlatStyle = FlatStyle.Flat
        Cari_Lomba.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cari_Lomba.ForeColor = Color.White
        Cari_Lomba.Location = New Point(59, 208)
        Cari_Lomba.Margin = New Padding(3, 4, 3, 4)
        Cari_Lomba.Name = "Cari_Lomba"
        Cari_Lomba.RightToLeft = RightToLeft.No
        Cari_Lomba.Size = New Size(168, 43)
        Cari_Lomba.TabIndex = 5
        Cari_Lomba.Text = "Cari Lomba"
        Cari_Lomba.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Label3.Font = New Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(14, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(1019, 100)
        Label3.TabIndex = 3
        Label3.Text = "Balombaa adalah web pusat informasi kompetisi atau lomba." & vbCrLf & "Lihat dan berpartisipasi dalam kompetisi atau post kompetisimu di sini."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Label2.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(14, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(648, 82)
        Label2.TabIndex = 2
        Label2.Text = "A New Champion Awaits!"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(TableLayoutPanel1)
        Panel3.Controls.Add(Label4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 319)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1463, 641)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(BLomba_Terbaru1, 0, 0)
        TableLayoutPanel1.Controls.Add(LihatSemuaLomba_Button, 1, 4)
        TableLayoutPanel1.Location = New Point(59, 76)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(1347, 532)
        TableLayoutPanel1.TabIndex = 11
        ' 
        ' BLomba_Terbaru1
        ' 
        BLomba_Terbaru1.BackColor = Color.White
        BLomba_Terbaru1.Dock = DockStyle.Top
        BLomba_Terbaru1.FlatAppearance.BorderSize = 0
        BLomba_Terbaru1.FlatStyle = FlatStyle.Flat
        BLomba_Terbaru1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BLomba_Terbaru1.Location = New Point(3, 4)
        BLomba_Terbaru1.Margin = New Padding(3, 4, 3, 4)
        BLomba_Terbaru1.Name = "BLomba_Terbaru1"
        BLomba_Terbaru1.Size = New Size(667, 98)
        BLomba_Terbaru1.TabIndex = 1
        BLomba_Terbaru1.Text = "Lomba Esai Mahasiswa - National Essay Oksigen Competition (NEON) 2024" & vbCrLf & "Deadline: 22/6/2024"
        BLomba_Terbaru1.TextAlign = ContentAlignment.MiddleLeft
        BLomba_Terbaru1.UseVisualStyleBackColor = False
        ' 
        ' LihatSemuaLomba_Button
        ' 
        LihatSemuaLomba_Button.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        LihatSemuaLomba_Button.Dock = DockStyle.Top
        LihatSemuaLomba_Button.FlatAppearance.BorderSize = 0
        LihatSemuaLomba_Button.FlatStyle = FlatStyle.Flat
        LihatSemuaLomba_Button.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LihatSemuaLomba_Button.ForeColor = Color.White
        LihatSemuaLomba_Button.Location = New Point(676, 428)
        LihatSemuaLomba_Button.Margin = New Padding(3, 4, 3, 4)
        LihatSemuaLomba_Button.Name = "LihatSemuaLomba_Button"
        LihatSemuaLomba_Button.Size = New Size(668, 100)
        LihatSemuaLomba_Button.TabIndex = 10
        LihatSemuaLomba_Button.Text = "Lihat semua" & vbCrLf & "Klik di sini untuk telusuri semua lomba"
        LihatSemuaLomba_Button.TextAlign = ContentAlignment.MiddleLeft
        LihatSemuaLomba_Button.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(58, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 36)
        Label4.TabIndex = 0
        Label4.Text = "Lomba Terbaru"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Home"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseHome As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cari_Lomba As Button
    Friend WithEvents ButtonBuat_Lomba As Button
    Friend WithEvents Akun As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BLomba_Terbaru1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LihatSemuaLomba_Button As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
