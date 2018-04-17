Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class Accounts_Adm
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim ds2 As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
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
    Private Sub Accounts_Adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        RefreshDatagrid()
        DisableFields()
    End Sub
    '///// ENABLE FIELDS /////
    Private Function EnableFields()
        cmbxType.Enabled = True
        txtbxNumber.Enabled = True
        txtbxFirstName.Enabled = True
        txtbxLastName.Enabled = True
        txtbxMiddle.Enabled = True
        txtbxAddStreet.Enabled = True
        txtbxAddBrgy.Enabled = True
        txtbxAddCity.Enabled = True
        txtbxAddBrgy.Enabled = True
        txtbxContact.Enabled = True
        txtbxEmail.Enabled = True
        txtbxUsername.Enabled = True
        txtbxPassword.Enabled = True
        txtbxConfirmPass.Enabled = True
        Return 0
    End Function
    '///// DISABLE FIELDS /////
    Private Function DisableFields()
        cmbxType.Enabled = False
        txtbxNumber.Enabled = False
        txtbxFirstName.Enabled = False
        txtbxLastName.Enabled = False
        txtbxMiddle.Enabled = False
        txtbxAddStreet.Enabled = False
        txtbxAddBrgy.Enabled = False
        txtbxAddCity.Enabled = False
        txtbxAddBrgy.Enabled = False
        txtbxContact.Enabled = False
        txtbxEmail.Enabled = False
        txtbxUsername.Enabled = False
        txtbxPassword.Enabled = False
        txtbxConfirmPass.Enabled = False
        Return 0
    End Function
    '///// CLEAR FIELDS /////
    Private Function ClearFields()
        txtbxNumber.Clear()
        txtbxFirstName.Clear()
        txtbxLastName.Clear()
        txtbxMiddle.Clear()
        txtbxAddStreet.Clear()
        txtbxAddBrgy.Clear()
        txtbxAddCity.Clear()
        txtbxAddBrgy.Clear()
        txtbxContact.Clear()
        txtbxEmail.Clear()
        txtbxUsername.Clear()
        txtbxPassword.Clear()
        txtbxConfirmPass.Clear()
        Return 0
    End Function
    '///// REFRESH DATAGRID /////
    Private Sub RefreshDatagrid()
        da = New OleDbDataAdapter("Select * from mtpro_login'", cnn)
        dt = New DataTable
        da.Fill(dt)
        GridViewAccounts.DataSource = dt
        With GridViewAccounts
            .Columns(0).HeaderCell.Value = "No"
            .Columns(1).HeaderCell.Value = "Account Type"
            .Columns(4).HeaderCell.Value = "First Name"
            .Columns(5).HeaderCell.Value = "Last Name"
            .Columns(8).HeaderCell.Value = "Baranggay"
            .Columns(9).HeaderCell.Value = "City"
            .Columns(10).HeaderCell.Value = "Contact No."
            .Columns(11).HeaderCell.Value = "Email"
            .Columns(2).HeaderCell.Value = "Username"
            .Columns(3).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(0).Width = 50
            .Columns(1).Width = 140
            .Columns(4).Width = 130
            .Columns(5).Width = 130
            .Columns(8).Width = 155
            .Columns(9).Width = 130
            .Columns(10).Width = 160
            .Columns(11).Width = 220
            .Columns(2).Width = 133
        End With
    End Sub
    '//// SHOW DETAILS /////
    Private Sub GridViewAccounts_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridViewAccounts.CellMouseClick
        cmbxType.Text = GridViewAccounts.Item(1, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxNumber.Text = GridViewAccounts.Item(0, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxLastName.Text = GridViewAccounts.Item(5, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxFirstName.Text = GridViewAccounts.Item(4, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxAddBrgy.Text = GridViewAccounts.Item(8, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxAddCity.Text = GridViewAccounts.Item(9, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxContact.Text = GridViewAccounts.Item(10, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxEmail.Text = GridViewAccounts.Item(11, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxUsername.Text = GridViewAccounts.Item(2, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxMiddle.Text = GridViewAccounts.Item(6, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxAddStreet.Text = GridViewAccounts.Item(7, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxPassword.Text = GridViewAccounts.Item(3, GridViewAccounts.CurrentCell.RowIndex).Value
        txtbxConfirmPass.Text = GridViewAccounts.Item(3, GridViewAccounts.CurrentCell.RowIndex).Value
    End Sub
    '///// SEARCH FUNCTION /////
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim table As New DataTable()
        Dim cmd As OleDbCommand
        Dim cmd2 As OleDbCommand
        Dim cmd3 As OleDbCommand
        Dim cmd4 As OleDbCommand
        Dim cmd5 As OleDbCommand
        Dim cmd6 As OleDbCommand
        Dim cmd7 As OleDbCommand
        Dim cmd8 As OleDbCommand

        cnn.Open()
        If (txtbxSearch.Text = "") Then
            MessageBox.Show("NO PRODUCTS SEARCHED.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cmbxSearch.SelectedIndex = 0 Then
                cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] Like '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] = '" & txtbxSearch.Text & "'", cnn)
                cmd5 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] Like '% " & txtbxSearch.Text & " %'", cnn)
                cmd6 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd7 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd8 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                table.Load(cmd5.ExecuteReader)
                table.Load(cmd6.ExecuteReader)
                table.Load(cmd7.ExecuteReader)
                table.Load(cmd8.ExecuteReader)
                GridViewAccounts.DataSource = table
                GridViewAccounts.Refresh()
            ElseIf cmbxSearch.SelectedIndex = 1 Then
                cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewAccounts.DataSource = table
                GridViewAccounts.Refresh()
            ElseIf cmbxSearch.SelectedIndex = 2 Then
                cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewAccounts.DataSource = table
                GridViewAccounts.Refresh()
            Else
                cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '" & txtbxSearch.Text & " %'", cnn)
                cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '% " & txtbxSearch.Text & "'", cnn)
                cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] = '" & txtbxSearch.Text & "'", cnn)
                table.Load(cmd.ExecuteReader)
                table.Load(cmd2.ExecuteReader)
                table.Load(cmd3.ExecuteReader)
                table.Load(cmd4.ExecuteReader)
                GridViewAccounts.DataSource = table
                GridViewAccounts.Refresh()
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
            Dim cmd5 As OleDbCommand
            Dim cmd6 As OleDbCommand
            Dim cmd7 As OleDbCommand
            Dim cmd8 As OleDbCommand

            cnn.Open()
            If (txtbxSearch.Text = "") Then
                MessageBox.Show("NO PRODUCTS SEARCHED.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If cmbxSearch.SelectedIndex = 0 Then
                    cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] Like '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [firstname] = '" & txtbxSearch.Text & "'", cnn)
                    cmd5 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] Like '% " & txtbxSearch.Text & " %'", cnn)
                    cmd6 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd7 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd8 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [lastname] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    table.Load(cmd5.ExecuteReader)
                    table.Load(cmd6.ExecuteReader)
                    table.Load(cmd7.ExecuteReader)
                    table.Load(cmd8.ExecuteReader)
                    GridViewAccounts.DataSource = table
                    GridViewAccounts.Refresh()
                ElseIf cmbxSearch.SelectedIndex = 1 Then
                    cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [emp_type] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewAccounts.DataSource = table
                    GridViewAccounts.Refresh()
                ElseIf cmbxSearch.SelectedIndex = 2 Then
                    cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [contact_no] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewAccounts.DataSource = table
                    GridViewAccounts.Refresh()
                Else
                    cmd = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '% " & txtbxSearch.Text & " %'", cnn)
                    cmd2 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '" & txtbxSearch.Text & " %'", cnn)
                    cmd3 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] LIKE '% " & txtbxSearch.Text & "'", cnn)
                    cmd4 = New OleDbCommand("SELECT emp_number,emp_type,firstname,lastname,add_baranggay,add_city,contact_no,email,username FROM [mtpro_login] WHERE [email] = '" & txtbxSearch.Text & "'", cnn)
                    table.Load(cmd.ExecuteReader)
                    table.Load(cmd2.ExecuteReader)
                    table.Load(cmd3.ExecuteReader)
                    table.Load(cmd4.ExecuteReader)
                    GridViewAccounts.DataSource = table
                    GridViewAccounts.Refresh()
                End If
            End If
        End If
        cnn.Close()
    End Sub
    '///// ADD BUTTON /////
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Select Case btnAdd.Text
            Case "&ADD NEW"
                ClearFields()
                EnableFields()
                txtbxPassword.Enabled = False
                txtbxConfirmPass.Enabled = False
                btnAdd.Text = "&SAVE"
                btnUpdate.Text = "C&LEAR FIELDS"
                btnDelete.Text = "&CANCEL"

            Case "&SAVE"
                da = New OleDbDataAdapter("INSERT INTO mtpro_login(emp_number,emp_type,lastname,firstname,middleinitial,add_street,add_baranggay,add_city,contact_no,email,username) 
                                            VALUES('" & txtbxNumber.Text & "',
                                                   '" & cmbxType.SelectedItem.ToString() & "',
                                                   '" & txtbxLastName.Text & "',
                                                   '" & txtbxFirstName.Text & "',
                                                   '" & txtbxMiddle.Text & "',
                                                   '" & txtbxAddStreet.Text & "',
                                                   '" & txtbxAddBrgy.Text & "',
                                                   '" & txtbxAddCity.Text & "',
                                                   '" & txtbxContact.Text & "',
                                                   '" & txtbxEmail.Text & "',
                                                   '" & txtbxUsername.Text & "')", cnn)

                If cmbxType.SelectedItem = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmbxType.Focus()
                    ElseIf txtbxNumber.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxNumber.Focus()
                    ElseIf txtbxLastName.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxLastName.Focus()
                    ElseIf txtbxFirstName.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxFirstName.Focus()
                    ElseIf txtbxMiddle.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxMiddle.Focus()
                    ElseIf txtbxAddStreet.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddStreet.Focus()
                    ElseIf txtbxAddBrgy.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddBrgy.Focus()
                    ElseIf txtbxAddCity.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddCity.Focus()
                    ElseIf txtbxContact.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    ElseIf txtbxEmail.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    ElseIf txtbxUsername.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    Else
                    Select Case MsgBox("Are you sure you want to Add?", MsgBoxStyle.OkCancel, "")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Added New Account')", cnn)
                            cmd2.ExecuteReader()
                            ds = New DataSet
                            da.Fill(ds)
                            RefreshDatagrid()
                            MsgBox("Added Successfully!", MsgBoxStyle.Information)
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
    '//// UPDATE BUTTON /////
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Select Case btnUpdate.Text
            Case "&UPDATE"
                If (txtbxNumber.Text = "") Then
                    MessageBox.Show("NO SELECTED ACCOUNT TO UPDATE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DisableFields()
                Else
                    EnableFields()
                    txtbxNumber.Enabled = False
                    txtbxPassword.Enabled = False
                    txtbxConfirmPass.Enabled = False
                    btnAdd.Text = "C&LEAR FIELDS"
                    btnUpdate.Text = "&SAVE UPDATE"
                    btnDelete.Text = "&CANCEL"
                End If

            Case "&SAVE UPDATE"
                da = New OleDbDataAdapter("UPDATE mtpro_login SET emp_type = '" & cmbxType.SelectedItem.ToString() & "',
                                                                lastname = '" & txtbxLastName.Text & "', 
                                                                firstname = '" & txtbxFirstName.Text & "', 
                                                                middleinitial = '" & txtbxMiddle.Text & "', 
                                                                add_street = '" & txtbxAddStreet.Text & "', 
                                                                add_baranggay = '" & txtbxAddBrgy.Text & "', 
                                                                add_city = '" & txtbxAddCity.Text & "',
                                                                contact_no = '" & txtbxContact.Text & "',
                                                                email = '" & txtbxEmail.Text & "',
                                                                username = '" & txtbxUsername.Text & "'                                                      
                                                                WHERE emp_number = '" & txtbxNumber.Text & "'", cnn)

                If (txtbxPassword.Text.Equals(txtbxConfirmPass.Text, StringComparison.Ordinal)) Then
                    If cmbxType.SelectedItem = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmbxType.Focus()
                    ElseIf txtbxNumber.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxNumber.Focus()
                    ElseIf txtbxLastName.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxLastName.Focus()
                    ElseIf txtbxFirstName.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxFirstName.Focus()
                    ElseIf txtbxMiddle.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxMiddle.Focus()
                    ElseIf txtbxAddStreet.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddStreet.Focus()
                    ElseIf txtbxAddBrgy.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddBrgy.Focus()
                    ElseIf txtbxAddCity.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxAddCity.Focus()
                    ElseIf txtbxContact.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    ElseIf txtbxEmail.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    ElseIf txtbxUsername.Text = Nothing Then
                        MessageBox.Show("Please complete all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtbxContact.Focus()
                    Else
                        Select Case MsgBox("    Are you sure you want to Update?", MsgBoxStyle.OkCancel, "UPDATE?")
                            Case MsgBoxResult.Ok
                                cnn.Open()
                                Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                                                            VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                                                                   '" & lblUsername.Text & "','Updated Account')", cnn)
                                cmd2.ExecuteReader()
                                da.Fill(ds)
                                ds = New DataSet
                                RefreshDatagrid()
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
                Else
                    MessageBox.Show("PASSWORD MISMATCH.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbxPassword.Clear()
                    txtbxConfirmPass.Clear()
                    txtbxPassword.Focus()
                End If
            Case "C&LEAR FIELDS"
                ClearFields()
        End Select
    End Sub
    '///// DELETE BUTTON /////
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case btnDelete.Text
            Case "&DELETE"
                If (txtbxNumber.Text = "") Then
                    MessageBox.Show("NO SELECTED ACCOUNT TO DELETE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    da = New OleDbDataAdapter("DELETE FROM mtpro_login WHERE emp_number = '" & txtbxNumber.Text & "'", cnn)
                    Select Case MsgBox("    Are you sure you want to Delete?", MsgBoxStyle.OkCancel, "DELETE?")
                        Case MsgBoxResult.Ok
                            cnn.Open()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Deleted Account')", cnn)
                            cmd2.ExecuteReader()
                            da.Fill(ds)
                            ds = New DataSet
                            RefreshDatagrid()
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
        RefreshDatagrid()
    End Sub
End Class