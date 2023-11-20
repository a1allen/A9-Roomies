Public Class ManagementRoommateProfilesControl
    Private Sub ManagementRoommateProfilesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Form1.showManagementTab()
    End Sub

    Private Sub Roommate1PreferenceCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate1PreferenceCheckBox.SelectedValueChanged, Roommate1PreferenceCheckBox.MouseLeave
        For Each item In Roommate1PreferenceCheckBox.Items

            ' Check if the item is selected
            If Roommate1PreferenceCheckBox.CheckedItems.Contains(item) Then
                Roommate1ExclusionCheckBox.Items.Remove(item)
            ElseIf Not Roommate1ExclusionCheckBox.Items.Contains(item) Then
                Roommate1ExclusionCheckBox.Items.Add(item)
            End If
        Next

    End Sub

    Private Sub Roommate1ExclusionCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate1ExclusionCheckBox.SelectedValueChanged, Roommate1ExclusionCheckBox.MouseLeave
        For Each item In Roommate1ExclusionCheckBox.Items
            ' Check if the item is selected
            If Roommate1ExclusionCheckBox.CheckedItems.Contains(item) Then
                Roommate1PreferenceCheckBox.Items.Remove(item)
            ElseIf Not Roommate1PreferenceCheckBox.Items.Contains(item) Then
                Roommate1PreferenceCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate2PreferenceCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate2PreferenceCheckBox.SelectedValueChanged, Roommate2PreferenceCheckBox.MouseLeave
        For Each item In Roommate2PreferenceCheckBox.Items
            ' Check if the item is selected
            If Roommate2PreferenceCheckBox.CheckedItems.Contains(item) Then
                Roommate2ExclusionCheckBox.Items.Remove(item)
            ElseIf Not Roommate2ExclusionCheckBox.Items.Contains(item) Then
                Roommate2ExclusionCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate2ExclusionCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate2ExclusionCheckBox.SelectedValueChanged, Roommate2ExclusionCheckBox.MouseLeave
        For Each item In Roommate2ExclusionCheckBox.Items
            ' Check if the item is selected
            If Roommate2ExclusionCheckBox.CheckedItems.Contains(item) Then
                Roommate2PreferenceCheckBox.Items.Remove(item)
            ElseIf Not Roommate2PreferenceCheckBox.Items.Contains(item) Then
                Roommate2PreferenceCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate3PreferenceCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate3PreferenceCheckBox.SelectedValueChanged, Roommate3PreferenceCheckBox.MouseLeave
        For Each item In Roommate3PreferenceCheckBox.Items
            ' Check if the item is selected
            If Roommate3PreferenceCheckBox.CheckedItems.Contains(item) Then
                Roommate3ExclusionCheckBox.Items.Remove(item)
            ElseIf Not Roommate3ExclusionCheckBox.Items.Contains(item) Then
                Roommate3ExclusionCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate3ExclusionCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate3ExclusionCheckBox.SelectedValueChanged, Roommate3ExclusionCheckBox.MouseLeave
        For Each item In Roommate3ExclusionCheckBox.Items
            ' Check if the item is selected
            If Roommate3ExclusionCheckBox.CheckedItems.Contains(item) Then
                Roommate3PreferenceCheckBox.Items.Remove(item)
            ElseIf Not Roommate3PreferenceCheckBox.Items.Contains(item) Then
                Roommate3PreferenceCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate4PreferenceCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate4PreferenceCheckBox.SelectedValueChanged, Roommate4PreferenceCheckBox.MouseLeave
        For Each item In Roommate4PreferenceCheckBox.Items
            ' Check if the item is selected
            If Roommate4PreferenceCheckBox.CheckedItems.Contains(item) Then
                Roommate4ExclusionCheckBox.Items.Remove(item)
            ElseIf Not Roommate4ExclusionCheckBox.Items.Contains(item) Then
                Roommate4ExclusionCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub Roommate4ExclusionCheckBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roommate4ExclusionCheckBox.SelectedValueChanged, Roommate4ExclusionCheckBox.MouseLeave
        For Each item In Roommate4ExclusionCheckBox.Items
            ' Check if the item is selected
            If Roommate4ExclusionCheckBox.CheckedItems.Contains(item) Then
                Roommate4PreferenceCheckBox.Items.Remove(item)
            ElseIf Not Roommate4PreferenceCheckBox.Items.Contains(item) Then
                Roommate4PreferenceCheckBox.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub BackManagementProfileButton_Click_1(sender As Object, e As EventArgs) Handles BackManagementProfileButton.Click
        Form1.showManagementTab()
    End Sub
End Class
