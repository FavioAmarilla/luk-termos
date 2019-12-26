Public Class frm_vista_asignaciones

    Private asignacion As New func_asignacion_pedido_empleado
    Private dt_asignacion As New DataTable
    Public FRM_ACTIVO As String = ""
    Public ID_EMPLEADO As String = ""

    Private Sub frm_vista_asignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_asignacion.Clear()
        dt_asignacion = asignacion.consultar("SELECT a.id_asignacion_pedido_empleado AS id_asignacion, p.numero AS pedido, CONCAT(e.nombres,' ',e.apellidos) AS empleado, 
                                            a.cantidad_asignada AS cantidad, a.mano_obra, a.pago_extra 
                                            FROM asignacion_pedido_empleado a
                                            INNER JOIN pedidos p ON p.id_pedido = a.id_pedido
                                            INNER JOIN empleados e ON e.id_empleado = a.id_empleado
                                            WHERE a.id_empleado = " + ID_EMPLEADO + " AND a.pagado = false")
        grid_asignaciones.DataSource = dt_asignacion
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_items_liquidacion_mano_obra" Then
            frm_items_liquidacion_mano_obra.add_item_liquidacion(id)
            Me.Close()
        End If
    End Sub

    Private Sub grid_asignaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_asignaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle <= 0 Then
                Return
            End If
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_asignacion").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_asignaciones_DoubleClick(sender As Object, e As EventArgs) Handles grid_asignaciones.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle <= 0 Then
            Return
        End If
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_asignacion").ToString()))
    End Sub
End Class