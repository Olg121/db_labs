using InternetShop.DbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Configuration.Assemblies;

namespace InternetShop.Forms
{
    public partial class SellHistoryGrid : Form
    {
        public SellHistoryGrid()
        {
            InitializeComponent();
        }

        private void productSalesHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productSalesHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void SellHistoryGrid_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            this.cashierTableAdapter.Fill(this.internetShopDataSet.Cashier);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.FullProductSaleHistory' table. You can move, or remove it, as needed.
            this.fullProductSaleHistoryTableAdapter.Fill(this.internetShopDataSet.FullProductSaleHistory);
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductSalesHistory' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductSalesHistory' table. You can move, or remove it, as needed.
            this.productSalesHistoryTableAdapter.Fill(this.internetShopDataSet.ProductSalesHistory);
        }

        private void productSalesHistoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productSalesHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productId = (int)productCB.SelectedValue;
            var count = (int)productCountUpDown.Value;
            var cashierId = (int)cashierCB.SelectedValue;
            int result = 0;
            var db = GetContext();
            db.TryToSaleProduct(cashierId, productId, count, ref result);
            if (result > 0)
                RefreshData();
            //Console.WriteLine("test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedCol = fullProductSaleHistoryDataGridView.SelectedRows?[0];
            var id = int.Parse(selectedCol?.Cells?[2]?.Value.ToString());

            var db = GetContext();
            db.DeleteProductHistoryRecord(id);
            RefreshData();

        }

        private ProceduresContext GetContext()
        {
            var connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return new ProceduresContext(connection);
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            var form = new labs.Grids.ProductGrid();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void updateCashierBtn_Click(object sender, EventArgs e)
        {
            var form = new labs.Grids.CashierGrid();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
