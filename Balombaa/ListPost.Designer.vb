<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPost
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        PanelListPost = New Panel()
        DataGridView1 = New DataGridView()
        Judul = New DataGridViewTextBoxColumn()
        Gambar = New DataGridViewTextBoxColumn()
        Tingkat_Pendidikan = New DataGridViewTextBoxColumn()
        Penyelenggara = New DataGridViewTextBoxColumn()
        Tingkat_Wilayah = New DataGridViewTextBoxColumn()
        Deadline = New DataGridViewTextBoxColumn()
        Prize = New DataGridViewTextBoxColumn()
        Kategori = New DataGridViewTextBoxColumn()
        Deskripsi = New DataGridViewTextBoxColumn()
        ComboBox3 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        Label11 = New Label()
        PanelListPost.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelListPost
        ' 
        PanelListPost.BackColor = Color.White
        PanelListPost.BorderStyle = BorderStyle.FixedSingle
        PanelListPost.Controls.Add(DataGridView1)
        PanelListPost.Controls.Add(ComboBox3)
        PanelListPost.Controls.Add(ComboBox1)
        PanelListPost.Controls.Add(TextBox3)
        PanelListPost.Controls.Add(Label11)
        PanelListPost.Location = New Point(3, 0)
        PanelListPost.Margin = New Padding(3, 4, 3, 4)
        PanelListPost.Name = "PanelListPost"
        PanelListPost.Size = New Size(1232, 911)
        PanelListPost.TabIndex = 29
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Judul, Gambar, Tingkat_Pendidikan, Penyelenggara, Tingkat_Wilayah, Deadline, Prize, Kategori, Deskripsi})
        DataGridView1.Location = New Point(64, 183)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1080, 561)
        DataGridView1.TabIndex = 5
        ' 
        ' Judul
        ' 
        Judul.HeaderText = "Judul"
        Judul.MinimumWidth = 6
        Judul.Name = "Judul"
        Judul.ReadOnly = True
        Judul.Width = 125
        ' 
        ' Gambar
        ' 
        Gambar.HeaderText = "Gambar"
        Gambar.MinimumWidth = 6
        Gambar.Name = "Gambar"
        Gambar.ReadOnly = True
        Gambar.Width = 125
        ' 
        ' Tingkat_Pendidikan
        ' 
        Tingkat_Pendidikan.HeaderText = "Tingkat Pendidikan"
        Tingkat_Pendidikan.MinimumWidth = 6
        Tingkat_Pendidikan.Name = "Tingkat_Pendidikan"
        Tingkat_Pendidikan.ReadOnly = True
        Tingkat_Pendidikan.Width = 125
        ' 
        ' Penyelenggara
        ' 
        Penyelenggara.HeaderText = "Penyelenggara"
        Penyelenggara.MinimumWidth = 6
        Penyelenggara.Name = "Penyelenggara"
        Penyelenggara.ReadOnly = True
        Penyelenggara.Width = 125
        ' 
        ' Tingkat_Wilayah
        ' 
        Tingkat_Wilayah.HeaderText = "Tingkat Wilayah"
        Tingkat_Wilayah.MinimumWidth = 6
        Tingkat_Wilayah.Name = "Tingkat_Wilayah"
        Tingkat_Wilayah.ReadOnly = True
        Tingkat_Wilayah.Width = 125
        ' 
        ' Deadline
        ' 
        Deadline.HeaderText = "Deadline"
        Deadline.MinimumWidth = 6
        Deadline.Name = "Deadline"
        Deadline.ReadOnly = True
        Deadline.Width = 125
        ' 
        ' Prize
        ' 
        Prize.HeaderText = "Prize"
        Prize.MinimumWidth = 6
        Prize.Name = "Prize"
        Prize.ReadOnly = True
        Prize.Width = 125
        ' 
        ' Kategori
        ' 
        Kategori.HeaderText = "Kategori"
        Kategori.MinimumWidth = 6
        Kategori.Name = "Kategori"
        Kategori.ReadOnly = True
        Kategori.Width = 125
        ' 
        ' Deskripsi
        ' 
        Deskripsi.HeaderText = "Deskripsi"
        Deskripsi.MinimumWidth = 6
        Deskripsi.Name = "Deskripsi"
        Deskripsi.ReadOnly = True
        Deskripsi.Width = 125
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Ascending", "Descending"})
        ComboBox3.Location = New Point(374, 111)
        ComboBox3.Margin = New Padding(3, 4, 3, 4)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(147, 28)
        ComboBox3.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Created At", "Updated At"})
        ComboBox1.Location = New Point(218, 111)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(147, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(64, 111)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(147, 27)
        TextBox3.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(57, 56)
        Label11.Name = "Label11"
        Label11.Size = New Size(164, 37)
        Label11.TabIndex = 1
        Label11.Text = "Filter and Sort"
        ' 
        ' ListPost
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(PanelListPost)
        Name = "ListPost"
        Size = New Size(1238, 915)
        PanelListPost.ResumeLayout(False)
        PanelListPost.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelListPost As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents Gambar As DataGridViewTextBoxColumn
    Friend WithEvents Tingkat_Pendidikan As DataGridViewTextBoxColumn
    Friend WithEvents Penyelenggara As DataGridViewTextBoxColumn
    Friend WithEvents Tingkat_Wilayah As DataGridViewTextBoxColumn
    Friend WithEvents Deadline As DataGridViewTextBoxColumn
    Friend WithEvents Prize As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label

End Class
