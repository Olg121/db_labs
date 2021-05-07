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
    public partial class CashierGrid : Form
    {
        public CashierGrid()
        {
            InitializeComponent();
        }

        private void cashierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cashierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);
        }

        private void CashierGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.internetShopDataSet.Cashier);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            GridHelper.Save(cashierBindingSource, tableAdapterManager, internetShopDataSet);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
