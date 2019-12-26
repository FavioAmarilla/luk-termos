<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_items_liquidacion_vendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_items_liquidacion_vendedores))
        Me.grid_items = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_fecha_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_liquidar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_id_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_item_liquidacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nuevo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_vendedor = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_liquidacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_registrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.txt_vendedor = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_agregar_item = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_vendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_liquidacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_items
        '
        Me.grid_items.Location = New System.Drawing.Point(12, 155)
        Me.grid_items.MainView = Me.GridView1
        Me.grid_items.Name = "grid_items"
        Me.grid_items.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.grid_items.Size = New System.Drawing.Size(749, 312)
        Me.grid_items.TabIndex = 2
        Me.grid_items.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_fecha_venta, Me.col_venta, Me.col_total_venta, Me.col_comision, Me.col_total, Me.col_liquidar, Me.col_id_venta, Me.col_id_item_liquidacion, Me.col_nuevo})
        Me.GridView1.GridControl = Me.grid_items
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_fecha_venta
        '
        Me.col_fecha_venta.Caption = "Fecha venta"
        Me.col_fecha_venta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fecha_venta.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_fecha_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_fecha_venta.FieldName = "fecha_cre"
        Me.col_fecha_venta.Name = "col_fecha_venta"
        Me.col_fecha_venta.Visible = True
        Me.col_fecha_venta.VisibleIndex = 0
        Me.col_fecha_venta.Width = 95
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_venta
        '
        Me.col_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_venta.Caption = "Nro. Venta"
        Me.col_venta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_venta.FieldName = "venta"
        Me.col_venta.Name = "col_venta"
        Me.col_venta.OptionsColumn.ReadOnly = True
        Me.col_venta.Visible = True
        Me.col_venta.VisibleIndex = 1
        Me.col_venta.Width = 90
        '
        'col_total_venta
        '
        Me.col_total_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_venta.Caption = "Total venta"
        Me.col_total_venta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_total_venta.DisplayFormat.FormatString = "#,#"
        Me.col_total_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_venta.FieldName = "total_venta"
        Me.col_total_venta.Name = "col_total_venta"
        Me.col_total_venta.Visible = True
        Me.col_total_venta.VisibleIndex = 2
        '
        'col_comision
        '
        Me.col_comision.AppearanceCell.Options.UseTextOptions = True
        Me.col_comision.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.AppearanceHeader.Options.UseTextOptions = True
        Me.col_comision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.Caption = "Comision"
        Me.col_comision.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_comision.DisplayFormat.FormatString = "#,#"
        Me.col_comision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_comision.FieldName = "comision"
        Me.col_comision.Name = "col_comision"
        Me.col_comision.OptionsColumn.ReadOnly = True
        Me.col_comision.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "comision", "{0:#,#}")})
        Me.col_comision.Visible = True
        Me.col_comision.VisibleIndex = 3
        Me.col_comision.Width = 83
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total a pagar"
        Me.col_total.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:#,#}")})
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 94
        '
        'col_liquidar
        '
        Me.col_liquidar.AppearanceCell.Options.UseTextOptions = True
        Me.col_liquidar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_liquidar.AppearanceHeader.Options.UseTextOptions = True
        Me.col_liquidar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_liquidar.Caption = "Liquidar"
        Me.col_liquidar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_liquidar.FieldName = "liquidar"
        Me.col_liquidar.Name = "col_liquidar"
        Me.col_liquidar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "liquidar", "{0}")})
        Me.col_liquidar.Visible = True
        Me.col_liquidar.VisibleIndex = 5
        Me.col_liquidar.Width = 102
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'col_id_venta
        '
        Me.col_id_venta.Caption = "id_venta"
        Me.col_id_venta.FieldName = "id_venta"
        Me.col_id_venta.Name = "col_id_venta"
        Me.col_id_venta.OptionsColumn.ReadOnly = True
        '
        'col_id_item_liquidacion
        '
        Me.col_id_item_liquidacion.Caption = "id_item_liquidacion"
        Me.col_id_item_liquidacion.FieldName = "id_item_liquidacion"
        Me.col_id_item_liquidacion.Name = "col_id_item_liquidacion"
        '
        'col_nuevo
        '
        Me.col_nuevo.Caption = "Nuevo"
        Me.col_nuevo.FieldName = "nuevo"
        Me.col_nuevo.Name = "col_nuevo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_id_vendedor)
        Me.GroupBox1.Controls.Add(Me.txt_nro_liquidacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.btn_registrar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.txt_vendedor)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 129)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Liquidacion"
        '
        'txt_id_vendedor
        '
        Me.txt_id_vendedor.Location = New System.Drawing.Point(78, 81)
        Me.txt_id_vendedor.Name = "txt_id_vendedor"
        Me.txt_id_vendedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_vendedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_vendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_vendedor.Properties.ReadOnly = True
        Me.txt_id_vendedor.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_vendedor.TabIndex = 15
        '
        'txt_nro_liquidacion
        '
        Me.txt_nro_liquidacion.Location = New System.Drawing.Point(78, 29)
        Me.txt_nro_liquidacion.Name = "txt_nro_liquidacion"
        Me.txt_nro_liquidacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_liquidacion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_liquidacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_liquidacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_liquidacion.Properties.ReadOnly = True
        Me.txt_nro_liquidacion.Size = New System.Drawing.Size(227, 22)
        Me.txt_nro_liquidacion.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Numero Liq.:"
        '
        'btn_registrar
        '
        Me.btn_registrar.Image = CType(resources.GetObject("btn_registrar.Image"), System.Drawing.Image)
        Me.btn_registrar.Location = New System.Drawing.Point(616, 30)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_registrar.TabIndex = 9
        Me.btn_registrar.Text = "Registrar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(616, 82)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Salir"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(325, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(359, 29)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txt_total.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total.Properties.Mask.EditMask = "n0"
        Me.txt_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total.Properties.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(227, 42)
        Me.txt_total.TabIndex = 6
        '
        'txt_vendedor
        '
        Me.txt_vendedor.Location = New System.Drawing.Point(119, 81)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_vendedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_vendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_vendedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_vendedor.Properties.ReadOnly = True
        Me.txt_vendedor.Size = New System.Drawing.Size(186, 22)
        Me.txt_vendedor.TabIndex = 5
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(78, 55)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(227, 22)
        Me.txt_fecha.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Vendedor:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(39, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha:"
        '
        'btn_agregar_item
        '
        Me.btn_agregar_item.Location = New System.Drawing.Point(670, 169)
        Me.btn_agregar_item.Name = "btn_agregar_item"
        Me.btn_agregar_item.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_item.TabIndex = 17
        Me.btn_agregar_item.Text = "Agregar"
        '
        'frm_items_liquidacion_vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 502)
        Me.Controls.Add(Me.btn_agregar_item)
        Me.Controls.Add(Me.grid_items)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_items_liquidacion_vendedores"
        Me.Text = "<<Detalles de Liquidacion >>"
        CType(Me.grid_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_vendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_liquidacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_items As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_comision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_liquidar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_vendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_liquidacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_registrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id_item_liquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nuevo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_agregar_item As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_fecha_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_venta As DevExpress.XtraGrid.Columns.GridColumn
End Class
