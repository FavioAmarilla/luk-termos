Public Class frm_vista_comprobantes

    Private venta As New func_ventas
    Private dt_venta As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_comprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        dt_venta = New DataTable()
        dt_venta = venta.consultar("select vta.id_venta, vta.fecha_venta, vta.numero, vta.total_venta, concat(cl.nombres,' ',cl.apellidos) as cliente
                                    from ventas vta
                                    left join clientes cl on cl.id_cliente = vta.id_cliente
                                    order by id_venta desc")

        If dt_venta.Rows.Count > 0 Then
            grid_ventas.DataSource = dt_venta
        Else

        End If
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_notas_credito" Then
            frm_notas_credito.get_comprobante(id)
            Close()
        End If

    End Sub

    Private Sub grid_ventas_DoubleClick(sender As Object, e As EventArgs) Handles grid_ventas.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If rowhandle < 0 Then
            Return
        End If
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_venta").ToString()))
    End Sub

    Private Sub grid_ventas_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_ventas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                Return
            End If
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_venta").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class