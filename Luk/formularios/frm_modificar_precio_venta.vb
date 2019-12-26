Public Class frm_modificar_precio_venta

    Private articulo As New func_articulos
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Modificacion de Precio de Venta>"

    Private ID_ARTICULO As Integer = 0
    Private PRECIO_ACTUAL As Integer = 0
    Private PRECIO_NUEVO As Integer = 0
    Private COSTO_UNIT As Integer = 0

    Private Sub frm_modificar_precio_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
    End Sub

    Private Sub desabilitar()
        txt_codigo_barras.Enabled = False
        txt_articulo.Enabled = False
        btn_buscar_articulo.Enabled = False
        txt_id_articulo.Enabled = False
        txt_codigo_barras.Enabled = False

        txt_va_precio_venta.Enabled = False
        txt_va_precio_costo.Enabled = False
        txt_va_porcentaje.Enabled = False

        txt_ul_precio.Enabled = False
        txt_ul_fecha.Enabled = False
        btn_historial.Enabled = False

        txt_nuevo_precio.Enabled = False
        btn_registrar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_codigo_barras.Enabled = True
        txt_articulo.Enabled = True
        btn_buscar_articulo.Enabled = True
        txt_id_articulo.Enabled = True
        txt_codigo_barras.Enabled = True

        txt_va_precio_venta.Enabled = True
        txt_va_precio_costo.Enabled = True
        txt_va_porcentaje.Enabled = True

        txt_ul_precio.Enabled = True
        txt_ul_fecha.Enabled = True
        btn_historial.Enabled = True

        txt_nuevo_precio.Enabled = True
        btn_registrar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_codigo_barras.Text = ""
        txt_articulo.Text = ""
        txt_id_articulo.Text = ""
        txt_cod_interno.Text = ""

        txt_va_precio_venta.Text = ""
        txt_va_precio_costo.Text = ""
        txt_va_porcentaje.Text = ""

        txt_ul_precio.Text = ""
        txt_ul_fecha.Text = ""

        txt_nuevo_precio.Text = ""
        ID_ARTICULO = 0
    End Sub

    Private Sub calcular_recargo(accion As String)
        Dim costo As Long = 0
        Dim nuevo As Long = 0
        Dim dif As Long = 0
        Dim porc As Long = 0
        Dim valor As Long = 0

        If txt_va_precio_costo.Text = "" Then
            costo = 0
        Else
            costo = CInt(txt_va_precio_costo.Text)
        End If

        If txt_va_porcentaje.Text.Replace(" ", "") = "" Then
            porc = 0
        Else
            porc = CInt(txt_va_porcentaje.Text)
        End If

        If txt_nuevo_precio.Text.Replace(" ", "") = "" Then
            nuevo = 0
        Else
            nuevo = CInt(txt_nuevo_precio.Text)
        End If


        If accion = "co" Then
            valor = CInt((costo * porc) / 100)
            txt_nuevo_precio.Text = CStr(costo + valor)
        End If

        If accion = "po" Then
            If nuevo > costo Then
                dif = nuevo - costo
            End If

            If nuevo < costo Then
                dif = costo - nuevo
            End If

            valor = CInt((dif * 100) / costo)
            txt_va_porcentaje.Text = CStr(valor)
        End If

    End Sub

    Private Sub calcular_porcentaje(precio As Integer, costo As Integer)
        Dim dif As Long = 0
        Dim valor As Long = 0

        If precio > costo Then
            dif = precio - costo
        End If

        If precio < costo Then
            dif = costo - precio
        End If

        If costo > 0 Then
            valor = CInt((dif * 100) / costo)
        End If
        txt_va_porcentaje.Text = CStr(valor)
    End Sub

    Public Sub obtener_articulos(cod As String)
        limpiar()
        Dim dt As New DataTable
        dt = articulo.listar("SELECT codigo_barras, nombre, id_articulo, codigo_articulo, COALESCE(precio_venta, 0), COALESCE(costo_unitario, 0) 
                              FROM articulos WHERE codigo_barras='" + cod + "' OR codigo_articulo = '" + cod + "'")

        If dt.Rows.Count > 0 Then
            txt_codigo_barras.Text = CStr(dt.Rows(0).Item(0))
            txt_articulo.Text = CStr(dt.Rows(0).Item(1))
            txt_id_articulo.Text = CStr(dt.Rows(0).Item(2))
            ID_ARTICULO = CInt(dt.Rows(0).Item(2))
            txt_cod_interno.Text = CStr(dt.Rows(0).Item(3))

            txt_va_precio_venta.Text = CStr(dt.Rows(0).Item(4))
            txt_va_precio_costo.Text = CStr(dt.Rows(0).Item(5))

            obtener_historial(CInt(txt_id_articulo.Text))
            calcular_porcentaje(CInt(dt.Rows(0).Item(4)), CInt(dt.Rows(0).Item(5)))

            txt_nuevo_precio.Focus()
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
            txt_codigo_barras.Focus()
        End If
    End Sub

    Private Sub obtener_historial(id As Integer)
        Dim dt As New DataTable
        dt = articulo.listar("SELECT nuevo_precio, fecha_cambio FROM historial_mod_precio_venta 
                             WHERE id_articulo= " + id.ToString + " 
                             AND fecha_cambio = (SELECT MAX(fecha_cambio) FROM historial_mod_precio_venta WHERE id_articulo=" + id.ToString + ")")

        If dt.Rows.Count > 0 Then
            txt_ul_precio.Text = CStr(dt.Rows(0).Item(0))
            txt_ul_fecha.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub registrar()
        If txt_va_precio_costo.Text.Replace(" ", "") = "" Then
            COSTO_UNIT = 0
        Else
            COSTO_UNIT = CInt(txt_va_precio_costo.Text)
        End If

        If txt_nuevo_precio.Text.Replace(" ", "") = "" Then
            PRECIO_NUEVO = 0
        Else
            PRECIO_NUEVO = CInt(txt_nuevo_precio.Text)
        End If

        If ID_ARTICULO <= 0 Then
            util.mensajes("Debe seleccionar articulo para actualizar", TITULO_MSJ, "WAR")
            Return
        End If

        If txt_va_precio_venta.Text.Replace(" ", "") = "" Then
            PRECIO_ACTUAL = 0
        Else
            PRECIO_ACTUAL = CInt(txt_va_precio_venta.Text)
        End If

        If PRECIO_NUEVO <= 0 Then
            util.mensajes("Nuevo precio de venta debe ser mayor a cero(0)", TITULO_MSJ, "WAR")
            txt_nuevo_precio.Focus()
            Return
        End If

        If COSTO_UNIT > PRECIO_NUEVO Then
            util.mensajes("Nuevo precio de venta debe ser mayor al costo", TITULO_MSJ, "WAR")
            txt_nuevo_precio.Focus()
            Return
        End If

        If articulo.actualizar_costo(COSTO_UNIT, ID_ARTICULO) = False Then
            util.mensajes("Precio de Costo no actualizado", TITULO_MSJ, "WAR")
            Return
        End If

        If articulo.actualizar_precio_venta(PRECIO_NUEVO, ID_ARTICULO) = False Then
            util.mensajes("Precio de Venta no actualizado", TITULO_MSJ, "WAR")
            Return
        End If

        If articulo.insertar_historial(ID_ARTICULO, PRECIO_NUEVO, PRECIO_ACTUAL) = False Then
            util.mensajes("Historial no Registrado", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Precio de Venta actualizdo", TITULO_MSJ, "INF")
        limpiar()
        desabilitar()
    End Sub

    Private Sub btn_buscar_articulo_Click(sender As Object, e As EventArgs) Handles btn_buscar_articulo.Click
        Dim frm As New frm_vista_articulos
        frm.FRM_ACTIVO = "frm_modificar_precio_venta"
        frm.Show()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitar()
        limpiar()
        txt_codigo_barras.Focus()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        registrar()
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo_barras.Text.Replace(" ", "") = "" Then
            Else
                obtener_articulos(txt_codigo_barras.Text)
            End If
        End If

        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_modificar_precio_venta"
            frm.Show()
        End If
    End Sub

    Private Sub txt_va_precio_costo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_va_precio_costo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_va_porcentaje.Focus()
        End If
    End Sub

    Private Sub txt_va_porcentaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_va_porcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_va_porcentaje.Text.Replace(" ", "") = "" Then
                txt_nuevo_precio.Focus()
            Else
                If txt_va_precio_costo.Text.Replace(" ", "") = "" Or txt_va_porcentaje.Text.Replace(" ", "") = "" Then
                    txt_nuevo_precio.Text = "0"
                Else
                    txt_nuevo_precio.Text = "0"
                    If CInt(txt_va_precio_costo.Text) > 0 And CInt(txt_va_porcentaje.Text) > 0 Then
                        calcular_recargo("co")
                    End If
                End If
                txt_nuevo_precio.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nuevo_precio_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nuevo_precio.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nuevo_precio.Text = "" Then
            Else
                If txt_nuevo_precio.Text.Replace(" ", "") = "" Or txt_va_precio_costo.Text.Replace(" ", "") = "" Then
                    txt_va_porcentaje.Text = "0"
                Else
                    txt_va_porcentaje.Text = "0"
                    If CInt(txt_nuevo_precio.Text) > 0 And CInt(txt_va_precio_costo.Text) > 0 Then
                        calcular_recargo("po")
                    End If
                End If
                btn_registrar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_historial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        If txt_id_articulo.Text = "" Then
            util.mensajes("Debe seleccionar articulo para visualizar Historial", TITULO_MSJ, "WAR")
            txt_codigo_barras.Focus()
            Return
        End If
        Dim frm As New frm_historial_precio_venta
        frm.listar(txt_id_articulo.Text)
        frm.Show()
    End Sub

End Class