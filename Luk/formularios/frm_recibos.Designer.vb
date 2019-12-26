<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recibos))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_forma_pago = New DevExpress.XtraEditors.TextEdit()
        Me.btn_formas_pago = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_monto = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_observacion = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_cliente = New DevExpress.XtraEditors.TextEdit()
        Me.btn_clientes = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_calendar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cld_fecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txt_forma_pago)
        Me.PanelControl1.Controls.Add(Me.btn_formas_pago)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.txt_numero)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txt_monto)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.txt_observacion)
        Me.PanelControl1.Controls.Add(Me.txt_cliente)
        Me.PanelControl1.Controls.Add(Me.btn_clientes)
        Me.PanelControl1.Controls.Add(Me.btn_calendar)
        Me.PanelControl1.Controls.Add(Me.txt_fecha)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(664, 358)
        Me.PanelControl1.TabIndex = 0
        '
        'txt_forma_pago
        '
        Me.txt_forma_pago.Location = New System.Drawing.Point(151, 102)
        Me.txt_forma_pago.Name = "txt_forma_pago"
        Me.txt_forma_pago.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_forma_pago.Properties.Appearance.Options.UseBackColor = True
        Me.txt_forma_pago.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_forma_pago.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_forma_pago.Properties.ReadOnly = True
        Me.txt_forma_pago.Size = New System.Drawing.Size(229, 22)
        Me.txt_forma_pago.TabIndex = 64
        '
        'btn_formas_pago
        '
        Me.btn_formas_pago.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_formas_pago.Location = New System.Drawing.Point(384, 102)
        Me.btn_formas_pago.Name = "btn_formas_pago"
        Me.btn_formas_pago.Size = New System.Drawing.Size(28, 22)
        Me.btn_formas_pago.TabIndex = 66
        Me.btn_formas_pago.TabStop = False
        Me.btn_formas_pago.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Forma de pago:"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(151, 19)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_numero.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Properties.ReadOnly = True
        Me.txt_numero.Size = New System.Drawing.Size(229, 22)
        Me.txt_numero.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Numero:"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(151, 130)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_monto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_monto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_monto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_monto.Properties.Mask.EditMask = "n0"
        Me.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_monto.Size = New System.Drawing.Size(229, 22)
        Me.txt_monto.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 133)
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
        Me.btnCancelar.Location = New System.Drawing.Point(263, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 35)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(140, 307)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 35)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(151, 158)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_observacion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_observacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observacion.Size = New System.Drawing.Size(229, 83)
        Me.txt_observacion.TabIndex = 2
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(151, 74)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cliente.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cliente.Properties.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(229, 22)
        Me.txt_cliente.TabIndex = 1
        '
        'btn_clientes
        '
        Me.btn_clientes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_clientes.Location = New System.Drawing.Point(384, 74)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(28, 22)
        Me.btn_clientes.TabIndex = 59
        Me.btn_clientes.TabStop = False
        Me.btn_clientes.Text = "+"
        '
        'btn_calendar
        '
        Me.btn_calendar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_calendar.Location = New System.Drawing.Point(384, 47)
        Me.btn_calendar.Name = "btn_calendar"
        Me.btn_calendar.Size = New System.Drawing.Size(28, 21)
        Me.btn_calendar.TabIndex = 56
        Me.btn_calendar.TabStop = False
        Me.btn_calendar.Text = "+"
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Location = New System.Drawing.Point(151, 47)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha.TabIndex = 0
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'cld_fecha
        '
        Me.cld_fecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha.Location = New System.Drawing.Point(397, 59)
        Me.cld_fecha.Name = "cld_fecha"
        Me.cld_fecha.Size = New System.Drawing.Size(257, 227)
        Me.cld_fecha.TabIndex = 57
        Me.cld_fecha.Visible = False
        '
        'frm_recibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 384)
        Me.Controls.Add(Me.cld_fecha)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_recibos"
        Me.Text = "Recibos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_calendar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha As MaskedTextBox
    Friend WithEvents cld_fecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txt_observacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_clientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_forma_pago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_formas_pago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
End Class
