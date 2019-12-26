Imports Npgsql

Public Class func_asignacion_pedido_empleado

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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_asignacion_pedido_empleado", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal id_pedido As Integer, ByVal id_empleado As Integer, ByVal cantidad_asignada As Double,
                             ByVal pagado As Boolean, ByVal mano_obra As Integer, ByVal pago_extra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO asignacion_pedido_empleado(id_pedido, id_empleado, cantidad_asignada, 
                                            pagado, mano_obra, pago_extra)
                                            VALUES (@id_pedido, @id_empleado, @cantidad_asignada, 
                                            @pagado, @mano_obra, @pago_extra)", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@id_empleado", id_empleado)
            comand.Parameters.AddWithValue("@cantidad_asignada", cantidad_asignada)
            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@mano_obra", mano_obra)
            comand.Parameters.AddWithValue("@pago_extra", pago_extra)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Asignacion Pedido-Empleado: " + ex.Message, "func_asignacion_pedido_empleado", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ByVal cantidad_asignada As Double, ByVal pagado As Boolean, ByVal mano_obra As Integer,
                               ByVal pago_extra As Integer, ByVal id_asignacion_pedido_empleado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE asignacion_pedido_empleado SET cantidad_asignada=@cantidad_asignada, fecha_mod=now(), 
                                             pagado=@pagado, mano_obra=@mano_obra, pago_extra=@pago_extra
                                             WHERE id_asignacion_pedido_empleado=@id_asignacion_pedido_empleado", cnn)

            comand.Parameters.AddWithValue("@cantidad_asignada", cantidad_asignada)
            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@mano_obra", mano_obra)
            comand.Parameters.AddWithValue("@pago_extra", pago_extra)
            comand.Parameters.AddWithValue("@id_asignacion_pedido_empleado", id_asignacion_pedido_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Asignacion Pedido-Empleado: " + ex.Message, "func_asignacion_pedido_empleado", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_asignacion_pedido_empleado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM asignacion_pedido_empleado WHERE id_asignacion_pedido_empleado=@id_asignacion_pedido_empleado", cnn)

            comand.Parameters.AddWithValue("@id_asignacion_pedido_empleado", id_asignacion_pedido_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Asignacion Pedido-Empleado: " + ex.Message, "func_asignacion_pedido_empleado", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminarAsignacionPorPedido(ByVal id_pedido As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM asignacion_pedido_empleado WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Asignacion Pedido-Empleado: " + ex.Message, "func_asignacion_pedido_empleado", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
