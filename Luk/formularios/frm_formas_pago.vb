Public Class frm_formas_pago
    Private forma_pago As New func_formas_pago()
    Private util As New utilidades()
    Private dt_forma_pago As New DataTable()

    Private TITULO_MSJ As String = "<<Definicion de Formas de Pago>"
    Private ID_FORMA_PAGO As Integer = 0
    Private NOMBRE As String = ""
    Private ACTIVO As Boolean = False
    Private TIPO_PAGO As String = ""

    Private Sub frm_formas_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        txt_fecha_cre.Text = util.fecha()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_fecha_cre.Enabled = False
        txt_nombre.Enabled = False
        chk_activo.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_fecha_cre.Enabled = True
        txt_nombre.Enabled = True
        chk_activo.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_fecha_cre.Text = ""
        txt_nombre.Text = ""
        chk_activo.Checked = False
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_forma_pago.Clear()
        dt_forma_pago = forma_pago.listar("SELECT * FROM formas_pago ORDER BY fecha_cre DESC, fecha_mod DESC")

        grid_formas_pago.DataSource = dt_forma_pago
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text
        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre de Forma de Pago", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf cbo_tipo_pago.SelectedIndex < 0 Then
            util.mensajes("Ingrese Tipo de pago", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        Else
            If cbo_tipo_pago.SelectedIndex = 0 Then
                TIPO_PAGO = "EF"
            End If
            If cbo_tipo_pago.SelectedIndex = 1 Then
                TIPO_PAGO = "TR"
            End If
            If cbo_tipo_pago.SelectedIndex = 2 Then
                TIPO_PAGO = "DC"
            End If
            If cbo_tipo_pago.SelectedIndex = 3 Then
                TIPO_PAGO = "RE"
            End If
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_FORMA_PAGO <= 0 Then
                    If forma_pago.insertar(NOMBRE, ACTIVO, TIPO_PAGO) Then
                        util.mensajes("Forma de Pago Registrada", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Forma de Pago no Registrada", TITULO_MSJ, "WAR")
                    End If
                Else
                    If forma_pago.actualizar(NOMBRE, ACTIVO, TIPO_PAGO, ID_FORMA_PAGO) Then
                        util.mensajes("Forma de Pago Actualizada", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Forma de Pago no Actualizada", TITULO_MSJ, "WAR")
                    End If
                End If
                listar()
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            End If
        End If
    End Sub

    Private Sub cargar_fila(ByVal accion As String)
        Dim rowhandler As Integer = 0
        If accion = "up" Then
            rowhandler = GridView1.FocusedRowHandle() - 1
        End If
        If accion = "down" Then
            rowhandler = GridView1.FocusedRowHandle() + 1
        End If
        If accion = "enter" Then
            rowhandler = GridView1.FocusedRowHandle()
        End If

        If rowhandler >= 0 And rowhandler < GridView1.RowCount() Then
            ID_FORMA_PAGO = CInt(GridView1.GetRowCellValue(rowhandler, "id_forma_pago").ToString())
            txt_fecha_cre.Text = GridView1.GetRowCellValue(rowhandler, "fecha_cre").ToString()
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandler, "nombre").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandler, "activo").ToString())

            If GridView1.GetRowCellValue(rowhandler, "tipo_pago").ToString() = "EF" Then
                cbo_tipo_pago.SelectedIndex = 0
            End If

            If GridView1.GetRowCellValue(rowhandler, "tipo_pago").ToString() = "TR" Then
                cbo_tipo_pago.SelectedIndex = 1
            End If

            If GridView1.GetRowCellValue(rowhandler, "tipo_pago").ToString() = "DC" Then
                cbo_tipo_pago.SelectedIndex = 2
            End If
            If GridView1.GetRowCellValue(rowhandler, "tipo_pago").ToString() = "RE" Then
                cbo_tipo_pago.SelectedIndex = 3
            End If

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_FORMA_PAGO = 0
        txt_fecha_cre.Text = util.fecha
        txt_nombre.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_formas_pago_Click(sender As Object, e As EventArgs) Handles grid_formas_pago.Click
        cargar_fila("enter")
    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked Then
            ACTIVO = True
        Else
            ACTIVO = False
        End If
    End Sub

    Private Sub grid_formas_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_formas_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar_fila("enter")
        End If
        If e.KeyCode = Keys.Up Then
            cargar_fila("up")
        End If
        If e.KeyCode = Keys.Down Then
            cargar_fila("down")
        End If
    End Sub

    Private Sub txt_fecha_cre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_cre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre.Focus()
        End If
    End Sub

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text.Replace(" ", "") = "" Then
            Else
                cbo_tipo_pago.SelectedIndex = -1
                cbo_tipo_pago.Focus()
            End If
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_pago.SelectedIndexChanged
        If cbo_tipo_pago.SelectedIndex = 0 Then
            TIPO_PAGO = "EF"
        End If
        If cbo_tipo_pago.SelectedIndex = 1 Then
            TIPO_PAGO = "TR"
        End If
        If cbo_tipo_pago.SelectedIndex = 2 Then
            TIPO_PAGO = "DC"
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
         If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_pago.SelectedIndex >= 0 Then
                chk_activo.Focus()
            End If
        End If
    End Sub
End Class