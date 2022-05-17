namespace CustomChartDataSourceWin {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding1 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.salesPersonPivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new CustomChartDataSourceWin.nwindDataSet();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPriceUnbound = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.salesPersonChart = new DevExpress.XtraCharts.ChartControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesPersonTableAdapter = new CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.salesPersonPivot);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.salesPersonChart);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 747);
            this.splitContainerControl1.SplitterPosition = 317;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // salesPersonPivot
            // 
            this.salesPersonPivot.DataSource = this.salesPersonBindingSource;
            this.salesPersonPivot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesPersonPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName1,
            this.fieldYear,
            this.fieldExtendedPriceUnbound,
            this.fieldExtendedPrice1,
            this.fieldSalesPerson1,
            this.fieldQuarter});
            this.salesPersonPivot.Location = new System.Drawing.Point(0, 0);
            this.salesPersonPivot.Name = "salesPersonPivot";
            this.salesPersonPivot.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.salesPersonPivot.Size = new System.Drawing.Size(1235, 317);
            this.salesPersonPivot.TabIndex = 0;
            this.salesPersonPivot.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.OnPivotCustomCellValue);
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            dataSourceColumnBinding1.ColumnName = "CategoryName";
            this.fieldCategoryName1.DataBinding = dataSourceColumnBinding1;
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            dataSourceColumnBinding2.ColumnName = "OrderDate";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding2;
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldExtendedPriceUnbound
            // 
            this.fieldExtendedPriceUnbound.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPriceUnbound.AreaIndex = 1;
            this.fieldExtendedPriceUnbound.Caption = "Extended Price Unbound";
            expressionDataBinding1.Expression = "ToDecimal([Extended Price])";
            this.fieldExtendedPriceUnbound.DataBinding = expressionDataBinding1;
            this.fieldExtendedPriceUnbound.Name = "fieldExtendedPriceUnbound";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            dataSourceColumnBinding3.ColumnName = "Extended Price";
            this.fieldExtendedPrice1.DataBinding = dataSourceColumnBinding3;
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson1.AreaIndex = 1;
            this.fieldSalesPerson1.Caption = "Sales Person";
            dataSourceColumnBinding4.ColumnName = "Sales Person";
            this.fieldSalesPerson1.DataBinding = dataSourceColumnBinding4;
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            dataSourceColumnBinding5.ColumnName = "OrderDate";
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.DataBinding = dataSourceColumnBinding5;
            this.fieldQuarter.Name = "fieldQuarter";
            // 
            // salesPersonChart
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.salesPersonChart.Diagram = xyDiagram1;
            this.salesPersonChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesPersonChart.Location = new System.Drawing.Point(0, 0);
            this.salesPersonChart.Name = "salesPersonChart";
            this.salesPersonChart.SeriesDataMember = "Series";
            this.salesPersonChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.salesPersonChart.SeriesTemplate.ArgumentDataMember = "Arguments";
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.salesPersonChart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.salesPersonChart.SeriesTemplate.SeriesDataMember = "Series";
            this.salesPersonChart.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.salesPersonChart.Size = new System.Drawing.Size(1235, 420);
            this.salesPersonChart.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 747);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OfFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl salesPersonPivot;
        private DevExpress.XtraCharts.ChartControl salesPersonChart;
        private CustomChartDataSourceWin.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPriceUnbound;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

