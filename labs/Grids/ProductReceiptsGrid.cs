using labs.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs.Grids
{
    public partial class ProductReceiptsGrid : Form
    {
        public ProductReceiptsGrid()
        {
            InitializeComponent();
        }

        private void productReceiptsHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productReceiptsHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void ProductReceiptsGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductReceiptsHistory' table. You can move, or remove it, as needed.
            RefreshData();
        }

        private void RefreshData()
        {
            this.productReceiptsHistoryTableAdapter.Fill(this.internetShopDataSet.ProductReceiptsHistory);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductReceiptsHistory' table. You can move, or remove it, as needed.
            this.productReceiptsHistoryTableAdapter.Fill(this.internetShopDataSet.ProductReceiptsHistory);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(productBindingSource, tableAdapterManager, internetShopDataSet);
            DialogResult = DialogResult.OK;
            Close(); 
        }


        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var connectionString = System.Configuration.ConfigurationManager.
    ConnectionStrings["labs.Properties.Settings.InternetShopConnectionString"].ConnectionString;
            var db = new DataContext(connectionString);
            var receiptsCount = (int)productCountUpDown.Value;
            var productId = (int)productCB.SelectedValue; 

            db.ExecuteCommand("insert into ProductReceiptsHistory (ProductId, CountOfReceipts) values ({0}, {1}); ", productId, receiptsCount);
            RefreshData();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            var form = new ProductGrid();

            if (form.ShowDialog() == DialogResult.OK)
                RefreshData();
        }
    }
}
