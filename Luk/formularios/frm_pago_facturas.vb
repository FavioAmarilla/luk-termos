Imports DevExpress.XtraReports.UI

Public Class frm_pago_facturas

    Dim util As New utilidades
    Dim numeroLetras As New NumeroLetras
    Dim id_cliente As Integer = 0
    Dim id_forma_pago As Integer = 0
    Public id_control_caja As Integer = 0

    Dim func_ventas As New func_ventas
    Dim func_recibos As New func_recibos
    Dim func_cobros_caja As New func_cobros_caja

    Private Sub frm_pago_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_fecha.Visible = False
    End Sub

    Sub limpiar()
        id_cliente = 0
        txt_cliente.Text = ""
        txt_fecha.Text = ""
        txt_numero.Text = ""
        txt_total_pagar.Text = ""
        id_forma_pago = 0
        txt_forma_pago.Text = 0
        txt_importe.Text = ""
        txt_vuelto.Text = ""
        gridComprobantes.DataSource = Nothing
    End Sub

    Public Sub obtener_cliente(id As Integer)
        Dim dt As New DataTable
        dt = func_recibos.consultar("SELECT id_cliente, CONCAT(nombres,' ',apellidos) FROM clientes WHERE id_cliente = " + id.ToString + "")

        If dt.Rows.Count > 0 Then
            id_cliente = CInt(dt.Rows(0).Item(0))
            txt_cliente.Text = CStr(dt.Rows(0).Item(1))
            obtener_numero_recibo()
            obtener_comprobantes(id_cliente)
        End If
    End Sub


    Public Sub obtener_numero_recibo()
        Dim numero As Integer = func_recibos.get_nro_recibo

        txt_numero.Text = formato_numero(numero + 1)
    End Sub

    Private Sub crear_recibo()
        Dim report As New rpt_recibo

        report.Parameters("empresa").Value = frm_main.EMPRESA
        report.Parameters("telefono").Value = "TEL.: " & frm_main.TELEFONO
        report.Parameters("fecha").Value = txt_fecha.Text
        report.Parameters("total").Value = txt_total_pagar.Text
        report.Parameters("cliente").Value = txt_cliente.Text
        report.Parameters("monto").Value = numeroLetras.Letras(txt_total_pagar.Text.Replace(".", "")).ToUpper
        report.Parameters("concepto").Value = "COBRO DE FACTURA DE VENTA"
        report.Parameters("numero").Value = "RECIBO Nº " & txt_numero.Text

        report.Parameters("empresa").Visible = False
        report.Parameters("telefono").Visible = False
        report.Parameters("fecha").Visible = False
        report.Parameters("total").Visible = False
        report.Parameters("cliente").Visible = False
        report.Parameters("monto").Visible = False
        report.Parameters("concepto").Visible = False
        report.Parameters("numero").Visible = False


        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub


    Private Function formato_numero(ByVal ultimo_numero As Integer) As String
        Dim longitud As Integer = 7
        Dim n As String = CStr(ultimo_numero)
        Dim diferencia As Integer = longitud - (n.Length)
        Dim ceros As String = ""

        For i As Integer = 1 To diferencia
            ceros += "0"
        Next

        Return ceros + n
    End Function

    Public Sub obtener_comprobantes(cliente As Integer)
        Dim dt As New DataTable
        dt = func_recibos.consultar("select id_venta, numero AS comprobante, fecha_venta, COALESCE(total_venta, 0) AS total_venta, 
                                        COALESCE(total_pagado, 0) AS total_pagado, 0 as monto_pagar,
                                        COALESCE((total_venta - total_pagado), 0) AS saldo, FALSE AS pagar
                                        from ventas where COALESCE(total_pagado, 0) < total_venta AND id_condicion_venta=2 AND id_cliente=" & CStr(cliente))

        If dt.Rows.Count > 0 Then
            gridComprobantes.DataSource = dt
        Else
            util.mensajes("El cliente no tiene facturas pendientes", "Cobro de facturas", "WAR")
            limpiar()
        End If
    End Sub

    Sub obtener_total_pagar()
        Dim total_pagado As Integer = 0
        Dim pagar As Boolean = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            pagar = CBool(GridView1.GetRowCellValue(i, "pagar"))
            If pagar Then
                total_pagado += GridView1.GetRowCellValue(i, "monto_pagar")
            End If
        Next

        txt_total_pagar.Text = total_pagado
    End Sub

    Public Sub obtener_forma_pago(id As Integer)
        Dim dt As New DataTable
        dt = func_recibos.consultar("SELECT id_forma_pago, nombre FROM formas_pago WHERE id_forma_pago = " + id.ToString + "")

        If dt.Rows.Count > 0 Then
            id_forma_pago = CInt(dt.Rows(0).Item(0))
            txt_forma_pago.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub registrar_transaccion()
        If id_cliente <= 0 Then
            util.mensajes("Debe seleccionar cliente", "", "WAR")
            Return
        End If
        If txt_fecha.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha", "", "WAR")
            Return
        End If
        If txt_numero.Text = "" Then
            util.mensajes("Debe ingresar numero de recibo", "", "WAR")
            Return
        End If
        If txt_total_pagar.Text = "" Then
            util.mensajes("Debe ingresar total a pagar", "", "WAR")
            Return
        End If
        If CInt(txt_total_pagar.Text) <= 0 Then
            util.mensajes("Total a pagar debe ser mayor a cero(0)", "", "WAR")
            Return
        End If
        If id_forma_pago <= 0 Then
            util.mensajes("Debe seleccionar forma de pago", "", "WAR")
            Return
        End If
        If txt_importe.Text = "" Then
            util.mensajes("Debe ingresar importe", "", "WAR")
            Return
        End If
        If CInt(txt_importe.Text) <= 0 Then
            util.mensajes("Importe debe ser mayor a cero(0)", "", "WAR")
            Return
        End If

        'registrar recibo
        If func_recibos.insertar(Now.ToString("dd/MM/yyyy"), id_cliente, "", CInt(txt_total_pagar.Text), txt_numero.Text, 0, id_forma_pago) = False Then
            util.mensajes("Recibo no registrado", "Cobro de factura", "WAR")
            Return
        End If

        Dim id_venta As Integer = 0
        Dim total_pagado As Integer = 0
        Dim id_cobro As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            id_venta = GridView1.GetRowCellValue(i, "id_venta")
            total_pagado = GridView1.GetRowCellValue(i, "total_pagado") + GridView1.GetRowCellValue(i, "monto_pagar")

            'actualizar comprobantes
            If func_ventas.actualizar_monto_pagado(id_venta, total_pagado) = False Then
                util.mensajes("Comprobante no actualizado", "Cobro de factura", "WAR")
                Return
            End If

            id_cobro = func_cobros_caja.id_cobro()
            'registrar cobros
            If func_cobros_caja.insertar_cobro(total_pagado, id_venta, frm_main.ID_EMPRESA, frm_main.ID_SUCURSAL, frm_main.ID_USUARIO) = False Then
                util.mensajes("Cobro no registrado", "Cobro de factura", "WAR")
                Return
            End If

            If func_cobros_caja.insertar_item_cobro(id_cobro, id_forma_pago, CInt(txt_importe.Text), CInt(txt_vuelto.Text), "", "", i, 0) = False Then
                util.mensajes("Item de cobro no registrado", "Cobro de factura", "WAR")
                Return
            End If
        Next

        util.mensajes("Cobro registrado", "Cobro de factura", "INF")
        crear_recibo()
        limpiar()
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha.Text = "  /  /" Then
            Else
                txt_total_pagar.Focus()
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If cld_fecha.Visible = True Then
                cld_fecha.Visible = False
            Else
                cld_fecha.Visible = True
                cld_fecha.Focus()
            End If
        End If
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_cliente > 0 Then
                txt_fecha.Focus()
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_clientes
            frm.FRM_ACTIVO = "frm_pago_facturas"
            frm.Show()
        End If
    End Sub

    Private Sub cld_fecha_DoubleClick(sender As Object, e As EventArgs) Handles cld_fecha.DoubleClick
        txt_fecha.Text = cld_fecha.DateTime.ToString
        cld_fecha.Visible = False
        txt_fecha.Focus()
    End Sub

    Private Sub cld_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_fecha.KeyDown
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

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim frm As New frm_vista_clientes
        frm.FRM_ACTIVO = "frm_pago_facturas"
        frm.Show()
    End Sub

    Private Sub txt_total_pagar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_pagar.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_forma_pago.Focus()
        End If
    End Sub

    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total_pagar.Focus()
        End If
    End Sub

    Private Sub btn_formas_pago_Click(sender As Object, e As EventArgs) Handles btn_formas_pago.Click
        Dim frm As New frm_vista_formas_pago
        frm.frm_pago_facturas = Me
        frm.FRM_ACTIVO = "frm_pago_facturas"
        frm.Show()
    End Sub

    Private Sub txt_forma_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_forma_pago > 0 Then
                txt_importe.Focus()
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_formas_pago
            frm.frm_pago_facturas = Me
            frm.FRM_ACTIVO = "frm_pago_facturas"
            frm.Show()
        End If
    End Sub

    Private Sub txt_importe_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_importe.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CInt(txt_importe.Text) < CInt(txt_total_pagar.Text) Then
                util.mensajes("Importe debe ser mayor o igual a total a pagar", "Cobros de factura", "WAR")
                txt_importe.Focus()
            Else
                txt_vuelto.Text = CInt(txt_total_pagar.Text) - CInt(txt_importe.Text)
                txt_vuelto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_vuelto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vuelto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub btn_calendar_Click(sender As Object, e As EventArgs) Handles btn_calendar.Click
        If cld_fecha.Visible = True Then
            cld_fecha.Visible = False
        Else
            cld_fecha.Visible = True
            cld_fecha.Focus()
        End If
    End Sub

    Private Sub rps_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_monto.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Tab Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)

            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            Dim total_venta As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "total_venta"))
            Dim monto_pagar As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "monto_pagar"))
            Dim total_pagado As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "total_pagado"))

            GridView1.SetRowCellValue(rowhandle, "saldo", total_venta - (monto_pagar + total_pagado))
        End If
    End Sub

    Private Sub rps_pagar_CheckStateChanged(sender As Object, e As EventArgs) Handles rps_pagar.CheckStateChanged
        GridView1.FocusedColumn = GridView1.VisibleColumns(4)
        GridView1.FocusedColumn = GridView1.VisibleColumns(5)
        obtener_total_pagar()
    End Sub

    Private Sub txt_importe_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_importe.Validating
        If txt_importe.Text IsNot "" And txt_total_pagar.Text IsNot "" Then
            If CInt(txt_importe.Text) < CInt(txt_total_pagar.Text) Then
                util.mensajes("Importe debe ser mayor o igual a total a pagar", "Cobros de factura", "WAR")
                txt_importe.Focus()
            Else
                txt_vuelto.Text = CInt(txt_total_pagar.Text) - CInt(txt_importe.Text)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        registrar_transaccion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Cobro de facturas") Then
            limpiar()
        End If
    End Sub


End Class