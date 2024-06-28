Public Class Validators
    Public Shared Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Public Shared Function IsValidPassword(password As String) As Boolean
        If password.Length < 8 Then Return False
        If Not password.Any(Function(c) Char.IsUpper(c)) Then Return False
        If Not password.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not password.Any(Function(c) Char.IsDigit(c)) Then Return False
        Return True
    End Function

End Class
