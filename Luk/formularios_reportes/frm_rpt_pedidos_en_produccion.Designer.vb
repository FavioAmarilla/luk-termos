<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_pedidos_en_produccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_pedidos_en_produccion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_listado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_caracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_fecha_entrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_precio_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cld_fecha_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cls_fecha_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_caracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cls_fecha_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_desde)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 143)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(728, 98)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 62
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_hasta
        '
        Me.btn_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_hasta.Location = New System.Drawing.Point(318, 78)
        Me.btn_hasta.Name = "btn_hasta"
        Me.btn_hasta.Size = New System.Drawing.Size(23, 23)
        Me.btn_hasta.TabIndex = 57
        Me.btn_hasta.TabStop = False
        Me.btn_hasta.Text = "+"
        '
        'btn_desde
        '
        Me.btn_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_desde.Location = New System.Drawing.Point(318, 50)
        Me.btn_desde.Name = "btn_desde"
        Me.btn_desde.Size = New System.Drawing.Size(23, 23)
        Me.btn_desde.TabIndex = 55
        Me.btn_desde.TabStop = False
        Me.btn_desde.Text = "+"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(318, 21)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_sucursal.TabIndex = 40
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(87, 22)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_sucursal.TabIndex = 39
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(128, 22)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(188, 22)
        Me.txt_sucursal.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Sucursal:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(728, 57)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 9
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(728, 15)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 8
        Me.btn_consultar.Text = "Consultar"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(87, 79)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_hasta.TabIndex = 2
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(87, 51)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_desde.TabIndex = 1
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'grid_listado
        '
        Me.grid_listado.Location = New System.Drawing.Point(12, 176)
        Me.grid_listado.MainView = Me.GridView1
        Me.grid_listado.Name = "grid_listado"
        Me.grid_listado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_miles, Me.rps_caracteres, Me.rps_fecha, Me.rps_cantidad})
        Me.grid_listado.Size = New System.Drawing.Size(877, 306)
        Me.grid_listado.TabIndex = 4
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_numero, Me.col_fecha_entrega, Me.col_articulo, Me.col_cantidad, Me.col_costo_unitario, Me.col_precio_unitario, Me.col_costo_total, Me.col_total_venta})
        Me.GridView1.GridControl = Me.grid_listado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
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
        Me.col_numero.ColumnEdit = Me.rps_caracteres
        Me.col_numero.FieldName = "numero"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.Visible = True
        Me.col_numero.VisibleIndex = 0
        Me.col_numero.Width = 87
        '
        'rps_caracteres
        '
        Me.rps_caracteres.AutoHeight = False
        Me.rps_caracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_caracteres.Name = "rps_caracteres"
        '
        'col_fecha_entrega
        '
        Me.col_fecha_entrega.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha_entrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_entrega.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha_entrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_entrega.Caption = "Fec. Entrega"
        Me.col_fecha_entrega.ColumnEdit = Me.rps_fecha
        Me.col_fecha_entrega.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_fecha_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_fecha_entrega.FieldName = "fecha_entrega"
        Me.col_fecha_entrega.Name = "col_fecha_entrega"
        Me.col_fecha_entrega.Visible = True
        Me.col_fecha_entrega.VisibleIndex = 1
        Me.col_fecha_entrega.Width = 90
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
        'col_articulo
        '
        Me.col_articulo.AppearanceCell.Options.UseTextOptions = True
        Me.col_articulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_articulo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_articulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_articulo.Caption = "Articulo"
        Me.col_articulo.ColumnEdit = Me.rps_caracteres
        Me.col_articulo.FieldName = "articulo"
        Me.col_articulo.Name = "col_articulo"
        Me.col_articulo.Visible = True
        Me.col_articulo.VisibleIndex = 2
        Me.col_articulo.Width = 268
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rps_cantidad
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 3
        Me.col_cantidad.Width = 80
        '
        'rps_cantidad
        '
        Me.rps_cantidad.AutoHeight = False
        Me.rps_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cantidad.DisplayFormat.FormatString = "#,#"
        Me.rps_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_cantidad.Mask.EditMask = "n0"
        Me.rps_cantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_cantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rps_cantidad.Name = "rps_cantidad"
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "Costo unit."
        Me.col_costo_unitario.ColumnEdit = Me.rps_miles
        Me.col_costo_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 4
        Me.col_costo_unitario.Width = 80
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
        'col_precio_unitario
        '
        Me.col_precio_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.Caption = "PrecioUnit."
        Me.col_precio_unitario.ColumnEdit = Me.rps_miles
        Me.col_precio_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_precio_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_unitario.FieldName = "precio_unitario"
        Me.col_precio_unitario.Name = "col_precio_unitario"
        Me.col_precio_unitario.Visible = True
        Me.col_precio_unitario.VisibleIndex = 5
        Me.col_precio_unitario.Width = 80
        '
        'col_costo_total
        '
        Me.col_costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.Caption = "Costo total"
        Me.col_costo_total.ColumnEdit = Me.rps_miles
        Me.col_costo_total.FieldName = "costo_total"
        Me.col_costo_total.Name = "col_costo_total"
        Me.col_costo_total.Visible = True
        Me.col_costo_total.VisibleIndex = 6
        Me.col_costo_total.Width = 80
        '
        'col_total_venta
        '
        Me.col_total_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.Caption = "Total venta"
        Me.col_total_venta.ColumnEdit = Me.rps_miles
        Me.col_total_venta.FieldName = "total_venta"
        Me.col_total_venta.Name = "col_total_venta"
        Me.col_total_venta.Visible = True
        Me.col_total_venta.VisibleIndex = 7
        Me.col_total_venta.Width = 80
        '
        'cld_fecha_desde
        '
        Me.cld_fecha_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha_desde.Location = New System.Drawing.Point(330, 62)
        Me.cld_fecha_desde.Name = "cld_fecha_desde"
        Me.cld_fecha_desde.Size = New System.Drawing.Size(262, 227)
        Me.cld_fecha_desde.TabIndex = 59
        Me.cld_fecha_desde.Visible = False
        '
        'cls_fecha_hasta
        '
        Me.cls_fecha_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cls_fecha_hasta.Location = New System.Drawing.Point(330, 90)
        Me.cls_fecha_hasta.Name = "cls_fecha_hasta"
        Me.cls_fecha_hasta.Size = New System.Drawing.Size(262, 227)
        Me.cls_fecha_hasta.TabIndex = 58
        Me.cls_fecha_hasta.Visible = False
        '
        'frm_rpt_pedidos_en_produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 494)
        Me.Controls.Add(Me.cld_fecha_desde)
        Me.Controls.Add(Me.cls_fecha_hasta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_listado)
        Me.Name = "frm_rpt_pedidos_en_produccion"
        Me.Text = "Pedidos en produccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_caracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cls_fecha_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_listado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_entrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_caracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cld_fecha_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cls_fecha_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents rps_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
