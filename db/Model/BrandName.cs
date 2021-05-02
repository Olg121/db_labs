using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq.Mapping;


namespace db.DbModel
{      
    [Table(Name ="BrandName")]
    public class BrandName
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
    }
}
