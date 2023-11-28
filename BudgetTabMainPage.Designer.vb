<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetTabMainPage
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
        RoommateOweButton4 = New RoommateOweButton()
        RoommateOweButton3 = New RoommateOweButton()
        RoommateOweButton2 = New RoommateOweButton()
        RoommateOweButton1 = New RoommateOweButton()
        HistoryButton = New Button()
        RecordExpenseButton = New Button()
        BudgetPictureBox = New PictureBox()
        BudgetTitle = New Label()
        SettleUpButton = New Button()
        Label1 = New Panel()
        Label2 = New Panel()
        Label3 = New Panel()
        CType(BudgetPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoommateOweButton4
        ' 
        RoommateOweButton4.BackColor = Color.Transparent
        RoommateOweButton4.ColorOfRoommate = Color.MediumOrchid
        RoommateOweButton4.Location = New Point(34, 466)
        RoommateOweButton4.Margin = New Padding(3, 4, 3, 4)
        RoommateOweButton4.MinimumSize = New Size(370, 60)
        RoommateOweButton4.MoneyToOwe = 30R
        RoommateOweButton4.Name = "RoommateOweButton4"
        RoommateOweButton4.NameOfRoommate = 4
        RoommateOweButton4.Size = New Size(370, 60)
        RoommateOweButton4.TabIndex = 40
        ' 
        ' RoommateOweButton3
        ' 
        RoommateOweButton3.BackColor = Color.Transparent
        RoommateOweButton3.ColorOfRoommate = Color.DodgerBlue
        RoommateOweButton3.Location = New Point(34, 393)
        RoommateOweButton3.Margin = New Padding(3, 4, 3, 4)
        RoommateOweButton3.MinimumSize = New Size(370, 60)
        RoommateOweButton3.MoneyToOwe = 30R
        RoommateOweButton3.Name = "RoommateOweButton3"
        RoommateOweButton3.NameOfRoommate = 3
        RoommateOweButton3.Size = New Size(370, 60)
        RoommateOweButton3.TabIndex = 39
        ' 
        ' RoommateOweButton2
        ' 
        RoommateOweButton2.BackColor = Color.Transparent
        RoommateOweButton2.ColorOfRoommate = Color.Green
        RoommateOweButton2.Location = New Point(34, 322)
        RoommateOweButton2.Margin = New Padding(3, 4, 3, 4)
        RoommateOweButton2.MinimumSize = New Size(370, 60)
        RoommateOweButton2.MoneyToOwe = -60R
        RoommateOweButton2.Name = "RoommateOweButton2"
        RoommateOweButton2.NameOfRoommate = 2
        RoommateOweButton2.Size = New Size(370, 60)
        RoommateOweButton2.TabIndex = 38
        ' 
        ' RoommateOweButton1
        ' 
        RoommateOweButton1.BackColor = Color.Transparent
        RoommateOweButton1.ColorOfRoommate = Color.Crimson
        RoommateOweButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RoommateOweButton1.Location = New Point(34, 248)
        RoommateOweButton1.Margin = New Padding(3, 4, 3, 4)
        RoommateOweButton1.MinimumSize = New Size(370, 60)
        RoommateOweButton1.MoneyToOwe = 0R
        RoommateOweButton1.Name = "RoommateOweButton1"
        RoommateOweButton1.NameOfRoommate = 1
        RoommateOweButton1.Size = New Size(370, 60)
        RoommateOweButton1.TabIndex = 37
        ' 
        ' HistoryButton
        ' 
        HistoryButton.BackColor = Color.Gainsboro
        HistoryButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        HistoryButton.Location = New Point(152, 599)
        HistoryButton.Margin = New Padding(3, 4, 3, 4)
        HistoryButton.Name = "HistoryButton"
        HistoryButton.Size = New Size(142, 40)
        HistoryButton.TabIndex = 36
        HistoryButton.Text = "History"
        HistoryButton.UseVisualStyleBackColor = False
        ' 
        ' RecordExpenseButton
        ' 
        RecordExpenseButton.BackColor = Color.Gainsboro
        RecordExpenseButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RecordExpenseButton.Location = New Point(152, 548)
        RecordExpenseButton.Margin = New Padding(3, 4, 3, 4)
        RecordExpenseButton.Name = "RecordExpenseButton"
        RecordExpenseButton.Size = New Size(142, 40)
        RecordExpenseButton.TabIndex = 35
        RecordExpenseButton.Text = "Add Expense"
        RecordExpenseButton.UseVisualStyleBackColor = False
        ' 
        ' BudgetPictureBox
        ' 
        BudgetPictureBox.BackgroundImageLayout = ImageLayout.Stretch
        BudgetPictureBox.Image = My.Resources.myResources.Jar
        BudgetPictureBox.Location = New Point(152, 84)
        BudgetPictureBox.Margin = New Padding(3, 4, 3, 4)
        BudgetPictureBox.Name = "BudgetPictureBox"
        BudgetPictureBox.Size = New Size(131, 155)
        BudgetPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BudgetPictureBox.TabIndex = 34
        BudgetPictureBox.TabStop = False
        ' 
        ' BudgetTitle
        ' 
        BudgetTitle.AutoSize = True
        BudgetTitle.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        BudgetTitle.Location = New Point(41, 14)
        BudgetTitle.Name = "BudgetTitle"
        BudgetTitle.Size = New Size(355, 46)
        BudgetTitle.TabIndex = 33
        BudgetTitle.Text = "Household Summary"
        ' 
        ' SettleUpButton
        ' 
        SettleUpButton.BackColor = Color.Gainsboro
        SettleUpButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SettleUpButton.Location = New Point(152, 650)
        SettleUpButton.Margin = New Padding(3, 4, 3, 4)
        SettleUpButton.Name = "SettleUpButton"
        SettleUpButton.Size = New Size(142, 40)
        SettleUpButton.TabIndex = 44
        SettleUpButton.Text = "Settle Up"
        SettleUpButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Gainsboro
        Label1.Location = New Point(15, 314)
        Label1.Name = "Label1"
        Label1.Size = New Size(408, 5)
        Label1.TabIndex = 61
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Gainsboro
        Label2.Location = New Point(12, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(408, 5)
        Label2.TabIndex = 62
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Gainsboro
        Label3.Location = New Point(12, 456)
        Label3.Name = "Label3"
        Label3.Size = New Size(408, 5)
        Label3.TabIndex = 63
        ' 
        ' BudgetTabMainPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SettleUpButton)
        Controls.Add(RoommateOweButton4)
        Controls.Add(RoommateOweButton3)
        Controls.Add(RoommateOweButton2)
        Controls.Add(RoommateOweButton1)
        Controls.Add(HistoryButton)
        Controls.Add(RecordExpenseButton)
        Controls.Add(BudgetPictureBox)
        Controls.Add(BudgetTitle)
        Margin = New Padding(3, 4, 3, 4)
        Name = "BudgetTabMainPage"
        Size = New Size(434, 711)
        CType(BudgetPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoommateOweButton4 As RoommateOweButton
    Friend WithEvents RoommateOweButton3 As RoommateOweButton
    Friend WithEvents RoommateOweButton2 As RoommateOweButton
    Friend WithEvents RoommateOweButton1 As RoommateOweButton
    Friend WithEvents HistoryButton As Button
    Friend WithEvents RecordExpenseButton As Button
    Friend WithEvents BudgetPictureBox As PictureBox
    Friend WithEvents BudgetTitle As Label
    Friend WithEvents SettleUpButton As Button
    Friend WithEvents Label1 As Panel
    Friend WithEvents Label2 As Panel
    Friend WithEvents Label3 As Panel
End Class
