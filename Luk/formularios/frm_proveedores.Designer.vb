<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_proveedores))
        Me.grid_proveedores = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_proveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ruc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_correo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ciudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pagina_web = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_actico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_pagina_web = New DevExpress.XtraEditors.TextEdit()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ciudad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_pais = New DevExpress.XtraEditors.TextEdit()
        Me.txt_correo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ruc = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pagina_web.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_correo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_proveedores
        '
        Me.grid_proveedores.Location = New System.Drawing.Point(24, 195)
        Me.grid_proveedores.MainView = Me.GridView1
        Me.grid_proveedores.Name = "grid_proveedores"
        Me.grid_proveedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.grid_proveedores.Size = New System.Drawing.Size(901, 283)
        Me.grid_proveedores.TabIndex = 0
        Me.grid_proveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_proveedor, Me.col_ruc, Me.col_telefono, Me.col_correo, Me.col_pais, Me.col_ciudad, Me.col_direccion, Me.col_pagina_web, Me.col_actico, Me.col_nombre})
        Me.GridView1.GridControl = Me.grid_proveedores
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsPrint.RtfReportHeader = resources.GetString("GridView1.OptionsPrint.RtfReportHeader")
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_proveedor
        '
        Me.col_id_proveedor.Caption = "Id Proveedor"
        Me.col_id_proveedor.FieldName = "id_proveedor"
        Me.col_id_proveedor.Name = "col_id_proveedor"
        '
        'col_ruc
        '
        Me.col_ruc.Caption = "R.U.C."
        Me.col_ruc.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_ruc.FieldName = "ruc"
        Me.col_ruc.Name = "col_ruc"
        Me.col_ruc.Visible = True
        Me.col_ruc.VisibleIndex = 1
        Me.col_ruc.Width = 106
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_telefono
        '
        Me.col_telefono.Caption = "Telefono"
        Me.col_telefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_telefono.FieldName = "telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = True
        Me.col_telefono.VisibleIndex = 2
        Me.col_telefono.Width = 106
        '
        'col_correo
        '
        Me.col_correo.Caption = "Correo"
        Me.col_correo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_correo.FieldName = "correo"
        Me.col_correo.Name = "col_correo"
        Me.col_correo.Visible = True
        Me.col_correo.VisibleIndex = 3
        Me.col_correo.Width = 106
        '
        'col_pais
        '
        Me.col_pais.Caption = "Pais"
        Me.col_pais.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_pais.FieldName = "pais"
        Me.col_pais.Name = "col_pais"
        '
        'col_ciudad
        '
        Me.col_ciudad.Caption = "Ciudad"
        Me.col_ciudad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_ciudad.FieldName = "ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.Visible = True
        Me.col_ciudad.VisibleIndex = 4
        Me.col_ciudad.Width = 106
        '
        'col_direccion
        '
        Me.col_direccion.Caption = "Direccion"
        Me.col_direccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_direccion.FieldName = "direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.Visible = True
        Me.col_direccion.VisibleIndex = 5
        Me.col_direccion.Width = 106
        '
        'col_pagina_web
        '
        Me.col_pagina_web.Caption = "Pagina Web"
        Me.col_pagina_web.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_pagina_web.FieldName = "pagina_web"
        Me.col_pagina_web.Name = "col_pagina_web"
        '
        'col_actico
        '
        Me.col_actico.Caption = "Activo"
        Me.col_actico.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_actico.FieldName = "activo"
        Me.col_actico.Name = "col_actico"
        Me.col_actico.Visible = True
        Me.col_actico.VisibleIndex = 6
        Me.col_actico.Width = 115
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 235
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.chk_activo)
        Me.GroupBox1.Controls.Add(Me.txt_pagina_web)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_ciudad)
        Me.GroupBox1.Controls.Add(Me.txt_pais)
        Me.GroupBox1.Controls.Add(Me.txt_correo)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_ruc)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Proveedor"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(760, 114)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(760, 71)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 10
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(760, 28)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'chk_activo
        '
        Me.chk_activo.Location = New System.Drawing.Point(392, 112)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo:"
        Me.chk_activo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_activo.Size = New System.Drawing.Size(57, 19)
        Me.chk_activo.TabIndex = 9
        '
        'txt_pagina_web
        '
        Me.txt_pagina_web.Location = New System.Drawing.Point(432, 84)
        Me.txt_pagina_web.Name = "txt_pagina_web"
        Me.txt_pagina_web.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_pagina_web.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pagina_web.Size = New System.Drawing.Size(259, 22)
        Me.txt_pagina_web.TabIndex = 8
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(432, 58)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_direccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_direccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Size = New System.Drawing.Size(259, 22)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(432, 32)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ciudad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ciudad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ciudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ciudad.Size = New System.Drawing.Size(259, 22)
        Me.txt_ciudad.TabIndex = 6
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(91, 135)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_pais.Properties.Appearance.Options.UseBackColor = True
        Me.txt_pais.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_pais.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pais.Size = New System.Drawing.Size(259, 22)
        Me.txt_pais.TabIndex = 5
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(91, 109)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_correo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_correo.Size = New System.Drawing.Size(259, 22)
        Me.txt_correo.TabIndex = 4
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(91, 83)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_telefono.Properties.Appearance.Options.UseBackColor = True
        Me.txt_telefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_telefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Size = New System.Drawing.Size(259, 22)
        Me.txt_telefono.TabIndex = 3
        '
        'txt_ruc
        '
        Me.txt_ruc.Location = New System.Drawing.Point(91, 57)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ruc.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ruc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ruc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ruc.Size = New System.Drawing.Size(259, 22)
        Me.txt_ruc.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(91, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Size = New System.Drawing.Size(259, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(368, 88)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Pagina Web:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(51, 61)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "R.U.C.:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(392, 36)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Ciudad:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(382, 62)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Direccion:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(62, 139)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Pais:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(51, 113)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Correo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Telefono:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(47, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre:"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(826, 211)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.btn_imprimir.TabIndex = 1
        Me.btn_imprimir.Text = "Imprimir"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(557, 453)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 84
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 504)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_proveedores)
        Me.Name = "frm_proveedores"
        Me.Text = "<<Registro de Proveedores>>"
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pagina_web.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_correo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_proveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents col_id_proveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ruc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pagina_web As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ciudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_correo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ruc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_correo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ciudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pagina_web As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_actico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
