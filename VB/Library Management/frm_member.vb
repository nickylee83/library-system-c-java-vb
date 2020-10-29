Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frm_member

    'define path to database
    Public dsn_name As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\Misc\\Informatics\\Project Documents" & _
                                "\\VB\\library.accdb"

    'initialize variable
    Dim add_edit As String = ""
    Dim msg_title As String = "Library Management System"

    Private Sub btn_switch(ByVal func As Boolean)

        'boolean sub routine for buttons enable and disable

        btn_add.Enabled = func
        btn_show_all.Enabled = func
        btn_back_to_main.Enabled = func

    End Sub

    Private Sub btn_save_cancel(ByVal func As Boolean)

        'boolean sub routine for buttons enable and disable
        btn_save.Enabled = func
        btn_cancel.Enabled = func

    End Sub

    Private Sub btn_delete_update(ByVal func As Boolean)

        'boolean sub routine for buttons enable and disable
        btn_delete.Enabled = func
        btn_update.Enabled = func

    End Sub

    Private Sub clear_textbox()

        'clear text boxes and reset
        txt_mem_name.Text = ""
        txt_ic.Text = ""
        txt_addr.Text = ""
        txt_phone.Text = ""
        dt_reg_date.ResetText()
        dt_exp_date.ResetText()
        txt_max_items.Text = ""

    End Sub

    Private Sub txt_read_only(ByVal func As Boolean)

        'make other text box(es) read only
        txt_mem_name.ReadOnly = func
        txt_ic.ReadOnly = func
        txt_addr.ReadOnly = func
        txt_phone.ReadOnly = func
        dt_reg_date.Enabled = Not (func)
        dt_exp_date.Enabled = Not (func)
        txt_max_items.ReadOnly = func

    End Sub

    Private Sub assign_data_show_values()

        'assign data grid's values to variables
        Dim mem_id As String = dg_member.SelectedRows(0).Cells(0).Value.ToString()
        Dim mem_name As String = dg_member.SelectedRows(0).Cells(1).Value.ToString()
        Dim ic As String = dg_member.SelectedRows(0).Cells(2).Value.ToString()
        Dim addr As String = dg_member.SelectedRows(0).Cells(3).Value.ToString()
        Dim phone As String = dg_member.SelectedRows(0).Cells(4).Value.ToString()
        Dim reg_date As String = dg_member.SelectedRows(0).Cells(5).Value.ToString()
        Dim exp_date As String = dg_member.SelectedRows(0).Cells(6).Value.ToString()
        Dim max_items As String = dg_member.SelectedRows(0).Cells(7).Value.ToString()

        'show values in text boxes
        txt_mem_id.Text = mem_id
        txt_mem_name.Text = mem_name
        txt_ic.Text = ic
        txt_addr.Text = addr
        txt_phone.Text = phone
        dt_reg_date.Value = reg_date
        dt_exp_date.Value = exp_date
        txt_max_items.Text = max_items

    End Sub

    Private Sub btn_back_to_main_Click(sender As Object, e As EventArgs) Handles btn_back_to_main.Click

        'hide current form and show main form
        Me.Hide()
        frm_main.Show()

    End Sub

    Private Sub btn_show_all_Click(sender As Object, e As EventArgs) Handles btn_show_all.Click

        'create the database connection
        Dim cn As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim da As New OleDbDataAdapter("SELECT mem_id AS [Member ID],mem_name AS [Member Name],ic AS [IC No]," & _
                                       "addr AS [Address],phone AS [Phone],reg_date AS [Registration Date]," & _
                                       "exp_date AS [Expiry Date],max_items AS [Maximum Items] FROM member " & _
                                       "ORDER BY mem_id", cn)
        Dim dt As New DataTable

        da.Fill(dt)
        da.Dispose()
        cn.Dispose()
        dg_member.DataSource = dt

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(True)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub frm_member_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'show the main form if the user close current form
        frm_main.Show()

    End Sub

    Private Sub frm_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hide the maximize and minimize buttons
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'add background image for form
        Me.BackgroundImage = Image.FromFile("D:\Misc\Informatics\Project Documents\VB\Wallpaper.jpg")

        'make the ID text box read only
        Me.txt_mem_id.ReadOnly = True

        'make the data grid read only
        Me.dg_member.ReadOnly = True

        'maximum number of loan items should be 2 digit number only
        txt_max_items.MaxLength = 2

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'show "Auto Number" to user as this text box is a read only text box
        txt_mem_id.Text = "Auto Number"

        'clear text box(es) and reset date
        clear_textbox()

        'make other text box(es) can type
        txt_read_only(False)

        'set focus to text box
        txt_mem_name.Focus()

        'assign value to add_edit
        add_edit = "add"

        'enable and disable of buttons
        btn_switch(False)
        btn_save_cancel(True)
        btn_delete_update(False)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'check validation to text boxes
        If validate_fields() = True Then

            'if the variable contains 'add'
            If add_edit = "add" Then

                'get data from text box(es)
                Dim mem_name As String = Trim(txt_mem_name.Text)
                Dim ic As String = Trim(txt_ic.Text)
                Dim addr As String = Trim(txt_addr.Text)
                Dim phone As String = Trim(txt_phone.Text)
                Dim reg_date As String = dt_reg_date.Value.ToString("dd/MM/yyyy")
                Dim exp_date As String = dt_exp_date.Value.ToString("dd/MM/yyyy")
                Dim max_items As String = Trim(txt_max_items.Text)

                'insert a record to the table
                Dim str_add As String = "INSERT INTO member (mem_name,ic,addr,phone,reg_date,exp_date,max_items) " & _
                                        "VALUES ('" & mem_name & "','" & ic & "','" & addr & "','" & phone & "',#" & _
                                        reg_date & "#,#" & exp_date & "#," & max_items & ")"

                'create database connection
                Dim cn As New OleDbConnection(dsn_name)
                Dim cmd As New OleDbCommand

                With cmd

                    .CommandText = str_add
                    .Connection = cn
                    .Connection.Open()
                    .ExecuteNonQuery()
                    .Connection.Close()
                    .Dispose()

                End With
                cn.Dispose()

                'show status
                MessageBox.Show("The record is added !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'refresh data grid
                btn_show_all_Click(btn_show_all, New EventArgs())

                'if the variable contains 'edit'
            Else

                'get data from text boxes
                Dim mem_id As String = txt_mem_id.Text
                Dim mem_name As String = Trim(txt_mem_name.Text)
                Dim ic As String = Trim(txt_ic.Text)
                Dim addr As String = Trim(txt_addr.Text)
                Dim phone As String = Trim(txt_phone.Text)
                Dim reg_date As String = dt_reg_date.Value.ToString("dd/MM/yyyy")
                Dim exp_date As String = dt_exp_date.Value.ToString("dd/MM/yyyy")
                Dim max_items As String = Trim(txt_max_items.Text)

                'update record according to specific ID
                Dim str_update As String = "UPDATE member SET mem_name = '" & mem_name & "', ic = '" & ic & _
                                           "', addr = '" & addr & "', phone = '" & phone & "', reg_date = #" & _
                                           reg_date & "#, exp_date= #" & exp_date & "#, max_items= " & max_items & _
                                           " WHERE mem_id = " & mem_id

                'create database connection
                Dim cn As New OleDbConnection(dsn_name)
                Dim cmd As New OleDbCommand

                With cmd

                    .CommandText = str_update
                    .Connection = cn
                    .Connection.Open()
                    .ExecuteNonQuery()
                    .Connection.Close()
                    .Dispose()

                End With
                cn.Dispose()

                'show status
                MessageBox.Show("The record is updated !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'refresh data grid
                btn_show_all_Click(btn_show_all, New EventArgs())

            End If

        Else

            'if the data is not validated then exit this sub routine
            Exit Sub

        End If

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

        'set variable to null
        add_edit = ""

    End Sub

    Private Function validate_fields() As Boolean

        'check validation of data entries
        If Trim(txt_mem_name.Text) = "" Then

            'if the data fields are empty
            MessageBox.Show("Name cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_mem_name.Focus()

            Return False

        End If

        If Trim(txt_ic.Text) = "" Then

            MessageBox.Show("IC number cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_ic.Focus()

            Return False

        End If

        If Trim(txt_addr.Text) = "" Then

            MessageBox.Show("Address cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_addr.Focus()

            Return False

        End If

        If Trim(txt_phone.Text) = "" Then

            MessageBox.Show("Phone cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_mem_name.Focus()

            Return False

        End If

        If Trim(txt_max_items.Text) = "" Then

            MessageBox.Show("Maximum items cannot be empty", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_max_items.Focus()

            Return False

        End If

        Try

            Dim valid_max_items As Integer = CInt(txt_max_items.Text)

        Catch ex As Exception

            'if it's not a valid number format
            MessageBox.Show("Please enter a valid number !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_max_items.Focus()

            Return False

        End Try

        Return True

    End Function

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            Dim selected_row_count As Integer = dg_member.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selected_row_count > 0 Then

                'assign data grid's values to variables and show values in text boxes
                assign_data_show_values()

            End If

            'user choose a blank row in data grid view to perform operation
        Catch ex As Exception

            MessageBox.Show("Error !!!" & vbNewLine & _
                            "Choose a valid record !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) read only
            txt_read_only(True)

            'enable and disable of buttons
            btn_save_cancel(False)
            btn_switch(True)
            btn_delete_update(True)

            'exit this sub routine
            Exit Sub

        End Try

        'make other text box(es) can type
        txt_read_only(False)

        txt_mem_name.Focus()

        'assign 'edit' in variable
        add_edit = "edit"

        'enable and disable of buttons
        btn_save_cancel(True)
        btn_switch(False)
        btn_delete_update(False)

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        'clear text boxes
        txt_mem_id.Text = ""
        clear_textbox()

        'buttons enable and disable
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim selected_row_count As Integer = dg_member.Rows.GetRowCount(DataGridViewElementStates.Selected)

        'if there is no row in table
        If selected_row_count = 0 Then

            'show status
            MessageBox.Show("No records to delete !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'enable and disable of buttons
            btn_save_cancel(False)
            btn_switch(True)
            btn_delete_update(False)

            'make other text box(es) read only
            txt_read_only(True)

            'exit this sub routine
            Exit Sub

        End If

        Try

            'if there is at least one record
            If selected_row_count > 0 Then

                'assign data and show values in text boxes
                assign_data_show_values()

            End If

            'user choose a blank row in data grid view to perform operation
        Catch ex As Exception

            MessageBox.Show("Error !!!" & vbNewLine & _
                            "Choose a valid record !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) read only
            txt_read_only(True)

            'enable and disable of buttons
            btn_save_cancel(False)
            btn_switch(True)
            btn_delete_update(True)

            'exit this sub routine
            Exit Sub

        End Try

        'ask confirmation to delete
        If (MessageBox.Show("Are you sure you want to delete " & _
                            "this record ?", msg_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then

            Dim mem_id As String = txt_mem_id.Text

            'create database connection
            Dim cn As New OleDbConnection(dsn_name)
            Dim cmd As New OleDbCommand

            With cmd

                'delete the specific record according to ID
                .CommandText = "DELETE FROM member WHERE mem_id = " & mem_id
                .Connection = cn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
                .Dispose()

            End With
            cn.Dispose()

            'show status
            MessageBox.Show("The record is deleted !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'clear text box(es)
            txt_mem_id.Text = ""
            clear_textbox()

            'refresh data grid
            btn_show_all_Click(btn_show_all, New EventArgs())

        Else

            MessageBox.Show("The record is not deleted !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

End Class