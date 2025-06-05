<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(141, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 53)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME FATHIMA"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button1.Location = New Point(80, 103)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 63)
        Button1.TabIndex = 1
        Button1.Text = "CUST-DETAILS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button2.Location = New Point(278, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(148, 63)
        Button2.TabIndex = 2
        Button2.Text = "REPORT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button3.Location = New Point(472, 307)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 63)
        Button3.TabIndex = 3
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold)
        Button4.Location = New Point(0, 1)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 4
        Button4.Text = "BACK"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(659, 381)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "admin"
        Text = "admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
