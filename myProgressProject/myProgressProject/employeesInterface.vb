Imports WindowsApplication1.signUp

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
        'profileImg.Image = My.Resources.maleProfileAvatar
        profileImg.Image = My.Resources.femaleProfileAvatar

        lblUserName.Text = _employee.Name
        'GenderLabel.Text = Employee.Gender
        'lblUserId.Text = Employee.EmployeeId.ToString()
        lblUserId.Text = _employee.EmployeeId
        lblUserTitle.Text = _employee.JobTitle

    End Sub

    Private Sub btnViewCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCourse.Click
        Dim course As New courseUI
        course.ShowDialog()
    End Sub
End Class