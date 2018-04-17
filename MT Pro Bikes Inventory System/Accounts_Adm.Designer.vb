<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accounts_Adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts_Adm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtbxPassword = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtbxConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pcbx_back = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.cmbxSearch = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbxNumber = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.cmbxType = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtbxLastName = New System.Windows.Forms.TextBox()
        Me.txtbxFirstName = New System.Windows.Forms.TextBox()
        Me.txtbxMiddle = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtbxAddStreet = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtbxContact = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.txtbxAddBrgy = New System.Windows.Forms.TextBox()
        Me.txtbxAddCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassword.Location = New System.Drawing.Point(98, 51)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxPassword.Size = New System.Drawing.Size(294, 27)
        Me.txtbxPassword.TabIndex = 80
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(10, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 18)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "Password:"
        '
        'txtbxConfirmPass
        '
        Me.txtbxConfirmPass.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxConfirmPass.Location = New System.Drawing.Point(167, 80)
        Me.txtbxConfirmPass.Name = "txtbxConfirmPass"
        Me.txtbxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxConfirmPass.Size = New System.Drawing.Size(225, 27)
        Me.txtbxConfirmPass.TabIndex = 78
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label29.Location = New System.Drawing.Point(10, 85)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(161, 18)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "Confirm Password:"
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUsername.Location = New System.Drawing.Point(106, 21)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(286, 27)
        Me.txtbxUsername.TabIndex = 70
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(346, 529)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(163, 18)
        Me.Label27.TabIndex = 115
        Me.Label27.Text = "Employee Number:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label30.Location = New System.Drawing.Point(10, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(97, 18)
        Me.Label30.TabIndex = 69
        Me.Label30.Text = "Username:"
        '
        'Timer1
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtbxPassword)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtbxConfirmPass)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txtbxUsername)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(857, 546)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 114)
        Me.GroupBox4.TabIndex = 132
        Me.GroupBox4.TabStop = False
        '
        'pcbx_back
        '
        Me.pcbx_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_back.Image = CType(resources.GetObject("pcbx_back.Image"), System.Drawing.Image)
        Me.pcbx_back.Location = New System.Drawing.Point(378, 121)
        Me.pcbx_back.Name = "pcbx_back"
        Me.pcbx_back.Size = New System.Drawing.Size(55, 53)
        Me.pcbx_back.TabIndex = 127
        Me.pcbx_back.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnSearch.Location = New System.Drawing.Point(1071, 240)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(186, 32)
        Me.btnSearch.TabIndex = 126
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.txtbxSearch.Location = New System.Drawing.Point(559, 241)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(506, 33)
        Me.txtbxSearch.TabIndex = 125
        '
        'cmbxSearch
        '
        Me.cmbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxSearch.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.cmbxSearch.FormattingEnabled = True
        Me.cmbxSearch.Items.AddRange(New Object() {"NAME", "ACCOUNT TYPE", "CONTACT NUMBER", "EMAIL"})
        Me.cmbxSearch.Location = New System.Drawing.Point(240, 241)
        Me.cmbxSearch.Name = "cmbxSearch"
        Me.cmbxSearch.Size = New System.Drawing.Size(313, 33)
        Me.cmbxSearch.TabIndex = 124
        Me.cmbxSearch.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 25.0!)
        Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label3.Location = New System.Drawing.Point(22, 237)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(228, 41)
        Me.label3.TabIndex = 123
        Me.label3.Text = "SEARCH BY:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Baron Neue", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(425, 78)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(537, 96)
        Me.label9.TabIndex = 122
        Me.label9.Text = "accounts"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1043, 208)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 25)
        Me.lblDate.TabIndex = 121
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1185, 208)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 25)
        Me.lblTime.TabIndex = 120
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1189, 183)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 25)
        Me.lblUsername.TabIndex = 119
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(965, 28)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 149)
        Me.pictureBox1.TabIndex = 118
        Me.pictureBox1.TabStop = False
        '
        'txtbxNumber
        '
        Me.txtbxNumber.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNumber.Location = New System.Drawing.Point(512, 522)
        Me.txtbxNumber.Name = "txtbxNumber"
        Me.txtbxNumber.Size = New System.Drawing.Size(208, 27)
        Me.txtbxNumber.TabIndex = 116
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(859, 678)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(398, 47)
        Me.btnDelete.TabIndex = 135
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(440, 678)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(413, 47)
        Me.btnUpdate.TabIndex = 134
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(23, 678)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(411, 47)
        Me.btnAdd.TabIndex = 133
        Me.btnAdd.Text = "&ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(20, 529)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 18)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Employee Type:"
        '
        'GridViewAccounts
        '
        Me.GridViewAccounts.AllowUserToAddRows = False
        Me.GridViewAccounts.AllowUserToDeleteRows = False
        Me.GridViewAccounts.AllowUserToResizeColumns = False
        Me.GridViewAccounts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridViewAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridViewAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridViewAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridViewAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridViewAccounts.ColumnHeadersHeight = 30
        Me.GridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridViewAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewAccounts.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridViewAccounts.Location = New System.Drawing.Point(18, 278)
        Me.GridViewAccounts.Name = "GridViewAccounts"
        Me.GridViewAccounts.ReadOnly = True
        Me.GridViewAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridViewAccounts.RowHeadersVisible = False
        Me.GridViewAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.GridViewAccounts.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridViewAccounts.RowTemplate.Height = 30
        Me.GridViewAccounts.RowTemplate.ReadOnly = True
        Me.GridViewAccounts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewAccounts.ShowEditingIcon = False
        Me.GridViewAccounts.Size = New System.Drawing.Size(1252, 238)
        Me.GridViewAccounts.TabIndex = 138
        '
        'cmbxType
        '
        Me.cmbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbxType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxType.Items.AddRange(New Object() {"admin", "employee"})
        Me.cmbxType.Location = New System.Drawing.Point(153, 526)
        Me.cmbxType.Name = "cmbxType"
        Me.cmbxType.Size = New System.Drawing.Size(187, 26)
        Me.cmbxType.TabIndex = 180
        Me.cmbxType.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(5, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 18)
        Me.Label26.TabIndex = 71
        Me.Label26.Text = "Name:"
        '
        'txtbxLastName
        '
        Me.txtbxLastName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLastName.Location = New System.Drawing.Point(69, 17)
        Me.txtbxLastName.Name = "txtbxLastName"
        Me.txtbxLastName.Size = New System.Drawing.Size(310, 27)
        Me.txtbxLastName.TabIndex = 72
        Me.txtbxLastName.Text = "Last Name"
        '
        'txtbxFirstName
        '
        Me.txtbxFirstName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFirstName.Location = New System.Drawing.Point(383, 18)
        Me.txtbxFirstName.Name = "txtbxFirstName"
        Me.txtbxFirstName.Size = New System.Drawing.Size(341, 27)
        Me.txtbxFirstName.TabIndex = 73
        Me.txtbxFirstName.Text = "First Name"
        '
        'txtbxMiddle
        '
        Me.txtbxMiddle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMiddle.Location = New System.Drawing.Point(728, 19)
        Me.txtbxMiddle.Name = "txtbxMiddle"
        Me.txtbxMiddle.Size = New System.Drawing.Size(94, 27)
        Me.txtbxMiddle.TabIndex = 74
        Me.txtbxMiddle.Text = "M.I."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(5, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Address:"
        '
        'txtbxAddStreet
        '
        Me.txtbxAddStreet.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddStreet.Location = New System.Drawing.Point(85, 47)
        Me.txtbxAddStreet.Name = "txtbxAddStreet"
        Me.txtbxAddStreet.Size = New System.Drawing.Size(233, 27)
        Me.txtbxAddStreet.TabIndex = 76
        Me.txtbxAddStreet.Text = "Street"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(5, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 18)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "Contact No:"
        '
        'txtbxContact
        '
        Me.txtbxContact.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContact.Location = New System.Drawing.Point(117, 77)
        Me.txtbxContact.MaxLength = 10
        Me.txtbxContact.Name = "txtbxContact"
        Me.txtbxContact.Size = New System.Drawing.Size(292, 27)
        Me.txtbxContact.TabIndex = 78
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(415, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 18)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Email:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(475, 77)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(347, 27)
        Me.txtbxEmail.TabIndex = 80
        '
        'txtbxAddBrgy
        '
        Me.txtbxAddBrgy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddBrgy.Location = New System.Drawing.Point(322, 47)
        Me.txtbxAddBrgy.Name = "txtbxAddBrgy"
        Me.txtbxAddBrgy.Size = New System.Drawing.Size(277, 27)
        Me.txtbxAddBrgy.TabIndex = 87
        Me.txtbxAddBrgy.Text = "Baranggay"
        '
        'txtbxAddCity
        '
        Me.txtbxAddCity.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddCity.Location = New System.Drawing.Point(602, 47)
        Me.txtbxAddCity.Name = "txtbxAddCity"
        Me.txtbxAddCity.Size = New System.Drawing.Size(220, 27)
        Me.txtbxAddCity.TabIndex = 88
        Me.txtbxAddCity.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(73, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 91
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtbxAddCity)
        Me.GroupBox3.Controls.Add(Me.txtbxAddBrgy)
        Me.GroupBox3.Controls.Add(Me.txtbxEmail)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtbxContact)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtbxAddStreet)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtbxMiddle)
        Me.GroupBox3.Controls.Add(Me.txtbxFirstName)
        Me.GroupBox3.Controls.Add(Me.txtbxLastName)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(22, 547)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(829, 113)
        Me.GroupBox3.TabIndex = 131
        Me.GroupBox3.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Location = New System.Drawing.Point(29, 190)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 43)
        Me.btnRefresh.TabIndex = 189
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1060, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Username:"
        '
        'Accounts_Adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 765)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbxType)
        Me.Controls.Add(Me.GridViewAccounts)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.pcbx_back)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.cmbxSearch)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.txtbxNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Accounts_Adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts_Adm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtbxPassword As TextBox
    Private WithEvents Label28 As Label
    Private WithEvents txtbxConfirmPass As TextBox
    Private WithEvents Label29 As Label
    Private WithEvents txtbxUsername As TextBox
    Private WithEvents Label27 As Label
    Private WithEvents Label30 As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents GroupBox4 As GroupBox
    Friend WithEvents pcbx_back As PictureBox
    Private WithEvents btnSearch As Button
    Private WithEvents txtbxSearch As TextBox
    Private WithEvents cmbxSearch As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents label9 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents txtbxNumber As TextBox
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Private WithEvents Label8 As Label
    Private WithEvents GridViewAccounts As DataGridView
    Private WithEvents cmbxType As ComboBox
    Private WithEvents Label26 As Label
    Private WithEvents txtbxLastName As TextBox
    Private WithEvents txtbxFirstName As TextBox
    Private WithEvents txtbxMiddle As TextBox
    Private WithEvents Label24 As Label
    Private WithEvents txtbxAddStreet As TextBox
    Private WithEvents Label23 As Label
    Private WithEvents txtbxContact As TextBox
    Private WithEvents Label20 As Label
    Private WithEvents txtbxEmail As TextBox
    Private WithEvents txtbxAddBrgy As TextBox
    Private WithEvents txtbxAddCity As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents btnRefresh As Button
    Private WithEvents Label2 As Label
End Class
