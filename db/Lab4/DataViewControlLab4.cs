using db.Helpers;
using db.Lab3;
using db.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Lab4
{
    public partial class DataViewControlLab4 : UserControl
    {
        public DataViewControlLab4()
        {
            InitializeComponent();
        }

        public DataView firstDataView { get; set; }
        public DataView secondDataView { get; set; }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            var data = DataSetImplementations.ReadCashiersFromDb();
            ViewControlImplementations.AddCalculatingColumnToDataSet(data);
            firstDataView = ViewControlImplementations.GetDataOrderedByFirstName(data); 
            secondDataView = ViewControlImplementations.GetDataOrderedBySName(data);
            UpdateGrids();
            FilterGrids();
        }



        private void UpdateGrids()
        {
            GridViewHelper.UpdateGrid(dataGridView1, firstDataView);
            GridViewHelper.UpdateGrid(dataGridView2, secondDataView);
        }  

        private void FilterGrids()
        {
            ViewControlImplementations.FilterRows(firstDataView, textBox1.Text, textBox2.Text);
            ViewControlImplementations.FilterRows(secondDataView, textBox1.Text, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterGrids();
        }
    }
}
