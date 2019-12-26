Public Class frm_vista_clientes

    Dim util As New utilidades()
    Private cliente As New func_clientes()
    Private dt_clientes As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        dt_clientes.Clear()
        dt_clientes = cliente.listar("SELECT id_cliente, CONCAT(nombres,' ',apellidos) AS cliente FROM clientes")
        grid_clientes.DataSource = dt_clientes
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_pedidos" Then
            frm_pedidos.obtener_cliente(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_ventas" Then
            frm_ventas.obtener_cliente(id)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_ventas_por_clientes" Then
            frm_rpt_vta_por_clientes.obtener_cliente(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_pedidos_recibidos" Then
            frm_rpt_pedidos_recibidos.obtener_cliente(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_recibos" Then
            frm_recibos.obtener_cliente(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_pago_facturas" Then
            frm_pago_facturas.obtener_cliente(id.ToString())
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_cobros_caja_por_cliente" Then
            frm_rpt_cobros_caja_por_cliente.obtener_cliente(id.ToString())
            Close()
        End If
    End Sub

    Private Sub grid_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_clientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_cliente").ToString()))
        End If

        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_clientes_DoubleClick(sender As Object, e As EventArgs) Handles grid_clientes.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_cliente").ToString()))
    End Sub

    Private Sub btn_registro_cliente_Click(sender As Object, e As EventArgs) Handles btn_registro_cliente.Click
        If util.CheckForm(frm_clientes) = False Then
            frm_clientes.Show()
            Close()
        Else
            frm_clientes.Focus()
            Close()
        End If
    End Sub
End Class