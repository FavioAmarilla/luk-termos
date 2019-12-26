<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_costeo_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_costeo_pedido))
        Me.grid_materiales = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_material = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_costo_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_costo_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_cantidad_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_descuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_extra = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_total_mano_obra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total_costo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_descuento = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_extra = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_materia_prima = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cliente = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_pedidos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_agregar_material = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_codigo = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_cantidad_articulo = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_descripcion_articulo = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_descto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_extra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_materia_prima_unidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_costo_unitario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_precio_venta_unit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_recargo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_comision = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_porc_comision = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_num_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_venta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_quitar_materia_prima = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_costeo = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.tab_mano_obra = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_quitar_empleado = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_pedi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_cantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_extra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_mano_obra = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_asignacion = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_id_empleado = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_empleado = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_mano_obra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_mano_obra = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_pago_extra = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_asignacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nuevo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_costo_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_costo_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cantidad_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_descuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_extra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_mano_obra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_costo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_descuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_extra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_materia_prima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_materia_prima_unidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_precio_venta_unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_recargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_comision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_porc_comision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.tab_costeo.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.tab_mano_obra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_fecha_pedi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_extra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mano_obra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_asignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_id_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_mano_obra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_pago_extra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_materiales
        '
        Me.grid_materiales.Location = New System.Drawing.Point(3, 206)
        Me.grid_materiales.MainView = Me.GridView1
        Me.grid_materiales.Name = "grid_materiales"
        Me.grid_materiales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_cantidad, Me.rps_costo_unitario, Me.rps_descuento, Me.rps_extra, Me.rps_costo_total, Me.rps_cantidad_total, Me.rps_material})
        Me.grid_materiales.Size = New System.Drawing.Size(819, 348)
        Me.grid_materiales.TabIndex = 1
        Me.grid_materiales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_material, Me.col_material, Me.col_cantidad, Me.col_costo_cantidad, Me.GridColumn8, Me.GridColumn9, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.grid_materiales
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_material
        '
        Me.col_id_material.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_material.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_material.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_material.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.Name = "col_id_material"
        Me.col_id_material.OptionsColumn.ReadOnly = True
        '
        'col_material
        '
        Me.col_material.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_material.AppearanceCell.Options.UseBorderColor = True
        Me.col_material.Caption = "Material"
        Me.col_material.ColumnEdit = Me.rps_material
        Me.col_material.FieldName = "material"
        Me.col_material.Name = "col_material"
        Me.col_material.OptionsColumn.ReadOnly = True
        Me.col_material.Visible = True
        Me.col_material.VisibleIndex = 0
        Me.col_material.Width = 325
        '
        'rps_material
        '
        Me.rps_material.AutoHeight = False
        Me.rps_material.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_material.Name = "rps_material"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_cantidad.AppearanceCell.Options.UseBorderColor = True
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad Unt"
        Me.col_cantidad.ColumnEdit = Me.rps_cantidad
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 1
        Me.col_cantidad.Width = 99
        '
        'rps_cantidad
        '
        Me.rps_cantidad.AutoHeight = False
        Me.rps_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cantidad.Mask.EditMask = "n"
        Me.rps_cantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_cantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rps_cantidad.Name = "rps_cantidad"
        '
        'col_costo_cantidad
        '
        Me.col_costo_cantidad.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_costo_cantidad.AppearanceCell.Options.UseBorderColor = True
        Me.col_costo_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_cantidad.Caption = "Costo Unit"
        Me.col_costo_cantidad.ColumnEdit = Me.rps_costo_unitario
        Me.col_costo_cantidad.FieldName = "costo_unitario"
        Me.col_costo_cantidad.Name = "col_costo_cantidad"
        Me.col_costo_cantidad.Visible = True
        Me.col_costo_cantidad.VisibleIndex = 2
        Me.col_costo_cantidad.Width = 99
        '
        'rps_costo_unitario
        '
        Me.rps_costo_unitario.AutoHeight = False
        Me.rps_costo_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_costo_unitario.Mask.EditMask = "n0"
        Me.rps_costo_unitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_costo_unitario.Mask.UseMaskAsDisplayFormat = True
        Me.rps_costo_unitario.Name = "rps_costo_unitario"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn8.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.Caption = "Costo Total"
        Me.GridColumn8.ColumnEdit = Me.rps_costo_total
        Me.GridColumn8.FieldName = "costo_total"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 99
        '
        'rps_costo_total
        '
        Me.rps_costo_total.AutoHeight = False
        Me.rps_costo_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_costo_total.Mask.EditMask = "n0"
        Me.rps_costo_total.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_costo_total.Mask.UseMaskAsDisplayFormat = True
        Me.rps_costo_total.Name = "rps_costo_total"
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn9.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.Caption = "Cantidad Total"
        Me.GridColumn9.ColumnEdit = Me.rps_cantidad_total
        Me.GridColumn9.FieldName = "cantidad_total"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 103
        '
        'rps_cantidad_total
        '
        Me.rps_cantidad_total.AutoHeight = False
        Me.rps_cantidad_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cantidad_total.Mask.EditMask = "f2"
        Me.rps_cantidad_total.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_cantidad_total.Mask.UseMaskAsDisplayFormat = True
        Me.rps_cantidad_total.Name = "rps_cantidad_total"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nuevo"
        Me.GridColumn4.FieldName = "nuevo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "precio_venta"
        Me.GridColumn5.FieldName = "precio_venta"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "id_proveedor"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'rps_descuento
        '
        Me.rps_descuento.AutoHeight = False
        Me.rps_descuento.Mask.EditMask = "n0"
        Me.rps_descuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_descuento.Mask.UseMaskAsDisplayFormat = True
        Me.rps_descuento.Name = "rps_descuento"
        '
        'rps_extra
        '
        Me.rps_extra.AutoHeight = False
        Me.rps_extra.Mask.EditMask = "n0"
        Me.rps_extra.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_extra.Mask.UseMaskAsDisplayFormat = True
        Me.rps_extra.Name = "rps_extra"
        '
        'txt_total_mano_obra
        '
        Me.txt_total_mano_obra.Location = New System.Drawing.Point(368, 16)
        Me.txt_total_mano_obra.Name = "txt_total_mano_obra"
        Me.txt_total_mano_obra.Properties.AllowMouseWheel = False
        Me.txt_total_mano_obra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_mano_obra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_mano_obra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_mano_obra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_mano_obra.Properties.Mask.EditMask = "n0"
        Me.txt_total_mano_obra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_mano_obra.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_mano_obra.Size = New System.Drawing.Size(159, 22)
        Me.txt_total_mano_obra.TabIndex = 4
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(274, 20)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl12.TabIndex = 21
        Me.LabelControl12.Text = "Mano de Obra p/u:"
        '
        'txt_total_costo
        '
        Me.txt_total_costo.Location = New System.Drawing.Point(639, 15)
        Me.txt_total_costo.Name = "txt_total_costo"
        Me.txt_total_costo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_costo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_costo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_costo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_costo.Properties.Mask.EditMask = "n0"
        Me.txt_total_costo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_costo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_costo.Properties.ReadOnly = True
        Me.txt_total_costo.Size = New System.Drawing.Size(160, 22)
        Me.txt_total_costo.TabIndex = 8
        '
        'txt_total_descuento
        '
        Me.txt_total_descuento.Location = New System.Drawing.Point(639, 72)
        Me.txt_total_descuento.Name = "txt_total_descuento"
        Me.txt_total_descuento.Properties.AllowMouseWheel = False
        Me.txt_total_descuento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_descuento.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_descuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_descuento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_descuento.Properties.Mask.EditMask = "n0"
        Me.txt_total_descuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_descuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_descuento.Size = New System.Drawing.Size(160, 22)
        Me.txt_total_descuento.TabIndex = 11
        '
        'txt_total_extra
        '
        Me.txt_total_extra.Location = New System.Drawing.Point(94, 100)
        Me.txt_total_extra.Name = "txt_total_extra"
        Me.txt_total_extra.Properties.AllowMouseWheel = False
        Me.txt_total_extra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_extra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_extra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_extra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_extra.Properties.Mask.EditMask = "n0"
        Me.txt_total_extra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_extra.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_extra.Size = New System.Drawing.Size(158, 22)
        Me.txt_total_extra.TabIndex = 3
        '
        'txt_total_materia_prima
        '
        Me.txt_total_materia_prima.Location = New System.Drawing.Point(368, 73)
        Me.txt_total_materia_prima.Name = "txt_total_materia_prima"
        Me.txt_total_materia_prima.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_materia_prima.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_materia_prima.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_materia_prima.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_materia_prima.Properties.Mask.EditMask = "n0"
        Me.txt_total_materia_prima.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_materia_prima.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_materia_prima.Properties.ReadOnly = True
        Me.txt_total_materia_prima.Size = New System.Drawing.Size(159, 22)
        Me.txt_total_materia_prima.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(577, 19)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Total Costo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Total Extra p/u.:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(535, 76)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Total Descuento p/u:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(269, 77)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "Total Materia Prima:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(94, 71)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cliente.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cliente.Properties.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(158, 22)
        Me.txt_cliente.TabIndex = 2
        '
        'txt_fecha_pedido
        '
        Me.txt_fecha_pedido.Location = New System.Drawing.Point(94, 43)
        Me.txt_fecha_pedido.Name = "txt_fecha_pedido"
        Me.txt_fecha_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha_pedido.Properties.ReadOnly = True
        Me.txt_fecha_pedido.Size = New System.Drawing.Size(158, 22)
        Me.txt_fecha_pedido.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(55, 75)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Cliente:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha de Pedido:"
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Image = CType(resources.GetObject("btn_pedidos.Image"), System.Drawing.Image)
        Me.btn_pedidos.Location = New System.Drawing.Point(36, 19)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(117, 35)
        Me.btn_pedidos.TabIndex = 0
        Me.btn_pedidos.Text = "Pedidos"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(36, 60)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 1
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_agregar_material
        '
        Me.btn_agregar_material.Location = New System.Drawing.Point(739, 218)
        Me.btn_agregar_material.Name = "btn_agregar_material"
        Me.btn_agregar_material.Size = New System.Drawing.Size(74, 22)
        Me.btn_agregar_material.TabIndex = 20
        Me.btn_agregar_material.Text = "Agregar Mat."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.lbl_codigo)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.lbl_cantidad_articulo)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.lbl_descripcion_articulo)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 145)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(819, 55)
        Me.PanelControl2.TabIndex = 21
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(708, 18)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl11.TabIndex = 5
        Me.LabelControl11.Text = "Codigo:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbl_codigo.Location = New System.Drawing.Point(772, 18)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(0, 19)
        Me.lbl_codigo.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(8, 18)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl10.TabIndex = 3
        Me.LabelControl10.Text = "Cantidad:"
        '
        'lbl_cantidad_articulo
        '
        Me.lbl_cantidad_articulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbl_cantidad_articulo.Location = New System.Drawing.Point(93, 18)
        Me.lbl_cantidad_articulo.Name = "lbl_cantidad_articulo"
        Me.lbl_cantidad_articulo.Size = New System.Drawing.Size(0, 19)
        Me.lbl_cantidad_articulo.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(164, 18)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 19)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Articulo:"
        '
        'lbl_descripcion_articulo
        '
        Me.lbl_descripcion_articulo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbl_descripcion_articulo.Location = New System.Drawing.Point(248, 18)
        Me.lbl_descripcion_articulo.Name = "lbl_descripcion_articulo"
        Me.lbl_descripcion_articulo.Size = New System.Drawing.Size(0, 19)
        Me.lbl_descripcion_articulo.TabIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Cantidad Unt."
        Me.GridColumn1.ColumnEdit = Me.rps_cantidad
        Me.GridColumn1.DisplayFormat.FormatString = "0.00"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "cantidad"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 94
        '
        'col_cantidad_total
        '
        Me.col_cantidad_total.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_cantidad_total.AppearanceCell.Options.UseFont = True
        Me.col_cantidad_total.Caption = "Cantidad Total"
        Me.col_cantidad_total.ColumnEdit = Me.rps_cantidad_total
        Me.col_cantidad_total.FieldName = "cantidad_total"
        Me.col_cantidad_total.Name = "col_cantidad_total"
        Me.col_cantidad_total.OptionsColumn.ReadOnly = True
        Me.col_cantidad_total.Visible = True
        Me.col_cantidad_total.VisibleIndex = 0
        Me.col_cantidad_total.Width = 100
        '
        'col_costo_total
        '
        Me.col_costo_total.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_costo_total.AppearanceCell.Options.UseFont = True
        Me.col_costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_total.Caption = "Costo Total"
        Me.col_costo_total.ColumnEdit = Me.rps_costo_total
        Me.col_costo_total.DisplayFormat.FormatString = "#,#"
        Me.col_costo_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_total.FieldName = "costo_total"
        Me.col_costo_total.Name = "col_costo_total"
        Me.col_costo_total.OptionsColumn.ReadOnly = True
        Me.col_costo_total.Visible = True
        Me.col_costo_total.VisibleIndex = 0
        Me.col_costo_total.Width = 100
        '
        'col_descto
        '
        Me.col_descto.AppearanceCell.Options.UseTextOptions = True
        Me.col_descto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_descto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_descto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_descto.Caption = "Descuento (Gs)"
        Me.col_descto.ColumnEdit = Me.rps_descuento
        Me.col_descto.DisplayFormat.FormatString = "#,#"
        Me.col_descto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_descto.FieldName = "descuento"
        Me.col_descto.Name = "col_descto"
        Me.col_descto.Visible = True
        Me.col_descto.VisibleIndex = 0
        Me.col_descto.Width = 100
        '
        'col_extra
        '
        Me.col_extra.AppearanceCell.Options.UseTextOptions = True
        Me.col_extra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_extra.AppearanceHeader.Options.UseTextOptions = True
        Me.col_extra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_extra.Caption = "Extra (Gs)"
        Me.col_extra.ColumnEdit = Me.rps_extra
        Me.col_extra.DisplayFormat.FormatString = "#,#"
        Me.col_extra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_extra.FieldName = "extra"
        Me.col_extra.Name = "col_extra"
        Me.col_extra.Visible = True
        Me.col_extra.VisibleIndex = 0
        Me.col_extra.Width = 100
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_costo_unitario.Caption = "Costo Unitario"
        Me.col_costo_unitario.ColumnEdit = Me.rps_costo_unitario
        Me.col_costo_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 0
        Me.col_costo_unitario.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_materia_prima_unidad)
        Me.GroupBox1.Controls.Add(Me.LabelControl21)
        Me.GroupBox1.Controls.Add(Me.txt_costo_unitario)
        Me.GroupBox1.Controls.Add(Me.LabelControl19)
        Me.GroupBox1.Controls.Add(Me.txt_precio_venta_unit)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txt_recargo)
        Me.GroupBox1.Controls.Add(Me.txt_total_comision)
        Me.GroupBox1.Controls.Add(Me.LabelControl18)
        Me.GroupBox1.Controls.Add(Me.txt_porc_comision)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txt_num_pedido)
        Me.GroupBox1.Controls.Add(Me.txt_total_mano_obra)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.txt_total_costo)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txt_total_descuento)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_pedido)
        Me.GroupBox1.Controls.Add(Me.txt_total_extra)
        Me.GroupBox1.Controls.Add(Me.txt_total_materia_prima)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del Pedido"
        '
        'txt_materia_prima_unidad
        '
        Me.txt_materia_prima_unidad.Location = New System.Drawing.Point(368, 45)
        Me.txt_materia_prima_unidad.Name = "txt_materia_prima_unidad"
        Me.txt_materia_prima_unidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_materia_prima_unidad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_materia_prima_unidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_materia_prima_unidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_materia_prima_unidad.Properties.Mask.EditMask = "n0"
        Me.txt_materia_prima_unidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_materia_prima_unidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_materia_prima_unidad.Properties.ReadOnly = True
        Me.txt_materia_prima_unidad.Size = New System.Drawing.Size(159, 22)
        Me.txt_materia_prima_unidad.TabIndex = 5
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(261, 49)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl21.TabIndex = 33
        Me.LabelControl21.Text = "Materia prima p/und.:"
        '
        'txt_costo_unitario
        '
        Me.txt_costo_unitario.Location = New System.Drawing.Point(368, 100)
        Me.txt_costo_unitario.Name = "txt_costo_unitario"
        Me.txt_costo_unitario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_costo_unitario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_costo_unitario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_costo_unitario.Properties.Appearance.Options.UseFont = True
        Me.txt_costo_unitario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_costo_unitario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_costo_unitario.Properties.Mask.EditMask = "n0"
        Me.txt_costo_unitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo_unitario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_costo_unitario.Properties.ReadOnly = True
        Me.txt_costo_unitario.Size = New System.Drawing.Size(159, 22)
        Me.txt_costo_unitario.TabIndex = 7
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(273, 104)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl19.TabIndex = 31
        Me.LabelControl19.Text = "Total costo p/und.:"
        '
        'txt_precio_venta_unit
        '
        Me.txt_precio_venta_unit.Location = New System.Drawing.Point(685, 44)
        Me.txt_precio_venta_unit.Name = "txt_precio_venta_unit"
        Me.txt_precio_venta_unit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_precio_venta_unit.Properties.Appearance.Options.UseBackColor = True
        Me.txt_precio_venta_unit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_precio_venta_unit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_precio_venta_unit.Properties.Mask.EditMask = "n0"
        Me.txt_precio_venta_unit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_precio_venta_unit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_precio_venta_unit.Size = New System.Drawing.Size(114, 22)
        Me.txt_precio_venta_unit.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(533, 48)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl4.TabIndex = 29
        Me.LabelControl4.Text = "Precio venta unitario:"
        '
        'txt_recargo
        '
        Me.txt_recargo.Location = New System.Drawing.Point(639, 44)
        Me.txt_recargo.Name = "txt_recargo"
        Me.txt_recargo.Properties.AllowMouseWheel = False
        Me.txt_recargo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_recargo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_recargo.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_recargo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_recargo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_recargo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_recargo.Properties.Mask.EditMask = "n"
        Me.txt_recargo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_recargo.Size = New System.Drawing.Size(40, 22)
        Me.txt_recargo.TabIndex = 9
        '
        'txt_total_comision
        '
        Me.txt_total_comision.Location = New System.Drawing.Point(681, 100)
        Me.txt_total_comision.Name = "txt_total_comision"
        Me.txt_total_comision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_comision.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_comision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_comision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_comision.Properties.Mask.EditMask = "n0"
        Me.txt_total_comision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_comision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_comision.Size = New System.Drawing.Size(118, 22)
        Me.txt_total_comision.TabIndex = 13
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(559, 104)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl18.TabIndex = 23
        Me.LabelControl18.Text = "Comision Venta:"
        '
        'txt_porc_comision
        '
        Me.txt_porc_comision.Location = New System.Drawing.Point(639, 100)
        Me.txt_porc_comision.Name = "txt_porc_comision"
        Me.txt_porc_comision.Properties.AllowMouseWheel = False
        Me.txt_porc_comision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_porc_comision.Properties.Appearance.Options.UseBackColor = True
        Me.txt_porc_comision.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_porc_comision.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_porc_comision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_porc_comision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_porc_comision.Properties.Mask.EditMask = "n"
        Me.txt_porc_comision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_porc_comision.Size = New System.Drawing.Size(40, 22)
        Me.txt_porc_comision.TabIndex = 12
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 19)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Nro. Pedido:"
        '
        'txt_num_pedido
        '
        Me.txt_num_pedido.Location = New System.Drawing.Point(94, 15)
        Me.txt_num_pedido.Name = "txt_num_pedido"
        Me.txt_num_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_num_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_num_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_num_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_num_pedido.Properties.ReadOnly = True
        Me.txt_num_pedido.Size = New System.Drawing.Size(158, 22)
        Me.txt_num_pedido.TabIndex = 0
        '
        'txt_total_venta
        '
        Me.txt_total_venta.Location = New System.Drawing.Point(20, 37)
        Me.txt_total_venta.Name = "txt_total_venta"
        Me.txt_total_venta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_venta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_venta.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_venta.Properties.Appearance.Options.UseFont = True
        Me.txt_total_venta.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total_venta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_total_venta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_venta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_venta.Properties.Mask.EditMask = "n0"
        Me.txt_total_venta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_venta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_venta.Properties.ReadOnly = True
        Me.txt_total_venta.Size = New System.Drawing.Size(148, 38)
        Me.txt_total_venta.TabIndex = 12
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(48, 11)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(93, 23)
        Me.LabelControl20.TabIndex = 25
        Me.LabelControl20.Text = "Total venta"
        '
        'btn_quitar_materia_prima
        '
        Me.btn_quitar_materia_prima.Location = New System.Drawing.Point(658, 218)
        Me.btn_quitar_materia_prima.Name = "btn_quitar_materia_prima"
        Me.btn_quitar_materia_prima.Size = New System.Drawing.Size(74, 22)
        Me.btn_quitar_materia_prima.TabIndex = 25
        Me.btn_quitar_materia_prima.Text = "Quitar"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btn_cancelar)
        Me.PanelControl3.Controls.Add(Me.btn_confirmar)
        Me.PanelControl3.Controls.Add(Me.btn_pedidos)
        Me.PanelControl3.Location = New System.Drawing.Point(828, 145)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(188, 409)
        Me.PanelControl3.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(36, 101)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.tab_costeo)
        Me.TabPane1.Controls.Add(Me.tab_mano_obra)
        Me.TabPane1.Location = New System.Drawing.Point(2, 1)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_costeo, Me.tab_mano_obra})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1040, 605)
        Me.TabPane1.SelectedPage = Me.tab_costeo
        Me.TabPane1.Size = New System.Drawing.Size(1040, 605)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'tab_costeo
        '
        Me.tab_costeo.AllowTouchScroll = True
        Me.tab_costeo.AutoScroll = True
        Me.tab_costeo.AutoSize = True
        Me.tab_costeo.Caption = "Costeo del Pedido"
        Me.tab_costeo.Controls.Add(Me.PanelControl1)
        Me.tab_costeo.Controls.Add(Me.PanelControl3)
        Me.tab_costeo.Controls.Add(Me.GroupBox1)
        Me.tab_costeo.Controls.Add(Me.btn_quitar_materia_prima)
        Me.tab_costeo.Controls.Add(Me.btn_agregar_material)
        Me.tab_costeo.Controls.Add(Me.PanelControl2)
        Me.tab_costeo.Controls.Add(Me.grid_materiales)
        Me.tab_costeo.Name = "tab_costeo"
        Me.tab_costeo.Size = New System.Drawing.Size(1022, 560)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txt_total_venta)
        Me.PanelControl1.Controls.Add(Me.LabelControl20)
        Me.PanelControl1.Location = New System.Drawing.Point(828, 11)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(188, 126)
        Me.PanelControl1.TabIndex = 26
        '
        'tab_mano_obra
        '
        Me.tab_mano_obra.Caption = "Mano de Obra"
        Me.tab_mano_obra.Controls.Add(Me.btn_agregar)
        Me.tab_mano_obra.Controls.Add(Me.btn_quitar_empleado)
        Me.tab_mano_obra.Controls.Add(Me.GroupBox2)
        Me.tab_mano_obra.Controls.Add(Me.grid_asignacion)
        Me.tab_mano_obra.Name = "tab_mano_obra"
        Me.tab_mano_obra.Size = New System.Drawing.Size(1022, 560)
        '
        'btn_agregar
        '
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.Location = New System.Drawing.Point(714, 165)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(74, 22)
        Me.btn_agregar.TabIndex = 27
        Me.btn_agregar.Text = "Agregar"
        '
        'btn_quitar_empleado
        '
        Me.btn_quitar_empleado.Location = New System.Drawing.Point(794, 165)
        Me.btn_quitar_empleado.Name = "btn_quitar_empleado"
        Me.btn_quitar_empleado.Size = New System.Drawing.Size(74, 22)
        Me.btn_quitar_empleado.TabIndex = 26
        Me.btn_quitar_empleado.Text = "Quitar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_fecha_pedi)
        Me.GroupBox2.Controls.Add(Me.txt_nro_pedido)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.LabelControl13)
        Me.GroupBox2.Controls.Add(Me.txt_extra)
        Me.GroupBox2.Controls.Add(Me.LabelControl14)
        Me.GroupBox2.Controls.Add(Me.txt_mano_obra)
        Me.GroupBox2.Controls.Add(Me.txt_id_pedido)
        Me.GroupBox2.Controls.Add(Me.LabelControl15)
        Me.GroupBox2.Controls.Add(Me.LabelControl16)
        Me.GroupBox2.Controls.Add(Me.LabelControl17)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(858, 123)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Pedido"
        '
        'txt_fecha_pedi
        '
        Me.txt_fecha_pedi.Location = New System.Drawing.Point(152, 50)
        Me.txt_fecha_pedi.Name = "txt_fecha_pedi"
        Me.txt_fecha_pedi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_pedi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_pedi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_pedi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha_pedi.Properties.ReadOnly = True
        Me.txt_fecha_pedi.Size = New System.Drawing.Size(260, 22)
        Me.txt_fecha_pedi.TabIndex = 14
        '
        'txt_nro_pedido
        '
        Me.txt_nro_pedido.Location = New System.Drawing.Point(197, 22)
        Me.txt_nro_pedido.Name = "txt_nro_pedido"
        Me.txt_nro_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_pedido.Properties.ReadOnly = True
        Me.txt_nro_pedido.Size = New System.Drawing.Size(215, 22)
        Me.txt_nro_pedido.TabIndex = 13
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(502, 50)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cantidad.Properties.ReadOnly = True
        Me.txt_cantidad.Size = New System.Drawing.Size(260, 22)
        Me.txt_cantidad.TabIndex = 12
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl13.Location = New System.Drawing.Point(467, 26)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl13.TabIndex = 11
        Me.LabelControl13.Text = "Extra:"
        '
        'txt_extra
        '
        Me.txt_extra.Location = New System.Drawing.Point(502, 20)
        Me.txt_extra.Name = "txt_extra"
        Me.txt_extra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_extra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_extra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_extra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_extra.Properties.Mask.EditMask = "n0"
        Me.txt_extra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_extra.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_extra.Properties.ReadOnly = True
        Me.txt_extra.Size = New System.Drawing.Size(260, 22)
        Me.txt_extra.TabIndex = 10
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl14.Location = New System.Drawing.Point(449, 54)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl14.TabIndex = 8
        Me.LabelControl14.Text = "Cantidad:"
        '
        'txt_mano_obra
        '
        Me.txt_mano_obra.Location = New System.Drawing.Point(152, 79)
        Me.txt_mano_obra.Name = "txt_mano_obra"
        Me.txt_mano_obra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_mano_obra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_mano_obra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_mano_obra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mano_obra.Properties.Mask.EditMask = "n0"
        Me.txt_mano_obra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_mano_obra.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_mano_obra.Properties.ReadOnly = True
        Me.txt_mano_obra.Size = New System.Drawing.Size(260, 22)
        Me.txt_mano_obra.TabIndex = 2
        '
        'txt_id_pedido
        '
        Me.txt_id_pedido.Location = New System.Drawing.Point(152, 22)
        Me.txt_id_pedido.Name = "txt_id_pedido"
        Me.txt_id_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_pedido.Properties.ReadOnly = True
        Me.txt_id_pedido.Size = New System.Drawing.Size(44, 22)
        Me.txt_id_pedido.TabIndex = 3
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl15.Location = New System.Drawing.Point(75, 85)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl15.TabIndex = 5
        Me.LabelControl15.Text = "Mano de Obra:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl16.Location = New System.Drawing.Point(77, 56)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl16.TabIndex = 3
        Me.LabelControl16.Text = "Fecha Pedido:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl17.Location = New System.Drawing.Point(106, 27)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl17.TabIndex = 0
        Me.LabelControl17.Text = "Numero:"
        '
        'grid_asignacion
        '
        Me.grid_asignacion.Location = New System.Drawing.Point(30, 153)
        Me.grid_asignacion.MainView = Me.GridView2
        Me.grid_asignacion.Name = "grid_asignacion"
        Me.grid_asignacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_txt_empleado, Me.rps_txt_cantidad, Me.rps_txt_mano_obra, Me.rps_txt_id_empleado, Me.rps_txt_total, Me.rps_txt_pago_extra})
        Me.grid_asignacion.Size = New System.Drawing.Size(858, 314)
        Me.grid_asignacion.TabIndex = 3
        Me.grid_asignacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_empleado, Me.col_empleado, Me.GridColumn2, Me.col_mano_obra, Me.col_total, Me.GridColumn3, Me.col_id_asignacion, Me.col_nuevo})
        Me.GridView2.GridControl = Me.grid_asignacion
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsFind.ShowClearButton = False
        Me.GridView2.OptionsFind.ShowCloseButton = False
        Me.GridView2.OptionsFind.ShowFindButton = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'col_id_empleado
        '
        Me.col_id_empleado.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_id_empleado.AppearanceCell.Options.UseBorderColor = True
        Me.col_id_empleado.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empleado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empleado.Caption = "Id Empleado"
        Me.col_id_empleado.ColumnEdit = Me.rps_txt_id_empleado
        Me.col_id_empleado.FieldName = "id_empleado"
        Me.col_id_empleado.Name = "col_id_empleado"
        Me.col_id_empleado.Width = 140
        '
        'rps_txt_id_empleado
        '
        Me.rps_txt_id_empleado.AutoHeight = False
        Me.rps_txt_id_empleado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rps_txt_id_empleado.Name = "rps_txt_id_empleado"
        '
        'col_empleado
        '
        Me.col_empleado.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_empleado.AppearanceCell.Options.UseBorderColor = True
        Me.col_empleado.Caption = "Empleado"
        Me.col_empleado.ColumnEdit = Me.rps_txt_empleado
        Me.col_empleado.FieldName = "empleado"
        Me.col_empleado.Name = "col_empleado"
        Me.col_empleado.OptionsColumn.ReadOnly = True
        Me.col_empleado.Visible = True
        Me.col_empleado.VisibleIndex = 0
        Me.col_empleado.Width = 243
        '
        'rps_txt_empleado
        '
        Me.rps_txt_empleado.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_empleado.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_empleado.AutoHeight = False
        Me.rps_txt_empleado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_empleado.Name = "rps_txt_empleado"
        Me.rps_txt_empleado.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn2.Caption = "Cantidad Asignada"
        Me.GridColumn2.ColumnEdit = Me.rps_txt_cantidad
        Me.GridColumn2.FieldName = "cantidad"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 123
        '
        'rps_txt_cantidad
        '
        Me.rps_txt_cantidad.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_cantidad.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_cantidad.AutoHeight = False
        Me.rps_txt_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_cantidad.Name = "rps_txt_cantidad"
        '
        'col_mano_obra
        '
        Me.col_mano_obra.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_mano_obra.AppearanceCell.Options.UseBorderColor = True
        Me.col_mano_obra.Caption = "Mano de Obra"
        Me.col_mano_obra.ColumnEdit = Me.rps_txt_mano_obra
        Me.col_mano_obra.DisplayFormat.FormatString = "#,#"
        Me.col_mano_obra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_mano_obra.FieldName = "mano_obra"
        Me.col_mano_obra.Name = "col_mano_obra"
        Me.col_mano_obra.OptionsColumn.ReadOnly = True
        Me.col_mano_obra.Visible = True
        Me.col_mano_obra.VisibleIndex = 2
        Me.col_mano_obra.Width = 121
        '
        'rps_txt_mano_obra
        '
        Me.rps_txt_mano_obra.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_mano_obra.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_mano_obra.AutoHeight = False
        Me.rps_txt_mano_obra.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_mano_obra.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_mano_obra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_txt_mano_obra.Mask.EditMask = "n0"
        Me.rps_txt_mano_obra.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_mano_obra.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_mano_obra.Name = "rps_txt_mano_obra"
        Me.rps_txt_mano_obra.ReadOnly = True
        '
        'col_total
        '
        Me.col_total.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_total.AppearanceCell.Options.UseBorderColor = True
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.rps_txt_total
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 101
        '
        'rps_txt_total
        '
        Me.rps_txt_total.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_total.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_total.AutoHeight = False
        Me.rps_txt_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_total.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_txt_total.Mask.EditMask = "n0"
        Me.rps_txt_total.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_total.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_total.Name = "rps_txt_total"
        Me.rps_txt_total.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Extra"
        Me.GridColumn3.ColumnEdit = Me.rps_txt_pago_extra
        Me.GridColumn3.DisplayFormat.FormatString = "#,#"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "pago_extra"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 116
        '
        'rps_txt_pago_extra
        '
        Me.rps_txt_pago_extra.AutoHeight = False
        Me.rps_txt_pago_extra.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_pago_extra.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_pago_extra.Mask.EditMask = "n0"
        Me.rps_txt_pago_extra.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_pago_extra.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_pago_extra.Name = "rps_txt_pago_extra"
        '
        'col_id_asignacion
        '
        Me.col_id_asignacion.Caption = "Id Asignacion"
        Me.col_id_asignacion.FieldName = "id_asignacion_pedido_empleado"
        Me.col_id_asignacion.Name = "col_id_asignacion"
        '
        'col_nuevo
        '
        Me.col_nuevo.Caption = "nuevo"
        Me.col_nuevo.FieldName = "nuevo"
        Me.col_nuevo.Name = "col_nuevo"
        '
        'frm_costeo_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 611)
        Me.Controls.Add(Me.TabPane1)
        Me.Name = "frm_costeo_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Costeo de Pedido>>"
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_costo_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_costo_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cantidad_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_descuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_extra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_mano_obra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_costo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_descuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_extra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_materia_prima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_materia_prima_unidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_precio_venta_unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_recargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_comision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_porc_comision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabPane1.PerformLayout()
        Me.tab_costeo.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.tab_mano_obra.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_fecha_pedi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_extra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mano_obra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_asignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_id_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_mano_obra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_pago_extra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_materiales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_pedidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rps_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_costo_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_agregar_material As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_descripcion_articulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rps_descuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_extra As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_costo_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total_costo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_descuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_extra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_materia_prima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_cantidad_articulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_cantidad_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_cantidad_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_descto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_extra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_material As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_codigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total_mano_obra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_quitar_materia_prima As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab_costeo As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tab_mano_obra As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_cantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_extra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_mano_obra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_asignacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_id_empleado As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_empleado As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_mano_obra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_mano_obra As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_pago_extra As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_id_asignacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nuevo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_fecha_pedi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_quitar_empleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_total_comision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_porc_comision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_num_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_recargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_precio_venta_unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_costo_unitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_materia_prima_unidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
