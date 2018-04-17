Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class Products
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
        txtbxProd_Code.Enabled = True
        txtbxProd_Descr.Enabled = True
        txtbxSupplier.Enabled = True
        txtbxPrice.Enabled = True
        txtbxQty.Enabled = True
        txtbxSRP.Enabled = True
        Return 0
    End Function
    '///// DISABLE FIELDS /////
    Private Function DisableFields()
        txtbxProd_Code.Enabled = False
        txtbxProd_Descr.Enabled = False
        txtbxSupplier.Enabled = False
        txtbxPrice.Enabled = False
        txtbxQty.Enabled = False
        txtbxSRP.Enabled = False
        Return 0
    End Function
    '///// CLEAR FIELDS /////
    Private Function ClearFields()
        txtbxProd_Code.Clear()
        txtbxProd_Descr.Clear()
        txtbxSupplier.Clear()
        txtbxPrice.Clear()
        txtbxQty.Clear()
        txtbxSRP.Clear()
        Return 0
    End Function
    '///// REFRESH DATAGRIDVIEW /////
    Private Sub RefreshDataGrid()
        da = New OleDbDataAdapter("Select * from mtpro_products'", cnn)
        dt = New DataTable
        da.Fill(dt)
        GridViewProducts.DataSource = dt
        With GridViewProducts
            .Columns(0).HeaderCell.Value = "Code"
            .Columns(1).HeaderCell.Value = "Description"
            .Columns(2).HeaderCell.Value = "Price"
            .Columns(3).HeaderCell.Value = "SRP"
            .Columns(4).HeaderCell.Value = "Quantity"
            .Columns(5).HeaderCell.Value = "Supplier"
            .Columns(0).Width = 208
            .Columns(1).Width = 500
            .Columns(2).Width = 130
            .Columns(3).Width = 130
            .Columns(4).Width = 120
            .Columns(5).Width = 160
        End With
    End Sub
    '///// SHOWS THE PRODUCTS /////
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"

        RefreshDataGrid()
        DisableFields()
        GridViewProducts.Refresh()
    End Sub
    '///// WHEN CLICKED, SHOW PRODUCT DETAILS /////
    Private Sub GridViewProducts_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridViewProducts.CellMouseClick
        txtbxProd_Code.Text = GridViewProducts.Item(0, GridViewProducts.CurrentCell.RowIndex).Value
        txtbxSupplier.Text = GridViewProducts.Item(5, GridViewProducts.CurrentCell.RowIndex).Value
        txtbxPrice.Text = GridViewProducts.Item(2, GridViewProducts.CurrentCell.RowIndex).Value
        txtbxSRP.Text = GridViewProducts.Item(3, GridViewProducts.CurrentCell.RowIndex).Value
        txtbxQty.Text = GridViewProducts.Item(4, GridViewProducts.CurrentCell.RowIndex).Value
        txtbxProd_Descr.Text = GridViewProducts.Item(1, GridViewProducts.CurrentCell.RowIndex).Value
    End Sub
    '///// SEARCH FUNCTION /////
    Private Sub btnSeacrh_Click(sender As Object, e As EventArgs) Handles btnSeacrh.Click
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
                cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] Like '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewProducts.DataSource = table
                GridViewProducts.Refresh()
            ElseIf cmbxSearch.SelectedIndex = 1 Then
                cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewProducts.DataSource = table
                GridViewProducts.Refresh()
            Else
                cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewProducts.DataSource = table
                GridViewProducts.Refresh()
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
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_code] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewProducts.DataSource = table
                    GridViewProducts.Refresh()
                ElseIf cmbxSearch.SelectedIndex = 1 Then
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_description] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewProducts.DataSource = table
                    GridViewProducts.Refresh()
                Else
                    cmd = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT * FROM [mtpro_products] WHERE [prod_supplier] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewProducts.DataSource = table
                    GridViewProducts.Refresh()
                End If
            End If
            cnn.Close()
        End If
    End Sub
    '//// ADD BUTTON /////
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Select Case btnAdd.Text
            Case "&ADD NEW"
                ClearFields()
                EnableFields()

                btnAdd.Text = "&SAVE"
                btnUpdate.Text = "C&LEAR FIELDS"
                btnDelete.Text = "&CANCEL"

            Case "&SAVE"
                da = New OleDbDataAdapter("INSERT INTO mtpro_products(prod_code,prod_description,prod_cost,prod_srp,prod_qty,prod_supplier) 
                                            VALUES('" & txtbxProd_Code.Text & "','" & txtbxProd_Descr.Text & "','" & txtbxPrice.Text & "',
                                                    '" & txtbxSRP.Text & "','" & txtbxQty.Text & "','" & txtbxSupplier.Text & "')", cnn)

                If txtbxProd_Code.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxProd_Code.Focus()
                ElseIf txtbxProd_Descr.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxProd_Descr.Focus()
                ElseIf txtbxPrice.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxPrice.Focus()
                ElseIf txtbxSRP.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSRP.Focus()
                ElseIf txtbxQty.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxQty.Focus()
                ElseIf txtbxSupplier.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSupplier.Focus()
                Else
                    Select Case MsgBox("Are you sure you want to Add?", MsgBoxStyle.OkCancel, "")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Added New Products')", cnn)
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
    '//// UPDATE BUTTON /////
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Select Case btnUpdate.Text
            Case "&UPDATE"
                If (txtbxProd_Code.Text = "") Then
                    MessageBox.Show("NO SELECTED PRODUCT TO UPDATE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DisableFields()
                Else
                    EnableFields()
                    txtbxProd_Code.Enabled = False

                    btnAdd.Text = "C&LEAR FIELDS"
                    btnUpdate.Text = "&SAVE UPDATE"
                    btnDelete.Text = "&CANCEL"
                End If

            Case "&SAVE UPDATE"
                da = New OleDbDataAdapter("UPDATE mtpro_products SET prod_description = '" & txtbxProd_Descr.Text & "', 
                                                                prod_cost = '" & txtbxPrice.Text & "', 
                                                                prod_srp = '" & txtbxSRP.Text & "', 
                                                                prod_qty = '" & txtbxQty.Text & "', 
                                                                prod_supplier = '" & txtbxSupplier.Text & "' 
                                                                WHERE prod_code = '" & txtbxProd_Code.Text & "'", cnn)

                If txtbxProd_Code.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxProd_Code.Focus()
                ElseIf txtbxProd_Descr.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxProd_Descr.Focus()
                ElseIf txtbxPrice.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxPrice.Focus()
                ElseIf txtbxSRP.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSRP.Focus()
                ElseIf txtbxQty.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxQty.Focus()
                ElseIf txtbxSupplier.Text = Nothing Then
                    MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxSupplier.Focus()
                Else
                    Select Case MsgBox("    Are you sure you want to Update?", MsgBoxStyle.OkCancel, "UPDATE?")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Updated Products')", cnn)
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
    '//// DELETE BUTTON /////
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case btnDelete.Text
            Case "&DELETE"
                If (txtbxProd_Code.Text = "") Then
                    MessageBox.Show("NO SELECTED PRODUCT TO DELETE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    da = New OleDbDataAdapter("DELETE FROM mtpro_products WHERE prod_code = '" & txtbxProd_Code.Text & "'", cnn)
                    Select Case MsgBox("    Are you sure you want to Delete?", MsgBoxStyle.OkCancel, "DELETE?")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Deleted Products')", cnn)
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter Filename to create PDF")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF Created Successfully")
        End If
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name 
        Dim dataColumn_1 As New DataColumn(GridViewProducts.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(GridViewProducts.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(GridViewProducts.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(GridViewProducts.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(GridViewProducts.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        Dim dataColumn_6 As New DataColumn(GridViewProducts.Columns(5).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_6)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To GridViewProducts.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(GridViewProducts.Columns(0).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(0).Value.ToString()
            dataRow(GridViewProducts.Columns(1).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(1).Value.ToString()
            dataRow(GridViewProducts.Columns(2).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(2).Value.ToString()
            dataRow(GridViewProducts.Columns(3).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(3).Value.ToString()
            dataRow(GridViewProducts.Columns(4).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(4).Value.ToString()
            dataRow(GridViewProducts.Columns(5).HeaderText.ToString()) = GridViewProducts.Rows(i).Cells(5).Value.ToString()
            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function


    '////EXPORT TO PDF FUNTION

    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4.Rotate, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("Products", font12BoldRed))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(6)
        PdfTable.TotalWidth = 750.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {6.0F, 6.0F, 3.0F, 3.0F, 3.0F, 3.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Product Code", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Product Description", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Cost", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("SRP", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Quantity", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Supplier", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)

        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub

End Class