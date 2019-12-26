Imports utilidades
Public Class frm_vista_articulos

    Private articulos As New func_articulos()
    Private dt_vista_articulos As New DataTable()
    Public FRM_ACTIVO As String = ""
    Public OCULTAR_COLUMNA As String = ""
    Public CONDICION_SQL As String = ""

    Private Sub frm_vista_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount

        Dim ch As New utilidades
        If ch.CheckForm(frm_pedidos) = True Then
            btn_agregar.Visible = True
        End If

    End Sub

    Private Sub listar()
        dt_vista_articulos.Clear()
        dt_vista_articulos = articulos.listar("SELECT a.id_articulo, a.nombre, a.codigo_barras, a.precio_venta, SUM(s.cantidad) AS stock
                                               FROM articulos a
                                               INNER JOIN stock_articulos s ON s.id_articulo = a.id_articulo " + CONDICION_SQL + "
						                       GROUP BY a.id_articulo, a.nombre, a.codigo_barras, a.precio_venta ")
        grid_articulos.DataSource = dt_vista_articulos

        If OCULTAR_COLUMNA = "ST" Then
            GridView1.Columns("stock").Visible = True
        End If
    End Sub

    Private Sub enviar_id(id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.buscar_articulo(id)
            frm_articulos.EXISTE_ARTICULO = True
            Close()
        End If

        If FRM_ACTIVO = "frm_pedidos" Then
            frm_pedidos.obtener_articulo(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_item(id, "")
            Close()
        End If

        If FRM_ACTIVO = "frm_ventas" Then
            frm_ventas.txt_codigo_barras.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "codigo_barras").ToString
            Close()
        End If

        If FRM_ACTIVO = "frm_modificar_precio_venta" Then
            frm_modificar_precio_venta.obtener_articulos(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "codigo_barras").ToString)
            Close()
        End If

        If FRM_ACTIVO = "frm_movimientos_stock_items" Then
            frm_movimientos_stock_items.obtener_articulo(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_saldo_stock" Then
            frm_saldo_stock.obtener_articulo(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_existencia_en_stock" Then
            frm_existencia_en_stock.obtener_articulo(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_stock_articulos" Then
            frm_stock_articulos.obtener_articulo(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_compras_por_item" Then
            frm_rpt_compras_por_item.obtener_articulo(id.ToString())
            Close()
        End If

        If FRM_ACTIVO = "frm_impresion_cod_barras" Then
            frm_impresion_cod_barras.obtener_articulo(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_impresion_plantilla_cod_barras" Then
            frm_impresion_plantilla_cod_barras.obtener_articulo(id)
            Close()
        End If

        If FRM_ACTIVO = "frm_rpt_ventas_por_items" Then
            frm_rpt_ventas_por_items.get_articulo(id)
            Close()
        End If
    End Sub

    Private Sub txt_Descripcion_TextChanged(sender As Object, e As EventArgs)
        listar()
    End Sub

    Private Sub grid_articulos_DoubleClick(sender As Object, e As EventArgs) Handles grid_articulos.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_articulo").ToString()))
    End Sub

    Private Sub grid_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_articulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_articulo").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub txt_Descripcion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            grid_articulos.Focus()
        End If
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid_articulos.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            grid_articulos.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub txt_codigo_barras_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo_barras.TextChanged
        If dt_vista_articulos.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dt_vista_articulos.DefaultView
            dv.RowFilter = "nombre LIKE '%" & txt_codigo_barras.Text & "%' OR codigo_barras LIKE '%" & txt_codigo_barras.Text & "%'"
            grid_articulos.DataSource = dv
        End If

        'CONDICION_SQL = " WHERE nombre LIKE '%" & txt_codigo_barras.Text & "%'"
        'listar()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        frm_articulos.Show()

    End Sub
End Class