<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice
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
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_report = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txt_search)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_report)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Navy
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(542, 48)
        Me.Guna2CustomGradientPanel1.TabIndex = 7
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(147, 12)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(76, 20)
        Me.txt_search.TabIndex = 11
        Me.txt_search.Visible = False
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.Transparent
        Me.btn_report.BorderRadius = 10
        Me.btn_report.CheckedState.Parent = Me.btn_report
        Me.btn_report.CustomImages.Parent = Me.btn_report
        Me.btn_report.FillColor = System.Drawing.Color.Transparent
        Me.btn_report.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.HoverState.Parent = Me.btn_report
        Me.btn_report.Image = Global.sneaker_store.My.Resources.Resources.close
        Me.btn_report.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_report.Location = New System.Drawing.Point(485, 0)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.ShadowDecoration.Parent = Me.btn_report
        Me.btn_report.Size = New System.Drawing.Size(66, 46)
        Me.btn_report.TabIndex = 5
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 48)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(542, 627)
        Me.CrystalReportViewer1.TabIndex = 8
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 675)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invoice"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btn_report As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txt_search As TextBox
End Class
