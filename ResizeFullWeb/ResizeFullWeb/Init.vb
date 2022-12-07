Imports System.IO
Public Class Init

    Dim TimerValue As Integer

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        If WidthLabel.Text = " " Or HeightLabel.Text = " " Then
            Me.Width = 1000
            Me.Height = 500
        Else
            Me.Width = CInt(WidthLabel.Text)
            Me.Height = CInt(HeightLabel.Text)
        End If

        ResizeFullWeb.WebBrowser1.Navigate(TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "Personalizado"
        TimerPersonalize.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LabelTimer.Text = "Desligado"
        ResizeFullWeb.Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "30 Segundos"
        ResizeFullWeb.Timer1.Interval = 30000
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "1 Minuto"
        ResizeFullWeb.Timer1.Interval = 60000
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "2 Minutos"
        ResizeFullWeb.Timer1.Interval = 120000
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "3 Minutos"
        ResizeFullWeb.Timer1.Interval = 180000
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ResizeFullWeb.Timer1.Enabled = True
        LabelTimer.Text = "4 Minutos"
        ResizeFullWeb.Timer1.Interval = 240000
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim OpenFileDialog1 As New OpenFileDialog
        Dim DirectoryUrlText As String

        Dim fileReader As String

        OpenFileDialog1.Filter = "Resize Files (*)|*.rfgus"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DirectoryUrlText = OpenFileDialog1.FileName
            fileReader = My.Computer.FileSystem.ReadAllText(DirectoryUrlText)
            TextBox1.Text = fileReader
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("Escolha um diretorio para salvar o arquivo de backup")

        SaveFileDialog1.Filter = "Resize Files (*)|*.rfgus"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
        End If

        ResizeFullWeb.Show()
    End Sub
End Class