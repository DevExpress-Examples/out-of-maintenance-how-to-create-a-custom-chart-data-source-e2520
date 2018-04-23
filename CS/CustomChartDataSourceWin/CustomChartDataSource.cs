using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraPivotGrid;
using System.Collections.Generic;

namespace DXSample {
    public class CustomChartDataSource :IBindingList, ITypedList, IDisposable {
        private PivotGridControl fPivot;
        private List<object[]> fData;

        public CustomChartDataSource(PivotGridControl source) {
            fPivot = source;
            CreateChartData();
            fPivot.CellSelectionChanged += OnPivotCellSelectionChanged;
        }

        void OnPivotCellSelectionChanged(object sender, EventArgs e) {
            CreateChartData();
            RaiseListChanged();
        }

        void CreateChartData() {
            fData = fPivot.OptionsSelection.MultiSelect && fPivot.OptionsChartDataSource.SelectionOnly ? CreateChartDataFromMultiselection() :
                CreateChartDataFromSelection();
        }

        List<object[]> CreateChartDataFromSelection() {
            List<object[]> result = new List<object[]>();
            Rectangle selection = fPivot.OptionsChartDataSource.SelectionOnly ? fPivot.Cells.Selection :
                new Rectangle(0, 0, fPivot.Cells.ColumnCount, fPivot.Cells.RowCount);
            for (int col = selection.Left; col < selection.Right; col++)
                for (int row = selection.Top; row < selection.Bottom; row++) {
                    object[] data = GetDataFromCell(fPivot.Cells.GetCellInfo(col, row));
                    if (data != null)
                        result.Add(data);
                }
            return result;
        }

        List<object[]> CreateChartDataFromMultiselection() {
            List<object[]> result = new List<object[]>();
            foreach (Point cell in fPivot.Cells.MultiSelection.SelectedCells) {
                object[] data = GetDataFromCell(fPivot.Cells.GetCellInfo(cell.X, cell.Y));
                if (data != null)
                    result.Add(data);
            }
            return result;
        }

        object[] GetDataFromCell(PivotCellEventArgs cell) {
            if (SkipCellValue(cell)) return null;
            object[] result = new object[3];
            result[0] = string.Concat(fPivot.OptionsChartDataSource.ChartDataVertical ? GetFieldValue(cell, false) : GetFieldValue(cell, true),
                fPivot.GetFieldsByArea(PivotArea.DataArea).Count > 1 ? string.Concat(" | ", cell.DataField.Caption) : string.Empty);
            result[1] = fPivot.OptionsChartDataSource.ChartDataVertical ? GetFieldValue(cell, true) : GetFieldValue(cell, false);
            result[2] = Convert.ToDecimal(cell.Value);
            return result;
        }

        private static string GetFieldValue(PivotCellEventArgs cell, bool column) {
            PivotGridField[] fields = column ? cell.GetColumnFields() : cell.GetRowFields();
            StringBuilder result = new StringBuilder();
            foreach (PivotGridField field in fields)
                result.AppendFormat("{0} | ", cell.GetFieldValue(field));
            if (result.Length > 3)
                result.Remove(result.Length - 3, 3);
            if (column)
                switch (cell.ColumnValueType) {
                    case PivotGridValueType.CustomTotal:
                        return result.AppendFormat(" Total ({0})", cell.ColumnCustomTotal.SummaryType).ToString();
                    case PivotGridValueType.GrandTotal:
                        return "Grand Total";
                    case PivotGridValueType.Total:
                        return result.Append(" Total").ToString();
                } else
                switch (cell.RowValueType) {
                    case PivotGridValueType.CustomTotal:
                        return result.AppendFormat(" Total ({0})", cell.RowCustomTotal.SummaryType).ToString();
                    case PivotGridValueType.GrandTotal:
                        return "Grand Total";
                    case PivotGridValueType.Total:
                        return result.Append(" Total").ToString();
                }
            return result.ToString();
        }

        private bool SkipCellValue(PivotCellEventArgs cell) {
            return (!fPivot.OptionsChartDataSource.ShowColumnCustomTotals && cell.ColumnValueType == PivotGridValueType.CustomTotal) ||
                (!fPivot.OptionsChartDataSource.ShowColumnGrandTotals && cell.ColumnValueType == PivotGridValueType.GrandTotal) ||
                (!fPivot.OptionsChartDataSource.ShowColumnTotals && cell.ColumnValueType == PivotGridValueType.Total) ||
                (!fPivot.OptionsChartDataSource.ShowRowCustomTotals && cell.RowValueType == PivotGridValueType.CustomTotal) ||
                (!fPivot.OptionsChartDataSource.ShowRowGrandTotals && cell.RowValueType == PivotGridValueType.GrandTotal) ||
                (!fPivot.OptionsChartDataSource.ShowRowTotals && cell.RowValueType == PivotGridValueType.Total);
        }

        #region IBindingList Members

        void IBindingList.AddIndex(PropertyDescriptor property) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        object IBindingList.AddNew() {
            throw new System.Exception("The method or operation is not implemented.");
        }

        bool IBindingList.AllowEdit {
            get { return false; }
        }

        bool IBindingList.AllowNew {
            get { return false; }
        }

        bool IBindingList.AllowRemove {
            get { return false; }
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        int IBindingList.Find(PropertyDescriptor property, object key) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        bool IBindingList.IsSorted {
            get { throw new System.Exception("The method or operation is not implemented."); }
        }

        private ListChangedEventHandler fListChanged;
        protected void RaiseListChanged() {
            if (fListChanged != null)
                fListChanged(this, new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        event ListChangedEventHandler IBindingList.ListChanged {
            add { fListChanged += value; }
            remove { fListChanged -= value; }
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        void IBindingList.RemoveSort() {
            throw new System.Exception("The method or operation is not implemented.");
        }

        ListSortDirection IBindingList.SortDirection {
            get { throw new System.Exception("The method or operation is not implemented."); }
        }

        PropertyDescriptor IBindingList.SortProperty {
            get { throw new System.Exception("The method or operation is not implemented."); }
        }

        bool IBindingList.SupportsChangeNotification {
            get { return true; }
        }

        bool IBindingList.SupportsSearching {
            get { return false; }
        }

        bool IBindingList.SupportsSorting {
            get { return false; }
        }

        #endregion

        #region IList Members

        int IList.Add(object value) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        void IList.Clear() {
            throw new System.Exception("The method or operation is not implemented.");
        }

        bool IList.Contains(object value) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        int IList.IndexOf(object value) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        void IList.Insert(int index, object value) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        bool IList.IsFixedSize {
            get { return true; }
        }

        bool IList.IsReadOnly {
            get { return true; }
        }

        void IList.Remove(object value) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        void IList.RemoveAt(int index) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        object IList.this[int index] {
            get { return fData[index]; }
            set { throw new System.Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        int ICollection.Count {
            get { return fData.Count; }
        }

        bool ICollection.IsSynchronized {
            get { throw new System.Exception("The method or operation is not implemented."); }
        }

        object ICollection.SyncRoot {
            get { throw new System.Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator() {
            return new CustomChartDataSourceEnumerator(fData);
        }

        #endregion

        #region ITypedList Members

        PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) {
            List<CustomChartDataSourcePropertyDescriptor> properties = new List<CustomChartDataSourcePropertyDescriptor>();
            properties.Add(new CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Series));
            properties.Add(new CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Arguments));
            properties.Add(new CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty.Values));
            return new PropertyDescriptorCollection(properties.ToArray());
        }

        string ITypedList.GetListName(PropertyDescriptor[] listAccessors) {
            throw new System.Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IDisposable Members

        public void Dispose() {
            if (fPivot != null) {
                fPivot.CellSelectionChanged -= OnPivotCellSelectionChanged;
                fPivot = null;
            }
        }

        #endregion

        public class CustomChartDataSourceEnumerator :IEnumerator {
            List<object[]> fData;
            int fPosition = -1;

            internal CustomChartDataSourceEnumerator(List<object[]> data) {
                fData = data;
            }

            #region IEnumerator Members

            object IEnumerator.Current {
                get {
                    if (fPosition < 0 || fPosition >= fData.Count) return null;
                    return fData[fPosition];
                }
            }

            bool IEnumerator.MoveNext() {
                if (fPosition >= fData.Count) return false;
                fPosition++;
                return true;
            }

            void IEnumerator.Reset() {
                fPosition = -1;
            }

            #endregion
        }

        public class CustomChartDataSourcePropertyDescriptor :PropertyDescriptor {
            private CustomChartDataSourceProperty fPropertyType;

            public CustomChartDataSourcePropertyDescriptor(CustomChartDataSourceProperty propertyType)
                : base(propertyType.ToString(), null) {
                fPropertyType = propertyType;
            }

            public override bool CanResetValue(object component) {
                return false;
            }

            public override Type ComponentType {
                get { return typeof(object[]); }
            }

            public override object GetValue(object component) {
                object[] source = component as object[];
                if (source == null || source.Length != 3) throw new ArgumentException("The array of three values expected");
                return source[(int)fPropertyType];
            }

            public override bool IsReadOnly {
                get { return true; }
            }

            public override Type PropertyType {
                get { return fPropertyType == CustomChartDataSourceProperty.Values ? typeof(decimal) : typeof(string); }
            }

            public override void ResetValue(object component) {
                throw new Exception("The method or operation is not implemented.");
            }

            public override void SetValue(object component, object value) {
                throw new Exception("The method or operation is not implemented.");
            }

            public override bool ShouldSerializeValue(object component) {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public enum CustomChartDataSourceProperty { Series, Arguments, Values };
}
}