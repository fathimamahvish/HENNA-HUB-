Imports Microsoft.Data.SqlClient

Public Class CUST_DETAILS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim QUERY = "SELECT * FROM register"
        Using con = New SqlConnection("Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True")
            Using cmd = New SqlCommand(QUERY, con)
                Using sda As New SqlDataAdapter
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class