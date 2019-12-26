<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_traspaso_articulo_prov
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_traspaso_articulo_prov))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.btn_proveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_traspaso = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_traspaso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_confirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_proveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_traspaso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.lbl_total_registros)
        Me.GroupBox1.Controls.Add(Me.btn_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_traspaso)
        Me.GroupBox1.Controls.Add(Me.txt_traspaso)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.btn_confirmar)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Traspaso"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.Location = New System.Drawing.Point(108, 243)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(117, 35)
        Me.btn_consultar.TabIndex = 81
        Me.btn_consultar.Text = "Consultar"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(168, 107)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(308, 23)
        Me.lbl_total_registros.TabIndex = 80
        Me.lbl_total_registros.Text = "Registros recuperados: 0"
        '
        'btn_proveedor
        '
        Me.btn_proveedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_proveedor.Location = New System.Drawing.Point(444, 52)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(33, 22)
        Me.btn_proveedor.TabIndex = 42
        Me.btn_proveedor.Text = "+"
        '
        'btn_traspaso
        '
        Me.btn_traspaso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btn_traspaso.Location = New System.Drawing.Point(444, 78)
        Me.btn_traspaso.Name = "btn_traspaso"
        Me.btn_traspaso.Size = New System.Drawing.Size(33, 22)
        Me.btn_traspaso.TabIndex = 41
        Me.btn_traspaso.Text = "+"
        '
        'txt_traspaso
        '
        Me.txt_traspaso.Location = New System.Drawing.Point(168, 79)
        Me.txt_traspaso.Name = "txt_traspaso"
        Me.txt_traspaso.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_traspaso.Properties.Appearance.Options.UseBackColor = True
        Me.txt_traspaso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_traspaso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_traspaso.Properties.ReadOnly = True
        Me.txt_traspaso.Size = New System.Drawing.Size(273, 22)
        Me.txt_traspaso.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(101, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "Traspasar a:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Image = CType(resources.GetObject("btn_confirmar.Image"), System.Drawing.Image)
        Me.btn_confirmar.Location = New System.Drawing.Point(231, 243)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(117, 35)
        Me.btn_confirmar.TabIndex = 2
        Me.btn_confirmar.Text = "Confirmar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(354, 243)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(168, 53)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_proveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txt_proveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_proveedor.Properties.ReadOnly = True
        Me.txt_proveedor.Size = New System.Drawing.Size(273, 22)
        Me.txt_proveedor.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(108, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Proveedor:"
        '
        'frm_traspaso_articulo_prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_traspaso_articulo_prov"
        Me.Text = "<<Traspaso de Articulos>>"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_traspaso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_proveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_traspaso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_traspaso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_confirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_consultar As DevExpress.XtraEditors.SimpleButton
End Class
