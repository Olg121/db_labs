
namespace labs.Grids
{
    partial class CashierReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetShopDataSet = new labs.InternetShopDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.internetShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierTableAdapter = new labs.InternetShopDataSetTableAdapters.CashierTableAdapter();
            this.tableAdapterManager = new labs.InternetShopDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.internetShopDataSet;
            // 
            // internetShopDataSet
            // 
            this.internetShopDataSet.DataSetName = "InternetShopDataSet";
            this.internetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CashierDataset";
            reportDataSource1.Value = this.cashierBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "labs.Report.CashierReportTemplate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(858, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // internetShopDataSetBindingSource
            // 
            this.internetShopDataSetBindingSource.DataSource = this.internetShopDataSet;
            this.internetShopDataSetBindingSource.Position = 0;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandNameTableAdapter = null;
            this.tableAdapterManager.CashierTableAdapter = this.cashierTableAdapter;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.ProductReceiptsHistoryTableAdapter = null;
            this.tableAdapterManager.ProductSalesHistoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = labs.InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CashierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CashierReport";
            this.Text = "Список работников";
            this.Load += new System.EventHandler(this.CashierReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource internetShopDataSetBindingSource;
        private InternetShopDataSet internetShopDataSet;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private InternetShopDataSetTableAdapters.CashierTableAdapter cashierTableAdapter;
        private InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}