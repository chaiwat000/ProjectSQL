Public Class frmRegis
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
End Class