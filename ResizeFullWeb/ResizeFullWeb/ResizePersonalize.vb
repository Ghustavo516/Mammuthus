Public Class ResizePersonalize
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ResizeFullWeb.Width = CInt(WidthLabel.Text)
        ResizeFullWeb.Height = CInt(HeightLabel.Text)
        Me.Close()
    End Sub
End Class