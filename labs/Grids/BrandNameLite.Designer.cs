
namespace labs.Grids
{
    partial class BrandNameLite
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
            this.internetShopDataSet = new labs.InternetShopDataSet();
            this.brandNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandNameTableAdapter = new labs.InternetShopDataSetTableAdapters.BrandNameTableAdapter();
            this.tableAdapterManager = new labs.InternetShopDataSetTableAdapters.TableAdapterManager();
            this.brandNameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandNameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // internetShopDataSet
            // 
            this.internetShopDataSet.DataSetName = "InternetShopDataSet";
            this.internetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandNameBindingSource
            // 
            this.brandNameBindingSource.DataMember = "BrandName";
            this.brandNameBindingSource.DataSource = this.internetShopDataSet;
            // 
            // brandNameTableAdapter
            // 
            this.brandNameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandNameTableAdapter = this.brandNameTableAdapter;
            this.tableAdapterManager.CashierTableAdapter = null;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.ProductReceiptsHistoryTableAdapter = null;
            this.tableAdapterManager.ProductSalesHistoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = labs.InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brandNameDataGridView
            // 
            this.brandNameDataGridView.AutoGenerateColumns = false;
            this.brandNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.brandNameDataGridView.DataSource = this.brandNameBindingSource;
            this.brandNameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandNameDataGridView.Location = new System.Drawing.Point(0, 0);
            this.brandNameDataGridView.Name = "brandNameDataGridView";
            this.brandNameDataGridView.Size = new System.Drawing.Size(800, 450);
            this.brandNameDataGridView.TabIndex = 1;
            this.brandNameDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandNameDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BrandNameLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brandNameDataGridView);
            this.Name = "BrandNameLite";
            this.Text = "BrandNameLite";
            this.Load += new System.EventHandler(this.BrandNameLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandNameDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InternetShopDataSet internetShopDataSet;
        private System.Windows.Forms.BindingSource brandNameBindingSource;
        private InternetShopDataSetTableAdapters.BrandNameTableAdapter brandNameTableAdapter;
        private InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView brandNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}