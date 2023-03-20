Imports WindowsApplication1.signUp

Public Class logIn
    Private Function GetUserCredentials() As Employees
        ' Retrieve the username and password from the sign-in page
        Dim userId As String = txtBxEmployeeIdLog.Text
        Dim password As String = txtBxPasswordLog.Text


        ' Create a new UserCredentials object and set its properties
        Dim userCreds1 As New Employees
        userCreds1.password = password
        userCreds1.EmployeeId = userId
        userCreds1.JobTitle = ""

        ' Return the UserCredentials object
        Return userCreds1
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click

        ' Retrieve the UserCredentials object that was created earlier
        Dim userCreds As Employees = GetUserCredentials()

        ' Retrieve the username and password from the UserCredentials object
        Dim userId As String = userCreds.employeeID
        Dim password As String = userCreds.Password
        Dim jobTitle As String = userCreds.JobTitle

        Dim userIdLog As String = txtBxEmployeeIdLog.Text
        Dim userPassLog As String = txtBxPasswordLog.Text
        ' Check if the username and password are valid
        If userIdLog = userId AndAlso userPassLog = password Then
            ' The username and password are valid, so log in the user
            ' Put your code to log in here
            If chckBoxEmployee.Checked Then
                jobTitle = "Employeee"
                Dim employeeUI As New employeesInterface()
                employeeUI.ShowDialog()
                employeeUI.Employee = signUp.NewUserObject
            ElseIf chckBoxManager.Checked Then
                jobTitle = "Training Managers"
                Dim trainerUi As New trainingManager
                trainerUi.ShowDialog()
            Else
                MessageBox.Show("Please select your job title")
            End If


        Else
            ' The username and password are not valid, so show an error message
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub


    Private Sub chckBoxemployeeTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chckBoxEmployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckBoxEmployee.CheckedChanged

    End Sub

    Private Sub logIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class