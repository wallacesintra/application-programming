Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtBxName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBxName.TextChanged

    End Sub

    Private Sub btnWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWelcome.Click
        Dim name As String = txtBxName.Text
        Dim Message As String = greet(name)
        MsgBox(Message)
    End Sub

    Function greet(ByVal nme As String) As String
        Dim msg As String = "welcome " & nme
        Return msg
    End Function
End Class
