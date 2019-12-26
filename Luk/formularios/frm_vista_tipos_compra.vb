Public Class frm_vista_tipos_compra

    Private tipo_compra As New func_tipos_compra
    Private dt_tipo_compra As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_tipo_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_tipo_compra = New DataTable()
        dt_tipo_compra = tipo_compra.listar("SELECT id_tipo_compra, nombre, relacion, activo FROM tipos_compra WHERE activo = true")
        grid_tipos_compras.DataSource = dt_tipo_compra
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_compras" Then
            frm_compras.obtener_tipo_compra(id)
            Me.Close()
        End If
    End Sub

    Private Sub grid_tipos_compras_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_tipos_compras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_tipo_compra").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_tipos_compras_DoubleClick(sender As Object, e As EventArgs) Handles grid_tipos_compras.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_tipo_compra").ToString()))
    End Sub
End Class