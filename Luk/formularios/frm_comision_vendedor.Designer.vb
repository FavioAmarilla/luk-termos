<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comision_vendedor
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_aceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_vendedores = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_comision = New DevExpress.XtraEditors.TextEdit()
        Me.txt_porc_comision = New DevExpress.XtraEditors.TextEdit()
        Me.txt_vendedor = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_comision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_porc_comision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_cancelar)
        Me.PanelControl1.Controls.Add(Me.btn_aceptar)
        Me.PanelControl1.Controls.Add(Me.btn_vendedores)
        Me.PanelControl1.Controls.Add(Me.txt_comision)
        Me.PanelControl1.Controls.Add(Me.txt_porc_comision)
        Me.PanelControl1.Controls.Add(Me.txt_vendedor)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(492, 225)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(262, 165)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(88, 32)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(143, 165)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(88, 32)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        '
        'btn_vendedores
        '
        Me.btn_vendedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_vendedores.Location = New System.Drawing.Point(384, 25)
        Me.btn_vendedores.Name = "btn_vendedores"
        Me.btn_vendedores.Size = New System.Drawing.Size(26, 21)
        Me.btn_vendedores.TabIndex = 5
        Me.btn_vendedores.Text = "+"
        '
        'txt_comision
        '
        Me.txt_comision.Location = New System.Drawing.Point(224, 64)
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Properties.AllowMouseWheel = False
        Me.txt_comision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_comision.Properties.Appearance.Options.UseFont = True
        Me.txt_comision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_comision.Properties.DisplayFormat.FormatString = "#,#"
        Me.txt_comision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_comision.Properties.Mask.EditMask = "n0"
        Me.txt_comision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_comision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_comision.Properties.NullText = "0"
        Me.txt_comision.Size = New System.Drawing.Size(186, 24)
        Me.txt_comision.TabIndex = 4
        '
        'txt_porc_comision
        '
        Me.txt_porc_comision.Location = New System.Drawing.Point(160, 64)
        Me.txt_porc_comision.Name = "txt_porc_comision"
        Me.txt_porc_comision.Properties.AllowMouseWheel = False
        Me.txt_porc_comision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_porc_comision.Properties.Appearance.Options.UseFont = True
        Me.txt_porc_comision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_porc_comision.Properties.DisplayFormat.FormatString = "0.00"
        Me.txt_porc_comision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_porc_comision.Properties.Mask.EditMask = "n"
        Me.txt_porc_comision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_porc_comision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_porc_comision.Properties.NullText = "0"
        Me.txt_porc_comision.Size = New System.Drawing.Size(58, 24)
        Me.txt_porc_comision.TabIndex = 3
        '
        'txt_vendedor
        '
        Me.txt_vendedor.Location = New System.Drawing.Point(160, 25)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_vendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_vendedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_vendedor.Properties.Appearance.Options.UseFont = True
        Me.txt_vendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_vendedor.Properties.ReadOnly = True
        Me.txt_vendedor.Size = New System.Drawing.Size(218, 24)
        Me.txt_vendedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(86, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comision:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendedor:"
        '
        'frm_comision_vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 249)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_comision_vendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comision vendedor"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_comision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_porc_comision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_vendedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_comision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_porc_comision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_aceptar As DevExpress.XtraEditors.SimpleButton
End Class
