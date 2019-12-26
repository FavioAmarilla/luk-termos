Imports Npgsql

Public Class func_notas_credito

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_nota_credito() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT NEXTVAL('notas_credito_id_nota_credito_seq')", cnn)
            da.Fill(dt)

            If dt.Rows.Count() <> 0 Then
                Return CInt(dt.Rows(0).Item(0))
            Else
                util.mensajes("No existe secuencia para nota de credito", "func_movimientos_stock", "ERR")
                Return 0
            End If
        Catch ex As Exception
            util.mensajes("Error al listar Articulos: " + ex.Message, "func_movimientos_stock", "ERR")
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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_notas_credito", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function


    Public Function insertar(id_nota_credito As Integer, monto_total As Integer, id_comprobante As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO notas_credito(id_nota_credito, fecha, monto_total, id_comprobante, fecha_cre, usr_cre)
                                            VALUES (@id_nota_credito, @fecha, @monto_total, @id_comprobante, @fecha_cre, @usr_cre)", cnn)

            comand.Parameters.AddWithValue("@id_nota_credito", id_nota_credito)
            comand.Parameters.AddWithValue("@fecha", CDate(util.fecha()))
            comand.Parameters.AddWithValue("@monto_total", monto_total)
            comand.Parameters.AddWithValue("@id_comprobante", id_comprobante)
            comand.Parameters.AddWithValue("@fecha_cre", CDate(util.fecha()))
            comand.Parameters.AddWithValue("@usr_cre", frm_main.LOGIN_USER)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar: " + ex.Message, "func_notas_credito", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(id_nota_credito As Integer, monto_total As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("update notas_credito set fecha=@fecha, monto_total=@monto_total, fecha_mod=@fecha_mod, usr_cre=@usr_mod
                                            where id_nota_credito=@id_nota_credito", cnn)

            comand.Parameters.AddWithValue("@fecha", CDate(util.fecha()))
            comand.Parameters.AddWithValue("@monto_total", monto_total)
            comand.Parameters.AddWithValue("@fecha_mod", CDate(util.fecha()))
            comand.Parameters.AddWithValue("@usr_mod", frm_main.LOGIN_USER)
            comand.Parameters.AddWithValue("@id_nota_credito", id_nota_credito)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            util.mensajes("Error al registrar: " + ex.Message, "func_notas_credito", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function insertar_items(id_nota_credito As Integer, id_articulo As Integer, cantidad As Double, precio_unitario As Integer, total As Integer, id_proveedor As Integer, costo_unitario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO notas_credito_items(id_nota_credito, id_articulo, cantidad, precio_unitario, total, id_proveedor, costo_unitario)
                                             VALUES (@id_nota_credito, @id_articulo, @cantidad, @precio_unitario, @total, @id_proveedor, @costo_unitario)", cnn)

            comand.Parameters.AddWithValue("@id_nota_credito", id_nota_credito)
            comand.Parameters.AddWithValue("@id_articulo", id_articulo)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@total", total)
            comand.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar item: " + ex.Message, "func_notas_credito", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_items(id_nota_credito_item As Integer, cantidad As Double, precio_unitario As Integer, total As Integer, costo_unitario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("update notas_credito_items set cantidad=@cantidad, precio_unitario=@precio_unitario, total=@total, costo_unitario=@costo_unitario
                                             where id_nota_credito_item=@id_nota_credito_item", cnn)

            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@precio_unitario", precio_unitario)
            comand.Parameters.AddWithValue("@total", total)
            comand.Parameters.AddWithValue("@costo_unitario", costo_unitario)
            comand.Parameters.AddWithValue("@id_nota_credito_item", id_nota_credito_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar item: " + ex.Message, "func_notas_credito", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_items(id_nota_credito_item As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("delete from notas_credito_items where id_nota_credito_item=@id_nota_credito_item", cnn)

            comand.Parameters.AddWithValue("@id_nota_credito_item", id_nota_credito_item)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar item: " + ex.Message, "func_notas_credito", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
