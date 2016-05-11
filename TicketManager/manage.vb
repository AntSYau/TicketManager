
Public Class manageFilmForm
    Private Sub manageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getfilms()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Try
            deletefilm(ListBox1.SelectedItem.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        MessageBox.Show("Please click [Add Film] from the start form, enter the " & vbCrLf _
                        & "exact film name and enter the currect information.", "Entry Closed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainModule.consult()
    End Sub
End Class