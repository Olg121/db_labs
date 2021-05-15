using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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

        private void RefreshData()
        {
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

        private void DiscountGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            RefreshData();

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

        private void button1_Click(object sender, EventArgs e)
        {
            var dateFrom = $"CAST('{fromDateTimePicker.Value.ToString("dd/MM/yyyy")}' AS DATETIME)" ;
            var dateTo = $"CAST('{dateTimePicker2.Value.ToString("dd/MM/yyyy")}' AS DATETIME)";
                                    
            var productId = (int)comboBox1.SelectedValue;
            var discountVal = ((float)discountUpDown.Value) / 100; 

            var connectionString = System.Configuration.ConfigurationManager.
  ConnectionStrings["labs.Properties.Settings.InternetShopConnectionString"].ConnectionString;
            var db = new DataContext(connectionString);

            var sql = string.Format("insert into Discount(ProductId, DateFrom, DateTo, Amount) values({0}, {1}, {2}, {3})", productId, dateFrom, dateTo, discountVal.ToString().Replace(',', '.'));
            db.ExecuteCommand(sql);
            RefreshData();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            var form = new labs.Grids.ProductGrid();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}
