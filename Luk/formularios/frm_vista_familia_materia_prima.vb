Public Class frm_vista_familia_materia_prima
    Dim util As New utilidades
    Private familias As New func_familias_materia_prima
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_familia_materia_prima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = familias.listar("SELECT identificador, descripcion, codigo FROM familias_materia_prima WHERE ultimo_nivel=true order by codigo")
        grid_familias.DataSource = dt
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_materiales" Then
            frm_materiales.obtener_familia(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_traspaso_materia_prima" Then
            frm_traspaso_materia_prima.obtener_linea_padre(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_ranking_compras" Then
            frm_ranking_compras.obtener_familia(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_valorizado" Then
            frm_stock_valorizado.obtener_familia_material(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_familia" Then
            frm_rpt_compras_por_familia.obtener_familia_material(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_ranking_compras" Then
            frm_ranking_compras.obtener_familia_material(id)
            Close()
        End If
    End Sub

    Private Sub grid_familias_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_familias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "identificador").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_familias_DoubleClick(sender As Object, e As EventArgs) Handles grid_familias.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "identificador").ToString()))
    End Sub
End Class