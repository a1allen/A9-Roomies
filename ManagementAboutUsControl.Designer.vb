<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementAboutUsControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManagementAboutUsControl))
        AboutUsTitleLabel = New Label()
        TestimonialsLabel = New Label()
        AboutUsRichTextBox = New RichTextBox()
        BackButton = New Button()
        SuspendLayout()
        ' 
        ' AboutUsTitleLabel
        ' 
        AboutUsTitleLabel.AutoSize = True
        AboutUsTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        AboutUsTitleLabel.Location = New Point(119, 28)
        AboutUsTitleLabel.Name = "AboutUsTitleLabel"
        AboutUsTitleLabel.Size = New Size(190, 32)
        AboutUsTitleLabel.TabIndex = 15
        AboutUsTitleLabel.Text = "About Roomies"
        ' 
        ' TestimonialsLabel
        ' 
        TestimonialsLabel.AutoSize = True
        TestimonialsLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TestimonialsLabel.Location = New Point(44, 628)
        TestimonialsLabel.Name = "TestimonialsLabel"
        TestimonialsLabel.Size = New Size(340, 75)
        TestimonialsLabel.TabIndex = 17
        TestimonialsLabel.Text = "★★★★★ - Forbes Magazine" & vbCrLf & vbCrLf & """A9 Team: Geniuses of the Year - 2023"" - People Magazine" & vbCrLf & vbCrLf & """Roomies is the Best Thing Since Sliced Bread"" - Bloomberg"
        TestimonialsLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' AboutUsRichTextBox
        ' 
        AboutUsRichTextBox.BackColor = Color.WhiteSmoke
        AboutUsRichTextBox.Location = New Point(6, 65)
        AboutUsRichTextBox.Name = "AboutUsRichTextBox"
        AboutUsRichTextBox.ReadOnly = True
        AboutUsRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical
        AboutUsRichTextBox.Size = New Size(417, 544)
        AboutUsRichTextBox.TabIndex = 18
        AboutUsRichTextBox.Text = resources.GetString("AboutUsRichTextBox.Text")
        ' 
        ' BackButton
        ' 
        BackButton.Location = New Point(9, 12)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(75, 23)
        BackButton.TabIndex = 19
        BackButton.Text = "Back"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' ManagementAboutUsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BackButton)
        Controls.Add(AboutUsRichTextBox)
        Controls.Add(TestimonialsLabel)
        Controls.Add(AboutUsTitleLabel)
        Name = "ManagementAboutUsControl"
        Size = New Size(429, 722)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AboutUsTitleLabel As Label
    Friend WithEvents TestimonialsLabel As Label
    Friend WithEvents AboutUsRichTextBox As RichTextBox
    Friend WithEvents BackButton As Button
End Class
