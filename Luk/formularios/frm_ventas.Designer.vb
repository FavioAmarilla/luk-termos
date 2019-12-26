<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ventas
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
        Me.grid_items = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pct_logo_empresa = New System.Windows.Forms.PictureBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_conexion = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_empresa = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sucursal = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cbo_condicion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_buscar_cliente = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_cliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_modo_venta = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_codigo_barras = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRecibos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_extraccion = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_pedidos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_anular = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_devolucion = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_precios = New DevExpress.XtraEditors.SimpleButton()
        Me.pct_img_articulo = New System.Windows.Forms.PictureBox()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_total_items = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_logo_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cbo_condicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.pct_img_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_items
        '
        Me.grid_items.Location = New System.Drawing.Point(11, 238)
        Me.grid_items.MainView = Me.GridView1
        Me.grid_items.Name = "grid_items"
        Me.grid_items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.grid_items.Size = New System.Drawing.Size(773, 256)
        Me.grid_items.TabIndex = 2
        Me.grid_items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_codigo_barras, Me.col_descripcion, Me.col_precio_unitario, Me.col_cantidad, Me.col_total, Me.col_id_articulo, Me.col_costo_unitario, Me.col_id_pedido, Me.col_id_item, Me.col_id_proveedor})
        Me.GridView1.GridControl = Me.grid_items
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo_barras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo_barras.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo_barras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo_barras.Caption = "Codigo Barras"
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 105
        '
        'col_descripcion
        '
        Me.col_descripcion.AppearanceCell.Options.UseTextOptions = True
        Me.col_descripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_descripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_descripcion.Caption = "Descripcion"
        Me.col_descripcion.FieldName = "descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 1
        Me.col_descripcion.Width = 297
        '
        'col_precio_unitario
        '
        Me.col_precio_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.Caption = "Precio Unitario"
        Me.col_precio_unitario.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_precio_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_precio_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_unitario.FieldName = "precio_unitario"
        Me.col_precio_unitario.Name = "col_precio_unitario"
        Me.col_precio_unitario.Visible = True
        Me.col_precio_unitario.VisibleIndex = 2
        Me.col_precio_unitario.Width = 115
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 3
        Me.col_cantidad.Width = 115
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 120
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_id_articulo
        '
        Me.col_id_articulo.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_articulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_id_articulo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_articulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_id_articulo.Caption = "id articulo"
        Me.col_id_articulo.FieldName = "id_articulo"
        Me.col_id_articulo.Name = "col_id_articulo"
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "costo_unitario"
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        '
        'col_id_pedido
        '
        Me.col_id_pedido.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_pedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_id_pedido.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_id_pedido.Caption = "id_pedido"
        Me.col_id_pedido.FieldName = "id_pedido"
        Me.col_id_pedido.Name = "col_id_pedido"
        '
        'col_id_item
        '
        Me.col_id_item.Caption = "id_item"
        Me.col_id_item.FieldName = "id_item"
        Me.col_id_item.Name = "col_id_item"
        '
        'col_id_proveedor
        '
        Me.col_id_proveedor.Caption = "ID Proveedor"
        Me.col_id_proveedor.FieldName = "id_proveedor"
        Me.col_id_proveedor.Name = "col_id_proveedor"
        '
        'pct_logo_empresa
        '
        Me.pct_logo_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_logo_empresa.Location = New System.Drawing.Point(11, 58)
        Me.pct_logo_empresa.Name = "pct_logo_empresa"
        Me.pct_logo_empresa.Size = New System.Drawing.Size(226, 172)
        Me.pct_logo_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_logo_empresa.TabIndex = 3
        Me.pct_logo_empresa.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_conexion)
        Me.PanelControl1.Controls.Add(Me.lbl_empresa)
        Me.PanelControl1.Controls.Add(Me.lbl_sucursal)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 11)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1021, 41)
        Me.PanelControl1.TabIndex = 0
        '
        'lbl_conexion
        '
        Me.lbl_conexion.Location = New System.Drawing.Point(960, 12)
        Me.lbl_conexion.Name = "lbl_conexion"
        Me.lbl_conexion.Size = New System.Drawing.Size(45, 13)
        Me.lbl_conexion.TabIndex = 2
        Me.lbl_conexion.Text = "EN LINEA"
        '
        'lbl_empresa
        '
        Me.lbl_empresa.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_empresa.Location = New System.Drawing.Point(461, 11)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(98, 18)
        Me.lbl_empresa.TabIndex = 1
        Me.lbl_empresa.Text = "LUK TERMOS"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.Location = New System.Drawing.Point(15, 12)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(75, 13)
        Me.lbl_sucursal.TabIndex = 0
        Me.lbl_sucursal.Text = "CASA CENTRAL"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cbo_condicion)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.btn_buscar_cliente)
        Me.PanelControl2.Controls.Add(Me.txt_cliente)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.txt_numero)
        Me.PanelControl2.Controls.Add(Me.txt_usuario)
        Me.PanelControl2.Controls.Add(Me.txt_fecha)
        Me.PanelControl2.Controls.Add(Me.LabelControl9)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Location = New System.Drawing.Point(236, 58)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(548, 172)
        Me.PanelControl2.TabIndex = 0
        '
        'cbo_condicion
        '
        Me.cbo_condicion.Location = New System.Drawing.Point(95, 97)
        Me.cbo_condicion.Name = "cbo_condicion"
        Me.cbo_condicion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbo_condicion.Properties.Appearance.Options.UseFont = True
        Me.cbo_condicion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_condicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_condicion.Properties.ImmediatePopup = True
        Me.cbo_condicion.Size = New System.Drawing.Size(291, 24)
        Me.cbo_condicion.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(27, 97)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 18)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Condicion:"
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(353, 124)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(33, 22)
        Me.btn_buscar_cliente.TabIndex = 5
        Me.btn_buscar_cliente.Text = "..."
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(95, 124)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cliente.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cliente.Properties.Appearance.Options.UseFont = True
        Me.txt_cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cliente.Properties.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(256, 24)
        Me.txt_cliente.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(45, 125)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 18)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Cliente:"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(95, 70)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_numero.Properties.Appearance.Options.UseFont = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Size = New System.Drawing.Size(291, 24)
        Me.txt_numero.TabIndex = 2
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(95, 42)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_usuario.Properties.Appearance.Options.UseFont = True
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(291, 24)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(95, 14)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.Appearance.Options.UseFont = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(291, 24)
        Me.txt_fecha.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(35, 73)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(57, 18)
        Me.LabelControl9.TabIndex = 5
        Me.LabelControl9.Text = "Numero:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(39, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Usuario:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(48, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 18)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Fecha:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lbl_modo_venta)
        Me.PanelControl3.Controls.Add(Me.LabelControl12)
        Me.PanelControl3.Controls.Add(Me.txt_cantidad)
        Me.PanelControl3.Controls.Add(Me.txt_codigo_barras)
        Me.PanelControl3.Controls.Add(Me.LabelControl11)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Location = New System.Drawing.Point(790, 238)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(242, 174)
        Me.PanelControl3.TabIndex = 1
        '
        'lbl_modo_venta
        '
        Me.lbl_modo_venta.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lbl_modo_venta.Location = New System.Drawing.Point(128, 136)
        Me.lbl_modo_venta.Name = "lbl_modo_venta"
        Me.lbl_modo_venta.Size = New System.Drawing.Size(46, 18)
        Me.lbl_modo_venta.TabIndex = 5
        Me.lbl_modo_venta.Text = "Normal"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(19, 135)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl12.TabIndex = 4
        Me.LabelControl12.Text = "Modo Venta:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(19, 92)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txt_cantidad.Properties.Appearance.Options.UseFont = True
        Me.txt_cantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cantidad.Size = New System.Drawing.Size(204, 30)
        Me.txt_cantidad.TabIndex = 1
        '
        'txt_codigo_barras
        '
        Me.txt_codigo_barras.Location = New System.Drawing.Point(19, 30)
        Me.txt_codigo_barras.Name = "txt_codigo_barras"
        Me.txt_codigo_barras.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.txt_codigo_barras.Properties.Appearance.Options.UseFont = True
        Me.txt_codigo_barras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo_barras.Size = New System.Drawing.Size(204, 30)
        Me.txt_codigo_barras.TabIndex = 0
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl11.Location = New System.Drawing.Point(19, 72)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Cantidad"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl10.Location = New System.Drawing.Point(19, 10)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(95, 18)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "Codigo Barras:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnRecibos)
        Me.PanelControl4.Controls.Add(Me.btn_extraccion)
        Me.PanelControl4.Controls.Add(Me.btn_pedidos)
        Me.PanelControl4.Controls.Add(Me.btn_cerrar)
        Me.PanelControl4.Controls.Add(Me.btn_confirmar)
        Me.PanelControl4.Controls.Add(Me.btn_anular)
        Me.PanelControl4.Controls.Add(Me.btn_devolucion)
        Me.PanelControl4.Controls.Add(Me.btn_precios)
        Me.PanelControl4.Location = New System.Drawing.Point(11, 500)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1021, 74)
        Me.PanelControl4.TabIndex = 2
        '
        'btnRecibos
        '
        Me.btnRecibos.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnRecibos.Appearance.Options.UseFont = True
        Me.btnRecibos.Location = New System.Drawing.Point(747, 20)
        Me.btnRecibos.Name = "btnRecibos"
        Me.btnRecibos.Size = New System.Drawing.Size(117, 35)
        Me.btnRecibos.TabIndex = 8
        Me.btnRecibos.Text = "F11-Recibos"
        '
        'btn_extraccion
        '
        Me.btn_extraccion.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_extraccion.Appearance.Options.UseFont = True
        Me.btn_extraccion.Location = New System.Drawing.Point(624, 20)
        Me.btn_extraccion.Name = "btn_extraccion"
        Me.btn_extraccion.Size = New System.Drawing.Size(117, 35)
        Me.btn_extraccion.TabIndex = 7
        Me.btn_extraccion.Text = "F9-Extraccion"
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_pedidos.Appearance.Options.UseFont = True
        Me.btn_pedidos.Location = New System.Drawing.Point(11, 20)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(117, 35)
        Me.btn_pedidos.TabIndex = 4
        Me.btn_pedidos.Text = "F4-Pedidos"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_cerrar.Appearance.Options.UseFont = True
        Me.btn_cerrar.Location = New System.Drawing.Point(870, 20)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.Text = "Esc-Cerrar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_confirmar.Appearance.Options.UseFont = True
        Me.btn_confirmar.Location = New System.Drawing.Point(501, 20)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "F8-Confirmar"
        '
        'btn_anular
        '
        Me.btn_anular.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_anular.Appearance.Options.UseFont = True
        Me.btn_anular.Location = New System.Drawing.Point(378, 20)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(117, 35)
        Me.btn_anular.TabIndex = 3
        Me.btn_anular.Text = "F7-Anular"
        '
        'btn_devolucion
        '
        Me.btn_devolucion.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_devolucion.Appearance.Options.UseFont = True
        Me.btn_devolucion.Location = New System.Drawing.Point(255, 20)
        Me.btn_devolucion.Name = "btn_devolucion"
        Me.btn_devolucion.Size = New System.Drawing.Size(117, 35)
        Me.btn_devolucion.TabIndex = 1
        Me.btn_devolucion.Text = "F6-Eliminar Item"
        '
        'btn_precios
        '
        Me.btn_precios.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_precios.Appearance.Options.UseFont = True
        Me.btn_precios.Location = New System.Drawing.Point(134, 20)
        Me.btn_precios.Name = "btn_precios"
        Me.btn_precios.Size = New System.Drawing.Size(117, 35)
        Me.btn_precios.TabIndex = 0
        Me.btn_precios.Text = "F5-Precios"
        '
        'pct_img_articulo
        '
        Me.pct_img_articulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_img_articulo.Location = New System.Drawing.Point(790, 58)
        Me.pct_img_articulo.Name = "pct_img_articulo"
        Me.pct_img_articulo.Size = New System.Drawing.Size(242, 172)
        Me.pct_img_articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_img_articulo.TabIndex = 6
        Me.pct_img_articulo.TabStop = False
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.lbl_total_items)
        Me.PanelControl5.Controls.Add(Me.lbl_total)
        Me.PanelControl5.Controls.Add(Me.LabelControl15)
        Me.PanelControl5.Controls.Add(Me.LabelControl14)
        Me.PanelControl5.Location = New System.Drawing.Point(790, 418)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(242, 76)
        Me.PanelControl5.TabIndex = 7
        '
        'lbl_total_items
        '
        Me.lbl_total_items.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lbl_total_items.Location = New System.Drawing.Point(132, 44)
        Me.lbl_total_items.Name = "lbl_total_items"
        Me.lbl_total_items.Size = New System.Drawing.Size(8, 18)
        Me.lbl_total_items.TabIndex = 8
        Me.lbl_total_items.Text = "1"
        '
        'lbl_total
        '
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lbl_total.Location = New System.Drawing.Point(77, 13)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(53, 18)
        Me.lbl_total.TabIndex = 7
        Me.lbl_total.Text = "235.000"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Location = New System.Drawing.Point(19, 42)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(104, 21)
        Me.LabelControl15.TabIndex = 1
        Me.LabelControl15.Text = "Total Items:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Location = New System.Drawing.Point(19, 11)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(49, 21)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "Total:"
        '
        'frm_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 612)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.pct_img_articulo)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pct_logo_empresa)
        Me.Controls.Add(Me.grid_items)
        Me.Name = "frm_ventas"
        Me.Text = "<<Punto de Ventas>>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_logo_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cbo_condicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.pct_img_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_items As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pct_logo_empresa As PictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_conexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_empresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sucursal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_cerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_anular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_devolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_precios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pct_img_articulo As PictureBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_cantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_codigo_barras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_modo_venta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_total_items As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_pedidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_buscar_cliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbo_condicion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_id_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_extraccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRecibos As DevExpress.XtraEditors.SimpleButton
End Class
