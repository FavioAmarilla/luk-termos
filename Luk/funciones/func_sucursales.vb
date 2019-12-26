Imports Npgsql

Public Class func_sucursales

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
            util.mensajes("Error al listar Sucursales: " + ex.Message, "func_sucursales", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal telefono As String, ByVal email As String,
                             ByVal pais As String, ByVal ciudad As String, ByVal direccion As String,
                             ByVal codigo As String, ByVal id_empresa As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO sucursales (nombre, telefono, email, pais, ciudad, direccion, codigo, id_empresa)
                                            VALUES (@nombre, @telefono, @email, @pais, @ciudad, @direccion, @codigo, @id_empresa)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@email", email)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Sucursal: " + ex.Message, "func_sucursales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombre As String, ByVal telefono As String, ByVal email As String,
                               ByVal pais As String, ByVal ciudad As String, ByVal direccion As String,
                               ByVal codigo As String, ByVal id_empresa As Integer,
                               ByVal id_sucursal As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE sucursales SET nombre=@nombre, telefono=@telefono, 
                                            email=@email, pais=@pais, ciudad=@ciudad, direccion=@direccion, 
                                            codigo=@codigo, id_empresa=@id_empresa, fecha_mod=now() WHERE id_sucursal=@id_sucursal", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@email", email)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Sucursal: " + ex.Message, "func_sucursales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_sucursal As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP sucursales WHERE id_sucursal=@id_sucursal", cnn)

            comand.Parameters.AddWithValue("@id_empleado", id_sucursal)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Sucursal: " + ex.Message, "func_sucursales", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
