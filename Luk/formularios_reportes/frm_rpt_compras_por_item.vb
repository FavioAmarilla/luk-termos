Imports DevExpress.XtraReports.UI

Public Class frm_rpt_compras_por_item

    Dim compra As New func_compras
    Dim dt_compras As New DataTable
    Dim util As New utilidades
    Dim TITULO_MSJ As String = "<Reporte de compras por item>"
    Dim ID_SUCURSAL As Integer
    Dim ID_ITEM As Integer

    Private Sub frm_rpt_compras_por_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub consultar()
        Dim sql As String = ""
        Dim sucursal As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim item As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "where ic.id_articulo > 0 AND c.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " and c.fecha_compra >= '" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " and c.fecha_compra <='" + txt_fecha_hasta.Text + "'"
        End If

        If cbo_tipo.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de item", TITULO_MSJ, "WAR")
            cbo_tipo.Focus()
            Return
        End If

        If ID_ITEM <= 0 Then
            util.mensajes("Debe seleccionar item de compra", TITULO_MSJ, "WAR")
            txt_item.Focus()
            Return
        End If

        If cbo_tipo.SelectedIndex = 0 Then
            item = " and ic.id_articulo=" & ID_ITEM.ToString

            sql = "select c.fecha_compra as fecha, a.codigo_barras as codigo_barras, a.nombre as item, p.nombre as proveedor, coalesce(fc.numero_factura, '*') as numero_factura, 
                    ic.costo_unitario, sum(ic.cantidad) as cantidad, sum(round(ic.costo_unitario * ic.cantidad) )as costo_total
                    from compras c
                    left join facturas_compra fc on fc.id_factura = c.id_factura 
                    left join items_compras ic on ic.id_compra = c.id_compra
                    left join articulos a on a.id_articulo = ic.id_articulo
                    left join proveedores p on p.id_proveedor = ic.id_proveedor " &
                    sucursal & desde & hasta & item &
                    " group by c.fecha_compra, a.codigo_barras, a.nombre, p.nombre, fc.numero_factura, ic.costo_unitario order by c.fecha_compra asc"
        End If

        If cbo_tipo.SelectedIndex = 1 Then
            item = " and ic.id_material=" & ID_ITEM.ToString

            sql = "select c.fecha_compra as fecha, m.codigo as codigo_barras, m.nombre as item, p.nombre as proveedor, coalesce(fc.numero_factura, '*') as numero_factura, 
                    ic.costo_unitario, sum(ic.cantidad) as cantidad, sum(round(ic.costo_unitario * ic.cantidad) )as costo_total
                    from compras c
                    left join facturas_compra fc on fc.id_factura = c.id_factura 
                    left join items_compras ic on ic.id_compra = c.id_compra
                    left join materiales m on m.id_material = ic.id_material
                    left join proveedores p on p.id_proveedor = ic.id_proveedor " &
                    sucursal & desde & hasta & item &
                    " group by c.fecha_compra, m.codigo, m.nombre, p.nombre, fc.numero_factura, ic.costo_unitario order by c.fecha_compra asc"
        End If

        dt_compras = compra.consultar(sql)

        If dt_compras.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
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

    Public Sub obtener_articulo(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_articulo, nombre FROM articulos WHERE id_articulo=" + id)

        If dt.Rows.Count > 0 Then
            ID_ITEM = CInt(dt.Rows(0).Item(0))
            txt_item.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_materia_prima(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_material, nombre FROM materiales WHERE id_material=" + id)

        If dt.Rows.Count > 0 Then
            ID_ITEM = CInt(dt.Rows(0).Item(0))
            txt_item.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text IsNot "" Then
                cbo_tipo.Focus()
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
        frm.CONDICION_SQL = " WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub cbo_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo.SelectedIndex >= 0 Then
                txt_item.Focus()
            End If
        End If
    End Sub

    Private Sub txt_item_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_item.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_item.Text IsNot "" Then
                txt_fecha_desde.Focus()
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If cbo_tipo.SelectedIndex = 0 Then
                Dim frm As New frm_vista_articulos
                frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
                frm.CONDICION_SQL = " WHERE activo = TRUE"
                frm.Show()
            End If
            If cbo_tipo.SelectedIndex = 1 Then
                Dim frm As New frm_vista_materiales
                frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
                frm.Show()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If cbo_tipo.SelectedIndex = 0 Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
            frm.CONDICION_SQL = " WHERE activo= TRUE"
            frm.Show()
        End If
        If cbo_tipo.SelectedIndex = 1 Then
            Dim frm As New frm_vista_materiales
            frm.FRM_ACTIVO = "frm_rpt_compras_por_item"
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

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        consultar()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_compras_por_item

        report.DataSource = dt_compras

        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        cbo_tipo.SelectedIndex = -1
        txt_item.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
    End Sub

    Private Sub cbo_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo.SelectedIndexChanged
        txt_item.Text = ""
        ID_ITEM = 0
    End Sub
End Class