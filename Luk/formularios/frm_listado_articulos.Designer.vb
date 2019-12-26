<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_listado_articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_articulos))
        Me.grid_listado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_familia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tipo_impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_proveedores = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.btn_familia = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.chk_proveedor = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_familia = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_todos = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_todos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_listado
        '
        Me.grid_listado.Location = New System.Drawing.Point(316, 12)
        Me.grid_listado.MainView = Me.GridView1
        Me.grid_listado.Name = "grid_listado"
        Me.grid_listado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_listado.Size = New System.Drawing.Size(913, 471)
        Me.grid_listado.TabIndex = 1
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
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_nombre, Me.col_costo_unitario, Me.col_precio_venta, Me.col_familia, Me.col_codigo_barras, Me.col_proveedor, Me.col_tipo_impuesto})
        Me.GridView1.GridControl = Me.grid_listado
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsPrint.RtfPageFooter = resources.GetString("GridView1.OptionsPrint.RtfPageFooter")
        Me.GridView1.OptionsPrint.RtfReportHeader = resources.GetString("GridView1.OptionsPrint.RtfReportHeader")
        Me.GridView1.OptionsPrint.UsePrintStyles = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.col_familia, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'col_nombre
        '
        Me.col_nombre.AppearanceCell.Options.UseTextOptions = True
        Me.col_nombre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombre.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 1
        Me.col_nombre.Width = 221
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_costo_unitario
        '
        Me.col_costo_unitario.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_unitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_unitario.Caption = "Costo Unitario"
        Me.col_costo_unitario.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_costo_unitario.DisplayFormat.FormatString = "#,#"
        Me.col_costo_unitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_unitario.FieldName = "costo_unitario"
        Me.col_costo_unitario.Name = "col_costo_unitario"
        Me.col_costo_unitario.Visible = True
        Me.col_costo_unitario.VisibleIndex = 4
        Me.col_costo_unitario.Width = 92
        '
        'col_precio_venta
        '
        Me.col_precio_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_precio_venta.Caption = "Precio Venta"
        Me.col_precio_venta.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_precio_venta.DisplayFormat.FormatString = "#,#"
        Me.col_precio_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_venta.FieldName = "precio_venta"
        Me.col_precio_venta.Name = "col_precio_venta"
        Me.col_precio_venta.Visible = True
        Me.col_precio_venta.VisibleIndex = 5
        Me.col_precio_venta.Width = 99
        '
        'col_familia
        '
        Me.col_familia.AppearanceCell.Options.UseTextOptions = True
        Me.col_familia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_familia.AppearanceHeader.Options.UseTextOptions = True
        Me.col_familia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_familia.Caption = "Familia"
        Me.col_familia.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_familia.FieldName = "familia"
        Me.col_familia.Name = "col_familia"
        Me.col_familia.Visible = True
        Me.col_familia.VisibleIndex = 2
        Me.col_familia.Width = 105
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.AppearanceCell.Options.UseTextOptions = True
        Me.col_codigo_barras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_codigo_barras.AppearanceHeader.Options.UseTextOptions = True
        Me.col_codigo_barras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_codigo_barras.Caption = "Codigo Barras"
        Me.col_codigo_barras.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 116
        '
        'col_proveedor
        '
        Me.col_proveedor.AppearanceCell.Options.UseTextOptions = True
        Me.col_proveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_proveedor.AppearanceHeader.Options.UseTextOptions = True
        Me.col_proveedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_proveedor.Caption = "Proveedor"
        Me.col_proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_proveedor.FieldName = "proveedor"
        Me.col_proveedor.Name = "col_proveedor"
        Me.col_proveedor.Visible = True
        Me.col_proveedor.VisibleIndex = 2
        Me.col_proveedor.Width = 231
        '
        'col_tipo_impuesto
        '
        Me.col_tipo_impuesto.AppearanceCell.Options.UseTextOptions = True
        Me.col_tipo_impuesto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_tipo_impuesto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_tipo_impuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_tipo_impuesto.Caption = "Tipo Impuesto"
        Me.col_tipo_impuesto.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_tipo_impuesto.FieldName = "tipo_impuesto"
        Me.col_tipo_impuesto.Name = "col_tipo_impuesto"
        Me.col_tipo_impuesto.Visible = True
        Me.col_tipo_impuesto.VisibleIndex = 3
        Me.col_tipo_impuesto.Width = 133
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(157, 275)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.btn_proveedores)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_familia)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.chk_proveedor)
        Me.GroupBox1.Controls.Add(Me.chk_familia)
        Me.GroupBox1.Controls.Add(Me.chk_todos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro Busqueda"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(16, 275)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        '
        'btn_proveedores
        '
        Me.btn_proveedores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_proveedores.Location = New System.Drawing.Point(247, 132)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(27, 21)
        Me.btn_proveedores.TabIndex = 18
        Me.btn_proveedores.Text = "+"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(16, 132)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(229, 22)
        Me.txt_proveedor.TabIndex = 2
        '
        'btn_familia
        '
        Me.btn_familia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_familia.Location = New System.Drawing.Point(247, 82)
        Me.btn_familia.Name = "btn_familia"
        Me.btn_familia.Size = New System.Drawing.Size(27, 21)
        Me.btn_familia.TabIndex = 16
        Me.btn_familia.Text = "+"
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(16, 82)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(229, 22)
        Me.txt_familia.TabIndex = 1
        '
        'chk_proveedor
        '
        Me.chk_proveedor.Location = New System.Drawing.Point(16, 110)
        Me.chk_proveedor.Name = "chk_proveedor"
        Me.chk_proveedor.Properties.Caption = "Proveedor:"
        Me.chk_proveedor.Size = New System.Drawing.Size(75, 19)
        Me.chk_proveedor.TabIndex = 2
        '
        'chk_familia
        '
        Me.chk_familia.Location = New System.Drawing.Point(16, 60)
        Me.chk_familia.Name = "chk_familia"
        Me.chk_familia.Properties.Caption = "Familia:"
        Me.chk_familia.Size = New System.Drawing.Size(75, 19)
        Me.chk_familia.TabIndex = 1
        '
        'chk_todos
        '
        Me.chk_todos.Location = New System.Drawing.Point(16, 35)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Properties.Caption = "Todos"
        Me.chk_todos.Size = New System.Drawing.Size(75, 19)
        Me.chk_todos.TabIndex = 0
        '
        'frm_listado_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_listado)
        Me.Name = "frm_listado_articulos"
        Me.Text = "<<Listado de Articulos por Familia>>"
        CType(Me.grid_listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_todos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_listado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_familia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tipo_impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_todos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_familia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_proveedores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_proveedor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_familia As DevExpress.XtraEditors.CheckEdit
End Class
