<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_publisher
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
        Me.txt_pub_id = New System.Windows.Forms.TextBox()
        Me.txt_pub_name = New System.Windows.Forms.TextBox()
        Me.lbl_pub_id = New System.Windows.Forms.Label()
        Me.lbl_pub_name = New System.Windows.Forms.Label()
        Me.gb_publisher = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_show_all = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.dg_publisher = New System.Windows.Forms.DataGridView()
        Me.btn_back_to_main = New System.Windows.Forms.Button()
        Me.gb_publisher.SuspendLayout()
        CType(Me.dg_publisher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pub_id
        '
        Me.txt_pub_id.Location = New System.Drawing.Point(121, 31)
        Me.txt_pub_id.Name = "txt_pub_id"
        Me.txt_pub_id.Size = New System.Drawing.Size(259, 21)
        Me.txt_pub_id.TabIndex = 0
        '
        'txt_pub_name
        '
        Me.txt_pub_name.Location = New System.Drawing.Point(121, 86)
        Me.txt_pub_name.Name = "txt_pub_name"
        Me.txt_pub_name.Size = New System.Drawing.Size(259, 21)
        Me.txt_pub_name.TabIndex = 1
        '
        'lbl_pub_id
        '
        Me.lbl_pub_id.AutoSize = True
        Me.lbl_pub_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_pub_id.Location = New System.Drawing.Point(15, 31)
        Me.lbl_pub_id.Name = "lbl_pub_id"
        Me.lbl_pub_id.Size = New System.Drawing.Size(74, 15)
        Me.lbl_pub_id.TabIndex = 2
        Me.lbl_pub_id.Text = "Publisher ID"
        '
        'lbl_pub_name
        '
        Me.lbl_pub_name.AutoSize = True
        Me.lbl_pub_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_pub_name.Location = New System.Drawing.Point(15, 86)
        Me.lbl_pub_name.Name = "lbl_pub_name"
        Me.lbl_pub_name.Size = New System.Drawing.Size(96, 15)
        Me.lbl_pub_name.TabIndex = 3
        Me.lbl_pub_name.Text = "Publisher Name"
        '
        'gb_publisher
        '
        Me.gb_publisher.BackColor = System.Drawing.Color.Transparent
        Me.gb_publisher.Controls.Add(Me.lbl_pub_id)
        Me.gb_publisher.Controls.Add(Me.lbl_pub_name)
        Me.gb_publisher.Controls.Add(Me.txt_pub_id)
        Me.gb_publisher.Controls.Add(Me.txt_pub_name)
        Me.gb_publisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_publisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_publisher.Location = New System.Drawing.Point(27, 53)
        Me.gb_publisher.Name = "gb_publisher"
        Me.gb_publisher.Size = New System.Drawing.Size(411, 131)
        Me.gb_publisher.TabIndex = 4
        Me.gb_publisher.TabStop = False
        Me.gb_publisher.Text = "Publisher Information"
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add.Location = New System.Drawing.Point(503, 53)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "&Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(604, 53)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_show_all
        '
        Me.btn_show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_all.Location = New System.Drawing.Point(505, 107)
        Me.btn_show_all.Name = "btn_show_all"
        Me.btn_show_all.Size = New System.Drawing.Size(75, 23)
        Me.btn_show_all.TabIndex = 6
        Me.btn_show_all.Text = "&Show All"
        Me.btn_show_all.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(606, 107)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(505, 161)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Sa&ve"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(606, 161)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'dg_publisher
        '
        Me.dg_publisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_publisher.Location = New System.Drawing.Point(27, 207)
        Me.dg_publisher.Name = "dg_publisher"
        Me.dg_publisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_publisher.Size = New System.Drawing.Size(698, 214)
        Me.dg_publisher.TabIndex = 10
        '
        'btn_back_to_main
        '
        Me.btn_back_to_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_to_main.Location = New System.Drawing.Point(591, 457)
        Me.btn_back_to_main.Name = "btn_back_to_main"
        Me.btn_back_to_main.Size = New System.Drawing.Size(134, 23)
        Me.btn_back_to_main.TabIndex = 11
        Me.btn_back_to_main.Text = "Back To &Main Form"
        Me.btn_back_to_main.UseVisualStyleBackColor = True
        '
        'frm_publisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 498)
        Me.Controls.Add(Me.btn_back_to_main)
        Me.Controls.Add(Me.dg_publisher)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_show_all)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.gb_publisher)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frm_publisher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Publisher Information"
        Me.gb_publisher.ResumeLayout(False)
        Me.gb_publisher.PerformLayout()
        CType(Me.dg_publisher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_pub_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_pub_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pub_id As System.Windows.Forms.Label
    Friend WithEvents lbl_pub_name As System.Windows.Forms.Label
    Friend WithEvents gb_publisher As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_show_all As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents dg_publisher As System.Windows.Forms.DataGridView
    Friend WithEvents btn_back_to_main As System.Windows.Forms.Button
End Class
