<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nueva_familia_materia_prima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nueva_familia_materia_prima))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_familia_padre = New DevExpress.XtraEditors.TextEdit()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_padre = New DevExpress.XtraEditors.TextEdit()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chk_asentable = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_codigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_nivel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_familia_padre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_padre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_asentable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_nivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.txt_familia_padre)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_id_padre)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.chk_asentable)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.cbo_nivel)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Familia"
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(178, 238)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(117, 35)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Registrar"
        '
        'txt_familia_padre
        '
        Me.txt_familia_padre.Location = New System.Drawing.Point(152, 36)
        Me.txt_familia_padre.Name = "txt_familia_padre"
        Me.txt_familia_padre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_familia_padre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia_padre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia_padre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familia_padre.Properties.ReadOnly = True
        Me.txt_familia_padre.Size = New System.Drawing.Size(215, 22)
        Me.txt_familia_padre.TabIndex = 5
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(301, 238)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cerrar"
        '
        'txt_id_padre
        '
        Me.txt_id_padre.Location = New System.Drawing.Point(104, 36)
        Me.txt_id_padre.Name = "txt_id_padre"
        Me.txt_id_padre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_padre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_padre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_padre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_padre.Properties.ReadOnly = True
        Me.txt_id_padre.Size = New System.Drawing.Size(46, 22)
        Me.txt_id_padre.TabIndex = 25
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(104, 120)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familia.Size = New System.Drawing.Size(299, 22)
        Me.txt_familia.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Linea Padre:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(59, 95)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Codigo:"
        '
        'chk_asentable
        '
        Me.chk_asentable.Location = New System.Drawing.Point(44, 148)
        Me.chk_asentable.Name = "chk_asentable"
        Me.chk_asentable.Properties.Caption = "Asentable:"
        Me.chk_asentable.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk_asentable.Size = New System.Drawing.Size(77, 19)
        Me.chk_asentable.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(60, 123)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Familia:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(104, 92)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_codigo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_codigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_codigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo.Properties.ReadOnly = True
        Me.txt_codigo.Size = New System.Drawing.Size(99, 22)
        Me.txt_codigo.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(69, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Nivel:"
        '
        'cbo_nivel
        '
        Me.cbo_nivel.Enabled = False
        Me.cbo_nivel.Location = New System.Drawing.Point(104, 64)
        Me.cbo_nivel.Name = "cbo_nivel"
        Me.cbo_nivel.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_nivel.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_nivel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cbo_nivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_nivel.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbo_nivel.Size = New System.Drawing.Size(100, 22)
        Me.cbo_nivel.TabIndex = 4
        '
        'frm_nueva_familia_materia_prima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 360)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_nueva_familia_materia_prima"
        Me.Text = "<<Definicion de Familias de Materia Prima>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_familia_padre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_padre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_asentable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_nivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_familia_padre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_padre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_asentable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_codigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_nivel As DevExpress.XtraEditors.ComboBoxEdit
End Class
