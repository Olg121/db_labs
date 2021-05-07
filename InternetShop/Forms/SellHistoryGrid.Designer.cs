
namespace InternetShop.Forms
{
    partial class SellHistoryGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fullProductSaleHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullProductSaleHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetShopDataSet = new InternetShop.InternetShopDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countLbl = new System.Windows.Forms.Label();
            this.productCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierCB = new System.Windows.Forms.ComboBox();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.productSalesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSalesHistoryTableAdapter = new InternetShop.InternetShopDataSetTableAdapters.ProductSalesHistoryTableAdapter();
            this.tableAdapterManager = new InternetShop.InternetShopDataSetTableAdapters.TableAdapterManager();
            this.fullProductSaleHistoryTableAdapter = new InternetShop.InternetShopDataSetTableAdapters.FullProductSaleHistoryTableAdapter();
            this.productTableAdapter = new InternetShop.InternetShopDataSetTableAdapters.ProductTableAdapter();
            this.cashierTableAdapter = new InternetShop.InternetShopDataSetTableAdapters.CashierTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.updateCashierBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductSaleHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductSaleHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fullProductSaleHistoryDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 450);
            this.panel1.TabIndex = 2;
            // 
            // fullProductSaleHistoryDataGridView
            // 
            this.fullProductSaleHistoryDataGridView.AutoGenerateColumns = false;
            this.fullProductSaleHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullProductSaleHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.fullProductSaleHistoryDataGridView.DataSource = this.fullProductSaleHistoryBindingSource;
            this.fullProductSaleHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullProductSaleHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fullProductSaleHistoryDataGridView.Name = "fullProductSaleHistoryDataGridView";
            this.fullProductSaleHistoryDataGridView.ReadOnly = true;
            this.fullProductSaleHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullProductSaleHistoryDataGridView.Size = new System.Drawing.Size(631, 450);
            this.fullProductSaleHistoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Бренд";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ResultPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Итоговая цена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата продажи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Касир";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // fullProductSaleHistoryBindingSource
            // 
            this.fullProductSaleHistoryBindingSource.DataMember = "FullProductSaleHistory";
            this.fullProductSaleHistoryBindingSource.DataSource = this.internetShopDataSet;
            // 
            // internetShopDataSet
            // 
            this.internetShopDataSet.DataSetName = "InternetShopDataSet";
            this.internetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(631, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 450);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.countLbl);
            this.flowLayoutPanel1.Controls.Add(this.productCountUpDown);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продать товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Продукт";
            // 
            // productCB
            // 
            this.productCB.DataSource = this.productBindingSource;
            this.productCB.DisplayMember = "Name";
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(3, 3);
            this.productCB.Margin = new System.Windows.Forms.Padding(10, 3, 5, 0);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(146, 21);
            this.productCB.TabIndex = 2;
            this.productCB.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.internetShopDataSet;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(10, 121);
            this.countLbl.Margin = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(66, 13);
            this.countLbl.TabIndex = 3;
            this.countLbl.Text = "Количество";
            // 
            // productCountUpDown
            // 
            this.productCountUpDown.Location = new System.Drawing.Point(10, 137);
            this.productCountUpDown.Margin = new System.Windows.Forms.Padding(10, 3, 5, 0);
            this.productCountUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productCountUpDown.Name = "productCountUpDown";
            this.productCountUpDown.Size = new System.Drawing.Size(203, 20);
            this.productCountUpDown.TabIndex = 4;
            this.productCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Касир";
            // 
            // cashierCB
            // 
            this.cashierCB.DataSource = this.cashierBindingSource;
            this.cashierCB.DisplayMember = "FIO";
            this.cashierCB.FormattingEnabled = true;
            this.cashierCB.Location = new System.Drawing.Point(3, 3);
            this.cashierCB.Margin = new System.Windows.Forms.Padding(10, 3, 5, 0);
            this.cashierCB.Name = "cashierCB";
            this.cashierCB.Size = new System.Drawing.Size(146, 21);
            this.cashierCB.TabIndex = 6;
            this.cashierCB.ValueMember = "Id";
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.internetShopDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Продать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productSalesHistoryBindingSource
            // 
            this.productSalesHistoryBindingSource.DataMember = "ProductSalesHistory";
            this.productSalesHistoryBindingSource.DataSource = this.internetShopDataSet;
            // 
            // productSalesHistoryTableAdapter
            // 
            this.productSalesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandNameTableAdapter = null;
            this.tableAdapterManager.CashierTableAdapter = null;
            this.tableAdapterManager.DiscountTableAdapter = null;
            this.tableAdapterManager.ProductReceiptsHistoryTableAdapter = null;
            this.tableAdapterManager.ProductSalesHistoryTableAdapter = this.productSalesHistoryTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InternetShop.InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fullProductSaleHistoryTableAdapter
            // 
            this.fullProductSaleHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Удаление";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалить выбранную запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productCB);
            this.panel3.Controls.Add(this.updateProductBtn);
            this.panel3.Location = new System.Drawing.Point(10, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 3, 5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 27);
            this.panel3.TabIndex = 10;
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(157, 3);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(41, 21);
            this.updateProductBtn.TabIndex = 11;
            this.updateProductBtn.Text = "Изм.";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.updateCashierBtn);
            this.panel4.Controls.Add(this.cashierCB);
            this.panel4.Location = new System.Drawing.Point(10, 178);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 3, 5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 29);
            this.panel4.TabIndex = 11;
            // 
            // updateCashierBtn
            // 
            this.updateCashierBtn.Location = new System.Drawing.Point(157, 2);
            this.updateCashierBtn.Name = "updateCashierBtn";
            this.updateCashierBtn.Size = new System.Drawing.Size(41, 21);
            this.updateCashierBtn.TabIndex = 12;
            this.updateCashierBtn.Text = "Изм.";
            this.updateCashierBtn.UseVisualStyleBackColor = true;
            this.updateCashierBtn.Click += new System.EventHandler(this.updateCashierBtn_Click);
            // 
            // SellHistoryGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SellHistoryGrid";
            this.Text = "История продаж";
            this.Load += new System.EventHandler(this.SellHistoryGrid_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullProductSaleHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductSaleHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private InternetShopDataSet internetShopDataSet;
        private System.Windows.Forms.BindingSource productSalesHistoryBindingSource;
        private InternetShopDataSetTableAdapters.ProductSalesHistoryTableAdapter productSalesHistoryTableAdapter;
        private InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource fullProductSaleHistoryBindingSource;
        private InternetShopDataSetTableAdapters.FullProductSaleHistoryTableAdapter fullProductSaleHistoryTableAdapter;
        private System.Windows.Forms.DataGridView fullProductSaleHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.BindingSource productBindingSource;
        private InternetShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.NumericUpDown productCountUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cashierCB;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private InternetShopDataSetTableAdapters.CashierTableAdapter cashierTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button updateCashierBtn;
    }
}