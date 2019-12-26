<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vendedores))
        Me.grid_vendedores = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_usuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ciudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_correo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_clave = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_apellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_correo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ciudad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_apellidos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_comision = New DevExpress.XtraEditors.TextEdit()
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_vendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_correo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_comision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_vendedores
        '
        Me.grid_vendedores.Location = New System.Drawing.Point(24, 25)
        Me.grid_vendedores.MainView = Me.GridView1
        Me.grid_vendedores.Name = "grid_vendedores"
        Me.grid_vendedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_vendedores.Size = New System.Drawing.Size(791, 254)
        Me.grid_vendedores.TabIndex = 0
        Me.grid_vendedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_usuario, Me.col_nombres, Me.col_telefono, Me.col_ciudad, Me.col_direccion, Me.col_correo, Me.col_clave, Me.col_apellidos, Me.col_activo})
        Me.GridView1.GridControl = Me.grid_vendedores
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_usuario
        '
        Me.col_id_usuario.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_usuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_usuario.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_usuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_usuario.Caption = "Id Usuario"
        Me.col_id_usuario.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_usuario.FieldName = "id_usuario"
        Me.col_id_usuario.Name = "col_id_usuario"
        Me.col_id_usuario.Width = 20
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_nombres
        '
        Me.col_nombres.AppearanceCell.Options.UseTextOptions = True
        Me.col_nombres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombres.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nombres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_nombres.Caption = "Nombre/s"
        Me.col_nombres.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombres.FieldName = "nombres"
        Me.col_nombres.Name = "col_nombres"
        Me.col_nombres.Visible = True
        Me.col_nombres.VisibleIndex = 0
        Me.col_nombres.Width = 236
        '
        'col_telefono
        '
        Me.col_telefono.AppearanceCell.Options.UseTextOptions = True
        Me.col_telefono.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.AppearanceHeader.Options.UseTextOptions = True
        Me.col_telefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.Caption = "Telefono"
        Me.col_telefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_telefono.FieldName = "telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = True
        Me.col_telefono.VisibleIndex = 4
        Me.col_telefono.Width = 94
        '
        'col_ciudad
        '
        Me.col_ciudad.AppearanceCell.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.Caption = "Ciudad"
        Me.col_ciudad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_ciudad.FieldName = "ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.Visible = True
        Me.col_ciudad.VisibleIndex = 2
        Me.col_ciudad.Width = 113
        '
        'col_direccion
        '
        Me.col_direccion.AppearanceCell.Options.UseTextOptions = True
        Me.col_direccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_direccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.Caption = "Direccion"
        Me.col_direccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_direccion.FieldName = "direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.Visible = True
        Me.col_direccion.VisibleIndex = 3
        Me.col_direccion.Width = 113
        '
        'col_correo
        '
        Me.col_correo.AppearanceCell.Options.UseTextOptions = True
        Me.col_correo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_correo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_correo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_correo.Caption = "Correo"
        Me.col_correo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_correo.FieldName = "correo"
        Me.col_correo.Name = "col_correo"
        Me.col_correo.Visible = True
        Me.col_correo.VisibleIndex = 5
        Me.col_correo.Width = 113
        '
        'col_clave
        '
        Me.col_clave.AppearanceCell.Options.UseTextOptions = True
        Me.col_clave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_clave.AppearanceHeader.Options.UseTextOptions = True
        Me.col_clave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_clave.Caption = "Clave"
        Me.col_clave.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_clave.FieldName = "clave_acceso"
        Me.col_clave.Name = "col_clave"
        Me.col_clave.Width = 95
        '
        'col_apellidos
        '
        Me.col_apellidos.Caption = "Apellido/s"
        Me.col_apellidos.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_apellidos.FieldName = "apellidos"
        Me.col_apellidos.Name = "col_apellidos"
        Me.col_apellidos.Visible = True
        Me.col_apellidos.VisibleIndex = 1
        '
        'col_activo
        '
        Me.col_activo.Caption = "Activo"
        Me.col_activo.FieldName = "activo"
        Me.col_activo.Name = "col_activo"
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(428, 56)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_correo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_correo.Size = New System.Drawing.Size(234, 22)
        Me.txt_correo.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(389, 59)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 37
        Me.LabelControl7.Text = "Correo:"
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(114, 82)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ciudad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ciudad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ciudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ciudad.Properties.Mask.EditMask = "n0"
        Me.txt_ciudad.Size = New System.Drawing.Size(234, 22)
        Me.txt_ciudad.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(71, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Ciudad:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmar.Appearance.Options.UseForeColor = True
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(691, 75)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 9
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(691, 31)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(428, 30)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_telefono.Properties.Appearance.Options.UseBackColor = True
        Me.txt_telefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_telefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Size = New System.Drawing.Size(234, 22)
        Me.txt_telefono.TabIndex = 5
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(114, 56)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_apellidos.Properties.Appearance.Options.UseBackColor = True
        Me.txt_apellidos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_apellidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos.Size = New System.Drawing.Size(234, 22)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(114, 108)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_direccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_direccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Properties.Mask.EditMask = "n0"
        Me.txt_direccion.Size = New System.Drawing.Size(234, 22)
        Me.txt_direccion.TabIndex = 4
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(114, 30)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombres.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombres.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombres.Size = New System.Drawing.Size(234, 22)
        Me.txt_nombres.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(380, 33)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Telefono:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(62, 111)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Direccion:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(58, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Apellido/s:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(58, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre/s:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_total_registros)
        Me.GroupBox1.Controls.Add(Me.grid_vendedores)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 296)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vendedores"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(449, 254)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 86
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_comision)
        Me.GroupBox2.Controls.Add(Me.chk_activo)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.txt_ciudad)
        Me.GroupBox2.Controls.Add(Me.txt_correo)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.txt_apellidos)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Controls.Add(Me.txt_direccion)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.txt_nombres)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.btn_confirmar)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(843, 170)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Vendedor"
        '
        'txt_comision
        '
        Me.txt_comision.Location = New System.Drawing.Point(428, 84)
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Properties.AllowMouseWheel = False
        Me.txt_comision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_comision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_comision.Properties.DisplayFormat.FormatString = "#,#"
        Me.txt_comision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_comision.Properties.Mask.EditMask = "n0"
        Me.txt_comision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_comision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_comision.Size = New System.Drawing.Size(123, 22)
        Me.txt_comision.TabIndex = 7
        '
        'chk_activo
        '
        Me.chk_activo.Location = New System.Drawing.Point(389, 111)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo:"
        Me.chk_activo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_activo.Size = New System.Drawing.Size(54, 19)
        Me.chk_activo.TabIndex = 8
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Appearance.Options.UseForeColor = True
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(691, 116)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(361, 85)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Comision(%):"
        '
        'frm_vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 527)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Vendedores>>"
        CType(Me.grid_vendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_correo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_comision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_vendedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_usuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ciudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_correo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_clave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_ciudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_apellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_correo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_apellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_comision As DevExpress.XtraEditors.TextEdit
End Class
