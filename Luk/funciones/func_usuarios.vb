Imports Npgsql

Public Class func_usuarios
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
            util.mensajes("Error al listar Usuarios: " + ex.Message, "func_usuarios", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre_completo As String, ByVal telefono As String, ByVal direccion As String, ByVal ciudad As String,
                             ByVal correo As String, ByVal login As String, ByVal clave_acceso As String, ByVal activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO usuarios(nombre_completo, telefono, direccion, ciudad, correo, login, clave_acceso, activo)
                                            VALUES (@nombre_completo, @telefono, @direccion, @ciudad, @correo, @login, @clave_acceso, @activo)", cnn)

            comand.Parameters.AddWithValue("@nombre_completo", nombre_completo)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@login", login)
            comand.Parameters.AddWithValue("@clave_acceso", clave_acceso)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Usuario: " + ex.Message, "func_usuarios", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombre_completo As String, ByVal telefono As String, ByVal direccion As String, ByVal ciudad As String,
                               ByVal correo As String, ByVal login As String, ByVal clave_acceso As String, ByVal activo As Boolean,
                               ByVal id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE usuarios SET nombre_completo=@nombre_completo, telefono=@telefono, 
                                            direccion=@direccion, ciudad=@ciudad, correo=@correo, login=@login, 
                                            clave_acceso=@clave_acceso, activo=@activo, fecha_mod=now() 
                                            WHERE id_usuario=@id_usuario", cnn)

            comand.Parameters.AddWithValue("@nombre_completo", nombre_completo)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@login", login)
            comand.Parameters.AddWithValue("@clave_acceso", clave_acceso)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Usuario: " + ex.Message, "func_usuarios", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP usuarios WHERE id_usuario=@id_usuario", cnn)

            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Usuario: " + ex.Message, "func_usuarios", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
