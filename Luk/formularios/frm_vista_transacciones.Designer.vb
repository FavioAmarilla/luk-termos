<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_transacciones
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
        Me.grid_transacciones = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_transaccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_vendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_accion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_transacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_transacciones
        '
        Me.grid_transacciones.Location = New System.Drawing.Point(12, 12)
        Me.grid_transacciones.MainView = Me.GridView1
        Me.grid_transacciones.Name = "grid_transacciones"
        Me.grid_transacciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_transacciones.Size = New System.Drawing.Size(380, 398)
        Me.grid_transacciones.TabIndex = 1
        Me.grid_transacciones.TabStop = False
        Me.grid_transacciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_pedido, Me.col_id_transaccion, Me.col_nombre, Me.col_id_vendedor, Me.col_id_cliente, Me.col_accion})
        Me.GridView1.GridControl = Me.grid_transacciones
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
        Me.col_id_pedido.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_pedido.FieldName = "id_pedido"
        Me.col_id_pedido.Name = "col_id_pedido"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_id_transaccion
        '
        Me.col_id_transaccion.Caption = "Id Transaccion"
        Me.col_id_transaccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_transaccion.FieldName = "id_transaccion"
        Me.col_id_transaccion.Name = "col_id_transaccion"
        Me.col_id_transaccion.Width = 214
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 241
        '
        'col_id_vendedor
        '
        Me.col_id_vendedor.Caption = "Id Vendedor"
        Me.col_id_vendedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_vendedor.FieldName = "vendedor"
        Me.col_id_vendedor.Name = "col_id_vendedor"
        '
        'col_id_cliente
        '
        Me.col_id_cliente.Caption = "Id Cliente"
        Me.col_id_cliente.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_cliente.FieldName = "id_cliente"
        Me.col_id_cliente.Name = "col_id_cliente"
        '
        'col_accion
        '
        Me.col_accion.Caption = "Accion"
        Me.col_accion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_accion.FieldName = "accion"
        Me.col_accion.Name = "col_accion"
        Me.col_accion.Visible = True
        Me.col_accion.VisibleIndex = 1
        Me.col_accion.Width = 131
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(24, 385)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_vista_transacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 422)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_transacciones)
        Me.Name = "frm_vista_transacciones"
        Me.Text = "<<Transacciones de Stock>>"
        CType(Me.grid_transacciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_transacciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_transaccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_vendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_accion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
