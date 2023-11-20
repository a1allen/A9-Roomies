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
        FAQRichTextBox = New RichTextBox()
        FAQTitleLabel = New Label()
        BackButton = New Button()
        SuspendLayout()
        ' 
        ' FAQRichTextBox
        ' 
        FAQRichTextBox.BackColor = Color.WhiteSmoke
        FAQRichTextBox.Location = New Point(19, 145)
        FAQRichTextBox.Margin = New Padding(3, 4, 3, 4)
        FAQRichTextBox.Name = "FAQRichTextBox"
        FAQRichTextBox.ReadOnly = True
        FAQRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical
        FAQRichTextBox.Size = New Size(396, 527)
        FAQRichTextBox.TabIndex = 22
        FAQRichTextBox.Text = resources.GetString("FAQRichTextBox.Text")
        ' 
        ' FAQTitleLabel
        ' 
        FAQTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        FAQTitleLabel.Location = New Point(15, 45)
        FAQTitleLabel.Name = "FAQTitleLabel"
        FAQTitleLabel.Size = New Size(404, 96)
        FAQTitleLabel.TabIndex = 20
        FAQTitleLabel.Text = "Frequently Asked Questions (FAQ)"
        FAQTitleLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(19, 16)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(42, 42)
        BackButton.TabIndex = 67
        BackButton.Text = "X"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' ManagementFAQControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(BackButton)
        Controls.Add(FAQRichTextBox)
        Controls.Add(FAQTitleLabel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ManagementFAQControl"
        Size = New Size(434, 690)
        ResumeLayout(False)
    End Sub
    Friend WithEvents FAQRichTextBox As RichTextBox
    Friend WithEvents FAQTitleLabel As Label
    Friend WithEvents BackButton As Button
End Class
