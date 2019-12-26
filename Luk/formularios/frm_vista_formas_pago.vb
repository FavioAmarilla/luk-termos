Public Class frm_vista_formas_pago

    Private formas_pago As New func_formas_pago
    Private dt_formas_pago As New DataTable
    Public FRM_ACTIVO As String = ""
    Public frm_recibos As frm_recibos
    Public frm_pago_facturas As frm_pago_facturas

    Private Sub frm_vista_formas_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_formas_pago = New DataTable()
        dt_formas_pago = formas_pago.listar("SELECT id_forma_pago, nombre, tipo_pago FROM formas_pago WHERE activo = true")
        grid_formas_pago.DataSource = dt_formas_pago
    End Sub

    Private Sub enviar_id(id As String)
        If FRM_ACTIVO = "frm_cobros_caja" Then
            frm_cobros_caja.obtener_forma_pago(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_cobros_caja" Then
            frm_rpt_cobros_caja.obtener_forma_pago(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_recibos" Then
            frm_recibos.obtener_forma_pago(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_pago_facturas" Then
            frm_pago_facturas.obtener_forma_pago(id)
            Close()
        End If
    End Sub

    Private Sub grid_formas_pago_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_formas_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_forma_pago").ToString())
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_formas_pago_DoubleClick(sender As Object, e As EventArgs) Handles grid_formas_pago.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(GridView1.GetRowCellValue(rowhandle, "id_forma_pago").ToString())
    End Sub
End Class