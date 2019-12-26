<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_tipos_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tipos_compra))
        Me.txt_fecha_cre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_nombre = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_tipos_compra = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_tipo_compra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_fecha_cre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_relacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_requiere_item = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_relacion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_tipos_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chk_requiere_item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_relacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_fecha_cre
        '
        Me.txt_fecha_cre.Location = New System.Drawing.Point(25, 43)
        Me.txt_fecha_cre.Name = "txt_fecha_cre"
        Me.txt_fecha_cre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_cre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_cre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_cre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha_cre.Properties.Mask.EditMask = "G"
        Me.txt_fecha_cre.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txt_fecha_cre.Properties.ReadOnly = True
        Me.txt_fecha_cre.Size = New System.Drawing.Size(210, 22)
        Me.txt_fecha_cre.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(25, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Fecha Creacion:"
        '
        'chk_activo
        '
        Me.chk_activo.Location = New System.Drawing.Point(25, 210)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo"
        Me.chk_activo.Size = New System.Drawing.Size(75, 19)
        Me.chk_activo.TabIndex = 4
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(156, 320)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 6
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(29, 320)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(25, 87)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Size = New System.Drawing.Size(235, 73)
        Me.txt_nombre.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(26, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Nombre:"
        '
        'grid_tipos_compra
        '
        Me.grid_tipos_compra.Location = New System.Drawing.Point(27, 22)
        Me.grid_tipos_compra.MainView = Me.GridView1
        Me.grid_tipos_compra.Name = "grid_tipos_compra"
        Me.grid_tipos_compra.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.grid_tipos_compra.Size = New System.Drawing.Size(567, 411)
        Me.grid_tipos_compra.TabIndex = 6
        Me.grid_tipos_compra.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_tipo_compra, Me.col_nombre, Me.col_activo, Me.col_fecha_cre, Me.col_relacion, Me.col_item})
        Me.GridView1.GridControl = Me.grid_tipos_compra
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
        'col_id_tipo_compra
        '
        Me.col_id_tipo_compra.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_tipo_compra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_tipo_compra.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_tipo_compra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_tipo_compra.Caption = "Id Tipo Compra"
        Me.col_id_tipo_compra.FieldName = "id_tipo_compra"
        Me.col_id_tipo_compra.Name = "col_id_tipo_compra"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 257
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        Me.col_activo.VisibleIndex = 2
        Me.col_activo.Width = 83
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'col_fecha_cre
        '
        Me.col_fecha_cre.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha_cre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_cre.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha_cre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_fecha_cre.Caption = "Fecha Creacion"
        Me.col_fecha_cre.FieldName = "fecha_cre"
        Me.col_fecha_cre.Name = "col_fecha_cre"
        '
        'col_relacion
        '
        Me.col_relacion.AppearanceCell.Options.UseTextOptions = True
        Me.col_relacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_relacion.AppearanceHeader.Options.UseTextOptions = True
        Me.col_relacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_relacion.Caption = "Relacion"
        Me.col_relacion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_relacion.FieldName = "relacion"
        Me.col_relacion.Name = "col_relacion"
        Me.col_relacion.Visible = True
        Me.col_relacion.VisibleIndex = 1
        Me.col_relacion.Width = 114
        '
        'col_item
        '
        Me.col_item.Caption = "Requiere Item"
        Me.col_item.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.col_item.FieldName = "requiere_item"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.chk_requiere_item)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.cbo_relacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_cre)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.chk_activo)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Location = New System.Drawing.Point(600, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 411)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Tipo de Compra "
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Appearance.Options.UseForeColor = True
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(93, 361)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        '
        'chk_requiere_item
        '
        Me.chk_requiere_item.Location = New System.Drawing.Point(25, 235)
        Me.chk_requiere_item.Name = "chk_requiere_item"
        Me.chk_requiere_item.Properties.Caption = "Requiere Item"
        Me.chk_requiere_item.Size = New System.Drawing.Size(93, 19)
        Me.chk_requiere_item.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(26, 166)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Relacion:"
        '
        'cbo_relacion
        '
        Me.cbo_relacion.Location = New System.Drawing.Point(26, 182)
        Me.cbo_relacion.Name = "cbo_relacion"
        Me.cbo_relacion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_relacion.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_relacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_relacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_relacion.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_relacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_relacion.Properties.Items.AddRange(New Object() {"ARTICULOS", "MATERIA PRIMA", "GASTOS"})
        Me.cbo_relacion.Size = New System.Drawing.Size(234, 22)
        Me.cbo_relacion.TabIndex = 3
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(227, 409)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 85
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_tipos_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 459)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_tipos_compra)
        Me.Name = "frm_tipos_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Definicion de Tipos de Compras>>"
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_tipos_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chk_requiere_item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_relacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_fecha_cre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_tipos_compra As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_tipo_compra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_cre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents col_relacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_relacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chk_requiere_item As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
