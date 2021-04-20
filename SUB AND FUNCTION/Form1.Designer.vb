<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(235, 101)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Button1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(455, 106)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(51, 17)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Label1"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(173, 184)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 2
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(345, 182)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "Button2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(548, 188)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(51, 17)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Label2"
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(189, 268)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 5
        Me.Btn3.Text = "Button3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(454, 273)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(51, 17)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "Label3"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(173, 362)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 7
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(344, 362)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 23)
        Me.Btn4.TabIndex = 8
        Me.Btn4.Text = "Button4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(548, 365)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(51, 17)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents lbl3 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Btn4 As Button
    Friend WithEvents lbl4 As Label
End Class
