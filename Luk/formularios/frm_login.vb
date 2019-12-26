Imports System.Management
Imports System.Threading
Imports DevExpress.XtraSplashScreen

Public Class frm_login

    Dim usuario As New func_usuarios
    Dim util As New utilidades

    'Permisos de usuarios
    'Menu Pedidos
    Friend Shared REGISTRAR_PEDIDOS As Integer = 0
    Friend Shared LISTADO_PEDIDOS As Integer = 0
    Friend Shared COSTEO_PEDIDOS As Integer = 0
    Friend Shared COSTEO_DESDE_PEDIDO As Integer = 0
    'Menu Produccion
    Friend Shared FABRICANTES As Integer = 0
    Friend Shared MATERIA_PRIMA As Integer = 0
    Friend Shared LIQUIDACION_EMP As Integer = 0
    Friend Shared RECEPCION_PRODUCCION As Integer = 0
    Friend Shared REGISTRO_FAMILIAS_MATERIA_PRIMA As Integer = 0
    Friend Shared MODIFICACION_PRECIO_VENTA As Integer = 0
    'Menu Productos/Articulos
    Friend Shared REGISTRO_PRODUCTOS As Integer = 0
    Friend Shared LISTADO_ARTICULOS As Integer = 0
    Friend Shared REGISTRO_FAMILIAS As Integer = 0
    'Menu Ventas
    Friend Shared REGISTRO_CLIENTES As Integer = 0
    Friend Shared REGISTRO_VENDEDORES As Integer = 0
    Friend Shared LIQUIDACION_VENDEDORES As Integer = 0
    Friend Shared PUNTO_DE_VENTAS As Integer = 0
    Friend Shared RANKING_VENTAS As Integer = 0
    'Menu Compras
    Friend Shared COMPRAS As Integer = 0
    Friend Shared FACTURAS As Integer = 0
    Friend Shared REGISTRO_PROVEEDORES As Integer = 0
    Friend Shared LISTADO_COMPRAS As Integer = 0
    Friend Shared RANKING_COMPRAS As Integer = 0
    'Menu Stock
    Friend Shared MOVIMIENTOS_STOCK As Integer = 0
    Friend Shared AJUSTE_STOCK As Integer = 0
    Friend Shared TRANSACCIONES_STOCK As Integer = 0
    'Menu Configuracion
    Friend Shared USUARIOS As Integer = 0
    Friend Shared EMPRESAS As Integer = 0
    Friend Shared SUCURSALES As Integer = 0
    Friend Shared PERMISOS As Integer = 0
    Friend Shared FORMAS_PAGO As Integer = 0
    Friend Shared TIPOS_COMPROBANTES As Integer = 0
    Friend Shared TIPOS_COMPRA As Integer = 0
    Friend Shared TIPOS_IMPUESTO As Integer = 0
    Friend Shared TIMBRADOS As Integer = 0
    'Menu Reportes
    Friend Shared REPORTES_COMPRAS As Integer = 0
    Friend Shared REPORTES_VENTAS As Integer = 0
    Friend Shared REPORTES_PEDIDOS As Integer = 0
    Friend Shared REPORTES_PRODUCCION As Integer = 0
    Friend Shared REPORTES_EXTRAS As Integer = 0
    Friend Shared TRASPASO_ARTICULOS As Integer = 0

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Informacion()
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        SplashScreenManager.ShowForm(GetType(SplashScreen1), True, True)
        MyBase.OnLoad(e)
        Thread.Sleep(1300)
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub login()
        Dim dt As New DataTable

        dt = usuario.listar("SELECT id_usuario, login, nombre_completo FROM usuarios 
                             WHERE login='" + Trim(txt_usuario.Text.Replace("'", "")) + "' 
                             AND clave_acceso='" + Trim(txt_contraseña.Text.Replace("'", "")) + "' 
                             AND activo=true")

        If dt.Rows.Count <> 0 Then
            frm_main.ID_USUARIO = CInt(dt.Rows(0).Item(0))
            frm_main.LOGIN_USER = CStr(dt.Rows(0).Item(1))
            frm_main.NOMBRE_USER = CStr(dt.Rows(0).Item(2))
            obtener_permisos(frm_main.ID_USUARIO)
            frm_main.Show()
            Close()
        Else
            util.mensajes("Acceso Denegado", "<Acceso al Sistema>", "ERR")
            txt_usuario.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Focus()
        End If

    End Sub

    Sub Informacion()
        Dim nombre As String, so As String, arquitectura As String, placa As String

        ':::Obtenemos la informacion del Sistema operativo
        so = My.Computer.Info.OSFullName

        Dim consultaSQLArquitectura As String = "SELECT * FROM Win32_Processor"
        Dim objArquitectura As New ManagementObjectSearcher(consultaSQLArquitectura)
        Dim ArquitecturaSO As String = ""
        For Each info As ManagementObject In objArquitectura.Get()
            ArquitecturaSO = info.Properties("AddressWidth").Value.ToString()
        Next info
        arquitectura = ArquitecturaSO + " Bits"

        ':::Obtenemos la informacion del Equipo
        nombre = My.Computer.Name

        ':::Obtenemos el serial de la Board
        Dim serial As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
        Dim serialBoard As String = ""
        For Each serialB As ManagementObject In serial.Get()
            serialBoard = (serialB.GetPropertyValue("SerialNumber").ToString)
        Next
        placa = serialBoard

        parametros(nombre, so, arquitectura, placa, True)
    End Sub

    Private Sub parametros(nombre As String, so As String, arquitectura As String, placa As String, habilitado As Boolean)
        Dim dt As New DataTable
        dt = usuario.listar("SELECT eq.id_empresa, e.nombre, e.direccion, e.telefono FROM equipos_pc eq
                             INNER JOIN empresas e ON e.id_empresa = eq.id_empresa
                             WHERE eq.nombre='" + nombre + "' AND eq.sistema_operativo='" + so + "' 
                             AND eq.arquitectura='" + arquitectura + "' 
                             AND eq.placa_madre='" + placa + "' AND eq.habilitado=true")

        If dt.Rows.Count <> 0 Then
            frm_main.ID_EMPRESA = CInt(dt.Rows(0).Item(0))
            frm_main.EMPRESA = CStr(dt.Rows(0).Item(1))
            frm_main.DIRECCION = CStr(dt.Rows(0).Item(2))
            frm_main.TELEFONO = CStr(dt.Rows(0).Item(3))
        Else
            util.mensajes("No se encontraron parametros de Empresa", "<Acceso al Sistema>", "ERR")
            Me.Close()
            Return
        End If

        dt.Clear()
        dt = usuario.listar("SELECT eq.id_sucursal, s.nombre FROM equipos_pc eq
                             INNER JOIN sucursales s ON s.id_sucursal = eq.id_sucursal
                             WHERE eq.nombre='" + nombre + "' AND eq.sistema_operativo='" + so + "' 
                             AND eq.arquitectura='" + arquitectura + "' 
                             AND eq.placa_madre='" + placa + "' AND eq.habilitado=true")
        If dt.Rows.Count <> 0 Then
            frm_main.ID_SUCURSAL = CInt(dt.Rows(0).Item(0))
            frm_main.SUCURSAL = CStr(dt.Rows(0).Item(1))
        Else
            util.mensajes("No se encontraron parametros de Sucursal", "<Acceso al Sistema>", "ERR")
            Me.Close()
            Return
        End If

    End Sub

    Public Sub obtener_permisos(ByVal id_user As Integer)
        Dim dt As New DataTable
        dt = usuario.listar("SELECT p.nombre AS permiso FROM permisos_usuario u
                             INNER JOIN permisos p ON p.id_permiso = u.id_permiso
                             WHERE id_usuario = " + id_user.ToString() + "")

        For Each row As DataRow In dt.Rows
            'Menu Pedidos
            If CStr(row("permiso")) = "REGISTRO DE PEDIDOS" Then
                REGISTRAR_PEDIDOS = 1
            End If
            If CStr(row("permiso")) = "LISTADO DE PEDIDOS" Then
                LISTADO_PEDIDOS = 1
            End If
            If CStr(row("permiso")) = "COSTEO DE PEDIDOS" Then
                COSTEO_PEDIDOS = 1
            End If
            If CStr(row("permiso")) = "COSTEO DESDE PEDIDO" Then
                COSTEO_DESDE_PEDIDO = 1
            End If

            'Menu Produccion
            If CStr(row("permiso")) = "REGISTRO DE FABRICANTES" Then
                FABRICANTES = 1
            End If
            If CStr(row("permiso")) = "REGISTRO DE MATERIA PRIMA" Then
                MATERIA_PRIMA = 1
            End If
            If CStr(row("permiso")) = "LIQUIDACIONES DE EMPLEADOS" Then
                LIQUIDACION_EMP = 1
            End If
            If CStr(row("permiso")) = "RECEPCION DE ARTICULOS" Then
                RECEPCION_PRODUCCION = 1
            End If
            If CStr(row("permiso")) = "REGISTRO DE FAMILIAS DE MATERIA PRIMA" Then
                REGISTRO_FAMILIAS_MATERIA_PRIMA = 1
            End If
            'Menu Productos/Articulos
            If CStr(row("permiso")) = "REGISTRO DE ARTICULOS" Then
                REGISTRO_PRODUCTOS = 1
            End If
            If CStr(row("permiso")) = "LISTADO DE ARTICULOS" Then
                LISTADO_ARTICULOS = 1
            End If
            If CStr(row("permiso")) = "REGISTRO DE FAMILIAS DE ARTICULOS" Then
                REGISTRO_FAMILIAS = 1
            End If
            If CStr(row("permiso")) = "ACTUALIZACION DE PRECIO VENTA" Then
                MODIFICACION_PRECIO_VENTA = 1
            End If
            If CStr(row("permiso")) = "TRASPASO DE ARTICULOS" Then
                TRASPASO_ARTICULOS = 1
            End If
            'Menu Ventas
            If CStr(row("permiso")) = "REGISTRO DE CLIENTES" Then
                REGISTRO_CLIENTES = 1
            End If
            If CStr(row("permiso")) = "REGISTRO DE VENDEDORES" Then
                REGISTRO_VENDEDORES = 1
            End If
            If CStr(row("permiso")) = "LIQUIDACION DE VENDEDORES" Then
                LIQUIDACION_VENDEDORES = 1
            End If
            If CStr(row("permiso")) = "PUNTO DE VENTAS" Then
                PUNTO_DE_VENTAS = 1
            End If
            If CStr(row("permiso")) = "RANKING DE VENTAS" Then
                RANKING_VENTAS = 1
            End If
            'Menu Compras
            If CStr(row("permiso")) = "REGISTRO DE PROVEEDORES" Then
                REGISTRO_PROVEEDORES = 1
            End If
            If CStr(row("permiso")) = "REGISTRO DE COMPRAS" Then
                COMPRAS = 1
                FACTURAS = 1
            End If
            If CStr(row("permiso")) = "LISTADO DE COMPRAS" Then
                LISTADO_COMPRAS = 1
            End If
            If CStr(row("permiso")) = "RANKING DE COMPRAS" Then
                RANKING_COMPRAS = 1
            End If
            'Menu Stock
            If CStr(row("permiso")) = "MOVIMIENTOS DE STOCK" Then
                MOVIMIENTOS_STOCK = 1
            End If
            If CStr(row("permiso")) = "AJUSTE DE STOCK" Then
                AJUSTE_STOCK = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE TRANSACCIONES DE STOCK" Then
                TRANSACCIONES_STOCK = 1
            End If
            'Menu Configuracion
            If CStr(row("permiso")) = "REGISTRO DE USUARIOS" Then
                USUARIOS = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE PARAM. DE EMPRESAS" Then
                EMPRESAS = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE PARAM. DE SUCURSALES" Then
                SUCURSALES = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE PERMISOS DE ACCESO" Then
                PERMISOS = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE FORMAS DE PAGO" Then
                FORMAS_PAGO = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE TIPOS DE COMPROBANTES" Then
                TIPOS_COMPROBANTES = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE TIPOS DE COMPRAS" Then
                TIPOS_COMPRA = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE TIPOS DE IMPUESTOS" Then
                TIPOS_IMPUESTO = 1
            End If
            If CStr(row("permiso")) = "DEFINICION DE TIMBRADOS" Then
                TIMBRADOS = 1
            End If
            'Menu Reportes
            If CStr(row("permiso")) = "REPORTES DE COMPRAS" Then
                REPORTES_COMPRAS = 1
            End If
            If CStr(row("permiso")) = "REPORTES DE VENTAS" Then
                REPORTES_VENTAS = 1
            End If
            If CStr(row("permiso")) = "REPORTES DE PEDIDOS" Then
                REPORTES_PEDIDOS = 1
            End If
            If CStr(row("permiso")) = "REPORTES DE PRODUCCION" Then
                REPORTES_PRODUCCION = 1
            End If
            If CStr(row("permiso")) = "REPORTES EXTRAS" Then
                REPORTES_EXTRAS = 1
            End If
        Next
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        login()
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_contraseña.Focus()
        End If
    End Sub

    Private Sub txt_contraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_ingresar.Focus()
        End If
    End Sub

End Class