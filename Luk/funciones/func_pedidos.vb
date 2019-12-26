Imports Npgsql

Public Class func_pedidos

    Inherits conexion
    Dim util As New utilidades()

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_pedidos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_asignacion_pedido(ultimo_nro_usado As Integer, usuario_cre As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO asignacion_pedidos(ultimo_nro_usado, usuario_cre) VALUES (@ultimo_nro_usado, @usuario_cre)", cnn)

            comand.Parameters.AddWithValue("@ultimo_nro_usado", ultimo_nro_usado)
            comand.Parameters.AddWithValue("@usuario_cre", usuario_cre)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Asignacion de Pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_asignacion_pedido(ultimo_nro_usado As Integer, usuario_mod As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE asignacion_pedidos SET ultimo_nro_usado=@ultimo_nro_usado, usuario_mod=@usuario_mod, fecha_mod=now()", cnn)

            comand.Parameters.AddWithValue("@ultimo_nro_usado", ultimo_nro_usado)
            comand.Parameters.AddWithValue("@usuario_mod", usuario_mod)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Asignacion de Pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function enviar_produccion(id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET enviado_produccion=true, fecha_mod=now() WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al enviar a produccion: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function enviado_produccion(id_pedido As Integer) As Boolean
        Try
            Dim dt As New DataTable
            dt = consultar("SELECT 1 FROM pedidos WHERE id_pedido=" & id_pedido.ToString & " AND enviado_produccion=true")

            Return dt.Rows.Count > 0

        Catch ex As Exception
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function id_pedido() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('pedidos_id_pedido_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al obtener secuencia de Pedido: " + ex.Message, "func_pedidos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_pedido As Integer, id_articulo As Integer, numero As String,
                              fecha_pedido As Date, fecha_entrega As Date, id_cliente As Integer,
                              id_vendedor As Integer, id_usuario As Integer, id_sucursal As Integer,
                              cantidad As Double, costo_unitario As Integer, costo_total As Integer,
                              total_descto As Integer, total_mano_obra As Integer, total_adicional As Integer,
                              estado As String, prioridad As Boolean, texto_termo As String,
                              logo_termo As String, texto_guampa As String, logo_guampa As String,
                              deliveri As Boolean, total_precio_venta As Integer, observaciones As String,
                             precio_unitario As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO pedidos(
                                                    id_pedido, id_articulo, numero, fecha_pedido, fecha_entrega, 
                                                    id_cliente, id_vendedor, id_usuario, id_sucursal, cantidad, costo_unitario, 
                                                    costo_total, total_descto, total_mano_obra, total_adicional, 
                                                    estado, prioridad, texto_termo, logo_termo, texto_guampa, logo_guampa, 
                                                    deliveri, total_precio_venta, observaciones, precio_unitario, id_proveedor)
                                            VALUES (@id_pedido, @id_articulo, @numero, @fecha_pedido, @fecha_entrega, 
                                                    @id_cliente, @id_vendedor, @id_usuario, @id_sucursal, @cantidad, @costo_unitario, 
                                                    @costo_total, @total_descto, @total_mano_obra, @total_adicional, 
                                                    @estado, @prioridad, @texto_termo, @logo_termo, @texto_guampa, @logo_guampa, 
                                                    @deliveri, @total_precio_venta, @observaciones, @precio_unitario, @id_proveedor)", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@fecha_pedido", fecha_pedido)
            comand.Parameters.AddWithValue("@fecha_entrega", fecha_entrega)
            comand.Parameters.AddWithValue("@id_cliente", id_cliente)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@total_descto", total_descto)
            comand.Parameters.AddWithValue("@total_mano_obra", total_mano_obra)
            comand.Parameters.AddWithValue("@total_adicional", total_adicional)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@prioridad", prioridad)
            comand.Parameters.AddWithValue("@texto_termo", texto_termo)
            comand.Parameters.AddWithValue("@logo_termo", logo_termo)
            comand.Parameters.AddWithValue("@texto_guampa", texto_guampa)
            comand.Parameters.AddWithValue("@logo_guampa", logo_guampa)
            comand.Parameters.AddWithValue("@deliveri", deliveri)
            comand.Parameters.AddWithValue("@total_precio_venta", total_precio_venta)
            comand.Parameters.AddWithValue("@observaciones", observaciones)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(id_pedido As Integer, id_articulo As Integer, numero As String,
                              fecha_pedido As Date, fecha_entrega As Date, id_cliente As Integer,
                              id_vendedor As Integer, id_usuario As Integer, id_sucursal As Integer,
                              cantidad As Double, costo_unitario As Integer, costo_total As Integer,
                              total_descto As Integer, total_mano_obra As Integer, total_adicional As Integer,
                              estado As String, prioridad As Boolean, texto_termo As String,
                              logo_termo As String, texto_guampa As String, logo_guampa As String,
                              deliveri As Boolean, total_precio_venta As Integer, observaciones As String,
                             precio_unitario As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET id_pedido=@id_pedido, id_articulo=@id_articulo, numero=@numero,
                                                    fecha_pedido=@fecha_pedido, fecha_entrega=@fecha_entrega, id_cliente=@id_cliente, 
                                                    id_vendedor=@id_vendedor, id_usuario=@id_usuario, id_sucursal=@id_sucursal, 
                                                    cantidad=@cantidad, costo_unitario=@costo_unitario, costo_total=@costo_total, 
                                                    total_descto=@total_descto, total_mano_obra=@total_mano_obra, total_adicional=@total_adicional, 
                                                    estado=@estado, prioridad=@prioridad, texto_termo=@texto_termo, logo_termo=@logo_termo, 
                                                    texto_guampa=@texto_guampa, logo_guampa=@logo_guampa, deliveri=@deliveri, fecha_mod=now(),
                                                    total_precio_venta=@total_precio_venta, observaciones=@observaciones, precio_unitario=@precio_unitario,
                                                    id_proveedor=@id_proveedor
                                            WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@fecha_pedido", fecha_pedido)
            comand.Parameters.AddWithValue("@fecha_entrega", fecha_entrega)
            comand.Parameters.AddWithValue("@id_cliente", id_cliente)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@total_descto", total_descto)
            comand.Parameters.AddWithValue("@total_mano_obra", total_mano_obra)
            comand.Parameters.AddWithValue("@total_adicional", total_adicional)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@prioridad", prioridad)
            comand.Parameters.AddWithValue("@texto_termo", texto_termo)
            comand.Parameters.AddWithValue("@logo_termo", logo_termo)
            comand.Parameters.AddWithValue("@texto_guampa", texto_guampa)
            comand.Parameters.AddWithValue("@logo_guampa", logo_guampa)
            comand.Parameters.AddWithValue("@deliveri", deliveri)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@total_precio_venta", total_precio_venta)
            comand.Parameters.AddWithValue("@observaciones", observaciones)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function anular_pedido(id_pedido As Integer, usr_anulacion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET estado='ANULADO', anulado=true, usr_anulacion=@usr_anulacion, fecha_anulacion=now(), fecha_mod=now()
                                            WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@usr_anulacion", usr_anulacion)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al anular Pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function entregado(id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET entregado=true, fecha_mod=now() WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al entregar pedido: " + ex.Message, "func_pedidos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
