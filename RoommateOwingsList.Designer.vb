﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoommateOwingsList
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
        MainRoommateName = New Label()
        Label1 = New Label()
        TotalOwedLabel = New Label()
        TotalLentLabel = New Label()
        TotalOwed = New Label()
        TotalLent = New Label()
        OtherRoommateLabel1 = New Label()
        OtherRoommateLabel2 = New Label()
        OtherRoommateLabel3 = New Label()
        OtherRoommateMoney3 = New Label()
        OtherRoommateMoney2 = New Label()
        OtherRoommateMoney1 = New Label()
        ExitButton = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' MainRoommateName
        ' 
        MainRoommateName.AutoSize = True
        MainRoommateName.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        MainRoommateName.Location = New Point(135, 14)
        MainRoommateName.Name = "MainRoommateName"
        MainRoommateName.Size = New Size(159, 30)
        MainRoommateName.TabIndex = 0
        MainRoommateName.Text = "Main Roomate "
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Silver
        Label1.Location = New Point(-1, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 10)
        Label1.TabIndex = 1
        ' 
        ' TotalOwedLabel
        ' 
        TotalOwedLabel.AutoSize = True
        TotalOwedLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TotalOwedLabel.Location = New Point(3, 0)
        TotalOwedLabel.Name = "TotalOwedLabel"
        TotalOwedLabel.Size = New Size(87, 21)
        TotalOwedLabel.TabIndex = 2
        TotalOwedLabel.Text = "Total Owed"
        ' 
        ' TotalLentLabel
        ' 
        TotalLentLabel.AutoSize = True
        TotalLentLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TotalLentLabel.Location = New Point(341, 0)
        TotalLentLabel.Name = "TotalLentLabel"
        TotalLentLabel.Size = New Size(76, 21)
        TotalLentLabel.TabIndex = 3
        TotalLentLabel.Text = "Total Lent"
        ' 
        ' TotalOwed
        ' 
        TotalOwed.AutoSize = True
        TotalOwed.BackColor = Color.Transparent
        TotalOwed.ForeColor = Color.Red
        TotalOwed.Location = New Point(33, 29)
        TotalOwed.Name = "TotalOwed"
        TotalOwed.Size = New Size(19, 15)
        TotalOwed.TabIndex = 4
        TotalOwed.Text = "$0"
        ' 
        ' TotalLent
        ' 
        TotalLent.AutoSize = True
        TotalLent.BackColor = Color.Transparent
        TotalLent.ForeColor = Color.Green
        TotalLent.Location = New Point(369, 29)
        TotalLent.Name = "TotalLent"
        TotalLent.Size = New Size(19, 15)
        TotalLent.TabIndex = 5
        TotalLent.Text = "$0"
        ' 
        ' OtherRoommateLabel1
        ' 
        OtherRoommateLabel1.AutoSize = True
        OtherRoommateLabel1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateLabel1.ImageAlign = ContentAlignment.MiddleLeft
        OtherRoommateLabel1.Location = New Point(133, 72)
        OtherRoommateLabel1.Name = "OtherRoommateLabel1"
        OtherRoommateLabel1.Size = New Size(139, 20)
        OtherRoommateLabel1.TabIndex = 6
        OtherRoommateLabel1.Text = "Roommate X Owes:"
        OtherRoommateLabel1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OtherRoommateLabel2
        ' 
        OtherRoommateLabel2.AutoSize = True
        OtherRoommateLabel2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateLabel2.Location = New Point(133, 131)
        OtherRoommateLabel2.Name = "OtherRoommateLabel2"
        OtherRoommateLabel2.Size = New Size(143, 20)
        OtherRoommateLabel2.TabIndex = 7
        OtherRoommateLabel2.Text = "Roommate X Owes: "
        OtherRoommateLabel2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OtherRoommateLabel3
        ' 
        OtherRoommateLabel3.AutoSize = True
        OtherRoommateLabel3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateLabel3.Location = New Point(133, 190)
        OtherRoommateLabel3.Name = "OtherRoommateLabel3"
        OtherRoommateLabel3.Size = New Size(143, 20)
        OtherRoommateLabel3.TabIndex = 8
        OtherRoommateLabel3.Text = "Roommate X Owes: "
        OtherRoommateLabel3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OtherRoommateMoney3
        ' 
        OtherRoommateMoney3.AutoSize = True
        OtherRoommateMoney3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateMoney3.Location = New Point(189, 213)
        OtherRoommateMoney3.Name = "OtherRoommateMoney3"
        OtherRoommateMoney3.Size = New Size(25, 20)
        OtherRoommateMoney3.TabIndex = 11
        OtherRoommateMoney3.Text = "$0"
        OtherRoommateMoney3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OtherRoommateMoney2
        ' 
        OtherRoommateMoney2.AutoSize = True
        OtherRoommateMoney2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateMoney2.Location = New Point(189, 154)
        OtherRoommateMoney2.Name = "OtherRoommateMoney2"
        OtherRoommateMoney2.Size = New Size(25, 20)
        OtherRoommateMoney2.TabIndex = 10
        OtherRoommateMoney2.Text = "$0"
        OtherRoommateMoney2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' OtherRoommateMoney1
        ' 
        OtherRoommateMoney1.AutoSize = True
        OtherRoommateMoney1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        OtherRoommateMoney1.ImageAlign = ContentAlignment.MiddleLeft
        OtherRoommateMoney1.Location = New Point(189, 95)
        OtherRoommateMoney1.Name = "OtherRoommateMoney1"
        OtherRoommateMoney1.Size = New Size(25, 20)
        OtherRoommateMoney1.TabIndex = 9
        OtherRoommateMoney1.Text = "$0"
        OtherRoommateMoney1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.Red
        ExitButton.Location = New Point(168, 266)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 37)
        ExitButton.TabIndex = 12
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Silver
        Label3.Location = New Point(-2, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(429, 10)
        Label3.TabIndex = 13
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Silver
        Label4.Location = New Point(1, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(429, 10)
        Label4.TabIndex = 14
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Silver
        Label5.Location = New Point(2, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(429, 10)
        Label5.TabIndex = 15
        ' 
        ' RoommateOwingsList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ExitButton)
        Controls.Add(OtherRoommateMoney3)
        Controls.Add(OtherRoommateMoney2)
        Controls.Add(OtherRoommateMoney1)
        Controls.Add(OtherRoommateLabel3)
        Controls.Add(OtherRoommateLabel2)
        Controls.Add(OtherRoommateLabel1)
        Controls.Add(TotalLent)
        Controls.Add(TotalOwed)
        Controls.Add(TotalLentLabel)
        Controls.Add(TotalOwedLabel)
        Controls.Add(Label1)
        Controls.Add(MainRoommateName)
        MinimumSize = New Size(429, 200)
        Name = "RoommateOwingsList"
        Size = New Size(429, 326)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainRoommateName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalOwedLabel As Label
    Friend WithEvents TotalLentLabel As Label
    Friend WithEvents TotalOwed As Label
    Friend WithEvents TotalLent As Label
    Friend WithEvents OtherRoommateLabel1 As Label
    Friend WithEvents OtherRoommateLabel2 As Label
    Friend WithEvents OtherRoommateLabel3 As Label
    Friend WithEvents OtherRoommateMoney3 As Label
    Friend WithEvents OtherRoommateMoney2 As Label
    Friend WithEvents OtherRoommateMoney1 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class