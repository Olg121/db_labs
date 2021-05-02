using db.DbModel;
using db.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Controls.DataGrids
{
    public partial class CashierGrid : UserControl
    {
        public CashierGrid()
        {
            InitializeComponent();
            
        //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
     
        }

        public EventHandler SelectionChanged { get; set; }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChanged?.Invoke(GetSelectedCashier(), new EventArgs() { });
        }

        private List<Cashier> CashiersObservable { get; set; } = new();
        
       //ublic Cashier SelectedCashier => dataGridView1.SelectedColumns.
        public List<Cashier> Cashiers 
        { 
            get => CashiersObservable.ToList();
            set 
            {
                dataGridView1.ClearSelection();
                GridViewHelper.UpdateGrid(dataGridView1, value);
                CashiersObservable = value;                          
            } 
        }

        public Cashier GetSelectedCashier()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedCol = dataGridView1.SelectedRows?[0];
                var data = selectedCol?.Cells?["Id"]?.Value;
                return CashiersObservable.FirstOrDefault(x => x.Id == ((data as int?) ?? -1));
            }
            return null;
        }

        private void CashierGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CashiersObservable;
        }
    }
}
