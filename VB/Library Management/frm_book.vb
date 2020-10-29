Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frm_book

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
        txt_title.Text = ""
        txt_author.Text = ""
        txt_desp.Text = ""
        txt_isbn.Text = ""
        txt_price.Text = ""
        dt_pdate.ResetText()

    End Sub

    Private Sub txt_read_only(ByVal func As Boolean)

        'make other text box(es) read only
        txt_title.ReadOnly = func
        txt_author.ReadOnly = func
        txt_desp.ReadOnly = func
        cbo_cat_id.Enabled = Not (func)
        cbo_pub_id.Enabled = Not (func)
        txt_isbn.ReadOnly = func
        txt_price.ReadOnly = func
        dt_pdate.Enabled = Not (func)

    End Sub

    Private Sub assign_data_show_values()

        'assign data grid's values to variables
        Dim b_id As String = dg_book.SelectedRows(0).Cells(0).Value.ToString()
        Dim title As String = dg_book.SelectedRows(0).Cells(1).Value.ToString()
        Dim author As String = dg_book.SelectedRows(0).Cells(2).Value.ToString()
        Dim desp As String = dg_book.SelectedRows(0).Cells(3).Value.ToString()
        Dim cat_id As String = dg_book.SelectedRows(0).Cells(4).Value.ToString()
        Dim pub_id As String = dg_book.SelectedRows(0).Cells(5).Value.ToString()
        Dim isbn As String = dg_book.SelectedRows(0).Cells(6).Value.ToString()
        Dim price As String = dg_book.SelectedRows(0).Cells(7).Value.ToString()
        Dim pdate As String = dg_book.SelectedRows(0).Cells(8).Value.ToString()

        'show values in text boxes
        txt_b_id.Text = b_id
        txt_title.Text = title
        txt_author.Text = author
        txt_desp.Text = desp
        cbo_cat_id.Text = cat_id
        cbo_pub_id.Text = pub_id
        txt_isbn.Text = isbn
        txt_price.Text = price
        dt_pdate.Value = pdate

    End Sub

    Private Function validate_fields() As Boolean

        'check validation of data entries
        If Trim(txt_title.Text) = "" Then

            'if the data fields are empty
            MessageBox.Show("Book title cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_title.Focus()

            Return False

        End If

        If Trim(txt_author.Text) = "" Then

            MessageBox.Show("Author cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_author.Focus()

            Return False

        End If

        If Trim(txt_desp.Text) = "" Then

            MessageBox.Show("Description cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_desp.Focus()

            Return False

        End If

        If Trim(txt_isbn.Text) = "" Then

            MessageBox.Show("ISBN cannot be empty !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_isbn.Focus()

            Return False

        End If

        If Trim(txt_price.Text) = "" Then

            MessageBox.Show("Price cannot be empty", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_price.Focus()

            Return False

        End If

        Try

            Dim valid_price As Decimal = CDec(txt_price.Text)

        Catch ex As Exception

            'if it's not a valid number format
            MessageBox.Show("Please enter a valid price !", msg_title, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'make other text box(es) can type
            txt_read_only(False)

            txt_price.Focus()

            Return False

        End Try

        Return True

    End Function

    Private Sub btn_back_to_main_Click(sender As Object, e As EventArgs) Handles btn_back_to_main.Click

        'hide current form and show main form
        Me.Hide()
        frm_main.Show()

    End Sub

    Private Sub btn_show_all_Click(sender As Object, e As EventArgs) Handles btn_show_all.Click

        'create the database connection
        Dim cn As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim da As New OleDbDataAdapter("SELECT b_id AS [Book ID],title AS Title,author AS Author," & _
                                       "desp AS Description,cat_id AS [Category ID],pub_id AS [Publisher ID]," & _
                                       "isbn AS [ISBN No],price AS [Purchasing Price],pdate AS [Purchasing Date]" & _
                                       " FROM book ORDER BY b_id", cn)
        Dim dt As New DataTable

        da.Fill(dt)
        da.Dispose()
        cn.Dispose()
        dg_book.DataSource = dt

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

    Private Sub frm_book_Load(sender As Object, e As EventArgs) Handles Me.Load

        'hide the maximize and minimize buttons
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'make the ID text box read only
        Me.txt_b_id.ReadOnly = True

        'make the data grid read only
        Me.dg_book.ReadOnly = True

        'to take category ID from category table
        'create the database connection
        Dim cn As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim da_cat As New OleDbDataAdapter("SELECT cat_id FROM category ORDER BY cat_id", cn)
        Dim dt_cat As New DataTable

        da_cat.Fill(dt_cat)
        da_cat.Dispose()
        cn.Dispose()
        cbo_cat_id.DataSource = dt_cat
        cbo_cat_id.DisplayMember = "cat_id"

        'to take publisher ID from publisher table
        'create the database connection
        Dim con As New OleDbConnection(dsn_name)

        'create the select SQL
        Dim dat As New OleDbDataAdapter("SELECT pub_id FROM publisher ORDER BY pub_id", con)
        Dim tab As New DataTable

        dat.Fill(tab)
        dat.Dispose()
        con.Dispose()
        cbo_pub_id.DataSource = tab
        cbo_pub_id.DisplayMember = "pub_id"

        'enable and disable of buttons
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'show "Auto Number" to user as this text box is a read only text box
        txt_b_id.Text = "Auto Number"

        'clear text box(es) and reset date
        clear_textbox()

        'make other text box(es) can type
        txt_read_only(False)

        'set focus to text box
        txt_title.Focus()

        'assign value to add_edit
        add_edit = "add"

        'enable and disable of buttons
        btn_switch(False)
        btn_save_cancel(True)
        btn_delete_update(False)

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            Dim selected_row_count As Integer = dg_book.Rows.GetRowCount(DataGridViewElementStates.Selected)

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

        txt_title.Focus()

        'assign 'edit' in variable
        add_edit = "edit"

        'enable and disable of buttons
        btn_save_cancel(True)
        btn_switch(False)
        btn_delete_update(False)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'check validation to text boxes
        If validate_fields() = True Then

            'if the variable contains 'add'
            If add_edit = "add" Then

                'get data from text box(es)
                Dim title As String = Trim(txt_title.Text)
                Dim author As String = Trim(txt_author.Text)
                Dim desp As String = Trim(txt_desp.Text)
                Dim cat_id As String = cbo_cat_id.Text
                Dim pub_id As String = cbo_pub_id.Text
                Dim isbn As String = txt_isbn.Text
                Dim price As String = Trim(txt_price.Text)
                Dim pdate As String = dt_pdate.Value.ToString("dd/MM/yyyy")

                'insert a record to the table
                Dim str_add As String = "INSERT INTO book (title,author,desp,cat_id,pub_id,isbn,price,pdate) " & _
                                        "VALUES ('" & title & "','" & author & "','" & desp & "'," & cat_id & "," & _
                                        pub_id & ",'" & isbn & "'," & price & ",#" & pdate & "#)"

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
                Dim b_id As String = txt_b_id.Text
                Dim title As String = Trim(txt_title.Text)
                Dim author As String = Trim(txt_author.Text)
                Dim desp As String = Trim(txt_desp.Text)
                Dim cat_id As String = cbo_cat_id.Text
                Dim pub_id As String = cbo_pub_id.Text
                Dim isbn As String = txt_isbn.Text
                Dim price As String = Trim(txt_price.Text)
                Dim pdate As String = dt_pdate.Value.ToString("dd/MM/yyyy")

                'update record according to specific ID
                Dim str_update As String = "UPDATE book SET title = '" & title & "', author = '" & author & _
                                           "', desp = '" & desp & "', cat_id = " & cat_id & ", pub_id = " & _
                                           pub_id & ", isbn = '" & isbn & "', price = " & price & ", pdate =#" & pdate & _
                                           "# WHERE b_id = " & b_id

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

        Dim selected_row_count As Integer = dg_book.Rows.GetRowCount(DataGridViewElementStates.Selected)

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

            Dim b_id As String = txt_b_id.Text

            'create database connection
            Dim cn As New OleDbConnection(dsn_name)
            Dim cmd As New OleDbCommand

            With cmd

                'delete the specific record according to ID
                .CommandText = "DELETE FROM book WHERE b_id = " & b_id
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
            txt_b_id.Text = ""
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
        txt_b_id.Text = ""
        clear_textbox()

        'buttons enable and disable
        btn_save_cancel(False)
        btn_switch(True)
        btn_delete_update(False)

        'make other text box(es) read only
        txt_read_only(True)

    End Sub

End Class