Imports Npgsql

Public Class func_costeo_pedido
    Inherits conexion
    Dim util As New utilidades()

    Public Function id_costeo_pedido() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('costeo_pedido_id_costeo_pedido_seq')", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Costeo: " + ex.Message, "func_costeo_pedidos", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_costeo_pedidos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_totales_pedido(costo_unitario As Integer, costo_total As Integer, total_descto As Integer,
                                              total_mano_obra As Integer, total_adicional As Integer, id_pedido As Integer,
                                              comision_vendedor As Integer, precio_unitario As Integer,
                                              total_precio_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET costo_unitario=@costo_unitario, costo_total=@costo_total, 
                                            total_descto=@total_descto, total_mano_obra=@total_mano_obra, 
                                            total_adicional=@total_adicional, comision_vendedor=@comision_vendedor, 
                                            precio_unitario=@precio_unitario, total_precio_venta=@total_precio_venta, 
                                            fecha_mod=now() WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@total_descto", total_descto)
            comand.Parameters.AddWithValue("@total_mano_obra", total_mano_obra)
            comand.Parameters.AddWithValue("@total_adicional", total_adicional)
            comand.Parameters.AddWithValue("@comision_vendedor", comision_vendedor)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@total_precio_venta", total_precio_venta)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Totales del Pedido: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_estado_pedido(estado As String, id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET estado=@estado, fecha_mod=now()
                                            WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Estado del Pedido: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_costeo_pedido(id_costeo_pedido As Integer, id_pedido As Integer, id_articulo As Integer, total_costo As Integer,
                                           id_usuarios As Integer, total_descto As Integer, costo_adicional As Integer, id_sucursal As Integer,
                                           total_unitario As Integer, cantidad_articulo As Double, mano_obra As Integer, comision_vendedor As Integer,
                                           precio_venta As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO costeo_de_pedido(id_costeo_de_pedido, id_pedido, id_articulo, fecha_costeo, total_costo, 
                                            id_usuario, total_descto, costo_adicional, id_sucursal, total_unitario, cantidad_articulo, mano_obra,
                                            comision_vendedor, precio_venta, id_proveedor)
                                            VALUES (@id_costeo_pedido, @id_pedido, @id_articulo, now(), @total_costo,@id_usuario, @total_descto, @costo_adicional,
                                            @id_sucursal, @total_unitario, @cantidad_articulo, @mano_obra, @comision_vendedor, @precio_venta, @id_proveedor)", cnn)

            comand.Parameters.AddWithValue("@id_costeo_pedido", id_costeo_pedido)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@total_costo", total_costo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuarios)
            comand.Parameters.AddWithValue("@total_descto", total_descto)
            comand.Parameters.AddWithValue("@costo_adicional", costo_adicional)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@total_unitario", total_unitario)
            comand.Parameters.AddWithValue("@cantidad_articulo", cantidad_articulo)
            comand.Parameters.AddWithValue("@mano_obra", mano_obra)
            comand.Parameters.AddWithValue("@comision_vendedor", comision_vendedor)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Costeo de Pedido: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_costeo_pedido(id_pedido As Integer, id_articulo As Integer, total_costo As Integer,
                                total_descto As Integer, costo_adicional As Integer, id_usuario As Integer,
                                id_sucursal As Integer, total_unitario As Integer, cantidad_articulo As Double,
                                id_costeo_de_pedido As Integer, mano_obra As Integer, comision_vendedor As Integer,
                                precio_venta As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE costeo_de_pedido SET id_pedido=@id_pedido, id_articulo=@id_articulo, 
                                             total_costo=@total_costo, total_descto=@total_descto, costo_adicional=@costo_adicional, 
                                             id_usuario=@id_usuario, id_sucursal=@id_sucursal, total_unitario=@total_unitario, 
                                             cantidad_articulo=@cantidad_articulo, fecha_mod=now(), mano_obra=@mano_obra, 
                                             comision_vendedor=@comision_vendedor, precio_venta=@precio_venta, id_proveedor=@id_proveedor 
                                             WHERE id_costeo_de_pedido=@id_costeo_de_pedido", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@total_costo", total_costo)
            comand.Parameters.AddWithValue("@total_descto", total_descto)
            comand.Parameters.AddWithValue("@costo_adicional", costo_adicional)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@total_unitario", total_unitario)
            comand.Parameters.AddWithValue("@cantidad_articulo", cantidad_articulo)
            comand.Parameters.AddWithValue("@mano_obra", mano_obra)
            comand.Parameters.AddWithValue("@id_costeo_de_pedido", id_costeo_de_pedido)
            comand.Parameters.AddWithValue("@comision_vendedor", comision_vendedor)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Costeo de Pedido: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_costeo_item(id_costeo_de_pedido As Integer, id_material As Integer, cantidad As Double, costo_unitario As Integer,
                                         costo_final As Integer, cantidad_articulo As Double, precio_venta As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO costeo_item(id_costeo_de_pedido, id_material, cantidad, costo_unitario, 
                                            costo_final, cantidad_articulo, precio_venta, id_proveedor)
                                            VALUES (@id_costeo_de_pedido, @id_material, @cantidad, @costo_unitario, 
                                            @costo_final, @cantidad_articulo, @precio_venta, @id_proveedor)", cnn)

            comand.Parameters.AddWithValue("@id_costeo_de_pedido", id_costeo_de_pedido)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_final", costo_final)
            comand.Parameters.AddWithValue("@cantidad_articulo", cantidad_articulo)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Items del Costeo: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_costeo_item(id_costeo_de_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM costeo_item WHERE id_costeo_de_pedido=@id_costeo_de_pedido", cnn)

            comand.Parameters.AddWithValue("@id_costeo_de_pedido", id_costeo_de_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Items de Costeo: " + ex.Message, "func_costeo_pedido", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
