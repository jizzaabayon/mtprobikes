<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receipts2_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipts2_Details))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.datepickerDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbxReceipt_No = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtbxCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddtoCart = New System.Windows.Forms.Button()
        Me.txtbxCost = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtbxPrice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbxQty = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbxDescr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbxCode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtbxVat = New System.Windows.Forms.TextBox()
        Me.btnWOVat = New System.Windows.Forms.RadioButton()
        Me.btnWVat = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbxDiscountP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxTotalQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxNet = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbxDiscount = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtbxGross = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.listview_products = New System.Windows.Forms.ListView()
        Me.GridViewCart = New System.Windows.Forms.DataGridView()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridViewCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(786, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Username:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(-486, 665)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(411, 47)
        Me.btnAdd.TabIndex = 229
        Me.btnAdd.Text = "&ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(768, 129)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(108, 18)
        Me.lblDate.TabIndex = 228
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(886, 129)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(99, 18)
        Me.lblTime.TabIndex = 227
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(889, 104)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(90, 18)
        Me.lblUsername.TabIndex = 226
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(779, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(200, 89)
        Me.pictureBox1.TabIndex = 225
        Me.pictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'datepickerDate
        '
        Me.datepickerDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepickerDate.Location = New System.Drawing.Point(367, 64)
        Me.datepickerDate.Name = "datepickerDate"
        Me.datepickerDate.Size = New System.Drawing.Size(293, 27)
        Me.datepickerDate.TabIndex = 242
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(314, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 18)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "Date:"
        '
        'txtbxReceipt_No
        '
        Me.txtbxReceipt_No.Enabled = False
        Me.txtbxReceipt_No.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxReceipt_No.Location = New System.Drawing.Point(367, 97)
        Me.txtbxReceipt_No.Name = "txtbxReceipt_No"
        Me.txtbxReceipt_No.Size = New System.Drawing.Size(293, 27)
        Me.txtbxReceipt_No.TabIndex = 232
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label5.Location = New System.Drawing.Point(258, 101)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(110, 18)
        Me.label5.TabIndex = 231
        Me.label5.Text = "Receipt No.:"
        '
        'txtbxCustomer
        '
        Me.txtbxCustomer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCustomer.Location = New System.Drawing.Point(367, 31)
        Me.txtbxCustomer.Name = "txtbxCustomer"
        Me.txtbxCustomer.Size = New System.Drawing.Size(293, 27)
        Me.txtbxCustomer.TabIndex = 244
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(222, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 18)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Customer Name:"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(244, 463)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(161, 25)
        Me.btnRemove.TabIndex = 256
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSearch.Location = New System.Drawing.Point(12, 439)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(226, 27)
        Me.txtbxSearch.TabIndex = 257
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(73, 469)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 18)
        Me.Label13.TabIndex = 258
        Me.Label13.Text = "Search Item"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(411, 463)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 25)
        Me.btnReset.TabIndex = 259
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(568, 463)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(161, 25)
        Me.btnPrint.TabIndex = 260
        Me.btnPrint.Text = "PRINT PREVIEW"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddtoCart)
        Me.GroupBox1.Controls.Add(Me.txtbxCost)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtbxPrice)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtbxQty)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtbxDescr)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtbxCode)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 171)
        Me.GroupBox1.TabIndex = 261
        Me.GroupBox1.TabStop = False
        '
        'btnAddtoCart
        '
        Me.btnAddtoCart.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoCart.ForeColor = System.Drawing.Color.Black
        Me.btnAddtoCart.Location = New System.Drawing.Point(241, 118)
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Size = New System.Drawing.Size(238, 36)
        Me.btnAddtoCart.TabIndex = 262
        Me.btnAddtoCart.Text = "ADD TO CART"
        Me.btnAddtoCart.UseVisualStyleBackColor = True
        '
        'txtbxCost
        '
        Me.txtbxCost.Enabled = False
        Me.txtbxCost.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCost.Location = New System.Drawing.Point(62, 58)
        Me.txtbxCost.Multiline = True
        Me.txtbxCost.Name = "txtbxCost"
        Me.txtbxCost.Size = New System.Drawing.Size(172, 25)
        Me.txtbxCost.TabIndex = 271
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(4, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 18)
        Me.Label18.TabIndex = 270
        Me.Label18.Text = "Quantity:"
        '
        'txtbxPrice
        '
        Me.txtbxPrice.Enabled = False
        Me.txtbxPrice.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPrice.Location = New System.Drawing.Point(108, 124)
        Me.txtbxPrice.Multiline = True
        Me.txtbxPrice.Name = "txtbxPrice"
        Me.txtbxPrice.Size = New System.Drawing.Size(126, 25)
        Me.txtbxPrice.TabIndex = 269
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(4, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 18)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "Total Price:"
        '
        'txtbxQty
        '
        Me.txtbxQty.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxQty.Location = New System.Drawing.Point(96, 90)
        Me.txtbxQty.Multiline = True
        Me.txtbxQty.Name = "txtbxQty"
        Me.txtbxQty.Size = New System.Drawing.Size(138, 25)
        Me.txtbxQty.TabIndex = 267
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(4, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 266
        Me.Label16.Text = "Cost:"
        '
        'txtbxDescr
        '
        Me.txtbxDescr.Enabled = False
        Me.txtbxDescr.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDescr.Location = New System.Drawing.Point(241, 48)
        Me.txtbxDescr.Multiline = True
        Me.txtbxDescr.Name = "txtbxDescr"
        Me.txtbxDescr.Size = New System.Drawing.Size(238, 56)
        Me.txtbxDescr.TabIndex = 265
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(276, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(174, 18)
        Me.Label15.TabIndex = 264
        Me.Label15.Text = "Product Description:"
        '
        'txtbxCode
        '
        Me.txtbxCode.Enabled = False
        Me.txtbxCode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCode.Location = New System.Drawing.Point(62, 27)
        Me.txtbxCode.Multiline = True
        Me.txtbxCode.Name = "txtbxCode"
        Me.txtbxCode.Size = New System.Drawing.Size(172, 25)
        Me.txtbxCode.TabIndex = 263
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(3, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 18)
        Me.Label14.TabIndex = 262
        Me.Label14.Text = "Code:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.txtbxVat)
        Me.GroupBox2.Controls.Add(Me.btnWOVat)
        Me.GroupBox2.Controls.Add(Me.btnWVat)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtbxDiscountP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtbxTotalQty)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtbxTotal)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtbxNet)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtbxDiscount)
        Me.GroupBox2.Controls.Add(Me.label8)
        Me.GroupBox2.Controls.Add(Me.txtbxGross)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Location = New System.Drawing.Point(735, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 329)
        Me.GroupBox2.TabIndex = 262
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(47, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 25)
        Me.btnSave.TabIndex = 274
        Me.btnSave.Text = "ISSUE RECEIPT"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtbxVat
        '
        Me.txtbxVat.Enabled = False
        Me.txtbxVat.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxVat.Location = New System.Drawing.Point(61, 212)
        Me.txtbxVat.Name = "txtbxVat"
        Me.txtbxVat.Size = New System.Drawing.Size(196, 27)
        Me.txtbxVat.TabIndex = 270
        '
        'btnWOVat
        '
        Me.btnWOVat.AutoSize = True
        Me.btnWOVat.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWOVat.Location = New System.Drawing.Point(135, 190)
        Me.btnWOVat.Name = "btnWOVat"
        Me.btnWOVat.Size = New System.Drawing.Size(93, 22)
        Me.btnWOVat.TabIndex = 269
        Me.btnWOVat.TabStop = True
        Me.btnWOVat.Text = "w/o VAT"
        Me.btnWOVat.UseVisualStyleBackColor = True
        '
        'btnWVat
        '
        Me.btnWVat.AutoSize = True
        Me.btnWVat.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWVat.Location = New System.Drawing.Point(46, 190)
        Me.btnWVat.Name = "btnWVat"
        Me.btnWVat.Size = New System.Drawing.Size(83, 22)
        Me.btnWVat.TabIndex = 268
        Me.btnWVat.TabStop = True
        Me.btnWVat.Text = "w/ VAT"
        Me.btnWVat.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(14, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 267
        Me.Label11.Text = "VAT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(232, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 18)
        Me.Label7.TabIndex = 266
        Me.Label7.Text = "%"
        '
        'txtbxDiscountP
        '
        Me.txtbxDiscountP.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDiscountP.Location = New System.Drawing.Point(61, 91)
        Me.txtbxDiscountP.Name = "txtbxDiscountP"
        Me.txtbxDiscountP.Size = New System.Drawing.Size(165, 27)
        Me.txtbxDiscountP.TabIndex = 265
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(9, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Less:"
        '
        'txtbxTotalQty
        '
        Me.txtbxTotalQty.Enabled = False
        Me.txtbxTotalQty.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotalQty.Location = New System.Drawing.Point(131, 21)
        Me.txtbxTotalQty.Multiline = True
        Me.txtbxTotalQty.Name = "txtbxTotalQty"
        Me.txtbxTotalQty.Size = New System.Drawing.Size(126, 31)
        Me.txtbxTotalQty.TabIndex = 263
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(5, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 262
        Me.Label3.Text = "Total Quantity:"
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Enabled = False
        Me.txtbxTotal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotal.Location = New System.Drawing.Point(23, 265)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.Size = New System.Drawing.Size(218, 31)
        Me.txtbxTotal.TabIndex = 261
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(81, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 18)
        Me.Label12.TabIndex = 260
        Me.Label12.Text = "Total Price:"
        '
        'txtbxNet
        '
        Me.txtbxNet.Enabled = False
        Me.txtbxNet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNet.Location = New System.Drawing.Point(105, 157)
        Me.txtbxNet.Name = "txtbxNet"
        Me.txtbxNet.Size = New System.Drawing.Size(152, 27)
        Me.txtbxNet.TabIndex = 259
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(9, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 258
        Me.Label10.Text = "Net Sales:"
        '
        'txtbxDiscount
        '
        Me.txtbxDiscount.Enabled = False
        Me.txtbxDiscount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDiscount.Location = New System.Drawing.Point(97, 124)
        Me.txtbxDiscount.Name = "txtbxDiscount"
        Me.txtbxDiscount.Size = New System.Drawing.Size(160, 27)
        Me.txtbxDiscount.TabIndex = 257
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label8.Location = New System.Drawing.Point(9, 129)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(86, 18)
        Me.label8.TabIndex = 256
        Me.label8.Text = "Discount:"
        '
        'txtbxGross
        '
        Me.txtbxGross.Enabled = False
        Me.txtbxGross.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxGross.Location = New System.Drawing.Point(120, 55)
        Me.txtbxGross.Multiline = True
        Me.txtbxGross.Name = "txtbxGross"
        Me.txtbxGross.Size = New System.Drawing.Size(137, 31)
        Me.txtbxGross.TabIndex = 255
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label6.Location = New System.Drawing.Point(7, 64)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(111, 18)
        Me.label6.TabIndex = 254
        Me.label6.Text = "Gross Sales:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(12, 97)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(226, 28)
        Me.btnCancel.TabIndex = 272
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'listview_products
        '
        Me.listview_products.AutoArrange = False
        Me.listview_products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listview_products.FullRowSelect = True
        Me.listview_products.GridLines = True
        Me.listview_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listview_products.Location = New System.Drawing.Point(12, 130)
        Me.listview_products.MultiSelect = False
        Me.listview_products.Name = "listview_products"
        Me.listview_products.Size = New System.Drawing.Size(226, 303)
        Me.listview_products.TabIndex = 273
        Me.listview_products.UseCompatibleStateImageBehavior = False
        Me.listview_products.View = System.Windows.Forms.View.Details
        '
        'GridViewCart
        '
        Me.GridViewCart.AllowUserToAddRows = False
        Me.GridViewCart.AllowUserToDeleteRows = False
        Me.GridViewCart.AllowUserToResizeColumns = False
        Me.GridViewCart.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridViewCart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridViewCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridViewCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridViewCart.ColumnHeadersHeight = 30
        Me.GridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridViewCart.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewCart.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridViewCart.Location = New System.Drawing.Point(244, 307)
        Me.GridViewCart.Name = "GridViewCart"
        Me.GridViewCart.ReadOnly = True
        Me.GridViewCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridViewCart.RowHeadersVisible = False
        Me.GridViewCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewCart.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridViewCart.RowTemplate.Height = 30
        Me.GridViewCart.RowTemplate.ReadOnly = True
        Me.GridViewCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewCart.ShowEditingIcon = False
        Me.GridViewCart.Size = New System.Drawing.Size(485, 150)
        Me.GridViewCart.TabIndex = 274
        '
        'Receipts2_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.GridViewCart)
        Me.Controls.Add(Me.listview_products)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtbxCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datepickerDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbxReceipt_No)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Receipts2_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipts2_Details"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridViewCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label2 As Label
    Private WithEvents btnAdd As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents datepickerDate As DateTimePicker
    Private WithEvents Label9 As Label
    Private WithEvents txtbxReceipt_No As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtbxCustomer As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents btnRemove As Button
    Private WithEvents txtbxSearch As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents btnReset As Button
    Private WithEvents btnPrint As Button
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtbxDescr As TextBox
    Private WithEvents Label15 As Label
    Private WithEvents txtbxCode As TextBox
    Private WithEvents Label14 As Label
    Private WithEvents btnAddtoCart As Button
    Private WithEvents txtbxCost As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents txtbxPrice As TextBox
    Private WithEvents Label17 As Label
    Private WithEvents txtbxQty As TextBox
    Private WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents txtbxVat As TextBox
    Friend WithEvents btnWOVat As RadioButton
    Friend WithEvents btnWVat As RadioButton
    Private WithEvents Label11 As Label
    Private WithEvents Label7 As Label
    Private WithEvents txtbxDiscountP As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents txtbxTotalQty As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents txtbxTotal As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtbxNet As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents txtbxDiscount As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtbxGross As TextBox
    Private WithEvents label6 As Label
    Private WithEvents btnCancel As Button
    Friend WithEvents listview_products As ListView
    Private WithEvents btnSave As Button
    Private WithEvents GridViewCart As DataGridView
End Class
