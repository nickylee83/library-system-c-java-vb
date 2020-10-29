<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_book))
        Me.btn_back_to_main = New System.Windows.Forms.Button()
        Me.dg_book = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_show_all = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.gb_book = New System.Windows.Forms.GroupBox()
        Me.txt_isbn = New System.Windows.Forms.TextBox()
        Me.cbo_pub_id = New System.Windows.Forms.ComboBox()
        Me.cbo_cat_id = New System.Windows.Forms.ComboBox()
        Me.lbl_pdate = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_isbn = New System.Windows.Forms.Label()
        Me.lbl_cat_id = New System.Windows.Forms.Label()
        Me.lbl_pub_id = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.txt_desp = New System.Windows.Forms.TextBox()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.lbl_b_id = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_b_id = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.dt_pdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dg_book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_book.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_to_main
        '
        Me.btn_back_to_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_to_main.Location = New System.Drawing.Point(589, 680)
        Me.btn_back_to_main.Name = "btn_back_to_main"
        Me.btn_back_to_main.Size = New System.Drawing.Size(134, 23)
        Me.btn_back_to_main.TabIndex = 29
        Me.btn_back_to_main.Text = "Back To &Main Form"
        Me.btn_back_to_main.UseVisualStyleBackColor = True
        '
        'dg_book
        '
        Me.dg_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_book.Location = New System.Drawing.Point(25, 464)
        Me.dg_book.Name = "dg_book"
        Me.dg_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_book.Size = New System.Drawing.Size(698, 195)
        Me.dg_book.TabIndex = 28
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(605, 135)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 27
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(504, 135)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 26
        Me.btn_save.Text = "Sa&ve"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(605, 81)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 25
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_show_all
        '
        Me.btn_show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_all.Location = New System.Drawing.Point(504, 81)
        Me.btn_show_all.Name = "btn_show_all"
        Me.btn_show_all.Size = New System.Drawing.Size(75, 23)
        Me.btn_show_all.TabIndex = 24
        Me.btn_show_all.Text = "&Show All"
        Me.btn_show_all.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(603, 27)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 23
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add.Location = New System.Drawing.Point(502, 27)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 21
        Me.btn_add.Text = "&Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'gb_book
        '
        Me.gb_book.BackColor = System.Drawing.Color.Transparent
        Me.gb_book.Controls.Add(Me.txt_isbn)
        Me.gb_book.Controls.Add(Me.cbo_pub_id)
        Me.gb_book.Controls.Add(Me.cbo_cat_id)
        Me.gb_book.Controls.Add(Me.lbl_pdate)
        Me.gb_book.Controls.Add(Me.lbl_price)
        Me.gb_book.Controls.Add(Me.txt_price)
        Me.gb_book.Controls.Add(Me.lbl_isbn)
        Me.gb_book.Controls.Add(Me.lbl_cat_id)
        Me.gb_book.Controls.Add(Me.lbl_pub_id)
        Me.gb_book.Controls.Add(Me.lbl_desc)
        Me.gb_book.Controls.Add(Me.txt_author)
        Me.gb_book.Controls.Add(Me.txt_desp)
        Me.gb_book.Controls.Add(Me.lbl_author)
        Me.gb_book.Controls.Add(Me.lbl_b_id)
        Me.gb_book.Controls.Add(Me.lbl_title)
        Me.gb_book.Controls.Add(Me.txt_b_id)
        Me.gb_book.Controls.Add(Me.txt_title)
        Me.gb_book.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_book.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_book.Location = New System.Drawing.Point(26, 27)
        Me.gb_book.Name = "gb_book"
        Me.gb_book.Size = New System.Drawing.Size(411, 422)
        Me.gb_book.TabIndex = 22
        Me.gb_book.TabStop = False
        Me.gb_book.Text = "Book Information"
        '
        'txt_isbn
        '
        Me.txt_isbn.Location = New System.Drawing.Point(121, 297)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(259, 21)
        Me.txt_isbn.TabIndex = 33
        '
        'cbo_pub_id
        '
        Me.cbo_pub_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_pub_id.FormattingEnabled = True
        Me.cbo_pub_id.Location = New System.Drawing.Point(121, 254)
        Me.cbo_pub_id.Name = "cbo_pub_id"
        Me.cbo_pub_id.Size = New System.Drawing.Size(259, 23)
        Me.cbo_pub_id.TabIndex = 32
        '
        'cbo_cat_id
        '
        Me.cbo_cat_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cat_id.FormattingEnabled = True
        Me.cbo_cat_id.Location = New System.Drawing.Point(121, 211)
        Me.cbo_cat_id.Name = "cbo_cat_id"
        Me.cbo_cat_id.Size = New System.Drawing.Size(259, 23)
        Me.cbo_cat_id.TabIndex = 31
        '
        'lbl_pdate
        '
        Me.lbl_pdate.AutoSize = True
        Me.lbl_pdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_pdate.Location = New System.Drawing.Point(15, 382)
        Me.lbl_pdate.Name = "lbl_pdate"
        Me.lbl_pdate.Size = New System.Drawing.Size(98, 15)
        Me.lbl_pdate.TabIndex = 30
        Me.lbl_pdate.Text = "Purchasing Date"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_price.Location = New System.Drawing.Point(15, 342)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(100, 15)
        Me.lbl_price.TabIndex = 15
        Me.lbl_price.Text = "Purchasing Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(121, 340)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(259, 21)
        Me.txt_price.TabIndex = 14
        '
        'lbl_isbn
        '
        Me.lbl_isbn.AutoSize = True
        Me.lbl_isbn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_isbn.Location = New System.Drawing.Point(15, 300)
        Me.lbl_isbn.Name = "lbl_isbn"
        Me.lbl_isbn.Size = New System.Drawing.Size(35, 15)
        Me.lbl_isbn.TabIndex = 12
        Me.lbl_isbn.Text = "ISBN"
        '
        'lbl_cat_id
        '
        Me.lbl_cat_id.AutoSize = True
        Me.lbl_cat_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_cat_id.Location = New System.Drawing.Point(15, 214)
        Me.lbl_cat_id.Name = "lbl_cat_id"
        Me.lbl_cat_id.Size = New System.Drawing.Size(70, 15)
        Me.lbl_cat_id.TabIndex = 10
        Me.lbl_cat_id.Text = "Category ID"
        '
        'lbl_pub_id
        '
        Me.lbl_pub_id.AutoSize = True
        Me.lbl_pub_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_pub_id.Location = New System.Drawing.Point(15, 257)
        Me.lbl_pub_id.Name = "lbl_pub_id"
        Me.lbl_pub_id.Size = New System.Drawing.Size(74, 15)
        Me.lbl_pub_id.TabIndex = 11
        Me.lbl_pub_id.Text = "Publisher ID"
        Me.lbl_pub_id.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_desc.Location = New System.Drawing.Point(15, 169)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(69, 15)
        Me.lbl_desc.TabIndex = 7
        Me.lbl_desc.Text = "Description"
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(121, 120)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(259, 21)
        Me.txt_author.TabIndex = 5
        '
        'txt_desp
        '
        Me.txt_desp.Location = New System.Drawing.Point(121, 163)
        Me.txt_desp.Name = "txt_desp"
        Me.txt_desp.Size = New System.Drawing.Size(259, 21)
        Me.txt_desp.TabIndex = 6
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_author.Location = New System.Drawing.Point(15, 123)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(88, 15)
        Me.lbl_author.TabIndex = 4
        Me.lbl_author.Text = "Author's Name"
        '
        'lbl_b_id
        '
        Me.lbl_b_id.AutoSize = True
        Me.lbl_b_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_b_id.Location = New System.Drawing.Point(15, 37)
        Me.lbl_b_id.Name = "lbl_b_id"
        Me.lbl_b_id.Size = New System.Drawing.Size(50, 15)
        Me.lbl_b_id.TabIndex = 2
        Me.lbl_b_id.Text = "Book ID"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(15, 80)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(61, 15)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "Book Title"
        '
        'txt_b_id
        '
        Me.txt_b_id.Location = New System.Drawing.Point(121, 31)
        Me.txt_b_id.Name = "txt_b_id"
        Me.txt_b_id.Size = New System.Drawing.Size(259, 21)
        Me.txt_b_id.TabIndex = 0
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(121, 74)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(259, 21)
        Me.txt_title.TabIndex = 1
        '
        'dt_pdate
        '
        Me.dt_pdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_pdate.Location = New System.Drawing.Point(147, 405)
        Me.dt_pdate.Name = "dt_pdate"
        Me.dt_pdate.Size = New System.Drawing.Size(259, 20)
        Me.dt_pdate.TabIndex = 23
        '
        'frm_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 721)
        Me.Controls.Add(Me.dt_pdate)
        Me.Controls.Add(Me.btn_back_to_main)
        Me.Controls.Add(Me.dg_book)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_show_all)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.gb_book)
        Me.Name = "frm_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Information"
        CType(Me.dg_book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_book.ResumeLayout(False)
        Me.gb_book.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_back_to_main As System.Windows.Forms.Button
    Friend WithEvents dg_book As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_show_all As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents gb_book As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_isbn As System.Windows.Forms.Label
    Friend WithEvents lbl_cat_id As System.Windows.Forms.Label
    Friend WithEvents lbl_pub_id As System.Windows.Forms.Label
    Friend WithEvents lbl_desc As System.Windows.Forms.Label
    Friend WithEvents txt_author As System.Windows.Forms.TextBox
    Friend WithEvents txt_desp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_author As System.Windows.Forms.Label
    Friend WithEvents lbl_b_id As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents txt_b_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pdate As System.Windows.Forms.Label
    Friend WithEvents dt_pdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_isbn As System.Windows.Forms.TextBox
    Friend WithEvents cbo_pub_id As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_cat_id As System.Windows.Forms.ComboBox
End Class
