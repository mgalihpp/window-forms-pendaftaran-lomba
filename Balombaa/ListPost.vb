Public Class ListPost
    Public Sub New()
        InitializeComponent()
        InitializeDataGridView()
        LoadDataIntoDataGridView()
    End Sub
    Private Sub InitializeDataGridView()

        Me.DataGridView1.Columns.Clear()

        With Me.DataGridView1
            .AutoGenerateColumns = False
            .Columns.AddRange(
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "Judul", .HeaderText = "Judul"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "Gambar", .HeaderText = "Gambar"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "TingkatPendidikan", .HeaderText = "Tingkat Pendidikan"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "penyelenggara", .HeaderText = "Penyelenggara"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "TingkatWilayah", .HeaderText = "Tingkat Wilayah"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "TanggalDeadline", .HeaderText = "Deadline"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "TotalHadiah", .HeaderText = "Prize"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "Kategori", .HeaderText = "Kategori"},
                New DataGridViewTextBoxColumn() With {.DataPropertyName = "Deskripsi", .HeaderText = "Deskripsi"}
            )
        End With
    End Sub
    Private Sub LoadDataIntoDataGridView()
        Try

            Dim dataTable = Db.Post.GetAll()
            Me.DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}")
        End Try
    End Sub
End Class
