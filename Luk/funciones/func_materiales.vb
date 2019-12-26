Imports Npgsql

Public Class func_materiales

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_material() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('materiales_id_material_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al obtener id_material: " + ex.Message, "func_materiales", "ERR")
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
            util.mensajes("Error al listar Materiales: " + ex.Message, "func_materiales", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_material As Integer, nombre As String, codigo As String, id_usuario As Integer, costo_unitario As Integer,
                             id_tipo_impuesto As Integer, id_familia As Integer, controlar_stock As Boolean, id_proveedor As Integer, stock_minimo As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO materiales(id_material, nombre, codigo, id_usuario, costo_unitario, 
                                            id_tipo_impuesto, id_familia, controlar_stock, id_proveedor, stock_minimo)
                                            VALUES (@id_material, @nombre, @codigo, @id_usuario, @costo_unitario, @id_tipo_impuesto, 
                                            @id_familia, @controlar_stock, @id_proveedor, @stock_minimo)", cnn)

            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)
            comand.Parameters.AddWithValue("@id_familia", id_familia)
            comand.Parameters.AddWithValue("@controlar_stock", controlar_stock)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@stock_minimo", stock_minimo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Material: " + ex.Message, "func_materiales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(nombre As String, codigo As String, id_usuario As Integer, id_material As Integer, costo_unitario As Integer,
                                id_tipo_impuesto As Integer, id_familia As Integer, controlar_stock As Boolean, id_proveedor As Integer, stock_minimo As Double) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE materiales SET nombre=@nombre, codigo=@codigo, id_usuario=@id_usuario, 
                                             costo_unitario=@costo_unitario, id_tipo_impuesto=@id_tipo_impuesto, fecha_mod=now(),
                                             id_familia=@id_familia, controlar_stock=@controlar_stock, id_proveedor=@id_proveedor,
                                             stock_minimo=@stock_minimo WHERE id_material=@id_material", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)
            comand.Parameters.AddWithValue("@id_familia", id_familia)
            comand.Parameters.AddWithValue("@controlar_stock", controlar_stock)
            comand.Parameters.AddWithValue("@id_material", id_material)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@stock_minimo", stock_minimo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Material: " + ex.Message, "func_materiales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_costo(costo_unitario As Integer, id_material As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE materiales SET costo_unitario=@costo_unitario WHERE id_material=@id_material", cnn)

            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_material", id_material)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Costo de Materia Prima: " + ex.Message, "func_materiales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
