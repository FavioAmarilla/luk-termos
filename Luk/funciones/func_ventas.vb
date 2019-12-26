Imports Npgsql

Public Class func_ventas

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_venta() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('ventas_id_venta_seq')", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Venta: " + ex.Message, "func_ventas", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function id_item_venta() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT last_value as id_articulo FROM items_venta_id_item_venta_seq", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_articulos", "ERR")
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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_ventas", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_venta(id_venta As Integer, numero As String, id_cliente As Integer, id_usuario As Integer, id_empresa As Integer,
                                   id_sucursal As Integer, id_control_caja As Integer, id_pedido As Integer, factura As Boolean,
                                   id_condicion_venta As Integer, id_timbrado As Integer, nro_comprobante As Integer,
                                   id_vendedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO ventas(id_venta, numero, id_cliente, id_usuario, id_empresa, id_sucursal, id_control_caja, 
                                            id_pedido, factura, id_condicion_venta, id_timbrado, nro_comprobante, id_vendedor)
                                            VALUES (@id_venta, @numero, @id_cliente, @id_usuario, @id_empresa, @id_sucursal, @id_control_caja, @id_pedido, 
                                            @factura, @id_condicion_venta, @id_timbrado, @nro_comprobante, @id_vendedor)", cnn)

            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@id_cliente", id_cliente)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@id_control_caja", id_control_caja)
            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@factura", factura)
            comand.Parameters.AddWithValue("@id_condicion_venta", id_condicion_venta)
            comand.Parameters.AddWithValue("@id_timbrado", id_timbrado)
            comand.Parameters.AddWithValue("@nro_comprobante", nro_comprobante)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_totales_venta(total_venta As Integer, gravado5 As Integer, gravado10 As Integer, gravados As Integer,
                                            impuesto5 As Integer, impuesto10 As Integer, impuestos As Integer,
                                            exentas As Integer, costo_total As Integer, id_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET total_venta=@total_venta, gravado5=@gravado5, gravado10=@gravado10, 
                                            gravados=@gravados, impuesto5=@impuesto5, impuesto10=@impuesto10, impuestos=@impuestos, 
                                            exentas=@exentas, costo_total=@costo_total, fecha_mod=now() WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@total_venta", total_venta)
            comand.Parameters.AddWithValue("@gravado5", gravado5)
            comand.Parameters.AddWithValue("@gravado10", gravado10)
            comand.Parameters.AddWithValue("@gravados", gravados)
            comand.Parameters.AddWithValue("@impuesto5", impuesto5)
            comand.Parameters.AddWithValue("@impuesto10", impuesto10)
            comand.Parameters.AddWithValue("@impuestos", impuestos)
            comand.Parameters.AddWithValue("@exentas", exentas)
            comand.Parameters.AddWithValue("@costo_total", costo_total)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar totales de Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function anular_venta(id_usr_anulacion As Integer, id_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET anulado=true, id_usr_anulacion=@id_usr_anulacion, 
                                            fecha_anulacion=now(), fecha_mod=now()
                                            WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@id_usr_anulacion", id_usr_anulacion)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al anular Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function pedido_facturado(id_pedido As Integer, valor As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE pedidos SET facturado=@facturado, entregado=@entregado, fecha_mod=now()
                                            WHERE id_pedido=@id_pedido", cnn)

            comand.Parameters.AddWithValue("@id_pedido", id_pedido)
            comand.Parameters.AddWithValue("@facturado", valor)
            comand.Parameters.AddWithValue("@entregado", valor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al anular Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_item_venta(id_venta As Integer, id_articulo As Integer, cantidad As Integer, costo_unitario As Integer,
                                        precio_venta As Integer, total_item As Integer, id_proveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO items_venta(id_venta, id_articulo, cantidad, costo_unitario, 
                                            precio_venta, total_item, id_proveedor)
                                            VALUES (@id_venta, @id_articulo, @cantidad, @costo_unitario, 
                                            @precio_venta, @total_item, @id_proveedor)", cnn)

            comand.Parameters.AddWithValue("@id_venta", id_venta)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@precio_venta", precio_venta)
            comand.Parameters.AddWithValue("@total_item", total_item)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Item de Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_item_venta(id_item_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM items_venta WHERE id_item_venta=@id_item_venta", cnn)

            comand.Parameters.AddWithValue("@id_item_venta", id_item_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Item de Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar_asignacion_comprob(ultimo_nro_usado As Integer, id_timbrado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO asignacion_comprobante(ultimo_nro_usado, id_timbrado) 
                                            VALUES(@ultimo_nro_usado, @id_timbrado)", cnn)

            comand.Parameters.AddWithValue("@ultimo_nro_usado", ultimo_nro_usado)
            comand.Parameters.AddWithValue("@id_timbrado", id_timbrado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Asignacion Comprobante: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_asignacion_comprob(ultimo_nro_usado As Integer, id_timbrado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE asignacion_comprobante SET ultimo_nro_usado=@ultimo_nro_usado,
                                            fecha_mod=now() WHERE id_timbrado=@id_timbrado", cnn)

            comand.Parameters.AddWithValue("@ultimo_nro_usado", ultimo_nro_usado)
            comand.Parameters.AddWithValue("@id_timbrado", id_timbrado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Asignacion Comprobante: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function comision_venta(comision_vendedor As Integer, id_vendedor As Integer, id_venta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET comision_vendedor=@comision_vendedor, id_vendedor=@id_vendedor WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@comision_vendedor", comision_vendedor)
            comand.Parameters.AddWithValue("@id_vendedor", id_vendedor)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar comision: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar_monto_pagado(id_venta As Integer, total_pagado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE ventas SET total_pagado=@total_pagado, fecha_mod=now() WHERE id_venta=@id_venta", cnn)

            comand.Parameters.AddWithValue("@total_pagado", total_pagado)
            comand.Parameters.AddWithValue("@id_venta", id_venta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar totales de Venta: " + ex.Message, "func_ventas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
