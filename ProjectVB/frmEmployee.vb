Public Class frmEmployee


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        connect()

        If txtUser.Text = "" Or txtPass.Text = "" Or txtName.Text = "" Or txtlastname.Text = "" Or txtAdress.Text = "" Or txtMail.Text = "" Or txtTel.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If

        sql = "select count(*) from employees where emp_user ='" & txtUser.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        If cmd.ExecuteScalar > 0 Then
            MsgBox("username มีแล้ว")
            Exit Sub
        End If

        sql = "insert into Employees (emp_user,emp_pass,emp_name,emp_lastname,emp_born,emp_add,emp_email,emp_tel) values(@0,@1,@2,@3,@4,@5,@6,@7)"

        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.Parameters.Clear()

        With cmd.Parameters
            .AddWithValue("0", txtUser.Text)
            .AddWithValue("1", txtPass.Text)
            .AddWithValue("2", txtName.Text)
            .AddWithValue("3", txtlastname.Text)
            .AddWithValue("4", DateTime1.Value)
            .AddWithValue("5", txtAdress.Text)
            .AddWithValue("6", txtMail.Text)
            .AddWithValue("7", txtTel.Text)

        End With



        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("add fail")
        Else
            MsgBox("add success")

            sql = "select max(emp_id) from employees "
            cmd = New SqlClient.SqlCommand(sql, con)
            Try
                txtID.Text = cmd.ExecuteScalar + 1
            Catch ex As Exception
                txtID.Text = "1100"
            End Try

            sql = "select * from employees "
            DA = New SqlClient.SqlDataAdapter(sql, con)
            DS = New DataSet
            DA.Fill(DS, "table")
            dgdv1.DataSource = DS.Tables("table")

            txtUser.Text = ""
            txtPass.Text = ""
            txtName.Text = ""
            txtlastname.Text = ""

            txtAdress.Text = ""
            txtMail.Text = ""
            txtTel.Text = ""

        End If

    End Sub



    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * from employees "
        DA = New SqlClient.SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        dgdv1.DataSource = DS.Tables("table")

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()
        Dim i As Integer = dgdv1.CurrentRow.Index
        Dim delete As String = dgdv1.Item(0, i).Value
        sql = "delete from employees where emp_id ='" & delete & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("delete fail")
        Else
            MsgBox("delete success")

            sql = "select * from employees "
            DA = New SqlClient.SqlDataAdapter(sql, con)
            DS = New DataSet
            DA.Fill(DS, "table")
            dgdv1.DataSource = DS.Tables("table")


        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        connect()

        If txtUser.Text.Trim = "" And txtPass.Text.Trim = "" And txtName.Text.Trim = "" And txtlastname.Text.Trim = "" And txtAdress.Text.Trim = "" And txtMail.Text.Trim = "" And txtTel.Text.Trim = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If

        Dim sure As DialogResult = MessageBox.Show("คุณต้องการบันทึกการแก้ไขหรือไม่", "คุณแน่ใจหรือไม่", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If sure = DialogResult.Yes Then

            sql = "update employees set emp_user=@1, emp_pass=@2, emp_name=@3, emp_lastname=@4, emp_born=@5, emp_add=@6, emp_email=@7, emp_tel=@8 where emp_id=@id"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("1", txtUser.Text)
                .AddWithValue("2", txtPass.Text)
                .AddWithValue("3", txtName.Text)
                .AddWithValue("4", txtlastname.Text)
                .AddWithValue("5", DateTime1.Value)
                .AddWithValue("6", txtAdress.Text)
                .AddWithValue("7", txtMail.Text)
                .AddWithValue("8", txtTel.Text)
                .AddWithValue("id", txtID.Text)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("edit fail")
            Else
                MsgBox("edit success")

                sql = "select * from employees "
                DA = New SqlClient.SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dgdv1.DataSource = DS.Tables("table")
            End If
        Else
            txtUser.Text = ""
            txtPass.Text = ""
            txtName.Text = ""
            txtlastname.Text = ""
            DateTime1.Value = ""
            txtAdress.Text = ""
            txtMail.Text = ""
            txtTel.Text = ""

        End If
    End Sub

    Private Sub dgdv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdv1.CellDoubleClick
        connect()

        Dim i As Integer = dgdv1.CurrentRow.Index
        Dim emp_id As String = dgdv1.Item(0, i).Value
        sql = "select * from employees where emp_id = '" & emp_id & "'"

        txtID.Text = dgdv1.Item(0, i).Value
        txtUser.Text = dgdv1.Item(1, i).Value
        txtPass.Text = dgdv1.Item(2, i).Value
        txtName.Text = dgdv1.Item(3, i).Value
        txtlastname.Text = dgdv1.Item(4, i).Value

        txtAdress.Text = dgdv1.Item(6, i).Value
        txtMail.Text = dgdv1.Item(7, i).Value
        txtTel.Text = dgdv1.Item(8, i).Value

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "select emp_user,emp_pass,emp_name,emp_lastname,emp_born,emp_add,emp_email,emp_tel from employees where emp_id like '%" & txtSearch.Text & "%' OR emp_name like '%" & txtSearch.Text & "%'"
        DA = New SqlClient.SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        dgdv1.DataSource = DS.Tables("table")
    End Sub


End Class