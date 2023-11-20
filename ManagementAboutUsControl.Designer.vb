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
        AboutUsTitleLabel.Location = New Point(102, 40)
        AboutUsTitleLabel.Name = "AboutUsTitleLabel"
        AboutUsTitleLabel.Size = New Size(234, 41)
        AboutUsTitleLabel.TabIndex = 15
        AboutUsTitleLabel.Text = "About Roomies"
        ' 
        ' TestimonialsLabel
        ' 
        TestimonialsLabel.AutoSize = True
        TestimonialsLabel.BorderStyle = BorderStyle.FixedSingle
        TestimonialsLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TestimonialsLabel.Location = New Point(3, 590)
        TestimonialsLabel.Name = "TestimonialsLabel"
        TestimonialsLabel.Size = New Size(428, 102)
        TestimonialsLabel.TabIndex = 17
        TestimonialsLabel.Text = "★★★★★ - Forbes Magazine" & vbCrLf & vbCrLf & """A9 Team: Geniuses of the Year - 2023"" - People Magazine" & vbCrLf & vbCrLf & """Roomies is the Best Thing Since Sliced Bread"" - Bloomberg"
        TestimonialsLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' AboutUsRichTextBox
        ' 
        AboutUsRichTextBox.BackColor = Color.WhiteSmoke
        AboutUsRichTextBox.Location = New Point(11, 87)
        AboutUsRichTextBox.Margin = New Padding(3, 4, 3, 4)
        AboutUsRichTextBox.Name = "AboutUsRichTextBox"
        AboutUsRichTextBox.ReadOnly = True
        AboutUsRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical
        AboutUsRichTextBox.Size = New Size(412, 485)
        AboutUsRichTextBox.TabIndex = 18
        AboutUsRichTextBox.Text = resources.GetString("AboutUsRichTextBox.Text")
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(16, 15)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(42, 42)
        BackButton.TabIndex = 67
        BackButton.Text = "X"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' ManagementAboutUsControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(BackButton)
        Controls.Add(AboutUsRichTextBox)
        Controls.Add(TestimonialsLabel)
        Controls.Add(AboutUsTitleLabel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ManagementAboutUsControl"
        Size = New Size(434, 711)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AboutUsTitleLabel As Label
    Friend WithEvents TestimonialsLabel As Label
    Friend WithEvents AboutUsRichTextBox As RichTextBox
    Friend WithEvents BackButton As Button
End Class
