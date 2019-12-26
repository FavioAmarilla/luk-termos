Public Class frm_historial_precio_venta
    Private Sub frm_historial_precio_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub listar(id As String)
        Dim articulo As New func_articulos
        Dim dt As New DataTable
        dt = articulo.listar("SELECT a.nombre AS articulo, h.nuevo_precio AS precio_venta, h.fecha_cre AS fecha 
                              FROM historial_mod_precio_venta h
                              INNER JOIN articulos a ON a.id_articulo = h.id_articulo
                              WHERE h.id_articulo = " + id + " ORDER BY h.fecha_cre DESC")

        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        Else
            Dim util As New utilidades
            util.mensajes("No se registraron cambios en el Precio de Venta", "<Historial de Precio de Venta>", "WAR")
        End If
    End Sub
End Class