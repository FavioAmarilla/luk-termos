<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reimpresion_recibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reimpresion_recibos))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_buscar_recibos = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_forma_pago = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_monto = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_observacion = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_cliente = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_buscar_recibos)
        Me.PanelControl1.Controls.Add(Me.txt_forma_pago)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.txt_numero)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txt_monto)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnImprimir)
        Me.PanelControl1.Controls.Add(Me.txt_observacion)
        Me.PanelControl1.Controls.Add(Me.txt_cliente)
        Me.PanelControl1.Controls.Add(Me.txt_fecha)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(588, 358)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_buscar_recibos
        '
        Me.btn_buscar_recibos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_recibos.Location = New System.Drawing.Point(420, 18)
        Me.btn_buscar_recibos.Name = "btn_buscar_recibos"
        Me.btn_buscar_recibos.Size = New System.Drawing.Size(30, 23)
        Me.btn_buscar_recibos.TabIndex = 66
        Me.btn_buscar_recibos.Text = "+"
        '
        'txt_forma_pago
        '
        Me.txt_forma_pago.Location = New System.Drawing.Point(189, 102)
        Me.txt_forma_pago.Name = "txt_forma_pago"
        Me.txt_forma_pago.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_forma_pago.Properties.Appearance.Options.UseBackColor = True
        Me.txt_forma_pago.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_forma_pago.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_forma_pago.Size = New System.Drawing.Size(261, 22)
        Me.txt_forma_pago.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Forma de pago:"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(189, 19)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_numero.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Size = New System.Drawing.Size(225, 22)
        Me.txt_numero.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Numero:"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(189, 130)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_monto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_monto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_monto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_monto.Properties.Mask.EditMask = "n0"
        Me.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_monto.Size = New System.Drawing.Size(261, 22)
        Me.txt_monto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Monto:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(297, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 35)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(174, 307)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(117, 35)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(189, 158)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_observacion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_observacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observacion.Size = New System.Drawing.Size(261, 83)
        Me.txt_observacion.TabIndex = 5
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(189, 74)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cliente.Size = New System.Drawing.Size(261, 22)
        Me.txt_cliente.TabIndex = 2
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Location = New System.Drawing.Point(189, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(261, 21)
        Me.txt_fecha.TabIndex = 1
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'frm_reimpresion_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 388)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_reimpresion_recibos"
        Me.Text = "Reimpresion de recibos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_forma_pago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_observacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar_recibos As DevExpress.XtraEditors.SimpleButton
End Class
