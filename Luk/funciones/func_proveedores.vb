Imports Npgsql
Public Class func_proveedores
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
            util.mensajes("Error al listar Proveedores: " + ex.Message, "func_proveedores", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(nombre As String, ruc As String, telefono As String, correo As String, pais As String,
                              ciudad As String, direccion As String, pagina_web As String, activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO proveedores(nombre, ruc, telefono, correo, pais, ciudad, direccion, pagina_web, activo)
                                            VALUES (@nombre, @ruc, @telefono, @correo, @pais, @ciudad, @direccion, @pagina_web, @activo)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@ruc", ruc)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@pagina_web", pagina_web)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Proveedor: " + ex.Message, "func_proveedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(nombre As String, ruc As String, telefono As String, correo As String, pais As String,
                                ciudad As String, direccion As String, pagina_web As String, activo As Boolean,
                                id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE proveedores SET nombre=@nombre, ruc=@ruc, telefono=@telefono, correo=@correo, pais=@pais, 
                                             ciudad=@ciudad, direccion=@direccion, pagina_web=@pagina_web, 
                                             activo=@activo, fecha_mod=now() WHERE id_proveedor=@id_proveedor", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@ruc", ruc)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@pagina_web", pagina_web)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Proveedor: " + ex.Message, "func_proveedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class