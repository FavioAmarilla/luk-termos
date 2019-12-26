Imports DevExpress.XtraReports.UI

Public Class frm_rpt_prodcuccion_ranking_emp

    Private movim As New func_movimientos_stock
    Private dt_asignacion As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Produccion de Empl.>"

    Private Sub frm_rpt_prodcuccion_ranking_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_monto.Focus()
        lbl_total_registros.Text = "Registros recuperados: 0"
        cld_desde.Visible = False
        cld_hasta.Visible = False
        txt_sucursal.Focus()
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = movim.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub consultar()
        Dim sql As String = ""
        Dim sucursal As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim orden As String = ""

        sql = "SELECT ape.fecha AS fecha, CONCAT(e.nombres,' ',e.apellidos) AS empleado, 
                SUM(ape.cantidad_asignada) AS cantidad, SUM(p.costo_total) AS costo_total
                FROM asignacion_pedido_empleado ape
                INNER JOIN empleados e ON e.id_empleado = ape.id_empleado 
                INNER JOIN pedidos p ON p.id_pedido = ape.id_pedido
                INNER JOIN articulos a ON a.id_articulo = p.id_articulo"

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = " WHERE p.id_sucursal= " + txt_id_sucursal.Text
        End If

        If chk_monto.Checked Then
            orden = " GROUP BY ape.fecha, CONCAT(e.nombres,' ',e.apellidos) ORDER BY SUM(p.costo_total) DESC"
        End If

        If chk_cantidad.Checked Then
            orden = " GROUP BY ape.fecha, CONCAT(e.nombres,' ',e.apellidos) ORDER BY SUM(ape.cantidad_asignada) DESC"
        End If

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresar Fecha Desde", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        Else
            desde = " AND ape.fecha >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresar Fecha Hasta", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        Else
            hasta = " AND ape.fecha <='" + txt_fecha_hasta.Text + "'"
        End If

        dt_asignacion = movim.consultar(sql + sucursal + desde + hasta + orden)

        If dt_asignacion.Rows.Count > 0 Then
            grid_movimientos.DataSource = dt_asignacion
        Else
            util.mensajes("No se registraron Movimientos de Produccion", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_movimientos.DataSource = Nothing
        End If


    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_prodcuccion_ranking_emp"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub chk_monto_CheckedChanged(sender As Object, e As EventArgs) Handles chk_monto.CheckedChanged
        If chk_monto.Checked Then
            chk_cantidad.Checked = False
        End If
    End Sub

    Private Sub chk_cantidad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cantidad.CheckedChanged
        If chk_cantidad.Checked Then
            chk_monto.Checked = False
        End If
    End Sub
    Private Sub chk_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_monto.KeyDown
        If chk_monto.Checked Then
            txt_sucursal.Focus()
        Else
            chk_cantidad.Checked = False
        End If
    End Sub

    Private Sub chk_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sucursal.Focus()
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_prodcuccion_ranking_emp"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Space Then
            cld_desde.Visible = True
            cld_desde.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_desde.Text = "  /  /" Then
            Else
                txt_fecha_hasta.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_hasta.Text = "  /  /" Then
            Else
                btn_consultar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        consultar()
        btn_consultar.Focus()

        If GridView1.RowCount <= 0 Then
            txt_sucursal.Focus()
        End If
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim titulo As String = ""
        Dim report As New rpt_produccion_ranking_emp

        report.DataSource = dt_asignacion

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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        chk_cantidad.Checked = False
        chk_monto.Checked = False
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""

        grid_movimientos.DataSource = Nothing
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