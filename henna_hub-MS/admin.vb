Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CUST_DETAILS.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REPORT.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class