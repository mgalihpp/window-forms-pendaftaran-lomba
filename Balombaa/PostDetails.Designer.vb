Imports Microsoft.VisualBasic.Devices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PostDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostDetails))
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseHome = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        BackHome = New Button()
        PictureBox1 = New PictureBox()
        Daftar_Button = New Button()
        Deskripsi_Label = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel6 = New Panel()
        Penyelenggara_Value = New Label()
        Penyelenggara_Label = New Label()
        Panel5 = New Panel()
        Peserta_Value = New Label()
        Peserta_Label = New Label()
        TotalHadiah_Panel = New Panel()
        TotalHadiah_Value = New Label()
        TotalHadiah_Label = New Label()
        Deadline_Panel = New Panel()
        Deadline_Value = New Label()
        Deadline_Label = New Label()
        Judul_Label = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        TotalHadiah_Panel.SuspendLayout()
        Deadline_Panel.SuspendLayout()
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
        Panel1.TabIndex = 2
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
        Panel2.AutoScroll = True
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 43)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1463, 917)
        Panel2.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(BackHome)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Daftar_Button)
        Panel4.Controls.Add(Deskripsi_Label)
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Controls.Add(Judul_Label)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1463, 917)
        Panel4.TabIndex = 2
        ' 
        ' BackHome
        ' 
        BackHome.BackColor = Color.Transparent
        BackHome.Image = CType(resources.GetObject("BackHome.Image"), Image)
        BackHome.Location = New Point(1046, 21)
        BackHome.Name = "BackHome"
        BackHome.Size = New Size(50, 50)
        BackHome.TabIndex = 11
        BackHome.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = My.Resources.Resources.loading_loading_forever
        PictureBox1.Location = New Point(1139, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(282, 416)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' Daftar_Button
        ' 
        Daftar_Button.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Daftar_Button.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Daftar_Button.ForeColor = Color.White
        Daftar_Button.ImageAlign = ContentAlignment.MiddleRight
        Daftar_Button.Location = New Point(1142, 472)
        Daftar_Button.Name = "Daftar_Button"
        Daftar_Button.Size = New Size(279, 58)
        Daftar_Button.TabIndex = 3
        Daftar_Button.Text = "Daftar"
        Daftar_Button.UseVisualStyleBackColor = False
        ' 
        ' Deskripsi_Label
        ' 
        Deskripsi_Label.AutoSize = True
        Deskripsi_Label.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Deskripsi_Label.Location = New Point(38, 141)
        Deskripsi_Label.MaximumSize = New Size(900, 9999)
        Deskripsi_Label.MinimumSize = New Size(900, 200)
        Deskripsi_Label.Name = "Deskripsi_Label"
        Deskripsi_Label.Size = New Size(900, 200)
        Deskripsi_Label.TabIndex = 2
        Deskripsi_Label.Text = "Deskripsi_Post"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel6, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel5, 0, 2)
        TableLayoutPanel1.Controls.Add(TotalHadiah_Panel, 0, 1)
        TableLayoutPanel1.Controls.Add(Deadline_Panel, 0, 0)
        TableLayoutPanel1.Location = New Point(1139, 547)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(285, 363)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Penyelenggara_Value)
        Panel6.Controls.Add(Penyelenggara_Label)
        Panel6.Location = New Point(3, 273)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(279, 84)
        Panel6.TabIndex = 7
        ' 
        ' Penyelenggara_Value
        ' 
        Penyelenggara_Value.AutoSize = True
        Penyelenggara_Value.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Penyelenggara_Value.Location = New Point(14, 41)
        Penyelenggara_Value.Name = "Penyelenggara_Value"
        Penyelenggara_Value.Size = New Size(222, 31)
        Penyelenggara_Value.TabIndex = 4
        Penyelenggara_Value.Text = "{Penyelenggara Value}"
        ' 
        ' Penyelenggara_Label
        ' 
        Penyelenggara_Label.AutoSize = True
        Penyelenggara_Label.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Penyelenggara_Label.Location = New Point(14, 14)
        Penyelenggara_Label.Margin = New Padding(1)
        Penyelenggara_Label.Name = "Penyelenggara_Label"
        Penyelenggara_Label.Size = New Size(126, 26)
        Penyelenggara_Label.TabIndex = 3
        Penyelenggara_Label.Text = "Penyelenggara"
        ' 
        ' Panel5
        ' 
        Panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Peserta_Value)
        Panel5.Controls.Add(Peserta_Label)
        Panel5.Location = New Point(3, 183)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(279, 84)
        Panel5.TabIndex = 6
        ' 
        ' Peserta_Value
        ' 
        Peserta_Value.AutoSize = True
        Peserta_Value.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Peserta_Value.Location = New Point(14, 41)
        Peserta_Value.Name = "Peserta_Value"
        Peserta_Value.Size = New Size(153, 31)
        Peserta_Value.TabIndex = 4
        Peserta_Value.Text = "{Peserta Value}"
        ' 
        ' Peserta_Label
        ' 
        Peserta_Label.AutoSize = True
        Peserta_Label.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Peserta_Label.Location = New Point(14, 14)
        Peserta_Label.Margin = New Padding(1)
        Peserta_Label.Name = "Peserta_Label"
        Peserta_Label.Size = New Size(68, 26)
        Peserta_Label.TabIndex = 3
        Peserta_Label.Text = "Peserta"
        ' 
        ' TotalHadiah_Panel
        ' 
        TotalHadiah_Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TotalHadiah_Panel.BorderStyle = BorderStyle.FixedSingle
        TotalHadiah_Panel.Controls.Add(TotalHadiah_Value)
        TotalHadiah_Panel.Controls.Add(TotalHadiah_Label)
        TotalHadiah_Panel.Location = New Point(3, 93)
        TotalHadiah_Panel.Name = "TotalHadiah_Panel"
        TotalHadiah_Panel.Size = New Size(279, 84)
        TotalHadiah_Panel.TabIndex = 5
        ' 
        ' TotalHadiah_Value
        ' 
        TotalHadiah_Value.AutoSize = True
        TotalHadiah_Value.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalHadiah_Value.Location = New Point(14, 41)
        TotalHadiah_Value.Name = "TotalHadiah_Value"
        TotalHadiah_Value.Size = New Size(195, 31)
        TotalHadiah_Value.TabIndex = 4
        TotalHadiah_Value.Text = "{TotalHadiah Value}"
        ' 
        ' TotalHadiah_Label
        ' 
        TotalHadiah_Label.AutoSize = True
        TotalHadiah_Label.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalHadiah_Label.Location = New Point(14, 14)
        TotalHadiah_Label.Margin = New Padding(1)
        TotalHadiah_Label.Name = "TotalHadiah_Label"
        TotalHadiah_Label.Size = New Size(107, 26)
        TotalHadiah_Label.TabIndex = 3
        TotalHadiah_Label.Text = "Total Hadiah"
        ' 
        ' Deadline_Panel
        ' 
        Deadline_Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Deadline_Panel.BorderStyle = BorderStyle.FixedSingle
        Deadline_Panel.Controls.Add(Deadline_Value)
        Deadline_Panel.Controls.Add(Deadline_Label)
        Deadline_Panel.Location = New Point(3, 3)
        Deadline_Panel.Name = "Deadline_Panel"
        Deadline_Panel.Size = New Size(279, 84)
        Deadline_Panel.TabIndex = 2
        ' 
        ' Deadline_Value
        ' 
        Deadline_Value.AutoSize = True
        Deadline_Value.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Deadline_Value.Location = New Point(14, 41)
        Deadline_Value.Name = "Deadline_Value"
        Deadline_Value.Size = New Size(165, 31)
        Deadline_Value.TabIndex = 4
        Deadline_Value.Text = "{Deadline Value}"
        ' 
        ' Deadline_Label
        ' 
        Deadline_Label.AutoSize = True
        Deadline_Label.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Deadline_Label.Location = New Point(14, 14)
        Deadline_Label.Margin = New Padding(1)
        Deadline_Label.Name = "Deadline_Label"
        Deadline_Label.Size = New Size(79, 26)
        Deadline_Label.TabIndex = 3
        Deadline_Label.Text = "Deadline"
        ' 
        ' Judul_Label
        ' 
        Judul_Label.AutoSize = True
        Judul_Label.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Judul_Label.Location = New Point(38, 21)
        Judul_Label.Name = "Judul_Label"
        Judul_Label.Size = New Size(199, 53)
        Judul_Label.TabIndex = 0
        Judul_Label.Text = "Judul_Post"
        ' 
        ' PostDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "PostDetails"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "PostDetails"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        TotalHadiah_Panel.ResumeLayout(False)
        TotalHadiah_Panel.PerformLayout()
        Deadline_Panel.ResumeLayout(False)
        Deadline_Panel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseHome As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Judul_Label As Label
    Friend WithEvents Deadline_Panel As Panel
    Friend WithEvents Deadline_Value As Label
    Friend WithEvents Deadline_Label As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Penyelenggara_Value As Label
    Friend WithEvents Penyelenggara_Label As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Peserta_Value As Label
    Friend WithEvents Peserta_Label As Label
    Friend WithEvents TotalHadiah_Panel As Panel
    Friend WithEvents TotalHadiah_Value As Label
    Friend WithEvents TotalHadiah_Label As Label
    Friend WithEvents Deskripsi_Label As Label
    Friend WithEvents Daftar_Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackHome As Button
End Class
