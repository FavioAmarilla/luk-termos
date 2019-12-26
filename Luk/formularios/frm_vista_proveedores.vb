Public Class frm_vista_proveedores

    Private proveedor As New func_proveedores()
    Private dt_proveedores As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_proveedores = New DataTable()
        dt_proveedores = proveedor.listar("SELECT id_proveedor, nombre, telefono, ciudad FROM proveedores WHERE activo = true")
        grid_proveedores.DataSource = dt_proveedores
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_proveedores" Then
            frm_rpt_compras_por_proveedores.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_articulos" Then
            frm_listado_articulos.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_compras" Then
            frm_listado_compras.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_traspaso_articulo_prov" Then
            frm_traspaso_articulo_prov.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_resumen_ventas_por_proveedor" Then
            frm_rpt_vta_resumen_ventas_por_proveedor.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_detalle_ventas_por_proveedor" Then
            frm_rpt_vta_detalle_ventas_por_proveedor.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_ventas_por_proveedor_familia" Then
            frm_rpt_vta_resumen_ventas_por_proveedor_familia.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_materiales" Then
            frm_materiales.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "FrmExistenciaStockItems" Then
            FrmExistenciaStockItems.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_articulos_gru_proveedor" Then
            frm_listado_articulos_gru_proveedor.obtener_proveedor(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_valorizado" Then
            frm_stock_valorizado.obtener_proveedor(id)
            Close()
        End If

    End Sub

    Private Sub grid_proveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_proveedores.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_proveedores_DoubleClick(sender As Object, e As EventArgs) Handles grid_proveedores.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString()))
    End Sub
End Class