Public Class frm_vista_transacciones

    Private transaccion As New func_transacciones_stock()
    Private dt_transacciones As New DataTable()
    Public FRM_ACTIVO As String = ""
    Public CONDICION_SQL As String = ""

    Private Sub frm_vista_transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_transacciones = New DataTable()
        dt_transacciones = transaccion.listar("SELECT id_transaccion, nombre, accion FROM transacciones_stock ORDER BY nombre ASC")
        grid_transacciones.DataSource = dt_transacciones
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_stock_articulos" Then
            frm_stock_articulos.obtener_transaccion(id)
            Me.Close()
        End If

    End Sub

    Private Sub grid_transacciones_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_transacciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_transaccion").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_transacciones_DoubleClick(sender As Object, e As EventArgs) Handles grid_transacciones.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_transaccion").ToString()))
    End Sub

    Private Sub grid_transacciones_Click(sender As Object, e As EventArgs) Handles grid_transacciones.Click

    End Sub
End Class