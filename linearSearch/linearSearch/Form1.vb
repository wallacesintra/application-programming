Public Class Form1

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim fruits(4) As String
        fruits(0) = "Banana"
        fruits(1) = "Apple"
        fruits(2) = "Pineapple"
        fruits(3) = "Orange"
        fruits(4) = "Mango"

        Dim target As String = txtBoxSearch.Text
        Dim i As Integer
        Dim found As Boolean

        For i = 0 To 4
            If fruits(i) = target Then
                found = True
            End If
        Next

        If found = True Then
            MsgBox("Found")
        Else
            MsgBox("Not found")
        End If


    End Sub
End Class
