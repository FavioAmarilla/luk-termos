<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vista_pedidos
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
        Me.grid_pedidos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nro_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_costo_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_vendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cod_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.txt_buscar = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grid_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_buscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_pedidos
        '
        Me.grid_pedidos.Location = New System.Drawing.Point(30, 22)
        Me.grid_pedidos.MainView = Me.GridView1
        Me.grid_pedidos.Name = "grid_pedidos"
        Me.grid_pedidos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.grid_pedidos.Size = New System.Drawing.Size(806, 460)
        Me.grid_pedidos.TabIndex = 0
        Me.grid_pedidos.TabStop = False
        Me.grid_pedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_pedido, Me.col_nro_pedido, Me.col_costo_total, Me.col_id_vendedor, Me.col_id_cliente, Me.col_cliente, Me.col_estado, Me.col_fecha, Me.col_articulo, Me.col_cod_barras})
        Me.GridView1.GridControl = Me.grid_pedidos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_pedido
        '
        Me.col_id_pedido.Caption = "Id Pedido"
        Me.col_id_pedido.FieldName = "id_pedido"
        Me.col_id_pedido.Name = "col_id_pedido"
        '
        'col_nro_pedido
        '
        Me.col_nro_pedido.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_pedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_pedido.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_pedido.Caption = "Nro. de Pedido"
        Me.col_nro_pedido.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_pedido.FieldName = "numero"
        Me.col_nro_pedido.Name = "col_nro_pedido"
        Me.col_nro_pedido.Visible = True
        Me.col_nro_pedido.VisibleIndex = 0
        Me.col_nro_pedido.Width = 94
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_costo_total
        '
        Me.col_costo_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_costo_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_costo_total.Caption = "Costo Total"
        Me.col_costo_total.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_costo_total.DisplayFormat.FormatString = "#,#"
        Me.col_costo_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_costo_total.FieldName = "costo_total"
        Me.col_costo_total.Name = "col_costo_total"
        Me.col_costo_total.Visible = True
        Me.col_costo_total.VisibleIndex = 5
        Me.col_costo_total.Width = 95
        '
        'col_id_vendedor
        '
        Me.col_id_vendedor.Caption = "Id Vendedor"
        Me.col_id_vendedor.FieldName = "vendedor"
        Me.col_id_vendedor.Name = "col_id_vendedor"
        '
        'col_id_cliente
        '
        Me.col_id_cliente.Caption = "Id Cliente"
        Me.col_id_cliente.FieldName = "id_cliente"
        Me.col_id_cliente.Name = "col_id_cliente"
        '
        'col_cliente
        '
        Me.col_cliente.Caption = "Cliente"
        Me.col_cliente.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_cliente.FieldName = "cliente"
        Me.col_cliente.Name = "col_cliente"
        Me.col_cliente.Visible = True
        Me.col_cliente.VisibleIndex = 2
        Me.col_cliente.Width = 146
        '
        'col_estado
        '
        Me.col_estado.AppearanceCell.Options.UseTextOptions = True
        Me.col_estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_estado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_estado.Caption = "Estado"
        Me.col_estado.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_estado.FieldName = "estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.Visible = True
        Me.col_estado.VisibleIndex = 6
        Me.col_estado.Width = 86
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "Fecha Ped."
        Me.col_fecha.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fecha.FieldName = "fecha_pedido"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 1
        Me.col_fecha.Width = 92
        '
        'col_articulo
        '
        Me.col_articulo.Caption = "Articulo"
        Me.col_articulo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_articulo.FieldName = "articulo"
        Me.col_articulo.Name = "col_articulo"
        Me.col_articulo.Visible = True
        Me.col_articulo.VisibleIndex = 4
        Me.col_articulo.Width = 162
        '
        'col_cod_barras
        '
        Me.col_cod_barras.Caption = "Codigo Barras"
        Me.col_cod_barras.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_cod_barras.FieldName = "codigo_barras"
        Me.col_cod_barras.Name = "col_cod_barras"
        Me.col_cod_barras.Visible = True
        Me.col_cod_barras.VisibleIndex = 3
        Me.col_cod_barras.Width = 113
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(466, 457)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 86
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(43, 32)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_buscar.Size = New System.Drawing.Size(351, 22)
        Me.txt_buscar.TabIndex = 87
        '
        'frm_vista_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 504)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_pedidos)
        Me.Name = "frm_vista_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Pedidos>>"
        CType(Me.grid_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_buscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_pedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_costo_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_vendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_cod_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_buscar As DevExpress.XtraEditors.TextEdit
End Class
