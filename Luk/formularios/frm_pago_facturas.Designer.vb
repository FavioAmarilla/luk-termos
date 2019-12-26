<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pago_facturas
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pago_facturas))
        Me.rps_comprobante = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_total_venta = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_total_pagado = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_saldo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_pagar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cld_fecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cliente = New DevExpress.XtraEditors.TextEdit()
        Me.btn_clientes = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_calendar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_vuelto = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_importe = New DevExpress.XtraEditors.TextEdit()
        Me.txt_forma_pago = New DevExpress.XtraEditors.TextEdit()
        Me.btn_formas_pago = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_total_pagar = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gridComprobantes = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.con_id_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pagado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_monto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pagar = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rps_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_total_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_total_pagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_saldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_pagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txt_vuelto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_importe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_pagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rps_comprobante
        '
        Me.rps_comprobante.AutoHeight = False
        Me.rps_comprobante.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_comprobante.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.rps_comprobante.Name = "rps_comprobante"
        Me.rps_comprobante.ReadOnly = True
        '
        'rps_fecha
        '
        Me.rps_fecha.AutoHeight = False
        Me.rps_fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_fecha.Mask.EditMask = "d"
        Me.rps_fecha.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.rps_fecha.Mask.UseMaskAsDisplayFormat = True
        Me.rps_fecha.Name = "rps_fecha"
        Me.rps_fecha.ReadOnly = True
        '
        'rps_total_venta
        '
        Me.rps_total_venta.AutoHeight = False
        Me.rps_total_venta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_total_venta.Mask.EditMask = "n0"
        Me.rps_total_venta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_total_venta.Mask.UseMaskAsDisplayFormat = True
        Me.rps_total_venta.Name = "rps_total_venta"
        Me.rps_total_venta.ReadOnly = True
        '
        'rps_total_pagado
        '
        Me.rps_total_pagado.AutoHeight = False
        Me.rps_total_pagado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_total_pagado.Mask.EditMask = "n0"
        Me.rps_total_pagado.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_total_pagado.Mask.UseMaskAsDisplayFormat = True
        Me.rps_total_pagado.Name = "rps_total_pagado"
        Me.rps_total_pagado.ReadOnly = True
        '
        'rps_saldo
        '
        Me.rps_saldo.AutoHeight = False
        Me.rps_saldo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_saldo.Mask.EditMask = "n0"
        Me.rps_saldo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_saldo.Mask.UseMaskAsDisplayFormat = True
        Me.rps_saldo.Name = "rps_saldo"
        Me.rps_saldo.ReadOnly = True
        '
        'rps_pagar
        '
        Me.rps_pagar.AutoHeight = False
        Me.rps_pagar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_pagar.Name = "rps_pagar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl5)
        Me.PanelControl1.Controls.Add(Me.cld_fecha)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(943, 477)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btnCancelar)
        Me.PanelControl5.Controls.Add(Me.btnAceptar)
        Me.PanelControl5.Location = New System.Drawing.Point(745, 15)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(182, 128)
        Me.PanelControl5.TabIndex = 66
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(33, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 35)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(33, 25)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 35)
        Me.btnAceptar.TabIndex = 68
        Me.btnAceptar.Text = "Aceptar"
        '
        'cld_fecha
        '
        Me.cld_fecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha.Location = New System.Drawing.Point(326, 49)
        Me.cld_fecha.Name = "cld_fecha"
        Me.cld_fecha.Size = New System.Drawing.Size(254, 227)
        Me.cld_fecha.TabIndex = 65
        Me.cld_fecha.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txt_numero)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.txt_cliente)
        Me.PanelControl2.Controls.Add(Me.btn_clientes)
        Me.PanelControl2.Controls.Add(Me.btn_calendar)
        Me.PanelControl2.Controls.Add(Me.txt_fecha)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(365, 128)
        Me.PanelControl2.TabIndex = 0
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(82, 61)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_numero.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Properties.ReadOnly = True
        Me.txt_numero.Size = New System.Drawing.Size(261, 22)
        Me.txt_numero.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Recibo Nro:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(82, 9)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cliente.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cliente.Properties.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(229, 22)
        Me.txt_cliente.TabIndex = 0
        '
        'btn_clientes
        '
        Me.btn_clientes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_clientes.Location = New System.Drawing.Point(315, 9)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(28, 22)
        Me.btn_clientes.TabIndex = 66
        Me.btn_clientes.TabStop = False
        Me.btn_clientes.Text = "+"
        '
        'btn_calendar
        '
        Me.btn_calendar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_calendar.Location = New System.Drawing.Point(315, 34)
        Me.btn_calendar.Name = "btn_calendar"
        Me.btn_calendar.Size = New System.Drawing.Size(28, 21)
        Me.btn_calendar.TabIndex = 64
        Me.btn_calendar.TabStop = False
        Me.btn_calendar.Text = "+"
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Location = New System.Drawing.Point(82, 34)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha.TabIndex = 1
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Fecha:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.Label7)
        Me.PanelControl4.Controls.Add(Me.txt_vuelto)
        Me.PanelControl4.Controls.Add(Me.Label6)
        Me.PanelControl4.Controls.Add(Me.txt_importe)
        Me.PanelControl4.Controls.Add(Me.txt_forma_pago)
        Me.PanelControl4.Controls.Add(Me.btn_formas_pago)
        Me.PanelControl4.Controls.Add(Me.Label3)
        Me.PanelControl4.Controls.Add(Me.Label5)
        Me.PanelControl4.Controls.Add(Me.txt_total_pagar)
        Me.PanelControl4.Location = New System.Drawing.Point(382, 15)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(357, 128)
        Me.PanelControl4.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Vuelto:"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Location = New System.Drawing.Point(106, 90)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_vuelto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_vuelto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_vuelto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_vuelto.Properties.Mask.EditMask = "n0"
        Me.txt_vuelto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_vuelto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_vuelto.Properties.NullText = "0"
        Me.txt_vuelto.Properties.ReadOnly = True
        Me.txt_vuelto.Size = New System.Drawing.Size(229, 22)
        Me.txt_vuelto.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Importe:"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(106, 62)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_importe.Properties.Appearance.Options.UseBackColor = True
        Me.txt_importe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_importe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_importe.Properties.Mask.EditMask = "n0"
        Me.txt_importe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_importe.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_importe.Properties.NullText = "0"
        Me.txt_importe.Size = New System.Drawing.Size(229, 22)
        Me.txt_importe.TabIndex = 72
        '
        'txt_forma_pago
        '
        Me.txt_forma_pago.Location = New System.Drawing.Point(106, 34)
        Me.txt_forma_pago.Name = "txt_forma_pago"
        Me.txt_forma_pago.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_forma_pago.Properties.Appearance.Options.UseBackColor = True
        Me.txt_forma_pago.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_forma_pago.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_forma_pago.Properties.ReadOnly = True
        Me.txt_forma_pago.Size = New System.Drawing.Size(198, 22)
        Me.txt_forma_pago.TabIndex = 69
        '
        'btn_formas_pago
        '
        Me.btn_formas_pago.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_formas_pago.Location = New System.Drawing.Point(307, 33)
        Me.btn_formas_pago.Name = "btn_formas_pago"
        Me.btn_formas_pago.Size = New System.Drawing.Size(28, 22)
        Me.btn_formas_pago.TabIndex = 71
        Me.btn_formas_pago.TabStop = False
        Me.btn_formas_pago.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total a pagar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Forma de pago:"
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.Location = New System.Drawing.Point(106, 8)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_pagar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_pagar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_pagar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_pagar.Properties.Mask.EditMask = "n0"
        Me.txt_total_pagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_pagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_pagar.Properties.NullText = "0"
        Me.txt_total_pagar.Properties.ReadOnly = True
        Me.txt_total_pagar.Size = New System.Drawing.Size(229, 22)
        Me.txt_total_pagar.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gridComprobantes)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 149)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(916, 312)
        Me.PanelControl3.TabIndex = 1
        '
        'gridComprobantes
        '
        Me.gridComprobantes.Location = New System.Drawing.Point(18, 133)
        Me.gridComprobantes.MainView = Me.GridView1
        Me.gridComprobantes.Name = "gridComprobantes"
        Me.gridComprobantes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_monto})
        Me.gridComprobantes.Size = New System.Drawing.Size(881, 166)
        Me.gridComprobantes.TabIndex = 0
        Me.gridComprobantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.con_id_venta, Me.col_comprobante, Me.col_fecha, Me.col_total_venta, Me.col_pagado, Me.col_monto, Me.col_saldo, Me.col_pagar})
        Me.GridView1.GridControl = Me.gridComprobantes
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'con_id_venta
        '
        Me.con_id_venta.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.con_id_venta.AppearanceCell.Options.UseBackColor = True
        Me.con_id_venta.Caption = "ID Venta"
        Me.con_id_venta.ColumnEdit = Me.rps_comprobante
        Me.con_id_venta.FieldName = "id_venta"
        Me.con_id_venta.Name = "con_id_venta"
        '
        'col_comprobante
        '
        Me.col_comprobante.Caption = "Comprobante"
        Me.col_comprobante.ColumnEdit = Me.rps_comprobante
        Me.col_comprobante.FieldName = "comprobante"
        Me.col_comprobante.Name = "col_comprobante"
        Me.col_comprobante.Visible = True
        Me.col_comprobante.VisibleIndex = 0
        Me.col_comprobante.Width = 268
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "Fecha"
        Me.col_fecha.ColumnEdit = Me.rps_fecha
        Me.col_fecha.FieldName = "fecha_venta"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 1
        Me.col_fecha.Width = 106
        '
        'col_total_venta
        '
        Me.col_total_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.Caption = "Total Comprob."
        Me.col_total_venta.ColumnEdit = Me.rps_total_venta
        Me.col_total_venta.FieldName = "total_venta"
        Me.col_total_venta.Name = "col_total_venta"
        Me.col_total_venta.Visible = True
        Me.col_total_venta.VisibleIndex = 2
        Me.col_total_venta.Width = 107
        '
        'col_pagado
        '
        Me.col_pagado.AppearanceCell.Options.UseTextOptions = True
        Me.col_pagado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_pagado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pagado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_pagado.Caption = "Total pagado"
        Me.col_pagado.ColumnEdit = Me.rps_total_pagado
        Me.col_pagado.FieldName = "total_pagado"
        Me.col_pagado.Name = "col_pagado"
        Me.col_pagado.Visible = True
        Me.col_pagado.VisibleIndex = 3
        Me.col_pagado.Width = 108
        '
        'col_monto
        '
        Me.col_monto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_monto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_monto.AppearanceCell.Options.UseBackColor = True
        Me.col_monto.AppearanceCell.Options.UseFont = True
        Me.col_monto.Caption = "Monto a pagar"
        Me.col_monto.ColumnEdit = Me.rps_monto
        Me.col_monto.FieldName = "monto_pagar"
        Me.col_monto.Name = "col_monto"
        Me.col_monto.Visible = True
        Me.col_monto.VisibleIndex = 4
        Me.col_monto.Width = 106
        '
        'rps_monto
        '
        Me.rps_monto.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rps_monto.AppearanceFocused.Options.UseBackColor = True
        Me.rps_monto.AutoHeight = False
        Me.rps_monto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_monto.Mask.EditMask = "n0"
        Me.rps_monto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_monto.Mask.UseMaskAsDisplayFormat = True
        Me.rps_monto.Name = "rps_monto"
        Me.rps_monto.NullText = "0"
        '
        'col_saldo
        '
        Me.col_saldo.AppearanceCell.Options.UseTextOptions = True
        Me.col_saldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_saldo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_saldo.Caption = "Saldo"
        Me.col_saldo.ColumnEdit = Me.rps_saldo
        Me.col_saldo.FieldName = "saldo"
        Me.col_saldo.Name = "col_saldo"
        Me.col_saldo.Visible = True
        Me.col_saldo.VisibleIndex = 5
        Me.col_saldo.Width = 82
        '
        'col_pagar
        '
        Me.col_pagar.AppearanceCell.Options.UseTextOptions = True
        Me.col_pagar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pagar.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pagar.Caption = "Pagar?"
        Me.col_pagar.ColumnEdit = Me.rps_pagar
        Me.col_pagar.FieldName = "pagar"
        Me.col_pagar.Name = "col_pagar"
        Me.col_pagar.Visible = True
        Me.col_pagar.VisibleIndex = 6
        Me.col_pagar.Width = 86
        '
        'frm_pago_facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 501)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_pago_facturas"
        Me.Text = "Cobro de facturas"
        CType(Me.rps_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_total_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_total_pagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_saldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_pagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txt_vuelto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_importe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_pagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As Label
    Friend WithEvents gridComprobantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents con_id_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_comprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pagado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pagar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cld_fecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txt_cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_clientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_calendar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total_pagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_forma_pago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_formas_pago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents rps_comprobante As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_total_venta As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_total_pagado As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_saldo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_pagar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_vuelto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_importe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_monto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
