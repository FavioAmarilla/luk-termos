Imports System.IO
Imports System.Threading

Public Class frm_ventas

    Private venta As New func_ventas
    Private movim As New func_movimientos_stock
    Private stock As New func_stock_articulos
    Private util As New utilidades
    Private dt_items_venta As New DataTable
    Private dt_condiciones_venta As New DataTable
    Private TITULO_MSJ As String = "<Punto de Ventas>"

    'Variables para las operaciones sobre la tabla ventas
    Friend Shared ID_VENTA As Integer = 0
    Friend Shared TOTAL_VENTA As Integer = 0
    Private GRAVADO5 As Integer = 0
    Private GRAVADO10 As Integer = 0
    Private GRAVADOS As Integer = 0
    Private IMPUESTO5 As Integer = 0
    Private IMPUESTO10 As Integer = 0
    Private IMPUESTO As Integer = 0
    Private EXENTAS As Integer = 0
    Private NUMERO As String = ""
    Private NRO_COMPROBANTE As Integer = 0
    Public ID_CLIENTE As Integer = 0
    Friend Shared ID_CONTROL_CAJA As Integer = 0
    Friend Shared ID_PEDIDO As Integer = 0
    Private FACTURA As Boolean = False
    Private ID_CONDICION_VENTA As Integer = 0
    Private ID_VENDEDOR As Integer = 0
    Private COSTO_TOTAL As Integer = 0
    Private TOTAL_RECIBO As Integer = 0

    'Variables para las operaciones sobre la tabla items_ventas
    Private IT_ID_ARTICULO As Integer = 0
    Private IT_ID_PROVEEDOR As Integer = 0
    Private IT_CANTIDAD As Integer = 0
    Private IT_COSTO_UNITARIO As Integer = 0
    Private IT_PRECIO_VENTA As Integer = 0
    Private IT_PORC_IMPUESTO As Integer = 0
    Private IT_TOTAL_ITEM As Integer = 0

    'Variables para los operaciones sobre la tabla movim_stock
    Private ID_MOVIMIENTO As Integer = 0
    Private ID_ITEM_MOVIM As Integer = 0
    Private ID_TRANSACCION As Integer = 0

    'Variables utiles
    Private IMAGEN As String = ""
    Private FACTURANDO As Boolean = False
    Private DEVOLUCION As Boolean = False
    Private CANTIDAD_ITEMS As Integer = 0
    Private ITEM_PEDIDO As Boolean = False
    Private PRECIO_VENTA_PEDIDO As Integer = 0
    Private trd_stock As Thread
    Private trd_comision_venta As Thread

    'Parametros del timbrado
    Private ID_TIMBRADO As Integer = 0
    Private NRO_INICIAL As Integer = 0
    Private NRO_FINAL As Integer = 0
    Private LONGITUD_NRO_COMPROB As Integer = 0

    Private COMISION_VENTA As Integer = 0

    Private Sub frm_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Public Sub set_comision(value As Integer)
        COMISION_VENTA = value
    End Sub

    Public Sub set_id_vendedor(value As Integer)
        ID_VENDEDOR = value
    End Sub

    Public Sub inicializar()
        'Se asigna el logo de la empresa
        If File.Exists(frm_main.IMG_LOGO_EMPRESA) Then
            Dim fs As FileStream
            fs = New FileStream(frm_main.IMG_LOGO_EMPRESA, FileMode.Open, FileAccess.Read)
            pct_logo_empresa.Image = Image.FromStream(fs)
            fs.Close()
        End If

        'Se asigna la imagen no disponible al articulo
        If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
            Dim fs As FileStream
            fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
            pct_img_articulo.Image = Image.FromStream(fs)
        End If

        'Se cargan las etiquetas de encabezado
        lbl_sucursal.Text = frm_main.SUCURSAL
        lbl_empresa.Text = frm_main.EMPRESA

        'Se cargan los campos del encabezado de ventas
        txt_fecha.Text = Now.ToString("dd/MM/yyyy")
        txt_usuario.Text = frm_main.NOMBRE_USER

        'Se establece los parametros de venta
        lbl_total.Text = "0"
        lbl_total_items.Text = "0"
        txt_numero.Text = ""
        txt_cliente.Text = ""
        lbl_modo_venta.Text = "Normal"
        cbo_condicion.SelectedIndex = -1

        ID_VENTA = 0
        ID_CLIENTE = 0
        TOTAL_VENTA = 0
        GRAVADO5 = 0
        GRAVADO10 = 0
        GRAVADOS = 0
        IMPUESTO5 = 0
        IMPUESTO10 = 0
        IMPUESTO = 0
        EXENTAS = 0
        CANTIDAD_ITEMS = 0

        FACTURANDO = False
        DEVOLUCION = False
        ITEM_PEDIDO = False

        obtener_timbrado()
        obtener_condiciones_venta()
        grid_items.DataSource = Nothing

        txt_numero.Focus()
    End Sub

    Private Function obtener_timbrado() As Boolean
        Dim dt As New DataTable
        dt = venta.consultar("SELECT id_timbrado, nro_inicial, nro_final, longitud_nro_comprob FROM timbrados 
                             WHERE fecha_hasta >= '" + Now.ToString("dd/MM/yyyy") + "' AND activo=true")

        If dt.Rows.Count > 0 Then
            ID_TIMBRADO = CInt(dt.Rows(0).Item(0))
            NRO_INICIAL = CInt(dt.Rows(0).Item(1))
            NRO_FINAL = CInt(dt.Rows(0).Item(2))
            LONGITUD_NRO_COMPROB = CInt(dt.Rows(0).Item(3))
            Return True
        Else
            util.mensajes("Timbrado no definido", TITULO_MSJ, "WAR")
            Return False
        End If
    End Function

    Private Sub crear_cursor()
        dt_items_venta = New DataTable

        dt_items_venta.Columns.Add("id_articulo")
        dt_items_venta.Columns.Add("codigo_barras")
        dt_items_venta.Columns.Add("descripcion")
        dt_items_venta.Columns.Add("precio_unitario")
        dt_items_venta.Columns.Add("cantidad", GetType(Double))
        dt_items_venta.Columns.Add("total")
        dt_items_venta.Columns.Add("costo_unitario")
        dt_items_venta.Columns.Add("id_pedido")
        dt_items_venta.Columns.Add("id_item")
        dt_items_venta.Columns.Add("id_proveedor")

        grid_items.DataSource = dt_items_venta
    End Sub

    Private Sub modulos(accion As String)

        'Pedidos
        If accion = "F4" Then
            Dim frm As New frm_vista_pedidos
            frm.CONDICION_SQL = " WHERE p.recepcionado=true AND p.estado='COSTEADO' AND COALESCE(facturado, false) = false"
            frm.FRM_ACTIVO = "frm_ventas"
            frm.GridView1.Columns(3).Visible = False
            frm.Show()
        End If

        'Precios
        If accion = "F5" Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_ventas"
            frm.OCULTAR_COLUMNA = "ST"
            frm.Show()
        End If

        'Devolucion de Articulos
        If accion = "F6" Then
            If CANTIDAD_ITEMS <= 0 Then
                util.mensajes("No se registraron items para eliminar", TITULO_MSJ, "WAR")
                Return
            End If
            If util.msj_confirmacion("Deseas eliminar el item", TITULO_MSJ) Then
                DEVOLUCION = True
                If eliminar_item() Then
                    util.mensajes("Item de Venta eliminado", TITULO_MSJ, "INF")
                Else
                    util.mensajes("Item de Venta no eliminado", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("Item de Venta no eliminado", TITULO_MSJ, "WAR")
            End If

        End If


        'Anular
        If accion = "F7" Then
            If CANTIDAD_ITEMS <= 0 Then
                util.mensajes("No se registraron items para Anulacion", TITULO_MSJ, "WAR")
                Return
            End If

            If util.msj_confirmacion("Deseas anular la venta", TITULO_MSJ) = False Then
                util.mensajes("Venta no Anulada", TITULO_MSJ, "WAR")
                Return
            End If

            If venta.anular_venta(frm_main.ID_USUARIO, ID_VENTA) Then
                util.mensajes("Venta Anulada", TITULO_MSJ, "INF")
                inicializar()
            Else
                util.mensajes("Venta no Anulada", TITULO_MSJ, "WAR")
            End If
        End If


        'Confirmar
        If accion = "F8" Then
            If CANTIDAD_ITEMS <= 0 Then
                util.mensajes("No se registraron items para Confirmar", TITULO_MSJ, "WAR")
                Return
            End If

            If txt_numero.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe inggresar numero del comprobante", TITULO_MSJ, "WAR")
                txt_numero.Focus()
                Return
            End If

            If ID_CONDICION_VENTA <= 0 Then
                util.mensajes("Debe inggresar condicion de venta", TITULO_MSJ, "WAR")
                cbo_condicion.Focus()
                Return
            End If

            If ID_CLIENTE <= 0 Then
                util.mensajes("Debe inggresar cliente", TITULO_MSJ, "WAR")
                txt_cliente.Focus()
                Return
            End If

            frm_cobros_caja.MdiParent = frm_main
            frm_cobros_caja.set_total_recibo(TOTAL_RECIBO)
            frm_cobros_caja.Show()
        End If


        'Extraccion
        If accion = "F9" Then
            Dim frm_extraccion As New frm_extraccion_efectivo
            frm_extraccion.Show()
        End If

        'Cerrar
        If accion = "ESC" Then
            If CANTIDAD_ITEMS > 0 Then
                util.mensajes("Venta en Proceso", TITULO_MSJ, "WAR")
                Return
            End If
            Close()
        End If
    End Sub

    Public Sub obtener_transaccion_stock()
        Dim dt As New DataTable
        dt = venta.consultar("SELECT id_transaccion FROM transacciones_stock WHERE relacion='VT'")

        If dt.Rows.Count > 0 Then
            ID_TRANSACCION = CInt(dt.Rows(0).Item(0))
        End If
    End Sub

    Private Function insertar_venta() As Boolean

        obtener_transaccion_stock()

        If ID_TRANSACCION <= 0 Then
            util.mensajes("Transaccion de Stock de Venta no definido", TITULO_MSJ, "WAR")
            Return False
        End If

        If ID_TIMBRADO <= 0 Then
            util.mensajes("Timbrado no definido", TITULO_MSJ, "WAR")
            Return False
        End If

        If ID_CLIENTE <= 0 Then
            util.mensajes("Debe seleccionar Cliente", TITULO_MSJ, "WAR")
            txt_cliente.Focus()
            Return False
        End If

        If ID_CONDICION_VENTA <= 0 Then
            util.mensajes("Debe seleccionar Condicion de Venta", TITULO_MSJ, "WAR")
            txt_cliente.Focus()
            Return False
        End If

        ID_VENTA = venta.id_venta()
        If txt_numero.Text.Replace(" ", "") = "" Then
            txt_numero.Text = ID_VENTA.ToString()
        End If
        NUMERO = txt_numero.Text

        asignacion_comprobante()

        If venta.insertar_venta(ID_VENTA, NUMERO.Replace(" ", ""), ID_CLIENTE, frm_main.ID_USUARIO, frm_main.ID_EMPRESA, frm_main.ID_SUCURSAL, ID_CONTROL_CAJA, ID_PEDIDO, FACTURA, ID_CONDICION_VENTA, ID_TIMBRADO, NRO_COMPROBANTE, ID_VENDEDOR) = False Then
            util.mensajes("Cabezera de Venta no registrada", TITULO_MSJ, "WAR")
            Return False
        End If

        FACTURANDO = True
        DEVOLUCION = False
        crear_cursor()

        Return True
    End Function

    Private Function insertar_item_venta() As Boolean
        dt_items_venta = venta.consultar("SELECT a.id_articulo, a.codigo_barras, a.nombre AS descripcion, COALESCE(a.precio_venta, 0) AS precio_unitario, 
                                        ti.valor, COALESCE(a.costo_unitario, 0), a.imagen, a.id_proveedor
                                        FROM articulos a
                                        INNER JOIN tipos_impuesto ti ON ti.id_tipo_impuesto = a.id_tipo_impuesto
                                        WHERE a.codigo_barras = '" + txt_codigo_barras.Text + "'")

        If dt_items_venta.Rows.Count > 0 Then
            'Se obtienen los datos 
            IT_ID_ARTICULO = CInt(dt_items_venta.Rows(0).Item(0))
            If ITEM_PEDIDO Then
                IT_PRECIO_VENTA = PRECIO_VENTA_PEDIDO
            Else
                IT_PRECIO_VENTA = CInt(dt_items_venta.Rows(0).Item(3))
                ITEM_PEDIDO = True
                ID_PEDIDO = 0
                PRECIO_VENTA_PEDIDO = 0
                ID_VENDEDOR = 0
                COMISION_VENTA = 0
            End If
            IT_CANTIDAD = CInt(txt_cantidad.Text)
            IT_TOTAL_ITEM = IT_PRECIO_VENTA * IT_CANTIDAD
            IT_PORC_IMPUESTO = CInt(dt_items_venta.Rows(0).Item(4))
            IT_COSTO_UNITARIO = CInt(dt_items_venta.Rows(0).Item(5))
            COSTO_TOTAL += IT_COSTO_UNITARIO * IT_CANTIDAD
            IMAGEN = CStr(dt_items_venta.Rows(0).Item(6))
            IT_ID_PROVEEDOR = CInt(dt_items_venta.Rows(0).Item(7))

            'Se valida que tenga precio de venta mayor a cero(0)
            If IT_PRECIO_VENTA <= 0 Then
                util.mensajes("Articulo no posee Precio de Venta", TITULO_MSJ, "WAR")
                Return False
            End If

            'Se valida que cantidad sea mayor a cero(0)
            If IT_CANTIDAD <= 0 Then
                util.mensajes("Cantidad debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                txt_cantidad.Focus()
                Return False
            End If

            'En caso de que sea una devolucion se convierten los valores a negativos
            If DEVOLUCION Then
                IT_CANTIDAD = IT_CANTIDAD * (-1)
                IT_TOTAL_ITEM = IT_TOTAL_ITEM * (-1)
                COSTO_TOTAL -= (IT_COSTO_UNITARIO * 2)
            End If

            'Se registra el item en la base de dato
            If venta.insertar_item_venta(ID_VENTA, IT_ID_ARTICULO, IT_CANTIDAD, IT_COSTO_UNITARIO, IT_PRECIO_VENTA, IT_TOTAL_ITEM, IT_ID_PROVEEDOR) = False Then
                util.mensajes("Items de Venta no registrado", TITULO_MSJ, "WAR")
                Return False
            End If

            'Se actualiza el campo facturado del pedido
            If ID_PEDIDO > 0 Then
                If venta.pedido_facturado(ID_PEDIDO, True) = False Then
                    util.mensajes("Campo facturado de pedido no actualizado", TITULO_MSJ, "WAR")
                    Return False
                End If
            End If

            'Se agrega el registro a la grilla
            Dim newRow As DataRow = (TryCast(grid_items.DataSource, DataTable)).NewRow()
            newRow("id_articulo") = IT_ID_ARTICULO
            newRow("codigo_barras") = dt_items_venta.Rows(0).Item(1)
            newRow("descripcion") = dt_items_venta.Rows(0).Item(2)
            newRow("precio_unitario") = IT_PRECIO_VENTA
            newRow("cantidad") = IT_CANTIDAD
            newRow("total") = IT_TOTAL_ITEM
            newRow("costo_unitario") = IT_COSTO_UNITARIO
            newRow("id_item") = venta.id_item_venta
            newRow("id_proveedor") = IT_ID_PROVEEDOR
            TryCast(grid_items.DataSource, DataTable).Rows.Add(newRow)
            grid_items.RefreshDataSource()

            'Se carga la imagen del articulo
            If File.Exists(IMAGEN) Then
                Dim fs As FileStream
                fs = New FileStream(IMAGEN, FileMode.Open, FileAccess.Read)
                pct_img_articulo.Image = Image.FromStream(fs)
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_img_articulo.Image = Image.FromStream(fs)
                End If
            End If

            'Se obtiene los totales y se actualiza la cabezera de la venta
            obtener_gravadas(IT_PRECIO_VENTA * IT_CANTIDAD, IT_PORC_IMPUESTO)
            obtener_impuestos(IT_PRECIO_VENTA * IT_CANTIDAD, IT_PORC_IMPUESTO)
            obtener_total(IT_TOTAL_ITEM)
            actualizar_totales()

            'Se limpian los campos y se devuelve el foco
            txt_codigo_barras.Text = ""
            txt_cantidad.Text = ""
            txt_codigo_barras.Focus()

            DEVOLUCION = False
            ITEM_PEDIDO = False
            lbl_modo_venta.Text = "Normal"
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
            Return False
        End If

        Return True
    End Function

    Private Function eliminar_item() As Boolean
        Dim fila As Integer = GridView1.FocusedRowHandle
        If fila < 0 Then
            util.mensajes("Debe seleccionar item para eliminar", TITULO_MSJ, "WAR")
            Return False
        End If

        dt_items_venta = venta.consultar("SELECT ti.valor FROM articulos a
                                        INNER JOIN tipos_impuesto ti ON ti.id_tipo_impuesto = a.id_tipo_impuesto
                                        WHERE a.codigo_barras = '" + GridView1.GetRowCellValue(fila, "codigo_barras").ToString + "'")

        If dt_items_venta.Rows.Count > 0 Then
            'Se obtienen los datos 
            IT_ID_ARTICULO = CInt(GridView1.GetRowCellValue(fila, "id_articulo"))
            IT_PRECIO_VENTA = CInt(GridView1.GetRowCellValue(fila, "precio_unitario"))
            IT_CANTIDAD = CInt(GridView1.GetRowCellValue(fila, "cantidad"))
            IT_TOTAL_ITEM = CInt(GridView1.GetRowCellValue(fila, "total"))
            IT_PORC_IMPUESTO = CInt(dt_items_venta.Rows(0).Item(0))
            IT_COSTO_UNITARIO = CInt(GridView1.GetRowCellValue(fila, "costo_unitario"))
            COSTO_TOTAL += CInt(GridView1.GetRowCellValue(fila, "costo_unitario"))

            'Se elimina el item en la base de datos
            If venta.eliminar_item_venta(CInt(GridView1.GetRowCellValue(fila, "id_item"))) = False Then
                util.mensajes("Items de Venta no registrado", TITULO_MSJ, "WAR")
                Return False
            End If

            'Se aumenta el stock del articulo
            If stock.validar_stock(IT_ID_ARTICULO, "articulo", frm_main.ID_SUCURSAL) Then
                If stock.aumentar_stock(IT_ID_ARTICULO, IT_CANTIDAD, "articulo", frm_main.ID_SUCURSAL) = False Then
                    util.mensajes("Stock no disminuido", TITULO_MSJ, "WAR")
                    Return False
                End If
            Else
                If stock.insertar(IT_ID_ARTICULO, IT_CANTIDAD - 1, 0, IT_COSTO_UNITARIO, 0, 0, frm_main.ID_SUCURSAL) = False Then
                    util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                    Return False
                End If
            End If

            'Se actualiza el campo facturado del pedido
            If ID_PEDIDO > 0 Then
                If venta.pedido_facturado(ID_PEDIDO, False) = False Then
                    util.mensajes("Campo facturado de pedido no actualizado", TITULO_MSJ, "WAR")
                    Return False
                End If
            End If

            'Se obtiene los totales y se actualiza la cabezera de la venta
            obtener_gravadas(IT_PRECIO_VENTA * IT_CANTIDAD, IT_PORC_IMPUESTO)
            obtener_impuestos(IT_PRECIO_VENTA * IT_CANTIDAD, IT_PORC_IMPUESTO)
            obtener_total(IT_TOTAL_ITEM * (-1))
            actualizar_totales()

            'Se limpian los campos y se devuelve el foco
            txt_codigo_barras.Text = ""
            txt_cantidad.Text = ""
            txt_codigo_barras.Focus()

            DEVOLUCION = False
            ITEM_PEDIDO = False
            lbl_modo_venta.Text = "Normal"
            GridView1.DeleteRow(fila)

            Return True
        Else
            Return False
        End If
    End Function

    Private Function asignacion_comprobante() As Boolean
        Try
            Dim dt As New DataTable

            dt = venta.consultar("SELECT 1 FROM asignacion_comprobante WHERE id_timbrado=" + ID_TIMBRADO.ToString)
            If FACTURA Then
                obtener_numero_comprob()
            Else
                NRO_COMPROBANTE = CInt(txt_numero.Text)
            End If
            If dt.Rows.Count > 0 Then
                If venta.actualizar_asignacion_comprob(NRO_COMPROBANTE, ID_TIMBRADO) = False Then
                    util.mensajes("Asignacion de Comprobante no actualizada", TITULO_MSJ, "WAR")
                    Return False
                End If
            Else
                If venta.insertar_asignacion_comprob(NRO_COMPROBANTE, ID_TIMBRADO) = False Then
                    util.mensajes("Asignacion de Comprobante no registrada", TITULO_MSJ, "WAR")
                    Return False
                End If
            End If

            Return True

        Catch ex As Exception
            util.mensajes("Error: " + ex.Message, TITULO_MSJ, "ERR")
            Return False
        End Try
    End Function

    Private Function obtener_numero_comprob() As Boolean

        If txt_numero.Text.Length < 8 + LONGITUD_NRO_COMPROB Or txt_numero.Text.Length > 8 + LONGITUD_NRO_COMPROB Then
            util.mensajes("Formato de numero no valido: 000-000-" + long_nro_comprob(), TITULO_MSJ, "WAR")
            txt_numero.Text = ""
            txt_numero.Focus()
            Return False
        End If

        NUMERO = txt_numero.Text
        NRO_COMPROBANTE = CInt(txt_numero.Text.Substring(8))
        Return True
    End Function

    Private Function long_nro_comprob() As String
        Dim ceros = ""
        For i As Integer = 1 To LONGITUD_NRO_COMPROB
            ceros = ceros + "0"
        Next
        Return ceros
    End Function

    Private Function existe_comprobante(numero As String) As Boolean
        Dim dt As New DataTable
        dt = venta.consultar("SELECT 1 FROM ventas WHERE numero='" + numero + "'")

        Return dt.Rows.Count > 0
    End Function

    Private Sub obtener_condiciones_venta()
        dt_condiciones_venta = venta.consultar("SELECT id_condicion, nombre FROM condiciones_venta ORDER BY id_condicion")

        If dt_condiciones_venta.Rows.Count > 0 Then
            cbo_condicion.Properties.Items.Clear()
            For Each dr As DataRow In dt_condiciones_venta.Rows
                cbo_condicion.Properties.Items.Add(dr("nombre"))
            Next
        End If

    End Sub

    Public Sub obtener_pedido(id As Integer)
        Dim dt As New DataTable
        dt = venta.consultar("SELECT p.id_pedido, a.codigo_barras, p.cantidad, p.estado, COALESCE(p.recepcionado, false),
                             COALESCE(p.precio_unitario, 0), p.id_vendedor, p.id_cliente, p.comision_vendedor
                             FROM pedidos p
                             INNER JOIN articulos a ON a.id_articulo = p.id_articulo
                             WHERE id_pedido=" + id.ToString + " AND usr_anulacion IS NULL")

        If dt.Rows.Count > 0 Then

            If CStr(dt.Rows(0).Item(3)) = "PENDIENTE" Then
                util.mensajes("Pedido aun no Costeado", TITULO_MSJ, "WAR")
                Return
            End If

            If CBool(dt.Rows(0).Item(4)) = False Then
                util.mensajes("Pedido aun no ha sido Recepcionado", TITULO_MSJ, "WAR")
                Return
            End If

            If CInt(dt.Rows(0).Item(5)) <= 0 Then
                util.mensajes("Pedido no posee precio de venta", TITULO_MSJ, "WAR")
                Return
            End If

            ITEM_PEDIDO = True
            ID_PEDIDO = CInt(dt.Rows(0).Item(0))
            txt_codigo_barras.Text = CStr(dt.Rows(0).Item(1))
            txt_cantidad.Text = CStr(dt.Rows(0).Item(2))
            PRECIO_VENTA_PEDIDO = CInt(dt.Rows(0).Item(5))
            ID_VENDEDOR = CInt(dt.Rows(0).Item(6))
            obtener_cliente(CInt(dt.Rows(0).Item(7)))
            COMISION_VENTA = CInt(dt.Rows(0).Item(8))
            txt_codigo_barras.Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Public Sub obtener_cliente(id As Integer)
        Dim dt As New DataTable
        dt = venta.consultar("SELECT id_cliente, CONCAT(nombres,' ',apellidos), coalesce((select sum(monto) from recibos where id_cliente = " + id.ToString + "), 0)
                                FROM clientes WHERE id_cliente = " + id.ToString + "")

        If dt.Rows.Count > 0 Then
            ID_CLIENTE = CInt(dt.Rows(0).Item(0))
            txt_cliente.Text = CStr(dt.Rows(0).Item(1))
            TOTAL_RECIBO = CInt(dt.Rows(0).Item(2))
        End If
    End Sub

    Private Sub obtener_total(total As Integer)
        If DEVOLUCION Then
            CANTIDAD_ITEMS = CANTIDAD_ITEMS - 1
        Else
            CANTIDAD_ITEMS += 1
        End If
        TOTAL_VENTA += total
        lbl_total.Text = Format(TOTAL_VENTA, "##,##")
        lbl_total_items.Text = CANTIDAD_ITEMS.ToString

    End Sub

    Private Sub obtener_gravadas(precio_vt As Integer, porc As Integer)
        If porc = 5 Then
            If DEVOLUCION Then
                GRAVADO5 -= CInt(precio_vt / 1.05)
            Else
                GRAVADO5 += CInt(precio_vt / 1.05)
            End If
        End If

        If porc = 10 Then
            If DEVOLUCION Then
                GRAVADO10 -= CInt(precio_vt / 1.1)
            Else
                GRAVADO10 += CInt(precio_vt / 1.1)
            End If
        End If

        GRAVADOS = GRAVADO5 + GRAVADO10
    End Sub

    Private Sub obtener_impuestos(precio_vt As Integer, porc As Integer)
        If porc = 5 Then
            If DEVOLUCION Then
                IMPUESTO5 -= CInt(precio_vt / 21.0)
            Else
                IMPUESTO5 += CInt(precio_vt / 21.0)
            End If
        End If
        If porc = 10 Then
            If DEVOLUCION Then
                IMPUESTO10 -= CInt(precio_vt / 11.0)
            Else
                IMPUESTO10 += CInt(precio_vt / 11.0)
            End If
        End If

        IMPUESTO = IMPUESTO5 + IMPUESTO10
    End Sub

    Private Sub actualizar_totales()
        If venta.actualizar_totales_venta(TOTAL_VENTA, GRAVADO5, GRAVADO10, GRAVADOS, IMPUESTO5, IMPUESTO10, IMPUESTO, EXENTAS, COSTO_TOTAL, ID_VENTA) = False Then
            util.mensajes("Totales de Venta no actualizados", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub movim_stock()
        ID_MOVIMIENTO = movim.id_movimiento_stock

        If movim.insertar_movimiento_stock(ID_MOVIMIENTO, frm_main.ID_SUCURSAL, frm_main.ID_USUARIO, 0, "", ID_VENTA, 0) = False Then
            util.mensajes("Movimiento de Stock no Generado", TITULO_MSJ, "WAR")
            Return
        End If
        movim_item_stock_articulo()
    End Sub

    Private Sub movim_item_stock_articulo()
        Dim id_articulo As Integer = 0
        Dim cantidad As Double = 0
        Dim costo_unitario As Integer = 0
        Dim costo_total As Integer = 0
        Dim precio_unitario As Integer = 0
        Dim id_proveedor As Integer = 0

        obtener_transaccion_stock()
        For i As Integer = 0 To GridView1.RowCount - 1
            cantidad = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
            costo_unitario = CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
            costo_total = CInt(costo_unitario * cantidad)
            id_articulo = CInt(GridView1.GetRowCellValue(i, "id_articulo"))
            precio_unitario = CInt(GridView1.GetRowCellValue(i, "precio_unitario"))
            id_proveedor = CInt(GridView1.GetRowCellValue(i, "id_proveedor"))
            ID_ITEM_MOVIM = movim.id_movim_items_stock

            'Se inserta en item del movimiento de stock
            If movim.insertar_movim_item_stock(ID_MOVIMIENTO, ID_TRANSACCION, "EGRESO", 0, cantidad, costo_unitario, costo_total, id_articulo, precio_unitario, ID_ITEM_MOVIM, id_proveedor) = False Then
                util.mensajes("Item de Stock no registrado", TITULO_MSJ, "WAR")
                Return
            End If

            'Se disminuye el stock del articulo
            If stock.validar_stock(id_articulo, "articulo", frm_main.ID_SUCURSAL) Then
                If stock.disminuir_stock(id_articulo, cantidad, "articulo", frm_main.ID_SUCURSAL) = False Then
                    util.mensajes("Stock no disminuido", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                If stock.insertar(id_articulo, cantidad, 0, costo_unitario, 0, 0, frm_main.ID_SUCURSAL) = False Then
                    util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                    Return
                End If
            End If

        Next
    End Sub

    Public Sub generar_movim_stock()
        'Sub Proceso que genera en segundo plano el movimiento de Stock
        trd_stock = New Thread(AddressOf movim_stock)
        trd_stock.Start()
    End Sub


    Private Sub insertar_comision_vendedor()
        If venta.comision_venta(COMISION_VENTA, ID_VENDEDOR, ID_VENTA) = False Then
            util.mensajes("Comision de vendedor no registrado", TITULO_MSJ, "WAR")
        End If
    End Sub

    Public Sub generar_comision_vendedor()
        'Sub Proceso que registra la comision de un vendedor en caso de haber
        trd_comision_venta = New Thread(AddressOf insertar_comision_vendedor)
        trd_comision_venta.Start()
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_usuario.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_usuario.Text.Replace(" ", "") = "" Then
            Else
                txt_numero.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txt_numero.Text.Replace(" ", "") = "" Then
                FACTURA = False
                cbo_condicion.Focus()
            Else
                If obtener_numero_comprob() = False Then
                    Return
                End If

                If existe_comprobante(txt_numero.Text) Then
                    util.mensajes("El comprobante Nro.:" + txt_numero.Text + ", ya existe", TITULO_MSJ, "WAR")
                    Return
                End If

                FACTURA = True
                cbo_condicion.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub cbo_condicion_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_condicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_condicion.SelectedIndex >= 0 Then
                txt_cliente.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cliente.Text.Replace(" ", "") = "" Then
            Else
                txt_codigo_barras.Focus()
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F8 Then
            Dim frm As New frm_vista_clientes
            frm.FRM_ACTIVO = "frm_ventas"
            frm.Show()
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_buscar_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_cliente.Click
        Dim frm As New frm_vista_clientes
        frm.FRM_ACTIVO = "frm_ventas"
        frm.Show()
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo_barras.Text.Replace(" ", "") = "" Then
                txt_cantidad.Focus()
            Else
                'Si el campo de cantidad esta vacio se le asigna el valor 1
                If txt_cantidad.Text.Replace(" ", "") = "" Then
                    txt_cantidad.Text = "1"
                End If

                'Se agregan solamente los items a la venta
                If FACTURANDO Then
                    'Se registra el item de venta
                    If insertar_item_venta() = False Then
                        Return
                    End If
                End If

                'Si es una nueva venta
                If FACTURANDO = False Then
                    'Se valida que el numero de comprobante aun no exista
                    If existe_comprobante(txt_numero.Text) Then
                        util.mensajes("El comprobante Nro.:" + txt_numero.Text + ", ya existe", TITULO_MSJ, "WAR")
                        Return
                    End If
                    'Se registra la cabezera de venta
                    If insertar_venta() = False Then
                        Return
                    End If
                    'Se registra el item de venta
                    If insertar_item_venta() = False Then
                        Return
                    End If
                End If
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If

    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo_barras.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_precios_Click(sender As Object, e As EventArgs) Handles btn_precios.Click
        modulos("F5")
    End Sub

    Private Sub btn_devolucion_Click(sender As Object, e As EventArgs) Handles btn_devolucion.Click
        modulos("F6")
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        modulos("F7")
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        modulos("F4")
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        modulos("F8")
    End Sub

    Private Sub btn_extraccion_Click(sender As Object, e As EventArgs) Handles btn_extraccion.Click
        modulos("F9")
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        modulos("ESC")
    End Sub

    Private Sub btn_precios_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_precios.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_devolucion_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_devolucion.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_reimpresion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_anular_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_anular.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_pedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_pedidos.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_confirmar_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_confirmar.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btn_cerrar_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_cerrar.KeyDown
        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub cbo_condicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_condicion.SelectedIndexChanged
        If cbo_condicion.SelectedIndex >= 0 Then
            ID_CONDICION_VENTA = CInt(dt_condiciones_venta.Rows(cbo_condicion.SelectedIndex).Item(0))
        End If
    End Sub

    Private Sub frm_ventas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CANTIDAD_ITEMS > 0 Then
            util.mensajes("Venta en Proceso", TITULO_MSJ, "WAR")
            e.Cancel = True
        End If
    End Sub

    Private Sub grid_items_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_items.KeyDown

        If e.KeyCode = Keys.F4 Then
            modulos("F4")
        End If
        If e.KeyCode = Keys.F5 Then
            modulos("F5")
        End If
        If e.KeyCode = Keys.F6 Then
            modulos("F6")
        End If
        If e.KeyCode = Keys.F7 Then
            modulos("F7")
        End If
        If e.KeyCode = Keys.F8 Then
            modulos("F8")
        End If
        If e.KeyCode = Keys.F9 Then
            modulos("F9")
        End If
        If e.KeyCode = Keys.Escape Then
            modulos("ESC")
        End If
    End Sub

    Private Sub btnRecibos_Click(sender As Object, e As EventArgs) Handles btnRecibos.Click
        frm_recibos.id_control_caja = ID_CONTROL_CAJA
        frm_recibos.Show()
    End Sub
End Class