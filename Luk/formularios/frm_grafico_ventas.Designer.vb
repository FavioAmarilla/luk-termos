<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_grafico_ventas
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim KeyColorColorizer1 As DevExpress.XtraCharts.KeyColorColorizer = New DevExpress.XtraCharts.KeyColorColorizer()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim BarSlideAnimation1 As DevExpress.XtraCharts.BarSlideAnimation = New DevExpress.XtraCharts.BarSlideAnimation()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dts_ventas = New Luk.dts_ventas()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Dts_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 13)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 406)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.ChartControl1)
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 15)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(758, 376)
        Me.PanelControl3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(234, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ventas de los ultimos 6 meses"
        '
        'Dts_ventas
        '
        Me.Dts_ventas.DataSetName = "dts_ventas"
        Me.Dts_ventas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "In A Fog"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Location = New System.Drawing.Point(20, 60)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "dt_ventas.fecha_venta"
        Series1.Colorizer = KeyColorColorizer1
        Series1.Name = "Series 1"
        Series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
        Series1.ToolTipPointPattern = "{V:#,#}"
        SideBySideBarSeriesView1.Animation = BarSlideAnimation1
        SideBySideBarSeriesView1.ColorEach = True
        SideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(719, 301)
        Me.ChartControl1.TabIndex = 2
        '
        'frm_grafico_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 432)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_grafico_ventas"
        Me.Text = "Grafico de Ventas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.Dts_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Dts_ventas As dts_ventas
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
