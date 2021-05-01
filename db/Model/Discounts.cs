using System;
using System.Collections.Generic;
using System.Text;

namespace db.DbModel
{
    public class Discounts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Amount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
