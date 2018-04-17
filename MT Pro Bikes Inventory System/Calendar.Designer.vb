<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calendar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calendar))
        Me.pcbx_back = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.grpFeb = New System.Windows.Forms.GroupBox()
        Me.lblFeb_Supplier = New System.Windows.Forms.Label()
        Me.lblFeb_Attend = New System.Windows.Forms.Label()
        Me.lblFeb_Date = New System.Windows.Forms.Label()
        Me.lblFeb_Name = New System.Windows.Forms.Label()
        Me.cmbxFeb = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblJan_Supplier = New System.Windows.Forms.Label()
        Me.lblJan_Attend = New System.Windows.Forms.Label()
        Me.lblJan_Name = New System.Windows.Forms.Label()
        Me.lblJan_Date = New System.Windows.Forms.Label()
        Me.cmbxJan = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.grpMar = New System.Windows.Forms.GroupBox()
        Me.lblMar_Supplier = New System.Windows.Forms.Label()
        Me.lblMar_Attend = New System.Windows.Forms.Label()
        Me.lblMar_Date = New System.Windows.Forms.Label()
        Me.lblMar_Name = New System.Windows.Forms.Label()
        Me.cmbxMar = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApr_Name = New System.Windows.Forms.Label()
        Me.lblApr_Date = New System.Windows.Forms.Label()
        Me.lblApr_Attend = New System.Windows.Forms.Label()
        Me.lblApr_Supplier = New System.Windows.Forms.Label()
        Me.cmbxApr = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtbxEvent_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpMonthOrd = New System.Windows.Forms.DateTimePicker()
        Me.cmbxEventType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEventDesc = New System.Windows.Forms.TextBox()
        Me.dtpMonthRec = New System.Windows.Forms.DateTimePicker()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAttendees = New System.Windows.Forms.TextBox()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxAug = New System.Windows.Forms.ComboBox()
        Me.lblAug_Supplier = New System.Windows.Forms.Label()
        Me.lblAug_Attend = New System.Windows.Forms.Label()
        Me.lblAug_Date = New System.Windows.Forms.Label()
        Me.lblAug_Name = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblJune_Supplier = New System.Windows.Forms.Label()
        Me.lblJune_Attend = New System.Windows.Forms.Label()
        Me.lblJune_Date = New System.Windows.Forms.Label()
        Me.lblJune_Name = New System.Windows.Forms.Label()
        Me.cmbxJune = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblMay_Supplier = New System.Windows.Forms.Label()
        Me.lblMay_Attend = New System.Windows.Forms.Label()
        Me.lblMay_Name = New System.Windows.Forms.Label()
        Me.lblMay_Date = New System.Windows.Forms.Label()
        Me.cmbxMay = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblJuly_Supplier = New System.Windows.Forms.Label()
        Me.lblJuly_Attend = New System.Windows.Forms.Label()
        Me.lblJuly_Date = New System.Windows.Forms.Label()
        Me.lblJuly_Name = New System.Windows.Forms.Label()
        Me.cmbxJuly = New System.Windows.Forms.ComboBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmbxDec = New System.Windows.Forms.ComboBox()
        Me.lblDec_Supplier = New System.Windows.Forms.Label()
        Me.lblDec_Attend = New System.Windows.Forms.Label()
        Me.lblDec_Date = New System.Windows.Forms.Label()
        Me.lblDec_Name = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblOct_Supplier = New System.Windows.Forms.Label()
        Me.lblOct_Attend = New System.Windows.Forms.Label()
        Me.lblOct_Date = New System.Windows.Forms.Label()
        Me.lblOct_Name = New System.Windows.Forms.Label()
        Me.cmbxOct = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblSep_Supplier = New System.Windows.Forms.Label()
        Me.lblSep_Attend = New System.Windows.Forms.Label()
        Me.lblSep_Name = New System.Windows.Forms.Label()
        Me.lblSep_Date = New System.Windows.Forms.Label()
        Me.cmbxSep = New System.Windows.Forms.ComboBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblNov_Supplier = New System.Windows.Forms.Label()
        Me.lblNov_Attend = New System.Windows.Forms.Label()
        Me.lblNov_Date = New System.Windows.Forms.Label()
        Me.lblNov_Name = New System.Windows.Forms.Label()
        Me.cmbxNov = New System.Windows.Forms.ComboBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFeb.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpMar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbx_back
        '
        Me.pcbx_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_back.Image = CType(resources.GetObject("pcbx_back.Image"), System.Drawing.Image)
        Me.pcbx_back.Location = New System.Drawing.Point(391, 110)
        Me.pcbx_back.Name = "pcbx_back"
        Me.pcbx_back.Size = New System.Drawing.Size(55, 53)
        Me.pcbx_back.TabIndex = 171
        Me.pcbx_back.TabStop = False
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1047, 204)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 25)
        Me.lblDate.TabIndex = 167
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1187, 204)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 25)
        Me.lblTime.TabIndex = 166
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1191, 179)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 25)
        Me.lblUsername.TabIndex = 165
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(967, 27)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 149)
        Me.pictureBox1.TabIndex = 164
        Me.pictureBox1.TabStop = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label9.Font = New System.Drawing.Font("Baron Neue", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(452, 65)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(512, 96)
        Me.label9.TabIndex = 163
        Me.label9.Text = "calendar"
        '
        'grpFeb
        '
        Me.grpFeb.Controls.Add(Me.lblFeb_Supplier)
        Me.grpFeb.Controls.Add(Me.lblFeb_Attend)
        Me.grpFeb.Controls.Add(Me.lblFeb_Date)
        Me.grpFeb.Controls.Add(Me.lblFeb_Name)
        Me.grpFeb.Controls.Add(Me.cmbxFeb)
        Me.grpFeb.Controls.Add(Me.Label15)
        Me.grpFeb.Controls.Add(Me.Label16)
        Me.grpFeb.Controls.Add(Me.Label4)
        Me.grpFeb.Controls.Add(Me.Label5)
        Me.grpFeb.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFeb.Location = New System.Drawing.Point(248, 175)
        Me.grpFeb.Name = "grpFeb"
        Me.grpFeb.Size = New System.Drawing.Size(222, 192)
        Me.grpFeb.TabIndex = 184
        Me.grpFeb.TabStop = False
        Me.grpFeb.Text = "February"
        '
        'lblFeb_Supplier
        '
        Me.lblFeb_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeb_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFeb_Supplier.Location = New System.Drawing.Point(32, 115)
        Me.lblFeb_Supplier.Name = "lblFeb_Supplier"
        Me.lblFeb_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblFeb_Supplier.TabIndex = 187
        Me.lblFeb_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFeb_Attend
        '
        Me.lblFeb_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeb_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFeb_Attend.Location = New System.Drawing.Point(90, 69)
        Me.lblFeb_Attend.Name = "lblFeb_Attend"
        Me.lblFeb_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblFeb_Attend.TabIndex = 182
        '
        'lblFeb_Date
        '
        Me.lblFeb_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeb_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFeb_Date.Location = New System.Drawing.Point(97, 50)
        Me.lblFeb_Date.Name = "lblFeb_Date"
        Me.lblFeb_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblFeb_Date.TabIndex = 181
        '
        'lblFeb_Name
        '
        Me.lblFeb_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeb_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFeb_Name.Location = New System.Drawing.Point(101, 30)
        Me.lblFeb_Name.Name = "lblFeb_Name"
        Me.lblFeb_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblFeb_Name.TabIndex = 180
        '
        'cmbxFeb
        '
        Me.cmbxFeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFeb.Location = New System.Drawing.Point(41, 155)
        Me.cmbxFeb.Name = "cmbxFeb"
        Me.cmbxFeb.Size = New System.Drawing.Size(156, 26)
        Me.cmbxFeb.TabIndex = 179
        Me.cmbxFeb.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(63, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 18)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "Supplier: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(8, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 18)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Attendees: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(7, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 18)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Event Date: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Event Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblJan_Supplier)
        Me.GroupBox3.Controls.Add(Me.lblJan_Attend)
        Me.GroupBox3.Controls.Add(Me.lblJan_Name)
        Me.GroupBox3.Controls.Add(Me.lblJan_Date)
        Me.GroupBox3.Controls.Add(Me.cmbxJan)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(20, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox3.TabIndex = 183
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "January"
        '
        'lblJan_Supplier
        '
        Me.lblJan_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJan_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJan_Supplier.Location = New System.Drawing.Point(30, 115)
        Me.lblJan_Supplier.Name = "lblJan_Supplier"
        Me.lblJan_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblJan_Supplier.TabIndex = 186
        Me.lblJan_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJan_Attend
        '
        Me.lblJan_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJan_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJan_Attend.Location = New System.Drawing.Point(93, 75)
        Me.lblJan_Attend.Name = "lblJan_Attend"
        Me.lblJan_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblJan_Attend.TabIndex = 162
        '
        'lblJan_Name
        '
        Me.lblJan_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJan_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJan_Name.Location = New System.Drawing.Point(100, 31)
        Me.lblJan_Name.Name = "lblJan_Name"
        Me.lblJan_Name.Size = New System.Drawing.Size(116, 20)
        Me.lblJan_Name.TabIndex = 161
        '
        'lblJan_Date
        '
        Me.lblJan_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJan_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJan_Date.Location = New System.Drawing.Point(98, 53)
        Me.lblJan_Date.Name = "lblJan_Date"
        Me.lblJan_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblJan_Date.TabIndex = 160
        '
        'cmbxJan
        '
        Me.cmbxJan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxJan.Location = New System.Drawing.Point(37, 155)
        Me.cmbxJan.Name = "cmbxJan"
        Me.cmbxJan.Size = New System.Drawing.Size(156, 26)
        Me.cmbxJan.TabIndex = 178
        Me.cmbxJan.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(67, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 18)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "Supplier: "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(6, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 18)
        Me.Label26.TabIndex = 153
        Me.Label26.Text = "Attendees: "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(6, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 18)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Event Date: "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(5, 30)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 18)
        Me.Label28.TabIndex = 151
        Me.Label28.Text = "Event Name:"
        '
        'grpMar
        '
        Me.grpMar.Controls.Add(Me.lblMar_Supplier)
        Me.grpMar.Controls.Add(Me.lblMar_Attend)
        Me.grpMar.Controls.Add(Me.lblMar_Date)
        Me.grpMar.Controls.Add(Me.lblMar_Name)
        Me.grpMar.Controls.Add(Me.cmbxMar)
        Me.grpMar.Controls.Add(Me.Label29)
        Me.grpMar.Controls.Add(Me.Label30)
        Me.grpMar.Controls.Add(Me.Label31)
        Me.grpMar.Controls.Add(Me.Label32)
        Me.grpMar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMar.Location = New System.Drawing.Point(476, 175)
        Me.grpMar.Name = "grpMar"
        Me.grpMar.Size = New System.Drawing.Size(222, 192)
        Me.grpMar.TabIndex = 185
        Me.grpMar.TabStop = False
        Me.grpMar.Text = "March"
        '
        'lblMar_Supplier
        '
        Me.lblMar_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMar_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMar_Supplier.Location = New System.Drawing.Point(27, 114)
        Me.lblMar_Supplier.Name = "lblMar_Supplier"
        Me.lblMar_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblMar_Supplier.TabIndex = 186
        Me.lblMar_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMar_Attend
        '
        Me.lblMar_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMar_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMar_Attend.Location = New System.Drawing.Point(93, 69)
        Me.lblMar_Attend.Name = "lblMar_Attend"
        Me.lblMar_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblMar_Attend.TabIndex = 183
        '
        'lblMar_Date
        '
        Me.lblMar_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMar_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMar_Date.Location = New System.Drawing.Point(94, 49)
        Me.lblMar_Date.Name = "lblMar_Date"
        Me.lblMar_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblMar_Date.TabIndex = 182
        '
        'lblMar_Name
        '
        Me.lblMar_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMar_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMar_Name.Location = New System.Drawing.Point(100, 28)
        Me.lblMar_Name.Name = "lblMar_Name"
        Me.lblMar_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblMar_Name.TabIndex = 181
        '
        'cmbxMar
        '
        Me.cmbxMar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxMar.Location = New System.Drawing.Point(38, 155)
        Me.cmbxMar.Name = "cmbxMar"
        Me.cmbxMar.Size = New System.Drawing.Size(156, 26)
        Me.cmbxMar.TabIndex = 180
        Me.cmbxMar.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label29.Location = New System.Drawing.Point(72, 92)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 18)
        Me.Label29.TabIndex = 154
        Me.Label29.Text = "Supplier: "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label30.Location = New System.Drawing.Point(7, 70)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(87, 18)
        Me.Label30.TabIndex = 153
        Me.Label30.Text = "Attendees: "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(6, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 18)
        Me.Label31.TabIndex = 152
        Me.Label31.Text = "Event Date: "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label32.Location = New System.Drawing.Point(5, 29)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(97, 18)
        Me.Label32.TabIndex = 151
        Me.Label32.Text = "Event Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(5, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 18)
        Me.Label24.TabIndex = 151
        Me.Label24.Text = "Event Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(7, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Event Date: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(7, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Attendees: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(77, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Supplier: "
        '
        'lblApr_Name
        '
        Me.lblApr_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApr_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblApr_Name.Location = New System.Drawing.Point(98, 27)
        Me.lblApr_Name.Name = "lblApr_Name"
        Me.lblApr_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblApr_Name.TabIndex = 182
        '
        'lblApr_Date
        '
        Me.lblApr_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApr_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblApr_Date.Location = New System.Drawing.Point(97, 48)
        Me.lblApr_Date.Name = "lblApr_Date"
        Me.lblApr_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblApr_Date.TabIndex = 183
        '
        'lblApr_Attend
        '
        Me.lblApr_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApr_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblApr_Attend.Location = New System.Drawing.Point(94, 69)
        Me.lblApr_Attend.Name = "lblApr_Attend"
        Me.lblApr_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblApr_Attend.TabIndex = 184
        '
        'lblApr_Supplier
        '
        Me.lblApr_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApr_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblApr_Supplier.Location = New System.Drawing.Point(31, 116)
        Me.lblApr_Supplier.Name = "lblApr_Supplier"
        Me.lblApr_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblApr_Supplier.TabIndex = 185
        Me.lblApr_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxApr
        '
        Me.cmbxApr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxApr.Location = New System.Drawing.Point(42, 156)
        Me.cmbxApr.Name = "cmbxApr"
        Me.cmbxApr.Size = New System.Drawing.Size(156, 26)
        Me.cmbxApr.TabIndex = 188
        Me.cmbxApr.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbxApr)
        Me.GroupBox4.Controls.Add(Me.lblApr_Supplier)
        Me.GroupBox4.Controls.Add(Me.lblApr_Attend)
        Me.GroupBox4.Controls.Add(Me.lblApr_Date)
        Me.GroupBox4.Controls.Add(Me.lblApr_Name)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(704, 175)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox4.TabIndex = 186
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "April"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Location = New System.Drawing.Point(1221, 232)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 43)
        Me.btnRefresh.TabIndex = 187
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtbxEvent_ID)
        Me.grpInfo.Controls.Add(Me.Label7)
        Me.grpInfo.Controls.Add(Me.dtpMonthOrd)
        Me.grpInfo.Controls.Add(Me.cmbxEventType)
        Me.grpInfo.Controls.Add(Me.Label6)
        Me.grpInfo.Controls.Add(Me.btnDelete)
        Me.grpInfo.Controls.Add(Me.btnUpdate)
        Me.grpInfo.Controls.Add(Me.btnAdd)
        Me.grpInfo.Controls.Add(Me.Label19)
        Me.grpInfo.Controls.Add(Me.Label10)
        Me.grpInfo.Controls.Add(Me.txtSupplier)
        Me.grpInfo.Controls.Add(Me.Label11)
        Me.grpInfo.Controls.Add(Me.Label12)
        Me.grpInfo.Controls.Add(Me.Label13)
        Me.grpInfo.Controls.Add(Me.Label17)
        Me.grpInfo.Controls.Add(Me.Label18)
        Me.grpInfo.Controls.Add(Me.txtEventDesc)
        Me.grpInfo.Controls.Add(Me.dtpMonthRec)
        Me.grpInfo.Controls.Add(Me.dtpEventDate)
        Me.grpInfo.Controls.Add(Me.txtAttendees)
        Me.grpInfo.Controls.Add(Me.txtEventName)
        Me.grpInfo.Location = New System.Drawing.Point(942, 276)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(388, 423)
        Me.grpInfo.TabIndex = 188
        Me.grpInfo.TabStop = False
        '
        'txtbxEvent_ID
        '
        Me.txtbxEvent_ID.Enabled = False
        Me.txtbxEvent_ID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEvent_ID.Location = New System.Drawing.Point(287, 15)
        Me.txtbxEvent_ID.Name = "txtbxEvent_ID"
        Me.txtbxEvent_ID.Size = New System.Drawing.Size(95, 26)
        Me.txtbxEvent_ID.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(254, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 22)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "ID:"
        '
        'dtpMonthOrd
        '
        Me.dtpMonthOrd.CustomFormat = "dd/mm/yyyy"
        Me.dtpMonthOrd.Enabled = False
        Me.dtpMonthOrd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthOrd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonthOrd.Location = New System.Drawing.Point(155, 190)
        Me.dtpMonthOrd.Name = "dtpMonthOrd"
        Me.dtpMonthOrd.Size = New System.Drawing.Size(229, 26)
        Me.dtpMonthOrd.TabIndex = 190
        '
        'cmbxEventType
        '
        Me.cmbxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxEventType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxEventType.Items.AddRange(New Object() {"Company Event", "Procure Product"})
        Me.cmbxEventType.Location = New System.Drawing.Point(115, 16)
        Me.cmbxEventType.Name = "cmbxEventType"
        Me.cmbxEventType.Size = New System.Drawing.Size(136, 26)
        Me.cmbxEventType.TabIndex = 189
        Me.cmbxEventType.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(2, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Event Type:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(59, 369)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(272, 47)
        Me.btnDelete.TabIndex = 164
        Me.btnDelete.Text = "&DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Lime
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(61, 314)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(270, 47)
        Me.btnUpdate.TabIndex = 163
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(61, 259)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(270, 47)
        Me.btnAdd.TabIndex = 162
        Me.btnAdd.Text = "&ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(2, 218)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 22)
        Me.Label19.TabIndex = 160
        Me.Label19.Text = "Month Received:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(2, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 22)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Month Ordered:"
        '
        'txtSupplier
        '
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(88, 162)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(295, 26)
        Me.txtSupplier.TabIndex = 158
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(1, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 22)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Supplier:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(3, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 22)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Attendees:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(1, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 22)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "Event Description:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(2, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 22)
        Me.Label17.TabIndex = 154
        Me.Label17.Text = "Event Date:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(2, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 22)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "Event Name:"
        '
        'txtEventDesc
        '
        Me.txtEventDesc.Enabled = False
        Me.txtEventDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventDesc.Location = New System.Drawing.Point(165, 135)
        Me.txtEventDesc.Name = "txtEventDesc"
        Me.txtEventDesc.Size = New System.Drawing.Size(217, 26)
        Me.txtEventDesc.TabIndex = 152
        '
        'dtpMonthRec
        '
        Me.dtpMonthRec.CustomFormat = "dd/mm/yyyy"
        Me.dtpMonthRec.Enabled = False
        Me.dtpMonthRec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthRec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonthRec.Location = New System.Drawing.Point(155, 217)
        Me.dtpMonthRec.Name = "dtpMonthRec"
        Me.dtpMonthRec.Size = New System.Drawing.Size(229, 26)
        Me.dtpMonthRec.TabIndex = 151
        '
        'dtpEventDate
        '
        Me.dtpEventDate.CustomFormat = "dd/mm/yyyy"
        Me.dtpEventDate.Enabled = False
        Me.dtpEventDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventDate.Location = New System.Drawing.Point(110, 79)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(272, 26)
        Me.dtpEventDate.TabIndex = 149
        '
        'txtAttendees
        '
        Me.txtAttendees.Enabled = False
        Me.txtAttendees.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttendees.Location = New System.Drawing.Point(104, 107)
        Me.txtAttendees.Name = "txtAttendees"
        Me.txtAttendees.Size = New System.Drawing.Size(278, 26)
        Me.txtAttendees.TabIndex = 148
        '
        'txtEventName
        '
        Me.txtEventName.Enabled = False
        Me.txtEventName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.Location = New System.Drawing.Point(119, 48)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(265, 26)
        Me.txtEventName.TabIndex = 147
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbxAug)
        Me.GroupBox1.Controls.Add(Me.lblAug_Supplier)
        Me.GroupBox1.Controls.Add(Me.lblAug_Attend)
        Me.GroupBox1.Controls.Add(Me.lblAug_Date)
        Me.GroupBox1.Controls.Add(Me.lblAug_Name)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(704, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "August"
        '
        'cmbxAug
        '
        Me.cmbxAug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxAug.Location = New System.Drawing.Point(42, 156)
        Me.cmbxAug.Name = "cmbxAug"
        Me.cmbxAug.Size = New System.Drawing.Size(156, 26)
        Me.cmbxAug.TabIndex = 188
        Me.cmbxAug.TabStop = False
        '
        'lblAug_Supplier
        '
        Me.lblAug_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAug_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAug_Supplier.Location = New System.Drawing.Point(31, 116)
        Me.lblAug_Supplier.Name = "lblAug_Supplier"
        Me.lblAug_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblAug_Supplier.TabIndex = 185
        Me.lblAug_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAug_Attend
        '
        Me.lblAug_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAug_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAug_Attend.Location = New System.Drawing.Point(94, 69)
        Me.lblAug_Attend.Name = "lblAug_Attend"
        Me.lblAug_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblAug_Attend.TabIndex = 184
        '
        'lblAug_Date
        '
        Me.lblAug_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAug_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAug_Date.Location = New System.Drawing.Point(97, 48)
        Me.lblAug_Date.Name = "lblAug_Date"
        Me.lblAug_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblAug_Date.TabIndex = 183
        '
        'lblAug_Name
        '
        Me.lblAug_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAug_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAug_Name.Location = New System.Drawing.Point(98, 27)
        Me.lblAug_Name.Name = "lblAug_Name"
        Me.lblAug_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblAug_Name.TabIndex = 182
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(77, 90)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 18)
        Me.Label22.TabIndex = 154
        Me.Label22.Text = "Supplier: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(7, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 18)
        Me.Label23.TabIndex = 153
        Me.Label23.Text = "Attendees: "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(7, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(93, 18)
        Me.Label33.TabIndex = 152
        Me.Label33.Text = "Event Date: "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(5, 28)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 18)
        Me.Label34.TabIndex = 151
        Me.Label34.Text = "Event Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblJune_Supplier)
        Me.GroupBox2.Controls.Add(Me.lblJune_Attend)
        Me.GroupBox2.Controls.Add(Me.lblJune_Date)
        Me.GroupBox2.Controls.Add(Me.lblJune_Name)
        Me.GroupBox2.Controls.Add(Me.cmbxJune)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(248, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox2.TabIndex = 190
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "June"
        '
        'lblJune_Supplier
        '
        Me.lblJune_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJune_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJune_Supplier.Location = New System.Drawing.Point(32, 115)
        Me.lblJune_Supplier.Name = "lblJune_Supplier"
        Me.lblJune_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblJune_Supplier.TabIndex = 187
        Me.lblJune_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJune_Attend
        '
        Me.lblJune_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJune_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJune_Attend.Location = New System.Drawing.Point(90, 69)
        Me.lblJune_Attend.Name = "lblJune_Attend"
        Me.lblJune_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblJune_Attend.TabIndex = 182
        '
        'lblJune_Date
        '
        Me.lblJune_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJune_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJune_Date.Location = New System.Drawing.Point(97, 50)
        Me.lblJune_Date.Name = "lblJune_Date"
        Me.lblJune_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblJune_Date.TabIndex = 181
        '
        'lblJune_Name
        '
        Me.lblJune_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJune_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJune_Name.Location = New System.Drawing.Point(101, 30)
        Me.lblJune_Name.Name = "lblJune_Name"
        Me.lblJune_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblJune_Name.TabIndex = 180
        '
        'cmbxJune
        '
        Me.cmbxJune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxJune.Location = New System.Drawing.Point(41, 155)
        Me.cmbxJune.Name = "cmbxJune"
        Me.cmbxJune.Size = New System.Drawing.Size(156, 26)
        Me.cmbxJune.TabIndex = 179
        Me.cmbxJune.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label39.Location = New System.Drawing.Point(63, 92)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(74, 18)
        Me.Label39.TabIndex = 154
        Me.Label39.Text = "Supplier: "
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label40.Location = New System.Drawing.Point(8, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(87, 18)
        Me.Label40.TabIndex = 153
        Me.Label40.Text = "Attendees: "
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label41.Location = New System.Drawing.Point(7, 51)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(93, 18)
        Me.Label41.TabIndex = 152
        Me.Label41.Text = "Event Date: "
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label42.Location = New System.Drawing.Point(6, 30)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(97, 18)
        Me.Label42.TabIndex = 151
        Me.Label42.Text = "Event Name:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblMay_Supplier)
        Me.GroupBox5.Controls.Add(Me.lblMay_Attend)
        Me.GroupBox5.Controls.Add(Me.lblMay_Name)
        Me.GroupBox5.Controls.Add(Me.lblMay_Date)
        Me.GroupBox5.Controls.Add(Me.cmbxMay)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 373)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox5.TabIndex = 189
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "May"
        '
        'lblMay_Supplier
        '
        Me.lblMay_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMay_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMay_Supplier.Location = New System.Drawing.Point(30, 115)
        Me.lblMay_Supplier.Name = "lblMay_Supplier"
        Me.lblMay_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblMay_Supplier.TabIndex = 186
        Me.lblMay_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMay_Attend
        '
        Me.lblMay_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMay_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMay_Attend.Location = New System.Drawing.Point(93, 75)
        Me.lblMay_Attend.Name = "lblMay_Attend"
        Me.lblMay_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblMay_Attend.TabIndex = 162
        '
        'lblMay_Name
        '
        Me.lblMay_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMay_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMay_Name.Location = New System.Drawing.Point(100, 31)
        Me.lblMay_Name.Name = "lblMay_Name"
        Me.lblMay_Name.Size = New System.Drawing.Size(116, 20)
        Me.lblMay_Name.TabIndex = 161
        '
        'lblMay_Date
        '
        Me.lblMay_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMay_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMay_Date.Location = New System.Drawing.Point(98, 53)
        Me.lblMay_Date.Name = "lblMay_Date"
        Me.lblMay_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblMay_Date.TabIndex = 160
        '
        'cmbxMay
        '
        Me.cmbxMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxMay.Location = New System.Drawing.Point(37, 155)
        Me.cmbxMay.Name = "cmbxMay"
        Me.cmbxMay.Size = New System.Drawing.Size(156, 26)
        Me.cmbxMay.TabIndex = 178
        Me.cmbxMay.TabStop = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label47.Location = New System.Drawing.Point(67, 95)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(74, 18)
        Me.Label47.TabIndex = 154
        Me.Label47.Text = "Supplier: "
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label48.Location = New System.Drawing.Point(6, 74)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(87, 18)
        Me.Label48.TabIndex = 153
        Me.Label48.Text = "Attendees: "
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label49.Location = New System.Drawing.Point(6, 53)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(93, 18)
        Me.Label49.TabIndex = 152
        Me.Label49.Text = "Event Date: "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label50.Location = New System.Drawing.Point(5, 30)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(97, 18)
        Me.Label50.TabIndex = 151
        Me.Label50.Text = "Event Name:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblJuly_Supplier)
        Me.GroupBox6.Controls.Add(Me.lblJuly_Attend)
        Me.GroupBox6.Controls.Add(Me.lblJuly_Date)
        Me.GroupBox6.Controls.Add(Me.lblJuly_Name)
        Me.GroupBox6.Controls.Add(Me.cmbxJuly)
        Me.GroupBox6.Controls.Add(Me.Label55)
        Me.GroupBox6.Controls.Add(Me.Label56)
        Me.GroupBox6.Controls.Add(Me.Label57)
        Me.GroupBox6.Controls.Add(Me.Label58)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(476, 373)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox6.TabIndex = 191
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "July"
        '
        'lblJuly_Supplier
        '
        Me.lblJuly_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuly_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJuly_Supplier.Location = New System.Drawing.Point(27, 114)
        Me.lblJuly_Supplier.Name = "lblJuly_Supplier"
        Me.lblJuly_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblJuly_Supplier.TabIndex = 186
        Me.lblJuly_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJuly_Attend
        '
        Me.lblJuly_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuly_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJuly_Attend.Location = New System.Drawing.Point(93, 69)
        Me.lblJuly_Attend.Name = "lblJuly_Attend"
        Me.lblJuly_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblJuly_Attend.TabIndex = 183
        '
        'lblJuly_Date
        '
        Me.lblJuly_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuly_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJuly_Date.Location = New System.Drawing.Point(94, 49)
        Me.lblJuly_Date.Name = "lblJuly_Date"
        Me.lblJuly_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblJuly_Date.TabIndex = 182
        '
        'lblJuly_Name
        '
        Me.lblJuly_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuly_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJuly_Name.Location = New System.Drawing.Point(100, 28)
        Me.lblJuly_Name.Name = "lblJuly_Name"
        Me.lblJuly_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblJuly_Name.TabIndex = 181
        '
        'cmbxJuly
        '
        Me.cmbxJuly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxJuly.Location = New System.Drawing.Point(38, 155)
        Me.cmbxJuly.Name = "cmbxJuly"
        Me.cmbxJuly.Size = New System.Drawing.Size(156, 26)
        Me.cmbxJuly.TabIndex = 180
        Me.cmbxJuly.TabStop = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label55.Location = New System.Drawing.Point(72, 92)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(74, 18)
        Me.Label55.TabIndex = 154
        Me.Label55.Text = "Supplier: "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label56.Location = New System.Drawing.Point(7, 70)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(87, 18)
        Me.Label56.TabIndex = 153
        Me.Label56.Text = "Attendees: "
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label57.Location = New System.Drawing.Point(6, 50)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(93, 18)
        Me.Label57.TabIndex = 152
        Me.Label57.Text = "Event Date: "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label58.Location = New System.Drawing.Point(5, 29)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(97, 18)
        Me.Label58.TabIndex = 151
        Me.Label58.Text = "Event Name:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmbxDec)
        Me.GroupBox7.Controls.Add(Me.lblDec_Supplier)
        Me.GroupBox7.Controls.Add(Me.lblDec_Attend)
        Me.GroupBox7.Controls.Add(Me.lblDec_Date)
        Me.GroupBox7.Controls.Add(Me.lblDec_Name)
        Me.GroupBox7.Controls.Add(Me.Label64)
        Me.GroupBox7.Controls.Add(Me.Label65)
        Me.GroupBox7.Controls.Add(Me.Label66)
        Me.GroupBox7.Controls.Add(Me.Label67)
        Me.GroupBox7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(704, 571)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox7.TabIndex = 196
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "December"
        '
        'cmbxDec
        '
        Me.cmbxDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDec.Location = New System.Drawing.Point(42, 156)
        Me.cmbxDec.Name = "cmbxDec"
        Me.cmbxDec.Size = New System.Drawing.Size(156, 26)
        Me.cmbxDec.TabIndex = 188
        Me.cmbxDec.TabStop = False
        '
        'lblDec_Supplier
        '
        Me.lblDec_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDec_Supplier.Location = New System.Drawing.Point(31, 116)
        Me.lblDec_Supplier.Name = "lblDec_Supplier"
        Me.lblDec_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblDec_Supplier.TabIndex = 185
        Me.lblDec_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDec_Attend
        '
        Me.lblDec_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDec_Attend.Location = New System.Drawing.Point(94, 69)
        Me.lblDec_Attend.Name = "lblDec_Attend"
        Me.lblDec_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblDec_Attend.TabIndex = 184
        '
        'lblDec_Date
        '
        Me.lblDec_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDec_Date.Location = New System.Drawing.Point(97, 48)
        Me.lblDec_Date.Name = "lblDec_Date"
        Me.lblDec_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblDec_Date.TabIndex = 183
        '
        'lblDec_Name
        '
        Me.lblDec_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDec_Name.Location = New System.Drawing.Point(98, 27)
        Me.lblDec_Name.Name = "lblDec_Name"
        Me.lblDec_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblDec_Name.TabIndex = 182
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label64.Location = New System.Drawing.Point(77, 90)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(74, 18)
        Me.Label64.TabIndex = 154
        Me.Label64.Text = "Supplier: "
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label65.Location = New System.Drawing.Point(7, 70)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(87, 18)
        Me.Label65.TabIndex = 153
        Me.Label65.Text = "Attendees: "
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label66.Location = New System.Drawing.Point(7, 49)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(93, 18)
        Me.Label66.TabIndex = 152
        Me.Label66.Text = "Event Date: "
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label67.Location = New System.Drawing.Point(5, 28)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(97, 18)
        Me.Label67.TabIndex = 151
        Me.Label67.Text = "Event Name:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblOct_Supplier)
        Me.GroupBox8.Controls.Add(Me.lblOct_Attend)
        Me.GroupBox8.Controls.Add(Me.lblOct_Date)
        Me.GroupBox8.Controls.Add(Me.lblOct_Name)
        Me.GroupBox8.Controls.Add(Me.cmbxOct)
        Me.GroupBox8.Controls.Add(Me.Label72)
        Me.GroupBox8.Controls.Add(Me.Label73)
        Me.GroupBox8.Controls.Add(Me.Label74)
        Me.GroupBox8.Controls.Add(Me.Label75)
        Me.GroupBox8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(248, 571)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox8.TabIndex = 194
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "October"
        '
        'lblOct_Supplier
        '
        Me.lblOct_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOct_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOct_Supplier.Location = New System.Drawing.Point(32, 115)
        Me.lblOct_Supplier.Name = "lblOct_Supplier"
        Me.lblOct_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblOct_Supplier.TabIndex = 187
        Me.lblOct_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOct_Attend
        '
        Me.lblOct_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOct_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOct_Attend.Location = New System.Drawing.Point(90, 69)
        Me.lblOct_Attend.Name = "lblOct_Attend"
        Me.lblOct_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblOct_Attend.TabIndex = 182
        '
        'lblOct_Date
        '
        Me.lblOct_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOct_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOct_Date.Location = New System.Drawing.Point(97, 50)
        Me.lblOct_Date.Name = "lblOct_Date"
        Me.lblOct_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblOct_Date.TabIndex = 181
        '
        'lblOct_Name
        '
        Me.lblOct_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOct_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOct_Name.Location = New System.Drawing.Point(101, 30)
        Me.lblOct_Name.Name = "lblOct_Name"
        Me.lblOct_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblOct_Name.TabIndex = 180
        '
        'cmbxOct
        '
        Me.cmbxOct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxOct.Location = New System.Drawing.Point(41, 155)
        Me.cmbxOct.Name = "cmbxOct"
        Me.cmbxOct.Size = New System.Drawing.Size(156, 26)
        Me.cmbxOct.TabIndex = 179
        Me.cmbxOct.TabStop = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label72.Location = New System.Drawing.Point(63, 92)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(74, 18)
        Me.Label72.TabIndex = 154
        Me.Label72.Text = "Supplier: "
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label73.Location = New System.Drawing.Point(8, 72)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(87, 18)
        Me.Label73.TabIndex = 153
        Me.Label73.Text = "Attendees: "
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label74.Location = New System.Drawing.Point(7, 51)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(93, 18)
        Me.Label74.TabIndex = 152
        Me.Label74.Text = "Event Date: "
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label75.Location = New System.Drawing.Point(6, 30)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(97, 18)
        Me.Label75.TabIndex = 151
        Me.Label75.Text = "Event Name:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblSep_Supplier)
        Me.GroupBox9.Controls.Add(Me.lblSep_Attend)
        Me.GroupBox9.Controls.Add(Me.lblSep_Name)
        Me.GroupBox9.Controls.Add(Me.lblSep_Date)
        Me.GroupBox9.Controls.Add(Me.cmbxSep)
        Me.GroupBox9.Controls.Add(Me.Label80)
        Me.GroupBox9.Controls.Add(Me.Label81)
        Me.GroupBox9.Controls.Add(Me.Label82)
        Me.GroupBox9.Controls.Add(Me.Label83)
        Me.GroupBox9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(20, 571)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox9.TabIndex = 193
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "September"
        '
        'lblSep_Supplier
        '
        Me.lblSep_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSep_Supplier.Location = New System.Drawing.Point(30, 115)
        Me.lblSep_Supplier.Name = "lblSep_Supplier"
        Me.lblSep_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblSep_Supplier.TabIndex = 186
        Me.lblSep_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSep_Attend
        '
        Me.lblSep_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSep_Attend.Location = New System.Drawing.Point(93, 75)
        Me.lblSep_Attend.Name = "lblSep_Attend"
        Me.lblSep_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblSep_Attend.TabIndex = 162
        '
        'lblSep_Name
        '
        Me.lblSep_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSep_Name.Location = New System.Drawing.Point(100, 31)
        Me.lblSep_Name.Name = "lblSep_Name"
        Me.lblSep_Name.Size = New System.Drawing.Size(116, 20)
        Me.lblSep_Name.TabIndex = 161
        '
        'lblSep_Date
        '
        Me.lblSep_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSep_Date.Location = New System.Drawing.Point(98, 53)
        Me.lblSep_Date.Name = "lblSep_Date"
        Me.lblSep_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblSep_Date.TabIndex = 160
        '
        'cmbxSep
        '
        Me.cmbxSep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSep.Location = New System.Drawing.Point(37, 155)
        Me.cmbxSep.Name = "cmbxSep"
        Me.cmbxSep.Size = New System.Drawing.Size(156, 26)
        Me.cmbxSep.TabIndex = 178
        Me.cmbxSep.TabStop = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label80.Location = New System.Drawing.Point(67, 95)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(74, 18)
        Me.Label80.TabIndex = 154
        Me.Label80.Text = "Supplier: "
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label81.Location = New System.Drawing.Point(6, 74)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(87, 18)
        Me.Label81.TabIndex = 153
        Me.Label81.Text = "Attendees: "
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label82.Location = New System.Drawing.Point(6, 53)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(93, 18)
        Me.Label82.TabIndex = 152
        Me.Label82.Text = "Event Date: "
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label83.Location = New System.Drawing.Point(5, 30)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(97, 18)
        Me.Label83.TabIndex = 151
        Me.Label83.Text = "Event Name:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblNov_Supplier)
        Me.GroupBox10.Controls.Add(Me.lblNov_Attend)
        Me.GroupBox10.Controls.Add(Me.lblNov_Date)
        Me.GroupBox10.Controls.Add(Me.lblNov_Name)
        Me.GroupBox10.Controls.Add(Me.cmbxNov)
        Me.GroupBox10.Controls.Add(Me.Label88)
        Me.GroupBox10.Controls.Add(Me.Label89)
        Me.GroupBox10.Controls.Add(Me.Label90)
        Me.GroupBox10.Controls.Add(Me.Label91)
        Me.GroupBox10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(476, 571)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(222, 192)
        Me.GroupBox10.TabIndex = 195
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "November"
        '
        'lblNov_Supplier
        '
        Me.lblNov_Supplier.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNov_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNov_Supplier.Location = New System.Drawing.Point(27, 114)
        Me.lblNov_Supplier.Name = "lblNov_Supplier"
        Me.lblNov_Supplier.Size = New System.Drawing.Size(170, 33)
        Me.lblNov_Supplier.TabIndex = 186
        Me.lblNov_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNov_Attend
        '
        Me.lblNov_Attend.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNov_Attend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNov_Attend.Location = New System.Drawing.Point(93, 69)
        Me.lblNov_Attend.Name = "lblNov_Attend"
        Me.lblNov_Attend.Size = New System.Drawing.Size(102, 20)
        Me.lblNov_Attend.TabIndex = 183
        '
        'lblNov_Date
        '
        Me.lblNov_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNov_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNov_Date.Location = New System.Drawing.Point(94, 49)
        Me.lblNov_Date.Name = "lblNov_Date"
        Me.lblNov_Date.Size = New System.Drawing.Size(102, 20)
        Me.lblNov_Date.TabIndex = 182
        '
        'lblNov_Name
        '
        Me.lblNov_Name.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNov_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNov_Name.Location = New System.Drawing.Point(100, 28)
        Me.lblNov_Name.Name = "lblNov_Name"
        Me.lblNov_Name.Size = New System.Drawing.Size(102, 20)
        Me.lblNov_Name.TabIndex = 181
        '
        'cmbxNov
        '
        Me.cmbxNov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNov.Location = New System.Drawing.Point(38, 155)
        Me.cmbxNov.Name = "cmbxNov"
        Me.cmbxNov.Size = New System.Drawing.Size(156, 26)
        Me.cmbxNov.TabIndex = 180
        Me.cmbxNov.TabStop = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label88.Location = New System.Drawing.Point(72, 92)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(74, 18)
        Me.Label88.TabIndex = 154
        Me.Label88.Text = "Supplier: "
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label89.Location = New System.Drawing.Point(7, 70)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(87, 18)
        Me.Label89.TabIndex = 153
        Me.Label89.Text = "Attendees: "
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label90.Location = New System.Drawing.Point(6, 50)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(93, 18)
        Me.Label90.TabIndex = 152
        Me.Label90.Text = "Event Date: "
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label91.Location = New System.Drawing.Point(5, 29)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(97, 18)
        Me.Label91.TabIndex = 151
        Me.Label91.Text = "Event Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1064, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 25)
        Me.Label8.TabIndex = 197
        Me.Label8.Text = "Username:"
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 765)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpFeb)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpMar)
        Me.Controls.Add(Me.pcbx_back)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcbx_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFeb.ResumeLayout(False)
        Me.grpFeb.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpMar.ResumeLayout(False)
        Me.grpMar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbx_back As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label9 As Label
    Friend WithEvents grpFeb As GroupBox
    Friend WithEvents lblFeb_Supplier As Label
    Friend WithEvents lblFeb_Attend As Label
    Friend WithEvents lblFeb_Date As Label
    Friend WithEvents lblFeb_Name As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblJan_Supplier As Label
    Friend WithEvents lblJan_Attend As Label
    Friend WithEvents lblJan_Name As Label
    Friend WithEvents lblJan_Date As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents grpMar As GroupBox
    Friend WithEvents lblMar_Supplier As Label
    Friend WithEvents lblMar_Attend As Label
    Friend WithEvents lblMar_Date As Label
    Friend WithEvents lblMar_Name As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApr_Name As Label
    Friend WithEvents lblApr_Date As Label
    Friend WithEvents lblApr_Attend As Label
    Friend WithEvents lblApr_Supplier As Label
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents btnRefresh As Button
    Friend WithEvents grpInfo As GroupBox
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents btnAdd As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEventDesc As TextBox
    Friend WithEvents dtpMonthRec As DateTimePicker
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents txtAttendees As TextBox
    Friend WithEvents txtEventName As TextBox
    Private WithEvents cmbxJan As ComboBox
    Private WithEvents cmbxFeb As ComboBox
    Private WithEvents cmbxMar As ComboBox
    Private WithEvents cmbxApr As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents cmbxAug As ComboBox
    Friend WithEvents lblAug_Supplier As Label
    Friend WithEvents lblAug_Attend As Label
    Friend WithEvents lblAug_Date As Label
    Friend WithEvents lblAug_Name As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblJune_Supplier As Label
    Friend WithEvents lblJune_Attend As Label
    Friend WithEvents lblJune_Date As Label
    Friend WithEvents lblJune_Name As Label
    Private WithEvents cmbxJune As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblMay_Supplier As Label
    Friend WithEvents lblMay_Attend As Label
    Friend WithEvents lblMay_Name As Label
    Friend WithEvents lblMay_Date As Label
    Private WithEvents cmbxMay As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblJuly_Supplier As Label
    Friend WithEvents lblJuly_Attend As Label
    Friend WithEvents lblJuly_Date As Label
    Friend WithEvents lblJuly_Name As Label
    Private WithEvents cmbxJuly As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Private WithEvents cmbxDec As ComboBox
    Friend WithEvents lblDec_Supplier As Label
    Friend WithEvents lblDec_Attend As Label
    Friend WithEvents lblDec_Date As Label
    Friend WithEvents lblDec_Name As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblOct_Supplier As Label
    Friend WithEvents lblOct_Attend As Label
    Friend WithEvents lblOct_Date As Label
    Friend WithEvents lblOct_Name As Label
    Private WithEvents cmbxOct As ComboBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lblSep_Supplier As Label
    Friend WithEvents lblSep_Attend As Label
    Friend WithEvents lblSep_Name As Label
    Friend WithEvents lblSep_Date As Label
    Private WithEvents cmbxSep As ComboBox
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lblNov_Supplier As Label
    Friend WithEvents lblNov_Attend As Label
    Friend WithEvents lblNov_Date As Label
    Friend WithEvents lblNov_Name As Label
    Private WithEvents cmbxNov As ComboBox
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Private WithEvents cmbxEventType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpMonthOrd As DateTimePicker
    Friend WithEvents txtbxEvent_ID As TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents Label8 As Label
End Class
