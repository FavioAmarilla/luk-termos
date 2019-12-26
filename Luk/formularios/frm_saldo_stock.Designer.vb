<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_saldo_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_saldo_stock))
        Me.grid_movimientos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_accion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ingreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_egreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_item = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_item = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.chk_materia_prima = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_articulo = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cld_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_movimientos
        '
        Me.grid_movimientos.Location = New System.Drawing.Point(12, 155)
        Me.grid_movimientos.MainView = Me.GridView1
        Me.grid_movimientos.Name = "grid_movimientos"
        Me.grid_movimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.grid_movimientos.Size = New System.Drawing.Size(842, 363)
        Me.grid_movimientos.TabIndex = 1
        Me.grid_movimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_fecha, Me.col_nombre, Me.col_accion, Me.col_ingreso, Me.col_egreso, Me.col_saldo})
        Me.GridView1.GridControl = Me.grid_movimientos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_fecha
        '
        Me.col_fecha.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha.Caption = "Fecha"
        Me.col_fecha.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_fecha.FieldName = "fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 0
        Me.col_fecha.Width = 90
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Transaccion"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 1
        Me.col_nombre.Width = 268
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_accion
        '
        Me.col_accion.AppearanceCell.Options.UseTextOptions = True
        Me.col_accion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_accion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_accion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_accion.Caption = "Accion"
        Me.col_accion.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_accion.FieldName = "accion"
        Me.col_accion.Name = "col_accion"
        Me.col_accion.Visible = True
        Me.col_accion.VisibleIndex = 2
        Me.col_accion.Width = 100
        '
        'col_ingreso
        '
        Me.col_ingreso.AppearanceCell.Options.UseTextOptions = True
        Me.col_ingreso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ingreso.AppearanceHeader.Options.UseTextOptions = True
        Me.col_ingreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ingreso.Caption = "Ingreso"
        Me.col_ingreso.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_ingreso.FieldName = "ingreso"
        Me.col_ingreso.Name = "col_ingreso"
        Me.col_ingreso.Visible = True
        Me.col_ingreso.VisibleIndex = 3
        Me.col_ingreso.Width = 100
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_egreso
        '
        Me.col_egreso.AppearanceCell.Options.UseTextOptions = True
        Me.col_egreso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_egreso.AppearanceHeader.Options.UseTextOptions = True
        Me.col_egreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_egreso.Caption = "Egreso"
        Me.col_egreso.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_egreso.FieldName = "egreso"
        Me.col_egreso.Name = "col_egreso"
        Me.col_egreso.Visible = True
        Me.col_egreso.VisibleIndex = 4
        Me.col_egreso.Width = 100
        '
        'col_saldo
        '
        Me.col_saldo.AppearanceCell.Options.UseTextOptions = True
        Me.col_saldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_saldo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_saldo.Caption = "Saldo Actual"
        Me.col_saldo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_saldo.FieldName = "saldo_actual"
        Me.col_saldo.Name = "col_saldo"
        Me.col_saldo.Visible = True
        Me.col_saldo.VisibleIndex = 5
        Me.col_saldo.Width = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_desde)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.btn_item)
        Me.GroupBox1.Controls.Add(Me.txt_item)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.chk_materia_prima)
        Me.GroupBox1.Controls.Add(Me.chk_articulo)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_hasta
        '
        Me.btn_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_hasta.Location = New System.Drawing.Point(574, 56)
        Me.btn_hasta.Name = "btn_hasta"
        Me.btn_hasta.Size = New System.Drawing.Size(23, 23)
        Me.btn_hasta.TabIndex = 56
        Me.btn_hasta.TabStop = False
        Me.btn_hasta.Text = "+"
        '
        'btn_desde
        '
        Me.btn_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_desde.Location = New System.Drawing.Point(574, 29)
        Me.btn_desde.Name = "btn_desde"
        Me.btn_desde.Size = New System.Drawing.Size(23, 23)
        Me.btn_desde.TabIndex = 55
        Me.btn_desde.TabStop = False
        Me.btn_desde.Text = "+"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(53, 84)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo.Properties.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(233, 22)
        Me.txt_codigo.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Codigo:"
        '
        'btn_item
        '
        Me.btn_item.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_item.Location = New System.Drawing.Point(257, 58)
        Me.btn_item.Name = "btn_item"
        Me.btn_item.Size = New System.Drawing.Size(29, 20)
        Me.btn_item.TabIndex = 10
        Me.btn_item.Text = "+"
        '
        'txt_item
        '
        Me.txt_item.Location = New System.Drawing.Point(53, 58)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_item.Properties.Appearance.Options.UseBackColor = True
        Me.txt_item.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_item.Properties.ReadOnly = True
        Me.txt_item.Size = New System.Drawing.Size(203, 22)
        Me.txt_item.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(25, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Item:"
        '
        'chk_materia_prima
        '
        Me.chk_materia_prima.Location = New System.Drawing.Point(120, 30)
        Me.chk_materia_prima.Name = "chk_materia_prima"
        Me.chk_materia_prima.Properties.Caption = "Materia Prima"
        Me.chk_materia_prima.Size = New System.Drawing.Size(95, 19)
        Me.chk_materia_prima.TabIndex = 1
        '
        'chk_articulo
        '
        Me.chk_articulo.Location = New System.Drawing.Point(53, 30)
        Me.chk_articulo.Name = "chk_articulo"
        Me.chk_articulo.Properties.Caption = "Articulo"
        Me.chk_articulo.Size = New System.Drawing.Size(72, 19)
        Me.chk_articulo.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(646, 71)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(646, 30)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 6
        Me.btn_consultar.Text = "Consultar"
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(368, 57)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(203, 21)
        Me.txt_fecha_hasta.TabIndex = 5
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.Location = New System.Drawing.Point(368, 30)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(203, 21)
        Me.txt_fecha_desde.TabIndex = 4
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(301, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(299, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'cld_hasta
        '
        Me.cld_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_hasta.Location = New System.Drawing.Point(586, 67)
        Me.cld_hasta.Name = "cld_hasta"
        Me.cld_hasta.Size = New System.Drawing.Size(251, 227)
        Me.cld_hasta.TabIndex = 56
        Me.cld_hasta.Visible = False
        '
        'cld_desde
        '
        Me.cld_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_desde.Location = New System.Drawing.Point(586, 41)
        Me.cld_desde.Name = "cld_desde"
        Me.cld_desde.Size = New System.Drawing.Size(251, 227)
        Me.cld_desde.TabIndex = 57
        Me.cld_desde.Visible = False
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(491, 493)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_saldo_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 535)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_desde)
        Me.Controls.Add(Me.cld_hasta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_movimientos)
        Me.Name = "frm_saldo_stock"
        Me.Text = "<<Saldos de Stock>>"
        CType(Me.grid_movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_materia_prima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_movimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_accion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ingreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_egreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_item As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_item As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_materia_prima As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_articulo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cld_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
