<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_materiales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_materiales))
        Me.grid_materiales = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_pr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_material = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_costo_unitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_tipo_impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_familia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_control_stock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.fecha_cre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_familia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_stock_minimo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_nombre = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_costo_unitario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha_cre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_stock_min = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_buscar_proveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_controlar_stock = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_buscar_familia = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.btn_buscar_impuesto = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_impuesto = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_stock_min.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_controlar_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_impuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_materiales
        '
        Me.grid_materiales.Location = New System.Drawing.Point(21, 29)
        Me.grid_materiales.MainView = Me.GridView1
        Me.grid_materiales.Name = "grid_materiales"
        Me.grid_materiales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.grid_materiales.Size = New System.Drawing.Size(707, 449)
        Me.grid_materiales.TabIndex = 1
        Me.grid_materiales.TabStop = False
        Me.grid_materiales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_nombre, Me.col_pr, Me.col_id_material, Me.col_costo_unitario, Me.col_id_tipo_impuesto, Me.col_impuesto, Me.col_id_familia, Me.col_control_stock, Me.fecha_cre, Me.GridColumn1, Me.proveedor, Me.col_familia, Me.col_stock_minimo})
        Me.GridView1.GridControl = Me.grid_materiales
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
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
        Me.col_nombre.Caption = "Descripcion"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 189
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_pr
        '
        Me.col_pr.AppearanceCell.Options.UseTextOptions = True
        Me.col_pr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr.Caption = "Codigo"
        Me.col_pr.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_pr.DisplayFormat.FormatString = "#,#"
        Me.col_pr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_pr.FieldName = "codigo"
        Me.col_pr.Name = "col_pr"
        Me.col_pr.Width = 104
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_id_material
        '
        Me.col_id_material.Caption = "Id Material"
        Me.col_id_material.FieldName = "id_material"
        Me.col_id_material.Name = "col_id_material"
        Me.col_id_material.Width = 20
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
        Me.col_costo_unitario.VisibleIndex = 2
        Me.col_costo_unitario.Width = 97
        '
        'col_id_tipo_impuesto
        '
        Me.col_id_tipo_impuesto.Caption = "id_tipo_impuesto"
        Me.col_id_tipo_impuesto.FieldName = "id_tipo_impuesto"
        Me.col_id_tipo_impuesto.Name = "col_id_tipo_impuesto"
        '
        'col_impuesto
        '
        Me.col_impuesto.AppearanceCell.Options.UseTextOptions = True
        Me.col_impuesto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_impuesto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_impuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_impuesto.Caption = "Impuesto"
        Me.col_impuesto.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_impuesto.FieldName = "impuesto"
        Me.col_impuesto.Name = "col_impuesto"
        Me.col_impuesto.Visible = True
        Me.col_impuesto.VisibleIndex = 3
        Me.col_impuesto.Width = 120
        '
        'col_id_familia
        '
        Me.col_id_familia.Caption = "Familia"
        Me.col_id_familia.FieldName = "id_familia"
        Me.col_id_familia.Name = "col_id_familia"
        '
        'col_control_stock
        '
        Me.col_control_stock.AppearanceCell.Options.UseTextOptions = True
        Me.col_control_stock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_control_stock.AppearanceHeader.Options.UseTextOptions = True
        Me.col_control_stock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_control_stock.Caption = "Controlar Stock"
        Me.col_control_stock.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_control_stock.FieldName = "controlar_stock"
        Me.col_control_stock.Name = "col_control_stock"
        Me.col_control_stock.Visible = True
        Me.col_control_stock.VisibleIndex = 5
        Me.col_control_stock.Width = 96
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'fecha_cre
        '
        Me.fecha_cre.Caption = "fecha_cre"
        Me.fecha_cre.FieldName = "fecha_cre"
        Me.fecha_cre.Name = "fecha_cre"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "id_proveedor"
        Me.GridColumn1.FieldName = "id_proveedor"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'proveedor
        '
        Me.proveedor.Caption = "Proveedor"
        Me.proveedor.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.proveedor.FieldName = "proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Visible = True
        Me.proveedor.VisibleIndex = 1
        Me.proveedor.Width = 187
        '
        'col_familia
        '
        Me.col_familia.Caption = "Familia"
        Me.col_familia.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_familia.FieldName = "familia"
        Me.col_familia.Name = "col_familia"
        Me.col_familia.Visible = True
        Me.col_familia.VisibleIndex = 5
        '
        'col_stock_minimo
        '
        Me.col_stock_minimo.AppearanceCell.Options.UseTextOptions = True
        Me.col_stock_minimo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_stock_minimo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_stock_minimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_stock_minimo.Caption = "Stock Min."
        Me.col_stock_minimo.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_stock_minimo.FieldName = "stock_minimo"
        Me.col_stock_minimo.Name = "col_stock_minimo"
        Me.col_stock_minimo.Visible = True
        Me.col_stock_minimo.VisibleIndex = 4
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "0.##"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(104, 63)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Size = New System.Drawing.Size(229, 60)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_costo_unitario
        '
        Me.txt_costo_unitario.Location = New System.Drawing.Point(104, 155)
        Me.txt_costo_unitario.Name = "txt_costo_unitario"
        Me.txt_costo_unitario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_costo_unitario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_costo_unitario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_costo_unitario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_costo_unitario.Properties.Mask.EditMask = "n0"
        Me.txt_costo_unitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_costo_unitario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_costo_unitario.Size = New System.Drawing.Size(229, 22)
        Me.txt_costo_unitario.TabIndex = 3
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(104, 129)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo.Size = New System.Drawing.Size(229, 22)
        Me.txt_codigo.TabIndex = 2
        '
        'txt_fecha_cre
        '
        Me.txt_fecha_cre.Location = New System.Drawing.Point(104, 37)
        Me.txt_fecha_cre.Name = "txt_fecha_cre"
        Me.txt_fecha_cre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_cre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_cre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_cre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha_cre.Properties.ReadOnly = True
        Me.txt_fecha_cre.Size = New System.Drawing.Size(229, 22)
        Me.txt_fecha_cre.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 158)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Costo Unit.:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(61, 132)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Codigo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Descripcion:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(45, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Fecha Cre:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(178, 362)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 7
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(56, 362)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_stock_min)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.chk_controlar_stock)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_familia)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_impuesto)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txt_impuesto)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_cre)
        Me.GroupBox1.Controls.Add(Me.txt_costo_unitario)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(746, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 449)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Materia Prima"
        '
        'txt_stock_min
        '
        Me.txt_stock_min.Location = New System.Drawing.Point(104, 183)
        Me.txt_stock_min.Name = "txt_stock_min"
        Me.txt_stock_min.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_stock_min.Properties.Appearance.Options.UseBackColor = True
        Me.txt_stock_min.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_stock_min.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_stock_min.Properties.Mask.EditMask = "n0"
        Me.txt_stock_min.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_stock_min.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_stock_min.Size = New System.Drawing.Size(229, 22)
        Me.txt_stock_min.TabIndex = 33
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(45, 192)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Stock Min.:"
        '
        'btn_buscar_proveedor
        '
        Me.btn_buscar_proveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_proveedor.Location = New System.Drawing.Point(308, 266)
        Me.btn_buscar_proveedor.Name = "btn_buscar_proveedor"
        Me.btn_buscar_proveedor.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_proveedor.TabIndex = 31
        Me.btn_buscar_proveedor.TabStop = False
        Me.btn_buscar_proveedor.Text = "+"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(47, 269)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Proveedor:"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(104, 267)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(200, 22)
        Me.txt_proveedor.TabIndex = 30
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(117, 403)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        '
        'chk_controlar_stock
        '
        Me.chk_controlar_stock.Location = New System.Drawing.Point(16, 295)
        Me.chk_controlar_stock.Name = "chk_controlar_stock"
        Me.chk_controlar_stock.Properties.Caption = "Controlar Stock:"
        Me.chk_controlar_stock.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_controlar_stock.Size = New System.Drawing.Size(105, 19)
        Me.chk_controlar_stock.TabIndex = 6
        '
        'btn_buscar_familia
        '
        Me.btn_buscar_familia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_familia.Location = New System.Drawing.Point(308, 238)
        Me.btn_buscar_familia.Name = "btn_buscar_familia"
        Me.btn_buscar_familia.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_familia.TabIndex = 29
        Me.btn_buscar_familia.Text = "+"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(62, 242)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Familia:"
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(104, 239)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(200, 22)
        Me.txt_familia.TabIndex = 5
        '
        'btn_buscar_impuesto
        '
        Me.btn_buscar_impuesto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_impuesto.Location = New System.Drawing.Point(308, 210)
        Me.btn_buscar_impuesto.Name = "btn_buscar_impuesto"
        Me.btn_buscar_impuesto.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_impuesto.TabIndex = 26
        Me.btn_buscar_impuesto.Text = "+"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(49, 214)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 25
        Me.LabelControl6.Text = "Impuesto:"
        '
        'txt_impuesto
        '
        Me.txt_impuesto.Location = New System.Drawing.Point(104, 211)
        Me.txt_impuesto.Name = "txt_impuesto"
        Me.txt_impuesto.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_impuesto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_impuesto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_impuesto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_impuesto.Properties.ReadOnly = True
        Me.txt_impuesto.Size = New System.Drawing.Size(200, 22)
        Me.txt_impuesto.TabIndex = 4
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(362, 453)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 83
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(630, 41)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 25)
        Me.SimpleButton1.TabIndex = 33
        Me.SimpleButton1.Text = "Imprimir"
        '
        'frm_materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 507)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_materiales)
        Me.Name = "frm_materiales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   <<Registro de Materia Prima>>"
        CType(Me.grid_materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_costo_unitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_stock_min.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_controlar_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_impuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_materiales As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_material As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_costo_unitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_costo_unitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha_cre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_buscar_impuesto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_impuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_id_tipo_impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_buscar_familia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_id_familia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chk_controlar_stock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents col_control_stock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents fecha_cre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_buscar_proveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_familia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_stock_min As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_stock_minimo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
