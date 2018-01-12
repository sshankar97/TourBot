Public Class Queue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tourbotview1 = New TourBotView(3, 1)
        tourbotview1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tourbotview1 = New TourBotView(2, 2)
        tourbotview1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tourbotview1 = New TourBotView(4, 3)
        tourbotview1.Show()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        If (MessageBox.Show("Are you sure you want to exit?", "TourBot",
       MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) = DialogResult.OK) Then
            Me.Close()
        End If
    End Sub

    Private Sub InfoBTN_Click(sender As Object, e As EventArgs) Handles InfoBTN.Click
        AboutBox1.Show()
    End Sub

    Private Sub changeExhibit_Click(sender As Object, e As EventArgs) Handles changeExhibit.Click
        Me.Close()
        Main.Show()
    End Sub



    Private Sub appointment_Click(sender As Object, e As EventArgs) Handles appointment.Click
        AppointmentForm.Show()
    End Sub
End Class