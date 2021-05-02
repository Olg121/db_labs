using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace db.DbModel
{
    [Table(Name = "ProductSalesHistory")]
    public class ProductSalesHistory
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public long Id { get; set; }
        [Column]
        public int ProductId { get; set; }
        [Column]
        public int CashierId { get; set; }
        [Column]
        public double ResultPrice { get; set; }
        [Column]
        public DateTime SaleDate { get; set; }
    }
}
