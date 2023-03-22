Imports System.Data.OleDb
Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim conn As New OleDbConnection
        ' conn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb")
        'conn.Open()
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


        'working
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb"
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()
        'Dim command As New OleDbCommand("SELECT * FROM employees", connection) --- select all
        'Dim command As New OleDbCommand("SELECT * FROM employees WHERE ID = 3", connection) -- id

        Dim id As Integer = 3
        'Dim idValue As Integer = Integer.Parse(textBox1.Text)
        Dim command As New OleDbCommand("SELECT * FROM employees WHERE ID = @id", connection)
        command.Parameters.AddWithValue("@id", id)

        Dim reader As OleDbDataReader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            lblFirstName.Text = reader("Last Name").ToString()
            lblLastName.Text = reader("First Name").ToString()
            lblGender.Text = reader("Gender").ToString

            '..
        End If
        reader.Close()
        connection.Close()

    End Sub

    Private Sub btnId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnId.Click


    End Sub
End Class
