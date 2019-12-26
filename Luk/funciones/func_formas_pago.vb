Imports Npgsql

Public Class func_formas_pago

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
            util.mensajes("Error al listar Formas de Pago: " + ex.Message, "func_formas_pago", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(nombre As String, activo As Boolean, tipo_pago As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO formas_pago(nombre, activo, tipo_pago)
                                            VALUES (@nombre, @activo, @tipo_pago)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@tipo_pago", tipo_pago)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Forma de Pago: " + ex.Message, "func_formas_pago", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(nombre As String, activo As Boolean, tipo_pago As String, id_forma_pago As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE formas_pago SET nombre=@nombre, activo=@activo, 
                                            fecha_mod=now(), tipo_pago=@tipo_pago 
                                            WHERE id_forma_pago=@id_forma_pago", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@tipo_pago", tipo_pago)
            comand.Parameters.AddWithValue("@id_forma_pago", id_forma_pago)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Forma de Pago: " + ex.Message, "func_formas_pago", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(id_forma_pago As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM formas_pago WHERE id_forma_pago=@id_forma_pago", cnn)

            comand.Parameters.AddWithValue("@id_forma_pago", id_forma_pago)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Forma de Pago: " + ex.Message, "func_formas_pago", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
