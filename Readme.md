<!-- default file list -->
*Files to look at*:

* [CustomChartDataSource.cs](./CS/CustomChartDataSourceWin/CustomChartDataSource.cs) (VB: [CustomChartDataSource.vb](./VB/CustomChartDataSourceWin/CustomChartDataSource.vb))
* [Form1.cs](./CS/CustomChartDataSourceWin/Form1.cs) (VB: [Form1.vb](./VB/CustomChartDataSourceWin/Form1.vb))
<!-- default file list end -->
# How to: Create a custom chart data source


<p>Sometimes it is necessary to change cell values using custom summary calculation rules. When the custom summary depends on values in other cells, the only possible way to perform a custom calculation is to do it within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic">PivotGridControl.CustomCellDisplayText</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic">PivotGridControl.CustomCelllValue</a> event handlers. However, customized values are not available in the chart data source. This example demonstrates how to create your own chart data source that takes into account values provided within the CustomCellValue event.</p>


<h3>Description</h3>

<p>The PivotGridOptionsChartDataSourceBase.ChartDataVertical property is obsolete. The ProvideDataByColumns property is used instead.<br />
The PivotGridOptionsChartDataSourceBase.ShowColumnCustomTotals property is obsolete. The ProvideColumnCustomTotals property is used instead.</p><p>The PivotGridOptionsChartDataSourceBase.ShowColumnGrandTotals property is obsolete. The ProvideColumnGrandTotals property is used instead.</p><p>The PivotGridOptionsChartDataSourceBase.ShowColumnTotals property is obsolete. The ProvideColumnTotals property is used instead.</p><p>The PivotGridOptionsChartDataSourceBase.ShowRowCustomTotals property is obsolete. The ProvideRowCustomTotals property is used instead.</p><p>The PivotGridOptionsChartDataSourceBase.ShowRowGrandTotalsl property is obsolete. The ProvideRowGrandTotals property is used instead.<br />
The PivotGridOptionsChartDataSourceBase.ShowRowTotals property is obsolete. The ProvideRowTotals property is used instead.</p><br />


<br/>


