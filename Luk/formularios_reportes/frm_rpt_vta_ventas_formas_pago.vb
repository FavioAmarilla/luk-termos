Imports DevExpress.XtraReports.UI

Public Class frm_rpt_vta_ventas_formas_pago

    Dim util As New utilidades
    Dim TITULO_MSJ As String = "Reporte"
    Dim ventas As New func_ventas
    Dim dt_ventas As New DataTable
    Dim id_sucursal As Integer = 0

    Private Sub frm_rpt_vta_ventas_formas_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
    End Sub


    Private Sub consultar()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim orden As String = " group by cc.fecha, coalesce(fp.nombre, 'NO DEFINIDO'), ic.tipo_tarjeta, ic.procesadora, fp.nombre order by cc.fecha, fp.nombre asc"
        Dim sucursal As String = ""

        If id_sucursal <= 0 Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        End If

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe seleccionar fecha desde", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe seleccionar fecha hasta", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If

        dt_ventas = ventas.consultar("select vt.numero, concat(vt.numero,'  Total: ',vt.total_venta,'  Cliente: ',cl.nombres,' ',cl.apellidos) as comprobante, 
                                        fp.nombre as forma_pago, count(ic.importe_recibido) as cantidad, sum(ic.importe_recibido - coalesce(ic.importe_vuelto, 0)) as total,
                                        vt.total_venta, concat(cl.nombres,' ',cl.apellidos) as cliente
                                        from cobros_caja cc
                                        inner join ventas vt on vt.id_venta = cc.id_venta
                                        inner join clientes cl on cl.id_cliente = vt.id_cliente
                                        inner join items_cobro ic on ic.id_cobro = cc.id_cobro
                                        inner join formas_pago fp on fp.id_forma_pago = ic.id_forma_pago
                                        where vt.id_sucursal=" & CStr(id_sucursal) & " and cc.fecha >= '" & txt_fecha_desde.Text & "' and cc.fecha <= '" & txt_fecha_hasta.Text & "'
                                        group by vt.numero, concat(vt.numero,'  Total: ',vt.total_venta,'  Cliente: ',cl.nombres,' ',cl.apellidos), 
                                        fp.nombre, vt.total_venta, concat(cl.nombres,' ',cl.apellidos)")

        If dt_ventas.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_ventas
        Else
            util.mensajes("No se registraron cobros", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = ventas.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            id_sucursal = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub


    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_vta_ventas_formas_pago"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If id_sucursal > 0 Then
                txt_fecha_desde.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            cld_desde.Visible = True
            cld_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        consultar()
        btn_consultar.Focus()

        If GridView1.RowCount <= 0 Then
            txt_sucursal.Focus()
        Else
            btn_consultar.Focus()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_vta_ventas_formas_pago

        report.DataSource = grid_ventas.DataSource

        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        grid_ventas.DataSource = Nothing
        txt_sucursal.Focus()
    End Sub

    Private Sub cld_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_desde.DoubleClick
        txt_fecha_desde.Text = cld_desde.DateTime.ToString
        txt_fecha_desde.Focus()
        cld_desde.Visible = False
    End Sub

    Private Sub cld_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_desde.DateTime.ToString
            txt_fecha_desde.Focus()
            cld_desde.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_desde.Visible = False
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub cld_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cld_hasta.DoubleClick
        txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
        txt_fecha_hasta.Focus()
        cld_hasta.Visible = False
    End Sub

    Private Sub cld_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
            txt_fecha_hasta.Focus()
            cld_hasta.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_hasta.Visible = False
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub btn_calendar_desde_Click(sender As Object, e As EventArgs) Handles btn_cal_desde.Click
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub btn_calendar_hasta_Click(sender As Object, e As EventArgs) Handles btn_cld_hasta.Click
        cld_hasta.Visible = True
        cld_hasta.Focus()
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_vta_ventas_formas_pago"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub
End Class