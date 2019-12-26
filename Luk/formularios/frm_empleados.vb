Public Class frm_empleados
    Dim empleado As New func_empleados()
    Dim util As New utilidades()
    Dim dt_empleados As New DataTable()

    Private Const TITULO_MSJ As String = "<<Registro de Empleados>"
    Private ID_EMPLEADO As Integer = 0
    Private NOMBRES As String = ""
    Private APELLIDOS As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""
    Private ACTIVO As Boolean


    Private Sub frm_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_telefono.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        btn_confirmar.Enabled = False
        CheckEdit1.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_telefono.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        btn_confirmar.Enabled = True
        CheckEdit1.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_telefono.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        btn_confirmar.Text = "Registrar"
        CheckEdit1.Checked = False
    End Sub

    Private Sub listar()
        dt_empleados = empleado.listar("SELECT * FROM empleados ORDER BY fecha_cre DESC,  fecha_mod DESC")
        grid_empleados.DataSource = dt_empleados
    End Sub

    Private Sub insertar_actualizar()
        NOMBRES = txt_nombres.Text
        APELLIDOS = txt_apellidos.Text
        TELEFONO = txt_telefono.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text
        ACTIVO = CheckEdit1.Checked


        If NOMBRES = "" Then
            util.mensajes("Ingrese nombre/s del empleado", TITULO_MSJ, "WAR")
            txt_nombres.Focus()
        ElseIf APELLIDOS = "" Then
            util.mensajes("Ingrese apellido del empleado", TITULO_MSJ, "WAR")
            txt_apellidos.Focus()
        ElseIf TELEFONO = "" Then
            util.mensajes("Ingrese telefono del empleado", TITULO_MSJ, "WAR")
            txt_telefono.Focus()
        ElseIf DIRECCION = "" Then
            util.mensajes("Ingrese direccion del empleado", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_EMPLEADO <= 0 Then
                    If empleado.insertar(NOMBRES, APELLIDOS, TELEFONO, CIUDAD, DIRECCION, ACTIVO) Then
                        util.mensajes("Empleado Registrado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Empleado no Registrado", TITULO_MSJ, "WAR")
                    End If
                Else
                    If empleado.actualizar(NOMBRES, APELLIDOS, TELEFONO, CIUDAD, DIRECCION, ID_EMPLEADO, ACTIVO) Then
                        util.mensajes("Empleado Actualizado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Empleado no Actualizado", TITULO_MSJ, "WAR")
                    End If
                End If
                listar()
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
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
            ID_EMPLEADO = CInt(GridView1.GetRowCellValue(rowhandle, "id_empleado").ToString())
            txt_nombres.Text = GridView1.GetRowCellValue(rowhandle, "nombres").ToString()
            txt_apellidos.Text = GridView1.GetRowCellValue(rowhandle, "apellidos").ToString()
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString()
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString()
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString()
            CheckEdit1.Checked = Convert.ToBoolean(GridView1.GetRowCellValue(rowhandle, "activo").ToString())


            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_EMPLEADO = 0
        txt_nombres.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_empleados_Click(sender As Object, e As EventArgs) Handles grid_empleados.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_empleados_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_empleados.KeyDown
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
                txt_telefono.Focus()
            End If
        End If
    End Sub

    Private Sub txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_telefono.Text.Replace(" ", "") = "" Then
            Else
                txt_ciudad.Focus()
            End If
        End If
    End Sub

    Private Sub txt_ciudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ciudad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Focus()
        End If
    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_direccion.Text.Replace(" ", "") = "" Then
            Else
                CheckEdit1.Focus()
            End If
        End If
    End Sub

    Private Sub CheckEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles CheckEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub
End Class