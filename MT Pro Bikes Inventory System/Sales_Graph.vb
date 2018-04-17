Imports System.Data.OleDb

Public Class Sales_Graph
    Dim cnn As New OleDb.OleDbConnection
    Public Property username As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub pcbx_back_Click(sender As Object, e As EventArgs) Handles pcbx_back.Click
        Dim obj As New Sales
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    Private Sub SalesGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
    End Sub
    Private Sub btnShowGraphs_Click(sender As Object, e As EventArgs) Handles btnShowGraphs.Click
        Chart1.Series.Add("Supplier")

        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        cnn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(receipt_gross) as total FROM mtpro_receipts WHERE supplier = 'SPANK'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Supplier").Points.AddXY("SPANK", dr("total").ToString)
        End While
        dr.Close()
        cmd.Dispose()

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT SUM(receipt_gross) as total FROM mtpro_receipts WHERE supplier = 'FUNN'", cnn)
        Dim dr3 As OleDbDataReader = cmd3.ExecuteReader
        While dr3.Read
            Chart1.Series("Supplier").Points.AddXY("FUNN", dr3("total").ToString)
        End While
        dr3.Close()
        cmd3.Dispose()

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT SUM(receipt_gross) as total FROM mtpro_receipts WHERE supplier = 'HOPE'", cnn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
        While dr2.Read
            Chart1.Series("Supplier").Points.AddXY("HOPE", dr2("total").ToString)
        End While
        dr2.Close()
        cmd2.Dispose()

        cnn.Close()
    End Sub
End Class