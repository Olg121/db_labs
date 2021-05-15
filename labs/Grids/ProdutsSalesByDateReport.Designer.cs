
namespace labs.Grids
{
    partial class ProdutsSalesByDateReport
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
            this.internetShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetShopDataSet = new labs.InternetShopDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewTableAdapter = new labs.InternetShopDataSetTableAdapters.ReportViewTableAdapter();
            this.tableAdapterManager = new labs.InternetShopDataSetTableAdapters.TableAdapterManager();
            this.reportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // internetShopDataSetBindingSource
            // 
            this.internetShopDataSetBindingSource.DataSource = this.internetShopDataSet;
            this.internetShopDataSetBindingSource.Position = 0;
            // 
            // internetShopDataSet
            // 
            this.internetShopDataSet.DataSetName = "InternetShopDataSet";
            this.internetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 46);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 404);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSet";
            reportDataSource1.Value = this.reportViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "labs.Report.SalesByDatesReportTemplpate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1023, 404);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewBindingSource
            // 
            this.reportViewBindingSource.DataMember = "ReportView";
            this.reportViewBindingSource.DataSource = this.internetShopDataSet;
            // 
            // reportViewTableAdapter
            // 
            this.reportViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandNameTableAdapter = null;
            this.tableAdapterManager.CashierTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.ProductReceiptsHistoryTableAdapter = null;
            this.tableAdapterManager.ProductSalesHistoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = labs.InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewBindingSource1
            // 
            this.reportViewBindingSource1.DataMember = "ReportView";
            this.reportViewBindingSource1.DataSource = this.internetShopDataSet;
            // 
            // ProdutsSalesByDateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProdutsSalesByDateReport";
            this.Text = "ProdutsSalesByDateReport";
            this.Load += new System.EventHandler(this.ProdutsSalesByDateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource internetShopDataSetBindingSource;
        private InternetShopDataSet internetShopDataSet;
        private System.Windows.Forms.BindingSource reportViewBindingSource;
        private InternetShopDataSetTableAdapters.ReportViewTableAdapter reportViewTableAdapter;
        private InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource reportViewBindingSource1;
    }
}