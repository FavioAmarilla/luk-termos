﻿Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class frm_rpt_pedidos_recibidos_familia

    Private pedido As New func_pedidos
    Private dt_pedidos As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Reporte de Pedidos Recibidos>"

    Private COD_FAMILIA As String = ""
    Private ID_VENDEDOR As Integer = 0

    Private Sub frm_rpt_pedidos_recibidos_familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_fecha_desde.Visible = False
        cls_fecha_hasta.Visible = False
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub listar()
        Dim sucursal As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim prioridad As String = ""
        Dim familia As String = ""

        If txt_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            Return
        Else
            sucursal = " WHERE p.id_sucursal = " + txt_id_sucursal.Text
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND p.fecha_pedido >='" + txt_fecha_desde.Text + "'"
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND p.fecha_pedido <='" + txt_fecha_hasta.Text + "'"
        End If

        If chk_prioridad.Checked Then
            prioridad = "AND p.prioridad=TRUE"
        Else
            prioridad = " AND p.prioridad=false"
        End If

        If chk_familia.Checked Then
            familia = " AND f.codigo like '" & COD_FAMILIA & "%'"
        End If


        dt_pedidos = pedido.consultar("SELECT p.numero, p.fecha_pedido, p.fecha_entrega, CONCAT(c.nombres,' ',c.apellidos) AS cliente, a.nombre as articulo, 
                                       p.cantidad, p.costo_total AS costo_total, p.total_precio_venta, estado, f.descripcion as familia
                                       FROM pedidos p
                                       inner join articulos a on a.id_articulo = p.id_articulo
                                       inner join familias f on f.identificador = a.id_familia
                                       INNER JOIN clientes c ON c.id_cliente = p.id_cliente " +
                                       sucursal + desde + hasta + prioridad + familia + " ORDER BY p.numero DESC")
        If dt_pedidos.Rows.Count > 0 Then
            grid_listado.DataSource = dt_pedidos
        Else
            util.mensajes("No se registraron Pedidos", TITULO_MSJ, "INF")
            grid_listado.DataSource = Nothing
            txt_sucursal.Focus()
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = pedido.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable

        dt = pedido.consultar("SELECT descripcion, codigo FROM familias WHERE identificador= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_familia.Text = CStr(dt.Rows(0).Item(0))
            COD_FAMILIA = CStr(dt.Rows(0).Item(1))
            txt_familia.Focus()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs)
        GridView1.ShowPrintPreview()
    End Sub

    Private Sub GridView1_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        listar()
        btn_consultar.Focus()

        If GridView1.RowCount <= 0 Then
            txt_sucursal.Focus()
        Else
            btn_consultar.Focus()
        End If
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia"
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
            cld_fecha_desde.Visible = True
            cld_fecha_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_prioridad.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            cls_fecha_hasta.Visible = True
            cls_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub chk_prioridad_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_prioridad.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_familia.Focus()
        End If
    End Sub

    Private Sub btn_imprimir_Click_1(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_pedidos_recibidos_familia

        report.DataSource = dt_pedidos

        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("fecha_desde").Value = "Fecha Desde: " + txt_fecha_desde.Text
        report.Parameters("fecha_hasta").Value = "Fecha Hasta: " + txt_fecha_hasta.Text
        report.Parameters("familia").Value = "Familia: " + txt_familia.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("sucursal").Visible = False
        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub cld_fecha_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_fecha_desde.DoubleClick
        txt_fecha_desde.Text = cld_fecha_desde.DateTime.ToString
        txt_fecha_desde.Focus()
        cld_fecha_desde.Visible = False
    End Sub

    Private Sub cld_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_fecha_desde.DateTime.ToString
            txt_fecha_desde.Focus()
            cld_fecha_desde.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_fecha_desde.Visible = False
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub cls_fecha_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cls_fecha_hasta.DoubleClick
        txt_fecha_hasta.Text = cls_fecha_hasta.DateTime.ToString
        txt_fecha_hasta.Focus()
        cls_fecha_hasta.Visible = False
    End Sub

    Private Sub cls_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cls_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cls_fecha_hasta.DateTime.ToString
            txt_fecha_hasta.Focus()
            cls_fecha_hasta.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cls_fecha_hasta.Visible = False
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub btn_calendar_desde_Click(sender As Object, e As EventArgs) Handles btn_desde.Click
        cld_fecha_desde.Visible = True
        cld_fecha_desde.Focus()
    End Sub

    Private Sub btn_calendar_hasta_Click(sender As Object, e As EventArgs) Handles btn_hasta.Click
        cls_fecha_hasta.Visible = True
        cls_fecha_hasta.Focus()
    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_familias.Click
        Dim frm As New frm_vista_familias_all
        frm.FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia"
        frm.Show()
    End Sub

    Private Sub chk_familia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_familia.CheckedChanged
        If chk_familia.Checked Then
            txt_familia.Enabled = True
            btn_familias.Enabled = True
        Else
            txt_familia.Text = ""
            COD_FAMILIA = ""
            txt_familia.Enabled = False
            btn_familias.Enabled = False
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

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_familias_all
            frm.FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia"
            frm.Show()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        cld_fecha_desde.Visible = False
        cls_fecha_hasta.Visible = False
        chk_prioridad.Checked = False
        chk_familia.Checked = False
        txt_familia.Text = ""

        grid_listado.DataSource = Nothing
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub


End Class