<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_listado_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_pedidos))
        Me.grid_listado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha_entrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_utilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_recepcionado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_entregado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.id_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fehca_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_enviado_produccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_prioridad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_delivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cliente_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_direccion_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad_articulos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comentario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_anulado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_total_mano_obra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_adicional = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_sucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_imprimir_pedido = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ver_pedido = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_costear = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_enviar_productos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_asignar_empleados = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.chk_todos = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_anulados = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_no_anulados = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_buscar = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.chk_todos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_anulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_no_anulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_buscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_listado
        '
        Me.grid_listado.Location = New System.Drawing.Point(12, 110)
        Me.grid_listado.MainView = Me.GridView1
        Me.grid_listado.Name = "grid_listado"
        Me.grid_listado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemCheckEdit5, Me.RepositoryItemCheckEdit6})
        Me.grid_listado.Size = New System.Drawing.Size(1205, 463)
        Me.grid_listado.TabIndex = 0
        Me.grid_listado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.AppearancePrint.OddRow.Options.UseImage = True
        Me.GridView1.AppearancePrint.Preview.Options.UseImage = True
        Me.GridView1.AppearancePrint.Row.Options.UseImage = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_numero, Me.col_costo_total, Me.col_total_precio_venta, Me.col_articulo, Me.col_cliente, Me.col_fecha_entrega, Me.col_utilidad, Me.col_recepcionado, Me.col_entregado, Me.col_comision, Me.id_pedido, Me.col_fehca_pedido, Me.col_enviado_produccion, Me.col_prioridad, Me.col_delivery, Me.col_cliente_telefono, Me.col_direccion_cliente, Me.col_cantidad_articulos, Me.col_comentario, Me.col_anulado, Me.col_total_mano_obra, Me.col_total_adicional, Me.col_id_sucursal})
        Me.GridView1.GridControl = Me.grid_listado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ClearFindOnClose = False
        Me.GridView1.OptionsFind.HighlightFindResults = False
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsPrint.ExpandAllDetails = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsPrint.RtfPageFooter = resources.GetString("GridView1.OptionsPrint.RtfPageFooter")
        Me.GridView1.OptionsPrint.RtfReportHeader = resources.GetString("GridView1.OptionsPrint.RtfReportHeader")
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_numero
        '
        Me.col_numero.AppearanceCell.Options.UseTextOptions = True
        Me.col_numero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_numero.AppearanceHeader.Options.UseTextOptions = True
        Me.col_numero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_numero.Caption = "Nro. Pedido"
        Me.col_numero.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_numero.FieldName = "numero"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.Visible = True
        Me.col_numero.VisibleIndex = 0
        Me.col_numero.Width = 77
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_costo_total
        '
        Me.col_costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.Caption = "Costo Total"
        Me.col_costo_total.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_costo_total.DisplayFormat.FormatString = "#,#"
        Me.col_costo_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_total.FieldName = "costo_total"
        Me.col_costo_total.Name = "col_costo_total"
        Me.col_costo_total.Visible = True
        Me.col_costo_total.VisibleIndex = 7
        Me.col_costo_total.Width = 60
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "0"
        '
        'col_total_precio_venta
        '
        Me.col_total_precio_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_precio_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_precio_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_precio_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_precio_venta.Caption = "Precio Venta"
        Me.col_total_precio_venta.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_total_precio_venta.DisplayFormat.FormatString = "#,#"
        Me.col_total_precio_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_precio_venta.FieldName = "total_precio_venta"
        Me.col_total_precio_venta.Name = "col_total_precio_venta"
        Me.col_total_precio_venta.Visible = True
        Me.col_total_precio_venta.VisibleIndex = 8
        Me.col_total_precio_venta.Width = 60
        '
        'col_articulo
        '
        Me.col_articulo.AppearanceCell.Options.UseTextOptions = True
        Me.col_articulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_articulo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_articulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_articulo.Caption = "Articulo"
        Me.col_articulo.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_articulo.FieldName = "articulo"
        Me.col_articulo.Name = "col_articulo"
        Me.col_articulo.Visible = True
        Me.col_articulo.VisibleIndex = 6
        Me.col_articulo.Width = 141
        '
        'col_cliente
        '
        Me.col_cliente.AppearanceCell.Options.UseTextOptions = True
        Me.col_cliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_cliente.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_cliente.Caption = "Cliente"
        Me.col_cliente.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_cliente.FieldName = "cliente"
        Me.col_cliente.Name = "col_cliente"
        Me.col_cliente.Visible = True
        Me.col_cliente.VisibleIndex = 5
        Me.col_cliente.Width = 153
        '
        'col_fecha_entrega
        '
        Me.col_fecha_entrega.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha_entrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_entrega.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha_entrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_entrega.Caption = "Fec. Entrega"
        Me.col_fecha_entrega.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fecha_entrega.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_fecha_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_fecha_entrega.FieldName = "fecha_entrega"
        Me.col_fecha_entrega.Name = "col_fecha_entrega"
        Me.col_fecha_entrega.Visible = True
        Me.col_fecha_entrega.VisibleIndex = 2
        Me.col_fecha_entrega.Width = 73
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_utilidad
        '
        Me.col_utilidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_utilidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_utilidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_utilidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_utilidad.Caption = "Utilidad"
        Me.col_utilidad.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_utilidad.DisplayFormat.FormatString = "#,#"
        Me.col_utilidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_utilidad.FieldName = "utilidad"
        Me.col_utilidad.Name = "col_utilidad"
        Me.col_utilidad.Visible = True
        Me.col_utilidad.VisibleIndex = 10
        Me.col_utilidad.Width = 60
        '
        'col_recepcionado
        '
        Me.col_recepcionado.AppearanceCell.Options.UseTextOptions = True
        Me.col_recepcionado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_recepcionado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_recepcionado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_recepcionado.Caption = "Recepcionado"
        Me.col_recepcionado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_recepcionado.FieldName = "recepcionado"
        Me.col_recepcionado.Name = "col_recepcionado"
        Me.col_recepcionado.Visible = True
        Me.col_recepcionado.VisibleIndex = 12
        Me.col_recepcionado.Width = 66
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureChecked"), System.Drawing.Image)
        '
        'col_entregado
        '
        Me.col_entregado.AppearanceCell.Options.UseTextOptions = True
        Me.col_entregado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_entregado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_entregado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_entregado.Caption = "Entregado"
        Me.col_entregado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_entregado.FieldName = "entregado"
        Me.col_entregado.Name = "col_entregado"
        Me.col_entregado.Visible = True
        Me.col_entregado.VisibleIndex = 13
        Me.col_entregado.Width = 74
        '
        'col_comision
        '
        Me.col_comision.AppearanceCell.Options.UseTextOptions = True
        Me.col_comision.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.AppearanceHeader.Options.UseTextOptions = True
        Me.col_comision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.Caption = "Comision a Vend."
        Me.col_comision.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_comision.DisplayFormat.FormatString = "#,#"
        Me.col_comision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_comision.FieldName = "comision_vendedor"
        Me.col_comision.Name = "col_comision"
        Me.col_comision.Visible = True
        Me.col_comision.VisibleIndex = 9
        Me.col_comision.Width = 80
        '
        'id_pedido
        '
        Me.id_pedido.Caption = "id_pedido"
        Me.id_pedido.FieldName = "id_pedido"
        Me.id_pedido.Name = "id_pedido"
        '
        'col_fehca_pedido
        '
        Me.col_fehca_pedido.Caption = "Fec. Pedido"
        Me.col_fehca_pedido.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fehca_pedido.FieldName = "fecha_pedido"
        Me.col_fehca_pedido.Name = "col_fehca_pedido"
        Me.col_fehca_pedido.Visible = True
        Me.col_fehca_pedido.VisibleIndex = 1
        Me.col_fehca_pedido.Width = 76
        '
        'col_enviado_produccion
        '
        Me.col_enviado_produccion.AppearanceCell.Options.UseTextOptions = True
        Me.col_enviado_produccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_enviado_produccion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_enviado_produccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_enviado_produccion.Caption = "Env. prod"
        Me.col_enviado_produccion.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_enviado_produccion.FieldName = "enviado_produccion"
        Me.col_enviado_produccion.Name = "col_enviado_produccion"
        Me.col_enviado_produccion.Visible = True
        Me.col_enviado_produccion.VisibleIndex = 11
        Me.col_enviado_produccion.Width = 64
        '
        'col_prioridad
        '
        Me.col_prioridad.AppearanceCell.Options.UseTextOptions = True
        Me.col_prioridad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_prioridad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_prioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_prioridad.Caption = "Prioridad"
        Me.col_prioridad.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.col_prioridad.FieldName = "prioridad"
        Me.col_prioridad.Name = "col_prioridad"
        Me.col_prioridad.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.col_prioridad.Visible = True
        Me.col_prioridad.VisibleIndex = 3
        Me.col_prioridad.Width = 64
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.Appearance.Options.UseImage = True
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit3.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit3.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit3.PictureUnchecked"), System.Drawing.Image)
        '
        'col_delivery
        '
        Me.col_delivery.AppearanceCell.Options.UseTextOptions = True
        Me.col_delivery.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_delivery.AppearanceHeader.Options.UseTextOptions = True
        Me.col_delivery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_delivery.Caption = "Delivery"
        Me.col_delivery.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_delivery.FieldName = "delivery"
        Me.col_delivery.Name = "col_delivery"
        Me.col_delivery.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[True]
        Me.col_delivery.Visible = True
        Me.col_delivery.VisibleIndex = 4
        Me.col_delivery.Width = 64
        '
        'col_cliente_telefono
        '
        Me.col_cliente_telefono.Caption = "telefono"
        Me.col_cliente_telefono.FieldName = "telefono"
        Me.col_cliente_telefono.Name = "col_cliente_telefono"
        '
        'col_direccion_cliente
        '
        Me.col_direccion_cliente.Caption = "direccion"
        Me.col_direccion_cliente.FieldName = "direccion"
        Me.col_direccion_cliente.Name = "col_direccion_cliente"
        '
        'col_cantidad_articulos
        '
        Me.col_cantidad_articulos.Caption = "cantidad_articulos"
        Me.col_cantidad_articulos.FieldName = "cantidad_articulos"
        Me.col_cantidad_articulos.Name = "col_cantidad_articulos"
        '
        'col_comentario
        '
        Me.col_comentario.Caption = "comentario"
        Me.col_comentario.FieldName = "comentario"
        Me.col_comentario.Name = "col_comentario"
        '
        'col_anulado
        '
        Me.col_anulado.AppearanceCell.Options.UseTextOptions = True
        Me.col_anulado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_anulado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_anulado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_anulado.Caption = "Anulado"
        Me.col_anulado.ColumnEdit = Me.RepositoryItemCheckEdit6
        Me.col_anulado.FieldName = "anulado"
        Me.col_anulado.Name = "col_anulado"
        Me.col_anulado.Visible = True
        Me.col_anulado.VisibleIndex = 14
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'col_total_mano_obra
        '
        Me.col_total_mano_obra.Caption = "GridColumn2"
        Me.col_total_mano_obra.FieldName = "total_mano_obra"
        Me.col_total_mano_obra.Name = "col_total_mano_obra"
        '
        'col_total_adicional
        '
        Me.col_total_adicional.Caption = "GridColumn4"
        Me.col_total_adicional.FieldName = "total_adicional"
        Me.col_total_adicional.Name = "col_total_adicional"
        '
        'col_id_sucursal
        '
        Me.col_id_sucursal.Caption = "id_sucursal"
        Me.col_id_sucursal.FieldName = "id_sucursal"
        Me.col_id_sucursal.Name = "col_id_sucursal"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit4.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.PictureChecked = Global.Luk.My.Resources.Resources.logistics_delivery_truck_in_movement__1_
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit5.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style16
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'GridColumn3
        '
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 181
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 181
        '
        'btn_imprimir_pedido
        '
        Me.btn_imprimir_pedido.Image = CType(resources.GetObject("btn_imprimir_pedido.Image"), System.Drawing.Image)
        Me.btn_imprimir_pedido.Location = New System.Drawing.Point(525, 22)
        Me.btn_imprimir_pedido.Name = "btn_imprimir_pedido"
        Me.btn_imprimir_pedido.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir_pedido.TabIndex = 1
        Me.btn_imprimir_pedido.Text = " Imp. Pedidos"
        '
        'btn_ver_pedido
        '
        Me.btn_ver_pedido.Image = CType(resources.GetObject("btn_ver_pedido.Image"), System.Drawing.Image)
        Me.btn_ver_pedido.Location = New System.Drawing.Point(22, 22)
        Me.btn_ver_pedido.Name = "btn_ver_pedido"
        Me.btn_ver_pedido.Size = New System.Drawing.Size(117, 35)
        Me.btn_ver_pedido.TabIndex = 2
        Me.btn_ver_pedido.Text = "Ver Pedido"
        '
        'btn_costear
        '
        Me.btn_costear.Image = CType(resources.GetObject("btn_costear.Image"), System.Drawing.Image)
        Me.btn_costear.Location = New System.Drawing.Point(156, 22)
        Me.btn_costear.Name = "btn_costear"
        Me.btn_costear.Size = New System.Drawing.Size(117, 35)
        Me.btn_costear.TabIndex = 3
        Me.btn_costear.Text = "Costear"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(851, 549)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 82
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_enviar_productos)
        Me.PanelControl1.Controls.Add(Me.btn_asignar_empleados)
        Me.PanelControl1.Controls.Add(Me.btn_ver_pedido)
        Me.PanelControl1.Controls.Add(Me.btn_costear)
        Me.PanelControl1.Controls.Add(Me.btn_imprimir_pedido)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(666, 78)
        Me.PanelControl1.TabIndex = 83
        '
        'btn_enviar_productos
        '
        Me.btn_enviar_productos.Image = CType(resources.GetObject("btn_enviar_productos.Image"), System.Drawing.Image)
        Me.btn_enviar_productos.Location = New System.Drawing.Point(402, 22)
        Me.btn_enviar_productos.Name = "btn_enviar_productos"
        Me.btn_enviar_productos.Size = New System.Drawing.Size(117, 35)
        Me.btn_enviar_productos.TabIndex = 5
        Me.btn_enviar_productos.Text = "Enviar a Prod."
        '
        'btn_asignar_empleados
        '
        Me.btn_asignar_empleados.Image = CType(resources.GetObject("btn_asignar_empleados.Image"), System.Drawing.Image)
        Me.btn_asignar_empleados.Location = New System.Drawing.Point(279, 22)
        Me.btn_asignar_empleados.Name = "btn_asignar_empleados"
        Me.btn_asignar_empleados.Size = New System.Drawing.Size(117, 35)
        Me.btn_asignar_empleados.TabIndex = 4
        Me.btn_asignar_empleados.Text = "Asignar Emp."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.chk_todos)
        Me.PanelControl2.Controls.Add(Me.chk_anulados)
        Me.PanelControl2.Controls.Add(Me.chk_no_anulados)
        Me.PanelControl2.Location = New System.Drawing.Point(684, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(144, 78)
        Me.PanelControl2.TabIndex = 84
        '
        'chk_todos
        '
        Me.chk_todos.Location = New System.Drawing.Point(30, 7)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Properties.Caption = "Todos"
        Me.chk_todos.Size = New System.Drawing.Size(85, 19)
        Me.chk_todos.TabIndex = 2
        '
        'chk_anulados
        '
        Me.chk_anulados.Location = New System.Drawing.Point(30, 44)
        Me.chk_anulados.Name = "chk_anulados"
        Me.chk_anulados.Properties.Caption = "Anulados"
        Me.chk_anulados.Size = New System.Drawing.Size(75, 19)
        Me.chk_anulados.TabIndex = 1
        '
        'chk_no_anulados
        '
        Me.chk_no_anulados.Location = New System.Drawing.Point(30, 25)
        Me.chk_no_anulados.Name = "chk_no_anulados"
        Me.chk_no_anulados.Properties.Caption = "No anulados"
        Me.chk_no_anulados.Size = New System.Drawing.Size(85, 19)
        Me.chk_no_anulados.TabIndex = 0
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(25, 123)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_buscar.Size = New System.Drawing.Size(351, 22)
        Me.txt_buscar.TabIndex = 85
        '
        'frm_listado_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 585)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_listado)
        Me.Name = "frm_listado_pedidos"
        Me.Text = "<<Listado de Pedidos>>"
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.chk_todos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_anulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_no_anulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_buscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_listado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_entrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_utilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_recepcionado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_imprimir_pedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_entregado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_comision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_ver_pedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_costear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_fehca_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_enviado_produccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_prioridad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_delivery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_enviar_productos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_asignar_empleados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_cliente_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad_articulos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_comentario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chk_anulados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_no_anulados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents col_anulado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chk_todos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents col_total_mano_obra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_adicional As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_sucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_buscar As DevExpress.XtraEditors.TextEdit
End Class
