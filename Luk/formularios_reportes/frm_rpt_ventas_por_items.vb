Public Class frm_rpt_ventas_por_items

    Dim id_articulo As Integer = 0
    Dim id_sucursal As Integer = 0
    Dim util As New utilidades
    Dim func_ventas As New func_ventas

    Private Sub frm_rpt_ventas_por_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cld_desde.Visible = False
        cld_hasta.Visible = False
    End Sub

    Sub mostrar_vista(vr As String)
        If vr = "FD" Then
            If cld_desde.Visible = False Then
                cld_desde.Visible = True
                cld_desde.Focus()
            Else
                cld_desde.Visible = False
            End If
        End If
        If vr = "FH" Then
            If cld_hasta.Visible = False Then
                cld_hasta.Visible = True
                cld_hasta.Focus()
            Else
                cld_hasta.Visible = False
            End If
        End If

        If vr = "SU" Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_rpt_ventas_por_items"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If

        If vr = "AR" Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_rpt_ventas_por_items"
            frm.Show()
        End If

    End Sub

    Function get_id_articulo(codigo_barras As String) As Integer
        Dim dt As New DataTable
        dt = func_ventas.consultar("select id_articulo from articulos where codigo_barras=" & codigo_barras)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            util.mensajes("Idnetificador de producto no definido", "Reporte", "WAR")
            Return 0
        End If
    End Function

    Public Sub get_articulo(id As Integer)
        Dim dt As New DataTable
        dt = func_ventas.consultar("select nombre, codigo_barras from articulos where id_articulo=" & id)
        If dt.Rows.Count > 0 Then
            id_articulo = id
            txt_articulo.Text = CStr(dt.Rows(0).Item(0))
            txt_codigo_barras.Text = CStr(dt.Rows(0).Item(1))
            txt_articulo.Focus()
        Else
            util.mensajes("Producto no definido", "Reporte", "WAR")
            txt_codigo_barras.Focus()
        End If
    End Sub

    Sub consultar()
        Dim dt As New DataTable

        If id_articulo <= 0 Then
            util.mensajes("Debe seleccionar un articulo", "Reporte", "WAR")
            txt_codigo_barras.Focus()
            Return
        End If

        If id_sucursal <= 0 Then
            util.mensajes("Debe seleccionar sucursal", "Reporte", "WAR")
            txt_sucursal.Focus()
            Return
        End If

        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha desde", "Reporte", "WAR")
            txt_fecha_desde.Focus()
            Return
        End If

        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresar fecha hasta", "Reporte", "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If

        dt = func_ventas.consultar("select to_char(iv.fecha_cre,'dd/MM/yyyy') as fecha, ar.codigo_barras, ar.nombre as descripcion, iv.precio_venta, 
                                    sum(iv.cantidad) as cantidad, sum(iv.precio_venta * iv.cantidad) as total
                                    from items_venta iv
                                    inner join ventas vt on vt.id_venta = iv.id_venta
                                    inner join articulos ar on ar.id_articulo = iv.id_articulo
                                    where to_char(iv.fecha_cre,'dd/MM/yyyy') >= '" & txt_fecha_desde.Text & "' 
                                    and to_char(iv.fecha_cre,'dd/MM/yyyy') <= '" & txt_fecha_hasta.Text & "'
                                    and iv.id_articulo = " & CStr(id_articulo) & " and id_sucursal=" & CStr(id_sucursal) & "
                                    group by to_char(iv.fecha_cre,'dd/MM/yyyy'), ar.codigo_barras, ar.nombre, iv.precio_venta, iv.fecha_cre
                                    order by iv.fecha_cre desc")

        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        Else
            util.mensajes("No se registraron ventas del item", "Reporte", "INF")
        End If

    End Sub
    Public Sub get_sucursal(id As String)
        Dim dt As New DataTable

        dt = func_ventas.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            id_sucursal = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub limpiar()
        id_articulo = 0
        id_sucursal = 0
        txt_codigo_barras.Text = ""
        txt_articulo.Text = ""
        txt_sucursal.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_articulo > 0 Then
                txt_articulo.Focus()
            Else
                If txt_articulo.Text.Replace(" ", "") IsNot "" Then
                    If id_articulo > 0 Then
                        txt_articulo.Focus()
                    Else
                        get_articulo(get_id_articulo(txt_codigo_barras.Text))
                        txt_articulo.Focus()
                    End If
                End If
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("AR")
        End If
    End Sub

    Private Sub txt_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_articulo > 0 Then
                txt_sucursal.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("AR")
        End If
    End Sub

    Private Sub btn_articulos_Click(sender As Object, e As EventArgs) Handles btn_articulos.Click
        mostrar_vista("AR")
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If id_sucursal > 0 Then
                txt_fecha_desde.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("SU")
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        mostrar_vista("SU")
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_desde.Text = "  /  /" Then
            Else
                txt_fecha_hasta.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("FD")
        End If
    End Sub

    Private Sub btn_cal_desde_Click(sender As Object, e As EventArgs) Handles btn_cal_desde.Click
        mostrar_vista("FD")
    End Sub

    Private Sub cld_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_desde.DoubleClick
        txt_fecha_desde.Text = cld_desde.DateTime.ToString
        txt_fecha_desde.Focus()
        cld_desde.Visible = False
    End Sub

    Private Sub cld_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_desde.DateTime.ToString
            txt_fecha_desde.Focus()
            cld_desde.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_desde.Visible = False
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_hasta.Text = "  /  /" Then
            Else
                btn_consultar.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            mostrar_vista("FH")
        End If
    End Sub

    Private Sub btn_cld_hasta_Click(sender As Object, e As EventArgs) Handles btn_cld_hasta.Click
        mostrar_vista("FH")
    End Sub

    Private Sub cld_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cld_hasta.DoubleClick
        txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
        txt_fecha_hasta.Focus()
        cld_hasta.Visible = False
    End Sub

    Private Sub cld_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
            txt_fecha_hasta.Focus()
            cld_hasta.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_hasta.Visible = False
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        consultar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar laoperacion", "Confirmacion") Then
            limpiar()
            txt_codigo_barras.Focus()
        End If
    End Sub
End Class