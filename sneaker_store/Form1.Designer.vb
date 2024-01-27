<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ck_show_pass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_log = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txt_pass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_user = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_close)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(750, 449)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("AKbalthom HighSchool-Fun", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(67, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 49)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Store"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("AKbalthom HighSchool-Fun", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(35, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 67)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sneaker"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.CheckedState.Parent = Me.btn_close
        Me.btn_close.CustomImages.Parent = Me.btn_close
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.HoverState.Parent = Me.btn_close
        Me.btn_close.Image = Global.sneaker_store.My.Resources.Resources.close
        Me.btn_close.Location = New System.Drawing.Point(698, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.ShadowDecoration.Parent = Me.btn_close
        Me.btn_close.Size = New System.Drawing.Size(40, 26)
        Me.btn_close.TabIndex = 3
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.Controls.Add(Me.ck_show_pass)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.btn_log)
        Me.Guna2GradientPanel2.Controls.Add(Me.txt_pass)
        Me.Guna2GradientPanel2.Controls.Add(Me.txt_user)
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(379, 23)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(334, 414)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'ck_show_pass
        '
        Me.ck_show_pass.AutoSize = True
        Me.ck_show_pass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ck_show_pass.CheckedState.BorderRadius = 2
        Me.ck_show_pass.CheckedState.BorderThickness = 0
        Me.ck_show_pass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ck_show_pass.Location = New System.Drawing.Point(44, 260)
        Me.ck_show_pass.Name = "ck_show_pass"
        Me.ck_show_pass.Size = New System.Drawing.Size(102, 17)
        Me.ck_show_pass.TabIndex = 6
        Me.ck_show_pass.Text = "Show Password"
        Me.ck_show_pass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ck_show_pass.UncheckedState.BorderRadius = 2
        Me.ck_show_pass.UncheckedState.BorderThickness = 0
        Me.ck_show_pass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ck_show_pass.UseVisualStyleBackColor = True
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.sneaker_store.My.Resources.Resources.icon_user
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(118, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(96, 103)
        Me.Guna2CirclePictureBox1.TabIndex = 5
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name"
        '
        'btn_log
        '
        Me.btn_log.BorderRadius = 15
        Me.btn_log.CheckedState.Parent = Me.btn_log
        Me.btn_log.CustomImages.Parent = Me.btn_log
        Me.btn_log.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log.ForeColor = System.Drawing.Color.White
        Me.btn_log.HoverState.Parent = Me.btn_log
        Me.btn_log.Location = New System.Drawing.Point(107, 294)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.ShadowDecoration.Parent = Me.btn_log
        Me.btn_log.Size = New System.Drawing.Size(117, 38)
        Me.btn_log.TabIndex = 2
        Me.btn_log.Text = "LOGIN"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.RosyBrown
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.LineColor = System.Drawing.Color.Black
        Me.txt_pass.Location = New System.Drawing.Point(44, 218)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pass.SelectedText = ""
        Me.txt_pass.Size = New System.Drawing.Size(241, 36)
        Me.txt_pass.TabIndex = 1
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.RosyBrown
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_user.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.LineColor = System.Drawing.Color.Black
        Me.txt_user.Location = New System.Drawing.Point(44, 137)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.SelectedText = ""
        Me.txt_user.Size = New System.Drawing.Size(241, 36)
        Me.txt_user.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.sneaker_store.My.Resources.Resources.bg_user
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(330, 425)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 449)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_log As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_pass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_user As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ck_show_pass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
