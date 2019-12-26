Imports Npgsql

Public Class func_control_caja

    Inherits conexion
    Dim util As New utilidades()

    Public Function id_control() As Integer
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT last_value + increment_by FROM control_cajas_id_control_caja_seq", cnn)
            da.Fill(dt)

            Return CInt(dt.Rows(0).Item(0))
        Catch ex As Exception
            util.mensajes("Error al obtener Id Control: " + ex.Message, "func_control_caja", "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function trans_inicial() As String
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT nro_comprobante FROM ventas WHERE id_venta = (SELECT MAX(id_venta) FROM ventas)", cnn)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return CStr(CInt(dt.Rows(0).Item(0)) + 1)
            Else
                Return "1"
            End If
        Catch ex As Exception
            util.mensajes("Error al obtener Trans. Inicial: " + ex.Message, "func_control_caja", "ERR")
            Return "0"
        Finally
            desconectar()
        End Try
    End Function

    Public Function trans_final(id_control As String) As String
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter("SELECT nro_comprobante FROM ventas WHERE id_control_caja =" + id_control + " ORDER BY id_venta DESC", cnn)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return CStr(CInt(dt.Rows(0).Item(0)))
            Else
                Return "1"
            End If
        Catch ex As Exception
            util.mensajes("Error al obtener Trans. Final: " + ex.Message, "func_control_caja", "ERR")
            Return "0"
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
            util.mensajes("Error al realizar consulta: " + ex.Message, "func_control_caja", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function apertura_caja(id_usuario As Integer, trans_inicial As String, comentario As String, monto_inicial As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO control_caja(id_usuario, fecha_cre, trans_inicial, comentario, monto_inicial)
                                             VALUES (@id_usuario, now(), @trans_inicial, @comentario, @monto_inicial)", cnn)

            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@trans_inicial", trans_inicial)
            comand.Parameters.AddWithValue("@comentario", comentario)
            comand.Parameters.AddWithValue("@monto_inicial", monto_inicial)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Control Caja: " + ex.Message, "func_control_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function cierre_caja(total_monto As Integer, gravada5 As Integer, gravada10 As Integer, gravadas As Integer,
                               impuesto5 As Integer, impuesto10 As Integer, impuestos As Integer, trans_final As String,
                               exentas As Integer, cantidad_comprob As Integer, total_anulados As Integer,
                               id_control_caja As Integer, extracciones_efec As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE control_caja SET total_monto=@total_monto, gravada5=@gravada5, gravada10=@gravada10, 
                                            gravadas=@gravadas, impuesto5=@impuesto5, impuesto10=@impuesto10, impuestos=@impuestos, 
                                            fecha_cierre=now(), fecha_mod=now(), trans_final=@trans_final, exentas=@exentas,
                                            cantidad_comprob=@cantidad_comprob, total_anulados=@total_anulados, 
                                            extracciones_efec=@extracciones_efec WHERE id_control_caja=@id_control_caja", cnn)

            comand.Parameters.AddWithValue("@total_monto", total_monto)
            comand.Parameters.AddWithValue("@gravada5", gravada5)
            comand.Parameters.AddWithValue("@gravada10", gravada10)
            comand.Parameters.AddWithValue("@gravadas", gravadas)
            comand.Parameters.AddWithValue("@impuesto5", impuesto5)
            comand.Parameters.AddWithValue("@impuesto10", impuesto10)
            comand.Parameters.AddWithValue("@impuestos", impuestos)
            comand.Parameters.AddWithValue("@trans_final", trans_final)
            comand.Parameters.AddWithValue("@exentas", exentas)
            comand.Parameters.AddWithValue("@cantidad_comprob", cantidad_comprob)
            comand.Parameters.AddWithValue("@total_anulados", total_anulados)
            comand.Parameters.AddWithValue("@extracciones_efec", extracciones_efec)
            comand.Parameters.AddWithValue("@id_control_caja", id_control_caja)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Cerrar Caja: " + ex.Message, "func_control_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function declaracion_efectivo(id_control_caja As Integer, id_usuario As Integer, id_denominacion As Integer,
                                            valor As Integer, cantidad As Integer, total As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO public.declaracion_efectivo(id_control_caja, id_usuario, id_denominacion, 
                                            valor, cantidad, total)
                                            VALUES (@id_control_caja, @id_usuario, @id_denominacion, 
                                            @valor, @cantidad, @total)", cnn)

            comand.Parameters.AddWithValue("@id_control_caja", id_control_caja)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@id_denominacion", id_denominacion)
            comand.Parameters.AddWithValue("@valor", valor)
            comand.Parameters.AddWithValue("@cantidad", cantidad)
            comand.Parameters.AddWithValue("@total", total)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Cerrar Caja: " + ex.Message, "func_control_caja", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
