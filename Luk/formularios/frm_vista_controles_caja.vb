Public Class frm_vista_controles_caja

    Private control As New func_control_caja
    Private dt_controles As New DataTable
    Public FRM_ACTIVO As String

    Private Sub frm_vista_controles_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_controles = control.consultar("SELECT id_control_caja, fecha_apertura FROM control_caja WHERE fecha_cierre IS NULL")
        grid_controles.DataSource = dt_controles
    End Sub

    Private Sub enviar_id(id As String)
        If FRM_ACTIVO = "frm_cerrar_controles" Then
            frm_cerrar_controles.obtener_control(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_resumen_caja" Then
            frm_resumen_caja.obtener_control(id)
            Close()
        End If
    End Sub

    Private Sub grid_controles_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_controles.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_control_caja").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_controles_DoubleClick(sender As Object, e As EventArgs) Handles grid_controles.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_control_caja").ToString())
    End Sub
End Class