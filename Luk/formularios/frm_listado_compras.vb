Imports DevExpress.XtraReports.UI

Public Class frm_listado_compras

    Private compras As New func_compras
    Private dt_compras As New DataTable
    Private dt_tipo_comprobantes As New DataTable
    Private dt_items_compra As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Listado de Compras>"

    Private REQUIERE_ITEM As Boolean = False
    Private TIPO_ITEM As String = ""
    Private ID_TIPO As Integer = 0
    Private ID_PROVEEDOR As Integer = 0
    Private ID_FAMILIA As Integer = 0

    Private Sub frm_listado_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_tipo_facturas()
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
        lbl_total_registros_item.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub limpiar()
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        cbo_tipos.SelectedIndex = -1
        txt_proveedor.Text = ""
        grid_compras.DataSource = Nothing
    End Sub

    Private Sub obtener_compras()
        Dim sucursal As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim tipo As String = ""
        Dim proveedor As String = ""
        Dim familia As String = ""
        Dim orden As String = " ORDER BY c.id_compra DESC"

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "WHERE c.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND c.fecha_compra >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND c.fecha_compra <='" + txt_fecha_hasta.Text + "'"
        End If

        If cbo_tipos.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar Tipo de Compra", TITULO_MSJ, "WAR")
            cbo_tipos.Focus()
            Return
        Else
            tipo = " AND c.id_tipo_compra = " + ID_TIPO.ToString
        End If

        If txt_proveedor.Text.Replace(" ", "") = "" Then
        Else
            If ID_PROVEEDOR <= 0 Then
                util.mensajes("Debe seleccionar Proveedor", TITULO_MSJ, "WAR")
                txt_proveedor.Focus()
                Return
            End If
            proveedor = " AND c.id_proveedor = " + ID_PROVEEDOR.ToString
        End If

        dt_compras = compras.consultar("SELECT c.id_compra, c.numero AS nro_compra, tc.nombre AS tipo_compra, c.fecha_compra, p.nombre AS proveedor, 
                                        c.total_compra, fc.numero_factura AS nro_factura, COALESCE(c.factura, false) AS factura, tc.relacion,
                                        fc.monto_gravado AS gravadas, fc.total_iva AS impuestos
                                        FROM compras c 
                                        LEFT JOIN tipos_compra tc ON tc.id_tipo_compra = c.id_tipo_compra
                                        LEFT JOIN proveedores p ON p.id_proveedor = c.id_proveedor
                                        LEFT JOIN facturas_compra fc ON fc.id_factura = c.id_factura " &
                                        sucursal & desde & hasta & tipo & proveedor & orden)
        If dt_compras.Rows.Count > 0 Then
            grid_compras.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub obtener_items_compra(id_compra As String, relacion As String)
        dt_items_compra.Clear()
        If relacion = "ARTICULOS" Then
            dt_items_compra = compras.consultar("SELECT a.codigo_barras, a.nombre AS item, it.cantidad, it.costo_unitario, it.costo_total
                                        FROM items_compras it
                                        LEFT JOIN articulos a ON a.id_articulo = it.id_articulo
                                        WHERE it.id_compra = " + id_compra + "
                                        ORDER BY it.id_item_compra DESC")
            GridView2.Columns().Item("codigo_barras").Visible = True
        End If

        If relacion = "MATERIA PRIMA" Then
            dt_items_compra = compras.consultar("SELECT '' AS codigo_barras, m.nombre AS item, it.cantidad, it.costo_unitario, it.costo_total
                                                FROM items_compras it
                                                LEFT JOIN materiales m ON m.id_material = it.id_material
                                                WHERE it.id_compra = " + id_compra + "
                                                ORDER BY it.id_item_compra DESC")
            GridView2.Columns().Item("codigo_barras").Visible = False
        End If


        grid_items_compra.DataSource = dt_items_compra
        lbl_total_registros_item.Text = "Registros recuperados: " & GridView2.RowCount
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = compras.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable
        dt = compras.consultar("SELECT identificador, descripcion FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
        End If
    End Sub

    Public Sub obtener_tipo_facturas()
        dt_tipo_comprobantes = compras.consultar("SELECT id_tipo_compra, nombre, relacion FROM tipos_compra")
        If dt_tipo_comprobantes.Rows.Count > 0 Then
            cbo_tipos.Properties.Items.Clear()
            For Each row As DataRow In dt_tipo_comprobantes.Rows
                cbo_tipos.Properties.Items.Add(row("nombre"))
            Next
        End If
    End Sub

    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = compras.consultar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor=" + id.ToString() + "")
        ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
        txt_proveedor.Text = CStr(dt.Rows(0).Item(1))
    End Sub


    Private Sub grid_compras_DoubleClick(sender As Object, e As EventArgs) Handles grid_compras.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle
        If fila < 0 Then
            Return
        End If

        Dim id_compra As String = CStr(GridView1.GetRowCellValue(fila, "id_compra"))
        Dim relacion As String = CStr(GridView1.GetRowCellValue(fila, "relacion"))

        obtener_items_compra(id_compra, relacion)
    End Sub

    Private Sub grid_compras_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_compras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim fila As Integer = GridView1.FocusedRowHandle
            If fila < 0 Then
                Return
            End If

            Dim id_compra As String = CStr(GridView1.GetRowCellValue(fila, "id_compra"))
            Dim relacion As String = CStr(GridView1.GetRowCellValue(fila, "relacion"))

            obtener_items_compra(id_compra, relacion)
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", "<Listado de Compras>", "WAR")
            Return
        End If

        Dim fila As Integer = GridView1.FocusedRowHandle
        Dim report As New rpt_items_compra

        report.DataSource = grid_items_compra.DataSource

        report.Parameters("fecha").Value = "Fecha de Compra: " + GridView1.GetRowCellValue(fila, "fecha_compra").ToString
        report.Parameters("proveedor").Value = "Proveedor: " + GridView1.GetRowCellValue(fila, "proveedor").ToString
        report.Parameters("tipo_compra").Value = "Tipo de Compra: " + GridView1.GetRowCellValue(fila, "tipo_compra").ToString
        report.Parameters("nro_compra").Value = "Nro. de Compra: " + GridView1.GetRowCellValue(fila, "nro_compra").ToString
        report.Parameters("nro_factura").Value = "Nro. Factura: " + GridView1.GetRowCellValue(fila, "nro_factura").ToString
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("fecha").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("tipo_compra").Visible = False
        report.Parameters("nro_compra").Visible = False
        report.Parameters("nro_factura").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        obtener_compras()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub cbo_tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipos.SelectedIndexChanged
        If cbo_tipos.SelectedIndex >= 0 Then
            ID_TIPO = CInt(dt_tipo_comprobantes.Rows(cbo_tipos.SelectedIndex).Item(0))
            TIPO_ITEM = CStr(dt_tipo_comprobantes.Rows(cbo_tipos.SelectedIndex).Item(2))
        End If
    End Sub
    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_listado_compras"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_listado_compras"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
            Else
                txt_fecha_desde.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipos.Focus()
        End If
    End Sub

    Private Sub cbo_tipos_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipos.SelectedIndex >= 0 Then
                txt_proveedor.Focus()
            End If
        End If
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_listado_compras"
        frm.Show()
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_listado_compras"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btn_nueva_cons.Click
        limpiar()
        txt_sucursal.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
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

    Private Sub btn_familia_Click(sender As Object, e As EventArgs)
        If TIPO_ITEM = "ARTICULOS" Then
            Dim frm As New frm_vista_familias
            frm.FRM_ACTIVO = "frm_listado_compras"
            frm.Show()
        End If

        If TIPO_ITEM = "MATERIA PRIMA" Then
            Dim frm As New frm_vista_familia_materia_prima
            frm.FRM_ACTIVO = "frm_listado_compras"
            frm.Show()
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If TIPO_ITEM = "ARTICULOS" Then
                Dim frm As New frm_vista_familias
                frm.FRM_ACTIVO = "frm_listado_compras"
                frm.Show()
            End If

            If TIPO_ITEM = "MATERIA PRIMA" Then
                Dim frm As New frm_vista_familia_materia_prima
                frm.FRM_ACTIVO = "frm_listado_compras"
                frm.Show()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
    End Sub

End Class