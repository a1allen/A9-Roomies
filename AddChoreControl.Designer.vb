<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChoreControl
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        AddChoreTitleLabel = New Label()
        CancelButton = New Button()
        AddChoreButton = New Button()
        ChoreTypeLabel = New Label()
        ChoreTypeComboBox = New ComboBox()
        NewChoreLabel = New Label()
        CustomChorePanel = New Panel()
        DecorationPanel5 = New Panel()
        DecorationPanel4 = New Panel()
        NewChoreWeightComboBox = New ComboBox()
        NewChoreTextBox = New TextBox()
        NewChorePointsLabel = New Label()
        RoomateComboBox = New ComboBox()
        AssignedToLabel = New Label()
        DateLabel = New Label()
        AddChoreDateTimePicker = New DateTimePicker()
        RepeatComboBox = New ComboBox()
        RepeatLabel = New Label()
        RepeatFrequencyComboBox = New ComboBox()
        Label1 = New Label()
        CustomChorePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(200, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 7
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' AddChoreTitleLabel
        ' 
        AddChoreTitleLabel.AutoSize = True
        AddChoreTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        AddChoreTitleLabel.Location = New Point(133, 35)
        AddChoreTitleLabel.Name = "AddChoreTitleLabel"
        AddChoreTitleLabel.Size = New Size(168, 41)
        AddChoreTitleLabel.TabIndex = 14
        AddChoreTitleLabel.Text = "Add Chore"
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.WhiteSmoke
        CancelButton.Location = New Point(169, 603)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(94, 30)
        CancelButton.TabIndex = 53
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' AddChoreButton
        ' 
        AddChoreButton.BackColor = Color.WhiteSmoke
        AddChoreButton.Location = New Point(169, 558)
        AddChoreButton.Name = "AddChoreButton"
        AddChoreButton.Size = New Size(94, 30)
        AddChoreButton.TabIndex = 54
        AddChoreButton.Text = "Add Chore"
        AddChoreButton.UseVisualStyleBackColor = False
        ' 
        ' ChoreTypeLabel
        ' 
        ChoreTypeLabel.AutoSize = True
        ChoreTypeLabel.Location = New Point(30, 149)
        ChoreTypeLabel.Name = "ChoreTypeLabel"
        ChoreTypeLabel.Size = New Size(83, 20)
        ChoreTypeLabel.TabIndex = 55
        ChoreTypeLabel.Text = "Chore Type"
        ' 
        ' ChoreTypeComboBox
        ' 
        ChoreTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ChoreTypeComboBox.FormattingEnabled = True
        ChoreTypeComboBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery", "Add Custom Chore"})
        ChoreTypeComboBox.Location = New Point(158, 146)
        ChoreTypeComboBox.Name = "ChoreTypeComboBox"
        ChoreTypeComboBox.Size = New Size(156, 28)
        ChoreTypeComboBox.TabIndex = 56
        ' 
        ' NewChoreLabel
        ' 
        NewChoreLabel.AutoSize = True
        NewChoreLabel.Location = New Point(29, 14)
        NewChoreLabel.Name = "NewChoreLabel"
        NewChoreLabel.Size = New Size(126, 20)
        NewChoreLabel.TabIndex = 57
        NewChoreLabel.Text = "New Chore Name"
        ' 
        ' CustomChorePanel
        ' 
        CustomChorePanel.Controls.Add(DecorationPanel5)
        CustomChorePanel.Controls.Add(DecorationPanel4)
        CustomChorePanel.Controls.Add(NewChoreWeightComboBox)
        CustomChorePanel.Controls.Add(NewChoreTextBox)
        CustomChorePanel.Controls.Add(NewChorePointsLabel)
        CustomChorePanel.Controls.Add(NewChoreLabel)
        CustomChorePanel.Location = New Point(39, 180)
        CustomChorePanel.Name = "CustomChorePanel"
        CustomChorePanel.Size = New Size(355, 100)
        CustomChorePanel.TabIndex = 58
        CustomChorePanel.Visible = False
        ' 
        ' DecorationPanel5
        ' 
        DecorationPanel5.BackColor = Color.Gainsboro
        DecorationPanel5.Location = New Point(18, 84)
        DecorationPanel5.Name = "DecorationPanel5"
        DecorationPanel5.Size = New Size(332, 5)
        DecorationPanel5.TabIndex = 63
        ' 
        ' DecorationPanel4
        ' 
        DecorationPanel4.BackColor = Color.Gainsboro
        DecorationPanel4.Location = New Point(18, 3)
        DecorationPanel4.Name = "DecorationPanel4"
        DecorationPanel4.Size = New Size(5, 85)
        DecorationPanel4.TabIndex = 62
        ' 
        ' NewChoreWeightComboBox
        ' 
        NewChoreWeightComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        NewChoreWeightComboBox.FormattingEnabled = True
        NewChoreWeightComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        NewChoreWeightComboBox.Location = New Point(181, 46)
        NewChoreWeightComboBox.Name = "NewChoreWeightComboBox"
        NewChoreWeightComboBox.Size = New Size(168, 28)
        NewChoreWeightComboBox.TabIndex = 61
        ' 
        ' NewChoreTextBox
        ' 
        NewChoreTextBox.Location = New Point(181, 11)
        NewChoreTextBox.Name = "NewChoreTextBox"
        NewChoreTextBox.Size = New Size(168, 27)
        NewChoreTextBox.TabIndex = 59
        ' 
        ' NewChorePointsLabel
        ' 
        NewChorePointsLabel.AutoSize = True
        NewChorePointsLabel.Location = New Point(29, 49)
        NewChorePointsLabel.Name = "NewChorePointsLabel"
        NewChorePointsLabel.Size = New Size(99, 20)
        NewChorePointsLabel.TabIndex = 58
        NewChorePointsLabel.Text = "Chore Weight"
        ' 
        ' RoomateComboBox
        ' 
        RoomateComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        RoomateComboBox.FormattingEnabled = True
        RoomateComboBox.Items.AddRange(New Object() {"Roomate 1", "Roomate 2", "Roomate 3", "Roomate 4"})
        RoomateComboBox.Location = New Point(158, 299)
        RoomateComboBox.Name = "RoomateComboBox"
        RoomateComboBox.Size = New Size(230, 28)
        RoomateComboBox.TabIndex = 60
        ' 
        ' AssignedToLabel
        ' 
        AssignedToLabel.AutoSize = True
        AssignedToLabel.Location = New Point(30, 302)
        AssignedToLabel.Name = "AssignedToLabel"
        AssignedToLabel.Size = New Size(89, 20)
        AssignedToLabel.TabIndex = 59
        AssignedToLabel.Text = "Assigned To"
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Location = New Point(30, 388)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(41, 20)
        DateLabel.TabIndex = 61
        DateLabel.Text = "Date"
        ' 
        ' AddChoreDateTimePicker
        ' 
        AddChoreDateTimePicker.Location = New Point(158, 383)
        AddChoreDateTimePicker.Name = "AddChoreDateTimePicker"
        AddChoreDateTimePicker.Size = New Size(230, 27)
        AddChoreDateTimePicker.TabIndex = 63
        ' 
        ' RepeatComboBox
        ' 
        RepeatComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        RepeatComboBox.FormattingEnabled = True
        RepeatComboBox.Items.AddRange(New Object() {"No", "Yes"})
        RepeatComboBox.Location = New Point(158, 471)
        RepeatComboBox.Name = "RepeatComboBox"
        RepeatComboBox.Size = New Size(69, 28)
        RepeatComboBox.TabIndex = 65
        ' 
        ' RepeatLabel
        ' 
        RepeatLabel.AutoSize = True
        RepeatLabel.Location = New Point(30, 474)
        RepeatLabel.Name = "RepeatLabel"
        RepeatLabel.Size = New Size(63, 20)
        RepeatLabel.TabIndex = 64
        RepeatLabel.Text = "Repeat?"
        ' 
        ' RepeatFrequencyComboBox
        ' 
        RepeatFrequencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        RepeatFrequencyComboBox.FormattingEnabled = True
        RepeatFrequencyComboBox.Items.AddRange(New Object() {"Every Day", "Every Week", "Every 2 Weeks", "Every Month", "Every Year"})
        RepeatFrequencyComboBox.Location = New Point(233, 471)
        RepeatFrequencyComboBox.Name = "RepeatFrequencyComboBox"
        RepeatFrequencyComboBox.Size = New Size(155, 28)
        RepeatFrequencyComboBox.TabIndex = 61
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(320, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 66
        Label1.Text = "Weight"
        ' 
        ' AddChoreControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label1)
        Controls.Add(RepeatComboBox)
        Controls.Add(RepeatFrequencyComboBox)
        Controls.Add(RepeatLabel)
        Controls.Add(AddChoreDateTimePicker)
        Controls.Add(DateLabel)
        Controls.Add(RoomateComboBox)
        Controls.Add(AssignedToLabel)
        Controls.Add(CustomChorePanel)
        Controls.Add(ChoreTypeComboBox)
        Controls.Add(ChoreTypeLabel)
        Controls.Add(AddChoreButton)
        Controls.Add(CancelButton)
        Controls.Add(AddChoreTitleLabel)
        Name = "AddChoreControl"
        Size = New Size(434, 711)
        CustomChorePanel.ResumeLayout(False)
        CustomChorePanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CalendarTableLayoutPanel As TableLayoutPanel
    Friend WithEvents AddToCalendarButton As Button
    Friend WithEvents AddChoreTitleLabel As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddChoreButton As Button
    Friend WithEvents ChoreTypeLabel As Label
    Friend WithEvents ChoreTypeComboBox As ComboBox
    Friend WithEvents NewChoreLabel As Label
    Friend WithEvents CustomChorePanel As Panel
    Friend WithEvents NewChorePointsLabel As Label
    Friend WithEvents DayLabel1 As Label
    Friend WithEvents DayLabel3 As Label
    Friend WithEvents DayLabel4 As Label
    Friend WithEvents AssignedToLabel As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DayLabel2 As Label
    Friend WithEvents RoomateComboBox As ComboBox
    Friend WithEvents NewChoreTextBox As TextBox
    Friend WithEvents DecorationPanel4 As Panel
    Friend WithEvents NewChoreWeightComboBox As ComboBox
    Friend WithEvents DecorationPanel5 As Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents AddChoreDateTimePicker As DateTimePicker
    Friend WithEvents RepeatComboBox As ComboBox
    Friend WithEvents RepeatLabel As Label
    Friend WithEvents RepeatFrequencyComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
