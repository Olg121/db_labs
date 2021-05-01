using System;
using System.Collections.Generic;
using System.Text;

namespace db.DbModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public double Price { get; set; }
    }
}
