Public Class addFilmForm
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        If posterTextBox.Text <> "" And othersTextBox.Text <> "" And nameTextBox.Text <> "" Then
            addfilm(nameTextBox.Text.ToString, datePicker.Value, posterTextBox.Text, othersTextBox.Text)
        Else
            MessageBox.Show("Invalid input.", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        getfilms()
    End Sub
End Class