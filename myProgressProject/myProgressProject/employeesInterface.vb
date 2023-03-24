Imports WindowsApplication1.signUp
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Public Class employeesInterface

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
    Private _employee As Employees
    Public Property Employee As Employees
        Get
            Return _employee
        End Get
        Set(ByVal value As Employees)
            _employee = value
        End Set
    End Property

    Private Sub employeesInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        profileImg.Image = My.Resources.maleProfileAvatar
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb;"
        Dim query As String = "SELECT courseID, courseName, content FROM Courses ORDER BY courseName"
        Dim dt As New DataTable()

        Using conn As New OleDb.OleDbConnection(connString)
            Using cmd As New OleDb.OleDbCommand(query, conn)
                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        For Each row As DataRow In dt.Rows
            lstCourses.Items.Add(row("courseName").ToString())
        Next

    End Sub


    Private Sub btnViewCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnViewCourse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCourse.Click
        ' Open the selected course in a new window
        If lstCourses.SelectedIndex <> -1 Then
            Dim courseName As String = lstCourses.SelectedItem.ToString()
            Dim coursePath As String = ""

            ' Retrieve the path for the selected course
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb;"
            Dim query As String = "SELECT content FROM Courses WHERE courseName=@name"
            Dim dt As New DataTable()

            Using conn As New OleDb.OleDbConnection(connString)
                Using cmd As New OleDb.OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", courseName)
                    conn.Open()
                    coursePath = cmd.ExecuteScalar().ToString()
                End Using
            End Using

            ' Open the course viewer form passing the course name and path
            Dim viewerForm As New courseUI(courseName, coursePath)
            viewerForm.Show()
        End If
    End Sub
End Class