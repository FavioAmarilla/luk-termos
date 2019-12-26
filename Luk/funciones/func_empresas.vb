Imports Npgsql

Public Class func_empresas

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
            util.mensajes("Error al listar Empresas: " + ex.Message, "func_empresas", "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertar(ByVal nombre As String, ByVal telefono As String, ByVal numero_documento As String,
                             ByVal email As String, ByVal pagina_web As String, ByVal pais As String,
                             ByVal ciudad As String, ByVal direccion As String, ByVal logo_empresa As String,
                             ruta_img_recursos As String, ruta_img_logos_temos As String, ruta_img_logos_guampas As String,
                             ruta_img_articulos As String, img_no_disponible As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("INSERT INTO empresas (nombre, telefono, numero_documento, email, pagina_web, pais, ciudad, direccion, logo_empresa,
                                            ruta_img_recursos, ruta_img_logos_temos, ruta_img_logos_guampas,  ruta_img_articulos, img_no_disponible)
                                            VALUES (@nombre, @telefono, @numero_documento, @email, @pagina_web, @pais, @ciudad, @direccion, @logo_empresa,
                                            @ruta_img_recursos, @ruta_img_logos_temos, @ruta_img_logos_guampas, @ruta_img_articulos, @img_no_disponible)", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@numero_documento", numero_documento)
            comand.Parameters.AddWithValue("@email", email)
            comand.Parameters.AddWithValue("@pagina_web", pagina_web)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@logo_empresa", logo_empresa)
            comand.Parameters.AddWithValue("@ruta_img_recursos", ruta_img_recursos)
            comand.Parameters.AddWithValue("@ruta_img_logos_temos", ruta_img_logos_temos)
            comand.Parameters.AddWithValue("@ruta_img_logos_guampas", ruta_img_logos_guampas)
            comand.Parameters.AddWithValue("@ruta_img_articulos", ruta_img_articulos)
            comand.Parameters.AddWithValue("@img_no_disponible", img_no_disponible)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al registrar Empresa: " + ex.Message, "func_empresas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(ByVal nombre As String, ByVal telefono As String, ByVal numero_documento As String,
                               ByVal email As String, ByVal pagina_web As String, ByVal pais As String,
                               ByVal ciudad As String, ByVal direccion As String, ByVal logo_empresa As String, ByVal id_empresa As Integer,
                               ruta_img_recursos As String, ruta_img_logos_temos As String, ruta_img_logos_guampas As String,
                               ruta_img_articulos As String, img_no_disponible As String) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("UPDATE empresas SET nombre=@nombre, telefono=@telefono, numero_documento=@numero_documento, 
                                            email=@email, pagina_web=@pagina_web, pais=@pais, ciudad=@ciudad, direccion=@direccion, 
                                            logo_empresa=@logo_empresa, fecha_mod=now(), ruta_img_recursos=@ruta_img_recursos, 
                                            ruta_img_logos_temos=@ruta_img_logos_temos, ruta_img_logos_guampas=@ruta_img_logos_guampas, 
                                            ruta_img_articulos=@ruta_img_articulos, img_no_disponible=@img_no_disponible 
                                            WHERE id_empresa=@id_empresa", cnn)

            comand.Parameters.AddWithValue("@nombre", nombre)
            comand.Parameters.AddWithValue("@telefono", telefono)
            comand.Parameters.AddWithValue("@numero_documento", numero_documento)
            comand.Parameters.AddWithValue("@email", email)
            comand.Parameters.AddWithValue("@pagina_web", pagina_web)
            comand.Parameters.AddWithValue("@pais", pais)
            comand.Parameters.AddWithValue("@ciudad", ciudad)
            comand.Parameters.AddWithValue("@direccion", direccion)
            comand.Parameters.AddWithValue("@logo_empresa", logo_empresa)
            comand.Parameters.AddWithValue("@ruta_img_recursos", ruta_img_recursos)
            comand.Parameters.AddWithValue("@ruta_img_logos_temos", ruta_img_logos_temos)
            comand.Parameters.AddWithValue("@ruta_img_logos_guampas", ruta_img_logos_guampas)
            comand.Parameters.AddWithValue("@ruta_img_articulos", ruta_img_articulos)
            comand.Parameters.AddWithValue("@img_no_disponible", img_no_disponible)
            comand.Parameters.AddWithValue("@id_empresa", id_empresa)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al actualizar Empresa: " + ex.Message, "func_empresas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar(ByVal id_empresa As Integer) As Boolean
        Try
            conectar()
            Dim comand As New NpgsqlCommand("DELETE DROP empresas WHERE id_empresa=@id_empresa", cnn)

            comand.Parameters.AddWithValue("@id_empleado", id_empresa)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al eliminar Empresa: " + ex.Message, "func_empresas", "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
