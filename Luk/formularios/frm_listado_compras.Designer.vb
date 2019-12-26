<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_compras))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grid_compras = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_nro_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nro_factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tipo_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_relacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_gravadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_items_compra = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_nueva_cons = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_proveedores = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.cbo_tipos = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cal_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_registros_item = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_items_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_tipos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "0"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'grid_compras
        '
        Me.grid_compras.Location = New System.Drawing.Point(281, 22)
        Me.grid_compras.MainView = Me.GridView1
        Me.grid_compras.Name = "grid_compras"
        Me.grid_compras.Size = New System.Drawing.Size(900, 263)
        Me.grid_compras.TabIndex = 0
        Me.grid_compras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_nro_compra, Me.col_fecha, Me.col_total_compra, Me.col_nro_factura, Me.col_factura, Me.col_proveedor, Me.col_tipo_compra, Me.col_id_compra, Me.col_relacion, Me.col_gravadas, Me.col_impuesto})
        Me.GridView1.GridControl = Me.grid_compras
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_nro_compra
        '
        Me.col_nro_compra.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nro_compra.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nro_compra.Caption = "Nro. Compra"
        Me.col_nro_compra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_compra.FieldName = "nro_compra"
        Me.col_nro_compra.Name = "col_nro_compra"
        Me.col_nro_compra.Visible = True
        Me.col_nro_compra.VisibleIndex = 0
        Me.col_nro_compra.Width = 78
        '
        'col_fecha
        '
        Me.col_fecha.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fecha.Caption = "Fecha"
        Me.col_fecha.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_fecha.FieldName = "fecha_compra"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 1
        Me.col_fecha.Width = 86
        '
        'col_total_compra
        '
        Me.col_total_compra.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_compra.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_compra.Caption = "Total Compra"
        Me.col_total_compra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_total_compra.DisplayFormat.FormatString = "#,#"
        Me.col_total_compra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_compra.FieldName = "total_compra"
        Me.col_total_compra.Name = "col_total_compra"
        Me.col_total_compra.Visible = True
        Me.col_total_compra.VisibleIndex = 6
        Me.col_total_compra.Width = 88
        '
        'col_nro_factura
        '
        Me.col_nro_factura.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_factura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nro_factura.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_factura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nro_factura.Caption = "Nro. Factura"
        Me.col_nro_factura.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_factura.FieldName = "nro_factura"
        Me.col_nro_factura.Name = "col_nro_factura"
        Me.col_nro_factura.Visible = True
        Me.col_nro_factura.VisibleIndex = 7
        Me.col_nro_factura.Width = 103
        '
        'col_factura
        '
        Me.col_factura.AppearanceCell.Options.UseTextOptions = True
        Me.col_factura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_factura.AppearanceHeader.Options.UseTextOptions = True
        Me.col_factura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_factura.Caption = "Factura"
        Me.col_factura.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_factura.FieldName = "factura"
        Me.col_factura.Name = "col_factura"
        Me.col_factura.Visible = True
        Me.col_factura.VisibleIndex = 8
        Me.col_factura.Width = 63
        '
        'col_proveedor
        '
        Me.col_proveedor.AppearanceCell.Options.UseTextOptions = True
        Me.col_proveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_proveedor.AppearanceHeader.Options.UseTextOptions = True
        Me.col_proveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_proveedor.Caption = "Proveedor"
        Me.col_proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_proveedor.FieldName = "proveedor"
        Me.col_proveedor.Name = "col_proveedor"
        Me.col_proveedor.Visible = True
        Me.col_proveedor.VisibleIndex = 3
        Me.col_proveedor.Width = 183
        '
        'col_tipo_compra
        '
        Me.col_tipo_compra.AppearanceCell.Options.UseTextOptions = True
        Me.col_tipo_compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_tipo_compra.AppearanceHeader.Options.UseTextOptions = True
        Me.col_tipo_compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_tipo_compra.Caption = "Tipo Compra"
        Me.col_tipo_compra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_tipo_compra.FieldName = "tipo_compra"
        Me.col_tipo_compra.Name = "col_tipo_compra"
        Me.col_tipo_compra.Visible = True
        Me.col_tipo_compra.VisibleIndex = 2
        Me.col_tipo_compra.Width = 134
        '
        'col_id_compra
        '
        Me.col_id_compra.Caption = "Id Compra"
        Me.col_id_compra.FieldName = "id_compra"
        Me.col_id_compra.Name = "col_id_compra"
        '
        'col_relacion
        '
        Me.col_relacion.Caption = "Relacion"
        Me.col_relacion.FieldName = "relacion"
        Me.col_relacion.Name = "col_relacion"
        '
        'col_gravadas
        '
        Me.col_gravadas.AppearanceCell.Options.UseTextOptions = True
        Me.col_gravadas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_gravadas.AppearanceHeader.Options.UseTextOptions = True
        Me.col_gravadas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_gravadas.Caption = "Gravadas"
        Me.col_gravadas.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_gravadas.DisplayFormat.FormatString = "#,#"
        Me.col_gravadas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_gravadas.FieldName = "gravadas"
        Me.col_gravadas.Name = "col_gravadas"
        Me.col_gravadas.Visible = True
        Me.col_gravadas.VisibleIndex = 4
        Me.col_gravadas.Width = 76
        '
        'col_impuesto
        '
        Me.col_impuesto.AppearanceCell.Options.UseTextOptions = True
        Me.col_impuesto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_impuesto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_impuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_impuesto.Caption = "Impuestos"
        Me.col_impuesto.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_impuesto.DisplayFormat.FormatString = "#,#"
        Me.col_impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_impuesto.FieldName = "impuestos"
        Me.col_impuesto.Name = "col_impuesto"
        Me.col_impuesto.Visible = True
        Me.col_impuesto.VisibleIndex = 5
        Me.col_impuesto.Width = 71
        '
        'grid_items_compra
        '
        Me.grid_items_compra.Location = New System.Drawing.Point(281, 291)
        Me.grid_items_compra.MainView = Me.GridView2
        Me.grid_items_compra.Name = "grid_items_compra"
        Me.grid_items_compra.Size = New System.Drawing.Size(900, 206)
        Me.grid_items_compra.TabIndex = 1
        Me.grid_items_compra.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.HorzLine.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_item, Me.col_cantidad, Me.col_costo_unitario, Me.col_costo_total, Me.col_codigo_barras})
        Me.GridView2.GridControl = Me.grid_items_compra
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'col_item
        '
        Me.col_item.AppearanceCell.Options.UseTextOptions = True
        Me.col_item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_item.AppearanceHeader.Options.UseTextOptions = True
        Me.col_item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 300
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_cantidad.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 2
        Me.col_cantidad.Width = 153
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "Costo Unitario"
        Me.col_costo_unitario.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_costo_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 3
        Me.col_costo_unitario.Width = 153
        '
        'col_costo_total
        '
        Me.col_costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.Caption = "Costo Total"
        Me.col_costo_total.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_costo_total.DisplayFormat.FormatString = "#,#"
        Me.col_costo_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_total.FieldName = "costo_total"
        Me.col_costo_total.Name = "col_costo_total"
        Me.col_costo_total.Visible = True
        Me.col_costo_total.VisibleIndex = 4
        Me.col_costo_total.Width = 163
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.Caption = "Codigo Barras"
        Me.col_codigo_barras.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 110
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(73, 374)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 2
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.btn_nueva_cons)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.btn_proveedores)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.cbo_tipos)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.btn_cld_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_cal_desde)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 415)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Busqueda"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(224, 45)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 22)
        Me.btn_buscar_sucursal.TabIndex = 63
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(12, 45)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_sucursal.TabIndex = 62
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(53, 45)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(170, 22)
        Me.txt_sucursal.TabIndex = 60
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 61
        Me.LabelControl5.Text = "Sucursal:"
        '
        'btn_nueva_cons
        '
        Me.btn_nueva_cons.Image = CType(resources.GetObject("btn_nueva_cons.Image"), System.Drawing.Image)
        Me.btn_nueva_cons.Location = New System.Drawing.Point(11, 333)
        Me.btn_nueva_cons.Name = "btn_nueva_cons"
        Me.btn_nueva_cons.Size = New System.Drawing.Size(117, 35)
        Me.btn_nueva_cons.TabIndex = 59
        Me.btn_nueva_cons.Text = "Cancelar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 222)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "Proveedor:"
        '
        'btn_proveedores
        '
        Me.btn_proveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_proveedores.Location = New System.Drawing.Point(225, 238)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(27, 21)
        Me.btn_proveedores.TabIndex = 57
        Me.btn_proveedores.Text = "..."
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(11, 238)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(213, 22)
        Me.txt_proveedor.TabIndex = 56
        '
        'cbo_tipos
        '
        Me.cbo_tipos.Location = New System.Drawing.Point(12, 191)
        Me.cbo_tipos.Name = "cbo_tipos"
        Me.cbo_tipos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_tipos.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_tipos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipos.Properties.ImmediatePopup = True
        Me.cbo_tipos.Size = New System.Drawing.Size(241, 22)
        Me.cbo_tipos.TabIndex = 55
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 173)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Tipo de Compra:"
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(225, 137)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(28, 22)
        Me.btn_cld_hasta.TabIndex = 8
        Me.btn_cld_hasta.Text = "+"
        '
        'btn_cal_desde
        '
        Me.btn_cal_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cal_desde.Location = New System.Drawing.Point(225, 88)
        Me.btn_cal_desde.Name = "btn_cal_desde"
        Me.btn_cal_desde.Size = New System.Drawing.Size(28, 22)
        Me.btn_cal_desde.TabIndex = 4
        Me.btn_cal_desde.Text = "+"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(12, 138)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(212, 21)
        Me.txt_fecha_hasta.TabIndex = 7
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(12, 89)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(212, 21)
        Me.txt_fecha_desde.TabIndex = 5
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 122)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(134, 333)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(238, 159)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(250, 227)
        Me.cld_hasta.TabIndex = 64
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(238, 110)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(250, 227)
        Me.cld_desde.TabIndex = 64
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(814, 260)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 82
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'lbl_total_registros_item
        '
        Me.lbl_total_registros_item.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros_item.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros_item.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros_item.Location = New System.Drawing.Point(814, 472)
        Me.lbl_total_registros_item.Name = "lbl_total_registros_item"
        Me.lbl_total_registros_item.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros_item.TabIndex = 83
        Me.lbl_total_registros_item.Text = "Registros recuperados: 1000"
        '
        'frm_listado_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 514)
        Me.Controls.Add(Me.lbl_total_registros_item)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_items_compra)
        Me.Controls.Add(Me.grid_compras)
        Me.Name = "frm_listado_compras"
        Me.Text = "<<Listado de Compras>>"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_items_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_tipos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_compras As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_nro_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_items_compra As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tipo_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_relacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cal_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbo_tipos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_proveedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_nueva_cons As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents col_gravadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_registros_item As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
