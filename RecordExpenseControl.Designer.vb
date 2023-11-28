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
        Label2 = New Label()
        label_of_record = New TextBox()
        SuspendLayout()
        ' 
        ' RecordExpenseTitleLabel
        ' 
        RecordExpenseTitleLabel.AutoSize = True
        RecordExpenseTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        RecordExpenseTitleLabel.Location = New Point(86, 36)
        RecordExpenseTitleLabel.Name = "RecordExpenseTitleLabel"
        RecordExpenseTitleLabel.Size = New Size(194, 32)
        RecordExpenseTitleLabel.TabIndex = 67
        RecordExpenseTitleLabel.Text = "Record Expense"
        ' 
        ' devider2
        ' 
        devider2.AutoSize = True
        devider2.Location = New Point(50, 58)
        devider2.Name = "devider2"
        devider2.Size = New Size(267, 15)
        devider2.TabIndex = 68
        devider2.Text = "____________________________________________________"
        ' 
        ' BudgetExpenseBackButton
        ' 
        BudgetExpenseBackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BudgetExpenseBackButton.Location = New Point(19, 14)
        BudgetExpenseBackButton.Margin = New Padding(3, 2, 3, 2)
        BudgetExpenseBackButton.Name = "BudgetExpenseBackButton"
        BudgetExpenseBackButton.Size = New Size(37, 32)
        BudgetExpenseBackButton.TabIndex = 69
        BudgetExpenseBackButton.Text = "X"
        BudgetExpenseBackButton.UseVisualStyleBackColor = True
        ' 
        ' AddExpenseButton
        ' 
        AddExpenseButton.Location = New Point(132, 376)
        AddExpenseButton.Margin = New Padding(3, 2, 3, 2)
        AddExpenseButton.Name = "AddExpenseButton"
        AddExpenseButton.Size = New Size(115, 22)
        AddExpenseButton.TabIndex = 70
        AddExpenseButton.Text = "Add Expense"
        AddExpenseButton.UseVisualStyleBackColor = True
        ' 
        ' ExpenseAmountTextBox
        ' 
        ExpenseAmountTextBox.Location = New Point(60, 165)
        ExpenseAmountTextBox.Margin = New Padding(3, 2, 3, 2)
        ExpenseAmountTextBox.Name = "ExpenseAmountTextBox"
        ExpenseAmountTextBox.Size = New Size(262, 23)
        ExpenseAmountTextBox.TabIndex = 71
        ' 
        ' ExpenseAmountTitleLabel
        ' 
        ExpenseAmountTitleLabel.AutoSize = True
        ExpenseAmountTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ExpenseAmountTitleLabel.Location = New Point(60, 148)
        ExpenseAmountTitleLabel.Name = "ExpenseAmountTitleLabel"
        ExpenseAmountTitleLabel.Size = New Size(55, 15)
        ExpenseAmountTitleLabel.TabIndex = 72
        ExpenseAmountTitleLabel.Text = "Amount:"
        ' 
        ' AssignExpenseToTitleLabel
        ' 
        AssignExpenseToTitleLabel.AutoSize = True
        AssignExpenseToTitleLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AssignExpenseToTitleLabel.Location = New Point(60, 252)
        AssignExpenseToTitleLabel.Name = "AssignExpenseToTitleLabel"
        AssignExpenseToTitleLabel.Size = New Size(123, 15)
        AssignExpenseToTitleLabel.TabIndex = 74
        AssignExpenseToTitleLabel.Text = "Distrubute between:"
        ' 
        ' whoPaidCombo
        ' 
        whoPaidCombo.DropDownStyle = ComboBoxStyle.DropDownList
        whoPaidCombo.FormattingEnabled = True
        whoPaidCombo.Location = New Point(60, 216)
        whoPaidCombo.Margin = New Padding(3, 2, 3, 2)
        whoPaidCombo.Name = "whoPaidCombo"
        whoPaidCombo.Size = New Size(262, 23)
        whoPaidCombo.TabIndex = 78
        ' 
        ' whoPaidLabel
        ' 
        whoPaidLabel.AutoSize = True
        whoPaidLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        whoPaidLabel.Location = New Point(60, 199)
        whoPaidLabel.Name = "whoPaidLabel"
        whoPaidLabel.Size = New Size(146, 15)
        whoPaidLabel.TabIndex = 77
        whoPaidLabel.Text = "Who made the payment?"
        ' 
        ' R_check
        ' 
        R_check.AutoSize = True
        R_check.Location = New Point(60, 280)
        R_check.Margin = New Padding(3, 2, 3, 2)
        R_check.Name = "R_check"
        R_check.Size = New Size(74, 19)
        R_check.TabIndex = 79
        R_check.Text = "Everyone"
        R_check.UseVisualStyleBackColor = True
        ' 
        ' R1_check
        ' 
        R1_check.AutoSize = True
        R1_check.ForeColor = Color.Red
        R1_check.Location = New Point(60, 308)
        R1_check.Margin = New Padding(3, 2, 3, 2)
        R1_check.Name = "R1_check"
        R1_check.Size = New Size(94, 19)
        R1_check.TabIndex = 80
        R1_check.Text = "Roommate 1"
        R1_check.UseVisualStyleBackColor = True
        ' 
        ' R4_check
        ' 
        R4_check.AutoSize = True
        R4_check.ForeColor = Color.MediumOrchid
        R4_check.Location = New Point(178, 332)
        R4_check.Margin = New Padding(3, 2, 3, 2)
        R4_check.Name = "R4_check"
        R4_check.Size = New Size(94, 19)
        R4_check.TabIndex = 81
        R4_check.Text = "Roommate 4"
        R4_check.UseVisualStyleBackColor = True
        ' 
        ' R3_check
        ' 
        R3_check.AutoSize = True
        R3_check.ForeColor = Color.DodgerBlue
        R3_check.Location = New Point(60, 331)
        R3_check.Margin = New Padding(3, 2, 3, 2)
        R3_check.Name = "R3_check"
        R3_check.Size = New Size(94, 19)
        R3_check.TabIndex = 82
        R3_check.Text = "Roommate 3"
        R3_check.UseVisualStyleBackColor = True
        ' 
        ' R2_check
        ' 
        R2_check.AutoSize = True
        R2_check.ForeColor = Color.Green
        R2_check.Location = New Point(178, 308)
        R2_check.Margin = New Padding(3, 2, 3, 2)
        R2_check.Name = "R2_check"
        R2_check.Size = New Size(94, 19)
        R2_check.TabIndex = 83
        R2_check.Text = "Roommate 2"
        R2_check.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 289)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 84
        Label1.Text = "____________________"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(60, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 86
        Label2.Text = "Expense Name:"
        ' 
        ' label_of_record
        ' 
        label_of_record.Location = New Point(60, 114)
        label_of_record.Margin = New Padding(3, 2, 3, 2)
        label_of_record.Name = "label_of_record"
        label_of_record.Size = New Size(262, 23)
        label_of_record.TabIndex = 85
        ' 
        ' RecordExpenseControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Label2)
        Controls.Add(label_of_record)
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
        Margin = New Padding(3, 2, 3, 2)
        Name = "RecordExpenseControl"
        Size = New Size(380, 518)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents label_of_record As TextBox
End Class
