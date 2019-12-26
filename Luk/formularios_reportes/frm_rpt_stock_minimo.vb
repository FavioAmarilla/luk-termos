Public Class frm_rpt_stock_minimo

    Dim stock As New func_stock_articulos
    Dim util As New utilidades

    Private Sub frm_rpt_stock_minimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        cbo_tipo.SelectedIndex = 0
        GridControl1.DataSource = Nothing
    End Sub

    Sub consultar()
        Dim sql_articulos As String = "select ar.codigo_barras as codigo, ar.nombre as item, sa.cantidad as existencia
                                        from stock_articulos sa
                                        left join articulos ar on ar.id_articulo = sa.id_articulo
                                        where sa.id_articulo > 0 and sa.cantidad < sa.stock_minimo"

        Dim sql_materia_prima As String = "select ma.codigo, ma.nombre as item, sa.cantidad as existencia
                                        from stock_articulos sa
                                        left join materiales ma on ma.id_material = sa.id_material
                                        where sa.id_material > 0 and sa.cantidad < sa.stock_minimo"

        Dim dt As New DataTable

        If cbo_tipo.SelectedIndex = 0 Then
            dt = stock.consultar(sql_articulos)
        End If
        If cbo_tipo.SelectedIndex = 1 Then
            dt = stock.consultar(sql_materia_prima)
        End If

        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        Else
            util.mensajes("No se registraron items por debajo del stock minimo", "Stock minimo", "INF")
        End If

    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        consultar()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene pagina", "Stock minimo", "WAR")
        Else
            GridControl1.ShowPrintPreview()
        End If

    End Sub
End Class