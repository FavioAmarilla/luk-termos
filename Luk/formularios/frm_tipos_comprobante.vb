Public Class frm_tipos_comprobante

    Private tipos_comprobantes As New func_tipos_comprobante()
    Private util As New utilidades()
    Private dt_tipos_comprobantes As New DataTable()

    Private TITULO_MSJ As String = "<Definicion de Tipos de Comprobantes>"
    Private ID_TIPO_COMPROBANTE As Integer = 0
    Private NOMBRE As String = ""
    Private ACTIVO As Boolean = False

    Private Sub frm_tipos_comprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        txt_fecha_cre.Text = util.fecha()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        chk_activo.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
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
        dt_tipos_comprobantes.Clear()
        dt_tipos_comprobantes = tipos_comprobantes.listar("SELECT * FROM tipos_comprobante ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_tipos_comprobante.DataSource = dt_tipos_comprobantes
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text.Replace(vbCrLf, "")
        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre de Tipos de Comprobante", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_TIPO_COMPROBANTE <= 0 Then
                    If tipos_comprobantes.insertar(NOMBRE, ACTIVO) Then
                        util.mensajes("Tipos de Comprobante Registrado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Tipos de Comprobante no Registrado", TITULO_MSJ, "WAR")
                    End If
                Else
                    If tipos_comprobantes.actualizar(NOMBRE, ACTIVO, ID_TIPO_COMPROBANTE) Then
                        util.mensajes("Tipos de Comprobante Actualizado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Tipos de Comprobante no Actualizado", TITULO_MSJ, "WAR")
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
            ID_TIPO_COMPROBANTE = CInt(GridView1.GetRowCellValue(rowhandler, "id_tipo_comprobante").ToString())
            txt_fecha_cre.Text = GridView1.GetRowCellValue(rowhandler, "fecha_cre").ToString()
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandler, "nombre").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandler, "activo").ToString())

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_TIPO_COMPROBANTE = 0
        txt_fecha_cre.Text = util.fecha()
        txt_fecha_cre.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_tipos_comprobante_Click(sender As Object, e As EventArgs) Handles grid_tipos_comprobante.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_tipos_comprobante_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_tipos_comprobante.KeyDown
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
            If txt_nombre.Text.Replace(" ", "") = "" Then
                txt_nombre.Text = txt_nombre.Text.Replace(vbCrLf, "")
                chk_activo.Focus()
            End If
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
End Class