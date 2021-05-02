using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace db.DbModel
{
    [Table(Name = "Product")]
    public class Product
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public int BrandId { get; set; }
        [Column]
        public double Price { get; set; }
    }
}
