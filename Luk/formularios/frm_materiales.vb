Public Class frm_materiales

    Private dt_materiales As New DataTable
    Private Const TITULO_MSJ = "<Registro de Materias Primas>"
    Private EXISTE_MATERIAL As Boolean = False

    Private ID_MATERIAL As Integer = 0
    Private NOMBRE As String = ""
    Private CODIGO As String = ""
    Private COSTO_UNITARIO As Integer = 0
    Private ID_TIPO_IMPUESTO As Integer = 0
    Private ID_FAMILIA As Integer = 0
    Private CONTROLAR_STOCK As Boolean = False
    Private ID_PROVEEDOR As Integer = 0
    Private STOCK_MINIMO As Double = 0

    Private materiales As New func_materiales()
    Private stock As New func_stock_articulos()
    Private util As New utilidades()

    Private Sub frm_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_confirmar.Text = "Registrar"
        desabilitar()
        listar()
        btn_nuevo.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_fecha_cre.Enabled = False
        txt_nombre.Enabled = False
        txt_codigo.Enabled = False
        txt_costo_unitario.Enabled = False
        txt_impuesto.Enabled = False
        btn_buscar_impuesto.Enabled = False
        txt_familia.Enabled = False
        txt_proveedor.Enabled = False
        txt_stock_min.Enabled = False
        btn_buscar_familia.Enabled = False
        chk_controlar_stock.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_fecha_cre.Enabled = True
        txt_nombre.Enabled = True
        txt_codigo.Enabled = True
        txt_costo_unitario.Enabled = True
        txt_impuesto.Enabled = True
        btn_buscar_impuesto.Enabled = True
        txt_familia.Enabled = True
        txt_proveedor.Enabled = True
        txt_stock_min.Enabled = True
        btn_buscar_familia.Enabled = True
        chk_controlar_stock.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_fecha_cre.Text = ""
        txt_nombre.Text = ""
        txt_codigo.Text = ""
        txt_costo_unitario.Text = ""
        txt_impuesto.Text = ""
        txt_familia.Text = ""
        txt_stock_min.Text = ""
        txt_proveedor.Text = ""
        ID_FAMILIA = 0
        chk_controlar_stock.Checked = False
        btn_confirmar.Text = "Registrar"

        ID_TIPO_IMPUESTO = 0
        ID_PROVEEDOR = 0
        ID_FAMILIA = 0
        ID_MATERIAL = 0
        EXISTE_MATERIAL = False
    End Sub

    Private Sub listar()
        dt_materiales.Clear()
        dt_materiales = materiales.listar("SELECT m.id_material, m.nombre, m.costo_unitario, m.codigo, t.id_tipo_impuesto, t.nombre AS impuesto, 
                                           COALESCE(m.id_familia, 0) AS id_familia, COALESCE(controlar_stock, false) AS controlar_stock, 
                                           m.fecha_cre, COALESCE(p.nombre,'NO DEFINIDO') AS proveedor, COALESCE(p.id_proveedor, 0) AS id_proveedor, 
                                           COALESCE(fm.descripcion,'NO DEFINIDO') AS familia, COALESCE(m.stock_minimo, 0) AS stock_minimo
                                           FROM materiales m
                                           LEFT JOIN tipos_impuesto t ON t.id_tipo_impuesto = m.id_tipo_impuesto
                                           LEFT JOIN proveedores p ON p.id_proveedor = m.id_proveedor
                                           LEFT JOIN familias_materia_prima fm ON fm.identificador = m.id_familia
                                           ORDER BY m.fecha_cre DESC, m.fecha_mod DESC")

        grid_materiales.DataSource = dt_materiales
    End Sub

    Public Sub obtener_tipo_impuesto(ByVal id As Integer)
        Dim dt As New DataTable
        dt = materiales.listar("SELECT id_tipo_impuesto, nombre FROM tipos_impuesto WHERE id_tipo_impuesto = " + id.ToString() + "")
        ID_TIPO_IMPUESTO = CInt(dt.Rows(0).Item(0))
        txt_impuesto.Text = CStr(dt.Rows(0).Item(1))
        txt_impuesto.Focus()
    End Sub

    Public Sub obtener_familia(ByVal id As Integer)
        Dim dt As New DataTable
        dt = materiales.listar("SELECT identificador,descripcion FROM familias_materia_prima WHERE identificador = " + id.ToString() + "")
        If dt.Rows.Count() <> 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
            txt_familia.Focus()
        End If
    End Sub

    Private Function obtener_codigo() As String
        Dim longitud_id = CStr(ID_MATERIAL).Length
        Dim ceros As String = ""
        Dim limite As Integer = 7

        For i As Integer = 1 To limite - longitud_id
            ceros += "0"
        Next

        Return ceros & ID_MATERIAL
    End Function
    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = materiales.listar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor = " + id.ToString() + "")
        If dt.Rows.Count > 0 Then
            ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
            txt_proveedor.Text = CType(dt.Rows(0).Item(1), String)
        End If
    End Sub

    Private Sub insertar_actualizar()
        NOMBRE = txt_nombre.Text
        CODIGO = txt_codigo.Text

        If txt_costo_unitario.Text = "" Then
            COSTO_UNITARIO = 0
        Else
            COSTO_UNITARIO = CInt(txt_costo_unitario.Text)
        End If

        If txt_stock_min.Text = "" Then
            STOCK_MINIMO = 0
        Else
            STOCK_MINIMO = CInt(txt_stock_min.Text)
        End If

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre de Materia Prima", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf COSTO_UNITARIO <= 0 Then
            util.mensajes("Ingrese costo unitario de Materia Prima", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_TIPO_IMPUESTO <= 0 Then
            util.mensajes("Ingrese tipo de impuesto de Materia Prima", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_FAMILIA <= 0 Then
            util.mensajes("Ingrese familia de Materia Prima", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_PROVEEDOR <= 0 Then
            util.mensajes("Ingrese Proveedor de Materia Prima", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then

                If EXISTE_MATERIAL = False Then
                    ID_MATERIAL = materiales.id_material()
                    If CODIGO = ""
                        CODIGO = obtener_codigo()
                    End If
                    If materiales.insertar(ID_MATERIAL, NOMBRE, CODIGO, 1, COSTO_UNITARIO, ID_TIPO_IMPUESTO, ID_FAMILIA, CONTROLAR_STOCK, ID_PROVEEDOR, STOCK_MINIMO) Then

                        Dim dt_sucursales As New DataTable
                        dt_sucursales = materiales.listar("SELECT id_sucursal FROM sucursales WHERE id_empresa=" + frm_main.ID_SUCURSAL.ToString + "")
                        For i As Integer = 0 To dt_sucursales.Rows.Count - 1
                            If stock.insertar(0, 0, 0, 0, 0, ID_MATERIAL, CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                                util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                                Return
                            End If
                        Next

                        util.mensajes("Materia Prima Registrada", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Materia Prima no Registrada", TITULO_MSJ, "WAR")
                    End If
                End If

                If EXISTE_MATERIAL Then

                    Dim dt_sucursales As New DataTable
                    dt_sucursales = materiales.listar("SELECT id_sucursal FROM sucursales WHERE id_empresa=" + frm_main.ID_SUCURSAL.ToString + "")
                    For i As Integer = 0 To dt_sucursales.Rows.Count - 1
                        If stock.validar_stock(ID_MATERIAL, "material", CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                            If stock.insertar(0, 0, 0, 0, 0, ID_MATERIAL, CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                                util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                                Return
                            End If
                        End If
                    Next

                    If materiales.actualizar(NOMBRE, CODIGO, frm_main.ID_USUARIO, ID_MATERIAL, COSTO_UNITARIO, ID_TIPO_IMPUESTO, ID_FAMILIA, CONTROLAR_STOCK, ID_PROVEEDOR, STOCK_MINIMO) Then
                        util.mensajes("Materia Prima Actualizada", TITULO_MSJ, "INF")
                        limpiar()
                        desabilitar()
                        btn_nuevo.Focus()
                    Else
                        util.mensajes("Materia Prima no Actualizada", TITULO_MSJ, "WAR")
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
            limpiar()
            habilitar()
            
            ID_MATERIAL = CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString()
            txt_codigo.Text = GridView1.GetRowCellValue(rowhandle, "codigo").ToString()
            txt_costo_unitario.Text = GridView1.GetRowCellValue(rowhandle, "costo_unitario").ToString()
            ID_TIPO_IMPUESTO = CInt(GridView1.GetRowCellValue(rowhandle, "id_tipo_impuesto").ToString())
            txt_impuesto.Text = GridView1.GetRowCellValue(rowhandle, "impuesto").ToString()
            chk_controlar_stock.Checked = CBool(GridView1.GetRowCellValue(rowhandle, "controlar_stock").ToString())
            txt_fecha_cre.Text = GridView1.GetRowCellValue(rowhandle, "fecha_cre").ToString()
            txt_stock_min.Text = GridView1.GetRowCellValue(rowhandle, "stock_minimo").ToString()
            obtener_familia(CInt(GridView1.GetRowCellValue(rowhandle, "id_familia").ToString()))

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString()) Then
            Else
                obtener_proveedor(CInt(GridView1.GetRowCellValue(rowhandle, "id_proveedor").ToString()))
            End If

            EXISTE_MATERIAL = True
            btn_confirmar.Text = "Actualizar"
            grid_materiales.Focus()
            End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        txt_fecha_cre.Text = util.fecha
        txt_nombre.Focus()
    End Sub

    Private Sub grid_materiales_Click(sender As Object, e As EventArgs) Handles grid_materiales.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_materiales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_materiales.KeyDown
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

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
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
            txt_costo_unitario.Focus()
        End If
    End Sub

    Private Sub txt_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_costo_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_costo_unitario.Text.Replace(" ", "") = "" Or txt_costo_unitario.Text.Replace(" ", "") = "0" Then
            Else
                txt_stock_min.Focus()
            End If
        End If
    End Sub

    Private Sub btn_buscar_impuesto_Click(sender As Object, e As EventArgs) Handles btn_buscar_impuesto.Click
        Dim frm As New frm_vista_tipos_impuesto
        frm.FRM_ACTIVO = "frm_materiales"
        frm.Show()
    End Sub

    Private Sub txt_impuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_impuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_impuesto.Text.Replace(" ", "") = "" Then
            Else
                txt_familia.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            btn_buscar_impuesto.Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub btn_buscar_familia_Click(sender As Object, e As EventArgs) Handles btn_buscar_familia.Click
        Dim frm As New frm_vista_familia_materia_prima
        frm.FRM_ACTIVO = "frm_materiales"
        frm.Show()
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_familia_materia_prima
            frm.FRM_ACTIVO = "frm_materiales"
            frm.Show()
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_familia.Text.Replace(" ", "") = "" Then
            Else
                txt_proveedor.Focus()
            End If
        End If
    End Sub

    Private Sub chk_controlar_stock_CheckedChanged(sender As Object, e As EventArgs) Handles chk_controlar_stock.CheckedChanged
        If chk_controlar_stock.Checked Then
            CONTROLAR_STOCK = True
        End If

        If chk_controlar_stock.Checked = False Then
            CONTROLAR_STOCK = False
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", TITULO_MSJ) Then
            limpiar()
            desabilitar()
        End If
    End Sub

    Private Sub chk_controlar_stock_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_controlar_stock.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub
    Private Sub btn_buscar_proveedor_Click(sender As Object, e As EventArgs) Handles btn_buscar_proveedor.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_materiales"
        frm.Show()
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_materiales"
            frm.ShowDialog()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_proveedor.Text.Replace(" ", "") = "" Then
            Else
                chk_controlar_stock.Focus()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.ShowPrintPreview()
    End Sub

    Private Sub txt_stock_min_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_stock_min.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_costo_unitario.Text.Replace(" ", "") = "" Or txt_costo_unitario.Text.Replace(" ", "") = "0" Then
            Else
                txt_impuesto.Focus()
            End If
        End If
    End Sub

End Class