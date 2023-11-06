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
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        CalendarTabPage = New TabPage()
        CalendarControl1 = New CalendarControl()
        BudgetTabPage = New TabPage()
        SettingsTabPage = New TabPage()
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        CalendarTabPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackgroundPictureBox
        ' 
        BackgroundPictureBox.BackColor = SystemColors.ButtonHighlight
        BackgroundPictureBox.BackgroundImage = My.Resources.backgroundResource.phoneBackground2
        BackgroundPictureBox.Location = New Point(0, 1)
        BackgroundPictureBox.Name = "BackgroundPictureBox"
        BackgroundPictureBox.Size = New Size(498, 901)
        BackgroundPictureBox.TabIndex = 0
        BackgroundPictureBox.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(32, 840)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 38)
        Panel1.TabIndex = 4
        ' 
        ' TabControl1
        ' 
        TabControl1.Alignment = TabAlignment.Bottom
        TabControl1.Controls.Add(CalendarTabPage)
        TabControl1.Controls.Add(BudgetTabPage)
        TabControl1.Controls.Add(SettingsTabPage)
        TabControl1.Location = New Point(34, 57)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(435, 777)
        TabControl1.TabIndex = 5
        ' 
        ' CalendarTabPage
        ' 
        CalendarTabPage.BackColor = Color.White
        CalendarTabPage.Controls.Add(CalendarControl1)
        CalendarTabPage.Location = New Point(4, 4)
        CalendarTabPage.Name = "CalendarTabPage"
        CalendarTabPage.Padding = New Padding(3)
        CalendarTabPage.Size = New Size(427, 744)
        CalendarTabPage.TabIndex = 0
        CalendarTabPage.Text = "Calendar"
        ' 
        ' CalendarControl1
        ' 
        CalendarControl1.Location = New Point(0, 3)
        CalendarControl1.Name = "CalendarControl1"
        CalendarControl1.Size = New Size(427, 633)
        CalendarControl1.TabIndex = 0
        ' 
        ' BudgetTabPage
        ' 
        BudgetTabPage.Location = New Point(4, 4)
        BudgetTabPage.Name = "BudgetTabPage"
        BudgetTabPage.Padding = New Padding(3)
        BudgetTabPage.Size = New Size(427, 744)
        BudgetTabPage.TabIndex = 1
        BudgetTabPage.Text = "Budget"
        BudgetTabPage.UseVisualStyleBackColor = True
        ' 
        ' SettingsTabPage
        ' 
        SettingsTabPage.Location = New Point(4, 4)
        SettingsTabPage.Name = "SettingsTabPage"
        SettingsTabPage.Padding = New Padding(3)
        SettingsTabPage.Size = New Size(427, 744)
        SettingsTabPage.TabIndex = 2
        SettingsTabPage.Text = "Settings"
        SettingsTabPage.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 904)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Controls.Add(BackgroundPictureBox)
        Name = "Form1"
        Text = "Roomies Application"
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        CalendarTabPage.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CalendarTabPage As TabPage
    Friend WithEvents BudgetTabPage As TabPage
    Friend WithEvents SettingsTabPage As TabPage
    Friend WithEvents CalendarControl1 As CalendarControl
End Class
