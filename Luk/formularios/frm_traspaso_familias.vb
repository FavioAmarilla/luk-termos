Public Class frm_traspaso_familias

    Private familia As New func_familias
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Traspaso de Articulos>"

    Private Sub frm_traspaso_familias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_linea.Focus()
    End Sub

    Public Sub obtener_linea_padre(id As String)
        Dim dt As DataTable
        dt = familia.listar("SELECT identificador, descripcion FROM familias WHERE identificador='" + id + "'")

        txt_id_linea_padre.Text = CStr(dt.Rows(0).Item(0))
        txt_linea.Text = CStr(dt.Rows(0).Item(1))
    End Sub

    Public Sub obtener_familia(id As String)
        Dim dt As DataTable
        dt = familia.listar("SELECT identificador, descripcion FROM familias WHERE identificador='" + id + "'")

        txt_id_familia.Text = CStr(dt.Rows(0).Item(0))
        txt_familia.Text = CStr(dt.Rows(0).Item(1))

    End Sub

    Private Sub traspaso()
        If txt_id_linea_padre.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione nueva Linea Padre", TITULO_MSJ, "WAR")
            txt_linea.Focus()
            Return
        End If

        If txt_id_familia.Text.Replace(" ", "") = "" Then
            util.mensajes("Seleccione familia actual", TITULO_MSJ, "WAR")
            txt_linea.Focus()
            Return
        End If

        If txt_id_familia.Text = txt_linea.Text Then
            util.mensajes("Linea Padre no debe ser igual a Familia actual", TITULO_MSJ, "WAR")
            txt_linea.Focus()
            Return
        End If

        If util.msj_confirmacion("Esta Seguro que desea realizar el traspaso", TITULO_MSJ) Then
            If familia.actualizar_familia_articulo(CInt(txt_id_linea_padre.Text), CInt(txt_id_familia.Text)) Then
                util.mensajes("Traspaso realizado", TITULO_MSJ, "INF")
                frm_familias.listar_familias()
                Close()
            Else
                util.mensajes("Traspaso no realizado", TITULO_MSJ, "WAR")
            End If
        End If

    End Sub

    Private Sub btn_buscar_linea_padre_Click(sender As Object, e As EventArgs) Handles btn_buscar_linea_padre.Click
        Dim frm As New frm_vista_familias
        frm.FRM_ACTIVO = "frm_traspaso_familias"
        frm.Show()
    End Sub

    Private Sub txt_linea_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_linea.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_familias
            frm.FRM_ACTIVO = "frm_traspaso_familias"
            frm.Show()
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_id_linea_padre.Text.Replace(" ", "") = "" Then
            Else
                txt_familia.Focus()
            End If
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_id_familia.Text.Replace(" ", "") = "" Then
            Else
                btn_agregar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        traspaso()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            Close()
        End If
    End Sub

End Class