
Imports Microsoft.Data.SqlClient
Public Class LOGIN
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Use "localhost" instead of "FNM\SQLEXPRESS" if unsure about the instance
            Using con As New SqlConnection("Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True")
                Dim command As New SqlCommand("SELECT * FROM register WHERE username = @username AND password = @password", con)

                ' Add parameters safely
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable

                adapter.Fill(table)

                If table.Rows.Count <= 0 Then
                    MessageBox.Show("Username or password are invalid", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DESIGN.Show()
                    Me.Hide()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "fathima" And TextBox2.Text = "admin" Then
            MessageBox.Show("WELCOME FATHIMA !!")
        Else
            MessageBox.Show("INVALID LOGIN !!")
        End If
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class