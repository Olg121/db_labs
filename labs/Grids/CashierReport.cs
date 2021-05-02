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
    public partial class CashierReport : Form
    {
        public CashierReport()
        {
            InitializeComponent();
        }

        private void CashierReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.internetShopDataSet.Cashier);

            this.reportViewer1.RefreshReport();
        }
    }
}
