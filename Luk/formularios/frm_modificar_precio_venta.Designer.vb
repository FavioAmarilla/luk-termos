<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modificar_precio_venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_modificar_precio_venta))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_codigo_barras = New DevExpress.XtraEditors.TextEdit()
        Me.txt_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_cod_interno = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_articulo = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_va_porcentaje = New DevExpress.XtraEditors.TextEdit()
        Me.txt_va_precio_costo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_va_precio_venta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_historial = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_ul_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ul_precio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_registrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_nuevo_precio = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_interno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_va_porcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_va_precio_costo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_va_precio_venta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_ul_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ul_precio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txt_nuevo_precio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(51, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Articulo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(38, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Id Articulo:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(54, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Codigo:"
        '
        'txt_codigo_barras
        '
        Me.txt_codigo_barras.Location = New System.Drawing.Point(97, 29)
        Me.txt_codigo_barras.Name = "txt_codigo_barras"
        Me.txt_codigo_barras.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_codigo_barras.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo_barras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo_barras.Size = New System.Drawing.Size(105, 22)
        Me.txt_codigo_barras.TabIndex = 0
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(204, 29)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_articulo.Properties.ReadOnly = True
        Me.txt_articulo.Size = New System.Drawing.Size(321, 22)
        Me.txt_articulo.TabIndex = 5
        '
        'txt_id_articulo
        '
        Me.txt_id_articulo.Location = New System.Drawing.Point(97, 55)
        Me.txt_id_articulo.Name = "txt_id_articulo"
        Me.txt_id_articulo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_articulo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_articulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_articulo.Properties.ReadOnly = True
        Me.txt_id_articulo.Size = New System.Drawing.Size(163, 22)
        Me.txt_id_articulo.TabIndex = 1
        '
        'txt_cod_interno
        '
        Me.txt_cod_interno.Location = New System.Drawing.Point(97, 81)
        Me.txt_cod_interno.Name = "txt_cod_interno"
        Me.txt_cod_interno.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_cod_interno.Properties.Appearance.Options.UseBackColor = True
        Me.txt_cod_interno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_cod_interno.Properties.ReadOnly = True
        Me.txt_cod_interno.Size = New System.Drawing.Size(164, 22)
        Me.txt_cod_interno.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscar_articulo)
        Me.GroupBox1.Controls.Add(Me.txt_codigo_barras)
        Me.GroupBox1.Controls.Add(Me.txt_cod_interno)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_id_articulo)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txt_articulo)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Articulo"
        '
        'btn_buscar_articulo
        '
        Me.btn_buscar_articulo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_articulo.Location = New System.Drawing.Point(527, 29)
        Me.btn_buscar_articulo.Name = "btn_buscar_articulo"
        Me.btn_buscar_articulo.Size = New System.Drawing.Size(29, 20)
        Me.btn_buscar_articulo.TabIndex = 9
        Me.btn_buscar_articulo.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.txt_va_porcentaje)
        Me.GroupBox2.Controls.Add(Me.txt_va_precio_costo)
        Me.GroupBox2.Controls.Add(Me.txt_va_precio_venta)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 172)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores Actuales"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(266, 107)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "(%)"
        '
        'txt_va_porcentaje
        '
        Me.txt_va_porcentaje.Location = New System.Drawing.Point(116, 103)
        Me.txt_va_porcentaje.Name = "txt_va_porcentaje"
        Me.txt_va_porcentaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_va_porcentaje.Size = New System.Drawing.Size(144, 22)
        Me.txt_va_porcentaje.TabIndex = 2
        '
        'txt_va_precio_costo
        '
        Me.txt_va_precio_costo.Location = New System.Drawing.Point(116, 75)
        Me.txt_va_precio_costo.Name = "txt_va_precio_costo"
        Me.txt_va_precio_costo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_va_precio_costo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_va_precio_costo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_va_precio_costo.Properties.Mask.EditMask = "n0"
        Me.txt_va_precio_costo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_va_precio_costo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_va_precio_costo.Properties.ReadOnly = True
        Me.txt_va_precio_costo.Size = New System.Drawing.Size(169, 22)
        Me.txt_va_precio_costo.TabIndex = 1
        '
        'txt_va_precio_venta
        '
        Me.txt_va_precio_venta.Location = New System.Drawing.Point(116, 47)
        Me.txt_va_precio_venta.Name = "txt_va_precio_venta"
        Me.txt_va_precio_venta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_va_precio_venta.Properties.Appearance.Options.UseBackColor = True
        Me.txt_va_precio_venta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_va_precio_venta.Properties.Mask.EditMask = "n0"
        Me.txt_va_precio_venta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_va_precio_venta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_va_precio_venta.Properties.ReadOnly = True
        Me.txt_va_precio_venta.Size = New System.Drawing.Size(169, 22)
        Me.txt_va_precio_venta.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(42, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Porc. Recargo:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(35, 51)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Precio de Venta:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(50, 79)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Precio Costo:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_historial)
        Me.GroupBox3.Controls.Add(Me.txt_ul_fecha)
        Me.GroupBox3.Controls.Add(Me.txt_ul_precio)
        Me.GroupBox3.Controls.Add(Me.LabelControl9)
        Me.GroupBox3.Controls.Add(Me.LabelControl8)
        Me.GroupBox3.Location = New System.Drawing.Point(373, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 172)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ultimo cambio de Precio"
        '
        'btn_historial
        '
        Me.btn_historial.Location = New System.Drawing.Point(198, 131)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.Size = New System.Drawing.Size(87, 24)
        Me.btn_historial.TabIndex = 2
        Me.btn_historial.Text = "Historial"
        '
        'txt_ul_fecha
        '
        Me.txt_ul_fecha.Location = New System.Drawing.Point(116, 75)
        Me.txt_ul_fecha.Name = "txt_ul_fecha"
        Me.txt_ul_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ul_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ul_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ul_fecha.Properties.ReadOnly = True
        Me.txt_ul_fecha.Size = New System.Drawing.Size(169, 22)
        Me.txt_ul_fecha.TabIndex = 1
        '
        'txt_ul_precio
        '
        Me.txt_ul_precio.Location = New System.Drawing.Point(116, 47)
        Me.txt_ul_precio.Name = "txt_ul_precio"
        Me.txt_ul_precio.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_ul_precio.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ul_precio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_ul_precio.Properties.Mask.EditMask = "n0"
        Me.txt_ul_precio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_ul_precio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_ul_precio.Properties.ReadOnly = True
        Me.txt_ul_precio.Size = New System.Drawing.Size(169, 22)
        Me.txt_ul_precio.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(35, 51)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Precio Anterior:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(51, 79)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Ult. Cambio:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_registrar)
        Me.GroupBox4.Controls.Add(Me.btn_nuevo)
        Me.GroupBox4.Controls.Add(Me.txt_nuevo_precio)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(663, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nuevo Precio de Venta"
        '
        'btn_registrar
        '
        Me.btn_registrar.Image = CType(resources.GetObject("btn_registrar.Image"), System.Drawing.Image)
        Me.btn_registrar.Location = New System.Drawing.Point(496, 61)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_registrar.TabIndex = 2
        Me.btn_registrar.Text = "Registrar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(496, 20)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_nuevo_precio
        '
        Me.txt_nuevo_precio.Location = New System.Drawing.Point(14, 34)
        Me.txt_nuevo_precio.Name = "txt_nuevo_precio"
        Me.txt_nuevo_precio.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nuevo_precio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.txt_nuevo_precio.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nuevo_precio.Properties.Appearance.Options.UseFont = True
        Me.txt_nuevo_precio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nuevo_precio.Properties.Mask.EditMask = "n0"
        Me.txt_nuevo_precio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_nuevo_precio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_nuevo_precio.Size = New System.Drawing.Size(187, 32)
        Me.txt_nuevo_precio.TabIndex = 1
        '
        'frm_modificar_precio_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 489)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_modificar_precio_venta"
        Me.Text = "<<Modificacion de Precio de Venta>>"
        CType(Me.txt_codigo_barras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_interno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_va_porcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_va_precio_costo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_va_precio_venta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_ul_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ul_precio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.txt_nuevo_precio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_codigo_barras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cod_interno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_buscar_articulo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_va_porcentaje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_va_precio_costo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_va_precio_venta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ul_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ul_precio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_registrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nuevo_precio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_historial As DevExpress.XtraEditors.SimpleButton
End Class
