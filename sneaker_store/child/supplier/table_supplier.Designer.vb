<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table_supplier
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.supplierdatagridview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_adds = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.supplierdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'supplierdatagridview
        '
        Me.supplierdatagridview.AllowUserToAddRows = False
        Me.supplierdatagridview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.supplierdatagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.supplierdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.supplierdatagridview.BackgroundColor = System.Drawing.Color.White
        Me.supplierdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.supplierdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.supplierdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supplierdatagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.supplierdatagridview.ColumnHeadersHeight = 41
        Me.supplierdatagridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.supplierdatagridview.DefaultCellStyle = DataGridViewCellStyle3
        Me.supplierdatagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.supplierdatagridview.EnableHeadersVisualStyles = False
        Me.supplierdatagridview.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supplierdatagridview.Location = New System.Drawing.Point(0, 64)
        Me.supplierdatagridview.Name = "supplierdatagridview"
        Me.supplierdatagridview.ReadOnly = True
        Me.supplierdatagridview.RowHeadersVisible = False
        Me.supplierdatagridview.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.supplierdatagridview.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.supplierdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.supplierdatagridview.Size = New System.Drawing.Size(800, 386)
        Me.supplierdatagridview.TabIndex = 5
        Me.supplierdatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.supplierdatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.supplierdatagridview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.supplierdatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.supplierdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.supplierdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.supplierdatagridview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.supplierdatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.supplierdatagridview.ThemeStyle.HeaderStyle.Height = 41
        Me.supplierdatagridview.ThemeStyle.ReadOnly = True
        Me.supplierdatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.supplierdatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.supplierdatagridview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.supplierdatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.supplierdatagridview.ThemeStyle.RowsStyle.Height = 22
        Me.supplierdatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.supplierdatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column0
        '
        Me.Column0.HeaderText = "#"
        Me.Column0.Name = "Column0"
        Me.Column0.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Supplier ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Supplier Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Phone Number"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Address"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txt_search)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_refresh)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_adds)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(800, 64)
        Me.Guna2CustomGradientPanel1.TabIndex = 4
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh.BorderRadius = 10
        Me.btn_refresh.CheckedState.Parent = Me.btn_refresh
        Me.btn_refresh.CustomImages.Parent = Me.btn_refresh
        Me.btn_refresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.HoverState.Parent = Me.btn_refresh
        Me.btn_refresh.Location = New System.Drawing.Point(245, 12)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(157, 42)
        Me.btn_refresh.TabIndex = 5
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_adds
        '
        Me.btn_adds.BackColor = System.Drawing.Color.Transparent
        Me.btn_adds.BorderRadius = 10
        Me.btn_adds.CheckedState.Parent = Me.btn_adds
        Me.btn_adds.CustomImages.Parent = Me.btn_adds
        Me.btn_adds.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adds.ForeColor = System.Drawing.Color.White
        Me.btn_adds.HoverState.Parent = Me.btn_adds
        Me.btn_adds.Location = New System.Drawing.Point(71, 12)
        Me.btn_adds.Name = "btn_adds"
        Me.btn_adds.ShadowDecoration.Parent = Me.btn_adds
        Me.btn_adds.Size = New System.Drawing.Size(157, 42)
        Me.btn_adds.TabIndex = 3
        Me.btn_adds.Text = "Add Supplier"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.BackColor = System.Drawing.Color.Transparent
        Me.txt_search.BorderColor = System.Drawing.Color.White
        Me.txt_search.BorderRadius = 20
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.Parent = Me.txt_search
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.FocusedState.Parent = Me.txt_search
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.IconRight = Global.sneaker_store.My.Resources.Resources.search
        Me.txt_search.IconRightSize = New System.Drawing.Size(40, 35)
        Me.txt_search.Location = New System.Drawing.Point(491, 12)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = ""
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(250, 42)
        Me.txt_search.TabIndex = 6
        '
        'table_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.supplierdatagridview)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "table_supplier"
        Me.Text = "table_supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.supplierdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents supplierdatagridview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_adds As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
