using db.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Lab2
{
    public partial class CashierControlLab2 : UserControl
    {
        public CashierControlLab2()
        {
            InitializeComponent();
            UpdateCashiers();
        }

        private void AddCashierBtn_Click(object sender, EventArgs e)
        {
            var lastId = SQLCommandImplementations.AddNewCashier(cashierControl.Cashier);
            lastIdValueLbl.Text = lastId.ToString(); 
            UpdateCashiers();
        }

        private void UpdateLstBtn_Click(object sender, EventArgs e)
        {
            UpdateCashiers();
        }

        private void UpdateCashiers()
        {
            var cashiers = SQLCommandImplementations.GetCashiers();
            cashierGrid.DataSource = cashiers;
            cashierGrid.Update();
            cashierGrid.Refresh();
            countValueLbl.Text = SQLCommandImplementations.GetRecordsCount().ToString();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            UpdateCashiers();
        }

     
    }
}
