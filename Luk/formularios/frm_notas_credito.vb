Public Class frm_notas_credito

    Dim notas_credito As New func_notas_credito
    Dim movim_stock As New func_movimientos_stock
    Dim stock_articulo As New func_stock_articulos
    Dim dt_nota_credito_items As New DataTable

    Dim util As New utilidades
    Dim titulo As String = "Notas de credito"

    Dim id_nota_credito As Integer = 0
    Dim id_comprobante As Integer = 0
    Dim id_transaccion_stock As Integer = 0
    Dim id_sucursal As Integer = 0

    Private Sub frm_notas_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_fecha.Visible = False
        get_transaccion_stock()
    End Sub

    Sub limpiar()
        id_nota_credito = 0
        id_comprobante = 0
        txt_comprobante.Text = ""
        txt_fecha_comp.Text = ""
        txt_total_comp.Text = ""
        txt_fecha.Text = ""
        grid_items_comprobantes.DataSource = Nothing
        txt_comprobante.Focus()
    End Sub

    Sub mostrar_vista(vr As String)
        If vr = "FE" Then
            If cld_fecha.Visible = False Then
                cld_fecha.Visible = True
                cld_fecha.Focus()
            Else
                cld_fecha.Visible = False
            End If
        End If

        If vr = "CM" Then
            Dim frm As New frm_vista_comprobantes
            frm.FRM_ACTIVO = "frm_notas_credito"
            frm.Show()
        End If

    End Sub


    Public Sub get_comprobante(id As Integer)
        Dim dt As New DataTable()
        dt = notas_credito.consultar("select vt.id_venta, vt.numero, vt.fecha_venta, vt.total_venta, vt.id_sucursal, su.nombre
                                      from ventas vt
                                      inner join sucursales su on su.id_sucursal = vt.id_sucursal  
                                      where id_venta=" & id.ToString)

        If dt.Rows.Count <> 0 Then
            id_comprobante = CInt(dt.Rows(0).Item(0))
            txt_comprobante.Text = CStr(dt.Rows(0).Item(1))
            txt_fecha_comp.Text = CStr(dt.Rows(0).Item(2))
            txt_total_comp.Text = CStr(dt.Rows(0).Item(3))
            id_sucursal = CInt(dt.Rows(0).Item(4))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(5))

            get_nota_credito(id_comprobante)
            txt_comprobante.Focus()
        End If
    End Sub

    Public Sub get_nota_credito(id As Integer)
        Dim dt As New DataTable()
        dt = notas_credito.consultar("select id_nota_credito, fecha, estado from notas_credito where id_comprobante=" & id.ToString)

        If dt.Rows.Count <> 0 Then
            id_nota_credito = CInt(dt.Rows(0).Item(0))
            txt_fecha.Text = CStr(dt.Rows(0).Item(1))

            get_items_nota_credito(CStr(id_nota_credito))
        Else
            get_items_venta(CStr(id))
        End If
    End Sub

    Sub get_items_venta(id As String)
        Dim dt As New DataTable()
        dt = notas_credito.consultar("select 0 as id_nota_credito_item, iv.id_articulo, iv.id_proveedor, a.codigo_barras, a.nombre, 
                                                iv.precio_venta, iv.cantidad, (iv.precio_venta * iv.cantidad) as total, iv.costo_unitario
                                                from items_venta iv 
                                                inner join articulos a on a.id_articulo = iv.id_articulo
                                                where iv.id_venta= " & id)

        grid_items_comprobantes.DataSource = dt
    End Sub

    Sub get_items_nota_credito(id As String)
        Dim dt As New DataTable()
        dt = notas_credito.consultar("select it.id_nota_credito_item, a.codigo_barras, it.id_nota_credito_item, a.nombre, 
                                        it.cantidad, it.precio_unitario as precio_venta, 
                                        it.total, it.id_proveedor, it.id_articulo, 'U' as accion, it.costo_unitario
                                        from notas_credito_items it
                                        inner join articulos a on a.id_articulo = it.id_articulo
                                        where it.id_nota_credito= " & id)

        grid_items_comprobantes.DataSource = dt
    End Sub

    Function get_monto_total() As Integer
        Dim monto_total As Integer = 0
        For i As Integer = 0 To GridView1.RowCount - 1
            monto_total += GridView1.GetRowCellValue(i, "total")
        Next

        Return monto_total
    End Function

    Sub confirmar()
        If id_nota_credito <= 0 Then
            insertar_nota_credito()
        Else
            actualizar_nota_credito()
        End If
    End Sub

    Sub insertar_nota_credito()
        If txt_comprobante.Text = "" Then
            util.mensajes("El campo comprobante no puede estar vacio", titulo, "WAR")
            Return
        End If

        If txt_fecha.Text = "  /  /" Then
            util.mensajes("El campo fecha no puede estar vacio", titulo, "WAR")
            Return
        End If

        If id_transaccion_stock <= 0 Then
            util.mensajes("Transacicon de stock no definida", titulo, "WAR")
            Return
        End If

        If GridView1.RowCount <= 0 Then
            util.mensajes("Debe agregar items a la nota de credito", titulo, "WAR")
            Return
        End If

        id_nota_credito = notas_credito.id_nota_credito()
        Dim monto_total As Integer = get_monto_total()
        Dim estado As String = ""
        Dim id_movimiento As Integer = movim_stock.id_movimiento_stock

        If notas_credito.insertar(id_nota_credito, monto_total, id_comprobante) = False Then
            util.mensajes("Nota de credito no registrada", titulo, "WAR")
            Return
        End If

        If movim_stock.insertar_movimiento_stock(id_movimiento, frm_main.ID_SUCURSAL, frm_main.ID_USUARIO, 0, "", 0, 0) = False Then
            util.mensajes("Movimiento de stock no registrado", titulo, "WAR")
            Return
        End If


        Dim id_articulo As Integer = 0
        Dim cantidad As Double = 0
        Dim precio_unitario As Integer = 0
        Dim total As Integer = 0
        Dim id_proveedor As Integer = 0
        Dim id_items_stock As Integer = 0
        Dim costo_unitario As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            id_articulo = CInt(GridView1.GetRowCellValue(i, "id_articulo").ToString)
            cantidad = CDbl(GridView1.GetRowCellValue(i, "cantidad").ToString)
            precio_unitario = CInt(GridView1.GetRowCellValue(i, "precio_venta").ToString)
            total = CInt(GridView1.GetRowCellValue(i, "total").ToString)
            id_proveedor = CInt(GridView1.GetRowCellValue(i, "id_proveedor").ToString)
            costo_unitario = CInt(GridView1.GetRowCellValue(i, "costo_unitario").ToString)
            id_items_stock = movim_stock.id_movim_items_stock()

            If notas_credito.insertar_items(id_nota_credito, id_articulo, cantidad, precio_unitario, total, id_proveedor, costo_unitario) = False Then
                util.mensajes("Items de nota de credito no registrada", titulo, "WAR")
            End If

            If movim_stock.insertar_movim_item_stock(id_movimiento, id_transaccion_stock, "INGRESO", 0, cantidad, costo_unitario, costo_unitario * cantidad, id_articulo, precio_unitario, id_items_stock, id_proveedor) = False Then
                util.mensajes("Item de stock no registrado", titulo, "WAR")
            End If

            If stock_articulo.aumentar_stock(id_articulo, cantidad, "articulo", id_sucursal) = False Then
                util.mensajes("Stock no aumentado", titulo, "WAR")
            End If

        Next
        util.mensajes("Nota de credito registrada", titulo, "INF")
        limpiar()

    End Sub

    Sub actualizar_nota_credito()
        If txt_comprobante.Text = "" Then
            util.mensajes("El campo comprobante no puede estar vacio", titulo, "WAR")
            Return
        End If

        If txt_fecha.Text = "  /  /" Then
            util.mensajes("El campo fecha no puede estar vacio", titulo, "WAR")
            Return
        End If

        If id_transaccion_stock <= 0 Then
            util.mensajes("Transacicon de stock no definida", titulo, "WAR")
            Return
        End If

        If GridView1.RowCount <= 0 Then
            util.mensajes("Debe agregar items a la nota de credito", titulo, "WAR")
            Return
        End If

        Dim monto_total As Integer = get_monto_total()


        If notas_credito.actualizar(id_nota_credito, monto_total) = False Then
            util.mensajes("Nota de credito no actualizada", titulo, "WAR")
            Return
        End If

        Dim id_item_nota_credito As Integer = 0
        Dim cantidad As Double = 0
        Dim precio_unitario As Integer = 0
        Dim total As Integer = 0
        Dim costo_unitario As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            id_item_nota_credito = CInt(GridView1.GetRowCellValue(i, "id_nota_credito_item").ToString)
            cantidad = CDbl(GridView1.GetRowCellValue(i, "cantidad").ToString)
            precio_unitario = CInt(GridView1.GetRowCellValue(i, "precio_venta").ToString)
            total = CInt(GridView1.GetRowCellValue(i, "total").ToString)
            costo_unitario = CInt(GridView1.GetRowCellValue(i, "costo_unitario").ToString)

            If notas_credito.actualizar_items(id_item_nota_credito, cantidad, precio_unitario, total, costo_unitario) = False Then
                util.mensajes("Items de nota de credito no actualizada", titulo, "WAR")
            End If
        Next
        util.mensajes("Nota de credito actualizada", titulo, "INF")
        limpiar()
    End Sub

    Public Sub eliminaritem()
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            util.mensajes("Seleccione item a eliminar", titulo, "WAR")
            Return
        End If

        Dim id_item As Integer = GridView1.GetRowCellValue(rowhandle, "id_nota_credito_item")
        If id_item > 0 Then
            If notas_credito.eliminar_items(id_item) Then
                util.mensajes("Item eliminado", titulo, "INF")
                GridView1.DeleteRow(rowhandle)
            End If
        Else
            GridView1.DeleteRow(rowhandle)
        End If
    End Sub


    Sub get_transaccion_stock()
        Dim dt As New DataTable
        dt = notas_credito.consultar("select id_transaccion from transacciones_stock where relacion='DN'")
        If dt.Rows.Count > 0 Then
            id_transaccion_stock = dt.Rows(0).Item(0)
        Else
            id_transaccion_stock = 0
            btn_confirmar.Enabled = False
            util.mensajes("Transacicon de stock no definida", titulo, "WAR")
        End If
    End Sub

    Private Sub btn_calendar_Click(sender As Object, e As EventArgs) Handles btn_calendar.Click
        mostrar_vista("FE")
        cld_fecha.Focus()
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha.Text = "  /  /" Then
            Else
                btn_confirmar.Focus()
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            cld_fecha.Focus()
            mostrar_vista("FE")
        End If
    End Sub

    Private Sub CalendarControl1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_fecha.Text = cld_fecha.DateTime.ToString
            cld_fecha.Visible = False
            txt_fecha.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            cld_fecha.Visible = False
            txt_fecha.Focus()
        End If
    End Sub

    Private Sub CalendarControl1_DoubleClick_1(sender As Object, e As EventArgs) Handles cld_fecha.DoubleClick
        txt_fecha.Text = cld_fecha.DateTime.ToString
        cld_fecha.Visible = False
        txt_fecha.Focus()
    End Sub

    Private Sub CalendarControl1_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cld_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha.Text = cld_fecha.DateTime.ToString
            cld_fecha.Visible = False
            txt_fecha.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            cld_fecha.Visible = False
            txt_fecha.Focus()
        End If
    End Sub


    Private Sub txt_comprobante_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comprobante.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("CM")
        End If
        If e.KeyCode = Keys.Enter Then
            txt_total_comp.Focus()
        End If
    End Sub

    Private Sub btn_comprobantes_Click(sender As Object, e As EventArgs) Handles btn_comprobantes.Click
        mostrar_vista("CM")
    End Sub

    Private Sub txt_total_comp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_comp.KeyDown
        If e.KeyCode = Keys.Enter And txt_total_comp.Text IsNot "" Then
            txt_fecha_comp.Focus()
        End If
    End Sub

    Private Sub txt_fecha_comp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_comp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "") Then
            limpiar()
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If util.msj_confirmacion("Deseas confirmar la operacion", "") Then
            confirmar()
        End If
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If util.msj_confirmacion("Deseas eliminar el Item?", titulo) Then
            eliminaritem()
        End If
    End Sub

    Private Sub rps_precio_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_precio_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle

            GridView1.FocusedColumn = GridView1.Columns(5)
            GridView1.FocusedColumn = GridView1.Columns(4)
            Dim precio As Integer = GridView1.GetRowCellValue(rowhandle, "precio_venta")
            Dim cantidad As Double = GridView1.GetRowCellValue(rowhandle, "cantidad")

            GridView1.SetRowCellValue(rowhandle, "total", precio * cantidad)
            GridView1.FocusedColumn = GridView1.Columns(5)
        End If
    End Sub

    Private Sub rps_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle

            GridView1.FocusedColumn = GridView1.Columns(6)
            GridView1.FocusedColumn = GridView1.Columns(5)
            Dim precio As Integer = GridView1.GetRowCellValue(rowhandle, "precio_venta")
            Dim cantidad As Double = GridView1.GetRowCellValue(rowhandle, "cantidad")

            GridView1.SetRowCellValue(rowhandle, "total", precio * cantidad)
            GridView1.FocusedColumn = GridView1.Columns(6)
        End If
    End Sub

End Class