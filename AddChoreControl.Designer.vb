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
        NewChoreTextBox = New TextBox()
        AssignedToPanel = New Panel()
        RoomateComboBox = New ComboBox()
        AssignedToLabel = New Label()
        DatePanel = New Panel()
        AddChoreDateTimePicker = New DateTimePicker()
        DateLabel = New Label()
        ChoreBackButton = New Button()
        devider = New Label()
        EffortPanel = New Panel()
        EffortScore = New ComboBox()
        Label2 = New Label()
        CustomChorePanel.SuspendLayout()
        AssignedToPanel.SuspendLayout()
        DatePanel.SuspendLayout()
        EffortPanel.SuspendLayout()
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
        AddChoreTitleLabel.Location = New Point(133, 78)
        AddChoreTitleLabel.Name = "AddChoreTitleLabel"
        AddChoreTitleLabel.Size = New Size(168, 41)
        AddChoreTitleLabel.TabIndex = 14
        AddChoreTitleLabel.Text = "Add Chore"
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.WhiteSmoke
        CancelButton.Location = New Point(170, 523)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(94, 30)
        CancelButton.TabIndex = 53
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' AddChoreButton
        ' 
        AddChoreButton.BackColor = Color.WhiteSmoke
        AddChoreButton.Location = New Point(170, 484)
        AddChoreButton.Name = "AddChoreButton"
        AddChoreButton.Size = New Size(94, 30)
        AddChoreButton.TabIndex = 54
        AddChoreButton.Text = "Add Chore"
        AddChoreButton.UseVisualStyleBackColor = False
        ' 
        ' ChoreTypeLabel
        ' 
        ChoreTypeLabel.AutoSize = True
        ChoreTypeLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ChoreTypeLabel.Location = New Point(45, 162)
        ChoreTypeLabel.Name = "ChoreTypeLabel"
        ChoreTypeLabel.Size = New Size(91, 20)
        ChoreTypeLabel.TabIndex = 55
        ChoreTypeLabel.Text = "Chore Type:"
        ' 
        ' ChoreTypeComboBox
        ' 
        ChoreTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ChoreTypeComboBox.FormattingEnabled = True
        ChoreTypeComboBox.Items.AddRange(New Object() {"----- Custom Chore -----", "Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        ChoreTypeComboBox.Location = New Point(189, 159)
        ChoreTypeComboBox.Name = "ChoreTypeComboBox"
        ChoreTypeComboBox.Size = New Size(188, 28)
        ChoreTypeComboBox.TabIndex = 56
        ' 
        ' NewChoreLabel
        ' 
        NewChoreLabel.AutoSize = True
        NewChoreLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        NewChoreLabel.Location = New Point(9, 14)
        NewChoreLabel.Name = "NewChoreLabel"
        NewChoreLabel.Size = New Size(136, 20)
        NewChoreLabel.TabIndex = 57
        NewChoreLabel.Text = "New Chore Name:"
        ' 
        ' CustomChorePanel
        ' 
        CustomChorePanel.Controls.Add(NewChoreTextBox)
        CustomChorePanel.Controls.Add(NewChoreLabel)
        CustomChorePanel.Location = New Point(36, 188)
        CustomChorePanel.Name = "CustomChorePanel"
        CustomChorePanel.Size = New Size(351, 48)
        CustomChorePanel.TabIndex = 58
        CustomChorePanel.Visible = False
        ' 
        ' NewChoreTextBox
        ' 
        NewChoreTextBox.Location = New Point(153, 11)
        NewChoreTextBox.Name = "NewChoreTextBox"
        NewChoreTextBox.Size = New Size(188, 27)
        NewChoreTextBox.TabIndex = 59
        ' 
        ' AssignedToPanel
        ' 
        AssignedToPanel.Controls.Add(RoomateComboBox)
        AssignedToPanel.Controls.Add(AssignedToLabel)
        AssignedToPanel.Location = New Point(36, 255)
        AssignedToPanel.Name = "AssignedToPanel"
        AssignedToPanel.Size = New Size(351, 48)
        AssignedToPanel.TabIndex = 60
        AssignedToPanel.Visible = False
        ' 
        ' RoomateComboBox
        ' 
        RoomateComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        RoomateComboBox.FormattingEnabled = True
        RoomateComboBox.Items.AddRange(New Object() {"Roomate 1", "Roomate 2", "Roomate 3", "Roomate 4"})
        RoomateComboBox.Location = New Point(153, 10)
        RoomateComboBox.Name = "RoomateComboBox"
        RoomateComboBox.Size = New Size(188, 28)
        RoomateComboBox.TabIndex = 62
        ' 
        ' AssignedToLabel
        ' 
        AssignedToLabel.AutoSize = True
        AssignedToLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AssignedToLabel.Location = New Point(9, 13)
        AssignedToLabel.Name = "AssignedToLabel"
        AssignedToLabel.Size = New Size(98, 20)
        AssignedToLabel.TabIndex = 61
        AssignedToLabel.Text = "Assigned To:"
        ' 
        ' DatePanel
        ' 
        DatePanel.Controls.Add(AddChoreDateTimePicker)
        DatePanel.Controls.Add(DateLabel)
        DatePanel.Location = New Point(36, 397)
        DatePanel.Name = "DatePanel"
        DatePanel.Size = New Size(351, 48)
        DatePanel.TabIndex = 63
        DatePanel.Visible = False
        ' 
        ' AddChoreDateTimePicker
        ' 
        AddChoreDateTimePicker.Location = New Point(153, 11)
        AddChoreDateTimePicker.Name = "AddChoreDateTimePicker"
        AddChoreDateTimePicker.Size = New Size(188, 27)
        AddChoreDateTimePicker.TabIndex = 65
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DateLabel.Location = New Point(9, 11)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(46, 20)
        DateLabel.TabIndex = 64
        DateLabel.Text = "Date:"
        ' 
        ' ChoreBackButton
        ' 
        ChoreBackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChoreBackButton.Location = New Point(19, 17)
        ChoreBackButton.Name = "ChoreBackButton"
        ChoreBackButton.Size = New Size(42, 42)
        ChoreBackButton.TabIndex = 65
        ChoreBackButton.Text = "X"
        ChoreBackButton.UseVisualStyleBackColor = True
        ' 
        ' devider
        ' 
        devider.AutoSize = True
        devider.Location = New Point(57, 108)
        devider.Name = "devider"
        devider.Size = New Size(321, 20)
        devider.TabIndex = 66
        devider.Text = "____________________________________________________"
        ' 
        ' EffortPanel
        ' 
        EffortPanel.Controls.Add(EffortScore)
        EffortPanel.Controls.Add(Label2)
        EffortPanel.Location = New Point(36, 327)
        EffortPanel.Name = "EffortPanel"
        EffortPanel.Size = New Size(351, 48)
        EffortPanel.TabIndex = 67
        ' 
        ' EffortScore
        ' 
        EffortScore.DropDownStyle = ComboBoxStyle.DropDownList
        EffortScore.FormattingEnabled = True
        EffortScore.Items.AddRange(New Object() {"1 ★", "2 ★★", "3 ★★★", "4 ★★★★", "5 ★★★★★"})
        EffortScore.Location = New Point(241, 11)
        EffortScore.Name = "EffortScore"
        EffortScore.Size = New Size(101, 28)
        EffortScore.TabIndex = 67
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(9, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 20)
        Label2.TabIndex = 65
        Label2.Text = "Difficulty Of The Chore?"
        ' 
        ' AddChoreControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(EffortPanel)
        Controls.Add(ChoreBackButton)
        Controls.Add(DatePanel)
        Controls.Add(AssignedToPanel)
        Controls.Add(CustomChorePanel)
        Controls.Add(ChoreTypeComboBox)
        Controls.Add(ChoreTypeLabel)
        Controls.Add(AddChoreButton)
        Controls.Add(CancelButton)
        Controls.Add(AddChoreTitleLabel)
        Controls.Add(devider)
        Name = "AddChoreControl"
        Size = New Size(434, 711)
        CustomChorePanel.ResumeLayout(False)
        CustomChorePanel.PerformLayout()
        AssignedToPanel.ResumeLayout(False)
        AssignedToPanel.PerformLayout()
        DatePanel.ResumeLayout(False)
        DatePanel.PerformLayout()
        EffortPanel.ResumeLayout(False)
        EffortPanel.PerformLayout()
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
    Friend WithEvents DayLabel1 As Label
    Friend WithEvents DayLabel3 As Label
    Friend WithEvents DayLabel4 As Label
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
    Friend WithEvents NewChoreTextBox As TextBox
    Friend WithEvents AssignedToPanel As Panel
    Friend WithEvents RoomateComboBox As ComboBox
    Friend WithEvents AssignedToLabel As Label
    Friend WithEvents DatePanel As Panel
    Friend WithEvents AddChoreDateTimePicker As DateTimePicker
    Friend WithEvents DateLabel As Label
    Friend WithEvents ChoreBackButton As Button
    Friend WithEvents devider As Label
    Friend WithEvents EffortPanel As Panel
    Friend WithEvents EffortScore As ComboBox
End Class
