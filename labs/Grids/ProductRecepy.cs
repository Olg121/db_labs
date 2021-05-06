using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs.Grids
{
    public partial class ProductRecepy : Form
    {
        public ProductRecepy()
        {
            InitializeComponent();
        }

        private void ProductRecepy_Load(object sender, EventArgs e)
        {
            if (this.Owner is ProductsDetails parent)
            {
                var productName = parent.ProductName;
                var productNameParam = new ReportParameter("productNameStr", productName);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { productNameParam });
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
