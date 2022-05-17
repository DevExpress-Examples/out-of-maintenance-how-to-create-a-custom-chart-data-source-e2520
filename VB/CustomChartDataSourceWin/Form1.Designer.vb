Namespace CustomChartDataSourceWin
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim ExpressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.salesPersonPivot = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPriceUnbound = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonChart = New DevExpress.XtraCharts.ChartControl()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.salesPersonPivot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.salesPersonChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            '
            'splitContainerControl1.Panel1
            '
            Me.splitContainerControl1.Panel1.Controls.Add(Me.salesPersonPivot)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            '
            'splitContainerControl1.Panel2
            '
            Me.splitContainerControl1.Panel2.Controls.Add(Me.salesPersonChart)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dataGridView1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1235, 747)
            Me.splitContainerControl1.SplitterPosition = 317
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'salesPersonPivot
            '
            Me.salesPersonPivot.DataSource = Me.salesPersonBindingSource
            Me.salesPersonPivot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.salesPersonPivot.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName1, Me.fieldYear, Me.fieldExtendedPriceUnbound, Me.fieldExtendedPrice1, Me.fieldSalesPerson1, Me.fieldQuarter})
            Me.salesPersonPivot.Location = New System.Drawing.Point(0, 0)
            Me.salesPersonPivot.Name = "salesPersonPivot"
            Me.salesPersonPivot.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.salesPersonPivot.Size = New System.Drawing.Size(1235, 317)
            Me.salesPersonPivot.TabIndex = 0
            '
            'salesPersonBindingSource
            '
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'fieldCategoryName1
            '
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            DataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName1.DataBinding = DataSourceColumnBinding1
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            '
            'fieldYear
            '
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            DataSourceColumnBinding2.ColumnName = "OrderDate"
            DataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = DataSourceColumnBinding2
            Me.fieldYear.Name = "fieldYear"
            '
            'fieldExtendedPriceUnbound
            '
            Me.fieldExtendedPriceUnbound.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPriceUnbound.AreaIndex = 1
            Me.fieldExtendedPriceUnbound.Caption = "Extended Price Unbound"
            ExpressionDataBinding1.Expression = "ToDecimal([Extended Price])"
            Me.fieldExtendedPriceUnbound.DataBinding = ExpressionDataBinding1
            Me.fieldExtendedPriceUnbound.Name = "fieldExtendedPriceUnbound"
            '
            'fieldExtendedPrice1
            '
            Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.Caption = "Extended Price"
            DataSourceColumnBinding3.ColumnName = "Extended Price"
            Me.fieldExtendedPrice1.DataBinding = DataSourceColumnBinding3
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            '
            'fieldSalesPerson1
            '
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson1.AreaIndex = 1
            Me.fieldSalesPerson1.Caption = "Sales Person"
            DataSourceColumnBinding4.ColumnName = "Sales Person"
            Me.fieldSalesPerson1.DataBinding = DataSourceColumnBinding4
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            '
            'fieldQuarter
            '
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            DataSourceColumnBinding5.ColumnName = "OrderDate"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.DataBinding = DataSourceColumnBinding5
            Me.fieldQuarter.Name = "fieldQuarter"
            '
            'salesPersonChart
            '
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.salesPersonChart.Diagram = XyDiagram1
            Me.salesPersonChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.salesPersonChart.Location = New System.Drawing.Point(0, 0)
            Me.salesPersonChart.Name = "salesPersonChart"
            Me.salesPersonChart.SeriesDataMember = "Series"
            Me.salesPersonChart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.salesPersonChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.salesPersonChart.SeriesTemplate.Label = SideBySideBarSeriesLabel1
            Me.salesPersonChart.SeriesTemplate.SeriesDataMember = "Series"
            Me.salesPersonChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.salesPersonChart.Size = New System.Drawing.Size(1235, 420)
            Me.salesPersonChart.TabIndex = 0
            '
            'dataGridView1
            '
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Location = New System.Drawing.Point(475, 36)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(576, 259)
            Me.dataGridView1.TabIndex = 1
            '
            'salesPersonTableAdapter
            '
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1235, 747)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.salesPersonPivot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.salesPersonChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents salesPersonPivot As DevExpress.XtraPivotGrid.PivotGridControl
        Private salesPersonChart As DevExpress.XtraCharts.ChartControl
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPriceUnbound As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
        Private dataGridView1 As System.Windows.Forms.DataGridView
    End Class
End Namespace

