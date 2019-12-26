Public Class frm_nueva_familia_materia_prima

    Private familia As New func_familias_materia_prima
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Definicion de Familias>"
    'Variables para las operaciones sobre la tabla familias
    Private IDENTIFICADOR As Integer = 0
    Private DESCRIPCION As String = ""
    Private NIVEL As Integer = 0
    Private CODIGO As String = ""
    Private NRO_ITEM As Integer = 0
    Private ID_LINEA_PADRE As Integer = 0
    Private ULTIMO_NIVEL As Boolean = False
    Private TIPO_REGISTRO As String = ""

    Private Sub frm_nueva_familia_materia_prima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_datos()
    End Sub

    Public Sub setTIPO_REGISTRO(valor As String)
        TIPO_REGISTRO = valor
    End Sub

    Public Sub setIDENTIFICADOR(id As Integer)
        IDENTIFICADOR = id
    End Sub

    Public Sub setID_LINEA_PADRE(id As Integer)
        ID_LINEA_PADRE = id
    End Sub

    Public Sub obtener_datos()
        NRO_ITEM = obtener_nro_item()

        If TIPO_REGISTRO = "P" Then
            txt_codigo.Text = obtener_codigo_padre()
        End If

        If TIPO_REGISTRO = "S" Then
            txt_codigo.Text = obtener_codigo_sub(NRO_ITEM)
        End If

        cbo_nivel.SelectedItem = obtener_nivel().ToString
        chk_asentable.Checked = False

        txt_familia.Focus()
    End Sub

    Public Sub obtener_familia_padre()
        Dim dt As New DataTable

        dt = familia.listar("select descripcion from familias_materia_prima where identificador=" & IDENTIFICADOR)

        If dt.Rows.Count > 0 Then
            txt_id_padre.Text = IDENTIFICADOR.ToString
            txt_familia_padre.Text = dt.Rows(0).Item(0).ToString
        Else
            util.mensajes("Familia padre no definida", TITULO_MSJ, "WAR")
        End If

    End Sub

    Private Function obtener_nivel() As Integer
        Dim dt As New DataTable
        dt = familia.listar("select coalesce(nivel, 1) + 1 from familias_materia_prima where identificador=" & IDENTIFICADOR)

        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0).Item(0))
        Else
            Return 1
        End If
    End Function

    Private Function obtener_codigo_padre() As String
        Dim dt As New DataTable
        Dim nuevo_codigo As String = ""

        dt = familia.listar("select codigo from familias_materia_prima where COALESCE(id_linea_padre, 0) <= 0 order by identificador desc limit 1")

        If dt.Rows.Count > 0 Then
            Dim codigo As Integer = CInt(dt.Rows(0).Item(0).ToString)
            Dim numero As Integer = CInt(codigo) + 1

            If numero < 10 Then
                nuevo_codigo = "0" & numero.ToString
            End If

            If numero > 9 Then
                nuevo_codigo = numero.ToString()
            End If
        Else
            nuevo_codigo = "01"
        End If

        Return nuevo_codigo
    End Function

    Private Function obtener_codigo_sub(nro_item As Integer) As String
        Dim dt As New DataTable
        Dim codigo_padre As String = ""
        Dim nuevo_codigo As String = ""

        '1- Obtener el codigo del padre
        dt = familia.listar("select codigo from familias_materia_prima where identificador=" & IDENTIFICADOR)
        If dt.Rows.Count > 0 Then
            codigo_padre = dt.Rows(0).Item(0).ToString
        Else
            util.mensajes("Familia padre no posee codigo", TITULO_MSJ, "WAR")
            Return ""
        End If

        '2- Validar si el numero de item es menor a 10 nuevo_codigo = 0&nro_item
        If nro_item < 10 Then
            nuevo_codigo = codigo_padre & "0" & nro_item.ToString
        End If

        '2- Validar si el numero de item es mayor a 9 nuevo_codigo = nro_item
        If nro_item > 9 Then
            nuevo_codigo = codigo_padre & nro_item.ToString
        End If


        Return nuevo_codigo
    End Function

    Private Function obtener_nro_item() As Integer
        Dim dt As New DataTable
        Dim numero As Integer = 0

        dt = familia.listar("select nro_item from familias_materia_prima where id_linea_padre=" & IDENTIFICADOR & " order by nro_item desc limit 1")

        If TIPO_REGISTRO = "S" Then
            If dt.Rows.Count > 0 Then
                numero = CInt(dt.Rows(0).Item(0)) + 1
            Else
                numero = 1
            End If
        End If

        Return numero
    End Function

    Private Sub insertar()
        If TIPO_REGISTRO = "S" And txt_id_padre.Text = "" Then
            util.mensajes("Debe seleccionar familia padre", TITULO_MSJ, "WAR")
            txt_familia_padre.Focus()
            Return
        End If

        If cbo_nivel.SelectedIndex < 0 Then
            util.mensajes("Seleccione nivel de Familia", TITULO_MSJ, "WAR")
            Return
        End If

        If txt_codigo.Text = "" Then
            util.mensajes("Ingrese codigo de Familia", TITULO_MSJ, "WAR")
            Return
        End If

        If txt_familia.Text = "" Then
            util.mensajes("Ingrese nombre de Familia", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
        End If

        If TIPO_REGISTRO = "S" Then
            ID_LINEA_PADRE = CInt(txt_id_padre.Text)
        End If

        NIVEL = CInt(cbo_nivel.SelectedItem)
        CODIGO = txt_codigo.Text
        DESCRIPCION = txt_familia.Text


        If familia.insertar(DESCRIPCION, NIVEL, ULTIMO_NIVEL, CODIGO, ID_LINEA_PADRE, NRO_ITEM) Then
            util.mensajes("Familia registrada", TITULO_MSJ, "INF")
        Else
            util.mensajes("Familia no registrada", TITULO_MSJ, "WAR")
            Return
        End If

        btn_cancelar.Focus()
        frm_familias_materia_prima.listar_familias()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        insertar()
        Close()
    End Sub

    Private Sub btn_linea_padre_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_vista_lineas_padre
        frm.FRM_ACTIVO = "frm_nueva_familia"
        frm.Show()
    End Sub

    Private Sub txt_linea_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia_padre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_padre.Text = "" Then
                cbo_nivel.SelectedIndex = 0
                cbo_nivel.Focus()
            Else
                cbo_nivel.Focus()
            End If
        End If

    End Sub

    Private Sub cbo_nivel_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_nivel.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_nivel.SelectedIndex >= 0 Then
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo.Text.Replace(" ", "") = "" Then
            Else
                txt_familia.Focus()
            End If
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_familia.Text.Replace(" ", "") = "" Then
            Else
                chk_asentable.Focus()
            End If
        End If
    End Sub

    Private Sub chk_asentable_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_asentable.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar.Focus()
        End If
    End Sub

    Private Sub chk_asentable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_asentable.CheckedChanged
        If chk_asentable.Checked Then
            ULTIMO_NIVEL = True
        Else
            ULTIMO_NIVEL = False
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            Close()
        End If
    End Sub

End Class
