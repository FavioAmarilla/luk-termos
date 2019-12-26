Public Class frm_existencia_en_stock

    Dim stock As New func_stock_articulos
    Dim util As New utilidades

    Private Sub frm_existencia_en_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiar()
        cbo_tipo_stock.SelectedIndex = -1
        txt_codigo_barras.Text = ""
        txt_nombre.Text = ""
        txt_impuesto.Text = ""
        txt_familia.Text = ""
        txt_existencia.Text = ""
        cbo_tipo_stock.Focus()
    End Sub

    Public Sub obtener_articulo(id As String)
        If cbo_tipo_stock.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de item", "Stock", "WAR")
            cbo_tipo_stock.Focus()
            Return
        End If
        If txt_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", "Stock", "WAR")
            txt_sucursal.Focus()
            Return
        End If

        Dim dt As New DataTable
        Dim codigo As String = txt_codigo_barras.Text
        Dim condicion_sql As String = ""

        If codigo.Replace(" ", "") IsNot "" And id = "" Then
            condicion_sql = "WHERE a.codigo_barras='" + codigo + "'"
        Else
            condicion_sql = "WHERE a.id_articulo=" + id.ToString + ""
        End If

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", "<Stock de Item>", "WAR")
            txt_sucursal.Focus()
        Else
            condicion_sql += "AND sa.id_sucursal=" & txt_id_sucursal.Text
        End If

        dt = stock.consultar("SELECT COALESCE(a.codigo_barras,'-'), a.nombre, COALESCE(ti.nombre,'-') AS impuesto, COALESCE(f.descripcion,'-') AS familia,
                                ROUND(COALESCE(sa.cantidad, 0), 2) FROM articulos a
                                INNER JOIN tipos_impuesto ti ON ti.id_tipo_impuesto = a.id_tipo_impuesto
                                INNER JOIN familias f ON f.identificador = a.id_familia
                                INNER JOIN stock_articulos sa ON sa.id_articulo = a.id_articulo " + condicion_sql)

        If dt.Rows.Count > 0 Then
            txt_codigo_barras.Text = CStr(dt.Rows(0).Item(0))
            txt_nombre.Text = CStr(dt.Rows(0).Item(1))
            txt_impuesto.Text = CStr(dt.Rows(0).Item(2))
            txt_familia.Text = CStr(dt.Rows(0).Item(3))
            txt_existencia.Text = CStr(dt.Rows(0).Item(4))
            txt_codigo_barras.Focus()
        Else
            util.mensajes("Stock no definido", "<Stock de Items>", "WAR")
            txt_codigo_barras.Text = ""
            txt_nombre.Text = ""
            txt_impuesto.Text = ""
            txt_familia.Text = ""
            txt_existencia.Text = ""
            txt_codigo_barras.Focus()
        End If

    End Sub

    Public Sub obtener_materia_prima(id As String)
        If cbo_tipo_stock.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de item", "Stock", "WAR")
            cbo_tipo_stock.Focus()
            Return
        End If
        If txt_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", "Stock", "WAR")
            txt_sucursal.Focus()
            Return
        End If


        Dim dt As New DataTable
        Dim codigo As String = txt_codigo_barras.Text
        Dim condicion_sql As String = ""

        If codigo.Replace(" ", "") IsNot "" And id = "" Then
            condicion_sql = " WHERE m.codigo='" + codigo + "'"
        Else
            condicion_sql = " WHERE m.id_material=" + id.ToString + ""
        End If

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", "<Stock de Item>", "WAR")
            txt_sucursal.Focus()
        Else
            condicion_sql += " AND sa.id_sucursal=" & txt_id_sucursal.Text
        End If

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", "<Stock de Item>", "WAR")
            txt_sucursal.Focus()
        Else
            condicion_sql += "AND sa.id_sucursal=" & txt_id_sucursal.Text
        End If



        dt = stock.consultar("SELECT COALESCE(m.codigo,'-'), m.nombre, COALESCE(ti.nombre,'-') AS impuesto, COALESCE(f.descripcion,'-') AS familia,
                                ROUND(COALESCE(sa.cantidad, 0), 2) FROM materiales m
                                INNER JOIN tipos_impuesto ti ON ti.id_tipo_impuesto = m.id_tipo_impuesto
                                INNER JOIN familias_materia_prima f ON f.identificador = m.id_familia
                                INNER JOIN stock_articulos sa ON sa.id_material = m.id_material " & condicion_sql)

        If dt.Rows.Count > 0 Then
            txt_codigo_barras.Text = CStr(dt.Rows(0).Item(0))
            txt_nombre.Text = CStr(dt.Rows(0).Item(1))
            txt_impuesto.Text = CStr(dt.Rows(0).Item(2))
            txt_familia.Text = CStr(dt.Rows(0).Item(3))
            txt_existencia.Text = CInt(dt.Rows(0).Item(4))
            txt_codigo_barras.Focus()
        Else
            util.mensajes("Stock no definido", "<Stock de Items>", "WAR")
            txt_codigo_barras.Text = ""
            txt_nombre.Text = ""
            txt_impuesto.Text = ""
            txt_familia.Text = ""
            txt_existencia.Text = ""
            txt_codigo_barras.Focus()
        End If

    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = stock.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            util.mensajes("Sucursal no definida", "<Stock de Items>", "WAR")
            limpiar()
        End If
    End Sub

    Private Sub btn_articulos_Click(sender As Object, e As EventArgs) Handles btn_articulos.Click
        If cbo_tipo_stock.SelectedIndex = 0 Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_existencia_en_stock"
            frm.Show()
        End If

        If cbo_tipo_stock.SelectedIndex = 1 Then
            Dim frm As New frm_vista_materiales
            frm.FRM_ACTIVO = "frm_existencia_en_stock"
            frm.Show()
        End If
    End Sub

    Private Sub cbo_tipo_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_stock.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_stock.SelectedIndex >= 0 Then
                txt_sucursal.Focus()
            End If
        End If
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo_barras.Text.Replace(" ", "") = "" Then
            Else
                If cbo_tipo_stock.SelectedIndex = 0 Then
                    obtener_articulo(txt_codigo_barras.Text)
                End If
                If cbo_tipo_stock.SelectedIndex = 1 And txt_nombre.Text.Replace(" ", "") IsNot "" Then
                    obtener_materia_prima(txt_codigo_barras.Text)
                End If
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            If cbo_tipo_stock.SelectedIndex = 0 Then
                Dim frm As New frm_vista_articulos
                frm.FRM_ACTIVO = "frm_existencia_en_stock"
                frm.Show()
            End If

            If cbo_tipo_stock.SelectedIndex = 1 Then
                Dim frm As New frm_vista_materiales
                frm.FRM_ACTIVO = "frm_existencia_en_stock"
                frm.Show()
            End If
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Existencia") Then
            limpiar()
        End If
    End Sub

    Private Sub cbo_tipo_stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_stock.SelectedIndexChanged
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_codigo_barras.Text = ""
        txt_nombre.Text = ""
        txt_impuesto.Text = ""
        txt_familia.Text = ""
        txt_existencia.Text = ""
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs)
        If cbo_tipo_stock.SelectedIndex = 0 Then
            obtener_articulo(txt_codigo_barras.Text)
        End If
        If cbo_tipo_stock.SelectedIndex = 1 Then
            obtener_materia_prima(txt_codigo_barras.Text)
        End If
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_existencia_en_stock"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            Else
                txt_codigo_barras.Focus()
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_existencia_en_stock"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
    End Sub

End Class