﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaraBuatLomba
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaraBuatLomba))
        Panel1 = New Panel()
        Label1 = New Label()
        ButtonCloseHome = New Button()
        Panel3 = New Panel()
        Akun = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        ButtonPost_Lomba = New Button()
        BackHome = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonCloseHome)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1463, 43)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(71), CByte(132), CByte(246))
        Label1.Location = New Point(14, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 37)
        Label1.TabIndex = 1
        Label1.Text = "Balombaa"
        ' 
        ' ButtonCloseHome
        ' 
        ButtonCloseHome.BackColor = Color.Transparent
        ButtonCloseHome.BackgroundImage = My.Resources.Resources.Close25px
        ButtonCloseHome.BackgroundImageLayout = ImageLayout.Center
        ButtonCloseHome.Dock = DockStyle.Right
        ButtonCloseHome.FlatAppearance.BorderSize = 0
        ButtonCloseHome.FlatStyle = FlatStyle.Flat
        ButtonCloseHome.Location = New Point(1418, 0)
        ButtonCloseHome.Margin = New Padding(3, 4, 3, 4)
        ButtonCloseHome.Name = "ButtonCloseHome"
        ButtonCloseHome.Size = New Size(45, 43)
        ButtonCloseHome.TabIndex = 0
        ButtonCloseHome.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Panel3.Controls.Add(Akun)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Top
        Panel3.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1463, 276)
        Panel3.TabIndex = 2
        ' 
        ' Akun
        ' 
        Akun.BackgroundImageLayout = ImageLayout.Center
        Akun.FlatAppearance.BorderColor = Color.White
        Akun.FlatStyle = FlatStyle.Flat
        Akun.Image = CType(resources.GetObject("Akun.Image"), Image)
        Akun.Location = New Point(1378, 51)
        Akun.Margin = New Padding(3, 4, 3, 4)
        Akun.Name = "Akun"
        Akun.Size = New Size(46, 53)
        Akun.TabIndex = 6
        Akun.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Label3.Font = New Font("Poppins", 16.2F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(36, 112)
        Label3.MaximumSize = New Size(800, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(776, 100)
        Label3.TabIndex = 3
        Label3.Text = "Publikasikan lomba dan kompetisi anda di Balombaa dan cakup ribuan peserta potensial tanpa biaya."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        Label2.Font = New Font("Poppins", 28.2F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(32, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(939, 82)
        Label2.TabIndex = 2
        Label2.Text = "Your Stage for Thousands to Witness!"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 43)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1463, 276)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 12F)
        Label4.Location = New Point(32, 341)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(921, 252)
        Label4.TabIndex = 3
        Label4.Text = resources.GetString("Label4.Text")
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonPost_Lomba
        ' 
        ButtonPost_Lomba.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        ButtonPost_Lomba.Font = New Font("Poppins", 12F)
        ButtonPost_Lomba.ForeColor = Color.White
        ButtonPost_Lomba.Location = New Point(36, 612)
        ButtonPost_Lomba.Margin = New Padding(3, 4, 3, 4)
        ButtonPost_Lomba.Name = "ButtonPost_Lomba"
        ButtonPost_Lomba.RightToLeft = RightToLeft.No
        ButtonPost_Lomba.Size = New Size(185, 53)
        ButtonPost_Lomba.TabIndex = 6
        ButtonPost_Lomba.Text = "Post Lomba"
        ButtonPost_Lomba.UseVisualStyleBackColor = False
        ' 
        ' BackHome
        ' 
        BackHome.BackColor = Color.Transparent
        BackHome.Image = CType(resources.GetObject("BackHome.Image"), Image)
        BackHome.Location = New Point(1376, 859)
        BackHome.Name = "BackHome"
        BackHome.Size = New Size(50, 50)
        BackHome.TabIndex = 11
        BackHome.UseVisualStyleBackColor = False
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "Kembali Ke Home"
        ' 
        ' CaraBuatLomba
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1463, 960)
        Controls.Add(BackHome)
        Controls.Add(ButtonPost_Lomba)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "CaraBuatLomba"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCloseHome As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Akun As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonPost_Lomba As Button
    Friend WithEvents BackHome As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
