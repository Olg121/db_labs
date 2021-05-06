using labs.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, Type> FormsByName { get; set; } = new Dictionary<string, Type>()
        {
            { "BrandName" , typeof(BrandGrid) },
            { "Cashier" ,typeof(CashierGrid) },
            { "Discount" , typeof(DiscountGrid)},
            { "Product" , typeof(ProductGrid)},
            { "ProductReceipts" ,typeof(ProductReceiptsGrid) },
            { "ProductSale" , typeof(ProductSaleGrid)},
            { "ProductsDetails" , typeof(ProductsDetails)},
            { "CashierReport", typeof(CashierReport) },
        };

        private List<Form> Forms { get; set; } = new List<Form>();

        
        private void OpenForm(string name)
        {
            if (!FormsByName.ContainsKey(name))
                return;
            var formType = FormsByName[name];
            var form = Forms.FirstOrDefault(x => x.GetType() == formType); 

            if (form is null)
            {
                form = formType.GetConstructor(Array.Empty<Type>()).Invoke(Array.Empty<object>()) as Form;
                Forms.Add(form);
            }
        
            form.ShowDialog(); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm("BrandName");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm("Cashier");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm("Product");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm("Discount");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm("ProductReceipts");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm("ProductSale");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm("ProductsDetails");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenForm("CashierReport");
        }

        private void button9_Click(object sender, EventArgs e)
        {
           //penForm("CashierRecepy");
        }
    }
}
