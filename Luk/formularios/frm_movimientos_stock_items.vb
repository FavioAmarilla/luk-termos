Imports DevExpress.XtraReports.UI

Public Class frm_movimientos_stock_items

    Private movim As New func_movimientos_stock
    Private dt_movimiento As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Movimientos de Stock por Items>"

    Private Sub frm_movimientos_stock_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub limpiar()
        txt_descripcion.Text = ""
        txt_codigo.Text = ""
    End Sub

    Private Sub listar()
        Dim sql As String = ""
        Dim orden As String = " ORDER BY fecha ASC"
        Dim desde As String = ""
        Dim hasta As String = ""

        If chk_articulos.Checked = False And chk_materia_prima.Checked = False Then
            util.mensajes("Debe seleccionar Tipo de Movimiento", TITULO_MSJ, "WAR")
            Return
        End If

        If txt_descripcion.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar Descripcion del Item", TITULO_MSJ, "WAR")
            Return
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND mi.fecha >= '" + txt_fecha_desde.Text + "' "
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND mi.fecha <= '" + txt_fecha_hasta.Text + "' "
        End If

        If chk_articulos.Checked Then
            sql = "SELECT mi.fecha_cre AS fecha, ts.nombre As transaccion, mi.cantidad_unit As cantidad, a.nombre As item, mi.costo_unitario As costo_unitario, 
                    mi.precio_unitario AS precio_venta, mi.id_movimiento
                    FROM movim_item_stock mi
                    INNER JOIN transacciones_stock ts ON ts.id_transaccion = mi.id_transaccion
                    INNER JOIN articulos a ON a.id_articulo = mi.id_articulo
                    WHERE a.nombre Like '%" + txt_descripcion.Text + "%' " & desde & hasta & orden
        End If

        If chk_materia_prima.Checked Then
            sql = "SELECT mi.fecha_cre AS fecha, ts.nombre AS transaccion, mi.cantidad_unit AS cantidad,m.nombre AS item, mi.costo_unitario AS costo_unitario, 
                    mi.precio_unitario AS precio_venta, mi.id_movimiento
                    FROM movim_item_stock mi
                    INNER JOIN transacciones_stock ts ON ts.id_transaccion = mi.id_transaccion
                    INNER JOIN materiales m ON m.id_material = mi.id_material
                    WHERE m.nombre LIKE '%" + txt_descripcion.Text + "%'" & desde & hasta & orden
        End If

        dt_movimiento = movim.consultar(sql)

        If dt_movimiento.Rows.Count > 0 Then
            grid_movimientos.DataSource = dt_movimiento
            txt_descripcion.Focus()
        Else
            util.mensajes("No se registran movimientos para el Item", TITULO_MSJ, "WAR")
            txt_descripcion.Text = ""
            txt_codigo.Text = ""
        End If
    End Sub

    Private Sub buscar_item()
        If chk_articulos.Checked = False And chk_materia_prima.Checked = False Then
            util.mensajes("Debe seleccionar Tipo de Movimiento", TITULO_MSJ, "WAR")
            Return
        End If

        If chk_articulos.Checked Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_movimientos_stock_items"
            frm.Show()
        End If

        If chk_materia_prima.Checked Then
            Dim frm As New frm_vista_materiales
            frm.FRM_ACTIVO = "frm_movimientos_stock_items"
            frm.Show()
        End If
    End Sub

    Public Sub obtener_articulo(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT nombre, codigo_barras FROM articulos WHERE id_articulo=" + id)

        If dt.Rows.Count > 0 Then
            txt_descripcion.Text = CStr(dt.Rows(0).Item(0))
            txt_codigo.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_materia_prima(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT nombre, codigo FROM materiales WHERE id_material=" + id)

        If dt.Rows.Count > 0 Then
            txt_descripcion.Text = CStr(dt.Rows(0).Item(0))
            txt_codigo.Text = CStr(dt.Rows(0).Item(1))
        End If

        listar()
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

        Dim id_movimiento As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "id_movimiento").ToString())

        Dim dt = movim.consultar("select coalesce(pe.numero,''), coalesce(co.numero,''), coalesce(ve.numero,'')
                                    from movimiento_stock ms 
                                    left join pedidos pe on pe.id_pedido = ms.id_pedido
                                    left join compras co on co.id_compra = ms.id_compra
                                    left join ventas ve on ve.id_venta = ms.id_venta
                                    where ms.id_movimiento_stock=" & CStr(id_movimiento))

        txt_nro_pedido.Text = CStr(dt.Rows(0).Item(0))
        txt_nro_venta.Text = CStr(dt.Rows(0).Item(1))
        txt_nro_compra.Text = CStr(dt.Rows(0).Item(2))
    End Sub


    Private Sub chk_articulos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulos.CheckedChanged
        If chk_articulos.Checked Then
            chk_materia_prima.Checked = False
            grid_movimientos.DataSource = Nothing
            limpiar()
        End If
    End Sub

    Private Sub chk_materia_prima_CheckedChanged(sender As Object, e As EventArgs) Handles chk_materia_prima.CheckedChanged
        If chk_materia_prima.Checked Then
            chk_articulos.Checked = False
            grid_movimientos.DataSource = Nothing
            limpiar()
        End If
    End Sub

    Private Sub txt_descripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_descripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            buscar_item()
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub btn_buscar_item_Click(sender As Object, e As EventArgs) Handles btn_buscar_item.Click
        buscar_item()
    End Sub

    Private Sub btn_desde_Click(sender As Object, e As EventArgs) Handles btn_desde.Click
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub btn_hasta_Click(sender As Object, e As EventArgs) Handles btn_hasta.Click
        cld_hasta.Visible = True
        cld_hasta.Focus()
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
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim report As New rpt_movim_stock_item

        report.DataSource = grid_movimientos.DataSource

        If chk_articulos.Checked Then
            report.Parameters("tipo_movimiento").Value = "Tipo de Movim.: ARTICULOS"
        End If
        If chk_materia_prima.Checked Then
            report.Parameters("tipo_movimiento").Value = "Tipo de Movim.: MATERIA PRIMA"
        End If

        report.Parameters("descripcion").Value = "Descripcion: " & txt_descripcion.Text
        report.Parameters("fecha_desde").Value = "Fecha Desde: " & txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " & txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("tipo_movimiento").Visible = False
        report.Parameters("descripcion").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub

    Private Sub chk_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_articulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_articulos.Checked Then
                txt_descripcion.Focus()
            Else
                chk_materia_prima.Focus()
            End If
        End If
    End Sub

    Private Sub chk_materia_prima_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_materia_prima.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_materia_prima.Checked Then
                txt_descripcion.Focus()
            Else
                chk_articulos.Focus()
            End If
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

    Private Sub grid_movimientos_Click(sender As Object, e As EventArgs) Handles grid_movimientos.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_movimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_movimientos.KeyDown
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
End Class