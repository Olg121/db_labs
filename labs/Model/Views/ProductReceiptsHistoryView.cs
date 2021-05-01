using db.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Model.Views
{
    public class ProductReceiptsHistoryView : ProductReceiptsHistory
    {
        public Product Product { get; set; }
        public string ProductName { get => Product?.Name ?? string.Empty;  }
    }
}
