Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class Sales
    Private bitmap As Bitmap
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection
    Dim cnn2 As New OleDb.OleDbConnection

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

    Private Sub RefreshDataGrid()
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        da = New OleDbDataAdapter("Select * from mtpro_receipts'", cnn)
        dt = New DataTable
        da.Fill(dt)
        GridViewSales.DataSource = dt
        With GridViewSales
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
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        RefreshDataGrid()
    End Sub
    '//// SHOW GRAPHS /////
    Private Sub btnShowGraphs_Click(sender As Object, e As EventArgs) Handles btnShowGraphs.Click
        Dim obj As New Sales_Graph
        obj.username = lblUsername.Text
        Me.Hide()
        obj.Show()
    End Sub
    '///// SEARCH SALES /////
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sdate As Date = DateTimePicker1.Value
        Dim edate As Date = DateTimePicker2.Value.AddDays(+1)

        Try
            cnn2 = New OleDb.OleDbConnection
            cnn2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
            Dim sqlstr1 As String
            sqlstr1 = "SELECT * FROM mtpro_receipts WHERE receipt_date BETWEEN #" & sdate & "# AND #" & edate & "# ORDER BY receipt_date"
            Dim da As New OleDbDataAdapter(sqlstr1, cnn2)
            Dim dt As New DataTable("mtpro_receipts")
            da.Fill(dt)
            GridViewSales.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Dispose()
        End Try
    End Sub
    '//// IMPORT TO EXCEL *PRINT BUTTON /////
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To GridViewSales.RowCount - 2
            For j = 0 To GridViewSales.ColumnCount - 1
                For k As Integer = 1 To GridViewSales.Columns.Count
                    xlWorkSheet.Cells(1, k) = GridViewSales.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = GridViewSales(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\salesreport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can now find the file D:\salesreport.xlsx")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGrid()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
        Dim dataColumn_1 As New DataColumn(GridViewSales.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(GridViewSales.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(GridViewSales.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(GridViewSales.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(GridViewSales.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        Dim dataColumn_6 As New DataColumn(GridViewSales.Columns(5).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_6)
        Dim dataColumn_7 As New DataColumn(GridViewSales.Columns(6).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_7)
        Dim dataColumn_8 As New DataColumn(GridViewSales.Columns(7).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_8)
        Dim dataColumn_9 As New DataColumn(GridViewSales.Columns(8).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_9)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To GridViewSales.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(GridViewSales.Columns(0).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(0).Value.ToString()
            dataRow(GridViewSales.Columns(1).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(1).Value.ToString()
            dataRow(GridViewSales.Columns(2).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(2).Value.ToString()
            dataRow(GridViewSales.Columns(3).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(3).Value.ToString()
            dataRow(GridViewSales.Columns(4).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(4).Value.ToString()
            dataRow(GridViewSales.Columns(5).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(5).Value.ToString()
            dataRow(GridViewSales.Columns(6).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(6).Value.ToString()
            dataRow(GridViewSales.Columns(7).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(7).Value.ToString()
            dataRow(GridViewSales.Columns(8).HeaderText.ToString()) = GridViewSales.Rows(i).Cells(8).Value.ToString()
            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    '////ExportDataToPDFTable

    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4.Rotate, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("Sales Report", font12BoldRed))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(9)
        PdfTable.TotalWidth = 750.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {6.0F, 4.0F, 4.0F, 3.0F, 4.0F, 3.0F, 3.0F, 3.0F, 3.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Receipt No", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Receipt ID", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Date", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Supplier", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Customer", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Gross Sales", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Net Sales", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Discount", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Total Price", font12Bold)))
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