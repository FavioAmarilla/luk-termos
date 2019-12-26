Imports Npgsql

Public Class func_familias
    Inherits conexion
    Dim util As New utilidades()

    Public Function listar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al Realizar Consulta: " + ex.Message, "func_familias", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function validar_familia_articulo(codigo As String) As Boolean
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT 1 FROM articulos a
                                                                 INNER JOIN familias f ON f.identificador = a.id_familia
                                                                 WHERE f.codigo = '" + codigo + "'", cnn)
            da.Fill(dt)
            Dim filas As Integer = dt.Rows().Count()

            Return filas > 0
        Catch ex As Exception
            util.mensajes("Error al Realizar Consulta: " + ex.Message, "func_familias", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(descripcion As String, nivel As Integer, ultimo_nivel As Boolean, codigo As String, id_linea_padre As Integer, nro_item As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO familias(descripcion, nivel, ultimo_nivel, codigo, id_linea_padre, nro_item)
                                             VALUES (@descripcion, @nivel, @ultimo_nivel, @codigo, @id_linea_padre, @nro_item)", cnn)

            comand.Parameters.AddWithValue("@descripcion", descripcion)
            comand.Parameters.AddWithValue("@nivel", nivel)
            comand.Parameters.AddWithValue("@ultimo_nivel", ultimo_nivel)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_linea_padre", id_linea_padre)
            comand.Parameters.AddWithValue("@nro_item", nro_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Registrar Familia: " + ex.Message, "func_familias", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ultimo_nivel As Boolean, identificador As Integer, descripcion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE familias SET ultimo_nivel=@ultimo_nivel,descripcion=@descripcion WHERE identificador=@identificador", cnn)

            comand.Parameters.AddWithValue("@ultimo_nivel", ultimo_nivel)
            comand.Parameters.AddWithValue("@identificador", identificador)
            comand.Parameters.AddWithValue("@descripcion", descripcion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Actualizar Familia: " + ex.Message, "func_familias", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM familias WHERE identificador=@identificador", cnn)

            comand.Parameters.AddWithValue("@identificador", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Eliminar Familia: " + ex.Message, "func_familias", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_familia_articulo(id_familia_valor As Integer, id_familia As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE articulos SET id_familia=@id_familia_valor WHERE id_familia=@id_familia", cnn)

            comand.Parameters.AddWithValue("@id_familia_valor", id_familia_valor)
            comand.Parameters.AddWithValue("@id_familia", id_familia)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Realizar Traspaso: " + ex.Message, "func_familias", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
