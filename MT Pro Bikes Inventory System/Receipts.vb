Imports System.Data.OleDb

Public Class Receipts
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
    '///// ENABLE FIELDS /////
    Private Function EnableFields()
        cmbxType.Enabled = True
        txtbxReceipt_No.Enabled = True
        datepickerDate.Enabled = True
        txtbxSupplier.Enabled = True
        txtbxCustomer.Enabled = True
        txtbxGross.Enabled = True
        txtbxNet.Enabled = True
        txtbxDiscount.Enabled = True
        txtbxTotal.Enabled = True
        Return 0
    End Function
    '///// DISABLE FIELDS /////
    Private Function DisableFields()
        cmbxType.Enabled = False
        txtbxReceipt_No.Enabled = False
        datepickerDate.Enabled = False
        txtbxSupplier.Enabled = False
        txtbxCustomer.Enabled = False
        txtbxGross.Enabled = False
        txtbxNet.Enabled = False
        txtbxDiscount.Enabled = False
        txtbxTotal.Enabled = False
        Return 0
    End Function
    '///// CLEAR FIELDS /////
    Private Function ClearFields()
        txtbxReceipt_No.Clear()
        txtbxSupplier.Clear()
        txtbxCustomer.Clear()
        txtbxGross.Clear()
        txtbxNet.Clear()
        txtbxDiscount.Clear()
        txtbxTotal.Clear()
        Return 0
    End Function
    '///// REFRESH DATAGRIDVIEW /////
    Private Sub RefreshDataGrid()
        da = New OleDbDataAdapter("Select * from mtpro_receipts'", cnn)
        dt = New DataTable
        da.Fill(dt)
        GridViewReceipts.DataSource = dt
        With GridViewReceipts
            .Columns(0).HeaderCell.Value = "  Receipt Type"
            .Columns(1).HeaderCell.Value = "Receipt No."
            .Columns(2).HeaderCell.Value = "Date"
            .Columns(3).HeaderCell.Value = "Supplier"
            .Columns(4).HeaderCell.Value = "Customer"
            .Columns(5).HeaderCell.Value = "Gross Sales"
            .Columns(6).HeaderCell.Value = "Net Sales"
            .Columns(7).HeaderCell.Value = "Discount"
            .Columns(8).HeaderCell.Value = "Total Price"
            .Columns(0).Width = 177
            .Columns(1).Width = 160
            .Columns(2).Width = 130
            .Columns(3).Width = 100
            .Columns(4).Width = 130
            .Columns(5).Width = 140
            .Columns(6).Width = 130
            .Columns(7).Width = 130
            .Columns(8).Width = 130
        End With
    End Sub
    '///// SHOWS RECEIPTS /////
    Private Sub Receipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
        Application.StartupPath & "\MTProBikes.accdb"
        RefreshDataGrid()
        DisableFields()
    End Sub
    '/////SEARCH RECEIPTS/////
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim table As New DataTable()
        Dim cmd As OleDbCommand
        Dim cmd2 As OleDbCommand
        Dim cmd3 As OleDbCommand
        Dim cmd4 As OleDbCommand

        cnn.Open()
        If (txtbxSearch.Text = "") Then
            MessageBox.Show("NO PRODUCTS SEARCHED.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cmbxSearch.SelectedIndex = 0 Then
                cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewReceipts.DataSource = table
                GridViewReceipts.Refresh()
            ElseIf cmbxSearch.SelectedIndex = 1 Then
                cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewReceipts.DataSource = table
                GridViewReceipts.Refresh()
            ElseIf cmbxSearch.SelectedIndex = 2 Then
                cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewReceipts.DataSource = table
                GridViewReceipts.Refresh()
            Else
                cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewReceipts.DataSource = table
                GridViewReceipts.Refresh()
            End If
        End If
        cnn.Close()
    End Sub
    Private Sub txtbxSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbxSearch.KeyPress
        If e.KeyChar = vbCr Then
            Dim table As New DataTable()
            Dim cmd As OleDbCommand
            Dim cmd2 As OleDbCommand

            Dim cmd3 As OleDbCommand
            Dim cmd4 As OleDbCommand

            cnn.Open()
            If (txtbxSearch.Text = "") Then
                MessageBox.Show("NO PRODUCTS SEARCHED.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If cmbxSearch.SelectedIndex = 0 Then
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_id] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewReceipts.DataSource = table
                    GridViewReceipts.Refresh()
                ElseIf cmbxSearch.SelectedIndex = 1 Then
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [receipt_type] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewReceipts.DataSource = table
                    GridViewReceipts.Refresh()
                ElseIf cmbxSearch.SelectedIndex = 2 Then
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [supplier] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewReceipts.DataSource = table
                    GridViewReceipts.Refresh()
                Else
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_receipts] WHERE [customer] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewReceipts.DataSource = table
                    GridViewReceipts.Refresh()
                End If
            End If
        End If
        cnn.Close()
    End Sub
    '///// SHOW DETAILS /////
    Private Sub GridViewReceipts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewReceipts.CellContentClick
        cmbxType.Text = GridViewReceipts.Item(0, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxReceipt_No.Text = GridViewReceipts.Item(1, GridViewReceipts.CurrentCell.RowIndex).Value
        datepickerDate.Text = GridViewReceipts.Item(2, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxSupplier.Text = GridViewReceipts.Item(3, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxCustomer.Text = GridViewReceipts.Item(4, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxGross.Text = GridViewReceipts.Item(5, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxNet.Text = GridViewReceipts.Item(6, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxDiscount.Text = GridViewReceipts.Item(7, GridViewReceipts.CurrentCell.RowIndex).Value
        txtbxTotal.Text = GridViewReceipts.Item(8, GridViewReceipts.CurrentCell.RowIndex).Value
    End Sub
    '///// ADDING RECEIPTS //////
    Private Sub pcbxAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Select Case btnAdd.Text
            Case "&ADD NEW"
                ClearFields()
                EnableFields()

                btnAdd.Text = "&SAVE"
                btnUpdate.Text = "C&LEAR FIELDS"
                btnDelete.Text = "&CANCEL"

            Case "&SAVE"
                da = New OleDbDataAdapter("INSERT INTO mtpro_receipts(receipt_type,receipt_id,receipt_date,supplier,customer,receipt_gross,receipt_net,receipt_discount,receipt_total) 
                                            VALUES('" & cmbxType.SelectedItem.ToString & "','" & txtbxReceipt_No.Text & "','" & datepickerDate.Value.Date & "',
                                                    '" & txtbxSupplier.Text & "','" & txtbxCustomer.Text & "','" & txtbxGross.Text & "','" & txtbxNet.Text & "',
                                                    '" & txtbxDiscount.Text & "','" & txtbxTotal.Text & "')", cnn)

                If cmbxType.SelectedItem = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmbxType.Focus()
                ElseIf txtbxReceipt_No.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxReceipt_No.Focus()
                ElseIf datepickerDate.Value = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    datepickerDate.Focus()
                ElseIf txtbxSupplier.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSupplier.Focus()
                ElseIf txtbxCustomer.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxCustomer.Focus()
                ElseIf txtbxGross.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxGross.Focus()
                ElseIf txtbxNet.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxNet.Focus()
                ElseIf txtbxDiscount.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxDiscount.Focus()
                ElseIf txtbxTotal.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxTotal.Focus()
                Else
                    Select Case MsgBox("Are you sure you want to Add?", MsgBoxStyle.OkCancel, "")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Added New Receipt')", cnn)
                            cmd2.ExecuteReader()
                            da.Fill(ds)
                            ds = New DataSet
                            RefreshDataGrid()
                            MsgBox("Added Successfully!", MsgBoxStyle.Information)
                            ClearFields()
                            DisableFields()
                            RefreshDataGrid()
                            btnAdd.Text = "&ADD NEW"
                            btnUpdate.Text = "&UPDATE"
                            btnDelete.Text = "&DELETE"
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
                End If
            Case "C&LEAR FIELDS"
                ClearFields()
        End Select
    End Sub
    '///// UPDATE RECEIPTS /////
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Select Case btnUpdate.Text
            Case "&UPDATE"
                If (txtbxReceipt_No.Text = "") Then
                    MessageBox.Show("NO SELECTED RECEIPT TO UPDATE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DisableFields()
                Else
                    EnableFields()
                    txtbxReceipt_No.Enabled = False

                    btnAdd.Text = "C&LEAR FIELDS"
                    btnUpdate.Text = "&SAVE UPDATE"
                    btnDelete.Text = "&CANCEL"
                End If

            Case "&SAVE UPDATE"
                da = New OleDbDataAdapter("UPDATE mtpro_receipts SET receipt_type = '" & cmbxType.SelectedItem.ToString & "', 
                                                                receipt_date = '" & datepickerDate.Value.Date & "', 
                                                                supplier = '" & txtbxSupplier.Text & "', 
                                                                customer = '" & txtbxCustomer.Text & "', 
                                                                receipt_gross = '" & txtbxGross.Text & "',
                                                                receipt_net = '" & txtbxNet.Text & "',
                                                                receipt_discount  = '" & txtbxDiscount.Text & "',
                                                                receipt_total = '" & txtbxTotal.Text & "'
                                                                WHERE receipt_id = '" & txtbxReceipt_No.Text & "'", cnn)

                If cmbxType.SelectedItem = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmbxType.Focus()
                ElseIf datepickerDate.Value = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    datepickerDate.Focus()
                ElseIf txtbxSupplier.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSupplier.Focus()
                ElseIf txtbxCustomer.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxCustomer.Focus()
                ElseIf txtbxGross.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxGross.Focus()
                ElseIf txtbxNet.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxNet.Focus()
                ElseIf txtbxDiscount.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxDiscount.Focus()
                ElseIf txtbxTotal.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxTotal.Focus()
                Else
                    Select Case MsgBox("    Are you sure you want to Update?", MsgBoxStyle.OkCancel, "UPDATE?")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Updated Receipts')", cnn)
                            cmd2.ExecuteReader()
                            da.Fill(ds)
                            ds = New DataSet
                            RefreshDataGrid()
                            MsgBox("Updated Successfully!", MsgBoxStyle.Information, "SUCCESS!")
                            ClearFields()
                            DisableFields()
                            btnAdd.Text = "&ADD NEW"
                            btnUpdate.Text = "&UPDATE"
                            btnDelete.Text = "&DELETE"
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
                End If
            Case "C&LEAR FIELDS"
                ClearFields()
        End Select
    End Sub
    '///// DELETE RECEIPTS /////
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case btnDelete.Text
            Case "&DELETE"
                If (txtbxReceipt_No.Text = "") Then
                    MessageBox.Show("NO SELECTED RECEIPTS TO DELETE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    da = New OleDbDataAdapter("DELETE FROM mtpro_receipts WHERE receipt_id= '" & txtbxReceipt_No.Text & "'", cnn)
                    Select Case MsgBox("    Are you sure you want to Delete?", MsgBoxStyle.OkCancel, "DELETE?")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Deleted Receipts')", cnn)
                            cmd2.ExecuteReader()
                            da.Fill(ds)
                            ds = New DataSet
                            RefreshDataGrid()
                            MsgBox("Deleted Successfully!", MsgBoxStyle.Information, "SUCCESS!")
                            ClearFields()
                            DisableFields()
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
                End If
            Case "&CANCEL"
                ClearFields()
                DisableFields()

                btnAdd.Text = "&ADD NEW"
                btnUpdate.Text = "&UPDATE"
                btnDelete.Text = "&DELETE"
        End Select
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        da.Fill(ds)
        ds = New DataSet
        RefreshDataGrid()
    End Sub
End Class