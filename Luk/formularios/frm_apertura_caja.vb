Public Class frm_apertura_caja

    Private control As New func_control_caja
    Private util As New utilidades
    Private Const TITULO_MSJ As String = "<Apertura de Caja>"

    Private ID_USUARIO As Integer = 0
    Private TRANS_INICIAL As String = ""
    Private COMENTARIO As String = ""
    Private MONTO_INICIAL As Integer = 0

    Private Sub frm_apertura_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Private Sub inicializar()
        txt_nro_apertura.Text = CStr(control.id_control())
        txt_fecha.Text = Now.ToString("dd/MM/yyyy")
        txt_empresa.Text = frm_main.EMPRESA
        txt_sucursal.Text = frm_main.SUCURSAL
        txt_usuario.Text = frm_main.NOMBRE_USER
        txt_trans_inicial.Text = CStr(control.trans_inicial())
    End Sub

    Private Sub insertar()
        TRANS_INICIAL = txt_trans_inicial.Text
        COMENTARIO = txt_comentario.Text
        If txt_monto_inicial.Text.Replace(" ", "") = "" Then
            MONTO_INICIAL = 0
        Else
            MONTO_INICIAL = CInt(txt_monto_inicial.Text)
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Apertura de caja no realizada", TITULO_MSJ, "INF")
            Return
        End If

        If control.apertura_caja(frm_main.ID_USUARIO, TRANS_INICIAL, COMENTARIO, MONTO_INICIAL) Then
            util.mensajes("Apertura de Caja realizada", TITULO_MSJ, "INF")
            btn_registrar.Enabled = False
            Close()
        End If

    End Sub

    Private Sub txt_trans_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_trans_inicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_trans_final.Focus()
        End If
    End Sub

    Private Sub txt_trans_final_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_trans_final.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_monto_inicial.Focus()
        End If
    End Sub

    Private Sub txt_monto_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_monto_inicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_comentario.Focus()
        End If
    End Sub

    Private Sub txt_comentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_registrar.Focus()
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        insertar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            Close()
        End If
    End Sub

End Class