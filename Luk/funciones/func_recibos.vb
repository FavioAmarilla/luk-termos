Imports Npgsql

Public Class func_recibos

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
            util.mensajes("Error al listar Empresas: " + ex.Message, "func_recibos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(fecha As Date, id_cliente As Integer, observacion As String, monto As Integer, numero As String, id_control As Integer, id_forma_pago As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO recibos (id_cliente, estado, fecha, observacion, fecha_cre, monto, numero, id_control, id_forma_pago)
                                            VALUES (@id_cliente, @estado, @fecha, @observacion, now(), @monto, @numero, @id_control, @id_forma_pago)", cnn)

            comand.Parameters.AddWithValue("@id_cliente", id_cliente)
            comand.Parameters.AddWithValue("@estado", False)
            comand.Parameters.AddWithValue("@fecha", fecha)
            comand.Parameters.AddWithValue("@observacion", observacion)
            comand.Parameters.AddWithValue("@monto", monto)
            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@id_control", id_control)
            comand.Parameters.AddWithValue("@id_forma_pago", id_forma_pago)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar recibo: " + ex.Message, "func_recibos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function get_nro_recibo() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("select ult_usado from asignacion_recibos", cnn)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                insertar_asignacion()
                Return 0
            End If

            Return 0
        Catch ex As Exception
            util.mensajes("Error al obtener numero de recibo: " + ex.Message, "func_recibos", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_asignacion() As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO asignacion_recibos (ult_usado) VALUES (0)", cnn)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar asignacion recibo: " + ex.Message, "func_recibos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_asignacion() As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE asignacion_recibos SET ult_usado = ult_usado + 1", cnn)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar asignacion recibo: " + ex.Message, "func_recibos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar_recibo(id_recibo As Integer, estado As Boolean, id_pedido As Integer, id_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE recibos SET estado=@estado, id_pedido=@id_pedido, id_venta=@id_venta where id_recibo=@id_recibo", cnn)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@id_recibo", id_recibo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar estado: " + ex.Message, "func_recibos", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
