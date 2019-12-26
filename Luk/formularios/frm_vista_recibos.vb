Public Class frm_vista_recibos
    Private recibos As New func_recibos
    Private dt_recibos As New DataTable
    Public FRM_ACTIVO As String = ""
    Private ID_CLIENTE As Integer = 0
    Private verificador As String = ""
    Private condicion As String = ""

    Private Sub frm_vista_recibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setIdCliente(value As Integer)
        ID_CLIENTE = value
    End Sub

    Public Sub setVerificador(value As String)
        verificador = value
    End Sub

    Public Sub setCondicion(value As String)
        condicion = value
    End Sub

    Private Sub listar()
        If verificador = "POS" Then
            dt_recibos.Clear()
            dt_recibos = recibos.consultar("select id_recibo, numero, observacion as concepto, monto from recibos where estado=false and id_cliente=" & CStr(ID_CLIENTE))
            dt_recibos.Select(condicion)
            grid_recibos.DataSource = dt_recibos
        Else
            dt_recibos.Clear()
            dt_recibos = recibos.consultar("select id_recibo, numero, observacion as concepto, monto from recibos where estado=false and id_cliente=" & CStr(ID_CLIENTE))
            grid_recibos.DataSource = dt_recibos
        End If
    End Sub

    Private Sub enviar_id(id As String)
        If FRM_ACTIVO = "frm_cobros_caja" Then
            frm_cobros_caja.obtener_recibo(id)
            Close()
        End If
    End Sub

    Private Sub grid_sucursales_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_recibos.KeyDown
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

    Private Sub grid_sucursales_DoubleClick(sender As Object, e As EventArgs) Handles grid_recibos.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        If GridView1.RowCount > 0 Then
            enviar_id(GridView1.GetRowCellValue(rowhandle, "id_recibo").ToString())
        End If
    End Sub

End Class