<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_detalle_ventas_por_comprob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_detalle_ventas_por_comprob))
        Me.grid_ventas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.participacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.acumulado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.utilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.porc_util = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.codigoarticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cal_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_ventas
        '
        Me.grid_ventas.Location = New System.Drawing.Point(12, 171)
        Me.grid_ventas.MainView = Me.GridView1
        Me.grid_ventas.Name = "grid_ventas"
        Me.grid_ventas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.grid_ventas.Size = New System.Drawing.Size(1138, 348)
        Me.grid_ventas.TabIndex = 64
        Me.grid_ventas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_item, Me.cantidad, Me.col_total, Me.codigo_barras, Me.costo_total, Me.participacion, Me.acumulado, Me.utilidad, Me.porc_util, Me.col_comprobante, Me.codigoarticulo})
        Me.GridView1.GridControl = Me.grid_ventas
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.col_total, "{0:#,#}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo_total", Me.costo_total, "{0:#,#}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "utilidad", Me.utilidad, "{0:#,#}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "porc_util", Me.porc_util, "{0:#.##} %"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "porc_util", Me.porc_util, "{0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.col_comprobante, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 2
        Me.col_item.Width = 222
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'cantidad
        '
        Me.cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cantidad.Caption = "Cantidad"
        Me.cantidad.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.cantidad.FieldName = "cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Visible = True
        Me.cantidad.VisibleIndex = 3
        Me.cantidad.Width = 98
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total Ventas"
        Me.col_total.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:#,#}")})
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 5
        Me.col_total.Width = 98
        '
        'codigo_barras
        '
        Me.codigo_barras.Caption = "Codigo Barras"
        Me.codigo_barras.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.codigo_barras.FieldName = "codigo_barras"
        Me.codigo_barras.Name = "codigo_barras"
        Me.codigo_barras.Visible = True
        Me.codigo_barras.VisibleIndex = 1
        Me.codigo_barras.Width = 113
        '
        'costo_total
        '
        Me.costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costo_total.Caption = "Costo Total"
        Me.costo_total.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.costo_total.FieldName = "costo_total"
        Me.costo_total.Name = "costo_total"
        Me.costo_total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo_total", "{0:#,#}")})
        Me.costo_total.Visible = True
        Me.costo_total.VisibleIndex = 4
        Me.costo_total.Width = 98
        '
        'participacion
        '
        Me.participacion.AppearanceCell.Options.UseTextOptions = True
        Me.participacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.participacion.AppearanceHeader.Options.UseTextOptions = True
        Me.participacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.participacion.Caption = "Particip. (%)"
        Me.participacion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.participacion.FieldName = "participacion"
        Me.participacion.Name = "participacion"
        Me.participacion.Visible = True
        Me.participacion.VisibleIndex = 8
        Me.participacion.Width = 98
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#.##"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "P"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'acumulado
        '
        Me.acumulado.AppearanceCell.Options.UseTextOptions = True
        Me.acumulado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.acumulado.AppearanceHeader.Options.UseTextOptions = True
        Me.acumulado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.acumulado.Caption = "Acumulado(%)"
        Me.acumulado.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.acumulado.FieldName = "acumulado"
        Me.acumulado.Name = "acumulado"
        Me.acumulado.Visible = True
        Me.acumulado.VisibleIndex = 9
        Me.acumulado.Width = 117
        '
        'utilidad
        '
        Me.utilidad.AppearanceCell.Options.UseTextOptions = True
        Me.utilidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.utilidad.AppearanceHeader.Options.UseTextOptions = True
        Me.utilidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.utilidad.Caption = "Utilidad (Gs.)"
        Me.utilidad.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.utilidad.FieldName = "utilidad"
        Me.utilidad.Name = "utilidad"
        Me.utilidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "utilidad", "{0:#,#}")})
        Me.utilidad.Visible = True
        Me.utilidad.VisibleIndex = 6
        Me.utilidad.Width = 98
        '
        'porc_util
        '
        Me.porc_util.AppearanceCell.Options.UseTextOptions = True
        Me.porc_util.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.porc_util.AppearanceHeader.Options.UseTextOptions = True
        Me.porc_util.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.porc_util.Caption = "Utilidad (%)"
        Me.porc_util.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.porc_util.FieldName = "porc_util"
        Me.porc_util.Name = "porc_util"
        Me.porc_util.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "porc_util", "{0:0.##} %")})
        Me.porc_util.Visible = True
        Me.porc_util.VisibleIndex = 7
        Me.porc_util.Width = 113
        '
        'col_comprobante
        '
        Me.col_comprobante.Caption = "Comprobante"
        Me.col_comprobante.FieldName = "comprobante"
        Me.col_comprobante.Name = "col_comprobante"
        Me.col_comprobante.Visible = True
        Me.col_comprobante.VisibleIndex = 9
        '
        'codigoarticulo
        '
        Me.codigoarticulo.Caption = "Id Articulo"
        Me.codigoarticulo.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.codigoarticulo.FieldName = "id_articulo"
        Me.codigoarticulo.Name = "codigoarticulo"
        Me.codigoarticulo.Visible = True
        Me.codigoarticulo.VisibleIndex = 0
        Me.codigoarticulo.Width = 65
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cld_hasta)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.btn_cal_desde)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1138, 153)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(415, 88)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(27, 22)
        Me.btn_cld_hasta.TabIndex = 91
        Me.btn_cld_hasta.Text = "+"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(857, 98)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 62
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btn_cal_desde
        '
        Me.btn_cal_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cal_desde.Location = New System.Drawing.Point(415, 62)
        Me.btn_cal_desde.Name = "btn_cal_desde"
        Me.btn_cal_desde.Size = New System.Drawing.Size(27, 22)
        Me.btn_cal_desde.TabIndex = 90
        Me.btn_cal_desde.Text = "+"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(415, 34)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 22)
        Me.btn_buscar_sucursal.TabIndex = 52
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(184, 35)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_sucursal.TabIndex = 51
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(225, 35)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(188, 22)
        Me.txt_sucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(137, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Sucursal:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(857, 57)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(857, 16)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(184, 89)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_hasta.TabIndex = 3
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(184, 62)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(115, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(117, 93)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(428, 74)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(260, 227)
        Me.cld_hasta.TabIndex = 95
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(428, 102)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(260, 227)
        Me.cld_desde.TabIndex = 94
        '
        'frm_rpt_detalle_ventas_por_comprob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 530)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.grid_ventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_rpt_detalle_ventas_por_comprob"
        Me.Text = "<<Detalle de Ventas por Comprobante >>"
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_ventas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents participacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents acumulado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents utilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents porc_util As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_comprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents codigoarticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cal_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
End Class
