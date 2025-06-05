<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(31, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 29)
        Button1.TabIndex = 0
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGray
        Button2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(22, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 29)
        Button2.TabIndex = 1
        Button2.Text = "CUSTOMER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightGray
        Button3.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(244, 370)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 29)
        Button3.TabIndex = 2
        Button3.Text = "ADMIN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightGray
        Button4.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Location = New Point(439, 370)
        Button4.Name = "Button4"
        Button4.Size = New Size(101, 29)
        Button4.TabIndex = 3
        Button4.Text = "RESET"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightGray
        Button5.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Location = New Point(629, 370)
        Button5.Name = "Button5"
        Button5.Size = New Size(101, 29)
        Button5.TabIndex = 4
        Button5.Text = "EXIT"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(211, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 21)
        Label1.TabIndex = 5
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(211, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 21)
        Label2.TabIndex = 6
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        TextBox1.ForeColor = SystemColors.ActiveCaptionText
        TextBox1.Location = New Point(388, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "ENTER YOUR USERNAME.."
        TextBox1.Size = New Size(254, 28)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightGray
        TextBox2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic)
        TextBox2.ForeColor = SystemColors.ActiveCaptionText
        TextBox2.Location = New Point(388, 197)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "ENTER YOUR PASSWORD..."
        TextBox2.Size = New Size(254, 28)
        TextBox2.TabIndex = 8
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "LOGIN"
        Text = "LOGIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
