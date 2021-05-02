using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace db.DbModel
{
    [Table(Name = "ProductReceiptsHistory")]
    public class ProductReceiptsHistory
    {    
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public long Id { get; set; }
        [Column]
        public int ProductId { get; set; }
        [Column]
        public int CountOfReceipts { get; set; }
    }
}
