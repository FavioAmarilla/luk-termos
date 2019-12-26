Public Class frm_permisos_usuarios

    Private permiso As New func_permisos
    Private dt_permisos As New DataTable
    Private dt_permisos_usuario As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Permisos de usuario>"
    Private EXISTE_PERMISOS As Boolean = False

    Private ID_USUARIO As Integer = 0
    Private ID_PERMISO As Integer = 0

    Private Sub frm_permisos_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crear_cursor()
        obtener_permisos_usuario(txt_id_usuario.Text)
        obtener_permisos()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub obtener_permisos()
        Dim dt As New DataTable
        dt = permiso.consultar("SELECT nombre FROM permisos ORDER BY nombre ASC")

        If dt.Rows().Count() <= 0 Then
            util.mensajes("Permisos no definidos", TITULO_MSJ, "WAR")
            Return
        End If

        For i As Integer = 0 To dt.Rows().Count() - 1
            If validar_permiso(dt.Rows(i).Item(0).ToString()) Then
                lst_permisos.Items.Add(dt.Rows(i).Item(0))
            End If
        Next

        If GridView1.RowCount() <= 0 Then
            EXISTE_PERMISOS = False
        Else
            EXISTE_PERMISOS = True
        End If
    End Sub

    Private Function validar_permiso(ByVal permiso As String) As Boolean
        For i As Integer = 0 To GridView1.RowCount() - 1
            If CStr(GridView1.GetRowCellValue(i, "permiso")) = permiso Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub crear_cursor()
        dt_permisos_usuario = New DataTable
        dt_permisos_usuario.Columns.Add("usuario")
        dt_permisos_usuario.Columns.Add("id_permiso")
        dt_permisos_usuario.Columns.Add("permiso")

        grid_permisos_asignados.DataSource = dt_permisos_usuario
    End Sub

    Public Sub add_permiso(ByVal nom As String)
        Dim dt As New DataTable
        dt = permiso.consultar("SELECT id_permiso, nombre FROM permisos WHERE nombre = '" + nom + "'")

        If dt.Rows().Count() <> 0 Then
            Dim newRow As DataRow = (TryCast(grid_permisos_asignados.DataSource, DataTable)).NewRow()
            newRow("usuario") = txt_nombre.Text
            newRow("id_permiso") = dt.Rows(0).Item(0)
            newRow("permiso") = dt.Rows(0).Item(1)

            For i As Integer = 0 To GridView1.RowCount() - 1
                If CInt(GridView1.GetRowCellValue(i, "id_permiso")) = CInt(newRow("id_permiso")) Then
                    util.mensajes("El permiso ya esta asignado al usuario", TITULO_MSJ, "WAR")
                    Return
                End If
            Next

            TryCast(grid_permisos_asignados.DataSource, DataTable).Rows.Add(newRow)
            grid_permisos_asignados.RefreshDataSource()
            lst_permisos.Items.RemoveAt(lst_permisos.SelectedIndex())

        End If
    End Sub

    Public Sub obtener_permisos_usuario(ByVal id_user As String)
        dt_permisos_usuario = permiso.consultar("SELECT u.id_permiso, p.nombre AS permiso, '" + txt_nombre.Text + "' AS usuario 
                                                 FROM permisos_usuario u
                                                 INNER JOIN permisos p ON p.id_permiso = u.id_permiso
                                                 WHERE u.id_usuario = '" + id_user + "' ORDER BY p.nombre ASC")

        If dt_permisos_usuario.Rows().Count() <> 0 Then
            grid_permisos_asignados.DataSource = dt_permisos_usuario
        End If
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_permisos_usuario.Rows()
            If IsDBNull(dr("id_permiso")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_permisos_usuario.Rows.Remove(dr)
        Next
    End Sub

    Private Sub insertar_actualizar()
        If GridView1.RowCount() <= 0 Then
            util.mensajes("Debe asignar permisos al Usuario", TITULO_MSJ, "WAR")
            Return
        End If

        If CInt(txt_id_usuario.Text) <= 0 Or txt_id_usuario.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar un usuario para asignar los permisos", TITULO_MSJ, "WAR")
            Return
        End If

        If ID_USUARIO = frm_main.ID_USUARIO Then
            If util.msj_confirmacion("El sistema de cerrara al confirmar, para actualizar sus datos" + Chr(13) + "               Deseas Confirmar la operacion", TITULO_MSJ) = False Then
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
                Return
            End If
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        If EXISTE_PERMISOS = False Then
            For i As Integer = 0 To GridView1.RowCount() - 1
                If permiso.insertar_permisos_usuario(CInt(GridView1.GetRowCellValue(i, "id_permiso")), CInt(txt_id_usuario.Text)) = False Then
                    util.mensajes("Permisos de Usuario no Registrados: " + i.ToString(), TITULO_MSJ, "WAR")
                End If
            Next
            util.mensajes("Permisos Registrados", TITULO_MSJ, "INF")
        End If

        If EXISTE_PERMISOS Then
            If permiso.eliminar_permisos_usuario(CInt(txt_id_usuario.Text)) Then
                For i As Integer = 0 To GridView1.RowCount() - 1
                    If permiso.insertar_permisos_usuario(CInt(GridView1.GetRowCellValue(i, "id_permiso")), CInt(txt_id_usuario.Text)) = False Then
                        util.mensajes("Permisos de Usuario no Actualizados: " + i.ToString(), TITULO_MSJ, "WAR")
                    End If
                Next
                util.mensajes("Permisos Actualizados, cierre sesion", TITULO_MSJ, "INF")
            End If
        End If

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If lst_permisos.Items.Count() > 0 Then
            Dim str As String = ""
            str = lst_permisos.SelectedItem.ToString()
            add_permiso(str)
        End If
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If util.msj_confirmacion("Deseas quitar el permiso", TITULO_MSJ) Then
            lst_permisos.Items.Add(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "permiso"))
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_agregar_todos_Click(sender As Object, e As EventArgs)
        If util.msj_confirmacion("Deseas agregar todos los permisos al usuario", TITULO_MSJ) = False Then
            util.mensajes("Permisos no asignados al usuario", TITULO_MSJ, "WAR")
            Return
        End If

        For i As Integer = 0 To lst_permisos.ItemCount()
            Dim str As String = ""
            str = lst_permisos.SelectedItem.ToString()
            add_permiso(str)
            lst_permisos.Items.RemoveAt(i)
        Next
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class