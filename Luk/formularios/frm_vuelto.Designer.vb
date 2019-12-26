<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vuelto
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_aceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_vuelto = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txt_vuelto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 25.0!)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(89, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(334, 40)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Total Vuelto"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.btn_aceptar.Appearance.Options.UseFont = True
        Me.btn_aceptar.Location = New System.Drawing.Point(356, 170)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(129, 37)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Location = New System.Drawing.Point(89, 80)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_vuelto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 19.0!)
        Me.txt_vuelto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_vuelto.Properties.Appearance.Options.UseFont = True
        Me.txt_vuelto.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_vuelto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_vuelto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_vuelto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_vuelto.Size = New System.Drawing.Size(334, 34)
        Me.txt_vuelto.TabIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_aceptar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txt_vuelto)
        Me.PanelControl1.Location = New System.Drawing.Point(31, 26)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(513, 231)
        Me.PanelControl1.TabIndex = 5
        '
        'frm_vuelto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 283)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_vuelto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Total Vuelto>>"
        CType(Me.txt_vuelto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_aceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_vuelto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
