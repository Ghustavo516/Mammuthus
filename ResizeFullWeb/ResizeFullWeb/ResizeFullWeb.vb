Option Strict On

Imports mshtml ' add a reference to Microsoft.mshtml in Assemblies, extensions
Public Class ResizeFullWeb


    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = 1
    Const HTCAPTION As Integer = 2
    Const TEMPO As Integer = 0

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = CType(HTCLIENT, IntPtr) Then
                    m.Result = CType(HTCAPTION, IntPtr)
                End If
        End Select
    End Sub

    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H40000
            Return cp
        End Get
    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        WebBrowser1.ScriptErrorsSuppressed = True
        Me.Width = 380 : Me.Height = 480
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebBrowser1.Refresh()
    End Sub

    Private Sub RefleshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefleshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub X480ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X480ToolStripMenuItem.Click
        Me.Width = 640
        Me.Height = 480
    End Sub

    Private Sub X600ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X600ToolStripMenuItem.Click
        Me.Width = 800
        Me.Height = 600
    End Sub

    Private Sub X768ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X768ToolStripMenuItem.Click
        Me.Width = 1024
        Me.Height = 768
    End Sub

    Private Sub PersonalizadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalizadoToolStripMenuItem.Click
        ResizePersonalize.Show()
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class
