Imports System.Data.OleDb


Public Class Logs
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
    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        RefreshDataGrid()
    End Sub

    Private Sub RefreshDataGrid()
        da = New OleDbDataAdapter("Select * from mtpro_logs'", cnn)
        dt = New DataTable
        da.Fill(dt)
        GridViewLogs.DataSource = dt
        With GridViewLogs
            .Columns(0).HeaderCell.Value = "Log ID"
            .Columns(1).HeaderCell.Value = "Time Executed"
            .Columns(2).HeaderCell.Value = "Username"
            .Columns(3).HeaderCell.Value = "Changes Executed"
            .Columns(0).Width = 150
            .Columns(1).Width = 233
            .Columns(2).Width = 200
            .Columns(3).Width = 517
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        da.Fill(ds)
        ds = New DataSet
        RefreshDataGrid()
    End Sub
End Class