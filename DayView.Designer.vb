<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        DayDate = New Label()
        Label1 = New Label()
        devider = New Label()
        Chore_item_inDay1 = New Chore_item_inDay()
        Chore_item_inDay2 = New Chore_item_inDay()
        SuspendLayout()
        ' 
        ' DayDate
        ' 
        DayDate.AutoSize = True
        DayDate.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        DayDate.Location = New Point(92, 37)
        DayDate.Name = "DayDate"
        DayDate.Size = New Size(152, 46)
        DayDate.TabIndex = 19
        DayDate.Text = "Monday"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(237, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 20
        Label1.Text = "2023-11-18"
        ' 
        ' devider
        ' 
        devider.AutoSize = True
        devider.Location = New Point(57, 69)
        devider.Name = "devider"
        devider.Size = New Size(321, 20)
        devider.TabIndex = 21
        devider.Text = "____________________________________________________"
        ' 
        ' Chore_item_inDay1
        ' 
        Chore_item_inDay1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Chore_item_inDay1.BorderStyle = BorderStyle.FixedSingle
        Chore_item_inDay1.Location = New Point(39, 114)
        Chore_item_inDay1.Name = "Chore_item_inDay1"
        Chore_item_inDay1.Size = New Size(356, 97)
        Chore_item_inDay1.TabIndex = 22
        ' 
        ' Chore_item_inDay2
        ' 
        Chore_item_inDay2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Chore_item_inDay2.BorderStyle = BorderStyle.FixedSingle
        Chore_item_inDay2.Location = New Point(39, 248)
        Chore_item_inDay2.Name = "Chore_item_inDay2"
        Chore_item_inDay2.Size = New Size(356, 97)
        Chore_item_inDay2.TabIndex = 23
        ' 
        ' DayView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(Chore_item_inDay2)
        Controls.Add(Chore_item_inDay1)
        Controls.Add(Label1)
        Controls.Add(DayDate)
        Controls.Add(devider)
        Name = "DayView"
        Size = New Size(434, 690)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DayDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents devider As Label
    Friend WithEvents Chore_item_inDay1 As Chore_item_inDay
    Friend WithEvents Chore_item_inDay2 As Chore_item_inDay

End Class
