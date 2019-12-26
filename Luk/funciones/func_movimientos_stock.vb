Imports Npgsql

Public Class func_movimientos_stock

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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_movimientos_stock", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    'Operaciones sobre la tabla <<movimientos_stock>>
    Public Function id_movimiento_stock() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('movimiento_stock_id_movimiento_stock_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                util.mensajes("No existe secuencia para articulo", "func_movimientos_stock", "ERR")
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_movimientos_stock", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_movimiento_stock(id_movimiento_stock As Integer, id_sucursal As Integer,
                                               id_usuario As Integer, id_pedido As Integer, nro_pedido As String,
                                              id_venta As Integer, id_compra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO movimiento_stock(id_movimiento_stock, id_sucursal, id_usuario, 
                                            id_pedido, nro_pedido, id_venta, id_compra)
                                            VALUES (@id_movimiento_stock, @id_sucursal, @id_usuario, @id_pedido, 
                                            @nro_pedido, @id_venta, @id_compra)", cnn)

            comand.Parameters.AddWithValue("@id_movimiento_stock", id_movimiento_stock)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@nro_pedido", nro_pedido)
            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@id_compra", id_compra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Movimiento de Stock: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_movimiento_stock(id_movimiento_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE movimiento_stock SET fecha_mod=now() WHERE id_movimiento_stock=@id_movimiento_stock", cnn)

            comand.Parameters.AddWithValue("@id_movimiento_stock", id_movimiento_stock)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar fecha de mod. Movimiento de Stock: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_movimiento_stock_costeo(id_movimiento_stock As Integer, id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE costeo_De_pedido SET fecha_mod=now(), id_movimiento_stock=@id_movimiento_stock
                                            WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_movimiento_stock", id_movimiento_stock)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Movim. de Stock de Costeo: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    'Operaciones sobre la tabla <<movim_items_stock>>
    Public Function id_movim_items_stock() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('movim_item_stock_id_movim_item_stock_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_movimientos_stock", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_movim_item_stock(id_movimiento As Integer, id_transaccion As Integer, accion As String, id_material As Integer,
                                               cantidad_unit As Double, costo_unitario As Double, costo_total As Integer, id_articulo As Integer,
                                               precio_unitario As Integer, id_movim_item_stock As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO movim_item_stock(id_movim_item_stock, id_movimiento, id_transaccion, accion, id_material, 
                                                    cantidad_unit, costo_unitario, costo_total, id_articulo, precio_unitario, id_proveedor)
                                            VALUES (@id_movim_item_stock, @id_movimiento, @id_transaccion, @accion, @id_material, 
                                                    @cantidad_unit, @costo_unitario,@costo_total, @id_articulo, @precio_unitario, @id_proveedor)", cnn)

            comand.Parameters.AddWithValue("@id_movimiento", id_movimiento)
            comand.Parameters.AddWithValue("@id_transaccion", id_transaccion)
            comand.Parameters.AddWithValue("@accion", accion)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@cantidad_unit", cantidad_unit)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@id_movim_item_stock", id_movim_item_stock)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Items de Movimiento de Stock: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_movim_item_stock(cantidad_unit As Double, costo_unitario As Integer,
                                                        costo_total As Integer, id_movim_item_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE movim_item_stock SET cantidad_unit=@cantidad_unit, costo_unitario=@costo_unitario, costo_total=@costo_total, 
                                            fecha_mod=now()
                                            WHERE id_movim_item_stock=@id_movim_item_stock", cnn)

            comand.Parameters.AddWithValue("@cantidad_unit", cantidad_unit)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@id_movim_item_stock", id_movim_item_stock)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Movim. Stock de Items: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_movim_item_stock(id_movim_item_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM movim_item_stock WHERE id_movim_item_stock=@id_movim_item_stock", cnn)

            comand.Parameters.AddWithValue("@id_movim_item_stock", id_movim_item_stock)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Items de Stock: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar_movim_item_stock_costeo(id_costeo_item As Integer, id_movim_item_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE costeo_item SET id_movim_item_stock=@id_movim_item_stock 
                                             WHERE id_costeo_item=@id_costeo_item", cnn)

            comand.Parameters.AddWithValue("@id_movim_item_stock", id_movim_item_stock)
            comand.Parameters.AddWithValue("@id_costeo_item", id_costeo_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Movim. Stock de Items Costeo: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_recepcionado_pedido(recepcionado As Boolean, id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET recepcionado=@recepcionado 
                                             WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@recepcionado", recepcionado)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar campo Recepcionado de Pedido: " + ex.Message, "func_movimientos_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
