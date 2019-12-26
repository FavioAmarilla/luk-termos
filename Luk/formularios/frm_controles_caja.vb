Imports DevExpress.XtraReports.UI

Public Class frm_controles_caja

    Private control As New func_control_caja
    Private dt_denominaciones As New DataTable
    Private util As New utilidades

    Private TITULO_MSJ As String = "<Controles de Caja>"

    'Variables a ser utilizadas para el Cierre de Caja
    Private TOTAL_MONTO As Integer = 0
    Private GRAVADA5 As Integer = 0
    Private GRAVADA10 As Integer = 0
    Private GRAVADAS As Integer = 0
    Private IMPUESTO5 As Integer = 0
    Private IMPUESTO10 As Integer = 0
    Private IMPUESTOS As Integer = 0
    Private TRANS_INICIAL As String = ""
    Private TRANS_FINAL As String = ""
    Private EXENTAS As Integer = 0
    Private CANTIDAD_COMPROB As Integer = 0
    Private TOTAL_ANULADO As Integer = 0
    Private EXTRACCIONES As Integer = 0
    Private ID_CONTROL_CAJA As Integer = 0

    'Variables a ser utilizadas para la Declaracion de Efectivo
    Private ID_DENOMINACION As Integer = 0
    Private VALOR As Integer = 0
    Private CANTIDAD As Integer = 0
    Private TOTAL As Integer = 0
    Private TOTAL_DECLARACION As Integer = 0

    'VARIABLES PARA LOS TOTALES POR FORMA DE PAGO
    Private TOTAL_PAGO_EFECTIVO As Integer = 0
    Private TOTAL_PAGO_TARJETAS As Integer = 0
    Private TOTAL_PAGO_VUELTO As Integer = 0

    Private Sub frm_controles_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub obtener_control(id As String)
        txt_fecha_apertura.Text = ""
        grid_denominaciones.DataSource = Nothing

        Dim dt As New DataTable
        dt = control.consultar("SELECT id_control_caja, fecha_apertura, trans_inicial, trans_final FROM control_caja WHERE id_control_caja = " & id)

        If dt.Rows.Count() > 0 Then
            txt_id_control.Text = CStr(dt.Rows(0).Item(0))
            txt_fecha_apertura.Text = CStr(dt.Rows(0).Item(1))
            TRANS_INICIAL = CStr(dt.Rows(0).Item(2))
            TRANS_FINAL = CStr(dt.Rows(0).Item(2))
            obtener_totales(id)
            obtener_extracciones(id)
            total_forma_pago(id)
            obtener_declaracion_control(id)
            obtener_total_declaracion_efectivo()
        End If
        btn_consultar.Focus()
    End Sub

    Private Sub obtener_totales(id As String)
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_venta),0) AS total_monto, COALESCE(SUM(gravado5),0) AS gravada5,COALESCE( SUM(gravado10),0) AS gravada10, 
                                COALESCE(SUM(gravados),0) AS gravadas, COALESCE(SUM(impuesto5),0) AS impuesto5, COALESCE(SUM(impuesto10),0) AS impuesto10, 
                                COALESCE(SUM(impuestos),0) AS impuestos, COALESCE(SUM(exentas),0) AS exentas, COALESCE(COUNT(*),0) AS cantidad_comprob, 
                                COALESCE( (SELECT SUM(total_venta) FROM ventas WHERE id_usr_anulacion IS NOT NULL AND id_control_caja = 4),0) AS total_anulado
                                FROM ventas WHERE id_control_caja = " + id + "")

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
        Else
            TOTAL_MONTO = 0
            GRAVADA5 = 0
            GRAVADA10 = 0
            GRAVADAS = 0
            IMPUESTO5 = 0
            IMPUESTO10 = 0
            IMPUESTOS = 0
            EXENTAS = 0
            CANTIDAD_COMPROB = 0
            TOTAL_ANULADO = 0
        End If
    End Sub

    Private Sub obtener_extracciones(id As String)
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_monto), 0) FROM extraccion_efectivo WHERE id_control_caja = " + id + "")

        If dt.Rows.Count > 0 Then
            EXTRACCIONES = CInt(dt.Rows(0).Item(0))
        Else
            EXTRACCIONES = 0
        End If
    End Sub

    Private Sub obtener_total_declaracion_efectivo()
        For i As Integer = 0 To GridView1.RowCount - 1
            TOTAL_DECLARACION += CInt(GridView1.GetRowCellValue(i, "total"))
        Next
    End Sub

    Private Sub total_forma_pago(id As String)
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(importe_recibido), 0)
                                FROM items_cobro ic
                                INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
                                WHERE ic.id_control_caja= " + id + " AND ic.id_forma_pago= 1")
        If dt.Rows.Count > 0 Then
            TOTAL_PAGO_EFECTIVO = CInt(dt.Rows(0).Item(0))
        End If

        dt = control.consultar("SELECT COALESCE(SUM(importe_recibido), 0)
                                FROM items_cobro ic
                                INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
                                WHERE ic.id_control_caja= " + id + " AND ic.id_forma_pago= 2")
        If dt.Rows.Count > 0 Then
            TOTAL_PAGO_TARJETAS = CInt(dt.Rows(0).Item(0))
        End If

        dt = control.consultar("SELECT COALESCE(SUM(importe_vuelto), 0)
                                FROM items_cobro ic
                                INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
                                WHERE ic.id_control_caja= " + id + "")
        If dt.Rows.Count > 0 Then
            TOTAL_PAGO_VUELTO = CInt(dt.Rows(0).Item(0))
        End If
    End Sub

    Private Sub obtener_declaracion_control(id As String)
        Dim dt As New DataTable

        dt = control.consultar("SELECT dn.nombre, dn.valor, de.cantidad, de.total
                                FROM declaracion_efectivo de
                                INNER JOIN denominaciones_moneda dn ON dn.id_denominacion = de.id_denominacion
                                WHERE id_control_caja = " & id)

        If dt.Rows.Count > 0 Then
            grid_denominaciones.DataSource = dt
        Else
            util.mensajes("No se registraron declaraciones de Efectivo", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Function crear_reporte() As XtraReport

        Dim report As New rpt_resumen_caja

        report.DataSource = grid_denominaciones.DataSource

        report.Parameters("ctrl_numero").Value = txt_id_control.Text
        report.Parameters("fecha_apertura").Value = txt_fecha_apertura.Text
        report.Parameters("fecha_cierre").Value = Now.ToString("dd/MM/yyyy hh:mm:ss")
        report.Parameters("trans_inicial").Value = TRANS_INICIAL
        report.Parameters("trans_final").Value = TRANS_FINAL
        report.Parameters("cantidad_comprob").Value = CANTIDAD_COMPROB
        report.Parameters("total_bruto").Value = TOTAL_MONTO
        report.Parameters("total_anulado").Value = TOTAL_ANULADO
        report.Parameters("impuesto5").Value = IMPUESTO5
        report.Parameters("impuesto10").Value = IMPUESTO10
        report.Parameters("exentas").Value = EXENTAS
        report.Parameters("impuestos").Value = IMPUESTOS
        report.Parameters("gravada5").Value = GRAVADA5
        report.Parameters("gravada10").Value = GRAVADA10
        report.Parameters("gravadas").Value = GRAVADAS
        report.Parameters("extracciones").Value = EXTRACCIONES
        report.Parameters("total_monto").Value = TOTAL_PAGO_EFECTIVO + TOTAL_PAGO_TARJETAS
        report.Parameters("declarado").Value = TOTAL_DECLARACION
        report.Parameters("efectivo").Value = TOTAL_PAGO_EFECTIVO
        report.Parameters("tarjetas").Value = TOTAL_PAGO_TARJETAS
        report.Parameters("vuelto").Value = TOTAL_PAGO_VUELTO
        report.Parameters("diferencia").Value = ((TOTAL_DECLARACION + TOTAL_PAGO_TARJETAS) - (TOTAL_PAGO_EFECTIVO + TOTAL_PAGO_TARJETAS)) - TOTAL_PAGO_VUELTO
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("ctrl_numero").Visible = False
        report.Parameters("fecha_apertura").Visible = False
        report.Parameters("fecha_cierre").Visible = False
        report.Parameters("trans_inicial").Visible = False
        report.Parameters("cantidad_comprob").Visible = False
        report.Parameters("trans_final").Visible = False
        report.Parameters("total_bruto").Visible = False
        report.Parameters("total_monto").Visible = False
        report.Parameters("total_anulado").Visible = False
        report.Parameters("impuesto5").Visible = False
        report.Parameters("impuesto10").Visible = False
        report.Parameters("exentas").Visible = False
        report.Parameters("impuestos").Visible = False
        report.Parameters("gravada5").Visible = False
        report.Parameters("gravada10").Visible = False
        report.Parameters("gravadas").Visible = False
        report.Parameters("extracciones").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False
        report.Parameters("total_monto").Visible = False
        report.Parameters("diferencia").Visible = False
        report.Parameters("efectivo").Visible = False
        report.Parameters("tarjetas").Visible = False
        report.Parameters("vuelto").Visible = False
        report.Parameters("declarado").Visible = False


        Return report
    End Function

    Private Sub btn_controles_caja_Click(sender As Object, e As EventArgs) Handles btn_controles_caja.Click
        Dim frm As New frm_vista_controles_cerrados
        frm.FRM_ACTIVO = "frm_controles_caja"
        frm.Show()
    End Sub

    Private Sub txt_fecha_apertura_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_apertura.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
    End Sub

    Private Sub txt_id_control_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id_control.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_control.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe seleccionar Control de Caja", TITULO_MSJ, "WAR")
                Return
            End If
            obtener_control(txt_id_control.Text)
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_controles_cerrados
            frm.FRM_ACTIVO = "frm_controles_caja"
            frm.Show()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If txt_id_control.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Control de Caja", TITULO_MSJ, "WAR")
            txt_id_control.Focus()
            Return
        End If
        obtener_control(txt_id_control.Text)
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If txt_id_control.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Control de Caja", TITULO_MSJ, "WAR")
            txt_id_control.Focus()
            Return
        End If
        Dim printTool As New ReportPrintTool(crear_reporte)
        printTool.ShowPreview()
    End Sub


End Class