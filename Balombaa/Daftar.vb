Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Daftar

    Private email As String
    Private password As String
    Private nama As String
    Private username As String
    Private tgl_lahir As Date

    Private Sub ButtonCloseDaftar_Click(sender As Object, e As EventArgs) Handles ButtonCloseDaftar.Click
        Application.Exit()
    End Sub
    Private Sub Login_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Login_LinkLabel.LinkClicked
        Login.Show()
        Me.Close()
    End Sub
    Private Sub ButtonDaftar_Click(sender As Object, e As EventArgs) Handles ButtonDaftar.Click

        email = Email_Textbox.Text
        password = Password_TextBox.Text
        nama = NamaTextbox.Text
        username = UsernameTextbox.Text
        tgl_lahir = Tanggal_lahirTextbox.Value

        If Not CheckField() Then
            Return
        End If

        Dim isCreated = Db.User.Create(nama, username, tgl_lahir, email, password)

        If Not isCreated Then
            Return
        End If

        Login.Show()
        Me.Close()
    End Sub

    Private Function CheckField()
        If String.IsNullOrWhiteSpace(nama) Then
            MessageBox.Show("Nama tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Username tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Validators.IsValidEmail(email) Then
            MessageBox.Show("Email tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not Validators.IsValidPassword(password) Then
            MessageBox.Show("Password harus terdiri dari minimal 8 karakter, termasuk huruf besar, huruf kecil, dan angka", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(tgl_lahir) Then
            MessageBox.Show("Tanggal lahir tidak boleh kosong")
            Return False
        End If

        Return True
    End Function

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonDaftar_Click(Me, EventArgs.Empty)
        End If
    End Sub

End Class