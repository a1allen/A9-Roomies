<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetControl
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
        BudgetLabel = New Label()
        SuspendLayout()
        ' 
        ' BudgetLabel
        ' 
        BudgetLabel.AutoSize = True
        BudgetLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BudgetLabel.Location = New Point(109, 37)
        BudgetLabel.Name = "BudgetLabel"
        BudgetLabel.Size = New Size(217, 41)
        BudgetLabel.TabIndex = 15
        BudgetLabel.Text = "House Budget"
        ' 
        ' BudgetControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BudgetLabel)
        Name = "BudgetControl"
        Size = New Size(434, 711)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BudgetLabel As Label
End Class
