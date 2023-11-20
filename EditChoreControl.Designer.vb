<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditChoreControl
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
        EditChoreTitleLabel = New Label()
        devider = New Label()
        ChoreBackButton = New Button()
        EditChorePanel = New Panel()
        EditChoreTextBox = New TextBox()
        EditChoreLabel = New Label()
        EditAssignedToPanel = New Panel()
        EditRoomateComboBox = New ComboBox()
        EditAssignedToLabel = New Label()
        EditDatePanel = New Panel()
        EditChoreDateTimePicker = New DateTimePicker()
        EditDateLabel = New Label()
        SubmitChangesChoreButton = New Button()
        DeleteButton = New Button()
        EditChorePanel.SuspendLayout()
        EditAssignedToPanel.SuspendLayout()
        EditDatePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' EditChoreTitleLabel
        ' 
        EditChoreTitleLabel.AutoSize = True
        EditChoreTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        EditChoreTitleLabel.Location = New Point(135, 79)
        EditChoreTitleLabel.Name = "EditChoreTitleLabel"
        EditChoreTitleLabel.Size = New Size(165, 41)
        EditChoreTitleLabel.TabIndex = 67
        EditChoreTitleLabel.Text = "Edit Chore"
        ' 
        ' devider
        ' 
        devider.AutoSize = True
        devider.Location = New Point(57, 109)
        devider.Name = "devider"
        devider.Size = New Size(321, 20)
        devider.TabIndex = 68
        devider.Text = "____________________________________________________"
        ' 
        ' ChoreBackButton
        ' 
        ChoreBackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChoreBackButton.Location = New Point(18, 17)
        ChoreBackButton.Name = "ChoreBackButton"
        ChoreBackButton.Size = New Size(42, 42)
        ChoreBackButton.TabIndex = 69
        ChoreBackButton.Text = "X"
        ChoreBackButton.UseVisualStyleBackColor = True
        ' 
        ' EditChorePanel
        ' 
        EditChorePanel.Controls.Add(EditChoreTextBox)
        EditChorePanel.Controls.Add(EditChoreLabel)
        EditChorePanel.Location = New Point(42, 195)
        EditChorePanel.Name = "EditChorePanel"
        EditChorePanel.Size = New Size(351, 48)
        EditChorePanel.TabIndex = 71
        ' 
        ' EditChoreTextBox
        ' 
        EditChoreTextBox.Location = New Point(153, 11)
        EditChoreTextBox.Name = "EditChoreTextBox"
        EditChoreTextBox.Size = New Size(188, 27)
        EditChoreTextBox.TabIndex = 59
        ' 
        ' EditChoreLabel
        ' 
        EditChoreLabel.AutoSize = True
        EditChoreLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        EditChoreLabel.Location = New Point(9, 14)
        EditChoreLabel.Name = "EditChoreLabel"
        EditChoreLabel.Size = New Size(91, 20)
        EditChoreLabel.TabIndex = 57
        EditChoreLabel.Text = "Chore Type:"
        ' 
        ' EditAssignedToPanel
        ' 
        EditAssignedToPanel.Controls.Add(EditRoomateComboBox)
        EditAssignedToPanel.Controls.Add(EditAssignedToLabel)
        EditAssignedToPanel.Location = New Point(42, 258)
        EditAssignedToPanel.Name = "EditAssignedToPanel"
        EditAssignedToPanel.Size = New Size(351, 48)
        EditAssignedToPanel.TabIndex = 72
        ' 
        ' EditRoomateComboBox
        ' 
        EditRoomateComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        EditRoomateComboBox.FormattingEnabled = True
        EditRoomateComboBox.Items.AddRange(New Object() {"Roomate 1", "Roomate 2", "Roomate 3", "Roomate 4"})
        EditRoomateComboBox.Location = New Point(153, 10)
        EditRoomateComboBox.Name = "EditRoomateComboBox"
        EditRoomateComboBox.Size = New Size(188, 28)
        EditRoomateComboBox.TabIndex = 62
        ' 
        ' EditAssignedToLabel
        ' 
        EditAssignedToLabel.AutoSize = True
        EditAssignedToLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        EditAssignedToLabel.Location = New Point(9, 13)
        EditAssignedToLabel.Name = "EditAssignedToLabel"
        EditAssignedToLabel.Size = New Size(98, 20)
        EditAssignedToLabel.TabIndex = 61
        EditAssignedToLabel.Text = "Assigned To:"
        ' 
        ' EditDatePanel
        ' 
        EditDatePanel.Controls.Add(EditChoreDateTimePicker)
        EditDatePanel.Controls.Add(EditDateLabel)
        EditDatePanel.Location = New Point(42, 321)
        EditDatePanel.Name = "EditDatePanel"
        EditDatePanel.Size = New Size(351, 48)
        EditDatePanel.TabIndex = 73
        ' 
        ' EditChoreDateTimePicker
        ' 
        EditChoreDateTimePicker.Location = New Point(153, 11)
        EditChoreDateTimePicker.Name = "EditChoreDateTimePicker"
        EditChoreDateTimePicker.Size = New Size(188, 27)
        EditChoreDateTimePicker.TabIndex = 65
        ' 
        ' EditDateLabel
        ' 
        EditDateLabel.AutoSize = True
        EditDateLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        EditDateLabel.Location = New Point(9, 11)
        EditDateLabel.Name = "EditDateLabel"
        EditDateLabel.Size = New Size(46, 20)
        EditDateLabel.TabIndex = 64
        EditDateLabel.Text = "Date:"
        ' 
        ' SubmitChangesChoreButton
        ' 
        SubmitChangesChoreButton.BackColor = Color.WhiteSmoke
        SubmitChangesChoreButton.Location = New Point(150, 431)
        SubmitChangesChoreButton.Name = "SubmitChangesChoreButton"
        SubmitChangesChoreButton.Size = New Size(135, 30)
        SubmitChangesChoreButton.TabIndex = 75
        SubmitChangesChoreButton.Text = "Submit Changes"
        SubmitChangesChoreButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.WhiteSmoke
        DeleteButton.Location = New Point(150, 476)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(135, 30)
        DeleteButton.TabIndex = 74
        DeleteButton.Text = "Delete Chore"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' EditChoreControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(SubmitChangesChoreButton)
        Controls.Add(DeleteButton)
        Controls.Add(EditDatePanel)
        Controls.Add(EditAssignedToPanel)
        Controls.Add(EditChorePanel)
        Controls.Add(ChoreBackButton)
        Controls.Add(EditChoreTitleLabel)
        Controls.Add(devider)
        Name = "EditChoreControl"
        Size = New Size(434, 690)
        EditChorePanel.ResumeLayout(False)
        EditChorePanel.PerformLayout()
        EditAssignedToPanel.ResumeLayout(False)
        EditAssignedToPanel.PerformLayout()
        EditDatePanel.ResumeLayout(False)
        EditDatePanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EditChoreTitleLabel As Label
    Friend WithEvents devider As Label
    Friend WithEvents ChoreBackButton As Button
    Friend WithEvents EditChorePanel As Panel
    Friend WithEvents EditChoreTextBox As TextBox
    Friend WithEvents EditChoreLabel As Label
    Friend WithEvents EditAssignedToPanel As Panel
    Friend WithEvents EditRoomateComboBox As ComboBox
    Friend WithEvents EditAssignedToLabel As Label
    Friend WithEvents EditDatePanel As Panel
    Friend WithEvents EditChoreDateTimePicker As DateTimePicker
    Friend WithEvents EditDateLabel As Label
    Friend WithEvents SubmitChangesChoreButton As Button
    Friend WithEvents DeleteButton As Button
End Class
