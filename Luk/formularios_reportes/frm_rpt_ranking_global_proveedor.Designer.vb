<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rpt_ranking_global_proveedor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_ranking_global_proveedor))
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cal_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.grid_ventas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.total_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Dts_ranking_compras = New Luk.dts_ranking_compras()
        Me.DtsrankingcomprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dts_ranking_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsrankingcomprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(455, 63)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(251, 227)
        Me.cld_hasta.TabIndex = 104
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(455, 91)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(251, 227)
        Me.cld_desde.TabIndex = 103
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
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 153)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(442, 78)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(28, 22)
        Me.btn_cld_hasta.TabIndex = 99
        Me.btn_cld_hasta.Text = "+"
        '
        'btn_cal_desde
        '
        Me.btn_cal_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cal_desde.Location = New System.Drawing.Point(442, 51)
        Me.btn_cal_desde.Name = "btn_cal_desde"
        Me.btn_cal_desde.Size = New System.Drawing.Size(28, 22)
        Me.btn_cal_desde.TabIndex = 98
        Me.btn_cal_desde.Text = "+"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(506, 100)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(443, 23)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 22)
        Me.btn_buscar_sucursal.TabIndex = 52
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(212, 24)
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
        Me.txt_sucursal.Location = New System.Drawing.Point(253, 24)
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
        Me.LabelControl4.Location = New System.Drawing.Point(165, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Sucursal:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(506, 59)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(506, 17)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(212, 78)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_hasta.TabIndex = 3
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(212, 51)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(229, 21)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(143, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(145, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'grid_ventas
        '
        Me.grid_ventas.Location = New System.Drawing.Point(12, 171)
        Me.grid_ventas.MainView = Me.GridView1
        Me.grid_ventas.Name = "grid_ventas"
        Me.grid_ventas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1})
        Me.grid_ventas.Size = New System.Drawing.Size(379, 302)
        Me.grid_ventas.TabIndex = 105
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.proveedor, Me.total_compra})
        Me.GridView1.GridControl = Me.grid_ventas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'proveedor
        '
        Me.proveedor.Caption = "Proveedor"
        Me.proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.proveedor.FieldName = "proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Visible = True
        Me.proveedor.VisibleIndex = 0
        Me.proveedor.Width = 423
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'total_compra
        '
        Me.total_compra.AppearanceCell.Options.UseTextOptions = True
        Me.total_compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.total_compra.AppearanceHeader.Options.UseTextOptions = True
        Me.total_compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.total_compra.Caption = "Total Compra"
        Me.total_compra.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.total_compra.FieldName = "total_compra"
        Me.total_compra.Name = "total_compra"
        Me.total_compra.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_compra", "{0:#,#}")})
        Me.total_compra.Visible = True
        Me.total_compra.VisibleIndex = 1
        Me.total_compra.Width = 166
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
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
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Total Compra"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn1.FieldName = "monto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "monto", "{0:#,#}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 166
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.DtsrankingcomprasBindingSource
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(397, 171)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(379, 302)
        Me.ChartControl1.TabIndex = 106
        '
        'Dts_ranking_compras
        '
        Me.Dts_ranking_compras.DataSetName = "dts_ranking_compras"
        Me.Dts_ranking_compras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtsrankingcomprasBindingSource
        '
        Me.DtsrankingcomprasBindingSource.DataSource = Me.Dts_ranking_compras
        Me.DtsrankingcomprasBindingSource.Position = 0
        '
        'frm_rpt_ranking_global_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 501)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.grid_ventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_rpt_ranking_global_proveedor"
        Me.Text = "<<Ranking de Compras Por Proveedor>>"
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dts_ranking_compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsrankingcomprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cal_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents grid_ventas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents total_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents DtsrankingcomprasBindingSource As BindingSource
    Friend WithEvents Dts_ranking_compras As dts_ranking_compras
End Class
