Imports System.IO

Public Class frm_articulos

    Private articulos As New func_articulos()
    Private stock As New func_stock_articulos()
    Dim dt_items_materiales As New DataTable
    Private util As New utilidades()
    Private Const TITULO_MSJ As String = "<<Registro de Articulos>"
    Public EXISTE_ARTICULO As Boolean = False
    Private open_file_dialog As New OpenFileDialog()

    'Variables para las transacciones de la tabla articulos
    Private ID_ARTICULO As Integer = 0
    Private NOMBRE As String = ""
    Private DESCRIPCION As String = ""
    Private CODIGO As String = ""
    Private COSTO_UNITARIO As Integer = 0
    Private PRECIO_VENTA As Integer = 0
    Private ID_PROVEEDOR As Integer = 0
    Private ID_TIPO_IMPUESTO As Integer = 0
    Private CODIGO_BARRAS As String = ""
    Private PRODUCCION_PROPIA As Boolean = False
    Private ID_FAMILIA As Integer = 0
    Private IMAGEN As String = ""
    Private IMAGEN_ANT As String = ""
    Private COSTO_MANO_OBRA As Integer = 0
    Private ACTIVO As Boolean = False
    Private PORC_RECARGO As Double = False

    'Variables para las transacciones de la tabla articulo_materiales
    Private ID_MATERIAL As Integer = 0
    Private CANTIDAD As Double = 0
    Private COSTO_TOTAL As Integer = 0

    Private Sub frm_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        crear_cursor()
        btn_nuevo.Focus()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_codigo_barras.Enabled = False
        txt_codigo.Enabled = False
        txt_proveedor.Enabled = False
        btn_buscar_proveedor.Enabled = False
        txt_impuesto.Enabled = False
        btn_buscar_impuesto.Enabled = False
        txt_familia.Enabled = False
        chk_articulo_Luk.Enabled = False
        chk_activo.Enabled = False
        txt_mano_obra.Enabled = False
        txt_recargo.Enabled = False
        btn_confirmar.Enabled = False
        btn_agregar_material.Enabled = False
        btn_quitar_empleado.Enabled = False

        txt_imagen.Enabled = False
        btn_buscar_imagen.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        txt_codigo_barras.Enabled = True
        txt_codigo.Enabled = True
        txt_proveedor.Enabled = True
        btn_buscar_proveedor.Enabled = True
        txt_impuesto.Enabled = True
        btn_buscar_impuesto.Enabled = True
        txt_familia.Enabled = True
        chk_articulo_Luk.Enabled = True
        chk_activo.Enabled = True
        txt_mano_obra.Enabled = True
        txt_recargo.Enabled = True
        btn_confirmar.Enabled = True
        btn_agregar_material.Enabled = True
        btn_quitar_empleado.Enabled = True

        txt_imagen.Enabled = True
        btn_buscar_imagen.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_codigo_barras.Text = ""
        txt_codigo.Text = ""
        txt_proveedor.Text = ""
        txt_impuesto.Text = ""
        txt_familia.Text = ""
        chk_articulo_Luk.Checked = False
        chk_activo.Checked = False
        txt_mano_obra.Text = ""
        txt_recargo.Text = ""
        btn_confirmar.Text = "Registrar"

        txt_imagen.Text = ""

        If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
            Dim fs As FileStream
            fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
            pct_imagen.Image = Image.FromStream(fs)
            fs.Close()
        End If

    End Sub

    Private Sub nuevo()
        EXISTE_ARTICULO = False
        ID_ARTICULO = articulos.id_articulo()
        If ID_ARTICULO > 0 Then
            habilitar()
            limpiar()
            chk_activo.Checked = True
            txt_nombre.Focus()
        End If
    End Sub

    Private Sub crear_cursor()
        dt_items_materiales = New DataTable
        dt_items_materiales.Columns.Add("id_material")
        dt_items_materiales.Columns.Add("nombre")
        dt_items_materiales.Columns.Add("cantidad", GetType(Double))

        grid_materiales.DataSource = dt_items_materiales
    End Sub

    Private Function validar_cantidad_materiales() As Boolean
        Dim cantidad As Double = 0.0
        Dim validar As String
        For i As Integer = 0 To GridView1.RowCount
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            validar = GridView1.GetFocusedDisplayText()
            If validar <> "" Then
                If CInt(validar) > 0 Then
                    cantidad += CDbl(GridView1.GetFocusedDisplayText())
                End If
            End If
        Next

        Return cantidad >= 0
    End Function

    Private Sub listar_materiales()
        dt_items_materiales.Clear()
        dt_items_materiales = articulos.listar("SELECT *, 0.0 AS cantidad FROM materiales ORDER BY nombre ASC")
        grid_materiales.DataSource = dt_items_materiales
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Function copiar_imagenes() As Boolean
        Try
            Dim IMAG As String = frm_main.CARPETA_IMG_ARTICULOS + ID_ARTICULO.ToString + ".jpg"
            IMAGEN = IMAG

            If IMAGEN = txt_imagen.Text Then
                IMAGEN = IMAGEN_ANT
                Return True
            End If

            'Se valida que exista el directorio
            If Directory.Exists(frm_main.CARPETA_IMG_ARTICULOS) = False Then
                util.mensajes("No se encontro el directorio de Imagenes", TITULO_MSJ, "ERR")
                Return False
            End If

            'Si el campo de texto de logo esta vacio no se realiza ningun proceso y se retorna true 
            'para gardar el campo como vacio
            If txt_imagen.Text.Replace(" ", "") = "" Then
                Return True
            Else
                'Esta variable crea una nueva imagen a partir de la imagen seleccionada
                Dim img As New Bitmap(New Bitmap(txt_imagen.Text), frm_main.WIDTH_IMG, frm_main.HEIGHT_IMG)

                'Se valida si existe el archivo,si no existe se guarda la imagen 
                'si existe se elimina y se guarda la nueva imagen
                If File.Exists(IMAG) = False Then
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                Else
                    pct_imagen.Image.Dispose()
                    pct_imagen.Image = Nothing
                    File.Delete(IMAG)
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                End If
            End If
        Catch ex As Exception
            util.mensajes("Error al copiar Imagen de Articulo: " + ex.Message, TITULO_MSJ, "ERR")
            Return False
        End Try
    End Function

    Private Sub insertar_actualizar_articulo()
        NOMBRE = txt_nombre.Text
        CODIGO = txt_codigo.Text
        CODIGO_BARRAS = txt_codigo_barras.Text
        COSTO_MANO_OBRA = CInt(txt_mano_obra.Text)

        If txt_recargo.Text.Replace(" ", "") = "" Then
            PORC_RECARGO = 0
        Else
            PORC_RECARGO = txt_recargo.Text.Replace(" ", "")
        End If

        If NOMBRE = "" Then
            util.mensajes("Ingrese nombre del Articulo", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf CODIGO_BARRAS = "" Then
            util.mensajes("Ingrese codigo de barras del articulo", TITULO_MSJ, "WAR")
            txt_codigo_barras.Focus()
        ElseIf CODIGO = "" Then
            util.mensajes("Ingrese codigo del articulo", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_PROVEEDOR < 0 Then
            util.mensajes("Ingrese proveedor del articulo", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_TIPO_IMPUESTO < 0 Then
            util.mensajes("Ingrese impuesto del articulo", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        ElseIf ID_FAMILIA <= 0 Then
            util.mensajes("Ingrese familia del articulo", TITULO_MSJ, "WAR")
            txt_codigo.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion?", TITULO_MSJ) Then

                copiar_imagenes()

                If EXISTE_ARTICULO = False Then
                    If articulos.existe_codigo_barras(txt_codigo_barras.Text) Then
                        Return
                    End If

                    If articulos.insertar(ID_ARTICULO, NOMBRE, DESCRIPCION, CODIGO, ID_PROVEEDOR, ID_TIPO_IMPUESTO, CODIGO_BARRAS, PRODUCCION_PROPIA, ID_FAMILIA, IMAGEN, COSTO_MANO_OBRA, ACTIVO, PORC_RECARGO) Then

                        Dim dt_sucursales As New DataTable
                        dt_sucursales = articulos.listar("SELECT id_sucursal FROM sucursales WHERE id_empresa=" + frm_main.ID_SUCURSAL.ToString + "")
                        For i As Integer = 0 To dt_sucursales.Rows.Count - 1
                            If stock.insertar(ID_ARTICULO, 0, 0, 0, 0, 0, CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                                util.mensajes("Stock de Articulo no registrado", TITULO_MSJ, "WAR")
                                Return
                            End If
                        Next

                        If GridView1.RowCount() > 0 Then
                            If insertar_materiales_articulo() Then
                                util.mensajes("Articulo Registrado", TITULO_MSJ, "INF")
                                limpiar()
                                desabilitar()
                                btn_nuevo.Focus()
                            Else
                                util.mensajes("Materiales del Articulo no Registrados", TITULO_MSJ, "WAR")
                            End If
                        Else
                            util.mensajes("Articulo Registrado", TITULO_MSJ, "INF")
                        End If
                    Else
                        util.mensajes("Articulo no Registrado", TITULO_MSJ, "WAR")
                    End If
                End If

                If EXISTE_ARTICULO = True Then

                    Dim dt_sucursales As New DataTable
                    dt_sucursales = articulos.listar("SELECT id_sucursal FROM sucursales WHERE id_empresa=" + frm_main.ID_SUCURSAL.ToString + "")
                    For i As Integer = 0 To dt_sucursales.Rows.Count - 1
                        If stock.validar_stock(ID_ARTICULO, "articulo", CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                            If stock.insertar(ID_ARTICULO, 0, 0, 0, 0, 0, CInt(dt_sucursales.Rows(i).Item(0))) = False Then
                                util.mensajes("Stock de Articulo no actualizado", TITULO_MSJ, "WAR")
                                Return
                            End If
                        End If
                    Next

                    If articulos.actualizar(NOMBRE, DESCRIPCION, CODIGO, ID_PROVEEDOR, ID_TIPO_IMPUESTO, ID_ARTICULO, PRODUCCION_PROPIA, ID_FAMILIA, IMAGEN, COSTO_MANO_OBRA, ACTIVO, PORC_RECARGO) Then
                        If GridView1.RowCount() > 0 Then
                            If dt_items_materiales.Rows.Count() <> 0 Then
                                If eliminar_materiales_articulo(ID_ARTICULO) Then
                                    If insertar_materiales_articulo() Then
                                        util.mensajes("Articulo Actualizado", TITULO_MSJ, "INF")
                                        limpiar()
                                        desabilitar()
                                        btn_nuevo.Focus()
                                    Else
                                        util.mensajes("Materiales del Articulo no Actualizados", TITULO_MSJ, "WAR")
                                    End If
                                Else
                                    If insertar_materiales_articulo() Then
                                        util.mensajes("Articulo Actualizado", TITULO_MSJ, "INF")
                                        limpiar()
                                        desabilitar()
                                        btn_nuevo.Focus()
                                    Else
                                        util.mensajes("Materiales del Articulo no Actualizados", TITULO_MSJ, "WAR")
                                    End If
                                End If
                            Else
                                util.mensajes("Debe asignar materiales al articulo", TITULO_MSJ, "WAR")
                            End If
                        Else
                            util.mensajes("Articulo Registrado", TITULO_MSJ, "INF")
                        End If
                    Else
                        util.mensajes("Articulo no Actualizado", TITULO_MSJ, "WAR")
                    End If
                End If
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "INF")
            End If
        End If

    End Sub

    Private Function insertar_materiales_articulo() As Boolean
        Dim resultado As Boolean = False
        Dim rowhandle As Integer
        Dim cant As Double = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            'MANDAMOS EL FOCO A LA FILA <<i>> MEDIANTE EL FocusedRowHandle
            GridView1.FocusedRowHandle = i
            'OBTENEMOS LA FILA EN LA QUE SE ENCUENTRA EL FOCO
            rowhandle = GridView1.FocusedRowHandle
            'OBTENEMOS TODOS LOS VALORES
            ID_MATERIAL = CInt(GridView1.GetRowCellValue(rowhandle, "id_material").ToString())
            'MANDAMOS EL FOCO A LA COLUMNA DE CANTIDAD PARA OBTENER SU VALOR
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            'OBTENEMOS EL VALOR DE LA COLUMNA CANTIDAD
            cant = CDbl(GridView1.GetFocusedDisplayText())

            If cant > 0.0 Then
                CANTIDAD = CDbl(GridView1.GetFocusedDisplayText())
                resultado = articulos.insertar_articulo_materiales(ID_ARTICULO, ID_MATERIAL, CANTIDAD)
                If resultado = False Then
                    Return False
                End If
            End If
        Next

        Return resultado
    End Function

    Private Function eliminar_materiales_articulo(ByVal id_articulo As Integer) As Boolean
        Return articulos.eliminar_articulo_materiales(id_articulo)
    End Function

    Public Sub buscar_articulo(ByVal id As Integer)
        Dim dt_articulos As New DataTable()
        dt_articulos = articulos.listar("SELECT a.id_articulo, a.nombre, a.codigo_articulo, a.costo_unitario, a.precio_venta, p.id_proveedor, p.nombre AS proveedor,
                                         t.id_tipo_impuesto, t.nombre AS impuesto, codigo_barras, COALESCE(produccion_propia,false), imagen, COALESCE(a.id_familia,0),
                                         COALESCE(f.descripcion,''),costo_mano_obra, COALESCE(a.activo, false), COALESCE(porc_recargo, 0)
                                         FROM articulos a
                                         INNER JOIN proveedores p ON p.id_proveedor = a.id_proveedor
                                         INNER JOIN tipos_impuesto t ON t.id_tipo_impuesto = a.id_tipo_impuesto
                                         INNER JOIN familias f ON f.identificador = a.id_familia
                                         WHERE id_articulo = " + id.ToString() + "")

        If dt_articulos.Rows.Count() <> 0 Then
            ID_ARTICULO = CInt(dt_articulos.Rows(0).Item(0).ToString())
            txt_nombre.Text = dt_articulos.Rows(0).Item(1).ToString()
            txt_codigo.Text = dt_articulos.Rows(0).Item(2).ToString()
            txt_codigo_barras.Text = dt_articulos.Rows(0).Item(9).ToString()
            chk_articulo_Luk.Checked = CBool(dt_articulos.Rows(0).Item(10))
            txt_mano_obra.Text = dt_articulos.Rows(0).Item(14).ToString()
            chk_activo.Checked = CBool(dt_articulos.Rows(0).Item(15))
            txt_recargo.Text = CStr(dt_articulos.Rows(0).Item(16))

            If IsDBNull(dt_articulos.Rows(0).Item(5).ToString()) Or dt_articulos.Rows(0).Item(5).ToString() = "" Then
                ID_PROVEEDOR = 0
            Else
                ID_PROVEEDOR = CInt(dt_articulos.Rows(0).Item(5).ToString())
            End If
            txt_proveedor.Text = dt_articulos.Rows(0).Item(6).ToString()

            If IsDBNull(dt_articulos.Rows(0).Item(7).ToString()) Or dt_articulos.Rows(0).Item(7).ToString() = "" Then
                ID_TIPO_IMPUESTO = 0
            Else
                ID_TIPO_IMPUESTO = CInt(dt_articulos.Rows(0).Item(7).ToString())
            End If
            txt_impuesto.Text = dt_articulos.Rows(0).Item(8).ToString()

            txt_imagen.Text = dt_articulos.Rows(0).Item(11).ToString()
            IMAGEN_ANT = txt_imagen.Text
            If File.Exists(txt_imagen.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_imagen.Text, FileMode.Open, FileAccess.Read)
                pct_imagen.Image = Image.FromStream(fs)
                fs.Close()
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_imagen.Image = Image.FromStream(fs)
                    fs.Close()
                    txt_imagen.Text = ""
                End If
            End If

            ID_FAMILIA = CInt(dt_articulos.Rows(0).Item(12))
            txt_familia.Text = CStr(dt_articulos.Rows(0).Item(13))

            buscar_materiales()
            habilitar()
            txt_nombre.Focus()

            GridView1.FocusedRowHandle = GridView1.RowCount()
            btn_agregar_material.Enabled = True
            txt_codigo_barras.Enabled = False
            txt_codigo.Enabled = False
            btn_confirmar.Text = "Actualizar"
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
        End If
    End Sub

    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = articulos.listar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor = " + id.ToString() + "")
        ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
        txt_proveedor.Text = CType(dt.Rows(0).Item(1), String)
        txt_proveedor.Focus()
    End Sub

    Public Sub obtener_tipo_impuesto(ByVal id As Integer)
        Dim dt As New DataTable
        dt = articulos.listar("SELECT id_tipo_impuesto, nombre FROM tipos_impuesto WHERE id_tipo_impuesto = " + id.ToString() + "")
        ID_TIPO_IMPUESTO = CInt(dt.Rows(0).Item(0))
        txt_impuesto.Text = CType(dt.Rows(0).Item(1), String)
        txt_impuesto.Focus()
    End Sub

    Public Sub obtener_familia(ByVal id As Integer)
        Dim dt As New DataTable
        dt = articulos.listar("SELECT identificador,descripcion FROM familias WHERE identificador = " + id.ToString() + "")
        ID_FAMILIA = CInt(dt.Rows(0).Item(0))
        txt_familia.Text = CType(dt.Rows(0).Item(1), String)
        txt_familia.Focus()
    End Sub

    Private Sub buscar_materiales()
        dt_items_materiales.Clear()
        dt_items_materiales = articulos.listar("SELECT a.*, m.nombre FROM articulo_materiales a INNER JOIN materiales m
                                          ON a.id_material = m.id_material WHERE id_articulo = " + ID_ARTICULO.ToString() + "")
        grid_materiales.DataSource = Nothing
        grid_materiales.DataSource = dt_items_materiales
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub add_materiales(ByVal id As Integer)
        Dim dt_material As New DataTable()
        dt_material = articulos.listar("SELECT id_material, nombre, 0 AS cantidad FROM materiales WHERE id_material=" + id.ToString() + "")

        If dt_material.Rows().Count() <> 0 Then
            'Se valida que el material aun no este agregado al articulo
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "id_material") = dt_material.Rows(0).Item(0).ToString Then
                    util.mensajes(dt_material.Rows(0).Item(1).ToString() + ", ya esta asignado al Articulo", "Articulos", "WAR")
                    Return
                End If
            Next

            Dim row As DataRow = dt_items_materiales.NewRow()

            row.Item("id_material") = dt_material.Rows(0).Item(0)
            row.Item("nombre") = dt_material.Rows(0).Item(1)
            row.Item("cantidad") = dt_material.Rows(0).Item(2)

            dt_items_materiales.Rows.Add(row)
            grid_materiales.DataSource = dt_items_materiales
            grid_materiales.Refresh()
        End If
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_items_materiales.Rows()
            If IsDBNull(dr("id_material")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_items_materiales.Rows.Remove(dr)
        Next
    End Sub

#Region "GENERAR CODIGO BARRAS INTERNO"
    Sub generar_codigo_barras()

        Dim digito_verificador As Integer
        Dim codigoint As String
        Dim codigo_barra As String
        codigoint = GetCodigoInternoEAN13()
        digito_verificador = GetDCBarCodEAN13(GetCodigoInternoEAN13())

        codigo_barra = codigoint + CStr(digito_verificador)

        txt_codigo_barras.Text = codigo_barra

    End Sub

    Public Function obtener_codigo_articulo() As String
        Dim longitud_id = CStr(ID_ARTICULO.ToString()).Length
        Dim ceros As String = ""
        Dim limite As Integer = 5

        For i As Integer = 1 To limite - longitud_id
            ceros += "0"
        Next

        Return ceros + ID_ARTICULO.ToString()
    End Function

    Public Function GetDCBarCodEAN13(ByRef number As String) As Integer

        '*******************************************************************
        ' Nombre:     GetDCBarCodEAN13
        '             por Enrique Martínez Montejo - 07/05/2006
        '
        ' Versión:    1.0
        '
        ' Finalidad:  Calcular el dígito de control de un código de
        '             barras en formato EAN13.
        '
        ' Entradas:
        '    number:  String. El número cuyo digíto de control se desea
        '             obtener.
        ' Resultados:
        '    Integer: El dígito de control del número. En el parámetro de
        '             la función se devolverá el número completo.
        '*******************************************************************

        ' Si el número no cumple con el formato EAN13, la función
        ' devolverá una excepción de argumentos no válidos. 
        ' Para ello, la cadena deberá tener 12 caracteres de
        ' longitud, y contener sólo números.
        '
        If (number.Length <> 12) Then
            number = ""
            ' Throw New System.ArgumentException
        Else
            Dim ch As Char
            For Each ch In number
                If (Not Char.IsNumber(ch)) Then
                    number = ""
                    Throw New System.ArgumentException
                End If
            Next
        End If

        Dim x, digito, sumaCod As Integer

        ' Extrae el valor del dígito, y va
        ' sumando los valores resultantes.
        '
        For x = 11 To 0 Step -1

            digito = CInt(number.Substring(x, 1))

            Select Case x
                Case 1, 3, 5, 7, 9, 11
                    ' Las posiciones impares se multiplican por 3
                    sumaCod += (digito * 3)

                Case Else
                    ' Las posiciones pares se multiplican por 1
                    sumaCod += (digito * 1)
            End Select

        Next

        ' Calcula la decena superior
        '
        digito = (sumaCod Mod 10)

        ' Calcula el dígito de control
        '
        digito = 10 - digito

        ' Código de barras completo
        '
        number &= CStr(digito)

        ' Devuelve el dígito de control
        '
        Return digito

    End Function

    Public Function GetCodigoInternoEAN13() As String
        Dim codigoInterno As String
        Dim prefijo_pais As String = "365"
        Dim codigo_empresa As String = "0017"
        Dim codigo_producto As String

        codigo_producto = obtener_codigo_articulo()

        codigoInterno = prefijo_pais + codigo_empresa + codigo_producto

        Return codigoInterno


    End Function

#End Region

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If util.msj_confirmacion("Deseas registrar un nuevo articulo", TITULO_MSJ) Then
            EXISTE_ARTICULO = False
            nuevo()
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_codigo_barras.Text = "" Then
            If ID_ARTICULO < 0 Then
                txt_codigo.Text = obtener_codigo_articulo()
                generar_codigo_barras()
            End If
        Else
            If ID_ARTICULO < 0 Then
                txt_codigo.Text = obtener_codigo_articulo()
            End If
        End If


        If txt_codigo_barras.Text = "" Then
            generar_codigo_barras()
        End If

        If txt_codigo.Text = "" Then
            txt_codigo.Text = obtener_codigo_articulo()
        End If

        insertar_actualizar_articulo()
        EXISTE_ARTICULO = False
        nuevo()
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub cbo_tipo_articulo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub col_txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SI PRECIONA PUNTO(.) EN VEZ DE COMA(,)DEBEMOS CAMBIARLO POR COMA(,) 
        'PARA QUE LA COLUMNA CANTIDAD TOME CORRECTAMENTE LOS DATOS
        If e.KeyChar = "," Then

        ElseIf e.KeyChar = "." Then
            'ENVIA PULSACION DE COMA (,)
            SendKeys.Send(Microsoft.VisualBasic.Chr(44))
            e.Handled = True
        Else
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs)
        limpiar()
        desabilitar()
        btn_nuevo.Focus()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        EXISTE_ARTICULO = False
        Dim frm As New frm_vista_articulos()
        frm.FRM_ACTIVO = "frm_articulos"
        frm.ShowDialog()
    End Sub

    Private Sub btn_agregar_material_Click(sender As Object, e As EventArgs) Handles btn_agregar_material.Click
        Dim frm As New frm_vista_materiales()
        frm.FRM_ACTIVO = "frm_articulos"
        frm.OCULTAR_COLUMNA = "ST"
        frm.ShowDialog()
        grid_materiales.Focus()

        Dim x As Integer
        x = GridView1.RowCount
        GridView1.FocusedRowHandle = x - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(1)
        GridView1.ShowEditor()
    End Sub

    Private Sub txt_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text.Replace(" ", "") = "" Then
            Else
                txt_codigo_barras.Focus()
            End If
        End If
    End Sub

    Private Sub txt_codigo_barras_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub chk_articulo_Luk_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_articulo_Luk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_articulo_Luk.Checked = True Then
                txt_mano_obra.Focus()
            Else
                chk_activo.Focus()
            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo.Text = "" Then
                txt_proveedor.Focus()
            Else
                txt_proveedor.Focus()
            End If
        End If
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_articulos"
            frm.ShowDialog()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_proveedor.Text.Replace(" ", "") = "" Then
            Else
                txt_impuesto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_impuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_impuesto.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_tipos_impuesto
            frm.FRM_ACTIVO = "frm_articulos"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_impuesto.Text = "" Then
            Else
                txt_familia.Focus()
            End If
        End If
    End Sub

    Private Sub btn_quitar_empleado_Click(sender As Object, e As EventArgs) Handles btn_quitar_empleado.Click
        If util.msj_confirmacion("Deseas eliminar el Material", TITULO_MSJ) Then
            If GridView1.FocusedRowHandle < 0 Then
                util.mensajes("Debe seleccionar item a eliminar", TITULO_MSJ, "WAR")
                Return
            End If
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
        End If
    End Sub

    Private Sub btn_buscar_proveedor_Click(sender As Object, e As EventArgs) Handles btn_buscar_proveedor.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_articulos"
        frm.Show()
    End Sub

    Private Sub btn_buscar_impuesto_Click(sender As Object, e As EventArgs) Handles btn_buscar_impuesto.Click
        Dim frm As New frm_vista_tipos_impuesto
        frm.FRM_ACTIVO = "frm_articulos"
        frm.ShowDialog()
    End Sub

    Private Sub chk_articulo_Luk_CheckedChanged(sender As Object, e As EventArgs) Handles chk_articulo_Luk.CheckedChanged
        If chk_articulo_Luk.Checked = True Then
            GroupBox2.Visible = True
            PRODUCCION_PROPIA = True
            If btn_confirmar.Text = "Registrar" Then
                crear_cursor()
            End If
            txt_mano_obra.Visible = True
            LabelControl5.Visible = True
            txt_recargo.Focus()
        Else
            LabelControl5.Visible = False
            txt_mano_obra.Visible = False
            GroupBox2.Visible = False
            PRODUCCION_PROPIA = False
            txt_recargo.Focus()
        End If
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            frm_vista_familias.FRM_ACTIVO = "frm_articulos"
            frm_vista_familias.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_familia.Text.Replace(" ", "") = "" Then
            Else
                chk_articulo_Luk.Focus()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_buscar_familia.Click
        txt_familia.Focus()
        frm_vista_familias.FRM_ACTIVO = "frm_articulos"
        frm_vista_familias.Show()
    End Sub

    Private Sub btn_buscar_imagen_Click(sender As Object, e As EventArgs) Handles btn_buscar_imagen.Click
        If open_file_dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txt_imagen.Text = open_file_dialog.FileName
            If File.Exists(txt_imagen.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_imagen.Text, FileMode.Open, FileAccess.Read)
                pct_imagen.Image = Image.FromStream(fs)
                fs.Close()
            End If
        End If
    End Sub

    Private Sub txt_imagen_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_imagen.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If open_file_dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txt_imagen.Text = open_file_dialog.FileName
            End If
        End If
    End Sub

    Private Sub txt_mano_obra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mano_obra.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub RepositoryItemTextEdit2_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid_materiales.Focus()
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub RepositoryItemTextEdit3_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit3.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        End If
        If e.KeyCode = Keys.Enter Then
            btn_agregar_material.Focus()
        End If
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs)
        grid_materiales.Focus()
        Dim x As Integer
        x = GridView1.RowCount
        GridView1.FocusedRowHandle = x - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(1)
        GridView1.ShowEditor()
    End Sub

    Private Sub RepositoryItemTextEdit3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RepositoryItemTextEdit3.KeyPress
        'SI PRECIONA PUNTO(.) EN VEZ DE COMA(,)DEBEMOS CAMBIARLO POR COMA(,) 
        'PARA QUE LA COLUMNA CANTIDAD TOME CORRECTAMENTE LOS DATOS
        If e.KeyChar = "," Then

        ElseIf e.KeyChar = "." Then
            'ENVIA PULSACION DE COMA (,)
            SendKeys.Send(Microsoft.VisualBasic.Chr(44))
            e.Handled = True
        Else
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tab_datos_articulo_Paint(sender As Object, e As PaintEventArgs) Handles tab_datos_articulo.Paint

    End Sub

    Private Sub txt_codigo_barras_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_codigo_barras.Validating
        If articulos.existe_codigo_barras(txt_codigo_barras.Text) Then
            Return
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
            If chk_articulo_Luk.Checked = True Then
                txt_recargo.Focus()
            Else
                btn_confirmar.Focus()
            End If
        End If
    End Sub

    Private Sub txt_recargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_recargo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_articulo_Luk.Checked Then
                txt_mano_obra.Visible = True
                txt_mano_obra.Focus()
            Else
                txt_mano_obra.Visible = False
                btn_confirmar.Focus()
            End If
        End If
    End Sub
End Class