Imports Npgsql

Public Class func_clientes

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
            util.mensajes("Error al listar Clientes: " + ex.Message, "func_clientes", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombres As String, ByVal apellidos As String, ByVal nro_documento As String, ByVal telefono As String,
                             ByVal ciudad As String, ByVal direccion As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO clientes(nombres, apellidos, numero_documento, telefono, ciudad, direccion)
                                            VALUES (@nombres, @apellidos, @numero_documento, @telefono, @ciudad, @direccion)", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@numero_documento", nro_documento)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Cliente: " + ex.Message, "func_clientes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizar(ByVal nombres As String, ByVal apellidos As String, ByVal nro_documento As String, ByVal telefono As String,
                             ByVal ciudad As String, ByVal direccion As String, ByVal id_cliente As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE clientes SET nombres=@nombres, apellidos=@apellidos, numero_documento=@numero_documento, 
                                             telefono=@telefono, ciudad=@ciudad, direccion=@direccion, fecha_mod=now() WHERE id_cliente=@id_cliente", cnn)

            comand.Parameters.AddWithValue("@nombres", nombres)
            comand.Parameters.AddWithValue("@apellidos", apellidos)
            comand.Parameters.AddWithValue("@numero_documento", nro_documento)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@id_cliente", id_cliente)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Cliente: " + ex.Message, "func_clientes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar_direccion(ByVal direccion As String, ByVal id_cliente As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE clientes SET direccion=@direccion, fecha_mod=now() WHERE id_cliente=@id_cliente", cnn)

            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@id_cliente", id_cliente)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar direccion del Cliente: " + ex.Message, "func_clientes", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
