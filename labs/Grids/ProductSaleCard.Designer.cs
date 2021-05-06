
namespace labs.Grids
{
    partial class ProductSaleCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSaleCard));
            this.internetShopDataSet = new labs.InternetShopDataSet();
            this.productSalesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSalesHistoryTableAdapter = new labs.InternetShopDataSetTableAdapters.ProductSalesHistoryTableAdapter();
            this.tableAdapterManager = new labs.InternetShopDataSetTableAdapters.TableAdapterManager();
            this.productSalesHistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productSalesHistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productSalesHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingNavigator)).BeginInit();
            this.productSalesHistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // internetShopDataSet
            // 
            this.internetShopDataSet.DataSetName = "InternetShopDataSet";
            this.internetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.UpdateOrder = labs.InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productSalesHistoryBindingNavigator
            // 
            this.productSalesHistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productSalesHistoryBindingNavigator.BindingSource = this.productSalesHistoryBindingSource;
            this.productSalesHistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productSalesHistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productSalesHistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productSalesHistoryBindingNavigatorSaveItem});
            this.productSalesHistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productSalesHistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productSalesHistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productSalesHistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productSalesHistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productSalesHistoryBindingNavigator.Name = "productSalesHistoryBindingNavigator";
            this.productSalesHistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productSalesHistoryBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.productSalesHistoryBindingNavigator.TabIndex = 0;
            this.productSalesHistoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productSalesHistoryBindingNavigatorSaveItem
            // 
            this.productSalesHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productSalesHistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productSalesHistoryBindingNavigatorSaveItem.Image")));
            this.productSalesHistoryBindingNavigatorSaveItem.Name = "productSalesHistoryBindingNavigatorSaveItem";
            this.productSalesHistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productSalesHistoryBindingNavigatorSaveItem.Text = "Save Data";
            this.productSalesHistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.productSalesHistoryBindingNavigatorSaveItem_Click);
            // 
            // productSalesHistoryDataGridView
            // 
            this.productSalesHistoryDataGridView.AutoGenerateColumns = false;
            this.productSalesHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSalesHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productSalesHistoryDataGridView.DataSource = this.productSalesHistoryBindingSource;
            this.productSalesHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productSalesHistoryDataGridView.Location = new System.Drawing.Point(0, 25);
            this.productSalesHistoryDataGridView.Name = "productSalesHistoryDataGridView";
            this.productSalesHistoryDataGridView.Size = new System.Drawing.Size(800, 425);
            this.productSalesHistoryDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CashierId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CashierId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ResultPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "ResultPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "SaleDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ProductSaleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productSalesHistoryDataGridView);
            this.Controls.Add(this.productSalesHistoryBindingNavigator);
            this.Name = "ProductSaleCard";
            this.Text = "ProductSaleCard";
            this.Load += new System.EventHandler(this.ProductSaleCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryBindingNavigator)).EndInit();
            this.productSalesHistoryBindingNavigator.ResumeLayout(false);
            this.productSalesHistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InternetShopDataSet internetShopDataSet;
        private System.Windows.Forms.BindingSource productSalesHistoryBindingSource;
        private InternetShopDataSetTableAdapters.ProductSalesHistoryTableAdapter productSalesHistoryTableAdapter;
        private InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productSalesHistoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productSalesHistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productSalesHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}