using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Context
{
    public class ContextBase
    {
        protected static string ConnectionString { get; set; } = @"Data Source=KOPUHTER\swpdm;Initial Catalog=InternetShop;Integrated Security=True";
    }
}
