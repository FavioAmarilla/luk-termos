<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ranking_ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ranking_ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_calendar_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_calendar_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_familia = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_familia = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_limite = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chk_cantidad = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_monto = New DevExpress.XtraEditors.CheckEdit()
        Me.grid_ranking = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_familia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chk_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_limite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_ranking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_calendar_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_calendar_desde)
        Me.GroupBox1.Controls.Add(Me.chk_familia)
        Me.GroupBox1.Controls.Add(Me.PanelControl2)
        Me.GroupBox1.Controls.Add(Me.PanelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.chk_cantidad)
        Me.GroupBox1.Controls.Add(Me.chk_monto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 512)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_calendar_hasta
        '
        Me.btn_calendar_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_calendar_hasta.Location = New System.Drawing.Point(352, 44)
        Me.btn_calendar_hasta.Name = "btn_calendar_hasta"
        Me.btn_calendar_hasta.Size = New System.Drawing.Size(29, 21)
        Me.btn_calendar_hasta.TabIndex = 13
        Me.btn_calendar_hasta.Text = "+"
        '
        'btn_calendar_desde
        '
        Me.btn_calendar_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_calendar_desde.Location = New System.Drawing.Point(161, 44)
        Me.btn_calendar_desde.Name = "btn_calendar_desde"
        Me.btn_calendar_desde.Size = New System.Drawing.Size(29, 21)
        Me.btn_calendar_desde.TabIndex = 12
        Me.btn_calendar_desde.Text = "+"
        '
        'chk_familia
        '
        Me.chk_familia.Location = New System.Drawing.Point(9, 216)
        Me.chk_familia.Name = "chk_familia"
        Me.chk_familia.Properties.Caption = "Familia"
        Me.chk_familia.Size = New System.Drawing.Size(53, 19)
        Me.chk_familia.TabIndex = 11
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_familia)
        Me.PanelControl2.Controls.Add(Me.txt_familia)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 236)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(372, 36)
        Me.PanelControl2.TabIndex = 6
        '
        'btn_familia
        '
        Me.btn_familia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_familia.Location = New System.Drawing.Point(228, 8)
        Me.btn_familia.Name = "btn_familia"
        Me.btn_familia.Size = New System.Drawing.Size(27, 21)
        Me.btn_familia.TabIndex = 12
        Me.btn_familia.Text = "+"
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(15, 8)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(212, 22)
        Me.txt_familia.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txt_limite)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 94)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(372, 33)
        Me.PanelControl1.TabIndex = 10
        '
        'txt_limite
        '
        Me.txt_limite.Location = New System.Drawing.Point(107, 6)
        Me.txt_limite.Name = "txt_limite"
        Me.txt_limite.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_limite.Size = New System.Drawing.Size(38, 22)
        Me.txt_limite.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 9)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Consultar los"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(151, 9)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Articulos mas vendidos"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.BackColor = System.Drawing.Color.White
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(236, 44)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(115, 21)
        Me.txt_fecha_hasta.TabIndex = 1
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(202, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Hasta:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(82, 447)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(205, 447)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.BackColor = System.Drawing.Color.White
        Me.txt_fecha_desde.Location = New System.Drawing.Point(45, 44)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(115, 21)
        Me.txt_fecha_desde.TabIndex = 0
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Desde:"
        '
        'chk_cantidad
        '
        Me.chk_cantidad.Location = New System.Drawing.Point(9, 180)
        Me.chk_cantidad.Name = "chk_cantidad"
        Me.chk_cantidad.Properties.Caption = "Ordenar por Cantidad Vendida"
        Me.chk_cantidad.Size = New System.Drawing.Size(278, 19)
        Me.chk_cantidad.TabIndex = 3
        '
        'chk_monto
        '
        Me.chk_monto.Location = New System.Drawing.Point(9, 160)
        Me.chk_monto.Name = "chk_monto"
        Me.chk_monto.Properties.Caption = "Ordenar por Monto de Venta"
        Me.chk_monto.Size = New System.Drawing.Size(280, 19)
        Me.chk_monto.TabIndex = 2
        '
        'grid_ranking
        '
        Me.grid_ranking.Location = New System.Drawing.Point(412, 12)
        Me.grid_ranking.MainView = Me.GridView1
        Me.grid_ranking.Name = "grid_ranking"
        Me.grid_ranking.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.grid_ranking.Size = New System.Drawing.Size(828, 508)
        Me.grid_ranking.TabIndex = 1
        Me.grid_ranking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_item, Me.col_proveedor, Me.col_monto, Me.col_cantidad, Me.col_familia, Me.col_codigo})
        Me.GridView1.GridControl = Me.grid_ranking
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsPrint.RtfPageFooter = resources.GetString("GridView1.OptionsPrint.RtfPageFooter")
        Me.GridView1.OptionsPrint.RtfPageHeader = resources.GetString("GridView1.OptionsPrint.RtfPageHeader")
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'col_item
        '
        Me.col_item.Caption = "Articulo"
        Me.col_item.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 176
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_proveedor
        '
        Me.col_proveedor.Caption = "Proveedor"
        Me.col_proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_proveedor.FieldName = "ranking"
        Me.col_proveedor.Name = "col_proveedor"
        Me.col_proveedor.Visible = True
        Me.col_proveedor.VisibleIndex = 2
        Me.col_proveedor.Width = 133
        '
        'col_monto
        '
        Me.col_monto.AppearanceCell.Options.UseTextOptions = True
        Me.col_monto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_monto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_monto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_monto.Caption = "Monto de Ventas"
        Me.col_monto.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.col_monto.FieldName = "monto"
        Me.col_monto.Name = "col_monto"
        Me.col_monto.Visible = True
        Me.col_monto.VisibleIndex = 4
        Me.col_monto.Width = 102
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 5
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_familia
        '
        Me.col_familia.Caption = "Familia"
        Me.col_familia.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_familia.FieldName = "familia"
        Me.col_familia.Name = "col_familia"
        Me.col_familia.Visible = True
        Me.col_familia.VisibleIndex = 3
        Me.col_familia.Width = 203
        '
        'col_codigo
        '
        Me.col_codigo.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_codigo.Caption = "Codigo Barras"
        Me.col_codigo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_codigo.FieldName = "codigo_barras"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = True
        Me.col_codigo.VisibleIndex = 0
        Me.col_codigo.Width = 118
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(173, 56)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(250, 227)
        Me.cld_desde.TabIndex = 14
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(365, 57)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(250, 227)
        Me.cld_hasta.TabIndex = 15
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(873, 495)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 84
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_ranking_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 543)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.grid_ranking)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_ranking_ventas"
        Me.Text = "<<Ranking de Ventas>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chk_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_limite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_ranking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grid_ranking As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_cantidad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_monto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_limite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_familia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chk_familia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents col_familia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_calendar_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_calendar_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
