Public Class User
    Public Property Id As Integer
    Public Property Username As String
    Public Property Email As String
End Class

Public Class SessionManager
    Private Shared _currentUser As User

    Public Shared Sub CreateSession(id As Integer, username As String, email As String)
        _currentUser = New User With {
            .Id = id,
            .Username = username,
            .Email = email
        }
    End Sub

    Public Shared ReadOnly Property CurrentUser As User
        Get
            Return _currentUser
        End Get
    End Property

    Public Shared Function IsUserLoggedIn() As Boolean
        Return _currentUser IsNot Nothing
    End Function

    Public Shared Sub ClearSession()
        _currentUser = Nothing
    End Sub
End Class
