Public Class frm_stock_articulos

    Private movim As New func_movimientos_stock
    Private stock As New func_stock_articulos
    Private util As New utilidades
    Private dt_items As New DataTable
    Private dt_transacciones As New DataTable
    Private TITULO_MSJ As String = "<Ajuste de Stock>"

    'Variables para las operaciones sobre la tabla stock_articulos
    Private CAMPO As String = ""
    Private ID_ITEM As Integer = 0
    Private CANTIDAD As Double = 0

    'Variables para las operaciones sobre la tabla items_stock
    Private ID_MATERIAL As Integer = 0
    Private ID_ARTICULO As Integer = 0
    Private ID_PROVEE As Integer = 0
    Private ID_MOVIM_STOCK As Integer = 0
    Private ID_TRANSACCION As Integer = 0
    Private ACCION As String = ""
    Private CANTIDAD_UNIT As Double = 0
    Private CANTIDAD_TOTAL As Double = 0
    Private COSTO_UNITARIO As Integer = 0
    Private PRECIO_UNITARIO As Integer = 0
    Private COSTO_TOTAL As Integer = 0

    Private Sub frm_stock_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_sucursal.Text = frm_main.SUCURSAL
        desabilitar()
        limpiar()
        cbo_tipo_stock.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_fecha.Enabled = False
        cbo_tipo_stock.Enabled = False
        txt_id_sucursal.Enabled = False
        txt_sucursal.Enabled = False
        txt_id_transaccion.Enabled = False
        txt_transaccion.Enabled = false
    End Sub

    Private Sub habilitar()
        txt_fecha.Enabled = True
        cbo_tipo_stock.Enabled = True
        txt_id_sucursal.Enabled = True
        txt_sucursal.Enabled = True
        txt_id_transaccion.Enabled = True
        txt_transaccion.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_fecha.Text = ""
        cbo_tipo_stock.SelectedIndex = -1
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_id_transaccion.Text = ""
        txt_transaccion.Text = ""
        grid_items.DataSource = Nothing
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)
        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_transaccion(id As Integer)
        dt_transacciones.Clear()
        dt_transacciones = stock.consultar("SELECT id_transaccion, nombre, accion FROM transacciones_stock WHERE id_transaccion = " + id.ToString() + "")
        If dt_transacciones.Rows.Count() <> 0 Then
            txt_id_transaccion.Text = CStr(dt_transacciones.Rows(0).Item(0))
            txt_transaccion.Text = CStr(dt_transacciones.Rows(0).Item(1))
            ACCION = CStr(dt_transacciones.Rows(0).Item(2))
        Else
            util.mensajes("Transaccion no definida", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub crear_cursor()
        dt_items = New DataTable
        dt_items.Columns.Add("codigo_barras")
        dt_items.Columns.Add("item")
        dt_items.Columns.Add("costo_unitario")
        dt_items.Columns.Add("precio_unitario")
        dt_items.Columns.Add("cantidad", GetType(Double))
        dt_items.Columns.Add("id_item")
        dt_items.Columns.Add("id_proveedor")
        grid_items.DataSource = dt_items
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)
        For Each dr As DataRow In dt_items.Rows()
            If IsDBNull(dr("id_item")) Then
                listaux.Add(dr)
            End If
        Next
        For Each dr As DataRow In listaux
            dt_items.Rows.Remove(dr)
        Next
    End Sub

    Public Sub obtener_articulo(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_articulo, codigo_barras, nombre, COALESCE(costo_unitario, 0), COALESCE(precio_venta, 0), COALESCE(id_proveedor, 0) FROM articulos 
                                WHERE id_articulo=" + id.Replace(" ", "") + " Or codigo_barras = '" + id.Replace(" ", "") + "'")

        If dt.Rows.Count > 0 Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle

            GridView1.SetRowCellValue(rowhandle, "id_item", dt.Rows(0).Item(0))
            GridView1.SetRowCellValue(rowhandle, "codigo_barras", dt.Rows(0).Item(1))
            GridView1.SetRowCellValue(rowhandle, "item", dt.Rows(0).Item(2))
            GridView1.SetRowCellValue(rowhandle, "costo_unitario", dt.Rows(0).Item(3))
            GridView1.SetRowCellValue(rowhandle, "precio_unitario", dt.Rows(0).Item(4))
            GridView1.SetRowCellValue(rowhandle, "cantidad", 0)
            GridView1.SetRowCellValue(rowhandle, "id_proveedor", dt.Rows(0).Item(5))

            eliminar_filas_vacias()
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
        End If
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        GridView1.ShowEditor()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub obtener_materia_prima(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_material, COALESCE(codigo, '-'), nombre, COALESCE(costo_unitario, 0), COALESCE(id_proveedor, 0) FROM materiales 
                                WHERE id_material=" + id.Replace(" ", "") + " OR codigo = '" + id.Replace(" ", "") + "'")
        If dt.Rows.Count > 0 Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.SetRowCellValue(rowhandle, "id_item", dt.Rows(0).Item(0))
            GridView1.SetRowCellValue(rowhandle, "codigo_barras", dt.Rows(0).Item(1))
            GridView1.SetRowCellValue(rowhandle, "item", dt.Rows(0).Item(2))
            GridView1.SetRowCellValue(rowhandle, "costo_unitario", dt.Rows(0).Item(3))
            GridView1.SetRowCellValue(rowhandle, "precio_unitario", 0)
            GridView1.SetRowCellValue(rowhandle, "cantidad", 0)
            GridView1.SetRowCellValue(rowhandle, "id_proveedor", dt.Rows(0).Item(4))
            eliminar_filas_vacias()
        Else
            util.mensajes("Materia Prima no definida", TITULO_MSJ, "WAR")
        End If
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        GridView1.ShowEditor()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Function validar_cantidad() As Boolean

        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "cantidad")) Then
                util.mensajes("Cantidad debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                Return False
            End If
            If CDbl(GridView1.GetRowCellValue(i, "cantidad")) <= 0 Then
                util.mensajes("Cantidad debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub actualizar_stock()
        If cbo_tipo_stock.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de stock", TITULO_MSJ, "WAR")
            Return
        End If
        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", TITULO_MSJ, "WAR")
            Return
        End If
        If txt_id_transaccion.Text = "" Then
            util.mensajes("Debe seleccionar transaccion de stock", TITULO_MSJ, "WAR")
            Return
        End If
        If GridView1.RowCount <= 0 Then
            util.mensajes("Debe agregar items a la transaccion", TITULO_MSJ, "WAR")
            Return
        End If
        If validar_cantidad() = False Then
            Return
        End If
        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        For i As Integer = 0 To GridView1.RowCount - 1
            ID_ITEM = CInt(GridView1.GetRowCellValue(i, "id_item"))
            CANTIDAD = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
            If ACCION = "EGRESO" Then
                If stock.validar_stock(ID_ITEM, CAMPO, CInt(txt_id_sucursal.Text)) Then
                    If stock.disminuir_stock(ID_ITEM, CANTIDAD, CAMPO, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock no Actualizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If CAMPO = "articulo" Then
                        If stock.insertar(ID_ITEM, CANTIDAD, 0, COSTO_UNITARIO, PRECIO_UNITARIO, 0, CInt(txt_id_sucursal.Text)) = False Then
                            util.mensajes("Stock de articulo no registrado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                    If CAMPO = "material" Then
                        If stock.insertar(0, CANTIDAD, 0, COSTO_UNITARIO, PRECIO_UNITARIO, ID_ITEM, CInt(txt_id_sucursal.Text)) = False Then
                            util.mensajes("Stock de materia prima no registrado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                End If
            End If
            If ACCION = "INGRESO" Then
                If stock.validar_stock(ID_ITEM, CAMPO, CInt(txt_id_sucursal.Text)) Then
                    If stock.aumentar_stock(ID_ITEM, CANTIDAD, CAMPO, CInt(txt_id_sucursal.Text)) = False Then
                        util.mensajes("Stock no Actualizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If CAMPO = "articulo" Then
                        If stock.insertar(ID_ITEM, CANTIDAD, 0, COSTO_UNITARIO, PRECIO_UNITARIO, 0, CInt(txt_id_sucursal.Text)) = False Then
                            util.mensajes("Stock de articulo no registrado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                    If CAMPO = "material" Then
                        If stock.insertar(0, CANTIDAD, 0, COSTO_UNITARIO, PRECIO_UNITARIO, ID_ITEM, CInt(txt_id_sucursal.Text)) = False Then
                            util.mensajes("Stock de materia prima no registrado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                End If
            End If
        Next
        If movimiento_stock() = False Then
            Return
        End If
        util.mensajes(txt_transaccion.Text + " realizado con exito", TITULO_MSJ, "INF")
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Function movimiento_stock() As Boolean
        ID_MOVIM_STOCK = movim.id_movimiento_stock()
        ID_TRANSACCION = CInt(txt_id_transaccion.Text)
        If movim.insertar_movimiento_stock(ID_MOVIM_STOCK, CInt(txt_id_sucursal.Text), frm_main.ID_USUARIO, 0, "", 0, 0) = False Then
            util.mensajes("Movimiento de stock no registrado", TITULO_MSJ, "WAR")
            Return False
        End If
        For i As Integer = 0 To GridView1.RowCount - 1
            If CAMPO = "articulo" Then
                ID_ARTICULO = CInt(GridView1.GetRowCellValue(i, "id_item"))
            End If
            If CAMPO = "material" Then
                ID_MATERIAL = CInt(GridView1.GetRowCellValue(i, "id_item"))
            End If
            CANTIDAD_UNIT = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
            COSTO_UNITARIO = CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
            COSTO_TOTAL = CInt(GridView1.GetRowCellValue(i, "cantidad")) * CInt(GridView1.GetRowCellValue(i, "costo_unitario"))
            PRECIO_UNITARIO = CInt(GridView1.GetRowCellValue(i, "precio_unitario"))
            ID_PROVEE = CInt(GridView1.GetRowCellValue(i, "id_proveedor"))

            If movim.insertar_movim_item_stock(ID_MOVIM_STOCK, ID_TRANSACCION, ACCION, ID_MATERIAL, CANTIDAD_UNIT, COSTO_UNITARIO, COSTO_TOTAL, ID_ARTICULO, PRECIO_UNITARIO, movim.id_movim_items_stock(), ID_PROVEE) = False Then
                util.mensajes("Items de stock no registrados", TITULO_MSJ, "WAR")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_tipo_stock.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_stock.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sucursal.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_stock.SelectedIndexChanged
        If cbo_tipo_stock.SelectedIndex = 0 Then
            CAMPO = "articulo"
            GridView1.Columns("codigo_barras").Visible = True
            grid_items.DataSource = Nothing
        End If
        If cbo_tipo_stock.SelectedIndex = 1 Then
            CAMPO = "material"
            GridView1.Columns("codigo_barras").Visible = False
            grid_items.DataSource = Nothing
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            Else
                txt_transaccion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_stock_articulos"
            frm.CONDICION_SQL = " WHERE id_empresa=" + frm_main.ID_EMPRESA.ToString
            frm.Show()
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_stock_articulos"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_transaccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_transaccion.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_transacciones
            frm.FRM_ACTIVO = "frm_stock_articulos"
            frm.CONDICION_SQL = " WHERE transaccion_de_pedido IS NULL OR transaccion_de_pedido = false "
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_id_transaccion.Text.Replace(" ", "") = "" Then
            Else
                If GridView1.RowCount <= 0 Then
                    crear_cursor()
                    GridView1.AddNewRow()
                End If
                grid_items.Focus()
                GridView1.ShowEditor()
            End If
        End If
    End Sub

    Private Sub btn_transacciones_Click(sender As Object, e As EventArgs) Handles btn_transacciones.Click
        Dim frm As New frm_vista_transacciones
        frm.FRM_ACTIVO = "frm_stock_articulos"
        frm.Show()
    End Sub

    Private Sub btn_nuevo_Click_1(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        txt_fecha.Text = util.fecha
        txt_fecha.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        eliminar_filas_vacias()
        actualizar_stock()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
            lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
        End If
    End Sub

    Private Sub rpt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles rpt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "codigo_barras")) Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                Return
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_item")) Then
                obtener_articulo(CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "codigo_barras")))
                Return
            End If
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If cbo_tipo_stock.SelectedIndex < 0 Then
                util.mensajes("Seleccione Tipo de Stock", TITULO_MSJ, "WAR")
                Return
            End If
            If cbo_tipo_stock.SelectedIndex = 0 Then
                Dim frm As New frm_vista_articulos()
                frm.FRM_ACTIVO = "frm_stock_articulos"
                frm.Show()
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                Dim frm As New frm_vista_materiales()
                frm.FRM_ACTIVO = "frm_stock_articulos"
                frm.Show()
            End If
        End If
    End Sub

    Private Sub rpt_item_KeyDown(sender As Object, e As KeyEventArgs) Handles rpt_item.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_stock.SelectedIndex = 0 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If cbo_tipo_stock.SelectedIndex < 0 Then
                util.mensajes("Seleccione Tipo de Stock", TITULO_MSJ, "WAR")
                Return
            End If
            If cbo_tipo_stock.SelectedIndex = 0 Then
                Dim frm As New frm_vista_articulos()
                frm.FRM_ACTIVO = "frm_stock_articulos"
                frm.Show()
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                Dim frm As New frm_vista_materiales()
                frm.FRM_ACTIVO = "frm_stock_articulos"
                frm.Show()
            End If
        End If
    End Sub

    Private Sub rpt_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rpt_costo_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_stock.SelectedIndex = 0 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            End If
        End If
    End Sub

    Private Sub rpt_precio_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rpt_precio_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_stock.SelectedIndex = 0 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            End If
        End If
    End Sub

    Private Sub rpt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rpt_cantidad.KeyPress
        If e.KeyChar = "," Then

        ElseIf e.KeyChar = "." Then
            'ENVIA PULSACION DE COMA (,)
            SendKeys.Send(Chr(44))
            e.Handled = True
        Else
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub rpt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rpt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_stock.SelectedIndex = 0 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                GridView1.FocusedColumn = GridView1.VisibleColumns(5)
            End If
            If cbo_tipo_stock.SelectedIndex = 1 Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Cantidad debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                If cbo_tipo_stock.SelectedIndex = 0 Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                End If
                If cbo_tipo_stock.SelectedIndex = 1 Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                End If
                Return
            End If
            If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) <= 0 Then
                util.mensajes("Cantidad debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                If cbo_tipo_stock.SelectedIndex = 0 Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                End If
                If cbo_tipo_stock.SelectedIndex = 1 Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                End If
                Return
            End If
            GridView1.AddNewRow()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

        End If
    End Sub

    Private Sub btn_quitar_empleado_Click(sender As Object, e As EventArgs) Handles btn_quitar_empleado.Click
        If GridView1.FocusedRowHandle < 0 Then
            util.mensajes("Debe seleccionar item para eliminar", TITULO_MSJ, "WAR")
        End If
        GridView1.DeleteRow(GridView1.FocusedRowHandle)
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_agregar_material_Click(sender As Object, e As EventArgs)
        If cbo_tipo_stock.SelectedIndex < 0 Then
            util.mensajes("Seleccione Tipo de Stock", TITULO_MSJ, "INF")
            Return
        End If
        If cbo_tipo_stock.SelectedIndex = 0 Then
            Dim frm As New frm_vista_articulos()
            frm.FRM_ACTIVO = "frm_stock_articulos"
            frm.Show()
        End If
        If cbo_tipo_stock.SelectedIndex = 1 Then
            Dim frm As New frm_vista_materiales()
            frm.FRM_ACTIVO = "frm_stock_articulos"
            frm.Show()
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If GridView1.RowCount <= 0 Then
            crear_cursor()
            GridView1.AddNewRow()
        End If
        grid_items.Focus()
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        GridView1.ShowEditor()
    End Sub

    Private Sub txt_transaccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_transaccion.Validating
        If GridView1.RowCount <= 0 Then
            crear_cursor()
            GridView1.AddNewRow()
        End If
        grid_items.Focus()
        GridView1.ShowEditor()
    End Sub
End Class