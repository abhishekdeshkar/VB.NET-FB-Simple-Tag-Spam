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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnstartspam = New System.Windows.Forms.Button()
        Me.btnstopspam = New System.Windows.Forms.Button()
        Me.timerspam = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerinterval = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(181, 68)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(380, 22)
        Me.txtname.TabIndex = 1
        '
        'btnstartspam
        '
        Me.btnstartspam.Location = New System.Drawing.Point(72, 111)
        Me.btnstartspam.Name = "btnstartspam"
        Me.btnstartspam.Size = New System.Drawing.Size(187, 62)
        Me.btnstartspam.TabIndex = 2
        Me.btnstartspam.Text = "Start Spam"
        Me.btnstartspam.UseVisualStyleBackColor = True
        '
        'btnstopspam
        '
        Me.btnstopspam.Location = New System.Drawing.Point(265, 111)
        Me.btnstopspam.Name = "btnstopspam"
        Me.btnstopspam.Size = New System.Drawing.Size(187, 62)
        Me.btnstopspam.TabIndex = 3
        Me.btnstopspam.Text = "Stop Spam"
        Me.btnstopspam.UseVisualStyleBackColor = True
        '
        'timerspam
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Interval in Millisecond :"
        '
        'timerinterval
        '
        Me.timerinterval.Location = New System.Drawing.Point(181, 26)
        Me.timerinterval.Name = "timerinterval"
        Me.timerinterval.Size = New System.Drawing.Size(380, 22)
        Me.timerinterval.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 219)
        Me.Controls.Add(Me.timerinterval)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnstopspam)
        Me.Controls.Add(Me.btnstartspam)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tag Spam by Abhishek Deshkar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnstartspam As Button
    Friend WithEvents btnstopspam As Button
    Friend WithEvents timerspam As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents timerinterval As TextBox
End Class
