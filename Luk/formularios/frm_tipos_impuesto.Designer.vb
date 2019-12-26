<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tipos_impuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tipos_impuesto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_valor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fecha_cre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nombre = New DevExpress.XtraEditors.MemoEdit()
        Me.chk_activo = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_tipos_comprobante = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_tipo_impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_fecha_cre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_valor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_tipos_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_cre)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.chk_activo)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Location = New System.Drawing.Point(509, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 411)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Tipo de Impuesto"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Appearance.Options.UseForeColor = True
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(95, 357)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(23, 196)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Valor:"
        '
        'txt_valor
        '
        Me.txt_valor.Location = New System.Drawing.Point(23, 212)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_valor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_valor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_valor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_valor.Size = New System.Drawing.Size(235, 22)
        Me.txt_valor.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(23, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Fecha Creacion:"
        '
        'txt_fecha_cre
        '
        Me.txt_fecha_cre.Location = New System.Drawing.Point(23, 49)
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
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(24, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(23, 103)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Size = New System.Drawing.Size(235, 73)
        Me.txt_nombre.TabIndex = 2
        '
        'chk_activo
        '
        Me.chk_activo.Location = New System.Drawing.Point(23, 248)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Properties.Caption = "Activo"
        Me.chk_activo.Size = New System.Drawing.Size(75, 19)
        Me.chk_activo.TabIndex = 4
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(33, 316)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = " Nuevo"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(157, 316)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "Confirmar"
        '
        'grid_tipos_comprobante
        '
        Me.grid_tipos_comprobante.Location = New System.Drawing.Point(36, 31)
        Me.grid_tipos_comprobante.MainView = Me.GridView1
        Me.grid_tipos_comprobante.Name = "grid_tipos_comprobante"
        Me.grid_tipos_comprobante.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1})
        Me.grid_tipos_comprobante.Size = New System.Drawing.Size(452, 411)
        Me.grid_tipos_comprobante.TabIndex = 1
        Me.grid_tipos_comprobante.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_tipo_impuesto, Me.col_nombre, Me.col_activo, Me.col_fecha_cre, Me.col_valor})
        Me.GridView1.GridControl = Me.grid_tipos_comprobante
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
        'col_id_tipo_impuesto
        '
        Me.col_id_tipo_impuesto.AppearanceCell.Options.UseTextOptions = True
        Me.col_id_tipo_impuesto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_tipo_impuesto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id_tipo_impuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id_tipo_impuesto.Caption = "Id Tipo Impuesto"
        Me.col_id_tipo_impuesto.FieldName = "id_tipo_impuesto"
        Me.col_id_tipo_impuesto.Name = "col_id_tipo_impuesto"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 245
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
        Me.col_activo.Width = 120
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
        'col_valor
        '
        Me.col_valor.AppearanceCell.Options.UseTextOptions = True
        Me.col_valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_valor.AppearanceHeader.Options.UseTextOptions = True
        Me.col_valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_valor.Caption = "Valor"
        Me.col_valor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_valor.FieldName = "valor"
        Me.col_valor.Name = "col_valor"
        Me.col_valor.Visible = True
        Me.col_valor.VisibleIndex = 1
        Me.col_valor.Width = 120
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(121, 418)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 86
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'frm_tipos_impuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 473)
        Me.Controls.Add(Me.lbl_total_registros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_tipos_comprobante)
        Me.Name = "frm_tipos_impuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Definicion de Tipos de Impuestos>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_valor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_cre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_activo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_tipos_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_valor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fecha_cre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chk_activo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_tipos_comprobante As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_tipo_impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha_cre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
