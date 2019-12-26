<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_stock_articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stock_articulos))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_id_item = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_item = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_unit_actual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_costo_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_precio_unit_actual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_precio_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpt_codigo_barras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_items = New DevExpress.XtraGrid.GridControl()
        Me.txt_id_transaccion = New DevExpress.XtraEditors.TextEdit()
        Me.btn_transacciones = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_transaccion = New DevExpress.XtraEditors.TextEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbo_tipo_stock = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_combo = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_quitar_empleado = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_id_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_costo_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_precio_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpt_codigo_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_transaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_tipo_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_item, Me.col_item, Me.col_cantidad, Me.col_costo_unit_actual, Me.col_precio_unit_actual, Me.col_codigo_barras, Me.id_proveedor})
        Me.GridView1.GridControl = Me.grid_items
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_item
        '
        Me.col_id_item.Caption = "Id item"
        Me.col_id_item.ColumnEdit = Me.rpt_id_item
        Me.col_id_item.FieldName = "id_item"
        Me.col_id_item.Name = "col_id_item"
        '
        'rpt_id_item
        '
        Me.rpt_id_item.AutoHeight = False
        Me.rpt_id_item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_id_item.Name = "rpt_id_item"
        Me.rpt_id_item.ReadOnly = True
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.rpt_item
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 335
        '
        'rpt_item
        '
        Me.rpt_item.AutoHeight = False
        Me.rpt_item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_item.Name = "rpt_item"
        Me.rpt_item.ReadOnly = True
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rpt_cantidad
        Me.col_cantidad.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 4
        Me.col_cantidad.Width = 106
        '
        'rpt_cantidad
        '
        Me.rpt_cantidad.AutoHeight = False
        Me.rpt_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_cantidad.DisplayFormat.FormatString = "0.00"
        Me.rpt_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpt_cantidad.Name = "rpt_cantidad"
        '
        'col_costo_unit_actual
        '
        Me.col_costo_unit_actual.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unit_actual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unit_actual.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unit_actual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unit_actual.Caption = "Costo Unit."
        Me.col_costo_unit_actual.ColumnEdit = Me.rpt_costo_unitario
        Me.col_costo_unit_actual.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unit_actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unit_actual.FieldName = "costo_unitario"
        Me.col_costo_unit_actual.Name = "col_costo_unit_actual"
        Me.col_costo_unit_actual.Visible = True
        Me.col_costo_unit_actual.VisibleIndex = 2
        Me.col_costo_unit_actual.Width = 100
        '
        'rpt_costo_unitario
        '
        Me.rpt_costo_unitario.AutoHeight = False
        Me.rpt_costo_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_costo_unitario.Mask.EditMask = "n0"
        Me.rpt_costo_unitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpt_costo_unitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpt_costo_unitario.Name = "rpt_costo_unitario"
        Me.rpt_costo_unitario.ReadOnly = True
        '
        'col_precio_unit_actual
        '
        Me.col_precio_unit_actual.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_unit_actual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unit_actual.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_unit_actual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unit_actual.Caption = "Precio Unit."
        Me.col_precio_unit_actual.ColumnEdit = Me.rpt_precio_unitario
        Me.col_precio_unit_actual.DisplayFormat.FormatString = "#,#"
        Me.col_precio_unit_actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_unit_actual.FieldName = "precio_unitario"
        Me.col_precio_unit_actual.Name = "col_precio_unit_actual"
        Me.col_precio_unit_actual.Visible = True
        Me.col_precio_unit_actual.VisibleIndex = 3
        Me.col_precio_unit_actual.Width = 100
        '
        'rpt_precio_unitario
        '
        Me.rpt_precio_unitario.AutoHeight = False
        Me.rpt_precio_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_precio_unitario.Mask.EditMask = "n0"
        Me.rpt_precio_unitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpt_precio_unitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpt_precio_unitario.Name = "rpt_precio_unitario"
        Me.rpt_precio_unitario.ReadOnly = True
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.Caption = "Codigo de Barras"
        Me.col_codigo_barras.ColumnEdit = Me.rpt_codigo_barras
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 120
        '
        'rpt_codigo_barras
        '
        Me.rpt_codigo_barras.AutoHeight = False
        Me.rpt_codigo_barras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpt_codigo_barras.Name = "rpt_codigo_barras"
        '
        'id_proveedor
        '
        Me.id_proveedor.Caption = "id_proveedor"
        Me.id_proveedor.ColumnEdit = Me.rpt_costo_unitario
        Me.id_proveedor.FieldName = "id_proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        '
        'grid_items
        '
        Me.grid_items.Location = New System.Drawing.Point(24, 51)
        Me.grid_items.MainView = Me.GridView1
        Me.grid_items.Name = "grid_items"
        Me.grid_items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpt_id_item, Me.rpt_item, Me.rpt_codigo_barras, Me.rpt_cantidad, Me.rpt_costo_unitario, Me.rpt_precio_unitario})
        Me.grid_items.Size = New System.Drawing.Size(862, 279)
        Me.grid_items.TabIndex = 1
        Me.grid_items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'txt_id_transaccion
        '
        Me.txt_id_transaccion.Location = New System.Drawing.Point(245, 109)
        Me.txt_id_transaccion.Name = "txt_id_transaccion"
        Me.txt_id_transaccion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_transaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_transaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_transaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_transaccion.Properties.ReadOnly = True
        Me.txt_id_transaccion.Size = New System.Drawing.Size(43, 22)
        Me.txt_id_transaccion.TabIndex = 78
        '
        'btn_transacciones
        '
        Me.btn_transacciones.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_transacciones.Location = New System.Drawing.Point(467, 107)
        Me.btn_transacciones.Name = "btn_transacciones"
        Me.btn_transacciones.Size = New System.Drawing.Size(34, 23)
        Me.btn_transacciones.TabIndex = 78
        Me.btn_transacciones.Text = "+"
        '
        'txt_transaccion
        '
        Me.txt_transaccion.Location = New System.Drawing.Point(289, 108)
        Me.txt_transaccion.Name = "txt_transaccion"
        Me.txt_transaccion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_transaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_transaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_transaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_transaccion.Properties.ReadOnly = True
        Me.txt_transaccion.Size = New System.Drawing.Size(177, 22)
        Me.txt_transaccion.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(174, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Transaccion:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(619, 60)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(619, 104)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        '
        'cbo_tipo_stock
        '
        Me.cbo_tipo_stock.EditValue = ""
        Me.cbo_tipo_stock.Location = New System.Drawing.Point(245, 56)
        Me.cbo_tipo_stock.Name = "cbo_tipo_stock"
        Me.cbo_tipo_stock.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_tipo_stock.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_tipo_stock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_stock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_stock.Properties.ImmediatePopup = True
        Me.cbo_tipo_stock.Properties.Items.AddRange(New Object() {"ARTICULOS", "MATERIA PRIMA"})
        Me.cbo_tipo_stock.Size = New System.Drawing.Size(256, 22)
        Me.cbo_tipo_stock.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_nuevo)
        Me.PanelControl1.Controls.Add(Me.txt_fecha)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btn_buscar_sucursal)
        Me.PanelControl1.Controls.Add(Me.txt_id_sucursal)
        Me.PanelControl1.Controls.Add(Me.txt_sucursal)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.btn_cancelar)
        Me.PanelControl1.Controls.Add(Me.btn_confirmar)
        Me.PanelControl1.Controls.Add(Me.txt_transaccion)
        Me.PanelControl1.Controls.Add(Me.lbl_combo)
        Me.PanelControl1.Controls.Add(Me.cbo_tipo_stock)
        Me.PanelControl1.Controls.Add(Me.txt_id_transaccion)
        Me.PanelControl1.Controls.Add(Me.Label17)
        Me.PanelControl1.Controls.Add(Me.btn_transacciones)
        Me.PanelControl1.Location = New System.Drawing.Point(18, 18)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(910, 161)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(619, 21)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(245, 30)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(256, 22)
        Me.txt_fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Fecha:"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(467, 81)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(34, 22)
        Me.btn_buscar_sucursal.TabIndex = 84
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(245, 82)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(43, 22)
        Me.txt_id_sucursal.TabIndex = 82
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(289, 82)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(177, 22)
        Me.txt_sucursal.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(198, 86)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 81
        Me.LabelControl4.Text = "Sucursal:"
        '
        'lbl_combo
        '
        Me.lbl_combo.Location = New System.Drawing.Point(174, 59)
        Me.lbl_combo.Name = "lbl_combo"
        Me.lbl_combo.Size = New System.Drawing.Size(68, 13)
        Me.lbl_combo.TabIndex = 5
        Me.lbl_combo.Text = "Tipo de Stock:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_total_registros)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.btn_quitar_empleado)
        Me.GroupBox1.Controls.Add(Me.grid_items)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 353)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items del Movimiento"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(515, 305)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(730, 22)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "Agregar"
        '
        'btn_quitar_empleado
        '
        Me.btn_quitar_empleado.Location = New System.Drawing.Point(811, 22)
        Me.btn_quitar_empleado.Name = "btn_quitar_empleado"
        Me.btn_quitar_empleado.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar_empleado.TabIndex = 2
        Me.btn_quitar_empleado.Text = "Quitar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl1.TabIndex = 86
        Me.LabelControl1.Text = "Detalles del Movimiento"
        '
        'frm_stock_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 532)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_stock_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Ajuste de Stock>>"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_id_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_costo_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_precio_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpt_codigo_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_transaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_tipo_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_items As DevExpress.XtraGrid.GridControl
    Friend WithEvents cbo_tipo_stock As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_combo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unit_actual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_unit_actual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_transaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_transaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_transacciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rpt_id_item As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rpt_item As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpt_codigo_barras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpt_costo_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpt_precio_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_quitar_empleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
End Class
