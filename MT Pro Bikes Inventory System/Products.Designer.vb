<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridViewProducts = New System.Windows.Forms.DataGridView()
        Me.pcbx_back = New System.Windows.Forms.PictureBox()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.cmbxSearch = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtbxQty = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtbxPrice = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtbxProd_Descr = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtbxSupplier = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtbxProd_Code = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSeacrh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxSRP = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.GridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(30, 668)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 26)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Supplier:"
        '
        'GridViewProducts
        '
        Me.GridViewProducts.AllowUserToAddRows = False
        Me.GridViewProducts.AllowUserToDeleteRows = False
        Me.GridViewProducts.AllowUserToResizeColumns = False
        Me.GridViewProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridViewProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridViewProducts.ColumnHeadersHeight = 30
        Me.GridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridViewProducts.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewProducts.DefaultCellStyle = DataGridViewCellStyle7
        Me.GridViewProducts.Location = New System.Drawing.Point(25, 279)
        Me.GridViewProducts.Name = "GridViewProducts"
        Me.GridViewProducts.ReadOnly = True
        Me.GridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridViewProducts.RowHeadersVisible = False
        Me.GridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewProducts.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GridViewProducts.RowTemplate.Height = 30
        Me.GridViewProducts.RowTemplate.ReadOnly = True
        Me.GridViewProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewProducts.ShowEditingIcon = False
        Me.GridViewProducts.Size = New System.Drawing.Size(1252, 336)
        Me.GridViewProducts.TabIndex = 128
        '
        'pcbx_back
        '
        Me.pcbx_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_back.Image = CType(resources.GetObject("pcbx_back.Image"), System.Drawing.Image)
        Me.pcbx_back.Location = New System.Drawing.Point(460, 121)
        Me.pcbx_back.Name = "pcbx_back"
        Me.pcbx_back.Size = New System.Drawing.Size(55, 53)
        Me.pcbx_back.TabIndex = 127
        Me.pcbx_back.TabStop = False
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtbxSearch.Location = New System.Drawing.Point(560, 240)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(370, 33)
        Me.txtbxSearch.TabIndex = 125
        '
        'cmbxSearch
        '
        Me.cmbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.cmbxSearch.Items.AddRange(New Object() {"PRODUCT CODE", "PRODUCT DESCRIPTION", "SUPPLIER"})
        Me.cmbxSearch.Location = New System.Drawing.Point(259, 239)
        Me.cmbxSearch.Name = "cmbxSearch"
        Me.cmbxSearch.Size = New System.Drawing.Size(294, 33)
        Me.cmbxSearch.TabIndex = 124
        Me.cmbxSearch.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 25.0!)
        Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label3.Location = New System.Drawing.Point(38, 231)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(228, 41)
        Me.label3.TabIndex = 123
        Me.label3.Text = "SEARCH BY:"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(455, 590)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 129
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1048, 200)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 25)
        Me.lblDate.TabIndex = 122
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1200, 201)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 25)
        Me.lblTime.TabIndex = 121
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1207, 177)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 25)
        Me.lblUsername.TabIndex = 120
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(987, 27)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 149)
        Me.pictureBox1.TabIndex = 119
        Me.pictureBox1.TabStop = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Baron Neue", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(513, 78)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(471, 96)
        Me.label9.TabIndex = 118
        Me.label9.Text = "product"
        '
        'txtbxQty
        '
        Me.txtbxQty.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxQty.Enabled = False
        Me.txtbxQty.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxQty.Location = New System.Drawing.Point(1175, 671)
        Me.txtbxQty.Name = "txtbxQty"
        Me.txtbxQty.Size = New System.Drawing.Size(86, 30)
        Me.txtbxQty.TabIndex = 117
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label4.Location = New System.Drawing.Point(1055, 671)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(117, 26)
        Me.label4.TabIndex = 116
        Me.label4.Text = "Quantity:"
        '
        'txtbxPrice
        '
        Me.txtbxPrice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxPrice.Enabled = False
        Me.txtbxPrice.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxPrice.Location = New System.Drawing.Point(947, 633)
        Me.txtbxPrice.Name = "txtbxPrice"
        Me.txtbxPrice.Size = New System.Drawing.Size(315, 30)
        Me.txtbxPrice.TabIndex = 115
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label8.Location = New System.Drawing.Point(867, 637)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(74, 26)
        Me.label8.TabIndex = 114
        Me.label8.Text = "Price:"
        '
        'txtbxProd_Descr
        '
        Me.txtbxProd_Descr.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxProd_Descr.Enabled = False
        Me.txtbxProd_Descr.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxProd_Descr.Location = New System.Drawing.Point(591, 635)
        Me.txtbxProd_Descr.Multiline = True
        Me.txtbxProd_Descr.Name = "txtbxProd_Descr"
        Me.txtbxProd_Descr.Size = New System.Drawing.Size(269, 66)
        Me.txtbxProd_Descr.TabIndex = 113
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label7.Location = New System.Drawing.Point(879, 408)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(20, 26)
        Me.label7.TabIndex = 112
        Me.label7.Text = " "
        '
        'txtbxSupplier
        '
        Me.txtbxSupplier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxSupplier.Enabled = False
        Me.txtbxSupplier.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxSupplier.Location = New System.Drawing.Point(142, 670)
        Me.txtbxSupplier.Name = "txtbxSupplier"
        Me.txtbxSupplier.Size = New System.Drawing.Size(299, 30)
        Me.txtbxSupplier.TabIndex = 111
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label6.Location = New System.Drawing.Point(451, 642)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(145, 52)
        Me.label6.TabIndex = 110
        Me.label6.Text = "Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description:"
        '
        'txtbxProd_Code
        '
        Me.txtbxProd_Code.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxProd_Code.Enabled = False
        Me.txtbxProd_Code.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxProd_Code.Location = New System.Drawing.Point(194, 633)
        Me.txtbxProd_Code.Name = "txtbxProd_Code"
        Me.txtbxProd_Code.Size = New System.Drawing.Size(247, 30)
        Me.txtbxProd_Code.TabIndex = 109
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label5.Location = New System.Drawing.Point(29, 635)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(168, 26)
        Me.label5.TabIndex = 108
        Me.label5.Text = "Product Code:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(866, 707)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(398, 47)
        Me.btnDelete.TabIndex = 107
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(447, 707)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(413, 47)
        Me.btnUpdate.TabIndex = 106
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(30, 707)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(411, 47)
        Me.btnAdd.TabIndex = 105
        Me.btnAdd.Text = "&ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSeacrh
        '
        Me.btnSeacrh.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnSeacrh.Location = New System.Drawing.Point(936, 234)
        Me.btnSeacrh.Name = "btnSeacrh"
        Me.btnSeacrh.Size = New System.Drawing.Size(170, 43)
        Me.btnSeacrh.TabIndex = 126
        Me.btnSeacrh.Text = "SEARCH"
        Me.btnSeacrh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(867, 674)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "SRP:"
        '
        'txtbxSRP
        '
        Me.txtbxSRP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtbxSRP.Enabled = False
        Me.txtbxSRP.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.txtbxSRP.Location = New System.Drawing.Point(927, 671)
        Me.txtbxSRP.Name = "txtbxSRP"
        Me.txtbxSRP.Size = New System.Drawing.Size(122, 30)
        Me.txtbxSRP.TabIndex = 132
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Location = New System.Drawing.Point(45, 185)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 43)
        Me.btnRefresh.TabIndex = 188
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1080, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 25)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Username:"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnPrint.Location = New System.Drawing.Point(1109, 233)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(168, 43)
        Me.btnPrint.TabIndex = 190
        Me.btnPrint.Text = "EXPORT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 765)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtbxSRP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridViewProducts)
        Me.Controls.Add(Me.pcbx_back)
        Me.Controls.Add(Me.btnSeacrh)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.cmbxSearch)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.txtbxQty)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtbxPrice)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtbxProd_Descr)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtbxSupplier)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtbxProd_Code)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label10 As Label
    Private WithEvents GridViewProducts As DataGridView
    Friend WithEvents pcbx_back As PictureBox
    Private WithEvents txtbxSearch As TextBox
    Private WithEvents label3 As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label9 As Label
    Private WithEvents txtbxQty As TextBox
    Private WithEvents label4 As Label
    Private WithEvents txtbxPrice As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtbxProd_Descr As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtbxSupplier As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtbxProd_Code As TextBox
    Private WithEvents label5 As Label
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents btnSeacrh As Button
    Private WithEvents cmbxSearch As ComboBox
    Private WithEvents Label2 As Label
    Private WithEvents txtbxSRP As TextBox
    Private WithEvents btnRefresh As Button
    Private WithEvents Label11 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Private WithEvents btnPrint As Button
End Class
