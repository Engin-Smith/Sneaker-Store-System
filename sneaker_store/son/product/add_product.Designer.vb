﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_product
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_closeP = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_brand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_cat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_brow = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_sp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_bp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_unit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Db_sneakerDataSet = New sneaker_store.db_sneakerDataSet()
        Me.DbsneakerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_categoryTableAdapter = New sneaker_store.db_sneakerDataSetTableAdapters.tbl_categoryTableAdapter()
        Me.TblbrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_brandTableAdapter = New sneaker_store.db_sneakerDataSetTableAdapters.tbl_brandTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sneakerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsneakerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 16
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_closeP)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-4, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 146)
        Me.Panel2.TabIndex = 1
        '
        'btn_closeP
        '
        Me.btn_closeP.CheckedState.Parent = Me.btn_closeP
        Me.btn_closeP.CustomImages.Parent = Me.btn_closeP
        Me.btn_closeP.FillColor = System.Drawing.Color.Transparent
        Me.btn_closeP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_closeP.ForeColor = System.Drawing.Color.White
        Me.btn_closeP.HoverState.Parent = Me.btn_closeP
        Me.btn_closeP.Image = Global.sneaker_store.My.Resources.Resources.close
        Me.btn_closeP.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_closeP.Location = New System.Drawing.Point(596, 4)
        Me.btn_closeP.Name = "btn_closeP"
        Me.btn_closeP.ShadowDecoration.Parent = Me.btn_closeP
        Me.btn_closeP.Size = New System.Drawing.Size(60, 45)
        Me.btn_closeP.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Products"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb_brand)
        Me.Panel1.Controls.Add(Me.cb_cat)
        Me.Panel1.Controls.Add(Me.txt_id)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_brow)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txt_sp)
        Me.Panel1.Controls.Add(Me.txt_bp)
        Me.Panel1.Controls.Add(Me.txt_unit)
        Me.Panel1.Controls.Add(Me.txt_pname)
        Me.Panel1.Location = New System.Drawing.Point(31, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 420)
        Me.Panel1.TabIndex = 2
        '
        'cb_brand
        '
        Me.cb_brand.BackColor = System.Drawing.Color.Transparent
        Me.cb_brand.BorderRadius = 5
        Me.cb_brand.DataSource = Me.TblbrandBindingSource
        Me.cb_brand.DisplayMember = "b_name"
        Me.cb_brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_brand.FocusedColor = System.Drawing.Color.Empty
        Me.cb_brand.FocusedState.Parent = Me.cb_brand
        Me.cb_brand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_brand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_brand.FormattingEnabled = True
        Me.cb_brand.HoverState.Parent = Me.cb_brand
        Me.cb_brand.ItemHeight = 30
        Me.cb_brand.ItemsAppearance.Parent = Me.cb_brand
        Me.cb_brand.Location = New System.Drawing.Point(20, 197)
        Me.cb_brand.Name = "cb_brand"
        Me.cb_brand.ShadowDecoration.Parent = Me.cb_brand
        Me.cb_brand.Size = New System.Drawing.Size(200, 36)
        Me.cb_brand.TabIndex = 21
        Me.cb_brand.ValueMember = "b_id"
        '
        'cb_cat
        '
        Me.cb_cat.BackColor = System.Drawing.Color.Transparent
        Me.cb_cat.BorderRadius = 5
        Me.cb_cat.DataSource = Me.TblcategoryBindingSource
        Me.cb_cat.DisplayMember = "cat_name"
        Me.cb_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cat.FocusedColor = System.Drawing.Color.Empty
        Me.cb_cat.FocusedState.Parent = Me.cb_cat
        Me.cb_cat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_cat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_cat.FormattingEnabled = True
        Me.cb_cat.HoverState.Parent = Me.cb_cat
        Me.cb_cat.ItemHeight = 30
        Me.cb_cat.ItemsAppearance.Parent = Me.cb_cat
        Me.cb_cat.Location = New System.Drawing.Point(20, 137)
        Me.cb_cat.Name = "cb_cat"
        Me.cb_cat.ShadowDecoration.Parent = Me.cb_cat
        Me.cb_cat.Size = New System.Drawing.Size(200, 36)
        Me.cb_cat.TabIndex = 20
        Me.cb_cat.ValueMember = "cat_id"
        '
        'txt_id
        '
        Me.txt_id.BorderRadius = 5
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
        Me.txt_id.Location = New System.Drawing.Point(20, 23)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id.PlaceholderText = ""
        Me.txt_id.SelectedText = ""
        Me.txt_id.ShadowDecoration.Parent = Me.txt_id
        Me.txt_id.Size = New System.Drawing.Size(200, 34)
        Me.txt_id.TabIndex = 19
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(20, 3)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(15, 17)
        Me.Guna2HtmlLabel7.TabIndex = 18
        Me.Guna2HtmlLabel7.Text = "ID"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(20, 348)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(72, 17)
        Me.Guna2HtmlLabel6.TabIndex = 17
        Me.Guna2HtmlLabel6.Text = "Selling Price"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(20, 290)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(71, 17)
        Me.Guna2HtmlLabel5.TabIndex = 16
        Me.Guna2HtmlLabel5.Text = "Buying Price"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(20, 232)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(25, 17)
        Me.Guna2HtmlLabel4.TabIndex = 15
        Me.Guna2HtmlLabel4.Text = "Unit"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(20, 174)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(36, 17)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "Brand"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(20, 114)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(51, 17)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "Category"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(20, 56)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(82, 17)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Product Name"
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 10
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Location = New System.Drawing.Point(357, 327)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(98, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save"
        '
        'btn_brow
        '
        Me.btn_brow.BorderRadius = 10
        Me.btn_brow.CheckedState.Parent = Me.btn_brow
        Me.btn_brow.CustomImages.Parent = Me.btn_brow
        Me.btn_brow.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_brow.ForeColor = System.Drawing.Color.White
        Me.btn_brow.HoverState.Parent = Me.btn_brow
        Me.btn_brow.Location = New System.Drawing.Point(321, 269)
        Me.btn_brow.Name = "btn_brow"
        Me.btn_brow.ShadowDecoration.Parent = Me.btn_brow
        Me.btn_brow.Size = New System.Drawing.Size(180, 33)
        Me.btn_brow.TabIndex = 9
        Me.btn_brow.Text = "Browses"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sneaker_store.My.Resources.Resources.brows_pic
        Me.PictureBox1.Location = New System.Drawing.Point(291, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ShadowDecoration.Parent = Me.PictureBox1
        Me.PictureBox1.Size = New System.Drawing.Size(251, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txt_sp
        '
        Me.txt_sp.BorderRadius = 5
        Me.txt_sp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sp.DefaultText = ""
        Me.txt_sp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sp.DisabledState.Parent = Me.txt_sp
        Me.txt_sp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sp.FocusedState.Parent = Me.txt_sp
        Me.txt_sp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sp.HoverState.Parent = Me.txt_sp
        Me.txt_sp.Location = New System.Drawing.Point(20, 369)
        Me.txt_sp.Name = "txt_sp"
        Me.txt_sp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sp.PlaceholderText = ""
        Me.txt_sp.SelectedText = ""
        Me.txt_sp.ShadowDecoration.Parent = Me.txt_sp
        Me.txt_sp.Size = New System.Drawing.Size(200, 37)
        Me.txt_sp.TabIndex = 6
        '
        'txt_bp
        '
        Me.txt_bp.BorderRadius = 5
        Me.txt_bp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bp.DefaultText = ""
        Me.txt_bp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_bp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_bp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bp.DisabledState.Parent = Me.txt_bp
        Me.txt_bp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bp.FocusedState.Parent = Me.txt_bp
        Me.txt_bp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bp.HoverState.Parent = Me.txt_bp
        Me.txt_bp.Location = New System.Drawing.Point(20, 311)
        Me.txt_bp.Name = "txt_bp"
        Me.txt_bp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bp.PlaceholderText = ""
        Me.txt_bp.SelectedText = ""
        Me.txt_bp.ShadowDecoration.Parent = Me.txt_bp
        Me.txt_bp.Size = New System.Drawing.Size(200, 37)
        Me.txt_bp.TabIndex = 5
        '
        'txt_unit
        '
        Me.txt_unit.BorderRadius = 5
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
        Me.txt_unit.Location = New System.Drawing.Point(20, 253)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_unit.PlaceholderText = ""
        Me.txt_unit.SelectedText = ""
        Me.txt_unit.ShadowDecoration.Parent = Me.txt_unit
        Me.txt_unit.Size = New System.Drawing.Size(200, 37)
        Me.txt_unit.TabIndex = 4
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
        Me.txt_pname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pname.FocusedState.Parent = Me.txt_pname
        Me.txt_pname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pname.HoverState.Parent = Me.txt_pname
        Me.txt_pname.Location = New System.Drawing.Point(20, 77)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pname.PlaceholderText = ""
        Me.txt_pname.SelectedText = ""
        Me.txt_pname.ShadowDecoration.Parent = Me.txt_pname
        Me.txt_pname.Size = New System.Drawing.Size(200, 37)
        Me.txt_pname.TabIndex = 1
        '
        'Db_sneakerDataSet
        '
        Me.Db_sneakerDataSet.DataSetName = "db_sneakerDataSet"
        Me.Db_sneakerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbsneakerDataSetBindingSource
        '
        Me.DbsneakerDataSetBindingSource.DataSource = Me.Db_sneakerDataSet
        Me.DbsneakerDataSetBindingSource.Position = 0
        '
        'TblcategoryBindingSource
        '
        Me.TblcategoryBindingSource.DataMember = "tbl_category"
        Me.TblcategoryBindingSource.DataSource = Me.DbsneakerDataSetBindingSource
        '
        'Tbl_categoryTableAdapter
        '
        Me.Tbl_categoryTableAdapter.ClearBeforeFill = True
        '
        'TblbrandBindingSource
        '
        Me.TblbrandBindingSource.DataMember = "tbl_brand"
        Me.TblbrandBindingSource.DataSource = Me.DbsneakerDataSetBindingSource
        '
        'Tbl_brandTableAdapter
        '
        Me.Tbl_brandTableAdapter.ClearBeforeFill = True
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(655, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_product"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sneakerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsneakerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_unit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_sp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_bp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_brow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_closeP As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_cat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_brand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DbsneakerDataSetBindingSource As BindingSource
    Friend WithEvents Db_sneakerDataSet As db_sneakerDataSet
    Friend WithEvents TblcategoryBindingSource As BindingSource
    Friend WithEvents Tbl_categoryTableAdapter As db_sneakerDataSetTableAdapters.tbl_categoryTableAdapter
    Friend WithEvents TblbrandBindingSource As BindingSource
    Friend WithEvents Tbl_brandTableAdapter As db_sneakerDataSetTableAdapters.tbl_brandTableAdapter
End Class
