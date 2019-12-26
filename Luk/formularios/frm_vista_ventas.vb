Public Class frm_vista_ventas

    Private venta As New func_ventas
    Private dt_venta As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub
    Private Sub listar()
        dt_venta = New DataTable()
        dt_venta = venta.consultar("SELECT vta.id_venta, vta.fecha_cre, vta.numero, 
                                    CONCAT(ven.nombres,' ',ven.apellidos) AS vendedor, vta.comision_vendedor
                                    FROM ventas vta 
                                    INNER JOIN vendedores ven ON ven.id_vendedor = vta.id_vendedor
                                    WHERE COALESCE(vta.pagado, false) = false AND COALESCE(vta.comision_vendedor, 0) > 0")

        If dt_venta.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_venta
        Else

        End If
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_items_liquidacion_vendedores" Then
            frm_items_liquidacion_vendedores.add_item_liquidacion(id)
            Close()
        End If

    End Sub

    Private Sub grid_ventas_Click(sender As Object, e As EventArgs) Handles grid_ventas.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            Return
        End If
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_venta").ToString()))
    End Sub

    Private Sub grid_ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_ventas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                Return
            End If
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_venta").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class