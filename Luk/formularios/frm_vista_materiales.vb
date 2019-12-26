Public Class frm_vista_materiales

    Private material As New func_materiales()
    Private dt_materiales As New DataTable()
    Public FRM_ACTIVO As String = ""
    Public OCULTAR_COLUMNA As String = ""

    Private Sub frm_vista_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        dt_materiales.Clear()
        dt_materiales = material.listar("SELECT m.id_material, m.nombre, m.codigo, m.costo_unitario, SUM(s.cantidad) AS stock 
                                        FROM materiales m
                                        INNER JOIN stock_articulos s ON s.id_material = m.id_material
                                        GROUP BY m.id_material, m.nombre, m.codigo, m.costo_unitario")
        grid_materiales.DataSource = dt_materiales

        If OCULTAR_COLUMNA = "ST" Then
            GridView1.Columns("stock").Visible = True
        End If
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.add_materiales(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_costeo_pedido" Then
            frm_costeo_pedido.add_materiales(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_item(id, "")
            Close()
        End If

        If FRM_ACTIVO = "frm_movimientos_stock_items" Then
            frm_movimientos_stock_items.obtener_materia_prima(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_saldo_stock" Then
            frm_saldo_stock.obtener_materia_prima(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_existencia_en_stock" Then
            frm_existencia_en_stock.obtener_materia_prima(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_stock_articulos" Then
            frm_stock_articulos.obtener_materia_prima(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_compras_por_item" Then
            frm_rpt_compras_por_item.obtener_materia_prima(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_costear_pedido" Then
            frm_costear_pedido.add_materiales(id)
            Close()
        End If

    End Sub

    Private Sub grid_materiales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_materiales.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_materiales_DoubleClick(sender As Object, e As EventArgs) Handles grid_materiales.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString()))
    End Sub
End Class