using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.DbContext
{
    public class ProceduresContext : DataContext
    {
        public ProceduresContext(string connectionString) : base(connectionString)
        {

        }

        public void DeleteProductHistoryRecord(int id)
        {
            ExecuteCommand("delete from ProductSalesHistory where id = {0}", id);
        }

        [Function(Name = "TryToSaleProduct")]
        [return: Parameter(DbType = "Int")]
        public int TryToSaleProduct
            (
            [Parameter(DbType = "Int", Name = "cashierId")] int cashierId,
            [Parameter(DbType = "Int", Name = "productId")] int productId,
            [Parameter(DbType = "Int", Name = "productsCount")] int productsCount,
            [Parameter(DbType = "Int", Name = "id")] ref int id
            )
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cashierId, productId, productsCount, id);
            id = ((int)(result.GetParameterValue(1)));
            return ((int)(result.ReturnValue));
        }


    }
}
