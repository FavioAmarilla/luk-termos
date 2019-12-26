Imports DevExpress.XtraReports.UI

Public Class frm_stock_valorizado

    Dim util As New utilidades
    Dim stock As New func_stock_articulos
    Dim dt_stock As New DataTable

    Dim TITULO_MSJ As String = "<Stock valorizado>"
    Private ID_PROVEEDOR As Integer = 0
    Private ID_FAMILIA As Integer = 0
    Private COD_FMAILIA As String = ""

    Private Sub frm_stock_valorizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount.ToString
    End Sub

    Private Sub limpiar()
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        cbo_tipo_movimiento.SelectedIndex = -1
        txt_familia.Text = ""
        txt_proveedor.Text = ""
    End Sub

    Private Sub listar()
        Dim sql As String = ""
        Dim id_sucursal As String = ""
        Dim proveedor_a As String = ""
        Dim proveedor_m As String = ""
        Dim familia_a As String = ""
        Dim familia_m As String = ""
        Dim negativos As String = ""

        If txt_id_sucursal.Text = "" Then
            util.mensajes("Debe seleccionar sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        Else
            id_sucursal = " sa.id_sucursal=" & txt_id_sucursal.Text
        End If

        If txt_proveedor.Text = "" Then
            proveedor_a = ""
            proveedor_m = ""
        Else
            proveedor_a = " and a.id_proveedor=" & ID_PROVEEDOR.ToString()
            proveedor_m = " and m.id_proveedor=" & ID_PROVEEDOR.ToString()
        End If

        If txt_familia.Text = "" Then
            familia_a = ""
            familia_m = ""
        Else
            familia_a = " and f.codigo like '" & COD_FMAILIA & "%'"
            familia_a = " and f.codigo like '" & COD_FMAILIA & "%'"
        End If

        If chk_valores_negativos.Checked = False And cbo_tipo_movimiento.SelectedIndex = 0 Then
            negativos = " and sa.cantidad > 0"
        End If

        If cbo_tipo_movimiento.SelectedIndex < 0 Then
            util.mensajes("Debe seleccionar tipo de item", TITULO_MSJ, "WAR")
            cbo_tipo_movimiento.Focus()
            Return
        End If

        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            sql = "select a.codigo_barras as codigo, coalesce(a.nombre, 'SIN NOMBRE') as item, coalesce(p.nombre, 'NO DEFINIDO') as proveedor, 
                    coalesce(f.descripcion, 'NO DEFINIDO') as familia, sa.cantidad as existencia, a.costo_unitario, coalesce(a.costo_unitario * sa.cantidad, 0) as costo_total
                    from stock_articulos sa
                    inner join articulos a on a.id_articulo = sa.id_articulo
                    inner join proveedores p on p.id_proveedor = a.id_proveedor
                    inner join familias f on f.identificador = a.id_familia
                    where " & id_sucursal & familia_a & proveedor_a & negativos
        End If

        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            sql = "select m.codigo as codigo, coalesce(m.nombre, 'SIN NOMBRE') as item, coalesce(p.nombre, 'NO DEFINIDO') as proveedor, 
                    coalesce(f.descripcion, 'NO DEFINIDO') as familia, sa.cantidad as existencia, m.costo_unitario, coalesce(m.costo_unitario * sa.cantidad, 0) as costo_total
                    from stock_articulos sa
                    inner join materiales m on m.id_material = sa.id_material
                    inner join proveedores p on p.id_proveedor = m.id_proveedor
                    inner join familias_materia_prima f on f.identificador = m.id_familia
                    where " & id_sucursal & familia_m & proveedor_m & negativos
        End If

        dt_stock = stock.consultar(sql)

        If dt_stock.Rows.Count() <= 0 Then
            util.mensajes("No se registraton stock de " & cbo_tipo_movimiento.SelectedItem.ToString, TITULO_MSJ, "WAR")
        Else
            grid_stock.DataSource = dt_stock
        End If

        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount.ToString
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable

        dt = stock.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_familia_articulo(id As String)
        Dim dt As New DataTable
        dt = stock.consultar("SELECT identificador, descripcion, codigo FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
            COD_FMAILIA = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Public Sub obtener_familia_material(id As String)
        Dim dt As New DataTable
        dt = stock.consultar("SELECT identificador, descripcion, codigo FROM familias_materia_prima WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
            COD_FMAILIA = CStr(dt.Rows(0).Item(2))
        End If
    End Sub

    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = stock.consultar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor=" + id.ToString() + "")
        ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
        txt_proveedor.Text = CStr(dt.Rows(0).Item(1))
    End Sub

    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_stock_valorizado"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_stock_valorizado"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
                Return
            End If
            cbo_tipo_movimiento.Focus()
        End If
    End Sub
    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            If cbo_tipo_movimiento.SelectedIndex = 0 Then
                Dim frm As New frm_vista_familias_all
                frm.FRM_ACTIVO = "frm_stock_valorizado"
                frm.Show()
            End If
            If cbo_tipo_movimiento.SelectedIndex = 1 Then
                Dim frm As New frm_vista_familia_materia_prima_all
                frm.FRM_ACTIVO = "frm_stock_valorizado"
                frm.Show()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            txt_proveedor.Focus()
        End If
    End Sub

    Private Sub btn_familia_Click(sender As Object, e As EventArgs) Handles btn_familia.Click
        If cbo_tipo_movimiento.SelectedIndex = 0 Then
            Dim frm As New frm_vista_familias_all
            frm.FRM_ACTIVO = "frm_stock_valorizado"
            frm.Show()
        End If
        If cbo_tipo_movimiento.SelectedIndex = 1 Then
            Dim frm As New frm_vista_familia_materia_prima_all
            frm.FRM_ACTIVO = "frm_stock_valorizado"
            frm.Show()
        End If
    End Sub

    Private Sub btn_buscar_proveedor_Click(sender As Object, e As EventArgs) Handles btn_buscar_proveedor.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_stock_valorizado"
        frm.Show()
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_stock_valorizado"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            btn_consultar.Focus()
        End If
    End Sub

    Private Sub cbo_tipo_movimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_tipo_movimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_tipo_movimiento.SelectedIndex >= 0 Then
                txt_familia.Focus()
            End If
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        listar()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        limpiar()
        txt_sucursal.Focus()
    End Sub

    Private Sub grid_stock_Click(sender As Object, e As EventArgs) Handles grid_stock.Click

    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_stock_valorizado

        report.DataSource = dt_stock

        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha
        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("proveedor").Value = "Proveedor: " + txt_proveedor.Text
        report.Parameters("familia").Value = "Familia: " + txt_familia.Text
        report.Parameters("tipo").Value = "Items: " + cbo_tipo_movimiento.SelectedItem.ToString

        report.Parameters("sucursal").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("tipo").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub

End Class