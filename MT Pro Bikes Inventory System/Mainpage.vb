Public Class Mainpage

    Public Property username As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
    End Sub
    '    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Dim obj As New Help
    '        obj.username = lblUsername.Text
    '    Me.Hide()
    '        obj.Show()
    '    End Sub
    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        Dim obj As New AboutUs
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub LOGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGSToolStripMenuItem.Click
        Dim obj As New Logs
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub pcbx_products_Click(sender As Object, e As EventArgs) Handles pcbx_products.Click
        Dim obj As New Products
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub pcbx_receipts_Click(sender As Object, e As EventArgs) Handles pcbx_receipts.Click
        Dim obj As New Receipts
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub pcbx_calendar_Click(sender As Object, e As EventArgs)
        Dim obj As New Calendar
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub pcbx_sales_Click(sender As Object, e As EventArgs) Handles pcbx_sales.Click
        Dim obj As New Sales
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub pcbx_accounts_Click(sender As Object, e As EventArgs) Handles pcbx_accounts.Click
        Dim obj As New Accounts_Adm
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub

    Private Sub pcbx_receipts2_Click(sender As Object, e As EventArgs) Handles pcbxCalendar.Click
        Dim obj As New Receipts2
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
End Class