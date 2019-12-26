
Imports Npgsql

Public Class frm_vista_familias
    Dim util As New utilidades
    Private familias As New func_familias
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_familias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        dt = familias.listar("SELECT identificador, descripcion, codigo FROM familias WHERE ultimo_nivel=true ORDER BY codigo")
        grid_familias.DataSource = dt

        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub enviar_id(ByVal id As String)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.obtener_familia(CInt(id))
            Close()
        End If
        If FRM_ACTIVO = "frm_traspaso_familias" Then
            frm_traspaso_familias.obtener_linea_padre(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_familia" Then
            frm_rpt_vta_detalle_ventas_por_familia.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_ranking_ventas" Then
            frm_ranking_ventas.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_familia" Then
            frm_rpt_compras_por_familia.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_articulos" Then
            frm_listado_articulos.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_ranking_compras" Then
            frm_ranking_compras.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_vs_costo" Then
            frm_rpt_ventas_vs_costo.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_compras" Then
            frm_listado_compras.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_listado_articulos_gru_proveedor" Then
            frm_listado_articulos_gru_proveedor.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_valorizado" Then
            frm_stock_valorizado.obtener_familia_articulo(id)
            Close()
        End If
    End Sub

    Private Sub grid_familias_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_familias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "identificador").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_familias_DoubleClick(sender As Object, e As EventArgs) Handles grid_familias.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "identificador").ToString())
    End Sub
End Class