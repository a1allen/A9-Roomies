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
        NextButton = New Button()
        PreviousButton = New Button()
        FriLabel = New Label()
        Panel34 = New Panel()
        SatLabel = New Label()
        Panel27 = New Panel()
        ThursLabel = New Label()
        Panel33 = New Panel()
        WedLabel = New Label()
        Panel20 = New Panel()
        TuesLabel = New Label()
        MonLabel = New Label()
        Panel32 = New Panel()
        SunLabel = New Label()
        Panel26 = New Panel()
        Panel31 = New Panel()
        Panel35 = New Panel()
        Panel13 = New Panel()
        Panel30 = New Panel()
        Panel25 = New Panel()
        Panel29 = New Panel()
        Panel19 = New Panel()
        Panel24 = New Panel()
        Panel18 = New Panel()
        Panel28 = New Panel()
        Panel6 = New Panel()
        Panel23 = New Panel()
        Panel22 = New Panel()
        Panel17 = New Panel()
        Panel12 = New Panel()
        Panel21 = New Panel()
        Panel5 = New Panel()
        Panel16 = New Panel()
        Panel11 = New Panel()
        Panel15 = New Panel()
        Panel4 = New Panel()
        Panel10 = New Panel()
        Panel3 = New Panel()
        Panel14 = New Panel()
        Panel7 = New Panel()
        Panel9 = New Panel()
        Panel8 = New Panel()
        Panel2 = New Panel()
        Panel0 = New Panel()
        AddToCalendarButton = New Button()
        MonthLabel = New Label()
        BudgetTabPage = New TabPage()
        BudgetControl1 = New BudgetControl()
        HouseholdTabPage = New TabPage()
        PointsControl1 = New PointsControl()
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        CalendarTabPage.SuspendLayout()
        BudgetTabPage.SuspendLayout()
        HouseholdTabPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackgroundPictureBox
        ' 
        BackgroundPictureBox.BackColor = SystemColors.ButtonHighlight
        BackgroundPictureBox.BackgroundImage = My.Resources.myResources.phoneBackground2
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
        TabControl1.Controls.Add(HouseholdTabPage)
        TabControl1.Location = New Point(34, 57)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(435, 777)
        TabControl1.TabIndex = 5
        ' 
        ' CalendarTabPage
        ' 
        CalendarTabPage.BackColor = Color.White
        CalendarTabPage.Controls.Add(NextButton)
        CalendarTabPage.Controls.Add(PreviousButton)
        CalendarTabPage.Controls.Add(FriLabel)
        CalendarTabPage.Controls.Add(Panel34)
        CalendarTabPage.Controls.Add(SatLabel)
        CalendarTabPage.Controls.Add(Panel27)
        CalendarTabPage.Controls.Add(ThursLabel)
        CalendarTabPage.Controls.Add(Panel33)
        CalendarTabPage.Controls.Add(WedLabel)
        CalendarTabPage.Controls.Add(Panel20)
        CalendarTabPage.Controls.Add(TuesLabel)
        CalendarTabPage.Controls.Add(MonLabel)
        CalendarTabPage.Controls.Add(Panel32)
        CalendarTabPage.Controls.Add(SunLabel)
        CalendarTabPage.Controls.Add(Panel26)
        CalendarTabPage.Controls.Add(Panel31)
        CalendarTabPage.Controls.Add(Panel35)
        CalendarTabPage.Controls.Add(Panel13)
        CalendarTabPage.Controls.Add(Panel30)
        CalendarTabPage.Controls.Add(Panel25)
        CalendarTabPage.Controls.Add(Panel29)
        CalendarTabPage.Controls.Add(Panel19)
        CalendarTabPage.Controls.Add(Panel24)
        CalendarTabPage.Controls.Add(Panel18)
        CalendarTabPage.Controls.Add(Panel28)
        CalendarTabPage.Controls.Add(Panel6)
        CalendarTabPage.Controls.Add(Panel23)
        CalendarTabPage.Controls.Add(Panel22)
        CalendarTabPage.Controls.Add(Panel17)
        CalendarTabPage.Controls.Add(Panel12)
        CalendarTabPage.Controls.Add(Panel21)
        CalendarTabPage.Controls.Add(Panel5)
        CalendarTabPage.Controls.Add(Panel16)
        CalendarTabPage.Controls.Add(Panel11)
        CalendarTabPage.Controls.Add(Panel15)
        CalendarTabPage.Controls.Add(Panel4)
        CalendarTabPage.Controls.Add(Panel10)
        CalendarTabPage.Controls.Add(Panel3)
        CalendarTabPage.Controls.Add(Panel14)
        CalendarTabPage.Controls.Add(Panel7)
        CalendarTabPage.Controls.Add(Panel9)
        CalendarTabPage.Controls.Add(Panel8)
        CalendarTabPage.Controls.Add(Panel2)
        CalendarTabPage.Controls.Add(Panel0)
        CalendarTabPage.Controls.Add(AddToCalendarButton)
        CalendarTabPage.Controls.Add(MonthLabel)
        CalendarTabPage.Location = New Point(4, 4)
        CalendarTabPage.Name = "CalendarTabPage"
        CalendarTabPage.Padding = New Padding(3)
        CalendarTabPage.Size = New Size(427, 744)
        CalendarTabPage.TabIndex = 0
        CalendarTabPage.Text = "Calendar"
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(234, 631)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(94, 29)
        NextButton.TabIndex = 53
        NextButton.Text = "Next"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' PreviousButton
        ' 
        PreviousButton.Location = New Point(88, 631)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(94, 29)
        PreviousButton.TabIndex = 52
        PreviousButton.Text = "Previous"
        PreviousButton.UseVisualStyleBackColor = True
        ' 
        ' FriLabel
        ' 
        FriLabel.BackColor = SystemColors.ButtonHighlight
        FriLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        FriLabel.Location = New Point(306, 146)
        FriLabel.Name = "FriLabel"
        FriLabel.Size = New Size(59, 54)
        FriLabel.TabIndex = 13
        FriLabel.Text = "F"
        FriLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel34
        ' 
        Panel34.BorderStyle = BorderStyle.Fixed3D
        Panel34.Location = New Point(307, 507)
        Panel34.Name = "Panel34"
        Panel34.Size = New Size(58, 74)
        Panel34.TabIndex = 47
        ' 
        ' SatLabel
        ' 
        SatLabel.BackColor = SystemColors.ButtonHighlight
        SatLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        SatLabel.Location = New Point(367, 146)
        SatLabel.Name = "SatLabel"
        SatLabel.Size = New Size(59, 54)
        SatLabel.TabIndex = 12
        SatLabel.Text = "S"
        SatLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel27
        ' 
        Panel27.BorderStyle = BorderStyle.Fixed3D
        Panel27.Location = New Point(307, 431)
        Panel27.Name = "Panel27"
        Panel27.Size = New Size(58, 74)
        Panel27.TabIndex = 40
        ' 
        ' ThursLabel
        ' 
        ThursLabel.BackColor = SystemColors.ButtonHighlight
        ThursLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ThursLabel.Location = New Point(245, 146)
        ThursLabel.Name = "ThursLabel"
        ThursLabel.Size = New Size(59, 54)
        ThursLabel.TabIndex = 11
        ThursLabel.Text = "T"
        ThursLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel33
        ' 
        Panel33.BorderStyle = BorderStyle.Fixed3D
        Panel33.Location = New Point(246, 507)
        Panel33.Name = "Panel33"
        Panel33.Size = New Size(58, 74)
        Panel33.TabIndex = 48
        ' 
        ' WedLabel
        ' 
        WedLabel.BackColor = SystemColors.ButtonHighlight
        WedLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        WedLabel.Location = New Point(184, 146)
        WedLabel.Name = "WedLabel"
        WedLabel.Size = New Size(59, 54)
        WedLabel.TabIndex = 10
        WedLabel.Text = "W"
        WedLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel20
        ' 
        Panel20.BorderStyle = BorderStyle.Fixed3D
        Panel20.Location = New Point(307, 355)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(58, 74)
        Panel20.TabIndex = 33
        ' 
        ' TuesLabel
        ' 
        TuesLabel.BackColor = SystemColors.ButtonHighlight
        TuesLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TuesLabel.Location = New Point(123, 146)
        TuesLabel.Name = "TuesLabel"
        TuesLabel.Size = New Size(59, 54)
        TuesLabel.TabIndex = 9
        TuesLabel.Text = "T"
        TuesLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MonLabel
        ' 
        MonLabel.BackColor = SystemColors.ButtonHighlight
        MonLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        MonLabel.Location = New Point(62, 146)
        MonLabel.Name = "MonLabel"
        MonLabel.Size = New Size(59, 54)
        MonLabel.TabIndex = 8
        MonLabel.Text = "M"
        MonLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel32
        ' 
        Panel32.BorderStyle = BorderStyle.Fixed3D
        Panel32.Location = New Point(185, 507)
        Panel32.Name = "Panel32"
        Panel32.Size = New Size(58, 74)
        Panel32.TabIndex = 49
        ' 
        ' SunLabel
        ' 
        SunLabel.BackColor = SystemColors.ButtonHighlight
        SunLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        SunLabel.Location = New Point(1, 146)
        SunLabel.Name = "SunLabel"
        SunLabel.Size = New Size(59, 54)
        SunLabel.TabIndex = 7
        SunLabel.Text = "S"
        SunLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel26
        ' 
        Panel26.BorderStyle = BorderStyle.Fixed3D
        Panel26.Location = New Point(246, 431)
        Panel26.Name = "Panel26"
        Panel26.Size = New Size(58, 74)
        Panel26.TabIndex = 41
        ' 
        ' Panel31
        ' 
        Panel31.BorderStyle = BorderStyle.Fixed3D
        Panel31.Location = New Point(124, 507)
        Panel31.Name = "Panel31"
        Panel31.Size = New Size(58, 74)
        Panel31.TabIndex = 50
        ' 
        ' Panel35
        ' 
        Panel35.BorderStyle = BorderStyle.Fixed3D
        Panel35.Location = New Point(368, 507)
        Panel35.Name = "Panel35"
        Panel35.Size = New Size(58, 74)
        Panel35.TabIndex = 51
        ' 
        ' Panel13
        ' 
        Panel13.BorderStyle = BorderStyle.Fixed3D
        Panel13.Location = New Point(307, 279)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(58, 74)
        Panel13.TabIndex = 26
        ' 
        ' Panel30
        ' 
        Panel30.BorderStyle = BorderStyle.Fixed3D
        Panel30.Location = New Point(63, 507)
        Panel30.Name = "Panel30"
        Panel30.Size = New Size(58, 74)
        Panel30.TabIndex = 46
        ' 
        ' Panel25
        ' 
        Panel25.BorderStyle = BorderStyle.Fixed3D
        Panel25.Location = New Point(185, 431)
        Panel25.Name = "Panel25"
        Panel25.Size = New Size(58, 74)
        Panel25.TabIndex = 42
        ' 
        ' Panel29
        ' 
        Panel29.BorderStyle = BorderStyle.Fixed3D
        Panel29.Location = New Point(2, 507)
        Panel29.Name = "Panel29"
        Panel29.Size = New Size(58, 74)
        Panel29.TabIndex = 45
        ' 
        ' Panel19
        ' 
        Panel19.BorderStyle = BorderStyle.Fixed3D
        Panel19.Location = New Point(246, 355)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(58, 74)
        Panel19.TabIndex = 34
        ' 
        ' Panel24
        ' 
        Panel24.BorderStyle = BorderStyle.Fixed3D
        Panel24.Location = New Point(124, 431)
        Panel24.Name = "Panel24"
        Panel24.Size = New Size(58, 74)
        Panel24.TabIndex = 43
        ' 
        ' Panel18
        ' 
        Panel18.BorderStyle = BorderStyle.Fixed3D
        Panel18.Location = New Point(185, 355)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(58, 74)
        Panel18.TabIndex = 35
        ' 
        ' Panel28
        ' 
        Panel28.BorderStyle = BorderStyle.Fixed3D
        Panel28.Location = New Point(368, 431)
        Panel28.Name = "Panel28"
        Panel28.Size = New Size(58, 74)
        Panel28.TabIndex = 44
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Location = New Point(307, 203)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(58, 74)
        Panel6.TabIndex = 23
        ' 
        ' Panel23
        ' 
        Panel23.BorderStyle = BorderStyle.Fixed3D
        Panel23.Location = New Point(63, 431)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(58, 74)
        Panel23.TabIndex = 39
        ' 
        ' Panel22
        ' 
        Panel22.BorderStyle = BorderStyle.Fixed3D
        Panel22.Location = New Point(2, 431)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(58, 74)
        Panel22.TabIndex = 38
        ' 
        ' Panel17
        ' 
        Panel17.BorderStyle = BorderStyle.Fixed3D
        Panel17.Location = New Point(124, 355)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(58, 74)
        Panel17.TabIndex = 36
        ' 
        ' Panel12
        ' 
        Panel12.BorderStyle = BorderStyle.Fixed3D
        Panel12.Location = New Point(246, 279)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(58, 74)
        Panel12.TabIndex = 27
        ' 
        ' Panel21
        ' 
        Panel21.BorderStyle = BorderStyle.Fixed3D
        Panel21.Location = New Point(368, 355)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(58, 74)
        Panel21.TabIndex = 37
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Location = New Point(246, 203)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(58, 74)
        Panel5.TabIndex = 23
        ' 
        ' Panel16
        ' 
        Panel16.BorderStyle = BorderStyle.Fixed3D
        Panel16.Location = New Point(63, 355)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(58, 74)
        Panel16.TabIndex = 32
        ' 
        ' Panel11
        ' 
        Panel11.BorderStyle = BorderStyle.Fixed3D
        Panel11.Location = New Point(185, 279)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(58, 74)
        Panel11.TabIndex = 28
        ' 
        ' Panel15
        ' 
        Panel15.BorderStyle = BorderStyle.Fixed3D
        Panel15.Location = New Point(2, 355)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(58, 74)
        Panel15.TabIndex = 31
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Location = New Point(185, 203)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(58, 74)
        Panel4.TabIndex = 23
        ' 
        ' Panel10
        ' 
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Location = New Point(124, 279)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(58, 74)
        Panel10.TabIndex = 29
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Location = New Point(124, 203)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(58, 74)
        Panel3.TabIndex = 23
        ' 
        ' Panel14
        ' 
        Panel14.BorderStyle = BorderStyle.Fixed3D
        Panel14.Location = New Point(368, 279)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(58, 74)
        Panel14.TabIndex = 30
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Location = New Point(368, 203)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(58, 74)
        Panel7.TabIndex = 23
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Location = New Point(63, 279)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(58, 74)
        Panel9.TabIndex = 25
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Location = New Point(2, 279)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(58, 74)
        Panel8.TabIndex = 24
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Location = New Point(63, 203)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(58, 74)
        Panel2.TabIndex = 22
        ' 
        ' Panel0
        ' 
        Panel0.BorderStyle = BorderStyle.Fixed3D
        Panel0.Location = New Point(2, 203)
        Panel0.Name = "Panel0"
        Panel0.Size = New Size(58, 74)
        Panel0.TabIndex = 21
        ' 
        ' AddToCalendarButton
        ' 
        AddToCalendarButton.BackColor = Color.White
        AddToCalendarButton.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        AddToCalendarButton.ForeColor = SystemColors.ActiveCaptionText
        AddToCalendarButton.Location = New Point(338, 51)
        AddToCalendarButton.Name = "AddToCalendarButton"
        AddToCalendarButton.Size = New Size(53, 52)
        AddToCalendarButton.TabIndex = 20
        AddToCalendarButton.Text = "+"
        AddToCalendarButton.TextAlign = ContentAlignment.TopRight
        AddToCalendarButton.UseVisualStyleBackColor = False
        ' 
        ' MonthLabel
        ' 
        MonthLabel.AutoSize = True
        MonthLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        MonthLabel.Location = New Point(15, 35)
        MonthLabel.Name = "MonthLabel"
        MonthLabel.Size = New Size(248, 41)
        MonthLabel.TabIndex = 18
        MonthLabel.Text = "November, 2023"
        ' 
        ' BudgetTabPage
        ' 
        BudgetTabPage.Controls.Add(BudgetControl1)
        BudgetTabPage.Location = New Point(4, 4)
        BudgetTabPage.Name = "BudgetTabPage"
        BudgetTabPage.Padding = New Padding(3)
        BudgetTabPage.Size = New Size(427, 744)
        BudgetTabPage.TabIndex = 1
        BudgetTabPage.Text = "Budget"
        BudgetTabPage.UseVisualStyleBackColor = True
        ' 
        ' BudgetControl1
        ' 
        BudgetControl1.Location = New Point(0, 0)
        BudgetControl1.Name = "BudgetControl1"
        BudgetControl1.Size = New Size(427, 655)
        BudgetControl1.TabIndex = 0
        ' 
        ' HouseholdTabPage
        ' 
        HouseholdTabPage.Controls.Add(PointsControl1)
        HouseholdTabPage.Location = New Point(4, 4)
        HouseholdTabPage.Name = "HouseholdTabPage"
        HouseholdTabPage.Padding = New Padding(3)
        HouseholdTabPage.Size = New Size(427, 744)
        HouseholdTabPage.TabIndex = 2
        HouseholdTabPage.Text = "Household Management"
        HouseholdTabPage.UseVisualStyleBackColor = True
        ' 
        ' PointsControl1
        ' 
        PointsControl1.Location = New Point(0, 0)
        PointsControl1.Name = "PointsControl1"
        PointsControl1.Size = New Size(431, 701)
        PointsControl1.TabIndex = 0
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
        CalendarTabPage.PerformLayout()
        BudgetTabPage.ResumeLayout(False)
        HouseholdTabPage.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CalendarTabPage As TabPage
    Friend WithEvents BudgetTabPage As TabPage
    Friend WithEvents HouseholdTabPage As TabPage
    Friend WithEvents BudgetControl1 As BudgetControl
    Friend WithEvents PointsControl1 As PointsControl
    Friend WithEvents AddToCalendarButton As Button
    Friend WithEvents MonthLabel As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel0 As Panel
    Friend WithEvents FriLabel As Label
    Friend WithEvents SatLabel As Label
    Friend WithEvents ThursLabel As Label
    Friend WithEvents WedLabel As Label
    Friend WithEvents TuesLabel As Label
    Friend WithEvents MonLabel As Label
    Friend WithEvents SunLabel As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
End Class
