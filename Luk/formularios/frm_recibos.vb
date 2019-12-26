Imports DevExpress.XtraReports.UI

Public Class frm_recibos

    Dim func_recibos As New func_recibos
    Dim util As New utilidades
    Dim numeroLetras As New NumeroLetras
    Dim id_cliente As Integer = 0
    Dim id_forma_pago As Integer = 0
    Public id_control_caja As Integer = 0

    Private Sub frm_recibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_fecha.Visible = False
        obtener_numero_recibo()
    End Sub

    Public Sub limpiar()
        txt_fecha.Text = ""
        txt_cliente.Text = ""
        txt_monto.Text = ""
        txt_observacion.Text = ""
        id_cliente = 0

        obtener_numero_recibo()
    End Sub


    Public Sub obtener_cliente(id As Integer)
        Dim dt As New DataTable
        dt = func_recibos.consultar("SELECT id_cliente, CONCAT(nombres,' ',apellidos) FROM clientes WHERE id_cliente = " + id.ToString + "")

        If dt.Rows.Count > 0 Then
            id_cliente = CInt(dt.Rows(0).Item(0))
            txt_cliente.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_forma_pago(id As Integer)
        Dim dt As New DataTable
        dt = func_recibos.consultar("SELECT id_forma_pago, nombre FROM formas_pago WHERE id_forma_pago = " + id.ToString + "")

        If dt.Rows.Count > 0 Then
            id_forma_pago = CInt(dt.Rows(0).Item(0))
            txt_forma_pago.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_numero_recibo()
        Dim numero As Integer = func_recibos.get_nro_recibo

        txt_numero.Text = formato_numero(numero + 1)
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

    Sub insertar()
        If txt_fecha.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha", "", "WAR")
            Return
        End If
        If id_cliente <= 0 Then
            util.mensajes("Debe seleccionar cliente", "", "WAR")
            Return
        End If
        If id_forma_pago <= 0 Then
            util.mensajes("Debe seleccionar forma de pago", "", "WAR")
            Return
        End If
        If txt_monto.Text = "  /  /" Then
            util.mensajes("Debe ingresar monto", "", "WAR")
            Return
        End If
        If txt_monto.Text = "" Then
            util.mensajes("Debe ingresar observacion", "", "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", "") = False Then
            util.mensajes("Operacion no confirmada", "", "WAR")
            Return
        End If


        If func_recibos.insertar(txt_fecha.Text, id_cliente, txt_observacion.Text, CInt(txt_monto.Text), txt_numero.Text, id_control_caja, id_forma_pago) Then
            util.mensajes("Recibo registrado", "", "INF")
            func_recibos.actualizar_asignacion()
            crear_recibo()
            limpiar()
        Else
            util.mensajes("Recibo no registrado", "", "WAR")
        End If
    End Sub

    Private Sub crear_recibo()
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        insertar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "") = False Then
            Close()
        End If
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha.Text = "  /  /" Then
            Else
                txt_cliente.Focus()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If txt_fecha.Text = "  /  /" Then
            Else
                txt_cliente.Focus()
            End If
        End If
        If e.KeyCode = Keys.Up Then
            If txt_fecha.Text = "  /  /" Then
            Else
                txt_cliente.Focus()
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
                txt_forma_pago.Focus()
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_clientes
            frm.FRM_ACTIVO = "frm_recibos"
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
        frm.FRM_ACTIVO = "frm_recibos"
        frm.Show()
    End Sub

    Private Sub txt_observacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub txt_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_monto.Text IsNot "" Then
                txt_observacion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If id_cliente > 0 Then
                txt_observacion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Up Then
            If id_cliente > 0 Then
                txt_observacion.Focus()
            End If
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

    Private Sub btn_formas_pago_Click(sender As Object, e As EventArgs) Handles btn_formas_pago.Click
        Dim frm As New frm_vista_formas_pago
        frm.frm_recibos = Me
        frm.FRM_ACTIVO = "frm_recibos"
        frm.Show()
    End Sub

    Private Sub txt_forma_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_forma_pago > 0 Then
                txt_monto.Focus()
            End If
        End If

            If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
                Dim frm As New frm_vista_formas_pago
                frm.frm_recibos = Me
                frm.FRM_ACTIVO = "frm_recibos"
                frm.Show()
            End If
    End Sub
End Class