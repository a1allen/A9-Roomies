<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskExtendForm
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
        NoExtendButton = New Button()
        YesExtendButton = New Button()
        QuestionExtendLabel2 = New Label()
        QuestionExtendLabel1 = New Label()
        SuspendLayout()
        ' 
        ' NoExtendButton
        ' 
        NoExtendButton.Location = New Point(163, 125)
        NoExtendButton.Name = "NoExtendButton"
        NoExtendButton.Size = New Size(68, 37)
        NoExtendButton.TabIndex = 9
        NoExtendButton.Text = "No"
        NoExtendButton.UseVisualStyleBackColor = True
        ' 
        ' YesExtendButton
        ' 
        YesExtendButton.Location = New Point(72, 125)
        YesExtendButton.Name = "YesExtendButton"
        YesExtendButton.Size = New Size(68, 37)
        YesExtendButton.TabIndex = 8
        YesExtendButton.Text = "Yes"
        YesExtendButton.UseVisualStyleBackColor = True
        ' 
        ' QuestionExtendLabel2
        ' 
        QuestionExtendLabel2.Location = New Point(39, 67)
        QuestionExtendLabel2.Name = "QuestionExtendLabel2"
        QuestionExtendLabel2.Size = New Size(224, 35)
        QuestionExtendLabel2.TabIndex = 7
        QuestionExtendLabel2.Text = "Do you want to proceed?"
        QuestionExtendLabel2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QuestionExtendLabel1
        ' 
        QuestionExtendLabel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        QuestionExtendLabel1.Location = New Point(34, 17)
        QuestionExtendLabel1.Name = "QuestionExtendLabel1"
        QuestionExtendLabel1.Size = New Size(234, 55)
        QuestionExtendLabel1.TabIndex = 6
        QuestionExtendLabel1.Text = "This will extend the selected chore for 2 days."
        QuestionExtendLabel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AskExtendForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(302, 186)
        Controls.Add(NoExtendButton)
        Controls.Add(YesExtendButton)
        Controls.Add(QuestionExtendLabel2)
        Controls.Add(QuestionExtendLabel1)
        Name = "AskExtendForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents NoExtendButton As Button
    Friend WithEvents YesExtendButton As Button
    Friend WithEvents QuestionExtendLabel2 As Label
    Friend WithEvents QuestionExtendLabel1 As Label
End Class
