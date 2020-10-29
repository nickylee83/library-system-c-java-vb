<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_back_to_main = New System.Windows.Forms.Button()
        Me.dg_tran = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_show_all = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.gb_tran = New System.Windows.Forms.GroupBox()
        Me.cbo_status = New System.Windows.Forms.ComboBox()
        Me.lbl_due_date = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_b_id = New System.Windows.Forms.Label()
        Me.lbl_borrow_date = New System.Windows.Forms.Label()
        Me.dt_due_date = New System.Windows.Forms.DateTimePicker()
        Me.dt_borrow_date = New System.Windows.Forms.DateTimePicker()
        Me.cbo_b_id = New System.Windows.Forms.ComboBox()
        Me.cbo_mem_id = New System.Windows.Forms.ComboBox()
        Me.lbl_tran_id = New System.Windows.Forms.Label()
        Me.lbl_mem_id = New System.Windows.Forms.Label()
        Me.txt_tran_id = New System.Windows.Forms.TextBox()
        CType(Me.dg_tran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tran.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_to_main
        '
        Me.btn_back_to_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_to_main.Location = New System.Drawing.Point(589, 610)
        Me.btn_back_to_main.Name = "btn_back_to_main"
        Me.btn_back_to_main.Size = New System.Drawing.Size(134, 23)
        Me.btn_back_to_main.TabIndex = 20
        Me.btn_back_to_main.Text = "Back To &Main Form"
        Me.btn_back_to_main.UseVisualStyleBackColor = True
        '
        'dg_tran
        '
        Me.dg_tran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tran.Location = New System.Drawing.Point(25, 360)
        Me.dg_tran.Name = "dg_tran"
        Me.dg_tran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_tran.Size = New System.Drawing.Size(698, 214)
        Me.dg_tran.TabIndex = 19
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(604, 144)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(503, 144)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Sa&ve"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(604, 90)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_show_all
        '
        Me.btn_show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_all.Location = New System.Drawing.Point(503, 90)
        Me.btn_show_all.Name = "btn_show_all"
        Me.btn_show_all.Size = New System.Drawing.Size(75, 23)
        Me.btn_show_all.TabIndex = 15
        Me.btn_show_all.Text = "&Show All"
        Me.btn_show_all.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(602, 36)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add.Location = New System.Drawing.Point(501, 36)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 12
        Me.btn_add.Text = "&Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'gb_tran
        '
        Me.gb_tran.BackColor = System.Drawing.Color.Transparent
        Me.gb_tran.Controls.Add(Me.cbo_status)
        Me.gb_tran.Controls.Add(Me.lbl_due_date)
        Me.gb_tran.Controls.Add(Me.lbl_status)
        Me.gb_tran.Controls.Add(Me.lbl_b_id)
        Me.gb_tran.Controls.Add(Me.lbl_borrow_date)
        Me.gb_tran.Controls.Add(Me.dt_due_date)
        Me.gb_tran.Controls.Add(Me.dt_borrow_date)
        Me.gb_tran.Controls.Add(Me.cbo_b_id)
        Me.gb_tran.Controls.Add(Me.cbo_mem_id)
        Me.gb_tran.Controls.Add(Me.lbl_tran_id)
        Me.gb_tran.Controls.Add(Me.lbl_mem_id)
        Me.gb_tran.Controls.Add(Me.txt_tran_id)
        Me.gb_tran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_tran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_tran.Location = New System.Drawing.Point(25, 36)
        Me.gb_tran.Name = "gb_tran"
        Me.gb_tran.Size = New System.Drawing.Size(411, 307)
        Me.gb_tran.TabIndex = 13
        Me.gb_tran.TabStop = False
        Me.gb_tran.Text = "Rental Information"
        '
        'cbo_status
        '
        Me.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_status.FormattingEnabled = True
        Me.cbo_status.Location = New System.Drawing.Point(121, 263)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.Size = New System.Drawing.Size(259, 23)
        Me.cbo_status.TabIndex = 30
        '
        'lbl_due_date
        '
        Me.lbl_due_date.AutoSize = True
        Me.lbl_due_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_due_date.Location = New System.Drawing.Point(15, 222)
        Me.lbl_due_date.Name = "lbl_due_date"
        Me.lbl_due_date.Size = New System.Drawing.Size(59, 15)
        Me.lbl_due_date.TabIndex = 28
        Me.lbl_due_date.Text = "Due Date"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_status.Location = New System.Drawing.Point(15, 266)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(41, 15)
        Me.lbl_status.TabIndex = 29
        Me.lbl_status.Text = "Status"
        '
        'lbl_b_id
        '
        Me.lbl_b_id.AutoSize = True
        Me.lbl_b_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_b_id.Location = New System.Drawing.Point(15, 131)
        Me.lbl_b_id.Name = "lbl_b_id"
        Me.lbl_b_id.Size = New System.Drawing.Size(50, 15)
        Me.lbl_b_id.TabIndex = 26
        Me.lbl_b_id.Text = "Book ID"
        '
        'lbl_borrow_date
        '
        Me.lbl_borrow_date.AutoSize = True
        Me.lbl_borrow_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_borrow_date.Location = New System.Drawing.Point(15, 181)
        Me.lbl_borrow_date.Name = "lbl_borrow_date"
        Me.lbl_borrow_date.Size = New System.Drawing.Size(75, 15)
        Me.lbl_borrow_date.TabIndex = 27
        Me.lbl_borrow_date.Text = "Borrow Date"
        '
        'dt_due_date
        '
        Me.dt_due_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_due_date.Location = New System.Drawing.Point(121, 217)
        Me.dt_due_date.Name = "dt_due_date"
        Me.dt_due_date.Size = New System.Drawing.Size(259, 21)
        Me.dt_due_date.TabIndex = 25
        '
        'dt_borrow_date
        '
        Me.dt_borrow_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_borrow_date.Location = New System.Drawing.Point(121, 174)
        Me.dt_borrow_date.Name = "dt_borrow_date"
        Me.dt_borrow_date.Size = New System.Drawing.Size(259, 21)
        Me.dt_borrow_date.TabIndex = 24
        Me.dt_borrow_date.Value = New Date(2014, 3, 8, 0, 0, 0, 0)
        '
        'cbo_b_id
        '
        Me.cbo_b_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_b_id.FormattingEnabled = True
        Me.cbo_b_id.Location = New System.Drawing.Point(121, 128)
        Me.cbo_b_id.Name = "cbo_b_id"
        Me.cbo_b_id.Size = New System.Drawing.Size(259, 23)
        Me.cbo_b_id.TabIndex = 5
        '
        'cbo_mem_id
        '
        Me.cbo_mem_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_mem_id.FormattingEnabled = True
        Me.cbo_mem_id.Location = New System.Drawing.Point(121, 78)
        Me.cbo_mem_id.Name = "cbo_mem_id"
        Me.cbo_mem_id.Size = New System.Drawing.Size(259, 23)
        Me.cbo_mem_id.TabIndex = 4
        '
        'lbl_tran_id
        '
        Me.lbl_tran_id.AutoSize = True
        Me.lbl_tran_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_tran_id.Location = New System.Drawing.Point(15, 31)
        Me.lbl_tran_id.Name = "lbl_tran_id"
        Me.lbl_tran_id.Size = New System.Drawing.Size(86, 15)
        Me.lbl_tran_id.TabIndex = 2
        Me.lbl_tran_id.Text = "Transaction ID"
        '
        'lbl_mem_id
        '
        Me.lbl_mem_id.AutoSize = True
        Me.lbl_mem_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_mem_id.Location = New System.Drawing.Point(15, 81)
        Me.lbl_mem_id.Name = "lbl_mem_id"
        Me.lbl_mem_id.Size = New System.Drawing.Size(69, 15)
        Me.lbl_mem_id.TabIndex = 3
        Me.lbl_mem_id.Text = "Member ID"
        '
        'txt_tran_id
        '
        Me.txt_tran_id.Location = New System.Drawing.Point(121, 31)
        Me.txt_tran_id.Name = "txt_tran_id"
        Me.txt_tran_id.Size = New System.Drawing.Size(259, 21)
        Me.txt_tran_id.TabIndex = 0
        '
        'frm_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 644)
        Me.Controls.Add(Me.btn_back_to_main)
        Me.Controls.Add(Me.dg_tran)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_show_all)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.gb_tran)
        Me.Name = "frm_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental Information"
        CType(Me.dg_tran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tran.ResumeLayout(False)
        Me.gb_tran.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_back_to_main As System.Windows.Forms.Button
    Friend WithEvents dg_tran As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_show_all As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents gb_tran As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_b_id As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_mem_id As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tran_id As System.Windows.Forms.Label
    Friend WithEvents lbl_mem_id As System.Windows.Forms.Label
    Friend WithEvents txt_tran_id As System.Windows.Forms.TextBox
    Friend WithEvents dt_due_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_borrow_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_status As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_due_date As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents lbl_b_id As System.Windows.Forms.Label
    Friend WithEvents lbl_borrow_date As System.Windows.Forms.Label
End Class
