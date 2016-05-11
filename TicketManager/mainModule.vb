Imports MySql.Data.MySqlClient

Module mainModule
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim cnStr As String = "Server=103.27.76.66;User Id=sau;Password=password;Database=filmdata"

    Public Sub startup()
        Try
            cn = New MySqlConnection(cnStr)
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub excute(cmd As MySqlCommand)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub getfilms()
        Try
            manageFilmForm.ListBox1.Items.Clear()
            addTicket.filmList.Items.Clear()
            startup()
            Dim sql As String = "select fName from filmName"
            Dim cmd As New MySqlCommand(sql, cn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            Do While myreader.Read
                manageFilmForm.ListBox1.Items.Add(myreader(0))
                addTicket.filmList.Items.Add(myreader(0))
            Loop
            myreader.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub deletefilm(n As String)
        startup()
        Dim sql As String = "delete from filmName where fName='" & n & "'"
        Dim cmd As New MySqlCommand(sql, cn)
        excute(cmd)
        sql = "DROP TABLE `" & n & "`"
        cmd = New MySqlCommand(sql, cn)
        excute(cmd)
        cn.Close()
        getfilms()
    End Sub

    Public Sub addfilm(n As String, d As Date, p As Integer, o As Integer)
        startup()
        Dim dt As String = Format(d, "yyyy/MM/dd")
        Dim sql As String = "SELECT fName from filmName where fName='" & n & "'"
        Dim cmd As New MySqlCommand(sql, cn)
        Dim myreader As MySqlDataReader = cmd.ExecuteReader
        Dim a As Integer = 0
        Try
            myreader.Read()
            Dim b As String = myreader(0)
            myreader.Close()
        Catch ex As Exception
            a = 1
        End Try
        myreader.Close()
        myreader.Dispose()
        If a = 0 Then
            addFilmForm.Text = "Edit Film"
            sql = "UPDATE `filmName` SET dateSubmitted='" & dt & "', hasPoster='" & p & "', others='" & o & "' WHERE fName='" & n & "'"
            cmd = New MySqlCommand(sql, cn)
            excute(cmd)
            MessageBox.Show("Edited Film " & n)
            Exit Sub
        End If
        addFilmForm.Text = "Add Film"
        sql = "INSERT INTO `filmName` (`fName`,`dateSubmitted`,`hasPoster`,`others`) VALUES ('" & n & "','" & dt & "','" & p & "','" & o & "')"
        cmd = New MySqlCommand(sql, cn)
        excute(cmd)
        cn.Close()
        cn.Open()
        sql = "CREATE TABLE `" & n & "`(scenario numeric(3,1),perform numeric(3,1),camera numeric(3,1)," &
            "process numeric(3,1),crosscut numeric(3,1),music numeric(3,1),prop numeric(3,1),costume numeric(3,1))"
        cmd = New MySqlCommand(sql, cn)
        excute(cmd)
        cn.Close()
        getfilms()
        MessageBox.Show("Added Film " & n)
    End Sub

    Public Sub ticket(Sce As Integer, Per As Integer, Cam As Integer,
                      Pro As Integer, Cro As Integer, Mus As Integer,
                      Prop As Integer, Cos As Integer, f As String)
        startup()
        Try
            Dim sql As String = "INSERT INTO `" & f & "` (scenario,perform," &
            "camera,process,crosscut,music,prop,costume) VALUES ('" & Sce &
            "','" & Per & "','" & Cam & "','" & Pro & "','" & Cro & "','" &
            Mus & "','" & Prop & "','" & Cos & "')"
            Dim cmd As New MySqlCommand(sql, cn)
            excute(cmd)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        cn.Close()
    End Sub

    Public Sub listtickets(film As String)
        Try
            startup()
            Dim sql As String = "select * from `" & film & "`"
            da = New MySqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds)
            manageTickets.DataGridView1.DataSource = ds.Tables(0)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub consult()
        startup()
        Dim cn1 As New MySqlConnection
        cn1 = New MySqlConnection(cnStr)
        cn1.Open()
        Dim sql As String = "select fName from filmName"
        Dim fields(8) As String
        fields = {"scenario", "perform", "camera", "process", "crosscut", "music", "prop", "costume"}
        Dim cmd As New MySqlCommand(sql, cn)
        Dim myreader As MySqlDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        Dim sql1 As String
        Dim cmd1 As New MySqlCommand
        Do While myreader.Read
            ''sql1 = "insert into `filmStat`(filmName) values (" & myreader(0) & ""
            cmd1 = New MySqlCommand(sql1, cn1)
            excute(cmd1)
            sql1 = "update `filmStat` set scenario = (select avg(scenario) from `" & myreader(0) & "`," &
                "perform = (Select avg(perform) from `" & myreader(0) & "`)," &
                "camera = (select avg(camera) from `" & myreader(0) & "`)," &
                "process = (select avg(process) from `" & myreader(0) & "`)," &
                "crosscut = (select avg(crosscut) from `" & myreader(0) & "`)," &
                "music = (select avg(music) from `" & myreader(0) & "`)," &
                "prop = (select avg(prop) from `" & myreader(0) & "`)," &
                "costume = (select avg(costume) from `" & myreader(0) & "`) where filmName = '" & myreader(0) & "'"
            cmd1 = New MySqlCommand(sql1, cn1)
            excute(cmd1)
        Loop
        cn1.Close()
        cn.Close()
    End Sub
End Module

