Imports Npgsql

Public Class func_tipos_comprobante

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
            util.mensajes("Error al listar Tipos de Comprobantes: " + ex.Message, "func_tipos_comprobantes", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO tipos_comprobante(nombre, activo)
                                            VALUES (@nombre, @activo)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Tipo de Comprobantes: " + ex.Message, "func_tipos_comprobantes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombre As String, ByVal activo As Boolean, ByVal id_tipo_compra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE tipos_comprobante SET nombre=@nombre, activo=@activo, 
                                            fecha_mod=now() WHERE id_tipo_compra=@id_tipo_compra", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@id_tipo_compra", id_tipo_compra)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Tipo de Comprobantes: " + ex.Message, "func_tipos_comprobantes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_tipo_compra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM tipos_comprobante WHERE id_tipo_compra=@id_tipo_compra", cnn)

            comand.Parameters.AddWithValue("@id_tipo_compra", id_tipo_compra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Tipo de Comprobantes: " + ex.Message, "func_tipos_comprobantes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
