<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BackgroundPictureBox = New PictureBox()
        CalendarButton = New Button()
        BudgetButton = New Button()
        PointsButton = New Button()
        Panel1 = New Panel()
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackgroundPictureBox
        ' 
        BackgroundPictureBox.BackgroundImage = My.Resources.backgroundResource.phoneBackground2
        BackgroundPictureBox.Location = New Point(0, 1)
        BackgroundPictureBox.Name = "BackgroundPictureBox"
        BackgroundPictureBox.Size = New Size(498, 901)
        BackgroundPictureBox.TabIndex = 0
        BackgroundPictureBox.TabStop = False
        ' 
        ' CalendarButton
        ' 
        CalendarButton.Location = New Point(34, 776)
        CalendarButton.Name = "CalendarButton"
        CalendarButton.Size = New Size(143, 64)
        CalendarButton.TabIndex = 1
        CalendarButton.Text = "Calendar"
        CalendarButton.UseVisualStyleBackColor = True
        ' 
        ' BudgetButton
        ' 
        BudgetButton.Location = New Point(177, 776)
        BudgetButton.Name = "BudgetButton"
        BudgetButton.Size = New Size(149, 64)
        BudgetButton.TabIndex = 2
        BudgetButton.Text = "Budget"
        BudgetButton.UseVisualStyleBackColor = True
        ' 
        ' PointsButton
        ' 
        PointsButton.Location = New Point(325, 776)
        PointsButton.Name = "PointsButton"
        PointsButton.Size = New Size(143, 64)
        PointsButton.TabIndex = 3
        PointsButton.Text = "Points"
        PointsButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(32, 840)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 38)
        Panel1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 904)
        Controls.Add(Panel1)
        Controls.Add(PointsButton)
        Controls.Add(BudgetButton)
        Controls.Add(CalendarButton)
        Controls.Add(BackgroundPictureBox)
        Name = "Form1"
        Text = "Roomies Application"
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundPictureBox As PictureBox
    Friend WithEvents CalendarButton As Button
    Friend WithEvents BudgetButton As Button
    Friend WithEvents PointsButton As Button
    Friend WithEvents Panel1 As Panel
End Class
