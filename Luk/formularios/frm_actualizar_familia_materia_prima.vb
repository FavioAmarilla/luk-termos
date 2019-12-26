Public Class frm_actualizar_familia_materia_prima

    Private familia_materia_prima As New func_familias_materia_prima
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Actualizacion de Familias>"

    'Variables para las operaciones sobre la tabla familias
    Private IDENTIFICADOR As Integer = 0
    Private ULTIMO_NIVEL As Boolean = False

    Private Sub frm_actualizar_familia_materia_prima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_familia.Focus()
    End Sub

    Public Sub obtener_familia(codigo As String)
        Dim dt As DataTable
        dt = familia_materia_prima.listar("SELECT identificador, descripcion, nivel, codigo, ultimo_nivel FROM familias_materia_prima WHERE codigo='" + codigo + "'")

        txt_id_padre.Text = CStr(dt.Rows(0).Item(0))
        txt_familia.Text = CStr(dt.Rows(0).Item(1))
        cbo_nivel.SelectedItem = CStr(dt.Rows(0).Item(2))
        txt_codigo.Text = CStr(dt.Rows(0).Item(3))
        chk_asentable.Checked = CBool(dt.Rows(0).Item(4))
    End Sub

    Private Sub actualizar()
        If txt_id_padre.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar una familia para actualizar", TITULO_MSJ, "WAR")
            Return
        Else
            IDENTIFICADOR = CInt(txt_id_padre.Text)
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If familia_materia_prima.actualizar(ULTIMO_NIVEL, IDENTIFICADOR, txt_familia.Text) Then
            util.mensajes("Familia Actualizada", TITULO_MSJ, "INF")
            frm_familias_materia_prima.listar_familias()
            Close()
        Else
            util.mensajes("Familia no Actualizada", TITULO_MSJ, "INF")
        End If
    End Sub

    Private Sub txt_linea_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cbo_nivel.Focus()
        End If
    End Sub

    Private Sub cbo_nivel_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_nivel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_asentable.Focus()
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_familia.Text.Replace(" ", "") = "" Then
            Else
                cbo_nivel.Focus()
            End If
        End If
    End Sub

    Private Sub chk_asentable_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_asentable.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar.Focus()
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        actualizar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            Close()
        End If
    End Sub

    Private Sub chk_asentable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_asentable.CheckedChanged
        If chk_asentable.Checked Then
            ULTIMO_NIVEL = True
        Else
            ULTIMO_NIVEL = False
        End If
    End Sub

End Class