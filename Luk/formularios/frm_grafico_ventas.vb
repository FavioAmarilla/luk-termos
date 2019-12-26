Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Public Class frm_grafico_ventas
    Dim dt As New DataTable
    Dim func_ventas As New func_ventas
    Dim util As New utilidades


    Private Sub frm_grafico_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_ventas()
    End Sub

    Sub get_ventas()
        Try
            dt = func_ventas.consultar("select x.numero, x.mes as fecha_venta, sum(x.total_venta) as total_venta from (
		                                select extract(month from fecha_venta) as numero, 
		                                CASE 
		                                    WHEN extract(month from fecha_venta)=1 THEN 'ENERO'
		                                    WHEN extract(month from fecha_venta)=2 THEN 'FEBRERO'
		                                    WHEN extract(month from fecha_venta)=3 THEN 'MARZO'
		                                    WHEN extract(month from fecha_venta)=4 THEN 'ABRIL'
		                                    WHEN extract(month from fecha_venta)=5 THEN 'MAYO'
		                                    WHEN extract(month from fecha_venta)=6 THEN 'JUNIO'
		                                    WHEN extract(month from fecha_venta)=7 THEN 'JULIO'
		                                    WHEN extract(month from fecha_venta)=8 THEN 'AGOSTO'
		                                    WHEN extract(month from fecha_venta)=9 THEN 'SETIEMBRE'
		                                    WHEN extract(month from fecha_venta)=10 THEN 'OCTUBRE'
		                                    WHEN extract(month from fecha_venta)=11 THEN 'NOVIEMBRE'
		                                    WHEN extract(month from fecha_venta)=12 THEN 'DICIEMBRE'
		                                    ELSE 'other'
	                                        END as mes, total_venta from ventas where coalesce(anulado, false)=false
		                            ) as x
		                            group by x.numero, x.mes order by x.numero asc limit 6")

            If dt.Rows.Count > 0 Then
                ChartControl1.Series.Clear()


                Dim series_vta = New Series("Ventas", ViewType.Bar)
                series_vta.ToolTipPointPattern = "{V:#,#}"

                For Each dr As DataRow In dt.Rows
                    series_vta.Points.Add(New SeriesPoint(dr("fecha_venta").ToString, dr("total_venta").ToString))
                Next

                ChartControl1.Series.Add(series_vta)
                ChartControl1.Legend.Visibility = DefaultBoolean.False

                series_vta.ArgumentScaleType = ScaleType.Auto
                series_vta.ValueScaleType = ScaleType.Numerical

                'Formato miles Axis X
                Dim diagrama As XYDiagram = TryCast(ChartControl1.Diagram, XYDiagram)
                diagrama.AxisY.Label.TextPattern = "{V: #,#}"

                'Leyenda de barras
                Dim label As SideBySideBarSeriesLabel = TryCast(series_vta.Label, SideBySideBarSeriesLabel)
                label.Position = BarSeriesLabelPosition.Top
                label.TextPattern = "{V: #,#}"
                label.ShowForZeroValues = True
                label.Border.Visibility = False


                series_vta.LabelsVisibility = DefaultBoolean.True
                series_vta.ToolTipPointPattern = "{V: #,#}"

                'Multicolor 
                Dim SideBySideBarSeriesView1 As SideBySideBarSeriesView = New SideBySideBarSeriesView()
                SideBySideBarSeriesView1.ColorEach = True
                ChartControl1.PaletteName = "Neblina"

                'Estilo de barras
                SideBySideBarSeriesView1.FillStyle.FillMode = FillMode.Hatch
                series_vta.View = SideBySideBarSeriesView1

                'Animacion
                Dim seriesView As SideBySideBarSeriesView = TryCast(series_vta.View, SideBySideBarSeriesView)

                If seriesView IsNot Nothing Then
                    seriesView.Animation = New BarGrowUpAnimation With {
                        .BeginTime = New TimeSpan(0, 0, 0, 0, 10),
                        .Duration = New TimeSpan(0, 0, 0, 2, 0),
                        .PointDelay = New TimeSpan(0, 0, 0, 0, 300),
                        .EasingFunction = New LinearEasingFunction With {
                            .EasingMode = EasingMode.[In]
                        },
                        .PointOrder = PointAnimationOrder.Inverted
                    }
                End If
                ChartControl1.Animate()


                'Toltip
                series_vta.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
                series_vta.ToolTipPointPattern = "{V:#,#}"


            End If
        Catch ex As Exception
            util.mensajes(ex.Message, "", "ERR")
        End Try
    End Sub

End Class