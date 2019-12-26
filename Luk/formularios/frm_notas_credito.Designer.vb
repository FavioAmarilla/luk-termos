<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notas_credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_notas_credito))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_quitar = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_items_comprobantes = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_codigo_barras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_descripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_costo_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_precio_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_precio_unitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_accion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_nota_credito_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_buscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_calendar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_comprobantes = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_comp = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_comp = New DevExpress.XtraEditors.TextEdit()
        Me.txt_comprobante = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cld_fecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grid_items_comprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_codigo_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_costo_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_precio_unitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_comp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_comp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(849, 471)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btn_quitar)
        Me.PanelControl3.Controls.Add(Me.grid_items_comprobantes)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 172)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(822, 284)
        Me.PanelControl3.TabIndex = 1
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(13, 12)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar.TabIndex = 1
        Me.btn_quitar.Text = "Quitar"
        '
        'grid_items_comprobantes
        '
        Me.grid_items_comprobantes.Location = New System.Drawing.Point(13, 48)
        Me.grid_items_comprobantes.MainView = Me.GridView1
        Me.grid_items_comprobantes.Name = "grid_items_comprobantes"
        Me.grid_items_comprobantes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_codigo_barras, Me.rps_descripcion, Me.rps_precio_unitario, Me.rps_cantidad, Me.rps_total, Me.rps_costo_unitario})
        Me.grid_items_comprobantes.Size = New System.Drawing.Size(793, 220)
        Me.grid_items_comprobantes.TabIndex = 0
        Me.grid_items_comprobantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_articulo, Me.col_id_proveedor, Me.col_codigo_barras, Me.col_descripcion, Me.col_costo_unitario, Me.col_precio_unitario, Me.col_cantidad, Me.col_total, Me.col_accion, Me.col_id_nota_credito_item})
        Me.GridView1.GridControl = Me.grid_items_comprobantes
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_articulo
        '
        Me.col_id_articulo.Caption = "ID Articulo"
        Me.col_id_articulo.FieldName = "id_articulo"
        Me.col_id_articulo.Name = "col_id_articulo"
        Me.col_id_articulo.OptionsColumn.ReadOnly = True
        '
        'col_id_proveedor
        '
        Me.col_id_proveedor.Caption = "ID Proveedor"
        Me.col_id_proveedor.FieldName = "id_proveedor"
        Me.col_id_proveedor.Name = "col_id_proveedor"
        Me.col_id_proveedor.OptionsColumn.ReadOnly = True
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.Caption = "Codigo Barras"
        Me.col_codigo_barras.ColumnEdit = Me.rps_codigo_barras
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.OptionsColumn.ReadOnly = True
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 121
        '
        'rps_codigo_barras
        '
        Me.rps_codigo_barras.AutoHeight = False
        Me.rps_codigo_barras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_codigo_barras.Name = "rps_codigo_barras"
        Me.rps_codigo_barras.NullText = "0"
        '
        'col_descripcion
        '
        Me.col_descripcion.Caption = "Descripcion"
        Me.col_descripcion.ColumnEdit = Me.rps_descripcion
        Me.col_descripcion.FieldName = "nombre"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.OptionsColumn.ReadOnly = True
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 1
        Me.col_descripcion.Width = 354
        '
        'rps_descripcion
        '
        Me.rps_descripcion.AutoHeight = False
        Me.rps_descripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_descripcion.Name = "rps_descripcion"
        Me.rps_descripcion.NullText = "0"
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.Caption = "Costo unitario"
        Me.col_costo_unitario.ColumnEdit = Me.rps_costo_unitario
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        '
        'rps_costo_unitario
        '
        Me.rps_costo_unitario.AutoHeight = False
        Me.rps_costo_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_costo_unitario.DisplayFormat.FormatString = "#,#"
        Me.rps_costo_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_costo_unitario.Name = "rps_costo_unitario"
        '
        'col_precio_unitario
        '
        Me.col_precio_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_unitario.Caption = "Precio Unitario"
        Me.col_precio_unitario.ColumnEdit = Me.rps_precio_unitario
        Me.col_precio_unitario.FieldName = "precio_venta"
        Me.col_precio_unitario.Name = "col_precio_unitario"
        Me.col_precio_unitario.Visible = True
        Me.col_precio_unitario.VisibleIndex = 2
        Me.col_precio_unitario.Width = 97
        '
        'rps_precio_unitario
        '
        Me.rps_precio_unitario.AutoHeight = False
        Me.rps_precio_unitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_precio_unitario.DisplayFormat.FormatString = "#,#"
        Me.rps_precio_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_precio_unitario.Name = "rps_precio_unitario"
        Me.rps_precio_unitario.NullText = "0"
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
        Me.col_cantidad.Width = 97
        '
        'rps_cantidad
        '
        Me.rps_cantidad.AutoHeight = False
        Me.rps_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cantidad.DisplayFormat.FormatString = "0.00"
        Me.rps_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_cantidad.Name = "rps_cantidad"
        Me.rps_cantidad.NullText = "0"
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.rps_total
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 103
        '
        'rps_total
        '
        Me.rps_total.AutoHeight = False
        Me.rps_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_total.DisplayFormat.FormatString = "#,#"
        Me.rps_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_total.Name = "rps_total"
        Me.rps_total.NullText = "0"
        '
        'col_accion
        '
        Me.col_accion.Caption = "Accion"
        Me.col_accion.FieldName = "accion"
        Me.col_accion.Name = "col_accion"
        '
        'col_id_nota_credito_item
        '
        Me.col_id_nota_credito_item.Caption = "ID item nota credito"
        Me.col_id_nota_credito_item.FieldName = "id_nota_credito_item"
        Me.col_id_nota_credito_item.Name = "col_id_nota_credito_item"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txt_sucursal)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.btn_buscar)
        Me.PanelControl2.Controls.Add(Me.btn_calendar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btn_comprobantes)
        Me.PanelControl2.Controls.Add(Me.txt_fecha)
        Me.PanelControl2.Controls.Add(Me.btn_confirmar)
        Me.PanelControl2.Controls.Add(Me.txt_fecha_comp)
        Me.PanelControl2.Controls.Add(Me.txt_total_comp)
        Me.PanelControl2.Controls.Add(Me.txt_comprobante)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(822, 152)
        Me.PanelControl2.TabIndex = 0
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(95, 36)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(216, 22)
        Me.txt_sucursal.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Sucursal:"
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(679, 49)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(121, 35)
        Me.btn_buscar.TabIndex = 59
        Me.btn_buscar.Text = "Buscar"
        '
        'btn_calendar
        '
        Me.btn_calendar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_calendar.Location = New System.Drawing.Point(582, 10)
        Me.btn_calendar.Name = "btn_calendar"
        Me.btn_calendar.Size = New System.Drawing.Size(26, 22)
        Me.btn_calendar.TabIndex = 55
        Me.btn_calendar.TabStop = False
        Me.btn_calendar.Text = "+"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(679, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 35)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btn_comprobantes
        '
        Me.btn_comprobantes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_comprobantes.Location = New System.Drawing.Point(288, 8)
        Me.btn_comprobantes.Name = "btn_comprobantes"
        Me.btn_comprobantes.Size = New System.Drawing.Size(23, 22)
        Me.btn_comprobantes.TabIndex = 57
        Me.btn_comprobantes.TabStop = False
        Me.btn_comprobantes.Text = "+"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(392, 10)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(188, 21)
        Me.txt_fecha.TabIndex = 3
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(679, 10)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(121, 35)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        '
        'txt_fecha_comp
        '
        Me.txt_fecha_comp.Location = New System.Drawing.Point(95, 88)
        Me.txt_fecha_comp.Name = "txt_fecha_comp"
        Me.txt_fecha_comp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_comp.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_comp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_comp.Properties.ReadOnly = True
        Me.txt_fecha_comp.Size = New System.Drawing.Size(216, 22)
        Me.txt_fecha_comp.TabIndex = 2
        '
        'txt_total_comp
        '
        Me.txt_total_comp.Location = New System.Drawing.Point(95, 62)
        Me.txt_total_comp.Name = "txt_total_comp"
        Me.txt_total_comp.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_comp.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_comp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_comp.Properties.Mask.EditMask = "n0"
        Me.txt_total_comp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_comp.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_comp.Properties.ReadOnly = True
        Me.txt_total_comp.Size = New System.Drawing.Size(216, 22)
        Me.txt_total_comp.TabIndex = 1
        '
        'txt_comprobante
        '
        Me.txt_comprobante.Location = New System.Drawing.Point(95, 9)
        Me.txt_comprobante.Name = "txt_comprobante"
        Me.txt_comprobante.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_comprobante.Properties.Appearance.Options.UseBackColor = True
        Me.txt_comprobante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_comprobante.Properties.ReadOnly = True
        Me.txt_comprobante.Size = New System.Drawing.Size(187, 22)
        Me.txt_comprobante.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Comp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Comp.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprobante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'cld_fecha
        '
        Me.cld_fecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha.Location = New System.Drawing.Point(609, 36)
        Me.cld_fecha.Name = "cld_fecha"
        Me.cld_fecha.Size = New System.Drawing.Size(250, 227)
        Me.cld_fecha.TabIndex = 56
        Me.cld_fecha.Visible = False
        '
        'frm_notas_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 495)
        Me.Controls.Add(Me.cld_fecha)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_notas_credito"
        Me.Text = "Notas de credito"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grid_items_comprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_codigo_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_costo_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_precio_unitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_comp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_comp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_fecha_comp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_comp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_comprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grid_items_comprobantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_codigo_barras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_descripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_precio_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cld_fecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btn_calendar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fecha As MaskedTextBox
    Friend WithEvents btn_comprobantes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_accion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_quitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_nota_credito_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_costo_unitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
End Class
