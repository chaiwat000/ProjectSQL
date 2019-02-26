Public Class frmEmployee
    Dim emp_id As String
    Dim emp_user As String
    Dim emp_idcard As String

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        sql = "select emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,IIF(emp_gender=1,'ชาย','หญิง') As เพศ,emp_pic from Employee "
        DA = New SqlClient.SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        dgdv1.DataSource = DS.Tables("table")
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        Call closeText()
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "select emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,emp_gender,emp_pic from Employee where emp_id like '%" & txtSearch.Text & "%' OR emp_name like '%" & txtSearch.Text & "%'"
        DA = New SqlClient.SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        dgdv1.DataSource = DS.Tables("table")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUser.Text.Trim = "" And txtPass.Text.Trim = "" And txtName.Text.Trim = "" And txtlastname.Text.Trim = "" And txtAdress.Text.Trim = "" And txtMail.Text.Trim = "" And txtTel.Text.Trim = "" And txtIdCard.Text.Trim = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If

        Dim gender As Boolean
        If radmale.Checked = True Then
            gender = True
        Else
            gender = False
        End If

        connect()

        If status = "pluse" Then
            sql = "select emp_id from Employee where emp_id =@eid"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("eid", txtID.Text)
            DR = cmd.ExecuteReader
            If DR.HasRows Then
                MsgBox("id มีแล้ว")
                DR.Close()
                Exit Sub
            End If
            DR.Close()

            sql = "select emp_username from Employee where emp_username = @user"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("user", txtUser.Text)
            DR = cmd.ExecuteReader
            If DR.HasRows Then
                MsgBox("username มีแล้ว")
                DR.Close()
                Exit Sub
            End If
            DR.Close()



            sql = "select emp_idcard from Employee where emp_idcard = @idcard"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("idcard", txtIdCard.Text)
            DR = cmd.ExecuteReader
            If DR.HasRows Then
                MsgBox("idcard มีแล้ว")
                DR.Close()
                Exit Sub
            End If
            DR.Close()


            sql = "insert into Employee (emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,emp_gender,emp_pic) values(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)"

            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()

            With cmd.Parameters
                .AddWithValue("0", txtID.Text)
                .AddWithValue("1", txtIdCard.Text)
                .AddWithValue("2", txtUser.Text)
                .AddWithValue("3", txtPass.Text)
                .AddWithValue("4", txtName.Text)
                .AddWithValue("5", txtlastname.Text)
                .AddWithValue("6", DateTime1.Value)
                .AddWithValue("7", txtAdress.Text)
                .AddWithValue("8", txtMail.Text)
                .AddWithValue("9", txtTel.Text)
                .AddWithValue("10", gender)

            End With

            Dim mem As New IO.MemoryStream
            picEmp.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic() As Byte
            pic = mem.ToArray()
            cmd.Parameters.AddWithValue("11", pic)

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("add fail")
            Else
                sql = "select emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,IIF(emp_gender=1,'ชาย','หญิง') As เพศ,emp_pic from Employee"
                DA = New SqlClient.SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dgdv1.DataSource = DS.Tables("table")
                MsgBox("add success")

                Call clearText()
            End If

        Else

            emp_id = txtID.Text
            emp_idcard = txtIdCard.Text
            emp_user = txtUser.Text

            If emp_id <> txtID.Text Then
                sql = "select emp_id from Employee where emp_id =@eid"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("eid", txtID.Text)
                DR = cmd.ExecuteReader
                If DR.HasRows Then
                    MsgBox("ไอดีซ้ำ")
                    DR.Close()
                    Exit Sub
                End If
                DR.Close()
            End If


            If emp_idcard <> txtIdCard.Text Then
                sql = "select emp_idcard from Employee where emp_idcard =@eidcard"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("eidcard", txtUser.Text)
                DR = cmd.ExecuteReader
                If DR.HasRows Then
                    MsgBox("idcard ดีซ้ำ")
                    DR.Close()
                    Exit Sub
                End If
                DR.Close()
            End If


            If emp_user <> txtUser.Text Then
                sql = "select emp_username from Employee where emp_username =@euser"
                cmd = New SqlClient.SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("euser", txtUser.Text)
                DR = cmd.ExecuteReader
                If DR.HasRows Then
                    MsgBox("username ซ้ำ")
                    DR.Close()
                    Exit Sub
                End If
                DR.Close()
            End If


            sql = "update Employee set emp_id=@0, emp_idcard=@1, emp_username=@2, emp_password=@3, emp_name=@4, emp_lname=@5, emp_born=@6, emp_address=@7, emp_email=@8, emp_tel=@9, emp_gender=@10, emp_pic=@11 where emp_id = @id"
            cmd = New SqlClient.SqlCommand(sql, con)
            With cmd.Parameters
                .AddWithValue("0", txtID.Text)
                .AddWithValue("1", txtIdCard.Text)
                .AddWithValue("2", txtUser.Text)
                .AddWithValue("3", txtPass.Text)
                .AddWithValue("4", txtName.Text)
                .AddWithValue("5", txtlastname.Text)
                .AddWithValue("6", DateTime1.Value)
                .AddWithValue("7", txtAdress.Text)
                .AddWithValue("8", txtMail.Text)
                .AddWithValue("9", txtTel.Text)
                .AddWithValue("10", gender)

            End With

            Dim mem As New IO.MemoryStream
            picEmp.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic() As Byte
            pic = mem.ToArray()
            cmd.Parameters.AddWithValue("11", pic)

            cmd.Parameters.AddWithValue("id", emp_id)
            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("edit fail")
            Else
                sql = "select emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,IIF(emp_gender=1,'ชาย','หญิง') As เพศ,emp_pic from Employee"
                DA = New SqlClient.SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dgdv1.DataSource = DS.Tables("table")
                MsgBox("edit success")

                Call clearText()
            End If


        End If
        Call clearText()
        Call closeText()
        ToolStrip1.Enabled = True
    End Sub

    Private Sub dgdv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdv1.CellClick
        connect()

        Dim i As Integer = dgdv1.CurrentRow.Index
        Dim emp_id As String = dgdv1.Item(0, i).Value
        sql = "select * from Employee where emp_id = '" & emp_id & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        txtID.Text = dgdv1.Item(0, i).Value
        txtIdCard.Text = dgdv1.Item(1, i).Value
        txtUser.Text = dgdv1.Item(2, i).Value
        txtPass.Text = dgdv1.Item(3, i).Value
        txtName.Text = dgdv1.Item(4, i).Value
        txtlastname.Text = dgdv1.Item(5, i).Value

        txtAdress.Text = dgdv1.Item(7, i).Value
        txtMail.Text = dgdv1.Item(8, i).Value
        txtTel.Text = dgdv1.Item(9, i).Value



        If dgdv1.Item(10, i).Value = "ชาย" Then
            radmale.Checked = True
        Else
            radFemale.Checked = True
        End If

        Dim img() As Byte = dgdv1.Item(11, i).Value
        picEmp.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call closeText()
        ToolStrip1.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        connect()
        status = "pluse"
        Call openText()
        Call clearText()
        txtID.Select()
        txtTel.Enabled = True
        ToolStrip1.Enabled = False
        picEmp.Image = Nothing
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connect()
        status = "edit"
        Call openText()
        txtTel.Enabled = True
        txtID.Select()
        ToolStrip1.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()
        Dim i As Integer = dgdv1.CurrentRow.Index
        Dim delete As String = dgdv1.Item(0, i).Value
        sql = "delete from Employee where emp_id ='" & delete & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("delete fail")
        Else

            sql = "select emp_id,emp_idcard,emp_username,emp_password,emp_name,emp_lname,emp_born,emp_address,emp_email,emp_tel,IIF(emp_gender=1,'ชาย','หญิง') As เพศ,emp_pic from Employee "
            DA = New SqlClient.SqlDataAdapter(sql, con)
            DS = New DataSet
            DA.Fill(DS, "table")
            dgdv1.DataSource = DS.Tables("table")

            MsgBox("delete success")
        End If
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim imge As Image
            imge = Image.FromFile(OpenFileDialog1.FileName)
            picEmp.Image = imge
        End If
    End Sub
End Class