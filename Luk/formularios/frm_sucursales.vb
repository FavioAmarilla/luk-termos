Public Class frm_sucursales

    Private sucursales As New func_sucursales()
    Private util As New func_sucursales()
    Private dt_sucursales As New DataTable()
    Private dt_empresas As New DataTable()

    Private Const TITULO_MSJ = "<Definicion de Param. de Sucursales>"
    Private ID_SUCURSAL As Integer = 0
    Private ID_EMPRESA As Integer = 0
    Private NOMBRE As String = ""
    Private CODIGO As String = ""
    Private TELEFONO As String = ""
    Private EMAIL As String = ""
    Private PAIS As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""

    Private Sub frm_sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitar()
        listar()
        cargar_combo_empresas()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        cbo_empresas.Enabled = False
        txt_nombre.Enabled = False
        txt_codigo.Enabled = False
        txt_telefono.Enabled = False
        txt_email.Enabled = False
        txt_pais.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        cbo_empresas.Enabled = True
        txt_nombre.Enabled = True
        txt_codigo.Enabled = True
        txt_telefono.Enabled = True
        txt_email.Enabled = True
        txt_pais.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_codigo.Text = ""
        txt_telefono.Text = ""
        txt_email.Text = ""
        txt_pais.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_sucursales.Clear()
        dt_sucursales = sucursales.listar("SELECT * FROM sucursales ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_sucursales.DataSource = dt_sucursales
    End Sub

    Private Sub cargar_combo_empresas()
        dt_empresas.Clear()
        dt_empresas = sucursales.listar("SELECT id_empresa, nombre FROM empresas ORDER BY nombre ASC")
        For Each row As DataRow In dt_empresas.Rows
            cbo_empresas.Properties.Items.Add(row("nombre"))
        Next
        cbo_empresas.SelectedIndex = 0
    End Sub

    Private Sub insertar_actualizar()
        If cbo_empresas.SelectedIndex >= 0 Then
            ID_EMPRESA = CInt(dt_empresas.Rows(cbo_empresas.SelectedIndex).Item(0))
        Else
            ID_EMPRESA = 0
        End If
        NOMBRE = txt_nombre.Text
        CODIGO = txt_codigo.Text
        TELEFONO = txt_telefono.Text
        EMAIL = txt_email.Text
        PAIS = txt_pais.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre de la sucursal", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf CODIGO = "" Then
            util.mensajes("Ingrese codigo de la sucursal", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf TELEFONO = "" Then
            util.mensajes("Ingrese nro. de telefono de la sucursal", TITULO_MSJ, "WAR")
            txt_telefono.Focus()
        ElseIf PAIS = "" Then
            util.mensajes("Ingrese pais de la sucursal", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf CIUDAD = "" Then
            util.mensajes("Ingrese ciudad de la sucursal", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf DIRECCION = "" Then
            util.mensajes("Ingrese direccion de la sucursal", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                If ID_SUCURSAL < 1 Then
                    If sucursales.insertar(NOMBRE, TELEFONO, EMAIL, PAIS, CIUDAD, DIRECCION, CODIGO, ID_EMPRESA) Then
                        util.mensajes("Sucursal registrada", TITULO_MSJ, "inf")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Sucursal no registrada", TITULO_MSJ, "WAR")
                    End If
                End If

                If ID_SUCURSAL > 0 Then
                    If sucursales.actualizar(NOMBRE, TELEFONO, EMAIL, PAIS, CIUDAD, DIRECCION, CODIGO, ID_EMPRESA, ID_SUCURSAL) Then
                        util.mensajes("Sucursal actualizada", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Sucursal no actualizada", TITULO_MSJ, "WAR")
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
            ID_SUCURSAL = CInt(GridView1.GetRowCellValue(rowhandle, "id_empresa").ToString)
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString
            txt_email.Text = GridView1.GetRowCellValue(rowhandle, "email").ToString
            txt_pais.Text = GridView1.GetRowCellValue(rowhandle, "pais").ToString
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_SUCURSAL = 0
        cbo_empresas.Focus()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_sucursales_Click(sender As Object, e As EventArgs) Handles grid_sucursales.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_sucursales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_sucursales.KeyDown
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

    Private Sub cbo_empresas_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_empresas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_empresas.SelectedIndex < 0 Then
            Else
                txt_nombre.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text.Replace(" ", "") = "" Then
            Else
                txt_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo.Text.Replace(" ", "") = "" Then
            Else
                txt_telefono.Focus()
            End If
        End If
    End Sub

    Private Sub txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_telefono.Text.Replace(" ", "") = "" Then
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub txt_email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pais.Focus()
        End If
    End Sub

    Private Sub txt_pais_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pais.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_pais.Text.Replace(" ", "") = "" Then
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
                btn_confirmar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub
End Class