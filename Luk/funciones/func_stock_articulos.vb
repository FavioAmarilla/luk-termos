Imports Npgsql

Public Class func_stock_articulos

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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_stock_articulos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function validar_stock(id_item As Integer, campo As String, id_sucursal As Integer) As Boolean
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim sql As String = ""

            If campo = "articulo" Then
                sql = "SELECT * FROM stock_articulos WHERE id_articulo=" + id_item.ToString() + " AND id_sucursal=" + id_sucursal.ToString
            End If

            If campo = "material" Then
                sql = "SELECT * FROM stock_articulos WHERE id_material=" + id_item.ToString() + " AND id_sucursal=" + id_sucursal.ToString
            End If

            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt.Rows().Count() > 0
        Catch ex As Exception
            util.mensajes("Error al Validar Stock: " + ex.Message, "func_stock_articulos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_articulo As Integer, cantidad As Double, stock_minimo As Double, costo_unit_actual As Integer,
                                precio_unit_actual As Integer, id_material As Integer, id_sucursal As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO stock_articulos( id_articulo, cantidad, stock_minimo, costo_unitario_actual, 
                                                    precio_unitario_actual, id_sucursal, id_material)
                                            VALUES (@id_articulo, @cantidad, @stock_minimo, @costo_unitario_actual, 
                                                    @precio_unitario_actual, @id_sucursal, @id_material)", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@stock_minimo", stock_minimo)
            comand.Parameters.AddWithValue("@costo_unitario_actual", costo_unit_actual)
            comand.Parameters.AddWithValue("@precio_unitario_actual", precio_unit_actual)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@id_material", id_material)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Articulo: " + ex.Message, "func_stock_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(id_articulo As Integer, cantidad As Double, stock_minimo As Double, costo_unit_actual As Integer,
                                precio_unit_actual As Integer, id_material As Integer, id_stock As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE stock_articulos SET id_articulo=@id_articulo, cantidad=@cantidad, 
                                            stock_minimo=@stock_minimo, costo_unitario_actual=@costo_unitario_actual, 
                                            precio_unitario_actual=@precio_unitario_actual, id_sucursal=@id_sucursal, 
                                            id_material=@id_material, fecha_mod=now() 
                                            WHERE id_stock=@id_stock", cnn)

            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@stock_minimo", stock_minimo)
            comand.Parameters.AddWithValue("@costo_unitario_actual", costo_unit_actual)
            comand.Parameters.AddWithValue("@precio_unitario_actual", precio_unit_actual)
            comand.Parameters.AddWithValue("@id_sucursal", frm_main.ID_SUCURSAL)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@id_stock", id_stock)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Articulo: " + ex.Message, "func_stock_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function aumentar_stock(id_item As Integer, cantidad As Double, campo As String, id_sucursal As Integer) As Boolean
        Dim sql As String = ""
        Try
            conectar()

            If campo = "articulo" Then
                sql = "UPDATE stock_articulos SET cantidad= cantidad + @cantidad, fecha_mod=now() 
                                            WHERE id_articulo = @id_item AND id_sucursal=@id_sucursal"
            End If

            If campo = "material" Then
                sql = "UPDATE stock_articulos SET cantidad= cantidad + @cantidad, fecha_mod=now() 
                                            WHERE id_material = @id_item AND id_sucursal=@id_sucursal"
            End If

            Dim comand As New NpgsqlCommand(sql, cnn)

            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@id_item", id_item)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al aumentar Stock de Item: " + ex.Message, "func_stock_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function disminuir_stock(id_item As Integer, cantidad As Double, campo As String, id_sucursal As Integer) As Boolean
        Dim sql As String = ""
        Try
            conectar()

            If campo = "articulo" Then
                sql = "UPDATE stock_articulos SET cantidad= cantidad - @cantidad, fecha_mod=now() 
                                            WHERE id_articulo = @id_item AND id_sucursal=@id_sucursal"
            End If

            If campo = "material" Then
                sql = "UPDATE stock_articulos SET cantidad= cantidad - @cantidad, fecha_mod=now() 
                                            WHERE id_material = @id_item AND id_sucursal=@id_sucursal"
            End If

            Dim comand As New NpgsqlCommand(sql, cnn)

            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@id_item", id_item)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al aumentar Stock de Item: " + ex.Message, "func_stock_articulos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class

