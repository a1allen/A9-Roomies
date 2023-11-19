<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chore_item_inDay
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
        ChoreName = New Label()
        AssignTo = New Label()
        RepeatedEvent = New Label()
        AssignedLabel = New Label()
        Repeated_y_or_N = New Label()
        SuspendLayout()
        ' 
        ' ChoreName
        ' 
        ChoreName.AutoSize = True
        ChoreName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreName.Location = New Point(23, 9)
        ChoreName.Name = "ChoreName"
        ChoreName.Size = New Size(138, 25)
        ChoreName.TabIndex = 0
        ChoreName.Text = "Name of chore"
        ' 
        ' AssignTo
        ' 
        AssignTo.AutoSize = True
        AssignTo.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        AssignTo.Location = New Point(120, 75)
        AssignTo.Name = "AssignTo"
        AssignTo.Size = New Size(127, 17)
        AssignTo.TabIndex = 2
        AssignTo.Text = "Name of housemate"
        ' 
        ' RepeatedEvent
        ' 
        RepeatedEvent.AutoSize = True
        RepeatedEvent.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        RepeatedEvent.Location = New Point(25, 57)
        RepeatedEvent.Name = "RepeatedEvent"
        RepeatedEvent.Size = New Size(125, 17)
        RepeatedEvent.TabIndex = 3
        RepeatedEvent.Text = "Repeated (yes/no):"
        ' 
        ' AssignedLabel
        ' 
        AssignedLabel.AutoSize = True
        AssignedLabel.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        AssignedLabel.Location = New Point(25, 75)
        AssignedLabel.Name = "AssignedLabel"
        AssignedLabel.Size = New Size(85, 17)
        AssignedLabel.TabIndex = 4
        AssignedLabel.Text = "Assigned to:"
        ' 
        ' Repeated_y_or_N
        ' 
        Repeated_y_or_N.AutoSize = True
        Repeated_y_or_N.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Repeated_y_or_N.Location = New Point(156, 57)
        Repeated_y_or_N.Name = "Repeated_y_or_N"
        Repeated_y_or_N.Size = New Size(26, 17)
        Repeated_y_or_N.TabIndex = 5
        Repeated_y_or_N.Text = "No"
        ' 
        ' Chore_item_inDay
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(Repeated_y_or_N)
        Controls.Add(AssignedLabel)
        Controls.Add(RepeatedEvent)
        Controls.Add(AssignTo)
        Controls.Add(ChoreName)
        Name = "Chore_item_inDay"
        Size = New Size(412, 104)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChoreName As Label
    Friend WithEvents AssignTo As Label
    Friend WithEvents RepeatedEvent As Label
    Friend WithEvents AssignedLabel As Label
    Friend WithEvents Repeated_y_or_N As Label

End Class
