Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frm_category

    'define path to database
    Public dsn_name As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\Misc\\Informatics\\Project Documents" & _
                                "\\VB\\library.accdb"

    'initialize variable
    Dim add_edit As String = ""
    Dim msg_title As String = "Library Management System"

    Private Sub btn_back_to_main_Click(sender As Object, e As EventArgs) Handles btn_back_to_main.Click

        'hide current form and show main form
        Me.Hide()
        frm_main.Show()

    End Sub

    Private Sub frm_category_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'show the main form if the user close current form
        frm_main.Show()

    End Sub

    Private Sub frm_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'hide the maximize and minimize buttons
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'add background image for form
        Me.BackgroundImage = Image.FromFile("D:\Misc\Informatics\Project Documents\VB\Wallpaper.jpg")

        'make the ID text box read only
        Me.txt_cat_id.ReadOnly = True

        'make the data grid read only
        Me.dg_category.ReadOnly = True

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_show_all_Click(sender As Object, e As EventArgs) Handles btn_show_all.Click

        'create the database connection
        Dim cn As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim da As New OleDbDataAdapter("SELECT cat_id AS [Category ID],cat_name AS [Category Name]  FROM category " & _
                                       "ORDER BY cat_id", cn)
        Dim dt As New DataTable

        da.Fill(dt)
        da.Dispose()
        cn.Dispose()
        dg_category.DataSource = dt

        'make other text box(es) read only
        txt_read_only(True)

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(True)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'show "Auto Number" to user as this text box is a read only text box
        txt_cat_id.Text = "Auto Number"

        'clear text box
        txt_cat_name.Text = ""

        'make other text box(es) can type
        txt_read_only(False)

        'set focus to text box
        txt_cat_name.Focus()

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
                Dim cat_name As String = Trim(txt_cat_name.Text)

                'insert a record to the table
                Dim str_add As String = "INSERT INTO category (cat_name) VALUES ('" & cat_name & "')"

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
                Dim cat_id As String = txt_cat_id.Text
                Dim cat_name As String = Trim(txt_cat_name.Text)

                'update record according to specific ID
                Dim str_update As String = "UPDATE category SET cat_name = '" & cat_name & "' WHERE cat_id = " & cat_id

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

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim selected_row_count As Integer = dg_category.Rows.GetRowCount(DataGridViewElementStates.Selected)

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

                'assign data grid's values to variables
                Dim cat_id As String = dg_category.SelectedRows(0).Cells(0).Value.ToString()
                Dim cat_name As String = dg_category.SelectedRows(0).Cells(1).Value.ToString()

                'show values in text boxes
                txt_cat_id.Text = cat_id
                txt_cat_name.Text = cat_name

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

            Dim cat_id As String = txt_cat_id.Text

            'create database connection
            Dim cn As New OleDbConnection(dsn_name)
            Dim cmd As New OleDbCommand

            With cmd

                'delete the specific record according to ID
                .CommandText = "DELETE FROM category WHERE cat_id = " & cat_id
                .Connection = cn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
                .Dispose()

            End With
            cn.Dispose()

            'show status
            MessageBox.Show("The record is deleted !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'clear text box
            txt_cat_id.Text = ""
            txt_cat_name.Text = ""

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

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            Dim selected_row_count As Integer = dg_category.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selected_row_count > 0 Then

                'assign data grid's values to variables
                Dim cat_id As String = dg_category.SelectedRows(0).Cells(0).Value.ToString()
                Dim cat_name As String = dg_category.SelectedRows(0).Cells(1).Value.ToString()

                'show values in text boxes
                txt_cat_id.Text = cat_id
                txt_cat_name.Text = cat_name

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

        txt_cat_name.Focus()

        'assign 'edit' in variable
        add_edit = "edit"

        'enable and disable of buttons
        btn_save_cancel(True)
        btn_switch(False)
        btn_delete_update(False)

    End Sub

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

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        'clear text boxes
        txt_cat_id.Text = ""
        txt_cat_name.Text = ""

        'buttons enable and disable
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_delete_update(ByVal func As Boolean)

        'boolean sub routine for buttons enable and disable
        btn_delete.Enabled = func
        btn_update.Enabled = func

    End Sub

    Private Function validate_fields() As Boolean

        'check validation of data entry
        If Trim(txt_cat_name.Text) = "" Then

            MessageBox.Show("Name cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_cat_name.Focus()

            Return False

        End If

        Return True

    End Function

    Private Sub txt_read_only(ByVal func As Boolean)

        'make other text box(es) read only
        txt_cat_name.ReadOnly = func

    End Sub

End Class