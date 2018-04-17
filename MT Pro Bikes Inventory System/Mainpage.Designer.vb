<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainpage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pcbx_receipts = New System.Windows.Forms.PictureBox()
        Me.pcbx_accounts = New System.Windows.Forms.PictureBox()
        Me.pcbx_sales = New System.Windows.Forms.PictureBox()
        Me.pcbx_products = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcbxCalendar = New System.Windows.Forms.PictureBox()
        Me.pcbxReceipts2 = New System.Windows.Forms.PictureBox()
        CType(Me.pcbx_receipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_sales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pcbxCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxReceipts2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baron Neue", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(945, 96)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "inventory system"
        '
        'LOGSToolStripMenuItem
        '
        Me.LOGSToolStripMenuItem.Name = "LOGSToolStripMenuItem"
        Me.LOGSToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LOGSToolStripMenuItem.Text = "LO&GS"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ABOUTUSToolStripMenuItem.Text = "A&BOUT US"
        '
        'OPTIONSToolStripMenuItem
        '
        Me.OPTIONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTUSToolStripMenuItem, Me.LOGSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.OPTIONSToolStripMenuItem.Name = "OPTIONSToolStripMenuItem"
        Me.OPTIONSToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OPTIONSToolStripMenuItem.Text = "&OPTIONS"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LOGOUTToolStripMenuItem.Text = "&LOGOUT"
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1195, 219)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 25)
        Me.lblTime.TabIndex = 45
        Me.lblTime.Text = "hh:mm:sss"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1052, 219)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 25)
        Me.lblDate.TabIndex = 44
        Me.lblDate.Text = "mm/dd/yyyy"
        '
        'pcbx_receipts
        '
        Me.pcbx_receipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_receipts.Image = CType(resources.GetObject("pcbx_receipts.Image"), System.Drawing.Image)
        Me.pcbx_receipts.Location = New System.Drawing.Point(600, 251)
        Me.pcbx_receipts.Name = "pcbx_receipts"
        Me.pcbx_receipts.Size = New System.Drawing.Size(350, 150)
        Me.pcbx_receipts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_receipts.TabIndex = 43
        Me.pcbx_receipts.TabStop = False
        '
        'pcbx_accounts
        '
        Me.pcbx_accounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_accounts.Image = CType(resources.GetObject("pcbx_accounts.Image"), System.Drawing.Image)
        Me.pcbx_accounts.Location = New System.Drawing.Point(601, 551)
        Me.pcbx_accounts.Name = "pcbx_accounts"
        Me.pcbx_accounts.Size = New System.Drawing.Size(350, 150)
        Me.pcbx_accounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_accounts.TabIndex = 41
        Me.pcbx_accounts.TabStop = False
        '
        'pcbx_sales
        '
        Me.pcbx_sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_sales.Image = CType(resources.GetObject("pcbx_sales.Image"), System.Drawing.Image)
        Me.pcbx_sales.Location = New System.Drawing.Point(266, 551)
        Me.pcbx_sales.Name = "pcbx_sales"
        Me.pcbx_sales.Size = New System.Drawing.Size(350, 150)
        Me.pcbx_sales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_sales.TabIndex = 40
        Me.pcbx_sales.TabStop = False
        '
        'pcbx_products
        '
        Me.pcbx_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_products.Image = CType(resources.GetObject("pcbx_products.Image"), System.Drawing.Image)
        Me.pcbx_products.Location = New System.Drawing.Point(268, 251)
        Me.pcbx_products.Name = "pcbx_products"
        Me.pcbx_products.Size = New System.Drawing.Size(350, 150)
        Me.pcbx_products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_products.TabIndex = 39
        Me.pcbx_products.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(1203, 194)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(119, 25)
        Me.lblUsername.TabIndex = 38
        Me.lblUsername.Text = "Username"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(982, 42)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 149)
        Me.pictureBox1.TabIndex = 37
        Me.pictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPTIONSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1345, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1077, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Username:"
        '
        'pcbxCalendar
        '
        Me.pcbxCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxCalendar.Image = CType(resources.GetObject("pcbxCalendar.Image"), System.Drawing.Image)
        Me.pcbxCalendar.Location = New System.Drawing.Point(602, 402)
        Me.pcbxCalendar.Name = "pcbxCalendar"
        Me.pcbxCalendar.Size = New System.Drawing.Size(350, 150)
        Me.pcbxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbxCalendar.TabIndex = 49
        Me.pcbxCalendar.TabStop = False
        '
        'pcbxReceipts2
        '
        Me.pcbxReceipts2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxReceipts2.Image = CType(resources.GetObject("pcbxReceipts2.Image"), System.Drawing.Image)
        Me.pcbxReceipts2.Location = New System.Drawing.Point(259, 402)
        Me.pcbxReceipts2.Name = "pcbxReceipts2"
        Me.pcbxReceipts2.Size = New System.Drawing.Size(350, 150)
        Me.pcbxReceipts2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbxReceipts2.TabIndex = 50
        Me.pcbxReceipts2.TabStop = False
        '
        'Mainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1345, 765)
        Me.Controls.Add(Me.pcbxReceipts2)
        Me.Controls.Add(Me.pcbxCalendar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.pcbx_receipts)
        Me.Controls.Add(Me.pcbx_accounts)
        Me.Controls.Add(Me.pcbx_sales)
        Me.Controls.Add(Me.pcbx_products)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mainpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcbx_receipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_sales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pcbxCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxReceipts2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LOGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OPTIONSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pcbx_receipts As PictureBox
    Friend WithEvents pcbx_accounts As PictureBox
    Friend WithEvents pcbx_sales As PictureBox
    Friend WithEvents pcbx_products As PictureBox
    Private WithEvents lblUsername As Label
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Private WithEvents Label2 As Label
    Friend WithEvents pcbxCalendar As PictureBox
    Friend WithEvents pcbxReceipts2 As PictureBox
End Class
