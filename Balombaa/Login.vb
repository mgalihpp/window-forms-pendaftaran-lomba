Imports System.Drawing.Drawing2D

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCloseLogin.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Daftar.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim radius As Integer = 20 ' Ukuran radius sudut melengkung
        Dim path As New GraphicsPath()

        ' Menambahkan sudut melengkung pada path
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddLine(radius, 0, Me.Width - radius, 0)
        path.AddArc(New Rectangle(Me.Width - radius, 0, radius, radius), -90, 90)
        path.AddLine(Me.Width, radius, Me.Width, Me.Height - radius)
        path.AddArc(New Rectangle(Me.Width - radius, Me.Height - radius, radius, radius), 0, 90)
        path.AddLine(Me.Width - radius, Me.Height, radius, Me.Height)
        path.AddArc(New Rectangle(0, Me.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        ' Mengatur region form dengan path yang telah dibuat
        Me.Region = New Region(path)

        Me.KeyPreview = True
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim email As String = Email_Textbox.Text
        Dim password As String = Password_TextBox.Text

        If Not CheckField(email, password) Then
            Return
        End If

        Dim isUser As Boolean = Db.User.Login(email, password)

        If Not isUser Then
            Return
        End If

        Home.Show()
        Me.Close()

    End Sub
    Private Function CheckField(email As String, password As String) As Boolean
        If Not Validators.IsValidEmail(email) Then
            MessageBox.Show("Email tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Validators.IsValidPassword(password) Then
            MessageBox.Show("Password harus terdiri dari minimal 8 karakter, termasuk huruf besar, huruf kecil, dan angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class