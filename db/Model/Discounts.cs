using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace db.DbModel
{
    [Table(Name = "Discounts")]
    public class Discounts
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int ProductId { get; set; }
        [Column]
        public float Amount { get; set; }
        [Column]
        public DateTime DateFrom { get; set; }
        [Column]
        public DateTime DateTo { get; set; }
    }
}
