<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cobros_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cobros_caja))
        Me.grid_cobros = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id_forma_pago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_forma_pago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_importe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nro_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tipo_pago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id_recibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_total_venta = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_total_vuelto = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_recibido = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_saldo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total_pagar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRecibos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_forma_pago = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_importe = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_forma_pago = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_eliminar_cobro = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_tarjetas = New System.Windows.Forms.GroupBox()
        Me.cbo_tipo_tarjeta = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbo_procesadora = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nro_boleta = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_porc_descuento = New DevExpress.XtraEditors.TextEdit()
        Me.txt_descuento = New DevExpress.XtraEditors.TextEdit()
        Me.btn_comision_vendedor = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_recibos = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_recibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_numero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_monto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnEliminarRecibo = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_cobros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_total_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_vuelto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_recibido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_pagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_importe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_tarjetas.SuspendLayout()
        CType(Me.cbo_tipo_tarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_procesadora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_boleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_porc_descuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_cobros
        '
        Me.grid_cobros.Location = New System.Drawing.Point(12, 203)
        Me.grid_cobros.MainView = Me.GridView1
        Me.grid_cobros.Name = "grid_cobros"
        Me.grid_cobros.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit3})
        Me.grid_cobros.Size = New System.Drawing.Size(373, 136)
        Me.grid_cobros.TabIndex = 4
        Me.grid_cobros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id_forma_pago, Me.col_forma_pago, Me.col_importe, Me.col_nro_item, Me.col_tipo_pago, Me.col_id_recibo})
        Me.GridView1.GridControl = Me.grid_cobros
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_id_forma_pago
        '
        Me.col_id_forma_pago.Caption = "Id Forma Pago"
        Me.col_id_forma_pago.FieldName = "id_forma_pago"
        Me.col_id_forma_pago.Name = "col_id_forma_pago"
        '
        'col_forma_pago
        '
        Me.col_forma_pago.Caption = "Forma de Pago"
        Me.col_forma_pago.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.col_forma_pago.FieldName = "forma_pago"
        Me.col_forma_pago.Name = "col_forma_pago"
        Me.col_forma_pago.Visible = True
        Me.col_forma_pago.VisibleIndex = 0
        Me.col_forma_pago.Width = 188
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'col_importe
        '
        Me.col_importe.AppearanceCell.Options.UseTextOptions = True
        Me.col_importe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_importe.AppearanceHeader.Options.UseTextOptions = True
        Me.col_importe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_importe.Caption = "Importe"
        Me.col_importe.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_importe.DisplayFormat.FormatString = "#,#"
        Me.col_importe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_importe.FieldName = "importe"
        Me.col_importe.Name = "col_importe"
        Me.col_importe.Visible = True
        Me.col_importe.VisibleIndex = 1
        Me.col_importe.Width = 164
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_nro_item
        '
        Me.col_nro_item.AppearanceCell.Options.UseTextOptions = True
        Me.col_nro_item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_nro_item.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nro_item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_nro_item.Caption = "Nro Item"
        Me.col_nro_item.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_nro_item.FieldName = "nro_item"
        Me.col_nro_item.Name = "col_nro_item"
        Me.col_nro_item.Visible = True
        Me.col_nro_item.VisibleIndex = 2
        '
        'col_tipo_pago
        '
        Me.col_tipo_pago.Caption = "Tipo Pago"
        Me.col_tipo_pago.FieldName = "tipo_pago"
        Me.col_tipo_pago.Name = "col_tipo_pago"
        '
        'col_id_recibo
        '
        Me.col_id_recibo.Caption = "ID Recibo"
        Me.col_id_recibo.FieldName = "id_recibo"
        Me.col_id_recibo.Name = "col_id_recibo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_total_venta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_total_vuelto)
        Me.GroupBox1.Controls.Add(Me.txt_total_recibido)
        Me.GroupBox1.Controls.Add(Me.txt_total_saldo)
        Me.GroupBox1.Controls.Add(Me.txt_total_pagar)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 177)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'txt_total_venta
        '
        Me.txt_total_venta.Location = New System.Drawing.Point(116, 18)
        Me.txt_total_venta.Name = "txt_total_venta"
        Me.txt_total_venta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_venta.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_venta.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_venta.Properties.Appearance.Options.UseFont = True
        Me.txt_total_venta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_venta.Properties.Mask.EditMask = "n0"
        Me.txt_total_venta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_venta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_venta.Properties.ReadOnly = True
        Me.txt_total_venta.Size = New System.Drawing.Size(212, 24)
        Me.txt_total_venta.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Venta:"
        '
        'txt_total_vuelto
        '
        Me.txt_total_vuelto.Location = New System.Drawing.Point(116, 130)
        Me.txt_total_vuelto.Name = "txt_total_vuelto"
        Me.txt_total_vuelto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_vuelto.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_vuelto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_vuelto.Properties.Appearance.Options.UseFont = True
        Me.txt_total_vuelto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_vuelto.Properties.Mask.EditMask = "n0"
        Me.txt_total_vuelto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_vuelto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_vuelto.Properties.ReadOnly = True
        Me.txt_total_vuelto.Size = New System.Drawing.Size(212, 24)
        Me.txt_total_vuelto.TabIndex = 9
        '
        'txt_total_recibido
        '
        Me.txt_total_recibido.Location = New System.Drawing.Point(116, 102)
        Me.txt_total_recibido.Name = "txt_total_recibido"
        Me.txt_total_recibido.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_recibido.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_recibido.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_recibido.Properties.Appearance.Options.UseFont = True
        Me.txt_total_recibido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_recibido.Properties.Mask.EditMask = "n0"
        Me.txt_total_recibido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_recibido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_recibido.Properties.ReadOnly = True
        Me.txt_total_recibido.Size = New System.Drawing.Size(212, 24)
        Me.txt_total_recibido.TabIndex = 8
        '
        'txt_total_saldo
        '
        Me.txt_total_saldo.Location = New System.Drawing.Point(116, 74)
        Me.txt_total_saldo.Name = "txt_total_saldo"
        Me.txt_total_saldo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_saldo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_saldo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_saldo.Properties.Appearance.Options.UseFont = True
        Me.txt_total_saldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_saldo.Properties.Mask.EditMask = "n0"
        Me.txt_total_saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_saldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_saldo.Properties.ReadOnly = True
        Me.txt_total_saldo.Size = New System.Drawing.Size(212, 24)
        Me.txt_total_saldo.TabIndex = 7
        '
        'txt_total_pagar
        '
        Me.txt_total_pagar.Location = New System.Drawing.Point(116, 46)
        Me.txt_total_pagar.Name = "txt_total_pagar"
        Me.txt_total_pagar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_pagar.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_pagar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_pagar.Properties.Appearance.Options.UseFont = True
        Me.txt_total_pagar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_pagar.Properties.Mask.EditMask = "n0"
        Me.txt_total_pagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_pagar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_pagar.Properties.ReadOnly = True
        Me.txt_total_pagar.Size = New System.Drawing.Size(212, 24)
        Me.txt_total_pagar.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(35, 133)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Total Vuelto:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(18, 105)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Total Recibido:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(37, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Total Saldo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total a Pagar:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRecibos)
        Me.GroupBox2.Controls.Add(Me.btn_forma_pago)
        Me.GroupBox2.Controls.Add(Me.txt_importe)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.txt_forma_pago)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de Cobro"
        '
        'btnRecibos
        '
        Me.btnRecibos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibos.Appearance.Options.UseFont = True
        Me.btnRecibos.Location = New System.Drawing.Point(299, 66)
        Me.btnRecibos.Name = "btnRecibos"
        Me.btnRecibos.Size = New System.Drawing.Size(25, 21)
        Me.btnRecibos.TabIndex = 13
        Me.btnRecibos.Text = "+"
        '
        'btn_forma_pago
        '
        Me.btn_forma_pago.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_forma_pago.Appearance.Options.UseFont = True
        Me.btn_forma_pago.Location = New System.Drawing.Point(299, 37)
        Me.btn_forma_pago.Name = "btn_forma_pago"
        Me.btn_forma_pago.Size = New System.Drawing.Size(25, 21)
        Me.btn_forma_pago.TabIndex = 12
        Me.btn_forma_pago.Text = "+"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(112, 66)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_importe.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_importe.Properties.Appearance.Options.UseBackColor = True
        Me.txt_importe.Properties.Appearance.Options.UseFont = True
        Me.txt_importe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_importe.Properties.Mask.EditMask = "n0"
        Me.txt_importe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_importe.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_importe.Size = New System.Drawing.Size(184, 26)
        Me.txt_importe.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(55, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Importe:"
        '
        'txt_forma_pago
        '
        Me.txt_forma_pago.Location = New System.Drawing.Point(112, 37)
        Me.txt_forma_pago.Name = "txt_forma_pago"
        Me.txt_forma_pago.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_forma_pago.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_forma_pago.Properties.Appearance.Options.UseBackColor = True
        Me.txt_forma_pago.Properties.Appearance.Options.UseFont = True
        Me.txt_forma_pago.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_forma_pago.Properties.ReadOnly = True
        Me.txt_forma_pago.Size = New System.Drawing.Size(184, 24)
        Me.txt_forma_pago.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forma de Pago:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_aceptar.Appearance.Options.UseFont = True
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.Location = New System.Drawing.Point(403, 459)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(117, 35)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        '
        'btn_eliminar_cobro
        '
        Me.btn_eliminar_cobro.Location = New System.Drawing.Point(301, 312)
        Me.btn_eliminar_cobro.Name = "btn_eliminar_cobro"
        Me.btn_eliminar_cobro.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar_cobro.TabIndex = 5
        Me.btn_eliminar_cobro.Text = "Eliminar"
        '
        'panel_tarjetas
        '
        Me.panel_tarjetas.Controls.Add(Me.cbo_tipo_tarjeta)
        Me.panel_tarjetas.Controls.Add(Me.cbo_procesadora)
        Me.panel_tarjetas.Controls.Add(Me.LabelControl5)
        Me.panel_tarjetas.Controls.Add(Me.LabelControl6)
        Me.panel_tarjetas.Controls.Add(Me.txt_nro_boleta)
        Me.panel_tarjetas.Controls.Add(Me.Label3)
        Me.panel_tarjetas.Location = New System.Drawing.Point(403, 250)
        Me.panel_tarjetas.Name = "panel_tarjetas"
        Me.panel_tarjetas.Size = New System.Drawing.Size(420, 203)
        Me.panel_tarjetas.TabIndex = 2
        Me.panel_tarjetas.TabStop = False
        Me.panel_tarjetas.Text = "Detalles de Tarjeta"
        '
        'cbo_tipo_tarjeta
        '
        Me.cbo_tipo_tarjeta.EditValue = "T. CREDITO"
        Me.cbo_tipo_tarjeta.Location = New System.Drawing.Point(112, 94)
        Me.cbo_tipo_tarjeta.Name = "cbo_tipo_tarjeta"
        Me.cbo_tipo_tarjeta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbo_tipo_tarjeta.Properties.Appearance.Options.UseFont = True
        Me.cbo_tipo_tarjeta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_tarjeta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_tarjeta.Properties.ImmediatePopup = True
        Me.cbo_tipo_tarjeta.Properties.Items.AddRange(New Object() {"T. CREDITO", "T. DEBITO"})
        Me.cbo_tipo_tarjeta.Size = New System.Drawing.Size(212, 24)
        Me.cbo_tipo_tarjeta.TabIndex = 2
        '
        'cbo_procesadora
        '
        Me.cbo_procesadora.EditValue = "BANCARD"
        Me.cbo_procesadora.Location = New System.Drawing.Point(112, 62)
        Me.cbo_procesadora.Name = "cbo_procesadora"
        Me.cbo_procesadora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbo_procesadora.Properties.Appearance.Options.UseFont = True
        Me.cbo_procesadora.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_procesadora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_procesadora.Properties.ImmediatePopup = True
        Me.cbo_procesadora.Properties.Items.AddRange(New Object() {"BANCARD", "DINELCO"})
        Me.cbo_procesadora.Size = New System.Drawing.Size(212, 24)
        Me.cbo_procesadora.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(32, 97)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Tipo Tarjeta:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(27, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Procesadora:"
        '
        'txt_nro_boleta
        '
        Me.txt_nro_boleta.Location = New System.Drawing.Point(112, 31)
        Me.txt_nro_boleta.Name = "txt_nro_boleta"
        Me.txt_nro_boleta.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nro_boleta.Properties.Appearance.Options.UseFont = True
        Me.txt_nro_boleta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_boleta.Size = New System.Drawing.Size(212, 24)
        Me.txt_nro_boleta.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nro. Boleta:"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_cerrar.Appearance.Options.UseFont = True
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(649, 459)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cerrar.TabIndex = 4
        Me.btn_cerrar.Text = "Cerrar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelControl7)
        Me.GroupBox3.Controls.Add(Me.txt_porc_descuento)
        Me.GroupBox3.Controls.Add(Me.txt_descuento)
        Me.GroupBox3.Location = New System.Drawing.Point(403, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 81)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descuento"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(41, 31)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Descuento:"
        '
        'txt_porc_descuento
        '
        Me.txt_porc_descuento.Location = New System.Drawing.Point(112, 28)
        Me.txt_porc_descuento.Name = "txt_porc_descuento"
        Me.txt_porc_descuento.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_porc_descuento.Properties.AllowFocused = False
        Me.txt_porc_descuento.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txt_porc_descuento.Properties.AllowMouseWheel = False
        Me.txt_porc_descuento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txt_porc_descuento.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_porc_descuento.Properties.Appearance.Options.UseFont = True
        Me.txt_porc_descuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_porc_descuento.Properties.Mask.EditMask = "n"
        Me.txt_porc_descuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_porc_descuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_porc_descuento.Size = New System.Drawing.Size(58, 26)
        Me.txt_porc_descuento.TabIndex = 0
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(176, 28)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txt_descuento.Properties.AllowFocused = False
        Me.txt_descuento.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txt_descuento.Properties.AllowMouseWheel = False
        Me.txt_descuento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txt_descuento.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento.Properties.Appearance.Options.UseFont = True
        Me.txt_descuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_descuento.Properties.Mask.EditMask = "n0"
        Me.txt_descuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_descuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_descuento.Size = New System.Drawing.Size(148, 26)
        Me.txt_descuento.TabIndex = 1
        '
        'btn_comision_vendedor
        '
        Me.btn_comision_vendedor.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_comision_vendedor.Appearance.Options.UseFont = True
        Me.btn_comision_vendedor.Image = CType(resources.GetObject("btn_comision_vendedor.Image"), System.Drawing.Image)
        Me.btn_comision_vendedor.Location = New System.Drawing.Point(526, 459)
        Me.btn_comision_vendedor.Name = "btn_comision_vendedor"
        Me.btn_comision_vendedor.Size = New System.Drawing.Size(117, 35)
        Me.btn_comision_vendedor.TabIndex = 6
        Me.btn_comision_vendedor.Text = "Comision"
        '
        'grid_recibos
        '
        Me.grid_recibos.Location = New System.Drawing.Point(12, 353)
        Me.grid_recibos.MainView = Me.GridView2
        Me.grid_recibos.Name = "grid_recibos"
        Me.grid_recibos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit4})
        Me.grid_recibos.Size = New System.Drawing.Size(373, 141)
        Me.grid_recibos.TabIndex = 7
        Me.grid_recibos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_recibo, Me.col_numero, Me.col_monto})
        Me.GridView2.GridControl = Me.grid_recibos
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'col_recibo
        '
        Me.col_recibo.Caption = "ID Recibo"
        Me.col_recibo.FieldName = "id_recibo"
        Me.col_recibo.Name = "col_recibo"
        '
        'col_numero
        '
        Me.col_numero.Caption = "Numero"
        Me.col_numero.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.col_numero.FieldName = "numero"
        Me.col_numero.Name = "col_numero"
        Me.col_numero.Visible = True
        Me.col_numero.VisibleIndex = 0
        Me.col_numero.Width = 228
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'col_monto
        '
        Me.col_monto.AppearanceCell.Options.UseTextOptions = True
        Me.col_monto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_monto.AppearanceHeader.Options.UseTextOptions = True
        Me.col_monto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_monto.Caption = "Monto"
        Me.col_monto.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.col_monto.DisplayFormat.FormatString = "#,#"
        Me.col_monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_monto.FieldName = "monto"
        Me.col_monto.Name = "col_monto"
        Me.col_monto.Visible = True
        Me.col_monto.VisibleIndex = 1
        Me.col_monto.Width = 127
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'btnEliminarRecibo
        '
        Me.btnEliminarRecibo.Location = New System.Drawing.Point(301, 466)
        Me.btnEliminarRecibo.Name = "btnEliminarRecibo"
        Me.btnEliminarRecibo.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarRecibo.TabIndex = 8
        Me.btnEliminarRecibo.Text = "Eliminar"
        '
        'frm_cobros_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 505)
        Me.Controls.Add(Me.btnEliminarRecibo)
        Me.Controls.Add(Me.grid_recibos)
        Me.Controls.Add(Me.btn_comision_vendedor)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.panel_tarjetas)
        Me.Controls.Add(Me.btn_eliminar_cobro)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_cobros)
        Me.Name = "frm_cobros_caja"
        Me.Text = "<<Cobros de Caja>>"
        CType(Me.grid_cobros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_total_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_vuelto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_recibido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_pagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_importe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_forma_pago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_tarjetas.ResumeLayout(False)
        Me.panel_tarjetas.PerformLayout()
        CType(Me.cbo_tipo_tarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_procesadora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_boleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_porc_descuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_recibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_cobros As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_total_vuelto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_recibido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_pagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_forma_pago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_importe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_forma_pago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_aceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_eliminar_cobro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_tarjetas As GroupBox
    Friend WithEvents txt_nro_boleta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id_forma_pago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_forma_pago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_importe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbo_tipo_tarjeta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbo_procesadora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_nro_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tipo_pago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_porc_descuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_descuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_comision_vendedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecibos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id_recibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_recibos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_recibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_numero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnEliminarRecibo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
