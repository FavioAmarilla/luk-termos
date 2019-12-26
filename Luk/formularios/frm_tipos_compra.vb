Public Class frm_tipos_compra

    Private tipos_compra As New func_tipos_compra()
    Private util As New utilidades()
    Private dt_tipos_compra As New DataTable()

    Private TITULO_MSJ As String = "<Definicion de Tipos de Compra>"
    Private ID_TIPO_COMPRA As Integer = 0
    Private NOMBRE As String = ""
    Private ACTIVO As Boolean = False
    Private RELACION As String = ""
    Private REQUIERE_ITEM As Boolean = False

    Private Sub frm_tipos_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        txt_fecha_cre.Text = util.fecha()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        chk_activo.Enabled = False
        cbo_relacion.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        chk_activo.Enabled = True
        cbo_relacion.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_fecha_cre.Text = ""
        txt_nombre.Text = ""
        chk_activo.Checked = False
        chk_requiere_item.Checked = False
        cbo_relacion.SelectedIndex = -1
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_tipos_compra.Clear()
        dt_tipos_compra = tipos_compra.listar("SELECT * FROM tipos_compra ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_tipos_compra.DataSource = dt_tipos_compra
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text.Replace(vbCrLf, "")

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre del Tipo de Compra", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If

        If cbo_relacion.SelectedIndex < 0 Then
            util.mensajes("Seleccione relacion del Tipo de Compra", TITULO_MSJ, "WAR")
            cbo_relacion.Focus()
            Return
        End If
        RELACION = cbo_relacion.SelectedItem().ToString()

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If chk_requiere_item.Checked Then
            REQUIERE_ITEM = True
        Else
            REQUIERE_ITEM = False
        End If

        If ID_TIPO_COMPRA <= 0 Then
            If tipos_compra.insertar(NOMBRE, ACTIVO, RELACION, REQUIERE_ITEM) Then
                util.mensajes("Tipo de Compra Registrada", TITULO_MSJ, "INF")
                limpiar()
                desabilitar()
                btn_nuevo.Focus()
            Else
                util.mensajes("Tipo de Compra no Registrada", TITULO_MSJ, "WAR")
            End If
        Else
            If tipos_compra.actualizar(NOMBRE, ACTIVO, RELACION, ID_TIPO_COMPRA, REQUIERE_ITEM) Then
                util.mensajes("Tipo de Compra Actualizada", TITULO_MSJ, "INF")
                limpiar()
                desabilitar()
                btn_nuevo.Focus()
            Else
                util.mensajes("Tipo de Compra no Actualizada", TITULO_MSJ, "WAR")
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
            ID_TIPO_COMPRA = CInt(GridView1.GetRowCellValue(rowhandler, "id_tipo_compra").ToString())
            txt_fecha_cre.Text = GridView1.GetRowCellValue(rowhandler, "fecha_cre").ToString()
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandler, "nombre").ToString()
            cbo_relacion.SelectedItem = GridView1.GetRowCellValue(rowhandler, "relacion").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandler, "activo").ToString())
            chk_requiere_item.Checked = CBool(GridView1.GetRowCellValue(rowhandler, "requiere_item").ToString())
            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_TIPO_COMPRA = 0
        txt_fecha_cre.Text = util.fecha
        txt_fecha_cre.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_tipos_compra_Click(sender As Object, e As EventArgs) Handles grid_tipos_compra.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_tipos_compra_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_tipos_compra.KeyDown
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


    Private Sub txt_fecha_cre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_cre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre.Focus()
        End If
    End Sub

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nombre.Text = txt_nombre.Text.Replace(vbCrLf, "")
            cbo_relacion.Focus()
        End If
    End Sub

    Private Sub cbo_relacion_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_relacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_activo.Focus()
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_requiere_item.Focus()
        End If
    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub chk_requiere_item_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_requiere_item.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub
End Class