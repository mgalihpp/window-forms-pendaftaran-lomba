<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        PanelHome = New Panel()
        BackHome = New Button()
        Button_BuatPost = New Button()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        PanelHome.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHome
        ' 
        PanelHome.BorderStyle = BorderStyle.FixedSingle
        PanelHome.Controls.Add(BackHome)
        PanelHome.Controls.Add(Button_BuatPost)
        PanelHome.Controls.Add(Label12)
        PanelHome.Controls.Add(PictureBox2)
        PanelHome.Location = New Point(0, 0)
        PanelHome.Margin = New Padding(3, 4, 3, 4)
        PanelHome.Name = "PanelHome"
        PanelHome.Size = New Size(1213, 905)
        PanelHome.TabIndex = 8
        ' 
        ' BackHome
        ' 
        BackHome.BackColor = Color.Transparent
        BackHome.Image = CType(resources.GetObject("BackHome.Image"), Image)
        BackHome.Location = New Point(1124, 765)
        BackHome.Name = "BackHome"
        BackHome.Size = New Size(50, 50)
        BackHome.TabIndex = 11
        BackHome.UseVisualStyleBackColor = False
        ' 
        ' Button_BuatPost
        ' 
        Button_BuatPost.BackColor = Color.White
        Button_BuatPost.Font = New Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button_BuatPost.Location = New Point(536, 486)
        Button_BuatPost.Margin = New Padding(3, 4, 3, 4)
        Button_BuatPost.Name = "Button_BuatPost"
        Button_BuatPost.Size = New Size(149, 45)
        Button_BuatPost.TabIndex = 5
        Button_BuatPost.Text = "Buat Post"
        Button_BuatPost.TextAlign = ContentAlignment.BottomCenter
        Button_BuatPost.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(526, 395)
        Label12.Name = "Label12"
        Label12.Size = New Size(169, 50)
        Label12.TabIndex = 1
        Label12.Text = "Welcome!"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Home
        PictureBox2.Location = New Point(557, 288)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 103)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(PanelHome)
        Name = "Welcome"
        Size = New Size(1216, 909)
        PanelHome.ResumeLayout(False)
        PanelHome.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHome As Panel
    Friend WithEvents BackHome As Button
    Friend WithEvents Button_BuatPost As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
