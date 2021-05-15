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
    public partial class ProductGrid : Form
    {
        public ProductGrid()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void ProductGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            RefreshData();
        }

        private void RefreshData()
        {
            this.brandNameTableAdapter.Fill(this.internetShopDataSet.BrandName);
            this.productTableAdapter.Fill(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.BrandName' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.


        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
           // GridHelper.MoveFirst(productBindingSource);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
           // GridHelper.MovePrew(productBindingSource);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //GridHelper.MoveNext(productBindingSource);

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
           // GridHelper.MoveLast(productBindingSource);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // GridHelper.AddNewItem(productBindingSource, tableAdapterManager, internetShopDataSet);

        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            GridHelper.Save(productBindingSource, tableAdapterManager, internetShopDataSet);
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
            var bForm = new BrandGrid(); 
            if (bForm.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var brandId = (int)productCB.SelectedValue;
            var price = priceCB.Text.Replace(',', '.');
            var productName = textBox1.Text;
            var connectionString = System.Configuration.ConfigurationManager.
  ConnectionStrings["labs.Properties.Settings.InternetShopConnectionString"].ConnectionString;
            var db = new DataContext(connectionString);

            var sql = string.Format("insert into product(Name, BrandNameId, Price) values('{0}', {1}, cast('{2}' as float))",  productName , brandId, price);

            db.ExecuteCommand(sql);
            RefreshData();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            var form = new BrandGrid();
            form.ShowDialog();
            RefreshData(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new ProductsDetails();
            form.ShowDialog();
            RefreshData();
        }
    }
}
