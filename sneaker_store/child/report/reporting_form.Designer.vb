﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporting_form
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
        Me.menu_expense = New Guna.UI2.WinForms.Guna2Button()
        Me.menu_brand = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.menu_prod = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_expense)
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_brand)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_back)
        Me.Guna2GradientPanel1.Controls.Add(Me.menu_prod)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 59)
        Me.Guna2GradientPanel1.TabIndex = 5
        '
        'menu_expense
        '
        Me.menu_expense.BackColor = System.Drawing.Color.Transparent
        Me.menu_expense.CheckedState.Parent = Me.menu_expense
        Me.menu_expense.CustomImages.Parent = Me.menu_expense
        Me.menu_expense.FillColor = System.Drawing.Color.Transparent
        Me.menu_expense.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_expense.ForeColor = System.Drawing.Color.White
        Me.menu_expense.HoverState.Parent = Me.menu_expense
        Me.menu_expense.Location = New System.Drawing.Point(327, 12)
        Me.menu_expense.Name = "menu_expense"
        Me.menu_expense.ShadowDecoration.Parent = Me.menu_expense
        Me.menu_expense.Size = New System.Drawing.Size(108, 34)
        Me.menu_expense.TabIndex = 3
        Me.menu_expense.Text = "Expense"
        '
        'menu_brand
        '
        Me.menu_brand.BackColor = System.Drawing.Color.Transparent
        Me.menu_brand.CheckedState.Parent = Me.menu_brand
        Me.menu_brand.CustomImages.Parent = Me.menu_brand
        Me.menu_brand.FillColor = System.Drawing.Color.Transparent
        Me.menu_brand.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_brand.ForeColor = System.Drawing.Color.White
        Me.menu_brand.HoverState.Parent = Me.menu_brand
        Me.menu_brand.Location = New System.Drawing.Point(225, 12)
        Me.menu_brand.Name = "menu_brand"
        Me.menu_brand.ShadowDecoration.Parent = Me.menu_brand
        Me.menu_brand.Size = New System.Drawing.Size(108, 34)
        Me.menu_brand.TabIndex = 2
        Me.menu_brand.Text = "Stock"
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
        'menu_prod
        '
        Me.menu_prod.BackColor = System.Drawing.Color.Transparent
        Me.menu_prod.CheckedState.Parent = Me.menu_prod
        Me.menu_prod.CustomImages.Parent = Me.menu_prod
        Me.menu_prod.FillColor = System.Drawing.Color.Transparent
        Me.menu_prod.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_prod.ForeColor = System.Drawing.Color.White
        Me.menu_prod.HoverState.Parent = Me.menu_prod
        Me.menu_prod.Location = New System.Drawing.Point(123, 12)
        Me.menu_prod.Name = "menu_prod"
        Me.menu_prod.ShadowDecoration.Parent = Me.menu_prod
        Me.menu_prod.Size = New System.Drawing.Size(108, 34)
        Me.menu_prod.TabIndex = 1
        Me.menu_prod.Text = "Sale"
        '
        'reporting_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporting_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporting_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents menu_expense As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents menu_brand As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents menu_prod As Guna.UI2.WinForms.Guna2Button
End Class
