<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apertura_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_apertura_caja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_monto_inicial = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_comentario = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_empresa = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_registrar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_trans_final = New DevExpress.XtraEditors.TextEdit()
        Me.txt_trans_inicial = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fecha = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nro_apertura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_monto_inicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_empresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trans_final.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trans_inicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nro_apertura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_monto_inicial)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.txt_comentario)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txt_empresa)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_registrar)
        Me.GroupBox1.Controls.Add(Me.txt_trans_final)
        Me.GroupBox1.Controls.Add(Me.txt_trans_inicial)
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_sucursal)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.txt_nro_apertura)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 464)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Apertura"
        '
        'txt_monto_inicial
        '
        Me.txt_monto_inicial.Location = New System.Drawing.Point(165, 257)
        Me.txt_monto_inicial.Name = "txt_monto_inicial"
        Me.txt_monto_inicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_monto_inicial.Properties.Appearance.Options.UseFont = True
        Me.txt_monto_inicial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_monto_inicial.Properties.Mask.EditMask = "n0"
        Me.txt_monto_inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_monto_inicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_monto_inicial.Size = New System.Drawing.Size(234, 24)
        Me.txt_monto_inicial.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl9.Location = New System.Drawing.Point(89, 260)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Monto inicial:"
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(165, 287)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_comentario.Size = New System.Drawing.Size(234, 76)
        Me.txt_comentario.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl8.Location = New System.Drawing.Point(91, 288)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Comentario:"
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(165, 107)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_empresa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_empresa.Properties.Appearance.Options.UseBackColor = True
        Me.txt_empresa.Properties.Appearance.Options.UseFont = True
        Me.txt_empresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_empresa.Properties.ReadOnly = True
        Me.txt_empresa.Size = New System.Drawing.Size(234, 24)
        Me.txt_empresa.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl7.Location = New System.Drawing.Point(107, 110)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Empresa:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(244, 410)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Salir"
        '
        'btn_registrar
        '
        Me.btn_registrar.Image = CType(resources.GetObject("btn_registrar.Image"), System.Drawing.Image)
        Me.btn_registrar.Location = New System.Drawing.Point(117, 410)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(117, 35)
        Me.btn_registrar.TabIndex = 4
        Me.btn_registrar.Text = "Registrar"
        '
        'txt_trans_final
        '
        Me.txt_trans_final.Location = New System.Drawing.Point(165, 227)
        Me.txt_trans_final.Name = "txt_trans_final"
        Me.txt_trans_final.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_trans_final.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_trans_final.Properties.Appearance.Options.UseBackColor = True
        Me.txt_trans_final.Properties.Appearance.Options.UseFont = True
        Me.txt_trans_final.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_trans_final.Properties.ReadOnly = True
        Me.txt_trans_final.Size = New System.Drawing.Size(234, 24)
        Me.txt_trans_final.TabIndex = 1
        '
        'txt_trans_inicial
        '
        Me.txt_trans_inicial.Location = New System.Drawing.Point(165, 197)
        Me.txt_trans_inicial.Name = "txt_trans_inicial"
        Me.txt_trans_inicial.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_trans_inicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_trans_inicial.Properties.Appearance.Options.UseBackColor = True
        Me.txt_trans_inicial.Properties.Appearance.Options.UseFont = True
        Me.txt_trans_inicial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_trans_inicial.Properties.ReadOnly = True
        Me.txt_trans_inicial.Size = New System.Drawing.Size(234, 24)
        Me.txt_trans_inicial.TabIndex = 0
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(165, 167)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_usuario.Properties.Appearance.Options.UseFont = True
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(234, 24)
        Me.txt_usuario.TabIndex = 8
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(165, 137)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_sucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_sucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sucursal.Properties.Appearance.Options.UseFont = True
        Me.txt_sucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_sucursal.Properties.ReadOnly = True
        Me.txt_sucursal.Size = New System.Drawing.Size(234, 24)
        Me.txt_sucursal.TabIndex = 7
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(165, 77)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_fecha.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fecha.Properties.Appearance.Options.UseFont = True
        Me.txt_fecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_fecha.Properties.ReadOnly = True
        Me.txt_fecha.Size = New System.Drawing.Size(234, 24)
        Me.txt_fecha.TabIndex = 6
        '
        'txt_nro_apertura
        '
        Me.txt_nro_apertura.Location = New System.Drawing.Point(165, 47)
        Me.txt_nro_apertura.Name = "txt_nro_apertura"
        Me.txt_nro_apertura.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nro_apertura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_nro_apertura.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nro_apertura.Properties.Appearance.Options.UseFont = True
        Me.txt_nro_apertura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nro_apertura.Properties.ReadOnly = True
        Me.txt_nro_apertura.Size = New System.Drawing.Size(234, 24)
        Me.txt_nro_apertura.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(89, 230)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Trans. Final:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(83, 200)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Trans. Inicial:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(108, 170)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Usuario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(108, 140)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Sucursal:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(123, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(79, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nro. Apertura:"
        '
        'frm_apertura_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_apertura_caja"
        Me.Text = "<<Apertura de Caja>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_monto_inicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_empresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trans_final.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trans_inicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nro_apertura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_trans_final As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_trans_inicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nro_apertura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_empresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_registrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_comentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_monto_inicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
