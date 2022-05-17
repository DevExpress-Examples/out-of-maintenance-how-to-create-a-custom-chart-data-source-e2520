Imports System
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraPivotGrid
Imports System.Collections.Generic

Namespace DXSample

    Public Class CustomChartDataSource
        Implements IBindingList, ITypedList, IDisposable

        Private fPivot As PivotGridControl

        Private fData As List(Of Object())

        Public Sub New(ByVal source As PivotGridControl)
            fPivot = source
            CreateChartData()
            AddHandler fPivot.CellSelectionChanged, AddressOf OnPivotCellSelectionChanged
        End Sub

        Private Sub OnPivotCellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            CreateChartData()
            RaiseListChanged()
        End Sub

        Private Sub CreateChartData()
            fData = If(fPivot.OptionsSelection.MultiSelect AndAlso fPivot.OptionsChartDataSource.SelectionOnly, CreateChartDataFromMultiselection(), CreateChartDataFromSelection())
        End Sub

        Private Function CreateChartDataFromSelection() As List(Of Object())
            Dim result As List(Of Object()) = New List(Of Object())()
            Dim selection As Rectangle = If(fPivot.OptionsChartDataSource.SelectionOnly, fPivot.Cells.Selection, New Rectangle(0, 0, fPivot.Cells.ColumnCount, fPivot.Cells.RowCount))
            For col As Integer = selection.Left To selection.Right - 1
                For row As Integer = selection.Top To selection.Bottom - 1
                    Dim data As Object() = GetDataFromCell(fPivot.Cells.GetCellInfo(col, row))
                    If data IsNot Nothing Then result.Add(data)
                Next
            Next

            Return result
        End Function

        Private Function CreateChartDataFromMultiselection() As List(Of Object())
            Dim result As List(Of Object()) = New List(Of Object())()
            For Each cell As Point In fPivot.Cells.MultiSelection.SelectedCells
                Dim data As Object() = GetDataFromCell(fPivot.Cells.GetCellInfo(cell.X, cell.Y))
                If data IsNot Nothing Then result.Add(data)
            Next

            Return result
        End Function

        Private Function GetDataFromCell(ByVal cell As PivotCellEventArgs) As Object()
            If SkipCellValue(cell) Then Return Nothing
            Dim result As Object() = New Object(2) {}
            result(0) = String.Concat(If(fPivot.OptionsChartDataSource.ProvideDataByColumns, GetFieldValue(cell, False), GetFieldValue(cell, True)), If(fPivot.GetFieldsByArea(PivotArea.DataArea).Count > 1, String.Concat(" | ", cell.DataField.Caption), String.Empty))
            result(1) = If(fPivot.OptionsChartDataSource.ProvideDataByColumns, GetFieldValue(cell, True), GetFieldValue(cell, False))
            result(2) = Convert.ToDecimal(cell.Value)
            Return result
        End Function

        Private Shared Function GetFieldValue(ByVal cell As PivotCellEventArgs, ByVal column As Boolean) As String
            Dim fields As PivotGridField() = If(column, cell.GetColumnFields(), cell.GetRowFields())
            Dim result As StringBuilder = New StringBuilder()
            For Each field As PivotGridField In fields
                result.AppendFormat("{0} | ", cell.GetFieldValue(field))
            Next

            If result.Length > 3 Then result.Remove(result.Length - 3, 3)
            If column Then
                Select Case cell.ColumnValueType
                    Case PivotGridValueType.CustomTotal
                        Return result.AppendFormat(" Total ({0})", cell.ColumnCustomTotal.SummaryType).ToString()
                    Case PivotGridValueType.GrandTotal
                        Return "Grand Total"
                    Case PivotGridValueType.Total
                        Return result.Append(" Total").ToString()
                End Select
            Else
                Select Case cell.RowValueType
                    Case PivotGridValueType.CustomTotal
                        Return result.AppendFormat(" Total ({0})", cell.RowCustomTotal.SummaryType).ToString()
                    Case PivotGridValueType.GrandTotal
                        Return "Grand Total"
                    Case PivotGridValueType.Total
                        Return result.Append(" Total").ToString()
                End Select
            End If

            Return result.ToString()
        End Function

        Private Function SkipCellValue(ByVal cell As PivotCellEventArgs) As Boolean
            Return Not fPivot.OptionsChartDataSource.ProvideColumnCustomTotals AndAlso cell.ColumnValueType = PivotGridValueType.CustomTotal OrElse Not fPivot.OptionsChartDataSource.ProvideColumnGrandTotals AndAlso cell.ColumnValueType = PivotGridValueType.GrandTotal OrElse Not fPivot.OptionsChartDataSource.ProvideColumnTotals AndAlso cell.ColumnValueType = PivotGridValueType.Total OrElse Not fPivot.OptionsChartDataSource.ProvideRowCustomTotals AndAlso cell.RowValueType = PivotGridValueType.CustomTotal OrElse Not fPivot.OptionsChartDataSource.ProvideRowGrandTotals AndAlso cell.RowValueType = PivotGridValueType.GrandTotal OrElse Not fPivot.OptionsChartDataSource.ProvideRowTotals AndAlso cell.RowValueType = PivotGridValueType.Total
        End Function

#Region "IBindingList Members"
        Private Sub AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Function AddNew() As Object Implements IBindingList.AddNew
            Throw New Exception("The method or operation is not implemented.")
        End Function

        Private ReadOnly Property AllowEdit As Boolean Implements IBindingList.AllowEdit
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property AllowNew As Boolean Implements IBindingList.AllowNew
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property AllowRemove As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property

        Private Sub ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New Exception("The method or operation is not implemented.")
        End Function

        Private ReadOnly Property IsSorted As Boolean Implements IBindingList.IsSorted
            Get
                Throw New Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private fListChanged As ListChangedEventHandler

        Protected Sub RaiseListChanged()
            If fListChanged IsNot Nothing Then fListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))
        End Sub

        Private Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
                fListChanged = [Delegate].Combine(fListChanged, value)
            End AddHandler

            RemoveHandler(ByVal value As ListChangedEventHandler)
                fListChanged = [Delegate].Remove(fListChanged, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ListChangedEventArgs)
                fListChanged ?(sender, e)
            End RaiseEvent
        End Event

        Private Sub RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Sub RemoveSort() Implements IBindingList.RemoveSort
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property SortDirection As ListSortDirection Implements IBindingList.SortDirection
            Get
                Throw New Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property SortProperty As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Throw New Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property SupportsChangeNotification As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property SupportsSearching As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property SupportsSorting As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property

#End Region
#Region "IList Members"
        Private Function Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New Exception("The method or operation is not implemented.")
        End Function

        Private Sub Clear() Implements IList.Clear
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Throw New Exception("The method or operation is not implemented.")
        End Function

        Private Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Throw New Exception("The method or operation is not implemented.")
        End Function

        Private Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property IsFixedSize As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IsReadOnly As Boolean Implements IList.IsReadOnly
            Get
                Return True
            End Get
        End Property

        Private Sub Remove(ByVal value As Object) Implements IList.Remove
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private Property Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return fData(index)
            End Get

            Set(ByVal value As Object)
                Throw New Exception("The method or operation is not implemented.")
            End Set
        End Property

#End Region
#Region "ICollection Members"
        Private Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Throw New Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property Count As Integer Implements ICollection.Count
            Get
                Return fData.Count
            End Get
        End Property

        Private ReadOnly Property IsSynchronized As Boolean Implements ICollection.IsSynchronized
            Get
                Throw New Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property SyncRoot As Object Implements ICollection.SyncRoot
            Get
                Throw New Exception("The method or operation is not implemented.")
            End Get
        End Property

#End Region
#Region "IEnumerable Members"
        Private Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return New CustomChartDataSourceEnumerator(fData)
        End Function

#End Region
#Region "ITypedList Members"
        Private Function GetItemProperties(ByVal listAccessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Dim properties As List(Of CustomChartDataSourcePropertyDescriptor) = New List(Of CustomChartDataSourcePropertyDescriptor)()
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Series))
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Arguments))
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Values))
            Return New PropertyDescriptorCollection(properties.ToArray())
        End Function

        Private Function GetListName(ByVal listAccessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
            Throw New Exception("The method or operation is not implemented.")
        End Function

#End Region
#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            If fPivot IsNot Nothing Then
                RemoveHandler fPivot.CellSelectionChanged, AddressOf OnPivotCellSelectionChanged
                fPivot = Nothing
            End If
        End Sub

#End Region
        Public Class CustomChartDataSourceEnumerator
            Implements IEnumerator

            Private fData As List(Of Object())

            Private fPosition As Integer = -1

            Friend Sub New(ByVal data As List(Of Object()))
                fData = data
            End Sub

#Region "IEnumerator Members"
            Private ReadOnly Property Current As Object Implements IEnumerator.Current
                Get
                    If fPosition < 0 OrElse fPosition >= fData.Count Then Return Nothing
                    Return fData(fPosition)
                End Get
            End Property

            Private Function MoveNext() As Boolean Implements IEnumerator.MoveNext
                If fPosition >= fData.Count Then Return False
                fPosition += 1
                Return True
            End Function

            Private Sub Reset() Implements IEnumerator.Reset
                fPosition = -1
            End Sub
#End Region
        End Class

        Public Class CustomChartDataSourcePropertyDescriptor
            Inherits PropertyDescriptor

            Private fPropertyType As CustomChartDataSourceProperty

            Public Sub New(ByVal propertyType As CustomChartDataSourceProperty)
                MyBase.New(propertyType.ToString(), Nothing)
                fPropertyType = propertyType
            End Sub

            Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
                Return False
            End Function

            Public Overrides ReadOnly Property ComponentType As Type
                Get
                    Return GetType(Object())
                End Get
            End Property

            Public Overrides Function GetValue(ByVal component As Object) As Object
                Dim source As Object() = TryCast(component, Object())
                If source Is Nothing OrElse source.Length <> 3 Then Throw New ArgumentException("The array of three values expected")
                Return source(CInt(fPropertyType))
            End Function

            Public Overrides ReadOnly Property IsReadOnly As Boolean
                Get
                    Return True
                End Get
            End Property

            Public Overrides ReadOnly Property PropertyType As Type
                Get
                    Return If(fPropertyType = CustomChartDataSourceProperty.Values, GetType(Decimal), GetType(String))
                End Get
            End Property

            Public Overrides Sub ResetValue(ByVal component As Object)
                Throw New Exception("The method or operation is not implemented.")
            End Sub

            Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
                Throw New Exception("The method or operation is not implemented.")
            End Sub

            Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
                Throw New Exception("The method or operation is not implemented.")
            End Function
        End Class

        Public Enum CustomChartDataSourceProperty
            Series
            Arguments
            Values
        End Enum
    End Class
End Namespace
