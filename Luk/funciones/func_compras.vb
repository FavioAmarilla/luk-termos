Imports Npgsql

Public Class func_compras
    Inherits conexion
    Private util As New utilidades

    Public Function id_compra() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('compras_id_compra_seq') ", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Compra: " + ex.Message, "func_compras", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function consultar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_compras", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_compra(id_compra As Integer, id_tipo_compra As Integer, id_proveedor As Integer, id_sucursal As Integer,
                                    total_compra As Integer, id_usuario As Integer, ByVal numero As String,
                                    id_movim_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO compras(id_compra, id_tipo_compra, id_proveedor, fecha_compra, id_sucursal, 
                                            total_compra, id_usuario, numero, id_movim_stock)
                                            VALUES (@id_compra, @id_tipo_compra, @id_proveedor, now(), @id_sucursal,
                                            @total_compra, @id_usuario, @numero, @id_movim_stock)", cnn)

            comand.Parameters.AddWithValue("@id_compra", id_compra)
            comand.Parameters.AddWithValue("@id_tipo_compra", id_tipo_compra)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@total_compra", total_compra)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@id_movim_stock", id_movim_stock)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Compras: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_compras(total_compra As Integer, id_compra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE compras SET total_compra=@total_compra, fecha_mod=now() WHERE id_compra=@id_compra", cnn)

            comand.Parameters.AddWithValue("@total_compra", total_compra)
            comand.Parameters.AddWithValue("@id_compra", id_compra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Compra: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function id_item_compra() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT last_value FROM compras_id_compra_seq", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Compra: " + ex.Message, "func_compras", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_items_compra(id_compra As Integer, id_material As Integer, cantidad As Double,
                                          costo_unitario As Integer, costo_total As Integer, id_articulo As Integer,
                                          id_item_mv_stock As Integer, id_proveedor As Integer, precio_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO items_compras(id_compra, id_material, cantidad, costo_unitario, costo_total, id_articulo, 
                                             id_item_mv_stock, id_proveedor, precio_venta)
                                             VALUES (@id_compra, @id_material, @cantidad, @costo_unitario, @costo_total, @id_articulo, @id_item_mv_stock, 
                                             @id_proveedor, @precio_venta)", cnn)

            comand.Parameters.AddWithValue("@id_compra", id_compra)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@id_item_mv_stock", id_item_mv_stock)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Items de  Compras: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_items_compra(cantidad As Double, costo_unitario As Integer, costo_total As Double,
                                           id_item_compra As Integer, id_proveedor As Integer, precio_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE items_compras SET cantidad=@cantidad, costo_unitario=@costo_unitario, costo_total=@costo_total, 
                                            fecha_mod=now(), id_proveedor=@id_proveedor, precio_venta=@precio_venta
                                            WHERE id_item_compra=@id_item_compra", cnn)

            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@id_item_compra", id_item_compra)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Items Compras: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_item_compra(id_item_compra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM items_compras WHERE id_item_compra=@id_item_compra", cnn)

            comand.Parameters.AddWithValue("@id_item_compra", id_item_compra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Item Compra: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_id_proveedor_articulo(id_proveedor As Integer, id_item As Integer, item As String) As Boolean
        Try
            Dim sql As String = ""
            conectar()

            If item = "AR" Then
                sql = "UPDATE articulos SET id_proveedor=@id_proveedor, fecha_mod=now() WHERE id_articulo=@id_item"
            End If

            If item = "MA" Then
                sql = "UPDATE materiales SET id_proveedor=@id_proveedor, fecha_mod=now() WHERE id_material=@id_item"
            End If

            Dim comand As New NpgsqlCommand(sql, cnn)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@id_item", id_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Id Proveedor de Articulo: " + ex.Message, "func_compras", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
