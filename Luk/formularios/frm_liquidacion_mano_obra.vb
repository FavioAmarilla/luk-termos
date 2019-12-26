Imports DevExpress.XtraReports.UI

Public Class frm_liquidacion_mano_obra

    Private liquidacionas As New func_liquidacion_mano_obra()
    Private dt_liquidaciones As New DataTable()
    Private dt_items_liquidacion As New DataTable()
    Private util As New utilidades()
    Private TITULO_MSJ As String = "<Liquidaciones de Mano de Obra>"
    Private ID_LIQUIDACION As Integer = 0

    Private Sub frm_liquidacion_mano_obra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_actualizar.Enabled = False
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub listar()
        dt_liquidaciones = liquidacionas.consultar("SELECT l.id_liquidacion, l.fecha, CONCAT(e.nombres,' ',e.apellidos) AS empleado,
                                                    l.cantidad_articulos, e.id_empleado, l.total_pagado 
                                                    FROM liquidaciones_mano_obra l
                                                    LEFT JOIN empleados e ON e.id_empleado = l.id_empleado
                                                    ORDER BY id_liquidacion DESC")
        If dt_liquidaciones.Rows.Count > 0 Then
            grid_liquidaciones.DataSource = dt_liquidaciones
        End If
    End Sub

    Private Sub cargar_fila(ByVal accion As String)
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
            ID_LIQUIDACION = CInt(GridView1.GetRowCellValue(rowhandle, "id_liquidacion").ToString())
            obtener_items_liquidacion(ID_LIQUIDACION.ToString)
            btn_actualizar.Enabled = True
        End If
    End Sub

    Private Sub obtener_items_liquidacion(id As String)
        dt_items_liquidacion = liquidacionas.consultar("SELECT a.id_asignacion_pedido_empleado, p.numero AS pedido, ar.nombre AS articulo , 
                                    a.cantidad_asignada AS cantidad, COALESCE(a.mano_obra,0) AS mano_obra, COALESCE(a.pago_extra,0) AS pago_extra, 
                                    COALESCE((a.mano_obra + a.pago_extra) * a.cantidad_asignada,0) AS total, 
                                    COALESCE(a.pagado, false) AS liquidar, p.id_pedido, false AS nuevo
                                    FROM asignacion_pedido_empleado a
                                    LEFT JOIN empleados e ON e.id_empleado = a.id_empleado
                                    LEFT JOIN pedidos p ON p.id_pedido = a.id_pedido 
                                    LEFT JOIN articulos ar ON ar.id_articulo = p.id_articulo
                                    WHERE a.id_liquidacion=" + id + "")
    End Sub

    Private Sub grid_liquidaciones_Click(sender As Object, e As EventArgs) Handles grid_liquidaciones.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_liquidaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_liquidaciones.KeyDown
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

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_vista_empleados.FRM_ACTIVO = "frm_items_liquidacion_mano_obra"
        frm_vista_empleados.MdiParent = frm_main
        frm_vista_empleados.Show()
        Close()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If ID_LIQUIDACION > 0 Then
            Dim emp As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_empleado"))
            Dim liq As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_liquidacion").ToString()
            frm_items_liquidacion_mano_obra.MdiParent = frm_main
            frm_items_liquidacion_mano_obra.CONDICION_SQL = "WHERE a.id_liquidacion=" + liq + " ORDER BY p.numero ASC"
            frm_items_liquidacion_mano_obra.txt_nro_liquidacion.Text = liq
            frm_items_liquidacion_mano_obra.obtener_liquidacion(emp)
            frm_items_liquidacion_mano_obra.EXISTE_LIQUIDACION = True
            frm_items_liquidacion_mano_obra.btn_registrar.Text = "Actualizar"
            frm_items_liquidacion_mano_obra.Show()
        Else
            util.mensajes("Selccione Liquidacion para actualizar", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If

        If ID_LIQUIDACION <= 0 Then
            util.mensajes("Debe seleccionar Liquidacion", TITULO_MSJ, "WAR")
            Return
        End If

        Dim report As New rpt_liquidaciones_mano_obra

        report.DataSource = dt_items_liquidacion

        report.Parameters("empleado").Value = "Productor: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "empleado").ToString
        report.Parameters("fecha").Value = "Fecha Liq.: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fecha").ToString
        report.Parameters("numero").Value = "Numero Liq.: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_liquidacion").ToString
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("empleado").Visible = False
        report.Parameters("fecha").Visible = False
        report.Parameters("numero").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

End Class