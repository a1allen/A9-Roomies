<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordExpenseControl
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
        RecordExpenseTitleLabel = New Label()
        devider2 = New Label()
        BudgetExpenseBackButton = New Button()
        AddExpenseButton = New Button()
        ExpenseAmountTextBox = New TextBox()
        ExpenseAmountTitleLabel = New Label()
        ExpenseCheckBox = New CheckedListBox()
        AssignExpenseToTitleLabel = New Label()
        Label1 = New Label()
        ExpenseDecisionComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' RecordExpenseTitleLabel
        ' 
        RecordExpenseTitleLabel.AutoSize = True
        RecordExpenseTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        RecordExpenseTitleLabel.Location = New Point(98, 48)
        RecordExpenseTitleLabel.Name = "RecordExpenseTitleLabel"
        RecordExpenseTitleLabel.Size = New Size(239, 41)
        RecordExpenseTitleLabel.TabIndex = 67
        RecordExpenseTitleLabel.Text = "Record Expense"
        ' 
        ' devider2
        ' 
        devider2.AutoSize = True
        devider2.Location = New Point(57, 78)
        devider2.Name = "devider2"
        devider2.Size = New Size(321, 20)
        devider2.TabIndex = 68
        devider2.Text = "____________________________________________________"
        ' 
        ' BudgetExpenseBackButton
        ' 
        BudgetExpenseBackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BudgetExpenseBackButton.Location = New Point(22, 19)
        BudgetExpenseBackButton.Name = "BudgetExpenseBackButton"
        BudgetExpenseBackButton.Size = New Size(42, 42)
        BudgetExpenseBackButton.TabIndex = 69
        BudgetExpenseBackButton.Text = "X"
        BudgetExpenseBackButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseButton
        ' 
        AddExpenseButton.Location = New Point(151, 502)
        AddExpenseButton.Name = "AddExpenseButton"
        AddExpenseButton.Size = New Size(131, 29)
        AddExpenseButton.TabIndex = 70
        AddExpenseButton.Text = "Add Expense"
        AddExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' ExpenseAmountTextBox
        ' 
        ExpenseAmountTextBox.Location = New Point(57, 166)
        ExpenseAmountTextBox.Name = "ExpenseAmountTextBox"
        ExpenseAmountTextBox.Size = New Size(299, 27)
        ExpenseAmountTextBox.TabIndex = 71
        ' 
        ' ExpenseAmountTitleLabel
        ' 
        ExpenseAmountTitleLabel.AutoSize = True
        ExpenseAmountTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExpenseAmountTitleLabel.Location = New Point(57, 143)
        ExpenseAmountTitleLabel.Name = "ExpenseAmountTitleLabel"
        ExpenseAmountTitleLabel.Size = New Size(132, 20)
        ExpenseAmountTitleLabel.TabIndex = 72
        ExpenseAmountTitleLabel.Text = "Expense Amount:"
        ' 
        ' ExpenseCheckBox
        ' 
        ExpenseCheckBox.FormattingEnabled = True
        ExpenseCheckBox.Items.AddRange(New Object() {"Roommate1", "Roommate2", "Roommate3", "Roommate4"})
        ExpenseCheckBox.Location = New Point(57, 348)
        ExpenseCheckBox.Name = "ExpenseCheckBox"
        ExpenseCheckBox.Size = New Size(299, 92)
        ExpenseCheckBox.TabIndex = 73
        ' 
        ' AssignExpenseToTitleLabel
        ' 
        AssignExpenseToTitleLabel.AutoSize = True
        AssignExpenseToTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AssignExpenseToTitleLabel.Location = New Point(57, 325)
        AssignExpenseToTitleLabel.Name = "AssignExpenseToTitleLabel"
        AssignExpenseToTitleLabel.Size = New Size(109, 20)
        AssignExpenseToTitleLabel.TabIndex = 74
        AssignExpenseToTitleLabel.Text = "Distrubute To:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(57, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 20)
        Label1.TabIndex = 75
        Label1.Text = "Should expense be added or subtracted?"
        ' 
        ' ExpenseDecisionComboBox
        ' 
        ExpenseDecisionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ExpenseDecisionComboBox.FormattingEnabled = True
        ExpenseDecisionComboBox.Items.AddRange(New Object() {"Add", "Subtract"})
        ExpenseDecisionComboBox.Location = New Point(57, 255)
        ExpenseDecisionComboBox.Name = "ExpenseDecisionComboBox"
        ExpenseDecisionComboBox.Size = New Size(299, 28)
        ExpenseDecisionComboBox.TabIndex = 76
        ' 
        ' RecordExpenseControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ExpenseDecisionComboBox)
        Controls.Add(Label1)
        Controls.Add(AssignExpenseToTitleLabel)
        Controls.Add(ExpenseCheckBox)
        Controls.Add(ExpenseAmountTitleLabel)
        Controls.Add(ExpenseAmountTextBox)
        Controls.Add(AddExpenseButton)
        Controls.Add(BudgetExpenseBackButton)
        Controls.Add(RecordExpenseTitleLabel)
        Controls.Add(devider2)
        Name = "RecordExpenseControl"
        Size = New Size(434, 690)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RecordExpenseTitleLabel As Label
    Friend WithEvents devider2 As Label
    Friend WithEvents BudgetExpenseBackButton As Button
    Friend WithEvents AddExpenseButton As Button
    Friend WithEvents ExpenseAmountTextBox As TextBox
    Friend WithEvents ExpenseAmountTitleLabel As Label
    Friend WithEvents ExpenseCheckBox As CheckedListBox
    Friend WithEvents AssignExpenseToTitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExpenseDecisionComboBox As ComboBox
End Class
