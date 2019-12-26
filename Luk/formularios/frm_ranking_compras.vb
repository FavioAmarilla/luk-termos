Imports DevExpress.XtraReports.UI

Public Class frm_ranking_compras

    Private compra As New func_compras
    Private dt_ranking As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Ranking de Compras>"

    Private ID_FAMILIA As Integer = 0

    Private Sub frm_ranking_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_familia.Checked = False
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_ranking.Clear()
        Dim grupo_sql_m As String = " GROUP BY item, familia, proveedor "
        Dim grupo_sql_a As String = " GROUP BY item, codigo_barras, familia, proveedor"

        Dim desde As String = ""
        Dim hasta As String = ""
        Dim limit_sql As String = ""
        Dim familia_sql As String = ""
        Dim proveedor_sql As String = ""
        Dim orden_sql As String = ""

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " TO_CHAR(ic.fecha_cre, 'dd/MM/yyyy') >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND TO_CHAR(ic.fecha_cre, 'dd/MM/yyyy') <='" + txt_fecha_hasta.Text + "'"
        End If

        If txt_familia.Text.Replace(" ", "") = "" Then
        Else
            familia_sql = " AND f.identificador=" + ID_FAMILIA.ToString
        End If

        If chk_cantidad.Checked Then
            orden_sql = " ORDER BY SUM(cantidad) DESC "
        End If

        If chk_monto.Checked Then
            orden_sql = " ORDER BY SUM(total_compra) DESC "
        End If

        If txt_limite.Text.Replace(" ", "") = "" Then
        Else
            limit_sql = " LIMIT " + txt_limite.Text
        End If

        Dim sql_m As String = "SELECT item, familia, proveedor, SUM(total_compra) AS total_compra, SUM(cantidad) AS cantidad 
                                    FROM (
				                        SELECT m.nombre AS item, f.descripcion AS familia, p.nombre AS proveedor, costo_total AS total_compra, cantidad AS cantidad
                                        FROM items_compras ic
                                        INNER JOIN compras c ON c.id_compra = ic.id_compra
                                        INNER JOIN materiales m ON m.id_material = ic.id_material
                                        INNER JOIN familias_materia_prima f ON f.identificador =  m.id_familia
                                        INNER JOIN proveedores p ON p.id_proveedor = ic.id_proveedor  
                                        WHERE " & desde & hasta & familia_sql & " AND ic.id_material > 0 
		                            ) AS x  "


        Dim sql_a As String = "SELECT item, codigo_barras, familia, proveedor, SUM(total_compra) AS total_compra, SUM(cantidad) AS cantidad 
                                    FROM (
				                        SELECT a.nombre AS item, a.codigo_barras, f.descripcion AS familia, p.nombre AS proveedor, costo_total AS total_compra, cantidad AS cantidad
                                        FROM items_compras ic
                                        INNER JOIN compras c ON c.id_compra = ic.id_compra
                                        INNER JOIN articulos a ON a.id_articulo = ic.id_articulo
                                        INNER JOIN familias f ON f.identificador =  a.id_familia
                                        INNER JOIN proveedores p ON p.id_proveedor = ic.id_proveedor  
                                        WHERE " & desde & hasta & familia_sql & " AND ic.id_articulo > 0 ) AS x  "




        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            dt_ranking = compra.consultar(sql_a + grupo_sql_a + orden_sql + limit_sql)
        End If

        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            dt_ranking = compra.consultar(sql_m + grupo_sql_m + orden_sql + limit_sql)
        End If


        If dt_ranking.Rows.Count > 0 Then
            grid_ranking.DataSource = dt_ranking
        Else
            util.mensajes("No existen registros de compras", TITULO_MSJ, "WAR")
            grid_ranking.DataSource = Nothing
        End If
    End Sub

    Public Sub obtener_familia_material(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT identificador, descripcion FROM familias_materia_prima WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT identificador, descripcion FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If cbo_tipo_movimiento.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar Tipo de Item", TITULO_MSJ, "WAR")
            cbo_tipo_movimiento.Focus()
            Return
        End If

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
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_ranking_compras

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
        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            Dim frm As New frm_vista_familias
            frm.FRM_ACTIVO = "frm_ranking_compras"
            frm.Show()
        End If
        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            Dim frm As New frm_vista_familia_materia_prima
            frm.FRM_ACTIVO = "frm_ranking_compras"
            frm.Show()
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If cbo_tipo_movimiento.SelectedIndex = 0 Then
                Dim frm As New frm_vista_familias
                frm.FRM_ACTIVO = "frm_ranking_compras"
                frm.Show()
            End If
            If cbo_tipo_movimiento.SelectedIndex = 1 Then
                Dim frm As New frm_vista_familia_materia_prima
                frm.FRM_ACTIVO = "frm_ranking_compras"
                frm.Show()
            End If
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

    Private Sub cbo_tipo_movimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_movimiento.SelectedIndexChanged
        grid_ranking.DataSource = Nothing
        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            GridView1.Columns("codigo_barras").Visible = True
        End If
        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            GridView1.Columns("codigo_barras").Visible = False
        End If
    End Sub

    Private Sub cbo_tipo_movimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_movimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_movimiento.SelectedIndex >= 0 Then
                txt_fecha_desde.Focus()
            End If
        End If
    End Sub

End Class