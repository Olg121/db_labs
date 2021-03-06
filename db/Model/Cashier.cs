using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace db.DbModel
{
    [Table(Name = "Cashier")]
    public class Cashier
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }   
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string Surname { get; set; }
        [Column]
        public string MiddleName { get; set; }
    }
}
