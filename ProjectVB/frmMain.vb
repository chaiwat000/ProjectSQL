Public Class frmMain

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


    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Dim out As DialogResult
        out = MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "แจ้งเตือนจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If out = DialogResult.Yes Then

            Me.Close()

        End If
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menushowDate.Text = Date.Now

    End Sub

    Private Sub menuEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        frmEmployee.Show()

        frmEmployee.MdiParent = Me
    End Sub
End Class