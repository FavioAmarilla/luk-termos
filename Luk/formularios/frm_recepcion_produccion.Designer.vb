<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_recepcion_produccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recepcion_produccion))
        Me.txt_id_transaccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_id_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_costo_total_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_costo_unit_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_cantidad_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_movim_items_stock = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_movim_item_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unit_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_total_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_costeo_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_controlar_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_transaccion = New DevExpress.XtraEditors.TextEdit()
        Me.btn_pedidos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_transaccion_art = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_transaccion_art = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_id_transaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo_total_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo_unit_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_movim_items_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_transaccion_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_transaccion_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_transaccion
        '
        Me.txt_id_transaccion.Location = New System.Drawing.Point(94, 122)
        Me.txt_id_transaccion.Name = "txt_id_transaccion"
        Me.txt_id_transaccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_transaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_transaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_transaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_transaccion.Properties.ReadOnly = True
        Me.txt_id_transaccion.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_transaccion.TabIndex = 31
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(30, 126)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 30
        Me.LabelControl5.Text = "Transaccion:"
        '
        'txt_id_pedido
        '
        Me.txt_id_pedido.Location = New System.Drawing.Point(94, 39)
        Me.txt_id_pedido.Name = "txt_id_pedido"
        Me.txt_id_pedido.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_pedido.Properties.ReadOnly = True
        Me.txt_id_pedido.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_pedido.TabIndex = 29
        '
        'txt_id_articulo
        '
        Me.txt_id_articulo.Location = New System.Drawing.Point(93, 39)
        Me.txt_id_articulo.Name = "txt_id_articulo"
        Me.txt_id_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_articulo.Properties.ReadOnly = True
        Me.txt_id_articulo.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_articulo.TabIndex = 27
        '
        'txt_costo_total_articulo
        '
        Me.txt_costo_total_articulo.Location = New System.Drawing.Point(93, 121)
        Me.txt_costo_total_articulo.Name = "txt_costo_total_articulo"
        Me.txt_costo_total_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_costo_total_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_costo_total_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_costo_total_articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_costo_total_articulo.Properties.Mask.EditMask = "n0"
        Me.txt_costo_total_articulo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo_total_articulo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_costo_total_articulo.Properties.ReadOnly = True
        Me.txt_costo_total_articulo.Size = New System.Drawing.Size(256, 22)
        Me.txt_costo_total_articulo.TabIndex = 10
        '
        'txt_costo_unit_articulo
        '
        Me.txt_costo_unit_articulo.Location = New System.Drawing.Point(93, 94)
        Me.txt_costo_unit_articulo.Name = "txt_costo_unit_articulo"
        Me.txt_costo_unit_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_costo_unit_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_costo_unit_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_costo_unit_articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_costo_unit_articulo.Properties.Mask.EditMask = "n0"
        Me.txt_costo_unit_articulo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo_unit_articulo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_costo_unit_articulo.Properties.ReadOnly = True
        Me.txt_costo_unit_articulo.Size = New System.Drawing.Size(256, 22)
        Me.txt_costo_unit_articulo.TabIndex = 9
        '
        'txt_cantidad_articulo
        '
        Me.txt_cantidad_articulo.Location = New System.Drawing.Point(93, 65)
        Me.txt_cantidad_articulo.Name = "txt_cantidad_articulo"
        Me.txt_cantidad_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cantidad_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cantidad_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cantidad_articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cantidad_articulo.Properties.ReadOnly = True
        Me.txt_cantidad_articulo.Size = New System.Drawing.Size(256, 22)
        Me.txt_cantidad_articulo.TabIndex = 6
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(135, 39)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_articulo.Properties.ReadOnly = True
        Me.txt_articulo.Size = New System.Drawing.Size(214, 22)
        Me.txt_articulo.TabIndex = 5
        '
        'txt_nro_pedido
        '
        Me.txt_nro_pedido.Location = New System.Drawing.Point(135, 39)
        Me.txt_nro_pedido.Name = "txt_nro_pedido"
        Me.txt_nro_pedido.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_nro_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_pedido.Properties.ReadOnly = True
        Me.txt_nro_pedido.Size = New System.Drawing.Size(188, 22)
        Me.txt_nro_pedido.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(94, 93)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(256, 22)
        Me.txt_fecha.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(31, 125)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl10.TabIndex = 14
        Me.LabelControl10.Text = "Costo Total:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(32, 98)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl12.TabIndex = 12
        Me.LabelControl12.Text = "Costo Unit.:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(43, 68)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Cantidad:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(50, 43)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Articulo:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(55, 42)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Pedido:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(58, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Fecha:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Sucursal:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(61, 123)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(61, 80)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 0
        Me.btn_confirmar.Text = "Confirmar"
        '
        'grid_movim_items_stock
        '
        Me.grid_movim_items_stock.Location = New System.Drawing.Point(37, 231)
        Me.grid_movim_items_stock.MainView = Me.GridView1
        Me.grid_movim_items_stock.Name = "grid_movim_items_stock"
        Me.grid_movim_items_stock.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.grid_movim_items_stock.Size = New System.Drawing.Size(1015, 313)
        Me.grid_movim_items_stock.TabIndex = 3
        Me.grid_movim_items_stock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_movim_item_stock, Me.col_id_material, Me.col_material, Me.col_cantidad_unit, Me.col_cantidad_total, Me.col_costo_unit_material, Me.col_costo_total_material, Me.col_id_costeo_item, Me.col_controlar_stock, Me.id_proveedor, Me.col_precio_venta})
        Me.GridView1.GridControl = Me.grid_movim_items_stock
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_movim_item_stock
        '
        Me.col_id_movim_item_stock.Caption = "Id Movim Item Stock"
        Me.col_id_movim_item_stock.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_id_movim_item_stock.FieldName = "id_movim_item_stock"
        Me.col_id_movim_item_stock.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_id_movim_item_stock.Name = "col_id_movim_item_stock"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'col_id_material
        '
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_id_material.Name = "col_id_material"
        '
        'col_material
        '
        Me.col_material.Caption = "Material"
        Me.col_material.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_material.FieldName = "material"
        Me.col_material.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_material.Name = "col_material"
        Me.col_material.OptionsColumn.ReadOnly = True
        Me.col_material.Visible = True
        Me.col_material.VisibleIndex = 0
        Me.col_material.Width = 364
        '
        'col_cantidad_unit
        '
        Me.col_cantidad_unit.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad_unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad_unit.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad_unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad_unit.Caption = "Cantidad Unit."
        Me.col_cantidad_unit.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_cantidad_unit.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad_unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad_unit.FieldName = "cantidad_unit"
        Me.col_cantidad_unit.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_cantidad_unit.Name = "col_cantidad_unit"
        Me.col_cantidad_unit.OptionsColumn.ReadOnly = True
        Me.col_cantidad_unit.Visible = True
        Me.col_cantidad_unit.VisibleIndex = 1
        Me.col_cantidad_unit.Width = 135
        '
        'col_cantidad_total
        '
        Me.col_cantidad_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cantidad_total.Caption = "Cantidad Total"
        Me.col_cantidad_total.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_cantidad_total.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad_total.FieldName = "cantidad_total"
        Me.col_cantidad_total.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_cantidad_total.Name = "col_cantidad_total"
        Me.col_cantidad_total.OptionsColumn.ReadOnly = True
        Me.col_cantidad_total.Visible = True
        Me.col_cantidad_total.VisibleIndex = 2
        Me.col_cantidad_total.Width = 135
        '
        'col_costo_unit_material
        '
        Me.col_costo_unit_material.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unit_material.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_unit_material.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unit_material.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_unit_material.Caption = "Costo Unit."
        Me.col_costo_unit_material.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_costo_unit_material.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unit_material.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unit_material.FieldName = "costo_unit_material"
        Me.col_costo_unit_material.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_costo_unit_material.Name = "col_costo_unit_material"
        Me.col_costo_unit_material.OptionsColumn.ReadOnly = True
        Me.col_costo_unit_material.Visible = True
        Me.col_costo_unit_material.VisibleIndex = 3
        Me.col_costo_unit_material.Width = 135
        '
        'col_costo_total_material
        '
        Me.col_costo_total_material.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total_material.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_total_material.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total_material.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_total_material.Caption = "Costo Total"
        Me.col_costo_total_material.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_costo_total_material.DisplayFormat.FormatString = "#,#"
        Me.col_costo_total_material.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_total_material.FieldName = "costo_total_material"
        Me.col_costo_total_material.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_costo_total_material.Name = "col_costo_total_material"
        Me.col_costo_total_material.OptionsColumn.ReadOnly = True
        Me.col_costo_total_material.Visible = True
        Me.col_costo_total_material.VisibleIndex = 4
        Me.col_costo_total_material.Width = 144
        '
        'col_id_costeo_item
        '
        Me.col_id_costeo_item.Caption = "Id Costeo Item"
        Me.col_id_costeo_item.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_id_costeo_item.FieldName = "id_costeo_item"
        Me.col_id_costeo_item.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_id_costeo_item.Name = "col_id_costeo_item"
        '
        'col_controlar_stock
        '
        Me.col_controlar_stock.Caption = "controlar_stock"
        Me.col_controlar_stock.FieldName = "controlar_stock"
        Me.col_controlar_stock.Name = "col_controlar_stock"
        '
        'id_proveedor
        '
        Me.id_proveedor.Caption = "id_proveedor"
        Me.id_proveedor.FieldName = "id_proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        '
        'col_precio_venta
        '
        Me.col_precio_venta.Caption = "Precio Venta"
        Me.col_precio_venta.FieldName = "precio_venta"
        Me.col_precio_venta.Name = "col_precio_venta"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_transaccion)
        Me.GroupBox1.Controls.Add(Me.btn_pedidos)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_transaccion)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txt_id_pedido)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txt_nro_pedido)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Recepcion"
        '
        'txt_transaccion
        '
        Me.txt_transaccion.Location = New System.Drawing.Point(135, 122)
        Me.txt_transaccion.Name = "txt_transaccion"
        Me.txt_transaccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_transaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_transaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_transaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_transaccion.Properties.ReadOnly = True
        Me.txt_transaccion.Size = New System.Drawing.Size(215, 22)
        Me.txt_transaccion.TabIndex = 43
        '
        'btn_pedidos
        '
        Me.btn_pedidos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_pedidos.Location = New System.Drawing.Point(325, 39)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(25, 22)
        Me.btn_pedidos.TabIndex = 40
        Me.btn_pedidos.Text = "+"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(325, 65)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_sucursal.TabIndex = 36
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(94, 66)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_sucursal.TabIndex = 35
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(135, 66)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(188, 22)
        Me.txt_sucursal.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_transaccion_art)
        Me.GroupBox2.Controls.Add(Me.txt_id_transaccion_art)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.txt_articulo)
        Me.GroupBox2.Controls.Add(Me.LabelControl10)
        Me.GroupBox2.Controls.Add(Me.LabelControl12)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad_articulo)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Controls.Add(Me.txt_costo_unit_articulo)
        Me.GroupBox2.Controls.Add(Me.txt_costo_total_articulo)
        Me.GroupBox2.Controls.Add(Me.txt_id_articulo)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de Articulo"
        '
        'txt_transaccion_art
        '
        Me.txt_transaccion_art.Location = New System.Drawing.Point(134, 149)
        Me.txt_transaccion_art.Name = "txt_transaccion_art"
        Me.txt_transaccion_art.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_transaccion_art.Properties.Appearance.Options.UseBackColor = True
        Me.txt_transaccion_art.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_transaccion_art.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_transaccion_art.Properties.ReadOnly = True
        Me.txt_transaccion_art.Size = New System.Drawing.Size(215, 22)
        Me.txt_transaccion_art.TabIndex = 46
        '
        'txt_id_transaccion_art
        '
        Me.txt_id_transaccion_art.Location = New System.Drawing.Point(93, 149)
        Me.txt_id_transaccion_art.Name = "txt_id_transaccion_art"
        Me.txt_id_transaccion_art.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_transaccion_art.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_transaccion_art.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_transaccion_art.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_transaccion_art.Properties.ReadOnly = True
        Me.txt_id_transaccion_art.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_transaccion_art.TabIndex = 45
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 153)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Transaccion:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_nuevo)
        Me.GroupBox3.Controls.Add(Me.btn_cancelar)
        Me.GroupBox3.Controls.Add(Me.btn_confirmar)
        Me.GroupBox3.Location = New System.Drawing.Point(833, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 187)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(61, 39)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(685, 520)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 84
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_recepcion_produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 567)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_movim_items_stock)
        Me.Name = "frm_recepcion_produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Recepcion de Produccion>>"
        CType(Me.txt_id_transaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo_total_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo_unit_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_movim_items_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_transaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_transaccion_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_transaccion_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_movim_items_stock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_costo_total_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_costo_unit_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cantidad_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id_movim_item_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unit_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_total_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_costeo_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_id_transaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_pedidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_transaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_controlar_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_transaccion_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_transaccion_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
End Class
