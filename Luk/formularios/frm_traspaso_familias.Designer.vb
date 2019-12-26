<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_traspaso_familias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_traspaso_familias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_linea_padre = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_linea = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id_linea_padre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id_familia = New DevExpress.XtraEditors.TextEdit()
        Me.txt_familia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_linea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_linea_padre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscar_linea_padre)
        Me.GroupBox1.Controls.Add(Me.txt_linea)
        Me.GroupBox1.Controls.Add(Me.txt_id_linea_padre)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_id_familia)
        Me.GroupBox1.Controls.Add(Me.txt_familia)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Traspaso"
        '
        'btn_buscar_linea_padre
        '
        Me.btn_buscar_linea_padre.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_buscar_linea_padre.Location = New System.Drawing.Point(361, 74)
        Me.btn_buscar_linea_padre.Name = "btn_buscar_linea_padre"
        Me.btn_buscar_linea_padre.Size = New System.Drawing.Size(33, 22)
        Me.btn_buscar_linea_padre.TabIndex = 41
        Me.btn_buscar_linea_padre.Text = "+"
        '
        'txt_linea
        '
        Me.txt_linea.Location = New System.Drawing.Point(130, 75)
        Me.txt_linea.Name = "txt_linea"
        Me.txt_linea.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_linea.Properties.Appearance.Options.UseBackColor = True
        Me.txt_linea.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_linea.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_linea.Properties.ReadOnly = True
        Me.txt_linea.Size = New System.Drawing.Size(228, 22)
        Me.txt_linea.TabIndex = 0
        '
        'txt_id_linea_padre
        '
        Me.txt_id_linea_padre.Location = New System.Drawing.Point(82, 75)
        Me.txt_id_linea_padre.Name = "txt_id_linea_padre"
        Me.txt_id_linea_padre.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_id_linea_padre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_linea_padre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_linea_padre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_linea_padre.Properties.ReadOnly = True
        Me.txt_id_linea_padre.Size = New System.Drawing.Size(46, 22)
        Me.txt_id_linea_padre.TabIndex = 39
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "Traspasar a:"
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.Location = New System.Drawing.Point(169, 243)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(117, 35)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Confirmar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(292, 243)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cerrar"
        '
        'txt_id_familia
        '
        Me.txt_id_familia.Location = New System.Drawing.Point(83, 49)
        Me.txt_id_familia.Name = "txt_id_familia"
        Me.txt_id_familia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_familia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_familia.Properties.ReadOnly = True
        Me.txt_id_familia.Size = New System.Drawing.Size(46, 22)
        Me.txt_id_familia.TabIndex = 37
        '
        'txt_familia
        '
        Me.txt_familia.Location = New System.Drawing.Point(130, 49)
        Me.txt_familia.Name = "txt_familia"
        Me.txt_familia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_familia.Properties.Appearance.Options.UseBackColor = True
        Me.txt_familia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_familia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familia.Properties.ReadOnly = True
        Me.txt_familia.Size = New System.Drawing.Size(264, 22)
        Me.txt_familia.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Familia:"
        '
        'frm_traspaso_familias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_traspaso_familias"
        Me.Text = "<<Traspaso de Articulos>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_linea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_linea_padre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_linea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_id_linea_padre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_id_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_familia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_buscar_linea_padre As DevExpress.XtraEditors.SimpleButton
End Class
