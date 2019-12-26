Imports DevExpress.XtraReports.UI

Public Class frm_rpt_vta_por_condicion

    Dim venta As New func_ventas
    Dim dt_ventas As New DataTable
    Dim dt_condicion As New DataTable
    Dim util As New utilidades
    Dim TITULO_MSJ As String = "<Rpt. de Ventas p/ Condicion>"
    Dim ID_CONDICION As Integer = 0


    Private Sub frm_rpt_ventas_por_condicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        obtener_condiciones_venta()
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub obtener_condiciones_venta()
        dt_condicion = venta.consultar("SELECT id_condicion, nombre FROM condiciones_venta")

        If dt_condicion.Rows.Count > 0 Then
            For Each dr As DataRow In dt_condicion.Rows
                cbo_condicion_venta.Properties.Items.Add(dr("nombre"))
            Next
        Else
            util.mensajes("Condiciones de Ventas no definidos", TITULO_MSJ, "ERR")
            Close()
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



    Private Sub consultar()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim condicion As String = ""
        Dim orden As String = " ORDER BY vta.id_venta DESC"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "WHERE vta.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND to_char(vta.fecha_venta,'dd/mm/yyyy') >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND to_char(vta.fecha_venta,'dd/mm/yyyy')  <='" + txt_fecha_hasta.Text + "'"
        End If

        If cbo_condicion_venta.SelectedIndex < 0 Then
            condicion = ""
        Else
            condicion = " AND vta.id_condicion_venta = " + ID_CONDICION.ToString
        End If

        dt_ventas = venta.consultar("SELECT CONCAT('FECHA: ',to_char(vta.fecha_venta, 'dd/mm/yyyy'),'  CLIENTE:',COALESCE(CONCAT(c.nombres,' ',c.apellidos), 'NO DEFINIDO'),'  NRO.:',vta.numero,'  TOTAL:',vta.total_venta) as comprobante,
                                        a.codigo_barras, a.nombre as item, iv.precio_venta, iv.cantidad, iv.total_item as total
                                        FROM ventas vta
                                        INNER JOIN condiciones_venta cv ON vta.id_condicion_venta = cv.id_condicion
                                        INNER JOIN items_venta iv ON iv.id_venta = vta.id_venta
                                        INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
                                        INNER JOIN clientes c ON c.id_cliente = vta.id_cliente " +
                                        sucursal + desde + hasta + condicion + " AND vta.fecha_anulacion IS NULL " + orden)

        If dt_ventas.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_ventas
        Else
            util.mensajes("No se registraron ventas", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
        End If
    End Sub

    Private Sub cbo_condicion_venta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_condicion_venta.SelectedIndexChanged
        If cbo_condicion_venta.SelectedIndex >= 0 Then
            ID_CONDICION = CInt(dt_condicion.Rows(cbo_condicion_venta.SelectedIndex).Item(0))
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
        Dim report As New rpt_vta_por_condicion

        report.DataSource = dt_ventas

        If cbo_condicion_venta.SelectedIndex >= 0 Then
            report.Parameters("condicion").Value = "Condicion de Vta.: " + cbo_condicion_venta.SelectedItem.ToString
        End If
        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text

        report.Parameters("sucursal").Visible = False

        report.Parameters("condicion").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_ventas_por_condicion"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_ventas_por_condicion"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            cbo_condicion_venta.Focus()
        End If
    End Sub

    Private Sub cbo_condicion_venta_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_condicion_venta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        cbo_condicion_venta.SelectedIndex = -1
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        ID_CONDICION = 0
        grid_ventas.DataSource = Nothing
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