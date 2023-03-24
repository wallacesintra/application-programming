Imports WindowsApplication1.signUp
Imports System.Data.OleDb

Public Class logIn

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        Dim userIdLog As String = txtBxEmployeeIdLog.Text
        Dim userPassLog As String = txtBxPasswordLog.Text

        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb;"
        Dim conn As New OleDbConnection(connString)
        Dim cmd As New OleDbCommand()
        Dim reader As OleDbDataReader

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM employees WHERE ID = @ID AND Password = @Password"
        cmd.Parameters.AddWithValue("@ID", userIdLog)
        cmd.Parameters.AddWithValue("@Password", userPassLog)
        cmd.Connection = conn

        Try
            conn.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                MsgBox("Login successful!")
                ' TODO: Navigate to the next form or do other actions for logged in user
                If chckBoxEmployee.Checked Then
                    Dim command As New OleDbCommand("SELECT * FROM employees WHERE ID = @id", conn)
                    command.Parameters.AddWithValue("@id", userIdLog)
                    Dim reader1 As OleDbDataReader = command.ExecuteReader()
                    If reader1.HasRows Then
                        reader1.Read()
                        Dim employeeUI As New employeesInterface()
                        employeeUI.lblUserName.Text = reader1("Name").ToString()
                        employeeUI.lblUserId.Text = reader1("ID").ToString()
                        employeeUI.lblUserTitle.Text = reader1("Title").ToString()
                        employeeUI.ShowDialog()


                    End If
                    reader.Close()
                    conn.Close()

                ElseIf chckBoxManager.Checked Then
                    Dim command As New OleDbCommand("SELECT * FROM employees WHERE ID = @id", conn)
                    command.Parameters.AddWithValue("@id", userIdLog)
                    Dim reader1 As OleDbDataReader = command.ExecuteReader()
                    If reader1.HasRows Then
                        reader1.Read()
                        Dim trainerUi As New trainingManager
                        trainerUi.lblUserName.Text = reader1("Name").ToString()
                        trainerUi.lblUserId.Text = reader1("ID").ToString()
                        trainerUi.lblUserTitle.Text = reader1("Title").ToString()
                        Dim managerKey As Integer = 2023
                        Dim managerKeyInput As Integer = InputBox("Enter Manager Key No: ")
                        If managerKey = managerKeyInput Then
                            trainerUi.ShowDialog()
                        End If
                    End If

                Else
                    MessageBox.Show("Please select your job title")
                End If
            Else
                MsgBox("Invalid ID or password.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub chckBoxemployeeTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chckBoxEmployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckBoxEmployee.CheckedChanged

    End Sub

    Private Sub logIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class