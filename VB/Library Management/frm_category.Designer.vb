<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_category
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
        Me.dg_category = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_show_all = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.gb_category = New System.Windows.Forms.GroupBox()
        Me.lbl_cat_id = New System.Windows.Forms.Label()
        Me.lbl_cat_name = New System.Windows.Forms.Label()
        Me.txt_cat_id = New System.Windows.Forms.TextBox()
        Me.txt_cat_name = New System.Windows.Forms.TextBox()
        CType(Me.dg_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_category.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_to_main
        '
        Me.btn_back_to_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_to_main.Location = New System.Drawing.Point(593, 464)
        Me.btn_back_to_main.Name = "btn_back_to_main"
        Me.btn_back_to_main.Size = New System.Drawing.Size(134, 23)
        Me.btn_back_to_main.TabIndex = 20
        Me.btn_back_to_main.Text = "Back To &Main Form"
        Me.btn_back_to_main.UseVisualStyleBackColor = True
        '
        'dg_category
        '
        Me.dg_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_category.Location = New System.Drawing.Point(29, 214)
        Me.dg_category.Name = "dg_category"
        Me.dg_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_category.Size = New System.Drawing.Size(698, 214)
        Me.dg_category.TabIndex = 19
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(608, 168)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(507, 168)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Sa&ve"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(608, 114)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_show_all
        '
        Me.btn_show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_all.Location = New System.Drawing.Point(507, 114)
        Me.btn_show_all.Name = "btn_show_all"
        Me.btn_show_all.Size = New System.Drawing.Size(75, 23)
        Me.btn_show_all.TabIndex = 15
        Me.btn_show_all.Text = "&Show All"
        Me.btn_show_all.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(608, 60)
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
        Me.btn_add.Location = New System.Drawing.Point(507, 60)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 12
        Me.btn_add.Text = "&Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'gb_category
        '
        Me.gb_category.BackColor = System.Drawing.Color.Transparent
        Me.gb_category.Controls.Add(Me.lbl_cat_id)
        Me.gb_category.Controls.Add(Me.lbl_cat_name)
        Me.gb_category.Controls.Add(Me.txt_cat_id)
        Me.gb_category.Controls.Add(Me.txt_cat_name)
        Me.gb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_category.Location = New System.Drawing.Point(29, 60)
        Me.gb_category.Name = "gb_category"
        Me.gb_category.Size = New System.Drawing.Size(411, 131)
        Me.gb_category.TabIndex = 13
        Me.gb_category.TabStop = False
        Me.gb_category.Text = "Category Information"
        '
        'lbl_cat_id
        '
        Me.lbl_cat_id.AutoSize = True
        Me.lbl_cat_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_cat_id.Location = New System.Drawing.Point(15, 31)
        Me.lbl_cat_id.Name = "lbl_cat_id"
        Me.lbl_cat_id.Size = New System.Drawing.Size(70, 15)
        Me.lbl_cat_id.TabIndex = 2
        Me.lbl_cat_id.Text = "Category ID"
        '
        'lbl_cat_name
        '
        Me.lbl_cat_name.AutoSize = True
        Me.lbl_cat_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_cat_name.Location = New System.Drawing.Point(15, 86)
        Me.lbl_cat_name.Name = "lbl_cat_name"
        Me.lbl_cat_name.Size = New System.Drawing.Size(92, 15)
        Me.lbl_cat_name.TabIndex = 3
        Me.lbl_cat_name.Text = "Category Name"
        '
        'txt_cat_id
        '
        Me.txt_cat_id.Location = New System.Drawing.Point(121, 31)
        Me.txt_cat_id.Name = "txt_cat_id"
        Me.txt_cat_id.Size = New System.Drawing.Size(259, 21)
        Me.txt_cat_id.TabIndex = 0
        '
        'txt_cat_name
        '
        Me.txt_cat_name.Location = New System.Drawing.Point(121, 86)
        Me.txt_cat_name.Name = "txt_cat_name"
        Me.txt_cat_name.Size = New System.Drawing.Size(259, 21)
        Me.txt_cat_name.TabIndex = 1
        '
        'frm_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 524)
        Me.Controls.Add(Me.btn_back_to_main)
        Me.Controls.Add(Me.dg_category)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_show_all)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.gb_category)
        Me.Name = "frm_category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Information"
        CType(Me.dg_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_category.ResumeLayout(False)
        Me.gb_category.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_back_to_main As System.Windows.Forms.Button
    Friend WithEvents dg_category As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_show_all As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents gb_category As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cat_id As System.Windows.Forms.Label
    Friend WithEvents lbl_cat_name As System.Windows.Forms.Label
    Friend WithEvents txt_cat_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_cat_name As System.Windows.Forms.TextBox
End Class
