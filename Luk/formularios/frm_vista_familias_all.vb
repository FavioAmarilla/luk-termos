Public Class frm_vista_familias_all
    Dim util As New utilidades
    Private familias As New func_familias_materia_prima
    Dim dt_familias As New DataTable
    Public FRM_ACTIVO As String = ""

    Private Sub frm_vista_familias_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar_familias()
    End Sub


    Public Sub listar_familias()
        dt_familias = familias.listar("SELECT descripcion, identificador, codigo, nivel, ultimo_nivel, id_linea_padre FROM familias")

        trl_familias.DataSource = dt_familias
        trl_familias.KeyFieldName = "identificador"
        trl_familias.ParentFieldName = "id_linea_padre"

        'Se asignan los tamanhos de las columnas
        trl_familias.Columns(0).Width = 280
        trl_familias.Columns(1).Width = 60
        trl_familias.Columns(2).Width = 60
        trl_familias.Columns(3).Width = 75

        'Nombres de columnas
        trl_familias.Columns(0).Caption = "Descripcion"
        trl_familias.Columns(1).Caption = "Codigo"
        trl_familias.Columns(2).Caption = "Nivel"
        trl_familias.Columns(3).Caption = "Ultimo Nivel"

        'Se bloquean las columnas para que no sean editables
        trl_familias.Columns("descripcion").OptionsColumn.ReadOnly = True
        trl_familias.Columns("descripcion").OptionsColumn.AllowEdit = False
        trl_familias.Columns("codigo").OptionsColumn.ReadOnly = True
        trl_familias.Columns("codigo").OptionsColumn.AllowEdit = False
        trl_familias.Columns("nivel").OptionsColumn.ReadOnly = True
        trl_familias.Columns("nivel").OptionsColumn.AllowEdit = False
        trl_familias.Columns("ultimo_nivel").OptionsColumn.ReadOnly = True
        trl_familias.Columns("ultimo_nivel").OptionsColumn.AllowEdit = False
    End Sub

    Private Function obtener_identificador(codigo As String) As Integer
        Dim dt As New DataTable
        Dim id As Integer
        dt = familias.listar("select identificador from familias where codigo = '" & codigo & "'")

        If dt.Rows().Count() > 0 Then
            id = CInt(dt.Rows(0).Item(0).ToString)
        Else
            util.mensajes("Identificador de familia no obtenido", "<Familias de productos>", "WAR")
            id = 0
        End If

        Return id
    End Function

    Private Sub enviar_codigo(ByVal codigo As String)
        If FRM_ACTIVO = "FrmExistenciaStockItems" Then
            FrmExistenciaStockItems.obtener_familia_articulo(obtener_identificador(codigo), codigo)
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_vta_detalle_ventas_por_familia" Then
            frm_rpt_vta_detalle_ventas_por_familia.obtener_familia(obtener_identificador(codigo))
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_compras_por_familia" Then
            frm_rpt_compras_por_familia.obtener_familia(obtener_identificador(codigo))
            Close()
        End If
        If FRM_ACTIVO = "frm_rpt_pedidos_recibidos_familia" Then
            frm_rpt_pedidos_recibidos_familia.obtener_familia(obtener_identificador(codigo))
            Close()
        End If
        If FRM_ACTIVO = "frm_stock_valorizado" Then
            frm_stock_valorizado.obtener_familia_articulo(obtener_identificador(codigo))
            Close()
        End If
    End Sub
    Private Sub trl_familias_DoubleClick(sender As Object, e As EventArgs) Handles trl_familias.DoubleClick
        enviar_codigo(CStr(trl_familias.FocusedNode(1)))
    End Sub

    Private Sub trl_familias_KeyDown(sender As Object, e As KeyEventArgs) Handles trl_familias.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviar_codigo(CStr(trl_familias.FocusedNode(1)))
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class