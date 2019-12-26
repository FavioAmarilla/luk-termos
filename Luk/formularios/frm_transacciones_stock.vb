Public Class frm_transacciones_stock

    Private transacciones As New func_transacciones_stock()
    Private util As New utilidades()
    Private dt_transacciones As New DataTable()

    Private TITULO_MSJ As String = "<Definicion de Transacciones de Stock>"
    Private ID_TRANSACCION As Integer = 0
    Private NOMBRE As String = ""
    Private ACCION As String = ""
    Private ACTIVO As Boolean = False
    Private RELACION As String = ""

    Private Sub frm_transacciones_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        txt_fecha_cre.Text = util.fecha()
        listar()
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        cbo_accion.Enabled = False
        cbo_relacion.Enabled = False
        chk_activo.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        cbo_accion.Enabled = True
        cbo_relacion.Enabled = True
        chk_activo.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_fecha_cre.Text = ""
        txt_nombre.Text = ""
        cbo_accion.SelectedIndex = 0
        cbo_relacion.SelectedIndex = 0
        chk_activo.Checked = False
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_transacciones.Clear()
        dt_transacciones = transacciones.listar("SELECT * FROM transacciones_stock ORDER BY fecha_cre DESC, fecha_mod DESC")

        grid_transacciones.DataSource = dt_transacciones

        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text.Replace(vbCrLf, "")
        ACCION = cbo_accion.SelectedItem.ToString()

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre de Transaccion", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If

        If cbo_relacion.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar relacion de Transaccion", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If cbo_relacion.SelectedIndex = 0 Then
            RELACION = ""
        End If
        If cbo_relacion.SelectedIndex = 1 Then
            RELACION = "EP"
        End If
        If cbo_relacion.SelectedIndex = 2 Then
            RELACION = "IP"
        End If
        If cbo_relacion.SelectedIndex = 3 Then
            RELACION = "CO"
        End If
        If cbo_relacion.SelectedIndex = 4 Then
            RELACION = "VT"
        End If

        If ID_TRANSACCION <= 0 Then
            If transacciones.insertar(NOMBRE, ACCION, ACTIVO, RELACION) Then
                util.mensajes("Transaccion de Stock Registrado", TITULO_MSJ, "INF")
                limpiar()
                desabilitar()
                btn_nuevo.Focus()
            Else
                util.mensajes("Transaccion de Stock no Registrado", TITULO_MSJ, "WAR")
            End If
        End If

        If ID_TRANSACCION > 0 Then
            If transacciones.actualizar(NOMBRE, ACCION, ACTIVO, RELACION, ID_TRANSACCION) Then
                util.mensajes("Transaccion de Stock Actualizado", TITULO_MSJ, "INF")
                limpiar()
                desabilitar()
                btn_nuevo.Focus()
            Else
                util.mensajes("Transaccion de Stock no Actualizado", TITULO_MSJ, "WAR")
            End If
        End If

        listar()
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
            ID_TRANSACCION = CInt(GridView1.GetRowCellValue(rowhandler, "id_transaccion").ToString())
            txt_fecha_cre.Text = GridView1.GetRowCellValue(rowhandler, "fecha_cre").ToString()
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandler, "nombre").ToString()
            cbo_accion.SelectedItem = GridView1.GetRowCellValue(rowhandler, "accion").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandler, "activo").ToString())

            Dim rel As String = GridView1.GetRowCellValue(rowhandler, "relacion").ToString()
            If rel = "" Then
                cbo_relacion.SelectedIndex = 0
            End If
            If rel = "EP" Then
                cbo_relacion.SelectedIndex = 1
            End If
            If rel = "IP" Then
                cbo_relacion.SelectedIndex = 2
            End If
            If rel = "VT" Then
                cbo_relacion.SelectedIndex = 3
            End If
            If rel = "CO" Then
                cbo_relacion.SelectedIndex = 4
            End If

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        txt_fecha_cre.Text = util.fecha()
        habilitar()
        ID_TRANSACCION = 0
        txt_fecha_cre.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
    End Sub

    Private Sub grid_transacciones_Click(sender As Object, e As EventArgs) Handles grid_transacciones.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_transacciones_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_transacciones.KeyDown
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

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked Then
            ACTIVO = True
        Else
            ACTIVO = False
        End If
    End Sub

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text = "" Then
            Else
                txt_nombre.Text = txt_nombre.Text.Replace(vbCrLf, "")
                cbo_accion.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_accion_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_accion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_relacion.Focus()
        End If
    End Sub

    Private Sub chk_recepcion_procuccion_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            chk_activo.Focus()
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub txt_fecha_cre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_cre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre.Focus()
        End If
    End Sub

    Private Sub cbo_relacion_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_relacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_activo.Focus()
        End If
    End Sub
End Class