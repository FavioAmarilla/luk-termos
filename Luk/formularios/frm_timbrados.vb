Public Class frm_timbrados

    Private timbrado As New func_timbrados
    Private dt_timbrados As New DataTable
    Private dt_empresas As New DataTable
    Private util As New utilidades
    Private TITULO_MSJ As String = "<Definicion de Timbrados>"

    'Variables para las operaciones sobre la tabla timbrados
    Private ID_TIMBRADO As Integer = 0
    Private NUMERO As String = ""
    Private FECHA_DESDE As Date = Nothing
    Private FECHA_HASTA As Date = Nothing
    Private NRO_INICIAL As Integer = 0
    Private NRO_FINAL As Integer = 0
    Private LONGITUD_NRO As Integer = 0
    Private ID_EMPRESA As Integer = 0
    Private ID_SUCURSAL As Integer = 0
    Private ACTIVO As Boolean

    Private Sub frm_timbrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_timbrados = timbrado.consultar("SELECT t.id_timbrado, t.numero, t.fecha_desde, t.fecha_hasta, e.id_empresa, e.nombre AS empresa,
                                            s.id_sucursal, s.nombre AS sucursal, t.longitud_nro_comprob, t.nro_inicial, t.nro_final, t.activo
                                            FROM timbrados t
                                            INNER JOIN empresas e ON e.id_empresa = t.id_empresa
                                            INNER JOIN sucursales s ON s.id_sucursal = t.id_sucursal
                                            ORDER BY fecha_hasta DESC")

        grid_timbrados.DataSource = dt_timbrados
    End Sub

    Private Sub desabilitar()
        txt_numero.Enabled = False
        txt_fecha_desde.Enabled = False
        btn_cld_desde.Enabled = False
        txt_fecha_hasta.Enabled = False
        btn_cld_hasta.Enabled = False
        cbo_empresas.Enabled = False
        txt_sucursal.Enabled = False
        btn_sucursal.Enabled = False
        txt_longitud.Enabled = False
        txt_nro_inicial.Enabled = False
        txt_nro_fina.Enabled = False
        chk_activo.Enabled = False
        btn_registrar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_numero.Enabled = True
        txt_fecha_desde.Enabled = True
        btn_cld_desde.Enabled = True
        txt_fecha_hasta.Enabled = True
        btn_cld_hasta.Enabled = True
        cbo_empresas.Enabled = True
        txt_sucursal.Enabled = True
        btn_sucursal.Enabled = True
        txt_longitud.Enabled = True
        txt_nro_inicial.Enabled = True
        txt_nro_fina.Enabled = True
        chk_activo.Enabled = True
        btn_registrar.Enabled = True
    End Sub

    Private Sub limpiar()
        cld_fecha_desde.Visible = False
        cld_fecha_hasta.Visible = False
        obtener_empresas()
        ID_TIMBRADO = 0
        txt_numero.Text = ""
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        cbo_empresas.SelectedIndex = -1
        ID_EMPRESA = 0
        txt_sucursal.Text = ""
        ID_SUCURSAL = 0
        txt_longitud.Text = ""
        txt_nro_inicial.Text = ""
        txt_nro_fina.Text = ""
        chk_activo.Checked = False
        btn_registrar.Text = "Registrar"
        listar()
    End Sub

    Private Sub obtener_empresas()
        dt_empresas = timbrado.consultar("SELECT id_empresa, nombre FROM empresas ORDER BY nombre ASC")

        If dt_empresas.Rows.Count > 0 Then
            cbo_empresas.Properties.Items.Clear()
            For Each dr As DataRow In dt_empresas.Rows
                cbo_empresas.Properties.Items.Add(dr("nombre"))
            Next
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        dt_empresas = timbrado.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal=" + id)

        If dt_empresas.Rows.Count > 0 Then
            ID_SUCURSAL = CInt(dt_empresas.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt_empresas.Rows(0).Item(1))
        End If
    End Sub

    Private Sub insertar_actualizar()
        If txt_numero.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar numero del Timbrado", TITULO_MSJ, "WAR")
            txt_numero.Focus()
            Return
        End If
        If txt_fecha_desde.Text = "  /  /" Then
            util.mensajes("Debe ingresar Fecha Desde", TITULO_MSJ, "WAR")
            txt_fecha_desde.Focus()
            Return
        End If
        If txt_fecha_hasta.Text = "  /  /" Then
            util.mensajes("Debe ingresar Fecha Hasta", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If
        If ID_EMPRESA <= 0 Then
            util.mensajes("Debe seleccionar Empresa", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If
        If txt_sucursal.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If
        If txt_longitud.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar longitud", TITULO_MSJ, "WAR")
            txt_fecha_hasta.Focus()
            Return
        End If
        If txt_nro_inicial.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar nro. inicial", TITULO_MSJ, "WAR")
            txt_nro_inicial.Focus()
            Return
        End If
        If txt_nro_fina.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe ingresar nro. final", TITULO_MSJ, "WAR")
            txt_nro_fina.Focus()
            Return
        End If

        If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) = False Then
            util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
            Return
        End If

        NUMERO = txt_numero.Text
        FECHA_DESDE = CDate(txt_fecha_desde.Text)
        FECHA_HASTA = CDate(txt_fecha_hasta.Text)
        LONGITUD_NRO = CInt(txt_longitud.Text)
        NRO_INICIAL = CInt(txt_nro_inicial.Text)
        NRO_FINAL = CInt(txt_nro_fina.Text)

        If ID_TIMBRADO <= 0 Then
            If timbrado.insertar(NUMERO, FECHA_DESDE, FECHA_HASTA, NRO_INICIAL, NRO_FINAL, LONGITUD_NRO, ID_EMPRESA, ID_SUCURSAL, ACTIVO) Then
                util.mensajes("Timbrado Registrado", TITULO_MSJ, "INF")
                limpiar()
                desabilitar()
                btn_nuevo.Focus()
            Else
                util.mensajes("Timbrado no Registrado", TITULO_MSJ, "WAR")
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
            habilitar()

            ID_TIMBRADO = CInt(GridView1.GetRowCellValue(rowhandle, "id_timbrado").ToString())
            txt_numero.Text = GridView1.GetRowCellValue(rowhandle, "numero").ToString()
            txt_fecha_desde.Text = GridView1.GetRowCellValue(rowhandle, "fecha_desde").ToString()
            txt_fecha_hasta.Text = GridView1.GetRowCellValue(rowhandle, "fecha_hasta").ToString()
            cbo_empresas.SelectedItem = GridView1.GetRowCellValue(rowhandle, "empresa").ToString()
            ID_EMPRESA = CInt(GridView1.GetRowCellValue(rowhandle, "id_empresa").ToString())
            txt_sucursal.Text = GridView1.GetRowCellValue(rowhandle, "sucursal").ToString()
            ID_SUCURSAL = CInt(GridView1.GetRowCellValue(rowhandle, "id_sucursal").ToString())
            txt_longitud.Text = GridView1.GetRowCellValue(rowhandle, "longitud_nro_comprob").ToString()
            txt_nro_inicial.Text = GridView1.GetRowCellValue(rowhandle, "nro_inicial").ToString()
            txt_nro_fina.Text = GridView1.GetRowCellValue(rowhandle, "nro_final").ToString()
            chk_activo.Checked = CBool(GridView1.GetRowCellValue(rowhandle, "activo").ToString())

            btn_registrar.Text = "Actualizar"
        End If
    End Sub

    Private Sub txt_numero_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_numero.Text.Replace(" ", "") = "" Then
            Else
                txt_fecha_desde.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_desde.Text = "  /  /" Then
            Else
                txt_fecha_hasta.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Then
            cld_fecha_desde.Visible = True
            cld_fecha_desde.Focus()
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_hasta.Text = "  /  /" Then
            Else
                cbo_empresas.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Then
            cld_fecha_hasta.Visible = True
            cld_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub cbo_empresas_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_empresas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_empresas.SelectedIndex >= 0 Then
                txt_sucursal.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_empresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_empresas.SelectedIndexChanged
        If cbo_empresas.SelectedIndex >= 0 Then
            ID_EMPRESA = CInt(dt_empresas.Rows(cbo_empresas.SelectedIndex).Item(0))
        End If
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text.Replace(" ", "") = "" Then
            Else
                txt_longitud.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If ID_EMPRESA <= 0 Then
                util.mensajes("Debe seleccionar Empresa", TITULO_MSJ, "WAR")
                Return
            End If
            Dim frm As New frm_vista_sucursales
            frm.CONDICION_SQL = " WHERE id_empresa=" + ID_EMPRESA.ToString
            frm.FRM_ACTIVO = "frm_timbrados"
            frm.Show()
        End If
    End Sub

    Private Sub txt_longitud_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_longitud.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_longitud.Text.Replace(" ", "") = "" Then
            Else
                txt_nro_inicial.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nro_inicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_inicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_inicial.Text.Replace(" ", "") = "" Then
            Else
                txt_nro_fina.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nro_fina_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nro_fina.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_fina.Text.Replace(" ", "") = "" Then
            Else
                chk_activo.Focus()
            End If
        End If
    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged
        If chk_activo.Checked Then
            ACTIVO = True
        End If
        If chk_activo.Checked = False Then
            ACTIVO = False
        End If
    End Sub

    Private Sub chk_activo_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_activo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_registrar.Focus()
        End If
    End Sub

    Private Sub btn_cld_desde_Click(sender As Object, e As EventArgs) Handles btn_cld_desde.Click
        cld_fecha_desde.Visible = True
        cld_fecha_desde.Focus()
    End Sub

    Private Sub btn_cld_hasta_Click(sender As Object, e As EventArgs) Handles btn_cld_hasta.Click
        cld_fecha_hasta.Visible = False
        cld_fecha_hasta.Focus()
    End Sub

    Private Sub btn_sucursal_Click(sender As Object, e As EventArgs) Handles btn_sucursal.Click
        If ID_EMPRESA <= 0 Then
            util.mensajes("Debe seleccionar Empresa", TITULO_MSJ, "WAR")
            Return
        End If
        Dim frm As New frm_vista_sucursales
        frm.CONDICION_SQL = " WHERE id_empresa=" + ID_EMPRESA.ToString
        frm.FRM_ACTIVO = "frm_timbrados"
        frm.Show()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        txt_numero.Focus()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
            btn_nuevo.Focus()
        End If
    End Sub

    Private Sub grid_timbrados_Click(sender As Object, e As EventArgs) Handles grid_timbrados.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_timbrados_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_timbrados.KeyDown
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

    Private Sub cld_fecha_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_fecha_desde.DoubleClick
        txt_fecha_desde.Text = cld_fecha_desde.DateTime.ToString
        txt_fecha_desde.Focus()
        cld_fecha_desde.Visible = False
    End Sub

    Private Sub cld_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_fecha_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_fecha_desde.DateTime.ToString
            txt_fecha_desde.Focus()
            cld_fecha_desde.Visible = False
        End If
    End Sub

    Private Sub cld_fecha_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cld_fecha_hasta.DoubleClick
        txt_fecha_hasta.Text = cld_fecha_hasta.DateTime.ToString
        txt_fecha_hasta.Focus()
        cld_fecha_hasta.Visible = False
    End Sub

    Private Sub cld_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cld_fecha_hasta.DateTime.ToString
            txt_fecha_hasta.Focus()
            cld_fecha_hasta.Visible = False
        End If
    End Sub


End Class