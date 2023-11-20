<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementRoommateProfilesControl
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
        RoommateProfilesTitleLabel = New Label()
        Roommate1Panel = New Panel()
        Label2 = New Label()
        Roommate1ExclusionCheckBox = New CheckedListBox()
        Roommate1Rating = New Label()
        Roommate1NameLabel = New Label()
        Roommate1PictureBox = New PictureBox()
        Label8 = New Label()
        Roommate1PreferenceCheckBox = New CheckedListBox()
        Roommate2Panel = New Panel()
        Label3 = New Label()
        Roommate2ExclusionCheckBox = New CheckedListBox()
        Roommate2Rating = New Label()
        Roommate2NameLabel = New Label()
        Roommate2PictureBox = New PictureBox()
        Label6 = New Label()
        Roommate2PreferenceCheckBox = New CheckedListBox()
        Roommate3Panel = New Panel()
        Label9 = New Label()
        Roommate3ExclusionCheckBox = New CheckedListBox()
        Roommate3Rating = New Label()
        Roommate3NameLabel = New Label()
        Roommate3PictureBox = New PictureBox()
        Label12 = New Label()
        Roommate3PreferenceCheckBox = New CheckedListBox()
        Roommate4Panel = New Panel()
        Label13 = New Label()
        Roommate4ExclusionCheckBox = New CheckedListBox()
        Roommate4Rating = New Label()
        Roommate4NameLabel = New Label()
        Roommate4PictureBox = New PictureBox()
        Label16 = New Label()
        Roommate4PreferenceCheckBox = New CheckedListBox()
        SaveButton = New Button()
        Roommate1Panel.SuspendLayout()
        CType(Roommate1PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Roommate2Panel.SuspendLayout()
        CType(Roommate2PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Roommate3Panel.SuspendLayout()
        CType(Roommate3PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Roommate4Panel.SuspendLayout()
        CType(Roommate4PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoommateProfilesTitleLabel
        ' 
        RoommateProfilesTitleLabel.AutoSize = True
        RoommateProfilesTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        RoommateProfilesTitleLabel.Location = New Point(98, 42)
        RoommateProfilesTitleLabel.Name = "RoommateProfilesTitleLabel"
        RoommateProfilesTitleLabel.Size = New Size(232, 32)
        RoommateProfilesTitleLabel.TabIndex = 20
        RoommateProfilesTitleLabel.Text = "Roommate Profiles"
        ' 
        ' Roommate1Panel
        ' 
        Roommate1Panel.Controls.Add(Label2)
        Roommate1Panel.Controls.Add(Roommate1ExclusionCheckBox)
        Roommate1Panel.Controls.Add(Roommate1Rating)
        Roommate1Panel.Controls.Add(Roommate1NameLabel)
        Roommate1Panel.Controls.Add(Roommate1PictureBox)
        Roommate1Panel.Controls.Add(Label8)
        Roommate1Panel.Controls.Add(Roommate1PreferenceCheckBox)
        Roommate1Panel.Location = New Point(6, 99)
        Roommate1Panel.Margin = New Padding(3, 2, 3, 2)
        Roommate1Panel.Name = "Roommate1Panel"
        Roommate1Panel.Size = New Size(417, 130)
        Roommate1Panel.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(266, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 25
        Label2.Text = "Be Excluded From:"
        ' 
        ' Roommate1ExclusionCheckBox
        ' 
        Roommate1ExclusionCheckBox.FormattingEnabled = True
        Roommate1ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate1ExclusionCheckBox.Location = New Point(268, 35)
        Roommate1ExclusionCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate1ExclusionCheckBox.Name = "Roommate1ExclusionCheckBox"
        Roommate1ExclusionCheckBox.Size = New Size(140, 76)
        Roommate1ExclusionCheckBox.TabIndex = 24
        ' 
        ' Roommate1Rating
        ' 
        Roommate1Rating.AutoSize = True
        Roommate1Rating.Location = New Point(9, 101)
        Roommate1Rating.Name = "Roommate1Rating"
        Roommate1Rating.Size = New Size(97, 15)
        Roommate1Rating.TabIndex = 23
        Roommate1Rating.Text = "Rating: ★★★★★"
        Roommate1Rating.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate1NameLabel
        ' 
        Roommate1NameLabel.AutoSize = True
        Roommate1NameLabel.Location = New Point(25, 17)
        Roommate1NameLabel.Name = "Roommate1NameLabel"
        Roommate1NameLabel.Size = New Size(64, 30)
        Roommate1NameLabel.TabIndex = 22
        Roommate1NameLabel.Text = "Roomate 1" & vbCrLf & "Ethan Kim"
        Roommate1NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate1PictureBox
        ' 
        Roommate1PictureBox.Image = My.Resources.myResources.pink
        Roommate1PictureBox.Location = New Point(42, 59)
        Roommate1PictureBox.Margin = New Padding(3, 2, 3, 2)
        Roommate1PictureBox.Name = "Roommate1PictureBox"
        Roommate1PictureBox.Size = New Size(30, 30)
        Roommate1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Roommate1PictureBox.TabIndex = 21
        Roommate1PictureBox.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(115, 17)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 15)
        Label8.TabIndex = 20
        Label8.Text = "Chore Preferences:"
        ' 
        ' Roommate1PreferenceCheckBox
        ' 
        Roommate1PreferenceCheckBox.FormattingEnabled = True
        Roommate1PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate1PreferenceCheckBox.Location = New Point(117, 35)
        Roommate1PreferenceCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate1PreferenceCheckBox.Name = "Roommate1PreferenceCheckBox"
        Roommate1PreferenceCheckBox.Size = New Size(140, 76)
        Roommate1PreferenceCheckBox.TabIndex = 19
        ' 
        ' Roommate2Panel
        ' 
        Roommate2Panel.Controls.Add(Label3)
        Roommate2Panel.Controls.Add(Roommate2ExclusionCheckBox)
        Roommate2Panel.Controls.Add(Roommate2Rating)
        Roommate2Panel.Controls.Add(Roommate2NameLabel)
        Roommate2Panel.Controls.Add(Roommate2PictureBox)
        Roommate2Panel.Controls.Add(Label6)
        Roommate2Panel.Controls.Add(Roommate2PreferenceCheckBox)
        Roommate2Panel.Location = New Point(6, 242)
        Roommate2Panel.Margin = New Padding(3, 2, 3, 2)
        Roommate2Panel.Name = "Roommate2Panel"
        Roommate2Panel.Size = New Size(417, 130)
        Roommate2Panel.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(266, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 15)
        Label3.TabIndex = 25
        Label3.Text = "Be Excluded From:"
        ' 
        ' Roommate2ExclusionCheckBox
        ' 
        Roommate2ExclusionCheckBox.FormattingEnabled = True
        Roommate2ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate2ExclusionCheckBox.Location = New Point(268, 35)
        Roommate2ExclusionCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate2ExclusionCheckBox.Name = "Roommate2ExclusionCheckBox"
        Roommate2ExclusionCheckBox.Size = New Size(140, 76)
        Roommate2ExclusionCheckBox.TabIndex = 24
        ' 
        ' Roommate2Rating
        ' 
        Roommate2Rating.AutoSize = True
        Roommate2Rating.Location = New Point(9, 101)
        Roommate2Rating.Name = "Roommate2Rating"
        Roommate2Rating.Size = New Size(97, 15)
        Roommate2Rating.TabIndex = 23
        Roommate2Rating.Text = "Rating: ★★★★★"
        Roommate2Rating.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate2NameLabel
        ' 
        Roommate2NameLabel.AutoSize = True
        Roommate2NameLabel.Location = New Point(25, 17)
        Roommate2NameLabel.Name = "Roommate2NameLabel"
        Roommate2NameLabel.Size = New Size(64, 30)
        Roommate2NameLabel.TabIndex = 22
        Roommate2NameLabel.Text = "Roomate 2" & vbCrLf & "Eric Ku" & vbCrLf
        Roommate2NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate2PictureBox
        ' 
        Roommate2PictureBox.Image = My.Resources.myResources.green
        Roommate2PictureBox.Location = New Point(42, 59)
        Roommate2PictureBox.Margin = New Padding(3, 2, 3, 2)
        Roommate2PictureBox.Name = "Roommate2PictureBox"
        Roommate2PictureBox.Size = New Size(30, 30)
        Roommate2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Roommate2PictureBox.TabIndex = 21
        Roommate2PictureBox.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(115, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 15)
        Label6.TabIndex = 20
        Label6.Text = "Chore Preferences:"
        ' 
        ' Roommate2PreferenceCheckBox
        ' 
        Roommate2PreferenceCheckBox.FormattingEnabled = True
        Roommate2PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate2PreferenceCheckBox.Location = New Point(117, 35)
        Roommate2PreferenceCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate2PreferenceCheckBox.Name = "Roommate2PreferenceCheckBox"
        Roommate2PreferenceCheckBox.Size = New Size(140, 76)
        Roommate2PreferenceCheckBox.TabIndex = 19
        ' 
        ' Roommate3Panel
        ' 
        Roommate3Panel.Controls.Add(Label9)
        Roommate3Panel.Controls.Add(Roommate3ExclusionCheckBox)
        Roommate3Panel.Controls.Add(Roommate3Rating)
        Roommate3Panel.Controls.Add(Roommate3NameLabel)
        Roommate3Panel.Controls.Add(Roommate3PictureBox)
        Roommate3Panel.Controls.Add(Label12)
        Roommate3Panel.Controls.Add(Roommate3PreferenceCheckBox)
        Roommate3Panel.Location = New Point(6, 385)
        Roommate3Panel.Margin = New Padding(3, 2, 3, 2)
        Roommate3Panel.Name = "Roommate3Panel"
        Roommate3Panel.Size = New Size(417, 130)
        Roommate3Panel.TabIndex = 36
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(266, 17)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 15)
        Label9.TabIndex = 25
        Label9.Text = "Be Excluded From:"
        ' 
        ' Roommate3ExclusionCheckBox
        ' 
        Roommate3ExclusionCheckBox.FormattingEnabled = True
        Roommate3ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate3ExclusionCheckBox.Location = New Point(268, 35)
        Roommate3ExclusionCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate3ExclusionCheckBox.Name = "Roommate3ExclusionCheckBox"
        Roommate3ExclusionCheckBox.Size = New Size(140, 76)
        Roommate3ExclusionCheckBox.TabIndex = 24
        ' 
        ' Roommate3Rating
        ' 
        Roommate3Rating.AutoSize = True
        Roommate3Rating.Location = New Point(9, 101)
        Roommate3Rating.Name = "Roommate3Rating"
        Roommate3Rating.Size = New Size(97, 15)
        Roommate3Rating.TabIndex = 23
        Roommate3Rating.Text = "Rating: ★★★★★"
        Roommate3Rating.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate3NameLabel
        ' 
        Roommate3NameLabel.AutoSize = True
        Roommate3NameLabel.Location = New Point(14, 17)
        Roommate3NameLabel.Name = "Roommate3NameLabel"
        Roommate3NameLabel.Size = New Size(87, 30)
        Roommate3NameLabel.TabIndex = 22
        Roommate3NameLabel.Text = "Roomate 3" & vbCrLf & "Sophie Quigley"
        Roommate3NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate3PictureBox
        ' 
        Roommate3PictureBox.Image = My.Resources.myResources.blue
        Roommate3PictureBox.Location = New Point(42, 59)
        Roommate3PictureBox.Margin = New Padding(3, 2, 3, 2)
        Roommate3PictureBox.Name = "Roommate3PictureBox"
        Roommate3PictureBox.Size = New Size(30, 30)
        Roommate3PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Roommate3PictureBox.TabIndex = 21
        Roommate3PictureBox.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(115, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 15)
        Label12.TabIndex = 20
        Label12.Text = "Chore Preferences:"
        ' 
        ' Roommate3PreferenceCheckBox
        ' 
        Roommate3PreferenceCheckBox.FormattingEnabled = True
        Roommate3PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate3PreferenceCheckBox.Location = New Point(117, 35)
        Roommate3PreferenceCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate3PreferenceCheckBox.Name = "Roommate3PreferenceCheckBox"
        Roommate3PreferenceCheckBox.Size = New Size(140, 76)
        Roommate3PreferenceCheckBox.TabIndex = 19
        ' 
        ' Roommate4Panel
        ' 
        Roommate4Panel.Controls.Add(Label13)
        Roommate4Panel.Controls.Add(Roommate4ExclusionCheckBox)
        Roommate4Panel.Controls.Add(Roommate4Rating)
        Roommate4Panel.Controls.Add(Roommate4NameLabel)
        Roommate4Panel.Controls.Add(Roommate4PictureBox)
        Roommate4Panel.Controls.Add(Label16)
        Roommate4Panel.Controls.Add(Roommate4PreferenceCheckBox)
        Roommate4Panel.Location = New Point(6, 528)
        Roommate4Panel.Margin = New Padding(3, 2, 3, 2)
        Roommate4Panel.Name = "Roommate4Panel"
        Roommate4Panel.Size = New Size(417, 130)
        Roommate4Panel.TabIndex = 37
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(266, 17)
        Label13.Name = "Label13"
        Label13.Size = New Size(105, 15)
        Label13.TabIndex = 25
        Label13.Text = "Be Excluded From:"
        ' 
        ' Roommate4ExclusionCheckBox
        ' 
        Roommate4ExclusionCheckBox.FormattingEnabled = True
        Roommate4ExclusionCheckBox.Items.AddRange(New Object() {"Wash Dishes", "Shovel Snow", "Grocery"})
        Roommate4ExclusionCheckBox.Location = New Point(268, 35)
        Roommate4ExclusionCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate4ExclusionCheckBox.Name = "Roommate4ExclusionCheckBox"
        Roommate4ExclusionCheckBox.Size = New Size(140, 76)
        Roommate4ExclusionCheckBox.TabIndex = 24
        ' 
        ' Roommate4Rating
        ' 
        Roommate4Rating.AutoSize = True
        Roommate4Rating.Location = New Point(9, 101)
        Roommate4Rating.Name = "Roommate4Rating"
        Roommate4Rating.Size = New Size(97, 15)
        Roommate4Rating.TabIndex = 23
        Roommate4Rating.Text = "Rating: ★★★★★"
        Roommate4Rating.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate4NameLabel
        ' 
        Roommate4NameLabel.AutoSize = True
        Roommate4NameLabel.Location = New Point(19, 17)
        Roommate4NameLabel.Name = "Roommate4NameLabel"
        Roommate4NameLabel.Size = New Size(76, 30)
        Roommate4NameLabel.TabIndex = 22
        Roommate4NameLabel.Text = "Roomate 4" & vbCrLf & "Ryan Gosling"
        Roommate4NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate4PictureBox
        ' 
        Roommate4PictureBox.Image = My.Resources.myResources.purple
        Roommate4PictureBox.Location = New Point(42, 59)
        Roommate4PictureBox.Margin = New Padding(3, 2, 3, 2)
        Roommate4PictureBox.Name = "Roommate4PictureBox"
        Roommate4PictureBox.Size = New Size(30, 30)
        Roommate4PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Roommate4PictureBox.TabIndex = 21
        Roommate4PictureBox.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(115, 17)
        Label16.Name = "Label16"
        Label16.Size = New Size(106, 15)
        Label16.TabIndex = 20
        Label16.Text = "Chore Preferences:"
        ' 
        ' Roommate4PreferenceCheckBox
        ' 
        Roommate4PreferenceCheckBox.FormattingEnabled = True
        Roommate4PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Shovel Snow"})
        Roommate4PreferenceCheckBox.Location = New Point(117, 35)
        Roommate4PreferenceCheckBox.Margin = New Padding(3, 2, 3, 2)
        Roommate4PreferenceCheckBox.Name = "Roommate4PreferenceCheckBox"
        Roommate4PreferenceCheckBox.Size = New Size(140, 76)
        Roommate4PreferenceCheckBox.TabIndex = 19
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SaveButton.Location = New Point(177, 669)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(75, 26)
        SaveButton.TabIndex = 38
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' ManagementRoommateProfilesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(SaveButton)
        Controls.Add(Roommate4Panel)
        Controls.Add(Roommate3Panel)
        Controls.Add(Roommate2Panel)
        Controls.Add(Roommate1Panel)
        Controls.Add(RoommateProfilesTitleLabel)
        Name = "ManagementRoommateProfilesControl"
        Size = New Size(429, 722)
        Roommate1Panel.ResumeLayout(False)
        Roommate1Panel.PerformLayout()
        CType(Roommate1PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Roommate2Panel.ResumeLayout(False)
        Roommate2Panel.PerformLayout()
        CType(Roommate2PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Roommate3Panel.ResumeLayout(False)
        Roommate3Panel.PerformLayout()
        CType(Roommate3PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Roommate4Panel.ResumeLayout(False)
        Roommate4Panel.PerformLayout()
        CType(Roommate4PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoommateProfilesTitleLabel As Label
    Friend WithEvents Roommate1Panel As Panel
    Friend WithEvents Roommate1NameLabel As Label
    Friend WithEvents Roommate1PictureBox As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Roommate1PreferenceCheckBox As CheckedListBox
    Friend WithEvents Roommate1Rating As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Roommate1ExclusionCheckBox As CheckedListBox
    Friend WithEvents Roommate2Panel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Roommate2ExclusionCheckBox As CheckedListBox
    Friend WithEvents Roommate2Rating As Label
    Friend WithEvents Roommate2NameLabel As Label
    Friend WithEvents Roommate2PictureBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Roommate2PreferenceCheckBox As CheckedListBox
    Friend WithEvents Roommate3Panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Roommate3ExclusionCheckBox As CheckedListBox
    Friend WithEvents Roommate3Rating As Label
    Friend WithEvents Roommate3NameLabel As Label
    Friend WithEvents Roommate3PictureBox As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Roommate3PreferenceCheckBox As CheckedListBox
    Friend WithEvents Roommate4Panel As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Roommate4ExclusionCheckBox As CheckedListBox
    Friend WithEvents Roommate4Rating As Label
    Friend WithEvents Roommate4NameLabel As Label
    Friend WithEvents Roommate4PictureBox As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Roommate4PreferenceCheckBox As CheckedListBox
    Friend WithEvents SaveButton As Button
End Class
