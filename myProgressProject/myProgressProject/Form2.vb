Imports WindowsApplication1.signUp
Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.Office.Interop.Access.Dao


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
        'Me.Text = _courseName
        lblCourseTitle.Text = _courseName
        'working
        WebBrowser1.Url = New Uri("D:\application programming(VB.net)\application-programming\myProgressProject\myProgressProject\Resources\courses\course1.htm")
        'WebBrowser1.Url = New Uri(_coursePath)
        ' Load the course document into the web browser control

        'If IO.File.Exists(_coursePath) Then
        'WebBrowser1.Navigate("file://" & _coursePath)
        'WebBrowser1.Navigate(New Uri(_coursePath).AbsoluteUri)
        'Else
        'MessageBox.Show("Course document not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Me.Close()
        'End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub lblCourseTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCourseTitle.Click

    End Sub
End Class