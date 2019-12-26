<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.grid_clientes = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_apellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nro_documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_ciudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ciudad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_documeto = New DevExpress.XtraEditors.TextEdit()
        Me.txt_apellidos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_documeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_total_registros)
        Me.GroupControl2.Controls.Add(Me.grid_clientes)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 174)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(823, 351)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Listado de Clientes"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(445, 307)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 79
        Me.lbl_total_registros.Text = "Registros recuperados: 0"
        '
        'grid_clientes
        '
        Me.grid_clientes.Location = New System.Drawing.Point(10, 28)
        Me.grid_clientes.MainView = Me.GridView1
        Me.grid_clientes.Name = "grid_clientes"
        Me.grid_clientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.grid_clientes.Size = New System.Drawing.Size(803, 304)
        Me.grid_clientes.TabIndex = 0
        Me.grid_clientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_cliente, Me.col_nombres, Me.col_apellidos, Me.col_nro_documento, Me.col_telefono, Me.col_ciudad, Me.col_direccion})
        Me.GridView1.GridControl = Me.grid_clientes
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
        'col_id_cliente
        '
        Me.col_id_cliente.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_cliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_cliente.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_cliente.Caption = "Id Cliente"
        Me.col_id_cliente.FieldName = "id_cliente"
        Me.col_id_cliente.Name = "col_id_cliente"
        Me.col_id_cliente.Width = 20
        '
        'col_nombres
        '
        Me.col_nombres.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_nombres.AppearanceCell.Options.UseBorderColor = True
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
        Me.col_nombres.Width = 185
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_apellidos
        '
        Me.col_apellidos.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_apellidos.AppearanceCell.Options.UseBorderColor = True
        Me.col_apellidos.AppearanceCell.Options.UseTextOptions = True
        Me.col_apellidos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_apellidos.AppearanceHeader.Options.UseTextOptions = True
        Me.col_apellidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_apellidos.Caption = "Apellido/s"
        Me.col_apellidos.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_apellidos.FieldName = "apellidos"
        Me.col_apellidos.Name = "col_apellidos"
        Me.col_apellidos.Visible = True
        Me.col_apellidos.VisibleIndex = 1
        Me.col_apellidos.Width = 177
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'col_nro_documento
        '
        Me.col_nro_documento.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_nro_documento.AppearanceCell.Options.UseBorderColor = True
        Me.col_nro_documento.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_documento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_documento.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_documento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nro_documento.Caption = "Nro. Documento"
        Me.col_nro_documento.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_nro_documento.FieldName = "numero_documento"
        Me.col_nro_documento.Name = "col_nro_documento"
        Me.col_nro_documento.Visible = True
        Me.col_nro_documento.VisibleIndex = 2
        Me.col_nro_documento.Width = 97
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_telefono
        '
        Me.col_telefono.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_telefono.AppearanceCell.Options.UseBorderColor = True
        Me.col_telefono.AppearanceCell.Options.UseTextOptions = True
        Me.col_telefono.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.AppearanceHeader.Options.UseTextOptions = True
        Me.col_telefono.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_telefono.Caption = "Telefono"
        Me.col_telefono.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.col_telefono.FieldName = "telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = True
        Me.col_telefono.VisibleIndex = 3
        Me.col_telefono.Width = 97
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'col_ciudad
        '
        Me.col_ciudad.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_ciudad.AppearanceCell.Options.UseBorderColor = True
        Me.col_ciudad.AppearanceCell.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_ciudad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_ciudad.Caption = "Ciudad"
        Me.col_ciudad.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.col_ciudad.FieldName = "ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.Visible = True
        Me.col_ciudad.VisibleIndex = 4
        Me.col_ciudad.Width = 97
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'col_direccion
        '
        Me.col_direccion.AppearanceCell.BorderColor = System.Drawing.Color.White
        Me.col_direccion.AppearanceCell.Options.UseBorderColor = True
        Me.col_direccion.AppearanceCell.Options.UseTextOptions = True
        Me.col_direccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_direccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_direccion.Caption = "Direccion"
        Me.col_direccion.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.col_direccion.FieldName = "direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.Visible = True
        Me.col_direccion.VisibleIndex = 5
        Me.col_direccion.Width = 97
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GroupControl1.Controls.Add(Me.btn_cancelar)
        Me.GroupControl1.Controls.Add(Me.btn_confirmar)
        Me.GroupControl1.Controls.Add(Me.btn_nuevo)
        Me.GroupControl1.Controls.Add(Me.txt_direccion)
        Me.GroupControl1.Controls.Add(Me.txt_ciudad)
        Me.GroupControl1.Controls.Add(Me.txt_telefono)
        Me.GroupControl1.Controls.Add(Me.txt_nro_documeto)
        Me.GroupControl1.Controls.Add(Me.txt_apellidos)
        Me.GroupControl1.Controls.Add(Me.txt_nombres)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(823, 156)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos del Cliente"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Appearance.Options.UseForeColor = True
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(685, 106)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmar.Appearance.Options.UseForeColor = True
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(685, 65)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 7
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(685, 21)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(422, 79)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_direccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Size = New System.Drawing.Size(230, 22)
        Me.txt_direccion.TabIndex = 5
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(422, 51)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ciudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ciudad.Size = New System.Drawing.Size(230, 22)
        Me.txt_ciudad.TabIndex = 4
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(422, 23)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_telefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Size = New System.Drawing.Size(230, 22)
        Me.txt_telefono.TabIndex = 3
        '
        'txt_nro_documeto
        '
        Me.txt_nro_documeto.Location = New System.Drawing.Point(112, 23)
        Me.txt_nro_documeto.Name = "txt_nro_documeto"
        Me.txt_nro_documeto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_documeto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_documeto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_documeto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nro_documeto.Properties.Mask.EditMask = "n0"
        Me.txt_nro_documeto.Size = New System.Drawing.Size(230, 22)
        Me.txt_nro_documeto.TabIndex = 0
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(112, 79)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_apellidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos.Size = New System.Drawing.Size(230, 22)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(112, 51)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombres.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombres.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombres.Size = New System.Drawing.Size(230, 22)
        Me.txt_nombres.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(379, 54)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Ciudad:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(366, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = " Direccion:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = " Nro. Documento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(370, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Telefono:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(53, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = " Apellido/s:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = " Nombre/s:"
        '
        'frm_clientes
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 555)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Clientes>>"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_documeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_clientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_apellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nro_documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ciudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ciudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_documeto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_apellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
