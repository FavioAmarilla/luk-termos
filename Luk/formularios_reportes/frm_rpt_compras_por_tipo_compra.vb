Imports DevExpress.XtraReports.UI

Public Class frm_rpt_compras_por_tipo_compra

    Private compra As New func_compras
    Private dt_compras As New DataTable
    Private dt_tipo_comprobantes As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Compras por Tipo>"

    Private ID_TIPO As Integer = 0

    Private Sub frm_rpt_compras_por_tipo_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        obtener_tipo_facturas()
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub consultar()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim tipo As String = ""
        Dim orden As String = " ORDER BY cmp.fecha_compra DESC"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "WHERE cmp.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND cmp.fecha_compra >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND cmp.fecha_compra <='" + txt_fecha_hasta.Text + "'"
        End If

        If ID_TIPO <= 0 Then
            util.mensajes("Debe seleccionar Tipo de Compra", TITULO_MSJ, "WAR")
            Return
        Else
            tipo = " AND tco.id_tipo_comprobante = " + ID_TIPO.ToString
        End If

        dt_compras = compra.consultar("SELECT s.nombre AS sucursal, fecha_compra AS fecha, tc.nombre AS tipo_compra, p.nombre AS proveedor, 
                                        COALESCE(tco.nombre, '-') AS tipo_factura, COALESCE(fc.numero_factura, '-') AS numero_factura, 
                                        COALESCE(fc.monto_gravado, 0) AS gravado, COALESCE(fc.total_iva, 0) AS impuesto, COALESCE(total_compra, 0) AS total
                                        FROM compras cmp
                                        INNER JOIN tipos_compra tc ON tc.id_tipo_compra = cmp.id_tipo_compra
                                        INNER JOIN proveedores p ON p.id_proveedor = cmp.id_proveedor
                                        INNER JOIN sucursales s ON s.id_sucursal	= cmp.id_sucursal
                                        INNER JOIN facturas_compra fc ON fc.id_factura = cmp.id_factura
                                        INNER JOIN tipos_comprobante tco ON tco.id_tipo_comprobante = fc.id_tipo_comprobante " +
                                        sucursal + tipo + desde + hasta + orden)

        If dt_compras.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
        End If

    End Sub

    Public Sub obtener_tipo_facturas()
        dt_tipo_comprobantes = compra.consultar("SELECT id_tipo_comprobante, nombre FROM tipos_comprobante")
        If dt_tipo_comprobantes.Rows.Count > 0 Then
            cbo_tipos.Properties.Items.Clear()
            For Each row As DataRow In dt_tipo_comprobantes.Rows
                cbo_tipos.Properties.Items.Add(row("nombre"))
            Next
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = compra.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub


    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_compras_por_tipo_compra"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_compras_por_tipo_compra"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            cbo_tipos.Focus()
        End If
    End Sub

    Private Sub cbo_tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipos.SelectedIndexChanged
        ID_TIPO = CInt(dt_tipo_comprobantes.Rows(cbo_tipos.SelectedIndex).Item(0))
    End Sub

    Private Sub cbo_tipos_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipos.SelectedIndex < 0 Then
                Return
            End If
            txt_fecha_desde.Focus()
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
        Dim report As New rpt_cmp_por_tipo_compra

        report.DataSource = dt_compras

        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("tipo_compra").Value = "Tipo Compra: " + cbo_tipos.SelectedItem.ToString

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("tipo_compra").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        cbo_tipos.SelectedIndex = -1
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""

        grid_ventas.DataSource = Nothing
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub
End Class