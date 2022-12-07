Public Class SaveBackup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Save 
        Dim file As System.IO.StreamWriter
        Dim FileText As String
        FileText = Init.Text
        file = My.Computer.FileSystem.OpenTextFileWriter("ResizeFullWebPage_B", True)
        file.WriteLine(FileText)
        file.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class