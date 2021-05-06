using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs.Grids
{
    public partial class ProductSaleCard : Form
    {
        public ProductSaleCard()
        {
            InitializeComponent();
        }

        private void productSalesHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productSalesHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void ProductSaleCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductSalesHistory' table. You can move, or remove it, as needed.
            this.productSalesHistoryTableAdapter.Fill(this.internetShopDataSet.ProductSalesHistory);

        }
    }
}
