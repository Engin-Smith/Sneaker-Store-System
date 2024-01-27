<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class search_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.searchDataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_cat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_brand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_buy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_unit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_sell = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.searchDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.TransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Controls.Add(Me.Guna2Panel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(984, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 694)
        Me.Panel1.TabIndex = 8
        '
        'txt_search
        '
        Me.txt_search.BorderRadius = 10
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
        Me.txt_search.IconLeft = Global.sneaker_store.My.Resources.Resources.search
        Me.txt_search.Location = New System.Drawing.Point(44, 29)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = ""
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(305, 36)
        Me.txt_search.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.Controls.Add(Me.searchDataGridView1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 71)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(382, 623)
        Me.Guna2Panel1.TabIndex = 0
        '
        'searchDataGridView1
        '
        Me.searchDataGridView1.AllowUserToAddRows = False
        Me.searchDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.searchDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.searchDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.searchDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.searchDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.searchDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.searchDataGridView1.ColumnHeadersHeight = 41
        Me.searchDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.searchDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchDataGridView1.EnableHeadersVisualStyles = False
        Me.searchDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.searchDataGridView1.Name = "searchDataGridView1"
        Me.searchDataGridView1.ReadOnly = True
        Me.searchDataGridView1.RowHeadersVisible = False
        Me.searchDataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.searchDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.searchDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.searchDataGridView1.Size = New System.Drawing.Size(382, 623)
        Me.searchDataGridView1.TabIndex = 4
        Me.searchDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.searchDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.searchDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.searchDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.searchDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.searchDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.searchDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.searchDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.searchDataGridView1.ThemeStyle.HeaderStyle.Height = 41
        Me.searchDataGridView1.ThemeStyle.ReadOnly = True
        Me.searchDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.searchDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.searchDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.searchDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.searchDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.searchDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column0
        '
        Me.Column0.HeaderText = "#"
        Me.Column0.Name = "Column0"
        Me.Column0.ReadOnly = True
        Me.Column0.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Brand"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Unit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Buying Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Selling Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Image"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_back)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1372, 59)
        Me.Guna2GradientPanel1.TabIndex = 7
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Transparent
        Me.btn_back.CheckedState.Parent = Me.btn_back
        Me.btn_back.CustomImages.Parent = Me.btn_back
        Me.btn_back.FillColor = System.Drawing.Color.Transparent
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.HoverState.Parent = Me.btn_back
        Me.btn_back.Image = Global.sneaker_store.My.Resources.Resources.icon_back
        Me.btn_back.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_back.Location = New System.Drawing.Point(0, 1)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.ShadowDecoration.Parent = Me.btn_back
        Me.btn_back.Size = New System.Drawing.Size(73, 55)
        Me.btn_back.TabIndex = 0
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.DefaultText = ""
        Me.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id.DisabledState.Parent = Me.txt_id
        Me.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id.FocusedState.Parent = Me.txt_id
        Me.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_id.HoverState.Parent = Me.txt_id
        Me.txt_id.Location = New System.Drawing.Point(32, 88)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id.PlaceholderText = "Product Code"
        Me.txt_id.SelectedText = ""
        Me.txt_id.ShadowDecoration.Parent = Me.txt_id
        Me.txt_id.Size = New System.Drawing.Size(136, 36)
        Me.txt_id.TabIndex = 10
        '
        'txt_cat
        '
        Me.txt_cat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cat.DefaultText = ""
        Me.txt_cat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cat.DisabledState.Parent = Me.txt_cat
        Me.txt_cat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cat.FocusedState.Parent = Me.txt_cat
        Me.txt_cat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cat.HoverState.Parent = Me.txt_cat
        Me.txt_cat.Location = New System.Drawing.Point(174, 88)
        Me.txt_cat.Name = "txt_cat"
        Me.txt_cat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cat.PlaceholderText = "Category"
        Me.txt_cat.SelectedText = ""
        Me.txt_cat.ShadowDecoration.Parent = Me.txt_cat
        Me.txt_cat.Size = New System.Drawing.Size(136, 36)
        Me.txt_cat.TabIndex = 11
        '
        'txt_brand
        '
        Me.txt_brand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_brand.DefaultText = ""
        Me.txt_brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_brand.DisabledState.Parent = Me.txt_brand
        Me.txt_brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_brand.FocusedState.Parent = Me.txt_brand
        Me.txt_brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_brand.HoverState.Parent = Me.txt_brand
        Me.txt_brand.Location = New System.Drawing.Point(316, 88)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_brand.PlaceholderText = "Brand"
        Me.txt_brand.SelectedText = ""
        Me.txt_brand.ShadowDecoration.Parent = Me.txt_brand
        Me.txt_brand.Size = New System.Drawing.Size(136, 36)
        Me.txt_brand.TabIndex = 12
        '
        'txt_buy
        '
        Me.txt_buy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_buy.DefaultText = ""
        Me.txt_buy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_buy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_buy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buy.DisabledState.Parent = Me.txt_buy
        Me.txt_buy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_buy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buy.FocusedState.Parent = Me.txt_buy
        Me.txt_buy.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_buy.HoverState.Parent = Me.txt_buy
        Me.txt_buy.Location = New System.Drawing.Point(600, 88)
        Me.txt_buy.Name = "txt_buy"
        Me.txt_buy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_buy.PlaceholderText = "Selling Prices"
        Me.txt_buy.SelectedText = ""
        Me.txt_buy.ShadowDecoration.Parent = Me.txt_buy
        Me.txt_buy.Size = New System.Drawing.Size(136, 36)
        Me.txt_buy.TabIndex = 13
        '
        'txt_unit
        '
        Me.txt_unit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_unit.DefaultText = ""
        Me.txt_unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_unit.DisabledState.Parent = Me.txt_unit
        Me.txt_unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_unit.FocusedState.Parent = Me.txt_unit
        Me.txt_unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_unit.HoverState.Parent = Me.txt_unit
        Me.txt_unit.Location = New System.Drawing.Point(458, 88)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_unit.PlaceholderText = "Unit"
        Me.txt_unit.SelectedText = ""
        Me.txt_unit.ShadowDecoration.Parent = Me.txt_unit
        Me.txt_unit.Size = New System.Drawing.Size(136, 36)
        Me.txt_unit.TabIndex = 13
        '
        'txt_sell
        '
        Me.txt_sell.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sell.DefaultText = ""
        Me.txt_sell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sell.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sell.DisabledState.Parent = Me.txt_sell
        Me.txt_sell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sell.FocusedState.Parent = Me.txt_sell
        Me.txt_sell.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sell.HoverState.Parent = Me.txt_sell
        Me.txt_sell.Location = New System.Drawing.Point(742, 88)
        Me.txt_sell.Name = "txt_sell"
        Me.txt_sell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sell.PlaceholderText = "shevle/clothline"
        Me.txt_sell.SelectedText = ""
        Me.txt_sell.ShadowDecoration.Parent = Me.txt_sell
        Me.txt_sell.Size = New System.Drawing.Size(136, 36)
        Me.txt_sell.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.Parent = Me.txt_name
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.FocusedState.Parent = Me.txt_name
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.HoverState.Parent = Me.txt_name
        Me.txt_name.Location = New System.Drawing.Point(12, 130)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = "Product Code"
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.Parent = Me.txt_name
        Me.txt_name.Size = New System.Drawing.Size(136, 36)
        Me.txt_name.TabIndex = 15
        Me.txt_name.Visible = False
        '
        'TransfarantPictureBox1
        '
        Me.TransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.TransfarantPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.TransfarantPictureBox1.Image = Global.sneaker_store.My.Resources.Resources.brows_pic
        Me.TransfarantPictureBox1.Location = New System.Drawing.Point(817, 160)
        Me.TransfarantPictureBox1.Name = "TransfarantPictureBox1"
        Me.TransfarantPictureBox1.Size = New System.Drawing.Size(164, 176)
        Me.TransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransfarantPictureBox1.TabIndex = 16
        Me.TransfarantPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderRadius = 5
        Me.PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sneaker_store.My.Resources.Resources.brows_pic
        Me.PictureBox1.Location = New System.Drawing.Point(69, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ShadowDecoration.Parent = Me.PictureBox1
        Me.PictureBox1.Size = New System.Drawing.Size(698, 585)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseTransparentBackground = True
        '
        'search_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 753)
        Me.Controls.Add(Me.TransfarantPictureBox1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_sell)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.txt_buy)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_cat)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "search_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "search_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.searchDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.TransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_sell As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_unit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_buy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_brand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_cat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents TransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
