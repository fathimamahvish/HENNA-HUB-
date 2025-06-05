Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient

Public Class BillForm

    Dim connectionString As String = "Data Source=FM\SQLEXPRESS01;Initial Catalog=MEHENDI;Integrated Security=True;Trust Server Certificate=True"
    Dim billData As New List(Of String)
    Dim WithEvents pd As New PrintDocument

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLatestBillData()
        pd.Print() ' Automatically print the bill
    End Sub

    Private Sub LoadLatestBillData()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT TOP 1 * FROM booking ORDER BY date DESC"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        billData.Clear()
                        billData.Add("----- HENNA HUB BILL -----")
                        billData.Add(" ")
                        billData.Add("Name: " & reader("name").ToString())
                        billData.Add("Phone: " & reader("phone").ToString())
                        billData.Add("Address: " & reader("address").ToString())
                        billData.Add("Category: " & reader("category").ToString())
                        billData.Add("Design: " & reader("design").ToString())
                        billData.Add("Date: " & Convert.ToDateTime(reader("date")).ToShortDateString())
                        billData.Add("Total Price: ₹" & reader("price").ToString())
                        billData.Add(" ")
                        billData.Add("Thank you for choosing Henna Hub!")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim yPos As Integer = 100
        Dim leftMargin As Integer = 100
        Dim font As New Font("Arial", 12)

        For Each line As String In billData
            e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos)
            yPos += 30
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        feedback.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        payment.Show()
        Me.Hide()
    End Sub
End Class