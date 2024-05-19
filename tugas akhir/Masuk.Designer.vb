<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Masuk
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
        Login_Heading_Label = New Label()
        Daftar_LinkLabel = New LinkLabel()
        Belum_Daftar_Label = New Label()
        Judul_Poster_TextBox = New TextBox()
        Email_TextBox = New TextBox()
        Login_Button = New Button()
        Judul_Poster = New Label()
        Email = New Label()
        SuspendLayout()
        ' 
        ' Login_Heading_Label
        ' 
        Login_Heading_Label.AutoSize = True
        Login_Heading_Label.BorderStyle = BorderStyle.FixedSingle
        Login_Heading_Label.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Login_Heading_Label.Location = New Point(162, 69)
        Login_Heading_Label.Name = "Login_Heading_Label"
        Login_Heading_Label.Size = New Size(97, 38)
        Login_Heading_Label.TabIndex = 36
        Login_Heading_Label.Text = "Login"
        ' 
        ' Daftar_LinkLabel
        ' 
        Daftar_LinkLabel.AutoSize = True
        Daftar_LinkLabel.Location = New Point(280, 416)
        Daftar_LinkLabel.Name = "Daftar_LinkLabel"
        Daftar_LinkLabel.Size = New Size(51, 20)
        Daftar_LinkLabel.TabIndex = 35
        Daftar_LinkLabel.TabStop = True
        Daftar_LinkLabel.Text = "Daftar"
        ' 
        ' Belum_Daftar_Label
        ' 
        Belum_Daftar_Label.AutoSize = True
        Belum_Daftar_Label.Location = New Point(142, 416)
        Belum_Daftar_Label.Name = "Belum_Daftar_Label"
        Belum_Daftar_Label.Size = New Size(141, 20)
        Belum_Daftar_Label.TabIndex = 34
        Belum_Daftar_Label.Text = "Belum punya akun ?"
        ' 
        ' Judul_Poster_TextBox
        ' 
        Judul_Poster_TextBox.Location = New Point(145, 274)
        Judul_Poster_TextBox.Name = "Judul_Poster_TextBox"
        Judul_Poster_TextBox.Size = New Size(218, 27)
        Judul_Poster_TextBox.TabIndex = 33
        ' 
        ' Email_TextBox
        ' 
        Email_TextBox.Location = New Point(145, 216)
        Email_TextBox.Name = "Email_TextBox"
        Email_TextBox.Size = New Size(218, 27)
        Email_TextBox.TabIndex = 31
        ' 
        ' Login_Button
        ' 
        Login_Button.Font = New Font("Segoe UI", 10F)
        Login_Button.Location = New Point(162, 336)
        Login_Button.Name = "Login_Button"
        Login_Button.Size = New Size(154, 52)
        Login_Button.TabIndex = 28
        Login_Button.Text = "Login"
        Login_Button.UseVisualStyleBackColor = True
        ' 
        ' Judul_Poster
        ' 
        Judul_Poster.AutoSize = True
        Judul_Poster.Location = New Point(17, 279)
        Judul_Poster.Name = "Judul_Poster"
        Judul_Poster.Size = New Size(70, 20)
        Judul_Poster.TabIndex = 27
        Judul_Poster.Text = "Password"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(17, 222)
        Email.Name = "Email"
        Email.Size = New Size(46, 20)
        Email.TabIndex = 25
        Email.Text = "Email"
        ' 
        ' Masuk
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 503)
        Controls.Add(Login_Heading_Label)
        Controls.Add(Daftar_LinkLabel)
        Controls.Add(Belum_Daftar_Label)
        Controls.Add(Judul_Poster_TextBox)
        Controls.Add(Email_TextBox)
        Controls.Add(Login_Button)
        Controls.Add(Judul_Poster)
        Controls.Add(Email)
        Name = "Masuk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Masuk"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Login_Heading_Label As Label
    Friend WithEvents Daftar_LinkLabel As LinkLabel
    Friend WithEvents Belum_Daftar_Label As Label
    Friend WithEvents Judul_Poster_TextBox As TextBox
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents Login_Button As Button
    Friend WithEvents Judul_Poster As Label
    Friend WithEvents Email As Label
End Class
