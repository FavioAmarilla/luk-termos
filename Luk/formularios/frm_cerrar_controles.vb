Public Class frm_cerrar_controles

    Private control As New func_control_caja
    Private dt_denominaciones As New DataTable
    Private util As New utilidades

    Private TITULO_MSJ As String = "<Cierre de Caja>"

    'Variables a ser utilizadas para el Cierre de Caja
    Private TOTAL_MONTO As Integer = 0
    Private GRAVADA5 As Integer = 0
    Private GRAVADA10 As Integer = 0
    Private GRAVADAS As Integer = 0
    Private IMPUESTO5 As Integer = 0
    Private IMPUESTO10 As Integer = 0
    Private IMPUESTOS As Integer = 0
    Private TRANS_FINAL As String = ""
    Private EXENTAS As Integer = 0
    Private CANTIDAD_COMPROB As Integer = 0
    Private TOTAL_ANULADO As Integer = 0
    Private EXTRACCIONES As Integer = 0
    Private ID_CONTROL_CAJA As Integer = 0

    Private Sub frm_cerrar_controles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiar()
        txt_id_control.Text = ""
        txt_fecha_apertura.Text = ""
        txt_total_monto.Text = ""
        txt_gravadas5.Text = ""
        txt_gravadas10.Text = ""
        txt_gravadas.Text = ""
        txt_impuesto5.Text = ""
        txt_impuesto10.Text = ""
        txt_impuestos.Text = ""
        txt_total_anulados.Text = ""
        txt_total_comprobantes.Text = ""
        txt_extracciones.Text = ""
        txt_id_control.Focus()
    End Sub

    Public Sub obtener_control(id As String)
        Dim dt As New DataTable
        dt = control.consultar("SELECT id_control_caja, fecha_apertura, COALESCE(total_monto, 0) 
                                FROM control_caja WHERE id_control_caja=" + id)

        If dt.Rows.Count() > 0 Then
            txt_id_control.Text = CStr(dt.Rows(0).Item(0))
            txt_fecha_apertura.Text = CStr(dt.Rows(0).Item(1))
            txt_total_monto.Text = CStr(dt.Rows(0).Item(2))
            obtener_totales()
            obtener_extracciones()
        End If

    End Sub

    Private Sub obtener_totales()
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_venta),0) AS total_monto, COALESCE(SUM(gravado5),0) AS gravada5, COALESCE(SUM(gravado10),0) AS gravada10, 
                                COALESCE(SUM(gravados),0) AS gravadas, COALESCE(SUM(impuesto5),0) AS impuesto5, COALESCE(SUM(impuesto10),0) AS impuesto10, 
                                COALESCE(SUM(impuestos),0) AS impuestos, COALESCE(SUM(exentas),0) AS exentas, COALESCE(COUNT(*),0) AS cantidad_comprob, 
                                COALESCE((SELECT SUM(total_venta) FROM ventas WHERE id_usr_anulacion IS NOT NULL AND id_control_caja = 4),0)
                                AS total_anulado
                                FROM ventas 
                                WHERE id_control_caja = " + txt_id_control.Text + "")

        If dt.Rows.Count > 0 Then
            TOTAL_MONTO = CInt(dt.Rows(0).Item(0))
            GRAVADA5 = CInt(dt.Rows(0).Item(1))
            GRAVADA10 = CInt(dt.Rows(0).Item(2))
            GRAVADAS = CInt(dt.Rows(0).Item(3))
            IMPUESTO5 = CInt(dt.Rows(0).Item(4))
            IMPUESTO10 = CInt(dt.Rows(0).Item(5))
            IMPUESTOS = CInt(dt.Rows(0).Item(6))
            EXENTAS = CInt(dt.Rows(0).Item(7))
            CANTIDAD_COMPROB = CInt(dt.Rows(0).Item(8))
            TOTAL_ANULADO = CInt(dt.Rows(0).Item(9))

            txt_total_monto.Text = TOTAL_MONTO.ToString
            txt_gravadas5.Text = GRAVADA5.ToString
            txt_gravadas10.Text = GRAVADA10.ToString
            txt_gravadas.Text = GRAVADAS.ToString
            txt_impuesto5.Text = IMPUESTO5.ToString
            txt_impuesto10.Text = IMPUESTO10.ToString
            txt_impuestos.Text = IMPUESTOS.ToString
            txt_total_anulados.Text = TOTAL_ANULADO.ToString
            txt_total_comprobantes.Text = CANTIDAD_COMPROB.ToString
        End If
    End Sub

    Private Sub obtener_extracciones()
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_monto), 0) FROM extraccion_efectivo WHERE id_control_caja = " + txt_id_control.Text + "")

        If dt.Rows.Count > 0 Then
            EXTRACCIONES = CInt(dt.Rows(0).Item(0))
            txt_extracciones.Text = CStr(EXTRACCIONES)
        Else
            EXTRACCIONES = 0
            txt_extracciones.Text = ""
        End If
    End Sub

    Private Sub cierre_caja()
        obtener_totales()
        obtener_extracciones()
        TRANS_FINAL = control.trans_final(txt_id_control.Text)
        ID_CONTROL_CAJA = CInt(txt_id_control.Text)

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            Return
        End If

        If control.cierre_caja(TOTAL_MONTO, GRAVADA5, GRAVADA10, GRAVADAS, IMPUESTO5, IMPUESTO10, IMPUESTOS, TRANS_FINAL, EXENTAS, CANTIDAD_COMPROB, TOTAL_ANULADO, ID_CONTROL_CAJA, EXTRACCIONES) Then
            util.mensajes("Cierre de Caja Registrado", TITULO_MSJ, "INF")
            Close()
        Else
            util.mensajes("Cierre de Caja no Registrado", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        cierre_caja()
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then
            limpiar()
            Close()
        End If
    End Sub

    Private Sub btn_controles_Click(sender As Object, e As EventArgs) Handles btn_controles.Click
        Dim frm As New frm_vista_controles_caja
        frm.FRM_ACTIVO = "frm_cerrar_controles"
        frm.Show()
    End Sub

    Private Sub btn_controles_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_controles.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_controles_caja
            frm.FRM_ACTIVO = "frm_cerrar_controles"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            btn_registrar.Focus()
        End If
    End Sub

    Private Sub txt_id_control_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id_control.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_controles_caja
            frm.FRM_ACTIVO = "frm_cerrar_controles"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            btn_registrar.Focus()
        End If
    End Sub

End Class