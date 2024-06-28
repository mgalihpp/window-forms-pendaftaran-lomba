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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseDaftar = New Button()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel_Daftar = New Panel()
        Login_LinkLabel = New LinkLabel()
        Tanggal_LahirLabel = New Label()
        Tanggal_lahirTextbox = New DateTimePicker()
        UsernameTextbox = New TextBox()
        Password_TextBox = New TextBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        DaftarLabel = New Label()
        NamaTextbox = New TextBox()
        Email_Textbox = New TextBox()
        ButtonDaftar = New Button()
        NamaLabel = New Label()
        Email_Label = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel_Daftar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonCloseDaftar)
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
        Label1.ForeColor = Color.FromArgb(CByte(225), CByte(169), CByte(3))
        Label1.Location = New Point(14, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 37)
        Label1.TabIndex = 2
        Label1.Text = "Balombaa"
        ' 
        ' ButtonCloseDaftar
        ' 
        ButtonCloseDaftar.BackColor = Color.Transparent
        ButtonCloseDaftar.BackgroundImage = My.Resources.Resources.Close25px
        ButtonCloseDaftar.BackgroundImageLayout = ImageLayout.Center
        ButtonCloseDaftar.Dock = DockStyle.Right
        ButtonCloseDaftar.FlatAppearance.BorderSize = 0
        ButtonCloseDaftar.FlatStyle = FlatStyle.Flat
        ButtonCloseDaftar.Location = New Point(1418, 0)
        ButtonCloseDaftar.Margin = New Padding(3, 4, 3, 4)
        ButtonCloseDaftar.Name = "ButtonCloseDaftar"
        ButtonCloseDaftar.Size = New Size(45, 43)
        ButtonCloseDaftar.TabIndex = 1
        ButtonCloseDaftar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 43)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1463, 917)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Fill
        PictureBox3.Image = My.Resources.Resources._2150257157
        PictureBox3.Location = New Point(0, 43)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1463, 917)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel_Daftar
        ' 
        Panel_Daftar.BackColor = Color.White
        Panel_Daftar.BackgroundImageLayout = ImageLayout.Zoom
        Panel_Daftar.Controls.Add(Login_LinkLabel)
        Panel_Daftar.Controls.Add(Tanggal_LahirLabel)
        Panel_Daftar.Controls.Add(Tanggal_lahirTextbox)
        Panel_Daftar.Controls.Add(UsernameTextbox)
        Panel_Daftar.Controls.Add(Password_TextBox)
        Panel_Daftar.Controls.Add(UsernameLabel)
        Panel_Daftar.Controls.Add(PasswordLabel)
        Panel_Daftar.Controls.Add(DaftarLabel)
        Panel_Daftar.Controls.Add(NamaTextbox)
        Panel_Daftar.Controls.Add(Email_Textbox)
        Panel_Daftar.Controls.Add(ButtonDaftar)
        Panel_Daftar.Controls.Add(NamaLabel)
        Panel_Daftar.Controls.Add(Email_Label)
        Panel_Daftar.Location = New Point(138, 200)
        Panel_Daftar.Margin = New Padding(3, 4, 3, 4)
        Panel_Daftar.Name = "Panel_Daftar"
        Panel_Daftar.Size = New Size(486, 610)
        Panel_Daftar.TabIndex = 8
        ' 
        ' Login_LinkLabel
        ' 
        Login_LinkLabel.AutoSize = True
        Login_LinkLabel.LinkColor = Color.Blue
        Login_LinkLabel.Location = New Point(214, 576)
        Login_LinkLabel.Name = "Login_LinkLabel"
        Login_LinkLabel.Size = New Size(46, 20)
        Login_LinkLabel.TabIndex = 10
        Login_LinkLabel.TabStop = True
        Login_LinkLabel.Text = "Login"
        ' 
        ' Tanggal_LahirLabel
        ' 
        Tanggal_LahirLabel.AutoSize = True
        Tanggal_LahirLabel.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        Tanggal_LahirLabel.Location = New Point(75, 269)
        Tanggal_LahirLabel.Name = "Tanggal_LahirLabel"
        Tanggal_LahirLabel.Size = New Size(97, 20)
        Tanggal_LahirLabel.TabIndex = 9
        Tanggal_LahirLabel.Text = "Tanggal Lahir"
        ' 
        ' Tanggal_lahirTextbox
        ' 
        Tanggal_lahirTextbox.Location = New Point(75, 300)
        Tanggal_lahirTextbox.Margin = New Padding(3, 4, 3, 4)
        Tanggal_lahirTextbox.Name = "Tanggal_lahirTextbox"
        Tanggal_lahirTextbox.Size = New Size(355, 27)
        Tanggal_lahirTextbox.TabIndex = 8
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.Location = New Point(75, 220)
        UsernameTextbox.Margin = New Padding(3, 4, 3, 4)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.Size = New Size(355, 27)
        UsernameTextbox.TabIndex = 7
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Location = New Point(75, 453)
        Password_TextBox.Margin = New Padding(3, 4, 3, 4)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.Size = New Size(355, 27)
        Password_TextBox.TabIndex = 7
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        UsernameLabel.Location = New Point(75, 196)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(75, 20)
        UsernameLabel.TabIndex = 6
        UsernameLabel.Text = "Username"
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        PasswordLabel.Location = New Point(75, 429)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(70, 20)
        PasswordLabel.TabIndex = 6
        PasswordLabel.Text = "Password"
        ' 
        ' DaftarLabel
        ' 
        DaftarLabel.AutoSize = True
        DaftarLabel.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DaftarLabel.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        DaftarLabel.Location = New Point(202, 60)
        DaftarLabel.Name = "DaftarLabel"
        DaftarLabel.Size = New Size(90, 37)
        DaftarLabel.TabIndex = 5
        DaftarLabel.Text = "Daftar"
        ' 
        ' NamaTextbox
        ' 
        NamaTextbox.Location = New Point(75, 140)
        NamaTextbox.Margin = New Padding(3, 4, 3, 4)
        NamaTextbox.Name = "NamaTextbox"
        NamaTextbox.Size = New Size(355, 27)
        NamaTextbox.TabIndex = 3
        ' 
        ' Email_Textbox
        ' 
        Email_Textbox.Location = New Point(75, 373)
        Email_Textbox.Margin = New Padding(3, 4, 3, 4)
        Email_Textbox.Name = "Email_Textbox"
        Email_Textbox.Size = New Size(355, 27)
        Email_Textbox.TabIndex = 3
        ' 
        ' ButtonDaftar
        ' 
        ButtonDaftar.Location = New Point(139, 509)
        ButtonDaftar.Margin = New Padding(3, 4, 3, 4)
        ButtonDaftar.Name = "ButtonDaftar"
        ButtonDaftar.Size = New Size(194, 49)
        ButtonDaftar.TabIndex = 4
        ButtonDaftar.Text = "Daftar"
        ButtonDaftar.UseVisualStyleBackColor = True
        ' 
        ' NamaLabel
        ' 
        NamaLabel.AutoSize = True
        NamaLabel.BackColor = Color.White
        NamaLabel.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        NamaLabel.Location = New Point(75, 116)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New Size(49, 20)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama"
        ' 
        ' Email_Label
        ' 
        Email_Label.AutoSize = True
        Email_Label.BackColor = Color.White
        Email_Label.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        Email_Label.Location = New Point(75, 349)
        Email_Label.Name = "Email_Label"
        Email_Label.Size = New Size(46, 20)
        Email_Label.TabIndex = 2
        Email_Label.Text = "Email"
        ' 
        ' Daftar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(Panel_Daftar)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Daftar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Daftar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel_Daftar.ResumeLayout(False)
        Panel_Daftar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonCloseDaftar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel_Daftar As Panel
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents DaftarLabel As Label
    Friend WithEvents Email_Textbox As TextBox
    Friend WithEvents ButtonDaftar As Button
    Friend WithEvents Email_Label As Label
    Friend WithEvents Tanggal_LahirLabel As Label
    Friend WithEvents Tanggal_lahirTextbox As DateTimePicker
    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents NamaTextbox As TextBox
    Friend WithEvents NamaLabel As Label
    Friend WithEvents Login_LinkLabel As LinkLabel
End Class
