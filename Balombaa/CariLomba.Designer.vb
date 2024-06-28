<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariLomba
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CariLomba))
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseHome = New Button()
        FilterJudul_TextBox = New TextBox()
        CariLomba_Button = New Button()
        BLomba_Panel = New Panel()
        LihatSelengkapnya_Label = New LinkLabel()
        Hadiah_Label = New Label()
        Deadline_Lomba = New Label()
        JudulLomba_Label = New Label()
        Gambar1 = New PictureBox()
        BackHome = New Button()
        ToolTip1 = New ToolTip(components)
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1.SuspendLayout()
        BLomba_Panel.SuspendLayout()
        CType(Gambar1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 1
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
        ' FilterJudul_TextBox
        ' 
        FilterJudul_TextBox.Font = New Font("Segoe UI", 13F)
        FilterJudul_TextBox.Location = New Point(280, 102)
        FilterJudul_TextBox.Name = "FilterJudul_TextBox"
        FilterJudul_TextBox.Size = New Size(896, 36)
        FilterJudul_TextBox.TabIndex = 2
        FilterJudul_TextBox.Text = "Cari Lomba..."
        ' 
        ' CariLomba_Button
        ' 
        CariLomba_Button.BackColor = Color.Transparent
        CariLomba_Button.Image = My.Resources.Resources.Search
        CariLomba_Button.Location = New Point(1182, 102)
        CariLomba_Button.Name = "CariLomba_Button"
        CariLomba_Button.Size = New Size(39, 36)
        CariLomba_Button.TabIndex = 3
        CariLomba_Button.UseVisualStyleBackColor = False
        ' 
        ' BLomba_Panel
        ' 
        BLomba_Panel.BorderStyle = BorderStyle.FixedSingle
        BLomba_Panel.Controls.Add(LihatSelengkapnya_Label)
        BLomba_Panel.Controls.Add(Hadiah_Label)
        BLomba_Panel.Controls.Add(Deadline_Lomba)
        BLomba_Panel.Controls.Add(JudulLomba_Label)
        BLomba_Panel.Controls.Add(Gambar1)
        BLomba_Panel.Location = New Point(3, 3)
        BLomba_Panel.Name = "BLomba_Panel"
        BLomba_Panel.Size = New Size(534, 159)
        BLomba_Panel.TabIndex = 4
        ' 
        ' LihatSelengkapnya_Label
        ' 
        LihatSelengkapnya_Label.AutoSize = True
        LihatSelengkapnya_Label.Location = New Point(141, 117)
        LihatSelengkapnya_Label.Name = "LihatSelengkapnya_Label"
        LihatSelengkapnya_Label.Size = New Size(137, 20)
        LihatSelengkapnya_Label.TabIndex = 4
        LihatSelengkapnya_Label.TabStop = True
        LihatSelengkapnya_Label.Text = "Lihat Selengkapnya"
        ' 
        ' Hadiah_Label
        ' 
        Hadiah_Label.AutoSize = True
        Hadiah_Label.Location = New Point(141, 88)
        Hadiah_Label.Name = "Hadiah_Label"
        Hadiah_Label.Size = New Size(57, 20)
        Hadiah_Label.TabIndex = 3
        Hadiah_Label.Text = "Hadiah"
        ' 
        ' Deadline_Lomba
        ' 
        Deadline_Lomba.AutoSize = True
        Deadline_Lomba.Location = New Point(141, 59)
        Deadline_Lomba.Name = "Deadline_Lomba"
        Deadline_Lomba.Size = New Size(69, 20)
        Deadline_Lomba.TabIndex = 2
        Deadline_Lomba.Text = "Deadline"
        ' 
        ' JudulLomba_Label
        ' 
        JudulLomba_Label.AutoSize = True
        JudulLomba_Label.Location = New Point(141, 30)
        JudulLomba_Label.Name = "JudulLomba_Label"
        JudulLomba_Label.Size = New Size(93, 20)
        JudulLomba_Label.TabIndex = 1
        JudulLomba_Label.Text = "Judul Lomba"
        ' 
        ' Gambar1
        ' 
        Gambar1.Dock = DockStyle.Left
        Gambar1.InitialImage = My.Resources.Resources.loading_loading_forever_resize
        Gambar1.Location = New Point(0, 0)
        Gambar1.Name = "Gambar1"
        Gambar1.Size = New Size(122, 157)
        Gambar1.TabIndex = 0
        Gambar1.TabStop = False
        ' 
        ' BackHome
        ' 
        BackHome.BackColor = Color.Transparent
        BackHome.Image = CType(resources.GetObject("BackHome.Image"), Image)
        BackHome.Location = New Point(1336, 786)
        BackHome.Name = "BackHome"
        BackHome.Size = New Size(50, 50)
        BackHome.TabIndex = 10
        ToolTip1.SetToolTip(BackHome, "Kembali Ke Home")
        BackHome.UseVisualStyleBackColor = False
        ' 
        ' ToolTip1
        ' 
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(BLomba_Panel, 0, 0)
        TableLayoutPanel1.Location = New Point(206, 173)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(1081, 663)
        TableLayoutPanel1.TabIndex = 11
        ' 
        ' CariLomba
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(BackHome)
        Controls.Add(CariLomba_Button)
        Controls.Add(FilterJudul_TextBox)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Name = "CariLomba"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CariLomba"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        BLomba_Panel.ResumeLayout(False)
        BLomba_Panel.PerformLayout()
        CType(Gambar1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseHome As Button
    Friend WithEvents FilterJudul_TextBox As TextBox
    Friend WithEvents CariLomba_Button As Button
    Friend WithEvents BLomba_Panel As Panel
    Friend WithEvents Gambar1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents JudulLomba_Label As Label
    Friend WithEvents Deadline_Lomba As Label
    Friend WithEvents LihatSelengkapnya_Label As LinkLabel
    Friend WithEvents Hadiah_Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BackHome As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
