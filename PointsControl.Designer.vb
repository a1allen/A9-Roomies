<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PointsControl
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
        PointsLabel = New Label()
        SuspendLayout()
        ' 
        ' PointsLabel
        ' 
        PointsLabel.AutoSize = True
        PointsLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        PointsLabel.Location = New Point(117, 43)
        PointsLabel.Name = "PointsLabel"
        PointsLabel.Size = New Size(201, 41)
        PointsLabel.TabIndex = 16
        PointsLabel.Text = "House Points"
        ' 
        ' PointsControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PointsLabel)
        Name = "PointsControl"
        Size = New Size(434, 711)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PointsLabel As Label
End Class
