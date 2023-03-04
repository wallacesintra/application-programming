Public Class logSignPage

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titleLabel.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim logIn As New logIn()
        logIn.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim signUp As New signUp()
        signUp.ShowDialog()
    End Sub
End Class
