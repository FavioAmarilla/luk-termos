Public Class frm_vista_tipos_impuesto

    Private tipos_impuesto As New func_tipos_impuesto()
    Private dt_tipos_impuesto As New DataTable()
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_tipos_impuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros Recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_tipos_impuesto = New DataTable()
        dt_tipos_impuesto = tipos_impuesto.listar("SELECT id_tipo_impuesto, nombre, valor, activo FROM tipos_impuesto WHERE activo = true")
        grid_tipos_impuesto.DataSource = dt_tipos_impuesto
    End Sub

    Private Sub enviar_id(ByVal id As Integer)
        If FRM_ACTIVO = "frm_articulos" Then
            frm_articulos.obtener_tipo_impuesto(id)
            Me.Close()
        End If
        If FRM_ACTIVO = "frm_materiales" Then
            frm_materiales.obtener_tipo_impuesto(id)
            Me.Close()
        End If
    End Sub

    Private Sub grid_tipos_impuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_tipos_impuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_tipo_impuesto").ToString()))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub grid_tipos_impuesto_DoubleClick(sender As Object, e As EventArgs) Handles grid_tipos_impuesto.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        enviar_id(CInt(GridView1.GetRowCellValue(rowhandle, "id_tipo_impuesto").ToString()))
    End Sub
End Class