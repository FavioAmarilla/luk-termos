<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_compras
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
        Me.grid_compras = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tipo_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_compras
        '
        Me.grid_compras.Location = New System.Drawing.Point(22, 23)
        Me.grid_compras.MainView = Me.GridView1
        Me.grid_compras.Name = "grid_compras"
        Me.grid_compras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_compras.Size = New System.Drawing.Size(773, 465)
        Me.grid_compras.TabIndex = 0
        Me.grid_compras.TabStop = False
        Me.grid_compras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_compra, Me.col_numero, Me.col_fecha, Me.col_proveedor, Me.col_tipo_compra, Me.col_total})
        Me.GridView1.GridControl = Me.grid_compras
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
        'col_id_compra
        '
        Me.col_id_compra.Caption = "Id Compra"
        Me.col_id_compra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_compra.FieldName = "id_compra"
        Me.col_id_compra.Name = "col_id_compra"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_numero
        '
        Me.col_numero.AppearanceCell.Options.UseTextOptions = True
        Me.col_numero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_numero.AppearanceHeader.Options.UseTextOptions = True
        Me.col_numero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_numero.Caption = "Numero"
        Me.col_numero.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_numero.FieldName = "numero"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.Visible = True
        Me.col_numero.VisibleIndex = 0
        Me.col_numero.Width = 85
        '
        'col_fecha
        '
        Me.col_fecha.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha.Caption = "Fecha"
        Me.col_fecha.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_fecha.FieldName = "fecha_compra"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 3
        Me.col_fecha.Width = 93
        '
        'col_proveedor
        '
        Me.col_proveedor.Caption = "Proveedor"
        Me.col_proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_proveedor.FieldName = "proveedor"
        Me.col_proveedor.Name = "col_proveedor"
        Me.col_proveedor.Visible = True
        Me.col_proveedor.VisibleIndex = 1
        Me.col_proveedor.Width = 247
        '
        'col_tipo_compra
        '
        Me.col_tipo_compra.Caption = "Tipo Compra"
        Me.col_tipo_compra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_tipo_compra.FieldName = "tipo_compra"
        Me.col_tipo_compra.Name = "col_tipo_compra"
        Me.col_tipo_compra.Visible = True
        Me.col_tipo_compra.VisibleIndex = 2
        Me.col_tipo_compra.Width = 218
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total.Caption = "Total Compra"
        Me.col_total.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total_compra"
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 112
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(423, 461)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_vista_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 510)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_compras)
        Me.Name = "frm_vista_compras"
        Me.Text = "<<Compras>>"
        CType(Me.grid_compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_compras As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tipo_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
