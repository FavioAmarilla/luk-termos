Public Class frm_extraccion_efectivo

    Private extraccion As New func_extraccion_efectivo
    Private util As New utilidades
    Private Const TITULO_MSJ As String = "<Extraccion de Efectivo>"

    Private ID_EXTRACCION As Integer = 0
    Private ID_SUCURSAL As Integer = 0
    Private ID_CONTROL_CAJA As Integer = 0
    Private ID_USUARIO As Integer = 0
    Private NRO_DOC_BENEFICIARIO As String = ""
    Private NOMBRE_BENEFICIARIO As String = ""
    Private TOTAL_MONTO As Integer = 0
    Private OBSERVACION As String = ""

    Private Sub frm_extraccion_efectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
    End Sub

    Private Sub desabilitar()
        txt_nro_extraccion.Enabled = False
        txt_sucursal.Enabled = False
        txt_id_control_caja.Enabled = False
        txt_usuario.Enabled = False
        txt_fecha.Enabled = False
        txt_nro_doc_beneficiario.Enabled = False
        txt_beneficiario.Enabled = False
        txt_total_monto.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nro_extraccion.Enabled = True
        txt_sucursal.Enabled = True
        txt_id_control_caja.Enabled = True
        txt_usuario.Enabled = True
        txt_fecha.Enabled = True
        txt_nro_doc_beneficiario.Enabled = True
        txt_beneficiario.Enabled = True
        txt_total_monto.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nro_extraccion.Text = ""
        txt_sucursal.Text = ""
        txt_id_control_caja.Text = ""
        txt_usuario.Text = ""
        txt_fecha.Text = ""
        txt_nro_doc_beneficiario.Text = ""
        txt_beneficiario.Text = ""
        txt_total_monto.Text = ""
    End Sub

    Private Function identificador() As Integer
        Dim dt As New DataTable
        dt = extraccion.consultar("SELECT last_value + increment_by FROM extraccion_efectivo_id_extraccion_seq")

        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0).Item(0))
        Else
            Return 1
        End If
    End Function


    Private Sub cargarDatos()
        txt_nro_extraccion.Text = CStr(identificador())
        txt_sucursal.Text = frm_main.SUCURSAL
        txt_id_control_caja.Text = CStr(frm_ventas.ID_CONTROL_CAJA)
        txt_usuario.Text = frm_main.NOMBRE_USER
        txt_fecha.Text = util.fecha()
    End Sub

    Private Sub insertar()
        If txt_nro_doc_beneficiario.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar Nro. de Doc. del Beneficiario", TITULO_MSJ, "WAR")
            txt_nro_doc_beneficiario.Focus()
            Return
        End If
        If txt_beneficiario.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar Nombre del Beneficiario", TITULO_MSJ, "WAR")
            txt_beneficiario.Focus()
            Return
        End If
        If txt_total_monto.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar Monto de Extraccion", TITULO_MSJ, "WAR")
            txt_total_monto.Focus()
            Return
        End If
        If util.msj_confirmacion("Deseas Confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        ID_SUCURSAL = frm_main.ID_SUCURSAL
        ID_CONTROL_CAJA = CInt(txt_id_control_caja.Text)
        ID_USUARIO = frm_main.ID_USUARIO
        NRO_DOC_BENEFICIARIO = txt_nro_doc_beneficiario.Text
        NOMBRE_BENEFICIARIO = txt_beneficiario.Text
        TOTAL_MONTO = CInt(txt_total_monto.Text)
        OBSERVACION = txt_observacion.Text.Replace(vbCrLf, " ")

        If extraccion.insertar(ID_SUCURSAL, ID_CONTROL_CAJA, ID_USUARIO, NRO_DOC_BENEFICIARIO, NOMBRE_BENEFICIARIO, TOTAL_MONTO, OBSERVACION) = False Then
            util.mensajes("Extraccion no Registrada", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Extraccion Registrada", TITULO_MSJ, "INF")
        limpiar()
        desabilitar()
        Close()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        cargarDatos()
        txt_nro_doc_beneficiario.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            Close()
        End If
        
    End Sub

    Private Sub txt_nro_doc_beneficiario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_doc_beneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_doc_beneficiario.Text.Replace(" ", "") = "" Then
            Else
                txt_beneficiario.Focus()
            End If
        End If
    End Sub

    Private Sub txt_beneficiario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_beneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_beneficiario.Text.Replace(" ", "") = "" Then
            Else
                txt_total_monto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_total_monto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_total_monto.Text.Replace(" ", "") = "" Then
            Else
                If CInt(txt_total_monto.Text) > 0 Then
                    txt_observacion.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txt_observacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_observacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

End Class