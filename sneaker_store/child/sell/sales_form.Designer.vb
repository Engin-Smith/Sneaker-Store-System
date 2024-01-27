<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sales_form
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.productDataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.cb_qty = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_sprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_addbasket = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.basketDataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.btn_checkout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_print = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_concel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_displaytotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.productDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.basketDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
        Me.Guna2GradientPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.productDataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 506)
        Me.Panel1.TabIndex = 8
        '
        'productDataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.productDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.productDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.productDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.productDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.productDataGridView1.ColumnHeadersHeight = 21
        Me.productDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.productDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productDataGridView1.EnableHeadersVisualStyles = False
        Me.productDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.productDataGridView1.Name = "productDataGridView1"
        Me.productDataGridView1.RowHeadersVisible = False
        Me.productDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productDataGridView1.Size = New System.Drawing.Size(386, 506)
        Me.productDataGridView1.TabIndex = 0
        Me.productDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.productDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.productDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.productDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.productDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.productDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.productDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.productDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.productDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.productDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.productDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.productDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.productDataGridView1.ThemeStyle.ReadOnly = False
        Me.productDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.productDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.productDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.productDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.productDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.productDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Unit"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Selling prices"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Image"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_close)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_back)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1226, 59)
        Me.Guna2GradientPanel1.TabIndex = 7
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.CheckedState.Parent = Me.btn_close
        Me.btn_close.CustomImages.Parent = Me.btn_close
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.HoverState.Parent = Me.btn_close
        Me.btn_close.Image = Global.sneaker_store.My.Resources.Resources.close
        Me.btn_close.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_close.Location = New System.Drawing.Point(1153, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.ShadowDecoration.Parent = Me.btn_close
        Me.btn_close.Size = New System.Drawing.Size(73, 55)
        Me.btn_close.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txt_total)
        Me.Panel2.Controls.Add(Me.cb_qty)
        Me.Panel2.Controls.Add(Me.Guna2GradientPanel2)
        Me.Panel2.Controls.Add(Me.btn_addbasket)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(404, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 568)
        Me.Panel2.TabIndex = 9
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(290, 0)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(15, 20)
        Me.txt_id.TabIndex = 9
        Me.txt_id.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sneaker_store.My.Resources.Resources.brows_pic
        Me.PictureBox1.Location = New System.Drawing.Point(39, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ShadowDecoration.Parent = Me.PictureBox1
        Me.PictureBox1.Size = New System.Drawing.Size(337, 284)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(311, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(98, 20)
        Me.txt_total.TabIndex = 7
        Me.txt_total.Visible = False
        '
        'cb_qty
        '
        Me.cb_qty.BackColor = System.Drawing.Color.Transparent
        Me.cb_qty.BorderRadius = 5
        Me.cb_qty.DisplayMember = "1,2,3,4,5"
        Me.cb_qty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_qty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_qty.FocusedColor = System.Drawing.Color.Empty
        Me.cb_qty.FocusedState.Parent = Me.cb_qty
        Me.cb_qty.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_qty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_qty.FormattingEnabled = True
        Me.cb_qty.HoverState.Parent = Me.cb_qty
        Me.cb_qty.ItemHeight = 30
        Me.cb_qty.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_qty.ItemsAppearance.Parent = Me.cb_qty
        Me.cb_qty.Location = New System.Drawing.Point(39, 44)
        Me.cb_qty.Name = "cb_qty"
        Me.cb_qty.ShadowDecoration.Parent = Me.cb_qty
        Me.cb_qty.Size = New System.Drawing.Size(124, 36)
        Me.cb_qty.TabIndex = 5
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.txt_sprice)
        Me.Guna2GradientPanel2.Controls.Add(Me.txt_pname)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(39, 376)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(337, 189)
        Me.Guna2GradientPanel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Selling Prices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Name"
        '
        'txt_sprice
        '
        Me.txt_sprice.BorderRadius = 5
        Me.txt_sprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sprice.DefaultText = ""
        Me.txt_sprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sprice.DisabledState.Parent = Me.txt_sprice
        Me.txt_sprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sprice.Enabled = False
        Me.txt_sprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sprice.FocusedState.Parent = Me.txt_sprice
        Me.txt_sprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sprice.HoverState.Parent = Me.txt_sprice
        Me.txt_sprice.Location = New System.Drawing.Point(28, 112)
        Me.txt_sprice.Name = "txt_sprice"
        Me.txt_sprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sprice.PlaceholderText = ""
        Me.txt_sprice.SelectedText = ""
        Me.txt_sprice.ShadowDecoration.Parent = Me.txt_sprice
        Me.txt_sprice.Size = New System.Drawing.Size(259, 36)
        Me.txt_sprice.TabIndex = 1
        '
        'txt_pname
        '
        Me.txt_pname.BorderRadius = 5
        Me.txt_pname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pname.DefaultText = ""
        Me.txt_pname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pname.DisabledState.Parent = Me.txt_pname
        Me.txt_pname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pname.Enabled = False
        Me.txt_pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pname.FocusedState.Parent = Me.txt_pname
        Me.txt_pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pname.HoverState.Parent = Me.txt_pname
        Me.txt_pname.Location = New System.Drawing.Point(28, 37)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pname.PlaceholderText = ""
        Me.txt_pname.SelectedText = ""
        Me.txt_pname.ShadowDecoration.Parent = Me.txt_pname
        Me.txt_pname.Size = New System.Drawing.Size(259, 36)
        Me.txt_pname.TabIndex = 0
        '
        'btn_addbasket
        '
        Me.btn_addbasket.BorderRadius = 15
        Me.btn_addbasket.CheckedState.Parent = Me.btn_addbasket
        Me.btn_addbasket.CustomImages.Parent = Me.btn_addbasket
        Me.btn_addbasket.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_addbasket.ForeColor = System.Drawing.Color.White
        Me.btn_addbasket.HoverState.Parent = Me.btn_addbasket
        Me.btn_addbasket.Image = Global.sneaker_store.My.Resources.Resources.shop
        Me.btn_addbasket.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_addbasket.Location = New System.Drawing.Point(212, 35)
        Me.btn_addbasket.Name = "btn_addbasket"
        Me.btn_addbasket.ShadowDecoration.Parent = Me.btn_addbasket
        Me.btn_addbasket.Size = New System.Drawing.Size(180, 45)
        Me.btn_addbasket.TabIndex = 2
        Me.btn_addbasket.Text = "ADD TO BASKET"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantity"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.basketDataGridView1)
        Me.Panel3.Controls.Add(Me.Guna2GradientPanel3)
        Me.Panel3.Location = New System.Drawing.Point(822, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 370)
        Me.Panel3.TabIndex = 10
        '
        'basketDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.basketDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.basketDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.basketDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.basketDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.basketDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.basketDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.basketDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.basketDataGridView1.ColumnHeadersHeight = 40
        Me.basketDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.basketDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.basketDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.basketDataGridView1.EnableHeadersVisualStyles = False
        Me.basketDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basketDataGridView1.Location = New System.Drawing.Point(0, 64)
        Me.basketDataGridView1.Name = "basketDataGridView1"
        Me.basketDataGridView1.RowHeadersVisible = False
        Me.basketDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.basketDataGridView1.Size = New System.Drawing.Size(392, 306)
        Me.basketDataGridView1.TabIndex = 1
        Me.basketDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.basketDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.basketDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.basketDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.basketDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.basketDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.basketDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.basketDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.basketDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.basketDataGridView1.ThemeStyle.ReadOnly = False
        Me.basketDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.basketDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.basketDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.basketDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.basketDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.basketDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basketDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column5
        '
        Me.Column5.HeaderText = "Product Name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Quantity"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Price"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Sub-Total"
        Me.Column8.Name = "Column8"
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel3.Controls.Add(Me.txt_date)
        Me.Guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.Red
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.ShadowDecoration.Parent = Me.Guna2GradientPanel3
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(392, 64)
        Me.Guna2GradientPanel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(174, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer's  Basket"
        '
        'txt_date
        '
        Me.txt_date.CheckedState.Parent = Me.txt_date
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.HoverState.Parent = Me.txt_date
        Me.txt_date.Location = New System.Drawing.Point(8, 18)
        Me.txt_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txt_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ShadowDecoration.Parent = Me.txt_date
        Me.txt_date.Size = New System.Drawing.Size(160, 36)
        Me.txt_date.TabIndex = 0
        Me.txt_date.Value = New Date(2024, 1, 27, 0, 0, 0, 0)
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel4.Controls.Add(Me.txt_no)
        Me.Guna2GradientPanel4.Controls.Add(Me.btn_checkout)
        Me.Guna2GradientPanel4.Controls.Add(Me.btn_print)
        Me.Guna2GradientPanel4.Controls.Add(Me.btn_concel)
        Me.Guna2GradientPanel4.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel4.Controls.Add(Me.txt_displaytotal)
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(822, 441)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.ShadowDecoration.Parent = Me.Guna2GradientPanel4
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(392, 189)
        Me.Guna2GradientPanel4.TabIndex = 7
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(92, 3)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(76, 20)
        Me.txt_no.TabIndex = 10
        Me.txt_no.Visible = False
        '
        'btn_checkout
        '
        Me.btn_checkout.BorderRadius = 10
        Me.btn_checkout.CheckedState.Parent = Me.btn_checkout
        Me.btn_checkout.CustomImages.Parent = Me.btn_checkout
        Me.btn_checkout.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.ForeColor = System.Drawing.Color.White
        Me.btn_checkout.HoverState.Parent = Me.btn_checkout
        Me.btn_checkout.Image = Global.sneaker_store.My.Resources.Resources.shopping_cart
        Me.btn_checkout.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_checkout.Location = New System.Drawing.Point(28, 112)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.ShadowDecoration.Parent = Me.btn_checkout
        Me.btn_checkout.Size = New System.Drawing.Size(335, 56)
        Me.btn_checkout.TabIndex = 8
        Me.btn_checkout.Text = "CHECK OUT"
        '
        'btn_print
        '
        Me.btn_print.BorderRadius = 10
        Me.btn_print.CheckedState.Parent = Me.btn_print
        Me.btn_print.CustomImages.Parent = Me.btn_print
        Me.btn_print.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.HoverState.Parent = Me.btn_print
        Me.btn_print.Image = Global.sneaker_store.My.Resources.Resources.printer
        Me.btn_print.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_print.Location = New System.Drawing.Point(142, 28)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.ShadowDecoration.Parent = Me.btn_print
        Me.btn_print.Size = New System.Drawing.Size(108, 45)
        Me.btn_print.TabIndex = 7
        Me.btn_print.Text = "PRINT"
        '
        'btn_concel
        '
        Me.btn_concel.BorderRadius = 10
        Me.btn_concel.CheckedState.Parent = Me.btn_concel
        Me.btn_concel.CustomImages.Parent = Me.btn_concel
        Me.btn_concel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_concel.ForeColor = System.Drawing.Color.White
        Me.btn_concel.HoverState.Parent = Me.btn_concel
        Me.btn_concel.Image = Global.sneaker_store.My.Resources.Resources.exclamation
        Me.btn_concel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_concel.Location = New System.Drawing.Point(28, 28)
        Me.btn_concel.Name = "btn_concel"
        Me.btn_concel.ShadowDecoration.Parent = Me.btn_concel
        Me.btn_concel.Size = New System.Drawing.Size(108, 45)
        Me.btn_concel.TabIndex = 6
        Me.btn_concel.Text = "CANCEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(276, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " Total Amount"
        '
        'txt_displaytotal
        '
        Me.txt_displaytotal.BorderRadius = 5
        Me.txt_displaytotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_displaytotal.DefaultText = ""
        Me.txt_displaytotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_displaytotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_displaytotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_displaytotal.DisabledState.Parent = Me.txt_displaytotal
        Me.txt_displaytotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_displaytotal.Enabled = False
        Me.txt_displaytotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_displaytotal.FocusedState.Parent = Me.txt_displaytotal
        Me.txt_displaytotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_displaytotal.HoverState.Parent = Me.txt_displaytotal
        Me.txt_displaytotal.Location = New System.Drawing.Point(279, 37)
        Me.txt_displaytotal.Name = "txt_displaytotal"
        Me.txt_displaytotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_displaytotal.PlaceholderText = ""
        Me.txt_displaytotal.SelectedText = ""
        Me.txt_displaytotal.ShadowDecoration.Parent = Me.txt_displaytotal
        Me.txt_displaytotal.Size = New System.Drawing.Size(110, 36)
        Me.txt_displaytotal.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.BorderRadius = 10
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.txt_search.Location = New System.Drawing.Point(31, 76)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = ""
        Me.txt_search.SelectedText = ""
        Me.txt_search.SelectionStart = 2
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(298, 36)
        Me.txt_search.TabIndex = 11
        '
        'sales_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 645)
        Me.Controls.Add(Me.Guna2GradientPanel4)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sales_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sales_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.productDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.basketDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2GradientPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents productDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_sprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_addbasket As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cb_qty As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_checkout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_print As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_concel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_displaytotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents basketDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents txt_total As TextBox
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_id As TextBox
    Public WithEvents txt_no As TextBox
End Class
