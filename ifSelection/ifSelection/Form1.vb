Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreet.Click
        Dim country As String
        country = txtCountry.Text

        If country = "Kenya" Then
            MsgBox("Habari")
        ElseIf country = "England" Then
            MsgBox("Hello")
        Else
            MsgBox("Good Morning")

        End If
    End Sub
End Class
