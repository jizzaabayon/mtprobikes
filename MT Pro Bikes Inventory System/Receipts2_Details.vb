Imports System.Data.OleDb

Public Class Receipts2_Details
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim datareader As OleDbDataReader
    Public Property username As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub Receipts2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
        Application.StartupPath & "\MTProBikes.accdb"
        txtbxSearch.Select()
        SetupListView()

        dt.Columns.Add("Code", Type.GetType("System.String"))
        dt.Columns.Add("Description", Type.GetType("System.String"))
        dt.Columns.Add("Cost", Type.GetType("System.Decimal"))
        dt.Columns.Add("Quantity", Type.GetType("System.Int32"))
        dt.Columns.Add("Total", Type.GetType("System.Decimal"))
        GridViewCart.DataSource = dt
    End Sub
    Private Sub SetupListView()
        listview_products.Columns.Add("Product Code", 100)
        listview_products.Columns.Add("Description", 180)
        listview_products.Columns.Add("Qty", 30)
        listview_products.Columns.Add("Price", 45)
        txtbxReceipt_No.Text = GenerateRandom(6)
        Retrieve()
    End Sub
    'CALL DATABASE DETAILS
    Private Sub Retrieve()
        listview_products.Items.Clear()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM mtpro_products", cnn)
        cnn.Open()
        datareader = cmd.ExecuteReader()
        If datareader.HasRows Then
            While datareader.Read
                Dim newitem As New ListViewItem()
                newitem.Text = datareader.GetValue(0)
                newitem.SubItems.Add(datareader.GetValue(1))
                newitem.SubItems.Add(datareader.GetValue(4))
                newitem.SubItems.Add(datareader.GetValue(3))
                listview_products.Items.Add(newitem)
            End While
        End If
        cnn.Close()
    End Sub
    'GENERATE RANDOM
    Public Function GenerateRandom(ByVal len As Integer)
        Dim pool As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXVCBNM1234567890"
        Dim nn As New Random
        Dim result As String
        Dim cc = 0
        While cc < len
            result &= pool(nn.Next(0, pool.Length))
            cc += 1
        End While
        Return result
    End Function
    'FIXED COLUMN SIZE
    Private Sub listview_products_ColumnWidthChanging(ByVal Sender As Object, ByVal E As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles listview_products.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2}
        For Each DCol As Integer In DisableColumns
            If E.ColumnIndex = DCol Then
                E.Cancel = True
                E.NewWidth = listview_products.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    'SEARCH PRODUCTS
    Private Sub txtbxSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxSearch.KeyPress
        If e.KeyChar = vbCr Then
            If (txtbxSearch.Text = String.Empty) Then
                MessageBox.Show("NO PRODUCTS SEARCHED.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                listview_products.Items.Clear()
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '%" & txtbxSearch.Text & "%' ORDER BY prod_code ASC", cnn)
                cnn.Open()
                datareader = cmd.ExecuteReader()
                If datareader.HasRows Then
                    While datareader.Read
                        Dim newitem As New ListViewItem()
                        newitem.Text = datareader.GetValue(0)
                        newitem.SubItems.Add(datareader.GetValue(1))
                        newitem.SubItems.Add(datareader.GetValue(4))
                        newitem.SubItems.Add(datareader.GetValue(3))
                        listview_products.Items.Add(newitem)
                    End While
                Else
                    MessageBox.Show("PRODUCT NOT IN DATABASE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cnn.Close()
            End If
        End If
    End Sub
    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        listview_products.Items.Clear()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '%" & txtbxSearch.Text & "%' ORDER BY prod_code ASC", cnn)
        cnn.Open()
        datareader = cmd.ExecuteReader()
        While datareader.Read
            Dim newitem As New ListViewItem()
            newitem.Text = datareader.GetValue(0)
            newitem.SubItems.Add(datareader.GetValue(1))
            newitem.SubItems.Add(datareader.GetValue(4))
            newitem.SubItems.Add(datareader.GetValue(3))
            listview_products.Items.Add(newitem)
        End While
        cnn.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim obj As New Receipts2
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    'LISTING TO TEXTBOX
    Private Sub listview_products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_products.SelectedIndexChanged
        If listview_products.SelectedItems.Count > 0 Then
            txtbxCode.Text = listview_products.SelectedItems(0).Text
            txtbxDescr.Text = listview_products.SelectedItems(0).SubItems(1).Text
            txtbxCost.Text = listview_products.SelectedItems(0).SubItems(3).Text
            txtbxQty.Clear()
            txtbxPrice.Clear()
        End If
    End Sub
    'COMPUTE PRODUCT TOTAL PRICE
    Private Sub txtbxQty_TextChanged(sender As Object, e As EventArgs) Handles txtbxQty.TextChanged
        If txtbxQty.Text = String.Empty Then
            txtbxPrice.Text = ""
        Else
            Dim cost As Decimal = Convert.ToDecimal(txtbxCost.Text)
            Dim qty As Int32 = Convert.ToInt32(txtbxQty.Text)
            txtbxPrice.Text = qty * cost
        End If
    End Sub
    Private Sub txtbxqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxQty.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("ENTER NUMBERS ONLY.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        ElseIf e.KeyChar = vbCr Then
            MessageBox.Show("ENTER NUMBERS ONLY.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'DISABLE GROUPBOX1
    Private Sub ClearGB1()
        txtbxCode.Clear()
        txtbxDescr.Clear()
        txtbxCost.Clear()
        txtbxQty.Clear()
        txtbxPrice.Clear()
    End Sub
    'DISABLE GROUPBOX2
    Private Sub ClearGB2()
        txtbxTotalQty.Clear()
        txtbxGross.Clear()
        txtbxDiscountP.Clear()
        txtbxDiscount.Clear()
        txtbxNet.Clear()
        txtbxVat.Clear()
        txtbxTotal.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    End Sub

    Private Sub btnAddtoCart_Click(sender As Object, e As EventArgs) Handles btnAddtoCart.Click
        If txtbxQty.Text = "" Then
            MessageBox.Show("PLEASE ENTER QUANTITY.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dt.Rows.Add(txtbxCode.Text, txtbxDescr.Text, txtbxCost.Text, txtbxQty.Text, txtbxPrice.Text)
            GridViewCart.DataSource = dt
            ClearGB1()
        End If
    End Sub
End Class