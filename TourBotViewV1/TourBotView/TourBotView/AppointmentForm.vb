Public Class AppointmentForm
    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click

        If (Me.DateTimePicker1.Value.Equals(Today)) Then
            Dim tourbotview1 = New TourBotView(3, 1)
            tourbotview1.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class