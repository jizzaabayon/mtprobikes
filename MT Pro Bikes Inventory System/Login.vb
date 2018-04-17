Imports System.Data.OleDb

Public Class Login
    Dim dt As New DataTable
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim cnn As New OleDb.OleDbConnection

    '///// LOG-IN /////
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
        Application.StartupPath & "\MTProBikes.accdb"
        'the query:
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [mtpro_login] WHERE [username] = '" & txtbx_username.Text & "' AND [password] = '" & txtbx_password.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim username As String = " "
        Dim emp_type As String = " "
        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("firstname").ToString
            LastName = dr("lastname").ToString
            emp_type = dr("emp_type").ToString
        End While
        'checking the result
        If userFound = True Then
            If emp_type = "admin" Then
                Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & txtbx_username.Text & "','Admin Login')", cnn)
                cmd2.ExecuteReader()
                MsgBox("    Welcome " & FirstName & " " & LastName, MsgBoxStyle.OkOnly, "Log-in Succesfully")
                Dim obj As New Mainpage
                obj.username = txtbx_username.Text
                txtbx_username.Clear()
                txtbx_password.Clear()
                txtbx_username.Focus()
                Me.Hide()
                obj.Show()
            ElseIf emp_type = "employee" Then
                Dim cmd3 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime.ToString() & "',
                                               '" & txtbx_username.Text & "','Employee Login Attempt Failure')", cnn)
                cmd3.ExecuteReader()
                txtbx_username.Clear()
                txtbx_password.Clear()
                txtbx_username.Focus()
                MessageBox.Show("Unauthorized Login. Ask for Admin.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbx_username.Focus()
            End If
        Else
            txtbx_username.Clear()
            txtbx_password.Clear()
            MessageBox.Show("Unable to log-in. Check credentials.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbx_username.Focus()
        End If
        cnn.Close()
    End Sub
    Private Sub txtbx_password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_password.KeyPress
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" &
        Application.StartupPath & "\MTProBikes.accdb"
        'the query:
        cnn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [mtpro_login] WHERE [username] = '" & txtbx_username.Text & "' AND [password] = '" & txtbx_password.Text & "'", cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim emp_type As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("firstName").ToString
            LastName = dr("lastName").ToString
            emp_type = dr("emp_type").ToString
        End While

        If e.KeyChar = vbCr Then
            If userFound = True Then
                If emp_type = "admin" Then
                    Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime & "',
                                               '" & txtbx_username.Text & "','Admin Login')", cnn)
                    cmd2.ExecuteReader()
                    MsgBox("    Welcome " & FirstName & " " & LastName, MsgBoxStyle.OkOnly, "Log-in Succesfully")
                    Dim obj As New Mainpage
                    obj.username = txtbx_username.Text
                    txtbx_username.Clear()
                    txtbx_password.Clear()
                    txtbx_username.Focus()
                    Me.Hide()
                    obj.Show()
                ElseIf emp_type = "employee" Then
                    Dim cmd3 As OleDbCommand = New OleDbCommand("INSERT INTO mtpro_logs(logs_time,logs_user,logs_function) 
                                        VALUES('" & DateTime.Now.ToLocalTime & "',
                                               '" & txtbx_username.Text & "','Employee Login Attempt Failure')", cnn)
                    cmd3.ExecuteReader()
                    txtbx_username.Clear()
                    txtbx_password.Clear()
                    txtbx_username.Focus()
                    MessageBox.Show("Unauthorized Login. Ask for Admin.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtbx_username.Focus()
                End If
            Else
                txtbx_username.Clear()
                txtbx_password.Clear()
                MessageBox.Show("Unable to log-in. Check credentials.", "ERROR ENCOUNTERED", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbx_username.Focus()
            End If
        End If
    End Sub
    Private Sub EXITToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbx_username.Clear()
        txtbx_password.Clear()
        txtbx_username.Focus()
    End Sub
End Class
