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
    public partial class BrandControl : UserControl
    {
        private int brandId = 0; 
        public BrandControl()
        {
            InitializeComponent();
        }   
        public BrandControl(BrandName brandName)
        {
            InitializeComponent();
            BrandName = brandName; 
        }

        public BrandName BrandName 
        {
            get => new()
            {
                Id = brandId,
                Name = nameTB.Text ?? string.Empty
            };
            set
            {
                brandId = value?.Id ?? 0;
                nameTB.Text = value?.Name ?? string.Empty; 
            }
        }
    }
}
