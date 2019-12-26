Public Class frm_usuarios
    Private usuario As New func_usuarios()
    Private util As New utilidades()
    Private dt_usuarios As New DataTable()

    Private TITULO_MSJ As String = "<<Definicion de Usuarios>"
    Private ID_USUARIO As Integer = 0
    Private NOMBRE_COMPLETO As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""
    Private CORREO As String = ""
    Private LOGIN As String = ""
    Private CLAVE As String = ""
    Private RPT_CLAVE As String = ""
    Private ACTIVO As Boolean = False

    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_telefono.Enabled = False
        txt_direccion.Enabled = False
        txt_ciudad.Enabled = False
        txt_correo.Enabled = False
        txt_login.Enabled = False
        txt_clave.Enabled = False
        txt_rpt_clave.Enabled = False
        chk_activo.Enabled = False
        btn_confirmar.Enabled = False
        btn_permisos.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        txt_telefono.Enabled = True
        txt_direccion.Enabled = True
        txt_ciudad.Enabled = True
        txt_correo.Enabled = True
        txt_login.Enabled = True
        txt_clave.Enabled = True
        txt_rpt_clave.Enabled = True
        chk_activo.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_telefono.Text = ""
        txt_direccion.Text = ""
        txt_ciudad.Text = ""
        txt_correo.Text = ""
        txt_login.Text = ""
        txt_clave.Text = ""
        txt_rpt_clave.Text = ""
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_usuarios = usuario.listar("SELECT * FROM usuarios ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_usuarios.DataSource = dt_usuarios
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE_COMPLETO = txt_nombre.Text
        TELEFONO = txt_telefono.Text
        DIRECCION = txt_direccion.Text
        CIUDAD = txt_ciudad.Text
        CORREO = txt_correo.Text
        LOGIN = txt_login.Text
        CLAVE = txt_clave.Text
        RPT_CLAVE = txt_rpt_clave.Text

        If NOMBRE_COMPLETO = "" Then
            util.mensajes("Ingrese nombre del usuario", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf TELEFONO = "" Then
            util.mensajes("Ingrese nro. de telefono de la empresa", TITULO_MSJ, "WAR")
            txt_telefono.Focus()
        ElseIf DIRECCION = "" Then
            util.mensajes("Ingrese direccion del usuario", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf LOGIN = "" Then
            util.mensajes("Ingrese login del usuario", TITULO_MSJ, "WAR")
            txt_login.Focus()
        ElseIf CLAVE = "" Then
            util.mensajes("Ingrese clave del usuario", TITULO_MSJ, "WAR")
            txt_clave.Focus()
        ElseIf CLAVE <> RPT_CLAVE Then
            util.mensajes("Las claves del usuario no coinciden", TITULO_MSJ, "WAR")
            txt_rpt_clave.Text = ""
            txt_rpt_clave.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_USUARIO < 1 Then
                    If usuario.insertar(NOMBRE_COMPLETO, TELEFONO, DIRECCION, CIUDAD, CORREO, LOGIN, CLAVE, ACTIVO) Then
                        util.mensajes("Usuario registrado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Usuario no registrado", TITULO_MSJ, "WAR")
                    End If
                End If

                If ID_USUARIO > 0 Then
                    If usuario.actualizar(NOMBRE_COMPLETO, TELEFONO, DIRECCION, CIUDAD, CORREO, LOGIN, CLAVE, ACTIVO, ID_USUARIO) Then
                        util.mensajes("Usuario actualizado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Usuario no actualizado", TITULO_MSJ, "WAR")
                    End If
                End If
                listar()
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            End If
        End If
    End Sub

    Private Sub cargar_fila(ByVal accion As String)
        Dim rowhandle As Integer = 0
        If accion = "up" Then
            rowhandle = GridView1.FocusedRowHandle() - 1
        End If
        If accion = "down" Then
            rowhandle = GridView1.FocusedRowHandle() + 1
        End If
        If accion = "enter" Then
            rowhandle = GridView1.FocusedRowHandle()
        End If

        If rowhandle >= 0 And rowhandle < GridView1.RowCount() Then
            ID_USUARIO = CInt(GridView1.GetRowCellValue(rowhandle, "id_usuario").ToString)
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre_completo").ToString
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString
            txt_correo.Text = GridView1.GetRowCellValue(rowhandle, "correo").ToString
            txt_login.Text = GridView1.GetRowCellValue(rowhandle, "login").ToString
            txt_clave.Text = GridView1.GetRowCellValue(rowhandle, "clave_acceso").ToString
            txt_rpt_clave.Text = GridView1.GetRowCellValue(rowhandle, "clave_acceso").ToString
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandle, "activo").ToString)

            habilitar()
            btn_permisos.Enabled = True
            btn_confirmar.Text = "Actualizar"
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_USUARIO = 0
        txt_nombre.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_usuarios_Click(sender As Object, e As EventArgs) Handles grid_usuarios.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_usuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_usuarios.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar_fila("enter")
        End If
        If e.KeyCode = Keys.Up Then
            cargar_fila("up")
        End If
        If e.KeyCode = Keys.Down Then
            cargar_fila("down")
        End If
    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked Then
            ACTIVO = True
        Else
            ACTIVO = False
        End If
    End Sub

    Private Sub btn_permisos_Click(sender As Object, e As EventArgs) Handles btn_permisos.Click
        If ID_USUARIO > 0 Then
            Dim frm As New frm_permisos_usuarios
            frm.MdiParent = frm_main
            frm.txt_id_usuario.Text = ID_USUARIO.ToString()
            frm.txt_nombre.Text = txt_nombre.Text
            frm.txt_usuario.Text = txt_login.Text
            frm.txt_telefono.Text = txt_telefono.Text
            frm.txt_direccion.Text = txt_direccion.Text
            frm.Show()
        Else
            util.mensajes("Seleccione un usuario para asignar los permisos", "<Definicion de Usuarios>", "WAR")
        End If
    End Sub
End Class