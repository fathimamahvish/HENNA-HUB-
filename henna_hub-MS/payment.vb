Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class payment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        QR.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("THANKS FOR PLACING THE ORDER")
        MessageBox.Show("KINDLY RATE US SERVICE")
        feedback.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SUBMISSION.Show()
        Me.Hide()
    End Sub

End Class
