Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class frm_listado_pedidos

    Private pedido As New func_pedidos
    Private dt_pedidos As New DataTable
    Private util As New utilidades

    Private Sub frm_listado_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub listar()
        dt_pedidos = pedido.consultar("SELECT p.id_pedido, p.fecha_pedido, p.numero, p.costo_total, p.total_precio_venta, a.nombre AS articulo, 
                                       CONCAT(c.nombres,' ',c.apellidos) AS cliente, c.telefono, c.direccion, COALESCE(recepcionado,false) AS recepcionado, 
                                       fecha_entrega,  COALESCE(entregado,false) AS entregado, COALESCE(p.comision_vendedor, 0) AS comision_vendedor,
                                       (p.total_precio_venta - p.costo_total) AS utilidad, COALESCE(p.enviado_produccion, false) AS enviado_produccion,
                                       COALESCE(p.prioridad, false) AS prioridad, COALESCE(p.deliveri, false) AS delivery, p.cantidad AS cantidad_articulos,
                                       COALESCE(p.anulado, FALSE) AS anulado, p.total_mano_obra, p.total_adicional, p.id_sucursal
                                       FROM pedidos p
                                       LEFT JOIN articulos a ON a.id_articulo = p.id_articulo
                                       LEFT JOIN clientes c ON c.id_cliente = p.id_cliente
                                       ORDER BY p.numero DESC")

        grid_listado.DataSource = dt_pedidos
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Function get_materias_primas(id_pedido As Integer, id_sucursal As Integer) As DataTable
        Dim dt As New DataTable
        dt = pedido.consultar("SELECT ma.nombre AS material, it.cantidad,  (it.cantidad * it.cantidad_articulo) as cantidad_articulo, sa.cantidad AS existencia
                                FROM costeo_item it
                                INNER JOIN costeo_de_pedido cp on cp.id_costeo_de_pedido  = it.id_costeo_de_pedido 
                                INNER JOIN materiales ma ON ma.id_material = it.id_material
                                INNER JOIN stock_articulos sa ON sa.id_material = it.id_material
                                WHERE sa.id_sucursal= " & id_sucursal & " AND cp.id_pedido = " & id_pedido.ToString)

        Return dt
    End Function

    Function get_empleados_asignados(id_pedido As Integer) As DataTable
        Dim dt As New DataTable
        dt = pedido.consultar("SELECT CONCAT(em.nombres, ' ', em.apellidos) AS empleado, cantidad_asignada
                                FROM asignacion_pedido_empleado ape
                                LEFT JOIN empleados em ON em.id_empleado = ape.id_empleado
                                WHERE ape.id_pedido = " & id_pedido.ToString)

        Return dt
    End Function

    Function costeado(id_pedido As Integer) As Boolean
        Dim dt As New DataTable
        Dim costeadoVal As Boolean = False

        dt = pedido.consultar("SELECT estado FROM pedidos WHERE id_pedido=" & id_pedido.ToString)
        If dt.Rows.Count Then
            If dt.Rows(0).Item(0) = "COSTEADO" Then
                costeadoVal = True
            End If
        End If
        Return costeadoVal
    End Function


    Sub crear_reporte()
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim report As New rpt_nota_pedido
        Dim dt As New DataTable

        Dim subreport As New rpt_asignacion_empleado
        Dim dt2 As New DataTable

        dt = get_materias_primas(GridView1.GetRowCellValue(rowhandle, "id_pedido"), GridView1.GetRowCellValue(rowhandle, "id_sucursal"))
        If dt.Rows.Count > 0 Then
            report.Parameters("titulo_material").Value = "Descripcion"
            report.Parameters("titulo_cantidad").Value = "Cantidad"
            report.Parameters("titulo_existencia").Value = "Existencia"
            report.DataSource = dt
        End If

        report.Parameters("nro_pedido").Value = GridView1.GetRowCellValue(rowhandle, "numero")
        report.Parameters("fecha_pedido").Value = GridView1.GetRowCellValue(rowhandle, "fecha_pedido")
        report.Parameters("fecha_entrega").Value = GridView1.GetRowCellValue(rowhandle, "fecha_entrega")
        report.Parameters("prioridad").Value = GridView1.GetRowCellValue(rowhandle, "prioridad")
        report.Parameters("delivery").Value = GridView1.GetRowCellValue(rowhandle, "delivery")
        report.Parameters("vendedor").Value = GridView1.GetRowCellValue(rowhandle, "vendedor")
        report.Parameters("cliente").Value = GridView1.GetRowCellValue(rowhandle, "cliente")
        report.Parameters("telefono").Value = GridView1.GetRowCellValue(rowhandle, "telefono")
        report.Parameters("direccion").Value = GridView1.GetRowCellValue(rowhandle, "direccion")
        report.Parameters("articulo").Value = GridView1.GetRowCellValue(rowhandle, "articulo")
        report.Parameters("cantidad").Value = GridView1.GetRowCellValue(rowhandle, "cantidad_articulos")
        report.Parameters("precio_unitario").Value = GridView1.GetRowCellValue(rowhandle, "total_precio_venta") / GridView1.GetRowCellValue(rowhandle, "cantidad_articulos")
        report.Parameters("precio_total").Value = GridView1.GetRowCellValue(rowhandle, "total_precio_venta")
        report.Parameters("comentario").Value = GridView1.GetRowCellValue(rowhandle, "comentario")

        report.Parameters("nro_pedido").Visible = False
        report.Parameters("fecha_pedido").Visible = False
        report.Parameters("prioridad").Visible = False
        report.Parameters("delivery").Visible = False
        report.Parameters("fecha_entrega").Visible = False
        report.Parameters("vendedor").Visible = False
        report.Parameters("cliente").Visible = False
        report.Parameters("telefono").Visible = False
        report.Parameters("direccion").Visible = False
        report.Parameters("articulo").Visible = False
        report.Parameters("cantidad").Visible = False
        report.Parameters("precio_unitario").Visible = False
        report.Parameters("precio_total").Visible = False
        report.Parameters("titulo_material").Visible = False
        report.Parameters("titulo_cantidad").Visible = False
        report.Parameters("titulo_existencia").Visible = False
        report.Parameters("comentario").Visible = False


        dt2 = get_empleados_asignados(GridView1.GetRowCellValue(rowhandle, "id_pedido"))

        report.XrSubreport1.ReportSource = subreport
        subreport.DataSource = dt2
        subreport.DataMember = "dt"



        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

        listar()
    End Sub

    Function empleado_asignado(id_ped) As Boolean
        Dim rowhandle As Integer = 0
        Dim id_pedido As Integer = GridView1.GetRowCellValue(rowhandle, "id_pedido")

        Dim dt As DataTable
        dt = pedido.consultar("SELECT * FROM asignacion_pedido_empleado WHERE id_pedido =" & id_ped.ToString)

        Return dt.Rows.Count > 0
    End Function


    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir_pedido.Click
        GridView1.ShowPrintPreview()
    End Sub

    Private Sub GridView1_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub btn_ver_pedido_Click(sender As Object, e As EventArgs) Handles btn_ver_pedido.Click
        Try
            Dim fila As Integer = GridView1.FocusedRowHandle
            If fila < 0 Then
                util.mensajes("Debe seleccionar un pedido", "<Listado de Pedido>", "WAR")
                Return
            End If
            Dim id As Integer = CInt(GridView1.GetRowCellValue(fila, "id_pedido"))
            frm_pedidos.MdiParent = frm_main
            frm_pedidos.Show()
            frm_pedidos.Focus()
            frm_pedidos.ver_pedido = True
            frm_pedidos.obtener_pedido(id)
        Catch ex As Exception
            util.mensajes(ex.Message, "<Listado de Pedido>", "WAR")
        End Try
    End Sub

    Private Sub btn_costear_Click(sender As Object, e As EventArgs) Handles btn_costear.Click
        Try
            Dim fila As Integer = GridView1.FocusedRowHandle
            If fila < 0 Then
                util.mensajes("Debe seleccionar un pedido", "<Listado de Pedido>", "WAR")
                Return
            End If

            Dim id As Integer = CInt(GridView1.GetRowCellValue(fila, "id_pedido"))
            frm_costeo_pedido.MdiParent = frm_main
            frm_costeo_pedido.Show()
            frm_costeo_pedido.Focus()
            frm_costeo_pedido.obtener_pedido(id)
        Catch ex As Exception
            util.mensajes(ex.Message, "<Listado de Pedido>", "WAR")
        End Try
    End Sub

    Private Sub btn_asignar_empleados_Click(sender As Object, e As EventArgs) Handles btn_asignar_empleados.Click
        frm_asignar_empleados_pedidos.set_id_pedido(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_pedido"))
        frm_asignar_empleados_pedidos.set_mano_obra(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_mano_obra"))
        frm_asignar_empleados_pedidos.set_pago_extra(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_adicional"))
        frm_asignar_empleados_pedidos.get_pedido()
        frm_asignar_empleados_pedidos.Show()
    End Sub

    Private Sub frm_listado_pedidos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        listar()
        chk_todos.Checked = True
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_enviar_productos_Click(sender As Object, e As EventArgs) Handles btn_enviar_productos.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle

        If rowhandle < 0 Then
            util.mensajes("Debe seleccionar pedido", "Pedidos", "WAR")
            Return
        End If

        If pedido.enviado_produccion(GridView1.GetRowCellValue(rowhandle, "id_pedido")) Then
            If util.msj_confirmacion("El pedido ya esta en produccion" + vbCrLf + "Desea imprimir la orden?", "Pedidos") Then
                crear_reporte()
            End If
            Return
        End If

        If empleado_asignado(GridView1.GetRowCellValue(rowhandle, "id_pedido")) = False Then
            util.mensajes("Debe asignar empleados al pedido", "Pedidos", "WAR")
            Return
        End If

        If costeado(GridView1.GetRowCellValue(rowhandle, "id_pedido")) = False Then
            util.mensajes("El pedido debe estar costeado", "Pedidos", "WAR")
            Return
        End If

        If util.msj_confirmacion("Desea enviar a produccion", "Pedidos") = False Then
            util.mensajes("Pedido no enviado a produccion", "Peidos", "WAR")
            Return
        End If

        If pedido.enviar_produccion(GridView1.GetRowCellValue(rowhandle, "id_pedido")) Then
            crear_reporte()
        Else
            util.mensajes("Pedido no enviado a produccion", "Peidos", "WAR")
        End If

    End Sub

    Private Sub chk_no_anulados_CheckedChanged(sender As Object, e As EventArgs) Handles chk_no_anulados.CheckedChanged
        If chk_no_anulados.Checked Then
            chk_no_anulados.Checked = True
            chk_anulados.Checked = False
            chk_todos.Checked = False

            Dim dv As DataView
            dv = dt_pedidos.DefaultView
            dv.RowFilter = "anulado=FALSE"
            grid_listado.DataSource = dv
        End If
    End Sub

    Private Sub chk_anulados_CheckedChanged(sender As Object, e As EventArgs) Handles chk_anulados.CheckedChanged
        If chk_anulados.Checked Then
            chk_anulados.Checked = True
            chk_no_anulados.Checked = False
            chk_todos.Checked = False

            Dim dv As DataView
            dv = dt_pedidos.DefaultView
            dv.RowFilter = "anulado=TRUE"
            grid_listado.DataSource = dv
        End If
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            chk_todos.Checked = True
            chk_anulados.Checked = False
            chk_no_anulados.Checked = False

            listar()
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If dt_pedidos.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dt_pedidos.DefaultView
            dv.RowFilter = "numero LIKE '%" & txt_buscar.Text & "%' OR cliente LIKE '%" & txt_buscar.Text & "%' OR articulo LIKE '%" & txt_buscar.Text & "%'"
            grid_listado.DataSource = dv
        End If
    End Sub
End Class