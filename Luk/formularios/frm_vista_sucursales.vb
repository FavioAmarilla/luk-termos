Public Class frm_vista_sucursales

    Private sucursal As New func_sucursales
    Private dt_sucursal As New DataTable
    Public FRM_ACTIVO As String = ""
    Public CONDICION_SQL As String = ""

    Private Sub frm_vista_sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_sucursal.Clear()
        dt_sucursal = sucursal.listar("SELECT id_sucursal, nombre, ciudad FROM sucursales " + CONDICION_SQL)
        grid_sucursales.DataSource = dt_sucursal
    End Sub

    Private Sub enviar_id(id As String)
        If FRM_ACTIVO = "frm_recepcion_produccion" Then
            frm_recepcion_produccion.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_movimientos_stock" Then
            frm_movimientos_stock.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_timbrados" Then
            frm_timbrados.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_articulos" Then
            frm_stock_articulos.obtener_sucursal(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_ventas_por_clientes" Then
            frm_rpt_vta_por_clientes.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_familia" Then
            frm_rpt_vta_detalle_ventas_por_familia.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_fecha" Then
            frm_rpt_vta_por_fecha.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_vendedores" Then
            frm_rpt_vta_por_vendedores.obtener_sucursal(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_compras_por_fecha" Then
            frm_rpt_compras_por_fecha.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_familia" Then
            frm_rpt_compras_por_familia.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_proveedores" Then
            frm_rpt_compras_por_proveedores.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_tipo_compra" Then
            frm_rpt_compras_por_tipo_compra.obtener_sucursal(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_pedidos_recibidos" Then
            frm_rpt_pedidos_recibidos.obtener_sucursal(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_produccion_por_fecha" Then
            frm_rpt_produccion_por_fecha.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_prodcuccion_ranking_emp" Then
            frm_rpt_prodcuccion_ranking_emp.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_reporte_mensual" Then
            frm_reporte_mensual.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_vs_costo" Then
            frm_rpt_ventas_vs_costo.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_condicion" Then
            frm_rpt_vta_por_condicion.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_compras" Then
            frm_listado_compras.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_existencia_en_stock" Then
            frm_existencia_en_stock.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_resumen_ventas_por_proveedor" Then
            frm_rpt_vta_resumen_ventas_por_proveedor.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_detalle_ventas_por_proveedor" Then
            frm_rpt_vta_detalle_ventas_por_proveedor.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_ventas_por_proveedor_familia" Then
            frm_rpt_vta_resumen_ventas_por_proveedor_familia.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "FrmExistenciaStockItems" Then
            FrmExistenciaStockItems.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_cobros_caja" Then
            frm_rpt_cobros_caja.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ranking_global_proveedor" Then
            frm_rpt_ranking_global_proveedor.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_valorizado" Then
            frm_stock_valorizado.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_item" Then
            frm_rpt_compras_por_item.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_pedidos_en_produccion" Then
            frm_rpt_pedidos_en_produccion.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_detalle_ventas_por_comprob" Then
            frm_rpt_detalle_ventas_por_comprob.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_ventas_formas_pago" Then
            frm_rpt_vta_ventas_formas_pago.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_detalle_por_fecha" Then
            frm_rpt_compras_detalle_por_fecha.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente" Then
            frm_rpt_cobros_caja_por_cliente.obtener_sucursal(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia" Then
            frm_rpt_pedidos_recibidos_familia.obtener_sucursal(id)
            Close()
        End If
    End Sub

    Private Sub grid_sucursales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_sucursales.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_sucursal").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_sucursales_DoubleClick(sender As Object, e As EventArgs) Handles grid_sucursales.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_sucursal").ToString())
    End Sub
End Class