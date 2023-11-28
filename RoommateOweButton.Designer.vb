<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoommateOweButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        RoommateNameOwes = New Label()
        RoommateNameMoney = New Label()
        SuspendLayout()
        ' 
        ' RoommateNameOwes
        ' 
        RoommateNameOwes.AutoSize = True
        RoommateNameOwes.BackColor = Color.Transparent
        RoommateNameOwes.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        RoommateNameOwes.ImageAlign = ContentAlignment.MiddleLeft
        RoommateNameOwes.Location = New Point(0, 15)
        RoommateNameOwes.Name = "RoommateNameOwes"
        RoommateNameOwes.Size = New Size(260, 37)
        RoommateNameOwes.TabIndex = 0
        RoommateNameOwes.Text = "Roommate 0 Owes: "
        RoommateNameOwes.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoommateNameMoney
        ' 
        RoommateNameMoney.AutoSize = True
        RoommateNameMoney.BackColor = Color.Transparent
        RoommateNameMoney.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        RoommateNameMoney.Location = New Point(276, 15)
        RoommateNameMoney.Name = "RoommateNameMoney"
        RoommateNameMoney.Size = New Size(47, 37)
        RoommateNameMoney.TabIndex = 1
        RoommateNameMoney.Text = "$0"
        RoommateNameMoney.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoommateOweButton
        ' 
        BackColor = Color.Transparent
        Controls.Add(RoommateNameMoney)
        Controls.Add(RoommateNameOwes)
        MinimumSize = New Size(400, 60)
        Name = "RoommateOweButton"
        Size = New Size(400, 60)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents RoommateNameOwes As Label
    Public WithEvents RoommateNameMoney As Label
End Class
