Imports DevExpress.XtraReports.UI

Public Class frm_reimpresion_recibos

    Dim titulo As String = "Reimpresion de recibos"
    Dim func_recibo As New func_recibos
    Dim util As New utilidades
    Dim id_recibo As Integer = 0
    Dim numeroLetras As New NumeroLetras

    Private Sub frm_reimpresion_recibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        id_recibo = 0
        txt_numero.Text = ""
        txt_fecha.Text = ""
        txt_cliente.Text = ""
        txt_forma_pago.Text = ""
        txt_monto.Text = ""
        txt_observacion.Text = ""
    End Sub

    Function get_numero(numero As String) As String
        Dim length As Integer = 7
        Dim ceros As String = ""
        Dim num_length As Integer = numero.Length

        If numero.Length < 7 Then
            For i As Integer = 1 To length - num_length
                ceros += "0"
            Next
        End If

        Return ceros & numero
    End Function

    Public Sub obtener_recibo(id As String)

        Dim dt As New DataTable
        dt = func_recibo.consultar("select re.id_recibo, re.numero, re.fecha, coalesce(concat(cl.nombres,' ',cl.apellidos), 'NO DEFINIDO'), coalesce(fp.nombre, 'NO DEFINIDO'), re.monto, re.observacion
                                    from recibos re
                                    left join clientes cl on cl.id_cliente = re.id_cliente
				                    left join formas_pago fp on fp.id_forma_pago = re.id_forma_pago
                                    where re.id_recibo = '" & id & "'")

        If dt.Rows.Count() > 0 Then
            id_recibo = CInt(dt.Rows(0).Item(0))
            txt_numero.Text = CStr(dt.Rows(0).Item(1))
            txt_fecha.Text = CStr(dt.Rows(0).Item(2))
            txt_cliente.Text = CStr(dt.Rows(0).Item(3))
            txt_forma_pago.Text = CStr(dt.Rows(0).Item(4))
            txt_monto.Text = CStr(dt.Rows(0).Item(5))
            txt_observacion.Text = CStr(dt.Rows(0).Item(6))
        Else
            util.mensajes("Recibo no efinido", titulo, "ERR")
            limpiar()
            txt_numero.Focus()
        End If
    End Sub

    Public Sub get_recibos()
        Dim numero As String = get_numero(txt_numero.Text)

        If numero = "" Or numero = "0000000" Then
            util.mensajes("Debe ingresar numero de recibo", titulo, "ERR")
            txt_numero.Focus()
            Return
        End If

        Dim dt As New DataTable
        dt = func_recibo.consultar("select re.id_recibo, re.numero, re.fecha, coalesce(concat(cl.nombres,' ',cl.apellidos), 'NO DEFINIDO'), coalesce(fp.nombre, 'NO DEFINIDO'), re.monto, re.observacion
                                    from recibos re
                                    left join clientes cl on cl.id_cliente = re.id_cliente
				                    left join formas_pago fp on fp.id_forma_pago = re.id_forma_pago
                                    where re.numero = '" & numero & "'")

        If dt.Rows.Count() > 0 Then
            id_recibo = CInt(dt.Rows(0).Item(0))
            txt_numero.Text = CStr(dt.Rows(0).Item(1))
            txt_fecha.Text = CStr(dt.Rows(0).Item(2))
            txt_cliente.Text = CStr(dt.Rows(0).Item(3))
            txt_forma_pago.Text = CStr(dt.Rows(0).Item(4))
            txt_monto.Text = CStr(dt.Rows(0).Item(5))
            txt_observacion.Text = CStr(dt.Rows(0).Item(6))
        Else
            util.mensajes("Recibo no efinido", titulo, "ERR")
            limpiar()
            txt_numero.Focus()
        End If
    End Sub

    Private Sub crear_recibo()
        If id_recibo = 0 Then
            util.mensajes("Debe seleccionar recibo", titulo, "ERR")
            txt_numero.Focus()
        End If
        Dim report As New rpt_recibo

        report.Parameters("empresa").Value = frm_main.EMPRESA
        report.Parameters("telefono").Value = "TEL.: " & frm_main.TELEFONO
        report.Parameters("fecha").Value = txt_fecha.Text
        report.Parameters("total").Value = txt_monto.Text
        report.Parameters("cliente").Value = txt_cliente.Text
        report.Parameters("monto").Value = numeroLetras.Letras(txt_monto.Text.Replace(".", "")).ToUpper
        report.Parameters("concepto").Value = txt_observacion.Text
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


    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then
            get_recibos()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_recibos_all
            frm.FRM_ACTIVO = "frm_reimpresion_recibos"
            frm.Show()
        End If
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_cliente.Focus()
        End If
    End Sub


    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_forma_pago.Focus()
        End If
    End Sub

    Private Sub txt_forma_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_monto.Focus()
        End If
    End Sub

    Private Sub txt_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_observacion.Focus()
        End If
    End Sub

    Private Sub txt_observacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnImprimir.Focus()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        crear_recibo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btn_buscar_recibos_Click(sender As Object, e As EventArgs) Handles btn_buscar_recibos.Click
        Dim frm As New frm_vista_recibos_all
        frm.FRM_ACTIVO = "frm_reimpresion_recibos"
        frm.Show()
    End Sub

End Class