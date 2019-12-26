<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExistenciaStockItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExistenciaStockItems))
        Me.grid_stock = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.familia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_existencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_buscar_proveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.btn_familia = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.cbo_tipo_movimiento = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_tipo_movimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_stock
        '
        Me.grid_stock.Location = New System.Drawing.Point(362, 12)
        Me.grid_stock.MainView = Me.GridView1
        Me.grid_stock.Name = "grid_stock"
        Me.grid_stock.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit3})
        Me.grid_stock.Size = New System.Drawing.Size(684, 490)
        Me.grid_stock.TabIndex = 113
        Me.grid_stock.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.familia, Me.proveedor, Me.col_existencia, Me.col_item, Me.col_codigo})
        Me.GridView1.GridControl = Me.grid_stock
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.familia, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'familia
        '
        Me.familia.AppearanceCell.Options.UseTextOptions = True
        Me.familia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.familia.AppearanceHeader.Options.UseTextOptions = True
        Me.familia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.familia.Caption = "Familia"
        Me.familia.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.familia.FieldName = "familia"
        Me.familia.Name = "familia"
        Me.familia.Visible = True
        Me.familia.VisibleIndex = 3
        Me.familia.Width = 160
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'proveedor
        '
        Me.proveedor.Caption = "Proveedor"
        Me.proveedor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.proveedor.FieldName = "proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Visible = True
        Me.proveedor.VisibleIndex = 2
        Me.proveedor.Width = 230
        '
        'col_existencia
        '
        Me.col_existencia.AppearanceCell.Options.UseTextOptions = True
        Me.col_existencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_existencia.AppearanceHeader.Options.UseTextOptions = True
        Me.col_existencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_existencia.Caption = "Existencia"
        Me.col_existencia.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_existencia.FieldName = "existencia"
        Me.col_existencia.Name = "col_existencia"
        Me.col_existencia.Visible = True
        Me.col_existencia.VisibleIndex = 3
        Me.col_existencia.Width = 98
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_item.FieldName = "item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 1
        Me.col_item.Width = 230
        '
        'col_codigo
        '
        Me.col_codigo.Caption = "Codigo"
        Me.col_codigo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_codigo.FieldName = "codigo"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Visible = True
        Me.col_codigo.VisibleIndex = 0
        Me.col_codigo.Width = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_familia)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_movimiento)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 316)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 124)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 90
        Me.LabelControl2.Text = "Proveedor:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(33, 98)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "Familia:"
        '
        'btn_buscar_proveedor
        '
        Me.btn_buscar_proveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_proveedor.Location = New System.Drawing.Point(303, 120)
        Me.btn_buscar_proveedor.Name = "btn_buscar_proveedor"
        Me.btn_buscar_proveedor.Size = New System.Drawing.Size(27, 21)
        Me.btn_buscar_proveedor.TabIndex = 88
        Me.btn_buscar_proveedor.Text = "+"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(72, 120)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(229, 22)
        Me.txt_proveedor.TabIndex = 85
        '
        'btn_familia
        '
        Me.btn_familia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_familia.Location = New System.Drawing.Point(303, 94)
        Me.btn_familia.Name = "btn_familia"
        Me.btn_familia.Size = New System.Drawing.Size(27, 21)
        Me.btn_familia.TabIndex = 87
        Me.btn_familia.Text = "+"
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(72, 94)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(229, 22)
        Me.txt_familia.TabIndex = 83
        '
        'cbo_tipo_movimiento
        '
        Me.cbo_tipo_movimiento.Location = New System.Drawing.Point(72, 67)
        Me.cbo_tipo_movimiento.Name = "cbo_tipo_movimiento"
        Me.cbo_tipo_movimiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_tipo_movimiento.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_tipo_movimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_movimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_movimiento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_tipo_movimiento.Properties.ImmediatePopup = True
        Me.cbo_tipo_movimiento.Properties.Items.AddRange(New Object() {"ARTICULOS", "MATERIA PRIMA"})
        Me.cbo_tipo_movimiento.Size = New System.Drawing.Size(258, 22)
        Me.cbo_tipo_movimiento.TabIndex = 81
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(43, 71)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl5.TabIndex = 82
        Me.LabelControl5.Text = "Item:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(114, 243)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(303, 39)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(27, 22)
        Me.btn_buscar_sucursal.TabIndex = 52
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(72, 40)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_sucursal.TabIndex = 51
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(113, 40)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(188, 22)
        Me.txt_sucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(25, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Sucursal:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(185, 202)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(43, 202)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proveedor"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "proveedor"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 211
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(682, 476)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 91
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'FrmExistenciaStockItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 514)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.grid_stock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmExistenciaStockItems"
        Me.Text = "<<Stock de Items>>"
        CType(Me.grid_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_tipo_movimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_stock As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents familia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_existencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbo_tipo_movimiento As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_buscar_proveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_familia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
