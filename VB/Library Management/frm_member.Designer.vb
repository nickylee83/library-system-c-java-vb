<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_member
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
        Me.dg_member = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_show_all = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.gb_member = New System.Windows.Forms.GroupBox()
        Me.dt_exp_date = New System.Windows.Forms.DateTimePicker()
        Me.dt_reg_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_max_items = New System.Windows.Forms.Label()
        Me.txt_max_items = New System.Windows.Forms.TextBox()
        Me.lbl_exp_date = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_reg_date = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_addr = New System.Windows.Forms.Label()
        Me.txt_ic = New System.Windows.Forms.TextBox()
        Me.txt_addr = New System.Windows.Forms.TextBox()
        Me.lbl_ic = New System.Windows.Forms.Label()
        Me.lbl_mem_id = New System.Windows.Forms.Label()
        Me.lbl_mem_name = New System.Windows.Forms.Label()
        Me.txt_mem_id = New System.Windows.Forms.TextBox()
        Me.txt_mem_name = New System.Windows.Forms.TextBox()
        CType(Me.dg_member, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_member.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_to_main
        '
        Me.btn_back_to_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_to_main.Location = New System.Drawing.Point(588, 679)
        Me.btn_back_to_main.Name = "btn_back_to_main"
        Me.btn_back_to_main.Size = New System.Drawing.Size(134, 23)
        Me.btn_back_to_main.TabIndex = 20
        Me.btn_back_to_main.Text = "Back To &Main Form"
        Me.btn_back_to_main.UseVisualStyleBackColor = True
        '
        'dg_member
        '
        Me.dg_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_member.Location = New System.Drawing.Point(24, 443)
        Me.dg_member.Name = "dg_member"
        Me.dg_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_member.Size = New System.Drawing.Size(698, 214)
        Me.dg_member.TabIndex = 19
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
        'gb_member
        '
        Me.gb_member.BackColor = System.Drawing.Color.Transparent
        Me.gb_member.Controls.Add(Me.dt_exp_date)
        Me.gb_member.Controls.Add(Me.dt_reg_date)
        Me.gb_member.Controls.Add(Me.lbl_max_items)
        Me.gb_member.Controls.Add(Me.txt_max_items)
        Me.gb_member.Controls.Add(Me.lbl_exp_date)
        Me.gb_member.Controls.Add(Me.lbl_phone)
        Me.gb_member.Controls.Add(Me.lbl_reg_date)
        Me.gb_member.Controls.Add(Me.txt_phone)
        Me.gb_member.Controls.Add(Me.lbl_addr)
        Me.gb_member.Controls.Add(Me.txt_ic)
        Me.gb_member.Controls.Add(Me.txt_addr)
        Me.gb_member.Controls.Add(Me.lbl_ic)
        Me.gb_member.Controls.Add(Me.lbl_mem_id)
        Me.gb_member.Controls.Add(Me.lbl_mem_name)
        Me.gb_member.Controls.Add(Me.txt_mem_id)
        Me.gb_member.Controls.Add(Me.txt_mem_name)
        Me.gb_member.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_member.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_member.Location = New System.Drawing.Point(25, 36)
        Me.gb_member.Name = "gb_member"
        Me.gb_member.Size = New System.Drawing.Size(411, 383)
        Me.gb_member.TabIndex = 13
        Me.gb_member.TabStop = False
        Me.gb_member.Text = "Member Information"
        '
        'dt_exp_date
        '
        Me.dt_exp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_exp_date.Location = New System.Drawing.Point(121, 300)
        Me.dt_exp_date.Name = "dt_exp_date"
        Me.dt_exp_date.Size = New System.Drawing.Size(259, 21)
        Me.dt_exp_date.TabIndex = 22
        '
        'dt_reg_date
        '
        Me.dt_reg_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_reg_date.Location = New System.Drawing.Point(121, 257)
        Me.dt_reg_date.Name = "dt_reg_date"
        Me.dt_reg_date.Size = New System.Drawing.Size(259, 21)
        Me.dt_reg_date.TabIndex = 21
        Me.dt_reg_date.Value = New Date(2014, 3, 8, 0, 0, 0, 0)
        '
        'lbl_max_items
        '
        Me.lbl_max_items.AutoSize = True
        Me.lbl_max_items.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_max_items.Location = New System.Drawing.Point(15, 346)
        Me.lbl_max_items.Name = "lbl_max_items"
        Me.lbl_max_items.Size = New System.Drawing.Size(96, 15)
        Me.lbl_max_items.TabIndex = 15
        Me.lbl_max_items.Text = "Maximum Items"
        '
        'txt_max_items
        '
        Me.txt_max_items.Location = New System.Drawing.Point(121, 340)
        Me.txt_max_items.Name = "txt_max_items"
        Me.txt_max_items.Size = New System.Drawing.Size(259, 21)
        Me.txt_max_items.TabIndex = 14
        '
        'lbl_exp_date
        '
        Me.lbl_exp_date.AutoSize = True
        Me.lbl_exp_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_exp_date.Location = New System.Drawing.Point(15, 300)
        Me.lbl_exp_date.Name = "lbl_exp_date"
        Me.lbl_exp_date.Size = New System.Drawing.Size(69, 15)
        Me.lbl_exp_date.TabIndex = 12
        Me.lbl_exp_date.Text = "Expiry Date"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_phone.Location = New System.Drawing.Point(15, 214)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(43, 15)
        Me.lbl_phone.TabIndex = 10
        Me.lbl_phone.Text = "Phone"
        '
        'lbl_reg_date
        '
        Me.lbl_reg_date.AutoSize = True
        Me.lbl_reg_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_reg_date.Location = New System.Drawing.Point(15, 257)
        Me.lbl_reg_date.Name = "lbl_reg_date"
        Me.lbl_reg_date.Size = New System.Drawing.Size(102, 15)
        Me.lbl_reg_date.TabIndex = 11
        Me.lbl_reg_date.Text = "Registration Date"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(121, 211)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(259, 21)
        Me.txt_phone.TabIndex = 8
        '
        'lbl_addr
        '
        Me.lbl_addr.AutoSize = True
        Me.lbl_addr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_addr.Location = New System.Drawing.Point(15, 169)
        Me.lbl_addr.Name = "lbl_addr"
        Me.lbl_addr.Size = New System.Drawing.Size(51, 15)
        Me.lbl_addr.TabIndex = 7
        Me.lbl_addr.Text = "Address"
        '
        'txt_ic
        '
        Me.txt_ic.Location = New System.Drawing.Point(121, 120)
        Me.txt_ic.Name = "txt_ic"
        Me.txt_ic.Size = New System.Drawing.Size(259, 21)
        Me.txt_ic.TabIndex = 5
        '
        'txt_addr
        '
        Me.txt_addr.Location = New System.Drawing.Point(121, 163)
        Me.txt_addr.Name = "txt_addr"
        Me.txt_addr.Size = New System.Drawing.Size(259, 21)
        Me.txt_addr.TabIndex = 6
        '
        'lbl_ic
        '
        Me.lbl_ic.AutoSize = True
        Me.lbl_ic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_ic.Location = New System.Drawing.Point(15, 123)
        Me.lbl_ic.Name = "lbl_ic"
        Me.lbl_ic.Size = New System.Drawing.Size(40, 15)
        Me.lbl_ic.TabIndex = 4
        Me.lbl_ic.Text = "IC No:"
        '
        'lbl_mem_id
        '
        Me.lbl_mem_id.AutoSize = True
        Me.lbl_mem_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_mem_id.Location = New System.Drawing.Point(15, 37)
        Me.lbl_mem_id.Name = "lbl_mem_id"
        Me.lbl_mem_id.Size = New System.Drawing.Size(69, 15)
        Me.lbl_mem_id.TabIndex = 2
        Me.lbl_mem_id.Text = "Member ID"
        '
        'lbl_mem_name
        '
        Me.lbl_mem_name.AutoSize = True
        Me.lbl_mem_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_mem_name.Location = New System.Drawing.Point(15, 80)
        Me.lbl_mem_name.Name = "lbl_mem_name"
        Me.lbl_mem_name.Size = New System.Drawing.Size(91, 15)
        Me.lbl_mem_name.TabIndex = 3
        Me.lbl_mem_name.Text = "Member Name"
        '
        'txt_mem_id
        '
        Me.txt_mem_id.Location = New System.Drawing.Point(121, 31)
        Me.txt_mem_id.Name = "txt_mem_id"
        Me.txt_mem_id.Size = New System.Drawing.Size(259, 21)
        Me.txt_mem_id.TabIndex = 0
        '
        'txt_mem_name
        '
        Me.txt_mem_name.Location = New System.Drawing.Point(121, 74)
        Me.txt_mem_name.Name = "txt_mem_name"
        Me.txt_mem_name.Size = New System.Drawing.Size(259, 21)
        Me.txt_mem_name.TabIndex = 1
        '
        'frm_member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 721)
        Me.Controls.Add(Me.btn_back_to_main)
        Me.Controls.Add(Me.dg_member)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_show_all)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.gb_member)
        Me.Name = "frm_member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Information"
        CType(Me.dg_member, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_member.ResumeLayout(False)
        Me.gb_member.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_back_to_main As System.Windows.Forms.Button
    Friend WithEvents dg_member As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_show_all As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents gb_member As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_mem_id As System.Windows.Forms.Label
    Friend WithEvents lbl_mem_name As System.Windows.Forms.Label
    Friend WithEvents txt_mem_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_mem_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_max_items As System.Windows.Forms.Label
    Friend WithEvents txt_max_items As System.Windows.Forms.TextBox
    Friend WithEvents lbl_exp_date As System.Windows.Forms.Label
    Friend WithEvents lbl_phone As System.Windows.Forms.Label
    Friend WithEvents lbl_reg_date As System.Windows.Forms.Label
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents lbl_addr As System.Windows.Forms.Label
    Friend WithEvents txt_ic As System.Windows.Forms.TextBox
    Friend WithEvents txt_addr As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ic As System.Windows.Forms.Label
    Friend WithEvents dt_reg_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_exp_date As System.Windows.Forms.DateTimePicker
End Class
