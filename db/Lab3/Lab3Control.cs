using db.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Lab3
{
    public partial class Lab3Control : UserControl
    {
        public Lab3Control()
        {
            InitializeComponent();
        }

        private DataSet _dataSet; 

        private void button1_Click(object sender, EventArgs e)
        {
            var data = DataSetImplementations.ReadCashiersFromDb();
            _dataSet = data;
            cashiersGrid.DataSource = DataSetImplementations.GetCashiersFromDataSet(data);
            cashiersGrid.Update();
            cashiersGrid.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = GridViewHelper.PrepairDataForGrid(DataSetImplementations.CreateTable());
            customObjectGrid.DataSource = data;
            customObjectGrid.Update();
            customObjectGrid.Refresh();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            var cashier = cashierControl1.Cashier;
            DataSetImplementations.AddCashierToDataSet(_dataSet, cashier);
        }
    }
}
