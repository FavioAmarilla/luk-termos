Imports DevExpress.XtraReports.UI

Public Class frm_liquidacion_vendedores

    Private liquidacionas As New func_liquidacion_vendedores
    Private dt_liquidaciones As New DataTable()
    Private dt_items_liquidacion As New DataTable
    Private util As New utilidades()
    Private TITULO_MSJ As String = "<Liquidaciones de Vendedores>"
    Private ID_LIQUIDACION As Integer = 0

    Private Sub frm_liquidacion_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        btn_actualizar.Enabled = False
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub listar()
        dt_liquidaciones = liquidacionas.consultar("SELECT l.id_liquidacion, l.fecha, CONCAT(v.nombres,' ',v.apellidos) AS vendedor,
                                                    COALESCE(l.total_pagado, 0) AS total_pagado, l.id_vendedor
                                                    FROM liquidaciones_vendedores l
                                                    LEFT JOIN vendedores v ON v.id_vendedor = l.id_vendedor 
                                                    ORDER BY id_liquidacion DESC")

        grid_liquidaciones.DataSource = dt_liquidaciones
    End Sub

    Private Sub obtener_items_liquidacion(id As String)
        dt_items_liquidacion = liquidacionas.consultar("SELECT vt.fecha_cre, vt.numero, vt.total_venta, vt.comision_vendedor AS comision, 
                                                        vt.comision_vendedor AS total, it.pagado, it.id_venta, it.id_item_liquidacion, FALSE AS nuevo
                                                        FROM items_liquidacion_vendedores it
                                                        LEFT JOIN ventas vt ON vt.id_venta = it.id_venta
                                                        WHERE vt.id_liquidacion=" + id + " ")
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

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_vista_vendedores.FRM_ACTIVO = "frm_items_liquidacion_vendedores"
        frm_vista_vendedores.MdiParent = frm_main
        frm_vista_vendedores.Show()
        Close()
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

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If ID_LIQUIDACION > 0 Then
            Dim emp As Integer = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_vendedor"))
            Dim liq As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_liquidacion").ToString()
            frm_items_liquidacion_vendedores.MdiParent = frm_main
            frm_items_liquidacion_vendedores.CONDICION_SQL = " WHERE it.id_liquidacion=" + liq + " ORDER BY it.fecha_cre ASC"
            frm_items_liquidacion_vendedores.txt_nro_liquidacion.Text = liq
            frm_items_liquidacion_vendedores.obtener_liquidacion(emp, "update")
            frm_items_liquidacion_vendedores.EXISTE_LIQUIDACION = True
            frm_items_liquidacion_vendedores.btn_registrar.Text = "Actualizar"
            frm_items_liquidacion_vendedores.Show()
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
        Dim report As New rpt_liquidacion_vendedores

        report.DataSource = dt_items_liquidacion

        report.Parameters("vendedor").Value = "Vendedor: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "vendedor").ToString
        report.Parameters("fecha").Value = "Fecha Liq.: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "fecha").ToString
        report.Parameters("numero").Value = "Numero Liq.: " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_liquidacion").ToString
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("vendedor").Visible = False
        report.Parameters("fecha").Visible = False
        report.Parameters("numero").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

End Class