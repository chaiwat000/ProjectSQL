Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module Method
    'เคลื่อนย้ายFromNone
    Public isBegin As Boolean
    Public MouseDownX As Integer
    Public MouseDownY As Integer

    'ตัวแปรเชื่อมต่อ DB
    Public strCon As String = ConfigurationManager.ConnectionStrings("ProjectVB.My.MySettings.strcon").ConnectionString
    Public con As New SqlConnection(strCon)
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public cmd As SqlCommand
    Public DR As SqlDataReader
    Public sql As String
    Public DT As DataTable
    Public RD As SqlDataReader

    Public Sub connect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Public Function _Datatable()
        DA = New SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function
End Module
