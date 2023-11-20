<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayPanelControl
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
        DayNumberLabel = New Label()
        Roomate1PictureBox = New PictureBox()
        Roomate2PictureBox = New PictureBox()
        Roomate3PictureBox = New PictureBox()
        Roomate4PictureBox = New PictureBox()
        CType(Roomate1PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(Roomate2PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(Roomate3PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(Roomate4PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DayNumberLabel
        ' 
        DayNumberLabel.AutoSize = True
        DayNumberLabel.Location = New Point(0, 0)
        DayNumberLabel.Name = "DayNumberLabel"
        DayNumberLabel.Size = New Size(17, 20)
        DayNumberLabel.TabIndex = 0
        DayNumberLabel.Text = "1"
        ' 
        ' Roomate1PictureBox
        ' 
        Roomate1PictureBox.Image = My.Resources.myResources.pink
        Roomate1PictureBox.Location = New Point(11, 26)
        Roomate1PictureBox.Name = "Roomate1PictureBox"
        Roomate1PictureBox.Size = New Size(17, 17)
        Roomate1PictureBox.TabIndex = 1
        Roomate1PictureBox.TabStop = False
        Roomate1PictureBox.Tag = Me
        ' 
        ' Roomate2PictureBox
        ' 
        Roomate2PictureBox.Image = My.Resources.myResources.green
        Roomate2PictureBox.Location = New Point(30, 26)
        Roomate2PictureBox.Name = "Roomate2PictureBox"
        Roomate2PictureBox.Size = New Size(17, 17)
        Roomate2PictureBox.TabIndex = 2
        Roomate2PictureBox.TabStop = False
        Roomate2PictureBox.Tag = Me
        ' 
        ' Roomate3PictureBox
        ' 
        Roomate3PictureBox.Image = My.Resources.myResources.blue
        Roomate3PictureBox.Location = New Point(12, 45)
        Roomate3PictureBox.Name = "Roomate3PictureBox"
        Roomate3PictureBox.Size = New Size(17, 17)
        Roomate3PictureBox.TabIndex = 3
        Roomate3PictureBox.TabStop = False
        Roomate3PictureBox.Tag = Me
        ' 
        ' Roomate4PictureBox
        ' 
        Roomate4PictureBox.Image = My.Resources.myResources.purple
        Roomate4PictureBox.Location = New Point(30, 45)
        Roomate4PictureBox.Name = "Roomate4PictureBox"
        Roomate4PictureBox.Size = New Size(17, 17)
        Roomate4PictureBox.TabIndex = 4
        Roomate4PictureBox.TabStop = False
        Roomate4PictureBox.Tag = Me
        ' 
        ' DayPanelControl
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Roomate4PictureBox)
        Controls.Add(Roomate3PictureBox)
        Controls.Add(Roomate2PictureBox)
        Controls.Add(Roomate1PictureBox)
        Controls.Add(DayNumberLabel)
        Name = "DayPanelControl"
        Size = New Size(58, 74)
        CType(Roomate1PictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(Roomate2PictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(Roomate3PictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(Roomate4PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DayNumberLabel As Label
    Friend WithEvents Roomate1PictureBox As PictureBox
    Friend WithEvents Roomate2PictureBox As PictureBox
    Friend WithEvents Roomate3PictureBox As PictureBox
    Friend WithEvents Roomate4PictureBox As PictureBox
End Class
