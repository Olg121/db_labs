using System;
using System.Collections.Generic;
using System.Text;

namespace db.DbModel
{
    public class ProductReceiptsHistory
    {
        public long Id { get; set; }
        public int ProductId { get; set; }
        public int CountOfReceipts { get; set; }
    }
}
