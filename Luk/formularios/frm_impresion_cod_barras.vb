Imports DevExpress.XtraReports.UI

Public Class frm_impresion_cod_barras

    Dim cont_articulo As New func_articulos
    Dim util As New utilidades
    Dim dt_impresion As New DataTable

    Private Sub frm_impresion_cod_barras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        crear_cursor()
    End Sub

    Private Sub crear_cursor()
        dt_impresion = New DataTable
        dt_impresion.Columns.Add("codigo_barras")
        dt_impresion.Columns.Add("descripcion")
        dt_impresion.Columns.Add("precio_venta")
        dt_impresion.Columns.Add("cantidad", GetType(Double))
        grid_articulos.DataSource = dt_impresion
    End Sub

    Sub limpiar()
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
        txt_precio_venta.Text = ""
        txt_cantidad.Text = ""
    End Sub

    Public Sub add_articulo()
        If txt_codigo.Text = "" Or txt_descripcion.Text = "" Or txt_precio_venta.Text = "" Or txt_cantidad.Text = "" Then
            util.mensajes("Debe ingresar articulo", "Impresion", "WAR")
            Return
        End If

        Dim newRow As DataRow = (TryCast(grid_articulos.DataSource, DataTable)).NewRow()
        newRow("codigo_barras") = txt_codigo.Text
        newRow("descripcion") = txt_descripcion.Text
        newRow("precio_venta") = txt_precio_venta.Text
        newRow("cantidad") = txt_cantidad.Text

        TryCast(grid_articulos.DataSource, DataTable).Rows.Add(newRow)
        grid_articulos.RefreshDataSource()

        eliminar_filas_vacias()
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_impresion.Rows()
            If IsDBNull(dr("codigo_barras")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_impresion.Rows.Remove(dr)
        Next
    End Sub

    Sub obtener_articulo(codigo As String)
        Dim dt As New DataTable
        dt = cont_articulo.listar("SELECT nombre, codigo_barras, COALESCE(precio_venta, 0) FROM articulos WHERE id_articulo='" & codigo & "'")

        If dt.Rows.Count > 0 Then
            Dim codigo_barras As String = CStr(dt.Rows(0).Item(1))
            txt_codigo.Text = codigo_barras
            txt_descripcion.Text = dt.Rows(0).Item(0)
            txt_cantidad.Text = CStr(2)
            txt_cantidad.Focus()
            txt_precio_venta.Text = Format(dt.Rows(0).Item(2), "##,##") + "  Gs."
        Else
            util.mensajes("Producto no definido", "Imp. de codigos", "WAR")
        End If
    End Sub

    Sub obtener_articulo_codigo(codigo As String)
        Dim dt As New DataTable
        dt = cont_articulo.listar("SELECT nombre, codigo_barras, COALESCE(precio_venta, 0) FROM articulos WHERE codigo_barras='" & codigo & "'")

        If dt.Rows.Count > 0 Then
            Dim codigo_barras As String = CStr(dt.Rows(0).Item(1))
            txt_codigo.Text = codigo_barras
            txt_descripcion.Text = dt.Rows(0).Item(0)
            txt_cantidad.Text = CStr(2)
            txt_cantidad.Focus()
            txt_precio_venta.Text = Format(dt.Rows(0).Item(2), "##,##") + "  Gs."
        Else
            util.mensajes("Producto no definido", "Imp. de codigos", "WAR")
        End If
    End Sub

    Sub crear_datatable()
    End Sub

    Function add_item_impresion() As DataTable
        Try
            Dim dt As New DataTable
            Dim column As DataColumn
            Dim row As DataRow
            Dim limite As Integer

            column = New DataColumn()
            column.ColumnName = "codigo_barras"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "nombre"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "precio_venta"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "fecha"
            dt.Columns.Add(column)

            For i As Integer = 0 To dt_impresion.Rows.Count - 1
                limite = dt_impresion.Rows(i).Item(3)
                For j As Integer = 1 To limite
                    row = dt.NewRow()
                    row("codigo_barras") = dt_impresion.Rows(i).Item(0)
                    row("nombre") = dt_impresion.Rows(i).Item(1)
                    row("precio_venta") = dt_impresion.Rows(i).Item(2)
                    row("fecha") = Now.ToString("dd/MM/yyyy")
                    dt.Rows.Add(row)
                Next
            Next

            Return dt
        Catch ex As Exception
            util.mensajes(ex.Message, "Error", "ERR")
            Return Nothing
        End Try
    End Function


    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo.Text.Replace(" ", "") IsNot "" Then
                obtener_articulo_codigo(txt_codigo.Text)
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_articulos
            frm.FRM_ACTIVO = "frm_impresion_cod_barras"
            frm.Show()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If util.msj_confirmacion("Deseas cancelar la operacion", "Existencia") Then
            limpiar()
            dt_impresion = Nothing
            grid_articulos.DataSource = Nothing
            crear_cursor()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If dt_impresion.Rows.Count <= 0 Then
            util.mensajes("Debe agregar articulos a la lista", "Impresion", "WAR")
            Return
        End If

        Dim report As New rpt_imp_cod_barras
        report.DataSource = add_item_impresion()

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
        limpiar()
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad.Text IsNot "" Then
                btn_agregar.Focus()
            End If
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        add_articulo()
        limpiar()
        txt_codigo.Focus()
    End Sub
End Class