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
        ExtendChoreButton = New Button()
        Label_eff = New Label()
        score_label = New Label()
        choreDone = New CheckBox()
        SuspendLayout()
        ' 
        ' ChoreName
        ' 
        ChoreName.AutoSize = True
        ChoreName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreName.Location = New Point(14, 10)
        ChoreName.Name = "ChoreName"
        ChoreName.Size = New Size(138, 25)
        ChoreName.TabIndex = 0
        ChoreName.Text = "Name of chore"
        ' 
        ' AssignTo
        ' 
        AssignTo.AutoSize = True
        AssignTo.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        AssignTo.Location = New Point(99, 54)
        AssignTo.Name = "AssignTo"
        AssignTo.Size = New Size(88, 17)
        AssignTo.TabIndex = 2
        AssignTo.Text = "RoomieName"
        ' 
        ' AssignedLabel
        ' 
        AssignedLabel.AutoSize = True
        AssignedLabel.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        AssignedLabel.Location = New Point(16, 54)
        AssignedLabel.Name = "AssignedLabel"
        AssignedLabel.Size = New Size(85, 17)
        AssignedLabel.TabIndex = 4
        AssignedLabel.Text = "Assigned to:"
        ' 
        ' EditChoreButton
        ' 
        EditChoreButton.BackColor = Color.White
        EditChoreButton.Location = New Point(212, 42)
        EditChoreButton.Name = "EditChoreButton"
        EditChoreButton.Size = New Size(52, 29)
        EditChoreButton.TabIndex = 5
        EditChoreButton.Text = "Edit"
        EditChoreButton.UseVisualStyleBackColor = False
        ' 
        ' RequestVolunteerButton
        ' 
        RequestVolunteerButton.BackColor = Color.White
        RequestVolunteerButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RequestVolunteerButton.Location = New Point(212, 73)
        RequestVolunteerButton.Name = "RequestVolunteerButton"
        RequestVolunteerButton.Size = New Size(137, 29)
        RequestVolunteerButton.TabIndex = 6
        RequestVolunteerButton.Text = "Request Volunteer"
        RequestVolunteerButton.UseVisualStyleBackColor = False
        ' 
        ' ExtendChoreButton
        ' 
        ExtendChoreButton.BackColor = Color.White
        ExtendChoreButton.Location = New Point(270, 42)
        ExtendChoreButton.Name = "ExtendChoreButton"
        ExtendChoreButton.Size = New Size(79, 29)
        ExtendChoreButton.TabIndex = 7
        ExtendChoreButton.Text = "Extend"
        ExtendChoreButton.UseVisualStyleBackColor = False
        ' 
        ' Label_eff
        ' 
        Label_eff.AutoSize = True
        Label_eff.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_eff.Location = New Point(16, 76)
        Label_eff.Name = "Label_eff"
        Label_eff.Size = New Size(117, 17)
        Label_eff.TabIndex = 8
        Label_eff.Text = "difficulty (effort):"
        ' 
        ' score_label
        ' 
        score_label.AutoSize = True
        score_label.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        score_label.Location = New Point(139, 76)
        score_label.Name = "score_label"
        score_label.Size = New Size(13, 17)
        score_label.TabIndex = 9
        score_label.Text = "-"
        ' 
        ' choreDone
        ' 
        choreDone.AutoSize = True
        choreDone.BackColor = Color.Transparent
        choreDone.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        choreDone.ForeColor = SystemColors.ActiveCaptionText
        choreDone.Location = New Point(275, 11)
        choreDone.Name = "choreDone"
        choreDone.RightToLeft = RightToLeft.No
        choreDone.Size = New Size(75, 24)
        choreDone.TabIndex = 10
        choreDone.Text = "Done?"
        choreDone.UseVisualStyleBackColor = False
        ' 
        ' Chore_item_inDay
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(choreDone)
        Controls.Add(score_label)
        Controls.Add(Label_eff)
        Controls.Add(ExtendChoreButton)
        Controls.Add(RequestVolunteerButton)
        Controls.Add(EditChoreButton)
        Controls.Add(AssignedLabel)
        Controls.Add(AssignTo)
        Controls.Add(ChoreName)
        Name = "Chore_item_inDay"
        Size = New Size(412, 107)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChoreName As Label
    Friend WithEvents AssignTo As Label
    Friend WithEvents AssignedLabel As Label
    Friend WithEvents EditChoreButton As Button
    Friend WithEvents RequestVolunteerButton As Button
    Friend WithEvents ExtendChoreButton As Button
    Friend WithEvents Label_eff As Label
    Friend WithEvents score_label As Label
    Friend WithEvents choreDone As CheckBox
End Class
