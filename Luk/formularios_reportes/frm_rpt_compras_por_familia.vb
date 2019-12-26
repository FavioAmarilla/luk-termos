Imports DevExpress.XtraReports.UI

Public Class frm_rpt_compras_por_familia

    Private compra As New func_compras
    Private dt_compras As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Compras por Familia>"

    Private ID_FAMILIA As Integer = 0
    Private COD_FAMILIA As String = ""
    Private ID_ARTICULO As Integer = 0

    Private Sub frm_rpt_compras_por_familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub consultar_articulos()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim familia As String = ""
        Dim orden As String = " ORDER BY ic.fecha_Cre DESC"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "WHERE ic.id_articulo > 0 AND c.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND to_char(ic.fecha_cre, 'dd/MM/yyyy')  >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND to_char(ic.fecha_cre, 'dd/MM/yyyy')  <='" + txt_fecha_hasta.Text + "'"
        End If

        If txt_familia.Text.Replace(" ", "") = "" Then
        Else
            familia = " AND f.codigo like '" + COD_FAMILIA + "%'"
        End If

        dt_compras = compra.consultar("SELECT to_char(ic.fecha_cre, 'dd/MM/yyyy') AS fecha, a.nombre AS item, 
                                        f.descripcion AS familia, ic.cantidad, ic.costo_unitario, ic.costo_total
                                        FROM items_compras ic
                                        INNER JOIN compras c ON c.id_compra = ic.id_compra
                                        INNER JOIN articulos a ON a.id_articulo = ic.id_articulo
                                        INNER JOIN familias f ON f.identificador =a.id_familia " +
                                        sucursal + familia + desde + hasta + orden)

        If dt_compras.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
        End If

    End Sub

    Private Sub consultar_materia_prima()
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim familia As String = ""
        Dim orden As String = " ORDER BY ic.fecha_Cre DESC"
        Dim sucursal As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            sucursal = "WHERE ic.id_material > 0 AND c.id_sucursal= " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND to_char(ic.fecha_cre, 'dd/MM/yyyy')  >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND to_char(ic.fecha_cre, 'dd/MM/yyyy')  <='" + txt_fecha_hasta.Text + "'"
        End If

        If txt_familia.Text.Replace(" ", "") = "" Then
        Else
            familia = " AND f.codigo like '" + COD_FAMILIA + "%'"
        End If

        dt_compras = compra.consultar("SELECT to_char(ic.fecha_cre, 'dd/MM/yyyy') AS fecha, m.nombre AS item, 
                                        f.descripcion AS familia, ic.cantidad, ic.costo_unitario, ic.costo_total
                                        FROM items_compras ic
                                        INNER JOIN compras c ON c.id_compra = ic.id_compra
                                        INNER JOIN materiales m ON m.id_material = ic.id_material
                                        INNER JOIN familias_materia_prima f ON f.identificador =a.id_familia " +
                                        sucursal + familia + desde + hasta + orden)

        If dt_compras.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_compras
        Else
            util.mensajes("No se registraron compras", TITULO_MSJ, "INF")
            txt_sucursal.Focus()
            grid_ventas.DataSource = Nothing
        End If

    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT identificador, descripcion, codigo FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
            COD_FAMILIA = CStr(dt.Rows(0).Item(2))
        End If
    End Sub
    Public Sub obtener_familia_material(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT identificador, descripcion, codigo FROM familias_materia_prima WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
            COD_FAMILIA = CStr(dt.Rows(0).Item(2))
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


    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            cbo_tipo.Focus()
        End If
    End Sub

    Private Sub btn_familia_Click(sender As Object, e As EventArgs) Handles btn_familia.Click
        If cbo_tipo.SelectedIndex = 0 Then
            Dim frm As New frm_vista_familias_all
            frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
            frm.Show()
        End If
        If cbo_tipo.SelectedIndex = 1 Then
            Dim frm As New frm_vista_familia_materia_prima_all
            frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
            frm.Show()
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If cbo_tipo.SelectedIndex = 0 Then
                Dim frm As New frm_vista_familias_all
                frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
                frm.Show()
            End If
            If cbo_tipo.SelectedIndex = 1 Then
                Dim frm As New frm_vista_familia_materia_prima_all
                frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
                frm.Show()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
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
        If cbo_tipo.SelectedIndex = 0 Then
            consultar_articulos()
        End If
        If cbo_tipo.SelectedIndex = 1 Then
            consultar_materia_prima()
        End If

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
        Dim report As New rpt_compras_por_familia

        report.DataSource = dt_compras

        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("familia").Value = "Familia: " + txt_familia.Text

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub btn_articulo_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_vista_articulos
        frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
        frm.Show()
    End Sub

    Private Sub txt_articulo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_rpt_compras_por_familia"
            frm.Show()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_familia.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        ID_FAMILIA = 0
        ID_ARTICULO = 0
        grid_ventas.DataSource = Nothing
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

    Private Sub cbo_tipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_familia.Focus()
        End If
    End Sub
End Class