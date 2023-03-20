Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConn As MySqlConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection

    End Sub
End Class