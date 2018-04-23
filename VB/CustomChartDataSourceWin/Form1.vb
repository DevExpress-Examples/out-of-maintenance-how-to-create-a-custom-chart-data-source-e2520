Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DXSample
Imports DevExpress.XtraPivotGrid
Imports System.Collections.Generic
Imports System.Collections

Namespace CustomChartDataSourceWin
	Partial Public Class Form1
		Inherits Form
		Private chartDataSource As CustomChartDataSource

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
			chartDataSource = New CustomChartDataSource(salesPersonPivot)
			salesPersonChart.DataSource = chartDataSource
		End Sub

		Private Sub OfFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			salesPersonChart.DataSource = Nothing
			chartDataSource.Dispose()
		End Sub

		' some custom logic to demonstrate the approach in action
		Private Sub OnPivotCustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs) Handles salesPersonPivot.CustomCellValue
            If e.DataField Is fieldExtendedPriceUnbound Then
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim value As Decimal = 0
                Dim columnFieldValues As New Dictionary(Of PivotGridField, Object)()
                Dim columnFields() As PivotGridField = e.GetColumnFields()
                For Each field As PivotGridField In columnFields
                    columnFieldValues(field) = e.GetFieldValue(field)
                Next field
                For i As Integer = 0 To ds.RowCount - 1
                    Dim skip As Boolean = False
                    For Each field As PivotGridField In columnFields
                        If (Not Comparer.Equals(ds(i)(field), columnFieldValues(field))) Then
                            skip = True
                            Exit For
                        End If
                    Next field
                    If skip Then
                        Continue For
                    End If
                    Dim v1 As Decimal = Convert.ToDecimal(ds(i)(e.DataField))
                    value += v1
                Next i
                e.Value = value
            End If
		End Sub
	End Class
End Namespace