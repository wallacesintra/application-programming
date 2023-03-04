Public Class Window1
    Dim name As String = "Wallace"

    Dim nameLabel As Label = CType(Me.FindName("employeeName"), Label)
    nameLabel.Content = name

End Class
