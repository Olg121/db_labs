using db.DbModel;
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
    public partial class BrandGrid : Form
    {
        public BrandGrid()
        {
            InitializeComponent();
        }

        private void brandNameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            GridHelper.Save(brandNameBindingSource, tableAdapterManager, internetShopDataSet);
            brandNameBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(internetShopDataSet);
        }

        private void BrandGrid_Load(object sender, EventArgs e)
        {
            this.brandNameTableAdapter.Fill(this.internetShopDataSet.BrandName);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(brandNameBindingSource, tableAdapterManager, internetShopDataSet);
        }
    }
}
