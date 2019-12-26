Public Class frm_vista_recibos_all
    Private recibos As New func_recibos
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_recibos_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        Dim dt As New DataTable
        dt = recibos.consultar("select id_recibo, concat(cl.nombres, ' ', cl.apellidos) as cliente, numero, observacion as concepto, monto 
                                        from recibos re
                                        inner join clientes cl on cl.id_cliente = re.id_cliente
                                        order by numero desc")
        grid_recibos.DataSource = dt
    End Sub

    Private Sub enviar_id(id As String)
        If FRM_ACTIVO = "frm_reimpresion_recibos" Then
            frm_reimpresion_recibos.obtener_recibo(id)
            Close()
        End If
    End Sub

    Private Sub grid_recibos_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_recibos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If GridView1.RowCount > 0 Then
                enviar_id(GridView1.GetRowCellValue(rowhandle, "id_recibo").ToString())
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_recibos_DoubleClick(sender As Object, e As EventArgs) Handles grid_recibos.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If GridView1.RowCount > 0 Then
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_recibo").ToString())
        End If
    End Sub

End Class