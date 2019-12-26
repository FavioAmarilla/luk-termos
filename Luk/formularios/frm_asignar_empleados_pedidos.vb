Public Class frm_asignar_empleados_pedidos

    Dim func_pedidos As New func_pedidos
    Dim func_asignacion As New func_asignacion_pedido_empleado
    Dim util As New utilidades
    Dim dt_empleados As New DataTable

    Dim titulo As String = "Asignacion de emp."
    Dim id_pedido As Integer = 0
    Dim mano_obra As Integer = 0
    Dim pago_extra As Integer = 0

    Private Sub frm_asignar_empleados_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_asignados()
    End Sub

    Public Sub set_id_pedido(id As Integer)
        id_pedido = id
    End Sub
    Public Sub set_mano_obra(mano_obra_val As Integer)
        mano_obra = mano_obra_val
    End Sub

    Public Sub set_pago_extra(pago_extra_val As Integer)
        pago_extra = pago_extra_val
    End Sub


    Sub get_asignados()
        Dim dt As New DataTable
        dt = func_asignacion.consultar("SELECT CONCAT(e.nombres,' ',e.apellidos) AS empleado, SUM(cantidad_asignada) 
                                        FROM asignacion_pedido_empleado ap
                                        LEFT JOIN empleados e ON e.id_empleado = ap.id_empleado 
                                        LEFT JOIN pedidos p ON p.id_pedido = ap.id_pedido
                                        WHERE p.estado='COSTEADO' AND COALESCE(p.recepcionado, FALSE)=FALSE
                                        GROUP BY  CONCAT(e.nombres,' ',e.apellidos)")

        If dt.Rows.Count > 0 Then
            txt_asignados.Text = "TRABAJOS EN PRODUCCION PENDIENTES DE ENTREGA:" & vbCrLf

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim empleado As String = CStr(dt.Rows(i).Item(0))
                Dim cantidad As String = CStr(dt.Rows(i).Item(1))

                txt_asignados.Text &= empleado & ":  " & cantidad & vbCrLf
            Next

            Dim alerta As New alerta
            alerta.Caption = "Cantidad Empleados Asignados"
            alerta.Text = txt_asignados.Text
            AlertControl1.Show(Me, alerta.Caption, alerta.Text, "")
        End If
    End Sub

    Public Sub get_pedido()
        Dim dt As New DataTable
        dt = func_pedidos.consultar("SELECT p.id_pedido, p.numero, p.fecha_pedido, COALESCE(p.cantidad, 0) FROM pedidos p WHERE p.id_pedido=" & id_pedido.ToString)

        If dt.Rows.Count > 0 Then
            txt_id_pedido.Text = CStr(dt.Rows(0).Item(0))
            txt_nro_pedido.Text = CStr(dt.Rows(0).Item(1))
            txt_fecha_pedi.Text = CStr(dt.Rows(0).Item(2))
            txt_cantidad.Text = CInt(dt.Rows(0).Item(3))
            get_asig_empleados(id_pedido)
        Else
            util.mensajes("Pedido no definido", titulo, "WAR")
            Close()
        End If
    End Sub

    Private Sub crear_cursor_asignacion()
        dt_empleados = New DataTable
        dt_empleados.Columns.Add("id_empleado")
        dt_empleados.Columns.Add("empleado")
        dt_empleados.Columns.Add("cantidad")
        dt_empleados.Columns.Add("id_asignacion_pedido_empleado")
        dt_empleados.Columns.Add("nuevo")

        grid_asignacion.DataSource = dt_empleados
        grid_asignacion.Focus()
    End Sub

    Private Sub get_asig_empleados(pedido As String)
        dt_empleados = func_pedidos.consultar("SELECT a.id_empleado, CONCAT(e.nombres,' ',e.apellidos) AS empleado, a.cantidad_asignada AS cantidad, 
                                   a.mano_obra, a.pago_extra, a.id_asignacion_pedido_empleado, false AS nuevo, 
                                   (a.mano_obra + a.pago_extra) *a.cantidad_asignada AS total
                                   FROM asignacion_pedido_empleado a
                                   INNER JOIN empleados e ON e.id_empleado = a.id_empleado 
                                   WHERE a.id_pedido=" + pedido + "")

        If dt_empleados.Rows.Count > 0 Then
            grid_asignacion.DataSource = dt_empleados
        Else
            crear_cursor_asignacion()
            GridView2.AddNewRow()
            GridView2.FocusedRowHandle = 0
            GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            GridView2.ShowEditor()
        End If
    End Sub

    Private Function validar_cantidad_limite(ByVal i As Integer) As Boolean
        Try
            eliminar_filas_vacias()
            Dim cantidad As Integer = 0

            For fila As Integer = 0 To GridView2.RowCount
                If IsDBNull(GridView2.GetRowCellValue(fila, "cantidad")) Then
                Else
                    cantidad += CInt(GridView2.GetRowCellValue(fila, "cantidad"))
                End If
            Next

            Return cantidad + i > CInt(Me.txt_cantidad.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function validar_cantidad_menor() As Boolean
        eliminar_filas_vacias()
        Dim cantidad As Double = 0

        For fila As Integer = 0 To GridView2.RowCount
            If IsDBNull(GridView2.GetRowCellValue(fila, "cantidad")) Then
            Else
                cantidad += CDbl(GridView2.GetRowCellValue(fila, "cantidad"))
            End If
        Next

        Return cantidad < CInt(txt_cantidad.Text)
    End Function

    Private Sub eliminar_filas_vacias()
        For i As Integer = 0 To GridView2.RowCount - 1
            If IsDBNull(GridView2.GetRowCellValue(i, "id_empleado")) Then
                GridView2.DeleteRow(i)
            End If
        Next
    End Sub


    Public Sub get_empleado(ByVal id As String)
        If validar_cantidad_limite(1) Then
            util.mensajes("Cantidad limite superada", titulo, "WAR")
            Return
        End If
        Dim dt As New DataTable
        dt = func_pedidos.consultar("SELECT id_empleado, CONCAT(nombres,', ',apellidos) AS empleado FROM empleados WHERE id_empleado = " + id + "")

        If dt.Rows().Count() <> 0 Then

            Dim newRow As DataRow = (TryCast(grid_asignacion.DataSource, DataTable)).NewRow()
            newRow("id_empleado") = dt.Rows(0).Item(0)
            newRow("empleado") = dt.Rows(0).Item(1)
            newRow("cantidad") = 1
            newRow("id_asignacion_pedido_empleado") = 0
            newRow("nuevo") = True
            TryCast(grid_asignacion.DataSource, DataTable).Rows.Add(newRow)
            grid_asignacion.RefreshDataSource()

            eliminar_filas_vacias()
            grid_asignacion.Focus()
        End If
    End Sub

    Sub insertar_asignacion()
        Dim id_empleado As Integer = 0
        Dim cantidad As Integer = 0
        If validar_cantidad_menor() Then
            util.mensajes("Cantidad no alcanzada", titulo, "WAR")
            Return
        End If

        If validar_cantidad_limite(0) Then
            util.mensajes("Cantidad limite superada", titulo, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", "Asignacion") = False Then
            Return
        End If

        func_asignacion.eliminarAsignacionPorPedido(id_pedido)

        For i As Integer = 0 To GridView2.RowCount - 1
            id_empleado = GridView2.GetRowCellValue(i, "id_empleado")
            cantidad = GridView2.GetRowCellValue(i, "cantidad")

            If func_asignacion.insertar(id_pedido, id_empleado, cantidad, False, mano_obra, pago_extra) = False Then
                util.mensajes("Asignacion no registrada: " & i, titulo, "WAR")
                Return
            End If
        Next

        util.mensajes("Asignacion registrada", titulo, "INF")
        Close()
    End Sub

    Private Sub rps_txt_empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_empleado.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If validar_cantidad_limite(1) Then
                util.mensajes("Cantidad limite superada", titulo, "WAR")
                Return
            End If

            frm_vista_empleados.FRM_ACTIVO = "frm_asignar_empleados_pedidos"
            frm_vista_empleados.Show()
        End If

        If e.KeyCode = Keys.Enter Then
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_empleado")) Then
                util.mensajes("Asigne empleado al pedido", titulo, "WAR")
                Return
            End If
            GridView2.FocusedColumn = GridView2.VisibleColumns(1)
            GridView2.ShowEditor()
        End If
        eliminar_filas_vacias()
    End Sub

    Private Sub rps_txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            GridView2.FocusedColumn = GridView2.VisibleColumns(1)
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Ingrese Cantidad asignada al empleado", titulo, "WAR")
                Return
            Else
                If validar_cantidad_limite(1) Then
                    util.mensajes("Cantidad limite superada", titulo, "WAR")
                    GridView2.FocusedColumn = GridView2.VisibleColumns(1)
                    Return
                Else
                    eliminar_filas_vacias()
                    GridView2.AddNewRow()
                    GridView2.ShowEditor()
                End If
            End If
        End If
    End Sub

    Private Sub btn_quitar_empleado_Click(sender As Object, e As EventArgs) Handles btn_quitar_empleado.Click
        If GridView2.RowCount <= 0 Then
            util.mensajes("No se encontraron items para eliminar", titulo, "WAR")
            Return
        End If

        Dim fila As Integer = GridView2.FocusedRowHandle
        If fila < 0 Then
            util.mensajes("Selccione Empleado a eliminar", titulo, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas eliminar el empleado", titulo) Then
            If IsDBNull(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_asignacion_pedido_empleado")) Then
                util.mensajes("No se encontrol asignacion de empleado", titulo, "WAR")
                Return
            End If
            func_asignacion.eliminar(CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_asignacion_pedido_empleado")))
            GridView2.DeleteRow(fila)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If validar_cantidad_limite(1) Then
            util.mensajes("Cantidad limite superada", titulo, "WAR")
            Return
        End If
        If GridView2.RowCount <= 0 Then
            crear_cursor_asignacion()
        End If
        GridView2.AddNewRow()
        grid_asignacion.Focus()
        GridView2.FocusedColumn = GridView2.VisibleColumns(0)
        GridView2.ShowEditor()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_asignacion()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then
            Close()
        End If
    End Sub


End Class