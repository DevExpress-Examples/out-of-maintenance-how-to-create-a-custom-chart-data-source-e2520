<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581749/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2520)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomChartDataSource.cs](./CS/CustomChartDataSourceWin/CustomChartDataSource.cs) (VB: [CustomChartDataSource.vb](./VB/CustomChartDataSourceWin/CustomChartDataSource.vb))
* [Form1.cs](./CS/CustomChartDataSourceWin/Form1.cs) (VB: [Form1.vb](./VB/CustomChartDataSourceWin/Form1.vb))
<!-- default file list end -->
# How to: Create a custom chart data source


<p>Sometimes it is necessary to change cell values using custom summary calculation rules. When the custom summary depends on values in other cells, the only possible way to perform a custom calculation is to do it within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic">PivotGridControl.CustomCellDisplayText</a> or <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic">PivotGridControl.CustomCelllValue</a> event handlers. However, customized values are not available in the chart data source. This example demonstrates how to create your own chart data source that takes into account values provided within the CustomCellValue event.</p>

<br/>


