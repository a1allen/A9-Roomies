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
        AssignedLabel = New Label()
        EditChoreButton = New Button()
        RequestVolunteerButton = New Button()
        SuspendLayout()
        ' 
        ' ChoreName
        ' 
        ChoreName.AutoSize = True
        ChoreName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreName.Location = New Point(23, 13)
        ChoreName.Name = "ChoreName"
        ChoreName.Size = New Size(138, 25)
        ChoreName.TabIndex = 0
        ChoreName.Text = "Name of chore"
        ' 
        ' AssignTo
        ' 
        AssignTo.AutoSize = True
        AssignTo.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        AssignTo.Location = New Point(120, 61)
        AssignTo.Name = "AssignTo"
        AssignTo.Size = New Size(127, 17)
        AssignTo.TabIndex = 2
        AssignTo.Text = "Name of housemate"
        ' 
        ' AssignedLabel
        ' 
        AssignedLabel.AutoSize = True
        AssignedLabel.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        AssignedLabel.Location = New Point(25, 61)
        AssignedLabel.Name = "AssignedLabel"
        AssignedLabel.Size = New Size(85, 17)
        AssignedLabel.TabIndex = 4
        AssignedLabel.Text = "Assigned to:"
        ' 
        ' EditChoreButton
        ' 
        EditChoreButton.BackColor = Color.White
        EditChoreButton.Location = New Point(220, 9)
        EditChoreButton.Name = "EditChoreButton"
        EditChoreButton.Size = New Size(109, 29)
        EditChoreButton.TabIndex = 5
        EditChoreButton.Text = "Edit"
        EditChoreButton.UseVisualStyleBackColor = False
        ' 
        ' RequestVolunteerButton
        ' 
        RequestVolunteerButton.BackColor = Color.White
        RequestVolunteerButton.Location = New Point(220, 44)
        RequestVolunteerButton.Name = "RequestVolunteerButton"
        RequestVolunteerButton.Size = New Size(109, 54)
        RequestVolunteerButton.TabIndex = 6
        RequestVolunteerButton.Text = "Request Volunteer"
        RequestVolunteerButton.UseVisualStyleBackColor = False
        ' 
        ' Chore_item_inDay
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(RequestVolunteerButton)
        Controls.Add(EditChoreButton)
        Controls.Add(AssignedLabel)
        Controls.Add(AssignTo)
        Controls.Add(ChoreName)
        Name = "Chore_item_inDay"
        Size = New Size(412, 104)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChoreName As Label
    Friend WithEvents AssignTo As Label
    Friend WithEvents AssignedLabel As Label
    Friend WithEvents EditChoreButton As Button
    Friend WithEvents RequestVolunteerButton As Button
End Class
