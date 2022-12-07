<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResizeFullWeb
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefleshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X480ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X600ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X768ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 40)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(824, 462)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.RefleshToolStripMenuItem, Me.HistoricToolStripMenuItem, Me.NewPageToolStripMenuItem, Me.ResizeScreenToolStripMenuItem, Me.FullScreenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'RefleshToolStripMenuItem
        '
        Me.RefleshToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefleshToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RefleshToolStripMenuItem.Name = "RefleshToolStripMenuItem"
        Me.RefleshToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.RefleshToolStripMenuItem.Text = "Reflesh"
        '
        'HistoricToolStripMenuItem
        '
        Me.HistoricToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoricToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.HistoricToolStripMenuItem.Name = "HistoricToolStripMenuItem"
        Me.HistoricToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HistoricToolStripMenuItem.Text = "Historic"
        '
        'NewPageToolStripMenuItem
        '
        Me.NewPageToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPageToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NewPageToolStripMenuItem.Name = "NewPageToolStripMenuItem"
        Me.NewPageToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.NewPageToolStripMenuItem.Text = "New Page"
        '
        'ResizeScreenToolStripMenuItem
        '
        Me.ResizeScreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizadoToolStripMenuItem, Me.X480ToolStripMenuItem, Me.X600ToolStripMenuItem, Me.X768ToolStripMenuItem})
        Me.ResizeScreenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResizeScreenToolStripMenuItem.Name = "ResizeScreenToolStripMenuItem"
        Me.ResizeScreenToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ResizeScreenToolStripMenuItem.Text = "Resize Screen"
        '
        'PersonalizadoToolStripMenuItem
        '
        Me.PersonalizadoToolStripMenuItem.Name = "PersonalizadoToolStripMenuItem"
        Me.PersonalizadoToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PersonalizadoToolStripMenuItem.Text = "Personalizado"
        '
        'X480ToolStripMenuItem
        '
        Me.X480ToolStripMenuItem.Name = "X480ToolStripMenuItem"
        Me.X480ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.X480ToolStripMenuItem.Text = "640 x 480"
        '
        'X600ToolStripMenuItem
        '
        Me.X600ToolStripMenuItem.Name = "X600ToolStripMenuItem"
        Me.X600ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.X600ToolStripMenuItem.Text = "800 x 600"
        '
        'X768ToolStripMenuItem
        '
        Me.X768ToolStripMenuItem.Name = "X768ToolStripMenuItem"
        Me.X768ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.X768ToolStripMenuItem.Text = "1024 x 768"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.FullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'ResizeFullWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(824, 514)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ResizeFullWeb"
        Me.Text = "Form1"
        Me.UseWaitCursor = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RefleshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResizeScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X480ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X600ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X768ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As ToolStripMenuItem
End Class
