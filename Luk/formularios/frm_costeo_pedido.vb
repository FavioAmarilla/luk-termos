Public Class frm_costeo_pedido

    Private util As New utilidades()
    Private dt_materiales_articulos As New DataTable()
    Private dt_material As New DataTable()
    Private costeo As New func_costeo_pedido()
    Private articulo As New func_articulos()
    Private material As New func_materiales()

    Private Const TITULO_MSJ As String = "<<Costeo de Pedido>"
    Public EXISTE_COSTEO As Boolean = False
    Private RECEPCIONADO As Boolean = False

    'Variables para las operaciones sobre la tabla costeo_pedido
    Private ID_COSTEO_PEDIDO As Integer = 0
    Public ID_PEDIDO As Integer = 0
    Public ID_ARTICULO As Integer = 0
    Private FECHA_COSTEO As Date = Nothing
    Private TOTAL_UNITARIO As Integer = 0
    Private TOTAL_DESCTO As Integer = 0
    Private TOTAL_EXTRA As Integer = 0
    Private TOTAL_COSTO As Integer = 0
    Private COMISION As Integer = 0
    Private PRECIO_VENTA As Integer = 0
    Private ID_ART_PROVEEDOR As Integer = 0
    'Variables para las operaciones sobre la tabla costeo_item
    Private ID_MATERIAL As Integer = 0
    Private CANTIDAD As Double = 0
    Private CANTIDAD_ARTICULO As Double = 0

    Private asignacion As New func_asignacion_pedido_empleado
    Private dt_asignacion As New DataTable
    Public MANO_OBRA As Integer = 0
    Public PAGO_EXTRA As Integer = 0
    Public ID_ASIGNACION As Integer = 0
    Public NUEVO As Boolean = False
    Private TOTAL_PRECIO_VENTA As Integer = 0
    Private ID_PROVEEDOR As Integer = 0

    'Variables para las operaciones sobre la tabla asignacion_pedido_empleado 
    Private ID_EMPLEADO As Integer = 0
    Private PAGADO As Boolean = False

    Private Sub frm_costeo_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_materiales(ID_ARTICULO, "insert")
        limpiar()
        desabilitar()
    End Sub

    Private Sub desabilitar()
        'Tab Costeo
        txt_num_pedido.Enabled = False
        txt_fecha_pedido.Enabled = False
        txt_cliente.Enabled = False
        txt_total_extra.Enabled = False
        txt_total_descuento.Enabled = False
        txt_total_mano_obra.Enabled = False
        txt_total_materia_prima.Enabled = False
        txt_total_costo.Enabled = False
        txt_total_venta.Enabled = False
        txt_porc_comision.Enabled = False
        txt_total_comision.Enabled = False
        btn_quitar_materia_prima.Enabled = False
        btn_agregar_material.Enabled = False
        btn_confirmar.Enabled = False

        'Tab Mano de Obra
        txt_id_pedido.Enabled = False
        txt_nro_pedido.Enabled = False
        txt_fecha_pedi.Enabled = False
        txt_mano_obra.Enabled = False
        txt_extra.Enabled = False
        txt_cantidad.Enabled = False
        btn_agregar.Enabled = False
        btn_quitar_empleado.Enabled = False
    End Sub

    Private Sub habilitar()
        'Tab Costeo
        txt_num_pedido.Enabled = True
        txt_fecha_pedido.Enabled = True
        txt_cliente.Enabled = True
        txt_total_extra.Enabled = True
        txt_total_descuento.Enabled = True
        txt_total_mano_obra.Enabled = True
        txt_total_materia_prima.Enabled = True
        txt_total_costo.Enabled = True
        txt_total_venta.Enabled = True
        txt_porc_comision.Enabled = True
        txt_total_comision.Enabled = True
        btn_confirmar.Enabled = True
        btn_quitar_materia_prima.Enabled = True
        btn_agregar_material.Enabled = True

        'Tab Mano de Obra
        txt_id_pedido.Enabled = True
        txt_nro_pedido.Enabled = True
        txt_fecha_pedi.Enabled = True
        txt_mano_obra.Enabled = True
        txt_extra.Enabled = True
        txt_cantidad.Enabled = True
        btn_agregar.Enabled = True
        btn_quitar_empleado.Enabled = True
    End Sub

    Private Sub limpiar()
        'Tab Costeo
        txt_num_pedido.Text = ""
        txt_fecha_pedido.Text = ""
        txt_cliente.Text = ""
        txt_total_extra.Text = ""
        txt_total_descuento.Text = ""
        txt_total_mano_obra.Text = ""
        txt_materia_prima_unidad.Text = ""
        txt_total_materia_prima.Text = ""
        txt_costo_unitario.Text = ""
        txt_total_costo.Text = ""
        txt_recargo.Text = ""
        txt_precio_venta_unit.Text = ""
        txt_total_venta.Text = ""
        txt_porc_comision.Text = ""
        txt_total_comision.Text = ""
        lbl_cantidad_articulo.Text = ""
        lbl_descripcion_articulo.Text = ""
        lbl_codigo.Text = ""
        grid_materiales.DataSource = Nothing

        'Tab Mano de Obra
        txt_id_pedido.Text = ""
        txt_nro_pedido.Text = ""
        txt_fecha_pedi.Text = ""
        txt_mano_obra.Text = ""
        txt_extra.Text = ""
        txt_cantidad.Text = ""
        grid_asignacion.DataSource = Nothing
    End Sub

    Public Sub obtener_materiales(id_articulo As Integer, accion As String)
        Dim cant As Double
        If lbl_cantidad_articulo.Text.Replace(" ", "") = "" Then
            cant = 0
        Else
            cant = CDbl(lbl_cantidad_articulo.Text)
        End If
        If accion = "update" Then
            dt_materiales_articulos = costeo.consultar("SELECT ci.id_material, m.nombre AS material, ci.cantidad, ci.costo_unitario,
                                                        (ci.cantidad * ci.costo_unitario) AS costo_total,
                                                        (ci.cantidad * ci.cantidad_articulo) AS cantidad_total, false AS nuevo,
                                                        0 AS precio_venta, COALESCE(ci.id_proveedor, 0) AS id_proveedor FROM costeo_de_pedido cp
                                                        INNER JOIN costeo_item ci ON ci.id_costeo_de_pedido = cp.id_costeo_de_pedido
                                                        INNER JOIN materiales m ON m.id_material = ci.id_material
                                                        WHERE cp.id_pedido = " + id_articulo.ToString + "")
        End If

        If accion = "insert" Then
            dt_materiales_articulos = costeo.consultar("SELECT am.id_material, m.nombre AS material, am.cantidad AS cantidad,m.costo_unitario, 0 AS descuento, 
                                                    0 AS extra, 0 AS costo_totaL, am.cantidad * " + cant.ToString + " AS cantidad_total, false AS nuevo,
                                                    0 AS precio_venta, COALESCE(m.id_proveedor, 0) AS id_proveedor FROM articulo_materiales am
                                                    INNER JOIN articulos a ON am.id_articulo = a.id_articulo
                                                    INNER JOIN materiales m ON am.id_material = m.id_material 
                                                    WHERE am.id_Articulo = " + id_articulo.ToString() + "")
        End If

        If dt_materiales_articulos.Rows.Count > 0 Then
            grid_materiales.DataSource = dt_materiales_articulos
            obtener_totales()
        End If

    End Sub

    Private Sub obtener_totales()
        Dim un As Integer = 0
        Dim monto As Integer = 0
        Dim ca As Double = 0

        TOTAL_UNITARIO = 0
        TOTAL_COSTO = 0
        PAGO_EXTRA = 0

        For i As Integer = 0 To GridView1.RowCount() - 1
            GridView1.SetRowCellValue(i, "cantidad_total", CDbl(GridView1.GetRowCellValue(i, "cantidad")) * CInt(lbl_cantidad_articulo.Text))
            un = CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
            ca = CDbl(GridView1.GetRowCellValue(i, "cantidad_total"))

            GridView1.SetRowCellValue(i, "costo_total", un * ca)

            TOTAL_UNITARIO += CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
            TOTAL_COSTO += CInt(GridView1.GetRowCellValue(i, "costo_total"))
        Next

        Dim cant As Integer = 0

        If txt_total_extra.Text.Replace(" ", "") = "" Then
            TOTAL_EXTRA = 0
        Else
            TOTAL_EXTRA = CInt(txt_total_extra.Text)
        End If

        If txt_total_mano_obra.Text.Replace(" ", "") = "" Then
            MANO_OBRA = 0
        Else
            MANO_OBRA = CInt(txt_total_mano_obra.Text)
        End If

        If lbl_cantidad_articulo.Text.Replace(" ", "") = "" Then
            cant = 0
        Else
            cant = CInt(lbl_cantidad_articulo.Text)
        End If

        If txt_total_descuento.Text.Replace(" ", "") = "" Then
            TOTAL_DESCTO = 0
        Else
            TOTAL_DESCTO = CInt(txt_total_descuento.Text)
        End If

        If txt_precio_venta_unit.Text.Replace(" ", "") = "" Then
            TOTAL_UNITARIO = 0
        Else
            TOTAL_UNITARIO = CInt(txt_precio_venta_unit.Text)
        End If

        obtener_comision()
        txt_total_materia_prima.Text = TOTAL_COSTO.ToString()
        txt_materia_prima_unidad.Text = TOTAL_COSTO.ToString() / txt_cantidad.Text
        txt_total_costo.Text = CStr(((MANO_OBRA * cant) + (TOTAL_EXTRA * cant) + TOTAL_COSTO))
        txt_costo_unitario.Text = CInt(txt_total_costo.Text) / CInt(lbl_cantidad_articulo.Text)

        If TOTAL_UNITARIO > 0 Then
            txt_total_venta.Text = (TOTAL_UNITARIO - TOTAL_DESCTO) * CInt(txt_cantidad.Text)
        End If
    End Sub

    Public Sub obtener_recargo(vr As String)
        Dim porcentaje As Double = 0.0
        Dim costo_unitario As Integer = 0
        Dim precio_venta As Integer = 0
        Dim precio_final As Integer = 0

        If txt_recargo.Text.Replace(" ", "") = "" Then
            porcentaje = 0
        Else
            porcentaje = CDbl(txt_recargo.Text)
        End If

        If txt_costo_unitario.Text.Replace(" ", "") = "" Then
            costo_unitario = 0
        Else
            costo_unitario = CInt(txt_costo_unitario.Text)
        End If

        If txt_precio_venta_unit.Text.Replace(" ", "") = "" Then
            precio_venta = 0
        Else
            precio_venta = CInt(txt_precio_venta_unit.Text)
        End If

        If vr = "PV" Then
            precio_final = ((costo_unitario * porcentaje) / 100) + costo_unitario
            txt_precio_venta_unit.Text = precio_final
            txt_total_venta.Text = precio_final * CInt(lbl_cantidad_articulo.Text) - (txt_total_descuento.Text * txt_cantidad.Text)
        End If

        If vr = "PO" And costo_unitario > 0 Then
            porcentaje = ((precio_venta / costo_unitario) * 100) - 100
            precio_final = CInt(txt_precio_venta_unit.Text)
            txt_recargo.Text = porcentaje
            txt_total_venta.Text = precio_final * CInt(lbl_cantidad_articulo.Text) - (txt_total_descuento.Text * txt_cantidad.Text)
        End If

    End Sub

    Private Sub obtener_comision()
        Dim porc As Double = 0.0
        Dim comision As Integer = 0

        If txt_porc_comision.Text.Replace(" ", "") = "" Then
            porc = 0
        Else
            porc = CInt(txt_porc_comision.Text)
        End If

        comision = CInt((TOTAL_PRECIO_VENTA * porc) / 100)

        txt_total_comision.Text = CStr(comision)
    End Sub


    Public Sub add_materiales(ByVal id As Integer)
        dt_material = costeo.consultar("SELECT id_material, nombre, costo_unitario, id_proveedor
                                        FROM materiales WHERE id_material=" + id.ToString() + "")

        If dt_material.Rows.Count() <> 0 Then

            'Validamos que el material aun no este agregado al articulo
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "id_material") = dt_material.Rows(0).Item(0).ToString Then
                    util.mensajes(dt_material.Rows(0).Item(1).ToString() + ", ya esta asignado al Articulo", TITULO_MSJ, "WAR")
                    Return
                End If
            Next


            Dim row As DataRow = dt_materiales_articulos.NewRow()

            row.Item("id_material") = dt_material.Rows(0).Item(0)
            row.Item("material") = dt_material.Rows(0).Item(1)
            row.Item("cantidad") = 0
            row.Item("costo_unitario") = dt_material.Rows(0).Item(2)
            row.Item("costo_total") = 0
            row.Item("cantidad_total") = 0
            row.Item("nuevo") = True
            row.Item("precio_venta") = 0
            row.Item("id_proveedor") = dt_material.Rows(0).Item(3)

            dt_materiales_articulos.Rows.Add(row)
            grid_materiales.DataSource = dt_materiales_articulos

            grid_materiales.Refresh()

            'Se manda el foco a la columna cantidad de la fila agregada
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.ShowEditor()
        Else
            util.mensajes("El material seleccionado no existe", TITULO_MSJ, "WAR")
        End If

    End Sub

    Private Sub insertar_actualizar()
        If GridView2.RowCount <= 0 Then
            util.mensajes("Debe asignar Mano de Obra al pedido", TITULO_MSJ, "WAR")
            tab_mano_obra.Focus()
            Return
        End If

        If EXISTE_COSTEO = False Then
            ID_COSTEO_PEDIDO = costeo.id_costeo_pedido()
        End If

        If txt_total_materia_prima.Text.Replace(" ", "") = "" Then
            TOTAL_UNITARIO = 0
        Else
            TOTAL_UNITARIO = CInt(txt_total_materia_prima.Text)
        End If

        If txt_total_extra.Text.Replace(" ", "") = "" Then
            TOTAL_EXTRA = 0
        Else
            TOTAL_EXTRA = CInt(txt_total_extra.Text)
        End If

        If txt_total_mano_obra.Text.Replace(" ", "") = "" Then
            MANO_OBRA = 0
        Else
            MANO_OBRA = CInt(txt_total_mano_obra.Text)
        End If

        If txt_total_descuento.Text.Replace(" ", "") = "" Then
            TOTAL_DESCTO = 0
        Else
            TOTAL_DESCTO = CInt(txt_total_descuento.Text)
        End If

        If txt_total_costo.Text.Replace(" ", "") = "" Then
            TOTAL_COSTO = 0
        Else
            TOTAL_COSTO = CInt(txt_total_costo.Text)
        End If

        If txt_total_comision.Text.Replace(" ", "") = "" Then
            COMISION = 0
        Else
            COMISION = CInt(txt_total_comision.Text)
        End If

        If txt_total_venta.Text.Replace(" ", "") = "" Then
            PRECIO_VENTA = 0
        Else
            PRECIO_VENTA = CInt(txt_total_comision.Text)
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If EXISTE_COSTEO = False Then
            If costeo.insertar_costeo_pedido(ID_COSTEO_PEDIDO, ID_PEDIDO, ID_ARTICULO, TOTAL_COSTO, frm_main.ID_USUARIO, TOTAL_DESCTO, TOTAL_EXTRA, frm_main.ID_SUCURSAL, CInt(TOTAL_COSTO / CDbl(lbl_cantidad_articulo.Text)), CDbl(lbl_cantidad_articulo.Text), MANO_OBRA, COMISION, PRECIO_VENTA, ID_ART_PROVEEDOR) Then

                'articulo.actualizar_costo(CInt(TOTAL_COSTO / CDbl(lbl_cantidad_articulo.Text)), ID_ARTICULO)
                'articulo.actualizar_precio_venta(CInt(txt_precio_venta_unit.Text), ID_ARTICULO)

                If costeo.actualizar_estado_pedido("COSTEADO", ID_PEDIDO) Then
                    EXISTE_COSTEO = True
                    Dim respuesta As Boolean = False

                    For i As Integer = 0 To GridView1.RowCount() - 1
                        ID_MATERIAL = CInt(GridView1.GetRowCellValue(i, "id_material"))
                        CANTIDAD = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
                        CANTIDAD_ARTICULO = CDbl(GridView1.GetRowCellValue(i, "cantidad_total"))
                        TOTAL_UNITARIO = CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
                        TOTAL_COSTO = CInt(GridView1.GetRowCellValue(i, "costo_total"))
                        PRECIO_VENTA = CInt(GridView1.GetRowCellValue(i, "precio_venta"))
                        ID_PROVEEDOR = CInt(GridView1.GetRowCellValue(i, "id_proveedor"))

                        respuesta = costeo.insertar_costeo_item(ID_COSTEO_PEDIDO, ID_MATERIAL, CANTIDAD, TOTAL_UNITARIO, TOTAL_COSTO, CANTIDAD_ARTICULO, PRECIO_VENTA, ID_PROVEEDOR)

                        material.actualizar_costo(TOTAL_UNITARIO, ID_MATERIAL)
                        'Si la variable respuesta queda en false es porque ocurrio un error al insertar los items,
                        'en ese caso realizamos un return para salir del metodo
                        If respuesta = False Then
                            util.mensajes("Items de Costeo no registrados", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Next

                    TOTAL_COSTO = CInt(txt_total_costo.Text)
                    TOTAL_DESCTO = CInt(txt_total_descuento.Text)
                    MANO_OBRA = CInt(txt_total_mano_obra.Text)
                    TOTAL_EXTRA = CInt(txt_total_extra.Text)
                    'Se actualiza los campos de totales en la base de datos y en el frm_pedido
                    If costeo.actualizar_totales_pedido(CInt(TOTAL_COSTO / CDbl(lbl_cantidad_articulo.Text)), TOTAL_COSTO, TOTAL_DESCTO, MANO_OBRA, TOTAL_EXTRA, ID_PEDIDO, COMISION, CInt(txt_precio_venta_unit.Text), CInt(txt_total_venta.Text)) Then
                        EXISTE_COSTEO = True
                        insertar_actualizar_asignacion()
                        'Se realiza el return para salir del metodo, si no se aplica este return va ingresar a la siguiente condicion
                        'y realizara el proceso de actualizadcion del costeo
                        Return
                    Else
                        util.mensajes("Totales del pedido no actualizados", TITULO_MSJ, "WAR")
                    End If
                Else
                    util.mensajes("Estado del Pedido no actualizado", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("Costeo de Pedido no Registrado", TITULO_MSJ, "WAR")
                EXISTE_COSTEO = False
            End If
        End If


        If EXISTE_COSTEO Then
            'Se eliminan todos los items del costeo si es que hay registros
            costeo.eliminar_costeo_item(ID_COSTEO_PEDIDO)
            'Se insertan los nuevos valores
            If lbl_cantidad_articulo.Text = "" Then
                CANTIDAD_ARTICULO = 0
            Else
                CANTIDAD_ARTICULO = CDbl(lbl_cantidad_articulo.Text)
            End If
            If costeo.actualizar_costeo_pedido(ID_PEDIDO, ID_ARTICULO, TOTAL_COSTO, TOTAL_DESCTO, TOTAL_EXTRA, frm_main.ID_USUARIO, frm_main.ID_SUCURSAL, TOTAL_UNITARIO, CANTIDAD_ARTICULO, ID_COSTEO_PEDIDO, MANO_OBRA, COMISION, PRECIO_VENTA, ID_ART_PROVEEDOR) Then

                costeo.actualizar_estado_pedido("COSTEADO", ID_PEDIDO)
                'articulo.actualizar_precio_venta(CInt(txt_precio_venta_unit.Text), ID_ARTICULO)

                For i As Integer = 0 To GridView1.RowCount() - 1
                    ID_MATERIAL = CInt(GridView1.GetRowCellValue(i, "id_material"))
                    CANTIDAD = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
                    CANTIDAD_ARTICULO = CDbl(GridView1.GetRowCellValue(i, "cantidad_total"))
                    TOTAL_UNITARIO = CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
                    TOTAL_COSTO = CInt(GridView1.GetRowCellValue(i, "costo_total"))
                    ID_PROVEEDOR = CInt(GridView1.GetRowCellValue(i, "id_proveedor"))

                    If costeo.insertar_costeo_item(ID_COSTEO_PEDIDO, ID_MATERIAL, CANTIDAD, TOTAL_UNITARIO, TOTAL_COSTO, CANTIDAD_ARTICULO, PRECIO_VENTA, ID_PROVEEDOR) = False Then
                        util.mensajes("Items de Costeo no registrados", TITULO_MSJ, "WAR")
                        Return
                    End If
                Next


                'Se actualiza los campos de totales en la base de datos y en el frm_pedido
                If costeo.actualizar_totales_pedido(CInt(txt_total_materia_prima.Text), CInt(txt_total_costo.Text), CInt(txt_total_descuento.Text), CInt(txt_total_mano_obra.Text), CInt(txt_total_extra.Text), ID_PEDIDO, COMISION, CInt(txt_precio_venta_unit.Text), CInt(txt_total_venta.Text)) Then
                    insertar_actualizar_asignacion()
                Else
                    util.mensajes("Totales del pedido no actualizados", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("Costeo de Pedido no Actualizado", TITULO_MSJ, "WAR")
            End If
        End If
    End Sub

    Public Sub obtener_pedido(ByVal id As Integer)
        Dim dt As New DataTable()
        dt = costeo.consultar("SELECT p.id_pedido, p.numero, p.fecha_pedido, CONCAT(v.nombres,' ',v.apellidos) AS vendedor, 
                                CONCAT(c.nombres,' ',c.apellidos) AS cliente, 
                                p.costo_unitario, p.total_adicional, total_descto, p.total_mano_obra, p.costo_total, 
                                a.nombre, a.codigo_articulo, p.cantidad, a.id_articulo, p.estado, p.cantidad, COALESCE(a.costo_mano_obra,0),
                                COALESCE(v.porcentaje_comision, 0), COALESCE(precio_unitario * cantidad, 0) AS total_precio_venta, 
                                COALESCE(recepcionado, false), p.id_proveedor, COALESCE(p.comision_vendedor, 0)
                                FROM pedidos p
                                INNER JOIN articulos a ON a.id_articulo = p.id_articulo
                                INNER JOIN clientes c ON c.id_cliente = p.id_cliente
                                INNER JOIN vendedores v ON v.id_vendedor = p.id_vendedor 
                                WHERE p.id_pedido=" + Trim(id.ToString()) + "")

        If dt.Rows.Count <> 0 Then
            ID_PEDIDO = CInt(dt.Rows(0).Item(0))
            txt_num_pedido.Text = CStr(dt.Rows(0).Item(1))
            txt_fecha_pedido.Text = CStr(dt.Rows(0).Item(2))
            txt_cliente.Text = CStr(dt.Rows(0).Item(4))
            txt_total_materia_prima.Text = CStr(dt.Rows(0).Item(5))
            txt_total_extra.Text = CStr(dt.Rows(0).Item(6))
            txt_total_descuento.Text = CStr(dt.Rows(0).Item(7))
            txt_total_mano_obra.Text = CStr(dt.Rows(0).Item(8))
            txt_total_costo.Text = CStr(dt.Rows(0).Item(9))
            lbl_descripcion_articulo.Text = CStr(dt.Rows(0).Item(10))
            lbl_codigo.Text = CStr(dt.Rows(0).Item(11))
            lbl_cantidad_articulo.Text = CStr(dt.Rows(0).Item(12))
            ID_ARTICULO = CInt(dt.Rows(0).Item(13))
            txt_id_pedido.Text = ID_PEDIDO.ToString()
            txt_nro_pedido.Text = txt_num_pedido.Text
            txt_fecha_pedi.Text = txt_fecha_pedido.Text
            txt_mano_obra.Text = CStr(dt.Rows(0).Item(8))
            txt_extra.Text = CStr(dt.Rows(0).Item(6))
            txt_cantidad.Text = CStr(dt.Rows(0).Item(12))
            TOTAL_PRECIO_VENTA = CInt(dt.Rows(0).Item(18))
            txt_total_venta.Text = CStr(dt.Rows(0).Item(18))
            txt_precio_venta_unit.Text = CInt(dt.Rows(0).Item(18)) / CInt(lbl_cantidad_articulo.Text)
            RECEPCIONADO = CBool(dt.Rows(0).Item(19))
            ID_ART_PROVEEDOR = CInt(dt.Rows(0).Item(20))
            txt_total_comision.Text = CStr(dt.Rows(0).Item(21))

            If dt.Rows(0).Item(14).ToString() = "PENDIENTE" Then
                EXISTE_COSTEO = False
                obtener_materiales(ID_ARTICULO, "insert")
            End If
            If dt.Rows(0).Item(14).ToString() = "COSTEADO" Then
                obtener_costeo_pedido(ID_PEDIDO)
                EXISTE_COSTEO = True
                obtener_materiales(ID_PEDIDO, "update")
            End If

            obtener_asignacion(ID_PEDIDO.ToString())
            obtener_recargo("PO")



            habilitar()

            Dim total_venta As Integer = 0
            Dim total_comision As Integer = 0
            Dim porc As Double = 0.0
            If CStr(dt.Rows(0).Item(21)) = "" Then
                total_comision = 0
            Else
                total_comision = CInt(dt.Rows(0).Item(21))
            End If

            If CStr(dt.Rows(0).Item(18)) = "" Then
                total_venta = 0
            Else
                total_venta = CInt(dt.Rows(0).Item(18))
            End If

            porc = ((total_comision * 100) / total_venta)
            txt_total_comision.Text = total_comision
            txt_porc_comision.Text = CStr(porc)
            ''obtener_comision()

            txt_nro_pedido.Focus()
        Else
            util.mensajes("Pedido no Registrado en Base de Datos", TITULO_MSJ, "WAR")
            EXISTE_COSTEO = False
            btn_pedidos.Focus()
        End If
    End Sub

    Private Sub obtener_costeo_pedido(ByVal id_ped As Integer)
        Dim dt As New DataTable()
        dt = costeo.consultar("SELECT * FROM costeo_de_pedido WHERE id_pedido=" + Trim(id_ped.ToString()) + "")

        If dt.Rows.Count <> 0 Then
            ID_COSTEO_PEDIDO = CInt(dt.Rows(0).Item(0))
            ID_PEDIDO = CInt(dt.Rows(0).Item(1))
            ID_ARTICULO = CInt(dt.Rows(0).Item(2))
            TOTAL_COSTO = CInt(dt.Rows(0).Item(4))
            TOTAL_DESCTO = CInt(dt.Rows(0).Item(5))
            TOTAL_EXTRA = CInt(dt.Rows(0).Item(6))
            TOTAL_UNITARIO = CInt(dt.Rows(0).Item(9))

            obtener_costeo_item(ID_COSTEO_PEDIDO)
            grid_materiales.Focus()
        End If

    End Sub

    Public Sub obtener_costeo_item(ByVal id_costeo As Integer)
        Dim cant As Double
        If lbl_cantidad_articulo.Text = "" Then
            cant = 0
        Else
            cant = CDbl(lbl_cantidad_articulo.Text)
        End If
        dt_materiales_articulos.Clear()
        dt_materiales_articulos = costeo.consultar("SELECT c.id_material, m.nombre AS material, c.cantidad, c.costo_unitario, c.costo_final AS costo_total, 
                                                    c.cantidad_articulo AS cantidad_total, false AS nuevo
                                                    FROM costeo_item c
                                                    INNER JOIN materiales m ON m.id_material = c.id_material
                                                    WHERE c.id_costeo_de_pedido = " + id_costeo.ToString() + "")
        grid_materiales.DataSource = dt_materiales_articulos
    End Sub

    Private Sub actualizar_totales()
        eliminar_filas_vacias()
        Dim mano_de_obra As Integer = 0
        Dim extra As Integer = 0
        Dim cant As Double = 0

        If txt_total_mano_obra.Text.Replace(" ", "") = "" Then
        Else
            mano_de_obra = CInt(txt_total_mano_obra.Text)
        End If

        If txt_total_extra.Text.Replace(" ", "") = "" Then
        Else
            extra = CInt(txt_total_extra.Text)
        End If

        txt_total_mano_obra.Text = mano_de_obra.ToString()
        txt_mano_obra.Text = mano_de_obra.ToString
        txt_extra.Text = extra.ToString()

        If GridView2.RowCount > 0 Then
            For i As Integer = 0 To GridView2.RowCount - 1
                If IsDBNull(GridView2.GetRowCellValue(i, "cantidad")) Then
                Else
                    cant = CDbl(GridView2.GetRowCellValue(i, "cantidad"))
                End If
                GridView2.SetRowCellValue(i, "mano_obra", mano_de_obra)
                GridView2.SetRowCellValue(i, "pago_extra", extra)
                GridView2.SetRowCellValue(i, "total", (mano_de_obra + extra) * cant)
            Next
        End If
    End Sub

    Sub calcular_comision()
        Dim total_venta As Integer = 0
        Dim comision As Integer = 0
        Dim porc As Double = 0.0


        If txt_porc_comision.Text.Replace(" ", "") = "" Then
            total_venta = 0
        Else
            porc = txt_porc_comision.Text
        End If

        If txt_total_venta.Text.Replace(" ", "") = "" Then
            total_venta = 0
        Else
            total_venta = CInt(txt_total_venta.Text)
        End If

        comision = ((total_venta * porc) / 100)
        txt_total_comision.Text = CStr(comision)
    End Sub



    '--------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub crear_cursor_asignacion()
        dt_asignacion = New DataTable
        dt_asignacion.Columns.Add("id_empleado")
        dt_asignacion.Columns.Add("empleado")
        dt_asignacion.Columns.Add("cantidad", GetType(System.Double))
        dt_asignacion.Columns.Add("mano_obra")
        dt_asignacion.Columns.Add("pago_extra")
        dt_asignacion.Columns.Add("total")
        dt_asignacion.Columns.Add("id_asignacion_pedido_empleado")
        dt_asignacion.Columns.Add("nuevo")

        grid_asignacion.DataSource = dt_asignacion
        grid_asignacion.Focus()
    End Sub

    Private Sub obtener_asignacion(pedido As String)
        dt_asignacion = asignacion.consultar("SELECT a.id_empleado, CONCAT(e.nombres,' ',e.apellidos) AS empleado, a.cantidad_asignada AS cantidad, 
                                   a.mano_obra, a.pago_extra, a.id_asignacion_pedido_empleado, false AS nuevo, 
                                   (a.mano_obra + a.pago_extra) *a.cantidad_asignada AS total
                                   FROM asignacion_pedido_empleado a
                                   INNER JOIN empleados e ON e.id_empleado = a.id_empleado 
                                   WHERE a.id_pedido=" + pedido + "")

        grid_asignacion.DataSource = dt_asignacion

    End Sub

    Public Sub obtener_empleado(ByVal id As String)
        If validar_cantidad_limite(1) = False Then
            util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
            Return
        End If

        Dim dt As New DataTable
        dt = asignacion.consultar("SELECT id_empleado, CONCAT(nombres,', ',apellidos) AS empleado FROM empleados WHERE id_empleado = " + id + "")

        If dt.Rows().Count() <> 0 Then
            Dim newRow As DataRow = (TryCast(grid_asignacion.DataSource, DataTable)).NewRow()
            newRow("id_empleado") = dt.Rows(0).Item(0)
            newRow("empleado") = dt.Rows(0).Item(1)
            newRow("cantidad") = 1
            newRow("mano_obra") = CInt(txt_mano_obra.Text)
            newRow("pago_extra") = CInt(txt_extra.Text)
            newRow("total") = (CInt(txt_mano_obra.Text) + CInt(txt_extra.Text)) * CDbl(newRow.Item("cantidad"))
            newRow("id_asignacion_pedido_empleado") = 0
            newRow("nuevo") = True
            TryCast(grid_asignacion.DataSource, DataTable).Rows.Add(newRow)
            grid_asignacion.RefreshDataSource()

            eliminar_filas_vacias()
            grid_asignacion.Focus()
        End If

    End Sub

    Private Function validar_cantidad_limite(ByVal i As Integer) As Boolean
        eliminar_filas_vacias()
        Dim cantidad As Double = 0

        For fila As Integer = 0 To GridView2.RowCount
            If IsDBNull(GridView2.GetRowCellValue(fila, "cantidad")) Then
            Else
                cantidad += CDbl(GridView2.GetRowCellValue(fila, "cantidad"))
            End If
        Next

        'Si devuelve True puede continuar asignando empleados
        Return cantidad + i <= CDbl(lbl_cantidad_articulo.Text)
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

        'Si devuelve false aun quedan items por asignar al empleado
        Return cantidad >= CDbl(lbl_cantidad_articulo.Text)
    End Function

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_asignacion.Rows()
            If IsDBNull(dr("id_empleado")) Or IsDBNull(dr("empleado")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_asignacion.Rows.Remove(dr)
        Next
    End Sub

    Private Sub insertar_actualizar_asignacion()
        Dim msj As Integer = 0
        eliminar_filas_vacias()
        ID_PEDIDO = CInt(txt_id_pedido.Text)

        For i As Integer = 0 To GridView2.RowCount() - 1
            ID_EMPLEADO = CInt(GridView2.GetRowCellValue(i, "id_empleado"))
            CANTIDAD = CDbl(GridView2.GetRowCellValue(i, "cantidad"))
            ID_ASIGNACION = CInt(GridView2.GetRowCellValue(i, "id_asignacion_pedido_empleado"))
            NUEVO = CBool(GridView2.GetRowCellValue(i, "nuevo"))
            PAGADO = False
            MANO_OBRA = CInt(GridView2.GetRowCellValue(i, "mano_obra"))
            PAGO_EXTRA = CInt(GridView2.GetRowCellValue(i, "pago_extra"))

            If NUEVO Then
                If asignacion.insertar(ID_PEDIDO, ID_EMPLEADO, CANTIDAD, PAGADO, MANO_OBRA, PAGO_EXTRA) = False Then
                    util.mensajes("Asignacion Pedido-Empleado no registrado", TITULO_MSJ, "WAR")
                    Return
                End If
                msj = 0
            Else
                If asignacion.actualizar(CANTIDAD, False, MANO_OBRA, PAGO_EXTRA, ID_ASIGNACION) = False Then
                    util.mensajes("Asignacion Pedido-Empleado no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
                msj = 1
            End If
        Next

        If msj = 0 Then
            util.mensajes("Costeo de Pedido Registrado", TITULO_MSJ, "INF")
        End If
        If msj = 1 Then
            util.mensajes("Costeo de Pedido Actualizado", TITULO_MSJ, "INF")
        End If
        limpiar()
        desabilitar()
    End Sub

    Sub calcular_comision(vr As String)
        Dim total_comision As Integer = 0
        Dim total_venta As Integer = 0
        Dim comision As Integer = 0
        Dim porc As Double = 0.0


        If txt_porc_comision.Text.Replace(" ", "") = "" Then
            porc = 0
        Else
            porc = txt_porc_comision.Text
        End If

        If txt_total_comision.Text.Replace(" ", "") = "" Then
            total_comision = 0
        Else
            total_comision = CInt(txt_total_comision.Text)
        End If

        If txt_total_venta.Text.Replace(" ", "") = "" Then
            total_venta = 0
        Else
            total_venta = CInt(txt_total_venta.Text)
        End If


        If vr = "PV" Then
            comision = (porc * total_venta) / 100
            txt_total_comision.Text = CStr(comision)
        End If

        If vr = "PO" And total_comision > 0 Then
            porc = (total_comision * 100) / total_venta
            txt_porc_comision.Text = porc
        End If


    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------------

    Private Sub rps_material_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_material.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Enter Then
            Dim frm As New frm_vista_materiales()
            frm.FRM_ACTIVO = "frm_costeo_pedido"
            frm.OCULTAR_COLUMNA = "ST"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
        End If
    End Sub

    Private Sub rps_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se actualiza la cantidad_total en caso de que se haya modificado la cantidad_unt
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "cantidad_total", CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) * CInt(lbl_cantidad_articulo.Text))
            'Enviamos el foco a la columna costo_unitario
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            'Actualizamos los totales
            obtener_totales()
            actualizar_totales()
            obtener_recargo("PO")
        End If
    End Sub

    Private Sub rps_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_costo_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se actualiza la cantidad_total en caso de que se haya modificado la cantidad_unt
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "cantidad_total", CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) * CInt(lbl_cantidad_articulo.Text))
            'Enviamos el foco a la columna costo_unitario
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            'Actualizamos los totales
            obtener_totales()
            actualizar_totales()
            obtener_recargo("PO")

        End If
    End Sub

    Private Sub rps_cantidad_total_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_cantidad_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se actualiza la cantidad_total en caso de que se haya modificado la cantidad_unt
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "cantidad_total", CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) * CInt(lbl_cantidad_articulo.Text))
            'Enviamos el foco a la columna costo_unitario
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            'Actualizamos los totales
            obtener_totales()
            actualizar_totales()
        End If
    End Sub

    Private Sub rps_costo_total_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_costo_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se valida que solo pase el foco a la siguiente fila si aun existen
            If GridView1.FocusedRowHandle <= GridView1.RowCount() Then
                'Se envia el foco a la columna cantidad de la siguiente fila
                GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
                GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                'Actualizamos los totales
                obtener_totales()
                actualizar_totales()
            Else
                obtener_totales()
                actualizar_totales()
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            End If
        End If
    End Sub

    Private Sub btn_agregar_material_Click(sender As Object, e As EventArgs) Handles btn_agregar_material.Click
        Dim frm As New frm_vista_materiales()
        frm.FRM_ACTIVO = "frm_costeo_pedido"
        frm.OCULTAR_COLUMNA = "ST"
        frm.Show()
    End Sub

    Private Sub btn_nuevo_costeo_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        Dim frm As New frm_vista_pedidos
        frm.FRM_ACTIVO = "frm_costeo_pedido"
        frm.CONDICION_SQL = " WHERE p.usr_anulacion IS NULL AND COALESCE(p.facturado,false)=false AND COALESCE(p.entregado,false)=false"
        frm.Show()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If CInt(txt_total_venta.Text) < CInt(txt_total_costo.Text) Then
            util.mensajes("PRECIO VENTA DEBE SER MAYOR A COSTO TOTAL", "VERIFICAR PRECIO VENTA", "WAR")
            txt_precio_venta_unit.Focus()
            Return
        End If

        eliminar_filas_vacias()
        ' obtener_totales()
        'actualizar_totales()
        If validar_cantidad_limite(0) = False Then
            util.mensajes("Cantidad limite asignada a empleados superada", TITULO_MSJ, "WAR")
            TabPane1.SelectedPageIndex = 1
            tab_mano_obra.Focus()
            Return
        End If
        If validar_cantidad_menor() = False Then
            util.mensajes("Cantidad asignada a empleados debe igualar al Pedido", TITULO_MSJ, "WAR")
            TabPane1.SelectedPageIndex = 1
            tab_mano_obra.Focus()
            Return
        End If

        insertar_actualizar()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        If util.msj_confirmacion("Deseas Salir del Costeo de Pedido", TITULO_MSJ) Then
            frm_pedidos.btn_nuevo_pedido.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub btn_quitar_materia_prima_Click(sender As Object, e As EventArgs) Handles btn_quitar_materia_prima.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("No se encontraron items para eliminar", TITULO_MSJ, "WAR")
            Return
        End If

        Dim fila As Integer = GridView1.FocusedRowHandle
        If fila < 0 Then
            util.mensajes("Seleccione Materia Prima a eliminar", TITULO_MSJ, "WAR")
            Return
        End If

        'If CBool(GridView1.GetRowCellValue(fila, "nuevo")) = True Then
        '    util.mensajes("Materia agregada no puede ser eliminado", TITULO_MSJ, "WAR")
        '    Return
        'End If

        If util.msj_confirmacion("Deseas eliminar la Materia Prima", TITULO_MSJ) Then
            GridView1.DeleteRow(fila)
        End If
        obtener_totales()

    End Sub

    Private Sub txt_total_extra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_extra.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            obtener_recargo("PO")
            actualizar_totales()
            txt_total_mano_obra.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub txt_total_extra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_total_extra.Validating
        obtener_totales()
        obtener_recargo("PO")
        actualizar_totales()
    End Sub

    Private Sub txt_total_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_descuento.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            actualizar_totales()
            txt_porc_comision.Focus()

        End If
    End Sub

    Private Sub txt_total_descuento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_total_descuento.Validating
        'obtener_totales()
        'actualizar_totales()
    End Sub

    Private Sub txt_total_mano_obra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_mano_obra.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            obtener_recargo("PO")
            actualizar_totales()
            txt_materia_prima_unidad.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub txt_total_mano_obra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_total_mano_obra.Validating
        obtener_totales()
        obtener_recargo("PO")
        actualizar_totales()
    End Sub

    Private Sub txt_total_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_materia_prima.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            actualizar_totales()
            txt_costo_unitario.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub txt_total_unitario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_total_materia_prima.Validating
        obtener_totales()
        actualizar_totales()
    End Sub

    Private Sub txt_total_pagar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_costo.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            actualizar_totales()
            txt_recargo.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub txt_total_pagar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_total_costo.Validating
        obtener_totales()
        actualizar_totales()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------

    Private Sub txt_nro_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_pedi.Focus()
        End If
    End Sub

    Private Sub txt_fecha_pedi_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_pedi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_mano_obra.Focus()
        End If
    End Sub

    Private Sub txt_mano_obra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mano_obra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_extra.Focus()
        End If
    End Sub

    Private Sub txt_extra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_extra.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cantidad.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GridView2.RowCount() <= 0 Then
                crear_cursor_asignacion()
            End If
            If validar_cantidad_limite(1) = False Then
                grid_asignacion.Focus()
                GridView2.FocusedColumn = GridView2.VisibleColumns(0)
                Return
            End If
            GridView2.AddNewRow()
            grid_asignacion.Focus()
            GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            GridView2.ShowEditor()
        End If
    End Sub

    Private Sub rps_txt_empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_empleado.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If validar_cantidad_limite(1) = False Then
                util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
                Return
            End If

            Dim frm As New frm_vista_empleados
            frm.FRM_ACTIVO = "frm_costeo_pedido"
            frm.Show()
        End If

        If e.KeyCode = Keys.Enter Then
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_empleado")) Then
                util.mensajes("Asigne empleado al pedido", TITULO_MSJ, "WAR")
                Return
            End If
            actualizar_totales()
            GridView2.FocusedColumn = GridView2.VisibleColumns(1)
            GridView2.ShowEditor()
        End If
        eliminar_filas_vacias()
    End Sub

    Private Sub rps_txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView2.FocusedColumn = GridView2.VisibleColumns(1)
            GridView2.FocusedColumn = GridView2.VisibleColumns(2)
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Ingrese Cantidad asignada al empleado", TITULO_MSJ, "WAR")
                Return
            Else
                actualizar_totales()
                If validar_cantidad_limite(0) = False Then
                    util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
                    GridView2.FocusedColumn = GridView2.VisibleColumns(1)
                    Return
                Else
                    GridView2.FocusedColumn = GridView2.VisibleColumns(2)
                End If
            End If
        End If
    End Sub

    Private Sub rps_txt_mano_obra_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_mano_obra.KeyDown
        If e.KeyCode = Keys.Enter Then
            actualizar_totales()
            GridView2.FocusedColumn = GridView2.VisibleColumns(3)
        End If
    End Sub

    Private Sub rps_txt_pago_extra_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_pago_extra.KeyDown
        If e.KeyCode = Keys.Enter Then
            actualizar_totales()
            GridView2.FocusedColumn = GridView2.VisibleColumns(4)
        End If
    End Sub

    Private Sub rps_txt_total_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_empleado")) Then
                util.mensajes("Debe asignar Empleado al pedido", TITULO_MSJ, "WAR")
                Return
            End If
            If IsDBNull(Me.GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Debe asignar Cantidad al empleado", TITULO_MSJ, "WAR")
                Return
            End If
            If validar_cantidad_limite(1) = False Then
                util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
                Return
            End If
            actualizar_totales()
            GridView2.AddNewRow()
            GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            GridView2.ShowEditor()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub grid_asignacion_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_asignacion.KeyDown
        If e.KeyCode = Keys.Insert Then
            If validar_cantidad_limite(1) = False Then
                util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
                Return
            End If
            If GridView2.RowCount <= 0 Then
                crear_cursor_asignacion()
            End If
            GridView2.AddNewRow()
            grid_asignacion.Focus()
            GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            GridView2.ShowEditor()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub btn_quitar_empleado_Click(sender As Object, e As EventArgs) Handles btn_quitar_empleado.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("No se encontraron items para eliminar", TITULO_MSJ, "WAR")
            Return
        End If

        Dim fila As Integer = GridView2.FocusedRowHandle
        If fila < 0 Then
            util.mensajes("Selccione Empleado a eliminar", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas eliminar el empleado", TITULO_MSJ) Then
            If IsDBNull(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_asignacion_pedido_empleado")) Then
                util.mensajes("No se encontrol asignacion de empleado", TITULO_MSJ, "WAR")
                Return
            End If
            asignacion.eliminar(CInt(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "id_asignacion_pedido_empleado")))
            GridView2.DeleteRow(fila)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If validar_cantidad_limite(1) = False Then
            util.mensajes("Cantidad limite alcanzada", TITULO_MSJ, "WAR")
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

    Private Sub txt_porc_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_porc_comision.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            If txt_porc_comision.Text.Replace(" ", "") = "" Then
            Else
                calcular_comision("PV")
                txt_total_comision.Focus()
            End If
        End If
    End Sub

    Private Sub txt_total_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_comision.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_total_comision.Text.Replace(" ", "") = "" Then
            Else
                calcular_comision("PO")
                btn_confirmar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then
            limpiar()
            desabilitar()
        End If
    End Sub

    Private Sub txt_recargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recargo.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            obtener_recargo("PV")
            obtener_totales()
            txt_precio_venta_unit.Focus()
        End If
    End Sub

    Private Sub txt_precio_venta_unit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_precio_venta_unit.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_recargo("PO")
            obtener_totales()
            txt_total_descuento.Focus()

        End If
    End Sub

    Private Sub txt_num_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_pedido.Focus()
        End If
    End Sub

    Private Sub txt_fecha_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cliente.Focus()
        End If
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_extra.Focus()
        End If
    End Sub

    Private Sub txt_materia_prima_unidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_materia_prima_unidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_materia_prima.Focus()
        End If
    End Sub

    Private Sub txt_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_costo.Focus()
        End If
    End Sub

    Private Sub txt_total_venta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_venta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_porc_comision.Focus()
        End If
    End Sub

    Private Sub txt_total_extra_Properties_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_extra.Properties.KeyDown
        e.Handled = True
    End Sub

    Private Sub txt_recargo_Validated(sender As Object, e As EventArgs) Handles txt_recargo.Validated
        obtener_recargo("PV")
        obtener_totales()
        txt_precio_venta_unit.Focus()
    End Sub

    Private Sub txt_precio_venta_unit_Validated(sender As Object, e As EventArgs) Handles txt_precio_venta_unit.Validated
        obtener_recargo("PO")
        obtener_totales()
        txt_total_descuento.Focus()
    End Sub

    Private Sub txt_total_descuento_Validated(sender As Object, e As EventArgs) Handles txt_total_descuento.Validated
        obtener_totales()
        actualizar_totales()
        txt_porc_comision.Focus()
    End Sub

    Private Sub txt_porc_comision_Validated(sender As Object, e As EventArgs) Handles txt_porc_comision.Validated
        calcular_comision("PV")
        txt_total_comision.Focus()
    End Sub

    Private Sub LabelControl6_Click(sender As Object, e As EventArgs) Handles LabelControl6.Click

    End Sub
End Class