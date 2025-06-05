Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient
Public Class SUBMISSION

    ' Submit/Insert Booking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Basic validation
        If ComboBox1.SelectedItem Is Nothing OrElse ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both category and design type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database connection
        Dim con As New SqlConnection("Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True")
        Dim query As String = "INSERT INTO [dbo].[booking] (name, phone, address, category, design, date, price) VALUES (@name, @phone, @address, @category, @design, @date, @price)"
        Dim cmd As New SqlCommand(query, con)

        ' Add parameters
        cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim())
        cmd.Parameters.AddWithValue("@phone", TextBox2.Text.Trim())
        cmd.Parameters.AddWithValue("@address", TextBox3.Text.Trim())
        cmd.Parameters.AddWithValue("@category", ComboBox1.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@design", ComboBox2.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)
        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(TextBox4.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("ORDER PLACED SUCCESSFULLY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        ' Show payment form
        payment.Show()
        Me.Hide()
    End Sub

    ' Search Booking (Filter by name and date)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "SELECT * FROM booking WHERE name = @name AND date >= @startDate AND date < @endDate"

        Using con As New SqlConnection("Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True")
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim())
                cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.Date)
                cmd.Parameters.AddWithValue("@endDate", DateTimePicker1.Value.Date.AddDays(1))

                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    DataGridView1.DataSource = dt

                    If dt.Rows.Count > 0 Then
                        Dim billForm As New BillForm()
                        billForm.DataGridView1.DataSource = dt
                        billForm.Show()
                    Else
                        MessageBox.Show("No matching booking found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Clear Input Fields
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    ' Go to Summary Page
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        summary.Show()
        Me.Hide()
    End Sub

    ' Auto-fill Price Based on Design Code
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim designCode As String = ComboBox2.SelectedItem.ToString()
        Select Case designCode
            Case "DT01", "DA01", "DM01", "DF01"
                TextBox4.Text = "100"
            Case "DT02", "DA02", "DM02", "DF02"
                TextBox4.Text = "200"
            Case "DT03", "DA03", "DM03", "DF03"
                TextBox4.Text = "300"
            Case "DT04", "DA04", "DM04", "DF04"
                TextBox4.Text = "400"
            Case "DT05", "DA05", "DM05", "DF05"
                TextBox4.Text = "500"
            Case Else
                TextBox4.Text = ""
        End Select
    End Sub

    ' Populate Design ComboBox
    Private Sub SUBMISSION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.AddRange(New String() {
            "DT01", "DT02", "DT03", "DT04", "DT05",
            "------------------------------------",
            "DA01", "DA02", "DA03", "DA04", "DA05",
            "------------------------------------",
            "DM01", "DM02", "DM03", "DM04", "DM05",
            "------------------------------------",
            "DF01", "DF02", "DF03", "DF04", "DF05"
        })
    End Sub
End Class
