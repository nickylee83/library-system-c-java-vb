<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.lbl_library = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnu_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_member = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_book = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_category = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_publisher = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_rental = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_library_name = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_library
        '
        Me.lbl_library.AutoSize = True
        Me.lbl_library.BackColor = System.Drawing.Color.Transparent
        Me.lbl_library.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_library.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_library.Location = New System.Drawing.Point(335, 357)
        Me.lbl_library.Name = "lbl_library"
        Me.lbl_library.Size = New System.Drawing.Size(710, 79)
        Me.lbl_library.TabIndex = 0
        Me.lbl_library.Text = "Library Management System"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_file})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1226, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_file
        '
        Me.mnu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_member, Me.mnu_book, Me.mnu_category, Me.mnu_publisher, Me.mnu_rental, Me.mnu_exit})
        Me.mnu_file.Name = "mnu_file"
        Me.mnu_file.Size = New System.Drawing.Size(37, 20)
        Me.mnu_file.Text = "&File"
        '
        'mnu_member
        '
        Me.mnu_member.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_member.Name = "mnu_member"
        Me.mnu_member.Size = New System.Drawing.Size(189, 22)
        Me.mnu_member.Text = "&Member Information"
        '
        'mnu_book
        '
        Me.mnu_book.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_book.Name = "mnu_book"
        Me.mnu_book.Size = New System.Drawing.Size(189, 22)
        Me.mnu_book.Text = "&Book Information"
        '
        'mnu_category
        '
        Me.mnu_category.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_category.Name = "mnu_category"
        Me.mnu_category.Size = New System.Drawing.Size(189, 22)
        Me.mnu_category.Text = "&Category Information"
        '
        'mnu_publisher
        '
        Me.mnu_publisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_publisher.Name = "mnu_publisher"
        Me.mnu_publisher.Size = New System.Drawing.Size(189, 22)
        Me.mnu_publisher.Text = "&Publisher Information"
        '
        'mnu_rental
        '
        Me.mnu_rental.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_rental.Name = "mnu_rental"
        Me.mnu_rental.Size = New System.Drawing.Size(189, 22)
        Me.mnu_rental.Text = "&Rental Information"
        '
        'mnu_exit
        '
        Me.mnu_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnu_exit.Name = "mnu_exit"
        Me.mnu_exit.Size = New System.Drawing.Size(189, 22)
        Me.mnu_exit.Text = "E&xit"
        '
        'lbl_library_name
        '
        Me.lbl_library_name.AutoSize = True
        Me.lbl_library_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_library_name.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_library_name.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_library_name.Location = New System.Drawing.Point(467, 278)
        Me.lbl_library_name.Name = "lbl_library_name"
        Me.lbl_library_name.Size = New System.Drawing.Size(466, 79)
        Me.lbl_library_name.TabIndex = 2
        Me.lbl_library_name.Text = "Knowledge Planet"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1226, 623)
        Me.Controls.Add(Me.lbl_library_name)
        Me.Controls.Add(Me.lbl_library)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_library As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_member As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_book As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_rental As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_category As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_publisher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_library_name As System.Windows.Forms.Label

End Class
