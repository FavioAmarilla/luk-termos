Imports Npgsql

Public Class func_extraccion_efectivo
    Inherits conexion
    Dim util As New utilidades()

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al realizar Consulta: " + ex.Message, "func_extraccion_efectivo", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(id_sucursal As Integer, id_control_caja As Integer, id_usuario As Integer,
                             nro_doc_beneficiario As String, nombre_beneficiario As String,
                             total_monto As Integer, observacion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO extraccion_efectivo(id_sucursal, id_control_caja, id_usuario, 
                                            nro_doc_beneficiario, nombre_beneficiario, fecha, total_monto, observacion) 
                                            VALUES(@id_sucursal, @id_control_caja, @id_usuario, @nro_doc_beneficiario, 
                                            @nombre_beneficiario, now(), @total_monto, @observacion)", cnn)

            comand.Parameters.AddWithValue("@id_sucursal", id_sucursal)
            comand.Parameters.AddWithValue("@id_control_caja", id_control_caja)
            comand.Parameters.AddWithValue("@id_usuario", id_usuario)
            comand.Parameters.AddWithValue("@nro_doc_beneficiario", nro_doc_beneficiario)
            comand.Parameters.AddWithValue("@nombre_beneficiario", nombre_beneficiario)
            comand.Parameters.AddWithValue("@total_monto", total_monto)
            comand.Parameters.AddWithValue("@observacion", observacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Extraccion: " + ex.Message, "func_extraccion_efectivo", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
