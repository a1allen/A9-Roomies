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
        DateLabel = New Label()
        ExpenseNameLabel = New Label()
        RoommateNamePaid = New Label()
        MoneyPaidLabel = New Label()
        ViewItemButton = New Button()
        SuspendLayout()
        ' 
        ' DateLabel
        ' 
        DateLabel.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateLabel.ForeColor = Color.Gray
        DateLabel.Location = New Point(3, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(37, 50)
        DateLabel.TabIndex = 0
        DateLabel.Text = "Jan 01"
        DateLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ExpenseNameLabel
        ' 
        ExpenseNameLabel.AutoSize = True
        ExpenseNameLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ExpenseNameLabel.Location = New Point(46, 16)
        ExpenseNameLabel.MaximumSize = New Size(150, 40)
        ExpenseNameLabel.MinimumSize = New Size(100, 17)
        ExpenseNameLabel.Name = "ExpenseNameLabel"
        ExpenseNameLabel.Size = New Size(100, 17)
        ExpenseNameLabel.TabIndex = 1
        ExpenseNameLabel.Text = "Expense Name"
        ' 
        ' RoommateNamePaid
        ' 
        RoommateNamePaid.AutoSize = True
        RoommateNamePaid.BackColor = Color.Transparent
        RoommateNamePaid.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoommateNamePaid.Location = New Point(231, 3)
        RoommateNamePaid.Name = "RoommateNamePaid"
        RoommateNamePaid.Size = New Size(68, 12)
        RoommateNamePaid.TabIndex = 2
        RoommateNamePaid.Text = "Roommate Paid"
        RoommateNamePaid.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MoneyPaidLabel
        ' 
        MoneyPaidLabel.AutoSize = True
        MoneyPaidLabel.BackColor = Color.Transparent
        MoneyPaidLabel.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        MoneyPaidLabel.Location = New Point(243, 16)
        MoneyPaidLabel.Name = "MoneyPaidLabel"
        MoneyPaidLabel.Size = New Size(56, 25)
        MoneyPaidLabel.TabIndex = 3
        MoneyPaidLabel.Text = "$100"
        ' 
        ' ViewItemButton
        ' 
        ViewItemButton.Location = New Point(346, 24)
        ViewItemButton.Name = "ViewItemButton"
        ViewItemButton.Size = New Size(51, 23)
        ViewItemButton.TabIndex = 6
        ViewItemButton.Text = "View"
        ViewItemButton.UseVisualStyleBackColor = True
        ' 
        ' BudgetItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        Controls.Add(ViewItemButton)
        Controls.Add(MoneyPaidLabel)
        Controls.Add(RoommateNamePaid)
        Controls.Add(ExpenseNameLabel)
        Controls.Add(DateLabel)
        Name = "BudgetItem"
        Size = New Size(400, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateLabel As Label
    Friend WithEvents ExpenseNameLabel As Label
    Friend WithEvents RoommateNamePaid As Label
    Friend WithEvents MoneyPaidLabel As Label
    Private WithEvents ViewItemButton As Button
End Class
