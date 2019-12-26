Public Class frm_items_liquidacion_mano_obra

    Private liquidacion As New func_liquidacion_mano_obra()
    Private dt_liquidacion As New DataTable()
    Dim dt_items_liquidacion As New DataTable
    Private util As New utilidades()
    Private TITULO_MSJ As String = "<Detalles de Liquidacion>"
    Public CONDICION_SQL As String = ""
    Public EXISTE_LIQUIDACION As Boolean = False

    'Variables para las operaciones sobre la tabla liquidaciones_mano_obra
    Public ID_LIQUIDACION As Integer = 0
    Private ID_USUARIO As Integer = 0
    Public ID_EMPLEADO As Integer = 0
    Public EMPLEADO As String = ""
    Private ID_ASIGNACION As Integer = 0

    'Variables para las operaciones sobre la tabla items_liquidaciones
    Private CANTIDAD As Double = 0
    Private ID_PEDIDO As Integer = 0
    Private TOTAL_UNITARIO As Integer = 0
    Private TOTAL As Integer = 0
    Private PAGADO As Boolean = False
    Private PAGO_EXTRA As Integer = 0

    Private Sub frm_items_liquidacion_mano_obra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub crear_cursor()
        dt_items_liquidacion = New DataTable
        dt_items_liquidacion.Columns.Add("articulo")
        dt_items_liquidacion.Columns.Add("cantidad", GetType(Double))
        dt_items_liquidacion.Columns.Add("mano_obra")
        dt_items_liquidacion.Columns.Add("total")
        dt_items_liquidacion.Columns.Add("liquidar")
        dt_items_liquidacion.Columns.Add("id_asignacion_pedido_empleado")
        dt_items_liquidacion.Columns.Add("pedido")
        dt_items_liquidacion.Columns.Add("id_pedido")
        dt_items_liquidacion.Columns.Add("pago_extra")
        dt_items_liquidacion.Columns.Add("nuevo")
        dt_items_liquidacion.Columns.Add("fecha_pedido")

        grid_items.DataSource = dt_items_liquidacion
    End Sub

    Public Sub obtener_total()
        TOTAL = 0
        For i As Integer = 0 To GridView1.RowCount() - 1
            If CBool(GridView1.GetRowCellValue(i, "liquidar")) = True Then
                TOTAL = TOTAL + CInt(GridView1.GetRowCellValue(i, "total"))
            End If
        Next
        txt_total.Text = CStr(TOTAL)
    End Sub

    Private Sub obtener_cantidad()
        CANTIDAD = 0
        For i As Integer = 0 To GridView1.RowCount() - 1
            If CBool(GridView1.GetRowCellValue(i, "liquidar")) = True Then
                CANTIDAD = CANTIDAD + CInt(GridView1.GetRowCellValue(i, "cantidad"))
            End If
        Next
    End Sub

    Public Sub obtener_liquidacion(ByVal id As Integer)
        txt_fecha.Text = util.fecha()

        Dim dt As New DataTable
        dt = liquidacion.consultar("SELECT id_empleado, CONCAT(nombres,' ',apellidos) FROM empleados WHERE id_empleado=" + id.ToString + "")
        txt_id_empleado.Text = CStr(dt.Rows(0).Item(0))
        txt_empleado.Text = CStr(dt.Rows(0).Item(1))

        If obtener_items_liquidacion() = False Then
            Return
        End If

        obtener_total()
        obtener_cantidad()
    End Sub

    Private Function obtener_items_liquidacion() As Boolean
        crear_cursor()
        Dim sql As String = "SELECT a.id_asignacion_pedido_empleado, p.numero AS pedido, ar.nombre AS articulo, 
                                    a.cantidad_asignada AS cantidad, COALESCE(a.mano_obra,0) AS mano_obra, COALESCE(a.pago_extra,0) AS pago_extra, 
                                    COALESCE((a.mano_obra + a.pago_extra) * a.cantidad_asignada,0) AS total, 
                                    COALESCE(a.pagado, false) AS liquidar, p.id_pedido, false AS nuevo, p.fecha_pedido,p.recepcionado
                                    FROM asignacion_pedido_empleado a
                                    LEFT JOIN empleados e ON e.id_empleado = a.id_empleado
                                    LEFT JOIN pedidos p ON p.id_pedido = a.id_pedido 
                                    LEFT JOIN articulos ar ON ar.id_articulo = p.id_articulo " + CONDICION_SQL

        dt_items_liquidacion = liquidacion.consultar(sql)

        grid_items.DataSource = dt_items_liquidacion
        ID_EMPLEADO = CInt(txt_id_empleado.Text)
        If dt_items_liquidacion.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub add_item_liquidacion(ByVal id As Integer)
        Dim dt_material As New DataTable()
        dt_material = liquidacion.consultar("SELECT a.id_asignacion_pedido_empleado, p.numero AS pedido, ar.nombre as articulo , a.cantidad_asignada AS cantidad, 
                                    COALESCE(a.mano_obra,0) AS mano_obra, COALESCE(a.pago_extra,0) AS pago_extra, 
                                    COALESCE((a.mano_obra + a.pago_extra) * a.cantidad_asignada,0) AS total, 
                                    COALESCE(a.pagado, true) AS liquidar, p.id_pedido, p.fecha_pedido
                                    FROM asignacion_pedido_empleado a
                                    INNER JOIN empleados e ON e.id_empleado = a.id_empleado
                                    INNER JOIN pedidos p ON p.id_pedido = a.id_pedido
                                    INNER JOIN articulos ar ON ar.id_articulo = p.id_articulo
				                    WHERE a.id_asignacion_pedido_empleado = " + id.ToString + " AND a.pagado = false")

        If dt_material.Rows().Count() <> 0 Then

            For Each dr As DataRow In dt_items_liquidacion.Rows
                If dr("id_asignacion_pedido_empleado").ToString = dt_material.Rows(0).Item(0).ToString Then
                    util.mensajes("El pedido ya esta asignado a la Liquidacion", TITULO_MSJ, "WAR")
                    Return
                End If
            Next

            Dim newRow As DataRow = (TryCast(grid_items.DataSource, DataTable)).NewRow()
            newRow("id_asignacion_pedido_empleado") = dt_material.Rows(0).Item(0)
            newRow("pedido") = dt_material.Rows(0).Item(1)
            newRow("articulo") = dt_material.Rows(0).Item(2)
            newRow("cantidad") = dt_material.Rows(0).Item(3)
            newRow("mano_obra") = dt_material.Rows(0).Item(4)
            newRow("pago_extra") = dt_material.Rows(0).Item(5)
            newRow("total") = dt_material.Rows(0).Item(6)
            newRow("liquidar") = False
            newRow("id_pedido") = dt_material.Rows(0).Item(8)
            newRow("nuevo") = True
            newRow("fecha_pedido") = dt_material.Rows(0).Item(9)
            TryCast(grid_items.DataSource, DataTable).Rows.Add(newRow)
            grid_items.RefreshDataSource()

            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
            GridView1.ShowEditor()

            obtener_total()
            obtener_cantidad()
        End If

    End Sub

    Private Function validar_liquidacion() As Boolean
        If EXISTE_LIQUIDACION = False Then
            Dim liquidacion As Integer = 0
            Dim dt As New DataTable
            dt = CType(grid_items.DataSource, DataTable)

            For Each dr As DataRow In dt.Rows()
                If IsDBNull(dr("liquidar")) Or CBool(dr("liquidar")) = False Then
                Else
                    liquidacion += 1
                End If
            Next

            Return liquidacion > 0
        Else
            Return True
        End If
    End Function

    Private Sub insertar_actualizar()
        ID_LIQUIDACION = CInt(txt_nro_liquidacion.Text)
        TOTAL = 0
        ID_USUARIO = frm_main.ID_USUARIO
        ID_EMPLEADO = CInt(txt_id_empleado.Text)

        If EXISTE_LIQUIDACION Then
            Dim nuevo As Boolean = False
            Dim dt As New DataTable
            dt = CType(grid_items.DataSource, DataTable)
            CANTIDAD = 0
            ID_PEDIDO = 0
            TOTAL = 0

            For i As Integer = 0 To GridView1.RowCount - 1
                ID_EMPLEADO = CInt(txt_id_empleado.Text)
                ID_PEDIDO = CInt(GridView1.GetRowCellValue(i, "id_pedido"))
                PAGADO = CBool(GridView1.GetRowCellValue(i, "liquidar"))
                nuevo = CBool(GridView1.GetRowCellValue(i, "nuevo"))
                PAGO_EXTRA = CInt(GridView1.GetRowCellValue(i, "pago_extra"))
                ID_ASIGNACION = CInt(GridView1.GetRowCellValue(i, "id_asignacion_pedido_empleado"))
                ID_LIQUIDACION = CInt(txt_nro_liquidacion.Text)

                If PAGADO Then
                    TOTAL += CInt(GridView1.GetRowCellValue(i, "total"))
                End If

                If IsDBNull(GridView1.GetRowCellValue(i, "cantidad")) Or CInt(GridView1.GetRowCellValue(i, "cantidad")) <= 0 Then
                    CANTIDAD = 0
                Else
                    CANTIDAD = CInt(GridView1.GetRowCellValue(i, "cantidad"))
                End If

                If IsDBNull(GridView1.GetRowCellValue(i, "total")) Or CInt(GridView1.GetRowCellValue(i, "total")) <= 0 Then
                    TOTAL = 0
                Else
                    TOTAL = CInt(GridView1.GetRowCellValue(i, "total"))
                End If

                If IsDBNull(GridView1.GetRowCellValue(i, "mano_obra")) Or CInt(GridView1.GetRowCellValue(i, "mano_obra")) <= 0 Then
                    TOTAL_UNITARIO = 0
                Else
                    TOTAL_UNITARIO = CInt(GridView1.GetRowCellValue(i, "mano_obra"))
                End If

                'Se insertan el nuevo items a liquidar
                If nuevo And PAGADO Then
                    If liquidacion.insertar_items_liquidacion_mano_obra(ID_LIQUIDACION, ID_EMPLEADO, CANTIDAD, ID_PEDIDO, TOTAL, TOTAL_UNITARIO, PAGADO, ID_ASIGNACION, PAGO_EXTRA) = False Then
                        util.mensajes("Items de Liquidacion no Registrados", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

                'Se actualiza el estado del registro de la tabla items_liquidacion
                If nuevo = False Then
                    If liquidacion.actualizar_items_liquidacion(PAGADO, ID_ASIGNACION) = False Then
                        util.mensajes("Items de liquidacion no actualizado" & CStr(ID_ASIGNACION), TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

                If PAGADO = False Then
                    ID_LIQUIDACION = 0
                End If

                'Se actualiza el estado del registro de la tabla asignacion_empleado_pedido
                If liquidacion.actualizar_estado_asignacion_pedido_empleado(PAGADO, ID_ASIGNACION, ID_LIQUIDACION) = False Then
                    util.mensajes("Estado de Asignacion Pedido-empleado no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
            Next

            'Se actualiza el total de la cabezera de liquidacion
            If liquidacion.actualizar_liquidacion(CInt(txt_total.Text), ID_LIQUIDACION) = False Then
                util.mensajes("Liquidacion no actualizada", TITULO_MSJ, "WAR")
                Return
            End If

            util.mensajes("Liquidacion Actualizada", TITULO_MSJ, "INF")
            obtener_items_liquidacion()
            EXISTE_LIQUIDACION = True
            frm_liquidacion_mano_obra.listar()
            btn_cancelar.Focus()
            Return
        End If


        If liquidacion.insertar_liquidacion_mano_obra(ID_LIQUIDACION, CInt(txt_total.Text), ID_USUARIO, CANTIDAD, ID_EMPLEADO) Then
            Dim dt As New DataTable
            dt = CType(grid_items.DataSource, DataTable)
            CANTIDAD = 0
            ID_PEDIDO = 0
            TOTAL = 0

            For i As Integer = 0 To GridView1.RowCount - 1
                ID_EMPLEADO = CInt(txt_id_empleado.Text)
                ID_PEDIDO = CInt(GridView1.GetRowCellValue(i, "id_pedido"))
                PAGADO = CBool(GridView1.GetRowCellValue(i, "liquidar"))
                PAGO_EXTRA = CInt(GridView1.GetRowCellValue(i, "pago_extra"))
                ID_ASIGNACION = CInt(GridView1.GetRowCellValue(i, "id_asignacion_pedido_empleado"))


                If IsDBNull(GridView1.GetRowCellValue(i, "cantidad")) Or CInt(GridView1.GetRowCellValue(i, "cantidad")) <= 0 Then
                    CANTIDAD = 0
                Else
                    CANTIDAD = CInt(GridView1.GetRowCellValue(i, "cantidad"))
                End If

                If IsDBNull(GridView1.GetRowCellValue(i, "total")) Or CInt(GridView1.GetRowCellValue(i, "total")) <= 0 Then
                    TOTAL = 0
                Else
                    TOTAL = CInt(GridView1.GetRowCellValue(i, "total"))
                End If

                If IsDBNull(GridView1.GetRowCellValue(i, "mano_obra")) Or CInt(GridView1.GetRowCellValue(i, "mano_obra")) <= 0 Then
                    TOTAL_UNITARIO = 0
                Else
                    TOTAL_UNITARIO = CInt(GridView1.GetRowCellValue(i, "mano_obra"))
                End If

                'Se insertan los items de liquidacion
                If PAGADO Then
                    If liquidacion.insertar_items_liquidacion_mano_obra(ID_LIQUIDACION, ID_EMPLEADO, CANTIDAD, ID_PEDIDO, TOTAL, TOTAL_UNITARIO, PAGADO, CInt(GridView1.GetRowCellValue(i, "id_asignacion_pedido_empleado")), PAGO_EXTRA) = False Then
                        util.mensajes("Items de Liquidacion no Registrados", TITULO_MSJ, "WAR")
                        Return
                    End If

                    'Se actualiza el estado del registro de la tabla asignacion_empleado_pedido
                    If liquidacion.actualizar_estado_asignacion_pedido_empleado(True, ID_ASIGNACION, CInt(txt_nro_liquidacion.Text)) = False Then
                        util.mensajes("Estado de Asignacion Pedido-empleado no actualizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

            Next

        Else
            util.mensajes("Liquidacion no Registrada", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Liquidacion de Registrada", TITULO_MSJ, "INF")
        CONDICION_SQL = "WHERE a.id_liquidacion=" + txt_nro_liquidacion.Text + " ORDER BY p.numero ASC"
        obtener_items_liquidacion()
        EXISTE_LIQUIDACION = True
        btn_registrar.Text = "Actualizar"
        btn_cancelar.Focus()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If GridView1.RowCount() <= 0 Then
            util.mensajes("Debe asignar items a la Liquidacion", TITULO_MSJ, "WAR")
            Return
        End If

        If validar_liquidacion() = False Then
            util.mensajes("Debe seleccionar liquidaciones para pago", TITULO_MSJ, "WAR")
            Return
        End If
        obtener_total()
        obtener_cantidad()
        insertar_actualizar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        
         If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            frm_liquidacion_mano_obra.MdiParent = frm_main
            frm_liquidacion_mano_obra.Show()
            Me.Close()
            frm_liquidacion_mano_obra.Focus()
        End If
        
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        If CBool(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "liquidar")) Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
        Else
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        GridView1.FocusedColumn = GridView1.VisibleColumns(5)
        GridView1.FocusedColumn = GridView1.VisibleColumns(6)
        obtener_total()
        obtener_cantidad()
    End Sub

    Private Sub btn_agregar_item_Click(sender As Object, e As EventArgs) Handles btn_agregar_item.Click
        Dim frm As New frm_vista_asignaciones
        frm.FRM_ACTIVO = "frm_items_liquidacion_mano_obra"
        frm.ID_EMPLEADO = txt_id_empleado.Text
        frm.Show()
    End Sub

End Class