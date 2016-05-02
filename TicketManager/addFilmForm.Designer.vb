<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addFilmForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.posterTextBox = New System.Windows.Forms.TextBox()
        Me.othersTextBox = New System.Windows.Forms.TextBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "影片名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "上交日期"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "海报加分"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 50)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "其他加分"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(97, 13)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(310, 28)
        Me.nameTextBox.TabIndex = 1
        '
        'posterTextBox
        '
        Me.posterTextBox.Location = New System.Drawing.Point(339, 83)
        Me.posterTextBox.Name = "posterTextBox"
        Me.posterTextBox.Size = New System.Drawing.Size(68, 28)
        Me.posterTextBox.TabIndex = 7
        Me.posterTextBox.Text = "0"
        '
        'othersTextBox
        '
        Me.othersTextBox.Location = New System.Drawing.Point(339, 47)
        Me.othersTextBox.Name = "othersTextBox"
        Me.othersTextBox.Size = New System.Drawing.Size(68, 28)
        Me.othersTextBox.TabIndex = 5
        Me.othersTextBox.Text = "0"
        '
        'datePicker
        '
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(97, 47)
        Me.datePicker.MaxDate = New Date(2099, 5, 1, 0, 0, 0, 0)
        Me.datePicker.MinDate = New Date(2016, 3, 1, 0, 0, 0, 0)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(151, 28)
        Me.datePicker.TabIndex = 3
        Me.datePicker.Value = New Date(2016, 4, 1, 0, 0, 0, 0)
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(18, 79)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(230, 35)
        Me.submitButton.TabIndex = 8
        Me.submitButton.Text = "提交 (&S)"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'addFilmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 126)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.othersTextBox)
        Me.Controls.Add(Me.posterTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "addFilmForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Film"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents posterTextBox As TextBox
    Friend WithEvents othersTextBox As TextBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents submitButton As Button
End Class
