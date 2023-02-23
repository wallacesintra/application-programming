Public Class Form1

    Private Sub btnGrader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrader.Click
        Dim marks As Integer

        If IsNumeric(TxtMarks.Text) = True Then
            marks = CInt(TxtMarks.Text)
        Else
            MsgBox("Enter A Number!")
            Exit Sub
        End If

        If (marks < 0 Or marks > 100) Then
            MsgBox("Invalid score, enter a number between 0 and 100")
            Exit Sub
        ElseIf marks <= 20 Then
            MsgBox("GRADE F")
        ElseIf marks > 20 And marks <= 30 Then
            MsgBox("GRADE E")
        ElseIf marks > 30 And marks <= 40 Then
            MsgBox("GRADE D")
        ElseIf marks > 40 And marks <= 50 Then
            MsgBox("GRADE C")
        ElseIf marks > 50 And marks <= 70 Then
            MsgBox("GRADE B")
        ElseIf marks > 70 And marks <= 100 Then
            MsgBox("GRADE A")
        End If

    End Sub

    Private Sub TxtMarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMarks.TextChanged

    End Sub
End Class
