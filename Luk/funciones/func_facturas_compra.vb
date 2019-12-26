Imports Npgsql

Public Class func_facturas_compra
    Inherits conexion
    Dim util As New utilidades()

    Public Function id_factura() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('facturas_id_factura_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al consultar secuencia para Factura: " + ex.Message, "func_facturas_compra", "ERR")
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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_fucturas_compra", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_factura As Integer, numero_factura As String, monto_gravado As Integer, monto_total As Integer, monto_exento As Integer,
                             id_compra As Integer, id_usuario As Integer, id_sucursal As Integer, nro_compra As String,
                             gravadas10 As Integer, gravadas5 As Integer, iva10 As Integer, iva5 As Integer, total_iva As Integer,
                             id_tipo_comprobante As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO facturas_compra(id_factura, numero_factura, monto_gravado, monto_total, monto_exento, 
                                            id_compra, id_usuario, id_sucursal, nro_compra, 
                                            gravadas10, gravadas5, iva10, iva5, total_iva, id_tipo_comprobante)
                                            VALUES (@id_factura, @numero_factura, @monto_gravado, @monto_total, @monto_exento, 
                                            @id_compra, @id_usuario, @id_sucursal, @nro_compra, @gravadas10, 
                                            @gravadas5, @iva10, @iva5, @total_iva, @id_tipo_comprobante)", cnn)

            comand.Parameters.AddWithValue("@id_factura", id_factura)
            comand.Parameters.AddWithValue("@numero_factura", numero_factura)
            comand.Parameters.AddWithValue("@monto_gravado", monto_gravado)
            comand.Parameters.AddWithValue("@monto_total", monto_total)
            comand.Parameters.AddWithValue("@monto_exento", monto_exento)
            comand.Parameters.AddWithValue("@id_compra", id_compra)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@nro_compra", nro_compra)
            comand.Parameters.AddWithValue("@gravadas10", gravadas10)
            comand.Parameters.AddWithValue("@gravadas5", gravadas5)
            comand.Parameters.AddWithValue("@iva10", iva10)
            comand.Parameters.AddWithValue("@iva5", iva5)
            comand.Parameters.AddWithValue("@total_iva", total_iva)
            comand.Parameters.AddWithValue("@id_tipo_comprobante", id_tipo_comprobante)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            util.mensajes("Error al registrar Factura: " + ex.Message, "func_fucturas_compra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(numero_factura As String, monto_gravado As Integer, monto_total As Integer,
                               monto_exento As Integer, gravadas10 As Integer,
                               gravadas5 As Integer, iva10 As Integer, iva5 As Integer, id_factura As Integer,
                               total_iva As Integer, id_tipo_comprobante As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE facturas_compra SET numero_factura=@numero_factura, monto_gravado=@monto_gravado, 
                                            monto_total=@monto_total, monto_exento=@monto_exento, gravadas10=@gravadas10, gravadas5=@gravadas5, 
                                            iva10=@iva10, iva5=@iva5, total_iva=@total_iva, id_tipo_comprobante=@id_tipo_comprobante
                                            WHERE id_factura=@id_factura", cnn)

            comand.Parameters.AddWithValue("@numero_factura", numero_factura)
            comand.Parameters.AddWithValue("@monto_gravado", monto_gravado)
            comand.Parameters.AddWithValue("@monto_total", monto_total)
            comand.Parameters.AddWithValue("@monto_exento", monto_exento)
            comand.Parameters.AddWithValue("@gravadas10", gravadas10)
            comand.Parameters.AddWithValue("@gravadas5", gravadas5)
            comand.Parameters.AddWithValue("@iva10", iva10)
            comand.Parameters.AddWithValue("@iva5", iva5)
            comand.Parameters.AddWithValue("@total_iva", total_iva)
            comand.Parameters.AddWithValue("@id_tipo_comprobante", id_tipo_comprobante)
            comand.Parameters.AddWithValue("@id_factura", id_factura)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Factura: " + ex.Message, "func_fucturas_compra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_compra(id_compra As Integer, id_factura As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE compras SET id_factura=@id_factura, factura=true WHERE id_compra=@id_compra", cnn)

            comand.Parameters.AddWithValue("@id_compra", id_compra)
            comand.Parameters.AddWithValue("@id_factura", id_factura)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Factura: " + ex.Message, "func_fucturas_compra", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
