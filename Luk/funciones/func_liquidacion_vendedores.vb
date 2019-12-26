Imports Npgsql

Public Class func_liquidacion_vendedores

    Inherits conexion
    Private util As New utilidades

    Public Function id_liquidacion_mano_obra() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('liquidaciones_vendedores_id_liquidacion_seq')", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Liquidacion: " + ex.Message, "func_liquidacion_vendedores", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function cantidad_articulo(ByVal id As String) As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT COALESCE(SUM(cantidad_asignada),0) FROM asignacion_pedido_empleado WHERE id_empleado=" + id + "", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Cantidad de Pedido: " + ex.Message, "func_liquidacion_vendedores", "ERR")
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
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_liquidacion_vendedores", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_liquidacion(id_liquidacion As Integer, total_pagado As Integer, id_usuario As Integer,
                                         id_vendedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO liquidaciones_vendedores(id_liquidacion, fecha_cre, fecha, total_pagado, 
                                            id_usuario, id_vendedor)
                                            VALUES (@id_liquidacion, now(), now(), @total_pagado, @id_usuario, @id_vendedor)", cnn)

            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar liquidacion de vendedor: " + ex.Message, "func_liquidacion_vendedores", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_liquidacion(ByVal total_pagado As Integer, id_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE liquidaciones_vendedores SET total_pagado=@total_pagado, fecha_mod=now()
                                             WHERE id_liquidacion=@id_liquidacion", cnn)

            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar liquidacion: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_items_liquidacion(id_liquidacion As Integer, id_vendedor As Integer, id_venta As Integer, total_pago As Integer, pagado As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO items_liquidacion_vendedores(id_liquidacion, id_vendedor, id_venta, total_pago, fecha_cre, pagado)
                                             VALUES (@id_liquidacion, @id_vendedor, @id_venta, @total_pago,now(), @pagado)", cnn)

            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)
            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@total_pago", total_pago)
            comand.Parameters.AddWithValue("@pagado", pagado)

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

    Public Function actualizar_items_liquidacion(ByVal pagado As Boolean, id_item_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE items_liquidacion_vendedores SET pagado=@pagado, fecha_mod=now() WHERE id_item_liquidacion=@id_item_liquidacion", cnn)

            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@id_item_liquidacion", id_item_liquidacion)

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

    Public Function actualizar_estado_venta(pagado As Boolean, id_venta As Integer, id_liquidacion As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET pagado=@pagado, fecha_mod=now(), id_liquidacion=@id_liquidacion
                                            WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@pagado", pagado)
            comand.Parameters.AddWithValue("@id_liquidacion", id_liquidacion)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar estado de item de venta: " + ex.Message, "func_liquidacion_mano_obra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
