Public Class frm_proveedores

    Private proveedor As New func_proveedores()
    Private dt_proveedor As New DataTable()
    Private util As New utilidades()
    Private TITULO_MSJ As String = "<Registro de Proveedores>"

    Private ID_PROVEEDOR As Integer = 0
    Private NOMBRE As String = ""
    Private RUC As String = ""
    Private TELEFONO As String = ""
    Private CORREO As String = ""
    Private PAIS As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""
    Private PAGINA_WEB As String = ""
    Private ACTIVO As Boolean = False


    Private Sub frm_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        limpiar()
        desabilitar()
        chk_activo.Checked = True
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_ruc.Enabled = False
        txt_telefono.Enabled = False
        txt_correo.Enabled = False
        txt_pais.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        txt_pagina_web.Enabled = False
        chk_activo.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        txt_ruc.Enabled = True
        txt_telefono.Enabled = True
        txt_correo.Enabled = True
        txt_pais.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        txt_pagina_web.Enabled = True
        chk_activo.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_ruc.Text = ""
        txt_telefono.Text = ""
        txt_correo.Text = ""
        txt_pais.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        txt_pagina_web.Text = ""
        chk_activo.Checked = False

        btn_confirmar.Text = "Registrar"
    End Sub

    Private Sub listar()
        dt_proveedor = proveedor.listar("SELECT * FROM proveedores ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_proveedores.DataSource = dt_proveedor
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text
        RUC = txt_ruc.Text
        TELEFONO = txt_telefono.Text
        CORREO = txt_correo.Text
        PAIS = txt_pais.Text
        CIUDAD = txt_ciudad.Text
        DIRECCION = txt_direccion.Text
        PAGINA_WEB = txt_pagina_web.Text

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre del Proveedor", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If
        If RUC = "" Then
            util.mensajes("Ingrese R.U.C del Proveedor", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If
        If TELEFONO = "" Then
            util.mensajes("Ingrese telefono del Proveedor", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If
        If DIRECCION = "" Then
            util.mensajes("Ingrese direccion del Proveedor", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        If ID_PROVEEDOR <= 0 Then
            If proveedor.insertar(NOMBRE, RUC, TELEFONO, CORREO, PAIS, CIUDAD, DIRECCION, PAGINA_WEB, ACTIVO) Then
                util.mensajes("Proveedor Registrado", TITULO_MSJ, "INF")
            Else
                util.mensajes("Proveedor no Registrado", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        If ID_PROVEEDOR > 0 Then
            If proveedor.actualizar(NOMBRE, RUC, TELEFONO, CORREO, PAIS, CIUDAD, DIRECCION, PAGINA_WEB, ACTIVO, ID_PROVEEDOR) Then
                util.mensajes("Proveedor Actualizado", TITULO_MSJ, "INF")
            Else
                util.mensajes("Proveedor no Actualizado", TITULO_MSJ, "WAR")
                Return
            End If
        End If

        listar()
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
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
            limpiar()
            habilitar()
            btn_confirmar.Text = "Actualizar"

            ID_PROVEEDOR = CInt(GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString)
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString
            txt_ruc.Text = GridView1.GetRowCellValue(rowhandle, "ruc").ToString
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString
            txt_correo.Text = GridView1.GetRowCellValue(rowhandle, "correo").ToString
            txt_pais.Text = GridView1.GetRowCellValue(rowhandle, "pais").ToString
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString
            txt_pagina_web.Text = GridView1.GetRowCellValue(rowhandle, "pagina_web").ToString
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandle, "activo").ToString)

        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_PROVEEDOR = 0
        txt_nombre.Focus()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            insertar_actualizar()
            lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
        End If
    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked = False Then
            ACTIVO = False
        End If
        If chk_activo.Checked = True Then
            ACTIVO = True
        End If
    End Sub

    Private Sub grid_proveedores_Click(sender As Object, e As EventArgs) Handles grid_proveedores.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_proveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_proveedores.KeyDown
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

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text.Replace(" ", "") = "" Then
            Else
                txt_ruc.Focus()
            End If
        End If
    End Sub

    Private Sub txt_ruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ruc.Text.Replace(" ", "") = "" Then
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
            txt_pais.Focus()
        End If
    End Sub

    Private Sub txt_pais_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pais.KeyDown
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
            If txt_direccion.Text.Replace(" ", "") = "" Then
            Else
                txt_pagina_web.Focus()
            End If
        End If
    End Sub

    Private Sub txt_pagina_web_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pagina_web.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_activo.Focus()
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If

        GridView1.ShowPrintPreview()
    End Sub
End Class