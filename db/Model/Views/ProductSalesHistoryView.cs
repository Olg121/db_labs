using db.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Model.Views
{
    public class ProductSalesHistoryView : ProductSalesHistory
    {
        public Product Product { get; set; }
        public Cashier Cashier { get; set; }
        public string ProductName { get => Product?.Name ?? string.Empty; }
        public string CashierFullName { get 
            {
                return string.Format("{1} {0} {2}",
                    Cashier?.Surname ?? string.Empty,
                    Cashier?.FirstName ?? string.Empty,
                    Cashier?.MiddleName ?? string.Empty
                    ).Trim();
            }
        }
    }
}
