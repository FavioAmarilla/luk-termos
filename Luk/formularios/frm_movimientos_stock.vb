Imports DevExpress.XtraReports.UI

Public Class frm_movimientos_stock

    Private util As New utilidades()
    Private movim As New func_movimientos_stock()
    Private dt_movimientos_stock As New DataTable()

    Private TITULO_MSJ As String = "<Movimientos de Stock>"
    Private ID_SUCURSAL As Integer = 0
    Private SQL As String = ""

    Private Sub frm_movimientos_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sucursal.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            ID_SUCURSAL = CInt(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            util.mensajes("Sucursal no definida", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub listar()
        dt_movimientos_stock = New DataTable()
        dt_movimientos_stock.Clear()

        If ID_SUCURSAL <= 0 Then
            util.mensajes("Debe seleccionar Sucursal ", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        End If

        If cbo_tipo_movimiento.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de Movimiento", TITULO_MSJ, "WAR")
            cbo_tipo_movimiento.Focus()
            Return
        End If

        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            SQL = "SELECT COALESCE(p.numero,'') AS pedido, COALESCE(vta.numero,'') AS venta, COALESCE(cmp.numero) AS compra,
		            a.nombre AS item, t.nombre AS transaccion, t.accion, COALESCE(s.cantidad_unit, 0) AS cantidad, 
                    COALESCE(s.costo_unitario, 0) AS costo,  COALESCE(s.precio_unitario, 0) AS precio, s.fecha_cre AS fecha
                    FROM movim_item_stock s
                    LEFT JOIN movimiento_stock mv ON mv.id_movimiento_stock = s.id_movimiento
                    LEFT JOIN pedidos p ON p.id_pedido = mv.id_pedido
                    LEFT JOIN ventas vta ON vta.id_venta = mv.id_venta
                    LEFT JOIN compras cmp ON cmp.id_compra = mv.id_compra
                    LEFT JOIN articulos a ON a.id_articulo = s.id_articulo
                    LEFT JOIN transacciones_stock t ON  t.id_transaccion = s.id_transaccion
                    WHERE s.id_articulo > 0 AND mv.id_sucursal = " + ID_SUCURSAL.ToString
        End If

        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            SQL = "SELECT COALESCE(p.numero,'') AS pedido, COALESCE(vta.numero,'') AS venta, COALESCE(cmp.numero) AS compra,
                    COALESCE(p.numero, '') AS pedido,  m.nombre AS item, t.nombre AS transaccion, t.accion, COALESCE(s.cantidad_unit, 0) AS cantidad, 
                    COALESCE(s.costo_unitario, 0) AS costo,  COALESCE(s.precio_unitario,0) AS precio, s.fecha_cre AS fecha
                    FROM movim_item_stock s
                    LEFT JOIN movimiento_stock mv ON mv.id_movimiento_stock = s.id_movimiento
                    LEFT JOIN pedidos p ON p.id_pedido = mv.id_pedido
                    LEFT JOIN ventas vta ON vta.id_venta = mv.id_venta
                    LEFT JOIN compras cmp ON cmp.id_compra = mv.id_compra
                    LEFT JOIN materiales m ON m.id_material = s.id_material
                    LEFT JOIN transacciones_stock t ON  t.id_transaccion = s.id_transaccion
                    WHERE s.id_material > 0 AND mv.id_sucursal =" + ID_SUCURSAL.ToString
        End If

        If cbo_accion.SelectedIndex = 1 Then
            SQL += " AND t.accion = 'EGRESO' "
        End If
        If cbo_accion.SelectedIndex = 2 Then
            SQL += " AND t.accion = 'INGRESO' "
        End If

        If txt_fecha_movimiento.Text = "  /  /" Then
            SQL += ""
        Else
            SQL += " AND s.fecha ='" + txt_fecha_movimiento.Text + "'"
        End If

        dt_movimientos_stock = movim.consultar(SQL + " ORDER BY s.id_movim_item_stock ASC")

        If dt_movimientos_stock.Rows().Count() <> 0 Then
            grid_movimientos_stock.DataSource = dt_movimientos_stock
            grid_movimientos_stock.Focus()
        Else
            util.mensajes("No existen Movimientos de Stock", TITULO_MSJ, "WAR")
            ID_SUCURSAL = 0
            txt_sucursal.Text = ""
            cbo_tipo_movimiento.SelectedIndex = -1
            cbo_accion.SelectedIndex = -1
            txt_fecha_movimiento.Text = ""
            dt_movimientos_stock.Clear()
            grid_movimientos_stock.DataSource = dt_movimientos_stock
            txt_sucursal.Focus()
        End If

    End Sub

    Private Sub cargar_fila(ByVal accion As String)
        If GridView1.RowCount() <= 0 Then
            Return
        End If
        Dim rowhandle As Integer = 0
        If accion = "up" Then
            rowhandle = GridView1.FocusedRowHandle() - 1
        End If
        If accion = "down" Then
            rowhandle = GridView1.FocusedRowHandle() + 1
        End If
        If accion = "enter" Then
            rowhandle = GridView1.FocusedRowHandle()
        End If

        If rowhandle >= 0 And rowhandle < GridView1.RowCount() Then
            txt_item.Text = GridView1.GetRowCellValue(rowhandle, "item").ToString()
            txt_cantidad.Text = GridView1.GetRowCellValue(rowhandle, "cantidad").ToString()
            txt_costo.Text = GridView1.GetRowCellValue(rowhandle, "costo").ToString()
            txt_precio.Text = GridView1.GetRowCellValue(rowhandle, "precio").ToString()
            txt_fecha.Text = GridView1.GetRowCellValue(rowhandle, "fecha").ToString()
            txt_transaccion.Text = GridView1.GetRowCellValue(rowhandle, "transaccion").ToString()
            txt_accion.Text = GridView1.GetRowCellValue(rowhandle, "accion").ToString()
            txt_nro_pedido.Text = GridView1.GetRowCellValue(rowhandle, "pedido").ToString()
            txt_nro_venta.Text = GridView1.GetRowCellValue(rowhandle, "venta").ToString()
            txt_nro_compra.Text = GridView1.GetRowCellValue(rowhandle, "compra").ToString()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub cbo_tipo_movimiento_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_movimiento.SelectedIndex >= 0 Then
                cbo_accion.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_accion_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_accion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_movimiento.Focus()
        End If
    End Sub

    Private Sub txt_fecha_movimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_movimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            cld_fecha_movim.Visible = True
            cld_fecha_movim.Focus()
        End If
    End Sub

    Private Sub grid_movimientos_stock_Click(sender As Object, e As EventArgs) Handles grid_movimientos_stock.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_movimientos_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_movimientos_stock.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar_fila("enter")
        End If
        If e.KeyCode = Keys.Up Then
            cargar_fila("up")
        End If
        If e.KeyCode = Keys.Down Then
            cargar_fila("down")
        End If
    End Sub

    Private Sub cbo_tipo_movimiento_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cbo_tipo_movimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_accion.SelectedIndex = 0
            cbo_accion.Focus()
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_movimientos_stock"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text.Replace(" ", "") = "" Then
            Else
                cbo_tipo_movimiento.SelectedIndex = 0
                cbo_tipo_movimiento.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_movimientos_stock"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim report As New rpt_mv_stock_general

        report.DataSource = grid_movimientos_stock.DataSource

        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("fecha").Value = "Fecha Movim.: " + txt_fecha.Text
        If cbo_tipo_movimiento.SelectedIndex < 0 Then
            report.Parameters("accion").Value = "Tipo de Movim.: TODOS"
        Else
            report.Parameters("tipo_movimiento").Value = "Tipo de Movim.: " + cbo_tipo_movimiento.SelectedItem.ToString
        End If
        If cbo_accion.SelectedIndex < 0 Then
            report.Parameters("accion").Value = "Accion: TODOS"
        Else
            report.Parameters("accion").Value = "Accion: " + cbo_accion.SelectedItem.ToString
        End If

        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha").Visible = False
        report.Parameters("tipo_movimiento").Visible = False
        report.Parameters("accion").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub


    Private Sub btn_desde_Click(sender As Object, e As EventArgs) Handles btn_desde.Click
        cld_fecha_movim.Visible = True
        cld_fecha_movim.Focus()
    End Sub

    Private Sub cld_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_fecha_movim.DoubleClick
        txt_fecha_movimiento.Text = cld_fecha_movim.DateTime.ToString
        cld_fecha_movim.Visible = False
        txt_fecha_movimiento.Focus()
    End Sub

    Private Sub cld_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_fecha_movim.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_movimiento.Text = cld_fecha_movim.DateTime.ToString
            cld_fecha_movim.Visible = False
            txt_fecha_movimiento.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_movimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_movimiento.SelectedIndexChanged
        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            grid_movimientos_stock.DataSource = Nothing
            GridView1.Columns("precio").Visible = True
        Else
            grid_movimientos_stock.DataSource = Nothing
            GridView1.Columns("precio").Visible = False
        End If
    End Sub
End Class