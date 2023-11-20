<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmationForm
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
        MessageLabel = New Label()
        YesButton = New Button()
        NoButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' MessageLabel
        ' 
        MessageLabel.AutoSize = True
        MessageLabel.Location = New Point(75, 37)
        MessageLabel.Name = "MessageLabel"
        MessageLabel.Size = New Size(159, 20)
        MessageLabel.TabIndex = 0
        MessageLabel.Text = "Are you sure you want "
        MessageLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' YesButton
        ' 
        YesButton.Location = New Point(52, 132)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(94, 29)
        YesButton.TabIndex = 1
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' NoButton
        ' 
        NoButton.Location = New Point(163, 132)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(94, 29)
        NoButton.TabIndex = 2
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 20)
        Label1.TabIndex = 3
        Label1.Text = "to mark the chore as done?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ConfirmationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 192)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(NoButton)
        Controls.Add(YesButton)
        Controls.Add(MessageLabel)
        Name = "ConfirmationForm"
        Text = "ConfirmationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MessageLabel As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
    Friend WithEvents Label1 As Label
End Class
