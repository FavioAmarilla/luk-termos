Public Class frm_vista_empleados

    Private liquidacion As New func_liquidacion_mano_obra
    Private empleado As New func_empleados()
    Private dt_empleados As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_empleados.Clear()
        dt_empleados = empleado.listar("SELECT id_empleado, CONCAT(nombres,' ',apellidos) AS empleado, telefono FROM empleados")
        grid_empleados.DataSource = dt_empleados
    End Sub

    Private Sub enviar_id(ByVal id As String)
        If FRM_ACTIVO = "frm_items_liquidacion_mano_obra" Then
            frm_items_liquidacion_mano_obra.MdiParent = frm_main
            frm_items_liquidacion_mano_obra.txt_nro_liquidacion.Text = liquidacion.id_liquidacion_mano_obra().ToString()
            frm_items_liquidacion_mano_obra.CONDICION_SQL = "WHERE a.id_empleado = " + id + " AND a.pagado = False AND p.recepcionado=True AND a.mano_obra > 0 ORDER BY p.id_pedido DESC"
            frm_items_liquidacion_mano_obra.obtener_liquidacion(CInt(id))
            frm_items_liquidacion_mano_obra.Show()
            Close()
        End If

        If FRM_ACTIVO = "frm_costeo_pedido" Then
            frm_costeo_pedido.obtener_empleado(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_asignar_empleados_pedidos" Then
            frm_asignar_empleados_pedidos.get_empleado(id)
            Close()
        End If
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_empleados.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_empleado").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_empleados_DoubleClick(sender As Object, e As EventArgs) Handles grid_empleados.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_empleado").ToString())
    End Sub
End Class