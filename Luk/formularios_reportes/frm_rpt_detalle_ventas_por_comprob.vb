Imports DevExpress.XtraReports.UI

Public Class frm_rpt_detalle_ventas_por_comprob

    Private venta As New func_ventas
    Private dt_ventas As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Ventas por Comprobante>"

    Private ID_FAMILIA As Integer = 0
    Private ID_ARTICULO As Integer = 0

    Private Sub frm_rpt_detalle_ventas_por_comprob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        txt_sucursal.Focus()
    End Sub

    Private Sub consultar()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim orden As String = " ORDER BY vta.fecha_venta DESC"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = " vta.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND vta.fecha_venta >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND vta.fecha_venta <='" + txt_fecha_hasta.Text + "'"
        End If

        dt_ventas = venta.consultar("select *, round(sum(participacion)over(order by pos),2) as acumulado from (
        SELECT  row_number() over(order by familia,item ASC) as pos ,*,
        round((CASE costo_total when 0 then 100 else  utilidad * 1.0 /costo_total * 100 end),2)as porc_util
        , round( (total * 1.0) /(select sum(total_item)*1.0 from items_venta iv
        						  INNER JOIN ventas vta ON vta.id_venta = iv.id_venta
        						  INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
        						  INNER JOIN familias f ON f.identificador = a.id_familia  WHERE" +
                            sucursal + desde + hasta + "
                                )*100,2)   As participacion
                            FROM(
        						SELECT CONCAT(vta.numero,'   Fecha: ',to_char(vta.fecha_venta,'DD/MM/YYYY')) AS comprobante, vta.id_venta, iv.id_articulo as id_articulo,a.codigo_barras as codigo_barras
        							,a.nombre AS item 
        							,COALESCE(f.descripcion,'NO DEFINIDO') AS familia
        							,sum(iv.cantidad)as cantidad 
        							,sum(iv.costo_unitario * iv.cantidad) AS costo_total 
        							,sum(iv.total_item) AS total 
        							,sum((iv.total_item - (iv.costo_unitario * iv.cantidad))) AS utilidad
        						FROM items_venta iv
        						INNER JOIN ventas vta ON vta.id_venta = iv.id_venta
        						INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
        						INNER JOIN familias f ON f.identificador = a.id_familia WHERE " +
                          sucursal + desde + hasta + " AND vta.fecha_anulacion IS NULL
        						GROUP BY  CONCAT(vta.numero,'   Fecha: ',vta.fecha_venta), vta.id_venta, vta.fecha_venta, iv.id_articulo,a.codigo_barras,a.nombre,f.descripcion
        						order by comprobante,item
        						 ) AS x
        )as xy order by id_venta")


        grid_ventas.DataSource = Nothing

        If dt_ventas.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_ventas
        Else
            util.mensajes("No se registraron ventas", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = venta.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
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
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_detalle_venta_por_comprob

        report.DataSource = dt_ventas

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

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_detalle_ventas_por_comprob"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_detalle_ventas_por_comprob"
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

    Private Sub btn_articulo_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_vista_articulos
        frm.FRM_ACTIVO = "frm_rpt_detalle_ventas_por_comprob"
        frm.Show()
    End Sub

    Private Sub txt_articulo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_rpt_detalle_ventas_por_comprob"
            frm.Show()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        ID_FAMILIA = 0
        ID_ARTICULO = 0
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