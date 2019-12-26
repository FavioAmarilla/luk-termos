<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_movimientos_stock_items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_movimientos_stock_items))
        Me.grid_movimientos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_transaccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.chk_articulos = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_materia_prima = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.btn_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_descripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscar_item = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_nro_venta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nro_compra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nro_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.col_id_movimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_articulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_nro_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_compra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_movimientos
        '
        Me.grid_movimientos.Location = New System.Drawing.Point(340, 12)
        Me.grid_movimientos.MainView = Me.GridView1
        Me.grid_movimientos.Name = "grid_movimientos"
        Me.grid_movimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.grid_movimientos.Size = New System.Drawing.Size(788, 304)
        Me.grid_movimientos.TabIndex = 1
        Me.grid_movimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_movimiento, Me.col_transaccion, Me.col_cantidad, Me.col_nombre, Me.col_costo_unitario, Me.col_fecha})
        Me.GridView1.GridControl = Me.grid_movimientos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_transaccion
        '
        Me.col_transaccion.Caption = "Transaccion"
        Me.col_transaccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_transaccion.FieldName = "transaccion"
        Me.col_transaccion.Name = "col_transaccion"
        Me.col_transaccion.Visible = True
        Me.col_transaccion.VisibleIndex = 1
        Me.col_transaccion.Width = 190
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 3
        Me.col_cantidad.Width = 120
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "item"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 2
        Me.col_nombre.Width = 234
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "Costo Unitario"
        Me.col_costo_unitario.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 4
        Me.col_costo_unitario.Width = 120
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "Fecha Movim."
        Me.col_fecha.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.col_fecha.FieldName = "fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 0
        Me.col_fecha.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'chk_articulos
        '
        Me.chk_articulos.Location = New System.Drawing.Point(18, 26)
        Me.chk_articulos.Name = "chk_articulos"
        Me.chk_articulos.Properties.Caption = "Articulos"
        Me.chk_articulos.Size = New System.Drawing.Size(75, 19)
        Me.chk_articulos.TabIndex = 0
        '
        'chk_materia_prima
        '
        Me.chk_materia_prima.Location = New System.Drawing.Point(135, 26)
        Me.chk_materia_prima.Name = "chk_materia_prima"
        Me.chk_materia_prima.Properties.Caption = "Materia Prima"
        Me.chk_materia_prima.Size = New System.Drawing.Size(98, 19)
        Me.chk_materia_prima.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.btn_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.btn_desde)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_item)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.chk_articulos)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.chk_materia_prima)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 472)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Busqueda"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(185, 259)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 65
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(18, 259)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 64
        Me.btn_consultar.Text = "Consultar"
        '
        'btn_hasta
        '
        Me.btn_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_hasta.Location = New System.Drawing.Point(223, 213)
        Me.btn_hasta.Name = "btn_hasta"
        Me.btn_hasta.Size = New System.Drawing.Size(23, 21)
        Me.btn_hasta.TabIndex = 63
        Me.btn_hasta.TabStop = False
        Me.btn_hasta.Text = "+"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(18, 120)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo.Properties.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(138, 22)
        Me.txt_codigo.TabIndex = 3
        '
        'btn_desde
        '
        Me.btn_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_desde.Location = New System.Drawing.Point(223, 167)
        Me.btn_desde.Name = "btn_desde"
        Me.btn_desde.Size = New System.Drawing.Size(23, 21)
        Me.btn_desde.TabIndex = 62
        Me.btn_desde.TabStop = False
        Me.btn_desde.Text = "+"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(18, 79)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_descripcion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_descripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_descripcion.Size = New System.Drawing.Size(254, 22)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(18, 213)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(203, 21)
        Me.txt_fecha_hasta.TabIndex = 60
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'btn_buscar_item
        '
        Me.btn_buscar_item.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_item.Location = New System.Drawing.Point(273, 79)
        Me.btn_buscar_item.Name = "btn_buscar_item"
        Me.btn_buscar_item.Size = New System.Drawing.Size(29, 21)
        Me.btn_buscar_item.TabIndex = 4
        Me.btn_buscar_item.Text = "+"
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(18, 167)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(203, 21)
        Me.txt_fecha_desde.TabIndex = 58
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripcion:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 194)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 61
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(235, 178)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(241, 227)
        Me.cld_desde.TabIndex = 65
        Me.cld_desde.Visible = False
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(235, 225)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(241, 227)
        Me.cld_hasta.TabIndex = 64
        Me.cld_hasta.Visible = False
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(757, 290)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 83
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_nro_venta)
        Me.GroupBox3.Controls.Add(Me.LabelControl14)
        Me.GroupBox3.Controls.Add(Me.txt_nro_compra)
        Me.GroupBox3.Controls.Add(Me.LabelControl13)
        Me.GroupBox3.Controls.Add(Me.txt_nro_pedido)
        Me.GroupBox3.Controls.Add(Me.LabelControl12)
        Me.GroupBox3.Location = New System.Drawing.Point(340, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(788, 162)
        Me.GroupBox3.TabIndex = 84
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
        'col_id_movimiento
        '
        Me.col_id_movimiento.Caption = "ID Movimiento"
        Me.col_id_movimiento.FieldName = "id_movimiento"
        Me.col_id_movimiento.Name = "col_id_movimiento"
        '
        'frm_movimientos_stock_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 553)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_movimientos)
        Me.Name = "frm_movimientos_stock_items"
        Me.Text = "<<Movimientos de Stock por Items >>"
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_articulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_nro_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_compra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_movimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_articulos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_materia_prima As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents col_transaccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar_item As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_nro_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nro_compra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nro_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id_movimiento As DevExpress.XtraGrid.Columns.GridColumn
End Class
