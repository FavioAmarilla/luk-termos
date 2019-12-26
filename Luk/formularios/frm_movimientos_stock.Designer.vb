<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_movimientos_stock
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
        Me.grid_movimientos_stock = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_caracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_transaccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_precio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_decimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_accion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_transaccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.txt_precio = New DevExpress.XtraEditors.TextEdit()
        Me.txt_costo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_cantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_item = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fecha_movimiento = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_accion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_tipo_movimiento = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_nro_venta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nro_compra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nro_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cld_fecha_movim = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_movimientos_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_caracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_decimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_accion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_precio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_accion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_tipo_movimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_nro_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_compra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha_movim.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_movimientos_stock
        '
        Me.grid_movimientos_stock.Location = New System.Drawing.Point(275, 26)
        Me.grid_movimientos_stock.MainView = Me.GridView1
        Me.grid_movimientos_stock.Name = "grid_movimientos_stock"
        Me.grid_movimientos_stock.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_caracteres, Me.rps_miles, Me.rps_decimales, Me.rps_fecha})
        Me.grid_movimientos_stock.Size = New System.Drawing.Size(803, 326)
        Me.grid_movimientos_stock.TabIndex = 2
        Me.grid_movimientos_stock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.Options.UseBorderColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.BorderColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.Options.UseBorderColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_item, Me.col_transaccion, Me.col_costo, Me.col_precio, Me.col_fecha, Me.col_cantidad, Me.col_pedido, Me.col_venta, Me.col_compra})
        Me.GridView1.GridControl = Me.grid_movimientos_stock
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.rps_caracteres
        Me.col_item.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 207
        '
        'rps_caracteres
        '
        Me.rps_caracteres.AutoHeight = False
        Me.rps_caracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_caracteres.Name = "rps_caracteres"
        '
        'col_transaccion
        '
        Me.col_transaccion.Caption = "Transaccion"
        Me.col_transaccion.ColumnEdit = Me.rps_caracteres
        Me.col_transaccion.FieldName = "transaccion"
        Me.col_transaccion.Name = "col_transaccion"
        Me.col_transaccion.Visible = True
        Me.col_transaccion.VisibleIndex = 2
        Me.col_transaccion.Width = 207
        '
        'col_costo
        '
        Me.col_costo.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo.Caption = "Costo Unit."
        Me.col_costo.ColumnEdit = Me.rps_miles
        Me.col_costo.DisplayFormat.FormatString = "#,#"
        Me.col_costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo.FieldName = "costo"
        Me.col_costo.Name = "col_costo"
        Me.col_costo.Visible = True
        Me.col_costo.VisibleIndex = 4
        Me.col_costo.Width = 102
        '
        'rps_miles
        '
        Me.rps_miles.AutoHeight = False
        Me.rps_miles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_miles.DisplayFormat.FormatString = "#,#"
        Me.rps_miles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_miles.Mask.EditMask = "n0"
        Me.rps_miles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_miles.Mask.UseMaskAsDisplayFormat = True
        Me.rps_miles.Name = "rps_miles"
        '
        'col_precio
        '
        Me.col_precio.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio.Caption = "Precio Venta"
        Me.col_precio.ColumnEdit = Me.rps_miles
        Me.col_precio.DisplayFormat.FormatString = "#,#"
        Me.col_precio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio.FieldName = "precio"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.Visible = True
        Me.col_precio.VisibleIndex = 5
        Me.col_precio.Width = 96
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "Fecha Movim."
        Me.col_fecha.ColumnEdit = Me.rps_fecha
        Me.col_fecha.FieldName = "fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 0
        Me.col_fecha.Width = 94
        '
        'rps_fecha
        '
        Me.rps_fecha.AutoHeight = False
        Me.rps_fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_fecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rps_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rps_fecha.Mask.EditMask = "d"
        Me.rps_fecha.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.rps_fecha.Mask.UseMaskAsDisplayFormat = True
        Me.rps_fecha.Name = "rps_fecha"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rps_decimales
        Me.col_cantidad.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 3
        Me.col_cantidad.Width = 79
        '
        'rps_decimales
        '
        Me.rps_decimales.AutoHeight = False
        Me.rps_decimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_decimales.DisplayFormat.FormatString = "0.00"
        Me.rps_decimales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_decimales.Mask.EditMask = "n"
        Me.rps_decimales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_decimales.Mask.UseMaskAsDisplayFormat = True
        Me.rps_decimales.Name = "rps_decimales"
        '
        'col_pedido
        '
        Me.col_pedido.Caption = "pedido"
        Me.col_pedido.ColumnEdit = Me.rps_caracteres
        Me.col_pedido.FieldName = "pedido"
        Me.col_pedido.Name = "col_pedido"
        '
        'col_venta
        '
        Me.col_venta.Caption = "venta"
        Me.col_venta.ColumnEdit = Me.rps_caracteres
        Me.col_venta.FieldName = "venta"
        Me.col_venta.Name = "col_venta"
        '
        'col_compra
        '
        Me.col_compra.Caption = "compra"
        Me.col_compra.ColumnEdit = Me.rps_caracteres
        Me.col_compra.FieldName = "compra"
        Me.col_compra.Name = "col_compra"
        '
        'txt_accion
        '
        Me.txt_accion.Location = New System.Drawing.Point(473, 93)
        Me.txt_accion.Name = "txt_accion"
        Me.txt_accion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_accion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_accion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_accion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_accion.Properties.ReadOnly = True
        Me.txt_accion.Size = New System.Drawing.Size(227, 22)
        Me.txt_accion.TabIndex = 6
        '
        'txt_transaccion
        '
        Me.txt_transaccion.Location = New System.Drawing.Point(473, 66)
        Me.txt_transaccion.Name = "txt_transaccion"
        Me.txt_transaccion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_transaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_transaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_transaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_transaccion.Properties.ReadOnly = True
        Me.txt_transaccion.Size = New System.Drawing.Size(227, 22)
        Me.txt_transaccion.TabIndex = 5
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(473, 38)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(227, 22)
        Me.txt_fecha.TabIndex = 4
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(88, 122)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_precio.Properties.Appearance.Options.UseBackColor = True
        Me.txt_precio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_precio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_precio.Properties.Mask.EditMask = "n0"
        Me.txt_precio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_precio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_precio.Properties.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(227, 22)
        Me.txt_precio.TabIndex = 3
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(88, 94)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_costo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_costo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_costo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_costo.Properties.Mask.EditMask = "n0"
        Me.txt_costo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_costo.Properties.ReadOnly = True
        Me.txt_costo.Size = New System.Drawing.Size(227, 22)
        Me.txt_costo.TabIndex = 2
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(88, 66)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cantidad.Properties.ReadOnly = True
        Me.txt_cantidad.Size = New System.Drawing.Size(227, 22)
        Me.txt_cantidad.TabIndex = 1
        '
        'txt_item
        '
        Me.txt_item.Location = New System.Drawing.Point(88, 38)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_item.Properties.Appearance.Options.UseBackColor = True
        Me.txt_item.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_item.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_item.Properties.ReadOnly = True
        Me.txt_item.Size = New System.Drawing.Size(227, 22)
        Me.txt_item.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(432, 96)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Accion:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(406, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "Transaccion:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(377, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Fecha Movimiento:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(23, 125)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Precio Unit.:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 97)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Costo Unit.:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(35, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Cantidad:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(56, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Item:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(14, 255)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(105, 30)
        Me.btn_consultar.TabIndex = 5
        Me.btn_consultar.Text = "Consultar"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(22, 180)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Fecha Movim."
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(22, 128)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "Accion"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 83)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Tipo de Movimiento"
        '
        'txt_fecha_movimiento
        '
        Me.txt_fecha_movimiento.Location = New System.Drawing.Point(22, 195)
        Me.txt_fecha_movimiento.Mask = "00/00/0000"
        Me.txt_fecha_movimiento.Name = "txt_fecha_movimiento"
        Me.txt_fecha_movimiento.Size = New System.Drawing.Size(172, 21)
        Me.txt_fecha_movimiento.TabIndex = 4
        Me.txt_fecha_movimiento.ValidatingType = GetType(Date)
        '
        'cbo_accion
        '
        Me.cbo_accion.Location = New System.Drawing.Point(22, 143)
        Me.cbo_accion.Name = "cbo_accion"
        Me.cbo_accion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_accion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_accion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_accion.Properties.ImmediatePopup = True
        Me.cbo_accion.Properties.Items.AddRange(New Object() {"TODOS", "EGRESO", "INGRESO"})
        Me.cbo_accion.Size = New System.Drawing.Size(201, 22)
        Me.cbo_accion.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_desde)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_movimiento)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.cbo_accion)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_movimiento)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(125, 255)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(105, 30)
        Me.btn_imprimir.TabIndex = 8
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_desde
        '
        Me.btn_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_desde.Location = New System.Drawing.Point(200, 196)
        Me.btn_desde.Name = "btn_desde"
        Me.btn_desde.Size = New System.Drawing.Size(23, 23)
        Me.btn_desde.TabIndex = 58
        Me.btn_desde.TabStop = False
        Me.btn_desde.Text = "+"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(193, 51)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(30, 23)
        Me.btn_buscar_sucursal.TabIndex = 1
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(22, 52)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(170, 22)
        Me.txt_sucursal.TabIndex = 0
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(22, 36)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl11.TabIndex = 7
        Me.LabelControl11.Text = "Sucursal"
        '
        'cbo_tipo_movimiento
        '
        Me.cbo_tipo_movimiento.Location = New System.Drawing.Point(22, 99)
        Me.cbo_tipo_movimiento.Name = "cbo_tipo_movimiento"
        Me.cbo_tipo_movimiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_tipo_movimiento.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_tipo_movimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_movimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_movimiento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_tipo_movimiento.Properties.ImmediatePopup = True
        Me.cbo_tipo_movimiento.Properties.Items.AddRange(New Object() {"ARTICULOS", "MATERIA PRIMA"})
        Me.cbo_tipo_movimiento.Size = New System.Drawing.Size(201, 22)
        Me.cbo_tipo_movimiento.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_accion)
        Me.GroupBox2.Controls.Add(Me.txt_item)
        Me.GroupBox2.Controls.Add(Me.txt_transaccion)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.txt_fecha)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.txt_costo)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.LabelControl8)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 162)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del Movimiento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_nro_venta)
        Me.GroupBox3.Controls.Add(Me.LabelControl14)
        Me.GroupBox3.Controls.Add(Me.txt_nro_compra)
        Me.GroupBox3.Controls.Add(Me.LabelControl13)
        Me.GroupBox3.Controls.Add(Me.txt_nro_pedido)
        Me.GroupBox3.Controls.Add(Me.LabelControl12)
        Me.GroupBox3.Location = New System.Drawing.Point(746, 358)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 162)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referencias"
        '
        'txt_nro_venta
        '
        Me.txt_nro_venta.Location = New System.Drawing.Point(94, 92)
        Me.txt_nro_venta.Name = "txt_nro_venta"
        Me.txt_nro_venta.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_nro_venta.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_venta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_venta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_venta.Properties.ReadOnly = True
        Me.txt_nro_venta.Size = New System.Drawing.Size(227, 22)
        Me.txt_nro_venta.TabIndex = 11
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(36, 96)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl14.TabIndex = 12
        Me.LabelControl14.Text = "Nro. Venta:"
        '
        'txt_nro_compra
        '
        Me.txt_nro_compra.Location = New System.Drawing.Point(94, 65)
        Me.txt_nro_compra.Name = "txt_nro_compra"
        Me.txt_nro_compra.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_nro_compra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_compra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_compra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_compra.Properties.ReadOnly = True
        Me.txt_nro_compra.Size = New System.Drawing.Size(227, 22)
        Me.txt_nro_compra.TabIndex = 9
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 69)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl13.TabIndex = 10
        Me.LabelControl13.Text = "Nro. de Compra:"
        '
        'txt_nro_pedido
        '
        Me.txt_nro_pedido.Location = New System.Drawing.Point(94, 37)
        Me.txt_nro_pedido.Name = "txt_nro_pedido"
        Me.txt_nro_pedido.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_nro_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_pedido.Properties.ReadOnly = True
        Me.txt_nro_pedido.Size = New System.Drawing.Size(227, 22)
        Me.txt_nro_pedido.TabIndex = 7
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(17, 41)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl12.TabIndex = 8
        Me.LabelControl12.Text = "Nro. de Pedido:"
        '
        'cld_fecha_movim
        '
        Me.cld_fecha_movim.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha_movim.Location = New System.Drawing.Point(225, 222)
        Me.cld_fecha_movim.Name = "cld_fecha_movim"
        Me.cld_fecha_movim.Size = New System.Drawing.Size(250, 227)
        Me.cld_fecha_movim.TabIndex = 59
        Me.cld_fecha_movim.Visible = False
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(711, 327)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 83
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_movimientos_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 548)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_fecha_movim)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_movimientos_stock)
        Me.Name = "frm_movimientos_stock"
        Me.Text = "<<Movimientos de Stock>>"
        CType(Me.grid_movimientos_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_caracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_decimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_accion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_precio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_accion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_tipo_movimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_nro_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_compra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha_movim.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_movimientos_stock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transaccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fecha_movimiento As MaskedTextBox
    Friend WithEvents cbo_accion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_accion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_transaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_precio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_costo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_item As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbo_tipo_movimiento As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents col_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_nro_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nro_compra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nro_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cld_fecha_movim As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rps_caracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_decimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
