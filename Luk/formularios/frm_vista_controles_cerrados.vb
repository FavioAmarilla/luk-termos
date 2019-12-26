Public Class frm_vista_controles_cerrados

    Private control As New func_control_caja
    Private dt_tipo_compra As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_controles_cerrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_tipo_compra = New DataTable()
        dt_tipo_compra = control.consultar("SELECT id_control_caja, fecha_apertura, fecha_cierre FROM control_caja 
                                            WHERE fecha_cierre IS NOT NULL ORDER BY id_control_caja DESC")
        grid_controles.DataSource = dt_tipo_compra
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_controles_caja" Then
            frm_controles_caja.obtener_control(id.ToString)
            Me.Close()
        End If
    End Sub

    Private Sub grid_tipos_compras_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_controles.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_control_caja").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_tipos_compras_DoubleClick(sender As Object, e As EventArgs) Handles grid_controles.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_control_caja").ToString()))
    End Sub
End Class