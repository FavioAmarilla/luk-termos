<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.txt_contraseña = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.btn_ingresar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.txt_contraseña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.EnableBonusSkins = True
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(114, 46)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(47, 13)
        Me.lbl_usuario.TabIndex = 2
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(94, 84)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(67, 13)
        Me.lbl_contraseña.TabIndex = 3
        Me.lbl_contraseña.Text = "Contraseña:"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(162, 81)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_contraseña.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_contraseña.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(177, 22)
        Me.txt_contraseña.TabIndex = 1
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(162, 43)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuario.Size = New System.Drawing.Size(177, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Image = CType(resources.GetObject("btn_ingresar.Image"), System.Drawing.Image)
        Me.btn_ingresar.Location = New System.Drawing.Point(114, 135)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(117, 35)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "INGRESAR"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(237, 135)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(117, 35)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "CANCELAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_usuario)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.lbl_usuario)
        Me.GroupBox1.Controls.Add(Me.btn_ingresar)
        Me.GroupBox1.Controls.Add(Me.lbl_contraseña)
        Me.GroupBox1.Controls.Add(Me.txt_contraseña)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 204)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'frm_login
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Acceso al Sistema>>"
        CType(Me.txt_contraseña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contraseña As Label
    Friend WithEvents txt_contraseña As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_ingresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
