Imports DevExpress.XtraReports.UI

Public Class frm_rpt_compras_detalle_por_fecha

    Private compra As New func_compras
    Private dt_compras As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Compras por Fecha>"

    Private Sub frm_rpt_compras_detalle_por_fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub limpiar()
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = compra.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub consultar()
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        End If

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha desde", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha hasta", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If

        Dim sql As String = ""
        If cbo_tipo.SelectedIndex = 0 Then
            sql = "select concat('FECHA: ',to_char(cp.fecha_compra,'dd/mm/yyyy'),'  PROVEEDOR:',pv.nombre ,'  FACTURA Nº:',coalesce(fc.numero_factura, 'SIN FACTURA') ,'  TOTAL:',cp.total_compra) as compra,
                                        ar.codigo_barras as codigo, ar.nombre as item, ic.cantidad, ic.costo_unitario, ic.costo_total
                                        from compras cp
                                        left join proveedores pv on pv.id_proveedor = cp.id_proveedor
                                        left join facturas_compra fc on fc.id_factura = cp.id_factura
                                        left join items_compras ic on ic.id_compra = cp.id_compra
                                        inner join articulos ar on ar.id_articulo = ic.id_articulo
                                        where cp.id_sucursal=" & txt_id_sucursal.Text & " and to_char(cp.fecha_compra,'dd/mm/yyyy') >= '" & txt_fecha_desde.Text & "' and to_char(cp.fecha_compra,'dd/mm/yyyy') <= '" & txt_fecha_hasta.Text & "'
                                        order by ic.fecha_cre desc"
        End If

        If cbo_tipo.SelectedIndex = 1 Then
            sql = "select concat('FECHA: ',to_char(cp.fecha_compra,'dd/mm/yyyy'),'  PROVEEDOR:',pv.nombre ,'  FACTURA Nº:',coalesce(fc.numero_factura, 'SIN FACTURA') ,'  TOTAL:',cp.total_compra) as compra,
					                    ma.codigo, ma.nombre as item, ic.cantidad, ic.costo_unitario, ic.costo_total
					                    from compras cp
					                    left join proveedores pv on pv.id_proveedor = cp.id_proveedor
					                    left join facturas_compra fc on fc.id_factura = cp.id_factura
					                    left join items_compras ic on ic.id_compra = cp.id_compra
					                    inner join materiales ma on ma.id_material = ic.id_material
                                        where cp.id_sucursal=" & txt_id_sucursal.Text & " and to_char(cp.fecha_compra,'dd/mm/yyyy') >= '" & txt_fecha_desde.Text & "' and to_char(cp.fecha_compra,'dd/mm/yyyy') <= '" & txt_fecha_hasta.Text & "'
                                        order by ic.fecha_cre desc"
        End If

        dt_compras = compra.consultar(sql)

        If dt_compras.Rows.Count > 0 Then
            grid_compras.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_compras.DataSource = Nothing
        End If

        txt_sucursal.Focus()

    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_compras_detalle_por_fecha"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_compras_detalle_por_fecha"
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
        Dim report As New rpt_cmp_detalle_por_fecha

        report.DataSource = grid_compras.DataSource

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
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""

        grid_compras.DataSource = Nothing
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