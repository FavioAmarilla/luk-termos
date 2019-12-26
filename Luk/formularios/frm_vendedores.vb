Public Class frm_vendedores

    Private vendedor As New func_vendedores()
    Private util As New utilidades()
    Private dt_vendedores As New DataTable()

    Private TITULO_MSJ As String = "<<Registro de Vendedores>"
    Private ID_VENDEDOR As Integer = 0
    Private NOMBRES As String = ""
    Private APELLIDOS As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""
    Private CORREO As String = ""
    Private COMISION As Integer = 0
    Private ACTIVO As Boolean = False

    Private Sub frm_vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        txt_telefono.Enabled = False
        txt_correo.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        txt_telefono.Enabled = True
        txt_correo.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""
        txt_comision.Text = ""
        chk_activo.Checked = False
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_vendedores = vendedor.listar("SELECT * FROM vendedores ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_vendedores.DataSource = dt_vendedores
    End Sub

    Private Sub insertar_actualizar()
        NOMBRES = txt_nombres.Text
        APELLIDOS = txt_apellidos.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text
        TELEFONO = txt_telefono.Text
        CORREO = txt_correo.Text
        COMISION = CInt(txt_comision.Text)

        If NOMBRES = "" Then
            util.mensajes("Ingrese nombre del usuario", TITULO_MSJ, "WAR")
            txt_nombres.Focus()
        ElseIf APELLIDOS = "" Then
            util.mensajes("Ingrese apellido del usuario", TITULO_MSJ, "WAR")
            txt_nombres.Focus()
        ElseIf CIUDAD = "" Then
            util.mensajes("Ingrese ciudad del usuario", TITULO_MSJ, "WAR")
            txt_ciudad.Focus()
        ElseIf DIRECCION = "" Then
            util.mensajes("Ingrese direccion del usuario", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf TELEFONO = "" Then
            util.mensajes("Ingrese nro. de telefono de la empresa", TITULO_MSJ, "WAR")
            txt_telefono.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_VENDEDOR < 1 Then
                    If vendedor.insertar(NOMBRES, APELLIDOS, TELEFONO, DIRECCION, CIUDAD, CORREO, COMISION, ACTIVO) Then
                        util.mensajes("Vendedor registrado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Vendedor no registrado", TITULO_MSJ, "WAR")
                    End If
                End If

                If ID_VENDEDOR > 0 Then
                    If vendedor.actualizar(NOMBRES, APELLIDOS, TELEFONO, DIRECCION, CIUDAD, CORREO, ID_VENDEDOR, COMISION, ACTIVO) Then
                        util.mensajes("Vendedor actualizado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Vendedor no actualizado", TITULO_MSJ, "WAR")
                    End If
                End If
                listar()
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "INF")
            End If
        End If
    End Sub

    Private Sub cargar_fila(ByVal accion As String)
        Dim rowhandle As Integer = 0
        If accion = "up" Then
            rowhandle = GridView1.FocusedRowHandle() - 1
        End If
        If accion = "down" Then
            rowhandle = GridView1.FocusedRowHandle() + 1
        End If
        If accion = "enter" Then
            rowhandle = GridView1.FocusedRowHandle()
        End If

        If rowhandle >= 0 And rowhandle < GridView1.RowCount() Then
            ID_VENDEDOR = CInt(GridView1.GetRowCellValue(rowhandle, "id_vendedor").ToString())
            txt_nombres.Text = GridView1.GetRowCellValue(rowhandle, "nombres").ToString()
            txt_apellidos.Text = GridView1.GetRowCellValue(rowhandle, "apellidos").ToString()
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString()
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString()
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString()
            txt_correo.Text = GridView1.GetRowCellValue(rowhandle, "correo").ToString()
            txt_comision.Text = GridView1.GetRowCellValue(rowhandle, "porcentaje_comision").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandle, "activo").ToString)

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_VENDEDOR = 0
        txt_nombres.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_vendedores_Click(sender As Object, e As EventArgs) Handles grid_vendedores.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_vendedores_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_vendedores.KeyDown
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

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
       If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
        End If
    End Sub

    Private Sub txt_nombres_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombres.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombres.Text.Replace(" ", "") = "" Then
            Else
                txt_apellidos.Focus()
            End If
        End If
    End Sub

    Private Sub txt_apellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_apellidos.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_apellidos.Text.Replace(" ", "") = "" Then
            Else
                txt_ciudad.Focus()
            End If
        End If
    End Sub

    Private Sub txt_ciudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ciudad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ciudad.Text.Replace(" ", "") = "" Then
            Else
                txt_direccion.Focus()
            End If
        End If
    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_direccion.Text.Replace(" ", "") = "" Then
            Else
                txt_telefono.Focus()
            End If
        End If
    End Sub

    Private Sub txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_telefono.Text.Replace(" ", "") = "" Then
            Else
                txt_correo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_correo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_correo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_comision.Focus()
        End If
    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked Then
            ACTIVO = True
        Else
            ACTIVO = False
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub txt_comision_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_comision.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            chk_activo.Focus()
        End If
    End Sub
End Class