<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_impresion_cod_barras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_impresion_cod_barras))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grid_articulos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_codigo_barras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_codigo_barras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_descripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_precio_venta = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rps_cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_precio_venta = New DevExpress.XtraEditors.TextEdit()
        Me.txt_descripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_codigo_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_precio_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_precio_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(685, 437)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.grid_articulos)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 162)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(654, 258)
        Me.PanelControl3.TabIndex = 1
        '
        'grid_articulos
        '
        Me.grid_articulos.Location = New System.Drawing.Point(14, 15)
        Me.grid_articulos.MainView = Me.GridView1
        Me.grid_articulos.Name = "grid_articulos"
        Me.grid_articulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rps_codigo_barras, Me.rps_descripcion, Me.rps_precio_venta, Me.rps_cantidad})
        Me.grid_articulos.Size = New System.Drawing.Size(627, 226)
        Me.grid_articulos.TabIndex = 0
        Me.grid_articulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_codigo_barras, Me.col_descripcion, Me.col_precio_venta, Me.col_cantidad})
        Me.GridView1.GridControl = Me.grid_articulos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_codigo_barras
        '
        Me.col_codigo_barras.Caption = "Codigo Barras"
        Me.col_codigo_barras.ColumnEdit = Me.rps_codigo_barras
        Me.col_codigo_barras.FieldName = "codigo_barras"
        Me.col_codigo_barras.Name = "col_codigo_barras"
        Me.col_codigo_barras.Visible = True
        Me.col_codigo_barras.VisibleIndex = 0
        Me.col_codigo_barras.Width = 109
        '
        'rps_codigo_barras
        '
        Me.rps_codigo_barras.AutoHeight = False
        Me.rps_codigo_barras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_codigo_barras.Name = "rps_codigo_barras"
        Me.rps_codigo_barras.ReadOnly = True
        '
        'col_descripcion
        '
        Me.col_descripcion.Caption = "Descripcion"
        Me.col_descripcion.ColumnEdit = Me.rps_descripcion
        Me.col_descripcion.FieldName = "descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 1
        Me.col_descripcion.Width = 281
        '
        'rps_descripcion
        '
        Me.rps_descripcion.AutoHeight = False
        Me.rps_descripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_descripcion.Name = "rps_descripcion"
        Me.rps_descripcion.ReadOnly = True
        '
        'col_precio_venta
        '
        Me.col_precio_venta.Caption = "Precio venta"
        Me.col_precio_venta.ColumnEdit = Me.rps_precio_venta
        Me.col_precio_venta.DisplayFormat.FormatString = "#,#"
        Me.col_precio_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_venta.FieldName = "precio_venta"
        Me.col_precio_venta.Name = "col_precio_venta"
        Me.col_precio_venta.Visible = True
        Me.col_precio_venta.VisibleIndex = 2
        Me.col_precio_venta.Width = 108
        '
        'rps_precio_venta
        '
        Me.rps_precio_venta.AutoHeight = False
        Me.rps_precio_venta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_precio_venta.Name = "rps_precio_venta"
        Me.rps_precio_venta.ReadOnly = True
        '
        'col_cantidad
        '
        Me.col_cantidad.Caption = "Cantidad"
        Me.col_cantidad.ColumnEdit = Me.rps_cantidad
        Me.col_cantidad.DisplayFormat.FormatString = "#,#"
        Me.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cantidad.FieldName = "cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 3
        Me.col_cantidad.Width = 111
        '
        'rps_cantidad
        '
        Me.rps_cantidad.AutoHeight = False
        Me.rps_cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rps_cantidad.Name = "rps_cantidad"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_cancelar)
        Me.PanelControl2.Controls.Add(Me.btn_agregar)
        Me.PanelControl2.Controls.Add(Me.btn_imprimir)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txt_precio_venta)
        Me.PanelControl2.Controls.Add(Me.txt_descripcion)
        Me.PanelControl2.Controls.Add(Me.txt_codigo)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txt_cantidad)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(654, 132)
        Me.PanelControl2.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(522, 88)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(110, 32)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(522, 12)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(110, 32)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.Location = New System.Drawing.Point(522, 50)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(110, 32)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(22, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Precio venta:"
        '
        'txt_precio_venta
        '
        Me.txt_precio_venta.EditValue = " "
        Me.txt_precio_venta.Location = New System.Drawing.Point(100, 53)
        Me.txt_precio_venta.Name = "txt_precio_venta"
        Me.txt_precio_venta.Properties.AllowMouseWheel = False
        Me.txt_precio_venta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_venta.Properties.Appearance.Options.UseFont = True
        Me.txt_precio_venta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_precio_venta.Properties.Mask.EditMask = "n0"
        Me.txt_precio_venta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_precio_venta.Size = New System.Drawing.Size(164, 24)
        Me.txt_precio_venta.TabIndex = 2
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(203, 28)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_descripcion.Size = New System.Drawing.Size(259, 22)
        Me.txt_descripcion.TabIndex = 1
        '
        'txt_codigo
        '
        Me.txt_codigo.EditValue = " "
        Me.txt_codigo.Location = New System.Drawing.Point(100, 28)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Properties.Appearance.Options.UseFont = True
        Me.txt_codigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo.Size = New System.Drawing.Size(101, 22)
        Me.txt_codigo.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(42, 84)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Cantidad:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.EditValue = " "
        Me.txt_cantidad.Location = New System.Drawing.Point(100, 81)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Properties.AllowMouseWheel = False
        Me.txt_cantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Properties.Appearance.Options.UseFont = True
        Me.txt_cantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cantidad.Properties.Mask.EditMask = "n0"
        Me.txt_cantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_cantidad.Size = New System.Drawing.Size(164, 24)
        Me.txt_cantidad.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(49, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Articulo:"
        '
        'frm_impresion_cod_barras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 464)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_impresion_cod_barras"
        Me.Text = "Impresion codigo barras"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_codigo_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_precio_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rps_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_precio_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_cantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_precio_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_descripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_articulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_codigo_barras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_codigo_barras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_descripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_precio_venta As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rps_cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
