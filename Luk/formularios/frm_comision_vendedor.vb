Public Class frm_comision_vendedor

    Dim func_vendedor As New func_vendedores
    Public id_vendedor As Integer = 0
    Dim util As New utilidades
    Dim total_venta As Integer = 0

    Private Sub frm_comision_vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub set_total_venta(value As Integer)
        total_venta = value
    End Sub

    Public Sub obtener_vendedor(ByVal id As Integer)
        Dim dt_vendedor As New DataTable()
        dt_vendedor = func_vendedor.listar("SELECT id_vendedor, CONCAT(nombres,' ',apellidos) AS vendedor FROM vendedores WHERE id_vendedor=" + Trim(id.ToString()) + "")

        If dt_vendedor.Rows.Count <> 0 Then
            id_vendedor = CInt(dt_vendedor.Rows(0).Item(0))
            txt_vendedor.Text = CStr(dt_vendedor.Rows(0).Item(1))
            txt_vendedor.Focus()
        Else
            util.mensajes("Vendedor no definido", "Comision de vendedor", "WAR")
            txt_vendedor.Focus()
        End If
    End Sub

    Sub obtener_comision()
        Dim porcentaje As Double = 0
        Dim comision As Integer = 0

        If txt_porc_comision.Text IsNot "" Then
            porcentaje = CDbl(txt_porc_comision.Text)
        End If

        comision = (total_venta * porcentaje) / 100

        txt_comision.Text = CInt(comision)
    End Sub

    Sub obtener_porcentaje()
        Dim porcentaje As Double = 0
        Dim comision As Integer = 0

        If txt_comision.Text IsNot "" Then
            comision = CDbl(txt_comision.Text)
        End If

        porcentaje = (comision * 100) / total_venta

        txt_porc_comision.Text = CDbl(porcentaje)
    End Sub

    Sub enviar_datos()
        If txt_comision.Text = "" Then
            util.mensajes("Debe ingresar comision de vendedor", "Comision", "WAR")
            Return
        End If

        If txt_vendedor.Text = "" Then
            util.mensajes("DEbe seleccionar vendedor", "Comision", "WAR")
            Return
        End If

        frm_ventas.set_comision(CInt(txt_comision.Text))
        frm_ventas.set_id_vendedor(id_vendedor)

        Close()
    End Sub


    Private Sub btn_vendedores_Click(sender As Object, e As EventArgs) Handles btn_vendedores.Click
        Dim frm As New frm_vista_vendedores
        frm.FRM_ACTIVO = "frm_comision_vendedor"
        frm.Show()
    End Sub

    Private Sub txt_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vendedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_vendedores
            frm.FRM_ACTIVO = "frm_comision_vendedor"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_vendedor.Text IsNot "" Then
                txt_porc_comision.Focus()
            End If
        End If
    End Sub

    Private Sub txt_porc_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_porc_comision.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            obtener_comision()
            txt_comision.Focus()
        End If
    End Sub

    Private Sub txt_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comision.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            obtener_porcentaje()
            btn_aceptar.Focus()
        End If
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        enviar_datos()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

End Class