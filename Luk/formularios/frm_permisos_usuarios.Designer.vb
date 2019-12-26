<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_permisos_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_permisos_usuarios))
        Me.grid_permisos_asignados = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_usuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_id_permiso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_permiso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lst_permisos = New DevExpress.XtraEditors.ListBoxControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_id_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_direccion = New DevExpress.XtraEditors.TextEdit()
        Me.txt_telefono = New DevExpress.XtraEditors.TextEdit()
        Me.txt_usuario = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_agregar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_registros = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_quitar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_permisos_asignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lst_permisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_id_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_permisos_asignados
        '
        Me.grid_permisos_asignados.Location = New System.Drawing.Point(18, 24)
        Me.grid_permisos_asignados.MainView = Me.GridView1
        Me.grid_permisos_asignados.Name = "grid_permisos_asignados"
        Me.grid_permisos_asignados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_permisos_asignados.Size = New System.Drawing.Size(612, 320)
        Me.grid_permisos_asignados.TabIndex = 0
        Me.grid_permisos_asignados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_usuario, Me.col_id_permiso, Me.col_permiso})
        Me.GridView1.GridControl = Me.grid_permisos_asignados
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_usuario
        '
        Me.col_usuario.Caption = "Usuario"
        Me.col_usuario.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_usuario.FieldName = "usuario"
        Me.col_usuario.Name = "col_usuario"
        Me.col_usuario.Visible = True
        Me.col_usuario.VisibleIndex = 0
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'col_id_permiso
        '
        Me.col_id_permiso.Caption = "Id Permiso"
        Me.col_id_permiso.FieldName = "id+permiso"
        Me.col_id_permiso.Name = "col_id_permiso"
        '
        'col_permiso
        '
        Me.col_permiso.Caption = "Permiso"
        Me.col_permiso.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.col_permiso.FieldName = "permiso"
        Me.col_permiso.Name = "col_permiso"
        Me.col_permiso.Visible = True
        Me.col_permiso.VisibleIndex = 1
        '
        'lst_permisos
        '
        Me.lst_permisos.Location = New System.Drawing.Point(20, 29)
        Me.lst_permisos.Name = "lst_permisos"
        Me.lst_permisos.Size = New System.Drawing.Size(262, 500)
        Me.lst_permisos.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lst_permisos)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 547)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Permisos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_id_usuario)
        Me.GroupBox2.Controls.Add(Me.txt_direccion)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.txt_usuario)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(479, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Usuario"
        '
        'txt_id_usuario
        '
        Me.txt_id_usuario.EditValue = " "
        Me.txt_id_usuario.Location = New System.Drawing.Point(120, 26)
        Me.txt_id_usuario.Name = "txt_id_usuario"
        Me.txt_id_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_id_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_id_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_id_usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id_usuario.Properties.ReadOnly = True
        Me.txt_id_usuario.Size = New System.Drawing.Size(40, 22)
        Me.txt_id_usuario.TabIndex = 8
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(420, 54)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_direccion.Properties.Appearance.Options.UseBackColor = True
        Me.txt_direccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_direccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Properties.ReadOnly = True
        Me.txt_direccion.Size = New System.Drawing.Size(201, 22)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(420, 26)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_telefono.Properties.Appearance.Options.UseBackColor = True
        Me.txt_telefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_telefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Properties.ReadOnly = True
        Me.txt_telefono.Size = New System.Drawing.Size(201, 22)
        Me.txt_telefono.TabIndex = 6
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(120, 54)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_usuario.Properties.Appearance.Options.UseBackColor = True
        Me.txt_usuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_usuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usuario.Properties.ReadOnly = True
        Me.txt_usuario.Size = New System.Drawing.Size(201, 22)
        Me.txt_usuario.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(166, 26)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_nombre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txt_nombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Properties.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(155, 22)
        Me.txt_nombre.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(368, 57)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Direccion"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(368, 29)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Telefono:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Usuario:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre Completo:"
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_agregar.Location = New System.Drawing.Point(354, 270)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(96, 28)
        Me.btn_agregar.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_total_registros)
        Me.GroupBox3.Controls.Add(Me.SimpleButton2)
        Me.GroupBox3.Controls.Add(Me.SimpleButton1)
        Me.GroupBox3.Controls.Add(Me.grid_permisos_asignados)
        Me.GroupBox3.Location = New System.Drawing.Point(479, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(647, 429)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permisos Asignados"
        '
        'lbl_total_registros
        '
        Me.lbl_total_registros.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_registros.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_registros.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_registros.Location = New System.Drawing.Point(264, 318)
        Me.lbl_total_registros.Name = "lbl_total_registros"
        Me.lbl_total_registros.Size = New System.Drawing.Size(361, 16)
        Me.lbl_total_registros.TabIndex = 84
        Me.lbl_total_registros.Text = "Registros recuperados: 1000"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(522, 374)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(399, 374)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 35)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Confirmar"
        '
        'btn_quitar
        '
        Me.btn_quitar.Image = CType(resources.GetObject("btn_quitar.Image"), System.Drawing.Image)
        Me.btn_quitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_quitar.Location = New System.Drawing.Point(354, 304)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(96, 28)
        Me.btn_quitar.TabIndex = 3
        '
        'frm_permisos_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 592)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_permisos_usuarios"
        Me.Text = "<<Asignacion de Permisos a Usuarios>>"
        CType(Me.grid_permisos_asignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lst_permisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_id_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_direccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_usuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_permisos_asignados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lst_permisos As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_agregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_direccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_usuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id_permiso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_permiso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_id_usuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_quitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbl_total_registros As DevExpress.XtraEditors.LabelControl
End Class
