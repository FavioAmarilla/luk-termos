<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_controles_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_controles_caja))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_denominaciones = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_denominacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_controles_caja = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_control = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha_apertura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_denominaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_control.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_apertura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_denominaciones)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 412)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Declaracion de Efectivo"
        '
        'grid_denominaciones
        '
        Me.grid_denominaciones.Location = New System.Drawing.Point(17, 35)
        Me.grid_denominaciones.MainView = Me.GridView1
        Me.grid_denominaciones.Name = "grid_denominaciones"
        Me.grid_denominaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_denominaciones.Size = New System.Drawing.Size(737, 320)
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
        Me.col_id_denominacion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_id_denominacion.FieldName = "id_denominacion"
        Me.col_id_denominacion.Name = "col_id_denominacion"
        Me.col_id_denominacion.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_nombre
        '
        Me.col_nombre.Caption = "Denominacion"
        Me.col_nombre.ColumnEdit = Me.RepositoryItemTextEdit1
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
        Me.col_valor.ColumnEdit = Me.RepositoryItemTextEdit1
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
        Me.col_cantidad.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.col_cantidad.AppearanceCell.Options.UseFont = True
        Me.col_cantidad.AppearanceCell.Options.UseForeColor = True
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.RepositoryItemTextEdit1
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
        Me.col_total.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_total.DisplayFormat.FormatString = "#,#"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.Name = "col_total"
        Me.col_total.OptionsColumn.ReadOnly = True
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 3
        Me.col_total.Width = 130
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(620, 61)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(117, 35)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(620, 20)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 2
        Me.btn_consultar.Text = "Consultar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.btn_controles_caja)
        Me.GroupBox1.Controls.Add(Me.txt_id_control)
        Me.GroupBox1.Controls.Add(Me.txt_fecha_apertura)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Control de Caja"
        '
        'btn_controles_caja
        '
        Me.btn_controles_caja.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_controles_caja.Location = New System.Drawing.Point(322, 32)
        Me.btn_controles_caja.Name = "btn_controles_caja"
        Me.btn_controles_caja.Size = New System.Drawing.Size(27, 21)
        Me.btn_controles_caja.TabIndex = 15
        Me.btn_controles_caja.Text = "+"
        '
        'txt_id_control
        '
        Me.txt_id_control.Location = New System.Drawing.Point(103, 32)
        Me.txt_id_control.Name = "txt_id_control"
        Me.txt_id_control.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_control.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_control.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_control.Size = New System.Drawing.Size(217, 22)
        Me.txt_id_control.TabIndex = 0
        '
        'txt_fecha_apertura
        '
        Me.txt_fecha_apertura.Location = New System.Drawing.Point(103, 60)
        Me.txt_fecha_apertura.Name = "txt_fecha_apertura"
        Me.txt_fecha_apertura.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha_apertura.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha_apertura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha_apertura.Size = New System.Drawing.Size(246, 22)
        Me.txt_fecha_apertura.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(38, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Control Nro.:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Apertura:"
        '
        'frm_controles_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 567)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_controles_caja"
        Me.Text = "<<Controles de Cajas>>"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_denominaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_control.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_apertura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_denominaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_denominacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_control As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha_apertura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_controles_caja As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
