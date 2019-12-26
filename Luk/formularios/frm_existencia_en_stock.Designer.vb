<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_existencia_en_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_existencia_en_stock))
        Me.lbl_combo = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_tipo_stock = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_sucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_articulos = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_existencia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_impuesto = New DevExpress.XtraEditors.TextEdit()
        Me.txt_codigo_barras = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbo_tipo_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_existencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_impuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_combo
        '
        Me.lbl_combo.Location = New System.Drawing.Point(43, 47)
        Me.lbl_combo.Name = "lbl_combo"
        Me.lbl_combo.Size = New System.Drawing.Size(86, 13)
        Me.lbl_combo.TabIndex = 5
        Me.lbl_combo.Text = "Stock a Visualizar:"
        '
        'cbo_tipo_stock
        '
        Me.cbo_tipo_stock.EditValue = ""
        Me.cbo_tipo_stock.Location = New System.Drawing.Point(132, 43)
        Me.cbo_tipo_stock.Name = "cbo_tipo_stock"
        Me.cbo_tipo_stock.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_tipo_stock.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_tipo_stock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_tipo_stock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_tipo_stock.Properties.ImmediatePopup = True
        Me.cbo_tipo_stock.Properties.Items.AddRange(New Object() {"ARTICULOS", "MATERIA PRIMA"})
        Me.cbo_tipo_stock.Size = New System.Drawing.Size(257, 22)
        Me.cbo_tipo_stock.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscar_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_id_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btn_articulos)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_existencia)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_stock)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.lbl_combo)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.txt_impuesto)
        Me.GroupBox1.Controls.Add(Me.txt_codigo_barras)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btn_buscar_sucursal
        '
        Me.btn_buscar_sucursal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_sucursal.Location = New System.Drawing.Point(366, 70)
        Me.btn_buscar_sucursal.Name = "btn_buscar_sucursal"
        Me.btn_buscar_sucursal.Size = New System.Drawing.Size(25, 22)
        Me.btn_buscar_sucursal.TabIndex = 40
        Me.btn_buscar_sucursal.Text = "+"
        '
        'txt_id_sucursal
        '
        Me.txt_id_sucursal.Location = New System.Drawing.Point(132, 71)
        Me.txt_id_sucursal.Name = "txt_id_sucursal"
        Me.txt_id_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_sucursal.Properties.ReadOnly = True
        Me.txt_id_sucursal.Size = New System.Drawing.Size(43, 22)
        Me.txt_id_sucursal.TabIndex = 39
        '
        'txt_sucursal
        '
        Me.txt_sucursal.EditValue = ""
        Me.txt_sucursal.Location = New System.Drawing.Point(176, 71)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(188, 22)
        Me.txt_sucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(85, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Sucursal:"
        '
        'btn_articulos
        '
        Me.btn_articulos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_articulos.Appearance.Options.UseFont = True
        Me.btn_articulos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_articulos.Location = New System.Drawing.Point(366, 99)
        Me.btn_articulos.Name = "btn_articulos"
        Me.btn_articulos.Size = New System.Drawing.Size(25, 21)
        Me.btn_articulos.TabIndex = 36
        Me.btn_articulos.Text = "+"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(170, 313)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        '
        'txt_existencia
        '
        Me.txt_existencia.Location = New System.Drawing.Point(132, 203)
        Me.txt_existencia.Name = "txt_existencia"
        Me.txt_existencia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_existencia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_existencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_existencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_existencia.Properties.DisplayFormat.FormatString = "0,00"
        Me.txt_existencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txt_existencia.Properties.Mask.EditMask = "n"
        Me.txt_existencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_existencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_existencia.Properties.ReadOnly = True
        Me.txt_existencia.Size = New System.Drawing.Size(257, 22)
        Me.txt_existencia.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(77, 207)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl9.TabIndex = 26
        Me.LabelControl9.Text = "Existencia:"
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(132, 177)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(257, 22)
        Me.txt_familia.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(93, 180)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Familia:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(132, 125)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Properties.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(257, 22)
        Me.txt_nombre.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(80, 154)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "Impuesto:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(92, 103)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Codigo:"
        '
        'txt_impuesto
        '
        Me.txt_impuesto.Location = New System.Drawing.Point(132, 151)
        Me.txt_impuesto.Name = "txt_impuesto"
        Me.txt_impuesto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_impuesto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_impuesto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_impuesto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_impuesto.Properties.ReadOnly = True
        Me.txt_impuesto.Size = New System.Drawing.Size(257, 22)
        Me.txt_impuesto.TabIndex = 4
        '
        'txt_codigo_barras
        '
        Me.txt_codigo_barras.Location = New System.Drawing.Point(132, 99)
        Me.txt_codigo_barras.Name = "txt_codigo_barras"
        Me.txt_codigo_barras.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_codigo_barras.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo_barras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo_barras.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo_barras.Size = New System.Drawing.Size(232, 22)
        Me.txt_codigo_barras.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(71, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Descripcion:"
        '
        'frm_existencia_en_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_existencia_en_stock"
        Me.Text = "<<Existencia en Stock>>"
        CType(Me.cbo_tipo_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_id_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_existencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_impuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_combo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_tipo_stock As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_impuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_codigo_barras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_existencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_articulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_buscar_sucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
