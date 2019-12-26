<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cierre_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cierre_caja))
        Me.rps_txt_id_denominacion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_txt_nombre = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_txt_valor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_txt_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rps_txt_total = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_control = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha_apertura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_denominaciones = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_denominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_denominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rps_txt_id_denominacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_valor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_control.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_apertura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_denominaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rps_txt_id_denominacion
        '
        Me.rps_txt_id_denominacion.AutoHeight = False
        Me.rps_txt_id_denominacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_id_denominacion.DisplayFormat.FormatString = "#,#"
        Me.rps_txt_id_denominacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rps_txt_id_denominacion.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.rps_txt_id_denominacion.Name = "rps_txt_id_denominacion"
        Me.rps_txt_id_denominacion.ReadOnly = True
        '
        'rps_txt_nombre
        '
        Me.rps_txt_nombre.AutoHeight = False
        Me.rps_txt_nombre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_nombre.Name = "rps_txt_nombre"
        Me.rps_txt_nombre.ReadOnly = True
        '
        'rps_txt_valor
        '
        Me.rps_txt_valor.AutoHeight = False
        Me.rps_txt_valor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_valor.Mask.EditMask = "n0"
        Me.rps_txt_valor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_valor.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_valor.Name = "rps_txt_valor"
        Me.rps_txt_valor.ReadOnly = True
        '
        'rps_txt_cantidad
        '
        Me.rps_txt_cantidad.AutoHeight = False
        Me.rps_txt_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_cantidad.Name = "rps_txt_cantidad"
        '
        'rps_txt_total
        '
        Me.rps_txt_total.AutoHeight = False
        Me.rps_txt_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_txt_total.Mask.EditMask = "n0"
        Me.rps_txt_total.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rps_txt_total.Mask.UseMaskAsDisplayFormat = True
        Me.rps_txt_total.Name = "rps_txt_total"
        Me.rps_txt_total.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_id_control)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_apertura)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Control de Caja"
        '
        'txt_id_control
        '
        Me.txt_id_control.Location = New System.Drawing.Point(102, 61)
        Me.txt_id_control.Name = "txt_id_control"
        Me.txt_id_control.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_control.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_control.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_control.Size = New System.Drawing.Size(258, 22)
        Me.txt_id_control.TabIndex = 3
        '
        'txt_fecha_apertura
        '
        Me.txt_fecha_apertura.Location = New System.Drawing.Point(102, 33)
        Me.txt_fecha_apertura.Name = "txt_fecha_apertura"
        Me.txt_fecha_apertura.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_apertura.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_apertura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_apertura.Size = New System.Drawing.Size(258, 22)
        Me.txt_fecha_apertura.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Control Nro.:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Apertura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_confirmar)
        Me.GroupBox2.Controls.Add(Me.grid_denominaciones)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(723, 412)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Declaracion de Efectivo"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(589, 365)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(466, 365)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 1
        Me.btn_confirmar.Text = "Confirmar"
        '
        'grid_denominaciones
        '
        Me.grid_denominaciones.Location = New System.Drawing.Point(17, 35)
        Me.grid_denominaciones.MainView = Me.GridView1
        Me.grid_denominaciones.Name = "grid_denominaciones"
        Me.grid_denominaciones.Size = New System.Drawing.Size(689, 320)
        Me.grid_denominaciones.TabIndex = 0
        Me.grid_denominaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_denominacion, Me.col_nombre, Me.col_valor, Me.col_cantidad, Me.col_total})
        Me.GridView1.GridControl = Me.grid_denominaciones
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 27
        '
        'col_id_denominacion
        '
        Me.col_id_denominacion.Caption = "Id Denominacion"
        Me.col_id_denominacion.ColumnEdit = Me.rps_txt_id_denominacion
        Me.col_id_denominacion.FieldName = "id_denominacion"
        Me.col_id_denominacion.Name = "col_id_denominacion"
        Me.col_id_denominacion.OptionsColumn.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Denominacion"
        Me.col_nombre.ColumnEdit = Me.rps_txt_nombre
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.OptionsColumn.ReadOnly = True
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 294
        '
        'col_valor
        '
        Me.col_valor.Caption = "Valor"
        Me.col_valor.ColumnEdit = Me.rps_txt_valor
        Me.col_valor.DisplayFormat.FormatString = "#,#"
        Me.col_valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_valor.FieldName = "valor"
        Me.col_valor.Name = "col_valor"
        Me.col_valor.OptionsColumn.ReadOnly = True
        Me.col_valor.Visible = True
        Me.col_valor.VisibleIndex = 1
        Me.col_valor.Width = 122
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_cantidad.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.col_cantidad.AppearanceCell.Options.UseFont = True
        Me.col_cantidad.AppearanceCell.Options.UseForeColor = True
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rps_txt_cantidad
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 2
        Me.col_cantidad.Width = 122
        '
        'col_total
        '
        Me.col_total.Caption = "Total"
        Me.col_total.ColumnEdit = Me.rps_txt_total
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 3
        Me.col_total.Width = 130
        '
        'col_denominacion
        '
        Me.col_denominacion.Caption = "Denominacion"
        Me.col_denominacion.ColumnEdit = Me.rps_txt_id_denominacion
        Me.col_denominacion.DisplayFormat.FormatString = "#,#"
        Me.col_denominacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_denominacion.FieldName = "nombre"
        Me.col_denominacion.Name = "col_denominacion"
        Me.col_denominacion.Visible = True
        Me.col_denominacion.VisibleIndex = 0
        Me.col_denominacion.Width = 252
        '
        'frm_cierre_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 639)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_cierre_caja"
        Me.Text = "<<Cierre de Caja>>"
        CType(Me.rps_txt_id_denominacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_valor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_txt_total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_control.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_apertura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_denominaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fecha_apertura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grid_denominaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_denominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_denominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_id_control As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rps_txt_id_denominacion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_txt_nombre As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_txt_valor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_txt_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rps_txt_total As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
