Public Class frmLogin

    Private Sub lbltitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lbltitle.MouseDown
        If e.Button = MouseButtons.Left Then
            isBegin = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub lbltitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lbltitle.MouseUp
        If e.Button = MouseButtons.Left Then
            isBegin = False
        End If
    End Sub

    Private Sub lbltitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lbltitle.MouseMove
        If isBegin Then
            Dim temp As Point = New Point()
            temp.X = Location.X + (e.X - MouseDownX)
            temp.Y = Location.Y + (e.Y - MouseDownY)
            Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connect()

        If txtUsername.Text.Trim() = "" And txtPassword.Text.Trim() = "" Then
            MessageBox.Show("กรุณากรอกข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If radEmployee.Checked = True Then

            sql = "select * from Employee where emp_username = '" & txtUsername.Text & "'AND emp_password ='" & txtPassword.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            Dim value As String = cmd.ExecuteScalar
            If value < 0 Then
                MsgBox("เข้าสู่ระบบโดยพนักงานล้มเหลว")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Select()
            Else
                MsgBox("เข้าสู่ระบบโดยพนักงานสำเร็จ")
                status = "emp"
                frmMain.Show()
                frmMain.btnEmp.Enabled = False



                sql = "select * from Employee where emp_username = '" & txtUsername.Text & "'And emp_password = '" & txtPassword.Text & "'"
                DA = New SqlClient.SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                DT = DS.Tables("table")

                With frmMain
                    .menushowLevel.Text = "EMPLOYEE"
                    .menushowUser.Text = txtUsername.Text
                    .lblshowname.Text = dt.Rows(0)("emp_name")
                End With

                With frmSale
                    .lblLevel.Text = "EMPLOYEE"
                    .lblName.Text = dt.Rows(0)("emp_name")
                End With

                Me.Hide()
                radEmployee.Checked = False
            End If

        Else

            If txtUsername.Text = My.Settings.username And txtPassword.Text = My.Settings.pass Then
                MessageBox.Show("เข้าสู่ระบบด้วย Adminministator สำเร็จ")
                status = "add"
                With frmMain
                    .menushowLevel.Text = "ADMINMINISTATOR"
                    .menushowUser.Text = txtUsername.Text
                    .lblshowname.Visible = False
                    .ToolStripLabel4.Visible = False
                End With
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("เข้าสู่ระบบด้วย Adminministator ล้มเหลว")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Select()
            End If
        End If
    End Sub

    Private Sub chkShowHidePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowHidePassword.CheckedChanged
        If chkShowHidePassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
