Public Class frm_vista_vendedores

    Private liquidacion As New func_liquidacion_vendedores
    Private vendedor As New func_vendedores()
    Private dt_vendedores As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_vendedores.Clear()
        dt_vendedores = vendedor.listar("SELECT id_vendedor, CONCAT(nombres,' ',apellidos) AS vendedor FROM vendedores WHERE activo=TRUE")
        grid_vendedores.DataSource = dt_vendedores
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_pedidos" Then
            frm_pedidos.obtener_vendedor(id)


            Close()
        End If
        If FRM_ACTIVO = "frm_items_liquidacion_vendedores" Then
            frm_items_liquidacion_vendedores.MdiParent = frm_main
            frm_items_liquidacion_vendedores.txt_nro_liquidacion.Text = liquidacion.id_liquidacion_mano_obra().ToString()
            frm_items_liquidacion_vendedores.CONDICION_SQL = "WHERE vta.id_vendedor = " + id.ToString + " AND COALESCE(vta.pagado, false) = False AND COALESCE(vta.comision_vendedor, 0) > 0"
            frm_items_liquidacion_vendedores.obtener_liquidacion(id, "insert")
            frm_items_liquidacion_vendedores.EXISTE_LIQUIDACION = False
            frm_items_liquidacion_vendedores.btn_registrar.Text = "Registrar"
            frm_items_liquidacion_vendedores.Show()
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_vendedores" Then
            frm_rpt_vta_por_vendedores.obtener_vendedor(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_comision_vendedor" Then
            frm_comision_vendedor.obtener_vendedor(id.ToString())
            Close()
        End If
    End Sub

    Private Sub txt_Descripcion_TextChanged(sender As Object, e As EventArgs) 
        listar()
    End Sub

    Private Sub grid_vendedores_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_vendedores.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_vendedor").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub txt_Descripcion_KeyDown(sender As Object, e As KeyEventArgs) 
        If e.KeyCode = Keys.Enter Then
            grid_vendedores.Focus()
        End If
    End Sub

    Private Sub grid_vendedores_DoubleClick(sender As Object, e As EventArgs) Handles grid_vendedores.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_vendedor").ToString()))
    End Sub
End Class