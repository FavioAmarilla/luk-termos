<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_produccion_por_fecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_produccion_por_fecha))
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.grid_movimientos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_accion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transaccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ccol_antidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cod_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cal_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_articulos = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_materia_prima = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.rps_cadena = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_decimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chk_articulos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cadena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_decimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#.00"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'grid_movimientos
        '
        Me.grid_movimientos.Location = New System.Drawing.Point(12, 173)
        Me.grid_movimientos.MainView = Me.GridView1
        Me.grid_movimientos.Name = "grid_movimientos"
        Me.grid_movimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_cadena, Me.rps_miles, Me.rps_fecha, Me.rps_decimales})
        Me.grid_movimientos.Size = New System.Drawing.Size(1009, 376)
        Me.grid_movimientos.TabIndex = 7
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.fecha, Me.col_accion, Me.col_transaccion, Me.ccol_antidad, Me.col_costo_unitario, Me.costo_total, Me.col_item, Me.col_cod_barras})
        Me.GridView1.GridControl = Me.grid_movimientos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'fecha
        '
        Me.fecha.AppearanceCell.Options.UseTextOptions = True
        Me.fecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.fecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.fecha.Caption = "Fecha"
        Me.fecha.ColumnEdit = Me.rps_fecha
        Me.fecha.FieldName = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Visible = True
        Me.fecha.VisibleIndex = 0
        Me.fecha.Width = 85
        '
        'col_accion
        '
        Me.col_accion.Caption = "Accion"
        Me.col_accion.ColumnEdit = Me.rps_cadena
        Me.col_accion.FieldName = "accion"
        Me.col_accion.Name = "col_accion"
        Me.col_accion.Visible = True
        Me.col_accion.VisibleIndex = 2
        Me.col_accion.Width = 77
        '
        'col_transaccion
        '
        Me.col_transaccion.Caption = "Transaccion"
        Me.col_transaccion.ColumnEdit = Me.rps_cadena
        Me.col_transaccion.FieldName = "transaccion"
        Me.col_transaccion.Name = "col_transaccion"
        Me.col_transaccion.Visible = True
        Me.col_transaccion.VisibleIndex = 1
        Me.col_transaccion.Width = 169
        '
        'ccol_antidad
        '
        Me.ccol_antidad.AppearanceCell.Options.UseTextOptions = True
        Me.ccol_antidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ccol_antidad.AppearanceHeader.Options.UseTextOptions = True
        Me.ccol_antidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ccol_antidad.Caption = "Cantidad"
        Me.ccol_antidad.ColumnEdit = Me.rps_decimales
        Me.ccol_antidad.FieldName = "cantidad"
        Me.ccol_antidad.Name = "ccol_antidad"
        Me.ccol_antidad.Visible = True
        Me.ccol_antidad.VisibleIndex = 5
        Me.ccol_antidad.Width = 84
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "Costo Unitario"
        Me.col_costo_unitario.ColumnEdit = Me.rps_miles
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 6
        Me.col_costo_unitario.Width = 84
        '
        'costo_total
        '
        Me.costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.costo_total.Caption = "Costo Total"
        Me.costo_total.ColumnEdit = Me.rps_miles
        Me.costo_total.FieldName = "costo_total"
        Me.costo_total.Name = "costo_total"
        Me.costo_total.Visible = True
        Me.costo_total.VisibleIndex = 7
        Me.costo_total.Width = 91
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.rps_cadena
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 4
        Me.col_item.Width = 275
        '
        'col_cod_barras
        '
        Me.col_cod_barras.Caption = "Codigo"
        Me.col_cod_barras.ColumnEdit = Me.rps_cadena
        Me.col_cod_barras.FieldName = "codigo"
        Me.col_cod_barras.Name = "col_cod_barras"
        Me.col_cod_barras.Visible = True
        Me.col_cod_barras.VisibleIndex = 3
        Me.col_cod_barras.Width = 126
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cld_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_cal_desde)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1009, 153)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(644, 82)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(28, 22)
        Me.btn_cld_hasta.TabIndex = 83
        Me.btn_cld_hasta.Text = "+"
        '
        'btn_cal_desde
        '
        Me.btn_cal_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cal_desde.Location = New System.Drawing.Point(644, 55)
        Me.btn_cal_desde.Name = "btn_cal_desde"
        Me.btn_cal_desde.Size = New System.Drawing.Size(28, 22)
        Me.btn_cal_desde.TabIndex = 80
        Me.btn_cal_desde.Text = "+"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.BackColor = System.Drawing.Color.White
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(414, 83)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_hasta.TabIndex = 79
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.BackColor = System.Drawing.Color.White
        Me.txt_fecha_desde.Location = New System.Drawing.Point(414, 56)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_desde.TabIndex = 78
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(343, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 81
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(345, 86)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl5.TabIndex = 82
        Me.LabelControl5.Text = "Fecha Hasta:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(725, 100)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 58
        Me.SimpleButton1.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_articulos)
        Me.GroupBox2.Controls.Add(Me.chk_materia_prima)
        Me.GroupBox2.Location = New System.Drawing.Point(133, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 82)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Item"
        '
        'chk_articulos
        '
        Me.chk_articulos.Location = New System.Drawing.Point(26, 20)
        Me.chk_articulos.Name = "chk_articulos"
        Me.chk_articulos.Properties.Caption = "Articulos"
        Me.chk_articulos.Size = New System.Drawing.Size(75, 19)
        Me.chk_articulos.TabIndex = 0
        '
        'chk_materia_prima
        '
        Me.chk_materia_prima.Location = New System.Drawing.Point(26, 46)
        Me.chk_materia_prima.Name = "chk_materia_prima"
        Me.chk_materia_prima.Properties.Caption = "Materia Prima"
        Me.chk_materia_prima.Size = New System.Drawing.Size(96, 19)
        Me.chk_materia_prima.TabIndex = 1
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(644, 27)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_sucursal.TabIndex = 40
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(413, 28)
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
        Me.txt_sucursal.Location = New System.Drawing.Point(454, 28)
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
        Me.LabelControl3.Location = New System.Drawing.Point(366, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Sucursal:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(725, 59)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(725, 17)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(654, 525)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 80
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(656, 97)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(275, 227)
        Me.cld_hasta.TabIndex = 85
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(656, 69)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(275, 227)
        Me.cld_desde.TabIndex = 84
        '
        'rps_cadena
        '
        Me.rps_cadena.AutoHeight = False
        Me.rps_cadena.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cadena.Name = "rps_cadena"
        '
        'rps_miles
        '
        Me.rps_miles.AutoHeight = False
        Me.rps_miles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_miles.DisplayFormat.FormatString = "#,#"
        Me.rps_miles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_miles.Name = "rps_miles"
        '
        'rps_fecha
        '
        Me.rps_fecha.AutoHeight = False
        Me.rps_fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_fecha.DisplayFormat.FormatString = "dd/mm/yyyy"
        Me.rps_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rps_fecha.Name = "rps_fecha"
        '
        'rps_decimales
        '
        Me.rps_decimales.AutoHeight = False
        Me.rps_decimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_decimales.DisplayFormat.FormatString = "0.00"
        Me.rps_decimales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_decimales.Name = "rps_decimales"
        '
        'frm_rpt_produccion_por_fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 575)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_movimientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_rpt_produccion_por_fecha"
        Me.Text = "<<Reporte de Produccion por Fecha>>"
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chk_articulos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cadena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_decimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_movimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_accion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transaccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ccol_antidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_materia_prima As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_articulos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cal_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents col_cod_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_cadena As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_decimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
