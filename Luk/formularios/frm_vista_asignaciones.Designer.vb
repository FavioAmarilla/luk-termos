﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vista_asignaciones
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
        Me.grid_asignaciones = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_asignacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_mano_obra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pago_extra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_asignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_asignaciones
        '
        Me.grid_asignaciones.Location = New System.Drawing.Point(21, 19)
        Me.grid_asignaciones.MainView = Me.GridView1
        Me.grid_asignaciones.Name = "grid_asignaciones"
        Me.grid_asignaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_asignaciones.Size = New System.Drawing.Size(547, 446)
        Me.grid_asignaciones.TabIndex = 1
        Me.grid_asignaciones.TabStop = False
        Me.grid_asignaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_asignacion, Me.col_pedido, Me.col_empleado, Me.col_mano_obra, Me.col_pago_extra})
        Me.GridView1.GridControl = Me.grid_asignaciones
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
        'col_id_asignacion
        '
        Me.col_id_asignacion.Caption = "Id Asignacion"
        Me.col_id_asignacion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_asignacion.FieldName = "id_asignacion"
        Me.col_id_asignacion.Name = "col_id_asignacion"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_pedido
        '
        Me.col_pedido.Caption = "Pedido Nro."
        Me.col_pedido.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_pedido.FieldName = "pedido"
        Me.col_pedido.Name = "col_pedido"
        Me.col_pedido.Visible = True
        Me.col_pedido.VisibleIndex = 0
        Me.col_pedido.Width = 88
        '
        'col_empleado
        '
        Me.col_empleado.Caption = "Empleado"
        Me.col_empleado.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_empleado.FieldName = "empleado"
        Me.col_empleado.Name = "col_empleado"
        Me.col_empleado.Visible = True
        Me.col_empleado.VisibleIndex = 1
        Me.col_empleado.Width = 246
        '
        'col_mano_obra
        '
        Me.col_mano_obra.Caption = "Mano Obra"
        Me.col_mano_obra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_mano_obra.FieldName = "mano_obra"
        Me.col_mano_obra.Name = "col_mano_obra"
        Me.col_mano_obra.Visible = True
        Me.col_mano_obra.VisibleIndex = 2
        Me.col_mano_obra.Width = 94
        '
        'col_pago_extra
        '
        Me.col_pago_extra.Caption = "Pago Extra"
        Me.col_pago_extra.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_pago_extra.FieldName = "pago_extra"
        Me.col_pago_extra.Name = "col_pago_extra"
        Me.col_pago_extra.Visible = True
        Me.col_pago_extra.VisibleIndex = 3
        Me.col_pago_extra.Width = 101
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(201, 439)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 86
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_vista_asignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 484)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_asignaciones)
        Me.Name = "frm_vista_asignaciones"
        Me.Text = "<<Manosde Obras>>"
        CType(Me.grid_asignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_asignaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_id_asignacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_mano_obra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pago_extra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class