Imports Npgsql

Public Class func_transacciones_stock

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
            util.mensajes("Error al listar Transacciones de Stock: " + ex.Message, "func_transacciones_stock", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal accion As String, ByVal activo As Boolean, relacion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO transacciones_stock(nombre, accion, activo, relacion)
                                            VALUES (@nombre, @accion, @activo, @relacion)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@accion", accion)
            comand.Parameters.AddWithValue("@relacion", relacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Transaccion de Stock: " + ex.Message, "func_transacciones_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(nombre As String, ByVal accion As String, ByVal activo As Boolean, ByVal relacion As String, ByVal id_transaccion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE transacciones_stock SET nombre=@nombre, accion=@accion, relacion=@relacion,
                                            activo=@activo, fecha_mod=now() WHERE id_transaccion=@id_transaccion", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@accion", accion)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@relacion", relacion)
            comand.Parameters.AddWithValue("@id_transaccion", id_transaccion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Transaccion de Stock: " + ex.Message, "func_transacciones_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_transaccion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM transacciones_stock WHERE id_transaccion=@id_transaccion", cnn)

            comand.Parameters.AddWithValue("@id_transaccion", id_transaccion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Transaccion de Stock: " + ex.Message, "func_transacciones_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function existe_transaccion_de_pedido() As Boolean
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT 1 FROM transacciones_stock WHERE transaccion_de_pedido=true", cnn)
            da.Fill(dt)

            Return dt.Rows.Count > 0
        Catch ex As Exception
            util.mensajes("Error al listar Transacciones de Stock: " + ex.Message, "func_transacciones_stock", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class

