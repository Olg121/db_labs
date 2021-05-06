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
    public partial class ProductsDetails : Form
    {
        public ProductsDetails()
        {
            InitializeComponent();
        }

        private void ProductsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetShopDataSet.ProductReceiptsHistory' table. You can move, or remove it, as needed.
            this.brandNameTableAdapter.Fill(this.internetShopDataSet.BrandName);

            // TODO: This line of code loads data into the 'internetShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.FillBy(this.internetShopDataSet.Product);
            // TODO: This line of code loads data into the 'internetShopDataSet.BrandName' table. You can move, or remove it, as needed.
        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_5(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_6(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.internetShopDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var brandName = new BrandNameLite();

            var dialogResult = brandName.ShowDialog(); 
            if (dialogResult == DialogResult.OK)
            {
                this.brandNameTableAdapter.Fill(this.internetShopDataSet.BrandName);
                this.productTableAdapter.FillBy(this.internetShopDataSet.Product);
            }
        }

        public string ProductName { get => this.nameTextBox.Text; }

        private ProductRecepy reportForm { get; set; } 
        private void productRecepyBtn_Click(object sender, EventArgs e)
        {
            if (reportForm is null)
                reportForm = new ProductRecepy();
            reportForm.ShowDialog(this); 

        }
    }
}
