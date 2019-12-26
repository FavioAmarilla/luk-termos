Imports Npgsql

Public Class func_vendedores
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
            util.mensajes("Error al listar Vendedores: " + ex.Message, "func_vendedores", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(nombres As String, apellidos As String, telefono As String, direccion As String, ciudad As String,
                             correo As String, porcentaje_comision As Integer, activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO vendedores(nombres, apellidos, telefono, direccion, ciudad, correo, porcentaje_comision, activo)
                                            VALUES (@nombres, @apellidos, @telefono, @direccion, @ciudad, @correo, @porcentaje_comision, @activo)", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@porcentaje_comision", porcentaje_comision)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Vendedor: " + ex.Message, "func_vendedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(nombres As String, apellidos As String, telefono As String, direccion As String, ciudad As String, correo As String,
                                id_vendedor As Integer, porcentaje_comision As Integer, activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE vendedores SET nombres=@nombres, apellidos=@apellidos, 
                                            telefono=@telefono, direccion=@direccion, ciudad=@ciudad, correo=@correo, 
                                            porcentaje_comision=@porcentaje_comision, activo=@activo, fecha_mod=now() 
                                            WHERE id_vendedor=@id_vendedor", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@correo", correo)
            comand.Parameters.AddWithValue("@porcentaje_comision", porcentaje_comision)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Vendedor: " + ex.Message, "func_vendedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(id_vendedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP vendedores WHERE id_vendedor=@id_vendedor", cnn)

            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Vendedor: " + ex.Message, "func_vendedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
