Imports System.Collections
Imports System.IO

Public Class frm_main

    Dim util As New utilidades

    'Parametros globales
    Friend Shared ID_USUARIO As Integer = 0
    Friend Shared LOGIN_USER As String = ""
    Friend Shared NOMBRE_USER As String = ""
    Friend Shared ID_SUCURSAL As Integer = 0
    Friend Shared SUCURSAL As String = ""
    Friend Shared ID_EMPRESA As Integer = 0
    Friend Shared EMPRESA As String = ""
    Friend Shared DIRECCION As String = ""
    Friend Shared TELEFONO As String = ""

    'Variables para el manejo de imagenes
    Friend Shared CARPETA_IMG_RECURSOS As String = ""
    Friend Shared CARPETA_IMG_ARTICULOS As String = ""
    Friend Shared BACKUP_IMG As String = ""
    Friend Shared CARPETA_LOGO_TERMOS As String = ""
    Friend Shared CARPETA_LOGO_GUAMPAS As String = ""
    Friend Shared IMG_NO_DISPONIBLE As String = ""
    Friend Shared IMG_LOGO_EMPRESA As String = ""
    Friend Shared WIDTH_IMG As Integer = 300
    Friend Shared HEIGHT_IMG As Integer = 300
    Friend Shared IP_SERVIDOR As String = ""

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultar_menus()
        static_text.Caption = "Usuario: " + NOMBRE_USER
        Text = EMPRESA + " - " + SUCURSAL
        parametrosImg()
    End Sub


    Public Sub parametrosImg()
        Try
            Dim directorio As String
            directorio = My.Application.Info.DirectoryPath & "\Luk.txt"
            Dim objReader As New StreamReader(directorio)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()

            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
            IP_SERVIDOR = arrText(0).ToString()

            Dim empresa As New func_empresas()
            Dim dt As New DataTable

            dt = empresa.listar("SELECT logo_empresa, ruta_img_recursos, ruta_img_logos_temos, 
                                ruta_img_logos_guampas, ruta_img_articulos,  img_no_disponible 
                                FROM empresas WHERE id_empresa=" & ID_EMPRESA)

            IMG_LOGO_EMPRESA = dt.Rows(0).Item(0).ToString()
            CARPETA_IMG_RECURSOS = dt.Rows(0).Item(1).ToString()
            CARPETA_LOGO_TERMOS = dt.Rows(0).Item(2).ToString()
            CARPETA_LOGO_GUAMPAS = dt.Rows(0).Item(3).ToString()
            CARPETA_IMG_ARTICULOS = dt.Rows(0).Item(4).ToString()
            IMG_NO_DISPONIBLE = dt.Rows(0).Item(5).ToString()
            BACKUP_IMG = My.Application.Info.DirectoryPath + "\backup_img\"
            WIDTH_IMG = 300
            HEIGHT_IMG = 300
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ocultar_menus()
        'Menu Pedidos
        If frm_login.REGISTRAR_PEDIDOS = 0 Then
            mnu_pedidos_registrar_pedidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.COSTEO_PEDIDOS = 0 Then
            mnu_pedidos_costeo_pedidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.LISTADO_PEDIDOS = 0 Then
            mnu_pedidos_listado_pedidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Produccion
        If frm_login.FABRICANTES = 0 Then
            mnu_produccion_fabricantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.MATERIA_PRIMA = 0 Then
            mnu_produccion_materia_prima.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.LIQUIDACION_EMP = 0 Then
            mnu_produccion_liquidacion_empleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.RECEPCION_PRODUCCION = 0 Then
            mnu_produccion_recepcion_articulos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REGISTRO_FAMILIAS_MATERIA_PRIMA = 0 Then
            mnu_produccionn_familias_materia_prima.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Productos/Articulos
        If frm_login.REGISTRO_PRODUCTOS = 0 Then
            mnu_articulos_productos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.LISTADO_ARTICULOS = 0 Then
            mnu_articulos_listado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REGISTRO_FAMILIAS = 0 Then
            mnu_articulos_familias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.MODIFICACION_PRECIO_VENTA = 0 Then
            mnu_articulos_modificar_precio_venta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Ventas
        If frm_login.REGISTRO_CLIENTES = 0 Then
            mnu_ventas_clientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REGISTRO_VENDEDORES = 0 Then
            mnu_ventas_vendedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.LIQUIDACION_VENDEDORES = 0 Then
            mnu_ventas_liquidacion_vendedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.RANKING_VENTAS = 0 Then
            mnu_ventas_ranking_ventas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Compras
        If frm_login.REGISTRO_PROVEEDORES = 0 Then
            mnu_compras_proveedore.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.COMPRAS = 0 Then
            mnu_compras_compras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_compras_facturas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.LISTADO_COMPRAS = 0 Then
            mnu_compras_listado_compras.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.RANKING_COMPRAS = 0 Then
            mnu_compras_ranking.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        'Menu Stock
        If frm_login.MOVIMIENTOS_STOCK = 0 Then
            mnu_stock_movimientos_stock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_stock_movim_stock_por_item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_stock_saldos_stock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.AJUSTE_STOCK = 0 Then
            mnu_stock_ajuste_stock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_stock_stock_items.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.TRANSACCIONES_STOCK = 0 Then
            mnu_stock_transacciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Configuracion
        If frm_login.USUARIOS = 0 Then
            mnu_configuracion_usuarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.EMPRESAS = 0 Then
            mnu_configuracion_empresas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.SUCURSALES = 0 Then
            mnu_configuracion_sucursales.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.FORMAS_PAGO = 0 Then
            mnu_configuracion_formas_pago.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.PERMISOS = 0 Then
            mnu_configuracion_permisos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.FORMAS_PAGO = 0 Then
            mnu_configuracion_formas_pago.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.TIPOS_COMPRA = 0 Then
            mnu_configuracion_tipos_compra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.TIPOS_COMPROBANTES = 0 Then
            mnu_configuracion_tipos_comprobantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.TIPOS_IMPUESTO = 0 Then
            mnu_configuracion_tipos_impuesto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Cajas
        If frm_login.PUNTO_DE_VENTAS = 0 Then
            mnu_cajas_apertura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_cajas_punto_de_ventas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_cajas_cierre.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_cajas_cerrar_controles.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        'Menu Reportes
        If frm_login.REPORTES_COMPRAS = 0 Then
            mnu_rpt_compras_por_fechas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_rpt_compras_por_proveedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_rpt_compras_por_familias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_rpt_compras_por_tipo_compra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REPORTES_VENTAS = 0 Then
            mnu_reportes_ventas_fecha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_reportes_ventas_clientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_reportes_ventas_familias.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_reportes_ventas_vendedores.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REPORTES_PRODUCCION = 0 Then
            mnu_reportes_produccion_por_fecha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_reportes_produccion_por_ranking.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REPORTES_PEDIDOS = 0 Then
            mnu_reportes_pedidos_recibidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If frm_login.REPORTES_EXTRAS = 0 Then
            mnu_reportes_extras_rpt_mensual.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            mnu_reportes_extras_ventas_vs_costo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    'Menu Pedidos
    Private Sub mnu_pedidos_registrar_pedidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_pedidos_registrar_pedidos.ItemClick
        If util.CheckForm(frm_pedidos) = False Then
            frm_pedidos.MdiParent = Me
            frm_pedidos.Show()
        Else
            frm_pedidos.Focus()
        End If
    End Sub

    Private Sub mnu_pedidos_costeo_pedidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_pedidos_costeo_pedidos.ItemClick
        If util.CheckForm(frm_costeo_pedido) = False Then
            frm_costeo_pedido.MdiParent = Me
            frm_costeo_pedido.Show()
        Else
            frm_costeo_pedido.Focus()
        End If
    End Sub

    Private Sub mnu_pedidos_listado_pedidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_pedidos_listado_pedidos.ItemClick
        If util.CheckForm(frm_listado_pedidos) = False Then
            frm_listado_pedidos.MdiParent = Me
            frm_listado_pedidos.Show()
        Else
            frm_listado_pedidos.Focus()
        End If
    End Sub

    'Menu Produccion
    Private Sub mnu_produccion_fabricantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_produccion_fabricantes.ItemClick
        If util.CheckForm(frm_empleados) = False Then
            frm_empleados.MdiParent = Me
            frm_empleados.Show()
        Else
            frm_empleados.Focus()
        End If
    End Sub

    Private Sub mnu_produccion_liquidacionnes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_produccion_liquidacionnes.ItemClick
        If util.CheckForm(frm_liquidacion_mano_obra) = False Then
            frm_liquidacion_mano_obra.MdiParent = Me
            frm_liquidacion_mano_obra.Show()
        Else
            frm_liquidacion_mano_obra.Focus()
        End If
    End Sub

    Private Sub mnu_produccion_recepcion_articulos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_produccion_recepcion_articulos.ItemClick
        If util.CheckForm(frm_recepcion_produccion) = False Then
            frm_recepcion_produccion.MdiParent = Me
            frm_recepcion_produccion.Show()
        Else
            frm_recepcion_produccion.Focus()
        End If
    End Sub

    Private Sub mnu_produccion_materia_prima_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_produccion_materia_prima.ItemClick
        If util.CheckForm(frm_materiales) = False Then
            frm_materiales.MdiParent = Me
            frm_materiales.Show()
        Else
            frm_materiales.Focus()
        End If
    End Sub

    Private Sub mnu_produccionn_familias_materia_prima_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_produccionn_familias_materia_prima.ItemClick
        If util.CheckForm(frm_familias_materia_prima) = False Then
            frm_familias_materia_prima.MdiParent = Me
            frm_familias_materia_prima.Show()
        Else
            frm_familias_materia_prima.Focus()
        End If
    End Sub

    'Menu Produccion/Articulos
    Private Sub mnu_articulos_productos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_articulos_productos.ItemClick
        If util.CheckForm(frm_articulos) = False Then
            frm_articulos.MdiParent = Me
            frm_articulos.Show()
        Else
            frm_articulos.Focus()
        End If
    End Sub

    Private Sub mnu_articulos_familias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_articulos_familias.ItemClick
        If util.CheckForm(frm_familias) = False Then
            frm_familias.MdiParent = Me
            frm_familias.Show()
        Else
            frm_familias.Focus()
        End If
    End Sub

    Private Sub mnu_articulos_listado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_articulos_listado.ItemClick

    End Sub

    Private Sub mnu_articulos_modificar_precio_venta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_articulos_modificar_precio_venta.ItemClick
        If util.CheckForm(frm_modificar_precio_venta) = False Then
            frm_modificar_precio_venta.MdiParent = Me
            frm_modificar_precio_venta.Show()
        Else
            frm_modificar_precio_venta.Focus()
        End If
    End Sub

    'Menu Ventas
    Private Sub mnu_ventas_clientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_ventas_clientes.ItemClick
        If util.CheckForm(frm_clientes) = False Then
            frm_clientes.MdiParent = Me
            frm_clientes.Show()
        Else
            frm_clientes.Focus()
        End If
    End Sub

    Private Sub mnu_ventas_vendedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_ventas_vendedores.ItemClick
        If util.CheckForm(frm_vendedores) = False Then
            frm_vendedores.MdiParent = Me
            frm_vendedores.Show()
        Else
            frm_vendedores.Focus()
        End If
    End Sub

    Private Sub mnu_ventas_liquidacion_vendedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_ventas_liquidacion_vendedores.ItemClick
        If util.CheckForm(frm_liquidacion_vendedores) = False Then
            frm_liquidacion_vendedores.MdiParent = Me
            frm_liquidacion_vendedores.Show()
        Else
            frm_familias_materia_prima.Focus()
        End If
    End Sub

    Private Sub mnu_ventas_ranking_ventas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_ventas_ranking_ventas.ItemClick
        If util.CheckForm(frm_ranking_ventas) = False Then
            frm_ranking_ventas.MdiParent = Me
            frm_ranking_ventas.Show()
        Else
            frm_ranking_ventas.Focus()
        End If
    End Sub

    'Menu Compras
    Private Sub mnu_compras_compras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_compras_compras.ItemClick
        If util.CheckForm(frm_compras) = False Then
            frm_compras.MdiParent = Me
            frm_compras.Show()
        Else
            frm_compras.Focus()
        End If
    End Sub

    Private Sub mnu_compras_proveedore_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_compras_proveedore.ItemClick
        If util.CheckForm(frm_proveedores) = False Then
            frm_proveedores.MdiParent = Me
            frm_proveedores.Show()
        Else
            frm_proveedores.Focus()
        End If
    End Sub

    Private Sub mnu_compras_listado_compras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_compras_listado_compras.ItemClick
        If util.CheckForm(frm_listado_compras) = False Then
            frm_listado_compras.MdiParent = Me
            frm_listado_compras.Show()
        Else
            frm_listado_compras.Focus()
        End If
    End Sub

    Private Sub mnu_compras_ranking_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_compras_ranking.ItemClick
        If util.CheckForm(frm_ranking_compras) = False Then
            frm_ranking_compras.MdiParent = Me
            frm_ranking_compras.Show()
        Else
            frm_ranking_compras.Focus()
        End If
    End Sub

    'Menu Stock
    Private Sub mnu_stock_movimientos_stock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_movimientos_stock.ItemClick
        If util.CheckForm(frm_movimientos_stock) = False Then
            frm_movimientos_stock.MdiParent = Me
            frm_movimientos_stock.Show()
        Else
            frm_movimientos_stock.Focus()
        End If
    End Sub

    Private Sub mnu_stock_movim_stock_por_item_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_movim_stock_por_item.ItemClick
        If util.CheckForm(frm_movimientos_stock_items) = False Then
            frm_movimientos_stock_items.MdiParent = Me
            frm_movimientos_stock_items.Show()
        Else
            frm_movimientos_stock_items.Focus()
        End If
    End Sub

    Private Sub mnu_stock_control_stock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_control_stock.ItemClick
        If util.CheckForm(frm_stock_articulos) = False Then
            frm_stock_articulos.MdiParent = Me
            frm_stock_articulos.Show()
        Else
            frm_stock_articulos.Focus()
        End If
    End Sub

    Private Sub mnu_stock_transacciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_transacciones.ItemClick
        If util.CheckForm(frm_transacciones_stock) = False Then
            frm_transacciones_stock.MdiParent = Me
            frm_transacciones_stock.Show()
        Else
            frm_transacciones_stock.Focus()
        End If
    End Sub

    Private Sub mnu_stock_ajuste_stock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_ajuste_stock.ItemClick
        If util.CheckForm(frm_stock_articulos) = False Then
            frm_stock_articulos.MdiParent = Me
            frm_stock_articulos.Show()
        Else
            frm_stock_articulos.Focus()
        End If
    End Sub

    Private Sub mnu_stock_stock_items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_stock_items.ItemClick
        If util.CheckForm(frm_existencia_en_stock) = False Then
            frm_existencia_en_stock.MdiParent = Me
            frm_existencia_en_stock.Show()
        Else
            frm_existencia_en_stock.Focus()
        End If
    End Sub
    'Menu Configuracion
    Private Sub mnu_configuracion_empresas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_empresas.ItemClick
        If util.CheckForm(frm_empresas) = False Then
            frm_empresas.MdiParent = Me
            frm_empresas.Show()
        Else
            frm_empresas.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_sucursales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_sucursales.ItemClick
        If util.CheckForm(frm_sucursales) = False Then
            frm_sucursales.MdiParent = Me
            frm_sucursales.Show()
        Else
            frm_sucursales.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_usuarios_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_usuarios.ItemClick
        If util.CheckForm(frm_usuarios) = False Then
            frm_usuarios.MdiParent = Me
            frm_usuarios.Show()
        Else
            frm_usuarios.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_permisos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_permisos.ItemClick
        If util.CheckForm(frm_permisos) = False Then
            frm_permisos.MdiParent = Me
            frm_permisos.Show()
        Else
            frm_permisos.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_formas_pago_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_formas_pago.ItemClick
        If util.CheckForm(frm_formas_pago) = False Then
            frm_formas_pago.MdiParent = Me
            frm_formas_pago.Show()
        Else
            frm_formas_pago.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_tipos_compra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_tipos_compra.ItemClick
        If util.CheckForm(frm_tipos_compra) = False Then
            frm_tipos_compra.MdiParent = Me
            frm_tipos_compra.Show()
        Else
            frm_tipos_compra.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_tipos_impuesto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_tipos_impuesto.ItemClick
        If util.CheckForm(frm_tipos_impuesto) = False Then
            frm_tipos_impuesto.MdiParent = Me
            frm_tipos_impuesto.Show()
        Else
            frm_tipos_impuesto.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_tipos_comprobantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_tipos_comprobantes.ItemClick
        If util.CheckForm(frm_tipos_comprobante) = False Then
            frm_tipos_comprobante.MdiParent = Me
            frm_tipos_comprobante.Show()
        Else
            frm_tipos_comprobante.Focus()
        End If
    End Sub

    Private Sub mnu_configuracion_timbrados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_configuracion_timbrados.ItemClick
        If util.CheckForm(frm_timbrados) = False Then
            frm_timbrados.MdiParent = Me
            frm_timbrados.Show()
        Else
            frm_timbrados.Focus()
        End If
    End Sub

    'Menu Cajas
    Private Function obtener_timbrado() As Boolean
        Dim venta As New func_ventas
        Dim dt As New DataTable
        dt = venta.consultar("SELECT id_timbrado, nro_inicial, nro_final, longitud_nro_comprob FROM timbrados 
                             WHERE fecha_hasta >= '" + Now.ToString("dd/MM/yyyy") + "' AND activo=true")

        Return dt.Rows.Count > 0
    End Function

    Private Function existe_control(sql As String) As Boolean
        Dim control As New func_control_caja
        Dim util As New utilidades
        Dim dt As New DataTable
        dt = control.consultar(sql)

        If dt.Rows.Count() > 0 Then
            frm_ventas.ID_CONTROL_CAJA = CInt(dt.Rows(0).Item(0))
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub mnu_cajas_apertura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_cajas_apertura.ItemClick
        Dim TITULO_MSJ As String = "<Punto de Ventas>"
        If obtener_timbrado() = False Then
            util.mensajes("Timbrado no definido", TITULO_MSJ, "ERR")
            Return
        End If
        If existe_control("SELECT id_control_caja FROM control_caja WHERE to_char(fecha_apertura,'YYYY/MM/DD') <= '" + Now.ToString("yyyy/MM/dd") + "' AND fecha_cierre IS NULL") Then
            util.mensajes("Existen controles de cajas que no han sido cerrados", TITULO_MSJ, "WAR")
            Return
        End If

        If util.CheckForm(frm_apertura_caja) = False Then
            frm_apertura_caja.MdiParent = Me
            frm_apertura_caja.Show()
        Else
            frm_apertura_caja.Focus()
        End If
    End Sub

    Private Sub mnu_cajas_punto_de_ventas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_cajas_punto_de_ventas.ItemClick
        Dim TITULO_MSJ As String = "<Punto de Ventas>"

        If obtener_timbrado() = False Then
            util.mensajes("Timbrado no definido", TITULO_MSJ, "ERR")
            Return
        End If

        If existe_control("SELECT id_control_caja FROM control_caja WHERE to_char(fecha_apertura,'YYYY/MM/DD') = '" + Now.ToString("yyyy/MM/dd") + "' AND fecha_cierre IS NULL") = False Then
            util.mensajes("No se determino control de caja para la fecha: " + Now.ToString("dd/MM/yyyy"), TITULO_MSJ, "WAR")
            Return
        End If
        If util.CheckForm(frm_ventas) = False Then
            frm_ventas.MdiParent = Me
            frm_ventas.Show()
        Else
            frm_ventas.Focus()
        End If
    End Sub

    Private Sub mnu_cajas_cierre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_cajas_cierre.ItemClick
        Dim TITULO_MSJ As String = "<Punto de Ventas>"
        If obtener_timbrado() = False Then
            util.mensajes("Timbrado no definido", TITULO_MSJ, "ERR")
            Return
        End If
        If existe_control("SELECT id_control_caja FROM control_caja WHERE to_char(fecha_apertura,'YYYY/MM/DD') = '" + Now.ToString("yyyy/MM/dd") + "' AND fecha_cierre IS NULL") = False Then
            util.mensajes("No se determino control de caja abierto para la fecha: " + Now.ToString("dd/MM/yyyy"), TITULO_MSJ, "WAR")
            Return
        End If
        If util.CheckForm(frm_cierre_caja) = False Then
            frm_cierre_caja.MdiParent = Me
            frm_cierre_caja.Show()
        Else
            frm_cierre_caja.Focus()
        End If
    End Sub

    Private Sub mnu_cajas_extracciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_cajas_extracciones.ItemClick
        Dim TITULO_MSJ As String = "<Extraccion de Efectivo>"
        If existe_control("SELECT id_control_caja FROM control_caja WHERE to_char(fecha_apertura,'YYYY/MM/DD') = '" + Now.ToString("yyyy/MM/dd") + "' AND fecha_cierre IS NULL") = False Then
            util.mensajes("No se determino control de caja abierto para la fecha: " + Now.ToString("dd/MM/yyyy"), TITULO_MSJ, "WAR")
            Return
        End If
        If util.CheckForm(frm_extraccion_efectivo) = False Then
            frm_extraccion_efectivo.MdiParent = Me
            frm_extraccion_efectivo.Show()
        Else
            frm_extraccion_efectivo.Focus()
        End If
    End Sub

    Private Sub mnu_cajas_cerrar_controles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_cajas_cerrar_controles.ItemClick
        If util.CheckForm(frm_cerrar_controles) = False Then
            frm_cerrar_controles.MdiParent = Me
            frm_cerrar_controles.Show()
        Else
            frm_cerrar_controles.Focus()
        End If
    End Sub

    Private Sub mnu_stock_saldos_stock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_stock_saldos_stock.ItemClick
        If util.CheckForm(frm_saldo_stock) = False Then
            frm_saldo_stock.MdiParent = Me
            frm_saldo_stock.Show()
        Else
            frm_saldo_stock.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_ventas_fecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_ventas_fecha.ItemClick
        If util.CheckForm(frm_rpt_vta_por_fecha) = False Then
            frm_rpt_vta_por_fecha.MdiParent = Me
            frm_rpt_vta_por_fecha.Show()
        Else
            frm_rpt_vta_por_fecha.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_ventas_familias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_ventas_familias.ItemClick
        If util.CheckForm(frm_rpt_vta_detalle_ventas_por_familia) = False Then
            frm_rpt_vta_detalle_ventas_por_familia.MdiParent = Me
            frm_rpt_vta_detalle_ventas_por_familia.Show()
        Else
            frm_rpt_vta_detalle_ventas_por_familia.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_ventas_clientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_ventas_clientes.ItemClick
        If util.CheckForm(frm_rpt_vta_por_clientes) = False Then
            frm_rpt_vta_por_clientes.MdiParent = Me
            frm_rpt_vta_por_clientes.Show()
        Else
            frm_rpt_vta_por_clientes.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_ventas_vendedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_ventas_vendedores.ItemClick
        If util.CheckForm(frm_rpt_vta_por_vendedores) = False Then
            frm_rpt_vta_por_vendedores.MdiParent = Me
            frm_rpt_vta_por_vendedores.Show()
        Else
            frm_rpt_vta_por_vendedores.Focus()
        End If
    End Sub

    Private Sub mnu_rpt_compras_por_fechas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_rpt_compras_por_fechas.ItemClick
        If util.CheckForm(frm_rpt_compras_por_fecha) = False Then
            frm_rpt_compras_por_fecha.MdiParent = Me
            frm_rpt_compras_por_fecha.Show()
        Else
            frm_rpt_compras_por_fecha.Focus()
        End If
    End Sub

    Private Sub mnu_rpt_compras_por_familias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_rpt_compras_por_familias.ItemClick
        If util.CheckForm(frm_rpt_compras_por_familia) = False Then
            frm_rpt_compras_por_familia.MdiParent = Me
            frm_rpt_compras_por_familia.Show()
        Else
            frm_rpt_compras_por_familia.Focus()
        End If
    End Sub

    Private Sub mnu_rpt_compras_por_proveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_rpt_compras_por_proveedores.ItemClick
        If util.CheckForm(frm_rpt_compras_por_proveedores) = False Then
            frm_rpt_compras_por_proveedores.MdiParent = Me
            frm_rpt_compras_por_proveedores.Show()
        Else
            frm_rpt_compras_por_proveedores.Focus()
        End If
    End Sub

    Private Sub mnu_rpt_compras_por_tipo_compra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_rpt_compras_por_tipo_compra.ItemClick
        If util.CheckForm(frm_rpt_compras_por_tipo_compra) = False Then
            frm_rpt_compras_por_tipo_compra.MdiParent = Me
            frm_rpt_compras_por_tipo_compra.Show()
        Else
            frm_rpt_compras_por_tipo_compra.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_pedidos_recibidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_pedidos_recibidos.ItemClick
        If util.CheckForm(frm_rpt_pedidos_recibidos) = False Then
            frm_rpt_pedidos_recibidos.MdiParent = Me
            frm_rpt_pedidos_recibidos.Show()
        Else
            frm_rpt_pedidos_recibidos.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_produccion_por_fecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_produccion_por_fecha.ItemClick
        If util.CheckForm(frm_rpt_produccion_por_fecha) = False Then
            frm_rpt_produccion_por_fecha.MdiParent = Me
            frm_rpt_produccion_por_fecha.Show()
        Else
            frm_rpt_produccion_por_fecha.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_produccion_por_ranking_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_produccion_por_ranking.ItemClick
        If util.CheckForm(frm_rpt_prodcuccion_ranking_emp) = False Then
            frm_rpt_prodcuccion_ranking_emp.MdiParent = Me
            frm_rpt_prodcuccion_ranking_emp.Show()
        Else
            frm_rpt_prodcuccion_ranking_emp.Focus()
        End If
    End Sub

    Private Sub menu_reportes_extras_rpt_mensual_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_extras_rpt_mensual.ItemClick
        If util.CheckForm(frm_reporte_mensual) = False Then
            frm_reporte_mensual.MdiParent = Me
            frm_reporte_mensual.Show()
        Else
            frm_reporte_mensual.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_extras_ventas_vs_costo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_extras_ventas_vs_costo.ItemClick
        If util.CheckForm(frm_rpt_ventas_vs_costo) = False Then
            frm_rpt_ventas_vs_costo.MdiParent = Me
            frm_rpt_ventas_vs_costo.Show()
        Else
            frm_rpt_ventas_vs_costo.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_ventas_condicion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_ventas_condicion.ItemClick
        If util.CheckForm(frm_rpt_vta_por_condicion) = False Then
            frm_rpt_vta_por_condicion.MdiParent = Me
            frm_rpt_vta_por_condicion.Show()
        Else
            frm_rpt_vta_por_condicion.Focus()
        End If
    End Sub

    Private Sub BarButtonItem17_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        If util.CheckForm(frm_controles_caja) = False Then
            frm_controles_caja.MdiParent = Me
            frm_controles_caja.Show()
        Else
            frm_controles_caja.Focus()
        End If
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        If util.CheckForm(frm_rpt_vta_resumen_ventas_por_proveedor) = False Then
            frm_rpt_vta_resumen_ventas_por_proveedor.MdiParent = Me
            frm_rpt_vta_resumen_ventas_por_proveedor.Show()
        Else
            frm_rpt_vta_resumen_ventas_por_proveedor.Focus()
        End If
    End Sub


    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        If util.CheckForm(frm_rpt_vta_detalle_ventas_por_proveedor) = False Then
            frm_rpt_vta_detalle_ventas_por_proveedor.MdiParent = Me
            frm_rpt_vta_detalle_ventas_por_proveedor.Show()
        Else
            frm_rpt_vta_detalle_ventas_por_proveedor.Focus()
        End If
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        If util.CheckForm(frm_rpt_vta_resumen_ventas_por_proveedor_familia) = False Then
            frm_rpt_vta_resumen_ventas_por_proveedor_familia.MdiParent = Me
            frm_rpt_vta_resumen_ventas_por_proveedor_familia.Show()
        Else
            frm_rpt_vta_resumen_ventas_por_proveedor_familia.Focus()
        End If
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        If util.CheckForm(FrmExistenciaStockItems) = False Then
            FrmExistenciaStockItems.MdiParent = Me
            FrmExistenciaStockItems.Show()
        Else
            FrmExistenciaStockItems.Focus()
        End If
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        If util.CheckForm(frm_listado_articulos) = False Then
            frm_listado_articulos.MdiParent = Me
            frm_listado_articulos.Show()
        Else
            frm_listado_articulos.Focus()
        End If
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        If util.CheckForm(frm_listado_articulos_gru_proveedor) = False Then
            frm_listado_articulos_gru_proveedor.MdiParent = Me
            frm_listado_articulos_gru_proveedor.Show()
        Else
            frm_listado_articulos_gru_proveedor.Focus()
        End If
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        If util.CheckForm(frm_rpt_cobros_caja) = False Then
            frm_rpt_cobros_caja.MdiParent = Me
            frm_rpt_cobros_caja.Show()
        Else
            frm_rpt_cobros_caja.Focus()
        End If
    End Sub

    Private Sub mnu_pedidos_Click(sender As Object, e As EventArgs) Handles mnu_pedidos.Click

    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        If util.CheckForm(FrmExistenciaStockItems) = False Then
            FrmExistenciaStockItems.MdiParent = Me
            FrmExistenciaStockItems.Show()
        Else
            FrmExistenciaStockItems.Focus()
        End If
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        If util.CheckForm(frm_rpt_ranking_global_proveedor) = False Then
            frm_rpt_ranking_global_proveedor.MdiParent = Me
            frm_rpt_ranking_global_proveedor.Show()
        Else
            frm_rpt_ranking_global_proveedor.Focus()
        End If
    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        If util.CheckForm(frm_stock_valorizado) = False Then
            frm_stock_valorizado.MdiParent = Me
            frm_stock_valorizado.Show()
        Else
            frm_stock_valorizado.Focus()
        End If
    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        If util.CheckForm(frm_rpt_compras_por_item) = False Then
            frm_rpt_compras_por_item.MdiParent = Me
            frm_rpt_compras_por_item.Show()
        Else
            frm_rpt_compras_por_item.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_produccion_pedidos_en_produccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_produccion_pedidos_en_produccion.ItemClick
        If util.CheckForm(frm_rpt_pedidos_en_produccion) = False Then
            frm_rpt_pedidos_en_produccion.MdiParent = Me
            frm_rpt_pedidos_en_produccion.Show()
        Else
            frm_rpt_pedidos_en_produccion.Focus()
        End If
    End Sub

    Private Sub mnu_articulos__imp_cod_barras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_articulos__imp_cod_barras.ItemClick
        If util.CheckForm(frm_impresion_cod_barras) = False Then
            frm_impresion_cod_barras.MdiParent = Me
            frm_impresion_cod_barras.Show()
        Else
            frm_impresion_cod_barras.Focus()
        End If
    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        If util.CheckForm(frm_rpt_detalle_ventas_por_comprob) = False Then
            frm_rpt_detalle_ventas_por_comprob.MdiParent = Me
            frm_rpt_detalle_ventas_por_comprob.Show()
        Else
            frm_rpt_detalle_ventas_por_comprob.Focus()
        End If
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If util.CheckForm(frm_impresion_plantilla_cod_barras) = False Then
            frm_impresion_plantilla_cod_barras.MdiParent = Me
            frm_impresion_plantilla_cod_barras.Show()
        Else
            frm_impresion_plantilla_cod_barras.Focus()
        End If
    End Sub

    Private Sub frm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If util.msj_confirmacion("Deseas salir del sistema", "Menu principal") = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnu_pedidos_nota_credito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_pedidos_nota_credito.ItemClick
        If util.CheckForm(frm_notas_credito) = False Then
            frm_notas_credito.MdiParent = Me
            frm_notas_credito.Show()
        Else
            frm_notas_credito.Focus()
        End If
    End Sub

    Private Sub mnu_reportes_extras_rpt_resumen_cajas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_reportes_extras_rpt_resumen_cajas.ItemClick
        If util.CheckForm(frm_resumen_caja) = False Then
            frm_resumen_caja.MdiParent = Me
            frm_resumen_caja.Show()
        Else
            frm_resumen_caja.Focus()
        End If
    End Sub

    Private Sub mnu_ventas_ultimas_ventas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnu_ventas_ultimas_ventas.ItemClick
        If util.CheckForm(frm_grafico_ventas) = False Then
            frm_grafico_ventas.MdiParent = Me
            frm_grafico_ventas.Show()
        Else
            frm_grafico_ventas.Focus()
        End If
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If util.CheckForm(frm_rpt_vta_ventas_formas_pago) = False Then
            frm_rpt_vta_ventas_formas_pago.MdiParent = Me
            frm_rpt_vta_ventas_formas_pago.Show()
        Else
            frm_rpt_vta_ventas_formas_pago.Focus()
        End If
    End Sub

    Private Sub BarButtonItem36_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        If util.CheckForm(frm_pago_facturas) = False Then
            frm_pago_facturas.MdiParent = Me
            frm_pago_facturas.Show()
        Else
            frm_pago_facturas.Focus()
        End If
    End Sub

    Private Sub BarButtonItem37_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        If util.CheckForm(frm_rpt_compras_detalle_por_fecha) = False Then
            frm_rpt_compras_detalle_por_fecha.MdiParent = Me
            frm_rpt_compras_detalle_por_fecha.Show()
        Else
            frm_rpt_compras_detalle_por_fecha.Focus()
        End If
    End Sub

    Private Sub BarButtonItem38_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        If util.CheckForm(frm_rpt_stock_minimo) = False Then
            frm_rpt_stock_minimo.MdiParent = Me
            frm_rpt_stock_minimo.Show()
        Else
            frm_rpt_stock_minimo.Focus()
        End If
    End Sub

    Private Sub BarButtonItem39_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        If util.CheckForm(frm_rpt_cobros_caja_por_cliente) = False Then
            frm_rpt_cobros_caja_por_cliente.MdiParent = Me
            frm_rpt_cobros_caja_por_cliente.Show()
        Else
            frm_rpt_cobros_caja_por_cliente.Focus()
        End If
    End Sub

    Private Sub BarButtonItem40_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        If util.CheckForm(frm_rpt_pedidos_recibidos_familia) = False Then
            frm_rpt_pedidos_recibidos_familia.MdiParent = Me
            frm_rpt_pedidos_recibidos_familia.Show()
        Else
            frm_rpt_pedidos_recibidos_familia.Focus()
        End If
    End Sub
End Class