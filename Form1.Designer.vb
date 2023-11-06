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
        CalendarTableLayoutPanel = New TableLayoutPanel()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        DayLabel2 = New Label()
        DayLabel3 = New Label()
        DayLabel4 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label14 = New Label()
        Label18 = New Label()
        Label20 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label19 = New Label()
        Label23 = New Label()
        DayLabel1 = New Label()
        AddToCalendarButton = New Button()
        DaysPanel = New Panel()
        FriLabel = New Label()
        SatLabel = New Label()
        ThursLabel = New Label()
        WedLabel = New Label()
        TuesLabel = New Label()
        MonLabel = New Label()
        SunLabel = New Label()
        MonthLabel = New Label()
        BudgetTabPage = New TabPage()
        BudgetControl1 = New BudgetControl()
        PointsTabPage = New TabPage()
        PointsControl1 = New PointsControl()
        CType(BackgroundPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        CalendarTabPage.SuspendLayout()
        CalendarTableLayoutPanel.SuspendLayout()
        DaysPanel.SuspendLayout()
        BudgetTabPage.SuspendLayout()
        PointsTabPage.SuspendLayout()
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
        TabControl1.Controls.Add(PointsTabPage)
        TabControl1.Location = New Point(34, 57)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(435, 777)
        TabControl1.TabIndex = 5
        ' 
        ' CalendarTabPage
        ' 
        CalendarTabPage.BackColor = Color.White
        CalendarTabPage.Controls.Add(CalendarTableLayoutPanel)
        CalendarTabPage.Controls.Add(AddToCalendarButton)
        CalendarTabPage.Controls.Add(DaysPanel)
        CalendarTabPage.Controls.Add(MonthLabel)
        CalendarTabPage.Location = New Point(4, 4)
        CalendarTabPage.Name = "CalendarTabPage"
        CalendarTabPage.Padding = New Padding(3)
        CalendarTabPage.Size = New Size(427, 744)
        CalendarTabPage.TabIndex = 0
        CalendarTabPage.Text = "Calendar"
        ' 
        ' CalendarTableLayoutPanel
        ' 
        CalendarTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        CalendarTableLayoutPanel.ColumnCount = 7
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        CalendarTableLayoutPanel.Controls.Add(Label27, 0, 4)
        CalendarTableLayoutPanel.Controls.Add(Label26, 0, 4)
        CalendarTableLayoutPanel.Controls.Add(Label25, 0, 4)
        CalendarTableLayoutPanel.Controls.Add(Label22, 0, 4)
        CalendarTableLayoutPanel.Controls.Add(Label21, 0, 4)
        CalendarTableLayoutPanel.Controls.Add(DayLabel2, 4, 0)
        CalendarTableLayoutPanel.Controls.Add(DayLabel3, 5, 0)
        CalendarTableLayoutPanel.Controls.Add(DayLabel4, 6, 0)
        CalendarTableLayoutPanel.Controls.Add(Label1, 0, 1)
        CalendarTableLayoutPanel.Controls.Add(Label8, 1, 1)
        CalendarTableLayoutPanel.Controls.Add(Label5, 2, 1)
        CalendarTableLayoutPanel.Controls.Add(Label4, 3, 1)
        CalendarTableLayoutPanel.Controls.Add(Label6, 4, 1)
        CalendarTableLayoutPanel.Controls.Add(Label7, 5, 1)
        CalendarTableLayoutPanel.Controls.Add(Label3, 6, 1)
        CalendarTableLayoutPanel.Controls.Add(Label2, 0, 2)
        CalendarTableLayoutPanel.Controls.Add(Label12, 1, 2)
        CalendarTableLayoutPanel.Controls.Add(Label13, 2, 2)
        CalendarTableLayoutPanel.Controls.Add(Label9, 3, 2)
        CalendarTableLayoutPanel.Controls.Add(Label10, 4, 2)
        CalendarTableLayoutPanel.Controls.Add(Label11, 5, 2)
        CalendarTableLayoutPanel.Controls.Add(Label14, 6, 2)
        CalendarTableLayoutPanel.Controls.Add(Label18, 0, 3)
        CalendarTableLayoutPanel.Controls.Add(Label20, 1, 3)
        CalendarTableLayoutPanel.Controls.Add(Label17, 2, 3)
        CalendarTableLayoutPanel.Controls.Add(Label15, 3, 3)
        CalendarTableLayoutPanel.Controls.Add(Label16, 4, 3)
        CalendarTableLayoutPanel.Controls.Add(Label19, 5, 3)
        CalendarTableLayoutPanel.Controls.Add(Label23, 6, 3)
        CalendarTableLayoutPanel.Controls.Add(DayLabel1, 3, 0)
        CalendarTableLayoutPanel.Location = New Point(3, 206)
        CalendarTableLayoutPanel.Name = "CalendarTableLayoutPanel"
        CalendarTableLayoutPanel.RowCount = 5
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        CalendarTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        CalendarTableLayoutPanel.Size = New Size(424, 415)
        CalendarTableLayoutPanel.TabIndex = 21
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(4, 329)
        Label27.Name = "Label27"
        Label27.Size = New Size(25, 20)
        Label27.TabIndex = 30
        Label27.Text = "27"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(244, 329)
        Label26.Name = "Label26"
        Label26.Size = New Size(25, 20)
        Label26.TabIndex = 29
        Label26.Text = "26"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(64, 329)
        Label25.Name = "Label25"
        Label25.Size = New Size(25, 20)
        Label25.TabIndex = 28
        Label25.Text = "28"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(124, 329)
        Label22.Name = "Label22"
        Label22.Size = New Size(25, 20)
        Label22.TabIndex = 25
        Label22.Text = "30"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(184, 329)
        Label21.Name = "Label21"
        Label21.Size = New Size(25, 20)
        Label21.TabIndex = 24
        Label21.Text = "29"
        ' 
        ' DayLabel2
        ' 
        DayLabel2.AutoSize = True
        DayLabel2.Location = New Point(244, 1)
        DayLabel2.Name = "DayLabel2"
        DayLabel2.Size = New Size(17, 20)
        DayLabel2.TabIndex = 1
        DayLabel2.Text = "2"
        ' 
        ' DayLabel3
        ' 
        DayLabel3.AutoSize = True
        DayLabel3.Location = New Point(304, 1)
        DayLabel3.Name = "DayLabel3"
        DayLabel3.Size = New Size(17, 20)
        DayLabel3.TabIndex = 2
        DayLabel3.Text = "3"
        ' 
        ' DayLabel4
        ' 
        DayLabel4.AutoSize = True
        DayLabel4.Location = New Point(364, 1)
        DayLabel4.Name = "DayLabel4"
        DayLabel4.Size = New Size(17, 20)
        DayLabel4.TabIndex = 3
        DayLabel4.Text = "4"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 20)
        Label1.TabIndex = 4
        Label1.Text = "5"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(64, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(17, 20)
        Label8.TabIndex = 11
        Label8.Text = "6"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(124, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 20)
        Label5.TabIndex = 8
        Label5.Text = "7"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(184, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 20)
        Label4.TabIndex = 7
        Label4.Text = "8"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(244, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 20)
        Label6.TabIndex = 9
        Label6.Text = "9"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(304, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 20)
        Label7.TabIndex = 10
        Label7.Text = "10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(364, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 20)
        Label3.TabIndex = 6
        Label3.Text = "11"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 20)
        Label2.TabIndex = 5
        Label2.Text = "12"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(64, 165)
        Label12.Name = "Label12"
        Label12.Size = New Size(25, 20)
        Label12.TabIndex = 15
        Label12.Text = "13"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(124, 165)
        Label13.Name = "Label13"
        Label13.Size = New Size(25, 20)
        Label13.TabIndex = 16
        Label13.Text = "14"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(184, 165)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 20)
        Label9.TabIndex = 12
        Label9.Text = "15"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(244, 165)
        Label10.Name = "Label10"
        Label10.Size = New Size(25, 20)
        Label10.TabIndex = 13
        Label10.Text = "16"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(304, 165)
        Label11.Name = "Label11"
        Label11.Size = New Size(25, 20)
        Label11.TabIndex = 14
        Label11.Text = "17"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(364, 165)
        Label14.Name = "Label14"
        Label14.Size = New Size(25, 20)
        Label14.TabIndex = 17
        Label14.Text = "18"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(4, 247)
        Label18.Name = "Label18"
        Label18.Size = New Size(25, 20)
        Label18.TabIndex = 21
        Label18.Text = "19"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(64, 247)
        Label20.Name = "Label20"
        Label20.Size = New Size(25, 20)
        Label20.TabIndex = 23
        Label20.Text = "20"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(124, 247)
        Label17.Name = "Label17"
        Label17.Size = New Size(25, 20)
        Label17.TabIndex = 20
        Label17.Text = "21"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(184, 247)
        Label15.Name = "Label15"
        Label15.Size = New Size(25, 20)
        Label15.TabIndex = 18
        Label15.Text = "22"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(244, 247)
        Label16.Name = "Label16"
        Label16.Size = New Size(25, 20)
        Label16.TabIndex = 19
        Label16.Text = "23"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(304, 247)
        Label19.Name = "Label19"
        Label19.Size = New Size(25, 20)
        Label19.TabIndex = 22
        Label19.Text = "24"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(364, 247)
        Label23.Name = "Label23"
        Label23.Size = New Size(25, 20)
        Label23.TabIndex = 26
        Label23.Text = "25"
        ' 
        ' DayLabel1
        ' 
        DayLabel1.AutoSize = True
        DayLabel1.Location = New Point(184, 1)
        DayLabel1.Name = "DayLabel1"
        DayLabel1.Size = New Size(17, 20)
        DayLabel1.TabIndex = 0
        DayLabel1.Text = "1"
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
        ' DaysPanel
        ' 
        DaysPanel.Controls.Add(FriLabel)
        DaysPanel.Controls.Add(SatLabel)
        DaysPanel.Controls.Add(ThursLabel)
        DaysPanel.Controls.Add(WedLabel)
        DaysPanel.Controls.Add(TuesLabel)
        DaysPanel.Controls.Add(MonLabel)
        DaysPanel.Controls.Add(SunLabel)
        DaysPanel.Location = New Point(-3, 146)
        DaysPanel.Name = "DaysPanel"
        DaysPanel.Size = New Size(434, 54)
        DaysPanel.TabIndex = 19
        ' 
        ' FriLabel
        ' 
        FriLabel.BackColor = Color.LightBlue
        FriLabel.BorderStyle = BorderStyle.FixedSingle
        FriLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        FriLabel.Location = New Point(309, 0)
        FriLabel.Name = "FriLabel"
        FriLabel.Size = New Size(59, 54)
        FriLabel.TabIndex = 6
        FriLabel.Text = "F"
        FriLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SatLabel
        ' 
        SatLabel.BackColor = Color.LightBlue
        SatLabel.BorderStyle = BorderStyle.FixedSingle
        SatLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        SatLabel.Location = New Point(370, 0)
        SatLabel.Name = "SatLabel"
        SatLabel.Size = New Size(59, 54)
        SatLabel.TabIndex = 5
        SatLabel.Text = "S"
        SatLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ThursLabel
        ' 
        ThursLabel.BackColor = Color.LightBlue
        ThursLabel.BorderStyle = BorderStyle.FixedSingle
        ThursLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ThursLabel.Location = New Point(248, 0)
        ThursLabel.Name = "ThursLabel"
        ThursLabel.Size = New Size(59, 54)
        ThursLabel.TabIndex = 4
        ThursLabel.Text = "T"
        ThursLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' WedLabel
        ' 
        WedLabel.BackColor = Color.LightBlue
        WedLabel.BorderStyle = BorderStyle.FixedSingle
        WedLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        WedLabel.Location = New Point(187, 0)
        WedLabel.Name = "WedLabel"
        WedLabel.Size = New Size(59, 54)
        WedLabel.TabIndex = 3
        WedLabel.Text = "W"
        WedLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TuesLabel
        ' 
        TuesLabel.BackColor = Color.LightBlue
        TuesLabel.BorderStyle = BorderStyle.FixedSingle
        TuesLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TuesLabel.Location = New Point(126, 0)
        TuesLabel.Name = "TuesLabel"
        TuesLabel.Size = New Size(59, 54)
        TuesLabel.TabIndex = 2
        TuesLabel.Text = "T"
        TuesLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MonLabel
        ' 
        MonLabel.BackColor = Color.LightBlue
        MonLabel.BorderStyle = BorderStyle.FixedSingle
        MonLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        MonLabel.Location = New Point(65, 0)
        MonLabel.Name = "MonLabel"
        MonLabel.Size = New Size(59, 54)
        MonLabel.TabIndex = 1
        MonLabel.Text = "M"
        MonLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SunLabel
        ' 
        SunLabel.BackColor = Color.LightBlue
        SunLabel.BorderStyle = BorderStyle.FixedSingle
        SunLabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        SunLabel.Location = New Point(4, 0)
        SunLabel.Name = "SunLabel"
        SunLabel.Size = New Size(59, 54)
        SunLabel.TabIndex = 0
        SunLabel.Text = "S"
        SunLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MonthLabel
        ' 
        MonthLabel.AutoSize = True
        MonthLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        MonthLabel.Location = New Point(16, 55)
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
        ' PointsTabPage
        ' 
        PointsTabPage.Controls.Add(PointsControl1)
        PointsTabPage.Location = New Point(4, 4)
        PointsTabPage.Name = "PointsTabPage"
        PointsTabPage.Padding = New Padding(3)
        PointsTabPage.Size = New Size(427, 744)
        PointsTabPage.TabIndex = 2
        PointsTabPage.Text = "Points"
        PointsTabPage.UseVisualStyleBackColor = True
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
        CalendarTableLayoutPanel.ResumeLayout(False)
        CalendarTableLayoutPanel.PerformLayout()
        DaysPanel.ResumeLayout(False)
        BudgetTabPage.ResumeLayout(False)
        PointsTabPage.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CalendarTabPage As TabPage
    Friend WithEvents BudgetTabPage As TabPage
    Friend WithEvents PointsTabPage As TabPage
    Friend WithEvents BudgetControl1 As BudgetControl
    Friend WithEvents PointsControl1 As PointsControl
    Friend WithEvents CalendarTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DayLabel2 As Label
    Friend WithEvents DayLabel3 As Label
    Friend WithEvents DayLabel4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents DayLabel1 As Label
    Friend WithEvents AddToCalendarButton As Button
    Friend WithEvents DaysPanel As Panel
    Friend WithEvents FriLabel As Label
    Friend WithEvents SatLabel As Label
    Friend WithEvents ThursLabel As Label
    Friend WithEvents WedLabel As Label
    Friend WithEvents TuesLabel As Label
    Friend WithEvents MonLabel As Label
    Friend WithEvents SunLabel As Label
    Friend WithEvents MonthLabel As Label
End Class
