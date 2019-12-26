Public Class frm_saldo_stock

    Private movim As New func_movimientos_stock
    Private dt_movimientos As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Saldos de Stock>"

    Private ID_ARTICULO As Integer = 0
    Private ID_MATERIA_PRIMA As Integer = 0

    Private Sub frm_saldo_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        Dim orden As String = " ORDER BY x.fecha ASC"
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim item As String = ""

        If chk_articulo.Checked = False And chk_materia_prima.Checked = False Then
            util.mensajes("Debe seleccionar Filtro de Item", TITULO_MSJ, "WAR")
            Return
        End If

        If chk_articulo.Checked Then
            item = " WHERE id_articulo=" + ID_ARTICULO.ToString
        End If

        If chk_materia_prima.Checked Then
            item = " WHERE id_material=" + ID_MATERIA_PRIMA.ToString
        End If

        If txt_fecha_desde.Text = "  /  /" Then
        Else
            desde = " AND x.fecha >= '" + txt_fecha_desde.Text + "' "
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
        Else
            hasta = " AND x.fecha <= '" + txt_fecha_hasta.Text + "' "
        End If

        dt_movimientos = movim.consultar("SELECT  x.fecha, transacciones_stock.nombre, x.accion, x.ingreso, x.egreso, 
                                        SUM(x.cantidad) OVER(ORDER BY id_movimiento) AS saldo_actual,
                                        COALESCE((x.egreso + SUM(x.cantidad) OVER(ORDER BY id_movimiento)) - x.ingreso,0) AS saldo_anterior  
                                        FROM
                                        (SELECT id_articulo, id_movimiento,id_transaccion,fecha,accion,id_material,cantidad_unit,
                                        CASE accion WHEN 'INGRESO' THEN cantidad_unit * + 1 ELSE 0 END AS ingreso,
                                        CASE accion WHEN 'EGRESO' THEN cantidad_unit * - 1 ELSE 0 END AS egreso,
                                        CASE accion WHEN 'EGRESO' THEN cantidad_unit * - 1 ELSE cantidad_unit END AS cantidad
                                        FROM movim_item_stock ) AS x
                                        INNER JOIN transacciones_stock ON transacciones_stock.id_transaccion = x.id_transaccion " +
                                        item + desde + hasta + orden)

        If dt_movimientos.Rows.Count > 0 Then
            grid_movimientos.DataSource = dt_movimientos
        Else
            util.mensajes("No se registraron Movimientos de Stock para la fecha", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            grid_movimientos.DataSource = Nothing
        End If

        txt_item.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub obtener_articulo(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_articulo, nombre, codigo_articulo FROM articulos WHERE id_articulo=" + id)

        If dt.Rows.Count > 0 Then
            ID_ARTICULO = CInt(dt.Rows(0).Item(0))
            txt_item.Text = CStr(dt.Rows(0).Item(1))
            txt_codigo.Text = CStr(dt.Rows(0).Item(2))
        End If

        txt_item.Focus()
    End Sub

    Public Sub obtener_materia_prima(id As String)
        Dim dt As New DataTable
        dt = movim.consultar("SELECT id_material, nombre, COALESCE(codigo,'') FROM materiales WHERE id_material=" + id)

        If dt.Rows.Count > 0 Then
            ID_MATERIA_PRIMA = CInt(dt.Rows(0).Item(0))
            txt_item.Text = CStr(dt.Rows(0).Item(1))
            txt_codigo.Text = CStr(dt.Rows(0).Item(2))
        End If

        txt_item.Focus()
    End Sub

    Private Sub buscar_item()

        If chk_articulo.Checked = False And chk_materia_prima.Checked = False Then
            util.mensajes("Debe seleccionar Filtro de Item", TITULO_MSJ, "WAR")
            Return
        End If

        If chk_articulo.Checked Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_saldo_stock"
            frm.Show()
        End If

        If chk_materia_prima.Checked Then
            Dim frm As New frm_vista_materiales
            frm.FRM_ACTIVO = "frm_saldo_stock"
            frm.Show()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        listar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            txt_fecha_desde.Text = ""
            txt_fecha_hasta.Text = ""
            txt_item.Text = ""
            txt_codigo.Text = ""
            grid_movimientos.DataSource = Nothing
        End If
    End Sub

    Private Sub btn_item_Click(sender As Object, e As EventArgs) Handles btn_item.Click
        buscar_item()
    End Sub

    Private Sub chk_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_articulo.Checked Then
                txt_item.Focus()
            Else
                chk_materia_prima.Focus()
            End If
        End If
    End Sub

    Private Sub chk_materia_prima_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_materia_prima.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_item.Focus()
        End If
    End Sub

    Private Sub txt_item_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_item.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_item.Text.Replace(" ", "") = "" Then
            Else
                txt_fecha_desde.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_item()
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Focus()
            cld_desde.Visible = False
        End If
        If e.KeyCode = Keys.Space Then
            cld_desde.Visible = True
            cld_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
            cld_hasta.Visible = False
        End If
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
    End Sub

    Private Sub chk_articulo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulo.CheckedChanged
        If chk_articulo.Checked Then
            chk_materia_prima.Checked = False
        End If
    End Sub

    Private Sub chk_materia_prima_CheckedChanged(sender As Object, e As EventArgs) Handles chk_materia_prima.CheckedChanged
        If chk_materia_prima.Checked Then
            chk_articulo.Checked = False
        End If
    End Sub

    Private Sub btn_desde_Click(sender As Object, e As EventArgs) Handles btn_desde.Click
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub cld_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_desde.DoubleClick
        txt_fecha_desde.Text = cld_desde.DateTime.ToString
        cld_desde.Visible = False
        txt_fecha_desde.Focus()
    End Sub

    Private Sub cld_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_desde.DateTime.ToString
            cld_desde.Visible = False
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub btn_hasta_Click(sender As Object, e As EventArgs) Handles btn_hasta.Click
        cld_hasta.Visible = True
        cld_hasta.Focus()
    End Sub

    Private Sub cld_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cld_hasta.DoubleClick
        txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
        cld_hasta.Visible = False
        txt_fecha_hasta.Focus()
    End Sub

    Private Sub cld_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
            cld_hasta.Visible = False
            txt_fecha_hasta.Focus()
        End If
    End Sub

End Class