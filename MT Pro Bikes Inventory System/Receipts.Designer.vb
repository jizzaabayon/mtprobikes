<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipts))
        Me.datepickerDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GridViewReceipts = New System.Windows.Forms.DataGridView()
        Me.pcbx_back = New System.Windows.Forms.PictureBox()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxNet = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbxCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxDiscount = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtbxSupplier = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtbxGross = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtbxReceipt_No = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbxSearch = New System.Windows.Forms.ComboBox()
        Me.cmbxType = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridViewReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datepickerDate
        '
        Me.datepickerDate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepickerDate.Location = New System.Drawing.Point(961, 575)
        Me.datepickerDate.Name = "datepickerDate"
        Me.datepickerDate.Size = New System.Drawing.Size(311, 31)
        Me.datepickerDate.TabIndex = 175
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(874, 685)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(398, 47)
        Me.btnDelete.TabIndex = 174
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(455, 685)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(413, 47)
        Me.btnUpdate.TabIndex = 173
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(38, 685)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(411, 47)
        Me.btnAdd.TabIndex = 172
        Me.btnAdd.Text = "&ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GridViewReceipts
        '
        Me.GridViewReceipts.AllowUserToAddRows = False
        Me.GridViewReceipts.AllowUserToDeleteRows = False
        Me.GridViewReceipts.AllowUserToResizeColumns = False
        Me.GridViewReceipts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReceipts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridViewReceipts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridViewReceipts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridViewReceipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReceipts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewReceipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridViewReceipts.EnableHeadersVisualStyles = False
        Me.GridViewReceipts.Location = New System.Drawing.Point(37, 284)
        Me.GridViewReceipts.Name = "GridViewReceipts"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReceipts.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridViewReceipts.RowHeadersVisible = False
        Me.GridViewReceipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReceipts.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridViewReceipts.RowTemplate.Height = 30
        Me.GridViewReceipts.RowTemplate.ReadOnly = True
        Me.GridViewReceipts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewReceipts.Size = New System.Drawing.Size(1231, 275)
        Me.GridViewReceipts.TabIndex = 169
        '
        'pcbx_back
        '
        Me.pcbx_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_back.Image = CType(resources.GetObject("pcbx_back.Image"), System.Drawing.Image)
        Me.pcbx_back.Location = New System.Drawing.Point(455, 125)
        Me.pcbx_back.Name = "pcbx_back"
        Me.pcbx_back.Size = New System.Drawing.Size(55, 53)
        Me.pcbx_back.TabIndex = 168
        Me.pcbx_back.TabStop = False
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Enabled = False
        Me.txtbxTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotal.Location = New System.Drawing.Point(1008, 642)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.Size = New System.Drawing.Size(264, 27)
        Me.txtbxTotal.TabIndex = 167
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(876, 642)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 26)
        Me.Label12.TabIndex = 166
        Me.Label12.Text = "Total Price:"
        '
        'txtbxNet
        '
        Me.txtbxNet.Enabled = False
        Me.txtbxNet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNet.Location = New System.Drawing.Point(569, 644)
        Me.txtbxNet.Name = "txtbxNet"
        Me.txtbxNet.Size = New System.Drawing.Size(297, 27)
        Me.txtbxNet.TabIndex = 165
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(452, 644)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 26)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "Net Sales:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(876, 579)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 26)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Date:"
        '
        'txtbxCustomer
        '
        Me.txtbxCustomer.Enabled = False
        Me.txtbxCustomer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCustomer.Location = New System.Drawing.Point(156, 645)
        Me.txtbxCustomer.Name = "txtbxCustomer"
        Me.txtbxCustomer.Size = New System.Drawing.Size(293, 27)
        Me.txtbxCustomer.TabIndex = 162
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(35, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 26)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Customer:"
        '
        'txtbxDiscount
        '
        Me.txtbxDiscount.Enabled = False
        Me.txtbxDiscount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDiscount.Location = New System.Drawing.Point(987, 612)
        Me.txtbxDiscount.Name = "txtbxDiscount"
        Me.txtbxDiscount.Size = New System.Drawing.Size(285, 27)
        Me.txtbxDiscount.TabIndex = 160
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label8.Location = New System.Drawing.Point(876, 612)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(117, 26)
        Me.label8.TabIndex = 159
        Me.label8.Text = "Discount:"
        '
        'txtbxSupplier
        '
        Me.txtbxSupplier.Enabled = False
        Me.txtbxSupplier.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSupplier.Location = New System.Drawing.Point(144, 609)
        Me.txtbxSupplier.Name = "txtbxSupplier"
        Me.txtbxSupplier.Size = New System.Drawing.Size(306, 27)
        Me.txtbxSupplier.TabIndex = 158
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label7.Location = New System.Drawing.Point(35, 609)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(113, 26)
        Me.label7.TabIndex = 157
        Me.label7.Text = "Supplier:"
        '
        'txtbxGross
        '
        Me.txtbxGross.Enabled = False
        Me.txtbxGross.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGross.Location = New System.Drawing.Point(592, 610)
        Me.txtbxGross.Multiline = True
        Me.txtbxGross.Name = "txtbxGross"
        Me.txtbxGross.Size = New System.Drawing.Size(274, 31)
        Me.txtbxGross.TabIndex = 156
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label6.Location = New System.Drawing.Point(451, 612)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(149, 26)
        Me.label6.TabIndex = 155
        Me.label6.Text = "Gross Sales:"
        '
        'txtbxReceipt_No
        '
        Me.txtbxReceipt_No.Enabled = False
        Me.txtbxReceipt_No.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxReceipt_No.Location = New System.Drawing.Point(591, 575)
        Me.txtbxReceipt_No.Name = "txtbxReceipt_No"
        Me.txtbxReceipt_No.Size = New System.Drawing.Size(274, 27)
        Me.txtbxReceipt_No.TabIndex = 154
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnSearch.Location = New System.Drawing.Point(1114, 246)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(154, 32)
        Me.btnSearch.TabIndex = 152
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtbxSearch.Location = New System.Drawing.Point(569, 245)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(539, 33)
        Me.txtbxSearch.TabIndex = 151
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 25.0!)
        Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label3.Location = New System.Drawing.Point(33, 236)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(228, 41)
        Me.label3.TabIndex = 149
        Me.label3.Text = "SEARCH BY:"
        '
        'Timer1
        '
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label5.Location = New System.Drawing.Point(450, 575)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(147, 26)
        Me.label5.TabIndex = 153
        Me.label5.Text = "Receipt No.:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1040, 209)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 25)
        Me.lblDate.TabIndex = 148
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1181, 209)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 25)
        Me.lblTime.TabIndex = 147
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1184, 184)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 25)
        Me.lblUsername.TabIndex = 146
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(961, 32)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 149)
        Me.pictureBox1.TabIndex = 145
        Me.pictureBox1.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Baron Neue", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(503, 82)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(455, 96)
        Me.label4.TabIndex = 144
        Me.label4.Text = "receipts"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(35, 575)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 26)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "Receipt Type:"
        '
        'cmbxSearch
        '
        Me.cmbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.cmbxSearch.Items.AddRange(New Object() {"RECEIPT NO.", "RECEIPT TYPE", "SUPPLIER", "CUSTOMER"})
        Me.cmbxSearch.Location = New System.Drawing.Point(253, 243)
        Me.cmbxSearch.Name = "cmbxSearch"
        Me.cmbxSearch.Size = New System.Drawing.Size(310, 33)
        Me.cmbxSearch.TabIndex = 178
        Me.cmbxSearch.TabStop = False
        '
        'cmbxType
        '
        Me.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxType.Items.AddRange(New Object() {"Customer Receipt", "Supplier Receipt"})
        Me.cmbxType.Location = New System.Drawing.Point(191, 575)
        Me.cmbxType.Name = "cmbxType"
        Me.cmbxType.Size = New System.Drawing.Size(258, 26)
        Me.cmbxType.TabIndex = 179
        Me.cmbxType.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Location = New System.Drawing.Point(40, 184)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 43)
        Me.btnRefresh.TabIndex = 188
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1058, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Username:"
        '
        'Receipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 765)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbxType)
        Me.Controls.Add(Me.cmbxSearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.datepickerDate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GridViewReceipts)
        Me.Controls.Add(Me.pcbx_back)
        Me.Controls.Add(Me.txtbxTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbxNet)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbxCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxDiscount)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtbxSupplier)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtbxGross)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtbxReceipt_No)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Receipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridViewReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datepickerDate As DateTimePicker
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents GridViewReceipts As DataGridView
    Friend WithEvents pcbx_back As PictureBox
    Private WithEvents txtbxTotal As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtbxNet As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents txtbxCustomer As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtbxDiscount As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtbxSupplier As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtbxGross As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtbxReceipt_No As TextBox
    Private WithEvents btnSearch As Button
    Private WithEvents txtbxSearch As TextBox
    Private WithEvents label3 As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents Label11 As Label
    Private WithEvents cmbxSearch As ComboBox
    Private WithEvents cmbxType As ComboBox
    Private WithEvents btnRefresh As Button
    Private WithEvents Label2 As Label
End Class
