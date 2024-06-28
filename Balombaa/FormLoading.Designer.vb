<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ProgressBarLoading = New ProgressBar()
        Dim LabelLoadingMessage = New Label()
        SuspendLayout()
        '
        ' ProgressBarLoading
        '
        ProgressBarLoading.Location = New System.Drawing.Point(20, 40)
        ProgressBarLoading.Name = "ProgressBarLoading"
        ProgressBarLoading.Size = New System.Drawing.Size(260, 23)
        ProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        ProgressBarLoading.TabIndex = 0
        '
        ' LabelLoadingMessage
        '
        LabelLoadingMessage.AutoSize = True
        LabelLoadingMessage.Location = New System.Drawing.Point(20, 80)
        LabelLoadingMessage.Name = "LabelLoadingMessage"
        LabelLoadingMessage.Size = New System.Drawing.Size(68, 13)
        LabelLoadingMessage.TabIndex = 1
        LabelLoadingMessage.Text = "Loading..."
        '
        ' FormLoading
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(300, 120)
        Controls.Add(LabelLoadingMessage)
        Controls.Add(ProgressBarLoading)
        Name = "FormLoading"
        Text = "FormLoading"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents ProgressBarLoading As ProgressBar
    Private WithEvents LabelLoadingMessage As Label
End Class
