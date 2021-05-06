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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
         //   GridHelper.MoveFirst(cashierBindingSource);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
         //   GridHelper.MovePrew(cashierBindingSource);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
         //   GridHelper.MoveNext(cashierBindingSource);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveLast(cashierBindingSource);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.AddNewItem(cashierBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.RemoveCurrent(cashierBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges( internetShopDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridHelper.MoveFirst(cashierBindingSource); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(cashierBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridHelper.RemoveCurrent(cashierBindingSource);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GridHelper.AddNewItem(cashierBindingSource);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridHelper.MoveLast(cashierBindingSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridHelper.MovePrew(cashierBindingSource);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridHelper.MoveNext(cashierBindingSource);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
        }
    }
}
