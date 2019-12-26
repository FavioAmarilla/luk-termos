Public Class frm_vuelto
    Private Sub frm_vuelto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub setVuelto(vuelto As String)
        txt_vuelto.Text = vuelto
        btn_aceptar.Focus()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        frm_cobros_caja.cerrar()
        frm_ventas.inicializar()
        Close()
        frm_ventas.Focus()
    End Sub

End Class