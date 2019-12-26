Imports Npgsql

Public Class func_permisos

    Inherits conexion
    Dim util As New utilidades()

    Public Function consultar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al listar realizar consulta: " + ex.Message, "func_permisos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO permisos(nombre)
                                            VALUES (@nombre)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Permiso: " + ex.Message, "func_permisos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ByVal nombre As String, ByVal id_permiso As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE permisos SET nombre=@nombre, 
                                            fecha_mod=now() WHERE id_permiso=@id_permiso", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@id_permiso", id_permiso)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Permisos: " + ex.Message, "func_permisos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_permisos_usuario(ByVal id_permiso As Integer, ByVal id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO permisos_usuario(id_permiso, id_usuario)
                                            VALUES (@id_permiso, @id_usuario)", cnn)

            comand.Parameters.AddWithValue("@id_permiso", id_permiso)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Permisos del Usuario: " + ex.Message, "func_permisos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_permisos_usuario(ByVal id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM permisos_usuario WHERE id_usuario=@id_usuario", cnn)

            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Permiso del Usuario: " + ex.Message, "func_permisos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
