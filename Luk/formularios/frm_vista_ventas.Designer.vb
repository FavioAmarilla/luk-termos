<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_ventas
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
        Me.col_nro_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_Caracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_comision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_vendedor = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.grid_ventas.Size = New System.Drawing.Size(419, 447)
        Me.grid_ventas.TabIndex = 0
        Me.grid_ventas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_venta, Me.col_fecha, Me.col_nro_venta, Me.col_comision, Me.col_vendedor})
        Me.GridView1.GridControl = Me.grid_ventas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
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
        Me.col_fecha.FieldName = "fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 0
        Me.col_fecha.Width = 69
        '
        'rps_fecha
        '
        Me.rps_fecha.AutoHeight = False
        Me.rps_fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_fecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rps_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rps_fecha.Name = "rps_fecha"
        '
        'col_nro_venta
        '
        Me.col_nro_venta.Caption = "Nro. venta"
        Me.col_nro_venta.ColumnEdit = Me.rps_Caracter
        Me.col_nro_venta.FieldName = "numero"
        Me.col_nro_venta.Name = "col_nro_venta"
        Me.col_nro_venta.Visible = True
        Me.col_nro_venta.VisibleIndex = 1
        Me.col_nro_venta.Width = 84
        '
        'rps_Caracter
        '
        Me.rps_Caracter.AutoHeight = False
        Me.rps_Caracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_Caracter.Name = "rps_Caracter"
        '
        'col_comision
        '
        Me.col_comision.AppearanceCell.Options.UseTextOptions = True
        Me.col_comision.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.AppearanceHeader.Options.UseTextOptions = True
        Me.col_comision.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_comision.Caption = "Comision"
        Me.col_comision.ColumnEdit = Me.rps_miles
        Me.col_comision.FieldName = "comision"
        Me.col_comision.Name = "col_comision"
        Me.col_comision.Visible = True
        Me.col_comision.VisibleIndex = 3
        Me.col_comision.Width = 90
        '
        'rps_miles
        '
        Me.rps_miles.AutoHeight = False
        Me.rps_miles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_miles.DisplayFormat.FormatString = "#,#"
        Me.rps_miles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_miles.Name = "rps_miles"
        '
        'col_vendedor
        '
        Me.col_vendedor.Caption = "Vendedor"
        Me.col_vendedor.ColumnEdit = Me.rps_Caracter
        Me.col_vendedor.FieldName = "vendedor"
        Me.col_vendedor.Name = "col_vendedor"
        Me.col_vendedor.Visible = True
        Me.col_vendedor.VisibleIndex = 2
        Me.col_vendedor.Width = 231
        '
        'frm_vista_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 471)
        Me.Controls.Add(Me.grid_ventas)
        Me.Name = "frm_vista_ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
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
    Friend WithEvents col_nro_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_comision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_vendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_Caracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
