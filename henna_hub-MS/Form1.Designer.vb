<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightPink
        Label1.Font = New Font("Algerian", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(35, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(749, 34)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO HENNA - HUB MANAGEMENT SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightPink
        Label2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(659, 564)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 24)
        Label2.TabIndex = 1
        Label2.Text = "BY"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LightPink
        Label3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(659, 602)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 24)
        Label3.TabIndex = 2
        Label3.Text = "FATHIMA MAHVISH"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightPink
        Button1.Font = New Font("Berlin Sans FB", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.Navy
        Button1.Location = New Point(279, 119)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 116)
        Button1.TabIndex = 3
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightPink
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Font = New Font("Berlin Sans FB", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.Navy
        Button2.Location = New Point(279, 290)
        Button2.Name = "Button2"
        Button2.Size = New Size(228, 116)
        Button2.TabIndex = 4
        Button2.Text = "REGISTER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightPink
        Button3.Font = New Font("Berlin Sans FB", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.Navy
        Button3.Location = New Point(279, 454)
        Button3.Name = "Button3"
        Button3.Size = New Size(228, 116)
        Button3.TabIndex = 5
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.R1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(809, 635)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
