Public Class startForm
    Private Sub addFilmButton_Click(sender As Object, e As EventArgs) Handles addFilmButton.Click
        addFilmForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        manageFilmForm.Show()
    End Sub

    Private Sub addTicketButton_Click(sender As Object, e As EventArgs) Handles addTicketButton.Click
        addTicket.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("TicketManager Online version 0.3 Beta CHN by @AntSYau", "Hello World!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub startForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("本程序需要互联网连接。", "欢迎", MessageBoxButtons.OK, MessageBoxIcon.Information)
        addFilmButton.Enabled = False
        manageFilmForm.deleteButton.Enabled = False
    End Sub
End Class
