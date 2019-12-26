
Imports Npgsql

Public Class func_tipos_impuesto
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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_tipos_impuesto", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal valor As Integer, ByVal activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO tipos_impuesto(nombre, valor, activo)
                                            VALUES (@nombre, @valor, @activo)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@valor", valor)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Tipo de Impuesto: " + ex.Message, "func_tipos_impuesto", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombre As String, ByVal valor As Integer, ByVal id_tipo_impuesto As Integer, ByVal activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE tipos_impuesto SET nombre=@nombre, valor=@valor, activo=@activo,  
                                            fecha_mod=now() WHERE id_tipo_impuesto=@id_tipo_impuesto", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@valor", valor)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Tipo de Impuesto: " + ex.Message, "func_tipos_impuesto", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_tipo_impuesto As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM tipos_impuesto WHERE id_tipo_impuesto=@id_tipo_impuesto", cnn)

            comand.Parameters.AddWithValue("@id_tipo_impuesto", id_tipo_impuesto)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Tipo de Impuesto: " + ex.Message, "func_tipos_impuesto", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
