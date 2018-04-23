using System;
using System.Windows.Forms;
using DXSample;
using DevExpress.XtraPivotGrid;
using System.Collections.Generic;
using System.Collections;

namespace CustomChartDataSourceWin {
    public partial class Form1 :Form {
        private CustomChartDataSource chartDataSource;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
            chartDataSource = new CustomChartDataSource(salesPersonPivot);
            salesPersonChart.DataSource = chartDataSource;
        }

        private void OfFormClosing(object sender, FormClosingEventArgs e) {
            salesPersonChart.DataSource = null;
            chartDataSource.Dispose();
        }

        // some custom logic to demonstrate the approach in action
        private void OnPivotCustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.DataField == fieldExtendedPriceUnbound) {
                PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                decimal value = 0;
                Dictionary<PivotGridField, object> columnFieldValues = new Dictionary<PivotGridField, object>();
                PivotGridField[] columnFields = e.GetColumnFields();
                foreach (PivotGridField field in columnFields)
                    columnFieldValues[field] = e.GetFieldValue(field);
                for (int i = 0; i < ds.RowCount; i++)
                {
                    bool skip = false;
                    foreach (PivotGridField field in columnFields)
                    {
                        if (!Comparer.Equals(ds[i][field], columnFieldValues[field]))
                        {
                            skip = true;
                            break;
                        }
                    }
                    if (skip)
                        continue;
                    decimal v1 = Convert.ToDecimal(ds[i][e.DataField]);
                    value += v1;
                }
                e.Value = value;
            }
        }
    }
}