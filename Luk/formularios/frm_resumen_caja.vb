Public Class frm_resumen_caja

    Dim control_caja As New func_control_caja
    Dim util As New utilidades
    Dim id_control As Integer = 0
    Dim total_efectivo As Integer = 0

    Private Sub frm_resumen_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        id_control = 0
        grid_formas_pago.DataSource = Nothing
        grid_comprobantes.DataSource = Nothing
        grid_items_comprobantes.DataSource = Nothing
        grid_extracciones.DataSource = Nothing
        txt_control_caja.Text = ""
        txt_fecha_apertura.Text = ""
        txt_usuario.Text = ""
        txt_monto_inicial.Text = ""
        txt_cantidad_ventas.Text = ""
        txt_total_venta.Text = ""
        txt_descuento.Text = ""
        txt_efectivo_en_caja.Text = ""
        txt_recibos_emitidos.Text = ""
    End Sub

    Public Sub obtener_control(id As String)
        total_efectivo = 0

        Dim dt As New DataTable
        Dim sql As String = "select * from(
                                        select cc.id_control_caja, cc.fecha_apertura,
                                        us.nombre_completo as usuario, coalesce(cc.monto_inicial, 0) as monto_inicial,
                                        coalesce((select count(id_venta) from ventas where id_control_caja=" & id & " and coalesce(anulado, false)=false) , 0) as cantidad_venta,
					                    coalesce((select sum(total_venta -  total_descuento) from ventas where id_control_caja=" & id & " and coalesce(anulado, false)=false) , 0) as total_venta,
                                        coalesce((select sum(total_descuento) from ventas where id_control_caja=" & id & " and coalesce(anulado, false)=false) , 0) as descuento,
                                        coalesce((select sum(monto) from recibos where id_control=" & id & ") , 0) as recibos
                                        from control_caja cc
				                        left join usuarios us on us.id_usuario = cc.id_usuario
				                        where id_control_caja=" & id & "
                                    ) as x"

        dt = control_caja.consultar(sql)

        If dt.Rows.Count() > 0 Then
            id_control = CInt(dt.Rows(0).Item(0))
            txt_fecha_apertura.Text = CStr(dt.Rows(0).Item(1))
            txt_usuario.Text = CStr(dt.Rows(0).Item(2))
            txt_monto_inicial.Text = CStr(dt.Rows(0).Item(3))
            txt_cantidad_ventas.Text = CStr(dt.Rows(0).Item(4))
            txt_total_venta.Text = CStr(dt.Rows(0).Item(5))
            txt_descuento.Text = CStr(dt.Rows(0).Item(6))
            txt_recibos_emitidos.Text = CStr(dt.Rows(0).Item(7))
            txt_control_caja.Text = CStr(id_control)

            obtener_comprobantes(id_control)
            obtener_formas_pago(id_control)
            obtener_extracciones(id_control)

            txt_efectivo_en_caja.Text = CStr(total_efectivo + CInt(txt_monto_inicial.Text))
        End If
    End Sub

    Dim dt_pagos As New DataTable
    Private Sub crear_cursor_pagos()
        dt_pagos = New DataTable
        dt_pagos.Columns.Add("forma_pago")
        dt_pagos.Columns.Add("cantidad")
        dt_pagos.Columns.Add("total")
        grid_formas_pago.DataSource = dt_pagos
    End Sub

    Public Sub obtener_formas_pago(id As String)
        crear_cursor_pagos()

        Dim dt As New DataTable
        dt = control_caja.consultar("select fp.nombre as forma_pago, count(ic.id_forma_pago) as cantidad, sum(importe_recibido) as total, fp.tipo_pago
                                    from items_cobro ic 
                                    left join formas_pago fp on fp.id_forma_pago = ic.id_forma_pago
                                    where ic.id_control_caja=" & id & "
                                    group by fp.nombre, fp.tipo_pago")

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim row As DataRow = dt_pagos.NewRow()

                row.Item("forma_pago") = dt.Rows(i).Item(0)
                row.Item("cantidad") = dt.Rows(i).Item(1)
                row.Item("total") = dt.Rows(i).Item(2)

                If dt.Rows(i).Item(3) = "EF" Then
                    total_efectivo += dt.Rows(i).Item(2)
                End If


                dt_pagos.Rows.Add(row)
                grid_formas_pago.DataSource = dt_pagos
                grid_formas_pago.Refresh()
            Next
        End If

        'recibos emitidos    
        Dim dt_re As New DataTable
        dt_re = control_caja.consultar("select coalesce(sum(monto), 0)
                                        from recibos re
                                        inner join formas_pago fp on fp.id_forma_pago = re.id_forma_pago
                                        where re.id_control=" & CStr(id_control) & " and fp.tipo_pago = 'EF'")

        If dt_re.Rows.Count > 0 Then
            total_efectivo += CInt(dt_re.Rows(0).Item(0))
        End If

        'vueltos
        Dim dt_vu As New DataTable
        dt_vu = control_caja.consultar("select count(ic.id_forma_pago) as cantidad, coalesce(sum(importe_vuelto), 0) as total
                                    from items_cobro ic
                                    where ic.id_control_caja=" & id & " and importe_vuelto > 0")
        If dt_vu.Rows.Count > 0 Then
            If CInt(dt_vu.Rows(0).Item(1)) > 0 Then

                Dim row As DataRow = dt_pagos.NewRow()

                row.Item("forma_pago") = "VUELTOS"
                row.Item("cantidad") = dt_vu.Rows(0).Item(0)
                row.Item("total") = CInt(dt_vu.Rows(0).Item(1)) * (-1)

                total_efectivo -= CInt(dt_vu.Rows(0).Item(1))

                dt_pagos.Rows.Add(row)
                grid_formas_pago.DataSource = dt_pagos
                grid_formas_pago.Refresh()
            End If
        End If
    End Sub

    Public Sub obtener_comprobantes(id As String)
        Dim dt As New DataTable
        dt = control_caja.consultar("select vta.id_venta, vta.numero, concat(cl.nombres,' ',cl.apellidos) as cliente, vta.total_venta as sub_total,
                                    vta.total_descuento as descuento, (vta.total_venta - vta.total_descuento) as total
                                    from ventas vta
                                    left join clientes cl on cl.id_cliente = vta.id_cliente
                                    where vta.id_control_caja=" & id & " and coalesce(anulado, false)=false order by vta.id_venta desc")

        If dt.Rows.Count > 0 Then
            grid_comprobantes.DataSource = dt
        End If
    End Sub

    Public Sub obtener_items_comprobantes(id As String)
        Dim dt As New DataTable
        dt = control_caja.consultar("select ar.codigo_barras, ar.nombre as articulo, iv.cantidad, iv.precio_venta as precio_unitario, iv.total_item as total
                                    from items_venta iv
                                    left join articulos ar on ar.id_articulo = iv.id_articulo
                                    where iv.id_venta = " + id)

        If dt.Rows.Count > 0 Then
            grid_items_comprobantes.DataSource = dt
        End If
    End Sub

    Public Sub obtener_extracciones(id As String)
        Dim dt As New DataTable
        dt = control_caja.consultar("select ee.fecha, us.login, nombre_beneficiario, coalesce(ee.observacion, 'SIN OBSERVACIONES') as observacion, ee.total_monto 
                                    from extraccion_efectivo ee
                                    left join usuarios us on us.id_usuario = ee.id_usuario
                                    where ee.id_control_caja=" + id)

        If dt.Rows.Count > 0 Then
            grid_extracciones.DataSource = dt

            Dim extracciones As Integer = 0
            For i As Integer = 0 To GridView4.RowCount - 1
                extracciones = CInt(GridView4.GetRowCellValue(i, "total_monto"))
            Next

            total_efectivo -= extracciones
        End If
    End Sub

    Sub listar_controles_caja()
        Dim frm As New frm_vista_controles_caja
        frm.FRM_ACTIVO = "frm_resumen_caja"
        frm.Show()
    End Sub

    Private Sub txt_control_caja_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_control_caja.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_control_caja.Text IsNot "" Then
                txt_fecha_apertura.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            listar_controles_caja()
        End If
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_apertura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_apertura.Text IsNot "" Then
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_usuario.Text IsNot "" Then
                txt_cantidad_ventas.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cantidad_ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_ventas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad_ventas.Text IsNot "" Then
                txt_total_venta.Focus()
            End If
        End If
    End Sub

    Private Sub txt_total_venta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_venta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_total_venta.Text IsNot "" Then
                txt_cantidad_ventas.Focus()
            End If
        End If
    End Sub

    Private Sub btn_controles_caja_Click(sender As Object, e As EventArgs) Handles btn_controles_caja.Click
        listar_controles_caja()
    End Sub

    Private Sub GridControl2_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_comprobantes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle = GridView2.FocusedRowHandle
            Dim id_comprobante As String = CStr(GridView2.GetRowCellValue(rowhandle, "id_venta"))
            obtener_items_comprobantes(id_comprobante)
        End If
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles grid_comprobantes.DoubleClick
        Dim rowhandle = GridView2.FocusedRowHandle
        Dim id_comprobante As String = CStr(GridView2.GetRowCellValue(rowhandle, "id_venta"))
        obtener_items_comprobantes(id_comprobante)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion?", "") Then
            limpiar()
        End If
    End Sub

End Class