Public Class Main
    Private Sub EnterExhibitBTN_Click(sender As Object, e As EventArgs) Handles EnterExhibitBTN.Click
        If (ExhibitComboBox.SelectedItem.Equals("Giraffe Exhibit")) Then
            Queue.Show()
            Me.Hide()

        ElseIf (ExhibitComboBox.SelectedItem.Equals("Elephant Exhibit")) Then
            MessageBox.Show("This exhibit is currently unavailable.", "TourBot",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)

        ElseIf (ExhibitComboBox.SelectedItem.Equals("Lion Exhibit")) Then
            MessageBox.Show("This exhibit is currently unavailable.", "TourBot",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)

        End If
    End Sub

    Private Sub InfoBTN_Click(sender As Object, e As EventArgs) Handles InfoBTN.Click
        AboutBox1.Show()


    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click

        If (MessageBox.Show("Are you sure you want to exit?", "TourBot",
       MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub ExhibitComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExhibitComboBox.SelectedIndexChanged

    End Sub
End Class
