<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleados))
        Me.grid_empleados = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_apellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_telefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ciudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_direccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ciudad = New DevExpress.XtraEditors.TextEdit()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_apellidos = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_empleados
        '
        Me.grid_empleados.Location = New System.Drawing.Point(17, 23)
        Me.grid_empleados.MainView = Me.GridView1
        Me.grid_empleados.Name = "grid_empleados"
        Me.grid_empleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.grid_empleados.Size = New System.Drawing.Size(789, 253)
        Me.grid_empleados.TabIndex = 0
        Me.grid_empleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_empleado, Me.col_nombres, Me.col_apellidos, Me.col_telefono, Me.col_ciudad, Me.col_direccion, Me.col_activo})
        Me.GridView1.GridControl = Me.grid_empleados
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
        'col_id_empleado
        '
        Me.col_id_empleado.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_empleado.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_empleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_id_empleado.Caption = "Id Empleado"
        Me.col_id_empleado.FieldName = "id_empleado"
        Me.col_id_empleado.Name = "col_id_empleado"
        Me.col_id_empleado.Width = 20
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
        Me.col_apellidos.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_apellidos.FieldName = "apellidos"
        Me.col_apellidos.Name = "col_apellidos"
        Me.col_apellidos.Visible = True
        Me.col_apellidos.VisibleIndex = 1
        Me.col_apellidos.Width = 177
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
        Me.col_telefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_telefono.FieldName = "telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.Visible = True
        Me.col_telefono.VisibleIndex = 2
        Me.col_telefono.Width = 97
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
        Me.col_ciudad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_ciudad.FieldName = "ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.Visible = True
        Me.col_ciudad.VisibleIndex = 3
        Me.col_ciudad.Width = 97
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
        Me.col_direccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_direccion.FieldName = "direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.Visible = True
        Me.col_direccion.VisibleIndex = 4
        Me.col_direccion.Width = 97
        '
        'col_activo
        '
        Me.col_activo.Caption = "Activo"
        Me.col_activo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_activo.FieldName = "activo"
        Me.col_activo.Name = "col_activo"
        Me.col_activo.Visible = True
        Me.col_activo.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmar.Appearance.Options.UseForeColor = True
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(679, 66)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 7
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(679, 22)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(411, 57)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_direccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_direccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Size = New System.Drawing.Size(233, 22)
        Me.txt_direccion.TabIndex = 5
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(411, 29)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ciudad.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ciudad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ciudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ciudad.Size = New System.Drawing.Size(233, 22)
        Me.txt_ciudad.TabIndex = 4
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(115, 85)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_telefono.Properties.Appearance.Options.UseBackColor = True
        Me.txt_telefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_telefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Size = New System.Drawing.Size(233, 22)
        Me.txt_telefono.TabIndex = 3
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(115, 57)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_apellidos.Properties.Appearance.Options.UseBackColor = True
        Me.txt_apellidos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_apellidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos.Size = New System.Drawing.Size(233, 22)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(115, 29)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombres.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombres.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombres.Size = New System.Drawing.Size(233, 22)
        Me.txt_nombres.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(368, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Ciudad:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(355, 60)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = " Direccion:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(63, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Telefono:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(56, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = " Apellido/s:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(56, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = " Nombre/s:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckEdit1)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txt_ciudad)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Empleado"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(366, 86)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Activo"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Size = New System.Drawing.Size(63, 19)
        Me.CheckEdit1.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_total_registros)
        Me.GroupBox2.Controls.Add(Me.grid_empleados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(823, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Empleados"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(440, 251)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 80
        Me.lbl_total_registros.Text = "Registros recuperados: 0"
        '
        'frm_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 493)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Registro de Empleados>>"
        CType(Me.grid_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ciudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_apellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_empleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_apellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_telefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ciudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_direccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ciudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_apellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents col_activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
