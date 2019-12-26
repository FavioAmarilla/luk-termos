Imports Npgsql

Public Class func_articulos

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_articulo() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('articulos_id_articulo_seq') ", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_articulos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function listar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_articulos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function existe_codigo_barras(codigo_barras As String) As Boolean
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT 1 FROM articulos where codigo_barras='" & codigo_barras & "'", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                util.mensajes("Codigo de Barras en uso", "Articulos", "WAR")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            util.mensajes("Error existe_codigo_barras(): " + ex.Message, "func_articulos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_articulo As Integer, nombre As String, comentario As String, codigo_articulo As String,
                              id_proveedor As Integer, id_tipo_impuesto As Integer, codigo_barras As String, produccion_propia As Boolean,
                             id_familia As Integer, imagen As String, costo_mano_obra As Integer, activo As Boolean, porc_recargo As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO articulos(id_articulo, nombre, comentario, codigo_articulo, id_proveedor, id_tipo_impuesto,
                                            codigo_barras, produccion_propia, id_familia, imagen,costo_mano_obra, activo, porc_recargo)
                                            VALUES (@id_articulo, @nombre, @comentario, @codigo_articulo, @id_proveedor, @id_tipo_impuesto,
                                            @codigo_barras, @produccion_propia, @id_familia, @imagen, @costo_mano_obra, @activo, @porc_recargo)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@comentario", comentario)
            comand.Parameters.AddWithValue("@codigo_articulo", codigo_articulo)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)
            comand.Parameters.AddWithValue("@codigo_barras", codigo_barras)
            comand.Parameters.AddWithValue("@produccion_propia", produccion_propia)
            comand.Parameters.AddWithValue("@id_familia", id_familia)
            comand.Parameters.AddWithValue("@imagen", imagen)
            comand.Parameters.AddWithValue("@costo_mano_obra", costo_mano_obra)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@porc_recargo", porc_recargo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(nombre As String, comentario As String, codigo_articulo As String, id_proveedor As Integer,
                               id_tipo_impuesto As Integer, id_articulo As Integer, produccion_propia As Boolean, id_familia As Integer,
                               imagen As String, costo_mano_obra As Integer, activo As Boolean, porc_recargo As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET nombre=@nombre, comentario=@comentario, 
                                            codigo_articulo=@codigo_articulo, id_proveedor=@id_proveedor, 
                                            produccion_propia=@produccion_propia, id_tipo_impuesto=@id_tipo_impuesto, 
                                            id_familia=@id_familia,costo_mano_obra=@costo_mano_obra, fecha_mod=now(), 
                                            imagen=@imagen, activo=@activo, porc_recargo=@porc_recargo
                                            WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@comentario", comentario)
            comand.Parameters.AddWithValue("@codigo_articulo", codigo_articulo)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@produccion_propia", produccion_propia)
            comand.Parameters.AddWithValue("@id_familia", id_familia)
            comand.Parameters.AddWithValue("@imagen", imagen)
            comand.Parameters.AddWithValue("@costo_mano_obra", costo_mano_obra)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@porc_recargo", porc_recargo)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_precio_venta(precio_venta As Integer, id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET precio_venta=@precio_venta WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizarcosto(costo_unitario As Integer, id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET costo_unitario=@costo_unitario WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM articulos WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_articulo_materiales(id_articulo As Integer, id_material As Integer, cantidad As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO articulo_materiales(id_articulo, id_material, cantidad)
                                            VALUES (@id_articulo, @id_material, @cantidad)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@cantidad", cantidad)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Materiales del Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_articulo_materiales(id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM articulo_materiales WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Materiales del Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_costo(costo_unitario As Integer, id_articulo As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET costo_unitario=@costo_unitario, fecha_mod=now() WHERE id_articulo=@id_articulo", cnn)

            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Costo de Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_historial(id_articulo As Integer, nuevo_precio As Integer, precio_anterior As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO historial_mod_precio_venta(id_articulo, nuevo_precio, precio_anterior)
                                            VALUES (@id_articulo, @nuevo_precio, @precio_anterior)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@nuevo_precio", nuevo_precio)
            comand.Parameters.AddWithValue("@precio_anterior", precio_anterior)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Historial de Precio de Venta: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function traspaso(id_proveedor As Integer, id_traspaso As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET id_proveedor=@id_traspaso, fecha_mod=now()
                                            WHERE id_proveedor=@id_proveedor", cnn)

            comand.Parameters.AddWithValue("@id_traspaso", id_traspaso)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al traspasar Articulo: " + ex.Message, "func_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
