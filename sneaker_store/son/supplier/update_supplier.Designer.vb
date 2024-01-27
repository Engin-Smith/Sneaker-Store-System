<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class update_supplier
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
        Me.btn_delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_phone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_sid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_sname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.txt_address)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.txt_phone)
        Me.Panel1.Controls.Add(Me.txt_sid)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.txt_sname)
        Me.Panel1.Location = New System.Drawing.Point(35, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 338)
        Me.Panel1.TabIndex = 12
        '
        'btn_delete
        '
        Me.btn_delete.BorderRadius = 10
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(167, 256)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(98, 36)
        Me.btn_delete.TabIndex = 24
        Me.btn_delete.Text = "DELETE"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(63, 185)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(47, 17)
        Me.Guna2HtmlLabel3.TabIndex = 23
        Me.Guna2HtmlLabel3.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.BorderRadius = 5
        Me.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_address.DefaultText = ""
        Me.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.DisabledState.Parent = Me.txt_address
        Me.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.FocusedState.Parent = Me.txt_address
        Me.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.HoverState.Parent = Me.txt_address
        Me.txt_address.Location = New System.Drawing.Point(63, 208)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.PlaceholderText = ""
        Me.txt_address.SelectedText = ""
        Me.txt_address.ShadowDecoration.Parent = Me.txt_address
        Me.txt_address.Size = New System.Drawing.Size(200, 31)
        Me.txt_address.TabIndex = 22
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(63, 125)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(87, 17)
        Me.Guna2HtmlLabel2.TabIndex = 21
        Me.Guna2HtmlLabel2.Text = "Phone Number"
        '
        'txt_phone
        '
        Me.txt_phone.BorderRadius = 5
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone.DefaultText = ""
        Me.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.DisabledState.Parent = Me.txt_phone
        Me.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.FocusedState.Parent = Me.txt_phone
        Me.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.HoverState.Parent = Me.txt_phone
        Me.txt_phone.Location = New System.Drawing.Point(63, 148)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.PlaceholderText = ""
        Me.txt_phone.SelectedText = ""
        Me.txt_phone.ShadowDecoration.Parent = Me.txt_phone
        Me.txt_phone.Size = New System.Drawing.Size(200, 31)
        Me.txt_phone.TabIndex = 20
        '
        'txt_sid
        '
        Me.txt_sid.BackColor = System.Drawing.Color.Transparent
        Me.txt_sid.BorderRadius = 5
        Me.txt_sid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sid.DefaultText = ""
        Me.txt_sid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sid.DisabledState.Parent = Me.txt_sid
        Me.txt_sid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sid.FocusedState.Parent = Me.txt_sid
        Me.txt_sid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sid.HoverState.Parent = Me.txt_sid
        Me.txt_sid.Location = New System.Drawing.Point(63, 30)
        Me.txt_sid.Name = "txt_sid"
        Me.txt_sid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sid.PlaceholderText = ""
        Me.txt_sid.ReadOnly = True
        Me.txt_sid.SelectedText = ""
        Me.txt_sid.ShadowDecoration.Parent = Me.txt_sid
        Me.txt_sid.Size = New System.Drawing.Size(200, 28)
        Me.txt_sid.TabIndex = 19
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(86, 17)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Supplier Name"
        '
        'btn_update
        '
        Me.btn_update.BorderRadius = 10
        Me.btn_update.CheckedState.Parent = Me.btn_update
        Me.btn_update.CustomImages.Parent = Me.btn_update
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.HoverState.Parent = Me.btn_update
        Me.btn_update.Location = New System.Drawing.Point(63, 256)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.ShadowDecoration.Parent = Me.btn_update
        Me.btn_update.Size = New System.Drawing.Size(98, 36)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "UPDATE"
        '
        'txt_sname
        '
        Me.txt_sname.BorderRadius = 5
        Me.txt_sname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sname.DefaultText = ""
        Me.txt_sname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sname.DisabledState.Parent = Me.txt_sname
        Me.txt_sname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sname.FocusedState.Parent = Me.txt_sname
        Me.txt_sname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sname.HoverState.Parent = Me.txt_sname
        Me.txt_sname.Location = New System.Drawing.Point(63, 88)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sname.PlaceholderText = ""
        Me.txt_sname.SelectedText = ""
        Me.txt_sname.ShadowDecoration.Parent = Me.txt_sname
        Me.txt_sname.Size = New System.Drawing.Size(200, 31)
        Me.txt_sname.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 146)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Create New Supplier"
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
        Me.btn_close.Location = New System.Drawing.Point(339, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.ShadowDecoration.Parent = Me.btn_close
        Me.btn_close.Size = New System.Drawing.Size(60, 45)
        Me.btn_close.TabIndex = 19
        '
        'update_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "update_supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update_supplier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_phone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_sid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_sname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
End Class
