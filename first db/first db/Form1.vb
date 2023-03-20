Imports System.Data.OleDb
Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnId.Click
        ' Dim conn As New OleDbConnection
        'conn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb")
        ' conn.Open()
        'Dim strsql As String
        'strsql = "SELECT ID,Last Name,First Name,Gender FROM employees WHERE ID=" + 0 + ""
        'strsql = "SELECT ID, [Last Name], [First Name], Gender FROM employees WHERE ID = '+ 0 +'"
        'Dim cmd As New OleDbCommand(strsql, conn)
        'Dim myreader As OleDbDataReader
        'myreader = cmd.ExecuteReader
        'myreader.Read()
        'lblFirstName.Text = myreader("First Name")
        'lblLastName.Text = myreader("Last Name")
        'lblGender.Text = myreader("Gender")
        'Dim command As New OleDbCommand(strsql)
        'command.Connection = New OleDbConnection(conn)


        'conn.Close()
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb"
        'Dim query As String = "SELECT ID, [Last Name], [First Name], Gender FROM employees WHERE ID = '+ 0 +'"
        Dim query As String = "SELECT [Last Name] FROM employees WHERE ID ='+ 0 +' "
        Dim command As New OleDbCommand(query)

        command.Connection = New OleDbConnection(connectionString)
        command.Connection.Open()
        Dim columnValue As String = command.ExecuteScalar()
        command.Connection.Close()
        lblFirstName.Text = columnValue
        'lblLastName.Text = myreader("Last Name")
        'lblGender.Text = myreader("Gender")
        command.Dispose()
        command.Connection.Dispose()
    End Sub
End Class
