<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_extraccion_efectivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_extraccion_efectivo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_observacion = New DevExpress.XtraEditors.MemoEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_total_monto = New DevExpress.XtraEditors.TextEdit()
        Me.txt_beneficiario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_doc_beneficiario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_control_caja = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_extraccion = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_beneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_doc_beneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_control_caja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_extraccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_observacion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_total_monto)
        Me.GroupBox1.Controls.Add(Me.txt_beneficiario)
        Me.GroupBox1.Controls.Add(Me.txt_nro_doc_beneficiario)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_id_control_caja)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_nro_extraccion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 498)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Extraccion"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(185, 269)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(250, 76)
        Me.txt_observacion.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Observacion:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Appearance.Options.UseForeColor = True
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(322, 424)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 20
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmar.Appearance.Options.UseForeColor = True
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(199, 424)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 19
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(76, 424)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(117, 35)
        Me.btn_nuevo.TabIndex = 18
        Me.btn_nuevo.Text = "Nuevo"
        '
        'txt_total_monto
        '
        Me.txt_total_monto.Location = New System.Drawing.Point(185, 241)
        Me.txt_total_monto.Name = "txt_total_monto"
        Me.txt_total_monto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_total_monto.Properties.Appearance.Options.UseBackColor = True
        Me.txt_total_monto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_total_monto.Properties.Mask.EditMask = "n0"
        Me.txt_total_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_monto.Size = New System.Drawing.Size(250, 22)
        Me.txt_total_monto.TabIndex = 17
        '
        'txt_beneficiario
        '
        Me.txt_beneficiario.Location = New System.Drawing.Point(185, 213)
        Me.txt_beneficiario.Name = "txt_beneficiario"
        Me.txt_beneficiario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_beneficiario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_beneficiario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_beneficiario.Size = New System.Drawing.Size(250, 22)
        Me.txt_beneficiario.TabIndex = 16
        '
        'txt_nro_doc_beneficiario
        '
        Me.txt_nro_doc_beneficiario.Location = New System.Drawing.Point(185, 185)
        Me.txt_nro_doc_beneficiario.Name = "txt_nro_doc_beneficiario"
        Me.txt_nro_doc_beneficiario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_doc_beneficiario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_doc_beneficiario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_doc_beneficiario.Size = New System.Drawing.Size(250, 22)
        Me.txt_nro_doc_beneficiario.TabIndex = 15
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(185, 157)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(250, 22)
        Me.txt_fecha.TabIndex = 14
        '
        'txt_usuario
        '
        Me.txt_usuario.EditValue = " "
        Me.txt_usuario.Location = New System.Drawing.Point(185, 129)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(250, 22)
        Me.txt_usuario.TabIndex = 13
        '
        'txt_id_control_caja
        '
        Me.txt_id_control_caja.Location = New System.Drawing.Point(185, 101)
        Me.txt_id_control_caja.Name = "txt_id_control_caja"
        Me.txt_id_control_caja.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_control_caja.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_control_caja.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_control_caja.Properties.ReadOnly = True
        Me.txt_id_control_caja.Size = New System.Drawing.Size(250, 22)
        Me.txt_id_control_caja.TabIndex = 12
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(185, 73)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(250, 22)
        Me.txt_sucursal.TabIndex = 11
        '
        'txt_nro_extraccion
        '
        Me.txt_nro_extraccion.Location = New System.Drawing.Point(185, 45)
        Me.txt_nro_extraccion.Name = "txt_nro_extraccion"
        Me.txt_nro_extraccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_extraccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_extraccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_extraccion.Properties.ReadOnly = True
        Me.txt_nro_extraccion.Size = New System.Drawing.Size(250, 22)
        Me.txt_nro_extraccion.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Monto Efectivo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Beneficiario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Nro. Doc. Beneficiario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Control caja Nro.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Extraccion Nro.:"
        '
        'frm_extraccion_efectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 547)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_extraccion_efectivo"
        Me.Text = "<<Detalles de Extraccion>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_observacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_beneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_doc_beneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_control_caja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_extraccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_total_monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_beneficiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_doc_beneficiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_control_caja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_extraccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_observacion As DevExpress.XtraEditors.MemoEdit
End Class
