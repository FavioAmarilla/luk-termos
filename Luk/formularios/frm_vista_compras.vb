Public Class frm_vista_compras

    Private compra As New func_compras
    Private dt_compras As New DataTable
    Public FRM_ACTIVO As String = ""
    Public CONDICION_SQL As String = "
"
    Private Sub frm_vista_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_compras.Clear()
        dt_compras = compra.consultar("SELECT c.id_compra, c.numero,c.fecha_compra, tc.nombre AS tipo_compra, 
				                        p.nombre AS proveedor, tc.nombre AS tipo_compra, c.total_compra
                                        FROM compras c 
                                        INNER JOIN tipos_compra tc ON tc.id_tipo_compra = c.id_tipo_compra
                                        INNER JOIN proveedores p ON p.id_proveedor = c.id_proveedor
                                        INNER JOIN sucursales s ON s.id_sucursal = c.id_sucursal
                                        INNER JOIN usuarios u ON u.id_usuario = c.id_usuario " +
                                        CONDICION_SQL +
                                        " ORDER BY c.id_compra DESC")
        grid_compras.DataSource = dt_compras
    End Sub

    Private Sub enviar_id(ByVal id As String)
        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_compra(CInt(id))
            Close()
        End If
    End Sub

    Private Sub grid_compras_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_compras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                Return
            End If
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_compra").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_compras_DoubleClick(sender As Object, e As EventArgs) Handles grid_compras.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            Return
        End If
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_compra").ToString())
    End Sub
End Class