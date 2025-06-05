Imports Microsoft.Data.SqlClient

Public Class REGISTER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = New SqlConnection("Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True")
        Dim cmd = New SqlCommand("INSERT INTO [dbo].[register]
           ([name]
           ,[address]
           ,[gender]
           ,[phone]
           ,[email]
           ,[country]
           ,[username]
           ,[password])
     VALUES
           ('" + txtName.Text + "','" + address.Text + "','" + gender.SelectedItem.ToString() + "','" + phone.Text + "','" + email.Text + "','" + country.SelectedItem.ToString() + "','" + username.Text + "','" + password.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("REGISTRATION SUCCESFULL", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        DESIGN.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class