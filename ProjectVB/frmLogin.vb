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
            sql = "select count(*) from employees where emp_user = '" & txtUsername.Text & "'AND emp_pass ='" & txtPassword.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteScalar()

            If cmd.ExecuteScalar <= 0 Then
                MsgBox("เข้าสู่ระบบโดยพนักงานล้มเหลว")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Select()
            Else
                MsgBox("เข้าสู่ระบบโดยพนักงานสำเร็จ")
                frmMain.Show()
                frmMain.btnEmp.Enabled = False


                With frmMain
                    .menushowLevel.Text = "EMPLOYEE"
                    .menushowUser.Text = txtUsername.Text
                End With
                Me.Hide()
                radEmployee.Checked = False
            End If



        Else
            If txtUsername.Text = My.Settings.username And txtPassword.Text = My.Settings.pass Then
                MessageBox.Show("เข้าสู่ระบบด้วย Adminministator สำเร็จ")
                With frmMain
                    .menushowLevel.Text = "ADMINMINISTATOR"
                    .menushowUser.Text = txtUsername.Text
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

    Private Sub linkRegis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegis.LinkClicked
        frmRegis.Show()
        Me.Hide()
    End Sub


End Class
