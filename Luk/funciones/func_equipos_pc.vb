Imports Npgsql

Public Class func_equipos_pc

    Inherits conexion
    Dim util As New utilidades()

    Public Function listar(ByVal sql As String) As DataTable
        Try
            conectar()
            Dim dt = New DataTable()
            Dim ds As New DataSet
            Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(sql, cnn)
            da.Fill(dt)

            Return dt
        Catch ex As Exception
            util.mensajes("Error al Realizar Consulta: " + ex.Message, "func_equipos_pc", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(nombre As String, sistema_operativo As String, arquitectura As String, disco_duro As String,
                             placa_madre As String, habilitado As Boolean) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO equipos_pc(nombre, sistema_operativo, arquitectura, disco_duro, 
                                            placa_madre, habilitado)
                                            VALUES (@nombre, @sistema_operativo, @arquitectura, @disco_duro, 
                                            @placa_madre, @habilitado)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@sistema_operativo", sistema_operativo)
            comand.Parameters.AddWithValue("@arquitectura", arquitectura)
            comand.Parameters.AddWithValue("@disco_duro", disco_duro)
            comand.Parameters.AddWithValue("@placa_madre", placa_madre)
            comand.Parameters.AddWithValue("@habilitado", habilitado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Registrar Equipo: " + ex.Message, "func_equipos_pc", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
