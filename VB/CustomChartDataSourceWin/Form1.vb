Imports System
Imports System.Windows.Forms
Imports DXSample
Imports DevExpress.XtraPivotGrid
Imports System.Collections.Generic

Namespace CustomChartDataSourceWin

    Public Partial Class Form1
        Inherits Form

        Private chartDataSource As CustomChartDataSource

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            salesPersonTableAdapter.Fill(nwindDataSet.SalesPerson)
            chartDataSource = New CustomChartDataSource(salesPersonPivot)
            salesPersonChart.DataSource = chartDataSource
        End Sub

        Private Sub OfFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            salesPersonChart.DataSource = Nothing
            chartDataSource.Dispose()
        End Sub

        ' some custom logic to demonstrate the approach in action
        Private Sub OnPivotCustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
            If e.DataField Is fieldExtendedPriceUnbound Then
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim value As Decimal = 0
                Dim columnFieldValues As Dictionary(Of PivotGridField, Object) = New Dictionary(Of PivotGridField, Object)()
                Dim columnFields As PivotGridField() = e.GetColumnFields()
                For Each field As PivotGridField In columnFields
                    columnFieldValues(field) = e.GetFieldValue(field)
                Next

                For i As Integer = 0 To ds.RowCount - 1
                    Dim skip As Boolean = False
                    For Each field As PivotGridField In columnFields
                        If Not Equals(ds(i)(field), columnFieldValues(field)) Then
                            skip = True
                            Exit For
                        End If
                    Next

                    If skip Then Continue For
                    Dim v1 As Decimal = Convert.ToDecimal(ds(i)(e.DataField))
                    value += v1
                Next

                e.Value = value
            End If
        End Sub
    End Class
End Namespace
