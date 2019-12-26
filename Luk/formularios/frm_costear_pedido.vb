
Public Class frm_costear_pedido

    Dim costeo As New func_costeo_pedido
    Dim dt_materiales_articulos As New DataTable
    Dim util As New utilidades
    Dim titulo As String = "Costeo de pedido"
    Public existe_costeo As Boolean = False
    Public id_costeo As Integer = 0
    Dim id_vendedor As Integer = 0
    Dim id_pedido As Integer = 0
    Dim recargo As Double = 0.0








    Public Sub name_articulo(name As String, cantidad As Double)
        LabelControl6.Text = name
        lbl_cantidad_articulo.Text = cantidad

    End Sub


    Public Sub obtiene_recargo(valor As Double)
        txt_recargo.Text = valor
        recargo = valor
    End Sub




    Public Sub set_pedido(numero_pedido As String, cantidad As String, articulo As String, precio_unitario As Integer, id_ven As Integer, recargo As Integer)
        txt_total_extra.Text = 0
        txt_total_descuento.Text = 0
        txt_total_mano_obra.Text = 0
        txt_total_materia_prima.Text = 0
        txt_total_costo.Text = 0
        txt_precio_venta_unt.Text = 0
        txt_porc_comision.Text = 0
        txt_total_comision.Text = 0
        txt_num_pedido.Text = numero_pedido
        lbl_cantidad_articulo.Text = cantidad
        lbl_descripcion_articulo.Text = articulo
        txt_precio_venta_unt.Text = CStr(precio_unitario)
        txt_total_venta.Text = CStr(precio_unitario * cantidad)
        txt_recargo.Text = CStr(recargo)
        id_vendedor = id_ven
    End Sub

    Public Sub obtener_materiales(id_pedido As Integer, accion As String)
        Dim cant As Double
        If lbl_cantidad_articulo.Text.Replace(" ", "") = "" Then
            cant = 0
        Else
            cant = CDbl(lbl_cantidad_articulo.Text)
        End If


        If accion = "U" Then
            dt_materiales_articulos = costeo.consultar("SELECT cp.id_costeo_de_pedido, ci.id_material, m.nombre AS material, ci.cantidad, ci.costo_unitario,
                                                        ((ci.cantidad_articulo * ci.cantidad) * ci.costo_unitario) AS costo_total,
                                                        (ci.cantidad_articulo * ci.cantidad) AS cantidad_total, false AS nuevo,
                                                        0 AS precio_venta, COALESCE(ci.id_proveedor, 0) AS id_proveedor
                                                        FROM costeo_de_pedido cp
                                                        left JOIN costeo_item ci ON ci.id_costeo_de_pedido = cp.id_costeo_de_pedido
                                                        left JOIN materiales m ON m.id_material = ci.id_material
                                                        WHERE cp.id_pedido = " + id_pedido.ToString + "")

            id_costeo = dt_materiales_articulos.Rows(0).Item(0)
            grid_materiales.DataSource = dt_materiales_articulos
            existe_costeo = True
        End If

        If accion = "I" Then
            dt_materiales_articulos = costeo.consultar("SELECT COALESCE(a.costo_mano_obra, 0), am.id_material, m.nombre AS material, am.cantidad AS cantidad, m.costo_unitario, 0 AS descuento, 
                                                    0 AS extra, (m.costo_unitario * (am.cantidad * " + cant.ToString + ")) AS costo_totaL, am.cantidad * " + cant.ToString + " AS cantidad_total, false AS nuevo,
                                                    0 AS precio_venta, COALESCE(m.id_proveedor, 0) AS id_proveedor 
                                                    FROM articulo_materiales am
                                                    left JOIN articulos a ON am.id_articulo = a.id_articulo
                                                    left JOIN materiales m ON am.id_material = m.id_material 
                                                    WHERE am.id_articulo = " + id_pedido.ToString() + "")
            existe_costeo = False
            If dt_materiales_articulos.Rows.Count > 0 Then
                txt_total_mano_obra.Text = CStr(dt_materiales_articulos.Rows(0).Item(0))
                grid_materiales.DataSource = dt_materiales_articulos
            Else
                txt_total_mano_obra.Text = 0
            End If
        End If
    End Sub



    Public Sub actualizar_grilla(cantidad As Integer)
        Dim cant_mp As Double
        Dim costo_mp As Integer
        lbl_cantidad_articulo.Text = cantidad
        For i As Integer = 0 To GridView1.RowCount - 1
            cant_mp = GridView1.GetRowCellValue(i, "cantidad")
            GridView1.SetRowCellValue(i, "cantidad_total", cantidad * cant_mp)

            costo_mp = GridView1.GetRowCellValue(i, "costo_unitario")
            GridView1.SetRowCellValue(i, "costo_total", (cantidad * cant_mp) * costo_mp)
        Next

        obtener_totales()
        obtener_recargo("PO")
        calcular_comision("PO")


    End Sub


    Public Sub obtener_comision(id As Integer)
        Dim dt As New DataTable
        Dim total_venta As Integer = 0
        Dim comision As Integer = 0
        Dim porc As Integer = 0
        id_vendedor = id
        dt = costeo.consultar("SELECT porcentaje_comision FROM vendedores WHERE id_vendedor=" & id.ToString)

        If dt.Rows.Count > 0 Then
            porc = CStr(dt.Rows(0).Item(0))

            If txt_total_venta.Text.Replace(" ", "") = "" Then
                total_venta = 0
            Else
                total_venta = CInt(txt_total_venta.Text)
            End If

            comision = CInt((total_venta * porc) / 100)
            txt_porc_comision.Text = CStr(porc)
            txt_total_comision.Text = CStr(comision)
        End If
    End Sub

    Sub calcular_comision(vr As String)
        Dim total_comision As Integer = 0
        Dim total_venta As Integer = 0
        Dim comision As Integer = 0
        Dim porc As Double = 0


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

    Public Sub obtener_totales()
        Dim total_materia_prima As Integer = 0
        Dim total_costo As Integer = 0
        Dim total_extra As Integer = 0
        Dim mano_obra As Integer = 0
        Dim total_descto As Integer = 0
        Dim comision As Integer = 0
        Dim cantidad_articulo As Integer = 0
        Dim precio_unitario As Integer = 0

        cantidad_articulo = CInt(lbl_cantidad_articulo.Text)

        For i As Integer = 0 To GridView1.RowCount - 1
            total_materia_prima += GridView1.GetRowCellValue(i, "costo_total")
        Next

        'total_materia_prima = total_materia_prima * cantidad_articulo


        If txt_total_extra.Text.Replace(" ", "") = "" Then
            total_extra = 0
        Else
            total_extra = CInt(txt_total_extra.Text)
        End If

        If txt_total_mano_obra.Text.Replace(" ", "") = "" Then
            mano_obra = 0
        Else
            mano_obra = CInt(txt_total_mano_obra.Text)
        End If

        If txt_total_descuento.Text.Replace(" ", "") = "" Then
            total_descto = 0
        Else
            total_descto = CInt(txt_total_descuento.Text)
        End If

        If txt_total_costo.Text.Replace(" ", "") = "" Then
            total_costo = 0
        Else
            total_costo = CInt(txt_total_costo.Text)
        End If

        If txt_total_comision.Text.Replace(" ", "") = "" Then
            comision = 0
        Else
            comision = CInt(txt_total_comision.Text)
        End If

        If lbl_cantidad_articulo.Text.Replace(" ", "") = "" Then
            cantidad_articulo = 0
        Else
            cantidad_articulo = CInt(lbl_cantidad_articulo.Text)
        End If

        If txt_precio_venta_unt.Text.Replace(" ", "") = "" Then
            precio_unitario = 0
        Else
            precio_unitario = CInt(txt_precio_venta_unt.Text)
        End If


        total_costo = (total_extra * cantidad_articulo) + (mano_obra * cantidad_articulo) + total_materia_prima

        txt_materia_prima_por_articulo.Text = total_materia_prima / cantidad_articulo
        txt_total_materia_prima.Text = CStr(total_materia_prima)
        txt_total_costo.Text = CStr(total_costo)
        txt_costo_unitario.Text = (total_costo / CInt(lbl_cantidad_articulo.Text)) - total_descto

        If precio_unitario > 0 Then
            txt_total_venta.Text = (precio_unitario - total_descto) * CInt(lbl_cantidad_articulo.Text)
        End If
    End Sub


    Public Sub obtener_pedido(ByVal id As Integer)
        Dim dt As New DataTable()
        dt = costeo.consultar("SELECT coalesce(total_adicional, 0), coalesce(total_mano_obra, 0), coalesce(costo_unitario, 0), coalesce(costo_total, 0),
                               coalesce(precio_unitario, 0), coalesce(total_precio_venta, 0), coalesce(total_descto, 0), coalesce(comision_vendedor, 0), 
                                id_pedido, id_articulo, estado, cantidad, numero, id_vendedor
                                FROM pedidos 
                                WHERE id_pedido=" + Trim(id.ToString()) + "")

        If dt.Rows.Count <> 0 Then
            id_pedido = CInt(dt.Rows(0).Item(8))
            txt_num_pedido.Text = CStr(dt.Rows(0).Item(12))
            txt_total_extra.Text = CInt(dt.Rows(0).Item(0))
            txt_total_mano_obra.Text = CInt(dt.Rows(0).Item(1))

            txt_materia_prima_por_articulo.Text = CInt(dt.Rows(0).Item(2)) / CInt(dt.Rows(0).Item(11))

            txt_total_materia_prima.Text = CInt(dt.Rows(0).Item(2))
            txt_costo_unitario.Text = CInt(dt.Rows(0).Item(3)) / CInt(dt.Rows(0).Item(11))
            txt_total_costo.Text = CInt(dt.Rows(0).Item(3))
            txt_precio_venta_unt.Text = CInt(dt.Rows(0).Item(4))
            txt_total_venta.Text = CInt(dt.Rows(0).Item(5))
            txt_total_descuento.Text = CInt(dt.Rows(0).Item(6))
            txt_total_comision.Text = CInt(dt.Rows(0).Item(7))
            lbl_cantidad_articulo.Text = CStr(dt.Rows(0).Item(11))
            id_vendedor = CInt(dt.Rows(0).Item(13))


            If dt.Rows(0).Item(10).ToString() = "PENDIENTE" Then
                existe_costeo = False
                obtener_materiales(CInt(dt.Rows(0).Item(9)), "I")
            End If
            If dt.Rows(0).Item(10).ToString() = "COSTEADO" Then
                existe_costeo = True
                obtener_materiales(CInt(dt.Rows(0).Item(8)), "U")
            End If


            calcular_comision("PO")
            obtener_recargo("PO")

            obtener_materiales(CInt(dt.Rows(0).Item(8)), "U")

        Else
            util.mensajes("Pedido no Registrado en Base de Datos", "Costeo", "WAR")
            existe_costeo = False
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

        If txt_precio_venta_unt.Text.Replace(" ", "") = "" Then
            precio_venta = 0
        Else
            precio_venta = CInt(txt_precio_venta_unt.Text)
        End If

        If vr = "PV" Then
            precio_final = ((costo_unitario * porcentaje) / 100) + costo_unitario
            txt_precio_venta_unt.Text = precio_final
            txt_total_venta.Text = precio_final * CInt(lbl_cantidad_articulo.Text) - (txt_total_descuento.Text * lbl_cantidad_articulo.Text)
        End If

        If vr = "PO" And costo_unitario > 0 Then
            porcentaje = ((precio_venta / costo_unitario) * 100) - 100
            precio_final = CInt(txt_precio_venta_unt.Text)
            txt_recargo.Text = porcentaje
            txt_total_venta.Text = precio_final * CInt(lbl_cantidad_articulo.Text) - (txt_total_descuento.Text * lbl_cantidad_articulo.Text)
        End If

    End Sub

    Public Sub add_materiales(ByVal id As Integer)
        Dim dt As New DataTable
        dt = costeo.consultar("SELECT id_material, nombre, costo_unitario, id_proveedor FROM materiales WHERE id_material=" + id.ToString() + "")

        If dt.Rows.Count() <> 0 Then
            'Validamos que el material aun no este agregado al articulo
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "id_material") = dt.Rows(0).Item(0).ToString Then
                    util.mensajes(dt.Rows(0).Item(1).ToString() + ", ya esta asignado al Articulo", titulo, "WAR")
                    Return
                End If
            Next

            Dim row As DataRow = dt_materiales_articulos.NewRow()

            row.Item("id_material") = dt.Rows(0).Item(0)
            row.Item("material") = dt.Rows(0).Item(1)
            row.Item("cantidad") = 0
            row.Item("costo_unitario") = dt.Rows(0).Item(2)
            row.Item("costo_total") = 0
            row.Item("cantidad_total") = 0
            row.Item("nuevo") = True
            row.Item("precio_venta") = 0
            row.Item("id_proveedor") = dt.Rows(0).Item(3)

            dt_materiales_articulos.Rows.Add(row)
            grid_materiales.DataSource = dt_materiales_articulos

            grid_materiales.Refresh()

            'Se manda el foco a la columna cantidad de la fila agregada
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.ShowEditor()
        Else
            util.mensajes("El material seleccionado no existe", titulo, "WAR")
        End If

    End Sub

    Private Sub eliminar_filas_vacias()
        For i As Integer = 0 To GridView1.RowCount
            If IsDBNull(GridView1.GetRowCellValue(i, "id_material")) Then
                GridView1.DeleteRow(i)
            End If
        Next
    End Sub


    Private Sub txt_num_pedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_extra.Focus()
        End If
    End Sub

    Private Sub txt_total_extra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_extra.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            obtener_recargo("PO")
            txt_total_mano_obra.Focus()
        End If
    End Sub

    Private Sub txt_total_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_descuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            txt_porc_comision.Focus()
        End If
    End Sub

    Private Sub txt_total_mano_obra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_mano_obra.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            obtener_recargo("PO")
            txt_materia_prima_por_articulo.Focus()
        End If
    End Sub

    Private Sub txt_materia_prima_por_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_materia_prima_por_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            txt_total_materia_prima.Focus()
        End If
    End Sub

    Private Sub txt_total_materia_prima_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_materia_prima.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_costo_unitario.Focus()
            obtener_totales()
        End If
    End Sub

    Private Sub txt_total_costo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_costo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_recargo.Focus()
            obtener_totales()
        End If
    End Sub

    Private Sub txt_recargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_precio_venta_unt.Focus()
            obtener_totales()
            obtener_recargo("PV")
        End If
    End Sub


    Private Sub txt_precio_venta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_precio_venta_unt.KeyDown
        If e.KeyCode = Keys.Enter Then
            obtener_totales()
            obtener_recargo("PO")
            calcular_comision("PV")

            txt_total_descuento.Focus()
        End If
    End Sub

    Private Sub txt_total_venta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_venta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_porc_comision.Focus()
            obtener_totales()
        End If
    End Sub


    Private Sub txt_porc_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_porc_comision.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_comision.Focus()
            calcular_comision("PV")
            obtener_totales()
        End If
    End Sub

    Private Sub txt_total_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_comision.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
            calcular_comision("PV")
            obtener_totales()
        End If
    End Sub

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
        End If
    End Sub

    Private Sub rps_cantidad_total_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_cantidad_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se actualiza la cantidad_total en caso de que se haya modificado la cantidad_unt
            Dim cantidad_total_m As Double = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad_total")
            Dim costo_unitario_m As Double = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "costo_unitario")
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "costo_total", (costo_unitario_m * cantidad_total_m))
            'Enviamos el foco a la columna costo_unitario
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            'Actualizamos los totales
            obtener_totales()
            obtener_comision(id_vendedor)
            obtener_recargo("PO")


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
            Else
                obtener_totales()
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            End If
        End If
    End Sub

    Private Sub btn_quitar_materia_prima_Click(sender As Object, e As EventArgs) Handles btn_quitar_materia_prima.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("No se encontraron items para eliminar", titulo, "WAR")
            Return
        End If

        Dim fila As Integer = GridView1.FocusedRowHandle
        If fila < 0 Then
            util.mensajes("Seleccione Materia Prima a eliminar", titulo, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas eliminar la Materia Prima", titulo) Then
            GridView1.DeleteRow(fila)
            obtener_totales()
            obtener_recargo("PO")
            calcular_comision("PV")

        End If
    End Sub

    Private Sub btn_agregar_material_Click(sender As Object, e As EventArgs) Handles btn_agregar_material.Click
        Dim frm As New frm_vista_materiales()
        frm.FRM_ACTIVO = "frm_costear_pedido"
        frm.OCULTAR_COLUMNA = "ST"
        frm.Show()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then

            obtener_pedido(id_pedido)
            obtiene_recargo(recargo)
            obtener_totales()
            obtener_recargo("PO")
            obtener_comision(id_vendedor)
            calcular_comision("PO")
            frm_pedidos.obtiene_Recargo_inicial = 0
            Visible = False


        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        obtener_totales()

        If CInt(txt_total_venta.Text) < CInt(txt_total_costo.Text) Then
            util.mensajes("PRECIO VENTA DEBE SER MAYOR A COSTO TOTAL", "VERIFICAR PRECIO VENTA", "WAR")
            txt_precio_venta_unt.Focus()
            Return
        End If


        frm_pedidos.txt_precio_unitario.Text = CInt(txt_precio_venta_unt.Text)
        frm_pedidos.txt_total.Text = CInt(txt_total_venta.Text)
        frm_pedidos.obtiene_Recargo_inicial = 1
        frm_pedidos.id_vendedor_rc = id_vendedor
        Visible = False
    End Sub

    Private Sub txt_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_costo.Focus()
            obtener_totales()
        End If
    End Sub

    Private Sub txt_total_extra_Validated(sender As Object, e As EventArgs) Handles txt_total_extra.Validated
        obtener_totales()
        obtener_recargo("PO")
        txt_total_mano_obra.Focus()
    End Sub

    Private Sub txt_total_mano_obra_Validated(sender As Object, e As EventArgs) Handles txt_total_mano_obra.Validated
        obtener_totales()
        obtener_recargo("PO")
        txt_materia_prima_por_articulo.Focus()
    End Sub

    Private Sub txt_recargo_Validated(sender As Object, e As EventArgs) Handles txt_recargo.Validated
        txt_precio_venta_unt.Focus()
        obtener_totales()
        obtener_recargo("PV")
    End Sub

    Private Sub txt_precio_venta_unt_Validated(sender As Object, e As EventArgs) Handles txt_precio_venta_unt.Validated
        obtener_totales()
        obtener_recargo("PO")
        calcular_comision("PV")

        txt_total_descuento.Focus()
    End Sub

    Private Sub txt_total_descuento_Validated(sender As Object, e As EventArgs) Handles txt_total_descuento.Validated
        obtener_totales()
        txt_porc_comision.Focus()
    End Sub

    Private Sub txt_porc_comision_Validated(sender As Object, e As EventArgs) Handles txt_porc_comision.Validated
        txt_total_comision.Focus()
        calcular_comision("PV")
        obtener_totales()
    End Sub

    Private Sub txt_total_comision_Validated(sender As Object, e As EventArgs) Handles txt_total_comision.Validated
        btn_confirmar.Focus()
        calcular_comision("PV")
        obtener_totales()
    End Sub

    Private Sub frm_costear_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class