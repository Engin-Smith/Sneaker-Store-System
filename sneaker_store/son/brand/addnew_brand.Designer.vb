<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addnew_brand
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txt_bid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_bname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txt_bid
        '
        Me.txt_bid.BackColor = System.Drawing.Color.Transparent
        Me.txt_bid.BorderRadius = 5
        Me.txt_bid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bid.DefaultText = ""
        Me.txt_bid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_bid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_bid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bid.DisabledState.Parent = Me.txt_bid
        Me.txt_bid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bid.FocusedState.Parent = Me.txt_bid
        Me.txt_bid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bid.HoverState.Parent = Me.txt_bid
        Me.txt_bid.Location = New System.Drawing.Point(63, 30)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bid.PlaceholderText = ""
        Me.txt_bid.ReadOnly = True
        Me.txt_bid.SelectedText = ""
        Me.txt_bid.ShadowDecoration.Parent = Me.txt_bid
        Me.txt_bid.Size = New System.Drawing.Size(73, 28)
        Me.txt_bid.TabIndex = 19
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
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Create New Brand"
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
        'txt_bname
        '
        Me.txt_bname.BorderRadius = 5
        Me.txt_bname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bname.DefaultText = ""
        Me.txt_bname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_bname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_bname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bname.DisabledState.Parent = Me.txt_bname
        Me.txt_bname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bname.FocusedState.Parent = Me.txt_bname
        Me.txt_bname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_bname.HoverState.Parent = Me.txt_bname
        Me.txt_bname.Location = New System.Drawing.Point(63, 88)
        Me.txt_bname.Name = "txt_bname"
        Me.txt_bname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bname.PlaceholderText = ""
        Me.txt_bname.SelectedText = ""
        Me.txt_bname.ShadowDecoration.Parent = Me.txt_bname
        Me.txt_bname.Size = New System.Drawing.Size(200, 31)
        Me.txt_bname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_bid)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.txt_bname)
        Me.Panel1.Location = New System.Drawing.Point(35, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 338)
        Me.Panel1.TabIndex = 8
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(73, 17)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Brand Name"
        '
        'addnew_brand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addnew_brand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addnew_brand"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_bid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_bname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
