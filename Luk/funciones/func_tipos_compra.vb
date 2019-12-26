Imports Npgsql

Public Class func_tipos_compra

    Inherits conexion
    Dim util As New utilidades()

    Public Function listar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al listar Tipos de Compra: " + ex.Message, "func_tipos_compra", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(nombre As String, activo As Boolean, relacion As String, requiere_item As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO tipos_compra(nombre, activo, relacion, requiere_item)
                                            VALUES (@nombre, @activo, @relacion, @requiere_item)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@relacion", relacion)
            comand.Parameters.AddWithValue("@requiere_item", requiere_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Tipo de Compra: " + ex.Message, "func_tipos_compra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(nombre As String, activo As Boolean, relacion As String, id_tipo_compra As Integer, requiere_item As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE tipos_compra SET nombre=@nombre, activo=@activo, 
                                            relacion=@relacion, requiere_item=@requiere_item, fecha_mod=now() 
                                            WHERE id_tipo_compra=@id_tipo_compra", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@relacion", relacion)
            comand.Parameters.AddWithValue("@requiere_item", requiere_item)
            comand.Parameters.AddWithValue("@id_tipo_compra", id_tipo_compra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Tipo de Compra: " + ex.Message, "func_tipos_compra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
