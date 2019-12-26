Public Class frm_clientes

    Private Const TITULO_MSJ = "<Registro de Clientes>"

    Private ID_CLIENTE As Integer = 0
    Private NOMBRES As String = ""
    Private APELLIDOS As String = ""
    Private NRO_DOCUMENTO As String = ""
    Private TELEFONO As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""

    Dim dt_clientes As New DataTable()
    Dim cliente As New func_clientes()
    Dim util As New utilidades()

    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        listar()
        limpiar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub desabilitar()
        txt_nombres.Enabled = False
        txt_apellidos.Enabled = False
        txt_nro_documeto.Enabled = False
        txt_telefono.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Public Sub habilitar()
        txt_nombres.Enabled = True
        txt_apellidos.Enabled = True
        txt_nro_documeto.Enabled = True
        txt_telefono.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Public Sub limpiar()
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_nro_documeto.Text = ""
        txt_telefono.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        btn_confirmar.Text = "Registrar"
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_clientes = cliente.listar("SELECT * FROM clientes ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_clientes.DataSource = dt_clientes
    End Sub

    Public Sub insertar_actualizar()
        NOMBRES = txt_nombres.Text
        APELLIDOS = txt_apellidos.Text
        NRO_DOCUMENTO = txt_nro_documeto.Text
        TELEFONO = txt_telefono.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text

        If NOMBRES = "" Then
            util.mensajes("Ingrese nombre/s del cliente", TITULO_MSJ, "WAR")
            txt_nombres.Focus()
        ElseIf NRO_DOCUMENTO = "" Then
            util.mensajes("Ingrese numero de documento del cliente", TITULO_MSJ, "WAR")
            txt_nro_documeto.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_CLIENTE <= 0 Then
                    If cliente.insertar(NOMBRES, APELLIDOS, NRO_DOCUMENTO, TELEFONO, CIUDAD, DIRECCION) Then
                        util.mensajes("Cliente Registrado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Cliente no Registrado", TITULO_MSJ, "WAR")
                    End If
                End If

                If ID_CLIENTE > 0 Then
                    If cliente.actualizar(NOMBRES, APELLIDOS, NRO_DOCUMENTO, TELEFONO, CIUDAD, DIRECCION, ID_CLIENTE) Then
                        util.mensajes("Cliente Actualizado", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Cliente no Actualizado", TITULO_MSJ, "WAR")
                    End If
                End If
                listar()
            Else
                util.mensajes("Operacion no Confirmada", TITULO_MSJ, "WAR")
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
            ID_CLIENTE = CInt(GridView1.GetRowCellValue(rowhandle, "id_cliente").ToString())
            txt_nombres.Text = GridView1.GetRowCellValue(rowhandle, "nombres").ToString()
            txt_apellidos.Text = GridView1.GetRowCellValue(rowhandle, "apellidos").ToString()
            txt_nro_documeto.Text = GridView1.GetRowCellValue(rowhandle, "numero_documento").ToString()
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString()
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString()
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString()

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Public Sub obtener_cliente(nro_documento As String)
        Dim dt As New DataTable
        dt = cliente.listar("SELECT id_cliente, nombres, apellidos, numero_documento, telefono, ciudad, direccion FROM clientes WHERE numero_documento='" + nro_documento + "'")

        If dt.Rows.Count > 0 Then
            ID_CLIENTE = CInt(dt.Rows(0).Item(0))
            txt_nombres.Text = CStr(dt.Rows(0).Item(1))
            txt_apellidos.Text = CStr(dt.Rows(0).Item(2))
            txt_nro_documeto.Text = CStr(dt.Rows(0).Item(3))
            txt_telefono.Text = CStr(dt.Rows(0).Item(4))
            txt_ciudad.Text = CStr(dt.Rows(0).Item(5))
            txt_direccion.Text = CStr(dt.Rows(0).Item(6))
        Else
            ID_CLIENTE = 0
            txt_nombres.Text = ""
            txt_apellidos.Text = ""
            txt_telefono.Text = ""
            txt_ciudad.Text = ""
            txt_direccion.Text = ""
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If util.msj_confirmacion("Deseas registrar un nuevo cliente", TITULO_MSJ) = False Then
            Return
        End If
        limpiar()
        habilitar()
        ID_CLIENTE = 0
        txt_nro_documeto.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_clientes_Click(sender As Object, e As EventArgs) Handles grid_clientes.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_clientes.KeyDown
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

    Private Sub txt_nro_documeto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_documeto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_documeto.Text.Replace(" ", "") = "" Then
            Else
                obtener_cliente(txt_nro_documeto.Text)
                txt_nombres.Focus()
            End If
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
            txt_telefono.Focus()
        End If
    End Sub

    Private Sub txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ciudad.Focus()
        End If
    End Sub

    Private Sub txt_ciudad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ciudad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Focus()
        End If
    End Sub
    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Asignacion") Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub
End Class