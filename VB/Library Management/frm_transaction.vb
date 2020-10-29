Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frm_transaction

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
        dt_borrow_date.ResetText()
        dt_due_date.ResetText()
        cbo_status.Text = cbo_status.Items(0).ToString

    End Sub

    Private Sub txt_read_only(ByVal func As Boolean)

        'make other text box(es) read only
        cbo_mem_id.Enabled = Not (func)
        cbo_b_id.Enabled = Not (func)
        dt_borrow_date.Enabled = Not (func)
        dt_due_date.Enabled = Not (func)
        cbo_status.Enabled = Not (func)

    End Sub

    Private Sub assign_data_show_values()

        'assign data grid's values to variables
        Dim tran_id As String = dg_tran.SelectedRows(0).Cells(0).Value.ToString()
        Dim mem_id As String = dg_tran.SelectedRows(0).Cells(1).Value.ToString()
        Dim b_id As String = dg_tran.SelectedRows(0).Cells(2).Value.ToString()
        Dim borrow_date As String = dg_tran.SelectedRows(0).Cells(3).Value.ToString()
        Dim due_date As String = dg_tran.SelectedRows(0).Cells(4).Value.ToString()
        Dim status As String = dg_tran.SelectedRows(0).Cells(5).Value.ToString()

        'show values in text boxes
        txt_tran_id.Text = tran_id
        cbo_mem_id.Text = mem_id
        cbo_b_id.Text = b_id
        dt_borrow_date.Value = borrow_date
        dt_due_date.Value = due_date
        cbo_status.Text = status

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
        Dim da As New OleDbDataAdapter("SELECT tran_id AS [Transaction ID],mem_id AS [Member ID],b_id AS [Book ID]," & _
                                       "borrow_date AS [Borrow Date],due_date AS [Due Date],status AS [Book Status]" & _
                                       "FROM [transaction] ORDER BY tran_id", cn)

        Dim dt As New DataTable

        da.Fill(dt)
        da.Dispose()
        cn.Dispose()
        dg_tran.DataSource = dt

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(True)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub frm_transaction_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'show the main form if the user close current form
        frm_main.Show()

    End Sub

    Private Sub frm_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hide the maximize and minimize buttons
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'add background image for form
        Me.BackgroundImage = Image.FromFile("D:\Misc\Informatics\Project Documents\VB\Wallpaper.jpg")

        'make the ID text box read only
        Me.txt_tran_id.ReadOnly = True

        'make the data grid read only
        Me.dg_tran.ReadOnly = True

        'to take member ID from member table
        'create the database connection
        Dim cn As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim da_mem As New OleDbDataAdapter("SELECT mem_id FROM member ORDER BY mem_id", cn)
        Dim dt_mem As New DataTable

        da_mem.Fill(dt_mem)
        da_mem.Dispose()
        cn.Dispose()
        cbo_mem_id.DataSource = dt_mem
        cbo_mem_id.DisplayMember = "mem_id"

        'to take book ID from book table
        'create the database connection
        Dim con As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim dat As New OleDbDataAdapter("SELECT b_id FROM book ORDER BY b_id", con)
        Dim tab As New DataTable

        dat.Fill(tab)
        dat.Dispose()
        con.Dispose()
        cbo_b_id.DataSource = tab
        cbo_b_id.DisplayMember = "b_id"

        'add items to status combo box
        cbo_status.Items.Clear()
        cbo_status.Items.Add("On Loan")
        cbo_status.Items.Add("Available")
        cbo_status.Items.Add("Lost")
        cbo_status.Items.Add("Damaged")

        cbo_status.Text = cbo_status.Items(0).ToString

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'show "Auto Number" to user as this text box is a read only text box
        txt_tran_id.Text = "Auto Number"

        'clear text box(es) and reset date
        clear_textbox()

        'make other text box(es) can type
        txt_read_only(False)

        'set focus to text box
        cbo_mem_id.Focus()

        'assign value to add_edit
        add_edit = "add"

        'enable and disable of buttons
        btn_switch(False)
        btn_save_cancel(True)
        btn_delete_update(False)

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            Dim selected_row_count As Integer = dg_tran.Rows.GetRowCount(DataGridViewElementStates.Selected)

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

        cbo_mem_id.Focus()

        'assign 'edit' in variable
        add_edit = "edit"

        'enable and disable of buttons
        btn_save_cancel(True)
        btn_switch(False)
        btn_delete_update(False)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'if the variable contains 'add'
        If add_edit = "add" Then

            'get data from text box(es)
            Dim mem_id As String = cbo_mem_id.Text
            Dim b_id As String = cbo_b_id.Text
            Dim borrow_date As String = dt_borrow_date.Value.ToString("dd/MM/yyyy")
            Dim due_date As String = dt_due_date.Value.ToString("dd/MM/yyyy")
            Dim status As String = cbo_status.Text

            'insert a record to the table
            Dim str_add As String = "INSERT INTO [transaction] (mem_id,b_id,borrow_date,due_date,status) " & _
                                    "VALUES (" & mem_id & "," & b_id & ",#" & borrow_date & "#,#" & due_date & _
                                    "#,'" & status & "')"

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
            Dim tran_id As String = txt_tran_id.Text
            Dim mem_id As String = cbo_mem_id.Text
            Dim b_id As String = cbo_b_id.Text
            Dim borrow_date As String = dt_borrow_date.Value.ToString("dd/MM/yyyy")
            Dim due_date As String = dt_due_date.Value.ToString("dd/MM/yyyy")
            Dim status As String = cbo_status.Text

            'update record according to specific ID
            Dim str_update As String = "UPDATE [transaction] SET mem_id = " & mem_id & ", b_id = " & b_id & _
                                       ", borrow_date = #" & borrow_date & "#, due_date = #" & due_date & _
                                       "#, status = '" & status & "' WHERE tran_id = " & tran_id

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

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

        'set variable to null
        add_edit = ""

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim selected_row_count As Integer = dg_tran.Rows.GetRowCount(DataGridViewElementStates.Selected)

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

            Dim tran_id As String = txt_tran_id.Text

            'create database connection
            Dim cn As New OleDbConnection(dsn_name)
            Dim cmd As New OleDbCommand

            With cmd

                'delete the specific record according to ID
                .CommandText = "DELETE FROM [transaction] WHERE tran_id = " & tran_id
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
            txt_tran_id.Text = ""
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

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        'clear text boxes
        txt_tran_id.Text = ""
        clear_textbox()

        'buttons enable and disable
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

End Class