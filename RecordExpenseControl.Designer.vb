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
        AssignExpenseToTitleLabel = New Label()
        whoPaidCombo = New ComboBox()
        whoPaidLabel = New Label()
        R_check = New CheckBox()
        R1_check = New CheckBox()
        R4_check = New CheckBox()
        R3_check = New CheckBox()
        R2_check = New CheckBox()
        Label1 = New Label()
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
        ExpenseAmountTextBox.Location = New Point(57, 151)
        ExpenseAmountTextBox.Name = "ExpenseAmountTextBox"
        ExpenseAmountTextBox.Size = New Size(299, 27)
        ExpenseAmountTextBox.TabIndex = 71
        ' 
        ' ExpenseAmountTitleLabel
        ' 
        ExpenseAmountTitleLabel.AutoSize = True
        ExpenseAmountTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExpenseAmountTitleLabel.Location = New Point(57, 128)
        ExpenseAmountTitleLabel.Name = "ExpenseAmountTitleLabel"
        ExpenseAmountTitleLabel.Size = New Size(71, 20)
        ExpenseAmountTitleLabel.TabIndex = 72
        ExpenseAmountTitleLabel.Text = "Amount:"
        ' 
        ' AssignExpenseToTitleLabel
        ' 
        AssignExpenseToTitleLabel.AutoSize = True
        AssignExpenseToTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AssignExpenseToTitleLabel.Location = New Point(57, 267)
        AssignExpenseToTitleLabel.Name = "AssignExpenseToTitleLabel"
        AssignExpenseToTitleLabel.Size = New Size(152, 20)
        AssignExpenseToTitleLabel.TabIndex = 74
        AssignExpenseToTitleLabel.Text = "Distrubute between:"
        ' 
        ' whoPaidCombo
        ' 
        whoPaidCombo.DropDownStyle = ComboBoxStyle.DropDownList
        whoPaidCombo.FormattingEnabled = True
        whoPaidCombo.Items.AddRange(New Object() {"No one yet", "Roommate1", "Roommate2", "Roommate3", "Roommate4"})
        whoPaidCombo.Location = New Point(57, 219)
        whoPaidCombo.Name = "whoPaidCombo"
        whoPaidCombo.Size = New Size(299, 28)
        whoPaidCombo.TabIndex = 78
        ' 
        ' whoPaidLabel
        ' 
        whoPaidLabel.AutoSize = True
        whoPaidLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        whoPaidLabel.Location = New Point(57, 196)
        whoPaidLabel.Name = "whoPaidLabel"
        whoPaidLabel.Size = New Size(184, 20)
        whoPaidLabel.TabIndex = 77
        whoPaidLabel.Text = "Who made the payment?"
        ' 
        ' R_check
        ' 
        R_check.AutoSize = True
        R_check.Location = New Point(57, 304)
        R_check.Name = "R_check"
        R_check.Size = New Size(91, 24)
        R_check.TabIndex = 79
        R_check.Text = "Everyone"
        R_check.UseVisualStyleBackColor = True
        ' 
        ' R1_check
        ' 
        R1_check.AutoSize = True
        R1_check.Location = New Point(57, 342)
        R1_check.Name = "R1_check"
        R1_check.Size = New Size(113, 24)
        R1_check.TabIndex = 80
        R1_check.Text = "Roommate1"
        R1_check.UseVisualStyleBackColor = True
        ' 
        ' R4_check
        ' 
        R4_check.AutoSize = True
        R4_check.Location = New Point(192, 374)
        R4_check.Name = "R4_check"
        R4_check.Size = New Size(113, 24)
        R4_check.TabIndex = 81
        R4_check.Text = "Roommate4"
        R4_check.UseVisualStyleBackColor = True
        ' 
        ' R3_check
        ' 
        R3_check.AutoSize = True
        R3_check.Location = New Point(57, 372)
        R3_check.Name = "R3_check"
        R3_check.Size = New Size(113, 24)
        R3_check.TabIndex = 82
        R3_check.Text = "Roommate3"
        R3_check.UseVisualStyleBackColor = True
        ' 
        ' R2_check
        ' 
        R2_check.AutoSize = True
        R2_check.Location = New Point(192, 342)
        R2_check.Name = "R2_check"
        R2_check.Size = New Size(113, 24)
        R2_check.TabIndex = 83
        R2_check.Text = "Roommate2"
        R2_check.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 316)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 20)
        Label1.TabIndex = 84
        Label1.Text = "____________________"
        ' 
        ' RecordExpenseControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(R2_check)
        Controls.Add(R3_check)
        Controls.Add(R4_check)
        Controls.Add(R1_check)
        Controls.Add(R_check)
        Controls.Add(whoPaidCombo)
        Controls.Add(whoPaidLabel)
        Controls.Add(AssignExpenseToTitleLabel)
        Controls.Add(ExpenseAmountTitleLabel)
        Controls.Add(ExpenseAmountTextBox)
        Controls.Add(AddExpenseButton)
        Controls.Add(BudgetExpenseBackButton)
        Controls.Add(RecordExpenseTitleLabel)
        Controls.Add(devider2)
        Controls.Add(Label1)
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
    Friend WithEvents AssignExpenseToTitleLabel As Label
    Friend WithEvents whoPaidCombo As ComboBox
    Friend WithEvents whoPaidLabel As Label
    Friend WithEvents R_check As CheckBox
    Friend WithEvents R1_check As CheckBox
    Friend WithEvents R4_check As CheckBox
    Friend WithEvents R3_check As CheckBox
    Friend WithEvents R2_check As CheckBox
    Friend WithEvents Label1 As Label
End Class
