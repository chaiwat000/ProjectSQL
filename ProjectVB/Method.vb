Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module Method
    'เคลื่อนย้ายFromNone
    Public isBegin As Boolean
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    'ตัวแปรเชื่อมต่อ DB
    Public strCn As String = ConfigurationManager.ConnectionStrings("ProjectVB.My.MySettings.strcn").ConnectionString
    Public con As New SqlConnection(strCn)
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public cmd As SqlCommand
    Public DR As SqlDataReader
    Public sql As String
    Public DT As DataTable


    Public status As String

    Public Sub connect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Public Sub clearText()
        With frmEmployee
            .txtID.Clear()
            .txtIdCard.Clear()
            .txtName.Clear()
            .txtlastname.Clear()
            .txtUser.Clear()
            .txtPass.Clear()
            .txtMail.Clear()
            .txtTel.Clear()
            .txtAdress.Clear()


        End With
    End Sub

    Public Sub closeText()
        With frmEmployee
            .txtID.Enabled = False
            .txtIdCard.Enabled = False
            .txtlastname.Enabled = False
            .txtName.Enabled = False
            .txtUser.Enabled = False
            .txtPass.Enabled = False
            .txtTel.Enabled = False
            .DateTime1.Enabled = False
            .txtMail.Enabled = False
            .txtAdress.Enabled = False
            .GroupBox1.Enabled = False

            .btnSelectPic.Enabled = False
            .btnSave.Enabled = False
            .btnCancel.Enabled = False
        End With
    End Sub

    Public Sub openText()
        With frmEmployee
            .txtID.Enabled = True
            .txtIdCard.Enabled = True
            .txtlastname.Enabled = True
            .txtName.Enabled = True
            .txtUser.Enabled = True
            .txtPass.Enabled = True
            
            .DateTime1.Enabled = True
            .txtMail.Enabled = True
            .txtAdress.Enabled = True
            .GroupBox1.Enabled = True

            .btnSelectPic.Enabled = True
            .btnSave.Enabled = True
            .btnCancel.Enabled = True
        End With
    End Sub


End Module

