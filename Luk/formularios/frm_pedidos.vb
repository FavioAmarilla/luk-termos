Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frm_pedidos

    Private pedido As New func_pedidos
    Dim costeo As New func_costeo_pedido
    Dim articulo As New func_articulos
    Dim material As New func_materiales
    Private util As New utilidades

    'Variables para las operaciones soble la tabla pedidos
    Private ID_PEDIDO As Integer = 0
    Private ID_ARTICULO As Integer = 0
    Private ID_PROVEEDOR As Integer = 0
    Private NUMERO_PEDIDO As Integer = 0
    Private NUMERO As String = ""
    Private FECHA_PEDIDO As Date = Nothing
    Private FECHA_ENTREGA As Date = Nothing
    Private ID_CLIENTE As Integer = 0
    Private ID_VENDEDOR As Integer = 0
    Private ID_SUCURSAL As Integer = 0
    Private CANTIDAD As Double = 0
    Private COSTO_UNITARIO As Integer = 0
    Private COSTO_TOTAL As Integer = 0
    Private TOTAL_DESCTO As Integer = 0
    Private TOTAL_MANO_OBRA As Integer = 0
    Private TOTAL_ADICIONAL As Integer = 0
    Private ESTADO As String = ""
    Private PRIORIDAD As Boolean = False
    Private TEXTO_TERMO As String = ""
    Private LOGO_TERMO As String = ""
    Private TEXTO_GUAMPA As String = ""
    Private LOGO_GUAMPA As String = ""
    Private DELIVERI As Boolean = False
    Private TOTAL_VENTAS As Integer = 0
    Private OBSERVACIONES As String = ""
    Private ELIMINAR_LOGO_TERMO As String = ""
    Private ELIMINAR_LOGO_GUAMPA As String = ""
    Private PRECIO_UNITARIO As Integer = 0
    Private CODIGO_ARTICULO As String = ""
    Private RECARGO_ARTICULO As Integer = 0
    Friend Shared ver_pedido As Boolean = False

    Friend Shared obtiene_Recargo_inicial = 0
    Friend Shared id_vendedor_rc = 0



    'Variables para la copia de imagenes
    Private open_file_dialog_termos As New OpenFileDialog()
    Private open_file_dialog_guampas As New OpenFileDialog()

    'Variables utiles
    Private Const TITULO_MSJ = "<Ordenes de Pedidos>"
    Public EXISTE_PEDIDO As Boolean = False
    Public PEDIDO_REGISTRADO As Boolean = False
    Private TIENE_LOGO_TERMO As Boolean = False
    Private TIENE_LOGO_GUAMPA As Boolean = False


    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_numero_pedido()
        lbl_fecha_pedido.Text = Now.ToString("dd/MM/yyyy")
        desabilitar()
    End Sub

    Private Sub inicializar_variables()

        EXISTE_PEDIDO = False
        PEDIDO_REGISTRADO = False
        open_file_dialog_termos.InitialDirectory = "C:\"
        open_file_dialog_termos.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png"
        open_file_dialog_guampas.InitialDirectory = "C:\"
        open_file_dialog_guampas.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png"

        If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
            Dim fs As FileStream
            fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
            pct_logo_termo.Image = Image.FromStream(fs)
            pct_logo_guampa.Image = Image.FromStream(fs)
            fs.Close()
        End If
    End Sub

    Private Sub desabilitar()
        btn_buscar_articulo.Enabled = False
        txt_articulo.Enabled = False
        btn_buscar_logo_termo.Enabled = False
        txt_logo_termo.Enabled = False
        txt_texto_termo.Enabled = False
        btn_buscar_logo_guampa.Enabled = False
        txt_logo_guampa.Enabled = False
        txt_texto_guampa.Enabled = False
        btn_vendedor.Enabled = False
        btn_cliente.Enabled = False
        chk_prioridad.Enabled = False
        chk_deliveri.Enabled = False
        txt_fecha_entrega.Enabled = False
        cbo_estado.Enabled = False
        txt_vendedor.Enabled = False
        txt_cliente.Enabled = False
        txt_obsevaciones.Enabled = False
        txt_precio_unitario.Enabled = False
        txt_total.Enabled = False
        txt_cantidad.Enabled = False
        btn_confirmar_pedido.Enabled = False
        btn_imprimir_orden.Enabled = False
        btn_cancelar.Enabled = False
        btn_calendar.Enabled = False
        btn_anular_pedido.Enabled = False
        btn_costear.Enabled = False
    End Sub

    Private Sub habilitar()
        btn_buscar_articulo.Enabled = True
        txt_articulo.Enabled = True
        btn_buscar_logo_termo.Enabled = True
        txt_logo_termo.Enabled = True
        txt_texto_termo.Enabled = True
        btn_buscar_logo_guampa.Enabled = True
        txt_logo_guampa.Enabled = True
        txt_texto_guampa.Enabled = True
        btn_vendedor.Enabled = True
        btn_cliente.Enabled = True
        chk_prioridad.Enabled = True
        chk_deliveri.Enabled = True
        txt_fecha_entrega.Enabled = True
        cbo_estado.Enabled = True
        txt_vendedor.Enabled = True
        txt_cliente.Enabled = True
        txt_obsevaciones.Enabled = True
        txt_precio_unitario.Enabled = True
        txt_total.Enabled = True
        txt_cantidad.Enabled = True
        btn_confirmar_pedido.Enabled = True
        btn_imprimir_orden.Enabled = True
        btn_cancelar.Enabled = True
        btn_calendar.Enabled = True
        btn_anular_pedido.Enabled = True

        If frm_login.COSTEO_DESDE_PEDIDO = 1 Then
            btn_costear.Enabled = True
        Else
            btn_costear.Enabled = False
        End If
    End Sub

    Private Sub limpiar()
        ID_PEDIDO = 0
        ID_ARTICULO = 0
        ID_VENDEDOR = 0
        ID_CLIENTE = 0
        txt_articulo.Text = ""
        txt_cantidad.Text = ""
        txt_logo_termo.Text = ""
        txt_texto_termo.Text = ""
        txt_logo_guampa.Text = ""
        txt_texto_guampa.Text = ""
        chk_prioridad.Checked = False
        chk_deliveri.Checked = False
        txt_fecha_entrega.Text = ""
        cbo_estado.SelectedIndex = 0
        txt_vendedor.Text = ""
        txt_cliente.Text = ""
        txt_telefono.Text = ""
        txt_direccion.Text = ""
        txt_precio_unitario.Text = 0
        txt_total.Text = 0
        txt_obsevaciones.Text = ""
        ID_PEDIDO = 0
        TIENE_LOGO_TERMO = False
        TIENE_LOGO_GUAMPA = False

        If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
            Dim fs As FileStream
            fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
            pct_logo_termo.Image = Image.FromStream(fs)
            pct_logo_guampa.Image = Image.FromStream(fs)
            fs.Close()
        End If

    End Sub

    Private Sub abrir_frm_vista(ByVal formulario As String)
        If formulario = "articulos" Then
            Dim frm As New frm_vista_articulos()
            frm.FRM_ACTIVO = "frm_pedidos"
            frm.CONDICION_SQL = " WHERE a.produccion_propia=true"
            frm.Show()
        End If

        If formulario = "vendedores" Then
            Dim frm As New frm_vista_vendedores
            frm.FRM_ACTIVO = "frm_pedidos"
            frm.Show()
        End If

        If formulario = "clientes" Then
            Dim frm As New frm_vista_clientes
            frm.FRM_ACTIVO = "frm_pedidos"
            frm.Show()
        End If

        If formulario = "logo_termo" Then
            If open_file_dialog_termos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txt_logo_termo.Text = open_file_dialog_termos.FileName
                pct_logo_termo.Image = Image.FromFile(open_file_dialog_termos.FileName)
            End If
        End If

        If formulario = "logo_guampa" Then
            If open_file_dialog_guampas.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txt_logo_guampa.Text = open_file_dialog_guampas.FileName
                pct_logo_guampa.Image = Image.FromFile(open_file_dialog_guampas.FileName)
            End If
        End If
    End Sub

    Private Function copiar_imagen_termo() As Boolean
        If ELIMINAR_LOGO_TERMO.ToUpper = txt_logo_termo.Text.ToUpper Then
            LOGO_TERMO = ELIMINAR_LOGO_TERMO
            Return True
        End If

        Try
            Dim IMAG As String = frm_main.CARPETA_LOGO_TERMOS + lbl_nro_pedido.Text + ".jpg"
            LOGO_TERMO = IMAG

            'Se valida que exista el directorio
            If Directory.Exists(frm_main.CARPETA_LOGO_TERMOS) = False Then
                util.mensajes("No se encontro el directorio de Imagenes de Termos", TITULO_MSJ, "WAR")
                Return False
            End If

            'Si el campo de texto de logo esta vacio no se realiza ningun proceso y se retorna true 
            'para gardar el campo como vacio
            If txt_logo_termo.Text.Replace(" ", "") = "" Then
                Return True
            Else
                'Esta variable crea una nueva imagen a partir de la imagen seleccionada
                Dim img As New Bitmap(New Bitmap(txt_logo_termo.Text), frm_main.WIDTH_IMG, frm_main.HEIGHT_IMG)

                'Se valida si existe el archivo,si no existe se guarda la imagen 
                'si existe se elimina y se guarda la nueva imagen
                If File.Exists(IMAG) = False Then
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                Else
                    pct_logo_termo.Image.Dispose()
                    pct_logo_termo.Image = Nothing
                    File.Delete(IMAG)
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                End If

                TIENE_LOGO_TERMO = True
            End If
        Catch ex As Exception
            util.mensajes("Error al copiar Imagen de Termos: " + ex.Message, TITULO_MSJ, "WAR")
            Return False
        End Try
    End Function

    Private Function copiar_imagen_guampa() As Boolean
        If ELIMINAR_LOGO_GUAMPA = txt_logo_guampa.Text Then
            LOGO_GUAMPA = ELIMINAR_LOGO_GUAMPA
            Return True
        End If

        Try
            Dim IMAG As String = frm_main.CARPETA_LOGO_GUAMPAS + lbl_nro_pedido.Text + ".jpg"
            LOGO_GUAMPA = IMAG
            'Se valida que exista el directorio
            If Directory.Exists(frm_main.CARPETA_LOGO_GUAMPAS) = False Then
                util.mensajes("No se encontro el directorio de Imagenes de Guampas", TITULO_MSJ, "WAR")
                Return False
            End If

            'Si el campo de texto de logo esta vacio no se realiza ningun proceso y se retorna true 
            'para gardar el campo como vacio
            If txt_logo_guampa.Text.Replace(" ", "") = "" Then
                Return True
            Else
                'Esta variable crea una nueva imagen a partir de la imagen seleccionada
                Dim img As New Bitmap(New Bitmap(txt_logo_guampa.Text), frm_main.WIDTH_IMG, frm_main.HEIGHT_IMG)

                'Se valida si existe el archivo,si no existe se guarda la imagen 
                'si existe se elimina y se guarda la nueva imagen
                If File.Exists(IMAG) = False Then
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                Else
                    pct_logo_guampa.Image.Dispose()
                    pct_logo_guampa.Image = Nothing
                    File.Delete(IMAG)
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                End If
                TIENE_LOGO_GUAMPA = True
            End If
        Catch ex As Exception
            util.mensajes("Error al copiar Imagen de Guampa: " + ex.Message, TITULO_MSJ, "WAR")
            Return False
        End Try
    End Function

    Private Sub costeo_pedido()
        frm_costeo_pedido.ID_ARTICULO = ID_ARTICULO
        frm_costeo_pedido.txt_num_pedido.Text = lbl_nro_pedido.Text
        frm_costeo_pedido.lbl_descripcion_articulo.Text = txt_articulo.Text
        frm_costeo_pedido.txt_fecha_pedido.Text = lbl_fecha_pedido.Text
        frm_costeo_pedido.txt_cliente.Text = txt_cliente.Text
        frm_costeo_pedido.ID_PEDIDO = ID_PEDIDO
        frm_costeo_pedido.EXISTE_COSTEO = EXISTE_PEDIDO
        frm_costeo_pedido.lbl_cantidad_articulo.Text = txt_cantidad.Text
        frm_costeo_pedido.lbl_codigo.Text = CODIGO_ARTICULO

        frm_costeo_pedido.Show()
    End Sub

    Public Sub obtener_articulo(ByVal id As Integer)
        Dim dt_articulo As New DataTable()
        dt_articulo = pedido.consultar("SELECT id_articulo, nombre, codigo_articulo, COALESCE(precio_venta, 0), id_proveedor, COALESCE(porc_recargo, 0)
                                        FROM articulos WHERE id_articulo=" + Trim(id.ToString()) + "")

        If dt_articulo.Rows.Count <> 0 Then
            ID_ARTICULO = CInt(dt_articulo.Rows(0).Item(0))
            txt_articulo.Text = CStr(dt_articulo.Rows(0).Item(1))
            CODIGO_ARTICULO = CStr(dt_articulo.Rows(0).Item(2))
            PRECIO_UNITARIO = CInt(dt_articulo.Rows(0).Item(3))
            ID_PROVEEDOR = CInt(dt_articulo.Rows(0).Item(4))
            RECARGO_ARTICULO = CInt(dt_articulo.Rows(0).Item(5))
            txt_precio_unitario.Text = CStr(PRECIO_UNITARIO)
            txt_articulo.Focus()
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
        End If
    End Sub

    Public Sub obtener_vendedor(ByVal id As Integer)
        Dim dt_vendedor As New DataTable()
        dt_vendedor = pedido.consultar("Select id_vendedor, CONCAT(nombres,' ',apellidos) AS vendedor FROM vendedores WHERE id_vendedor=" + Trim(id.ToString()) + "")

        If dt_vendedor.Rows.Count <> 0 Then
            ID_VENDEDOR = CInt(dt_vendedor.Rows(0).Item(0))
            txt_vendedor.Text = CStr(dt_vendedor.Rows(0).Item(1))
            frm_costear_pedido.obtener_comision(ID_VENDEDOR)
            frm_costear_pedido.calcular_comision("PV")
            txt_vendedor.Focus()
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
        End If
    End Sub

    Public Sub obtener_cliente(ByVal id As Integer)
        Dim dt_clientes As New DataTable()
        dt_clientes = pedido.consultar("SELECT id_cliente, CONCAT(nombres,' ',apellidos) AS cliente, telefono, direccion FROM clientes WHERE id_cliente=" + Trim(id.ToString()) + "")

        If dt_clientes.Rows.Count <> 0 Then
            ID_CLIENTE = CInt(dt_clientes.Rows(0).Item(0))
            txt_cliente.Text = CStr(dt_clientes.Rows(0).Item(1))
            txt_telefono.Text = CStr(dt_clientes.Rows(0).Item(2))
            txt_direccion.Text = CStr(dt_clientes.Rows(0).Item(3))
            txt_cliente.Focus()
        Else
            util.mensajes("Articulo no definido", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
        End If
    End Sub

    Public Sub obtener_numero_pedido()
        Dim dt_numero As New DataTable()
        dt_numero = pedido.consultar("SELECT ultimo_nro_usado FROM asignacion_pedidos")

        If dt_numero.Rows.Count() <> 0 Then
            Dim n As Integer = CInt(dt_numero.Rows(0).Item(0))
            NUMERO_PEDIDO = n + 1
            Dim NUM As String = formato_numero(n + 1)

            If validar_numero_pedido(NUM) Then
                lbl_nro_pedido.Text = NUM
            Else
                util.mensajes("El Pedido Nro.: " + NUM + " ya existe", TITULO_MSJ, "WAR")
            End If
        Else
            NUMERO_PEDIDO = 1
            Dim NUM As String = formato_numero(1)

            If validar_numero_pedido(NUM) Then
                lbl_nro_pedido.Text = NUM
                If pedido.insertar_asignacion_pedido(1, frm_main.LOGIN_USER) = False Then
                    util.mensajes("Asignacion de pedidos no insertada", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("El Pedido Nro.: " + NUM + " ya existe", TITULO_MSJ, "WAR")
                Me.Close()
            End If
        End If
    End Sub

    Public Function validar_numero_pedido(ByVal num As String) As Boolean
        Dim dt As New DataTable()
        dt = pedido.consultar("SELECT 1 FROM pedidos WHERE numero = '" + num + "'")

        Return dt.Rows.Count = 0
    End Function

    Private Function formato_numero(ByVal ultimo_numero As Integer) As String
        Dim longitud As Integer = 7
        Dim n As String = CStr(ultimo_numero)
        Dim diferencia As Integer = longitud - (n.Length)
        Dim ceros As String = ""

        For i As Integer = 1 To diferencia
            ceros += "0"
        Next

        Return ceros + n
    End Function

    Private Sub insertar_actualizar()

        If txt_fecha_entrega.Text = "  /  /" Then
            FECHA_ENTREGA = Nothing
        Else
            FECHA_ENTREGA = CDate(txt_fecha_entrega.Text)
        End If

        If txt_total.Text.Replace(" ", "") = "" Then
            TOTAL_VENTAS = 1
        Else
            TOTAL_VENTAS = CInt(txt_total.Text)
        End If

        If txt_cantidad.Text.Replace(" ", "") = "" Then
            CANTIDAD = 1
        Else
            CANTIDAD = CDbl(txt_cantidad.Text)
        End If

        If txt_precio_unitario.Text.Replace(" ", "") = "" Then
            PRECIO_UNITARIO = 0
        Else
            PRECIO_UNITARIO = CInt(txt_precio_unitario.Text)
        End If

        'Se procede a realizar las validaciones correspondientes
        If lbl_nro_pedido.Text = "" Then
            util.mensajes("El pedido no tiene numero", TITULO_MSJ, "WAR")
        ElseIf ID_ARTICULO <= 0 Then
            util.mensajes("Seleccione un Articulo para el Pedido", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
        ElseIf ID_VENDEDOR <= 0 Then
            util.mensajes("Seleccione un Vendedor para el Pedido", TITULO_MSJ, "WAR")
            txt_vendedor.Focus()
        ElseIf ID_CLIENTE <= 0 Then
            util.mensajes("Seleccione Cliente para el Pedido", TITULO_MSJ, "WAR")
            txt_cliente.Focus()
        ElseIf txt_precio_unitario.Text <= "" Then
            util.mensajes("Articulo no tiene precio de unitario", TITULO_MSJ, "WAR")
            txt_precio_unitario.Focus()
        Else

            NUMERO = lbl_nro_pedido.Text
            FECHA_PEDIDO = CDate(lbl_fecha_pedido.Text)
            COSTO_TOTAL = 0
            TOTAL_DESCTO = 0
            TOTAL_MANO_OBRA = 0
            TOTAL_ADICIONAL = 0
            ESTADO = cbo_estado.SelectedItem.ToString()
            TEXTO_TERMO = txt_texto_termo.Text
            TEXTO_GUAMPA = txt_texto_guampa.Text
            ID_SUCURSAL = frm_main.ID_SUCURSAL
            OBSERVACIONES = txt_obsevaciones.Text

            If util.msj_confirmacion("Deseas Confirmar la operacion", TITULO_MSJ) Then

                If copiar_imagen_termo() = False Then
                    Return
                End If

                If copiar_imagen_guampa() = False Then
                    Return
                End If

                'Se realiza el insert a la base de datos
                If EXISTE_PEDIDO = False Then
                    ID_PEDIDO = pedido.id_pedido()
                    obtener_numero_pedido()
                    If pedido.insertar(ID_PEDIDO, ID_ARTICULO, NUMERO, FECHA_PEDIDO, FECHA_ENTREGA, ID_CLIENTE, ID_VENDEDOR, frm_main.ID_USUARIO, frm_main.ID_SUCURSAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, TOTAL_DESCTO, TOTAL_MANO_OBRA, TOTAL_ADICIONAL, ESTADO, PRIORIDAD, TEXTO_TERMO, LOGO_TERMO, TEXTO_GUAMPA, LOGO_GUAMPA, DELIVERI, TOTAL_VENTAS, OBSERVACIONES, PRECIO_UNITARIO, ID_PROVEEDOR) Then
                        If frm_costear_pedido.GridView1.RowCount > 0 Then
                            insertar_actualizar_costeo()
                        End If
                        'articulo.actualizar_precio_venta(CInt(txt_precio_unitario.Text), ID_ARTICULO)

                        If pedido.actualizar_asignacion_pedido(NUMERO_PEDIDO, frm_main.LOGIN_USER) = False Then
                            util.mensajes("Asignacion de pedidos no actualizado", TITULO_MSJ, "WAR")
                        End If
                        util.mensajes("Pedido Registrado", TITULO_MSJ, "INF")
                        desabilitar()
                        btn_nuevo_pedido.Focus()
                        btn_buscar_pedido.Enabled = True


                        If util.msj_confirmacion("Imprimir comprobante de pedido", TITULO_MSJ) Then
                            crear_nota_pedido()
                        End If

                        limpiar()
                        frm_costear_pedido.Close()

                        Return
                    Else
                        util.mensajes("Pedido no Registrado", TITULO_MSJ, "WAR")
                        PEDIDO_REGISTRADO = False
                    End If
                End If

                'Se realiza el update a la base de datos
                If EXISTE_PEDIDO = True Then
                    If pedido.actualizar(ID_PEDIDO, ID_ARTICULO, NUMERO, FECHA_PEDIDO, FECHA_ENTREGA, ID_CLIENTE, ID_VENDEDOR, frm_main.ID_USUARIO, frm_main.ID_SUCURSAL, CANTIDAD, COSTO_UNITARIO, COSTO_TOTAL, TOTAL_DESCTO, TOTAL_MANO_OBRA, TOTAL_ADICIONAL, ESTADO, PRIORIDAD, TEXTO_TERMO, LOGO_TERMO, TEXTO_GUAMPA, LOGO_GUAMPA, DELIVERI, TOTAL_VENTAS, OBSERVACIONES, PRECIO_UNITARIO, ID_PROVEEDOR) Then
                        If frm_costear_pedido.GridView1.RowCount > 0 Then
                            insertar_actualizar_costeo()
                        End If
                        'articulo.actualizar_precio_venta(CInt(txt_precio_unitario.Text), ID_ARTICULO)

                        util.mensajes("Pedido Actualizado", TITULO_MSJ, "INF")
                        desabilitar()
                        btn_nuevo_pedido.Focus()
                        btn_buscar_pedido.Enabled = True
                        obtener_numero_pedido()

                        If util.msj_confirmacion("Imprimir comprobante de pedido", TITULO_MSJ) Then
                            crear_nota_pedido()
                        End If


                        limpiar()
                        frm_costear_pedido.Close()

                    Else
                        util.mensajes("Pedido no Actualizado", TITULO_MSJ, "WAR")
                        PEDIDO_REGISTRADO = False
                    End If
                End If
            Else
                util.mensajes("Operacion no confirmada", TITULO_MSJ, "WAR")
                PEDIDO_REGISTRADO = False
            End If
        End If
    End Sub

    Private Sub insertar_actualizar_costeo()
        Dim id_costeo As Integer = 0
        Dim total_unitario_c As Integer = 0
        Dim total_extra_c As Integer = 0
        Dim total_mano_obra_c As Integer = 0
        Dim total_descto_c As Integer = 0
        Dim total_costo_c As Integer = 0
        Dim total_comision_c As Integer = 0
        Dim total_precio_venta_c As Integer = 0

        Dim respuesta As Boolean = False
        Dim id_material_itc As Integer = 0
        Dim cantidad_itc As Double = 0
        Dim cantidad_total_itc As Double = 0
        Dim total_unitario_itc As Integer = 0
        Dim total_costo_itc As Integer = 0
        Dim precio_venta_itc As Integer = 0
        Dim id_proveedor_itc As Integer = 0

        If frm_costear_pedido.existe_costeo = False Then
            id_costeo = costeo.id_costeo_pedido()
        Else
            id_costeo = frm_costear_pedido.id_costeo
        End If

        If frm_costear_pedido.txt_total_materia_prima.Text.Replace(" ", "") = "" Then
            total_unitario_c = 0
        Else
            total_unitario_c = CInt(frm_costear_pedido.txt_total_materia_prima.Text)
        End If

        If frm_costear_pedido.txt_total_extra.Text.Replace(" ", "") = "" Then
            total_extra_c = 0
        Else
            total_extra_c = CInt(frm_costear_pedido.txt_total_extra.Text)
        End If

        If frm_costear_pedido.txt_total_mano_obra.Text.Replace(" ", "") = "" Then
            total_mano_obra_c = 0
        Else
            total_mano_obra_c = CInt(frm_costear_pedido.txt_total_mano_obra.Text)
        End If

        If frm_costear_pedido.txt_total_descuento.Text.Replace(" ", "") = "" Then
            total_descto_c = 0
        Else
            total_descto_c = CInt(frm_costear_pedido.txt_total_descuento.Text)
        End If

        If frm_costear_pedido.txt_total_costo.Text.Replace(" ", "") = "" Then
            total_costo_c = 0
        Else
            total_costo_c = CInt(frm_costear_pedido.txt_total_costo.Text)
        End If

        If frm_costear_pedido.txt_total_comision.Text.Replace(" ", "") = "" Then
            total_comision_c = 0
        Else
            total_comision_c = CInt(frm_costear_pedido.txt_total_comision.Text)
        End If

        If frm_costear_pedido.txt_precio_venta_unt.Text.Replace(" ", "") = "" Then
            total_precio_venta_c = 0
        Else
            total_precio_venta_c = CInt(frm_costear_pedido.txt_precio_venta_unt.Text)
        End If

        If frm_costear_pedido.existe_costeo = False Then
            If costeo.insertar_costeo_pedido(id_costeo, ID_PEDIDO, ID_ARTICULO, total_costo_c, frm_main.ID_USUARIO, total_descto_c, total_descto_c, frm_main.ID_SUCURSAL, CInt(total_costo_c / CDbl(txt_cantidad.Text)), CDbl(txt_cantidad.Text), total_mano_obra_c, total_comision_c, total_precio_venta_c, ID_PROVEEDOR) Then

                'articulo.actualizar_costo(CInt(total_costo_c / CDbl(txt_cantidad.Text)), ID_ARTICULO)

                If costeo.actualizar_estado_pedido("COSTEADO", ID_PEDIDO) Then
                    For i As Integer = 0 To frm_costear_pedido.GridView1.RowCount() - 1
                        id_material_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "id_material"))
                        cantidad_itc = CDbl(frm_costear_pedido.GridView1.GetRowCellValue(i, "cantidad"))
                        cantidad_total_itc = CDbl(frm_costear_pedido.GridView1.GetRowCellValue(i, "cantidad_total"))
                        total_unitario_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "costo_unitario"))
                        total_costo_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "costo_total"))
                        precio_venta_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "precio_venta"))
                        id_proveedor_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "id_proveedor"))

                        respuesta = costeo.insertar_costeo_item(id_costeo, id_material_itc, cantidad_itc, total_unitario_itc, total_costo_itc, txt_cantidad.Text, precio_venta_itc, id_proveedor_itc)

                        material.actualizar_costo(total_unitario_itc, id_material_itc)
                        'Si la variable respuesta queda en false es porque ocurrio un error al insertar los items,
                        'en ese caso realizamos un return para salir del metodo
                        If respuesta = False Then
                            util.mensajes("Items de Costeo no registrados", TITULO_MSJ, "WAR")
                            Return
                        End If
                    Next

                    Dim total_costo_co As Integer = CInt(frm_costear_pedido.txt_total_costo.Text)
                    Dim total_descto_co As Integer = CInt(frm_costear_pedido.txt_total_descuento.Text)
                    Dim total_mano_obra_co As Integer = CInt(frm_costear_pedido.txt_total_mano_obra.Text)
                    Dim total_total_extra_co As Integer = CInt(frm_costear_pedido.txt_total_extra.Text)
                    'Se actualiza los campos de totales en la base de datos y en el frm_pedido
                    If costeo.actualizar_totales_pedido(total_costo_c / CInt(txt_cantidad.Text), total_costo_c, total_descto_c, total_mano_obra_c, total_extra_c, ID_PEDIDO, total_comision_c, CInt(txt_precio_unitario.Text), CInt(txt_total.Text)) = False Then
                        util.mensajes("Totales del pedido no actualizados", TITULO_MSJ, "WAR")
                    End If
                Else
                    util.mensajes("Estado del Pedido no actualizado", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("Costeo de Pedido no Registrado", TITULO_MSJ, "WAR")
            End If
        End If


        If frm_costear_pedido.existe_costeo Then
            Dim cantidad_articulo As Integer = 0

            'Se eliminan todos los items del costeo si es que hay registros
            costeo.eliminar_costeo_item(frm_costear_pedido.id_costeo)
            'Se insertan los nuevos valores
            If txt_cantidad.Text = "" Then
                cantidad_articulo = 0
            Else
                cantidad_articulo = CDbl(txt_cantidad.Text)
            End If
            If costeo.actualizar_costeo_pedido(ID_PEDIDO, ID_ARTICULO, total_costo_c, total_descto_c, total_extra_c, frm_main.ID_USUARIO, frm_main.ID_SUCURSAL, total_unitario_c, cantidad_articulo, frm_costear_pedido.id_costeo, total_mano_obra_c, total_comision_c, total_precio_venta_c, ID_PROVEEDOR) Then

                costeo.actualizar_estado_pedido("COSTEADO", ID_PEDIDO)

                For i As Integer = 0 To frm_costear_pedido.GridView1.RowCount() - 1
                    id_material_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "id_material"))
                    cantidad_itc = CDbl(frm_costear_pedido.GridView1.GetRowCellValue(i, "cantidad"))
                    cantidad_total_itc = CDbl(frm_costear_pedido.GridView1.GetRowCellValue(i, "cantidad_total"))
                    total_unitario_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "costo_unitario"))
                    total_costo_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "costo_total"))
                    precio_venta_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "precio_venta"))
                    id_proveedor_itc = CInt(frm_costear_pedido.GridView1.GetRowCellValue(i, "id_proveedor"))

                    If costeo.insertar_costeo_item(id_costeo, id_material_itc, cantidad_itc, total_unitario_itc, total_costo_itc, txt_cantidad.Text, precio_venta_itc, id_proveedor_itc) = False Then
                        util.mensajes("Items de Costeo no registrados", TITULO_MSJ, "WAR")
                        Return
                    End If
                Next

                'Se actualiza los campos de totales en la base de datos y en el frm_pedido
                If costeo.actualizar_totales_pedido(total_costo_c / CInt(txt_cantidad.Text), total_costo_c, total_descto_c, total_mano_obra_c, total_extra_c, ID_PEDIDO, total_comision_c, CInt(txt_precio_unitario.Text), CInt(txt_total.Text)) = False Then
                    util.mensajes("Totales del pedido no actualizados", TITULO_MSJ, "WAR")
                End If
            Else
                util.mensajes("Costeo de Pedido no Actualizado", TITULO_MSJ, "WAR")
            End If
        End If
    End Sub

    Public Sub obtener_pedido(ByVal id As Integer)
        Dim dt As New DataTable()
        dt = pedido.consultar("SELECT id_pedido, id_articulo, numero, fecha_pedido, id_cliente, id_vendedor, 
                               cantidad, estado, texto_termo, COALESCE(logo_termo,''), texto_guampa, COALESCE(logo_guampa,''), 
                               deliveri, prioridad, fecha_entrega, total_precio_venta, observaciones, COALESCE(precio_unitario,0),
                               estado FROM pedidos WHERE id_pedido=" + Trim(id.ToString()) + "")

        If dt.Rows.Count <> 0 Then
            ID_PEDIDO = CInt(dt.Rows(0).Item(0))
            obtener_articulo(CInt(dt.Rows(0).Item(1)))
            lbl_nro_pedido.Text = CStr(dt.Rows(0).Item(2))
            lbl_fecha_pedido.Text = CStr(dt.Rows(0).Item(3))
            obtener_cliente(CInt(dt.Rows(0).Item(4)))
            obtener_vendedor(CInt(dt.Rows(0).Item(5)))
            txt_cantidad.Text = CStr(dt.Rows(0).Item(6))
            cbo_estado.SelectedItem = dt.Rows(0).Item(7)
            txt_texto_termo.Text = CStr(dt.Rows(0).Item(8))
            txt_logo_termo.Text = CStr(dt.Rows(0).Item(9))
            txt_texto_guampa.Text = CStr(dt.Rows(0).Item(10))
            txt_logo_guampa.Text = CStr(dt.Rows(0).Item(11))
            chk_deliveri.Checked = CBool(dt.Rows(0).Item(12))
            chk_prioridad.Checked = CBool(dt.Rows(0).Item(13))
            txt_fecha_entrega.Text = CStr(dt.Rows(0).Item(14))
            txt_total.Text = CStr(dt.Rows(0).Item(15))
            txt_obsevaciones.Text = CStr(dt.Rows(0).Item(16))
            txt_precio_unitario.Text = CStr(dt.Rows(0).Item(17))
            ESTADO = CStr(dt.Rows(0).Item(18))

            id_vendedor_rc = (CInt(dt.Rows(0).Item(5)))




            If ESTADO = "COSTEADO" Then
                If ver_pedido = False Then
                    frm_costear_pedido.obtener_pedido(ID_PEDIDO)
                End If
                frm_costear_pedido.existe_costeo = True
                frm_costear_pedido.Show()
                frm_costear_pedido.Visible = False
            End If


            If File.Exists(txt_logo_termo.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_logo_termo.Text, FileMode.Open, FileAccess.Read)
                pct_logo_termo.Image = Image.FromStream(fs)
                fs.Close()
                TIENE_LOGO_TERMO = True
                ELIMINAR_LOGO_TERMO = CStr(dt.Rows(0).Item(9))
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_logo_termo.Image = Image.FromStream(fs)
                    fs.Close()
                End If
                TIENE_LOGO_TERMO = False
            End If

            If File.Exists(txt_logo_guampa.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_logo_guampa.Text, FileMode.Open, FileAccess.Read)
                pct_logo_guampa.Image = Image.FromStream(fs)
                fs.Close()
                TIENE_LOGO_GUAMPA = True
                ELIMINAR_LOGO_GUAMPA = CStr(dt.Rows(0).Item(11))
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_logo_guampa.Image = Image.FromStream(fs)
                    fs.Close()
                End If
                TIENE_LOGO_GUAMPA = False
            End If

            EXISTE_PEDIDO = True
            PEDIDO_REGISTRADO = True
            btn_confirmar_pedido.Text = "Actualizar"
            habilitar()
        Else
            util.mensajes("Pedido no Registrado", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
        End If
    End Sub

    Private Sub crear_nota_pedido()
        Dim report As New rpt_pedido_cliente
        Dim dt As New DataTable

        dt = get_materias_primas()

        report.Parameters("nro_pedido").Value = lbl_nro_pedido.Text
        report.Parameters("fecha_pedido").Value = lbl_fecha_pedido.Text
        If chk_prioridad.Checked Then
            report.Parameters("prioridad").Value = True
        Else
            report.Parameters("prioridad").Value = False
        End If

        If chk_deliveri.Checked Then
            report.Parameters("delivery").Value = True
        Else
            report.Parameters("delivery").Value = False
        End If

        report.DataSource = dt
        report.Parameters("fecha_entrega").Value = txt_fecha_entrega.Text
        report.Parameters("vendedor").Value = txt_vendedor.Text
        report.Parameters("cliente").Value = txt_cliente.Text
        report.Parameters("telefono").Value = txt_telefono.Text
        report.Parameters("direccion").Value = txt_direccion.Text
        report.Parameters("articulo").Value = txt_articulo.Text
        report.Parameters("cantidad").Value = txt_cantidad.Text
        report.Parameters("precio_unitario").Value = txt_precio_unitario.Text
        report.Parameters("precio_total").Value = txt_total.Text
        report.Parameters("comentario").Value = txt_obsevaciones.Text

        report.Parameters("nro_pedido").Visible = False
        report.Parameters("fecha_pedido").Visible = False
        report.Parameters("prioridad").Visible = False
        report.Parameters("delivery").Visible = False
        report.Parameters("fecha_entrega").Visible = False
        report.Parameters("vendedor").Visible = False
        report.Parameters("cliente").Visible = False
        report.Parameters("telefono").Visible = False
        report.Parameters("direccion").Visible = False
        report.Parameters("articulo").Visible = False
        report.Parameters("cantidad").Visible = False
        report.Parameters("precio_unitario").Visible = False
        report.Parameters("precio_total").Visible = False
        report.Parameters("comentario").Visible = False


        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub


    '-----------------------------------------------------------------------------------
    '----------------------Eventos de Controles del Formulario--------------------------
    '-----------------------------------------------------------------------------------

    Private Sub chk_prioridad_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_prioridad.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_deliveri.Focus()
        End If
    End Sub

    Private Sub chk_deliveri_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_deliveri.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_entrega.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txt_fecha_entrega.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            chk_prioridad.Focus()
        End If



    End Sub

    Private Sub txt_fecha_entrega_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_entrega.Text = "  /  /" Then
            Else
                cbo_estado.Focus()
            End If
        End If

        If e.KeyCode = Keys.Down Then
            cbo_estado.Focus()

        ElseIf e.KeyCode = Keys.Up Then
            chk_deliveri.Focus()
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            CalendarControl1.Focus()
            mostar_calendar()
        End If
    End Sub

    Private Sub cbo_estado_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_estado.KeyDown
        If cbo_estado.SelectedIndex < 0 Then
        Else
            txt_vendedor.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txt_vendedor.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_fecha_entrega.Focus()
        End If

    End Sub

    Private Sub txt_vendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_vendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ID_VENDEDOR > 0 Then
                txt_cliente.Focus()
            End If
        End If

        If e.KeyCode = Keys.Down Then
            txt_cliente.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cbo_estado.Focus()
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            abrir_frm_vista("vendedores")
        End If
    End Sub

    Private Sub txt_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ID_CLIENTE > 0 Then
                txt_telefono.Focus()
            End If

        End If

        If e.KeyCode = Keys.Down Then
            txt_telefono.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_vendedor.Focus()

        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            abrir_frm_vista("clientes")
        End If
    End Sub

    Private Sub txt_telefono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_direccion.Focus()
        End If

        If e.KeyCode = Keys.Up Then
            txt_cliente.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            txt_direccion.Focus()

        End If

    End Sub

    Private Sub txt_direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cliente As New func_clientes
            cliente.actualizar_direccion(txt_direccion.Text, ID_CLIENTE)
            txt_articulo.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            txt_articulo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_telefono.Focus()

        End If

    End Sub

    Private Sub txt_total_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Se actualiza el precio de venta del articulo
            txt_obsevaciones.Focus()
            If txt_precio_unitario.Text = "" Then
                Return
            End If
        End If

        e.Handled = True

        If e.KeyCode = Keys.Down Then
            txt_obsevaciones.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_precio_unitario.Focus()

        End If

    End Sub

    Private Sub txt_articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ID_ARTICULO > 0 Then
                txt_cantidad.Focus()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            txt_cantidad.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_direccion.Focus()
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            abrir_frm_vista("articulos")
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_cantidad.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then


            If txt_cantidad.Text.Replace(" ", "") = "" Then
                txt_cantidad.Text = "1"
                txt_logo_termo.Focus()

            Else
                txt_logo_termo.Focus()
            End If


            frm_costear_pedido.actualizar_grilla(CInt(txt_cantidad.Text))




            End If
        If e.KeyCode = Keys.Down Then
            txt_logo_termo.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_articulo.Focus()
        End If

    End Sub

    Private Sub txt_logo_termo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_logo_termo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_texto_termo.Focus()
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            abrir_frm_vista("logo_termo")
        End If

        If e.KeyCode = Keys.Down Then
            txt_texto_termo.Focus()

        ElseIf e.KeyCode = Keys.Up Then
            txt_cantidad.Focus()

        End If

    End Sub

    Private Sub txt_texto_termo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_texto_termo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_logo_guampa.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txt_logo_guampa.Focus()

        ElseIf e.KeyCode = Keys.Up Then
            txt_logo_termo.Focus()


        End If

    End Sub

    Private Sub txt_logo_guampa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_logo_guampa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_texto_guampa.Focus()
        End If

        If e.KeyCode = Keys.Down Then
            txt_texto_guampa.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_texto_termo.Focus()
        End If


        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            abrir_frm_vista("logo_guampa")
        End If
    End Sub

    Private Sub txt_texto_guampa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_texto_guampa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_precio_unitario.Focus()
            txt_precio_unitario.Text = CStr(PRECIO_UNITARIO)
        End If

        If e.KeyCode = Keys.Down Then
            txt_precio_unitario.Focus()


        ElseIf e.KeyCode = Keys.Up Then
            txt_logo_guampa.Focus()




        End If

    End Sub

    Private Sub btn_buscar_articulo_Click(sender As Object, e As EventArgs) Handles btn_buscar_articulo.Click
        abrir_frm_vista("articulos")
    End Sub

    Private Sub btn_buscar_logo_termo_Click(sender As Object, e As EventArgs) Handles btn_buscar_logo_termo.Click
        abrir_frm_vista("logo_termo")
    End Sub

    Private Sub btn_buscar_logo_guampa_Click(sender As Object, e As EventArgs) Handles btn_buscar_logo_guampa.Click
        abrir_frm_vista("logo_guampa")
    End Sub

    Private Sub btn_vendedor_Click(sender As Object, e As EventArgs) Handles btn_vendedor.Click
        abrir_frm_vista("vendedores")
    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        abrir_frm_vista("clientes")
    End Sub


    '-----------------------------------------------------------------------------------
    '-----------------------Eventos de Botones del Formulario---------------------------
    '-----------------------------------------------------------------------------------
    Private Sub btn_nuevo_pedido_Click(sender As Object, e As EventArgs) Handles btn_nuevo_pedido.Click
        limpiar()
        habilitar()

        obtener_numero_pedido()
        inicializar_variables()
        EXISTE_PEDIDO = False
        btn_confirmar_pedido.Text = "Registrar"
        chk_prioridad.Focus()
        btn_nuevo_pedido.Enabled = False
        btn_anular_pedido.Enabled = False
        btn_buscar_pedido.Enabled = False
        obtiene_Recargo_inicial = 0
    End Sub

    Private Sub btn_buscar_pedido_Click(sender As Object, e As EventArgs) Handles btn_buscar_pedido.Click
        Dim frm As New frm_vista_pedidos()
        frm.FRM_ACTIVO = "frm_pedidos"
        frm.CONDICION_SQL = "WHERE usr_anulacion IS NULL AND COALESCE(facturado,false)=false AND COALESCE(entregado,false)=false"
        frm.Show()
    End Sub

    Private Sub btn_costear_pedido_Click(sender As Object, e As EventArgs)
        If PEDIDO_REGISTRADO Then
            costeo_pedido()
        Else
            util.mensajes("Debe registrar el pedido para costear", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Sub btn_confirmar_pedido_Click(sender As Object, e As EventArgs) Handles btn_confirmar_pedido.Click

        insertar_actualizar()
        frm_costear_pedido.Close()
        btn_nuevo_pedido.Enabled = True
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Pedidos") Then
            limpiar()
            desabilitar()
            btn_nuevo_pedido.Enabled = True
            btn_buscar_pedido.Enabled = True
            btn_nuevo_pedido.Focus()
        End If
    End Sub

    Private Sub txt_obsevaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obsevaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_confirmar_pedido.Focus()
        End If
    End Sub

    Sub mostar_calendar()
        If CalendarControl1.Visible = False Then
            CalendarControl1.Visible = True
            CalendarControl1.Focus()
        Else
            CalendarControl1.Visible = False
        End If
    End Sub


    Function get_materias_primas() As DataTable
        Dim dt As New DataTable
        dt = pedido.consultar("SELECT ma.nombre AS material, it.cantidad
                                FROM costeo_item it
                                LEFT JOIN costeo_de_pedido cp on cp.id_costeo_de_pedido  = it.id_costeo_de_pedido 
                                LEFT JOIN materiales ma ON ma.id_material = it.id_material
                                WHERE cp.id_pedido = " & ID_PEDIDO.ToString)
        Return dt
    End Function

    Private Sub btn_calendar_Click(sender As Object, e As EventArgs) Handles btn_calendar.Click
        mostar_calendar()
        CalendarControl1.Focus()
    End Sub

    Private Sub CalendarControl1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_fecha_entrega.Text = CalendarControl1.DateTime.ToString
            CalendarControl1.Visible = False
            txt_fecha_entrega.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            CalendarControl1.Visible = False
            txt_fecha_entrega.Focus()
        End If
    End Sub

    Private Sub CalendarControl1_DoubleClick_1(sender As Object, e As EventArgs) Handles CalendarControl1.DoubleClick
        txt_fecha_entrega.Text = CalendarControl1.DateTime.ToString
        CalendarControl1.Visible = False
        txt_fecha_entrega.Focus()
    End Sub

    Private Sub CalendarControl1_KeyDown_1(sender As Object, e As KeyEventArgs) Handles CalendarControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_entrega.Text = CalendarControl1.DateTime.ToString
            CalendarControl1.Visible = False
            txt_fecha_entrega.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            CalendarControl1.Visible = False
            txt_fecha_entrega.Focus()
        End If
    End Sub


    Private Sub txt_costo_unitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_precio_unitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_total.Text = CStr(CInt(txt_precio_unitario.Text) * CInt(txt_cantidad.Text))
            txt_total.Focus()
        End If

        e.Handled = True

        If e.KeyCode = Keys.Down Then
            txt_total.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txt_texto_guampa.Focus()

        End If
    End Sub

    Private Sub btn_anular_pedido_Click(sender As Object, e As EventArgs) Handles btn_anular_pedido.Click
        If ID_PEDIDO <= 0 Then
            util.mensajes("Seleccione pedido para Anular", TITULO_MSJ, "WAR")
            Return
        End If

        If util.msj_confirmacion("Deseas anular el Pedido", TITULO_MSJ) = False Then
            util.mensajes("Pedido no Anulado", TITULO_MSJ, "WAR")
            Return
        End If

        If pedido.anular_pedido(ID_PEDIDO, frm_main.LOGIN_USER) Then
            util.mensajes("Pedido Anulado", TITULO_MSJ, "WAR")
            limpiar()
        Else
            util.mensajes("Pedido no Anulado", TITULO_MSJ, "WAR")
        End If

    End Sub

    Private Sub btn_imprimir_orden_Click(sender As Object, e As EventArgs) Handles btn_imprimir_orden.Click
        If ID_PEDIDO <= 0 Then
            util.mensajes("Debe seleccionar pedido a imprimir", TITULO_MSJ, "WAR")
            btn_buscar_pedido.Focus()
            Return
        End If
        crear_nota_pedido()
    End Sub

    Private Sub CalendarControl1_Click(sender As Object, e As EventArgs)
        txt_fecha_entrega.Text = CalendarControl1.DateTime.ToString
        CalendarControl1.Visible = False
        txt_fecha_entrega.Focus()
    End Sub

    Private Sub txt_precio_unitario_Validated(sender As Object, e As EventArgs) Handles txt_precio_unitario.Validated
        txt_total.Text = CStr(CInt(txt_precio_unitario.Text) * CInt(txt_cantidad.Text))

    End Sub

    Private Sub btn_costear_Click(sender As Object, e As EventArgs) Handles btn_costear.Click
        Dim numero As String = lbl_nro_pedido.Text
        Dim articulo As String = txt_articulo.Text


        Dim cantidad As Integer = 0
        Dim precio_unitaro As Integer = 0

        If txt_cantidad.Text = "" Then
            cantidad = 0
        Else
            cantidad = CInt(txt_cantidad.Text)
        End If

        If txt_precio_unitario.Text = "" Then
            precio_unitaro = 0
        Else
            precio_unitaro = CInt(txt_precio_unitario.Text)
        End If

        If ID_ARTICULO <= 0 Then
            util.mensajes("Debe seleccionar Articulo", TITULO_MSJ, "WAR")
            txt_articulo.Focus()
            Return
        End If


        If cbo_estado.SelectedItem = "COSTEADO" Then
            If obtiene_Recargo_inicial = 0 Then
                frm_costear_pedido.obtener_pedido(ID_PEDIDO)
            End If

            If id_vendedor_rc <> ID_VENDEDOR Then
                frm_costear_pedido.obtener_comision(ID_VENDEDOR)
                frm_costear_pedido.calcular_comision("PV")
            End If

            frm_costear_pedido.name_articulo(articulo, cantidad)
            frm_costear_pedido.obtener_totales()
            frm_costear_pedido.obtener_recargo("PO")
            frm_costear_pedido.Show()
        Else
            If obtiene_Recargo_inicial = 0 Then
                frm_costear_pedido.set_pedido(numero, cantidad, articulo, precio_unitaro, ID_VENDEDOR, RECARGO_ARTICULO)
                frm_costear_pedido.obtiene_recargo(RECARGO_ARTICULO)
                frm_costear_pedido.obtener_materiales(ID_ARTICULO, "I")
                obtiene_Recargo_inicial = 1
            End If

            frm_costear_pedido.obtener_totales()
            frm_costear_pedido.obtener_comision(ID_VENDEDOR)
            'si porcentaje de recago es mayor a cero calcula el precio de venta
            If RECARGO_ARTICULO > 0 Then
                frm_costear_pedido.obtener_recargo("PV")
            End If
            'si porcentaje de recago es menor a cero calcula el porcentaje
            If RECARGO_ARTICULO <= 0 Then
                frm_costear_pedido.obtener_recargo("PO")
            End If

            frm_costear_pedido.name_articulo(articulo, cantidad)
            frm_costear_pedido.Show()
        End If
    End Sub

    Private Sub chk_prioridad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_prioridad.CheckedChanged
        If chk_prioridad.Checked Then
            PRIORIDAD = True
        Else
            PRIORIDAD = False
        End If
    End Sub

    Private Sub chk_deliveri_CheckedChanged(sender As Object, e As EventArgs) Handles chk_deliveri.CheckedChanged
        If chk_deliveri.Checked Then
            DELIVERI = True
        Else
            DELIVERI = False
        End If
    End Sub

    Private Sub txt_cantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_cantidad.Validating
        If txt_cantidad.Text.Replace(" ", "") = "" Then
            txt_cantidad.Text = "1"
        End If

        If util.CheckForm(frm_costear_pedido) Then
            frm_costear_pedido.actualizar_grilla(CInt(txt_cantidad.Text))
        End If

    End Sub

    Private Sub txt_precio_unitario_Spin(sender As Object, e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles txt_precio_unitario.Spin

    End Sub
End Class