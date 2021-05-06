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
    public partial class ProductSaleGrid : Form
    {
        public ProductSaleGrid()
        {
            InitializeComponent();
        }

        private void productSalesHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productSalesHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void ProductSaleGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductSalesHistory' table. You can move, or remove it, as needed.
            this.productSalesHistoryTableAdapter.Fill(this.internetShopDataSet.ProductSalesHistory);
            // TODO: This line of code loads data into the 'internetShopDataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.internetShopDataSet.Cashier);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.internetShopDataSet.Cashier);
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductSalesHistory' table. You can move, or remove it, as needed.
            this.productSalesHistoryTableAdapter.Fill(this.internetShopDataSet.ProductSalesHistory);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveFirst(productSalesHistoryBindingSource);

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
        //    GridHelper.MovePrew(productSalesHistoryBindingSource);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveNext(productSalesHistoryBindingSource);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.MoveLast(productSalesHistoryBindingSource);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // GridHelper.AddNewItem(productSalesHistoryBindingSource, tableAdapterManager, internetShopDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //GridHelper.RemoveCurrent(productSalesHistoryBindingSource, tableAdapterManager, internetShopDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges( internetShopDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridHelper.MoveFirst(productSalesHistoryBindingSource);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(productSalesHistoryBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridHelper.RemoveCurrent(productSalesHistoryBindingSource);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GridHelper.AddNewItem(productSalesHistoryBindingSource);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridHelper.MoveLast(productSalesHistoryBindingSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridHelper.MovePrew(productSalesHistoryBindingSource);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridHelper.MoveNext(productSalesHistoryBindingSource);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
        }
    }
}
