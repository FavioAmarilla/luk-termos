Public Class frm_permisos

    Private permiso As New func_permisos()
    Private util As New utilidades()
    Private dt_permisos As New DataTable()

    Private TITULO_MSJ As String = "<<Permisos de Acceso>>"
    Private ID_PERMISO As Integer = 0
    Private NOMBRE As String = ""

    Private Sub frm_permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub listar()
        dt_permisos.Clear()
        dt_permisos = permiso.consultar("SELECT * FROM permisos ORDER BY fecha_cre DESC, fecha_mod DESC")

        grid_tipos_comprobante.DataSource = dt_permisos
    End Sub

End Class