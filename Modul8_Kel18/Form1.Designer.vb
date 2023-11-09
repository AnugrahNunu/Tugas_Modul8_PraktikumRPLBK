<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button13 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(294, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 15)
        Label1.TabIndex = 0
        Label1.Text = "Temperature Input Kelompok 18"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(308, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "C To F"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(3, 90)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "F To C"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(462, 72)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 42)
        Button3.TabIndex = 0
        Button3.Text = "Konversi"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button13)
        Panel1.Controls.Add(Button12)
        Panel1.Controls.Add(Button11)
        Panel1.Controls.Add(Button10)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(565, 72)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(81, 357)
        Panel1.TabIndex = 4
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(3, 293)
        Button12.Name = "Button12"
        Button12.Size = New Size(75, 23)
        Button12.TabIndex = 12
        Button12.Text = "K To F"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(3, 264)
        Button11.Name = "Button11"
        Button11.Size = New Size(75, 23)
        Button11.TabIndex = 11
        Button11.Text = "K To C"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(3, 235)
        Button10.Name = "Button10"
        Button10.Size = New Size(75, 23)
        Button10.TabIndex = 10
        Button10.Text = "R To K"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(3, 206)
        Button9.Name = "Button9"
        Button9.Size = New Size(75, 23)
        Button9.TabIndex = 9
        Button9.Text = "R To F"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(3, 177)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 23)
        Button8.TabIndex = 8
        Button8.Text = "R To C"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(3, 148)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 7
        Button7.Text = "F To K"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(3, 119)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 6
        Button6.Text = "F To R"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(3, 61)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 5
        Button5.Text = "C To R"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(3, 32)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 4
        Button4.Text = "C To K"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(3, 322)
        Button13.Name = "Button13"
        Button13.Size = New Size(75, 23)
        Button13.TabIndex = 13
        Button13.Text = "K To R"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
End Class
