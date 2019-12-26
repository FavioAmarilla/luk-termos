Public Class frm_traspaso_articulo_prov

    Private articulo As New func_articulos
    Private dt As New DataTable
    Private util As New utilidades

    Private TITULO_MSJ As String = "<Transpaso de Articulos>"
    Private ACCION As String = ""
    Private ID_PROVEEDOR As Integer = 0
    Private ID_TRASPASO As Integer = 0

    Private Sub frm_traspaso_articulo_prov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_total_registros.Text = ""
    End Sub

    Private Sub limpiar()
        txt_proveedor.Text = ""
        txt_traspaso.Text = ""
        txt_proveedor.Focus()
        dt = Nothing
        lbl_total_registros.Text = ""
    End Sub

    Private Sub traspaso()
        If dt.Rows.Count <= 0 Then
            util.mensajes("No se registran Articulos para traspaso", TITULO_MSJ, "WAR")
            txt_proveedor.Focus()
            Return
        End If

        If articulo.traspaso(ID_PROVEEDOR, ID_TRASPASO) = False Then
            util.mensajes("Articulo no traspasado", TITULO_MSJ, "WAR")
            Return
        End If

        util.mensajes("Traspaso realizado", TITULO_MSJ, "INF")
        limpiar()
    End Sub


    Public Sub obtener_proveedor(id As Integer)
        Dim dt As New DataTable
        dt = articulo.listar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor=" + id.ToString() + "")
        If ACCION = "P" Then
            ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
            txt_proveedor.Text = CStr(dt.Rows(0).Item(1))
        End If
        If ACCION = "T" Then
            ID_TRASPASO = CInt(dt.Rows(0).Item(0))
            txt_traspaso.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Sub obtener_articulos()
        If txt_proveedor.Text = "" Then
            util.mensajes("Debe seleccionar Proveedor", TITULO_MSJ, "WAR")
            Return
        End If
        dt = articulo.listar("SELECT nombre, id_proveedor FROM articulos WHERE id_proveedor=" + ID_PROVEEDOR.ToString)
        lbl_total_registros.Text = "Registros recuperados: " & CStr(dt.Rows.Count)

        If dt.Rows.Count <= 0 Then
            txt_proveedor.Focus()
        Else
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_traspaso_articulo_prov"
            frm.Show()
            ACCION = "P"
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_proveedor.Text = "" Then
            Else
                txt_traspaso.Focus()
            End If
        End If
    End Sub

    Private Sub txt_traspaso_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_traspaso.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_traspaso_articulo_prov"
            frm.Show()
            ACCION = "T"
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_traspaso.Text = "" Then
            Else
                btn_consultar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_traspaso_articulo_prov"
        frm.Show()
        ACCION = "P"
    End Sub

    Private Sub btn_traspaso_Click(sender As Object, e As EventArgs) Handles btn_traspaso.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_traspaso_articulo_prov"
        frm.Show()
        ACCION = "P"
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        traspaso()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        obtener_articulos()
    End Sub
End Class