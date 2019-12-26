Imports System.Collections
Imports System.IO
Imports Npgsql

Public Class conexion

    Inherits utilidades

    Private USER As String = ""
    Private PASS As String = ""
    Private IP As String = ""
    Private DB As String = ""

    Private cadena As String = ""
    Public cnn As NpgsqlConnection

    Public Sub conectar()
        Try
            parametrosConexion()
            cadena = "User ID=" & USER & ";Password=" & PASS & ";Host=" & IP & ";Port=5432;Database=" & DB
            cnn = New NpgsqlConnection(cadena)
            cnn.Open()
        Catch ex As Exception
            mensajes("Error al conectarse a Base de Datos: " + ex.Message, "conexion", "ERR")
        End Try
    End Sub

    Public Sub desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            mensajes("Error al desconectarse de base de datos: " + ex.Message, "conexion", "ERR")
        End Try
    End Sub

    'funcion para obtener datos de la conexion a base de datos
    Public Sub parametrosConexion()
        Try
            Dim directorio As String
            directorio = My.Application.Info.DirectoryPath & "\Luk.txt"
            Dim objReader As New StreamReader(directorio)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()

            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()

            IP = arrText(0).ToString
            USER = arrText(1).ToString
            PASS = arrText(2).ToString
            DB = arrText(3).ToString
        Catch ex As Exception
            mensajes("Error al obtener  archivo de configuracion: " + ex.Message, "conexion", "ERR")
        End Try
    End Sub

End Class
