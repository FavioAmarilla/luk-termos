Imports Npgsql

Public Class func_liquidacion_mano_obra

    Inherits conexion
    Private util As New utilidades

    Public Function id_liquidacion_mano_obra() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('liquidaciones_id_liquidacion_seq')", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function consultar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_liquidacion_mano_obra(ByVal id_liquidacion As Integer, ByVal total_pagado As Integer, ByVal id_usuario As Integer,
                                                   ByVal cantidad_articulos As Double, ByVal id_empleado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO liquidaciones_mano_obra(id_liquidacion, fecha, total_pagado, id_usuario, 
                                            cantidad_articulos, id_empleado)
                                            VALUES (@id_liquidacion, now(), @total_pagado, @id_usuario,  
                                            @cantidad_articulos, @id_empleado)", cnn)

            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@cantidad_articulos", cantidad_articulos)
            comand.Parameters.AddWithValue("@id_empleado", id_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Liquidacion de Mano de Obra: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_totales_liquidacion(ByVal total_pagado As Integer, ByVal id_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE liquidaciones_mano_obra SET total_pagado=@total_pagado, fecha_mod=now()
                                            WHERE id_liquidacion=@id_liquidacion", cnn)

            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Totales de Liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_liquidacion(ByVal total_pagado As Integer, id_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE liquidaciones_mano_obra SET total_pagado=@total_pagado, fecha_mod=now() 
                                             WHERE id_liquidacion=@id_liquidacion", cnn)

            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Actualizar Liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_items_liquidacion_mano_obra(ByVal id_liquidacion As Integer, ByVal id_empleado As Integer, ByVal cantidad_producida As Double,
                                                         ByVal id_pedido As Integer, ByVal total_pago As Integer, ByVal total_unitario As Integer,
                                                         ByVal pagado As Boolean, id_asignacion As Integer, pago_extra As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO items_liquidacion_mano_obra(id_liquidacion, id_empleado, cantidad_producida, 
                                            id_pedido, total_pago, total_unitario, pagado, id_asignacion, pago_extra)
                                            VALUES (@id_liquidacion, @id_empleado, @cantidad_producida, 
                                            @id_pedido, @total_pago, @total_unitario, @pagado, @id_asignacion, @pago_extra)", cnn)

            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@id_empleado", id_empleado)
            comand.Parameters.AddWithValue("@cantidad_producida", cantidad_producida)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@total_pago", total_pago)
            comand.Parameters.AddWithValue("@total_unitario", total_unitario)
            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@pago_extra", pago_extra)
            comand.Parameters.AddWithValue("@id_asignacion", id_asignacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Items de Liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_items_liquidacion(ByVal pagado As Boolean, id_asignacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE items_liquidacion_mano_obra SET pagado=@pagado, fecha_mod=now() WHERE id_asignacion=@id_asignacion", cnn)

            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@id_asignacion", id_asignacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Actualizar Items de Liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_estado_asignacion_pedido_empleado(pagado As Boolean, id_asignacion_pedido_empleado As Integer, id_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE asignacion_pedido_empleado SET pagado=@pagado, fecha_mod=now(), id_liquidacion=@id_liquidacion
                                            WHERE id_asignacion_pedido_empleado=@id_asignacion_pedido_empleado", cnn)

            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@id_asignacion_pedido_empleado", id_asignacion_pedido_empleado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Actualizar Estado de Asignacion Pedido-Empleado: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
