Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class Calendar
    Dim cnn As New OleDb.OleDbConnection
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter

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
    '//// ENABLE FIELDS /////
    Private Function EnableFields()
        txtbxEvent_ID.Enabled = True
        txtEventName.Enabled = True
        dtpEventDate.Enabled = True
        txtAttendees.Enabled = True
        txtEventDesc.Enabled = True
        txtSupplier.Enabled = True
        dtpMonthOrd.Enabled = True
        dtpMonthRec.Enabled = True
        Return 0
    End Function
    '//// DISABLE FIELDS /////
    Private Function DisabledFields()
        txtbxEvent_ID.Enabled = False
        txtEventName.Enabled = False
        dtpEventDate.Enabled = False
        txtAttendees.Enabled = False
        txtEventDesc.Enabled = False
        txtSupplier.Enabled = False
        dtpMonthOrd.Enabled = False
        dtpMonthRec.Enabled = False
        Return 0
    End Function
    '//// CLEAR COMBO BOX /////
    Private Sub ClearIndex()
        cmbxJan.SelectedItem = Nothing
        cmbxFeb.SelectedItem = Nothing
        cmbxMar.SelectedItem = Nothing
        cmbxApr.SelectedItem = Nothing
        cmbxMay.SelectedItem = Nothing
        cmbxJune.SelectedItem = Nothing
        cmbxJuly.SelectedItem = Nothing
        cmbxAug.SelectedItem = Nothing
        cmbxSep.SelectedItem = Nothing
        cmbxOct.SelectedItem = Nothing
        cmbxNov.SelectedItem = Nothing
        cmbxDec.SelectedItem = Nothing
    End Sub
    '//// DISABLE COMBO BOX /////
    Private Sub DisableCombobox()
        cmbxJan.Enabled = False
        cmbxFeb.Enabled = False
        cmbxMar.Enabled = False
        cmbxApr.Enabled = False
        cmbxMay.Enabled = False
        cmbxJune.Enabled = False
        cmbxJuly.Enabled = False
        cmbxAug.Enabled = False
        cmbxSep.Enabled = False
        cmbxOct.Enabled = False
        cmbxNov.Enabled = False
        cmbxDec.Enabled = False
    End Sub
    '//// ENABLE COMBO BOX /////
    Private Sub EnableCombobox()
        cmbxJan.Enabled = True
        cmbxFeb.Enabled = True
        cmbxMar.Enabled = True
        cmbxApr.Enabled = True
        cmbxMay.Enabled = True
        cmbxJune.Enabled = True
        cmbxJuly.Enabled = True
        cmbxAug.Enabled = True
        cmbxSep.Enabled = True
        cmbxOct.Enabled = True
        cmbxNov.Enabled = True
        cmbxDec.Enabled = True
    End Sub
    '//// CLEAR FIELDS ////
    Private Function ClearFields()
        txtbxEvent_ID.Clear()
        txtEventName.Clear()
        dtpEventDate.ResetText()
        txtAttendees.Clear()
        txtEventDesc.Clear()
        txtSupplier.Clear()
        dtpMonthOrd.ResetText()
        dtpMonthRec.ResetText()
        Return 0
    End Function
    Private Sub RefreshData()
        cmbxJan.Items.Clear()
        cmbxFeb.Items.Clear()
        cmbxMar.Items.Clear()
        cmbxApr.Items.Clear()
        cmbxMay.Items.Clear()
        cmbxJune.Items.Clear()
        cmbxJuly.Items.Clear()
        cmbxAug.Items.Clear()
        cmbxSep.Items.Clear()
        cmbxOct.Items.Clear()
        cmbxNov.Items.Clear()
        cmbxDec.Items.Clear()
        EnableCombobox()
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 1 OR month_ordered2 = 1 OR month_received2 = 1", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            cmbxJan.Items.Add(dr("event_name").ToString)
        End While
        dr.Close()

        Dim cmd2 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 2 OR month_ordered2 = 2 OR month_received2 = 2", cnn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
        While dr2.Read
            cmbxFeb.Items.Add(dr2("event_name").ToString)
        End While
        dr2.Close()

        Dim cmd3 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 3 OR month_ordered2 = 3 OR month_received2 = 3", cnn)
        Dim dr3 As OleDbDataReader = cmd3.ExecuteReader
        While dr3.Read
            cmbxMar.Items.Add(dr3("event_name").ToString)
        End While
        dr3.Close()

        Dim cmd4 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 4 OR month_ordered2 = 4 OR month_received2 = 4", cnn)
        Dim dr4 As OleDbDataReader = cmd4.ExecuteReader
        While dr4.Read
            cmbxApr.Items.Add(dr4("event_name").ToString)
        End While
        dr4.Close()

        Dim cmd5 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 5 OR month_ordered2 = 5 OR month_received2 = 5", cnn)
        Dim dr5 As OleDbDataReader = cmd5.ExecuteReader
        While dr5.Read
            cmbxMay.Items.Add(dr5("event_name").ToString)
        End While
        dr5.Close()

        Dim cmd6 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 6 OR month_ordered2 = 6 OR month_received2 = 6", cnn)
        Dim dr6 As OleDbDataReader = cmd6.ExecuteReader
        While dr6.Read
            cmbxJune.Items.Add(dr6("event_name").ToString)
        End While
        dr6.Close()

        Dim cmd7 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 7 OR month_ordered2 = 7 OR month_received2 = 7", cnn)
        Dim dr7 As OleDbDataReader = cmd7.ExecuteReader
        While dr7.Read
            cmbxJuly.Items.Add(dr7("event_name").ToString)
        End While
        dr7.Close()

        Dim cmd8 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 8 OR month_ordered2 = 8 OR month_received2 = 8", cnn)
        Dim dr8 As OleDbDataReader = cmd8.ExecuteReader
        While dr8.Read
            cmbxAug.Items.Add(dr8("event_name").ToString)
        End While
        dr8.Close()

        Dim cmd9 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 9 OR month_ordered2 = 9 OR month_received2 = 9", cnn)
        Dim dr9 As OleDbDataReader = cmd9.ExecuteReader
        While dr9.Read
            cmbxSep.Items.Add(dr9("event_name").ToString)
        End While
        dr9.Close()

        Dim cmd10 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 10 OR month_ordered2 = 10 OR month_received2 = 10", cnn)
        Dim dr10 As OleDbDataReader = cmd10.ExecuteReader
        While dr10.Read
            cmbxOct.Items.Add(dr10("event_name").ToString)
        End While
        dr10.Close()

        Dim cmd11 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 11 OR month_ordered2 = 11 OR month_received2 = 11", cnn)
        Dim dr11 As OleDbDataReader = cmd11.ExecuteReader
        While dr11.Read
            cmbxNov.Items.Add(dr11("event_name").ToString)
        End While
        dr11.Close()

        Dim cmd12 As OleDbCommand = New OleDbCommand("Select event_name FROM mtpro_calendar WHERE event_month = 12 OR month_ordered2 = 12 OR month_received2 = 12", cnn)
        Dim dr12 As OleDbDataReader = cmd12.ExecuteReader
        While dr12.Read
            cmbxDec.Items.Add(dr12("event_name").ToString)
        End While
        dr12.Close()
        cnn.Close()
    End Sub
    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lblUsername.Text = username
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
                Application.StartupPath & "\MTProBikes.accdb"
        RefreshData()
    End Sub
    '//// ADD BUTTON ////
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbxEventType.SelectedIndex = 0 Then
            Select Case btnAdd.Text
                Case "C&LEAR FIELDS"
                    ClearFields()
                Case "&ADD NEW"
                    ClearFields()
                    EnableFields()
                    DisableCombobox()
                    txtbxEvent_ID.Text = GenerateRandom(6)
                    txtbxEvent_ID.Enabled = False
                    txtSupplier.Enabled = False
                    dtpMonthOrd.Enabled = False
                    dtpMonthRec.Enabled = False
                    btnAdd.Text = "&SAVE"
                    btnUpdate.Text = "C&LEAR ALL"
                    btnDelete.Text = "&CANCEL"
                Case "&SAVE"
                    Dim month As Integer = dtpEventDate.Value.Month()
                    cnn.Open()
                    Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_calendar(event_id,event_name,event_date,event_month,event_attendees,event_description,event_type) 
                                            VALUES('" & txtbxEvent_ID.Text & "','" & txtEventName.Text & "','" & dtpEventDate.Value.Date & "','" & month & "',
                                                    '" & txtAttendees.Text & "','" & txtEventDesc.Text & "','" & cmbxEventType.SelectedItem.ToString & "')", cnn)
                    Select Case MsgBox("Are you sure you want to Add?", MsgBoxStyle.OkCancel, "")
                        Case MsgBoxResult.Ok
                            cmd.ExecuteNonQuery()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Added New Event')", cnn)
                            cmd2.ExecuteReader()
                            MsgBox("Added Successfully!", MsgBoxStyle.Information)
                            cmbxEventType.SelectedItem = Nothing
                            ClearFields()
                            DisabledFields()
                            cmbxEventType.Enabled = True
                            btnAdd.Text = "&ADD NEW"
                            btnUpdate.Text = "&UPDATE"
                            btnDelete.Text = "&DELETE"
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
            End Select

        ElseIf cmbxEventType.SelectedIndex = 1 Then
            Select Case btnAdd.Text
                Case "C&LEAR FIELDS"
                    ClearFields()
                Case "&ADD NEW"
                    ClearFields()
                    EnableFields()
                    txtbxEvent_ID.Text = GenerateRandom(6)
                    txtbxEvent_ID.Enabled = False
                    txtEventName.Enabled = False
                    dtpEventDate.Enabled = False
                    txtAttendees.Enabled = False
                    txtEventDesc.Enabled = False
                    btnAdd.Text = "&SAVE"
                    btnUpdate.Text = "C&LEAR ALL"
                    btnDelete.Text = "&CANCEL"
                Case "&SAVE"
                    Dim month_o As Integer = dtpMonthOrd.Value.Month()
                    Dim month_r As Integer = dtpMonthRec.Value.Month()
                    cnn.Open()
                    Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_calendar(event_id,event_name,supplier,month_ordered,month_received,month_ordered2,month_received2,event_type) 
                                            VALUES('" & txtbxEvent_ID.Text & "','Procure Product','" & txtSupplier.Text & "','" & dtpMonthOrd.Value.Date & "','" & dtpMonthRec.Value.Date & "',
                                                    '" & month_o & "','" & month_r & "','" & cmbxEventType.SelectedItem.ToString & "')", cnn)
                    Select Case MsgBox("Are you sure you want to Add?", MsgBoxStyle.OkCancel, "")
                        Case MsgBoxResult.Ok
                            cmd.ExecuteNonQuery()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Added New Event')", cnn)
                            cmd2.ExecuteReader()
                            MsgBox("Added Successfully!", MsgBoxStyle.Information)
                            cmbxEventType.SelectedItem = Nothing
                            ClearFields()
                            DisabledFields()
                            btnAdd.Text = "&ADD NEW"
                            btnUpdate.Text = "&UPDATE"
                            btnDelete.Text = "&DELETE"
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
            End Select
        Else
            MessageBox.Show("SELECT EVENT TYPE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '//// UPDATE BUTTON ////
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Select Case btnUpdate.Text
            Case "&UPDATE"
                If (txtEventName.Text = Nothing) Then
                    MessageBox.Show("NO SELECTED EVENT TO UPDATE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DisabledFields()
                Else
                    If txtAttendees.Text = "" Then
                        DisabledFields()
                        cmbxEventType.Enabled = False
                        txtSupplier.Enabled = True
                        dtpMonthOrd.Enabled = True
                        dtpMonthRec.Enabled = True
                        txtbxEvent_ID.Enabled = False
                        btnAdd.Text = "C&LEAR FIELDS"
                        btnUpdate.Text = "&SAVE UPDATE"
                        btnDelete.Text = "&CANCEL"
                    Else
                        EnableFields()
                        cmbxEventType.Enabled = False
                        txtSupplier.Enabled = False
                        dtpMonthOrd.Enabled = False
                        dtpMonthRec.Enabled = False
                        txtbxEvent_ID.Enabled = False
                        btnAdd.Text = "C&LEAR FIELDS"
                        btnUpdate.Text = "&SAVE UPDATE"
                        btnDelete.Text = "&CANCEL"
                    End If


                End If
            Case "&SAVE UPDATE"
                Dim month As Integer = dtpEventDate.Value.Month()
                Dim month2 As Integer = dtpMonthOrd.Value.Month()
                Dim month3 As Integer = dtpMonthRec.Value.Month()

                cnn.Open()
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE mtpro_calendar SET event_name = '" & txtEventName.Text & "',
                                                                event_date = '" & dtpEventDate.Value.Date & "', 
                                                                event_month= '" & month & "', 
                                                                event_attendees = '" & txtAttendees.Text & "', 
                                                                event_description = '" & txtEventDesc.Text & "',
                                                                supplier = '" & txtSupplier.Text & "',
                                                                month_ordered = '" & dtpMonthOrd.Value.Date & "',
                                                                month_ordered2 = '" & month2 & "',
                                                                month_received = '" & dtpMonthRec.Value.Date & "',
                                                                month_received2 = '" & month3 & "'  
                                                                WHERE event_id = '" & txtbxEvent_ID.Text & "'", cnn)
                Select Case MsgBox("Are you sure you want to Update?", MsgBoxStyle.OkCancel, "")
                    Case MsgBoxResult.Ok
                        cmd.ExecuteNonQuery()
                        Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Updated Event')", cnn)
                        cmd2.ExecuteReader()
                        MsgBox("Updated Successfully!", MsgBoxStyle.Information)
                        cmbxEventType.SelectedItem = Nothing
                        ClearFields()
                        DisabledFields()
                        cmbxEventType.Enabled = True
                        btnAdd.Text = "&ADD NEW"
                        btnUpdate.Text = "&UPDATE"
                        btnDelete.Text = "&DELETE"
                        cnn.Close()
                    Case MsgBoxResult.Cancel
                End Select
            Case "C&LEAR FIELDS"
        End Select
    End Sub
    '//// DELETE BUTTON /////
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case btnDelete.Text
            Case "&DELETE"
                If (txtbxEvent_ID.Text = "") Then
                    MessageBox.Show("NO SELECTED PRODUCT TO DELETE.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    cnn.Open()
                    Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM mtpro_calendar WHERE event_id = '" & txtbxEvent_ID.Text & "'", cnn)

                    Select Case MsgBox("    Are you sure you want to Delete?", MsgBoxStyle.OkCancel, "DELETE?")
                        Case MsgBoxResult.Ok
                            cmd.ExecuteNonQuery()
                            Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & lblUsername.Text & "','Deleted Event')", cnn)
                            cmd2.ExecuteReader()
                            MsgBox("Deleted Successfully!", MsgBoxStyle.Information, "SUCCESS!")
                            cmbxEventType.SelectedItem = Nothing
                            ClearFields()
                            DisabledFields()
                            btnAdd.Text = "&ADD NEW"
                            btnUpdate.Text = "&UPDATE"
                            btnDelete.Text = "&DELETE"
                            cnn.Close()
                        Case MsgBoxResult.Cancel
                    End Select
                End If
            Case "&CANCEL"
                EnableCombobox()
                ClearFields()
                ClearIndex()
                cmbxEventType.Enabled = True
                cmbxEventType.SelectedItem = Nothing
                DisabledFields()
                btnAdd.Text = "&ADD NEW"
                btnUpdate.Text = "&UPDATE"
                btnDelete.Text = "&DELETE"
        End Select
    End Sub
    '//// REFRESH BUTTON /////
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
        ClearFields()
    End Sub
    Private Sub cmbxJan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxJan.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxJan.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblJan_Name.Text = (dr("event_name")).ToString
            lblJan_Date.Text = (dr("event_date")).ToString
            lblJan_Attend.Text = (dr("event_attendees")).ToString
            lblJan_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxFeb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFeb.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxFeb.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblFeb_Name.Text = (dr("event_name")).ToString
            lblFeb_Date.Text = (dr("event_date")).ToString
            lblFeb_Attend.Text = (dr("event_attendees")).ToString
            lblFeb_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxMar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxMar.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxMar.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblMar_Name.Text = (dr("event_name")).ToString
            lblMar_Date.Text = (dr("event_date")).ToString
            lblMar_Attend.Text = (dr("event_attendees")).ToString
            lblMar_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxApr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxApr.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxApr.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblApr_Name.Text = (dr("event_name")).ToString
            lblApr_Date.Text = (dr("event_date")).ToString
            lblApr_Attend.Text = (dr("event_attendees")).ToString
            lblApr_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxMay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxMay.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxMay.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblMay_Name.Text = (dr("event_name")).ToString
            lblMay_Date.Text = (dr("event_date")).ToString
            lblMay_Attend.Text = (dr("event_attendees")).ToString
            lblMay_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxJune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxJune.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxJune.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblJune_Name.Text = (dr("event_name")).ToString
            lblJune_Date.Text = (dr("event_date")).ToString
            lblJune_Attend.Text = (dr("event_attendees")).ToString
            lblJune_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxJuly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxJuly.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxJuly.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblJuly_Name.Text = (dr("event_name")).ToString
            lblJuly_Date.Text = (dr("event_date")).ToString
            lblJuly_Attend.Text = (dr("event_attendees")).ToString
            lblJuly_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxAug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxAug.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxAug.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblAug_Name.Text = (dr("event_name")).ToString
            lblAug_Date.Text = (dr("event_date")).ToString
            lblAug_Attend.Text = (dr("event_attendees")).ToString
            lblAug_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxSep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxSep.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxSep.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblSep_Name.Text = (dr("event_name")).ToString
            lblSep_Date.Text = (dr("event_date")).ToString
            lblSep_Attend.Text = (dr("event_attendees")).ToString
            lblSep_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxOct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxOct.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxOct.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblOct_Name.Text = (dr("event_name")).ToString
            lblOct_Date.Text = (dr("event_date")).ToString
            lblOct_Attend.Text = (dr("event_attendees")).ToString
            lblOct_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxNov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxNov.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxNov.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblNov_Name.Text = (dr("event_name")).ToString
            lblNov_Date.Text = (dr("event_date")).ToString
            lblNov_Attend.Text = (dr("event_attendees")).ToString
            lblNov_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Private Sub cmbxDec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxDec.SelectedIndexChanged
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM mtpro_calendar WHERE event_name = '" & cmbxDec.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If (dr.Read() = True) Then
            cmbxEventType.SelectedItem = (dr("event_type")).ToString
            lblDec_Name.Text = (dr("event_name")).ToString
            lblDec_Date.Text = (dr("event_date")).ToString
            lblDec_Attend.Text = (dr("event_attendees")).ToString
            lblDec_Supplier.Text = (dr("supplier")).ToString
            txtEventName.Text = (dr("event_name")).ToString
            dtpEventDate.Text = (dr("event_date")).ToString
            txtAttendees.Text = (dr("event_attendees")).ToString
            txtEventDesc.Text = (dr("event_description")).ToString
            txtSupplier.Text = (dr("supplier")).ToString
            dtpMonthOrd.Text = (dr("month_ordered")).ToString
            dtpMonthRec.Text = (dr("month_received")).ToString
            txtbxEvent_ID.Text = (dr("event_id")).ToString
        End If
        cnn.Close()
    End Sub
    Public Function GenerateRandom(ByVal len As Integer)
        Dim pool As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXVCBNM1234567890"
        Dim nn As New Random
        Dim result As String
        Dim cc = 0
        While cc < len
            result &= pool(nn.Next(0, pool.Length))
            cc += 1
        End While
        Return result
    End Function
End Class