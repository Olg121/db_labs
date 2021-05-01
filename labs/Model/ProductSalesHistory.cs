using System;
using System.Collections.Generic;
using System.Text;

namespace db.DbModel
{
    public class ProductSalesHistory
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public int CashierId { get; set; }
        public double ResultPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
