using db.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Model.Views
{
    class DiscountView : Discounts
    {
        public string ProductName { get => Product?.Name ?? string.Empty; }
        public Product Product { get; set; }
    }
}
