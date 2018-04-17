Imports System.Data.OleDb

Public Class Receipts2
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
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

    Private Sub Receipts2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
        Application.StartupPath & "\MTProBikes.accdb"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New Receipts2_Details
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
End Class