<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementFAQControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManagementFAQControl))
        BackButton = New Button()
        FAQRichTextBox = New RichTextBox()
        FAQTitleLabel = New Label()
        SuspendLayout()
        ' 
        ' BackButton
        ' 
        BackButton.Location = New Point(9, 16)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(75, 23)
        BackButton.TabIndex = 23
        BackButton.Text = "Back"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' FAQRichTextBox
        ' 
        FAQRichTextBox.BackColor = Color.WhiteSmoke
        FAQRichTextBox.Location = New Point(12, 85)
        FAQRichTextBox.Name = "FAQRichTextBox"
        FAQRichTextBox.ReadOnly = True
        FAQRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical
        FAQRichTextBox.Size = New Size(404, 623)
        FAQRichTextBox.TabIndex = 22
        FAQRichTextBox.Text = resources.GetString("FAQRichTextBox.Text")
        ' 
        ' FAQTitleLabel
        ' 
        FAQTitleLabel.AutoSize = True
        FAQTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        FAQTitleLabel.Location = New Point(9, 45)
        FAQTitleLabel.Name = "FAQTitleLabel"
        FAQTitleLabel.Size = New Size(404, 32)
        FAQTitleLabel.TabIndex = 20
        FAQTitleLabel.Text = "Frequently Asked Questions (FAQ)"
        ' 
        ' FAQControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BackButton)
        Controls.Add(FAQRichTextBox)
        Controls.Add(FAQTitleLabel)
        Name = "FAQControl"
        Size = New Size(429, 722)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents FAQRichTextBox As RichTextBox
    Friend WithEvents FAQTitleLabel As Label
End Class
