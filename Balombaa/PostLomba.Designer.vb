﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PostLomba
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostLomba))
        Panel1 = New Panel()
        ButtonCloseHome = New Button()
        Header_Label = New Label()
        Panel2 = New Panel()
        ButtonCreatePost = New Button()
        ButtonListPost = New Button()
        ButtonHome = New Button()
        Panel3 = New Panel()
        BackHome = New Button()
        Button_BuatPost = New Button()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ButtonCloseHome)
        Panel1.Controls.Add(Header_Label)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1463, 55)
        Panel1.TabIndex = 0
        ' 
        ' ButtonCloseHome
        ' 
        ButtonCloseHome.BackColor = Color.Transparent
        ButtonCloseHome.BackgroundImage = My.Resources.Resources.Close25px
        ButtonCloseHome.BackgroundImageLayout = ImageLayout.Center
        ButtonCloseHome.Dock = DockStyle.Right
        ButtonCloseHome.FlatAppearance.BorderSize = 0
        ButtonCloseHome.FlatStyle = FlatStyle.Flat
        ButtonCloseHome.Location = New Point(1409, 0)
        ButtonCloseHome.Margin = New Padding(3, 4, 3, 4)
        ButtonCloseHome.Name = "ButtonCloseHome"
        ButtonCloseHome.Size = New Size(52, 53)
        ButtonCloseHome.TabIndex = 3
        ButtonCloseHome.UseVisualStyleBackColor = False
        ' 
        ' Header_Label
        ' 
        Header_Label.AutoSize = True
        Header_Label.BackColor = Color.Transparent
        Header_Label.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Header_Label.ForeColor = Color.FromArgb(CByte(71), CByte(132), CByte(246))
        Header_Label.Location = New Point(46, 7)
        Header_Label.Name = "Header_Label"
        Header_Label.Size = New Size(142, 40)
        Header_Label.TabIndex = 2
        Header_Label.Text = "Balombaa"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ButtonCreatePost)
        Panel2.Controls.Add(ButtonListPost)
        Panel2.Controls.Add(ButtonHome)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 55)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 905)
        Panel2.TabIndex = 1
        ' 
        ' ButtonCreatePost
        ' 
        ButtonCreatePost.Dock = DockStyle.Top
        ButtonCreatePost.FlatAppearance.BorderSize = 0
        ButtonCreatePost.FlatStyle = FlatStyle.Flat
        ButtonCreatePost.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCreatePost.Image = My.Resources.Resources.Plus
        ButtonCreatePost.ImageAlign = ContentAlignment.MiddleLeft
        ButtonCreatePost.Location = New Point(0, 112)
        ButtonCreatePost.Margin = New Padding(3, 4, 3, 4)
        ButtonCreatePost.Name = "ButtonCreatePost"
        ButtonCreatePost.Padding = New Padding(6, 0, 0, 0)
        ButtonCreatePost.Size = New Size(250, 56)
        ButtonCreatePost.TabIndex = 3
        ButtonCreatePost.Text = "Create Post"
        ButtonCreatePost.UseVisualStyleBackColor = True
        ' 
        ' ButtonListPost
        ' 
        ButtonListPost.Dock = DockStyle.Top
        ButtonListPost.FlatAppearance.BorderSize = 0
        ButtonListPost.FlatStyle = FlatStyle.Flat
        ButtonListPost.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold)
        ButtonListPost.Image = My.Resources.Resources.List
        ButtonListPost.ImageAlign = ContentAlignment.MiddleLeft
        ButtonListPost.Location = New Point(0, 56)
        ButtonListPost.Margin = New Padding(3, 4, 3, 4)
        ButtonListPost.Name = "ButtonListPost"
        ButtonListPost.Padding = New Padding(6, 0, 0, 0)
        ButtonListPost.Size = New Size(250, 56)
        ButtonListPost.TabIndex = 2
        ButtonListPost.Text = "List Post"
        ButtonListPost.UseVisualStyleBackColor = True
        ' 
        ' ButtonHome
        ' 
        ButtonHome.BackgroundImageLayout = ImageLayout.Zoom
        ButtonHome.Dock = DockStyle.Top
        ButtonHome.FlatAppearance.BorderSize = 0
        ButtonHome.FlatStyle = FlatStyle.Flat
        ButtonHome.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold)
        ButtonHome.Image = CType(resources.GetObject("ButtonHome.Image"), Image)
        ButtonHome.ImageAlign = ContentAlignment.MiddleLeft
        ButtonHome.Location = New Point(0, 0)
        ButtonHome.Margin = New Padding(3, 4, 3, 4)
        ButtonHome.Name = "ButtonHome"
        ButtonHome.Padding = New Padding(6, 0, 0, 0)
        ButtonHome.Size = New Size(250, 56)
        ButtonHome.TabIndex = 1
        ButtonHome.Text = "Home"
        ButtonHome.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(250, 55)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1213, 905)
        Panel3.TabIndex = 2
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
        ' PostLomba
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "PostLomba"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PostLomba"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Header_Label As Label
    Friend WithEvents ButtonCloseHome As Button
    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonListPost As Button
    Friend WithEvents ButtonCreatePost As Button
    Friend WithEvents BackHome As Button
    Friend WithEvents Button_BuatPost As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
