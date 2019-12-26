Imports System.Threading

Public Class frm_cobros_caja

    Private cobro As New func_cobros_caja
    Private recibo As New func_recibos
    Private util As New utilidades
    Private dt_items_cobro As New DataTable
    Private dt_items_recibos As New DataTable
    Private TITULO_MSJ As String = "<Cobros de Caja>"

    'Variables para las operaciones sobre la tabla cobros
    Private ID_COBRO As Integer = 0
    Private MONTO_TOTAL As Integer = 0
    Private MONTO_TOTAL_PAGAR As Integer = 0
    Private IMPORTE_EFECTIVO As Integer = 0
    Private IMPORTE_DOCUMENTO As Integer = 0
    Private TOTAL_VUELTO As Integer = 0
    Private SALDO As Integer = 0
    Private RECIBIDO As Integer = 0
    Private TOTAL_DESCUENTO As Integer = 0
    Private PORC_DESCUENTO As Double = 0
    Private ID_RECIBO As Integer = 0
    Private NUMERO_RECIBO As String = ""

    'Variables para las operaciones sobre la tabla items_cobro
    Private IT_ID_FORMA_PAGO As Integer = 0
    Private IT_TIPO_PAGO As String = ""
    Private IT_IMPORTE_RECIBIDO As Integer = 0
    Private IT_IMPORTE_VUELTO As Integer = 0
    Private IT_PROCESADORA As String = ""
    Private IT_TIPO_TARJETA As String = ""
    Private TOTAL_RECIBO As Integer = 0

    'Varibles utiles
    Private COBRANDO As Boolean = False
    Private CANTIDAD_ITEMS As Integer = 0
    Friend Shared CERRAR_COBRO As Boolean = False
    Friend Shared CERRAR_FORMULARIO As Boolean = False

    'Variables para Sub Procesos
    Private trd_cerrar As Thread

    Private Sub frm_cobros_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Public Sub set_total_recibo(value As Integer)
        TOTAL_RECIBO = value
    End Sub

    Private Sub inicializar()
        txt_total_venta.Text = frm_ventas.TOTAL_VENTA.ToString
        txt_total_pagar.Text = frm_ventas.TOTAL_VENTA.ToString
        txt_total_saldo.Text = frm_ventas.TOTAL_VENTA.ToString
        txt_total_recibido.Text = "0"
        txt_total_vuelto.Text = "0"

        grid_cobros.DataSource = Nothing
        panel_tarjetas.Visible = False
        btnRecibos.Visible = False

        txt_forma_pago.Focus()
    End Sub

    Private Sub crear_cursor()
        dt_items_cobro = New DataTable

        dt_items_cobro.Columns.Add("id_forma_pago")
        dt_items_cobro.Columns.Add("forma_pago")
        dt_items_cobro.Columns.Add("importe")
        dt_items_cobro.Columns.Add("nro_item")
        dt_items_cobro.Columns.Add("tipo_pago")
        dt_items_cobro.Columns.Add("id_recibo")

        grid_cobros.DataSource = dt_items_cobro
    End Sub

    Private Sub crear_cursor_recibos()
        dt_items_cobro = New DataTable

        dt_items_recibos.Columns.Add("id_recibo")
        dt_items_recibos.Columns.Add("numero")
        dt_items_recibos.Columns.Add("monto")

        grid_recibos.DataSource = dt_items_recibos
    End Sub

    Private Sub limpiar()
        txt_forma_pago.Text = ""
        txt_importe.Text = ""

        txt_nro_boleta.Text = ""
        cbo_procesadora.SelectedIndex = 0
        cbo_tipo_tarjeta.SelectedIndex = 0

        txt_forma_pago.Focus()
        panel_tarjetas.Visible = False
        ID_RECIBO = 0
    End Sub

    Public Sub obtener_forma_pago(id As String)
        Dim dt As New DataTable
        dt = cobro.consultar("SELECT id_forma_pago, nombre, tipo_pago FROM formas_pago WHERE id_forma_pago=" + id + "")

        If dt.Rows.Count > 0 Then
            IT_ID_FORMA_PAGO = CInt(dt.Rows(0).Item(0))
            txt_forma_pago.Text = CStr(dt.Rows(0).Item(1))

            If IsDBNull(dt.Rows(0).Item(2)) Then
                IT_TIPO_PAGO = ""
            Else
                IT_TIPO_PAGO = CStr(dt.Rows(0).Item(2))
            End If

            If IT_TIPO_PAGO = "RE" Then
                btnRecibos.Visible = True
            Else
                btnRecibos.Visible = False
            End If
        End If
    End Sub

    Public Sub obtener_recibo(id As String)
        Dim dt As New DataTable
        dt = cobro.consultar("SELECT id_recibo, coalesce(monto, 0), numero FROM recibos WHERE id_recibo=" & id)

        If dt.Rows.Count > 0 Then
            ID_RECIBO = CInt(dt.Rows(0).Item(0))
            txt_importe.Text = CInt(dt.Rows(0).Item(1))
            NUMERO_RECIBO = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Private Function insertar_cobro() As Boolean
        'Se valida que importe sea mayor a cero(0)
        If txt_importe.Text.Replace(" ", "") = "" Then
            util.mensajes("Importe debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
            Return False
        End If

        ID_COBRO = cobro.id_cobro()
        IMPORTE_DOCUMENTO = 0
        IMPORTE_EFECTIVO = 0
        MONTO_TOTAL = frm_ventas.TOTAL_VENTA
        MONTO_TOTAL_PAGAR = txt_total_pagar.Text
        TOTAL_VUELTO = 0
        SALDO = CInt(txt_total_saldo.Text)
        CANTIDAD_ITEMS = 0

        If cobro.insertar_cobro(frm_ventas.TOTAL_VENTA, frm_ventas.ID_VENTA, frm_main.ID_EMPRESA, frm_main.ID_SUCURSAL, frm_main.ID_USUARIO) = False Then
            util.mensajes("Cobro de caja no Registrado", TITULO_MSJ, "WAR")
            Return False
        End If

        COBRANDO = True
        crear_cursor()
        crear_cursor_recibos()

        Return True
    End Function

    Private Function insertar_item_cobro() As Boolean
        'Se valida que se haya seleccionado una forma de pago
        If IT_ID_FORMA_PAGO <= 0 Then
            util.mensajes("Debe selecccionar forma de pago", TITULO_MSJ, "WAR")
            txt_forma_pago.Focus()
            Return False
        End If

        'si forma de pago es recibo se debe vlaidar que se haya seleccionado un recibo
        If IT_ID_FORMA_PAGO <= 0 Then
            util.mensajes("Debe selecccionar un recibo", TITULO_MSJ, "WAR")
            btnRecibos.Focus()
            Return False
        End If

        'Se valida que importe sea mayor a cero(0)
        If txt_importe.Text.Replace(" ", "") = "" Then
            util.mensajes("Importe debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
            txt_importe.Focus()
            Return False
        End If

        'Se obtienen los valores
        IT_IMPORTE_RECIBIDO = CInt(txt_importe.Text)
        If IT_IMPORTE_RECIBIDO > CInt(txt_total_saldo.Text) Then
            IT_IMPORTE_VUELTO = IT_IMPORTE_RECIBIDO - CInt(txt_total_saldo.Text)
        End If
        If IT_TIPO_PAGO = "EF" Or IT_TIPO_PAGO = "DC" Then
            IT_PROCESADORA = ""
            IT_TIPO_TARJETA = ""
        End If
        If IT_TIPO_PAGO = "TR" Then
            IT_PROCESADORA = cbo_procesadora.SelectedItem.ToString
            IT_TIPO_TARJETA = cbo_tipo_tarjeta.SelectedItem.ToString
        End If

        If txt_descuento.Text.Replace(" ", "") IsNot "" Then
            TOTAL_DESCUENTO = CInt(txt_descuento.Text)
        End If

        If txt_porc_descuento.Text.Replace(" ", "") IsNot "" Then
            PORC_DESCUENTO = CInt(txt_porc_descuento.Text)
        End If

        'Se obtiene los totales y se actualiza la cabezera de la venta
        obtener_totales(IT_IMPORTE_RECIBIDO, IT_IMPORTE_VUELTO)

        'Se registra el item en la base de datos
        If cobro.insertar_item_cobro(ID_COBRO, IT_ID_FORMA_PAGO, IT_IMPORTE_RECIBIDO, IT_IMPORTE_VUELTO, IT_PROCESADORA, IT_TIPO_TARJETA, CANTIDAD_ITEMS, frm_ventas.ID_CONTROL_CAJA) = False Then
            util.mensajes("Items de Cobro no registrado", TITULO_MSJ, "WAR")
            Return False
        End If

        'Se actualizan los totales de la cabezera
        If cobro.actualizar_totales_cobro(IMPORTE_EFECTIVO, IMPORTE_DOCUMENTO, TOTAL_VUELTO, TOTAL_DESCUENTO, PORC_DESCUENTO, ID_COBRO) = False Then
            util.mensajes("Total descuento de cobro no actualizado", TITULO_MSJ, "WAR")
            Return False
        End If

        'Se actualizan los totales de descuento de la venta
        If cobro.actualizar_descuento_ventas(TOTAL_DESCUENTO, PORC_DESCUENTO, frm_ventas.ID_VENTA) = False Then
            util.mensajes("Total descuento de venta no actualizado", TITULO_MSJ, "WAR")
            Return False
        End If

        'se actualiza estado de recibo en caso de utilizarse
        If IT_TIPO_PAGO = "RE" Then
            If recibo.actualizar_recibo(ID_RECIBO, True, frm_ventas.ID_PEDIDO, frm_ventas.ID_VENTA) = False Then
                util.mensajes("Recibo no actualizado", TITULO_MSJ, "WAR")
                Return False
            End If
        End If

        'Se agrega el registro a la grilla
        Dim newRow As DataRow = (TryCast(grid_cobros.DataSource, DataTable)).NewRow()
        newRow("id_forma_pago") = IT_ID_FORMA_PAGO
        newRow("forma_pago") = txt_forma_pago.Text
        newRow("importe") = IT_IMPORTE_RECIBIDO
        newRow("nro_item") = CANTIDAD_ITEMS
        newRow("tipo_pago") = IT_TIPO_PAGO
        newRow("id_recibo") = ID_RECIBO
        TryCast(grid_cobros.DataSource, DataTable).Rows.Add(newRow)
        grid_cobros.RefreshDataSource()

        If IT_TIPO_PAGO = "RE" Then
            agregar_recibo(ID_RECIBO, NUMERO_RECIBO, IT_IMPORTE_RECIBIDO)
        End If

        limpiar()

        Return True
    End Function

    Private Sub eliminar_pago()
        Dim fila As Integer = GridView1.FocusedRowHandle

        If fila < 0 Then
            util.mensajes("Debe seleccionar Cobro", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas eliminar el Cobro", TITULO_MSJ) = False Then
            util.mensajes("Cobro no eliminado", TITULO_MSJ, "WAR")
            Return
        End If

        Dim imp As Integer = CInt(GridView1.GetRowCellValue(fila, "importe"))
        Dim nro As Integer = CInt(GridView1.GetRowCellValue(fila, "nro_item"))
        Dim tipo As String = CStr(GridView1.GetRowCellValue(fila, "tipo_pago"))
        Dim id_rec As Integer = CInt(GridView1.GetRowCellValue(fila, "id_recibo"))

        If cobro.eliminar_item_cobro(ID_COBRO, nro) Then
            util.mensajes("Item de cobro eliminado", TITULO_MSJ, "INF")
            MONTO_TOTAL = MONTO_TOTAL - imp
            SALDO = SALDO + imp
            CANTIDAD_ITEMS = CANTIDAD_ITEMS - 1
            If tipo = "EF" Or IT_TIPO_PAGO = "DC" Then
                IMPORTE_EFECTIVO = IMPORTE_EFECTIVO - imp
            End If
            If tipo = "TR" Or IT_TIPO_PAGO = "RE" Then
                IMPORTE_DOCUMENTO = IMPORTE_DOCUMENTO - imp
            End If
            If tipo = "RE" Then
                Dim recibo_id As Integer = 0
                For i As Integer = 0 To GridView2.RowCount
                    recibo_id = CInt(GridView2.GetRowCellValue(i, "id_recibo"))
                    If id_rec = recibo_id Then
                        If recibo.actualizar_recibo(recibo_id, False, 0, 0) = False Then
                            util.mensajes("Recibo no actualizado", TITULO_MSJ, "WAR")
                        End If
                        GridView2.DeleteRow(i)
                    End If
                Next

                If recibo.actualizar_recibo(id_rec, False, 0, 0) = False Then
                    util.mensajes("Recibo no actualizado", TITULO_MSJ, "WAR")
                End If
            End If
        Else
            util.mensajes("Cobro no Eliminado", TITULO_MSJ, "WAR")
        End If

        txt_total_saldo.Text = CStr(SALDO.ToString)
        txt_total_vuelto.Text = CStr(TOTAL_VUELTO.ToString)
        txt_total_recibido.Text = CStr(IMPORTE_EFECTIVO.ToString)
        limpiar()
        GridView1.DeleteRow(fila)
        txt_forma_pago.Focus()
    End Sub


    Private Sub eliminar_recibo()
        Dim fila As Integer = GridView2.FocusedRowHandle

        If fila < 0 Then
            util.mensajes("Debe seleccionar Recibo", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas eliminar el recibo", TITULO_MSJ) = False Then
            util.mensajes("Cobro no eliminado", TITULO_MSJ, "WAR")
            Return
        End If

        Dim id_eliminar = CInt(GridView2.GetRowCellValue(fila, "id_recibo"))
        Dim recibo_id As Integer = 0

        For i As Integer = 0 To GridView1.RowCount
            recibo_id = CInt(GridView1.GetRowCellValue(i, "id_recibo"))
            If id_eliminar = recibo_id Then
                Dim imp As Integer = CInt(GridView1.GetRowCellValue(i, "importe"))
                Dim nro As Integer = CInt(GridView1.GetRowCellValue(i, "nro_item"))
                Dim tipo As String = CStr(GridView1.GetRowCellValue(i, "tipo_pago"))

                If cobro.eliminar_item_cobro(ID_COBRO, nro) Then
                    util.mensajes("Item de cobro eliminado", TITULO_MSJ, "INF")
                    MONTO_TOTAL = MONTO_TOTAL - imp
                    SALDO = SALDO + imp
                    CANTIDAD_ITEMS = CANTIDAD_ITEMS - 1
                    IMPORTE_DOCUMENTO = IMPORTE_DOCUMENTO - imp

                    If recibo.actualizar_recibo(recibo_id, False, 0, 0) = False Then
                        util.mensajes("Recibo no actualizado", TITULO_MSJ, "WAR")
                    End If
                    GridView1.DeleteRow(i)
                Else
                    util.mensajes("Item de cobro no eliminado", TITULO_MSJ, "INF")
                End If
            End If
        Next


        txt_total_saldo.Text = CStr(SALDO.ToString)
        txt_total_vuelto.Text = CStr(TOTAL_VUELTO.ToString)
        txt_total_recibido.Text = CStr(IMPORTE_EFECTIVO.ToString)
        GridView2.DeleteRow(fila)
        limpiar()
        txt_forma_pago.Focus()
    End Sub

    Sub agregar_recibo(id_recibo As Integer, numero As String, monto As Integer)
        Dim newRow As DataRow = (TryCast(grid_recibos.DataSource, DataTable)).NewRow()
        newRow("id_recibo") = id_recibo
        newRow("numero") = numero
        newRow("monto") = monto
        TryCast(grid_recibos.DataSource, DataTable).Rows.Add(newRow)
        grid_recibos.RefreshDataSource()
    End Sub

    Private Sub obtener_totales(importe As Integer, vuelto As Integer)
        If IT_TIPO_PAGO = "TR" Or IT_TIPO_PAGO = "RE" Then
            IMPORTE_DOCUMENTO += importe
        End If
        If IT_TIPO_PAGO = "EF" Or IT_TIPO_PAGO = "DC" Then
            IMPORTE_EFECTIVO += importe
        End If

        If importe < MONTO_TOTAL_PAGAR Then
            TOTAL_VUELTO += vuelto
        End If

        If importe > MONTO_TOTAL_PAGAR Then
            TOTAL_VUELTO = importe - MONTO_TOTAL_PAGAR
        End If

        SALDO = SALDO - importe
        If SALDO < 0 Then
            SALDO = 0
        End If

        CANTIDAD_ITEMS += 1

        txt_total_saldo.Text = CStr(SALDO.ToString)
        txt_total_vuelto.Text = CStr(TOTAL_VUELTO.ToString)
        txt_total_recibido.Text = CStr(IMPORTE_EFECTIVO.ToString)
    End Sub

    Public Sub cerrar()
        frm_ventas.generar_movim_stock()
        Thread.Sleep(500)
        frm_ventas.generar_comision_vendedor()
        limpiar()
        Close()
    End Sub

    'MODULO DE DESCUENTO POR VENTA
    'CALCULAR EL DESCUENTO A PARTIR DE UN PORCENTAJE
    Sub get_descuento()
        If GridView1.RowCount > 0 Then
            util.mensajes("Yo se ingresaron pagos, no puede aplicar descuento", TITULO_MSJ, "WAR")
            Return
        End If

        Dim porcentaje As Double = 0
        Dim total As Integer = 0
        Dim descuento As Integer = 0

        If txt_porc_descuento.Text.Replace(" ", "") = "" Then
            txt_porc_descuento.Text = "0"
            txt_descuento.Text = "0"
            Return
        Else
            porcentaje = CDbl(txt_porc_descuento.Text)
        End If

        If txt_total_venta.Text.Replace(" ", "") = "" Then
            txt_porc_descuento.Text = "0"
            txt_descuento.Text = "0"
            Return
        Else
            total = CInt(txt_total_venta.Text)
        End If

        descuento = (porcentaje * total) / 100
        txt_descuento.Text = CInt(descuento)
        txt_total_pagar.Text = CInt(total - descuento)
        txt_total_saldo.Text = CInt(total - descuento)

        txt_descuento.Focus()
    End Sub

    Sub get_porc_descuento()
        If GridView1.RowCount > 0 Then
            util.mensajes("Yo se ingresaron pagos, no puede aplicar descuento", TITULO_MSJ, "WAR")
            Return
        End If

        Dim total As Integer = 0
        Dim descuento As Integer = 0
        Dim porcentaje As Double = 0

        If txt_total_venta.Text.Replace(" ", "") = "" Then
            txt_porc_descuento.Text = "0"
            txt_descuento.Text = "0"
            Return
        Else
            total = CInt(txt_total_venta.Text)
        End If

        If txt_descuento.Text.Replace(" ", "") = "" Then
            txt_porc_descuento.Text = "0"
            txt_descuento.Text = "0"
            Return
        Else
            descuento = CInt(txt_descuento.Text)
        End If

        porcentaje = (descuento * 100) / total
        txt_porc_descuento.Text = CDbl(porcentaje)

        descuento = (porcentaje * total) / 100
        txt_total_pagar.Text = CInt(total - descuento)
        txt_total_saldo.Text = CInt(total - descuento)

        txt_descuento.Focus()
    End Sub


    Function get_condicion_recibos() As String
        If GridView2.RowCount > 0 Then
            Dim condicion As String = ""
            Dim id_Recibo As Integer = 0

            For i As Integer = 0 To GridView2.RowCount - 1
                recibo = GridView2.GetRowCellValue(i, "id_recibo")
                condicion += " and id_recibo <> " & CStr(id_Recibo)
            Next
            Return condicion
        Else
            Return ""
        End If

    End Function

    Private Sub txt_forma_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_forma_pago.Text.Replace(" ", "") = "" Then
            Else
                txt_importe.Focus()
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_formas_pago
            frm.FRM_ACTIVO = "frm_cobros_caja"
            frm.Show()
        End If

    End Sub

    Private Sub btn_forma_pago_Click(sender As Object, e As EventArgs) Handles btn_forma_pago.Click
        Dim frm As New frm_vista_formas_pago
        frm.FRM_ACTIVO = "frm_cobros_caja"
        frm.Show()
    End Sub

    Private Sub txt_importe_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_importe.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_importe.Text.Replace(" ", "") = "" Then
            Else
                If IT_TIPO_PAGO = "EF" Or IT_TIPO_PAGO = "DC" Then
                    panel_tarjetas.Visible = False
                    btn_aceptar.Focus()
                End If
                If IT_TIPO_PAGO = "TR" Then
                    panel_tarjetas.Visible = True
                    txt_nro_boleta.Focus()
                End If
                If IT_TIPO_PAGO = "RE" Then
                    btn_aceptar.Focus()
                End If
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If IT_TIPO_PAGO = "RE" Then
                Dim frm As New frm_vista_recibos
                frm.FRM_ACTIVO = "frm_cobros_caja"
                frm.setIdCliente(frm_ventas.ID_CLIENTE)
                frm.Show()
            End If
        End If
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            Return
        End If

        'Se agregan solamente los items de cobro
        If COBRANDO Then
            If insertar_item_cobro() = False Then
                util.mensajes("Item de cobro no registrado", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        'Si es un nuevo cobro
        If COBRANDO = False Then
            If insertar_cobro() = False Then
                util.mensajes("Cabezera de Cobro no registrado", TITULO_MSJ, "WAR")
                Return
            End If
            If insertar_item_cobro() = False Then
                util.mensajes("Item de cobro no registrado", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        'Finalizacion de Venta
        If CInt(txt_total_saldo.Text) <= 0 Then
            Dim frm As New frm_vuelto
            frm.setVuelto(txt_total_vuelto.Text & "  Gs.")
            frm.Show()
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) = False Then
            Return
        End If
        If GridView1.RowCount > 0 Then
            util.mensajes("Cobro en proceso", TITULO_MSJ, "WAR")
            Return
        End If
        Close()
    End Sub

    Private Sub txt_nro_boleta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_boleta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_boleta.Text.Replace(" ", "") = "" Then
            Else
                cbo_procesadora.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_procesadora_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_procesadora.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipo_tarjeta.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_tarjeta_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_tarjeta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar.Focus()
        End If
    End Sub

    Private Sub btn_eliminar_cobro_Click(sender As Object, e As EventArgs) Handles btn_eliminar_cobro.Click
        eliminar_pago()
    End Sub

    Private Sub txt_porc_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_porc_descuento.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            get_descuento()
            txt_descuento.Focus()
        End If
    End Sub

    Private Sub txt_descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_descuento.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            get_porc_descuento()
            txt_forma_pago.Focus()
        End If
    End Sub

    Private Sub btn_comision_vendedor_Click(sender As Object, e As EventArgs) Handles btn_comision_vendedor.Click
        frm_comision_vendedor.Show()
        frm_comision_vendedor.set_total_venta(CInt(txt_total_venta.Text))
    End Sub

    Private Sub btnRecibos_Click(sender As Object, e As EventArgs) Handles btnRecibos.Click
        Dim frm As New frm_vista_recibos
        frm.FRM_ACTIVO = "frm_cobros_caja"
        frm.setIdCliente(frm_ventas.ID_CLIENTE)
        frm.setCondicion(get_condicion_recibos())
        frm.setVerificador("POS")
        frm.Show()
    End Sub

    Private Sub btnEliminarRecibo_Click(sender As Object, e As EventArgs) Handles btnEliminarRecibo.Click
        eliminar_recibo()
    End Sub
End Class