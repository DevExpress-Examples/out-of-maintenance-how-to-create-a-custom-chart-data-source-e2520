<!-- default file list -->
*Files to look at*:

* **[CustomChartDataSource.cs](./CS/CustomChartDataSourceWin/CustomChartDataSource.cs) (VB: [CustomChartDataSource.vb](./VB/CustomChartDataSourceWin/CustomChartDataSource.vb))**
* [Form1.cs](./CS/CustomChartDataSourceWin/Form1.cs) (VB: [Form1.vb](./VB/CustomChartDataSourceWin/Form1.vb))
<!-- default file list end -->
# How to: Create a custom chart data source


<p>Sometimes it is necessary to change cell values using custom summary calculation rules. When the custom summary depends on values in other cells, the only possible way to perform a custom calculation is to do it within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic">PivotGridControl.CustomCellDisplayText</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic">PivotGridControl.CustomCelllValue</a> event handlers. However, customized values are not available in the chart data source. This example demonstrates how to create your own chart data source that takes into account values provided within the CustomCellValue event.</p>

<br/>


