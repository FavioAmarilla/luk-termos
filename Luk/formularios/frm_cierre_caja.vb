Imports DevExpress.XtraReports.UI

Public Class frm_cierre_caja

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
    Private TRANS_INICIAL As String = ""
    Private TRANS_FINAL As String = ""
    Private EXENTAS As Integer = 0
    Private CANTIDAD_COMPROB As Integer = 0
    Private TOTAL_ANULADO As Integer = 0
    Private EXTRACCIONES As Integer = 0
    Private ID_CONTROL_CAJA As Integer = 0
    Private RECIBOS As Integer = 0
    Private RECIBOS_EFECTIVO As Integer = 0
    Private TOTAL_FORMAS_PAGO As Integer = 0

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

    Private Sub frm_cierre_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_control()
        obtener_denominaciones()
    End Sub

    Private Sub crear_cursor()
        dt_denominaciones.Columns.Add("id_denominacion")
        dt_denominaciones.Columns.Add("nombre")
        dt_denominaciones.Columns.Add("valor")
        dt_denominaciones.Columns.Add("cantidad")
        dt_denominaciones.Columns.Add("total")
        grid_denominaciones.DataSource = dt_denominaciones
    End Sub

    Private Sub obtener_denominaciones()
        Dim i As Integer = 0
        crear_cursor()
        dt_denominaciones = control.consultar("SELECT id_denominacion, nombre, valor FROM denominaciones_moneda ORDER BY valor DESC")

        For Each dr As DataRow In dt_denominaciones.Rows
            Dim newRow As DataRow = (TryCast(grid_denominaciones.DataSource, DataTable)).NewRow()
            newRow("id_denominacion") = dt_denominaciones.Rows(i).Item(0)
            newRow("nombre") = dt_denominaciones.Rows(i).Item(1)
            newRow("valor") = dt_denominaciones.Rows(i).Item(2)
            newRow("cantidad") = 0
            newRow("total") = 0
            TryCast(grid_denominaciones.DataSource, DataTable).Rows.Add(newRow)
            grid_denominaciones.RefreshDataSource()
            i += 1
        Next

    End Sub

    Private Sub obtener_control()
        Dim dt As New DataTable
        dt = control.consultar("SELECT id_control_caja, fecha_apertura, trans_inicial FROM control_caja WHERE to_char(fecha_apertura,'yyyy-MM-dd') = '" + Now.ToString("yyyy-MM-dd") + "' AND fecha_cierre IS NULL")

        If dt.Rows.Count() > 0 Then
            txt_id_control.Text = CStr(dt.Rows(0).Item(0))
            txt_fecha_apertura.Text = CStr(dt.Rows(0).Item(1))
            TRANS_INICIAL = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Private Sub obtener_totales()
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_venta),0) AS total_monto, COALESCE(SUM(gravado5),0) AS gravada5,COALESCE( SUM(gravado10),0) AS gravada10, 
                                COALESCE(SUM(gravados),0) AS gravadas, COALESCE(SUM(impuesto5),0) AS impuesto5, COALESCE(SUM(impuesto10),0) AS impuesto10, 
                                COALESCE(SUM(impuestos),0) AS impuestos, COALESCE(SUM(exentas),0) AS exentas, COALESCE(COUNT(*),0) AS cantidad_comprob, 
                                COALESCE( (SELECT SUM(total_venta) FROM ventas WHERE id_usr_anulacion IS NOT NULL AND id_control_caja = " + txt_id_control.Text + "),0) AS total_anulado
                                FROM ventas WHERE id_control_caja = " + txt_id_control.Text + "")

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

    Private Function obtener_formas_pago() As DataTable
        Dim dt As New DataTable
        dt = control.consultar("select fp.tipo_pago, fp.nombre, sum(it.importe_recibido) as total
                                from items_cobro it
                                inner join formas_pago fp on fp.id_forma_pago = it.id_forma_pago
                                where it.id_control_caja = " + txt_id_control.Text + " 
                                group by fp.tipo_pago, fp.nombre")

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item(0) = "RE" Or dt.Rows(i).Item(0) = "EF" Then
                TOTAL_FORMAS_PAGO -= 0
            Else
                TOTAL_FORMAS_PAGO += dt.Rows(i).Item(2)
            End If
        Next


        TOTAL_FORMAS_PAGO = TOTAL_FORMAS_PAGO - TOTAL_PAGO_VUELTO
        Return dt
    End Function

    Private Sub obtener_extracciones()
        Dim dt As New DataTable
        dt = control.consultar("SELECT COALESCE(SUM(total_monto), 0) FROM extraccion_efectivo WHERE id_control_caja = " + txt_id_control.Text + "")

        If dt.Rows.Count > 0 Then
            EXTRACCIONES = CInt(dt.Rows(0).Item(0))
        Else
            EXTRACCIONES = 0
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
            declaracion_efectivo()
            total_forma_pago()
            obtener_recibos()
            util.mensajes("Cierre de Caja Registrado", TITULO_MSJ, "INF")

            crear_reporte()

            Close()
        Else
            util.mensajes("Cierre de Caja no Registrado", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub declaracion_efectivo()
        For i As Integer = 0 To GridView1.RowCount - 1
            ID_DENOMINACION = CInt(GridView1.GetRowCellValue(i, "id_denominacion"))
            VALOR = CInt(GridView1.GetRowCellValue(i, "valor"))
            CANTIDAD = CInt(GridView1.GetRowCellValue(i, "cantidad"))
            TOTAL = CInt(GridView1.GetRowCellValue(i, "total"))

            If CANTIDAD > 0 Then
                If control.declaracion_efectivo(CInt(txt_id_control.Text), frm_main.ID_USUARIO, ID_DENOMINACION, VALOR, CANTIDAD, TOTAL) = False Then
                    util.mensajes("Declaracion de Efectivo no Registrado: " + i.ToString, TITULO_MSJ, "WAR")
                    Return
                End If
                TOTAL_DECLARACION += TOTAL
            End If
        Next
    End Sub

    Private Sub total_forma_pago()
        Dim dt As New DataTable
        'dt = control.consultar("SELECT COALESCE(SUM(importe_recibido - importe_vuelto), 0)
        '                        FROM items_cobro ic
        '                        INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
        '                        WHERE ic.id_control_caja= " + txt_id_control.Text + " AND fp.tipo_pago= 'EF'")
        'If dt.Rows.Count > 0 Then
        '    TOTAL_PAGO_EFECTIVO = CInt(dt.Rows(0).Item(0))
        '    TOTAL_FORMAS_PAGO = CInt(dt.Rows(0).Item(0))

        'End If

        'dt = control.consultar("SELECT COALESCE(SUM(importe_recibido - importe_vuelto), 0)
        '                        FROM items_cobro ic
        '                        INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
        '                        WHERE ic.id_control_caja= " + txt_id_control.Text + " AND fp.tipo_pago= 'TR'")
        'If dt.Rows.Count > 0 Then
        '    TOTAL_PAGO_TARJETAS = CInt(dt.Rows(0).Item(0))
        '    TOTAL_FORMAS_PAGO += CInt(dt.Rows(0).Item(0))
        'End If

        dt = control.consultar("SELECT COALESCE(SUM(importe_vuelto - importe_vuelto), 0)
                                FROM items_cobro ic
                                INNER JOIN formas_pago fp ON fp.id_forma_pago = ic.id_forma_pago
                                WHERE ic.id_control_caja= " + txt_id_control.Text + "")
        If dt.Rows.Count > 0 Then
            TOTAL_PAGO_VUELTO = CInt(dt.Rows(0).Item(0))
        End If
    End Sub

    Private Function obtener_declaracion_control() As DataTable
        Dim dt As New DataTable

        dt = control.consultar("SELECT dn.nombre, dn.valor, de.cantidad, de.total
                                FROM declaracion_efectivo de
                                INNER JOIN denominaciones_moneda dn ON dn.id_denominacion = de.id_denominacion
                                WHERE id_control_caja = " & txt_id_control.Text & " order by dn.valor DESC")

        Return dt
    End Function

    Sub obtener_recibos()
        Dim dt_re As New DataTable
        dt_re = control.consultar("select coalesce(sum(monto), 0) from recibos where id_control=" & txt_id_control.Text)

        If dt_re.Rows.Count > 0 Then
            RECIBOS = dt_re.Rows(0).Item(0)
        End If
    End Sub

    Sub obtener_recibos_efectivo()
        Dim dt_re As New DataTable

        dt_re = control.consultar("select coalesce(sum(monto), 0)
                                        from recibos re
                                        inner join formas_pago fp on fp.id_forma_pago = re.id_forma_pago
                                        where re.id_control=" & txt_id_control.Text & " and fp.tipo_pago = 'EF'")

        ' dt_re = control.consultar("select coalesce(sum(monto), 0) from recibos where id_control=" & txt_id_control.Text)

        If dt_re.Rows.Count > 0 Then
            RECIBOS_EFECTIVO = dt_re.Rows(0).Item(0)
        End If
    End Sub

    Private Sub crear_reporte()

        Dim report As New rpt_resumen_caja
        Dim dt As New DataTable
        dt = obtener_declaracion_control()

        'datatable para subreporte
        Dim dt2 As New DataTable
        dt2 = obtener_formas_pago()

        report.DataSource = dt

        report.Parameters("ctrl_numero").Value = txt_id_control.Text
        report.Parameters("fecha_apertura").Value = txt_fecha_apertura.Text
        report.Parameters("fecha_cierre").Value = Now .ToString("dd/MM/yyyy hh:mm:ss")
        report.Parameters("trans_inicial").Value = TRANS_INICIAL
        report.Parameters("trans_final").Value = TRANS_FINAL
        report.Parameters("recibos").Value = RECIBOS
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
        report.Parameters("total_monto").Value = TOTAL_MONTO
        report.Parameters("declarado").Value = TOTAL_DECLARACION
        report.Parameters("efectivo").Value = TOTAL_PAGO_EFECTIVO
        report.Parameters("tarjetas").Value = TOTAL_PAGO_TARJETAS
        report.Parameters("vuelto").Value = TOTAL_PAGO_VUELTO
        report.Parameters("diferencia").Value = TOTAL_MONTO - ((TOTAL_FORMAS_PAGO + TOTAL_DECLARACION + EXTRACCIONES) - RECIBOS_EFECTIVO)
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("ctrl_numero").Visible = False
        report.Parameters("fecha_apertura").Visible = False
        report.Parameters("fecha_cierre").Visible = False
        report.Parameters("trans_inicial").Visible = False
        report.Parameters("recibos").Visible = False
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


        Dim subreport As New rpt_cierre_caja_formas_pago

        report.XrSubreport1.ReportSource = subreport
        subreport.DataSource = dt2
        subreport.DataMember = "dt"



        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub

    Private Sub txt_fecha_apertura_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_apertura.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_id_control.Focus()
        End If
    End Sub

    Private Sub txt_id_control_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id_control.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedRowHandle = 0
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            GridView1.ShowEditor()
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        cierre_caja()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then
            Close()
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName = "cantidad" Then
                Dim cant As Integer = 0
                Dim valor As Integer = 0

                cant = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad"))
                valor = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "valor"))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "total", valor * cant)
            End If
        Catch ex As Exception
            util.mensajes("CellValueChanged: " + ex.Message, TITULO_MSJ, "ERR")
        End Try
    End Sub


End Class