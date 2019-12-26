<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_timbrados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_timbrados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_empresas = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_registrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cld_hasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cld_desde = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nro_inicial = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_fina = New DevExpress.XtraEditors.TextEdit()
        Me.txt_longitud = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_numero = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_timbrados = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_timbrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha_desde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_fecha_hasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_empresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_empresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_sucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_longitud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nro_inicial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nro_final = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cld_fecha_hasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cld_fecha_desde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbo_empresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_inicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_fina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_longitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_timbrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cld_fecha_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_empresas)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_registrar)
        Me.GroupBox1.Controls.Add(Me.btn_sucursal)
        Me.GroupBox1.Controls.Add(Me.btn_cld_hasta)
        Me.GroupBox1.Controls.Add(Me.btn_cld_desde)
        Me.GroupBox1.Controls.Add(Me.chk_activo)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.txt_nro_inicial)
        Me.GroupBox1.Controls.Add(Me.txt_nro_fina)
        Me.GroupBox1.Controls.Add(Me.txt_longitud)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Timbrado"
        '
        'cbo_empresas
        '
        Me.cbo_empresas.Location = New System.Drawing.Point(79, 109)
        Me.cbo_empresas.Name = "cbo_empresas"
        Me.cbo_empresas.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbo_empresas.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_empresas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_empresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_empresas.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_empresas.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_empresas.Size = New System.Drawing.Size(250, 22)
        Me.cbo_empresas.TabIndex = 4
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(765, 30)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(764, 112)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_registrar
        '
        Me.btn_registrar.Image = CType(resources.GetObject("btn_registrar.Image"), System.Drawing.Image)
        Me.btn_registrar.Location = New System.Drawing.Point(764, 71)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_registrar.TabIndex = 10
        Me.btn_registrar.Text = "Registrar"
        '
        'btn_sucursal
        '
        Me.btn_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_sucursal.Location = New System.Drawing.Point(302, 135)
        Me.btn_sucursal.Name = "btn_sucursal"
        Me.btn_sucursal.Size = New System.Drawing.Size(27, 21)
        Me.btn_sucursal.TabIndex = 21
        Me.btn_sucursal.Text = "..."
        '
        'btn_cld_hasta
        '
        Me.btn_cld_hasta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_hasta.Location = New System.Drawing.Point(302, 80)
        Me.btn_cld_hasta.Name = "btn_cld_hasta"
        Me.btn_cld_hasta.Size = New System.Drawing.Size(27, 21)
        Me.btn_cld_hasta.TabIndex = 19
        Me.btn_cld_hasta.Text = "+"
        '
        'btn_cld_desde
        '
        Me.btn_cld_desde.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_cld_desde.Location = New System.Drawing.Point(302, 53)
        Me.btn_cld_desde.Name = "btn_cld_desde"
        Me.btn_cld_desde.Size = New System.Drawing.Size(27, 21)
        Me.btn_cld_desde.TabIndex = 18
        Me.btn_cld_desde.Text = "+"
        '
        'chk_activo
        '
        Me.chk_activo.Location = New System.Drawing.Point(396, 106)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo:"
        Me.chk_activo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_activo.Size = New System.Drawing.Size(58, 19)
        Me.chk_activo.TabIndex = 9
        '
        'txt_fecha_hasta
        '
        Me.txt_fecha_hasta.BackColor = System.Drawing.Color.White
        Me.txt_fecha_hasta.Location = New System.Drawing.Point(79, 81)
        Me.txt_fecha_hasta.Mask = "00/00/0000"
        Me.txt_fecha_hasta.Name = "txt_fecha_hasta"
        Me.txt_fecha_hasta.Size = New System.Drawing.Size(220, 21)
        Me.txt_fecha_hasta.TabIndex = 3
        Me.txt_fecha_hasta.ValidatingType = GetType(Date)
        '
        'txt_fecha_desde
        '
        Me.txt_fecha_desde.BackColor = System.Drawing.Color.White
        Me.txt_fecha_desde.Location = New System.Drawing.Point(79, 53)
        Me.txt_fecha_desde.Mask = "00/00/0000"
        Me.txt_fecha_desde.Name = "txt_fecha_desde"
        Me.txt_fecha_desde.Size = New System.Drawing.Size(220, 21)
        Me.txt_fecha_desde.TabIndex = 2
        Me.txt_fecha_desde.ValidatingType = GetType(Date)
        '
        'txt_nro_inicial
        '
        Me.txt_nro_inicial.Location = New System.Drawing.Point(437, 52)
        Me.txt_nro_inicial.Name = "txt_nro_inicial"
        Me.txt_nro_inicial.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_inicial.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_inicial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_inicial.Size = New System.Drawing.Size(250, 22)
        Me.txt_nro_inicial.TabIndex = 7
        '
        'txt_nro_fina
        '
        Me.txt_nro_fina.Location = New System.Drawing.Point(437, 80)
        Me.txt_nro_fina.Name = "txt_nro_fina"
        Me.txt_nro_fina.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_fina.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_fina.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_fina.Size = New System.Drawing.Size(250, 22)
        Me.txt_nro_fina.TabIndex = 8
        '
        'txt_longitud
        '
        Me.txt_longitud.Location = New System.Drawing.Point(437, 26)
        Me.txt_longitud.Name = "txt_longitud"
        Me.txt_longitud.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_longitud.Properties.Appearance.Options.UseBackColor = True
        Me.txt_longitud.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_longitud.Size = New System.Drawing.Size(250, 22)
        Me.txt_longitud.TabIndex = 6
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(79, 136)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Size = New System.Drawing.Size(220, 22)
        Me.txt_sucursal.TabIndex = 5
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(79, 27)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_numero.Properties.Appearance.Options.UseBackColor = True
        Me.txt_numero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_numero.Size = New System.Drawing.Size(250, 22)
        Me.txt_numero.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(381, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Nro. Inicial:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(386, 84)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Nro. Final:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(349, 30)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "Longitud de Nro.: "
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(32, 112)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Empresa:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(33, 140)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Sucursal:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(43, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Numero:"
        '
        'grid_timbrados
        '
        Me.grid_timbrados.Location = New System.Drawing.Point(12, 203)
        Me.grid_timbrados.MainView = Me.GridView1
        Me.grid_timbrados.Name = "grid_timbrados"
        Me.grid_timbrados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemCheckEdit1})
        Me.grid_timbrados.Size = New System.Drawing.Size(920, 284)
        Me.grid_timbrados.TabIndex = 1
        Me.grid_timbrados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_timbrado, Me.col_numero, Me.col_fecha_desde, Me.col_fecha_hasta, Me.col_id_empresa, Me.col_empresa, Me.col_id_sucursal, Me.col_sucursal, Me.col_longitud, Me.col_nro_inicial, Me.col_nro_final, Me.col_activo})
        Me.GridView1.GridControl = Me.grid_timbrados
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_timbrado
        '
        Me.col_id_timbrado.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_timbrado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_timbrado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_timbrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_timbrado.Caption = "Id Timbrado"
        Me.col_id_timbrado.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_timbrado.FieldName = "id_timbrado"
        Me.col_id_timbrado.Name = "col_id_timbrado"
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
        Me.col_numero.Width = 98
        '
        'col_fecha_desde
        '
        Me.col_fecha_desde.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha_desde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_desde.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha_desde.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_desde.Caption = "Fecha Desde"
        Me.col_fecha_desde.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_fecha_desde.FieldName = "fecha_desde"
        Me.col_fecha_desde.Name = "col_fecha_desde"
        Me.col_fecha_desde.Visible = True
        Me.col_fecha_desde.VisibleIndex = 1
        Me.col_fecha_desde.Width = 98
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_fecha_hasta
        '
        Me.col_fecha_hasta.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha_hasta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_hasta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha_hasta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_hasta.Caption = "Fecha Hasta"
        Me.col_fecha_hasta.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_fecha_hasta.FieldName = "fecha_hasta"
        Me.col_fecha_hasta.Name = "col_fecha_hasta"
        Me.col_fecha_hasta.Visible = True
        Me.col_fecha_hasta.VisibleIndex = 2
        Me.col_fecha_hasta.Width = 98
        '
        'col_id_empresa
        '
        Me.col_id_empresa.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_empresa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empresa.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_empresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_empresa.Caption = "Id Empresa"
        Me.col_id_empresa.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_empresa.FieldName = "id_empresa"
        Me.col_id_empresa.Name = "col_id_empresa"
        '
        'col_empresa
        '
        Me.col_empresa.Caption = "Empresa"
        Me.col_empresa.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_empresa.FieldName = "empresa"
        Me.col_empresa.Name = "col_empresa"
        Me.col_empresa.Visible = True
        Me.col_empresa.VisibleIndex = 3
        Me.col_empresa.Width = 193
        '
        'col_id_sucursal
        '
        Me.col_id_sucursal.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_sucursal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_sucursal.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_sucursal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_sucursal.Caption = "Id Sucursal"
        Me.col_id_sucursal.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_sucursal.FieldName = "id_sucursal"
        Me.col_id_sucursal.Name = "col_id_sucursal"
        '
        'col_sucursal
        '
        Me.col_sucursal.Caption = "Sucursal"
        Me.col_sucursal.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_sucursal.FieldName = "sucursal"
        Me.col_sucursal.Name = "col_sucursal"
        Me.col_sucursal.Visible = True
        Me.col_sucursal.VisibleIndex = 4
        Me.col_sucursal.Width = 193
        '
        'col_longitud
        '
        Me.col_longitud.AppearanceCell.Options.UseTextOptions = True
        Me.col_longitud.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_longitud.AppearanceHeader.Options.UseTextOptions = True
        Me.col_longitud.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_longitud.Caption = "Longitud de Nro."
        Me.col_longitud.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_longitud.FieldName = "longitud_nro_comprob"
        Me.col_longitud.Name = "col_longitud"
        '
        'col_nro_inicial
        '
        Me.col_nro_inicial.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_inicial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_inicial.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_inicial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_inicial.Caption = "Nro. Inicial"
        Me.col_nro_inicial.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_inicial.FieldName = "nro_inicial"
        Me.col_nro_inicial.Name = "col_nro_inicial"
        Me.col_nro_inicial.Visible = True
        Me.col_nro_inicial.VisibleIndex = 5
        Me.col_nro_inicial.Width = 98
        '
        'col_nro_final
        '
        Me.col_nro_final.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_final.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_final.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_final.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_final.Caption = "Nro. Final"
        Me.col_nro_final.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_final.FieldName = "nro_final"
        Me.col_nro_final.Name = "col_nro_final"
        Me.col_nro_final.Visible = True
        Me.col_nro_final.VisibleIndex = 6
        Me.col_nro_final.Width = 98
        '
        'col_activo
        '
        Me.col_activo.AppearanceCell.Options.UseTextOptions = True
        Me.col_activo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_activo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_activo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_activo.Caption = "Activo"
        Me.col_activo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_activo.FieldName = "activo"
        Me.col_activo.Name = "col_activo"
        Me.col_activo.Visible = True
        Me.col_activo.VisibleIndex = 7
        Me.col_activo.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'cld_fecha_hasta
        '
        Me.cld_fecha_hasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha_hasta.Location = New System.Drawing.Point(314, 92)
        Me.cld_fecha_hasta.Name = "cld_fecha_hasta"
        Me.cld_fecha_hasta.Size = New System.Drawing.Size(250, 227)
        Me.cld_fecha_hasta.TabIndex = 2
        '
        'cld_fecha_desde
        '
        Me.cld_fecha_desde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cld_fecha_desde.Location = New System.Drawing.Point(314, 65)
        Me.cld_fecha_desde.Name = "cld_fecha_desde"
        Me.cld_fecha_desde.Size = New System.Drawing.Size(250, 227)
        Me.cld_fecha_desde.TabIndex = 3
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(566, 462)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_timbrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 506)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.cld_fecha_desde)
        Me.Controls.Add(Me.cld_fecha_hasta)
        Me.Controls.Add(Me.grid_timbrados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_timbrados"
        Me.Text = "<<Definicion de Timbrados>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbo_empresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_inicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_fina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_longitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_timbrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha_hasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cld_fecha_desde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grid_timbrados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_fecha_hasta As MaskedTextBox
    Friend WithEvents txt_fecha_desde As MaskedTextBox
    Friend WithEvents txt_nro_inicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_fina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_longitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cld_hasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cld_desde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_registrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_timbrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_desde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_hasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_empresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_empresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_sucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_longitud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_inicial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_final As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_sucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cld_fecha_hasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cld_fecha_desde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cbo_empresas As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
