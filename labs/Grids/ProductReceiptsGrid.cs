﻿using System;
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
    public partial class ProductReceiptsGrid : Form
    {
        public ProductReceiptsGrid()
        {
            InitializeComponent();
        }

        private void productReceiptsHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productReceiptsHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void ProductReceiptsGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductReceiptsHistory' table. You can move, or remove it, as needed.
            this.productReceiptsHistoryTableAdapter.Fill(this.internetShopDataSet.ProductReceiptsHistory);
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductReceiptsHistory' table. You can move, or remove it, as needed.
            this.productReceiptsHistoryTableAdapter.Fill(this.internetShopDataSet.ProductReceiptsHistory);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges( internetShopDataSet);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
        //    GridHelper.MoveFirst(productReceiptsHistoryBindingSource);

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
       //     GridHelper.MovePrew(productReceiptsHistoryBindingSource);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        //    GridHelper.MoveNext(productReceiptsHistoryBindingSource);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
         //   GridHelper.MoveLast(productReceiptsHistoryBindingSource);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // GridHelper.AddNewItem(productReceiptsHistoryBindingSource, tableAdapterManager, internetShopDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          //  GridHelper.RemoveCurrent(productReceiptsHistoryBindingSource, tableAdapterManager, internetShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridHelper.MoveFirst(productBindingSource);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(productBindingSource, tableAdapterManager, internetShopDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridHelper.RemoveCurrent(productBindingSource);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GridHelper.AddNewItem(productBindingSource);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridHelper.MoveLast(productBindingSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridHelper.MovePrew(productBindingSource);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridHelper.MoveNext(productBindingSource);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            GridHelper.UndoChanges(internetShopDataSet);
        }
    }
}
