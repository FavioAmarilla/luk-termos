Imports DevExpress.XtraReports.UI

Public Class frm_rpt_produccion_por_fecha

    Private movim As New func_movimientos_stock
    Private dt_produccion As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Produccion por Fecha>"

    Private Sub frm_rpt_produccion_por_fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_articulos.Focus()
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
        Dim orden As String = " ORDER BY mi.fecha_Cre DESC"

        If chk_articulos.Checked = False And chk_materia_prima.Checked = False Then
            util.mensajes("Debe seleccionar Tipo de Item", TITULO_MSJ, "WAR")
            Return
        End If

        If chk_articulos.Checked Then
            sql = "SELECT ms.fecha, t.nombre AS transaccion, t.accion, a.nombre AS item, a.codigo_barras AS codigo, mi.cantidad_unit AS cantidad, mi.costo_unitario, mi.costo_total
                    FROM movim_item_stock mi
                    INNER JOIN articulos a ON a.id_articulo = mi.id_articulo
                    INNER JOIN movimiento_stock ms ON ms.id_movimiento_stock = mi.id_movimiento
                    INNER JOIN transacciones_stock t ON t.id_transaccion = mi.id_transaccion
                    WHERE t.relacion='IP' "
        End If

        If chk_materia_prima.Checked Then
            sql = "SELECT ms.fecha, t.nombre AS transaccion, t.accion, m.nombre AS item, m.codigo, mi.cantidad_unit AS cantidad, mi.costo_unitario, mi.costo_total
                    FROM movim_item_stock mi
                    INNER JOIN materiales m ON m.id_material = mi.id_material
                    INNER JOIN movimiento_stock ms ON ms.id_movimiento_stock = mi.id_movimiento
                    INNER JOIN transacciones_stock t ON t.id_transaccion = mi.id_transaccion
                    WHERE t.relacion='EP' "
        End If

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "AND ms.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND mi.fecha >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND mi.fecha <='" + txt_fecha_hasta.Text + "'"
        End If

        dt_produccion = movim.consultar(sql + sucursal + desde + hasta + orden)

        If dt_produccion.Rows.Count > 0 Then
            grid_movimientos.DataSource = dt_produccion
        Else
            util.mensajes("No se registraron Movimientos de Produccion", TITULO_MSJ, "INF")
            grid_movimientos.DataSource = Nothing
            SendKeys.Send("{ENTER}")
            txt_sucursal.Focus()
        End If

        txt_sucursal.Focus()

    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_produccion_por_fecha"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub chk_articulos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulos.CheckedChanged
        If chk_articulos.Checked Then
            chk_materia_prima.Checked = False
        End If
    End Sub
    Private Sub chk_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_articulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_articulos.Checked Then
                txt_sucursal.Focus()
            Else
                chk_materia_prima.Focus()
            End If
        End If
    End Sub

    Private Sub chk_materia_prima_CheckedChanged(sender As Object, e As EventArgs) Handles chk_materia_prima.CheckedChanged
        If chk_materia_prima.Checked Then
            chk_articulos.Checked = False
        End If
    End Sub

    Private Sub chk_materia_prima_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_materia_prima.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sucursal.Focus()
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_produccion_por_fecha"
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
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
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
        Dim titulo As String = ""
        Dim report As New rpt_produccion_por_fecha

        report.DataSource = dt_produccion
        If chk_articulos.Checked Then
            titulo = "Articulos Producidos"
        End If
        If chk_materia_prima.Checked Then
            titulo = "Materias Primas utilizadas para Produccion"
        End If

        report.Parameters("titulo").Value = titulo
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("titulo").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        chk_articulos.Checked = False
        chk_materia_prima.Checked = False
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