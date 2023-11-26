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
        SaveButton = New Button()
        BackManagementProfileButton = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Roommate2PreferenceCheckBox = New CheckedListBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Roommate3ExclusionCheckBox = New CheckedListBox()
        Label7 = New Label()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Label10 = New Label()
        Roommate3PreferenceCheckBox = New CheckedListBox()
        Panel3 = New Panel()
        Label11 = New Label()
        Roommate4ExclusionCheckBox = New CheckedListBox()
        Label12 = New Label()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        Label14 = New Label()
        Roommate4PreferenceCheckBox = New CheckedListBox()
        Roommate2ExclusionCheckBox = New CheckedListBox()
        Roommate1Panel.SuspendLayout()
        CType(Roommate1PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoommateProfilesTitleLabel
        ' 
        RoommateProfilesTitleLabel.AutoSize = True
        RoommateProfilesTitleLabel.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        RoommateProfilesTitleLabel.Location = New Point(74, 56)
        RoommateProfilesTitleLabel.Name = "RoommateProfilesTitleLabel"
        RoommateProfilesTitleLabel.Size = New Size(286, 41)
        RoommateProfilesTitleLabel.TabIndex = 20
        RoommateProfilesTitleLabel.Text = "Roommate Profiles"
        ' 
        ' Roommate1Panel
        ' 
        Roommate1Panel.BackColor = Color.WhiteSmoke
        Roommate1Panel.BorderStyle = BorderStyle.FixedSingle
        Roommate1Panel.Controls.Add(Label2)
        Roommate1Panel.Controls.Add(Roommate1ExclusionCheckBox)
        Roommate1Panel.Controls.Add(Roommate1Rating)
        Roommate1Panel.Controls.Add(Roommate1NameLabel)
        Roommate1Panel.Controls.Add(Roommate1PictureBox)
        Roommate1Panel.Controls.Add(Label8)
        Roommate1Panel.Controls.Add(Roommate1PreferenceCheckBox)
        Roommate1Panel.Location = New Point(5, 109)
        Roommate1Panel.Name = "Roommate1Panel"
        Roommate1Panel.Size = New Size(424, 122)
        Roommate1Panel.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(277, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 25
        Label2.Text = "Be Excluded From:"
        ' 
        ' Roommate1ExclusionCheckBox
        ' 
        Roommate1ExclusionCheckBox.FormattingEnabled = True
        Roommate1ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate1ExclusionCheckBox.Location = New Point(279, 25)
        Roommate1ExclusionCheckBox.Name = "Roommate1ExclusionCheckBox"
        Roommate1ExclusionCheckBox.Size = New Size(129, 92)
        Roommate1ExclusionCheckBox.TabIndex = 24
        ' 
        ' Roommate1Rating
        ' 
        Roommate1Rating.AutoSize = True
        Roommate1Rating.Location = New Point(11, 94)
        Roommate1Rating.Name = "Roommate1Rating"
        Roommate1Rating.Size = New Size(74, 20)
        Roommate1Rating.TabIndex = 23
        Roommate1Rating.Text = "★★★★★"
        Roommate1Rating.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate1NameLabel
        ' 
        Roommate1NameLabel.AutoSize = True
        Roommate1NameLabel.Location = New Point(4, 7)
        Roommate1NameLabel.Name = "Roommate1NameLabel"
        Roommate1NameLabel.Size = New Size(95, 40)
        Roommate1NameLabel.TabIndex = 22
        Roommate1NameLabel.Text = "Roomate 1" & vbCrLf & "Ryan Gosling"
        Roommate1NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Roommate1PictureBox
        ' 
        Roommate1PictureBox.Image = My.Resources.myResources.pink
        Roommate1PictureBox.Location = New Point(29, 56)
        Roommate1PictureBox.Name = "Roommate1PictureBox"
        Roommate1PictureBox.Size = New Size(34, 30)
        Roommate1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Roommate1PictureBox.TabIndex = 21
        Roommate1PictureBox.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(117, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 20)
        Label8.TabIndex = 20
        Label8.Text = "Chore Preferences:"
        ' 
        ' Roommate1PreferenceCheckBox
        ' 
        Roommate1PreferenceCheckBox.FormattingEnabled = True
        Roommate1PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate1PreferenceCheckBox.Location = New Point(120, 25)
        Roommate1PreferenceCheckBox.Name = "Roommate1PreferenceCheckBox"
        Roommate1PreferenceCheckBox.Size = New Size(128, 92)
        Roommate1PreferenceCheckBox.TabIndex = 19
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        SaveButton.Location = New Point(174, 640)
        SaveButton.Margin = New Padding(3, 4, 3, 4)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(86, 35)
        SaveButton.TabIndex = 38
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' BackManagementProfileButton
        ' 
        BackManagementProfileButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackManagementProfileButton.Location = New Point(17, 15)
        BackManagementProfileButton.Name = "BackManagementProfileButton"
        BackManagementProfileButton.Size = New Size(42, 42)
        BackManagementProfileButton.TabIndex = 66
        BackManagementProfileButton.Text = "X"
        BackManagementProfileButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Roommate2ExclusionCheckBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Roommate2PreferenceCheckBox)
        Panel1.Location = New Point(5, 240)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 122)
        Panel1.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(277, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 20)
        Label1.TabIndex = 25
        Label1.Text = "Be Excluded From:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 23
        Label3.Text = "★★★★★"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(4, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 40)
        Label4.TabIndex = 22
        Label4.Text = "Roomate 2" & vbCrLf & "Sophie Quigley"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.myResources.green
        PictureBox1.Location = New Point(29, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(117, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 20
        Label5.Text = "Chore Preferences:"
        ' 
        ' Roommate2PreferenceCheckBox
        ' 
        Roommate2PreferenceCheckBox.FormattingEnabled = True
        Roommate2PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate2PreferenceCheckBox.Location = New Point(120, 25)
        Roommate2PreferenceCheckBox.Name = "Roommate2PreferenceCheckBox"
        Roommate2PreferenceCheckBox.Size = New Size(128, 92)
        Roommate2PreferenceCheckBox.TabIndex = 19
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Roommate3ExclusionCheckBox)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Roommate3PreferenceCheckBox)
        Panel2.Location = New Point(5, 371)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(424, 122)
        Panel2.TabIndex = 36
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(277, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 20)
        Label6.TabIndex = 25
        Label6.Text = "Be Excluded From:"
        ' 
        ' Roommate3ExclusionCheckBox
        ' 
        Roommate3ExclusionCheckBox.FormattingEnabled = True
        Roommate3ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate3ExclusionCheckBox.Location = New Point(279, 25)
        Roommate3ExclusionCheckBox.Name = "Roommate3ExclusionCheckBox"
        Roommate3ExclusionCheckBox.Size = New Size(129, 92)
        Roommate3ExclusionCheckBox.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 94)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 23
        Label7.Text = "★★★★★"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 7)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 40)
        Label9.TabIndex = 22
        Label9.Text = "Roomate 3" & vbCrLf & "Ethan Kim"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.myResources.blue
        PictureBox2.Location = New Point(29, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(117, 3)
        Label10.Name = "Label10"
        Label10.Size = New Size(131, 20)
        Label10.TabIndex = 20
        Label10.Text = "Chore Preferences:"
        ' 
        ' Roommate3PreferenceCheckBox
        ' 
        Roommate3PreferenceCheckBox.FormattingEnabled = True
        Roommate3PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate3PreferenceCheckBox.Location = New Point(120, 25)
        Roommate3PreferenceCheckBox.Name = "Roommate3PreferenceCheckBox"
        Roommate3PreferenceCheckBox.Size = New Size(128, 92)
        Roommate3PreferenceCheckBox.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Roommate4ExclusionCheckBox)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Roommate4PreferenceCheckBox)
        Panel3.Location = New Point(5, 502)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(424, 122)
        Panel3.TabIndex = 37
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(277, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(131, 20)
        Label11.TabIndex = 25
        Label11.Text = "Be Excluded From:"
        ' 
        ' Roommate4ExclusionCheckBox
        ' 
        Roommate4ExclusionCheckBox.FormattingEnabled = True
        Roommate4ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate4ExclusionCheckBox.Location = New Point(279, 25)
        Roommate4ExclusionCheckBox.Name = "Roommate4ExclusionCheckBox"
        Roommate4ExclusionCheckBox.Size = New Size(129, 92)
        Roommate4ExclusionCheckBox.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(11, 94)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 20)
        Label12.TabIndex = 23
        Label12.Text = "★★★★★"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(10, 7)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 40)
        Label13.TabIndex = 22
        Label13.Text = "Roomate 4" & vbCrLf & "Eric Ku"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.myResources.purple
        PictureBox3.Location = New Point(29, 56)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(34, 30)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(117, 3)
        Label14.Name = "Label14"
        Label14.Size = New Size(131, 20)
        Label14.TabIndex = 20
        Label14.Text = "Chore Preferences:"
        ' 
        ' Roommate4PreferenceCheckBox
        ' 
        Roommate4PreferenceCheckBox.FormattingEnabled = True
        Roommate4PreferenceCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate4PreferenceCheckBox.Location = New Point(120, 25)
        Roommate4PreferenceCheckBox.Name = "Roommate4PreferenceCheckBox"
        Roommate4PreferenceCheckBox.Size = New Size(128, 92)
        Roommate4PreferenceCheckBox.TabIndex = 19
        ' 
        ' Roommate2ExclusionCheckBox
        ' 
        Roommate2ExclusionCheckBox.FormattingEnabled = True
        Roommate2ExclusionCheckBox.Items.AddRange(New Object() {"Vacuum", "Wash Dishes", "Grocery", "Laundry"})
        Roommate2ExclusionCheckBox.Location = New Point(279, 25)
        Roommate2ExclusionCheckBox.Name = "Roommate2ExclusionCheckBox"
        Roommate2ExclusionCheckBox.Size = New Size(129, 92)
        Roommate2ExclusionCheckBox.TabIndex = 24
        ' 
        ' ManagementRoommateProfilesControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BackManagementProfileButton)
        Controls.Add(SaveButton)
        Controls.Add(Roommate1Panel)
        Controls.Add(RoommateProfilesTitleLabel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ManagementRoommateProfilesControl"
        Size = New Size(434, 690)
        Roommate1Panel.ResumeLayout(False)
        Roommate1Panel.PerformLayout()
        CType(Roommate1PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackManagementProfileButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Roommate2PreferenceCheckBox As CheckedListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Roommate3ExclusionCheckBox As CheckedListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Roommate3PreferenceCheckBox As CheckedListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Roommate4ExclusionCheckBox As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Roommate4PreferenceCheckBox As CheckedListBox
    Friend WithEvents Roommate2ExclusionCheckBox As CheckedListBox
End Class
