Public Class Form1
    Private Sub btnstartspam_Click(sender As Object, e As EventArgs) Handles btnstartspam.Click
        timerspam.Enabled = True
        timerspam.Interval = timerinterval.Text
        timerspam.Start()
    End Sub

    Private Sub timerspam_Tick(sender As Object, e As EventArgs) Handles timerspam.Tick
        SendKeys.Send(txtname.Text)
        Delay(1)
        SendKeys.Send("{ENTER}")
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub btnstopspam_Click(sender As Object, e As EventArgs) Handles btnstopspam.Click
        timerspam.Enabled = False
        timerspam.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
