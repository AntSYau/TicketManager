Public Class addTicket
    Dim film As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If filmList.Text = "(None)" Then
            MessageBox.Show("请先选择影片", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("New Ticket:" & vbCrLf &
        " Film: " & film & vbCrLf & " Scenario:  " & sceText.Text & vbCrLf & " Perform:  " &
        perText.Text & vbCrLf & " Camera:   " & camText.Text & vbCrLf & " Process:   " & proText.Text &
        vbCrLf & " Crosscut: " & croText.Text & vbCrLf & " Music:      " & musText.Text & vbCrLf & " Prop:         " &
        propText.Text & vbCrLf & " Costume: " & cosText.Text, "Add Ticket", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then Exit Sub
        ticket(sceText.Text, perText.Text, camText.Text, proText.Text, croText.Text,
               musText.Text, propText.Text, cosText.Text, film)
        getfilms()
        sceText.Text = 0
        perText.Text = 0
        camText.Text = 0
        proText.Text = 0
        croText.Text = 0
        musText.Text = 0
        propText.Text = 0
        cosText.Text = 0
        sceText.Select()
    End Sub

    Private Sub addTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getfilms()
        sceText.Select()
    End Sub

    Private Sub filmList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filmList.SelectedIndexChanged
        film = filmList.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If filmList.Text = "(None)" Then
            MessageBox.Show("请先选择影片", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        mainModule.listtickets(filmList.Text)
        manageTickets.Show()
    End Sub

    Private Sub cosText_KeyDown(sender As Object, e As KeyEventArgs) Handles cosText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub sceText_KeyDown(sender As Object, e As KeyEventArgs) Handles sceText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub perText_KeyDown(sender As Object, e As KeyEventArgs) Handles perText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub camText_KeyDown(sender As Object, e As KeyEventArgs) Handles camText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub proText_KeyDown(sender As Object, e As KeyEventArgs) Handles proText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub croText_KeyDown(sender As Object, e As KeyEventArgs) Handles croText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub musText_KeyDown(sender As Object, e As KeyEventArgs) Handles musText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub propText_KeyDown(sender As Object, e As KeyEventArgs) Handles propText.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub filmList_KeyDown(sender As Object, e As KeyEventArgs) Handles filmList.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub
End Class