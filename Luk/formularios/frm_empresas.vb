Imports System.IO

Public Class frm_empresas

    Private empresa As New func_empresas()
    Private util As New utilidades()
    Private dt_empresas As New DataTable()

    Private open_file_dialog As New OpenFileDialog()
    Private Const TITULO_MSJ = "<Definicion de Param. de Empresas>"

    Private ID_EMPRESA As Integer = 0
    Private NOMBRE As String = ""
    Private TELEFONO As String = ""
    Private NUMERO_DOCUMENTO As String = ""
    Private EMAIL As String = ""
    Private PAGINA_WEB As String = ""
    Private PAIS As String = ""
    Private CIUDAD As String = ""
    Private DIRECCION As String = ""
    Private LOGO_EMPRESA As String = ""
    Private LOGO_EMPRESA_ANT As String = ""
    Private IMG_NO_DISPONIBLE As String = ""
    Private IMG_NO_DISPONIBLE_ANT As String = ""
    Private RUTA_IMG_RECURSOS As String = ""
    Private RUTA_IMG_ARTICULOS As String = ""
    Private RUTA_IMG_GUAMPAS As String = ""
    Private RUTA_IMG_TERMOS As String = ""

    Private Sub frm_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        desabilitar()
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub desabilitar()
        txt_nombre.Enabled = False
        txt_telefono.Enabled = False
        txt_nro_documeto.Enabled = False
        txt_email.Enabled = False
        txt_pagina_web.Enabled = False
        txt_pais.Enabled = False
        txt_ciudad.Enabled = False
        txt_direccion.Enabled = False
        txt_logo_empresa.Enabled = False
        btn_confirmar.Enabled = False
    End Sub

    Private Sub habilitar()
        txt_nombre.Enabled = True
        txt_telefono.Enabled = True
        txt_nro_documeto.Enabled = True
        txt_email.Enabled = True
        txt_pagina_web.Enabled = True
        txt_pais.Enabled = True
        txt_ciudad.Enabled = True
        txt_direccion.Enabled = True
        txt_logo_empresa.Enabled = True
        btn_confirmar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_telefono.Text = ""
        txt_nro_documeto.Text = ""
        txt_email.Text = ""
        txt_pagina_web.Text = ""
        txt_pais.Text = ""
        txt_ciudad.Text = ""
        txt_direccion.Text = ""
        txt_logo_empresa.Text = ""
        btn_confirmar.Text = "Registrar"

        txt_img_articulos.Text = ""
        txt_img_recursos.Text = ""
        txt_img_no_disponible.Text = ""
        txt_img_termos.Text = ""
        txt_img_guampas.Text = ""

        If Directory.Exists(frm_main.CARPETA_IMG_RECURSOS) Then
            If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                Dim fs As FileStream
                fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, IO.FileAccess.Read)
                pct_logo_empresa.Image = Image.FromStream(fs)
                fs.Close()
            End If
        Else
            util.mensajes("No se encontro el directorio de Imagenes", TITULO_MSJ, "WAR")
        End If
    End Sub

    Private Function copiar_imagenes() As Boolean
        If LOGO_EMPRESA_ANT = txt_logo_empresa.Text Then
            LOGO_EMPRESA = LOGO_EMPRESA_ANT
            Return True
        End If

        If frm_main.CARPETA_IMG_RECURSOS = "" Then
            frm_main.CARPETA_IMG_RECURSOS = txt_img_recursos.Text
        End If

        If frm_main.CARPETA_IMG_RECURSOS = "" Then
            util.mensajes("Debe ingresar directorio de recursos", TITULO_MSJ, "WAR")
            Return False
        End If

        Try
            Dim IMAG As String = frm_main.CARPETA_IMG_RECURSOS + "logo_empresa.jpg"
            LOGO_EMPRESA = IMAG

            'Se valida que exista el directorio
            If Directory.Exists(frm_main.CARPETA_IMG_RECURSOS) = False Then
                util.mensajes("No se encontro el directorio de Imagenes", TITULO_MSJ, "WAR")
                Return False
            End If

            'Si el campo de texto de logo esta vacio no se realiza ningun proceso y se retorna true 
            'para gardar el campo como vacio
            If txt_logo_empresa.Text.Replace(" ", "") = "" Then
                Return True
            Else
                'Esta variable crea una nueva imagen a partir de la imagen seleccionada
                Dim img As New Bitmap(New Bitmap(txt_logo_empresa.Text), frm_main.WIDTH_IMG, frm_main.HEIGHT_IMG)

                'Se valida si existe el archivo,si no existe se guarda la imagen 
                'si existe se elimina y se guarda la nueva imagen
                If File.Exists(IMAG) = False Then
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                Else
                    pct_logo_empresa.Image.Dispose()
                    pct_logo_empresa.Image = Nothing
                    File.Delete(IMAG)
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                End If
            End If
        Catch ex As Exception
            util.mensajes("Error al copiar Logo de Empresa: " + ex.Message, TITULO_MSJ, "WAR")
            Return False
        End Try
    End Function

    Private Function copiar_imagen_no_disponible() As Boolean
        If IMG_NO_DISPONIBLE_ANT = txt_img_no_disponible.Text Then
            IMG_NO_DISPONIBLE = IMG_NO_DISPONIBLE_ANT
            Return True
        End If

        If frm_main.CARPETA_IMG_RECURSOS = "" Then
            frm_main.CARPETA_IMG_RECURSOS = txt_img_recursos.Text
        End If

        If frm_main.CARPETA_IMG_RECURSOS = "" Then
            util.mensajes("Debe ingresar directorio de recursos", TITULO_MSJ, "WAR")
            Return False
        End If


        Try
            Dim IMAG As String = frm_main.CARPETA_IMG_RECURSOS + "img_no_disponible.jpg"
            IMG_NO_DISPONIBLE = IMAG

            'Se valida que exista el directorio
            If Directory.Exists(frm_main.CARPETA_IMG_RECURSOS) = False Then
                util.mensajes("No se encontro el directorio de Imagenes", TITULO_MSJ, "WAR")
                Return False
            End If

            'Si el campo de texto de logo esta vacio no se realiza ningun proceso y se retorna true 
            'para gardar el campo como vacio
            If txt_img_no_disponible.Text.Replace(" ", "") = "" Then
                Return True
            Else
                'Esta variable crea una nueva imagen a partir de la imagen seleccionada
                Dim img As New Bitmap(New Bitmap(txt_img_no_disponible.Text), 300, 300)

                'Se valida si existe el archivo,si no existe se guarda la imagen 
                'si existe se elimina y se guarda la nueva imagen
                If File.Exists(IMAG) = False Then
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                Else
                    File.Delete(IMAG)
                    img.Save(IMAG, Imaging.ImageFormat.Jpeg)
                    Return True
                End If
            End If
        Catch ex As Exception
            util.mensajes("Error al copiar Img. no Disponible: " + ex.Message, TITULO_MSJ, "WAR")
            Return False
        End Try
    End Function

    Private Sub buscar_imagenes(accion As String)
        If accion = "articulos" Then
            FolderBrowserDialog1 = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txt_img_articulos.Text = FolderBrowserDialog1.SelectedPath
            End If
        End If
        If accion = "recursos" Then
            FolderBrowserDialog1 = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txt_img_recursos.Text = FolderBrowserDialog1.SelectedPath
            End If
        End If
        If accion = "no_disponible" Then
            If open_file_dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txt_img_no_disponible.Text = open_file_dialog.FileName
            End If
        End If
        If accion = "termos" Then
            FolderBrowserDialog1 = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txt_img_termos.Text = FolderBrowserDialog1.SelectedPath
            End If
        End If
        If accion = "guampas" Then
            FolderBrowserDialog1 = New FolderBrowserDialog
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                txt_img_guampas.Text = FolderBrowserDialog1.SelectedPath
            End If
        End If
    End Sub

    Private Sub listar()
        dt_empresas = empresa.listar("SELECT * FROM empresas ORDER BY fecha_cre DESC, fecha_mod DESC")
        grid_empresas.DataSource = dt_empresas
    End Sub

    Private Sub insertar_actualizar()
        If txt_nombre.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese nombre de la empresa", TITULO_MSJ, "WAR")
            txt_nombre.Focus()
        ElseIf txt_telefono.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese nro. de telefono de la empresa", TITULO_MSJ, "WAR")
            txt_telefono.Focus()
        ElseIf txt_nro_documeto.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese nro. de documento de la empresa", TITULO_MSJ, "WAR")
            txt_nro_documeto.Focus()
        ElseIf txt_pais.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese pais de la empresa", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf txt_ciudad.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese ciudad de la empresa", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        ElseIf txt_direccion.Text.Replace(" ", "") = "" Then
            util.mensajes("Ingrese direccion de la empresa", TITULO_MSJ, "WAR")
            txt_direccion.Focus()
        Else
            If util.msj_confirmacion("Deseas confirmar la operacion", TITULO_MSJ) Then
                    NOMBRE = txt_nombre.Text
                    TELEFONO = txt_telefono.Text
                    NUMERO_DOCUMENTO = txt_nro_documeto.Text
                    EMAIL = txt_email.Text
                    PAGINA_WEB = txt_pagina_web.Text
                    PAIS = txt_pais.Text
                    CIUDAD = txt_ciudad.Text
                    DIRECCION = txt_direccion.Text
                    RUTA_IMG_ARTICULOS = txt_img_articulos.Text
                    RUTA_IMG_RECURSOS = txt_img_recursos.Text
                    IMG_NO_DISPONIBLE = txt_img_no_disponible.Text
                    RUTA_IMG_GUAMPAS = txt_img_guampas.Text
                    RUTA_IMG_TERMOS = txt_img_termos.Text

                If copiar_imagenes() = False Then
                    Return
                End If

                If copiar_imagen_no_disponible() = False Then
                    Return
                End If

                If ID_EMPRESA < 1 Then
                        If empresa.insertar(NOMBRE, TELEFONO, NUMERO_DOCUMENTO, EMAIL, PAGINA_WEB, PAIS, CIUDAD, DIRECCION, LOGO_EMPRESA, RUTA_IMG_RECURSOS, RUTA_IMG_TERMOS, RUTA_IMG_GUAMPAS, RUTA_IMG_ARTICULOS, IMG_NO_DISPONIBLE) Then
                            util.mensajes("Empresa registrada", TITULO_MSJ, "INF")
                            limpiar()
                            desabilitar()
                            btn_nuevo.Focus()
                        Else
                            util.mensajes("Empresa no registrada", TITULO_MSJ, "WAR")
                        End If
                    End If

                    If ID_EMPRESA > 0 Then
                        If empresa.actualizar(NOMBRE, TELEFONO, NUMERO_DOCUMENTO, EMAIL, PAGINA_WEB, PAIS, CIUDAD, DIRECCION, LOGO_EMPRESA, ID_EMPRESA, RUTA_IMG_RECURSOS, RUTA_IMG_TERMOS, RUTA_IMG_GUAMPAS, RUTA_IMG_ARTICULOS, IMG_NO_DISPONIBLE) Then
                            util.mensajes("Empresa actualizada", TITULO_MSJ, "INF")
                            limpiar()
                            desabilitar()
                            btn_nuevo.Focus()
                        Else
                            util.mensajes("Empresa no actualizada", TITULO_MSJ, "WAR")
                        End If
                    End If

                frm_main.CARPETA_IMG_ARTICULOS = RUTA_IMG_ARTICULOS
                frm_main.CARPETA_IMG_RECURSOS = RUTA_IMG_RECURSOS
                frm_main.CARPETA_LOGO_GUAMPAS = RUTA_IMG_GUAMPAS
                frm_main.CARPETA_LOGO_TERMOS = RUTA_IMG_TERMOS

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
            ID_EMPRESA = CInt(GridView1.GetRowCellValue(rowhandle, "id_empresa").ToString)
            txt_nombre.Text = GridView1.GetRowCellValue(rowhandle, "nombre").ToString
            txt_telefono.Text = GridView1.GetRowCellValue(rowhandle, "telefono").ToString
            txt_nro_documeto.Text = GridView1.GetRowCellValue(rowhandle, "numero_documento").ToString
            txt_email.Text = GridView1.GetRowCellValue(rowhandle, "email").ToString
            txt_pagina_web.Text = GridView1.GetRowCellValue(rowhandle, "pagina_web").ToString
            txt_pais.Text = GridView1.GetRowCellValue(rowhandle, "pais").ToString
            txt_ciudad.Text = GridView1.GetRowCellValue(rowhandle, "ciudad").ToString
            txt_direccion.Text = GridView1.GetRowCellValue(rowhandle, "direccion").ToString
            txt_img_no_disponible.Text = GridView1.GetRowCellValue(rowhandle, "img_no_disponible").ToString
            IMG_NO_DISPONIBLE_ANT = GridView1.GetRowCellValue(rowhandle, "img_no_disponible").ToString
            txt_logo_empresa.Text = GridView1.GetRowCellValue(rowhandle, "logo_empresa").ToString
            LOGO_EMPRESA_ANT = GridView1.GetRowCellValue(rowhandle, "logo_empresa").ToString

            If File.Exists(txt_logo_empresa.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_logo_empresa.Text, FileMode.Open, FileAccess.Read)
                pct_logo_empresa.Image = Image.FromStream(fs)
                fs.Close()
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_logo_empresa.Image = Image.FromStream(fs)
                    fs.Close()
                    pct_logo_empresa.Text = ""
                End If
            End If

            txt_img_recursos.Text = GridView1.GetRowCellValue(rowhandle, "ruta_img_recursos").ToString
            txt_img_termos.Text = GridView1.GetRowCellValue(rowhandle, "ruta_img_logos_temos").ToString
            txt_img_guampas.Text = GridView1.GetRowCellValue(rowhandle, "ruta_img_logos_guampas").ToString
            txt_img_articulos.Text = GridView1.GetRowCellValue(rowhandle, "ruta_img_articulos").ToString

            btn_confirmar.Text = "Actualizar"
            habilitar()
        End If
    End Sub

    Private Sub btn_nuevo_Click_1(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        ID_EMPRESA = 0
        txt_nombre.Focus()
    End Sub

    Private Sub btn_confirmar_Click_1(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        insertar_actualizar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub grid_empresas_Click_1(sender As Object, e As EventArgs) Handles grid_empresas.Click
        cargar_fila("enter")
    End Sub

    Private Sub grid_empresas_KeyDown_1(sender As Object, e As KeyEventArgs) Handles grid_empresas.KeyDown
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

    Private Sub txt_nombre_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nombre.Text.Replace(" ", "") = "" Then
            Else
                txt_telefono.Focus()
            End If
        End If
    End Sub

    Private Sub txt_telefono_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_telefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_telefono.Text.Replace(" ", "") = "" Then
            Else
                txt_nro_documeto.Focus()
            End If
        End If
    End Sub

    Private Sub txt_nro_documeto_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_nro_documeto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nro_documeto.Text.Replace(" ", "") = "" Then
            Else
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub txt_email_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pagina_web.Focus()
        End If
    End Sub

    Private Sub txt_pagina_web_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_pagina_web.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pais.Focus()
        End If
    End Sub

    Private Sub txt_pais_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_pais.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_pais.Text.Replace(" ", "") = "" Then
            Else
                txt_ciudad.Focus()
            End If
        End If
    End Sub

    Private Sub txt_ciudad_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_ciudad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ciudad.Text.Replace(" ", "") = "" Then
            Else
                txt_direccion.Focus()
            End If
        End If
    End Sub

    Private Sub txt_direccion_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_direccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_direccion.Text.Replace(" ", "") = "" Then
                txt_logo_empresa.Text = frm_main.IMG_NO_DISPONIBLE
                txt_logo_empresa.Focus()
            Else
                txt_logo_empresa.Focus()
            End If
        End If
    End Sub

    Private Sub txt_logo_empresa_KeyDown_1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub btn_logo_Click(sender As Object, e As EventArgs) Handles btn_logo.Click
        If open_file_dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txt_logo_empresa.Text = open_file_dialog.FileName

            If File.Exists(txt_logo_empresa.Text) Then
                Dim fs As FileStream
                fs = New FileStream(txt_logo_empresa.Text, FileMode.Open, FileAccess.Read)
                pct_logo_empresa.Image = Image.FromStream(fs)
                fs.Close()
            Else
                If File.Exists(frm_main.IMG_NO_DISPONIBLE) Then
                    Dim fs As FileStream
                    fs = New FileStream(frm_main.IMG_NO_DISPONIBLE, FileMode.Open, FileAccess.Read)
                    pct_logo_empresa.Image = Image.FromStream(fs)
                    fs.Close()
                    txt_logo_empresa.Text = ""
                End If
            End If


        End If
    End Sub

    Private Sub btn_img_recursos_Click(sender As Object, e As EventArgs) Handles btn_img_recursos.Click
        buscar_imagenes("recursos")
    End Sub

    Private Sub btn_img_articulos_Click(sender As Object, e As EventArgs) Handles btn_img_articulos.Click
        buscar_imagenes("articulos")
    End Sub

    Private Sub btn_img_no_disponible_Click(sender As Object, e As EventArgs) Handles btn_img_no_disponible.Click
        buscar_imagenes("no_disponible")
    End Sub

    Private Sub btn_img_termos_Click(sender As Object, e As EventArgs) Handles btn_img_termos.Click
        buscar_imagenes("termos")
    End Sub

    Private Sub btn_img_guampas_Click(sender As Object, e As EventArgs) Handles btn_img_guampas.Click
        buscar_imagenes("guampas")
    End Sub

    Private Sub txt_img_recursos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_img_recursos.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_imagenes("recursos")
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_img_recursos.Text.Replace(" ", "") = "" Then
            Else
                txt_img_articulos.Focus()
            End If
        End If
    End Sub

    Private Sub txt_img_articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_img_articulos.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_imagenes("articulos")
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_img_articulos.Text.Replace(" ", "") = "" Then
            Else
                txt_img_no_disponible.Focus()
            End If
        End If
    End Sub

    Private Sub txt_img_no_disponible_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_img_no_disponible.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_imagenes("no_disponible")
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_img_no_disponible.Text.Replace(" ", "") = "" Then
            Else
                txt_img_termos.Focus()
            End If
        End If
    End Sub

    Private Sub txt_img_termos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_img_termos.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_imagenes("termos")
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_img_termos.Text.Replace(" ", "") = "" Then
            Else
                txt_img_guampas.Focus()
            End If
        End If
    End Sub

    Private Sub txt_img_guampas_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_img_guampas.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            buscar_imagenes("guampas")
        End If

        If e.KeyCode = Keys.Enter Then
            If txt_img_guampas.Text.Replace(" ", "") = "" Then
            Else
                txt_logo_empresa.Focus()
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