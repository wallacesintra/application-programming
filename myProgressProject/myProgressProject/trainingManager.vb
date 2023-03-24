Public Class trainingManager

    Private Sub trainingManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        profileImg.Image = My.Resources.maleProfileAvatar
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\database1\dblectures.mdb;"
        Dim query As String = "SELECT ID, Name FROM employees ORDER BY Name"
        Dim dt As New DataTable()

        Using conn As New OleDb.OleDbConnection(connString)
            Using cmd As New OleDb.OleDbCommand(query, conn)
                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        For Each row As DataRow In dt.Rows
            lstStaff.Items.Add(row("Name").ToString())
        Next
    End Sub
    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class