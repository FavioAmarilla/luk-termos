<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_compras))
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_buscar_compras = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_factura = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_total_gasto = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_total_gasto = New DevExpress.XtraEditors.LabelControl()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_movim_stock = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_id_compra = New DevExpress.XtraEditors.TextEdit()
        Me.btn_proveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_tipo_compra = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_tipo_compra = New DevExpress.XtraEditors.TextEdit()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txt_tipo_compra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_id_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_compra = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.grid_items_tmp = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.controlar_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_quitar_item = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_item = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_id_item = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_item = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_total_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_item_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_movim_item_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nuevo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_codigo_barras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_controlar_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_iva = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_cod_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_proveedor_fact = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.cbo_tipo_comprobante = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_factura_total = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_numero_factura = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fac_iva5 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fact_gravadas5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fac_iva10 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fact_gravadas10 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_exentas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cbo_factura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_gasto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_movim_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_compra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_tipo_compra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tipo_compra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.grid_items_tmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grid_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_id_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_total_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_codigo_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_iva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txt_cod_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor_fact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.cbo_tipo_comprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_factura_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero_factura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fac_iva5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fact_gravadas5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fac_iva10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fact_gravadas10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_exentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage4.SuspendLayout()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.btn_buscar_compras)
        Me.PanelControl8.Controls.Add(Me.btn_cancelar)
        Me.PanelControl8.Controls.Add(Me.btn_confirmar)
        Me.PanelControl8.Controls.Add(Me.btn_nuevo)
        Me.PanelControl8.Location = New System.Drawing.Point(935, 18)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(161, 527)
        Me.PanelControl8.TabIndex = 0
        '
        'btn_buscar_compras
        '
        Me.btn_buscar_compras.Image = CType(resources.GetObject("btn_buscar_compras.Image"), System.Drawing.Image)
        Me.btn_buscar_compras.Location = New System.Drawing.Point(22, 52)
        Me.btn_buscar_compras.Name = "btn_buscar_compras"
        Me.btn_buscar_compras.Size = New System.Drawing.Size(117, 35)
        Me.btn_buscar_compras.TabIndex = 1
        Me.btn_buscar_compras.Text = "Buscar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(22, 134)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(22, 92)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 2
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(22, 14)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl24)
        Me.PanelControl2.Controls.Add(Me.cbo_factura)
        Me.PanelControl2.Controls.Add(Me.txt_total_gasto)
        Me.PanelControl2.Controls.Add(Me.lbl_total_gasto)
        Me.PanelControl2.Controls.Add(Me.btn_buscar_sucursal)
        Me.PanelControl2.Controls.Add(Me.txt_movim_stock)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txt_fecha)
        Me.PanelControl2.Controls.Add(Me.txt_id_compra)
        Me.PanelControl2.Controls.Add(Me.btn_proveedor)
        Me.PanelControl2.Controls.Add(Me.btn_tipo_compra)
        Me.PanelControl2.Controls.Add(Me.txt_id_proveedor)
        Me.PanelControl2.Controls.Add(Me.txt_id_tipo_compra)
        Me.PanelControl2.Controls.Add(Me.txt_proveedor)
        Me.PanelControl2.Controls.Add(Me.txt_tipo_compra)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txt_id_usuario)
        Me.PanelControl2.Controls.Add(Me.txt_id_sucursal)
        Me.PanelControl2.Controls.Add(Me.txt_usuario)
        Me.PanelControl2.Controls.Add(Me.txt_sucursal)
        Me.PanelControl2.Controls.Add(Me.txt_numero)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(19, 18)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(680, 168)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(380, 42)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl24.TabIndex = 26
        Me.LabelControl24.Text = "Factura:"
        '
        'cbo_factura
        '
        Me.cbo_factura.Location = New System.Drawing.Point(427, 38)
        Me.cbo_factura.Name = "cbo_factura"
        Me.cbo_factura.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_factura.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_factura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_factura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_factura.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_factura.Properties.ImmediatePopup = True
        Me.cbo_factura.Properties.Items.AddRange(New Object() {"SIN FACTURA", "CON FACTURA"})
        Me.cbo_factura.Size = New System.Drawing.Size(182, 22)
        Me.cbo_factura.TabIndex = 25
        '
        'txt_total_gasto
        '
        Me.txt_total_gasto.Location = New System.Drawing.Point(427, 62)
        Me.txt_total_gasto.Name = "txt_total_gasto"
        Me.txt_total_gasto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_gasto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_gasto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_gasto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total_gasto.Properties.Mask.EditMask = "n0"
        Me.txt_total_gasto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_gasto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_gasto.Size = New System.Drawing.Size(247, 22)
        Me.txt_total_gasto.TabIndex = 23
        Me.txt_total_gasto.Visible = False
        '
        'lbl_total_gasto
        '
        Me.lbl_total_gasto.Location = New System.Drawing.Point(353, 67)
        Me.lbl_total_gasto.Name = "lbl_total_gasto"
        Me.lbl_total_gasto.Size = New System.Drawing.Size(68, 13)
        Me.lbl_total_gasto.TabIndex = 24
        Me.lbl_total_gasto.Text = "Total Compra:"
        Me.lbl_total_gasto.Visible = False
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(307, 14)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 21)
        Me.btn_buscar_sucursal.TabIndex = 22
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_movim_stock
        '
        Me.txt_movim_stock.Location = New System.Drawing.Point(427, 88)
        Me.txt_movim_stock.Name = "txt_movim_stock"
        Me.txt_movim_stock.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_movim_stock.Properties.Appearance.Options.UseBackColor = True
        Me.txt_movim_stock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_movim_stock.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_movim_stock.Properties.ReadOnly = True
        Me.txt_movim_stock.Size = New System.Drawing.Size(247, 22)
        Me.txt_movim_stock.TabIndex = 7
        Me.txt_movim_stock.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(359, 94)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Mv de Stock:"
        Me.LabelControl1.Visible = False
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Location = New System.Drawing.Point(427, 15)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(247, 21)
        Me.txt_fecha.TabIndex = 3
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'txt_id_compra
        '
        Me.txt_id_compra.Location = New System.Drawing.Point(86, 88)
        Me.txt_id_compra.Name = "txt_id_compra"
        Me.txt_id_compra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_compra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_compra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_compra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_compra.Properties.ReadOnly = True
        Me.txt_id_compra.Size = New System.Drawing.Size(35, 22)
        Me.txt_id_compra.TabIndex = 18
        Me.txt_id_compra.Visible = False
        '
        'btn_proveedor
        '
        Me.btn_proveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_proveedor.Location = New System.Drawing.Point(306, 62)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(27, 21)
        Me.btn_proveedor.TabIndex = 17
        Me.btn_proveedor.Text = "+"
        '
        'btn_tipo_compra
        '
        Me.btn_tipo_compra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_tipo_compra.Location = New System.Drawing.Point(306, 38)
        Me.btn_tipo_compra.Name = "btn_tipo_compra"
        Me.btn_tipo_compra.Size = New System.Drawing.Size(27, 21)
        Me.btn_tipo_compra.TabIndex = 14
        Me.btn_tipo_compra.Text = "+"
        '
        'txt_id_proveedor
        '
        Me.txt_id_proveedor.Location = New System.Drawing.Point(86, 62)
        Me.txt_id_proveedor.Name = "txt_id_proveedor"
        Me.txt_id_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_proveedor.Properties.ReadOnly = True
        Me.txt_id_proveedor.Size = New System.Drawing.Size(35, 22)
        Me.txt_id_proveedor.TabIndex = 16
        '
        'txt_id_tipo_compra
        '
        Me.txt_id_tipo_compra.Location = New System.Drawing.Point(86, 38)
        Me.txt_id_tipo_compra.Name = "txt_id_tipo_compra"
        Me.txt_id_tipo_compra.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_tipo_compra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_tipo_compra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_tipo_compra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_tipo_compra.Properties.ReadOnly = True
        Me.txt_id_tipo_compra.Size = New System.Drawing.Size(35, 22)
        Me.txt_id_tipo_compra.TabIndex = 15
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(123, 62)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(180, 22)
        Me.txt_proveedor.TabIndex = 2
        '
        'txt_tipo_compra
        '
        Me.txt_tipo_compra.Location = New System.Drawing.Point(123, 38)
        Me.txt_tipo_compra.Name = "txt_tipo_compra"
        Me.txt_tipo_compra.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_tipo_compra.Properties.Appearance.Options.UseBackColor = True
        Me.txt_tipo_compra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_tipo_compra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tipo_compra.Properties.ReadOnly = True
        Me.txt_tipo_compra.Size = New System.Drawing.Size(180, 22)
        Me.txt_tipo_compra.TabIndex = 1
        Me.txt_tipo_compra.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(5, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Tipo de Compra:"
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.Location = New System.Drawing.Point(86, 114)
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_usuario.Properties.ReadOnly = True
        Me.txt_id_usuario.Size = New System.Drawing.Size(35, 22)
        Me.txt_id_usuario.TabIndex = 11
        Me.txt_id_usuario.Visible = False
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(86, 13)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(35, 22)
        Me.txt_id_sucursal.TabIndex = 10
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(123, 114)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuario.Properties.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(207, 22)
        Me.txt_usuario.TabIndex = 5
        Me.txt_usuario.Visible = False
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(123, 14)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(180, 22)
        Me.txt_sucursal.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(123, 89)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_numero.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Properties.ReadOnly = True
        Me.txt_numero.Size = New System.Drawing.Size(208, 22)
        Me.txt_numero.TabIndex = 0
        Me.txt_numero.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(43, 118)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Usuario:"
        Me.LabelControl7.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(30, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Proveedor:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Sucursal:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(388, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Fecha:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(43, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Numero:"
        Me.LabelControl3.Visible = False
        '
        'lbl_total_compra
        '
        Me.lbl_total_compra.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.lbl_total_compra.Location = New System.Drawing.Point(41, 72)
        Me.lbl_total_compra.Name = "lbl_total_compra"
        Me.lbl_total_compra.Size = New System.Drawing.Size(139, 33)
        Me.lbl_total_compra.TabIndex = 0
        Me.lbl_total_compra.Text = "110.000 GS"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(43, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(134, 24)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Total Compra"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.LabelControl2)
        Me.PanelControl6.Controls.Add(Me.lbl_total_compra)
        Me.PanelControl6.Location = New System.Drawing.Point(705, 18)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(220, 136)
        Me.PanelControl6.TabIndex = 2
        '
        'grid_items_tmp
        '
        Me.grid_items_tmp.Location = New System.Drawing.Point(14, 268)
        Me.grid_items_tmp.MainView = Me.GridView2
        Me.grid_items_tmp.Name = "grid_items_tmp"
        Me.grid_items_tmp.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5})
        Me.grid_items_tmp.Size = New System.Drawing.Size(816, 34)
        Me.grid_items_tmp.TabIndex = 3
        Me.grid_items_tmp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.grid_items_tmp.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.controlar_stock, Me.GridColumn9, Me.precio_venta})
        Me.GridView2.GridControl = Me.grid_items_tmp
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn1.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Id Item"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "id_item"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Width = 140
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn2.Caption = "Item"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn2.FieldName = "item"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 275
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn3.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn3.Caption = "Costo Unitario"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn3.DisplayFormat.FormatString = "#,#"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "total_unitario"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Total"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GridColumn4.DisplayFormat.FormatString = "#,#"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "total"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cantidad"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn5.DisplayFormat.FormatString = "0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn5.FieldName = "cantidad"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "id_item_compra"
        Me.GridColumn6.FieldName = "id_item_compra"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "id_movim_item_stock"
        Me.GridColumn7.FieldName = "id_item_mv_stock"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nuevo"
        Me.GridColumn8.FieldName = "nuevo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        '
        'controlar_stock
        '
        Me.controlar_stock.Caption = "controlar_stock"
        Me.controlar_stock.FieldName = "controlar_stock"
        Me.controlar_stock.Name = "controlar_stock"
        Me.controlar_stock.Visible = True
        Me.controlar_stock.VisibleIndex = 5
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "id_proveedor"
        Me.GridColumn9.FieldName = "id_proveedor"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'precio_venta
        '
        Me.precio_venta.Caption = "precio_venta"
        Me.precio_venta.FieldName = "precio_venta"
        Me.precio_venta.Name = "precio_venta"
        Me.precio_venta.Visible = True
        Me.precio_venta.VisibleIndex = 7
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemTextEdit6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Location = New System.Drawing.Point(19, 192)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage3, Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(907, 375)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(907, 375)
        Me.TabPane1.TabIndex = 6
        Me.TabPane1.Text = "TabPane1FF"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Items de Compras"
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl1)
        Me.TabNavigationPage1.Image = CType(resources.GetObject("TabNavigationPage1.Image"), System.Drawing.Image)
        Me.TabNavigationPage1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage1.Size = New System.Drawing.Size(889, 327)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grid_items_tmp)
        Me.PanelControl1.Controls.Add(Me.btn_quitar_item)
        Me.PanelControl1.Controls.Add(Me.grid_item)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(879, 312)
        Me.PanelControl1.TabIndex = 2
        '
        'btn_quitar_item
        '
        Me.btn_quitar_item.Location = New System.Drawing.Point(833, 14)
        Me.btn_quitar_item.Name = "btn_quitar_item"
        Me.btn_quitar_item.Size = New System.Drawing.Size(41, 23)
        Me.btn_quitar_item.TabIndex = 1
        Me.btn_quitar_item.Text = "Quitar"
        '
        'grid_item
        '
        Me.grid_item.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_item.Location = New System.Drawing.Point(11, 14)
        Me.grid_item.MainView = Me.GridView1
        Me.grid_item.Name = "grid_item"
        Me.grid_item.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_txt_item, Me.rps_txt_iva, Me.rps_txt_id_item, Me.rps_txt_total_unitario, Me.rps_txt_total, Me.rps_txt_cantidad, Me.rps_txt_codigo_barras})
        Me.grid_item.Size = New System.Drawing.Size(816, 248)
        Me.grid_item.TabIndex = 0
        Me.grid_item.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_item, Me.col_item, Me.col_total_unitario, Me.col_total, Me.col_cantidad, Me.col_id_item_compra, Me.col_id_movim_item_stock, Me.col_nuevo, Me.col_codigo_barras, Me.col_controlar_stock, Me.col_id_proveedor, Me.col_precio_venta})
        Me.GridView1.GridControl = Me.grid_item
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsPrint.PrintSelectedRowsOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'col_id_item
        '
        Me.col_id_item.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_id_item.AppearanceCell.Options.UseBorderColor = True
        Me.col_id_item.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_item.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_item.Caption = "Id Item"
        Me.col_id_item.ColumnEdit = Me.rps_txt_id_item
        Me.col_id_item.FieldName = "id_item"
        Me.col_id_item.Name = "col_id_item"
        Me.col_id_item.OptionsColumn.ReadOnly = True
        Me.col_id_item.Width = 140
        '
        'rps_txt_id_item
        '
        Me.rps_txt_id_item.AutoHeight = False
        Me.rps_txt_id_item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rps_txt_id_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rps_txt_id_item.Name = "rps_txt_id_item"
        Me.rps_txt_id_item.ReadOnly = True
        '
        'col_item
        '
        Me.col_item.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_item.AppearanceCell.Options.UseBorderColor = True
        Me.col_item.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.col_item.AppearanceHeader.Options.UseBorderColor = True
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.rps_txt_item
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.OptionsColumn.ReadOnly = True
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 319
        '
        'rps_txt_item
        '
        Me.rps_txt_item.AutoHeight = False
        Me.rps_txt_item.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rps_txt_item.Name = "rps_txt_item"
        Me.rps_txt_item.ValidateOnEnterKey = True
        '
        'col_total_unitario
        '
        Me.col_total_unitario.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_total_unitario.AppearanceCell.Options.UseBorderColor = True
        Me.col_total_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_unitario.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.col_total_unitario.AppearanceHeader.Options.UseBorderColor = True
        Me.col_total_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_unitario.Caption = "Costo Unitario"
        Me.col_total_unitario.ColumnEdit = Me.rps_txt_total_unitario
        Me.col_total_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_total_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_unitario.FieldName = "total_unitario"
        Me.col_total_unitario.Name = "col_total_unitario"
        Me.col_total_unitario.Visible = True
        Me.col_total_unitario.VisibleIndex = 3
        Me.col_total_unitario.Width = 114
        '
        'rps_txt_total_unitario
        '
        Me.rps_txt_total_unitario.AutoHeight = False
        Me.rps_txt_total_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_total_unitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rps_txt_total_unitario.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_total_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_txt_total_unitario.Mask.EditMask = "n0"
        Me.rps_txt_total_unitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_total_unitario.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_total_unitario.Name = "rps_txt_total_unitario"
        '
        'col_total
        '
        Me.col_total.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_total.AppearanceCell.Options.UseBorderColor = True
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.col_total.AppearanceHeader.Options.UseBorderColor = True
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.rps_txt_total
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 121
        '
        'rps_txt_total
        '
        Me.rps_txt_total.AutoHeight = False
        Me.rps_txt_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rps_txt_total.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_txt_total.Mask.EditMask = "n0"
        Me.rps_txt_total.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_total.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_total.Name = "rps_txt_total"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_cantidad.AppearanceCell.Options.UseBorderColor = True
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.BorderColor = System.Drawing.Color.White
        Me.col_cantidad.AppearanceHeader.Options.UseBorderColor = True
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rps_txt_cantidad
        Me.col_cantidad.DisplayFormat.FormatString = "0.00"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 2
        Me.col_cantidad.Width = 114
        '
        'rps_txt_cantidad
        '
        Me.rps_txt_cantidad.AutoHeight = False
        Me.rps_txt_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_cantidad.Name = "rps_txt_cantidad"
        '
        'col_id_item_compra
        '
        Me.col_id_item_compra.Caption = "id_item_compra"
        Me.col_id_item_compra.FieldName = "id_item_compra"
        Me.col_id_item_compra.Name = "col_id_item_compra"
        '
        'col_id_movim_item_stock
        '
        Me.col_id_movim_item_stock.Caption = "id_movim_item_stock"
        Me.col_id_movim_item_stock.FieldName = "id_item_mv_stock"
        Me.col_id_movim_item_stock.Name = "col_id_movim_item_stock"
        '
        'col_nuevo
        '
        Me.col_nuevo.Caption = "Nuevo"
        Me.col_nuevo.FieldName = "nuevo"
        Me.col_nuevo.Name = "col_nuevo"
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.Caption = "Código Barras"
        Me.col_codigo_barras.ColumnEdit = Me.rps_txt_codigo_barras
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 130
        '
        'rps_txt_codigo_barras
        '
        Me.rps_txt_codigo_barras.AutoHeight = False
        Me.rps_txt_codigo_barras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_codigo_barras.Name = "rps_txt_codigo_barras"
        '
        'col_controlar_stock
        '
        Me.col_controlar_stock.Caption = "controlar_stock"
        Me.col_controlar_stock.FieldName = "controlar_stock"
        Me.col_controlar_stock.Name = "col_controlar_stock"
        '
        'col_id_proveedor
        '
        Me.col_id_proveedor.Caption = "id_proveedor"
        Me.col_id_proveedor.FieldName = "id_proveedor"
        Me.col_id_proveedor.Name = "col_id_proveedor"
        '
        'col_precio_venta
        '
        Me.col_precio_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_venta.Caption = "Precio Venta"
        Me.col_precio_venta.FieldName = "precio_venta"
        Me.col_precio_venta.Name = "col_precio_venta"
        '
        'rps_txt_iva
        '
        Me.rps_txt_iva.AutoHeight = False
        Me.rps_txt_iva.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rps_txt_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rps_txt_iva.Name = "rps_txt_iva"
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "Facturas"
        Me.TabNavigationPage3.Controls.Add(Me.PanelControl4)
        Me.TabNavigationPage3.Controls.Add(Me.PanelControl3)
        Me.TabNavigationPage3.Controls.Add(Me.TabNavigationPage4)
        Me.TabNavigationPage3.Image = CType(resources.GetObject("TabNavigationPage3.Image"), System.Drawing.Image)
        Me.TabNavigationPage3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabNavigationPage3.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage3.Size = New System.Drawing.Size(889, 408)
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.txt_cod_proveedor)
        Me.PanelControl4.Controls.Add(Me.LabelControl11)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.txt_proveedor_fact)
        Me.PanelControl4.Location = New System.Drawing.Point(98, 19)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(692, 100)
        Me.PanelControl4.TabIndex = 1
        '
        'txt_cod_proveedor
        '
        Me.txt_cod_proveedor.Enabled = False
        Me.txt_cod_proveedor.Location = New System.Drawing.Point(135, 59)
        Me.txt_cod_proveedor.Name = "txt_cod_proveedor"
        Me.txt_cod_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cod_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cod_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cod_proveedor.Properties.ReadOnly = True
        Me.txt_cod_proveedor.Size = New System.Drawing.Size(172, 22)
        Me.txt_cod_proveedor.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(97, 63)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl11.TabIndex = 5
        Me.LabelControl11.Text = "Codigo:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(80, 28)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl10.TabIndex = 3
        Me.LabelControl10.Text = "Proveedor:"
        '
        'txt_proveedor_fact
        '
        Me.txt_proveedor_fact.Enabled = False
        Me.txt_proveedor_fact.Location = New System.Drawing.Point(135, 25)
        Me.txt_proveedor_fact.Name = "txt_proveedor_fact"
        Me.txt_proveedor_fact.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_proveedor_fact.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor_fact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor_fact.Properties.ReadOnly = True
        Me.txt_proveedor_fact.Size = New System.Drawing.Size(256, 22)
        Me.txt_proveedor_fact.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.cbo_tipo_comprobante)
        Me.PanelControl3.Controls.Add(Me.LabelControl20)
        Me.PanelControl3.Controls.Add(Me.LabelControl21)
        Me.PanelControl3.Controls.Add(Me.LabelControl12)
        Me.PanelControl3.Controls.Add(Me.txt_factura_total)
        Me.PanelControl3.Controls.Add(Me.LabelControl23)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.LabelControl22)
        Me.PanelControl3.Controls.Add(Me.txt_numero_factura)
        Me.PanelControl3.Controls.Add(Me.txt_fac_iva5)
        Me.PanelControl3.Controls.Add(Me.txt_fact_gravadas5)
        Me.PanelControl3.Controls.Add(Me.LabelControl19)
        Me.PanelControl3.Controls.Add(Me.txt_fac_iva10)
        Me.PanelControl3.Controls.Add(Me.txt_fact_gravadas10)
        Me.PanelControl3.Controls.Add(Me.txt_exentas)
        Me.PanelControl3.Controls.Add(Me.LabelControl13)
        Me.PanelControl3.Location = New System.Drawing.Point(98, 131)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(692, 236)
        Me.PanelControl3.TabIndex = 0
        '
        'cbo_tipo_comprobante
        '
        Me.cbo_tipo_comprobante.Location = New System.Drawing.Point(135, 49)
        Me.cbo_tipo_comprobante.Name = "cbo_tipo_comprobante"
        Me.cbo_tipo_comprobante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_comprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_comprobante.Properties.ImmediatePopup = True
        Me.cbo_tipo_comprobante.Size = New System.Drawing.Size(208, 22)
        Me.cbo_tipo_comprobante.TabIndex = 24
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(375, 138)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl20.TabIndex = 23
        Me.LabelControl20.Text = "Iva 5%:"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(369, 169)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl21.TabIndex = 22
        Me.LabelControl21.Text = "Iva 10%:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(66, 80)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl12.TabIndex = 21
        Me.LabelControl12.Text = "Total Factura:"
        '
        'txt_factura_total
        '
        Me.txt_factura_total.Location = New System.Drawing.Point(135, 76)
        Me.txt_factura_total.Name = "txt_factura_total"
        Me.txt_factura_total.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_factura_total.Properties.Appearance.Options.UseBackColor = True
        Me.txt_factura_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_factura_total.Properties.Mask.EditMask = "n0"
        Me.txt_factura_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_factura_total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_factura_total.Size = New System.Drawing.Size(208, 22)
        Me.txt_factura_total.TabIndex = 2
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(42, 52)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl23.TabIndex = 20
        Me.LabelControl23.Text = "Tipo Comprobante:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(69, 24)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl9.TabIndex = 2
        Me.LabelControl9.Text = "Nro. Factura:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(75, 138)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl22.TabIndex = 17
        Me.LabelControl22.Text = "Gravadas 5:"
        '
        'txt_numero_factura
        '
        Me.txt_numero_factura.Location = New System.Drawing.Point(135, 20)
        Me.txt_numero_factura.Name = "txt_numero_factura"
        Me.txt_numero_factura.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_numero_factura.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero_factura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero_factura.Size = New System.Drawing.Size(208, 22)
        Me.txt_numero_factura.TabIndex = 0
        '
        'txt_fac_iva5
        '
        Me.txt_fac_iva5.Location = New System.Drawing.Point(417, 134)
        Me.txt_fac_iva5.Name = "txt_fac_iva5"
        Me.txt_fac_iva5.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fac_iva5.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fac_iva5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fac_iva5.Properties.Mask.EditMask = "n0"
        Me.txt_fac_iva5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_fac_iva5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_fac_iva5.Properties.ReadOnly = True
        Me.txt_fac_iva5.Size = New System.Drawing.Size(208, 22)
        Me.txt_fac_iva5.TabIndex = 7
        '
        'txt_fact_gravadas5
        '
        Me.txt_fact_gravadas5.Location = New System.Drawing.Point(135, 134)
        Me.txt_fact_gravadas5.Name = "txt_fact_gravadas5"
        Me.txt_fact_gravadas5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fact_gravadas5.Properties.Mask.EditMask = "n0"
        Me.txt_fact_gravadas5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_fact_gravadas5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_fact_gravadas5.Size = New System.Drawing.Size(208, 22)
        Me.txt_fact_gravadas5.TabIndex = 5
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(69, 169)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl19.TabIndex = 13
        Me.LabelControl19.Text = "Gravadas 10:"
        '
        'txt_fac_iva10
        '
        Me.txt_fac_iva10.Location = New System.Drawing.Point(417, 165)
        Me.txt_fac_iva10.Name = "txt_fac_iva10"
        Me.txt_fac_iva10.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fac_iva10.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fac_iva10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fac_iva10.Properties.Mask.EditMask = "n0"
        Me.txt_fac_iva10.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_fac_iva10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_fac_iva10.Properties.ReadOnly = True
        Me.txt_fac_iva10.Size = New System.Drawing.Size(208, 22)
        Me.txt_fac_iva10.TabIndex = 6
        '
        'txt_fact_gravadas10
        '
        Me.txt_fact_gravadas10.Location = New System.Drawing.Point(135, 165)
        Me.txt_fact_gravadas10.Name = "txt_fact_gravadas10"
        Me.txt_fact_gravadas10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fact_gravadas10.Properties.Mask.EditMask = "n0"
        Me.txt_fact_gravadas10.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_fact_gravadas10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_fact_gravadas10.Size = New System.Drawing.Size(208, 22)
        Me.txt_fact_gravadas10.TabIndex = 4
        '
        'txt_exentas
        '
        Me.txt_exentas.Location = New System.Drawing.Point(135, 104)
        Me.txt_exentas.Name = "txt_exentas"
        Me.txt_exentas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_exentas.Properties.Mask.EditMask = "n0"
        Me.txt_exentas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_exentas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_exentas.Size = New System.Drawing.Size(208, 22)
        Me.txt_exentas.TabIndex = 3
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(91, 108)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl13.TabIndex = 9
        Me.LabelControl13.Text = "Exentas:"
        '
        'TabNavigationPage4
        '
        Me.TabNavigationPage4.Caption = "Facturas"
        Me.TabNavigationPage4.Controls.Add(Me.LabelControl14)
        Me.TabNavigationPage4.Controls.Add(Me.TextEdit5)
        Me.TabNavigationPage4.Controls.Add(Me.LabelControl15)
        Me.TabNavigationPage4.Controls.Add(Me.TextEdit6)
        Me.TabNavigationPage4.Controls.Add(Me.LabelControl16)
        Me.TabNavigationPage4.Controls.Add(Me.TextEdit7)
        Me.TabNavigationPage4.Controls.Add(Me.LabelControl17)
        Me.TabNavigationPage4.Controls.Add(Me.LabelControl18)
        Me.TabNavigationPage4.Controls.Add(Me.TextEdit8)
        Me.TabNavigationPage4.Controls.Add(Me.TextEdit9)
        Me.TabNavigationPage4.Image = CType(resources.GetObject("TabNavigationPage4.Image"), System.Drawing.Image)
        Me.TabNavigationPage4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabNavigationPage4.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage4.Name = "TabNavigationPage4"
        Me.TabNavigationPage4.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabNavigationPage4.Size = New System.Drawing.Size(889, 485)
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(182, 171)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl14.TabIndex = 9
        Me.LabelControl14.Text = "EXENTAS:"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(280, 168)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit5.TabIndex = 8
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(182, 299)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl15.TabIndex = 7
        Me.LabelControl15.Text = "TOTAL FACTURA"
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(280, 296)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit6.TabIndex = 6
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(182, 128)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl16.TabIndex = 5
        Me.LabelControl16.Text = "Cod.:"
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(280, 125)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit7.TabIndex = 4
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(182, 91)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl17.TabIndex = 3
        Me.LabelControl17.Text = "Proveedor:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(182, 54)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl18.TabIndex = 2
        Me.LabelControl18.Text = "Nro: Factura:"
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(280, 88)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit8.TabIndex = 1
        '
        'TextEdit9
        '
        Me.TextEdit9.Location = New System.Drawing.Point(280, 51)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Size = New System.Drawing.Size(172, 20)
        Me.TextEdit9.TabIndex = 0
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(889, 488)
        '
        'frm_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 565)
        Me.Controls.Add(Me.TabPane1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl6)
        Me.Controls.Add(Me.PanelControl8)
        Me.Name = "frm_compras"
        Me.Text = "<<Registro de Compras>>"
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cbo_factura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_gasto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_movim_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_compra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_tipo_compra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tipo_compra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.grid_items_tmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grid_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_id_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_total_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_codigo_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_iva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txt_cod_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor_fact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.cbo_tipo_comprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_factura_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero_factura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fac_iva5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fact_gravadas5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fac_iva10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fact_gravadas10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_exentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage4.ResumeLayout(False)
        Me.TabNavigationPage4.PerformLayout()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_compra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_tipo_compra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_proveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_tipo_compra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_tipo_compra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_compra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As MaskedTextBox
    Friend WithEvents btn_buscar_compras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_items_tmp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_movim_stock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_quitar_item As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_item As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_id_item As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_item As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_total_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_total_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_id_item_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_movim_item_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nuevo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_iva As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_factura_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_numero_factura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fac_iva5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_proveedor_fact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fact_gravadas5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cod_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fac_iva10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fact_gravadas10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_exentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_codigo_barras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_tipo_comprobante As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_total_gasto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_total_gasto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_factura As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents controlar_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_controlar_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents precio_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
End Class
