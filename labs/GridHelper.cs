using labs.InternetShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs
{
    public static class GridHelper
    {
         public static void Save(BindingSource source, TableAdapterManager tableAdapterManager, InternetShopDataSet dataSet)
        {
            source.EndEdit();
            tableAdapterManager.UpdateAll(dataSet);
        }


        public static void MoveNext(BindingSource source)
        {
            source.MoveNext(); 
        }

        public static void MovePrew(BindingSource source)
        {
            source.MovePrevious();
        }

        public static void MoveFirst(BindingSource source)
        {
            source.MoveFirst();
        }

        public static void MoveLast(BindingSource source)
        {
            source.MoveLast();
        }

        public static void AddNewItem(BindingSource source)
        {
            source.AddNew();
          //  source.AddNew();
        }
        public static void RemoveCurrent(BindingSource source)
        {
            var cur = source.Current;
            source.Remove(cur);
        }

        public static void UndoChanges(InternetShopDataSet dataSet)
        {
            dataSet.RejectChanges();
           // source.ResetBindings(false); 
        }



    }
}
