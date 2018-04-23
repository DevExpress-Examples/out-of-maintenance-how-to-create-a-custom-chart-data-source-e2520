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
            Dim result As New List(Of Object())()
            Dim selection As Rectangle = If(fPivot.OptionsChartDataSource.SelectionOnly, fPivot.Cells.Selection, New Rectangle(0, 0, fPivot.Cells.ColumnCount, fPivot.Cells.RowCount))
            For col As Integer = selection.Left To selection.Right - 1
                For row As Integer = selection.Top To selection.Bottom - 1
                    Dim data() As Object = GetDataFromCell(fPivot.Cells.GetCellInfo(col, row))
                    If data IsNot Nothing Then
                        result.Add(data)
                    End If
                Next row
            Next col
            Return result
        End Function

        Private Function CreateChartDataFromMultiselection() As List(Of Object())
            Dim result As New List(Of Object())()
            For Each cell As Point In fPivot.Cells.MultiSelection.SelectedCells
                Dim data() As Object = GetDataFromCell(fPivot.Cells.GetCellInfo(cell.X, cell.Y))
                If data IsNot Nothing Then
                    result.Add(data)
                End If
            Next cell
            Return result
        End Function

        Private Function GetDataFromCell(ByVal cell As PivotCellEventArgs) As Object()
            If SkipCellValue(cell) Then
                Return Nothing
            End If
            Dim result(2) As Object
            result(0) = String.Concat(If(fPivot.OptionsChartDataSource.ProvideDataByColumns, GetFieldValue(cell, False), GetFieldValue(cell, True)),If(fPivot.GetFieldsByArea(PivotArea.DataArea).Count > 1, String.Concat(" | ", cell.DataField.Caption), String.Empty))
            result(1) = If(fPivot.OptionsChartDataSource.ProvideDataByColumns, GetFieldValue(cell, True), GetFieldValue(cell, False))
            result(2) = Convert.ToDecimal(cell.Value)
            Return result
        End Function

        Private Shared Function GetFieldValue(ByVal cell As PivotCellEventArgs, ByVal column As Boolean) As String
            Dim fields() As PivotGridField = If(column, cell.GetColumnFields(), cell.GetRowFields())
            Dim result As New StringBuilder()
            For Each field As PivotGridField In fields
                result.AppendFormat("{0} | ", cell.GetFieldValue(field))
            Next field
            If result.Length > 3 Then
                result.Remove(result.Length - 3, 3)
            End If
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
            Return ((Not fPivot.OptionsChartDataSource.ProvideColumnCustomTotals) AndAlso cell.ColumnValueType = PivotGridValueType.CustomTotal) OrElse ((Not fPivot.OptionsChartDataSource.ProvideColumnGrandTotals) AndAlso cell.ColumnValueType = PivotGridValueType.GrandTotal) OrElse ((Not fPivot.OptionsChartDataSource.ProvideColumnTotals) AndAlso cell.ColumnValueType = PivotGridValueType.Total) OrElse ((Not fPivot.OptionsChartDataSource.ProvideRowCustomTotals) AndAlso cell.RowValueType = PivotGridValueType.CustomTotal) OrElse ((Not fPivot.OptionsChartDataSource.ProvideRowGrandTotals) AndAlso cell.RowValueType = PivotGridValueType.GrandTotal) OrElse ((Not fPivot.OptionsChartDataSource.ProvideRowTotals) AndAlso cell.RowValueType = PivotGridValueType.Total)
        End Function

        #Region "IBindingList Members"

        Private Sub IBindingList_AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private Function IBindingList_AddNew() As Object Implements IBindingList.AddNew
            Throw New System.Exception("The method or operation is not implemented.")
        End Function

        Private ReadOnly Property IBindingList_AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property

        Private Sub IBindingList_ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private Function IBindingList_Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New System.Exception("The method or operation is not implemented.")
        End Function

        Private ReadOnly Property IBindingList_IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Throw New System.Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private fListChanged As ListChangedEventHandler
        Protected Sub RaiseListChanged()
            If fListChanged IsNot Nothing Then
                fListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))
            End If
        End Sub
        Private Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
                fListChanged = DirectCast(System.Delegate.Combine(fListChanged, value), ListChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As ListChangedEventHandler)
                fListChanged = DirectCast(System.Delegate.Remove(fListChanged, value), ListChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
                If fListChanged IsNot Nothing Then
                    For Each d As ListChangedEventHandler In fListChanged.GetInvocationList()
                        d.Invoke(sender, e)
                    Next d
                End If
            End RaiseEvent
        End Event

        Private Sub IBindingList_RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private Sub IBindingList_RemoveSort() Implements IBindingList.RemoveSort
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property IBindingList_SortDirection() As ListSortDirection Implements IBindingList.SortDirection
            Get
                Throw New System.Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property IBindingList_SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Throw New System.Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property

        #End Region

        #Region "IList Members"

        Private Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New System.Exception("The method or operation is not implemented.")
        End Function

        Private Sub IList_Clear() Implements IList.Clear
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Throw New System.Exception("The method or operation is not implemented.")
        End Function

        Private Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Throw New System.Exception("The method or operation is not implemented.")
        End Function

        Private Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property IList_IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IList_IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return True
            End Get
        End Property

        Private Sub IList_Remove(ByVal value As Object) Implements IList.Remove
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private Sub IList_RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Public Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return fData(index)
            End Get
            Set(ByVal value As Object)
                Throw New System.Exception("The method or operation is not implemented.")
            End Set
        End Property

        #End Region

        #Region "ICollection Members"

        Private Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Throw New System.Exception("The method or operation is not implemented.")
        End Sub

        Private ReadOnly Property ICollection_Count() As Integer Implements ICollection.Count
            Get
                Return fData.Count
            End Get
        End Property

        Private ReadOnly Property ICollection_IsSynchronized() As Boolean Implements ICollection.IsSynchronized
            Get
                Throw New System.Exception("The method or operation is not implemented.")
            End Get
        End Property

        Private ReadOnly Property ICollection_SyncRoot() As Object Implements ICollection.SyncRoot
            Get
                Throw New System.Exception("The method or operation is not implemented.")
            End Get
        End Property

        #End Region

        #Region "IEnumerable Members"

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return New CustomChartDataSourceEnumerator(fData)
        End Function

        #End Region

        #Region "ITypedList Members"

        Private Function ITypedList_GetItemProperties(ByVal listAccessors() As PropertyDescriptor) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Dim properties As New List(Of CustomChartDataSourcePropertyDescriptor)()
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Series))
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Arguments))
            properties.Add(New CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Values))
            Return New PropertyDescriptorCollection(properties.ToArray())
        End Function

        Private Function ITypedList_GetListName(ByVal listAccessors() As PropertyDescriptor) As String Implements ITypedList.GetListName
            Throw New System.Exception("The method or operation is not implemented.")
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

            Private ReadOnly Property IEnumerator_Current() As Object Implements IEnumerator.Current
                Get
                    If fPosition < 0 OrElse fPosition >= fData.Count Then
                        Return Nothing
                    End If
                    Return fData(fPosition)
                End Get
            End Property

            Private Function IEnumerator_MoveNext() As Boolean Implements IEnumerator.MoveNext
                If fPosition >= fData.Count Then
                    Return False
                End If
                fPosition += 1
                Return True
            End Function

            Private Sub IEnumerator_Reset() Implements IEnumerator.Reset
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

            Public Overrides ReadOnly Property ComponentType() As Type
                Get
                    Return GetType(Object())
                End Get
            End Property

            Public Overrides Function GetValue(ByVal component As Object) As Object
                Dim source() As Object = TryCast(component, Object())
                If source Is Nothing OrElse source.Length <> 3 Then
                    Throw New ArgumentException("The array of three values expected")
                End If
                Return source(CInt(fPropertyType))
            End Function

            Public Overrides ReadOnly Property IsReadOnly() As Boolean
                Get
                    Return True
                End Get
            End Property

            Public Overrides ReadOnly Property PropertyType() As Type
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