Public Class courseUI
    Private _courseName As String
    Private _coursePath As String

    Public Sub New(ByVal courseName As String, ByVal coursePath As String)
        InitializeComponent()
        _courseName = courseName
        _coursePath = coursePath
    End Sub

    Private Sub CourseViewerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set the form's title to the course name
        Me.Text = _courseName

        ' Load the course document into the web browser control
        If IO.File.Exists(_coursePath) Then
            WebBrowser1.Navigate(_coursePath)
        Else
            MessageBox.Show("Course document not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
End Class