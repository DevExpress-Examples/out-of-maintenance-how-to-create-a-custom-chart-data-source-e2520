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
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.salesPersonPivot = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New CustomChartDataSourceWin.nwindDataSet()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPriceUnbound = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonChart = New DevExpress.XtraCharts.ChartControl()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.salesPersonTableAdapter = New CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.salesPersonPivot, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.salesPersonChart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.salesPersonPivot)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
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
            Me.salesPersonPivot.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldYear, Me.fieldExtendedPriceUnbound, Me.fieldExtendedPrice, Me.fieldSalesPerson, Me.fieldQuarter})
            Me.salesPersonPivot.Location = New System.Drawing.Point(0, 0)
            Me.salesPersonPivot.Name = "salesPersonPivot"
            Me.salesPersonPivot.Size = New System.Drawing.Size(1235, 317)
            Me.salesPersonPivot.TabIndex = 0
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
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldExtendedPriceUnbound
            ' 
            Me.fieldExtendedPriceUnbound.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPriceUnbound.AreaIndex = 1
            Me.fieldExtendedPriceUnbound.Caption = "Extended Price Unbound"
            Me.fieldExtendedPriceUnbound.Name = "fieldExtendedPriceUnbound"
            Me.fieldExtendedPriceUnbound.UnboundExpression = "[Extended Price]"
            Me.fieldExtendedPriceUnbound.UnboundFieldName = "fieldExtendedPriceUnbound"
            Me.fieldExtendedPriceUnbound.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 1
            Me.fieldSalesPerson.Caption = "Sales Person"
            Me.fieldSalesPerson.FieldName = "Sales Person"
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "OrderDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.RunningTotal = True
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
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
            Me.salesPersonChart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.salesPersonChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.salesPersonChart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.salesPersonChart.SeriesTemplate.SynchronizePointOptions = False
            Me.salesPersonChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.salesPersonChart.Size = New System.Drawing.Size(1235, 425)
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
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.salesPersonPivot, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.salesPersonChart, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents salesPersonPivot As DevExpress.XtraPivotGrid.PivotGridControl
        Private salesPersonChart As DevExpress.XtraCharts.ChartControl
        Private salesPersonTableAdapter As CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPriceUnbound As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField
        Private dataGridView1 As System.Windows.Forms.DataGridView
    End Class
End Namespace

