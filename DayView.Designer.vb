﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayView
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
        BackButton = New Button()
        FullDate = New Label()
        DayDate = New Label()
        devider = New Label()
        SuspendLayout()
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(25, 21)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(42, 42)
        BackButton.TabIndex = 27
        BackButton.Text = "X"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' FullDate
        ' 
        FullDate.AutoSize = True
        FullDate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        FullDate.Location = New Point(282, 61)
        FullDate.Name = "FullDate"
        FullDate.Size = New Size(106, 25)
        FullDate.TabIndex = 25
        FullDate.Text = "2023-11-18"
        ' 
        ' DayDate
        ' 
        DayDate.AutoSize = True
        DayDate.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        DayDate.Location = New Point(73, 45)
        DayDate.Name = "DayDate"
        DayDate.Size = New Size(152, 46)
        DayDate.TabIndex = 24
        DayDate.Text = "Monday"
        ' 
        ' devider
        ' 
        devider.AutoSize = True
        devider.Location = New Point(67, 76)
        devider.Name = "devider"
        devider.Size = New Size(321, 20)
        devider.TabIndex = 26
        devider.Text = "____________________________________________________"
        ' 
        ' DayView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        Controls.Add(BackButton)
        Controls.Add(FullDate)
        Controls.Add(DayDate)
        Controls.Add(devider)
        Name = "DayView"
        Size = New Size(434, 690)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents FullDate As Label
    Friend WithEvents DayDate As Label
    Friend WithEvents devider As Label

End Class
