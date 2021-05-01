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

namespace db.Controls
{
    public partial class ProductControl : UserControl
    {
        private int _id = 0;
        public List<BrandName> Brands { get; set; }
        
        private Product Product 
        { 
            get => new() 
        {
            Id = _id ,
            BrandId = Brands?.FirstOrDefault(x => x.Name == brandCB.Text)?.Id ?? 0, 
            Name = nameTB.Text, 
            Price = int.TryParse(priceTB.Text, out _) ? int.Parse(priceTB.Text) : 0, 
        };
            set
            {
                _id = value.Id;
                brandCB.SelectedIndex = Brands.Any(x => x.Id == value.BrandId) ?
                Brands.IndexOf(Brands.FirstOrDefault(x => x.Id == value.BrandId)) : -1;
                priceTB.Text = value.Price.ToString();
            }
        }

        public ProductControl()
        {
            InitializeComponent();
        }
    }
}
