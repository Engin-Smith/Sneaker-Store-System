<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbl_brand
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BrandDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btn_addb = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_refresh = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrandDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.BrandDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BrandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BrandDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.BrandDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrandDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BrandDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrandDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BrandDataGridView.ColumnHeadersHeight = 41
        Me.BrandDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.ID})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BrandDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.BrandDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrandDataGridView.EnableHeadersVisualStyles = False
        Me.BrandDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BrandDataGridView.Location = New System.Drawing.Point(0, 64)
        Me.BrandDataGridView.Name = "BrandDataGridView"
        Me.BrandDataGridView.RowHeadersVisible = False
        Me.BrandDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BrandDataGridView.Size = New System.Drawing.Size(800, 386)
        Me.BrandDataGridView.TabIndex = 7
        Me.BrandDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.BrandDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BrandDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BrandDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BrandDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BrandDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BrandDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BrandDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BrandDataGridView.ThemeStyle.HeaderStyle.Height = 41
        Me.BrandDataGridView.ThemeStyle.ReadOnly = False
        Me.BrandDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BrandDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BrandDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BrandDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BrandDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.BrandDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BrandDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_addb)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_refresh)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(800, 64)
        Me.Guna2CustomGradientPanel1.TabIndex = 6
        '
        'btn_addb
        '
        Me.btn_addb.BackColor = System.Drawing.Color.Transparent
        Me.btn_addb.BorderRadius = 10
        Me.btn_addb.CheckedState.Parent = Me.btn_addb
        Me.btn_addb.CustomImages.Parent = Me.btn_addb
        Me.btn_addb.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addb.ForeColor = System.Drawing.Color.White
        Me.btn_addb.HoverState.Parent = Me.btn_addb
        Me.btn_addb.Location = New System.Drawing.Point(71, 12)
        Me.btn_addb.Name = "btn_addb"
        Me.btn_addb.ShadowDecoration.Parent = Me.btn_addb
        Me.btn_addb.Size = New System.Drawing.Size(157, 42)
        Me.btn_addb.TabIndex = 3
        Me.btn_addb.Text = "Add Brand"
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
        Me.btn_refresh.Location = New System.Drawing.Point(249, 12)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.ShadowDecoration.Parent = Me.btn_refresh
        Me.btn_refresh.Size = New System.Drawing.Size(157, 42)
        Me.btn_refresh.TabIndex = 4
        Me.btn_refresh.Text = "Refresh"
        '
        'Column2
        '
        Me.Column2.HeaderText = "#"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Brand ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "Brand Name"
        Me.ID.Name = "ID"
        '
        'tbl_brand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BrandDataGridView)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tbl_brand"
        Me.Text = "tbl_brand"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BrandDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btn_addb As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_refresh As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
