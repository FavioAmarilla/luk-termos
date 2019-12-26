<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_asignar_empleados_pedidos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_asignar_empleados_pedidos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_pedi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_pedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_asignacion = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_id_empleado = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_empleado = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_txt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_asignacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nuevo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_quitar_empleado = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_asignados = New DevExpress.XtraEditors.MemoEdit()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_pedi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_asignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_id_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_asignados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_confirmar)
        Me.GroupBox2.Controls.Add(Me.txt_fecha_pedi)
        Me.GroupBox2.Controls.Add(Me.txt_nro_pedido)
        Me.GroupBox2.Controls.Add(Me.txt_id_pedido)
        Me.GroupBox2.Controls.Add(Me.LabelControl16)
        Me.GroupBox2.Controls.Add(Me.LabelControl17)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Pedido"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(87, 76)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cantidad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cantidad.Properties.ReadOnly = True
        Me.txt_cantidad.Size = New System.Drawing.Size(260, 20)
        Me.txt_cantidad.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(18, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Cantidad art.:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(438, 58)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 16
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(438, 17)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 15
        Me.btn_confirmar.Text = "Confirmar"
        '
        'txt_fecha_pedi
        '
        Me.txt_fecha_pedi.Location = New System.Drawing.Point(87, 48)
        Me.txt_fecha_pedi.Name = "txt_fecha_pedi"
        Me.txt_fecha_pedi.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_pedi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_pedi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_pedi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha_pedi.Properties.ReadOnly = True
        Me.txt_fecha_pedi.Size = New System.Drawing.Size(260, 22)
        Me.txt_fecha_pedi.TabIndex = 14
        '
        'txt_nro_pedido
        '
        Me.txt_nro_pedido.Location = New System.Drawing.Point(132, 20)
        Me.txt_nro_pedido.Name = "txt_nro_pedido"
        Me.txt_nro_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_pedido.Properties.ReadOnly = True
        Me.txt_nro_pedido.Size = New System.Drawing.Size(215, 22)
        Me.txt_nro_pedido.TabIndex = 13
        '
        'txt_id_pedido
        '
        Me.txt_id_pedido.Location = New System.Drawing.Point(87, 20)
        Me.txt_id_pedido.Name = "txt_id_pedido"
        Me.txt_id_pedido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_pedido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_pedido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_pedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_pedido.Properties.ReadOnly = True
        Me.txt_id_pedido.Size = New System.Drawing.Size(44, 22)
        Me.txt_id_pedido.TabIndex = 3
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl16.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl16.TabIndex = 3
        Me.LabelControl16.Text = "Fecha Pedido:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabelControl17.Location = New System.Drawing.Point(41, 25)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl17.TabIndex = 0
        Me.LabelControl17.Text = "Numero:"
        '
        'grid_asignacion
        '
        Me.grid_asignacion.Location = New System.Drawing.Point(12, 146)
        Me.grid_asignacion.MainView = Me.GridView2
        Me.grid_asignacion.Name = "grid_asignacion"
        Me.grid_asignacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_txt_empleado, Me.rps_txt_cantidad, Me.rps_txt_id_empleado})
        Me.grid_asignacion.Size = New System.Drawing.Size(575, 221)
        Me.grid_asignacion.TabIndex = 0
        Me.grid_asignacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_empleado, Me.col_empleado, Me.GridColumn2, Me.col_id_asignacion, Me.col_nuevo})
        Me.GridView2.GridControl = Me.grid_asignacion
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsFind.ShowClearButton = False
        Me.GridView2.OptionsFind.ShowCloseButton = False
        Me.GridView2.OptionsFind.ShowFindButton = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'col_id_empleado
        '
        Me.col_id_empleado.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_id_empleado.AppearanceCell.Options.UseBorderColor = True
        Me.col_id_empleado.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empleado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empleado.Caption = "Id Empleado"
        Me.col_id_empleado.ColumnEdit = Me.rps_txt_id_empleado
        Me.col_id_empleado.FieldName = "id_empleado"
        Me.col_id_empleado.Name = "col_id_empleado"
        Me.col_id_empleado.Width = 140
        '
        'rps_txt_id_empleado
        '
        Me.rps_txt_id_empleado.AutoHeight = False
        Me.rps_txt_id_empleado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rps_txt_id_empleado.Name = "rps_txt_id_empleado"
        '
        'col_empleado
        '
        Me.col_empleado.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_empleado.AppearanceCell.Options.UseBorderColor = True
        Me.col_empleado.Caption = "Empleado"
        Me.col_empleado.ColumnEdit = Me.rps_txt_empleado
        Me.col_empleado.FieldName = "empleado"
        Me.col_empleado.Name = "col_empleado"
        Me.col_empleado.OptionsColumn.ReadOnly = True
        Me.col_empleado.Visible = True
        Me.col_empleado.VisibleIndex = 0
        Me.col_empleado.Width = 243
        '
        'rps_txt_empleado
        '
        Me.rps_txt_empleado.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_empleado.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_empleado.AutoHeight = False
        Me.rps_txt_empleado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_empleado.Name = "rps_txt_empleado"
        Me.rps_txt_empleado.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.GridColumn2.AppearanceCell.Options.UseBorderColor = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.Caption = "Cantidad Asignada"
        Me.GridColumn2.ColumnEdit = Me.rps_txt_cantidad
        Me.GridColumn2.FieldName = "cantidad"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 123
        '
        'rps_txt_cantidad
        '
        Me.rps_txt_cantidad.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.rps_txt_cantidad.AppearanceFocused.Options.UseBackColor = True
        Me.rps_txt_cantidad.AutoHeight = False
        Me.rps_txt_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_cantidad.Name = "rps_txt_cantidad"
        '
        'col_id_asignacion
        '
        Me.col_id_asignacion.Caption = "Id Asignacion"
        Me.col_id_asignacion.FieldName = "id_asignacion_pedido_empleado"
        Me.col_id_asignacion.Name = "col_id_asignacion"
        '
        'col_nuevo
        '
        Me.col_nuevo.Caption = "nuevo"
        Me.col_nuevo.FieldName = "nuevo"
        Me.col_nuevo.Name = "col_nuevo"
        '
        'btn_quitar_empleado
        '
        Me.btn_quitar_empleado.Location = New System.Drawing.Point(415, 158)
        Me.btn_quitar_empleado.Name = "btn_quitar_empleado"
        Me.btn_quitar_empleado.Size = New System.Drawing.Size(74, 22)
        Me.btn_quitar_empleado.TabIndex = 26
        Me.btn_quitar_empleado.Text = "Quitar"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(495, 158)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(74, 22)
        Me.btn_agregar.TabIndex = 27
        Me.btn_agregar.Text = "Agregar"
        '
        'txt_asignados
        '
        Me.txt_asignados.Location = New System.Drawing.Point(12, 375)
        Me.txt_asignados.Name = "txt_asignados"
        Me.txt_asignados.Size = New System.Drawing.Size(575, 96)
        Me.txt_asignados.TabIndex = 28
        '
        'frm_asignar_empleados_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 483)
        Me.Controls.Add(Me.txt_asignados)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_quitar_empleado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grid_asignacion)
        Me.Name = "frm_asignar_empleados_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar empleados a pedido"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_pedi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_pedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_asignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_id_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_asignados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_fecha_pedi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_pedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_asignacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_id_empleado As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_empleado As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_txt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_id_asignacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nuevo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_quitar_empleado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_cantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_asignados As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
End Class
