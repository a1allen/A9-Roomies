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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        RoommateOweButton4 = New RoommateOweButton()
        RoommateOweButton3 = New RoommateOweButton()
        RoommateOweButton2 = New RoommateOweButton()
        RoommateOweButton1 = New RoommateOweButton()
        HistoryButton = New Button()
        RecordExpenseButton = New Button()
        BudgetPictureBox = New PictureBox()
        BudgetTitle = New Label()
        SettleUpButton = New Button()
        CType(BudgetPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.DarkGray
        Label3.Location = New Point(3, 427)
        Label3.MinimumSize = New Size(0, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(425, 15)
        Label3.TabIndex = 43
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.DarkGray
        Label2.Location = New Point(2, 346)
        Label2.MinimumSize = New Size(0, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(425, 15)
        Label2.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkGray
        Label1.Location = New Point(2, 263)
        Label1.MinimumSize = New Size(0, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(425, 15)
        Label1.TabIndex = 41
        ' 
        ' RoommateOweButton4
        ' 
        RoommateOweButton4.BackColor = Color.Transparent
        RoommateOweButton4.ColorOfRoommate = Color.MediumOrchid
        RoommateOweButton4.Location = New Point(16, 445)
        RoommateOweButton4.MinimumSize = New Size(400, 60)
        RoommateOweButton4.MoneyToOwe = 30R
        RoommateOweButton4.Name = "RoommateOweButton4"
        RoommateOweButton4.NameOfRoommate = 4
        RoommateOweButton4.Size = New Size(400, 60)
        RoommateOweButton4.TabIndex = 40
        ' 
        ' RoommateOweButton3
        ' 
        RoommateOweButton3.BackColor = Color.Transparent
        RoommateOweButton3.ColorOfRoommate = Color.DodgerBlue
        RoommateOweButton3.Location = New Point(16, 364)
        RoommateOweButton3.MinimumSize = New Size(400, 60)
        RoommateOweButton3.MoneyToOwe = 30R
        RoommateOweButton3.Name = "RoommateOweButton3"
        RoommateOweButton3.NameOfRoommate = 3
        RoommateOweButton3.Size = New Size(400, 60)
        RoommateOweButton3.TabIndex = 39
        ' 
        ' RoommateOweButton2
        ' 
        RoommateOweButton2.BackColor = Color.Transparent
        RoommateOweButton2.ColorOfRoommate = Color.Green
        RoommateOweButton2.Location = New Point(16, 283)
        RoommateOweButton2.MinimumSize = New Size(400, 60)
        RoommateOweButton2.MoneyToOwe = -60R
        RoommateOweButton2.Name = "RoommateOweButton2"
        RoommateOweButton2.NameOfRoommate = 2
        RoommateOweButton2.Size = New Size(400, 60)
        RoommateOweButton2.TabIndex = 38
        ' 
        ' RoommateOweButton1
        ' 
        RoommateOweButton1.BackColor = Color.Transparent
        RoommateOweButton1.ColorOfRoommate = Color.Red
        RoommateOweButton1.Location = New Point(16, 200)
        RoommateOweButton1.MinimumSize = New Size(400, 60)
        RoommateOweButton1.MoneyToOwe = 0R
        RoommateOweButton1.Name = "RoommateOweButton1"
        RoommateOweButton1.NameOfRoommate = 1
        RoommateOweButton1.Size = New Size(400, 60)
        RoommateOweButton1.TabIndex = 37
        ' 
        ' HistoryButton
        ' 
        HistoryButton.BackColor = Color.DarkGray
        HistoryButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        HistoryButton.Location = New Point(96, 645)
        HistoryButton.Name = "HistoryButton"
        HistoryButton.Size = New Size(244, 50)
        HistoryButton.TabIndex = 36
        HistoryButton.Text = "History"
        HistoryButton.UseVisualStyleBackColor = False
        ' 
        ' RecordExpenseButton
        ' 
        RecordExpenseButton.BackColor = Color.Salmon
        RecordExpenseButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RecordExpenseButton.Location = New Point(96, 511)
        RecordExpenseButton.Name = "RecordExpenseButton"
        RecordExpenseButton.Size = New Size(244, 50)
        RecordExpenseButton.TabIndex = 35
        RecordExpenseButton.Text = "Add Expense"
        RecordExpenseButton.UseVisualStyleBackColor = False
        ' 
        ' BudgetPictureBox
        ' 
        BudgetPictureBox.BackgroundImageLayout = ImageLayout.Stretch
        BudgetPictureBox.Image = My.Resources.myResources.Jar
        BudgetPictureBox.Location = New Point(137, 40)
        BudgetPictureBox.Name = "BudgetPictureBox"
        BudgetPictureBox.Size = New Size(138, 154)
        BudgetPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BudgetPictureBox.TabIndex = 34
        BudgetPictureBox.TabStop = False
        ' 
        ' BudgetTitle
        ' 
        BudgetTitle.AutoSize = True
        BudgetTitle.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        BudgetTitle.Location = New Point(64, 0)
        BudgetTitle.Name = "BudgetTitle"
        BudgetTitle.Size = New Size(286, 37)
        BudgetTitle.TabIndex = 33
        BudgetTitle.Text = "Household Summary"
        ' 
        ' SettleUpButton
        ' 
        SettleUpButton.BackColor = Color.DarkSeaGreen
        SettleUpButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        SettleUpButton.Location = New Point(96, 577)
        SettleUpButton.Name = "SettleUpButton"
        SettleUpButton.Size = New Size(244, 50)
        SettleUpButton.TabIndex = 44
        SettleUpButton.Text = "Settle Up"
        SettleUpButton.UseVisualStyleBackColor = False
        ' 
        ' BudgetTabMainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(SettleUpButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RoommateOweButton4)
        Controls.Add(RoommateOweButton3)
        Controls.Add(RoommateOweButton2)
        Controls.Add(RoommateOweButton1)
        Controls.Add(HistoryButton)
        Controls.Add(RecordExpenseButton)
        Controls.Add(BudgetPictureBox)
        Controls.Add(BudgetTitle)
        Name = "BudgetTabMainPage"
        Size = New Size(429, 722)
        CType(BudgetPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoommateOweButton4 As RoommateOweButton
    Friend WithEvents RoommateOweButton3 As RoommateOweButton
    Friend WithEvents RoommateOweButton2 As RoommateOweButton
    Friend WithEvents RoommateOweButton1 As RoommateOweButton
    Friend WithEvents HistoryButton As Button
    Friend WithEvents RecordExpenseButton As Button
    Friend WithEvents BudgetPictureBox As PictureBox
    Friend WithEvents BudgetTitle As Label
    Friend WithEvents SettleUpButton As Button
End Class
