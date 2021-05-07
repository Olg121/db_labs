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
    public partial class DiscountGrid : Form
    {
        public DiscountGrid()
        {
            InitializeComponent();
        }

        private void discountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void DiscountGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.internetShopDataSet.Discount);
            // TODO: This line of code loads data into the 'internetShopDataSet.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.internetShopDataSet.Discount);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'internetShopDataSet.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.internetShopDataSet.Discount);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'internetShopDataSet.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.internetShopDataSet.Discount);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var k = comboBox1.SelectedItem; 
        }

        private void discountBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.discountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void discountBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.discountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveFirst(discountBindingSource);  
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MovePrew(discountBindingSource);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveNext(discountBindingSource);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            //GridHelper.MoveLast(discountBindingSource);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // GridHelper.AddNewItem(discountBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
         //   GridHelper.RemoveCurrent(discountBindingSource, tableAdapterManager, internetShopDataSet);

        }


        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(discountBindingSource, tableAdapterManager, internetShopDataSet);
            DialogResult = DialogResult.OK;
            Close();
        } 

        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
