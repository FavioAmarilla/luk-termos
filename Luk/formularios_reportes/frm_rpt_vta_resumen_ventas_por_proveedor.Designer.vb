<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_vta_resumen_ventas_por_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_vta_resumen_ventas_por_proveedor))
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.grid_ventas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id_proveedo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.costototal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.totalventa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.porcentajeutil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.utilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.participacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.acumulado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Posicion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cal_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_proveedores = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(407, 100)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(250, 227)
        Me.cld_hasta.TabIndex = 106
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(408, 130)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(250, 227)
        Me.cld_desde.TabIndex = 105
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(507, 493)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 104
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'grid_ventas
        '
        Me.grid_ventas.Location = New System.Drawing.Point(12, 171)
        Me.grid_ventas.MainView = Me.GridView1
        Me.grid_ventas.Name = "grid_ventas"
        Me.grid_ventas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit4})
        Me.grid_ventas.Size = New System.Drawing.Size(861, 348)
        Me.grid_ventas.TabIndex = 103
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_proveedo, Me.proveedor, Me.costototal, Me.totalventa, Me.porcentajeutil, Me.utilidad, Me.participacion, Me.acumulado, Me.Posicion})
        Me.GridView1.GridControl = Me.grid_ventas
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, Nothing, Me.costototal, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'id_proveedo
        '
        Me.id_proveedo.AppearanceCell.Options.UseTextOptions = True
        Me.id_proveedo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id_proveedo.AppearanceHeader.Options.UseTextOptions = True
        Me.id_proveedo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id_proveedo.Caption = "ID Proveedor"
        Me.id_proveedo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.id_proveedo.FieldName = "id_proveedor"
        Me.id_proveedo.Name = "id_proveedo"
        Me.id_proveedo.Visible = True
        Me.id_proveedo.VisibleIndex = 0
        Me.id_proveedo.Width = 78
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'proveedor
        '
        Me.proveedor.Caption = "Proveedor"
        Me.proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.proveedor.FieldName = "proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Visible = True
        Me.proveedor.VisibleIndex = 1
        Me.proveedor.Width = 226
        '
        'costototal
        '
        Me.costototal.AppearanceCell.Options.UseTextOptions = True
        Me.costototal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costototal.AppearanceHeader.Options.UseTextOptions = True
        Me.costototal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costototal.Caption = "Costo Total"
        Me.costototal.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.costototal.FieldName = "costo_total"
        Me.costototal.Name = "costototal"
        Me.costototal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "costo_total", "{0:#,#}")})
        Me.costototal.Visible = True
        Me.costototal.VisibleIndex = 2
        Me.costototal.Width = 79
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "0"
        '
        'totalventa
        '
        Me.totalventa.AppearanceCell.Options.UseTextOptions = True
        Me.totalventa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.totalventa.AppearanceHeader.Options.UseTextOptions = True
        Me.totalventa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.totalventa.Caption = "Total Venta"
        Me.totalventa.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.totalventa.FieldName = "total_venta"
        Me.totalventa.Name = "totalventa"
        Me.totalventa.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_venta", "{0:#,#}")})
        Me.totalventa.Visible = True
        Me.totalventa.VisibleIndex = 3
        Me.totalventa.Width = 95
        '
        'porcentajeutil
        '
        Me.porcentajeutil.AppearanceCell.Options.UseTextOptions = True
        Me.porcentajeutil.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.porcentajeutil.AppearanceHeader.Options.UseTextOptions = True
        Me.porcentajeutil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.porcentajeutil.Caption = "%Util."
        Me.porcentajeutil.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.porcentajeutil.FieldName = "porcentaje_util"
        Me.porcentajeutil.Name = "porcentajeutil"
        Me.porcentajeutil.Visible = True
        Me.porcentajeutil.VisibleIndex = 5
        Me.porcentajeutil.Width = 71
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "#.##"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit4.Mask.EditMask = "P"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'utilidad
        '
        Me.utilidad.AppearanceCell.Options.UseTextOptions = True
        Me.utilidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.utilidad.AppearanceHeader.Options.UseTextOptions = True
        Me.utilidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.utilidad.Caption = "Utilidad"
        Me.utilidad.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.utilidad.FieldName = "utilidad"
        Me.utilidad.Name = "utilidad"
        Me.utilidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "utilidad", "{0:#,#}")})
        Me.utilidad.Visible = True
        Me.utilidad.VisibleIndex = 4
        Me.utilidad.Width = 74
        '
        'participacion
        '
        Me.participacion.Caption = "%Participación"
        Me.participacion.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.participacion.FieldName = "participacion"
        Me.participacion.Name = "participacion"
        Me.participacion.Visible = True
        Me.participacion.VisibleIndex = 6
        Me.participacion.Width = 79
        '
        'acumulado
        '
        Me.acumulado.Caption = "Acumulado"
        Me.acumulado.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.acumulado.FieldName = "acumulado"
        Me.acumulado.Name = "acumulado"
        Me.acumulado.Visible = True
        Me.acumulado.VisibleIndex = 7
        Me.acumulado.Width = 95
        '
        'Posicion
        '
        Me.Posicion.Caption = "Posicion"
        Me.Posicion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Posicion.FieldName = "pos"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.Width = 46
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cld_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_cal_desde)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.btn_proveedores)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 153)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(396, 114)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(28, 22)
        Me.btn_cld_hasta.TabIndex = 99
        Me.btn_cld_hasta.TabStop = False
        Me.btn_cld_hasta.Text = "+"
        '
        'btn_cal_desde
        '
        Me.btn_cal_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cal_desde.Location = New System.Drawing.Point(396, 87)
        Me.btn_cal_desde.Name = "btn_cal_desde"
        Me.btn_cal_desde.Size = New System.Drawing.Size(28, 22)
        Me.btn_cal_desde.TabIndex = 98
        Me.btn_cal_desde.TabStop = False
        Me.btn_cal_desde.Text = "+"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(648, 100)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(396, 31)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 22)
        Me.btn_buscar_sucursal.TabIndex = 52
        Me.btn_buscar_sucursal.TabStop = False
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(165, 32)
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
        Me.txt_sucursal.Location = New System.Drawing.Point(206, 32)
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
        Me.LabelControl4.Location = New System.Drawing.Point(118, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Sucursal:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(108, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Proveedor:"
        '
        'btn_proveedores
        '
        Me.btn_proveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_proveedores.Location = New System.Drawing.Point(396, 61)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(27, 21)
        Me.btn_proveedores.TabIndex = 14
        Me.btn_proveedores.TabStop = False
        Me.btn_proveedores.Text = "+"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(165, 61)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(229, 22)
        Me.txt_proveedor.TabIndex = 1
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(648, 59)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(648, 17)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(165, 115)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_hasta.TabIndex = 3
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(165, 88)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(96, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(98, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Total Compra"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn1.FieldName = "total"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 95
        '
        'frm_rpt_vta_resumen_ventas_por_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 537)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.grid_ventas)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_rpt_vta_resumen_ventas_por_proveedor"
        Me.Text = "<<Resumen de Ventas por Proveedores>>"
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_ventas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_proveedo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents costototal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents totalventa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents porcentajeutil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cal_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_proveedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents utilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents participacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents acumulado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Posicion As DevExpress.XtraGrid.Columns.GridColumn
End Class
