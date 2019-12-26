Imports Npgsql

Class func_cobros_caja

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_cobro() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT last_value + increment_by FROM cobros_caja_id_cobro_seq", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Cobro: " + ex.Message, "func_cobros_caja", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_cobros_caja", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_cobro(monto_total As Integer, id_venta As Integer, id_empresa As Integer, id_sucursal As Integer,
                                   id_usuario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO cobros_caja(monto_total, id_venta, id_empresa, id_sucursal, id_usuario)
                                            VALUES (@monto_total, @id_venta, @id_empresa, @id_sucursal, @id_usuario)", cnn)

            comand.Parameters.AddWithValue("@monto_total", monto_total)
            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Cobro: " + ex.Message, "func_cobros_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_totales_cobro(importe_efectivo As Integer, importe_documento As Integer, total_vuelto As Integer, total_descuento As Integer, porc_descuento As Double, id_cobro As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE cobros_caja SET importe_efectivo=@importe_efectivo, importe_documento=@importe_documento, 
                                            total_vuelto=@total_vuelto, total_descuento=@total_descuento, porc_descuento=@porc_descuento 
                                            WHERE id_cobro=@id_cobro", cnn)

            comand.Parameters.AddWithValue("@importe_efectivo", importe_efectivo)
            comand.Parameters.AddWithValue("@importe_documento", importe_documento)
            comand.Parameters.AddWithValue("@total_vuelto", total_vuelto)
            comand.Parameters.AddWithValue("@total_descuento", total_descuento)
            comand.Parameters.AddWithValue("@porc_descuento", porc_descuento)
            comand.Parameters.AddWithValue("@id_cobro", id_cobro)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar totales de Cobro: " + ex.Message, "func_cobros_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_descuento_ventas(total_descuento As Integer, porc_descuento As Integer, id_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET total_descuento=@total_descuento, porc_descuento=@porc_descuento
                                            WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@total_descuento", total_descuento)
            comand.Parameters.AddWithValue("@porc_descuento", porc_descuento)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar totales de Venta: " + ex.Message, "func_cobros_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_item_cobro(id_cobro As Integer, id_forma_pago As Integer, importe_recibido As Integer, importe_vuelto As Integer,
                                        procesadora As String, tipo_tarjeta As String, nro_item As Integer, id_control_caja As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO items_cobro(id_cobro, id_forma_pago, importe_recibido, importe_vuelto, procesadora, tipo_tarjeta, nro_item, id_control_caja)
                                            VALUES (@id_cobro, @id_forma_pago, @importe_recibido, @importe_vuelto, @procesadora, @tipo_tarjeta, @nro_item, @id_control_caja)", cnn)

            comand.Parameters.AddWithValue("@id_cobro", id_cobro)
            comand.Parameters.AddWithValue("@id_forma_pago", id_forma_pago)
            comand.Parameters.AddWithValue("@importe_recibido", importe_recibido)
            comand.Parameters.AddWithValue("@importe_vuelto", importe_vuelto)
            comand.Parameters.AddWithValue("@procesadora", procesadora)
            comand.Parameters.AddWithValue("@tipo_tarjeta", tipo_tarjeta)
            comand.Parameters.AddWithValue("@nro_item", nro_item)
            comand.Parameters.AddWithValue("@id_control_caja", id_control_caja)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Item de Cobro: " + ex.Message, "func_cobros_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_item_cobro(id_cobro As Integer, nro_item As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM items_cobro WHERE id_cobro=@id_cobro AND nro_item=@nro_item", cnn)

            comand.Parameters.AddWithValue("@id_cobro", id_cobro)
            comand.Parameters.AddWithValue("@nro_item", nro_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Item de Cobro: " + ex.Message, "func_cobros_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
