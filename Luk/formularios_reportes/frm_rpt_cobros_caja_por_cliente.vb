Imports DevExpress.XtraReports.UI

Public Class frm_rpt_cobros_caja_por_cliente

    Private venta As New func_ventas
    Private dt_ventas As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Cobros>"

    Private ID_CLIENTE As Integer = 0

    Private Sub frm_rpt_cobros_caja_por_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub consultar()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim forma_pago As String = ""
        Dim orden As String = " group by cc.fecha, coalesce(fp.nombre, 'NO DEFINIDO'), ic.tipo_tarjeta, ic.procesadora, fp.nombre order by cc.fecha, fp.nombre asc"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        End If

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha desde", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha hasta", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If

        dt_ventas = venta.consultar("select concat('FECHA:',to_char(vt.fecha_venta, 'dd/mm/yyyy'),'  ',cv.nombre,':', vt.numero,' TOTAL:',vt.total_venta) as comprobante,
                                        to_char(ic.fecha_cre, 'dd/mm/yyyy') as fecha, fp.nombre, ic.importe_recibido, ic.importe_vuelto
                                        from ventas vt
                                        inner join condiciones_venta cv on cv.id_condicion = vt.id_condicion_venta
                                        inner join cobros_caja cc on cc.id_venta = vt.id_venta
                                        inner join items_cobro ic on ic.id_cobro = cc.id_cobro
                                        inner join formas_pago fp on fp.id_forma_pago = ic.id_forma_pago
                                        where vt.id_sucursal=" & txt_id_sucursal.Text & " and vt.id_cliente=" & ID_CLIENTE & "
                                        and to_char(vt.fecha_venta, 'dd/mm/yyyy') >= '" & txt_fecha_desde.Text & "' 
                                        and to_char(vt.fecha_venta, 'dd/mm/yyyy') <= '" & txt_fecha_hasta.Text & "'")

        If dt_ventas.Rows.Count > 0 Then
            grid_cobros.DataSource = dt_ventas
        Else
            util.mensajes("No se registraron cobros", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_cobros.DataSource = Nothing
        End If
    End Sub
    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = venta.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_cliente(id As String)
        Dim dt As New DataTable
        dt = venta.consultar("SELECT id_cliente, concat(nombres,' ',apellidos) FROM clientes WHERE id_cliente=" + id)

        If dt.Rows.Count > 0 Then
            ID_CLIENTE = CInt(dt.Rows(0).Item(0))
            txt_cliente.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            txt_cliente.Focus()
        End If
    End Sub

    Private Sub btn_clienteo_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        Dim frm As New frm_vista_clientes
        frm.FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente"
        frm.Show()
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_clientes
            frm.FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente"
            frm.Show()
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
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_cobros_caja_por_cliente

        report.DataSource = dt_ventas

        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("cliente").Value = "Cliente: " + txt_cliente.Text
        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("sucursal").Visible = False
        report.Parameters("cliente").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        txt_cliente.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        ID_CLIENTE = 0
        grid_cobros.DataSource = Nothing
        lbl_total_registros.Text = "Registros recuperados: 0"
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

End Class