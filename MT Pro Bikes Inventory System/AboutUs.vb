Public Class AboutUs
    Public Property username As String
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub pcbx_back_Click(sender As Object, e As EventArgs) Handles pcbx_back.Click
        Dim obj As New Mainpage
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub AboutUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
    End Sub
End Class