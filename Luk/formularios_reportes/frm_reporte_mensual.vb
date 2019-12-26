Imports DevExpress.XtraReports.UI

Public Class frm_reporte_mensual

    Private func As New func_ventas
    Private util As New utilidades
    Private dt_rpt_mensual As New DataTable
    Private dt_meses As New DataTable
    Private Const TITULO_MSJ As String = "<Reporte Mensual>"
    Private FECHA As String = ""

    Private Sub frm_reporte_mensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_meses()
        cld_desde.Visible = False
        cld_hasta.Visible = False
        chk_mes.Checked = True
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub

    Private Sub limpiar()
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        cbo_meses.SelectedIndex = -1
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""
        cld_desde.Visible = False
        cld_hasta.Visible = False
        grid_conceptos.DataSource = Nothing
    End Sub

    Private Sub crear_cursor()
        dt_rpt_mensual = New DataTable
        dt_rpt_mensual.Columns.Add("concepto")
        dt_rpt_mensual.Columns.Add("total")
        dt_rpt_mensual.Columns.Add("cantidad", GetType(Double))

        grid_conceptos.DataSource = dt_rpt_mensual
    End Sub

    Public Sub agregar_concepto(concepto As String, total As Integer, cantidad As Double)
        Dim newRow As DataRow = (TryCast(grid_conceptos.DataSource, DataTable)).NewRow()
        newRow("concepto") = concepto
        newRow("total") = total
        newRow("cantidad") = cantidad
        TryCast(grid_conceptos.DataSource, DataTable).Rows.Add(newRow)
        grid_conceptos.RefreshDataSource()

        eliminar_filas_vacias()
    End Sub

    Private Sub eliminar_filas_vacias()
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_rpt_mensual.Rows()
            If IsDBNull(dr("concepto")) Then
                listaux.Add(dr)
            End If
        Next

        For Each dr As DataRow In listaux
            dt_rpt_mensual.Rows.Remove(dr)
        Next
    End Sub

    Private Sub obtener_meses()
        dt_meses = func.consultar("SELECT nombre, numero FROM meses ORDER BY numero ASC")

        If dt_meses.Rows.Count > 0 Then
            cbo_meses.Properties.Items.Clear()
            For Each dr As DataRow In dt_meses.Rows
                cbo_meses.Properties.Items.Add(dr("nombre"))
            Next
            cbo_meses.SelectedIndex = 0
        Else
            util.mensajes("No se encontraron meses en Base de Datos", TITULO_MSJ, "ERR")
        End If
    End Sub

    Public Sub obtener_sucursal(id As String)
        Dim dt As New DataTable
        dt = func.consultar("SELECT id_sucursal, nombre FROM sucursales WHERE id_sucursal= " + id)

        If dt.Rows().Count() <> 0 Then
            txt_id_sucursal.Text = CStr(dt.Rows(0).Item(0))
            txt_sucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Private Function consultas_compras() As Boolean
        Dim dt As New DataTable
        Dim compra As New func_compras
        Dim condicion As String = ""

        If chk_fechas.Checked Then
            If txt_fecha_desde.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Desde", "<Reporte Mensual>", "WAR")
                txt_fecha_desde.Focus()
                Return False
            End If

            If txt_fecha_hasta.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Hasta", "<Reporte Mensual>", "WAR")
                txt_fecha_hasta.Focus()
                Return False
            End If

            condicion = " AND TO_CHAR(fecha_compra,'dd/MM/yyyy') >='" + txt_fecha_desde.Text + "' AND TO_CHAR(fecha_compra,'dd/MM/yyyy') <='" + txt_fecha_hasta.Text + "'"
        End If

        If chk_mes.Checked Then
            If txt_anho.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe ingresar Año", "<Reporte Mensual>", "WAR")
                txt_anho.Focus()
                Return False
            End If

            If cbo_meses.SelectedIndex < 0 Then
                util.mensajes("Debe seleccionar Mes", "<Reporte Mensual>", "WAR")
                cbo_meses.Focus()
                Return False
            End If

            Dim mes As Integer = CInt(dt_meses.Rows(cbo_meses.SelectedIndex).Item(1))
            Dim anho As Integer = CInt(txt_anho.Text)
            If mes < 10 Then
                FECHA = anho.ToString + "-" + "0" + mes.ToString
            Else
                FECHA = anho.ToString + "-" + mes.ToString
            End If

            condicion = " AND TO_CHAR(fecha_compra,'YYYY-MM')='" + FECHA + "' "
        End If

        dt = compra.consultar("Select tc.nombre As titulo, COALESCE(SUM(c.total_compra),0) As total, COALESCE(COUNT(c.id_compra),0) As cantidad
                                FROM compras c
                                INNER JOIN tipos_compra tc ON tc.id_tipo_compra = c.id_tipo_compra
                                WHERE c.id_sucursal = " + txt_id_sucursal.Text + "" + condicion +
                                " GROUP BY tc.nombre")
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'TOTAL BRUTO COMPRAS' AS titulo, COALESCE(SUM(c.total_compra),0), COALESCE(COUNT(c.id_compra),0) AS cantidad
                                From compras c
                                WHERE c.id_sucursal = " + txt_id_sucursal.Text + "" + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If

        Return True
    End Function

    Private Function consultas_ventas() As Boolean
        Dim dt As New DataTable
        Dim compra As New func_compras
        Dim condicion As String = ""

        If chk_fechas.Checked Then
            If txt_fecha_desde.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Desde", "<Reporte Mensual>", "WAR")
                txt_fecha_desde.Focus()
                Return False
            End If

            If txt_fecha_hasta.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Hasta", "<Reporte Mensual>", "WAR")
                txt_fecha_hasta.Focus()
                Return False
            End If

            condicion = " AND TO_CHAR(vta.fecha_venta,'dd/MM/yyyy') >='" + txt_fecha_desde.Text + "' AND TO_CHAR(vta.fecha_venta,'dd/MM/yyyy') <='" + txt_fecha_hasta.Text + "'"
        End If

        If chk_mes.Checked Then
            If txt_anho.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe ingresar Año", "<Reporte Mensual>", "WAR")
                txt_anho.Focus()
                Return False
            End If

            If cbo_meses.SelectedIndex < 0 Then
                util.mensajes("Debe seleccionar Mes", "<Reporte Mensual>", "WAR")
                cbo_meses.Focus()
                Return False
            End If

            Dim mes As Integer = CInt(dt_meses.Rows(cbo_meses.SelectedIndex).Item(1))
            Dim anho As Integer = CInt(txt_anho.Text)
            If mes < 10 Then
                FECHA = anho.ToString + "-" + "0" + mes.ToString
            Else
                FECHA = anho.ToString + "-" + mes.ToString
            End If

            condicion = " AND TO_CHAR(vta.fecha_venta,'YYYY-MM')='" + FECHA + "' "
        End If

        dt = compra.consultar("SELECT 'COSTO DE VENTAS' AS titulo, COALESCE(SUM(iv.costo_unitario),0), COALESCE(COUNT(iv.id_venta),0) AS cantidad
                                FROM items_venta iv
                                INNER JOIN ventas vta ON vta.id_venta = iv.id_venta
                                INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + "" + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If

        dt = compra.consultar("SELECT CONCAT('VENTA ','',cv.nombre) AS titulo, COALESCE(SUM(vta.total_venta), 0) AS total, COALESCE(COUNT(vta.id_venta), 0) AS cantidad
                                FROM ventas vta
                                INNER JOIN condiciones_venta cv ON cv.id_condicion = vta.id_condicion_venta
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + " " + condicion +
                                " GROUP BY cv.nombre")
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'VENTAS ANULADAS' AS titulo, COALESCE(SUM(total_venta), 0), COALESCE(COUNT(id_venta), 0) AS cantidad  
                                From ventas vta
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + " AND fecha_anulacion IS NOT NULL " + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'VENTAS NO ANULADAS' AS titulo, COALESCE(SUM(total_venta), 0), COALESCE(COUNT(id_venta), 0) AS cantidad  
                                From ventas vta
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + " " + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 
	                                CASE a.produccion_propia 
		                                WHEN TRUE THEN 'PRODUCCION PROPIA'
		                                WHEN FALSE THEN 'ART. COMPRADOS'
	                                END AS titulo, 
	                                COALESCE(SUM(iv.precio_venta),0) AS total,
	                                COALESCE(COUNT(iv.id_item_venta),0) AS cantidad
                                FROM items_venta iv
	                                INNER JOIN articulos a ON a.id_articulo = iv.id_articulo
	                                INNER JOIN ventas vta ON vta.id_venta = iv.id_venta
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + "" + condicion +
                                "GROUP BY 
                                    a.produccion_propia ")
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'VENTA BRUTA' AS titulo, COALESCE(SUM(total_venta), 0), COALESCE(COUNT(id_venta), 0) AS cantidad    
                               FROM ventas vta
                                WHERE vta.id_sucursal = " + txt_id_sucursal.Text + "" + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If

        Return True
    End Function

    Private Function consultas_liquidaciones() As Boolean
        Dim dt As New DataTable
        Dim compra As New func_compras
        Dim TOTAL_LIQUIDACION As Integer = 0
        Dim CANTI_LIQUIDACION As Double = 0
        Dim condicion As String = ""

        If chk_fechas.Checked Then
            If txt_fecha_desde.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Desde", "<Reporte Mensual>", "WAR")
                txt_fecha_desde.Focus()
                Return False
            End If

            If txt_fecha_hasta.Text = "  /  /" Then
                util.mensajes("Debe ingresar Fecha Hasta", "<Reporte Mensual>", "WAR")
                txt_fecha_hasta.Focus()
                Return False
            End If

            condicion = " TO_CHAR(fecha,'dd/MM/yyyy') >='" + txt_fecha_desde.Text + "' AND TO_CHAR(fecha,'dd/MM/yyyy') <='" + txt_fecha_hasta.Text + "'"
        End If

        If chk_mes.Checked Then
            If txt_anho.Text.Replace(" ", "") = "" Then
                util.mensajes("Debe ingresar Año", "<Reporte Mensual>", "WAR")
                txt_anho.Focus()
                Return False
            End If

            If cbo_meses.SelectedIndex < 0 Then
                util.mensajes("Debe seleccionar Mes", "<Reporte Mensual>", "WAR")
                cbo_meses.Focus()
                Return False
            End If

            Dim mes As Integer = CInt(dt_meses.Rows(cbo_meses.SelectedIndex).Item(1))
            Dim anho As Integer = CInt(txt_anho.Text)
            If mes < 10 Then
                FECHA = anho.ToString + "-" + "0" + mes.ToString
            Else
                FECHA = anho.ToString + "-" + mes.ToString
            End If

            condicion = " TO_CHAR(fecha,'YYYY-MM')='" + FECHA + "' "
        End If

        dt = compra.consultar("SELECT 'LIQUIDACION P/MANO OBRA' AS titulo, COALESCE(SUM(total_pagado), 0) AS total,
                                COALESCE(COUNT(lmo.id_liquidacion),0) AS cantidad
                                FROM liquidaciones_mano_obra lmo
                                INNER JOIN items_liquidacion_mano_obra ilmo ON ilmo.id_liquidacion = lmo.id_liquidacion
                                WHERE " + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    TOTAL_LIQUIDACION = CInt(dt.Rows(i).Item(1))
                    CANTI_LIQUIDACION = CDbl(dt.Rows(i).Item(2))
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), TOTAL_LIQUIDACION, CANTI_LIQUIDACION)
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'PAGO EXTRA P/MANO OBRA' AS titulo, COALESCE(SUM(ilmo.pago_extra), 0) AS total,
                                COALESCE(COUNT(lmo.id_liquidacion),0) AS cantidad
                                FROM liquidaciones_mano_obra lmo
                                INNER JOIN items_liquidacion_mano_obra ilmo ON ilmo.id_liquidacion = lmo.id_liquidacion
                                WHERE " + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), CInt(dt.Rows(i).Item(1)), CDbl(dt.Rows(i).Item(2)))
                End If
            Next
        End If


        dt = compra.consultar("SELECT 'PAGO DE COMISION P/VENTAS' AS titulo, COALESCE(SUM(lv.total_pagado), 0) AS total,
                                COALESCE(COUNT(lv.id_liquidacion),0) AS cantidad
                                FROM liquidaciones_vendedores lv
                                INNER JOIN items_liquidacion_vendedores ilv ON  ilv.id_liquidacion = lv.id_liquidacion
                                WHERE " + condicion)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If CInt(dt.Rows(i).Item(2)) > 0 Then
                    TOTAL_LIQUIDACION += CInt(dt.Rows(i).Item(1))
                    CANTI_LIQUIDACION += CDbl(dt.Rows(i).Item(2))
                    agregar_concepto(CStr(dt.Rows(i).Item(0)), TOTAL_LIQUIDACION, CANTI_LIQUIDACION)
                End If
            Next
        End If

        If CANTI_LIQUIDACION > 0 Then
            agregar_concepto("TOTAL LIQUIDACIONES PAGADAS", TOTAL_LIQUIDACION, CANTI_LIQUIDACION)
        End If

        Return True
    End Function

    Private Sub txt_sucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sucursal.KeyDown
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            Dim frm As New frm_vista_sucursales
            frm.FRM_ACTIVO = "frm_reporte_mensual"
            frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
            frm.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_sucursal.Text = "" Then
            Else
                If chk_mes.Checked Then
                    txt_anho.Focus()
                End If
                If chk_fechas.Checked Then
                    txt_fecha_desde.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txt_anho_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_anho.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_anho.Text.Replace(" ", "") = "" Then
                txt_anho.Text = Now.ToString("yyyy")
                cbo_meses.Focus()
            Else
                cbo_meses.Focus()
            End If
        End If
    End Sub

    Private Sub cbo_meses_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_meses.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_meses.SelectedIndex >= 0 Then
                btn_consultar.Focus()
            End If
        End If
    End Sub


    Private Sub btn_buscar_sucursal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sucursal.Click
        Dim frm As New frm_vista_sucursales
        frm.FRM_ACTIVO = "frm_reporte_mensual"
        frm.CONDICION_SQL = "WHERE id_empresa=" + CStr(frm_main.ID_EMPRESA)
        frm.Show()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        dt_rpt_mensual.Clear()
        grid_conceptos.DataSource = Nothing

        If txt_id_sucursal.Text.Replace(" ", "") = "" Then
            util.mensajes("Debe seleccionar Sucursal", TITULO_MSJ, "WAR")
            txt_sucursal.Focus()
            Return
        End If

        crear_cursor()

        If consultas_compras() = False Then
            Return
        End If
        If consultas_ventas() = False Then
            Return
        End If
        If consultas_liquidaciones() = False Then
            Return
        End If

        If GridView1.RowCount <= 0 Then
            txt_sucursal.Focus()
        Else
            btn_consultar.Focus()
        End If

        lbl_total_registros.Text = "Registros recuperados: " & GridView1.RowCount
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click

        If GridView1.RowCount <= 0 Then
            util.mensajes("El documento no contiene paginas", TITULO_MSJ, "WAR")
            Return
        End If
        Dim report As New rpt_resumen_mensual

        report.DataSource = grid_conceptos.DataSource

        If chk_mes.Checked Then
            report.Parameters("mes").Value = "Mes: " + cbo_meses.SelectedItem.ToString
            report.Parameters("anho").Value = "Año: " + CStr(CInt(txt_anho.Text))
        End If

        If chk_fechas.Checked Then
            report.Parameters("mes").Value = "Fecha desde: " + txt_fecha_desde.Text
            report.Parameters("anho").Value = "Fecha hasta: " + txt_fecha_hasta.Text
        End If

        report.Parameters("sucursal").Value = "Sucursal: " + txt_sucursal.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + frm_main.LOGIN_USER + "   Fecha Imp.: " + util.fecha

        report.Parameters("sucursal").Visible = False
        report.Parameters("mes").Visible = False
        report.Parameters("anho").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub cld_desde_DoubleClick(sender As Object, e As EventArgs) Handles cld_desde.DoubleClick
        txt_fecha_desde.Text = cld_desde.DateTime.ToString
        txt_fecha_desde.Focus()
        cld_desde.Visible = False
    End Sub

    Private Sub cld_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_desde.Text = cld_desde.DateTime.ToString
            txt_fecha_desde.Focus()
            cld_desde.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_desde.Visible = False
            txt_fecha_desde.Focus()
        End If
    End Sub

    Private Sub cld_hasta_DoubleClick(sender As Object, e As EventArgs) Handles cld_hasta.DoubleClick
        txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
        txt_fecha_hasta.Focus()
        cld_hasta.Visible = False
    End Sub

    Private Sub cld_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cld_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fecha_hasta.Text = cld_hasta.DateTime.ToString
            txt_fecha_hasta.Focus()
            cld_hasta.Visible = False
        End If
        If e.KeyCode = Keys.Escape Then
            cld_hasta.Visible = False
            txt_fecha_hasta.Focus()
        End If
    End Sub

    Private Sub btn_calendar_desde_Click(sender As Object, e As EventArgs) Handles btn_cal_desde.Click
        cld_desde.Visible = True
        cld_desde.Focus()
    End Sub

    Private Sub btn_calendar_hasta_Click(sender As Object, e As EventArgs) Handles btn_cld_hasta.Click
        cld_hasta.Visible = True
        cld_hasta.Focus()
    End Sub

    Private Sub chk_fechas_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fechas.CheckedChanged
        limpiar()
        If chk_fechas.Checked Then
            txt_fecha_desde.Enabled = True
            txt_fecha_hasta.Enabled = True
            btn_cal_desde.Enabled = True
            btn_cld_hasta.Enabled = True

            txt_anho.Enabled = False
            cbo_meses.Enabled = False
            chk_mes.Checked = False
        Else
            txt_fecha_desde.Enabled = False
            txt_fecha_hasta.Enabled = False
            btn_cal_desde.Enabled = False
            btn_cld_hasta.Enabled = False

            txt_anho.Enabled = True
            cbo_meses.Enabled = True
        End If
    End Sub

    Private Sub chk_mes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mes.CheckedChanged
        limpiar()
        If chk_mes.Checked Then
            txt_fecha_desde.Enabled = False
            txt_fecha_hasta.Enabled = False
            btn_cal_desde.Enabled = False
            btn_cld_hasta.Enabled = False

            txt_anho.Enabled = True
            cbo_meses.Enabled = True
            chk_fechas.Checked = False
        Else
            txt_fecha_desde.Enabled = True
            txt_fecha_hasta.Enabled = True
            btn_cal_desde.Enabled = True
            btn_cld_hasta.Enabled = True

            txt_anho.Enabled = False
            cbo_meses.Enabled = False
        End If
    End Sub

    Private Sub chk_fechas_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_fechas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_fechas.Checked Then
                txt_sucursal.Focus()
            Else
                chk_mes.Focus()
            End If
        End If
    End Sub

    Private Sub chk_mes_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_mes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_mes.Checked Then
                txt_sucursal.Focus()
            Else
                chk_fechas.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_desde_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_desde.KeyDown
        If e.KeyCode = Keys.Space Then
            cld_desde.Visible = True
            cld_desde.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_desde.Text = "  /  /" Then
            Else
                txt_fecha_hasta.Focus()
            End If
        End If
    End Sub

    Private Sub txt_fecha_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fecha_hasta.KeyDown
        If e.KeyCode = Keys.Space Then
            cld_hasta.Visible = True
            cld_hasta.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_fecha_hasta.Text = "  /  /" Then
            Else
                btn_consultar.Focus()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        chk_fechas.Checked = False
        chk_mes.Checked = False
        txt_id_sucursal.Text = ""
        txt_sucursal.Text = ""
        txt_anho.Text = ""
        cbo_meses.SelectedIndex = -1
        txt_fecha_desde.Text = ""
        txt_fecha_hasta.Text = ""

        grid_conceptos.DataSource = Nothing
        lbl_total_registros.Text = "Registros recuperados: 0"
        txt_sucursal.Focus()
    End Sub
End Class