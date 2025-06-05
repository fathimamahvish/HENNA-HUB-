Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class summary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton5.Checked = True Then
            TextBox1.Text = "$100"
        ElseIf RadioButton6.Checked = True Then
            TextBox1.Text = "$200"
        ElseIf RadioButton7.Checked = True Then
            TextBox1.Text = "$300"
        ElseIf RadioButton8.Checked = True Then
            TextBox1.Text = "$400"
        ElseIf RadioButton9.Checked = True Then
            TextBox1.Text = "$500"
        ElseIf RadioButton10.Checked = True Then
            TextBox1.Text = "$600"
        Else
            TextBox1.Text = "Please select a value"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SUBMISSION.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DESIGN.Show()
        Me.Hide()
    End Sub
End Class