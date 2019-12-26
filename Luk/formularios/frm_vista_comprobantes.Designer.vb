<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_comprobantes
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
        Me.grid_ventas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_Caracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_comprobante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_Caracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_ventas
        '
        Me.grid_ventas.Location = New System.Drawing.Point(12, 12)
        Me.grid_ventas.MainView = Me.GridView1
        Me.grid_ventas.Name = "grid_ventas"
        Me.grid_ventas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_Caracter, Me.rps_miles, Me.rps_fecha})
        Me.grid_ventas.Size = New System.Drawing.Size(463, 432)
        Me.grid_ventas.TabIndex = 1
        Me.grid_ventas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_venta, Me.col_fecha, Me.col_cliente, Me.col_comprobante, Me.col_total})
        Me.GridView1.GridControl = Me.grid_ventas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_venta
        '
        Me.col_id_venta.Caption = "Id venta"
        Me.col_id_venta.FieldName = "id_venta"
        Me.col_id_venta.Name = "col_id_venta"
        '
        'col_fecha
        '
        Me.col_fecha.Caption = "Fecha"
        Me.col_fecha.ColumnEdit = Me.rps_fecha
        Me.col_fecha.FieldName = "fecha_venta"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 0
        Me.col_fecha.Width = 80
        '
        'rps_fecha
        '
        Me.rps_fecha.AutoHeight = False
        Me.rps_fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_fecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rps_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rps_fecha.Name = "rps_fecha"
        '
        'col_cliente
        '
        Me.col_cliente.Caption = "Cliente"
        Me.col_cliente.ColumnEdit = Me.rps_Caracter
        Me.col_cliente.FieldName = "cliente"
        Me.col_cliente.Name = "col_cliente"
        Me.col_cliente.Visible = True
        Me.col_cliente.VisibleIndex = 1
        Me.col_cliente.Width = 185
        '
        'rps_Caracter
        '
        Me.rps_Caracter.AutoHeight = False
        Me.rps_Caracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_Caracter.Name = "rps_Caracter"
        '
        'col_comprobante
        '
        Me.col_comprobante.Caption = "Comprobante"
        Me.col_comprobante.ColumnEdit = Me.rps_Caracter
        Me.col_comprobante.FieldName = "numero"
        Me.col_comprobante.Name = "col_comprobante"
        Me.col_comprobante.Visible = True
        Me.col_comprobante.VisibleIndex = 2
        Me.col_comprobante.Width = 108
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.rps_miles
        Me.col_total.FieldName = "total_venta"
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 3
        Me.col_total.Width = 72
        '
        'rps_miles
        '
        Me.rps_miles.AutoHeight = False
        Me.rps_miles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_miles.DisplayFormat.FormatString = "#,#"
        Me.rps_miles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_miles.Name = "rps_miles"
        '
        'frm_vista_comprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 457)
        Me.Controls.Add(Me.grid_ventas)
        Me.Name = "frm_vista_comprobantes"
        Me.Text = "Comprobantes"
        CType(Me.grid_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_Caracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_miles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_ventas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_comprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_Caracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_cliente As DevExpress.XtraGrid.Columns.GridColumn
End Class
