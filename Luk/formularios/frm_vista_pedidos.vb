Public Class frm_vista_pedidos

    Private pedido As New func_pedidos()
    Private dt_pedido As New DataTable()
    Public FRM_ACTIVO As String = ""
    Public CONDICION_SQL As String = ""

    Private Sub frm_vista_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_pedido = New DataTable()
        dt_pedido = pedido.consultar("SELECT p.numero, p.fecha_pedido, p.id_pedido, p.costo_total,
                                        p.id_vendedor, CONCAT(v.nombres,' ',v.apellidos) AS vendedor, 
                                        p.id_cliente, CONCAT(c.nombres,' ',c.apellidos) AS cliente,
                                        estado, a.codigo_barras, a.nombre AS articulo FROM pedidos p
                                        INNER JOIN vendedores v ON v.id_vendedor = p.id_vendedor
                                        INNER JOIN articulos a ON a.id_articulo = p.id_articulo
                                        INNER JOIN clientes c ON c.id_cliente = p.id_cliente " +
                                        CONDICION_SQL +
                                        " ORDER BY p.numero DESC")

        If dt_pedido.Rows.Count > 0 Then
            grid_pedidos.DataSource = dt_pedido
        End If
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_pedidos" Then
            frm_pedidos.obtener_pedido(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_costeo_pedido" Then
            frm_costeo_pedido.obtener_pedido(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_movimientos_stock" Then
            frm_recepcion_produccion.obtener_pedido(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_items_liquidacion_vendedores" Then
            frm_items_liquidacion_vendedores.add_item_liquidacion(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_ventas" Then
            frm_ventas.obtener_pedido(id)
            Close()
        End If
    End Sub


    Private Sub grid_pedidos_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_pedidos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                Return
            End If
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_pedido").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_pedidos_DoubleClick(sender As Object, e As EventArgs) Handles grid_pedidos.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            Return
        End If
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_pedido").ToString()))
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If dt_pedido.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dt_pedido.DefaultView
            dv.RowFilter = "numero LIKE '%" & txt_buscar.Text & "%' OR cliente LIKE '%" & txt_buscar.Text & "%' OR codigo_barras LIKE '%" & txt_buscar.Text & "%'  OR articulo LIKE '%" & txt_buscar.Text & "%'"
            grid_pedidos.DataSource = dv
        End If
    End Sub
End Class