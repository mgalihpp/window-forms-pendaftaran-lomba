<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseLogin = New Button()
        Email_Label = New Label()
        Email_Textbox = New TextBox()
        ButtonLogin = New Button()
        Panel_Login = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Password_TextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        Panel_Login.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonCloseLogin)
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
        Label1.ForeColor = Color.FromArgb(CByte(225), CByte(169), CByte(3))
        Label1.Location = New Point(14, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 37)
        Label1.TabIndex = 1
        Label1.Text = "Balombaa"
        ' 
        ' ButtonCloseLogin
        ' 
        ButtonCloseLogin.BackColor = Color.Transparent
        ButtonCloseLogin.BackgroundImage = My.Resources.Resources.Close25px
        ButtonCloseLogin.BackgroundImageLayout = ImageLayout.Center
        ButtonCloseLogin.Dock = DockStyle.Right
        ButtonCloseLogin.FlatAppearance.BorderSize = 0
        ButtonCloseLogin.FlatStyle = FlatStyle.Flat
        ButtonCloseLogin.Location = New Point(1418, 0)
        ButtonCloseLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonCloseLogin.Name = "ButtonCloseLogin"
        ButtonCloseLogin.Size = New Size(45, 43)
        ButtonCloseLogin.TabIndex = 0
        ButtonCloseLogin.UseVisualStyleBackColor = False
        ' 
        ' Email_Label
        ' 
        Email_Label.AutoSize = True
        Email_Label.BackColor = Color.White
        Email_Label.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        Email_Label.Location = New Point(75, 119)
        Email_Label.Name = "Email_Label"
        Email_Label.Size = New Size(46, 20)
        Email_Label.TabIndex = 2
        Email_Label.Text = "Email"
        ' 
        ' Email_Textbox
        ' 
        Email_Textbox.Location = New Point(75, 143)
        Email_Textbox.Margin = New Padding(3, 4, 3, 4)
        Email_Textbox.Name = "Email_Textbox"
        Email_Textbox.Size = New Size(355, 27)
        Email_Textbox.TabIndex = 3
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(139, 343)
        ButtonLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(194, 49)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' Panel_Login
        ' 
        Panel_Login.BackColor = Color.White
        Panel_Login.BackgroundImageLayout = ImageLayout.Zoom
        Panel_Login.Controls.Add(PictureBox2)
        Panel_Login.Controls.Add(PictureBox1)
        Panel_Login.Controls.Add(LinkLabel2)
        Panel_Login.Controls.Add(LinkLabel1)
        Panel_Login.Controls.Add(Password_TextBox)
        Panel_Login.Controls.Add(Label4)
        Panel_Login.Controls.Add(Label3)
        Panel_Login.Controls.Add(Email_Textbox)
        Panel_Login.Controls.Add(ButtonLogin)
        Panel_Login.Controls.Add(Email_Label)
        Panel_Login.Location = New Point(138, 257)
        Panel_Login.Margin = New Padding(3, 4, 3, 4)
        Panel_Login.Name = "Panel_Login"
        Panel_Login.Size = New Size(486, 487)
        Panel_Login.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(31, 223)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 53)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(31, 131)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 53)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.Blue
        LinkLabel2.Location = New Point(183, 400)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(122, 20)
        LinkLabel2.TabIndex = 9
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Daftar Akun Baru"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Blue
        LinkLabel1.Location = New Point(187, 315)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(106, 20)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Lupa Password"
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Location = New Point(75, 236)
        Password_TextBox.Margin = New Padding(3, 4, 3, 4)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.Size = New Size(355, 27)
        Password_TextBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        Label4.Location = New Point(75, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 6
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(55), CByte(83), CByte(113))
        Label3.Location = New Point(202, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 37)
        Label3.TabIndex = 5
        Label3.Text = "Login"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._2150257157
        PictureBox3.Location = New Point(0, 36)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1463, 924)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(Panel_Login)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel_Login.ResumeLayout(False)
        Panel_Login.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseLogin As Button
    Friend WithEvents Email_Label As Label
    Friend WithEvents Email_Textbox As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
