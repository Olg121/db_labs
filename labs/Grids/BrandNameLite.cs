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
    public partial class BrandNameLite : Form
    {
        public BrandNameLite()
        {
            InitializeComponent();
        }

        private void brandNameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandNameBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void BrandNameLite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.BrandName' table. You can move, or remove it, as needed.
            this.brandNameTableAdapter.Fill(this.internetShopDataSet.BrandName);

        }

        private void brandNameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandNameBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
