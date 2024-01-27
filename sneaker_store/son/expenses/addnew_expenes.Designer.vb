<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addnew_expenes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_desc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cb_extype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TblextypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsneakerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_sneakerDataSet = New sneaker_store.db_sneakerDataSet()
        Me.txt_dp = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_exA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_exid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_exname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.Tbl_extypeTableAdapter = New sneaker_store.db_sneakerDataSetTableAdapters.tbl_extypeTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TblextypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsneakerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_sneakerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_desc)
        Me.Panel1.Controls.Add(Me.cb_extype)
        Me.Panel1.Controls.Add(Me.txt_dp)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.txt_exA)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.txt_exid)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.txt_exname)
        Me.Panel1.Location = New System.Drawing.Point(35, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 338)
        Me.Panel1.TabIndex = 10
        '
        'txt_desc
        '
        Me.txt_desc.BorderRadius = 5
        Me.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_desc.DefaultText = ""
        Me.txt_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desc.DisabledState.Parent = Me.txt_desc
        Me.txt_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desc.FocusedState.Parent = Me.txt_desc
        Me.txt_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_desc.HoverState.Parent = Me.txt_desc
        Me.txt_desc.Location = New System.Drawing.Point(305, 148)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_desc.PlaceholderText = ""
        Me.txt_desc.SelectedText = ""
        Me.txt_desc.ShadowDecoration.Parent = Me.txt_desc
        Me.txt_desc.Size = New System.Drawing.Size(179, 91)
        Me.txt_desc.TabIndex = 28
        '
        'cb_extype
        '
        Me.cb_extype.BackColor = System.Drawing.Color.Transparent
        Me.cb_extype.BorderRadius = 5
        Me.cb_extype.DataSource = Me.TblextypeBindingSource
        Me.cb_extype.DisplayMember = "ex_name"
        Me.cb_extype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_extype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_extype.FocusedColor = System.Drawing.Color.Empty
        Me.cb_extype.FocusedState.Parent = Me.cb_extype
        Me.cb_extype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_extype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_extype.FormattingEnabled = True
        Me.cb_extype.HoverState.Parent = Me.cb_extype
        Me.cb_extype.ItemHeight = 30
        Me.cb_extype.ItemsAppearance.Parent = Me.cb_extype
        Me.cb_extype.Location = New System.Drawing.Point(63, 148)
        Me.cb_extype.Name = "cb_extype"
        Me.cb_extype.ShadowDecoration.Parent = Me.cb_extype
        Me.cb_extype.Size = New System.Drawing.Size(200, 36)
        Me.cb_extype.TabIndex = 27
        Me.cb_extype.ValueMember = "ex_id"
        '
        'TblextypeBindingSource
        '
        Me.TblextypeBindingSource.DataMember = "tbl_extype"
        Me.TblextypeBindingSource.DataSource = Me.DbsneakerDataSetBindingSource
        '
        'DbsneakerDataSetBindingSource
        '
        Me.DbsneakerDataSetBindingSource.DataSource = Me.Db_sneakerDataSet
        Me.DbsneakerDataSetBindingSource.Position = 0
        '
        'Db_sneakerDataSet
        '
        Me.Db_sneakerDataSet.DataSetName = "db_sneakerDataSet"
        Me.Db_sneakerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_dp
        '
        Me.txt_dp.BorderRadius = 5
        Me.txt_dp.CheckedState.Parent = Me.txt_dp
        Me.txt_dp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_dp.HoverState.Parent = Me.txt_dp
        Me.txt_dp.Location = New System.Drawing.Point(63, 23)
        Me.txt_dp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txt_dp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txt_dp.Name = "txt_dp"
        Me.txt_dp.ShadowDecoration.Parent = Me.txt_dp
        Me.txt_dp.Size = New System.Drawing.Size(200, 36)
        Me.txt_dp.TabIndex = 26
        Me.txt_dp.Value = New Date(2024, 1, 27, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(305, 125)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(65, 17)
        Me.Guna2HtmlLabel4.TabIndex = 25
        Me.Guna2HtmlLabel4.Text = "Description"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(63, 185)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(45, 17)
        Me.Guna2HtmlLabel3.TabIndex = 23
        Me.Guna2HtmlLabel3.Text = "Amount"
        '
        'txt_exA
        '
        Me.txt_exA.BorderRadius = 5
        Me.txt_exA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_exA.DefaultText = ""
        Me.txt_exA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_exA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_exA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exA.DisabledState.Parent = Me.txt_exA
        Me.txt_exA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exA.FocusedState.Parent = Me.txt_exA
        Me.txt_exA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exA.HoverState.Parent = Me.txt_exA
        Me.txt_exA.Location = New System.Drawing.Point(63, 208)
        Me.txt_exA.Name = "txt_exA"
        Me.txt_exA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_exA.PlaceholderText = ""
        Me.txt_exA.SelectedText = ""
        Me.txt_exA.ShadowDecoration.Parent = Me.txt_exA
        Me.txt_exA.Size = New System.Drawing.Size(200, 31)
        Me.txt_exA.TabIndex = 22
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(63, 125)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(80, 17)
        Me.Guna2HtmlLabel2.TabIndex = 21
        Me.Guna2HtmlLabel2.Text = "Expense Type"
        '
        'txt_exid
        '
        Me.txt_exid.BackColor = System.Drawing.Color.Transparent
        Me.txt_exid.BorderRadius = 5
        Me.txt_exid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_exid.DefaultText = ""
        Me.txt_exid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_exid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_exid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exid.DisabledState.Parent = Me.txt_exid
        Me.txt_exid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exid.FocusedState.Parent = Me.txt_exid
        Me.txt_exid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exid.HoverState.Parent = Me.txt_exid
        Me.txt_exid.Location = New System.Drawing.Point(305, 91)
        Me.txt_exid.Name = "txt_exid"
        Me.txt_exid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_exid.PlaceholderText = ""
        Me.txt_exid.ReadOnly = True
        Me.txt_exid.SelectedText = ""
        Me.txt_exid.ShadowDecoration.Parent = Me.txt_exid
        Me.txt_exid.Size = New System.Drawing.Size(91, 28)
        Me.txt_exid.TabIndex = 19
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(305, 71)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(15, 17)
        Me.Guna2HtmlLabel7.TabIndex = 18
        Me.Guna2HtmlLabel7.Text = "ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(63, 65)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(82, 17)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Expene Name"
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 10
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Location = New System.Drawing.Point(199, 277)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(98, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "SAVE"
        '
        'txt_exname
        '
        Me.txt_exname.BorderRadius = 5
        Me.txt_exname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_exname.DefaultText = ""
        Me.txt_exname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_exname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_exname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exname.DisabledState.Parent = Me.txt_exname
        Me.txt_exname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_exname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exname.FocusedState.Parent = Me.txt_exname
        Me.txt_exname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_exname.HoverState.Parent = Me.txt_exname
        Me.txt_exname.Location = New System.Drawing.Point(63, 88)
        Me.txt_exname.Name = "txt_exname"
        Me.txt_exname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_exname.PlaceholderText = ""
        Me.txt_exname.SelectedText = ""
        Me.txt_exname.ShadowDecoration.Parent = Me.txt_exname
        Me.txt_exname.Size = New System.Drawing.Size(200, 31)
        Me.txt_exname.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 146)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add New Expense Detail"
        '
        'btn_close
        '
        Me.btn_close.CheckedState.Parent = Me.btn_close
        Me.btn_close.CustomImages.Parent = Me.btn_close
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.HoverState.Parent = Me.btn_close
        Me.btn_close.Image = Global.sneaker_store.My.Resources.Resources.close
        Me.btn_close.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_close.Location = New System.Drawing.Point(535, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.ShadowDecoration.Parent = Me.btn_close
        Me.btn_close.Size = New System.Drawing.Size(60, 45)
        Me.btn_close.TabIndex = 19
        '
        'Tbl_extypeTableAdapter
        '
        Me.Tbl_extypeTableAdapter.ClearBeforeFill = True
        '
        'addnew_expenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addnew_expenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addnew_expenes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblextypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsneakerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_sneakerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_exid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_exname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_dp As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_exA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cb_extype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_desc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DbsneakerDataSetBindingSource As BindingSource
    Friend WithEvents Db_sneakerDataSet As db_sneakerDataSet
    Friend WithEvents TblextypeBindingSource As BindingSource
    Friend WithEvents Tbl_extypeTableAdapter As db_sneakerDataSetTableAdapters.tbl_extypeTableAdapter
End Class
