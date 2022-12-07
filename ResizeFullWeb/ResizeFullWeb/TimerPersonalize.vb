Public Class TimerPersonalize
    Dim timerValue As Integer

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        timerValue = CInt(TimerLabel.Text)
        timerValue = (timerValue * 60000) / 1
        ResizeFullWeb.Timer1.Interval = timerValue
        Me.Close()
    End Sub
End Class