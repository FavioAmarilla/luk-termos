Imports Npgsql

Public Class func_timbrados

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
            util.mensajes("Error al listar Clientes: " + ex.Message, "func_timbrados", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(numero As String, fecha_desde As Date, fecha_hasta As Date, nro_inicial As Integer, nro_final As Integer,
                             longitud_nro_comprob As Integer, id_empresa As Integer, id_sucursal As Integer, activo As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO timbrados(numero, fecha_desde, fecha_hasta, nro_inicial, nro_final, 
                                            longitud_nro_comprob, id_empresa, id_sucursal, activo)
                                            VALUES (@numero, @fecha_desde, @fecha_hasta, @nro_inicial, @nro_final, 
                                            @longitud_nro_comprob, @id_empresa, @id_sucursal, @activo)", cnn)

            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@fecha_desde", fecha_desde)
            comand.Parameters.AddWithValue("@fecha_hasta", fecha_hasta)
            comand.Parameters.AddWithValue("@nro_inicial", nro_inicial)
            comand.Parameters.AddWithValue("@nro_final", nro_final)
            comand.Parameters.AddWithValue("@longitud_nro_comprob", longitud_nro_comprob)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@activo", activo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Timbrado: " + ex.Message, "func_timbrados", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(numero As String, fecha_desde As Date, fecha_hasta As Date, nro_inicial As Integer, nro_final As Integer,
                               longitud_nro_comprob As Integer, id_empresa As Integer, id_sucursal As Integer, activo As Boolean,
                               id_timbrado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE timbrados SET numero=@numero, fecha_desde=@fecha_desde, fecha_hasta=@fecha_hasta, 
                                            nro_inicial=@nro_inicial, nro_final=@nro_final, longitud_nro_comprob=@longitud_nro_comprob, 
                                            id_empresa=@id_empresa, id_sucursal=@id_sucursal, activo=@activo, fecha_mod=now()
                                            WHERE id_timbrado=@id_timbrado", cnn)

            comand.Parameters.AddWithValue("@numero", numero)
            comand.Parameters.AddWithValue("@fecha_desde", fecha_desde)
            comand.Parameters.AddWithValue("@fecha_hasta", fecha_hasta)
            comand.Parameters.AddWithValue("@nro_inicial", nro_inicial)
            comand.Parameters.AddWithValue("@nro_final", nro_final)
            comand.Parameters.AddWithValue("@longitud_nro_comprob", longitud_nro_comprob)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)
            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@activo", activo)
            comand.Parameters.AddWithValue("@id_timbrado", id_timbrado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Timbrado: " + ex.Message, "func_timbrados", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function desactivar_anteriores() As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE timbrados SET activo=true", cnn)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al desactivar Timbrados: " + ex.Message, "func_timbrados", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
