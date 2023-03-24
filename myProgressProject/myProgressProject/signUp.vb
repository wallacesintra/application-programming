Imports System.Data.OleDb

Public Class signUp

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBxEmployeeId.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
0:
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private employeeObj As New Employees
    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
        Dim userName As String = txtBxUserName.Text
        Dim employeeId As String = txtBxEmployeeId.Text
        Dim userPass As String = txtBxPassword.Text

        Dim employeeObj As New Employees
        employeeObj.Name = userName
        employeeObj.EmployeeId = employeeId
        employeeObj.Password = userPass

        If chckBxAgree.Checked Then
            MessageBox.Show("Hello " & employeeObj.Name)

            'Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\YourUsername\Documents\YourDatabase.mdb;"
            'Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb;"
            'Dim conn As New OleDbConnection(connString)
            'conn.Open()

            'Create insert command
            'Dim cmd As New OleDbCommand("INSERT INTO employees (Name, Password, ID) VALUES (@Name, @Password, @ID)", conn)
            'Add parameters to the command
            'cmd.Parameters.AddWithValue("@Name", userName)
            'cmd.Parameters.AddWithValue("@Password", employeeId)
            'cmd.Parameters.AddWithValue("@ID", userPass)

            'Execute the command
            'cmd.ExecuteNonQuery()

            'Close the connection
            'conn.Close()
            'Display message box to inform user that registration was successful
            'MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim logIn As New logIn()
            logIn.ShowDialog()

        Else
            MessageBox.Show("Please agree with the terms and conditions")
        End If




    End Sub
    Public ReadOnly Property NewUserObject As Employees
        Get
            Return employeeObj
        End Get
    End Property

    Private Sub signUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class