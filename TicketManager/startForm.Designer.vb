<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addFilmButton = New System.Windows.Forms.Button()
        Me.addTicketButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addFilmButton
        '
        Me.addFilmButton.Location = New System.Drawing.Point(12, 12)
        Me.addFilmButton.Name = "addFilmButton"
        Me.addFilmButton.Size = New System.Drawing.Size(122, 43)
        Me.addFilmButton.TabIndex = 0
        Me.addFilmButton.Text = "添加影片 (&F)"
        Me.addFilmButton.UseVisualStyleBackColor = True
        '
        'addTicketButton
        '
        Me.addTicketButton.Location = New System.Drawing.Point(143, 12)
        Me.addTicketButton.Name = "addTicketButton"
        Me.addTicketButton.Size = New System.Drawing.Size(122, 43)
        Me.addTicketButton.TabIndex = 1
        Me.addTicketButton.Text = "添加选票 (&T)"
        Me.addTicketButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "管理影片 (&M)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "关于 (&A)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'startForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(277, 118)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addTicketButton)
        Me.Controls.Add(Me.addFilmButton)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "startForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addFilmButton As Button
    Friend WithEvents addTicketButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
