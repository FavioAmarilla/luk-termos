Public Class frm_items_liquidacion_vendedores

    Private liquidacion As New func_liquidacion_vendedores
    Private dt_liquidacion As New DataTable
    Private dt_items_liquidacion As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Detalles de Liquidacion>"
    Public CONDICION_SQL As String = ""
    Public EXISTE_LIQUIDACION As Boolean = False

    'Variables para las operaciones sobre la tabla liquidaciones_mano_obra
    Public ID_LIQUIDACION As Integer = 0
    Private ID_USUARIO As Integer = 0
    Public ID_VENDEDOR As Integer = 0
    Public VENDEDOR As String = ""

    'Variables para las operaciones sobre la tabla items_liquidaciones
    Private ID_VENTA As Integer = 0
    Private TOTAL As Integer = 0
    Private PAGADO As Boolean = False

    Private Sub frm_items_liquidacion_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub crear_cursor()
        dt_items_liquidacion = New DataTable
        dt_items_liquidacion.Columns.Add("fecha_cre")
        dt_items_liquidacion.Columns.Add("venta")
        dt_items_liquidacion.Columns.Add("total_venta")
        dt_items_liquidacion.Columns.Add("comision")
        dt_items_liquidacion.Columns.Add("total")
        dt_items_liquidacion.Columns.Add("liquidar")
        dt_items_liquidacion.Columns.Add("id_venta")
        dt_items_liquidacion.Columns.Add("id_item_liquidacion")
        dt_items_liquidacion.Columns.Add("nuevo")

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

    Public Sub obtener_liquidacion(id As Integer, accion As String)
        txt_fecha.Text = util.fecha()

        Dim dt As New DataTable
        dt = liquidacion.consultar("SELECT id_vendedor, CONCAT(nombres,' ',apellidos) FROM vendedores WHERE id_vendedor=" + id.ToString + "")
        txt_id_vendedor.Text = CStr(dt.Rows(0).Item(0))
        txt_vendedor.Text = CStr(dt.Rows(0).Item(1))

        If obtener_items_liquidacion(accion) = False Then
            Return
        End If

        obtener_total()
    End Sub

    Private Function obtener_items_liquidacion(accion As String) As Boolean
        crear_cursor()
        If accion = "insert" Then
            dt_items_liquidacion = liquidacion.consultar("SELECT vta.fecha_venta AS fecha_cre, vta.numero AS venta, vta.total_venta, 
                                                            vta.comision_vendedor AS comision, vta.comision_vendedor AS total,
                                                            FALSE AS liquidar, vta.id_venta, 0 AS id_item_liquidacion, TRUE AS nuevo
                                                            FROM ventas vta
                                                            LEFT JOIN vendedores ven ON ven.id_vendedor = vta.id_vendedor " + CONDICION_SQL)
        End If

        If accion = "update" Then
            dt_items_liquidacion = liquidacion.consultar("Select vt.fecha_cre, vt.numero As venta, vt.total_venta, vt.comision_vendedor As comision, 
            vt.comision_vendedor AS total, it.pagado As liquidar, it.id_venta, it.id_item_liquidacion, False AS nuevo
                                                            From items_liquidacion_vendedores it
                                                            Left Join ventas vt On vt.id_venta = it.id_venta" + CONDICION_SQL)
        End If

        grid_items.DataSource = dt_items_liquidacion
        If dt_items_liquidacion.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub add_item_liquidacion(ByVal id As Integer)
        Dim dt_material As New DataTable()
        dt_material = liquidacion.consultar("SELECT fecha_cre, numero, total_venta, comision_vendedor, id_venta FROM ventas WHERE id_venta=" & id.ToString)

        If dt_material.Rows().Count() <> 0 Then

            For Each dr As DataRow In dt_items_liquidacion.Rows
                If dr("id_venta").ToString = dt_material.Rows(0).Item(0).ToString Then
                    util.mensajes("La venta ya esta asignada a la liquidacion", TITULO_MSJ, "WAR")
                    Return
                End If
            Next

            Dim newRow As DataRow = (TryCast(grid_items.DataSource, DataTable)).NewRow()

            newRow("fecha_cre") = dt_material.Rows(0).Item(0)
            newRow("venta") = dt_material.Rows(0).Item(1)
            newRow("total_venta") = dt_material.Rows(0).Item(2)
            newRow("comision") = dt_material.Rows(0).Item(3)
            newRow("total") = dt_material.Rows(0).Item(3)
            newRow("liquidar") = False
            newRow("id_venta") = dt_material.Rows(0).Item(4)
            newRow("id_item_liquidacion") = 0
            newRow("nuevo") = True

            TryCast(grid_items.DataSource, DataTable).Rows.Add(newRow)
            grid_items.RefreshDataSource()

            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
            GridView1.ShowEditor()

            obtener_total()
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
        TOTAL = 0
        ID_USUARIO = frm_main.ID_USUARIO
        ID_VENDEDOR = CInt(txt_id_vendedor.Text)
        ID_LIQUIDACION = CInt(txt_nro_liquidacion.Text)

        If EXISTE_LIQUIDACION Then
            Dim nuevo As Boolean = False
            Dim i As Integer = 0
            Dim dt As New DataTable
            dt = CType(grid_items.DataSource, DataTable)
            ID_VENTA = 0
            TOTAL = 0

            For Each dr As DataRow In dt.Rows()
                ID_VENTA = CInt(dr("id_venta"))
                PAGADO = CBool(GridView1.GetRowCellValue(i, "liquidar"))
                ID_LIQUIDACION = CInt(txt_nro_liquidacion.Text)
                nuevo = CBool(GridView1.GetRowCellValue(i, "nuevo"))

                If PAGADO Then
                    TOTAL += CInt(GridView1.GetRowCellValue(i, "total"))
                End If

                If IsDBNull(dr("total")) Or CInt(dr("total")) <= 0 Then
                    TOTAL = 0
                Else
                    TOTAL = CInt(dr("total"))
                End If


                'Se insertan el nuevo items a liquidar
                If nuevo And PAGADO Then
                    If liquidacion.insertar_items_liquidacion(ID_LIQUIDACION, ID_VENDEDOR, ID_VENTA, TOTAL, PAGADO) = False Then
                        util.mensajes("Items de Liquidacion no Registrado", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

                'Se actualiza el estado del registro de la tabla items_liquidacion
                If nuevo = False Then
                    If liquidacion.actualizar_items_liquidacion(PAGADO, CInt(GridView1.GetRowCellValue(i, "id_item_liquidacion"))) = False Then
                        util.mensajes("Items de liquidacion no actualizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

                'Se actualiza el total de la cabezera de liquidacion
                If liquidacion.actualizar_liquidacion(TOTAL, ID_LIQUIDACION) = False Then
                    util.mensajes("Liquidacion no actualizada", TITULO_MSJ, "WAR")
                    Return
                End If

                If PAGADO = False Then
                    ID_LIQUIDACION = 0
                End If
                If liquidacion.actualizar_estado_venta(PAGADO, ID_VENTA, ID_LIQUIDACION) = False Then
                    util.mensajes("Estado de Pedido no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
                i += 1
            Next

            util.mensajes("Liquidacion Actualizada", TITULO_MSJ, "INF")
            obtener_liquidacion(ID_VENDEDOR, "update")
            EXISTE_LIQUIDACION = True
            btn_registrar.Text = "Actualizar"
            frm_liquidacion_vendedores.listar()
            btn_cancelar.Focus()
            SendKeys.Send("{Enter}")
            Return
        End If


        If liquidacion.insertar_liquidacion(ID_LIQUIDACION, CInt(txt_total.Text), ID_USUARIO, ID_VENDEDOR) Then
            Dim i As Integer = 0
            Dim dt As New DataTable
            dt = CType(grid_items.DataSource, DataTable)
            ID_VENTA = 0
            TOTAL = 0

            For Each dr As DataRow In dt.Rows()
                ID_VENTA = CInt(dr("id_venta"))
                PAGADO = CBool(GridView1.GetRowCellValue(i, "liquidar"))
                ID_LIQUIDACION = CInt(txt_nro_liquidacion.Text)

                If IsDBNull(dr("total")) Or CInt(dr("total")) <= 0 Then
                    TOTAL = 0
                Else
                    TOTAL = CInt(dr("total"))
                End If

                If PAGADO Then
                    If liquidacion.insertar_items_liquidacion(ID_LIQUIDACION, ID_VENDEDOR, ID_VENTA, TOTAL, PAGADO) = False Then
                        util.mensajes("Items de Liquidacion no Registrado", TITULO_MSJ, "WAR")
                        Return
                    End If

                    If liquidacion.actualizar_estado_venta(True, ID_VENTA, ID_LIQUIDACION) = False Then
                        util.mensajes("Estado de pedido no actualizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If

                i += 1
            Next
        Else
            util.mensajes("Liquidacion no Registrada", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Liquidacion Registrada", TITULO_MSJ, "INF")
        obtener_liquidacion(ID_VENDEDOR, "update")
        EXISTE_LIQUIDACION = True
        btn_cancelar.Focus()
        SendKeys.Send("{Enter}")
        btn_cancelar.Focus()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        obtener_total()
        insertar_actualizar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            Me.Close()
            frm_liquidacion_vendedores.MdiParent = frm_main
            frm_liquidacion_vendedores.Show()
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        If CBool(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "liquidar")) Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)
        Else
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        GridView1.FocusedColumn = GridView1.VisibleColumns(4)
        GridView1.FocusedColumn = GridView1.VisibleColumns(5)
        obtener_total()
    End Sub

    Private Sub btn_agregar_item_Click(sender As Object, e As EventArgs) Handles btn_agregar_item.Click
        Dim frm As New frm_vista_ventas

        frm.FRM_ACTIVO = "frm_items_liquidacion_vendedores"
        frm.Show()
    End Sub

End Class