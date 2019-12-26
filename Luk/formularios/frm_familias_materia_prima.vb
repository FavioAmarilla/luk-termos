Imports DevExpress.XtraReports.UI
Imports Npgsql

Public Class frm_familias_materia_prima

    Private familia As New func_familias_materia_prima
    Private dt_familias As New DataTable
    Private util As New utilidades

    Private ULTIMO_NIVEL As Boolean = False

    Private Sub frm_familias_materia_prima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar_familias()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Public Sub listar_familias()
        dt_familias = familia.listar("SELECT descripcion, identificador, codigo, nivel, ultimo_nivel, id_linea_padre FROM familias_materia_prima")

        trl_familias.DataSource = dt_familias
        trl_familias.KeyFieldName = "identificador"
        trl_familias.ParentFieldName = "id_linea_padre"

        'Se asignan los tamanhos de las columnas
        trl_familias.Columns(0).Width = 280
        trl_familias.Columns(1).Width = 60
        trl_familias.Columns(2).Width = 60
        trl_familias.Columns(3).Width = 75

        'Nombres de columnas
        trl_familias.Columns(0).Caption = "Descripcion"
        trl_familias.Columns(1).Caption = "Codigo"
        trl_familias.Columns(2).Caption = "Nivel"
        trl_familias.Columns(3).Caption = "Ultimo Nivel"

        'Se bloquean las columnas para que no sean editables
        trl_familias.Columns("descripcion").OptionsColumn.ReadOnly = True
        trl_familias.Columns("descripcion").OptionsColumn.AllowEdit = False
        trl_familias.Columns("codigo").OptionsColumn.ReadOnly = True
        trl_familias.Columns("codigo").OptionsColumn.AllowEdit = False
        trl_familias.Columns("nivel").OptionsColumn.ReadOnly = True
        trl_familias.Columns("nivel").OptionsColumn.AllowEdit = False
        trl_familias.Columns("ultimo_nivel").OptionsColumn.ReadOnly = True
        trl_familias.Columns("ultimo_nivel").OptionsColumn.AllowEdit = False
    End Sub

    Private Function obtener_identificador(codigo As String) As Integer
        Dim dt As New DataTable
        Dim id As Integer
        dt = familia.listar("select identificador from familias_materia_prima where codigo = '" & codigo & "'")

        If dt.Rows().Count() > 0 Then
            id = CInt(dt.Rows(0).Item(0).ToString)
        Else
            util.mensajes("Identificador de familia no obtenido", "<Familias de productos>", "WAR")
            id = 0
        End If

        Return id
    End Function

    Private Sub agregar()
        If util.msj_confirmacion("Deseas Registrar una Sub Familia", "<Familias de Productos>") Then
            If trl_familias.AllNodesCount <= 0 Then
                util.mensajes("No existen familias padre", "<Familias de Articulos>", "WAR")
                Return
            End If

            If CBool(trl_familias.FocusedNode(3).ToString) Then
                util.mensajes("No se puede agregar Sub Familia porque ya es ultimo nivel", "<Familias de Articulos>", "WAR")
                Return
            End If

            Dim identificador As Integer = obtener_identificador(trl_familias.FocusedNode(1).ToString())

            If identificador > 0 Then
                Dim frm As New frm_nueva_familia_materia_prima
                frm.setTIPO_REGISTRO("S")
                frm.setIDENTIFICADOR(identificador)
                frm.setID_LINEA_PADRE(identificador)
                frm.obtener_familia_padre()
                frm.Show()
            End If
        Else
            Dim frm As New frm_nueva_familia_materia_prima
            frm.setTIPO_REGISTRO("P")
            frm.setIDENTIFICADOR(0)
            frm.setID_LINEA_PADRE(0)
            frm.Show()
        End If
    End Sub

    Public Function borrar(identificador As Integer) As Boolean
        Try
            familia.conectar()
            Dim comand As New NpgsqlCommand("DELETE FROM familias_materia_prima WHERE identificador=@identificador", familia.cnn)

            comand.Parameters.AddWithValue("@identificador", identificador)


            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            util.mensajes("Error al Eliminar Familia: " + ex.Message, "<Familas de Materias Primas>", "ERR")
            Return False
        Finally
            familia.desconectar()
        End Try
    End Function

    Private Sub obtener_materia_prima()
        Dim dt As New DataTable

        dt = familia.listar("select m.*, ti.nombre as impuesto from materiales m
                            INNER JOIN tipos_impuesto ti on ti.id_tipo_impuesto = m.id_tipo_impuesto
                            where id_familia=" & obtener_identificador(trl_familias.FocusedNode(1).ToString))

        grid_articulos.DataSource = dt
    End Sub


    Private Sub trl_familias_KeyDown(sender As Object, e As KeyEventArgs) Handles trl_familias.KeyDown
        If e.KeyCode = Keys.Insert Then
            agregar()
        End If

        If e.KeyCode = Keys.Enter Then
            obtener_materia_prima()
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If familia.validar_familia_articulo(trl_familias.FocusedNode(2).ToString) Then
            util.mensajes("No se puede actualizar la familia porque esta asignada a un articulo", "<Familias de Articulo>", "WAR")
            Return
        End If

        If familia.validar_familia_articulo(trl_familias.FocusedNode(1).ToString) Then
            frm_actualizar_familia_materia_prima.obtener_familia(trl_familias.FocusedNode(1).ToString)
            frm_actualizar_familia_materia_prima.txt_familia.ReadOnly = False
            frm_actualizar_familia_materia_prima.chk_asentable.Enabled = False
            frm_actualizar_familia_materia_prima.Show()
        Else
            frm_actualizar_familia_materia_prima.txt_familia.ReadOnly = False
            frm_actualizar_familia_materia_prima.obtener_familia(trl_familias.FocusedNode(1).ToString)
            frm_actualizar_familia_materia_prima.Show()
        End If

    End Sub

    Private Sub trl_familias_DoubleClick(sender As Object, e As EventArgs) Handles trl_familias.DoubleClick
        obtener_materia_prima()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If trl_familias.AllNodesCount <= 0 Then
            util.mensajes("No existen familias para eliminar", "<Familias de Materia Prima>", "WAR")
            Return
        End If

        If util.msj_confirmacion("Esta Seguro que Desea eliminar esta Familia", "<Familias de Materia Prima>") Then
            Dim identificador As Integer = obtener_identificador(trl_familias.FocusedNode(1).ToString())
            Dim dt As New DataTable

            If identificador <= 0 Then
                util.mensajes("Debe seleccionar familia para eliminar", "<Familias de Materia Prima>", "WAR")
                Return
            End If
            dt = familia.listar("SELECT * FROM familias_materia_prima WHERE id_linea_padre=" & identificador.ToString)

            If dt.Rows.Count > 0 Then
                util.mensajes("No se puede eliminar porque tiene Sub Familias asignadas", "<Familias de Materia Prima>", "WAR")
                Return
            End If

            dt = familia.listar("SELECT * FROM articulos WHERE id_familia=" & identificador.ToString)

            If dt.Rows.Count > 0 Then
                util.mensajes("No se puede eliminar porque tiene Articulos asignados", "<Familias de Materia Prima>", "WAR")
                Return
            End If

            If familia.eliminar(identificador) Then
                util.mensajes("Familia Eliminada Correctamente ", "<Familias de Materia Prima>", "INF")
                listar_familias()
            Else
                util.mensajes("Familia no Eliminada ", "<Familias de Materia Primas>", "WAR")
            End If
        End If
    End Sub

    Private Sub btn_traspasar_Click(sender As Object, e As EventArgs) Handles btn_traspasar.Click
        If trl_familias.AllNodesCount <= 0 Then
            util.mensajes("No existen familias para traspaso", "<Familias de Materias Primas>", "WAR")
            Return
        End If

        If CBool(trl_familias.FocusedNode(3).ToString()) = False Then
            util.mensajes("No se puede realizar el traspaso porque no es ultimo nivel", "<Familias de Materias Primas>", "WAR")
            Return
        End If

        frm_traspaso_materia_prima.obtener_familia(trl_familias.FocusedNode("identificador").ToString())
        frm_traspaso_materia_prima.Show()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", "<Familia de Articulos>", "WAR")
            Return
        End If
        Dim report As New rpt_materiales_familia

        report.DataSource = grid_articulos.DataSource

        report.Parameters("familia").Value = "Familia: " + trl_familias.FocusedNode(0).ToString
        report.Parameters("cod_familia").Value = "Cod. Familia: " + trl_familias.FocusedNode(1).ToString
        report.Parameters("nivel_familia").Value = "Nivel: " + trl_familias.FocusedNode(2).ToString
        report.Parameters("ultimo_nivel").Value = trl_familias.FocusedNode(3).ToString
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("familia").Visible = False
        report.Parameters("cod_familia").Visible = False
        report.Parameters("nivel_familia").Visible = False
        report.Parameters("ultimo_nivel").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        agregar()
    End Sub
End Class