Imports DevExpress.XtraReports.UI

Public Class frm_ranking_ventas

    Private venta As New func_ventas
    Private dt_ranking As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Ranking de Ventas>"

    Private ID_FAMILIA As Integer = 0


    Private Sub frm_ranking_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_familia.Checked = False
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_ranking.Clear()
        Dim sql As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim limit_sql As String = ""
        Dim familia_sql As String = ""
        Dim proveedor_sql As String = ""
        Dim grupo_sql As String = " GROUP BY codigo_barras, item, familia, ranking "
        Dim orden_sql As String = ""

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " iv.fecha >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND iv.fecha <='" + txt_fecha_hasta.Text + "'"
        End If

        If txt_familia.Text.Replace(" ", "") = "" Then
        Else
            familia_sql = " AND f.identificador=" + ID_FAMILIA.ToString
        End If

        If chk_cantidad.Checked Then
            orden_sql = " ORDER BY SUM(cantidad) DESC "
        End If
        If chk_monto.Checked Then
            orden_sql = " ORDER BY SUM(monto) DESC "
        End If

        If txt_limite.Text.Replace(" ", "") = "" Then
        Else
            limit_sql = " LIMIT " + txt_limite.Text
        End If

        sql = "SELECT codigo_barras, item, familia, ranking, SUM(monto) AS monto, SUM(cantidad) AS cantidad 
                    FROM (
		                SELECT a.nombre AS item, a.codigo_barras, p.nombre AS ranking, iv.total_item AS monto, iv.cantidad,
                        f.descripcion AS familia 
                        FROM items_venta iv
                        INNER JOIN ventas vta ON vta.id_venta = iv.id_venta
                        INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
                        INNER JOIN familias f ON f.identificador = a.id_familia
                        INNER JOIN proveedores p ON p.id_proveedor = iv.id_proveedor  
                        WHERE " + desde + hasta + familia_sql + proveedor_sql + " 
                        AND iv.id_articulo > 0 AND vta.fecha_anulacion IS NULL
                    ) AS x " +
                     grupo_sql + orden_sql + limit_sql

        dt_ranking = venta.consultar(sql)

        If dt_ranking.Rows.Count > 0 Then
            grid_ranking.DataSource = dt_ranking
        Else
            util.mensajes("No existen registros de Ventas", TITULO_MSJ, "WAR")
            grid_ranking.DataSource = Nothing
        End If
    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable
        dt = venta.consultar("SELECT identificador, descripcion FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresa rango de fechas", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        End If
        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresa rango de fechas", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If

        If chk_monto.Checked = False And chk_cantidad.Checked = False Then
            util.mensajes("Debe Seleccionar Filtro de Busqueda", TITULO_MSJ, "WAR")
            chk_monto.Focus()
            Return
        End If
        If chk_monto.Checked Then
            chk_cantidad.Checked = False
            listar()
        End If
        If chk_cantidad.Checked Then
            chk_monto.Checked = False
            listar()
        End If
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_ranking_venta

        report.DataSource = grid_ranking.DataSource

        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("familia").Value = "Familia: " + txt_familia.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_desde.Text = "  /  /" Then
            Else
                txt_fecha_hasta.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Then
            cld_desde.Visible = True
            cld_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_hasta.Text = "  /  /" Then
            Else
                txt_limite.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
    End Sub

    Private Sub txt_limite_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_limite.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_monto.Focus()
        End If
    End Sub

    Private Sub chk_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_cantidad.Focus()
        End If
    End Sub

    Private Sub chk_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_familia.Focus()
        End If
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

    Private Sub btn_familia_Click(sender As Object, e As EventArgs) Handles btn_familia.Click
        Dim frm As New frm_vista_familias
        frm.FRM_ACTIVO = "frm_ranking_ventas"
        frm.Show()
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_familias
            frm.FRM_ACTIVO = "frm_ranking_ventas"
            frm.Show()
        End If
    End Sub

    Private Sub chk_familia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_familia.CheckedChanged
        If chk_familia.Checked = False Then
            txt_familia.Text = ""
            ID_FAMILIA = 0
            PanelControl2.Enabled = False
        End If
        If chk_familia.Checked Then
            PanelControl2.Enabled = True
            txt_familia.Focus()
        End If
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

    Private Sub chk_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_familia.Checked Then
                txt_familia.Focus()
            Else
                btn_consultar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_calendar_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_calendar_desde.KeyDown
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub btn_calendar_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_calendar_hasta.KeyDown
        cld_hasta.Visible = True
        cld_hasta.Focus()
    End Sub

    Private Sub btn_calendar_desde_Click(sender As Object, e As EventArgs) Handles btn_calendar_desde.Click
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub btn_calendar_hasta_Click(sender As Object, e As EventArgs) Handles btn_calendar_hasta.Click
        cld_hasta.Visible = True
        cld_hasta.Focus()
    End Sub

End Class