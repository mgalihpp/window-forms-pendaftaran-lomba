Imports System.Text.RegularExpressions

Public Class Daftar
    Private Sub Masuk_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Masuk_LinkLabel.LinkClicked
        Masuk.Show()
        Me.Hide()
    End Sub

    Private Sub MasukDaftarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasukDaftarToolStripMenuItem.Click

    End Sub

    Private Sub BerandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BerandaToolStripMenuItem.Click
        Me.Hide()
        Beranda.Show()
    End Sub

    Private Sub MasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasukToolStripMenuItem.Click
        Me.Hide()
        Masuk.Show()
    End Sub

    Private Sub Daftar_Button_Click(sender As Object, e As EventArgs) Handles Daftar_Button.Click
        ' Validate name field
        Dim nama As String = Nama_TextBox.Text
        If String.IsNullOrWhiteSpace(nama) Then
            ShowErrorMessage("Tolong isikan nama mu.")
            Return
        End If

        ' Validate date field
        Dim selectedDate As DateTime = DateTimePicker1.Value

        ' Validate phone number field
        Dim no_Hp As String = No_Hp_TextBox.Text
        If Not Regex.IsMatch(no_Hp, "^\d{10}$") Then ' 10 digits
            ShowErrorMessage("Pastikan nomor yang anda ketik sesuai 10 digit.")
            Return
        End If

        ' Validate gender field
        Dim kelamin As String = Jenis_Kelamin_ComboBox.SelectedItem?.ToString()
        If String.IsNullOrWhiteSpace(kelamin) Then
            ShowErrorMessage("Tolong pastikan jenis kelamin anda benar.")
            Return
        End If

        ' Validate email field
        Dim email As String = Email_TextBox.Text
        If Not Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            ShowErrorMessage("Pastikan email anda benar.")
            Return
        End If

        ' Validate password field
        Dim password As String = Password_TextBox.Text
        If String.IsNullOrWhiteSpace(password) Then
            ShowErrorMessage("Pastikan password anda benar.")
            Return
        End If

        MessageBox.Show("Registrasi berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Silahkan Login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset semua fields
        ClearFields()

        ' munculin si form login
        Me.Hide()
        Masuk.Show()
    End Sub

    Private Sub ShowErrorMessage(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ClearFields()
        Nama_TextBox.Clear()
        DateTimePicker1.Value = DateTime.Now
        No_Hp_TextBox.Clear()
        Jenis_Kelamin_ComboBox.SelectedIndex = -1
        Email_TextBox.Clear()
        Password_TextBox.Clear()
    End Sub
End Class