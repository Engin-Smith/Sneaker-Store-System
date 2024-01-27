<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_cat
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_cname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_cid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 146)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add New Category"
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
        Me.btn_close.Location = New System.Drawing.Point(334, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.ShadowDecoration.Parent = Me.btn_close
        Me.btn_close.Size = New System.Drawing.Size(60, 45)
        Me.btn_close.TabIndex = 19
        '
        'txt_cname
        '
        Me.txt_cname.BorderRadius = 5
        Me.txt_cname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cname.DefaultText = ""
        Me.txt_cname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cname.DisabledState.Parent = Me.txt_cname
        Me.txt_cname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cname.FocusedState.Parent = Me.txt_cname
        Me.txt_cname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cname.HoverState.Parent = Me.txt_cname
        Me.txt_cname.Location = New System.Drawing.Point(63, 88)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cname.PlaceholderText = ""
        Me.txt_cname.SelectedText = ""
        Me.txt_cname.ShadowDecoration.Parent = Me.txt_cname
        Me.txt_cname.Size = New System.Drawing.Size(200, 31)
        Me.txt_cname.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 10
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Location = New System.Drawing.Point(112, 150)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(98, 36)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "SAVE"
        '
        'txt_cid
        '
        Me.txt_cid.BackColor = System.Drawing.Color.Transparent
        Me.txt_cid.BorderRadius = 5
        Me.txt_cid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cid.DefaultText = ""
        Me.txt_cid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cid.DisabledState.Parent = Me.txt_cid
        Me.txt_cid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cid.FocusedState.Parent = Me.txt_cid
        Me.txt_cid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cid.HoverState.Parent = Me.txt_cid
        Me.txt_cid.Location = New System.Drawing.Point(63, 30)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cid.PlaceholderText = ""
        Me.txt_cid.ReadOnly = True
        Me.txt_cid.SelectedText = ""
        Me.txt_cid.ShadowDecoration.Parent = Me.txt_cid
        Me.txt_cid.Size = New System.Drawing.Size(88, 28)
        Me.txt_cid.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_cid)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.txt_cname)
        Me.Panel1.Location = New System.Drawing.Point(35, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 338)
        Me.Panel1.TabIndex = 6
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(63, 10)
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
        Me.Guna2HtmlLabel1.Text = "Product Name"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'add_cat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 376)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_cat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_cat"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_cid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
