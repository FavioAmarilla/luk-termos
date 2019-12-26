Imports DevExpress.XtraPrinting

Public Class frm_listado_articulos

    Private articulo As New func_articulos
    Private dt_articulos As New DataTable
    Private util As New utilidades

    Private ID_FAMILIA As Integer = 0
    Private ID_PROVEEDOR As Integer = 0

    Private Sub frm_listado_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_todos.Checked = True
        listar()
    End Sub

    Private Sub limpiar()
        txt_familia.Text = ""
        ID_FAMILIA = 0
        txt_proveedor.Text = ""
        ID_PROVEEDOR = 0
    End Sub

    Private Sub listar()
        Dim familia As String = ""
        Dim proveedor As String = ""

        If chk_familia.Checked Then
            familia = "WHERE a.id_familia = " & ID_FAMILIA.ToString
        End If

        If chk_proveedor.Checked Then
            If chk_familia.Checked Then
                proveedor = " AND a.id_proveedor = " & ID_PROVEEDOR.ToString
            Else
                proveedor = " WHERE a.id_proveedor = " & ID_PROVEEDOR.ToString
            End If
        End If

        dt_articulos = articulo.listar("SELECT a.codigo_barras, a.nombre, COALESCE(f.descripcion, 'NO DEFINIDO') AS familia, COALESCE(a.costo_unitario,0) AS costo_unitario, 
                                        COALESCE(a.precio_venta,0) AS precio_venta, a.codigo_articulo, COALESCE(p.nombre, 'NO DEFINIDO') AS proveedor, 
                                        t.nombre AS tipo_impuesto
                                        FROM articulos a
                                        INNER JOIN tipos_impuesto t ON t.id_tipo_impuesto = a.id_tipo_impuesto
                                        INNER JOIN proveedores p ON p.id_proveedor = a.id_proveedor 
                                        INNER JOIN familias f ON f.identificador = a.id_familia " & familia & proveedor)
        grid_listado.DataSource = dt_articulos
    End Sub


    Public Sub obtener_familia(id As String)
        Dim dt As New DataTable
        dt = articulo.listar("SELECT identificador, descripcion FROM familias WHERE identificador=" + id)

        If dt.Rows.Count > 0 Then
            ID_FAMILIA = CInt(dt.Rows(0).Item(0))
            txt_familia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Public Sub obtener_proveedor(ByVal id As Integer)
        Dim dt As New DataTable
        dt = articulo.listar("SELECT id_proveedor, nombre FROM proveedores WHERE id_proveedor=" + id.ToString() + "")
        ID_PROVEEDOR = CInt(dt.Rows(0).Item(0))
        txt_proveedor.Text = CStr(dt.Rows(0).Item(1))
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        GridView1.ShowPrintPreview()
    End Sub

    Private Sub GridView1_PrintInitialize(sender As Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub btn_familia_Click(sender As Object, e As EventArgs) Handles btn_familia.Click
        Dim frm As New frm_vista_familias
        frm.FRM_ACTIVO = "frm_listado_articulos"
        frm.Show()
    End Sub

    Private Sub txt_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_familia.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_familias
            frm.FRM_ACTIVO = "frm_listado_articulos"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If chk_familia.Checked Then
                If txt_familia.Text = "" Then
                Else
                    chk_proveedor.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        Dim frm As New frm_vista_proveedores
        frm.FRM_ACTIVO = "frm_listado_articulos"
        frm.Show()
    End Sub

    Private Sub txt_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_proveedor.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_proveedores
            frm.FRM_ACTIVO = "frm_listado_articulos"
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If chk_proveedor.Checked Then
                If txt_proveedor.Text = "" Then
                Else
                    btn_consultar.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If chk_todos.Checked = False And chk_familia.Checked = False And chk_proveedor.Checked = False Then
            util.mensajes("Debe seleccionar filtro de busqueda", "<Listado de Articulos>", "WAR")
            chk_todos.Focus()
            Return
        End If
        listar()
        '  lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub chk_todos_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_todos.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_familia.Focus()
        End If
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            chk_familia.Checked = False
            chk_proveedor.Checked = False
            limpiar()
        End If
    End Sub

    Private Sub chk_familia_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_familia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_familia.Focus()
        End If
    End Sub

    Private Sub chk_familia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_familia.CheckedChanged
        If chk_familia.Checked Then
            chk_todos.Checked = False
        Else
            txt_familia.Text = ""
            ID_FAMILIA = 0
        End If
    End Sub

    Private Sub chk_proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_proveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_proveedor.Focus()
        End If
    End Sub

    Private Sub chk_proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles chk_proveedor.CheckedChanged
        If chk_familia.Checked Then
            chk_todos.Checked = False
        Else
            txt_proveedor.Text = ""
            ID_PROVEEDOR = 0
        End If
    End Sub
End Class