Imports System.Drawing.Drawing2D

Public Class FormLoading

    Public Sub New()
        InitializeComponent()

        Dim radius As Integer = 10 ' Ukuran radius sudut melengkung
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
    End Sub

    Private Sub StartLoadingAnimation()
        ' Menampilkan animasi loading
        ProgressBarLoading.Style = ProgressBarStyle.Marquee
        LabelLoadingMessage.Text = "Loading, please wait..."
    End Sub

    ' Metode untuk memperbarui pesan loading dari luar form
    Public Sub UpdateLoadingMessage(message As String)
        LabelLoadingMessage.Text = message
    End Sub


End Class
