<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.menu_damagedstock = New Guna.UI2.WinForms.Guna2Button()
        Me.menu_purchase = New Guna.UI2.WinForms.Guna2Button()
        Me.menu_sale = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 391)
        Me.Panel1.TabIndex = 6
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_damagedstock)
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_purchase)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_back)
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_sale)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 59)
        Me.Guna2GradientPanel1.TabIndex = 5
        '
        'menu_damagedstock
        '
        Me.menu_damagedstock.BackColor = System.Drawing.Color.Transparent
        Me.menu_damagedstock.CheckedState.Parent = Me.menu_damagedstock
        Me.menu_damagedstock.CustomImages.Parent = Me.menu_damagedstock
        Me.menu_damagedstock.FillColor = System.Drawing.Color.Transparent
        Me.menu_damagedstock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_damagedstock.ForeColor = System.Drawing.Color.White
        Me.menu_damagedstock.HoverState.Parent = Me.menu_damagedstock
        Me.menu_damagedstock.Location = New System.Drawing.Point(495, 12)
        Me.menu_damagedstock.Name = "menu_damagedstock"
        Me.menu_damagedstock.ShadowDecoration.Parent = Me.menu_damagedstock
        Me.menu_damagedstock.Size = New System.Drawing.Size(180, 34)
        Me.menu_damagedstock.TabIndex = 3
        Me.menu_damagedstock.Text = "Damaged Stock"
        '
        'menu_purchase
        '
        Me.menu_purchase.BackColor = System.Drawing.Color.Transparent
        Me.menu_purchase.CheckedState.Parent = Me.menu_purchase
        Me.menu_purchase.CustomImages.Parent = Me.menu_purchase
        Me.menu_purchase.FillColor = System.Drawing.Color.Transparent
        Me.menu_purchase.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_purchase.ForeColor = System.Drawing.Color.White
        Me.menu_purchase.HoverState.Parent = Me.menu_purchase
        Me.menu_purchase.Location = New System.Drawing.Point(309, 12)
        Me.menu_purchase.Name = "menu_purchase"
        Me.menu_purchase.ShadowDecoration.Parent = Me.menu_purchase
        Me.menu_purchase.Size = New System.Drawing.Size(180, 34)
        Me.menu_purchase.TabIndex = 2
        Me.menu_purchase.Text = "Purchace"
        '
        'menu_sale
        '
        Me.menu_sale.BackColor = System.Drawing.Color.Transparent
        Me.menu_sale.CheckedState.Parent = Me.menu_sale
        Me.menu_sale.CustomImages.Parent = Me.menu_sale
        Me.menu_sale.FillColor = System.Drawing.Color.Transparent
        Me.menu_sale.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_sale.ForeColor = System.Drawing.Color.White
        Me.menu_sale.HoverState.Parent = Me.menu_sale
        Me.menu_sale.Location = New System.Drawing.Point(123, 12)
        Me.menu_sale.Name = "menu_sale"
        Me.menu_sale.ShadowDecoration.Parent = Me.menu_sale
        Me.menu_sale.Size = New System.Drawing.Size(180, 34)
        Me.menu_sale.TabIndex = 1
        Me.menu_sale.Text = "Sale"
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
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents menu_damagedstock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents menu_purchase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents menu_sale As Guna.UI2.WinForms.Guna2Button
End Class
