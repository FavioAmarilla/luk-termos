Public Class frm_compras

    Private stock As New func_stock_articulos()
    Private articulo As New func_articulos
    Private material As New func_materiales
    Private movim_stock As New func_movimientos_stock
    Private compra As New func_compras
    Private facturas As New func_facturas_compra
    Private dt_items_compra As New DataTable
    Private dt_items_compra_tmp As New DataTable
    Private dt_tipo_comprobantes As New DataTable
    Private util As New utilidades
    Private Const TITULO_MSJ As String = "<Registro de Compras>"
    Private RELACION As String = ""

    'Variables para las operaciones sobre la tabla compras
    Private ID_TIPO_COMPRA As Integer = 0
    Private ID_PROVEEDOR As Integer = 0
    Private ID_SUCURSAL As Integer = 0
    Private TOTAL_COMPRA As Integer = 0
    Private ID_USUARIO As Integer = 0
    Private NUMERO As String = ""
    Private ID_TIPO_COMPROBANTE As Integer = 0
    Private EXISTE_COMPRA As Boolean = False

    'Variables para las operaciones sobre la tabla facturas_compra
    Private ID_FACTURA As Integer = 0
    Private NUMERO_FACTURA As String = ""
    Private MONTO_TOTAL As Integer = 0
    Private MONTO_GRAVADO As Integer = 0
    Private MONTO_GRAVADO10 As Integer = 0
    Private MONTO_GRAVADO5 As Integer = 0
    Private MONTO_IVA As Integer = 0
    Private MONTO_IVA10 As Integer = 0
    Private MONTO_IVA5 As Integer = 0
    Private MONTO_EXENTO As Integer = 0
    Private EXISTE_FACTURA As Boolean = False

    'Variables para las operaciones sobre la tabla items_compras
    Private ID_ITEM_COMPRA As Integer = 0
    Private ID_COMPRA As Integer = 0
    Private ID_MATERIAL As Integer = 0
    Private CANTIDAD As Double = 0
    Private COSTO_UNITARIO As Integer = 0
    Private COSTO_TOTAL As Integer = 0
    Private ID_ARTICULO As Integer = 0
    Private REQUIERE_ITEM As Boolean = False
    Private CONTROLAR_STOCK_ITEM As Boolean = False
    Private PRECIO_VENTA_IT As Integer = 0

    'Variables para las operaciones de movimiento de stock
    Private ID_MOVIMIENTO As Integer = 0
    Private ID_MV_ITEMS_STOCK As Integer = 0
    Private ID_TRANSACCION As Integer = 0

    Private Sub frm_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        limpiar()
        crear_cursor()
        lbl_total_compra.Text = ""
        obtener_tipo_facturas()
        btn_nuevo.Focus()
        obtener_transaccion_stock()
    End Sub

    Private Sub desabilitar()
        txt_id_compra.Enabled = False
        txt_numero.Enabled = False
        txt_id_tipo_compra.Enabled = False
        txt_tipo_compra.Enabled = False
        btn_tipo_compra.Enabled = False
        txt_id_proveedor.Enabled = False
        txt_proveedor.Enabled = False
        btn_proveedor.Enabled = False
        txt_fecha.Enabled = False
        txt_id_sucursal.Enabled = False
        txt_sucursal.Enabled = False
        btn_buscar_sucursal.Enabled = False
        btn_quitar_item.Enabled = False
        btn_confirmar.Enabled = False
        TabNavigationPage3.PageVisible = False
        txt_total_gasto.Visible = False
        lbl_total_gasto.Visible = False
        TabNavigationPage3.PageVisible = False
        TabNavigationPage1.PageVisible = False
        PanelControl1.Visible = False
        PanelControl3.Visible = False
        PanelControl4.Visible = False
    End Sub

    Private Sub habilitar()
        btn_tipo_compra.Enabled = True
        btn_proveedor.Enabled = True
        btn_confirmar.Enabled = True
        btn_cancelar.Enabled = True
        btn_tipo_compra.Enabled = True
        txt_id_compra.Enabled = True
        txt_numero.Enabled = True
        txt_id_tipo_compra.Enabled = True
        txt_tipo_compra.Enabled = True
        txt_id_proveedor.Enabled = True
        txt_proveedor.Enabled = True
        btn_proveedor.Enabled = True
        txt_fecha.Enabled = True
        txt_id_sucursal.Enabled = True
        txt_sucursal.Enabled = True
        btn_buscar_sucursal.Enabled = True
        btn_quitar_item.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_id_compra.Text = ""
        txt_numero.Text = ""
        txt_id_tipo_compra.Text = ""
        txt_tipo_compra.Text = ""
        txt_id_proveedor.Text = ""
        txt_proveedor.Text = ""
        txt_fecha.Text = Now.ToString("dd/MM/yyyy")
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_id_usuario.Text = ""
        txt_usuario.Text = ""
        txt_movim_stock.Text = ""
        lbl_total_compra.Text = ""
        dt_items_compra.Clear()
        grid_item.DataSource = dt_items_compra
        cbo_tipo_comprobante.Properties.Items.Clear()
        txt_total_gasto.Text = ""
        txt_proveedor_fact.Text = ""
        txt_cod_proveedor.Text = ""
        txt_numero_factura.Text = ""
        txt_factura_total.Text = ""
        cbo_tipo_comprobante.SelectedIndex = -1
        cbo_factura.SelectedIndex = -1
        txt_exentas.Text = ""
        txt_fact_gravadas10.Text = ""
        txt_fact_gravadas5.Text = ""
        txt_fac_iva10.Text = ""
        txt_fac_iva5.Text = ""
        btn_confirmar.Text = "Confirmar"
        EXISTE_COMPRA = False
        EXISTE_FACTURA = False
    End Sub

    Public Sub obtener_tipo_compra(ByVal id As Integer)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_tipo_compra, nombre, relacion, COALESCE(requiere_item, false) FROM tipos_compra WHERE id_tipo_compra=" + id.ToString() + "")
        txt_id_tipo_compra.Text = CStr(dt.Rows(0).Item(0))
        txt_tipo_compra.Text = CStr(dt.Rows(0).Item(1))
        RELACION = CStr(dt.Rows(0).Item(2))
        REQUIERE_ITEM = CBool(dt.Rows(0).Item(3))
        txt_tipo_compra.Focus()

        If REQUIERE_ITEM Then
            grid_item.Enabled = True
            TabNavigationPage1.PageVisible = True
            PanelControl1.Visible = True
            txt_total_gasto.Visible = False
            lbl_total_gasto.Visible = False
        Else
            grid_item.Enabled = False
            TabNavigationPage1.PageVisible = False
            PanelControl1.Visible = False
        End If

        If RELACION = "ARTICULOS" Then
            If GridView1.RowCount <= 0 Then
                GridView1.AddNewRow()
            End If
            GridView1.Columns(8).Visible = True
            PanelControl3.Visible = True
            PanelControl4.Visible = True
        End If
        If RELACION = "MATERIA PRIMA" Then
            If GridView1.RowCount <= 0 Then
                GridView1.AddNewRow()
            End If
            GridView1.Columns(8).Visible = False
        End If

    End Sub

    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor=" + id.ToString() + "")
        txt_id_proveedor.Text = CStr(dt.Rows(0).Item(0))
        txt_proveedor.Text = CStr(dt.Rows(0).Item(1))
        txt_proveedor.Focus()
        txt_proveedor_fact.Text = txt_proveedor.Text
        txt_cod_proveedor.Text = txt_id_proveedor.Text
    End Sub

    Public Sub obtener_tipo_facturas()
        dt_tipo_comprobantes = compra.consultar("SELECT id_tipo_comprobante, nombre FROM tipos_comprobante")

        If dt_tipo_comprobantes.Rows.Count > 0 Then
            cbo_tipo_comprobante.Properties.Items.Clear()
            For Each row As DataRow In dt_tipo_comprobantes.Rows
                cbo_tipo_comprobante.Properties.Items.Add(row("nombre"))
            Next
        End If
    End Sub

    Public Sub obtener_transaccion_stock()
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_transaccion FROM transacciones_stock WHERE relacion='CO'")

        If dt.Rows.Count > 0 Then
            ID_TRANSACCION = CInt(dt.Rows(0).Item(0))
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal =" + id)

        If dt.Rows.Count > 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub crear_cursor()
        dt_items_compra = New DataTable
        dt_items_compra.Columns.Add("codigo_barras")
        dt_items_compra.Columns.Add("id_item")
        dt_items_compra.Columns.Add("item")
        dt_items_compra.Columns.Add("cantidad", GetType(Double))
        dt_items_compra.Columns.Add("total_unitario")
        dt_items_compra.Columns.Add("total")
        dt_items_compra.Columns.Add("id_item_compra")
        dt_items_compra.Columns.Add("id_item_mv_stock")
        dt_items_compra.Columns.Add("nuevo")
        dt_items_compra.Columns.Add("controlar_stock")
        dt_items_compra.Columns.Add("id_proveedor")
        dt_items_compra.Columns.Add("precio_venta")
        grid_item.DataSource = dt_items_compra
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_items_compra.Rows()
            If IsDBNull(dr("id_item")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_items_compra.Rows.Remove(dr)
        Next
    End Sub

    Public Sub obtener_item(ByVal id As Integer, cod_barras As String)
        Dim dt As New DataTable
        If RELACION = "ARTICULOS" Then
            dt = compra.consultar("SELECT a.id_articulo AS id_item, a.nombre AS item, COALESCE(t.valor,0) AS iva, 
                                   COALESCE(a.costo_unitario,0) AS total_unitario, a.codigo_barras, true AS controlar_stock,
                                   a.id_proveedor, COALESCE(a.precio_venta, 0) FROM articulos a
                                   INNER JOIN tipos_impuesto t ON t.id_tipo_impuesto = a.id_tipo_impuesto
                                   WHERE a.id_articulo = " + id.ToString + " or codigo_barras ='" + cod_barras + "'")
        End If

        If RELACION = "MATERIA PRIMA" Then
            dt = compra.consultar("SELECT m.id_material AS id_item, m.nombre AS item, t.valor AS iva, 
                                   m.costo_unitario AS total_unitario, '', COALESCE(m.controlar_stock, false),
                                   m.id_proveedor, 0 AS precio_venta FROM materiales m
                                   INNER JOIN tipos_impuesto t ON t.id_tipo_impuesto = m.id_tipo_impuesto
                                   WHERE m.id_material = " + id.ToString + "")
        End If

        If dt.Rows().Count() <> 0 Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.SetRowCellValue(rowhandle, "codigo_barras", dt.Rows(0).Item(4))
            GridView1.SetRowCellValue(rowhandle, "id_item", dt.Rows(0).Item(0))
            GridView1.SetRowCellValue(rowhandle, "item", dt.Rows(0).Item(1))
            GridView1.SetRowCellValue(rowhandle, "cantidad", 0)
            GridView1.SetRowCellValue(rowhandle, "total_unitario", obtener_utltimo_costo(CStr(dt.Rows(0).Item(0))))
            GridView1.SetRowCellValue(rowhandle, "total", 0)
            GridView1.SetRowCellValue(rowhandle, "id_item_compra", 0)
            GridView1.SetRowCellValue(rowhandle, "id_item_mv_stock", 0)
            GridView1.SetRowCellValue(rowhandle, "nuevo", True)
            GridView1.SetRowCellValue(rowhandle, "controlar_stock", dt.Rows(0).Item(5))
            GridView1.SetRowCellValue(rowhandle, "id_proveedor", dt.Rows(0).Item(6))
            GridView1.SetRowCellValue(rowhandle, "precio_venta", dt.Rows(0).Item(7))

            eliminar_filas_vacias()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            GridView1.ShowEditor()
        End If
    End Sub

    Private Sub obtener_total()
        TOTAL_COMPRA = 0
        If REQUIERE_ITEM Then
            For i As Integer = 0 To GridView1.RowCount() - 1
                If IsDBNull(GridView1.GetRowCellValue(i, "total")) Then
                Else
                    TOTAL_COMPRA += CInt(GridView1.GetRowCellValue(i, "total"))
                End If
            Next
        End If
        If REQUIERE_ITEM = False And cbo_factura.SelectedIndex = 0 Then
            If txt_total_gasto.Text.Replace(" ", "") = "" Then
                TOTAL_COMPRA = 0
            Else
                TOTAL_COMPRA = CInt(txt_total_gasto.Text)
            End If
        End If
        If REQUIERE_ITEM = False And cbo_factura.SelectedIndex = 1 Then
            If txt_total_gasto.Text.Replace(" ", "") = "" Then
                TOTAL_COMPRA = 0
            Else
                TOTAL_COMPRA = CInt(txt_factura_total.Text)
            End If
        End If
        lbl_total_compra.Text = Format(TOTAL_COMPRA, "##,##") + "  Gs."
    End Sub

    Private Sub actualizar_totales()
        eliminar_filas_vacias()
        Try
            Dim ca As Double = 0
            Dim un As Integer = 0

            For i As Integer = 0 To GridView1.RowCount - 1
                ca = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
                un = CInt(GridView1.GetRowCellValue(i, "total_unitario"))
                GridView1.SetRowCellValue(i, "total", un * ca)
            Next
            obtener_total()
        Catch ex As Exception
            util.mensajes("Error al actualizar totales: " & ex.Message, TITULO_MSJ, "ERR")
        End Try
    End Sub

    Private Sub obtener_numero_compra()
        Dim longitud_id = CStr(ID_COMPRA).Length
        Dim ceros As String = ""
        Dim limite As Integer = 7

        For i As Integer = 1 To limite - longitud_id
            ceros += "0"
        Next

        txt_id_compra.Text = ID_COMPRA.ToString()
        txt_numero.Text = ceros + ID_COMPRA.ToString()
    End Sub

    Public Sub obtener_compra(ByVal id As Integer)
        Dim dt As New DataTable
        dt = compra.consultar("SELECT c.id_compra, c.numero, c.id_tipo_compra, tc.nombre AS tipo_compra,  
                                c.id_proveedor, p.nombre AS proveedor, c.fecha_compra, c.id_sucursal, s.nombre AS sucursal,
                                u.id_usuario, u.nombre_completo AS usuario, tc.relacion, c.total_compra, c.id_movim_stock,
                                tc.requiere_item, COALESCE(c.factura, false)
                                FROM compras c 
                                INNER JOIN tipos_compra tc ON tc.id_tipo_compra = c.id_tipo_compra
                                INNER JOIN proveedores p ON p.id_proveedor = c.id_proveedor
                                INNER JOIN sucursales s ON s.id_sucursal = c.id_sucursal
                                INNER JOIN usuarios u ON u.id_usuario = c.id_usuario
                                WHERE c.id_compra = " + id.ToString() + " ")

        If dt.Rows.Count > 0 Then
            ID_COMPRA = CInt(dt.Rows(0).Item(0))
            txt_id_compra.Text = CStr(dt.Rows(0).Item(0))
            txt_numero.Text = CStr(dt.Rows(0).Item(1))
            txt_id_tipo_compra.Text = CStr(dt.Rows(0).Item(2))
            txt_tipo_compra.Text = CStr(dt.Rows(0).Item(3))
            txt_id_proveedor.Text = CStr(dt.Rows(0).Item(4))
            txt_proveedor.Text = CStr(dt.Rows(0).Item(5))
            txt_cod_proveedor.Text = CStr(dt.Rows(0).Item(4))
            txt_proveedor_fact.Text = CStr(dt.Rows(0).Item(5))
            txt_fecha.Text = CStr(dt.Rows(0).Item(6))
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(7))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(8))
            txt_id_usuario.Text = CStr(dt.Rows(0).Item(9))
            txt_usuario.Text = CStr(dt.Rows(0).Item(10))
            RELACION = CStr(dt.Rows(0).Item(11))
            lbl_total_compra.Text = Format(CInt(dt.Rows(0).Item(12)), "##,##") + "  Gs."
            txt_movim_stock.Text = CStr(dt.Rows(0).Item(13))
            REQUIERE_ITEM = CBool(dt.Rows(0).Item(14))

            If CBool(dt.Rows(0).Item(15)) = False Then
                cbo_factura.SelectedIndex = 0
            Else
                cbo_factura.SelectedIndex = 1
                obtener_factura(ID_COMPRA.ToString)
            End If
            obtener_tipo_compra(CInt(dt.Rows(0).Item(2)))
            obtener_items_compra(CInt(dt.Rows(0).Item(0)))
            btn_confirmar.Text = "Actualizar"
            txt_numero.Focus()
        End If
    End Sub

    Public Function obtener_utltimo_costo(id_item As String) As Integer
        Dim dt As New DataTable
        If RELACION = "ARTICULOS" Then
            dt = compra.consultar("SELECT COALESCE(costo_unitario, 0) FROM items_compras WHERE id_articulo = " + id_item + " 
                                AND fecha_cre = (SELECT MAX(fecha_cre) FROM items_compras WHERE id_articulo = " + id_item + " )")
        End If

        If RELACION = "MATERIA PRIMA" Then
            dt = compra.consultar("SELECT COALESCE(costo_unitario, 0) FROM items_compras WHERE id_material = " + id_item + " 
                                    AND fecha_cre = (SELECT MAX(fecha_cre) FROM items_compras WHERE id_material = " + id_item + ")")
        End If

        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0).Item(0))
        Else
            Return 0
        End If
    End Function

    Private Sub obtener_items_compra(ByVal id As Integer)
        dt_items_compra.Clear()
        crear_cursor()
        If RELACION = "ARTICULOS" Then
            dt_items_compra = compra.consultar("SELECT a.codigo_barras, i.id_articulo AS id_item, a.nombre AS item, i.cantidad, i.costo_unitario AS total_unitario,
                                                (i.costo_unitario * i.cantidad) AS total, i.id_item_mv_stock, i.id_item_compra, false AS nuevo, true AS controlar_stock,
                                                a.id_proveedor, i.precio_venta FROM items_compras i
                                                INNER JOIN articulos a ON a.id_articulo = i.id_articulo
                                                WHERE i.id_compra = " + id.ToString() + "")
            GridView1.Columns().Item("codigo_barras").Visible = True
        End If

        If RELACION = "MATERIA PRIMA" Then
            dt_items_compra = compra.consultar("SELECT '' AS codigo_barras, i.id_material AS id_item, m.nombre AS item, i.cantidad, i.costo_unitario AS total_unitario,
                                                (i.costo_unitario * i.cantidad) AS total, i.id_item_mv_stock, i.id_item_compra, false AS nuevo, 
                                                COALESCE(m.controlar_stock, false) AS controlar_stock, m.id_proveedor, i.precio_venta
                                                FROM items_compras i
                                                INNER JOIN materiales m ON m.id_material = i.id_material
                                                WHERE id_compra = " + id.ToString() + "")
            GridView1.Columns().Item("codigo_barras").Visible = False
        End If

        grid_item.DataSource = dt_items_compra

        'Copiamos los datos actuales a un DataTable que luego se usara para disminuir el stock 
        'de los valores anteriores y aumentar los nuevos valores
        dt_items_compra_tmp = dt_items_compra.Copy()
        grid_items_tmp.DataSource = dt_items_compra_tmp

        EXISTE_COMPRA = True
        btn_tipo_compra.Enabled = False
        btn_confirmar.Enabled = True
    End Sub

    Private Sub obtener_factura(id_compra As String)
        Dim dt As New DataTable
        dt = facturas.consultar("SELECT f.numero_factura, f.monto_total, f.monto_exento, f.gravadas5, f.gravadas10, f.iva5, f.iva10, tc.nombre
                                FROM facturas_compra f
                                INNER JOIN tipos_comprobante tc ON tc.id_tipo_comprobante = f.id_tipo_comprobante 
                                WHERE f.id_compra = " + id_compra)

        txt_numero_factura.Text = CStr(dt.Rows(0).Item(0))
        txt_factura_total.Text = CStr(dt.Rows(0).Item(1))
        txt_exentas.Text = CStr(dt.Rows(0).Item(2))
        txt_fact_gravadas5.Text = CStr(dt.Rows(0).Item(3))
        txt_fact_gravadas10.Text = CStr(dt.Rows(0).Item(4))
        txt_fac_iva5.Text = CStr(dt.Rows(0).Item(5))
        txt_fac_iva10.Text = CStr(dt.Rows(0).Item(6))
        cbo_tipo_comprobante.SelectedItem = CStr(dt.Rows(0).Item(7))

    End Sub

    Private Sub calcular_factura()
        Dim total As Integer = 0
        Dim exentas As Integer = 0
        Dim gravadas10 As Integer = 0
        Dim gravadas5 As Integer = 0

        If txt_exentas.Text.Replace(" ", "") = "" Then
        Else
            exentas = CInt(txt_exentas.Text)
        End If

        If txt_fact_gravadas10.Text.Replace(" ", "") = "" Then
        Else
            gravadas10 = CInt(txt_fact_gravadas5.Text)
        End If

        If txt_fact_gravadas5.Text.Replace(" ", "") = "" Then
        Else
            gravadas5 = CInt(txt_fact_gravadas5.Text)
        End If
    End Sub

    Private Sub calcular_gravadas()
        Dim exentas As Integer
        Dim gravadas10 As Integer
        Dim gravadas5 As Integer
        Dim iva10 As Integer
        Dim iva5 As Integer
        Dim total As Integer
        Dim gravadas10_sin_iva As Integer
        Dim gravadas5_sin_iva As Integer

        total = CInt(txt_factura_total.Text)
        exentas = CInt(txt_exentas.Text)
        gravadas5 = CInt(txt_fact_gravadas5.Text)
        gravadas10 = total - exentas - gravadas5
        txt_fact_gravadas10.Text = CStr(gravadas10)
        iva10 = CInt(gravadas10 / 11)
        txt_fac_iva10.Text = CStr(iva10)
        iva5 = CInt(gravadas5 / 21)
        txt_fac_iva5.Text = CStr(iva5)
        gravadas10_sin_iva = gravadas10 - iva10
        gravadas5_sin_iva = gravadas5 - iva5
    End Sub

    Private Sub disminuir_stock()
        Dim id As Integer
        Dim cantidad As Double

        For i As Integer = 0 To GridView2.RowCount() - 1
            id = CInt(GridView2.GetRowCellValue(i, "id_item"))
            cantidad = CDbl(GridView2.GetRowCellValue(i, "cantidad"))

            If RELACION = "ARTICULOS" Then
                If stock.validar_stock(id, "articulo", ID_SUCURSAL) Then
                    If stock.disminuir_stock(id, cantidad, "articulo", ID_SUCURSAL) = False Then
                        util.mensajes("Disminucion de stock no realizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If stock.insertar(id, cantidad, 0, COSTO_UNITARIO, 0, 0, ID_SUCURSAL) = False Then
                        util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If
            End If

            If RELACION = "MATERIA PRIMA" Then
                If stock.validar_stock(id, "material", ID_SUCURSAL) Then
                    If stock.disminuir_stock(id, cantidad, "material", ID_SUCURSAL) = False Then
                        util.mensajes("Disminucion de stock no realizado", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If stock.insertar(0, cantidad, 0, COSTO_UNITARIO, 0, id, ID_SUCURSAL) = False Then
                        util.mensajes("Stock de Materia prima no registrada", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub eliminar_item()
        If util.msj_confirmacion("Deseas eliminar el Item", TITULO_MSJ) = False Then
            util.mensajes("Item no eliminado", TITULO_MSJ, "WAR")
            Return
        End If

        If EXISTE_COMPRA = False Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            Return
        End If

        Dim fila As Integer = GridView1.FocusedRowHandle
        If IsDBNull(GridView1.GetRowCellValue(fila, "id_item")) Then
            GridView1.DeleteRow(fila)
            Return
        End If
        Dim id As Integer = CInt(GridView1.GetRowCellValue(fila, "id_item"))
        Dim id_mv As Integer = CInt(GridView1.GetRowCellValue(fila, "id_item_mv_stock"))
        Dim id_it_com As Integer = CInt(GridView1.GetRowCellValue(fila, "id_item_compra"))
        Dim cant As Double = CDbl(GridView1.GetRowCellValue(fila, "cantidad"))

        If RELACION = "ARTICULOS" Then
            If stock.validar_stock(id, "articulo", ID_SUCURSAL) Then
                If stock.disminuir_stock(id, cant, "articulo", ID_SUCURSAL) = False Then
                    util.mensajes("Disminucion de stock no realizado", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                If stock.insertar(id, CANTIDAD, 0, COSTO_UNITARIO, 0, 0, ID_SUCURSAL) = False Then
                    util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                    Return
                End If
            End If


        End If

        If RELACION = "MATERIA PRIMA" Then
            If stock.validar_stock(id, "material", ID_SUCURSAL) Then
                If stock.disminuir_stock(id, cant, "material", ID_SUCURSAL) = False Then
                    util.mensajes("Disminucion de stock no realizado", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                If stock.insertar(0, CANTIDAD, 0, COSTO_UNITARIO, 0, id, ID_SUCURSAL) = False Then
                    util.mensajes("Stock de Materia prima no registrada", TITULO_MSJ, "WAR")
                    Return
                End If
            End If
        End If

        If movim_stock.eliminar_movim_item_stock(id_mv) = False Then
            util.mensajes("Item de Stock no eliminado", TITULO_MSJ, "WAR")
            Return
        End If

        If compra.eliminar_item_compra(id_it_com) = False Then
            util.mensajes("Item de Compra no eliminado", TITULO_MSJ, "WAR")
            Return
        End If

        GridView1.DeleteRow(GridView1.FocusedRowHandle)

        util.mensajes("Item Eliminado", TITULO_MSJ, "INF")
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


    Private Sub insertar_actualizar_compra()
        If txt_id_tipo_compra.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione tipo de compra", TITULO_MSJ, "WAR")
            txt_tipo_compra.Focus()
            Return
        End If
        If txt_id_proveedor.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione proveedor", TITULO_MSJ, "WAR")
            txt_proveedor.Focus()
            Return
        End If
        If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione sucursal", TITULO_MSJ, "WAR")
            Return
        End If
        If TOTAL_COMPRA <= 0 Then
            util.mensajes("Total de compra debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
            Return
        End If
        If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione sucursal", TITULO_MSJ, "WAR")
            Return
        End If

        If cbo_factura.SelectedItem.ToString = "CON FACTURA" Then
            If txt_numero_factura.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe ingresar Numero de Factura", TITULO_MSJ, "WAR")
                txt_numero_factura.Focus()
                Return
            End If

            If txt_factura_total.Text.Replace(" ", "") = "" Then
                MONTO_TOTAL = 0
            Else
                MONTO_TOTAL = CInt(txt_factura_total.Text)
            End If

            If MONTO_TOTAL <> TOTAL_COMPRA And REQUIERE_ITEM Then
                util.mensajes("Total de factura debe ser igual " & vbCrLf & "al total de compra", TITULO_MSJ, "WAR")
                Return
            End If

            If ID_TIPO_COMPROBANTE <= 0 Then
                util.mensajes("Debe seleccionar Tipo de Comprobante", TITULO_MSJ, "WAR")
                cbo_tipo_comprobante.Focus()
                Return
            End If
        End If

        If validar_cantidad() = False Then
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        ID_TIPO_COMPRA = CInt(txt_id_tipo_compra.Text)
        ID_PROVEEDOR = CInt(txt_id_proveedor.Text)
        ID_SUCURSAL = CInt(txt_id_sucursal.Text)
        ID_USUARIO = CInt(txt_id_usuario.Text)

        'Se registra o se actualiza la cabezera de la compra
        If EXISTE_COMPRA = False Then
            ID_COMPRA = compra.id_compra()
            obtener_numero_compra()
            NUMERO = txt_numero.Text
            ID_MOVIMIENTO = movim_stock.id_movimiento_stock()
            If compra.insertar_compra(ID_COMPRA, ID_TIPO_COMPRA, ID_PROVEEDOR, ID_SUCURSAL, TOTAL_COMPRA, ID_USUARIO, NUMERO, ID_MOVIMIENTO) = False Then
                util.mensajes("Compra no registrada", TITULO_MSJ, "WAR")
                Return
            End If
        Else
            If compra.actualizar_compras(TOTAL_COMPRA, ID_COMPRA) = False Then
                util.mensajes("Compra no registrada", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        'Se registra o actualiza la cabezera del movimiento de stock
        If EXISTE_COMPRA = False Then
            If movim_stock.insertar_movimiento_stock(ID_MOVIMIENTO, ID_SUCURSAL, ID_USUARIO, 0, "", 0, ID_COMPRA) = False Then
                util.mensajes("Movimiento de Stock no registrado", TITULO_MSJ, "WAR")
                Return
            End If
        Else
            If movim_stock.actualizar_movimiento_stock(CInt(txt_movim_stock.Text)) = False Then
                util.mensajes("Movimiento de Stock no Actualizado", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        'Se registra o actualiza los items de la compra y del movimiento de stock
        For i As Integer = 0 To GridView1.RowCount() - 1
            CANTIDAD = CDbl(GridView1.GetRowCellValue(i, "cantidad"))
            COSTO_UNITARIO = CInt(GridView1.GetRowCellValue(i, "total_unitario"))
            COSTO_TOTAL = CInt(GridView1.GetRowCellValue(i, "total"))
            ID_ITEM_COMPRA = CInt(GridView1.GetRowCellValue(i, "id_item_compra"))
            CONTROLAR_STOCK_ITEM = CBool(GridView1.GetRowCellValue(i, "controlar_stock"))
            PRECIO_VENTA_IT = CInt(GridView1.GetRowCellValue(i, "precio_venta"))

            'Se actualiza los costos de los articulos/materiales y el id_proveedor
            If RELACION = "ARTICULOS" Then
                ID_ARTICULO = CInt(GridView1.GetRowCellValue(i, "id_item"))
                If articulo.actualizar_costo(COSTO_UNITARIO, ID_ARTICULO) = False Then
                    util.mensajes("Costo de articulo no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
                If compra.actualizar_id_proveedor_articulo(ID_PROVEEDOR, ID_ARTICULO, "AR") = False Then
                    util.mensajes("Id Proveedor de articulo no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
            End If

            If RELACION = "MATERIA PRIMA" Then
                ID_MATERIAL = CInt(GridView1.GetRowCellValue(i, "id_item"))
                If material.actualizar_costo(COSTO_UNITARIO, ID_MATERIAL) = False Then
                    util.mensajes("Costo de material no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
                If compra.actualizar_id_proveedor_articulo(ID_PROVEEDOR, ID_MATERIAL, "MA") = False Then
                    util.mensajes("Id Proveedor de articulo no actualizado", TITULO_MSJ, "WAR")
                    Return
                End If
            End If

            'Se registra o actualiza el item de compra
            If EXISTE_COMPRA = False Then
                ID_MV_ITEMS_STOCK = movim_stock.id_movim_items_stock()
                If compra.insertar_items_compra(ID_COMPRA, ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_ARTICULO, ID_MV_ITEMS_STOCK, ID_PROVEEDOR, PRECIO_VENTA_IT) = False Then
                    util.mensajes("Items de Compras no registrados", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                If CBool(GridView1.GetRowCellValue(i, "nuevo")) = True Then
                    ID_MV_ITEMS_STOCK = movim_stock.id_movim_items_stock()
                    If compra.insertar_items_compra(ID_COMPRA, ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_ARTICULO, ID_MV_ITEMS_STOCK, ID_PROVEEDOR, PRECIO_VENTA_IT) = False Then
                        util.mensajes("Items de Compras no registrados", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If compra.actualizar_items_compra(CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_ITEM_COMPRA, ID_PROVEEDOR, PRECIO_VENTA_IT) = False Then
                        util.mensajes("Items de Compras no actualizados", TITULO_MSJ, "WAR")
                        Return
                    End If
                End If
            End If

            If CONTROLAR_STOCK_ITEM Then
                'Se registra el item del movimiento de stock
                obtener_transaccion_stock()
                If EXISTE_COMPRA = False Then
                    If movim_stock.insertar_movim_item_stock(ID_MOVIMIENTO, ID_TRANSACCION, "INGRESO", ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_ARTICULO, PRECIO_VENTA_IT, ID_MV_ITEMS_STOCK, ID_PROVEEDOR) = False Then
                        util.mensajes("Items de Movim. de Stock no registrados", TITULO_MSJ, "WAR")
                        Return
                    End If
                Else
                    If CBool(GridView1.GetRowCellValue(i, "nuevo")) = True Then
                        If movim_stock.insertar_movim_item_stock(ID_MOVIMIENTO, ID_TRANSACCION, "INGRESO", ID_MATERIAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_ARTICULO, PRECIO_VENTA_IT, ID_MV_ITEMS_STOCK, ID_PROVEEDOR) = False Then
                            util.mensajes("Items de Movim. de Stock no registrados", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Else
                        ID_MV_ITEMS_STOCK = CInt(GridView1.GetRowCellValue(i, "id_item_mv_stock"))
                        If movim_stock.actualizar_movim_item_stock(CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, ID_MV_ITEMS_STOCK) = False Then
                            util.mensajes("Items de Movim. de Stock no actualizados", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                End If

                'Se aumenta el stock
                If RELACION = "ARTICULOS" Then
                    If stock.validar_stock(ID_ARTICULO, "articulo", ID_SUCURSAL) Then
                        If stock.aumentar_stock(ID_ARTICULO, CANTIDAD, "articulo", ID_SUCURSAL) = False Then
                            util.mensajes("Aumento de stock no realizado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Else
                        If stock.insertar(ID_ARTICULO, CANTIDAD, 0, COSTO_UNITARIO, 0, 0, ID_SUCURSAL) = False Then
                            util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                End If

                If RELACION = "MATERIA PRIMA" Then
                    If stock.validar_stock(ID_MATERIAL, "material", ID_SUCURSAL) Then
                        If stock.aumentar_stock(ID_MATERIAL, CANTIDAD, "material", ID_SUCURSAL) = False Then
                            util.mensajes("Aumento de stock no realizado", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Else
                        If stock.insertar(ID_ARTICULO, CANTIDAD, 0, COSTO_UNITARIO, 0, ID_MATERIAL, ID_SUCURSAL) = False Then
                            util.mensajes("Stock de Materia prima no registrada", TITULO_MSJ, "WAR")
                            Return
                        End If
                    End If
                End If
            End If
        Next

        'Si la compra es actualizada debe disminuir la cantidad anterior para volver a ingresar los nuevos valores al stock
        If EXISTE_COMPRA Then
            disminuir_stock()
        End If

        If cbo_factura.SelectedItem.ToString = "CON FACTURA" Then
            insertar_actualizar_factura()
        End If

        If cbo_factura.SelectedItem.ToString = "SIN FACTURA" Then
            util.mensajes("Compra Registrada", TITULO_MSJ, "INF")
        End If

        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub insertar_actualizar_factura()
        NUMERO_FACTURA = txt_numero_factura.Text

        If txt_fact_gravadas10.Text.Replace(" ", "") = "" Then
        Else
            MONTO_GRAVADO10 = CInt(txt_fact_gravadas10.Text)
        End If
        If txt_fact_gravadas5.Text.Replace(" ", "") = "" Then
        Else
            MONTO_GRAVADO5 = CInt(txt_fact_gravadas5.Text)
        End If
        MONTO_GRAVADO = MONTO_GRAVADO10 + MONTO_GRAVADO5

        If txt_factura_total.Text.Replace(" ", "") = "" Then
        Else
            MONTO_TOTAL = CInt(txt_factura_total.Text)
        End If
        If txt_exentas.Text.Replace(" ", "") = "" Then
        Else
            MONTO_EXENTO = CInt(txt_exentas.Text)
        End If

        If txt_fac_iva10.Text.Replace(" ", "") = "" Then
        Else
            MONTO_IVA10 = CInt(txt_fac_iva10.Text)
        End If
        If txt_fac_iva5.Text.Replace(" ", "") = "" Then
        Else
            MONTO_IVA5 = CInt(txt_fac_iva5.Text)
        End If
        MONTO_IVA = MONTO_IVA10 + MONTO_IVA5


        If EXISTE_FACTURA = False Then
            ID_FACTURA = facturas.id_factura()
            If facturas.insertar(ID_FACTURA, NUMERO_FACTURA, MONTO_GRAVADO, MONTO_TOTAL, MONTO_EXENTO, ID_COMPRA, ID_USUARIO, ID_SUCURSAL, NUMERO, MONTO_GRAVADO10, MONTO_GRAVADO5, MONTO_IVA10, MONTO_IVA5, MONTO_IVA, ID_TIPO_COMPROBANTE) Then
                If facturas.actualizar_compra(ID_COMPRA, ID_FACTURA) = False Then
                    util.mensajes("Id Factura de compra no actualizada", TITULO_MSJ, "WAR")
                    Return
                End If
            Else
                util.mensajes("Factura no Registrada", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        If EXISTE_FACTURA Then
            If facturas.actualizar(NUMERO_FACTURA, MONTO_GRAVADO, MONTO_TOTAL, MONTO_EXENTO, MONTO_GRAVADO10, MONTO_GRAVADO5, MONTO_IVA10, MONTO_IVA5, ID_FACTURA, MONTO_IVA, ID_TIPO_COMPROBANTE) = False Then
                util.mensajes("Factura no actualizada", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        util.mensajes("Compra Registrada", TITULO_MSJ, "INF")

    End Sub

    '------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------Eventos de Controles---------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------

    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_numero.Text.Replace(" ", "") = "" Then
            Else
                txt_tipo_compra.Focus()
            End If
        End If
    End Sub

    Private Sub txt_tipo_compra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tipo_compra.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_tipo_compra.Text.Replace(" ", "") = "" Then
            Else
                txt_proveedor.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            btn_tipo_compra.Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_proveedor.Text.Replace(" ", "") = "" Then
            Else
                txt_fecha.Text = Now.ToString("dd/MM/yyyy")
                txt_fecha.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            btn_proveedor.Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub txt_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_factura.Focus()
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            Else
                txt_tipo_compra.Focus()
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_compras"
            frm.CONDICION_SQL = " WHERE id_empresa=" + frm_main.ID_EMPRESA.ToString
            frm.Show()
        End If
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tipo_compra.Focus()
        End If
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        obtener_tipo_facturas()

        txt_id_usuario.Text = frm_main.ID_USUARIO.ToString()
        txt_usuario.Text = frm_main.NOMBRE_USER
        txt_usuario.Focus()

        txt_sucursal.Focus()
    End Sub

    Private Sub btn_buscar_compras_Click(sender As Object, e As EventArgs) Handles btn_buscar_compras.Click
        Dim frm As New frm_vista_compras
        frm.FRM_ACTIVO = "frm_compras"
        frm.Show()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        eliminar_filas_vacias()
        If ID_TRANSACCION <= 0 Then
            util.mensajes("Transaccion de Compra no definido", TITULO_MSJ, "WAR")
            Return
        End If

        obtener_total()
        actualizar_totales()
        insertar_actualizar_compra()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Compras") Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_compras"
        frm.Show()
    End Sub

    Private Sub btn_tipo_compra_Click(sender As Object, e As EventArgs) Handles btn_tipo_compra.Click
        Dim frm As New frm_vista_tipos_compra
        frm.FRM_ACTIVO = "frm_compras"
        frm.Show()
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_compras"
        frm.CONDICION_SQL = " WHERE id_empresa=" + frm_main.ID_EMPRESA.ToString
        frm.Show()
    End Sub

    Private Sub rps_txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then

            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "item").ToString = "" Then
            Else
                GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                Return
            End If

            Dim codigobarras As String
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            codigobarras = GridView1.GetFocusedDisplayText()
            obtener_item(0, codigobarras)
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If RELACION = "ARTICULOS" Then
                Dim frm As New frm_vista_articulos
                frm.FRM_ACTIVO = "frm_compras"
                frm.CONDICION_SQL = ""
                frm.Show()
            ElseIf RELACION = "MATERIA PRIMA" Then
                Dim frm As New frm_vista_materiales
                frm.FRM_ACTIVO = "frm_compras"
                frm.Show()
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            txt_numero_factura.Focus()
        End If
    End Sub

    Private Sub rps_txt_item_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_item.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If RELACION = "ARTICULOS" Then
                Dim frm As New frm_vista_articulos
                frm.FRM_ACTIVO = "frm_compras"
                frm.CONDICION_SQL = "WHERE produccion_propia=false OR produccion_propia IS NULL"
                frm.Show()
            ElseIf RELACION = "MATERIA PRIMA" Then
                Dim frm As New frm_vista_materiales
                frm.FRM_ACTIVO = "frm_compras"
                frm.Show()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "item")) Then
                util.mensajes("Asigne item al pedido", TITULO_MSJ, "WAR")
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                SendKeys.Send("ENTER")
                Return
            End If

            If RELACION = "ARTICULOS" Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            ElseIf RELACION = "MATERIA PRIMA" Then
                GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            TabPane1.SelectedPageIndex = 4
            txt_numero_factura.Focus()
        End If

    End Sub

    Private Sub rps_txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rps_txt_cantidad.KeyPress
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

    Private Sub rps_txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Ingrese Cantidad a comprar", TITULO_MSJ, "WAR")

                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                End If
            Else
                If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) <= 0 Then
                    util.mensajes("Ingrese Cantidad a comprar", TITULO_MSJ, "WAR")
                    If RELACION = "ARTICULOS" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                    ElseIf RELACION = "MATERIA PRIMA" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                    End If
                Else
                    Dim rowhandle As Integer = GridView1.FocusedRowHandle

                    If RELACION = "ARTICULOS" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                    ElseIf RELACION = "MATERIA PRIMA" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                    End If

                    obtener_total()
                    actualizar_totales()
                End If
            End If
        End If
    End Sub

    Private Sub rps_txt_total_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_total_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then

            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_unitario")) Then
                util.mensajes("Ingrese costo unitario", TITULO_MSJ, "WAR")

                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
            Else
                If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_unitario")) <= 0 Then
                    util.mensajes("Ingrese costo unitario", TITULO_MSJ, "WAR")
                    If RELACION = "ARTICULOS" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                    ElseIf RELACION = "MATERIA PRIMA" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                    End If
                Else
                    Dim rowhandle As Integer = GridView1.FocusedRowHandle
                    Dim total_unitario As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "total_unitario"))
                    Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(rowhandle, "cantidad"))

                    GridView1.SetRowCellValue(rowhandle, "total", total_unitario * cantidad)
                    If RELACION = "ARTICULOS" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                    ElseIf RELACION = "MATERIA PRIMA" Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                    End If
                    obtener_total()
                    actualizar_totales()
                End If
            End If
        End If
    End Sub

    Private Sub rps_txt_total_KeyDown(sender As Object, e As KeyEventArgs) Handles rps_txt_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_item")) Then
                util.mensajes("Asigne item al pedido", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                End If
                Return
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) Then
                util.mensajes("Ingrese Cantidad a comprar", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                End If
                GridView1.ShowEditor()
                Return
            End If
            If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cantidad")) <= 0 Then
                util.mensajes("Ingrese Cantidad a comprar", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                End If
                Return
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_unitario")) Then
                util.mensajes("Ingrese costo unitario", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
                GridView1.ShowEditor()
                Return
            End If
            If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total_unitario")) <= 0 Then
                util.mensajes("Ingrese costo unitario", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
                Return
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total")) Then
                util.mensajes("Total debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                End If
                GridView1.ShowEditor()
                Return
            End If
            If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "total")) <= 0 Then
                util.mensajes("Total debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
                If RELACION = "ARTICULOS" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                ElseIf RELACION = "MATERIA PRIMA" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                End If
                Return
            End If

            GridView1.AddNewRow()
            obtener_total()
            actualizar_totales()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub btn_quitar_item_Click(sender As Object, e As EventArgs) Handles btn_quitar_item.Click
        Dim i As Integer = GridView1.FocusedRowHandle()
        If i < 0 Then
            util.mensajes("Selccione un item para eliminar", TITULO_MSJ, "WAR")
            Return
        End If
        eliminar_item()
    End Sub

    Private Sub grid_item_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_item.KeyDown
        If e.KeyCode = Keys.Insert Then
            GridView1.AddNewRow()
            grid_item.Focus()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            GridView1.ShowEditor()
        End If
    End Sub

    Private Sub txt_numero_factura_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_factura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_numero_factura.Text.Replace(" ", "") = "" Then
            Else
                cbo_tipo_comprobante.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_tipo_comprobante_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_comprobante.SelectedIndex >= 0 Then
                txt_factura_total.Focus()
            End If
        End If
    End Sub

    Private Sub txt_factura_total_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_factura_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_factura_total.Text.Replace(" ", "") = "" Then
            Else
                txt_exentas.Focus()
            End If
        End If
    End Sub

    Private Sub txt_exentas_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_exentas.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fact_gravadas5.Focus()
        End If
    End Sub

    Private Sub txt_fact_gravadas5_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fact_gravadas5.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fact_gravadas10.Focus()
        End If
    End Sub

    Private Sub txt_fact_gravadas10_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fact_gravadas10.KeyDown
        If e.KeyCode = Keys.Enter Then
            If REQUIERE_ITEM = True Then
                TabPane1.SelectedPageIndex = 1
                grid_item.Focus()
                SendKeys.Send("{ENTER}")
            Else
                btn_confirmar.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_tipo_comprobante_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim indice As Integer = cbo_tipo_comprobante.SelectedIndex
        ID_TIPO_COMPROBANTE = CInt(dt_tipo_comprobantes.Rows(indice).Item(0))
    End Sub

    Private Sub txt_factura_total_Validated(sender As Object, e As EventArgs) Handles txt_factura_total.Validated
        calcular_gravadas()
    End Sub

    Private Sub txt_exentas_Validated(sender As Object, e As EventArgs) Handles txt_exentas.Validated
        calcular_gravadas()
    End Sub

    Private Sub txt_fact_gravadas5_Validated(sender As Object, e As EventArgs) Handles txt_fact_gravadas5.Validated
        calcular_gravadas()
    End Sub

    Private Sub txt_fact_gravadas10_Validated(sender As Object, e As EventArgs) Handles txt_fact_gravadas10.Validated
        calcular_gravadas()
    End Sub

    Private Sub cbo_tipo_comprobante_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbo_tipo_comprobante.SelectedIndexChanged
        ID_TIPO_COMPROBANTE = CInt(dt_tipo_comprobantes.Rows(cbo_tipo_comprobante.SelectedIndex).Item(0))
    End Sub

    Private Sub txt_total_gasto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_gasto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_comprobante_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cbo_tipo_comprobante.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_comprobante.SelectedIndex >= 0 Then
                txt_factura_total.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_factura.SelectedIndexChanged
        If cbo_factura.SelectedIndex = 0 Then
            TabNavigationPage3.PageVisible = False
            PanelControl3.Visible = False
            PanelControl4.Visible = False
            txt_total_gasto.Visible = True
            lbl_total_gasto.Visible = True
            TabPane1.SelectedPageIndex = 1
        End If

        If cbo_factura.SelectedIndex = 1 Then
            TabNavigationPage3.PageVisible = True
            PanelControl3.Visible = True
            PanelControl4.Visible = True
            txt_total_gasto.Visible = False
            lbl_total_gasto.Visible = False
            obtener_tipo_facturas()
            TabPane1.SelectedPageIndex = 0
        End If

        If REQUIERE_ITEM Then
            txt_total_gasto.Visible = False
            lbl_total_gasto.Visible = False
        End If

    End Sub

    Private Sub ComboBoxEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_factura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If REQUIERE_ITEM Then
                If cbo_factura.SelectedIndex = 0 Then
                    grid_item.Focus()
                    GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                    SendKeys.Send("{ENTER}")
                End If
                If cbo_factura.SelectedIndex = 1 Then
                    txt_numero_factura.Focus()
                End If
            Else
                If cbo_factura.SelectedIndex = 0 Then
                    txt_total_gasto.Focus()
                End If
                If cbo_factura.SelectedIndex = 1 Then
                    txt_numero_factura.Focus()
                End If
            End If
        End If
    End Sub


End Class