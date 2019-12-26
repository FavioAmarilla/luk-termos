Public Class frm_vista_lineas_padre

    Private familia As New func_familias
    Private dt_familias As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_lineas_padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_familias = familia.listar("SELECT identificador, descripcion, nivel FROM familias")
        grid_lineas_padres.DataSource = dt_familias
    End Sub

    Private Sub enviar_id(ByVal id As String)


    End Sub

    Private Sub grid_lineas_padres_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_lineas_padres.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                Return
            End If
            enviar_id(GridView1.GetRowCellValue(rowhandle, "identificador").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_lineas_padres_DoubleClick(sender As Object, e As EventArgs) Handles grid_lineas_padres.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            Return
        End If
        enviar_id(GridView1.GetRowCellValue(rowhandle, "identificador").ToString())
    End Sub
End Class