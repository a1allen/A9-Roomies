<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetItem
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
        BudgetItem_DateLabel = New Label()
        BudgetItem_ExpenseNameLabel = New Label()
        BudgetItem_RoommateNamePaid = New Label()
        BudgetItem_MoneyPaidLabel = New Label()
        BudgetItem_ViewItemButton = New Button()
        SuspendLayout()
        ' 
        ' BudgetItem_DateLabel
        ' 
        BudgetItem_DateLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BudgetItem_DateLabel.ForeColor = Color.Gray
        BudgetItem_DateLabel.Location = New Point(3, 0)
        BudgetItem_DateLabel.Name = "BudgetItem_DateLabel"
        BudgetItem_DateLabel.Size = New Size(60, 50)
        BudgetItem_DateLabel.TabIndex = 0
        BudgetItem_DateLabel.Text = "Jan 01"
        BudgetItem_DateLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BudgetItem_ExpenseNameLabel
        ' 
        BudgetItem_ExpenseNameLabel.AutoSize = True
        BudgetItem_ExpenseNameLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BudgetItem_ExpenseNameLabel.Location = New Point(61, 15)
        BudgetItem_ExpenseNameLabel.MaximumSize = New Size(171, 53)
        BudgetItem_ExpenseNameLabel.MinimumSize = New Size(114, 23)
        BudgetItem_ExpenseNameLabel.Name = "BudgetItem_ExpenseNameLabel"
        BudgetItem_ExpenseNameLabel.Size = New Size(123, 23)
        BudgetItem_ExpenseNameLabel.TabIndex = 1
        BudgetItem_ExpenseNameLabel.Text = "Expense Name"
        ' 
        ' BudgetItem_RoommateNamePaid
        ' 
        BudgetItem_RoommateNamePaid.AutoSize = True
        BudgetItem_RoommateNamePaid.BackColor = Color.Transparent
        BudgetItem_RoommateNamePaid.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point)
        BudgetItem_RoommateNamePaid.Location = New Point(192, 4)
        BudgetItem_RoommateNamePaid.Name = "BudgetItem_RoommateNamePaid"
        BudgetItem_RoommateNamePaid.Size = New Size(92, 15)
        BudgetItem_RoommateNamePaid.TabIndex = 2
        BudgetItem_RoommateNamePaid.Text = "Roommate Paid"
        BudgetItem_RoommateNamePaid.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BudgetItem_MoneyPaidLabel
        ' 
        BudgetItem_MoneyPaidLabel.AutoSize = True
        BudgetItem_MoneyPaidLabel.BackColor = Color.Transparent
        BudgetItem_MoneyPaidLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BudgetItem_MoneyPaidLabel.Location = New Point(205, 21)
        BudgetItem_MoneyPaidLabel.Name = "BudgetItem_MoneyPaidLabel"
        BudgetItem_MoneyPaidLabel.Size = New Size(60, 28)
        BudgetItem_MoneyPaidLabel.TabIndex = 3
        BudgetItem_MoneyPaidLabel.Text = "$100"
        ' 
        ' BudgetItem_ViewItemButton
        ' 
        BudgetItem_ViewItemButton.Location = New Point(328, 10)
        BudgetItem_ViewItemButton.Margin = New Padding(3, 4, 3, 4)
        BudgetItem_ViewItemButton.Name = "BudgetItem_ViewItemButton"
        BudgetItem_ViewItemButton.Size = New Size(58, 31)
        BudgetItem_ViewItemButton.TabIndex = 6
        BudgetItem_ViewItemButton.Text = "View"
        BudgetItem_ViewItemButton.UseVisualStyleBackColor = True
        ' 
        ' BudgetItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        Controls.Add(BudgetItem_ViewItemButton)
        Controls.Add(BudgetItem_MoneyPaidLabel)
        Controls.Add(BudgetItem_RoommateNamePaid)
        Controls.Add(BudgetItem_ExpenseNameLabel)
        Controls.Add(BudgetItem_DateLabel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "BudgetItem"
        Size = New Size(400, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BudgetItem_DateLabel As Label
    Friend WithEvents BudgetItem_ExpenseNameLabel As Label
    Friend WithEvents BudgetItem_RoommateNamePaid As Label
    Friend WithEvents BudgetItem_MoneyPaidLabel As Label
    Private WithEvents BudgetItem_ViewItemButton As Button
End Class
