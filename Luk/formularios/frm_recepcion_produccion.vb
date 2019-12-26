Public Class frm_recepcion_produccion

    Private stock As New func_stock_articulos()
    Private movimiento As New func_movimientos_stock()
    Private util As New utilidades()
    Private dt_movim_items_stock As New DataTable
    Private dt_pedidos As New DataTable
    Private dt_transacciones As New DataTable
    Private dt_costeo_items As New DataTable
    Private Const TITULO_MSJ = "<Movimientos de Stock>"
    Private EXISTE_MOVIMIENTO As Boolean = False

    'Variables para las operaciones sobre la tabla <movimientos_stock>
    Private ID_MOVIMIENTO As Integer = 0
    Private ID_SUCURSAL As Integer = frm_main.ID_SUCURSAL
    Private SUCURSAL As String = frm_main.SUCURSAL
    Private FECHAS As Date = Nothing
    Private ID_USUARIO As Integer = frm_main.ID_USUARIO
    Private USUARIO As String = frm_main.LOGIN_USER
    Private ID_PEDIDO As Integer = 0
    Private NRO_PEDIDO As String = ""

    'Variables para las operaciones sobre la tabla <movim_items_stock>
    Private ID_MOVIM_ITEMS_STOCK As Integer = 0
    Private ID_TRANSACCION As Integer = 0
    Private TRANSACCION As String = ""
    Private ACCION As String = ""
    Private ID_MATERIAL As Integer = 0
    Private ID_MAT_PROVEEDOR As Integer = 0
    Private ID_ARTICULO As Integer = 0
    Private ID_ART_PROVEEDOR As Integer = 0
    Private MATERIAL As String = ""
    Private CANTIDAD As Double = 0
    Private CANTIDAD_TOTAL As Double = 0
    Private COSTO_UNITARIO As Integer = 0
    Private COSTO_TOTAL As Integer = 0
    Private ID_COSTEO_ITEM As Integer = 0
    Private PRECIO_VENTA As Integer = 0
    Private CONTROLAR_STOCK As Boolean = False

    Private Sub frm_movimientos_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        'Detalles de Recepcion
        txt_id_pedido.Enabled = False
        txt_nro_pedido.Enabled = False
        btn_pedidos.Enabled = False
        txt_id_sucursal.Enabled = False
        txt_sucursal.Enabled = False
        btn_buscar_sucursal.Enabled = False
        txt_fecha.Enabled = False =
        txt_id_transaccion.Enabled = False
        txt_transaccion.Enabled = False

        'Detalles de Articulo
        txt_id_articulo.Enabled = False
        txt_articulo.Enabled = False
        txt_cantidad_articulo.Enabled = False
        txt_costo_unit_articulo.Enabled = False
        txt_costo_total_articulo.Enabled = False

        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        'Detalles de Recepcion
        txt_id_pedido.Enabled = True
        txt_nro_pedido.Enabled = True
        btn_pedidos.Enabled = True
        txt_id_sucursal.Enabled = True
        txt_sucursal.Enabled = True
        btn_buscar_sucursal.Enabled = True
        txt_fecha.Enabled = True
        txt_id_transaccion.Enabled = True
        txt_transaccion.Enabled = True

        'Detalles de Articulo
        txt_id_articulo.Enabled = True
        txt_articulo.Enabled = True
        txt_cantidad_articulo.Enabled = True
        txt_costo_unit_articulo.Enabled = True
        txt_costo_total_articulo.Enabled = True

        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        dt_movim_items_stock.Clear()
        dt_costeo_items.Clear()
        dt_pedidos.Clear()
        dt_transacciones.Clear()
        grid_movim_items_stock.DataSource = dt_movim_items_stock
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_fecha.Text = ""
        txt_id_pedido.Text = ""
        txt_nro_pedido.Text = ""
        txt_id_transaccion.Text = ""
        txt_transaccion.Text = ""
        txt_id_articulo.Text = ""
        txt_articulo.Text = ""
        txt_cantidad_articulo.Text = ""
        txt_costo_unit_articulo.Text = ""
        txt_costo_total_articulo.Text = ""
        txt_id_transaccion_art.Text = ""
        txt_transaccion_art.Text = ""
        btn_confirmar.Text = "Registrar"
        'Limpiamos las variables
        ID_MOVIMIENTO = 0
        ID_SUCURSAL = 0
        SUCURSAL = ""
        FECHAS = Nothing
        ID_USUARIO = 0
        USUARIO = ""
        ID_PEDIDO = 0
        NRO_PEDIDO = ""
        'Variables para las operaciones sobre la tabla <movim_items_stock>
        ID_MOVIM_ITEMS_STOCK = 0
        ID_TRANSACCION = 0
        TRANSACCION = ""
        ACCION = ""
        ID_MATERIAL = 0
        MATERIAL = ""
        CANTIDAD = 0
        COSTO_UNITARIO = 0
        COSTO_TOTAL = 0
        btn_nuevo.Focus()
    End Sub

    Public Sub obtener_pedido(id_ped As Integer)
        dt_pedidos.Clear()
        dt_pedidos = movimiento.consultar("SELECT p.id_pedido, p.numero, a.id_articulo, a.nombre AS articulo, p.cantidad,
                                            c.total_unitario, c.total_costo, COALESCE(c.id_movimiento_stock,0) AS id_movimiento_stock,
                                            a.codigo_barras, a.id_proveedor
                                            FROM pedidos p
                                            INNER JOIN articulos a ON a.id_articulo = p.id_articulo
                                            INNER JOIN costeo_de_pedido c ON c.id_pedido = p.id_pedido
                                            WHERE p.id_pedido =" + id_ped.ToString() + "")

        If dt_pedidos.Rows().Count() <> 0 Then
            txt_id_pedido.Text = CStr(dt_pedidos.Rows(0).Item(0))
            txt_nro_pedido.Text = CStr(dt_pedidos.Rows(0).Item(1))
            txt_id_articulo.Text = CStr(dt_pedidos.Rows(0).Item(2))
            txt_articulo.Text = CStr(dt_pedidos.Rows(0).Item(3))
            txt_cantidad_articulo.Text = CStr(dt_pedidos.Rows(0).Item(4))
            txt_costo_unit_articulo.Text = CStr(dt_pedidos.Rows(0).Item(5))
            txt_costo_total_articulo.Text = CStr(dt_pedidos.Rows(0).Item(6))
            ID_ART_PROVEEDOR = CInt(dt_pedidos.Rows(0).Item(9))

            If CInt(dt_pedidos.Rows(0).Item(7)) <= 0 Then
                EXISTE_MOVIMIENTO = False
            Else
                EXISTE_MOVIMIENTO = True
                ID_MOVIMIENTO = CInt(dt_pedidos.Rows(0).Item(7))
            End If

            obtener_transacciones("EP", "MP")
            obtener_transacciones("IP", "AR")
            obtener_costeo_items(CInt(txt_id_pedido.Text))
            txt_fecha.Text = Now.ToString("dd/MM/yyyy")
            txt_sucursal.Focus()
        Else
            util.mensajes("No se encontraron datos del Pedido", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub obtener_costeo_items(id_costeo As Integer)
        dt_costeo_items = movimiento.consultar("SELECT COALESCE(ci.id_movim_item_stock,0) AS id_movim_item_stock, ci.id_material, m.nombre AS material, 
                                               COALESCE(ci.cantidad, 0) AS cantidad_unit, COALESCE(ci.cantidad_articulo * ci.cantidad, 0) AS cantidad_total, 
                                               ci.costo_unitario AS costo_unit_material, ci.costo_final AS costo_total_material,  
                                               COALESCE(ci.id_costeo_item,0) AS id_costeo_item, COALESCE(m.controlar_stock, false) AS controlar_stock,
                                               COALESCE(ci.precio_venta, 0) AS precio_venta, COALESCE(ci.id_proveedor, 0) AS id_proveedor FROM costeo_item ci
                                               INNER JOIN costeo_de_pedido cp ON cp.id_costeo_de_pedido = ci.id_costeo_de_pedido 
                                               INNER JOIN materiales m ON m.id_material = ci.id_material
                                               WHERE cp.id_pedido = " + id_costeo.ToString() + "")

        grid_movim_items_stock.DataSource = dt_costeo_items
        btn_confirmar.Enabled = True
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = movimiento.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            util.mensajes("Sucursal no definida", TITULO_MSJ, "WAR")
            limpiar()
        End If
    End Sub

    Private Sub obtener_transacciones(rel As String, accion As String)
        dt_transacciones.Clear()
        dt_transacciones = movimiento.consultar("SELECT id_transaccion, nombre, accion FROM transacciones_stock WHERE relacion='" + rel + "'")

        If accion = "AR" Then
            If dt_transacciones.Rows().Count() <> 0 Then
                txt_id_transaccion_art.Text = CStr(dt_transacciones.Rows(0).Item(0))
                txt_transaccion_art.Text = CStr(dt_transacciones.Rows(0).Item(1))
                accion = CStr(dt_transacciones.Rows(0).Item(2))
                ID_TRANSACCION = CInt(dt_transacciones.Rows(0).Item(0))
            Else
                ID_TRANSACCION = 0
                util.mensajes("No se encuentran transacciones para Movimientos de Pedido", TITULO_MSJ, "ERR")
                limpiar()
            End If
        End If


        If accion = "MP" Then
            If dt_transacciones.Rows().Count() <> 0 Then
                txt_id_transaccion.Text = CStr(dt_transacciones.Rows(0).Item(0))
                txt_transaccion.Text = CStr(dt_transacciones.Rows(0).Item(1))
                accion = CStr(dt_transacciones.Rows(0).Item(2))
                ID_TRANSACCION = CInt(dt_transacciones.Rows(0).Item(0))
            Else
                ID_TRANSACCION = 0
                util.mensajes("No se encuentran transacciones para Movimientos de Pedido", TITULO_MSJ, "ERR")
                limpiar()
            End If
        End If

    End Sub

    Private Sub insertar_actualizar_movim_stock()
        ID_MOVIMIENTO = movimiento.id_movimiento_stock()

        If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            ID_SUCURSAL = CInt(txt_id_sucursal.Text)
        End If

        If txt_id_pedido.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Pedido", TITULO_MSJ, "WAR")
            txt_nro_pedido.Focus()
            Return
        Else
            ID_PEDIDO = CInt(txt_id_pedido.Text)
            NRO_PEDIDO = txt_nro_pedido.Text
        End If

        If txt_id_articulo.Text.Replace(" ", "") = "" Then
            util.mensajes("El pedido no contiene Articulo asignado", TITULO_MSJ, "WAR")
            txt_nro_pedido.Focus()
            Return
        Else
            ID_ARTICULO = CInt(txt_id_articulo.Text)
        End If

        If txt_transaccion.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar transaccion de Movimineto", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If movimiento.insertar_movimiento_stock(ID_MOVIMIENTO, ID_SUCURSAL, ID_USUARIO, ID_PEDIDO, NRO_PEDIDO, 0, 0) Then
            If movimiento.actualizar_movimiento_stock_costeo(ID_MOVIMIENTO, ID_PEDIDO) Then
                If movimiento.actualizar_recepcionado_pedido(True, ID_PEDIDO) Then
                    'Se realiza el movimiento de stock de los materiales
                    For i As Integer = 0 To GridView1.RowCount() - 1
                        ID_MOVIM_ITEMS_STOCK = movimiento.id_movim_items_stock()
                        ID_TRANSACCION = CInt(txt_id_transaccion.Text)
                        ID_MATERIAL = CInt(GridView1.GetRowCellValue(i, "id_material").ToString())
                        CANTIDAD = CDbl(GridView1.GetRowCellValue(i, "cantidad_total").ToString())
                        COSTO_UNITARIO = CInt(GridView1.GetRowCellValue(i, "costo_unit_material").ToString())
                        COSTO_TOTAL = CInt(GridView1.GetRowCellValue(i, "costo_total_material").ToString())
                        ID_COSTEO_ITEM = CInt(GridView1.GetRowCellValue(i, "id_costeo_item").ToString())
                        CONTROLAR_STOCK = CBool(GridView1.GetRowCellValue(i, "controlar_stock").ToString())
                        ID_MAT_PROVEEDOR = CInt(GridView1.GetRowCellValue(i, "id_proveedor").ToString())
                        PRECIO_VENTA = CInt(GridView1.GetRowCellValue(i, "precio_venta").ToString())

                        If CONTROLAR_STOCK Then
                            If insertar_actualizar_movim_items_stock(ID_MOVIMIENTO, ID_TRANSACCION, "EGRESO", ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, 0, PRECIO_VENTA, ID_MOVIM_ITEMS_STOCK, ID_MAT_PROVEEDOR) Then
                                If movimiento.actualizar_movim_item_stock_costeo(ID_COSTEO_ITEM, ID_MOVIM_ITEMS_STOCK) = False Then
                                    util.mensajes("Id Movim. Stock no actualizado en Costeo Items", TITULO_MSJ, "WAR")
                                    Return
                                End If
                            Else
                                util.mensajes("Item de Stock no Registrado", TITULO_MSJ, "WAR")
                                Return
                            End If
                        End If
                    Next

                    'Se realiza el movimiento de stock del articulo
                    ID_MOVIM_ITEMS_STOCK = movimiento.id_movim_items_stock()
                    ID_TRANSACCION = CInt(txt_id_transaccion_art.Text)
                    ID_MATERIAL = 0
                    CANTIDAD = CDbl(txt_cantidad_articulo.Text)
                    COSTO_UNITARIO = CInt(txt_costo_unit_articulo.Text)
                    COSTO_TOTAL = CInt(COSTO_UNITARIO * CANTIDAD)


                    If insertar_actualizar_movim_items_stock(ID_MOVIMIENTO, ID_TRANSACCION, "INGRESO", ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, CInt(txt_id_articulo.Text), PRECIO_VENTA, ID_MOVIM_ITEMS_STOCK, ID_ART_PROVEEDOR) Then
                        If movimiento.actualizar_movim_item_stock_costeo(ID_COSTEO_ITEM, ID_MOVIM_ITEMS_STOCK) = False Then
                            util.mensajes("Id Movim. Stock no actualizado en Costeo Items", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Else
                        util.mensajes("Item de Stock no Registrado", TITULO_MSJ, "WAR")
                        Return
                    End If

                Else
                    util.mensajes("Id Movim. Stock no actualizado en Costeo Pedido", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                util.mensajes("Pedido Recepcionado no actualizado", TITULO_MSJ, "WAR")
                Return
            End If
        Else
            util.mensajes("Movimiento de Stock no Registrado", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Recepcion de produccion registrado", TITULO_MSJ, "INF")
        limpiar()
    End Sub

    Private Function insertar_actualizar_movim_items_stock(id_movimiento As Integer, id_transaccion As Integer,
                                               accion As String, id_material As Integer,
                                               cantidad_unit As Double, costo_unitario As Integer,
                                               costo_total As Integer, id_articulo As Integer,
                                               precio_unitario As Integer, id_movim_item_stock As Integer, id_proveedor As Integer) As Boolean
        Dim respuesta As Boolean = False
        Dim campo As String = ""
        Dim id_item As Integer = 0

        If movimiento.insertar_movim_item_stock(id_movimiento, id_transaccion, accion, id_material, cantidad_unit, costo_unitario, costo_total, id_articulo, precio_unitario, id_movim_item_stock, id_proveedor) Then
            respuesta = True
        Else
            respuesta = False
        End If

        If id_articulo > 0 Then
            campo = "articulo"
            id_item = id_articulo
        End If

        If id_material > 0 Then
            campo = "material"
            id_item = id_material
        End If

        If accion = "INGRESO" Then
            If stock.validar_stock(id_item, campo, CInt(txt_id_sucursal.Text)) Then
                If stock.aumentar_stock(id_item, CANTIDAD, campo, CInt(txt_id_sucursal.Text)) = False Then
                    util.mensajes("Stock no Actualizado", TITULO_MSJ, "WAR")
                    respuesta = False
                End If
            Else
                If campo = "articulo" Then
                    If stock.insertar(id_item, CANTIDAD, 0, costo_unitario, precio_unitario, 0, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock de articulo no registrado", TITULO_MSJ, "WAR")
                        respuesta = False
                    End If
                End If
                If campo = "material" Then
                    If stock.insertar(0, CANTIDAD, 0, costo_unitario, precio_unitario, id_item, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock de materia prima no registrado", TITULO_MSJ, "WAR")
                        respuesta = False
                    End If
                End If
            End If
            respuesta = True
        End If

        If accion = "EGRESO" Then
            If stock.validar_stock(id_item, campo, CInt(txt_id_sucursal.Text)) Then
                If stock.disminuir_stock(id_item, CANTIDAD, campo, CInt(txt_id_sucursal.Text)) = False Then
                    util.mensajes("Stock no Actualizado", TITULO_MSJ, "WAR")
                    respuesta = False
                End If
            Else
                If campo = "articulo" Then
                    If stock.insertar(id_item, CANTIDAD, 0, costo_unitario, precio_unitario, 0, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock de articulo no registrado", TITULO_MSJ, "WAR")
                        respuesta = False
                    End If
                End If
                If campo = "material" Then
                    If stock.insertar(0, CANTIDAD, 0, costo_unitario, precio_unitario, id_item, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock de materia prima no registrado", TITULO_MSJ, "WAR")
                        respuesta = False
                    End If
                End If
            End If
            respuesta = True
        End If

        Return respuesta
    End Function

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_vista_pedidos()
        frm.FRM_ACTIVO = "frm_movimientos_stock"
        frm.CONDICION_SQL = " WHERE estado = 'COSTEADO' AND recepcionado IS NULL AND usr_anulacion IS NULL"
        frm.Show()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        obtener_transacciones("EP", "MP")
        If ID_TRANSACCION = 0 Then
            util.mensajes("Transaccion de Stock de Materia Prima no definido", TITULO_MSJ, "ERR")
            Return
        End If
        obtener_transacciones("IP", "AR")
        If ID_TRANSACCION = 0 Then
            util.mensajes("Transaccion de Stock de Articulo no definido", TITULO_MSJ, "ERR")
            Return
        End If

        insertar_actualizar_movim_stock()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click 
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
            lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
        End If
    End Sub

    Private Sub cbo_transaccion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            grid_movim_items_stock.Focus()
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_recepcion_produccion"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            Else
                btn_confirmar.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_recepcion_produccion"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
    End Sub

    Private Sub txt_nro_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_pedido.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_pedidos()
            frm.FRM_ACTIVO = "frm_movimientos_stock"
            frm.CONDICION_SQL = " WHERE estado = 'COSTEADO' AND recepcionado IS NULL AND usr_anulacion IS NULL AND enviado_produccion=TRUE"
            frm.Show()
        End If
    End Sub

    Private Sub btn_pedidos_Click_1(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Dim frm As New frm_vista_pedidos()
        frm.FRM_ACTIVO = "frm_movimientos_stock"
        frm.CONDICION_SQL = " WHERE estado = 'COSTEADO' AND recepcionado IS NULL AND usr_anulacion IS NULL AND enviado_produccion=TRUE"
        frm.Show()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitar()
        limpiar()
        txt_nro_pedido.Focus()
    End Sub

End Class