using Microsoft.Reporting.WinForms;
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
    public partial class ProdutsSalesByDateReport : Form
    {
        public ProdutsSalesByDateReport()
        {
            InitializeComponent();
        }

        private void ProdutsSalesByDateReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ReportView' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewTableAdapter.FillBy(this.internetShopDataSet.ReportView, dateTimePicker1.Value, dateTimePicker2.Value);
            var fromParam = new ReportParameter("dateFrom", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            var toParam = new ReportParameter("dateTo", dateTimePicker2.Value.ToString("dd-MM-yyyy"));
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fromParam, toParam });
            this.reportViewer1.RefreshReport();
        }
    }
}
