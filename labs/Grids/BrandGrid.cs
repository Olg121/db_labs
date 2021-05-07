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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridHelper.MovePrew(brandNameBindingSource);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridHelper.MoveNext(brandNameBindingSource);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridHelper.MoveLast(brandNameBindingSource);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GridHelper.AddNewItem(brandNameBindingSource);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridHelper.RemoveCurrent(brandNameBindingSource);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(brandNameBindingSource, tableAdapterManager, internetShopDataSet);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridHelper.MoveFirst(brandNameBindingSource);
        }
    }
}
