<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(499, 66)
        Label1.TabIndex = 0
        Label1.Text = "PAYMENT PANEL"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label3.Location = New Point(90, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 24)
        Label3.TabIndex = 2
        Label3.Text = "SELECT THE MODE OF PAYMENT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label4.Location = New Point(104, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 24)
        Label4.TabIndex = 3
        Label4.Text = "PAYMENT DATE"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        RadioButton1.Location = New Point(324, 137)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(63, 28)
        RadioButton1.TabIndex = 5
        RadioButton1.Text = "CASH"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        RadioButton2.Location = New Point(324, 176)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(77, 28)
        RadioButton2.TabIndex = 6
        RadioButton2.Text = "ONLINE"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(324, 252)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(196, 32)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button1.Location = New Point(52, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 49)
        Button1.TabIndex = 9
        Button1.Text = "QR CODE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button2.Location = New Point(215, 342)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 49)
        Button2.TabIndex = 10
        Button2.Text = "NEXT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button3.Location = New Point(376, 342)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 49)
        Button3.TabIndex = 11
        Button3.Text = "RESET"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button4.Location = New Point(543, 342)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 49)
        Button4.TabIndex = 12
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button5.Location = New Point(12, 12)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 13
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(700, 428)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "payment"
        Text = "payment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
