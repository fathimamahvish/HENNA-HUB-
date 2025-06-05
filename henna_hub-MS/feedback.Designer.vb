<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedback
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
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(130, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 66)
        Label1.TabIndex = 0
        Label1.Text = "FEEDBACK PANEL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label2.Location = New Point(170, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 24)
        Label2.TabIndex = 1
        Label2.Text = "RATINGS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label3.Location = New Point(160, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 24)
        Label3.TabIndex = 2
        Label3.Text = "COMMENTS"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        TextBox1.Location = New Point(341, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 32)
        TextBox1.TabIndex = 3
        TextBox1.Text = "? / 10"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        TextBox2.Location = New Point(341, 195)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "enter your experience"
        TextBox2.Size = New Size(177, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button1.Location = New Point(84, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 55)
        Button1.TabIndex = 5
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button2.Location = New Point(289, 329)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 55)
        Button2.TabIndex = 6
        Button2.Text = "SUBMIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button3.Location = New Point(496, 329)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 55)
        Button3.TabIndex = 7
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button4.Location = New Point(12, 16)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 8
        Button4.Text = "BACK"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(716, 439)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "feedback"
        Text = "feedback"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
