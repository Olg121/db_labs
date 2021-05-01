using db.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Model.Views
{
    public class ProductView : Product
    {
        public BrandName Brand { get; set; }
        public string BrandName { get => Brand?.Name ?? string.Empty; }
    }
}
