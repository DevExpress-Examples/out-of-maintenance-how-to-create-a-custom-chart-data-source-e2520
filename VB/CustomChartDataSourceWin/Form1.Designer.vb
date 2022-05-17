Namespace CustomChartDataSourceWin

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim expressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.salesPersonPivot = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New CustomChartDataSourceWin.nwindDataSet()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPriceUnbound = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonChart = New DevExpress.XtraCharts.ChartControl()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.salesPersonTableAdapter = New CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.salesPersonPivot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.salesPersonChart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            ' 
            ' splitContainerControl1.Panel1
            ' 
            Me.splitContainerControl1.Panel1.Controls.Add(Me.salesPersonPivot)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            ' 
            ' splitContainerControl1.Panel2
            ' 
            Me.splitContainerControl1.Panel2.Controls.Add(Me.salesPersonChart)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dataGridView1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1235, 747)
            Me.splitContainerControl1.SplitterPosition = 317
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' salesPersonPivot
            ' 
            Me.salesPersonPivot.DataSource = Me.salesPersonBindingSource
            Me.salesPersonPivot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.salesPersonPivot.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName1, Me.fieldYear, Me.fieldExtendedPriceUnbound, Me.fieldExtendedPrice1, Me.fieldSalesPerson1, Me.fieldQuarter})
            Me.salesPersonPivot.Location = New System.Drawing.Point(0, 0)
            Me.salesPersonPivot.Name = "salesPersonPivot"
            Me.salesPersonPivot.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.salesPersonPivot.Size = New System.Drawing.Size(1235, 317)
            Me.salesPersonPivot.TabIndex = 0
            AddHandler Me.salesPersonPivot.CustomCellValue, New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCellValueEventArgs)(AddressOf Me.OnPivotCustomCellValue)
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            dataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName1.DataBinding = dataSourceColumnBinding1
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "OrderDate"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding2
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldExtendedPriceUnbound
            ' 
            Me.fieldExtendedPriceUnbound.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPriceUnbound.AreaIndex = 1
            Me.fieldExtendedPriceUnbound.Caption = "Extended Price Unbound"
            expressionDataBinding1.Expression = "ToDecimal([Extended Price])"
            Me.fieldExtendedPriceUnbound.DataBinding = expressionDataBinding1
            Me.fieldExtendedPriceUnbound.Name = "fieldExtendedPriceUnbound"
            ' 
            ' fieldExtendedPrice1
            ' 
            Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.Caption = "Extended Price"
            dataSourceColumnBinding3.ColumnName = "Extended Price"
            Me.fieldExtendedPrice1.DataBinding = dataSourceColumnBinding3
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            ' 
            ' fieldSalesPerson1
            ' 
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson1.AreaIndex = 1
            Me.fieldSalesPerson1.Caption = "Sales Person"
            dataSourceColumnBinding4.ColumnName = "Sales Person"
            Me.fieldSalesPerson1.DataBinding = dataSourceColumnBinding4
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            dataSourceColumnBinding5.ColumnName = "OrderDate"
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.DataBinding = dataSourceColumnBinding5
            Me.fieldQuarter.Name = "fieldQuarter"
            ' 
            ' salesPersonChart
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.salesPersonChart.Diagram = xyDiagram1
            Me.salesPersonChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.salesPersonChart.Location = New System.Drawing.Point(0, 0)
            Me.salesPersonChart.Name = "salesPersonChart"
            Me.salesPersonChart.SeriesDataMember = "Series"
            Me.salesPersonChart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.salesPersonChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.salesPersonChart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.salesPersonChart.SeriesTemplate.SeriesDataMember = "Series"
            Me.salesPersonChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.salesPersonChart.Size = New System.Drawing.Size(1235, 420)
            Me.salesPersonChart.TabIndex = 0
            ' 
            ' dataGridView1
            ' 
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Location = New System.Drawing.Point(475, 36)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(576, 259)
            Me.dataGridView1.TabIndex = 1
            ' 
            ' salesPersonTableAdapter
            ' 
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1235, 747)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.OfFormClosing)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.salesPersonPivot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.salesPersonChart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private salesPersonPivot As DevExpress.XtraPivotGrid.PivotGridControl

        Private salesPersonChart As DevExpress.XtraCharts.ChartControl

        Private salesPersonTableAdapter As CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter

        Private nwindDataSet As CustomChartDataSourceWin.nwindDataSet

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
